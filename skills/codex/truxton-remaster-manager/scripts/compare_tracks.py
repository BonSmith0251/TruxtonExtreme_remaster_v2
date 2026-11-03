"""Compare an original-game track with a remaster capture (both truxton-track/1).

  compare_tracks.py observation.original.json capture.remaster.json [--out comparison.json]
                    [--tolerances tol.json] [--align spawn|absolute]

Exit code 0 = pass, 1 = fail, 2 = inconclusive.
"""
import argparse
import bisect
import json
import math
import sys
from pathlib import Path

DEFAULT_TOLERANCES = {
    "spawn": 0.05,        # seconds
    "despawn": 0.25,      # seconds
    "rms": 1.5,           # source units
    "max": 3.0,           # source units
    "end": 3.0,           # source units
    "angle": 5.0,         # degrees, max yaw/roll error
    "event": 0.1,         # seconds
    "matchWindow": 1.0,   # seconds, for spawn-time matching without keys
    "minOverlap": 0.1,    # seconds of common lifetime
    "edge": 0.25,         # seconds; events this close to an early (killed) end are not compared
}
STEP = 1 / 60
ANGLES = ("yaw", "roll")


def load(path):
    track = json.loads(Path(path).read_text(encoding="utf-8"))
    if track.get("schema") != "truxton-track/1":
        raise ValueError(f"{path}: schema is {track.get('schema')!r}, expected truxton-track/1")
    for instance in track.get("instances", []):
        instance["samples"] = sorted(instance.get("samples", []), key=lambda s: s["t"])
    return track


def match_instances(original, remaster, window):
    pairs, left, right = [], list(original), list(remaster)
    keyed = {i["key"]: i for i in right if i.get("key")}
    for instance in list(left):
        other = keyed.get(instance.get("key")) if instance.get("key") else None
        if other is not None and other in right:
            pairs.append((instance, other, "key"))
            left.remove(instance)
            right.remove(other)
    # Formations spawn several instances on one frame, so break spawn-time ties by spawn position:
    # 1000 source units cost as much as half a second of spawn delay (34 units is about one frame).
    def start(i):
        first = i["samples"][0] if i.get("samples") else None
        return (first["x"], first["z"]) if first else None
    def cost(a, b):
        pa, pb = start(a), start(b)
        apart = ((pa[0] - pb[0]) ** 2 + (pa[1] - pb[1]) ** 2) ** .5 if pa and pb else 0
        return abs(a["spawn"] - b["spawn"]) + apart / 2000
    candidates = sorted(((cost(a, b), abs(a["spawn"] - b["spawn"]), id(a), id(b), a, b) for a in left for b in right),
                        key=lambda c: c[0])
    used = set()
    for _, delta, ida, idb, a, b in candidates:
        if delta > window or ida in used or idb in used:
            continue
        used.update((ida, idb))
        pairs.append((a, b, "spawn"))
    left = [a for a in left if id(a) not in used]
    right = [b for b in right if id(b) not in used]
    return pairs, left, right


def interpolate(samples, times, field, t):
    index = bisect.bisect_left(times, t)
    if index <= 0:
        return samples[0].get(field)
    if index >= len(samples):
        return samples[-1].get(field)
    a, b = samples[index - 1], samples[index]
    if a.get(field) is None or b.get(field) is None:
        return None
    span = b["t"] - a["t"]
    f = 0 if span <= 0 else (t - a["t"]) / span
    if field in ANGLES:
        return a[field] + angle_diff(b[field], a[field]) * f
    return a[field] + (b[field] - a[field]) * f


def angle_diff(a, b):
    return (a - b + 180) % 360 - 180


def ended_early(instance):
    return instance.get("despawnReason") == "killed"


