"""Stage 3: parse every Unity object and export assets + a rebuild graph.

Reads <work>/survey.json (and decrypted bundles from decrypt.py), loads all
serialized files/bundles with UnityPy, and writes a staging tree:

  <work>/extract/project/Assets/...            exported files laid out as a Unity project
  <work>/extract/project/RebuildData/rebuild.json   graph consumed by the Unity-side rebuilder
  <work>/extract/project/RebuildData/meshes/   mesh data (json) for Mesh asset creation
  <work>/extract/reference/                    human-oriented extras (OBJ meshes, shader dumps,
                                               full per-file object dumps)
  <work>/extract/extract_report.json           counts, failures, unsupported types

usage: python extract.py <work_dir> [--no-dumps] [--include-builtin]
"""
from __future__ import annotations

import argparse
import io
import json
import sys
import traceback
import zlib
from collections import Counter, defaultdict
from pathlib import Path

sys.path.insert(0, str(Path(__file__).parent))
from ugp_common import (  # noqa: E402
    ensure_unityPy, log, make_typetree_generator, norm_file_key, obj_key, read_json, safe_name, write_json,
)

BUILTIN_FILES = {"unity default resources", "unity_builtin_extra", "unity_builtin_extra.assets"}
SETTINGS_TYPES = {
    "TagManager", "InputManager", "TimeManager", "Physics2DSettings", "PhysicsManager", "AudioManager",
    "QualitySettings", "PlayerSettings", "BuildSettings", "ResourceManager", "GraphicsSettings",
}
SKIP_TYPES = {
    "AssetBundle", "PreloadData", "AssetBundleManifest", "MonoManager", "ScriptMapper", "DelayedCallManager",
    "RuntimeInitializeOnLoadManager", "StreamingManager", "UnityConnectSettings", "VFXManager",
    "NavMeshProjectSettings", "LightmapSettings", "NavMeshSettings", "OcclusionCullingSettings",
    "OcclusionCullingData", "LightProbes", "SpriteAtlas", "ShaderVariantCollection", "PlayerSettings",
    "RenderSettings",  # captured per scene
}
# native assets the Unity-side rebuilder can recreate generically (new T() + SerializedObject)
CREATABLE_NATIVE = {
    "PhysicsMaterial2D", "PhysicMaterial", "PhysicsMaterial", "RenderTexture", "AvatarMask", "Flare",
    "LightingSettings", "TerrainLayer", "CustomRenderTexture",
}
FILE_TYPES = {"Texture2D", "Sprite", "AudioClip", "TextAsset", "Font", "Mesh", "VideoClip", "Shader", "MonoScript"}
COMPONENT_SKIP_FIELDS = {
    "m_GameObject", "m_Script", "m_Father", "m_Children", "m_PrefabInstance", "m_PrefabAsset",
    "m_CorrespondingSourceObject", "m_PrefabParentObject", "m_PrefabInternal", "m_ObjectHideFlags",
    "m_EditorHideFlags", "m_EditorClassIdentifier",
}
BUILTIN_TAGS = {0: "Untagged", 1: "Respawn", 2: "Finish", 3: "EditorOnly", 5: "MainCamera", 6: "Player", 7: "GameController"}
TEXT_EXTS = (".txt", ".json", ".xml", ".csv", ".yaml", ".html", ".htm", ".fnt", ".bytes")


