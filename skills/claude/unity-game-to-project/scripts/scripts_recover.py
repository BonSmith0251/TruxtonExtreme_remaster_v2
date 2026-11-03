"""Stage 4: recover game scripts.

Two strategies (pick with --mode, default auto):
  plugin  (Mono builds) copy the game's own managed assemblies (Assembly-CSharp.dll and
          third-party dependencies) so the rebuilt project runs the ORIGINAL compiled
          code. Unity-/package-provided assemblies are left to the package manager.
  stubs   (IL2CPP builds, or Mono when you want editable source) generate C# classes
          whose serialized fields mirror the type trees, so every MonoBehaviour /
          ScriptableObject re-binds and keeps its data. Method bodies are NOT
          recoverable this way: IL2CPP compiles them to native code. Use Il2CppDumper
          / Cpp2IL (see reference/scripts.md) to study the logic and re-implement it.

Outputs <work>/scripts/{plugins,stubs}/ and scripts_report.json.
usage: python scripts_recover.py <work_dir> [--mode auto|plugin|stubs]
"""
from __future__ import annotations

import argparse
import keyword
import re
import shutil
import sys
from collections import Counter, defaultdict
from pathlib import Path

sys.path.insert(0, str(Path(__file__).parent))
from ugp_common import log, make_typetree_generator, read_json, write_json  # noqa: E402

UNITY_ASM = re.compile(r"^(UnityEngine|UnityEditor|Unity\.|System|mscorlib|netstandard|Mono\.|Microsoft\.|Purchasing\.Common|Newtonsoft\.Json)")

PRIMITIVES = {
    "int": "int", "SInt32": "int", "unsigned int": "uint", "UInt32": "uint", "float": "float", "double": "double",
    "bool": "bool", "string": "string", "SInt64": "long", "long long": "long", "UInt64": "ulong",
    "unsigned long long": "ulong", "SInt16": "short", "short": "short", "UInt16": "ushort", "unsigned short": "ushort",
    "SInt8": "sbyte", "UInt8": "bool", "char": "char", "FileSize": "long",
}
UNITY_VALUE_TYPES = {
    "Vector2": "Vector2", "Vector2f": "Vector2", "Vector3": "Vector3", "Vector3f": "Vector3", "Vector4": "Vector4",
    "Vector4f": "Vector4", "Vector2Int": "Vector2Int", "int2_storage": "Vector2Int", "Vector3Int": "Vector3Int",
    "int3_storage": "Vector3Int", "Quaternion": "Quaternion", "Quaternionf": "Quaternion", "Color": "Color",
    "ColorRGBA": "Color", "Color32": "Color32", "Rect": "Rect", "Rectf": "Rect", "RectInt": "RectInt",
    "Bounds": "Bounds", "AABB": "Bounds", "BoundsInt": "BoundsInt", "Matrix4x4": "Matrix4x4", "Matrix4x4f": "Matrix4x4",
    "AnimationCurve": "AnimationCurve", "Gradient": "Gradient", "LayerMask": "LayerMask", "BitField": "LayerMask",
    "Hash128": "Hash128", "RectOffset": "RectOffset", "GUIStyle": "GUIStyle",
}
# serializable engine/uGUI structs that flattened base classes (Selectable, ...) carry as fields;
# their layouts match the real types, so bind to them instead of re-declaring copies
ENGINE_SERIALIZABLE = {
    "Navigation": "UnityEngine.UI.Navigation", "ColorBlock": "UnityEngine.UI.ColorBlock",
    "SpriteState": "UnityEngine.UI.SpriteState", "AnimationTriggers": "UnityEngine.UI.AnimationTriggers",
}
# PPtr targets outside the UnityEngine namespace (type trees name them without a namespace)
ENGINE_OBJECT_NS = {
    "Tilemap": "UnityEngine.Tilemaps", "TilemapRenderer": "UnityEngine.Tilemaps", "TileBase": "UnityEngine.Tilemaps",
    "Tile": "UnityEngine.Tilemaps", "TilemapCollider2D": "UnityEngine.Tilemaps",
    "PlayableDirector": "UnityEngine.Playables", "PlayableAsset": "UnityEngine.Playables",
    "VideoClip": "UnityEngine.Video", "VideoPlayer": "UnityEngine.Video",
    "AudioMixer": "UnityEngine.Audio", "AudioMixerGroup": "UnityEngine.Audio", "AudioMixerSnapshot": "UnityEngine.Audio",
    "SpriteAtlas": "UnityEngine.U2D", "SortingGroup": "UnityEngine.Rendering", "NavMeshAgent": "UnityEngine.AI",
}
# engine/package classes a stub can derive from without implementing anything; deriving keeps the
# component working (a UIText : TextMeshProUGUI still renders) and type-compatible in fields
SAFE_BASES = {
    "UnityEngine.EventSystems.UIBehaviour", "UnityEngine.EventSystems.EventTrigger",
    "UnityEngine.UI.Graphic", "UnityEngine.UI.MaskableGraphic", "UnityEngine.UI.Image", "UnityEngine.UI.RawImage",
    "UnityEngine.UI.Text", "UnityEngine.UI.Selectable", "UnityEngine.UI.Button", "UnityEngine.UI.Toggle",
    "UnityEngine.UI.Slider", "UnityEngine.UI.Scrollbar", "UnityEngine.UI.ScrollRect", "UnityEngine.UI.Mask",
    "UnityEngine.UI.RectMask2D", "UnityEngine.UI.InputField", "UnityEngine.UI.Dropdown",
    "UnityEngine.UI.GridLayoutGroup", "UnityEngine.UI.HorizontalLayoutGroup", "UnityEngine.UI.VerticalLayoutGroup",
    "UnityEngine.UI.ContentSizeFitter", "UnityEngine.UI.LayoutElement", "UnityEngine.UI.Outline", "UnityEngine.UI.Shadow",
    "TMPro.TextMeshProUGUI", "TMPro.TextMeshPro", "TMPro.TMP_InputField", "TMPro.TMP_Dropdown",
}
# abstract bases: stubs get empty overrides so they compile
ABSTRACT_OVERRIDES = {
    "UnityEngine.Rendering.Universal.ScriptableRendererFeature": [
        "public override void Create() { }",
        "public override void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, "
        "ref UnityEngine.Rendering.Universal.RenderingData renderingData) { }",
    ],
}
ROOTS = {"UnityEngine.MonoBehaviour": "MonoBehaviour", "UnityEngine.ScriptableObject": "ScriptableObject"}