def compare_events(original, remaster, offset_a, offset_b, limit, tolerance, window):
    """Greedy nearest-time pairing per (type, muzzle); events after `limit` (relative) are ignored."""
    def relative(events, offset):
        # A kill is compared through despawnReason, not as an event.
        return [dict(e, rt=e["t"] - offset) for e in events
                if e["type"] != "killed" and (limit is None or e["t"] - offset <= limit)]

    a_events, b_events = relative(original, offset_a), relative(remaster, offset_b)
    matched, over = [], []
    groups = {}
    for side, events in (("a", a_events), ("b", b_events)):
        for event in events:
            groups.setdefault((event["type"], event.get("muzzle")), {"a": [], "b": []})[side].append(event)
    missing, extra = [], []
    for (kind, muzzle), sides in sorted(groups.items(), key=lambda g: (g[0][0], str(g[0][1]))):
        free = list(sides["b"])
        for event in sorted(sides["a"], key=lambda e: e["rt"]):
            best = min(free, key=lambda e: abs(e["rt"] - event["rt"]), default=None)
            if best is None or abs(best["rt"] - event["rt"]) > window:
                missing.append({"type": kind, "muzzle": muzzle, "t": event["t"]})
                continue
            free.remove(best)
            dt = best["rt"] - event["rt"]
            matched.append({"type": kind, "muzzle": muzzle, "t": event["t"], "dt": round(dt, 4)})
            if abs(dt) > tolerance:
                over.append(f"{kind}{'/' + muzzle if muzzle else ''} at {event['t']:.2f}s off by {dt:+.3f}s")
        extra.extend({"type": kind, "muzzle": muzzle, "t": e["t"]} for e in free)
    return {"matched": matched, "missing": missing, "extra": extra}, over


def compare_pair(a, b, how, tol, align):
    result = {"original": a.get("key") or a["spawn"], "remaster": b.get("key") or b["spawn"], "matchedBy": how}
    problems = []
    result["spawnDelta"] = round(b["spawn"] - a["spawn"], 4)
    if abs(result["spawnDelta"]) > tol["spawn"]:
        problems.append(f"spawn off by {result['spawnDelta']:+.3f}s")
    if a.get("despawn") is not None and b.get("despawn") is not None and not (ended_early(a) or ended_early(b)):
        result["despawnDelta"] = round((b["despawn"] - b["spawn"]) - (a["despawn"] - a["spawn"]), 4)
        if abs(result["despawnDelta"]) > tol["despawn"]:
            problems.append(f"lifetime off by {result['despawnDelta']:+.3f}s")

    offset_a, offset_b = (a["spawn"], b["spawn"]) if align == "spawn" else (0.0, 0.0)
    sa, sb = a["samples"], b["samples"]
    if not sa or not sb:
        return result, problems, "no samples"
    start = max(sa[0]["t"] - offset_a, sb[0]["t"] - offset_b)
    end = min(sa[-1]["t"] - offset_a, sb[-1]["t"] - offset_b)
    result["overlap"] = round(end - start, 4)
    if end - start < tol["minOverlap"]:
        return result, problems, f"overlap {end - start:.3f}s"

    ta, tb = [s["t"] for s in sa], [s["t"] for s in sb]
    squares, worst, worst_at = 0.0, 0.0, start
    angle_worst = {}
    steps = int((end - start) / STEP) + 1
    for i in range(steps):
        t = start + i * STEP
        ax, az = interpolate(sa, ta, "x", t + offset_a), interpolate(sa, ta, "z", t + offset_a)
        bx, bz = interpolate(sb, tb, "x", t + offset_b), interpolate(sb, tb, "z", t + offset_b)
        distance = math.hypot(bx - ax, bz - az)
        squares += distance * distance
        if distance > worst:
            worst, worst_at = distance, t
        for field in ANGLES:
            va, vb = interpolate(sa, ta, field, t + offset_a), interpolate(sb, tb, field, t + offset_b)
            if va is not None and vb is not None:
                angle_worst[field] = max(angle_worst.get(field, 0.0), abs(angle_diff(vb, va)))
    result["rms"] = round(math.sqrt(squares / steps), 4)
    result["max"] = round(worst, 4)
    result["maxAt"] = round(worst_at + offset_a, 4)
    if result["rms"] > tol["rms"]:
        problems.append(f"path RMS {result['rms']:.2f} > {tol['rms']}")
    if result["max"] > tol["max"]:
        problems.append(f"path max {result['max']:.2f} at {result['maxAt']:.2f}s > {tol['max']}")
    if not (ended_early(a) or ended_early(b)):
        result["endError"] = round(math.hypot(sb[-1]["x"] - sa[-1]["x"], sb[-1]["z"] - sa[-1]["z"]), 4)
        if result["endError"] > tol["end"]:
            problems.append(f"end point off by {result['endError']:.2f}")
    for field, value in angle_worst.items():
        result[field + "Max"] = round(value, 3)
        if value > tol["angle"]:
            problems.append(f"{field} off by up to {value:.1f} deg")

    # After an early kill, an event in progress (e.g. a stop) can't be seen whole on that side.
    limit = end - tol["edge"] if (ended_early(a) or ended_early(b)) else None
    events, over = compare_events(a.get("events", []), b.get("events", []), offset_a, offset_b, limit,
                                  tol["event"], tol["matchWindow"])
    result["events"] = events
    problems.extend(over)
    problems.extend(f"missing {e['type']} at {e['t']:.2f}s" for e in events["missing"])
    problems.extend(f"extra {e['type']} at {e['t']:.2f}s" for e in events["extra"])
    return result, problems, None


