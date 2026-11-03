"""Shared helpers for the unity-game-to-project pipeline."""
from __future__ import annotations

import json
import math
import os
import re
import struct
import sys
from collections import Counter
from pathlib import Path

# ---------------------------------------------------------------- logging

def log(*args):
    print("[ugp]", *args, flush=True)


def write_json(path, data):
    path = Path(path)
    path.parent.mkdir(parents=True, exist_ok=True)
    with open(path, "w", encoding="utf-8") as f:
        json.dump(data, f, indent=1, ensure_ascii=False, default=_json_default)


def read_json(path):
    with open(path, encoding="utf-8") as f:
        return json.load(f)


def _json_default(o):
    if isinstance(o, (bytes, bytearray)):
        return {"$bytes": len(o)}
    if hasattr(o, "__dict__"):
        return {k: v for k, v in o.__dict__.items() if not k.startswith("_")}
    return str(o)


# ---------------------------------------------------------------- file sniffing

MAGICS = [
    (b"UnityFS\x00", "unity_bundle"),
    (b"UnityWeb\x00", "unity_bundle_legacy"),
    (b"UnityRaw\x00", "unity_bundle_legacy"),
    (b"UnityArchive", "unity_bundle_legacy"),
    (b"\x89PNG\r\n\x1a\n", "png"),
    (b"\xff\xd8\xff", "jpg"),
    (b"OggS", "ogg"),
    (b"RIFF", "riff"),
    (b"FSB5", "fsb5"),
    (b"MZ", "pe"),
    (b"\x1aE\xdf\xa3", "webm_mkv"),
    (b"PK\x03\x04", "zip"),
    (b"\x1f\x8b", "gzip"),
    (b"BKHD", "wwise_bank"),
    (b"AKPK", "wwise_pack"),
    (b"CRID", "cri_usm"),
    (b"AFS2", "cri_awb"),
    (b"@UTF", "cri_acb"),
]


def sniff(path: Path, head: bytes | None = None) -> str:
    if head is None:
        with open(path, "rb") as f:
            head = f.read(64)
    for magic, kind in MAGICS:
        if head.startswith(magic):
            return kind
    if len(head) >= 12 and head[4:8] == b"ftyp":
        return "mp4"
    if is_serialized_file(head, path.stat().st_size):
        return "unity_serialized"
    name = path.name.lower()
    if name.endswith(".ress") or name.endswith(".resource"):
        return "unity_resource_stream"
    if name.endswith((".json", ".txt", ".xml", ".config", ".info", ".md", ".ini", ".csv")):
        return "text"
    try:
        head.decode("utf-8")
        if all(32 <= b < 127 or b in (9, 10, 13) for b in head[:48]) and head:
            return "text"
    except UnicodeDecodeError:
        pass
    return "unknown"


def is_serialized_file(head: bytes, size: int) -> bool:
    """Heuristic check for a Unity SerializedFile header (big endian)."""
    if len(head) < 20:
        return False
    metadata_size, file_size, version, data_offset = struct.unpack(">IIII", head[:16])
    if 9 <= version <= 50 and version < 22 and 0 < file_size <= size + 16 and data_offset <= size:
        return True
    if version >= 22 and len(head) >= 48:
        # v22+: header fields are 0 and real values follow at offset 20
        md, fsz, doff = struct.unpack(">IQQ", head[20:40])
        return fsz == size and doff <= size
    return False


def entropy(data: bytes) -> float:
    if not data:
        return 0.0
    c = Counter(data)
    n = len(data)
    return -sum(v / n * math.log2(v / n) for v in c.values())


# ---------------------------------------------------------------- unity layout

def find_data_dir(game_dir: Path) -> Path | None:
    for p in sorted(game_dir.iterdir()):
        if p.is_dir() and p.name.endswith("_Data") and (
            (p / "globalgamemanagers").exists() or (p / "data.unity3d").exists() or (p / "mainData").exists()
        ):
            return p
    return None


def norm_file_key(name: str) -> str:
    """Canonical name for a serialized file, used to build stable object keys."""
    n = name.replace("\\", "/")
    if n.startswith("archive:/"):
        n = n.split("/")[-1]
    n = n.split("/")[-1]
    return n.lower()


def obj_key(file_name: str, path_id: int) -> str:
    return f"{norm_file_key(file_name)}:{path_id}"


def safe_name(name: str, fallback: str = "unnamed") -> str:
    name = re.sub(r'[<>:"/\\|?*\x00-\x1f]', "_", name or "").strip(" .")
    return name[:120] or fallback


def ensure_unityPy():
    try:
        import UnityPy  # noqa: F401
    except ImportError:
        sys.exit("UnityPy is not installed. Run: python -m pip install -r requirements.txt")


# ---------------------------------------------------------------- UnityPy environment

def make_typetree_generator(game_dir: Path, unity_version: str):
    """TypeTreeGenerator for script (MonoBehaviour) data in player builds without type trees.

    Works for Mono (Managed/*.dll) and IL2CPP (GameAssembly.dll + global-metadata.dat).
    Patches the generated MonoBehaviour header: TypeTreeGeneratorAPI omits the
    4-byte alignment flag on m_Enabled, which shifts every following field.
    IL2CPP loading needs capstone.dll, which ships beside TypeTreeGeneratorAPI.dll but
    is not on the DLL search path; preload it. The AssetsTools backend registers IL2CPP
    assemblies without the ".dll" suffix that UnityPy always appends, so try both forms.
    """
    try:
        import ctypes
        import os
        import TypeTreeGeneratorAPI
        cap = Path(TypeTreeGeneratorAPI.__file__).parent / "capstone.dll"
        if os.name == "nt" and cap.exists():
            ctypes.WinDLL(str(cap))
        from UnityPy.helpers.TypeTreeGenerator import TypeTreeGenerator
    except ImportError:
        return None

    class PatchedGenerator(TypeTreeGenerator):
        _names = None

        def get_nodes(self, assembly, fullname):
            if self._names is None:
                self._names = set(self.get_loaded_dll_names())
            if assembly not in self._names:
                alt = assembly[:-4] if assembly.endswith(".dll") else assembly + ".dll"
                if alt in self._names:
                    assembly = alt
            nodes = super().get_nodes(assembly, fullname)
            for n in nodes:
                if n.m_Level == 1 and n.m_Name == "m_Enabled":
                    n.m_MetaFlag = (n.m_MetaFlag or 0) | 0x4000
            return nodes

    try:
        gen = PatchedGenerator(unity_version)
        gen.load_local_game(str(game_dir))
        return gen
    except Exception as e:  # missing native lib, unsupported metadata, ...
        log("typetree generator unavailable:", e)
        return None