def load_signature_types(dll_dir: Path) -> dict:
    """{full name: {assembly, namespace, class, base}} from Il2CppDumper/Cpp2IL dummy DLLs.

    IL2CPP type trees carry fields but not inheritance; the dummy DLLs carry the base types.
    Generic bases (TypeSpec) are left as None, so those classes stay flattened.
    """
    import dnfile

    out = {}
    for dll in sorted(dll_dir.glob("*.dll")):
        try:
            pe = dnfile.dnPE(str(dll))
            md = pe.net.mdtables
        except Exception:
            continue
        if not md.TypeDef:
            continue
        nested = {r.NestedClass.row_index for r in md.NestedClass.rows} if md.NestedClass else set()
        for i, r in enumerate(md.TypeDef.rows, 1):
            if i in nested:
                continue
            ext = r.Extends.row if r.Extends and r.Extends.row else None
            name = getattr(ext, "TypeName", None)
            base = f"{ext.TypeNamespace}.{name}".lstrip(".") if name else None
            full = f"{r.TypeNamespace}.{r.TypeName}".lstrip(".")
            out[full] = {"assembly": dll.name, "namespace": str(r.TypeNamespace), "class": str(r.TypeName), "base": base}
    return out


def package_classes(project: Path) -> set[str]:
    """Class names declared in the target project's package sources (Library/PackageCache)."""
    names = set()
    for cs in (project / "Library" / "PackageCache").rglob("*.cs"):
        try:
            names.update(re.findall(r"\b(?:class|struct)\s+(\w+)", cs.read_text(encoding="utf-8", errors="ignore")))
        except OSError:
            pass
    return names


def cs_ident(name: str) -> str:
    name = re.sub(r"\W", "_", name)
    if name and name[0].isdigit():
        name = "_" + name
    return "@" + name if keyword.iskeyword(name) or name in ("object", "string", "base", "params", "event", "operator", "fixed") else name


