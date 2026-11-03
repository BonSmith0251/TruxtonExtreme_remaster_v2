"""Stage 1: survey a game folder.

Detects engine / Unity version / scripting backend, classifies every file by
content (not extension), flags encrypted or unknown blobs, and writes
<out>/survey.json and <out>/survey.md.

usage: python survey.py <game_dir> <out_dir>
"""
from __future__ import annotations

import argparse
import json
import re
import struct
import sys
from collections import Counter, defaultdict
from pathlib import Path

sys.path.insert(0, str(Path(__file__).parent))
from ugp_common import entropy, find_data_dir, log, sniff, write_json  # noqa: E402

OTHER_ENGINES = [
    ("Unreal Engine", lambda g: any(g.rglob("*.pak")) or any(g.rglob("*.uasset"))),
    ("Godot", lambda g: any(g.glob("*.pck"))),
    ("GameMaker", lambda g: (g / "data.win").exists()),
    ("Ren'Py", lambda g: (g / "renpy").is_dir()),
    ("RPG Maker MV/MZ", lambda g: (g / "www").is_dir() or (g / "js" / "rpg_core.js").exists()),
]


def unity_version_from(data_dir: Path) -> str | None:
    for name in ("globalgamemanagers", "data.unity3d", "mainData", "level0"):
        p = data_dir / name
        if not p.exists():
            continue
        with open(p, "rb") as f:
            head = f.read(256)
        m = re.search(rb"(\d{1,4}\.\d+\.\d+[abfpx]\d+)", head)
        if m:
            return m.group(1).decode()
    return None


def scripting_backend(game_dir: Path, data_dir: Path) -> dict:
    if (game_dir / "GameAssembly.dll").exists() or any(game_dir.glob("GameAssembly.*")):
        meta = data_dir / "il2cpp_data" / "Metadata" / "global-metadata.dat"
        info = {"backend": "IL2CPP", "metadata": str(meta) if meta.exists() else None}
        if meta.exists():
            with open(meta, "rb") as f:
                sanity, version = struct.unpack("<Ii", f.read(8))
            info["metadata_magic_ok"] = sanity == 0xFAB11BAF
            info["metadata_version"] = version
            if sanity != 0xFAB11BAF:
                info["note"] = "global-metadata.dat magic mismatch: metadata is encrypted/obfuscated"
        return info
    managed = data_dir / "Managed"
    if managed.is_dir():
        dlls = sorted(p.name for p in managed.glob("*.dll"))
        game_dlls = [d for d in dlls if not re.match(r"^(UnityEngine|Unity\.|System|mscorlib|netstandard|Mono\.|Microsoft\.)", d)]
        return {"backend": "Mono", "managed_dir": str(managed), "game_assemblies": game_dlls, "all_assemblies": dlls}
    return {"backend": "unknown"}


def survey(game_dir: Path) -> dict:
    game_dir = game_dir.resolve()
    result: dict = {"game_dir": str(game_dir), "engine": None}
    data_dir = find_data_dir(game_dir)
    if data_dir is None:
        for name, test in OTHER_ENGINES:
            try:
                if test(game_dir):
                    result["engine"] = name
                    break
            except OSError:
                pass
        result["engine"] = result["engine"] or "unknown"
        result["note"] = "Not a Unity player build; only generic file inventory is available."
    else:
        result["engine"] = "Unity"
        result["data_dir"] = str(data_dir)
        result["product_name"] = data_dir.name[: -len("_Data")]
        result["unity_version"] = unity_version_from(data_dir)
        result["scripting"] = scripting_backend(game_dir, data_dir)
        app_info = data_dir / "app.info"
        if app_info.exists():
            lines = app_info.read_text(encoding="utf-8", errors="replace").splitlines()
            result["company"], result["product"] = (lines + ["", ""])[:2]
        aa = data_dir / "StreamingAssets" / "aa"
        if aa.is_dir():
            result["addressables"] = {
                "root": str(aa),
                "catalogs": [str(p) for p in aa.glob("catalog*")],
                "settings": str(aa / "settings.json") if (aa / "settings.json").exists() else None,
            }

    files = []
    kinds = Counter()
    sizes = defaultdict(int)
    for p in sorted(game_dir.rglob("*")):
        if not p.is_file():
            continue
        size = p.stat().st_size
        with open(p, "rb") as f:
            head = f.read(4096)
        kind = sniff(p, head[:64])
        entry = {"path": str(p.relative_to(game_dir)).replace("\\", "/"), "size": size, "kind": kind}
        if kind == "unknown" and size > 64:
            e = entropy(head)
            entry["entropy"] = round(e, 3)
            idx = head.find(b"UnityFS\x00")
            if idx > 0:
                entry["kind"] = kind = "unity_bundle_prefixed"
                entry["bundle_offset"] = idx
            elif e > 7.2:
                entry["kind"] = kind = "encrypted_or_compressed"
        kinds[kind] += 1
        sizes[kind] += size
        files.append(entry)
    result["files"] = files
    result["summary"] = {k: {"count": kinds[k], "bytes": sizes[k]} for k in sorted(kinds)}
    result["needs_decryption"] = [f["path"] for f in files if f["kind"] in ("unity_bundle_prefixed", "encrypted_or_compressed")]
    return result


def to_markdown(s: dict) -> str:
    out = [f"# Survey: {s.get('product_name') or Path(s['game_dir']).name}", ""]
    out.append(f"- Engine: **{s['engine']}**")
    if s["engine"] == "Unity":
        sc = s.get("scripting", {})
        out.append(f"- Unity version: **{s.get('unity_version')}**")
        out.append(f"- Scripting backend: **{sc.get('backend')}**")
        if sc.get("backend") == "Mono":
            out.append(f"- Game assemblies: {', '.join(sc.get('game_assemblies', []))}")
        if sc.get("backend") == "IL2CPP":
            out.append(f"- global-metadata.dat version {sc.get('metadata_version')} (magic ok: {sc.get('metadata_magic_ok')})")
        if s.get("addressables"):
            out.append(f"- Addressables catalogs: {len(s['addressables']['catalogs'])}")
    out += ["", "## File kinds", "", "| kind | count | MB |", "|---|---:|---:|"]
    for k, v in s["summary"].items():
        out.append(f"| {k} | {v['count']} | {v['bytes'] / 1e6:.1f} |")
    if s["needs_decryption"]:
        out += ["", f"## Needs decryption ({len(s['needs_decryption'])})", ""]
        out += [f"- `{p}`" for p in s["needs_decryption"][:50]]
        if len(s["needs_decryption"]) > 50:
            out.append(f"- ... and {len(s['needs_decryption']) - 50} more")
    return "\n".join(out) + "\n"


def main():
    ap = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    ap.add_argument("game_dir", type=Path)
    ap.add_argument("out_dir", type=Path)
    a = ap.parse_args()
    s = survey(a.game_dir)
    write_json(a.out_dir / "survey.json", s)
    (a.out_dir / "survey.md").write_text(to_markdown(s), encoding="utf-8")
    log(f"engine={s['engine']} unity={s.get('unity_version')} backend={s.get('scripting', {}).get('backend')}")
    log(json.dumps(s["summary"]))
    if s["needs_decryption"]:
        log(f"{len(s['needs_decryption'])} file(s) need decryption -> run decrypt.py")


if __name__ == "__main__":
    main()