def compare(original, remaster, tol, align):
    report = {"schema": "truxton-comparison/1", "subject": original.get("subject", {}).get("id"),
              "align": align, "tolerances": tol, "reasons": [], "instances": []}
    for field in ("frame", "timeBase"):
        if original.get(field) != remaster.get(field):
            report["reasons"].append(f"{field} differs: {original.get(field)!r} vs {remaster.get(field)!r}")
    if original.get("subject", {}).get("id") != remaster.get("subject", {}).get("id"):
        report["reasons"].append("subject ids differ")
    if report["reasons"]:
        report["verdict"] = "inconclusive"
        return report

    pairs, missing, extra = match_instances(original["instances"], remaster["instances"], tol["matchWindow"])
    failures, inconclusive = [], []
    for a, b, how in sorted(pairs, key=lambda p: p[0]["spawn"]):
        result, problems, unusable = compare_pair(a, b, how, tol, align)
        result["problems"] = problems
        if unusable:
            result["inconclusive"] = unusable
            inconclusive.append(f"{result['original']}: {unusable}")
        failures.extend(f"{result['original']}: {p}" for p in problems)
        report["instances"].append(result)
    failures.extend(f"missing in remaster: {i.get('key') or i['spawn']}" for i in missing)
    failures.extend(f"extra in remaster: {i.get('key') or i['spawn']}" for i in extra)
    report["summary"] = {"original": len(original["instances"]), "remaster": len(remaster["instances"]),
                         "matched": len(pairs), "missing": len(missing), "extra": len(extra)}
    if not pairs:
        report["verdict"], report["reasons"] = "inconclusive", ["no instances matched"] + failures
    elif failures:
        report["verdict"], report["reasons"] = "fail", failures + inconclusive
    elif inconclusive:
        report["verdict"], report["reasons"] = "inconclusive", inconclusive
    else:
        report["verdict"] = "pass"
    return report


def main():
    parser = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    parser.add_argument("original")
    parser.add_argument("remaster")
    parser.add_argument("--out")
    parser.add_argument("--tolerances", help="JSON file overriding any default tolerance")
    parser.add_argument("--align", choices=["spawn", "absolute"], default="spawn",
                        help="compare paths from each instance's own spawn (default) or at the same stage time")
    args = parser.parse_args()
    tol = dict(DEFAULT_TOLERANCES)
    if args.tolerances:
        tol.update(json.loads(Path(args.tolerances).read_text(encoding="utf-8")))
    report = compare(load(args.original), load(args.remaster), tol, args.align)
    report["files"] = {"original": str(args.original), "remaster": str(args.remaster)}
    if args.out:
        Path(args.out).write_text(json.dumps(report, indent=2) + "\n", encoding="utf-8")
    summary = report.get("summary", {})
    print(f"verdict: {report['verdict']}  matched {summary.get('matched', 0)}/{summary.get('original', 0)}"
          f"  missing {summary.get('missing', 0)}  extra {summary.get('extra', 0)}")
    for reason in report["reasons"][:10]:
        print("  -", reason)
    if len(report["reasons"]) > 10:
        print(f"  ... {len(report['reasons']) - 10} more in the report")
    sys.exit({"pass": 0, "fail": 1}.get(report["verdict"], 2))


if __name__ == "__main__":
    main()