class StubWriter:
    def __init__(self, scripts: dict, gen):
        self.scripts = scripts
        self.gen = gen
        self.script_names = {s["class"]: s for s in scripts.values()}
        self.unwritten: set[str] = set()  # script classes that exist in the build but get no stub
        self.nested: dict[str, list[str]] = {}

    def pptr_type(self, t: str) -> str:
        inner = t[t.index("<") + 1 : -1].lstrip("$")
        short = inner.rsplit(".", 1)[-1]
        s = self.script_names.get(short)
        if s and (inner == short or inner == f"{s['namespace']}.{short}"):
            return (s["namespace"] + "." if s["namespace"] else "") + short
        if inner in ("Object", "EditorExtension", "NamedObject"):
            return "UnityEngine.Object"
        if short in self.unwritten or "." in inner and not inner.startswith(("UnityEngine.", "TMPro.")):
            # a script type with no stub (unused base class, abstract asset type, ...):
            # UnityEngine.Object still holds the serialized reference, a missing type would not compile
            return "UnityEngine.Object"
        if inner in ENGINE_OBJECT_NS:
            return f"{ENGINE_OBJECT_NS[inner]}.{inner}"
        return inner

    def field_type(self, nodes, i) -> str:
        n = nodes[i]
        t = n.m_Type
        kids = self.children(nodes, i)
        if kids and nodes[kids[0]].m_Type == "Array" and t not in ("string",):
            arr = kids[0]
            data = [k for k in self.children(nodes, arr) if nodes[k].m_Name == "data"]
            return (self.field_type(nodes, data[0]) if data else "object") + "[]"
        if t in PRIMITIVES:
            return PRIMITIVES[t]
        if t in UNITY_VALUE_TYPES:
            return UNITY_VALUE_TYPES[t]
        if t.startswith("PPtr<"):
            return self.pptr_type(t)
        if t in ENGINE_SERIALIZABLE:
            return ENGINE_SERIALIZABLE[t]
        if [nodes[k].m_Name for k in kids] == ["m_PersistentCalls"]:
            return "UnityEngine.Events.UnityEvent"  # UnityEvent subclass: same serialized layout
        # nested [Serializable] user type
        name = cs_ident(t)
        if name not in self.nested:
            self.nested[name] = []
            self.nested[name] = self.fields(nodes, i)
        return name

    @staticmethod
    def children(nodes, i):
        lvl = nodes[i].m_Level
        out = []
        for j in range(i + 1, len(nodes)):
            if nodes[j].m_Level <= lvl:
                break
            if nodes[j].m_Level == lvl + 1:
                out.append(j)
        return out

    def fields(self, nodes, i):
        lines = []
        for k in self.children(nodes, i):
            n = nodes[k]
            if n.m_Name in ("m_GameObject", "m_Enabled", "m_Script", "m_Name", "m_EditorHideFlags", "m_EditorClassIdentifier", "m_ObjectHideFlags"):
                continue
            lines.append(f"        public {self.field_type(nodes, k)} {cs_ident(n.m_Name)};")
        return lines

    def nodes_for(self, assembly: str, fullname: str):
        if not self.gen:
            return []
        try:
            return self.gen.get_nodes(assembly if assembly.endswith(".dll") else assembly + ".dll", fullname)
        except Exception as e:
            log(f"no type tree for {fullname}: {e}")
            return []

    def write_class(self, s: dict, base: str, inherited: set[str] = frozenset(), extra: list[str] = ()) -> str:
        """inherited: top-level field names the base class already declares (dropped here)."""
        self.nested = {}
        nodes = self.nodes_for(s["assembly"], (s["namespace"] + "." if s["namespace"] else "") + s["class"])
        if nodes and inherited:
            keep = [k for k in self.children(nodes, 0) if nodes[k].m_Name not in inherited]
            body = []
            for k in keep:
                if nodes[k].m_Name not in ("m_GameObject", "m_Enabled", "m_Script", "m_Name", "m_EditorHideFlags",
                                           "m_EditorClassIdentifier", "m_ObjectHideFlags"):
                    body.append(f"        public {self.field_type(nodes, k)} {cs_ident(nodes[k].m_Name)};")
        else:
            body = self.fields(nodes, 0) if nodes else ["        // field layout unavailable"]
        body += [f"        {l}" for l in extra]
        out = ["// Generated by unity-game-to-project: serialized fields only, method bodies not recovered.",
               "using System;", "using UnityEngine;", ""]
        indent = ""
        if s["namespace"]:
            out.append(f"namespace {s['namespace']}\n{{")
            indent = "    "
        cls = cs_ident(s["class"])
        taken = {cls} | {l.rstrip(";").split()[-1] for l in body if l.strip().startswith("public ")}
        for name in [n for n in self.nested if n in taken]:
            new = name + "_T"
            pat = re.compile(rf"(?<![\w.]){re.escape(name)}(?=(\[\])* \w+;)")
            body = [pat.sub(new, l) for l in body]
            self.nested = {(new if k == name else k): [pat.sub(new, l) for l in v] for k, v in self.nested.items()}
        out.append(f"{indent}public class {cls} : {base}\n{indent}{{")
        out += [indent + l[4:] for l in body]
        # nested inside the class: helper types from different stubs often share a name
        for name, flines in self.nested.items():
            out.append(f"\n{indent}    [Serializable]\n{indent}    public class {name}\n{indent}    {{")
            out += [indent + l for l in flines]
            out.append(f"{indent}    }}")
        out.append(f"{indent}}}")
        if s["namespace"]:
            out.append("}")
        return "\n".join(out) + "\n"


