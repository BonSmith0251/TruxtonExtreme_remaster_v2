"""Stage 2: recover readable Unity bundles from obfuscated/encrypted files.

Strategies, tried in order for every file the survey flagged:
  1. carve      - a plain UnityFS bundle hidden behind a junk prefix (or several
                  concatenated bundles); the header's size field gives exact bounds.
  2. xor        - repeating-key XOR (any key length up to ~24, any header offset),
                  recovered with a known-plaintext attack on the UnityFS header.
  3. plugins    - user-written decryptors: --plugin my_decrypt.py providing
                  `decrypt(path: Path, data: bytes) -> bytes | None`.  Write one
                  after locating the game's loader (see reference/decryption.md).
Every candidate is validated by parsing it with UnityPy before it is accepted.

usage: python decrypt.py <work_dir> [--plugin file.py ...] [--key HEX --offset N]
Outputs <work_dir>/decrypted/<relative path>.bundle and decrypt_report.json.
"""
from __future__ import annotations

import argparse
import importlib.util
import io
import struct
import sys
from pathlib import Path

sys.path.insert(0, str(Path(__file__).parent))
from ugp_common import ensure_unityPy, log, read_json, write_json  # noqa: E402

SIG = b"UnityFS\x00"


def bundle_header_size(buf: bytes, at: int = 0) -> int | None:
    """Total bundle size stored in a UnityFS header, or None if implausible."""
    try:
        p = at + len(SIG) + 4  # signature + format version
        for _ in range(2):  # "5.x.x\0" then engine revision "\0"-terminated
            end = buf.index(b"\x00", p, p + 64)
            p = end + 1
        (size,) = struct.unpack(">q", buf[p : p + 8])
        return size if 0 < size < 1 << 40 else None
    except (ValueError, struct.error):
        return None


def validate(data: bytes) -> bool:
    import UnityPy

    try:
        env = UnityPy.load(io.BytesIO(data))
        return len(env.files) > 0 and any(True for _ in env.objects)
    except Exception:
        return False


def try_carve(data: bytes) -> list[bytes]:
    out = []
    pos = data.find(SIG)
    while pos >= 0:
        size = bundle_header_size(data, pos)
        chunk = data[pos : pos + size] if size and pos + size <= len(data) else data[pos:]
        out.append(chunk)
        pos = data.find(SIG, pos + max(len(SIG), len(chunk)))
    return out


def known_plaintexts(unity_version: str | None) -> list[bytes]:
    pts = []
    for fmt in (8, 7, 6):
        for engine in ([unity_version] if unity_version else []) + [None]:
            pt = SIG + struct.pack(">I", fmt) + b"5.x.x\x00"
            if engine:
                pt += engine.encode() + b"\x00"
            pts.append(pt)
    return pts