class Extractor:
    def __init__(self, work: Path, include_builtin: bool, dumps: bool):
        import UnityPy

        self.work = work
        self.survey = read_json(work / "survey.json")
        self.game_dir = Path(self.survey["game_dir"])
        self.data_dir = Path(self.survey["data_dir"])
        self.product = safe_name(self.survey.get("product") or self.survey.get("product_name") or "Game")
        self.version = self.survey.get("unity_version") or "2020.3.0f1"
        self.out = work / "extract"
        self.proj = self.out / "project"
        self.refdir = self.out / "reference"
        self.root = f"Assets/_Recovered/{self.product}"
        self.include_builtin = include_builtin
        self.want_dumps = dumps
        self.report = {"exported": Counter(), "failed": [], "unsupported": Counter(), "warnings": []}
        self.used_paths: set[str] = set()

        paths = [str(self.data_dir)]
        dec = work / "decrypted"
        if dec.is_dir():
            paths += [str(p) for p in sorted(dec.rglob("*.bundle"))]
        # bundles built with version stripping store "0.0.0"; fall back to the player's version
        UnityPy.config.FALLBACK_UNITY_VERSION = self.version
        log("loading", len(paths), "roots with UnityPy ...")
        self.env = UnityPy.load(*paths)
        gen = make_typetree_generator(self.game_dir, self.version)
        if gen:
            self.env.typetree_generator = gen
        else:
            self.report["warnings"].append("No TypeTreeGenerator: script data in player builds can't be decoded")

        self.objs = {}
        for o in self.env.objects:
            self.objs[obj_key(o.assets_file.name, o.path_id)] = o
        log(f"{len(self.objs)} objects in {len({k.split(':')[0] for k in self.objs})} serialized files")

        self.containers = {}
        for path, ptr in self.env.container.items():
            try:
                o = ptr if hasattr(ptr, "assets_file") and hasattr(ptr, "path_id") and hasattr(ptr, "type") else ptr.deref()
                self.containers.setdefault(obj_key(o.assets_file.name, o.path_id), path)
            except Exception:
                pass

        # graph accumulated for rebuild.json
        self.assets: dict[str, dict] = {}
        self.textures: dict[str, dict] = {}
        self.scripts: dict[str, dict] = {}
        self.gameobjects: dict[str, dict] = {}
        self.components: dict[str, dict] = {}
        self.settings: dict[str, dict] = {}
        self.scenes: list[dict] = []
        self.prefabs: list[dict] = []
        self.tags: list[str] = []
        self.typetree_cache: dict[str, dict | None] = {}

    # ------------------------------------------------------------ helpers
    def tt(self, key):
        if key not in self.typetree_cache:
            o = self.objs[key]
            try:
                self.typetree_cache[key] = o.read_typetree()
            except Exception as e:
                self.typetree_cache[key] = None
                self.report["failed"].append({"key": key, "type": o.type.name, "stage": "typetree", "error": str(e)[:200]})
        return self.typetree_cache[key]

    def ref(self, src_obj, pptr) -> str | None:
        fid, pid = pptr.get("m_FileID", 0), pptr.get("m_PathID", 0)
        if not pid:
            return None
        sf = src_obj.assets_file
        if fid == 0:
            return obj_key(sf.name, pid)
        try:
            return obj_key(sf.externals[fid - 1].path, pid)
        except IndexError:
            return None

    def norm(self, src_obj, v):
        """Replace PPtrs by {"$ref": key}; shrink binary blobs."""
        if isinstance(v, dict):
            if set(v.keys()) == {"m_FileID", "m_PathID"}:
                r = self.ref(src_obj, v)
                return {"$ref": r} if r else None
            return {k: self.norm(src_obj, x) for k, x in v.items()}
        if isinstance(v, (list, tuple)):
            return [self.norm(src_obj, x) for x in v]
        if isinstance(v, (bytes, bytearray)):
            return list(v) if len(v) <= 65536 else {"$bytes": len(v)}
        return v

    def alloc(self, rel: str) -> str:
        """Reserve a unique project-relative path (case-insensitive)."""
        rel = rel.replace("\\", "/")
        stem, dot, ext = rel.rpartition(".")
        if not dot:
            stem, ext = rel, ""
        cand, i = rel, 1
        while cand.lower() in self.used_paths:
            cand = f"{stem}_{i}.{ext}" if ext else f"{stem}_{i}"
            i += 1
        self.used_paths.add(cand.lower())
        return cand

    def place(self, key, name, folder, ext) -> str:
        c = self.containers.get(key)
        if c:
            c = c.replace("\\", "/")
            if not c.lower().startswith("assets/"):
                # Resources.Load path (no extension) or addressable key
                c = f"Assets/Resources/{c}"
            else:
                c = "Assets/" + c[7:]
            base = c.rsplit(".", 1)[0] if "." in c.rsplit("/", 1)[-1] else c
            return self.alloc(f"{base}{ext}")
        return self.alloc(f"{self.root}/{folder}/{safe_name(name, key.replace(':', '_'))}{ext}")

    def write(self, rel: str, data: bytes):
        p = self.proj / rel
        p.parent.mkdir(parents=True, exist_ok=True)
        p.write_bytes(data)

    def file_of(self, key):
        return key.split(":", 1)[0]

    # ------------------------------------------------------------ passes
    def run(self):
        self.read_settings()
        by_type = defaultdict(list)
        for key, o in self.objs.items():
            by_type[o.type.name].append(key)
        for key in by_type.get("MonoScript", []):
            self.export_monoscript(key)
        for key in by_type.get("Texture2D", []):
            self.guard(self.export_texture, key)
        for key in by_type.get("Sprite", []):
            self.guard(self.export_sprite, key)
        for t, fn in (("AudioClip", self.export_audio), ("TextAsset", self.export_textasset), ("Font", self.export_font),
                      ("Mesh", self.export_mesh), ("VideoClip", self.export_video), ("Shader", self.export_shader)):
            for key in by_type.get(t, []):
                self.guard(fn, key)
        for key in by_type.get("Material", []):
            self.guard(self.export_material, key)
        for key in by_type.get("GameObject", []):
            self.guard(self.export_gameobject, key)
        for key in by_type.get("MonoBehaviour", []):
            if key not in self.components:
                self.guard(self.export_scriptable, key)
        for t, keys in by_type.items():
            if t in FILE_TYPES or t in SETTINGS_TYPES or t in SKIP_TYPES or t in ("Material", "GameObject", "MonoBehaviour"):
                continue
            for key in keys:
                if key in self.components or self.file_of(key) in BUILTIN_FILES:
                    continue
                self.guard(self.export_native, key)
        self.collect_scenes_and_prefabs()
        self.collect_bundles()
        if self.want_dumps:
            self.write_dumps()
        self.save()

    def guard(self, fn, key):
        if self.file_of(key) in BUILTIN_FILES and not self.include_builtin:
            self.register_builtin(key)
            return
        try:
            fn(key)
        except Exception as e:
            o = self.objs[key]
            self.report["failed"].append({"key": key, "type": o.type.name, "stage": fn.__name__, "error": f"{type(e).__name__}: {e}"[:300]})
            if len(self.report["failed"]) < 5:
                traceback.print_exc()

    def register_builtin(self, key):
        o = self.objs[key]
        name = ""
        try:
            if o.type.name == "Shader":
                name = self.shader_name(o)
            else:
                name = o.peek_name() or ""
        except Exception:
            pass
        self.assets[key] = {"kind": "builtin", "type": o.type.name, "name": name}

    # ------------------------------------------------------------ settings
    def read_settings(self):
        for key, o in self.objs.items():
            t = o.type.name
            if t not in SETTINGS_TYPES or self.file_of(key) in BUILTIN_FILES:
                continue
            d = self.tt(key)
            if d is None:
                # settings layouts drift between Unity versions; not fatal
                fail = self.report["failed"].pop()
                self.report["warnings"].append(f"settings {t} unreadable: {fail['error']}")
                continue
            if t == "PlayerSettings":
                keep = ("productName", "companyName", "defaultScreenWidth", "defaultScreenHeight", "runInBackground",
                        "fullscreenMode", "m_ActiveColorSpace", "defaultIsNativeResolution", "resizableWindow",
                        "bundleVersion", "visibleInBackground", "allowFullscreenSwitch")
                self.settings[t] = {k: d[k] for k in keep if k in d}
            elif t == "GraphicsSettings":
                self.settings[t] = {k: v for k, v in self.norm(o, d).items() if k in ("m_TransparencySortMode", "m_TransparencySortAxis")}
            else:
                self.settings[t] = self.norm(o, d)
        self.tags = list(self.settings.get("TagManager", {}).get("tags", []))
        ps = self.settings.setdefault("PlayerSettings", {})
        ps.setdefault("productName", self.survey.get("product") or self.product)
        ps.setdefault("companyName", self.survey.get("company") or "")
        # Resources.Load paths live in ResourceManager, not in env.container
        for path, ptr in self.settings.get("ResourceManager", {}).get("m_Container", []):
            if ptr and ptr.get("$ref"):
                self.containers.setdefault(ptr["$ref"], path)

    def tag_name(self, tag: int) -> str:
        if tag in BUILTIN_TAGS:
            return BUILTIN_TAGS[tag]
        if tag >= 20000 and tag - 20000 < len(self.tags):
            return self.tags[tag - 20000]
        return "Untagged"

    # ------------------------------------------------------------ exporters
    def export_monoscript(self, key):
        d = self.tt(key) or {}
        self.scripts[key] = {
            "class": d.get("m_ClassName", ""),
            "namespace": d.get("m_Namespace", ""),
            "assembly": d.get("m_AssemblyName", ""),
        }

    def export_texture(self, key):
        o = self.objs[key]
        tex = o.read()
        name = tex.m_Name or key
        sd = getattr(tex, "m_StreamData", None)
        if not getattr(tex, "image_data", b"") and not (sd and sd.path and sd.size):
            # dynamic font / TMP dynamic atlas: no pixels in the build, filled at runtime
            self.report["warnings"].append(f"{key} Texture2D '{name}' has no pixel data (runtime-generated); skipped")
            return
        img = tex.image
        rel = self.place(key, name, "Textures", ".png")
        buf = io.BytesIO()
        img.save(buf, "PNG")
        self.write(rel, buf.getvalue())
        ts = getattr(tex, "m_TextureSettings", None)
        self.textures[rel] = {
            "key": key,
            "width": img.width,
            "height": img.height,
            "filterMode": getattr(ts, "m_FilterMode", 1) if ts else 1,
            "wrapU": getattr(ts, "m_WrapU", 0) if ts else 0,
            "wrapV": getattr(ts, "m_WrapV", 0) if ts else 0,
            "aniso": getattr(ts, "m_Aniso", 1) if ts else 1,
            "mipmaps": (getattr(tex, "m_MipCount", 1) or 1) > 1,
            "readable": bool(getattr(tex, "m_IsReadable", False)),
            "sRGB": getattr(tex, "m_ColorSpace", 1) == 1,
            "sprites": [],
        }
        self.assets[key] = {"kind": "file", "type": "Texture2D", "name": name, "path": rel}
        self.report["exported"]["Texture2D"] += 1

    def export_sprite(self, key):
        o = self.objs[key]
        d = self.tt(key)
        name = d.get("m_Name") or key
        rd = d.get("m_RD", {})
        tex_key = self.ref(o, rd.get("texture", {}))
        atlas = self.ref(o, d.get("m_SpriteAtlas", {"m_FileID": 0, "m_PathID": 0}))
        rect = d["m_Rect"]
        trect = rd.get("textureRect", rect)
        # settingsRaw bit0 = packed into an atlas. For unpacked sprites textureRect is
        # only the trimmed alpha bounds, so m_Rect is the true slice on the texture.
        packed = bool(rd.get("settingsRaw", 0) & 1)
        same_rect = not packed or all(abs(rect[k] - trect.get(k, rect[k])) < 0.51 for k in ("x", "y", "width", "height"))
        tex_entry = self.assets.get(tex_key) if tex_key else None
        pivot = d.get("m_Pivot", {"x": 0.5, "y": 0.5})
        border = d.get("m_Border", {"x": 0, "y": 0, "z": 0, "w": 0})
        meta = {
            "name": name, "key": key,
            "pivot": [pivot["x"], pivot["y"]],
            "ppu": d.get("m_PixelsToUnits", 100.0),
            "border": [border["x"], border["y"], border["z"], border["w"]],
        }
        if tex_entry and tex_entry.get("kind") == "file" and not atlas and same_rect:
            meta["rect"] = [rect["x"], rect["y"], rect["width"], rect["height"]]
            tex = self.textures[tex_entry["path"]]
            names = {s["name"] for s in tex["sprites"]}
            base, i = meta["name"], 1
            while meta["name"] in names:
                meta["name"] = f"{base}_{i}"
                i += 1
            tex["sprites"].append(meta)
            self.assets[key] = {"kind": "sprite", "type": "Sprite", "name": meta["name"], "path": tex_entry["path"]}
        else:
            # atlas-packed / tight / rotated: render the sprite standalone
            img = o.read().image
            rel = self.place(key, name, "Sprites", ".png")
            buf = io.BytesIO()
            img.save(buf, "PNG")
            self.write(rel, buf.getvalue())
            meta["rect"] = [0, 0, img.width, img.height]
            self.textures[rel] = {"key": None, "width": img.width, "height": img.height, "filterMode": 1, "wrapU": 1,
                                  "wrapV": 1, "aniso": 1, "mipmaps": False, "readable": False, "sRGB": True, "sprites": [meta]}
            self.assets[key] = {"kind": "sprite", "type": "Sprite", "name": name, "path": rel}
        self.report["exported"]["Sprite"] += 1

    def export_audio(self, key):
        clip = self.objs[key].read()
        name = clip.m_Name or key
        samples = clip.samples
        if not samples:
            raise ValueError("no samples decoded (FMOD unavailable or unsupported codec)")
        first = True
        for sname, wav in samples.items():
            rel = self.place(key, name if first else sname, "Audio", ".wav")
            self.write(rel, wav)
            if first:
                self.assets[key] = {"kind": "file", "type": "AudioClip", "name": name, "path": rel,
                                    "loadInBackground": bool(getattr(clip, "m_LoadInBackground", False))}
                first = False
        self.report["exported"]["AudioClip"] += 1

    def export_textasset(self, key):
        o = self.objs[key]
        d = o.read()
        name = d.m_Name or key
        raw = d.m_Script
        data = raw.encode("utf-8", "surrogateescape") if isinstance(raw, str) else bytes(raw)
        c = self.containers.get(key, "")
        ext = "." + c.rsplit(".", 1)[-1].lower() if "." in c.rsplit("/", 1)[-1] else ""
        if ext not in TEXT_EXTS:
            try:
                txt = data.decode("utf-8")
                s = txt.lstrip()
                ext = ".json" if s[:1] in "{[" else ".xml" if s.startswith("<") else ".txt"
            except UnicodeDecodeError:
                ext = ".bytes"
        rel = self.place(key, name, "TextAssets", ext)
        self.write(rel, data)
        self.assets[key] = {"kind": "file", "type": "TextAsset", "name": name, "path": rel}
        self.report["exported"]["TextAsset"] += 1

    def export_font(self, key):
        d = self.objs[key].read()
        name = d.m_Name or key
        data = bytes(getattr(d, "m_FontData", b"") or b"")
        if not data:
            names = list(getattr(d, "m_FontNames", []) or [])
            self.assets[key] = {"kind": "osfont", "type": "Font", "name": name, "fontNames": names}
            return
        ext = ".otf" if data[:4] == b"OTTO" else ".ttf"
        rel = self.place(key, name, "Fonts", ext)
        self.write(rel, data)
        self.assets[key] = {"kind": "file", "type": "Font", "name": name, "path": rel}
        self.report["exported"]["Font"] += 1

    def export_mesh(self, key):
        from UnityPy.helpers.MeshHelper import MeshHandler

        o = self.objs[key]
        mesh = o.read()
        name = mesh.m_Name or key
        mh = MeshHandler(mesh)
        mh.process()
        tris = mh.get_triangles()

        def flat(vs, n):
            return [round(float(c), 6) for v in (vs or []) for c in list(v)[:n]]

        data = {
            "name": name,
            "vertices": flat(mh.m_Vertices, 3),
            "normals": flat(mh.m_Normals, 3),
            "tangents": flat(mh.m_Tangents, 4),
            "colors": flat(mh.m_Colors, 4),
            "uv": [flat(getattr(mh, f"m_UV{i}"), 2) for i in range(8)],
            "submeshes": [[i for t in sm for i in t] for sm in tris],
        }
        rel = self.alloc(f"RebuildData/meshes/{safe_name(name)}_{zlib.crc32(key.encode()):08x}.json")
        self.write(rel, json.dumps(data, separators=(",", ":")).encode())
        asset_rel = self.place(key, name, "Meshes", ".asset")
        self.assets[key] = {"kind": "mesh", "type": "Mesh", "name": name, "path": asset_rel, "data": rel}
        try:
            obj_path = self.refdir / "meshes" / f"{safe_name(name)}.obj"
            obj_path.parent.mkdir(parents=True, exist_ok=True)
            obj_path.write_text(mesh.export(), encoding="utf-8")
        except Exception:
            pass
        self.report["exported"]["Mesh"] += 1

    def export_video(self, key):
        from UnityPy.helpers.ResourceReader import get_resource_data

        o = self.objs[key]
        d = o.read()
        name = d.m_Name or key
        res = d.m_ExternalResources
        data = get_resource_data(res.m_Source, o.assets_file, res.m_Offset, res.m_Size)
        orig = getattr(d, "m_OriginalPath", "") or ""
        ext = "." + orig.rsplit(".", 1)[-1].lower() if "." in orig else ".mp4"
        rel = self.place(key, name, "Video", ext)
        self.write(rel, bytes(data))
        self.assets[key] = {"kind": "file", "type": "VideoClip", "name": name, "path": rel}
        self.report["exported"]["VideoClip"] += 1

    def shader_name(self, o) -> str:
        sh = o.read()
        pf = getattr(sh, "m_ParsedForm", None)
        return (getattr(pf, "m_Name", None) if pf else None) or getattr(sh, "m_Name", "") or ""

    def export_shader(self, key):
        o = self.objs[key]
        name = self.shader_name(o)
        self.assets[key] = {"kind": "shader", "type": "Shader", "name": name}
        try:
            text = o.read().export()
            p = self.refdir / "shaders" / (safe_name(name.replace("/", "_")) + ".shader.txt")
            p.parent.mkdir(parents=True, exist_ok=True)
            p.write_text(text, encoding="utf-8", errors="replace")
        except Exception:
            pass
        self.report["exported"]["Shader"] += 1

    def export_material(self, key):
        o = self.objs[key]
        d = self.norm(o, self.tt(key))
        name = d.get("m_Name") or key
        shader_key = (d.get("m_Shader") or {}).get("$ref")
        if shader_key and shader_key not in self.assets and shader_key in self.objs:
            so = self.objs[shader_key]
            self.assets[shader_key] = {"kind": "shader" if self.file_of(shader_key) not in BUILTIN_FILES else "builtin",
                                       "type": "Shader", "name": self.shader_name(so)}
        rel = self.place(key, name, "Materials", ".mat")
        self.assets[key] = {"kind": "material", "type": "Material", "name": name, "path": rel, "shader": shader_key, "data": d}
        self.report["exported"]["Material"] += 1

    def export_scriptable(self, key):
        o = self.objs[key]
        raw = self.tt(key)
        if raw is None:
            return
        d = self.norm(o, raw)
        go = (d.get("m_GameObject") or None)
        if go:
            return  # component; handled via its GameObject
        script = (d.get("m_Script") or {}).get("$ref")
        name = d.get("m_Name") or (self.scripts.get(script, {}).get("class") or key)
        rel = self.place(key, name, "ScriptableObjects", ".asset")
        data = {k: v for k, v in d.items() if k not in COMPONENT_SKIP_FIELDS}
        self.assets[key] = {"kind": "scriptable", "type": "MonoBehaviour", "name": name, "path": rel, "script": script, "data": data}
        if script in self.scripts:
            self.scripts[script]["usage"] = self.scripts[script].get("usage") or "scriptable"
        self.report["exported"]["ScriptableObject"] += 1

    def export_native(self, key):
        o = self.objs[key]
        t = o.type.name
        if t not in CREATABLE_NATIVE:
            # still present in reference/dumps; listed so the report shows what's missing
            self.report["unsupported"][t] += 1
            return
        raw = self.tt(key)
        if raw is None:
            self.report["unsupported"][t] += 1
            return
        d = self.norm(o, raw)
        if d.get("m_GameObject"):
            return  # orphan component (shouldn't happen)
        name = d.get("m_Name") or key
        ext = {"AnimationClip": ".anim", "AnimatorController": ".controller", "PhysicsMaterial2D": ".physicsMaterial2D",
               "PhysicMaterial": ".physicMaterial", "PhysicsMaterial": ".physicMaterial", "RenderTexture": ".renderTexture",
               "AudioMixerController": ".mixer", "AnimatorOverrideController": ".overrideController"}.get(t, ".asset")
        rel = self.place(key, name, t, ext)
        self.assets[key] = {"kind": "native", "type": t, "name": name, "path": rel, "data": d}
        self.report["exported"]["native:" + t] += 1

    def export_gameobject(self, key):
        o = self.objs[key]
        d = self.tt(key)
        comps = []
        for c in d.get("m_Component", []):
            p = c["component"] if isinstance(c, dict) and "component" in c else c[1] if isinstance(c, list) else c
            r = self.ref(o, p)
            if r:
                comps.append(r)
        go = {
            "name": d.get("m_Name", ""),
            "layer": d.get("m_Layer", 0),
            "tag": self.tag_name(d.get("m_Tag", 0)) if isinstance(d.get("m_Tag", 0), int) else d.get("m_TagString", "Untagged"),
            "active": bool(d.get("m_IsActive", True)),
            "components": [],
            "transform": None,
            "children": [],
            "parent": None,
        }
        for ck in comps:
            co = self.objs.get(ck)
            if co is None:
                self.report["warnings"].append(f"{key}: missing component {ck}")
                continue
            raw = self.tt(ck)
            cd = self.norm(co, raw) if raw is not None else None
            t = co.type.name
            entry = {"type": t, "go": key}
            if cd is None:
                entry["error"] = "undecodable (no type tree / script class not found)"
                if t == "MonoBehaviour":
                    entry["script"] = None
            else:
                if t == "MonoBehaviour":
                    entry["script"] = (cd.get("m_Script") or {}).get("$ref")
                    s = self.scripts.get(entry["script"])
                    if s is not None:
                        s["usage"] = "component"
                if t in ("Transform", "RectTransform"):
                    go["transform"] = ck
                    go["children"] = [c["$ref"] for c in cd.get("m_Children", []) if c]
                    go["parent"] = (cd.get("m_Father") or {}).get("$ref")
                entry["data"] = {k: v for k, v in cd.items() if k not in COMPONENT_SKIP_FIELDS}
            self.components[ck] = entry
            go["components"].append(ck)
        self.gameobjects[key] = go

    # ------------------------------------------------------------ scenes & prefabs
    def collect_scenes_and_prefabs(self):
        scene_paths = self.settings.get("BuildSettings", {}).get("scenes", [])
        # transform key -> go key
        t2go = {go["transform"]: k for k, go in self.gameobjects.items() if go["transform"]}
        for go in self.gameobjects.values():
            go["children"] = [t2go[c] for c in go["children"] if c in t2go]
            go["parent"] = t2go.get(go["parent"]) if go["parent"] else None

        files = defaultdict(list)
        for k, go in self.gameobjects.items():
            files[self.file_of(k)].append(k)

        def is_scene_file(f):
            return (f.startswith("level") and f[5:].isdigit()) or (f.startswith("buildplayer-") and not f.endswith(".sharedassets"))

        for f in sorted(files, key=lambda f: (len(f), f)):
            roots = [k for k in files[f] if self.gameobjects[k]["parent"] is None]
            if is_scene_file(f):
                if f.startswith("level"):
                    idx = int(f[5:])
                    path = scene_paths[idx] if idx < len(scene_paths) else f"{self.root}/Scenes/{f}.unity"
                else:
                    path = f"{self.root}/Scenes/{f[len('buildplayer-'):]}.unity"
                if not path.lower().startswith("assets/"):
                    path = f"{self.root}/Scenes/{Path(path).stem}.unity"
                path = self.alloc(path)
                rs = None
                for k, o in self.objs.items():
                    if self.file_of(k) == f and o.type.name == "RenderSettings":
                        raw = self.tt(k)
                        rs = self.norm(o, raw) if raw else None
                self.scenes.append({"name": Path(path).stem, "path": path, "file": f, "roots": roots, "renderSettings": rs})
            elif f not in BUILTIN_FILES:
                for r in roots:
                    name = self.gameobjects[r]["name"] or r
                    rel = self.place(r, name, "Prefabs", ".prefab")
                    self.prefabs.append({"root": r, "path": rel, "name": name})
        # scenes in build order first
        order = {p: i for i, p in enumerate(scene_paths)}
        self.scenes.sort(key=lambda s: order.get(s["path"], 10**6))
        self.report["exported"]["Scene"] = len(self.scenes)
        self.report["exported"]["Prefab"] = len(self.prefabs)

    def collect_bundles(self):
        """Runtime-loaded bundles (StreamingAssets), so the project can rebuild and re-obfuscate them.

        Original bundles reference scripts by their original assembly; once scripts are
        recovered (renamed plugin or stubs) the originals no longer bind, so they get repacked.
        """
        decrypted = {}
        rep = self.work / "decrypt_report.json"
        if rep.exists():
            for e in read_json(rep)["ok"]:
                decrypted[str(Path(e["output"]).resolve()).lower()] = e
        sa_root = (self.data_dir / "StreamingAssets").resolve()
        self.bundles = []
        for path, f in self.env.files.items():
            if type(f).__name__ != "BundleFile":
                continue
            p = Path(path).resolve()
            d = decrypted.get(str(p).lower())
            src = (Path(self.survey["game_dir"]) / d["source"]).resolve() if d else p
            try:
                rel = src.relative_to(sa_root).as_posix()
            except ValueError:
                continue  # player data (data.unity3d) etc. - not a runtime bundle
            comp = {0: "none", 1: "lzma", 2: "lz4", 3: "lz4"}.get((getattr(f, "_block_info_flags", 2) or 0) & 0x3F, "lz4")
            for sub_name in f.files:
                fk = norm_file_key(sub_name)
                for key, o in self.objs.items():
                    if self.file_of(key) != fk or o.type.name != "AssetBundle":
                        continue
                    ab = self.tt(key) or {}
                    assets = []
                    for entry in ab.get("m_Container", []):
                        cpath, info = entry if isinstance(entry, (list, tuple)) else (entry[0], entry[1])
                        r = self.ref(o, info["asset"])
                        if r and r not in assets:
                            assets.append(r)
                    self.bundles.append({
                        "name": ab.get("m_AssetBundleName") or ab.get("m_Name") or Path(rel).stem,
                        "source": rel,
                        "compression": comp,
                        "scenes": bool(ab.get("m_IsStreamedSceneAssetBundle")),
                        "assets": assets,
                        "transform": d.get("transform") if d else None,
                        "decrypted": bool(d),
                    })
        self.report["exported"]["Bundle"] = len(self.bundles)

    def write_dumps(self):
        dump_dir = self.refdir / "dumps"
        dump_dir.mkdir(parents=True, exist_ok=True)
        per_file = defaultdict(list)
        heavy = {"Texture2D", "AudioClip", "Mesh", "Shader", "Font", "VideoClip", "TextAsset", "Texture2DArray", "Cubemap"}
        for k, o in self.objs.items():
            if self.file_of(k) in BUILTIN_FILES:
                continue
            if o.type.name in heavy:
                per_file[self.file_of(k)].append({"key": k, "type": o.type.name, "name": self.assets.get(k, {}).get("name")})
                continue
            raw = self.typetree_cache.get(k) if k in self.typetree_cache else self.tt(k)
            per_file[self.file_of(k)].append({"key": k, "type": o.type.name, "data": self.norm(o, raw) if raw else None})
        for f, items in per_file.items():
            with open(dump_dir / f"{safe_name(f)}.jsonl", "w", encoding="utf-8") as fh:
                for it in items:
                    fh.write(json.dumps(it, ensure_ascii=False, default=str) + "\n")

    def save(self):
        rebuild = {
            "format": 1,
            "product": self.product,
            "unityVersion": self.version,
            "scriptingBackend": self.survey.get("scripting", {}).get("backend"),
            "root": self.root,
            "settings": self.settings,
            "scripts": self.scripts,
            "assets": self.assets,
            "textures": self.textures,
            "gameObjects": self.gameobjects,
            "components": self.components,
            "prefabs": self.prefabs,
            "scenes": self.scenes,
            "bundles": getattr(self, "bundles", []),
        }
        write_json(self.proj / "RebuildData" / "rebuild.json", rebuild)
        rep = {k: (dict(v) if isinstance(v, Counter) else v) for k, v in self.report.items()}
        write_json(self.out / "extract_report.json", rep)
        log("exported:", json.dumps(dict(self.report["exported"])))
        if self.report["unsupported"]:
            log("unsupported:", json.dumps(dict(self.report["unsupported"])))
        log(f"failures: {len(self.report['failed'])}, warnings: {len(self.report['warnings'])}")


def main():
    ap = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    ap.add_argument("work_dir", type=Path)
    ap.add_argument("--no-dumps", action="store_true", help="skip full per-file object dumps in reference/")
    ap.add_argument("--include-builtin", action="store_true", help="also export Unity built-in resources")
    a = ap.parse_args()
    ensure_unityPy()
    Extractor(a.work_dir, a.include_builtin, not a.no_dumps).run()


if __name__ == "__main__":
    main()