# Unity reserves these names for assemblies it compiles from loose scripts; a precompiled
# DLL with such a name gets no MonoScripts, so its components can't be attached.
# Renames keep the length and the "-CSharp..." suffix, so tail-merged #Strings entries
# stay valid and the patch is a byte-for-byte overwrite.
RESERVED = {
    "Assembly-CSharp": "Original-CSharp",
    "Assembly-CSharp-firstpass": "Original-CSharp-firstpass",
}


def rename_reserved(data: bytes) -> tuple[bytes, int]:
    """Rename reserved assembly identities (definition and references) in a .NET PE."""
    lo, hi = 0, len(data)
    try:
        import dnfile

        pe = dnfile.dnPE(data=data)
        s = pe.net.metadata.streams.get(b"#Strings")
        if s is not None:
            off = pe.get_offset_from_rva(pe.net.struct.MetaData_RVA) + s.struct.Offset
            lo, hi = off, off + s.struct.Size
    except Exception:
        pass  # fall back to patching NUL-terminated occurrences anywhere in the file
    buf = bytearray(data)
    patches = 0
    for old, new in RESERVED.items():
        for suffix in (b"\x00", b".dll\x00"):
            o, n = old.encode() + suffix, new.encode() + suffix
            i = buf.find(o, lo, hi)
            while i >= 0:
                # must be the start of a heap string (preceded by NUL), not a tail of a longer name
                if i == 0 or buf[i - 1] == 0:
                    buf[i : i + len(o)] = n
                    patches += 1
                i = buf.find(o, i + 1, hi)
    return bytes(buf), patches


def assembly_refs(path: Path) -> list[str]:
    try:
        import dnfile
    except ImportError:
        return []
    try:
        pe = dnfile.dnPE(str(path))
        t = pe.net.mdtables.AssemblyRef
        return [str(r.Name) for r in t.rows] if t else []
    except Exception:
        return []