def try_xor(data: bytes, unity_version: str | None, max_offset: int = 1024, max_key: int = 24):
    """Known-plaintext attack for repeating-key XOR. Returns (plain, offset, key) or None."""
    for pt in known_plaintexts(unity_version):
        n = len(pt)
        limit = min(max_offset, len(data) - n)
        for off in range(0, max(limit, 0) + 1):
            ks = bytes(data[off + i] ^ pt[i] for i in range(n))
            for klen in range(1, min(max_key, n - 4) + 1):
                if all(ks[i] == ks[i % klen] for i in range(klen, n)):
                    key = ks[:klen]
                    body = data[off:]
                    kk = (key * (len(body) // klen + 1))[: len(body)]
                    plain = bytes(a ^ b for a, b in zip(body, kk))
                    size = bundle_header_size(plain)
                    if size and size <= len(plain):
                        plain = plain[:size]
                    if validate(plain):
                        return plain, off, key
                    break  # shortest consistent period failed; longer ones are multiples
    return None


def xor_with(data: bytes, key: bytes, offset: int) -> bytes:
    body = data[offset:]
    kk = (key * (len(body) // len(key) + 1))[: len(body)]
    return bytes(a ^ b for a, b in zip(body, kk))


def encode(raw: bytes, transform: dict | None, original: bytes, source: Path) -> bytes | None:
    """Inverse of a recorded transform: re-obfuscate a rebuilt bundle so the game's loader accepts it."""
    if not transform:
        return raw
    t = transform["type"]
    if t == "xor":
        off = transform["offset"]
        return original[:off] + xor_with(raw, bytes.fromhex(transform["key"]), 0)
    if t == "carve":
        off, suf = transform["offset"], transform.get("suffix", 0)
        return original[:off] + raw + (original[len(original) - suf:] if suf else b"")
    if t == "plugin":
        spec = importlib.util.spec_from_file_location("ugp_plugin", transform["plugin"])
        mod = importlib.util.module_from_spec(spec)
        spec.loader.exec_module(mod)
        if hasattr(mod, "encrypt"):
            return mod.encrypt(source, raw)
    return None


def load_plugins(paths):
    funcs = []
    for p in paths or []:
        spec = importlib.util.spec_from_file_location(Path(p).stem, p)
        mod = importlib.util.module_from_spec(spec)
        spec.loader.exec_module(mod)
        funcs.append((Path(p).name, mod.decrypt))
    return funcs


def main():
    ap = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    ap.add_argument("work_dir", type=Path)
    ap.add_argument("--plugin", action="append", help="python file with decrypt(path, data)")
    ap.add_argument("--key", help="explicit XOR key (hex)")
    ap.add_argument("--offset", type=int, default=0, help="payload offset for --key")
    ap.add_argument("--all-unknown", action="store_true", help="also try files the survey classified as 'unknown'")
    a = ap.parse_args()
    ensure_unityPy()

    survey = read_json(a.work_dir / "survey.json")
    game_dir = Path(survey["game_dir"])
    version = survey.get("unity_version")
    targets = list(survey["needs_decryption"])
    if a.all_unknown:
        targets += [f["path"] for f in survey["files"] if f["kind"] == "unknown" and f["size"] > 256]
    plugins = load_plugins(a.plugin)
    out_dir = a.work_dir / "decrypted"
    report = {"ok": [], "failed": []}

    for rel in targets:
        data = (game_dir / rel).read_bytes()
        results, method, transform = [], None, None
        for name, fn in plugins:
            try:
                r = fn(game_dir / rel, data)
            except Exception as e:  # plugin bugs must not stop the run
                log(f"plugin {name} failed on {rel}: {e}")
                r = None
            if r and validate(r):
                results, method = [r], f"plugin:{name}"
                transform = {"type": "plugin", "plugin": str(Path(next(p for p in a.plugin if Path(p).name == name)).resolve())}
                break
        if not results and a.key:
            r = xor_with(data, bytes.fromhex(a.key), a.offset)
            if validate(r):
                results, method = [r], f"xor-key:{a.key}@{a.offset}"
                transform = {"type": "xor", "key": a.key, "offset": a.offset}
        if not results:
            carved = [c for c in try_carve(data) if validate(c)]
            if carved:
                results, method = carved, "carve"
                if len(carved) == 1:
                    start = data.find(carved[0][:64])
                    transform = {"type": "carve", "offset": start, "suffix": len(data) - start - len(carved[0])}
        if not results:
            r = try_xor(data, version)
            if r:
                plain, off, key = r
                results, method = [plain], f"xor key={key.hex()} ({key!r}) offset={off}"
                transform = {"type": "xor", "key": key.hex(), "offset": off}
        if results:
            for i, r in enumerate(results):
                dst = out_dir / (rel + (f".{i}" if len(results) > 1 else "") + ".bundle")
                dst.parent.mkdir(parents=True, exist_ok=True)
                dst.write_bytes(r)
                report["ok"].append({"source": rel, "output": str(dst), "method": method, "size": len(r),
                                     "transform": transform if len(results) == 1 else None})
            log(f"OK   {rel}: {method}")
        else:
            report["failed"].append({"source": rel, "size": len(data)})
            log(f"FAIL {rel}: no strategy worked (write a --plugin; see reference/decryption.md)")
    write_json(a.work_dir / "decrypt_report.json", report)
    log(f"decrypted {len(report['ok'])}, failed {len(report['failed'])}")


if __name__ == "__main__":
    main()