def main():
    ap = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    ap.add_argument("work_dir", type=Path)
    ap.add_argument("--mode", choices=["auto", "plugin", "stubs"], default="auto")
    ap.add_argument("--signatures", type=Path,
                    help="Il2CppDumper/Cpp2IL dummy DLL dir for base classes (default <work>/cpp2il/DummyDll)")
    ap.add_argument("--project", type=Path,
                    help="rebuilt project: stub package scripts its Library/PackageCache doesn't declare")
    a = ap.parse_args()

    survey = read_json(a.work_dir / "survey.json")
    rebuild = read_json(a.work_dir / "extract" / "project" / "RebuildData" / "rebuild.json")
    backend = survey.get("scripting", {}).get("backend")
    mode = a.mode if a.mode != "auto" else ("plugin" if backend == "Mono" else "stubs")
    if mode == "plugin" and backend != "Mono":
        sys.exit("plugin mode needs a Mono build (Managed/*.dll); use --mode stubs for IL2CPP")
    out = a.work_dir / "scripts"
    shutil.rmtree(out, ignore_errors=True)
    report = {"mode": mode, "backend": backend}

    used = {k: s for k, s in rebuild["scripts"].items() if s.get("usage")}
    used_asms = sorted({s["assembly"] if s["assembly"].endswith(".dll") else s["assembly"] + ".dll" for s in used.values()})
    report["scripts_used"] = len(used)
    report["assemblies_used"] = used_asms

    if mode == "plugin":
        managed = Path(survey["scripting"]["managed_dir"])
        todo = [x for x in used_asms if not UNITY_ASM.match(x)]
        copied = set()
        while todo:
            name = todo.pop()
            p = managed / name
            if name in copied or not p.exists():
                continue
            copied.add(name)
            for r in assembly_refs(p):
                dll = r + ".dll"
                if not UNITY_ASM.match(dll) and dll not in copied:
                    todo.append(dll)
        written = []
        for name in sorted(copied):
            data = (managed / name).read_bytes()
            data, n = rename_reserved(data)
            stem = name[:-4]
            new_name = RESERVED.get(stem, stem) + ".dll"
            dst = out / "plugins" / new_name
            dst.parent.mkdir(parents=True, exist_ok=True)
            dst.write_bytes(data)
            written.append(new_name if not n else f"{new_name} (renamed from {name}, {n} patches)")
        report["plugins"] = written
        log("plugin assemblies:", ", ".join(written) or "(none)")
    else:
        gen = make_typetree_generator(Path(survey["game_dir"]), survey.get("unity_version") or "")
        full = lambda s: (s["namespace"] + "." if s["namespace"] else "") + s["class"]  # noqa: E731
        sigdir = a.signatures or a.work_dir / "cpp2il" / "DummyDll"
        sig = load_signature_types(sigdir) if sigdir.is_dir() else {}
        report["signature_types"] = len(sig)
        pkg = package_classes(a.project) if a.project else None

        # what gets a stub: used game scripts, used "Unity.*" package scripts the target packages
        # don't have (games ship modified packages), and every game ancestor of those
        todo = {}
        for s in used.values():
            if not UNITY_ASM.match(s["assembly"]):
                todo[full(s)] = s
            elif pkg is not None and s["assembly"].startswith("Unity.") and s["class"] not in pkg:
                todo[full(s)] = dict(s, forced=True)
        for f in list(todo):
            b = sig.get(f, {}).get("base")
            while b and b in sig and b not in ROOTS and b not in todo:
                t = sig[b]
                if UNITY_ASM.match(t["assembly"]) and not (pkg is not None and t["class"] not in pkg):
                    break  # package-provided ancestor
                todo[b] = {"class": t["class"], "namespace": t["namespace"], "assembly": t["assembly"], "ancestor": True}
                b = t["base"]

        def pick_base(f, s):
            b, chain = sig.get(f, {}).get("base"), set()
            while b and b not in chain:
                chain.add(b)
                if b in todo or b in SAFE_BASES or b in ABSTRACT_OVERRIDES:
                    return b
                if b in ROOTS:
                    return ROOTS[b]
                b = sig.get(b, {}).get("base")
            return "ScriptableObject" if s.get("usage") == "scriptable" else "MonoBehaviour"

        # field types may only name classes that will exist: written stubs or package scripts
        known = {k: s for k, s in rebuild["scripts"].items() if UNITY_ASM.match(s["assembly"]) and full(s) not in todo}
        known.update({f"stub:{f}": s for f, s in todo.items()})
        sw = StubWriter(known, gen)
        sw.unwritten = {s["class"] for s in rebuild["scripts"].values()} - set(sw.script_names)
        stats = Counter()
        for f, s in todo.items():
            base = pick_base(f, s)
            inherited = set()
            if base not in ("MonoBehaviour", "ScriptableObject"):
                b = todo.get(base) or sig.get(base)
                inherited = {n.m_Name for n in sw.nodes_for(b["assembly"], base) if n.m_Level == 1} if b else set()
                stats["derived"] += 1
            path = out / "stubs" / (s["namespace"].replace(".", "/") or "_global") / f"{s['class']}.cs"
            path.parent.mkdir(parents=True, exist_ok=True)
            path.write_text(sw.write_class(s, base, inherited, ABSTRACT_OVERRIDES.get(base, [])), encoding="utf-8")
            stats["forced" if s.get("forced") else "ancestor" if s.get("ancestor") else "used"] += 1
        report["stubs"] = len(todo)
        report["stub_kinds"] = dict(stats)
        log(f"wrote {len(todo)} stub classes {dict(stats)}")
    write_json(a.work_dir / "scripts_report.json", report)


if __name__ == "__main__":
    main()
