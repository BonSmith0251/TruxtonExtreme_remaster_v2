// Rebuilds a Unity project from RebuildData/rebuild.json produced by extract.py.
// Batch: Unity -batchmode -projectPath P -executeMethod GameRebuild.Rebuilder.RunBatch -quit
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

namespace GameRebuild
{
    public static class Rebuilder
    {
        const string DataPath = "RebuildData/rebuild.json";
        const string ReportPath = "RebuildData/rebuild_report.json";

        static readonly HashSet<string> SkipComponent = new HashSet<string>
        {
            "m_GameObject", "m_Script", "m_Father", "m_Children", "m_Name", "m_ObjectHideFlags",
            "m_PrefabInstance", "m_PrefabAsset", "m_CorrespondingSourceObject",
        };
        static readonly HashSet<string> SkipAsset = new HashSet<string> { "m_Script", "m_Name", "m_ObjectHideFlags", "m_Shader" };
        static readonly HashSet<string> SkipSettings = new HashSet<string> { "m_ObjectHideFlags", "m_Name" };

        static Dictionary<string, object> root, assets, textures, scripts, gameObjects, components, settings;
        static readonly Dictionary<string, Object> global = new Dictionary<string, Object>();
        static Dictionary<string, Object> local;
        static PropertyApplier applier;
        static readonly Dictionary<string, Type> typeCache = new Dictionary<string, Type>();
        static Dictionary<string, Type> unityTypes;
        static readonly Dictionary<string, object> report = new Dictionary<string, object>();
        static readonly List<string> missingScripts = new List<string>();
        static readonly List<string> unknownTypes = new List<string>();
        static readonly List<string> notes = new List<string>();
        static int logErrors, logWarnings;
        static readonly List<string> errorMessages = new List<string>();
        static readonly HashSet<string> builtinUnmapped = new HashSet<string>();

        [MenuItem("Tools/Game Rebuild/Rebuild From RebuildData")]
        public static void RunInteractive() => Run();

        public static void RunBatch()
        {
            try
            {
                Run();
                EditorApplication.Exit(0);
            }
            catch (Exception e)
            {
                Debug.LogError("REBUILD FAILED: " + e);
                EditorApplication.Exit(1);
            }
        }

        static void Run()
        {
            Application.logMessageReceived += OnLog;
            try
            {
                root = (Dictionary<string, object>)MiniJson.Parse(File.ReadAllText(DataPath));
                assets = Dict(root, "assets");
                textures = Dict(root, "textures");
                scripts = Dict(root, "scripts");
                gameObjects = Dict(root, "gameObjects");
                components = Dict(root, "components");
                settings = Dict(root, "settings");
                global.Clear();
                applier = new PropertyApplier { Resolve = Resolve };

                Step("settings", ApplySettings);
                Step("textures", ConfigureTextures);
                Step("file assets", MapFileAssets);
                Step("meshes", CreateMeshes);
                Step("materials", CreateMaterials);
                Step("asset shells", CreateAssetShells);
                Step("prefabs (structure)", BuildPrefabStructure);
                Step("asset data", ApplyAssetData);
                Step("prefabs (data)", ApplyPrefabData);
                Step("scenes", BuildScenes);
                AssetDatabase.SaveAssets();
                Step("bundles", BuildBundles);
                AssetDatabase.Refresh();
            }
            finally
            {
                Application.logMessageReceived -= OnLog;
                WriteReport();
            }
        }

        static void OnLog(string msg, string stack, LogType type)
        {
            if (type == LogType.Error || type == LogType.Exception || type == LogType.Assert)
            {
                logErrors++;
                if (errorMessages.Count < 30) errorMessages.Add(msg.Split('\n')[0]);
            }
            else if (type == LogType.Warning) logWarnings++;
        }

        static void Step(string name, Action a)
        {
            var t = DateTime.Now;
            Debug.Log("[GameRebuild] " + name + " ...");
            a();
            Debug.Log($"[GameRebuild] {name} done in {(DateTime.Now - t).TotalSeconds:0.0}s");
        }

        // ================================================================ settings
        static void ApplySettings()
        {
            var map = new Dictionary<string, string>
            {
                { "TagManager", "ProjectSettings/TagManager.asset" },
                { "InputManager", "ProjectSettings/InputManager.asset" },
                { "TimeManager", "ProjectSettings/TimeManager.asset" },
                { "Physics2DSettings", "ProjectSettings/Physics2DSettings.asset" },
                { "PhysicsManager", "ProjectSettings/DynamicsManager.asset" },
                { "AudioManager", "ProjectSettings/AudioManager.asset" },
                { "QualitySettings", "ProjectSettings/QualitySettings.asset" },
                { "GraphicsSettings", "ProjectSettings/GraphicsSettings.asset" },
            };
            foreach (var kv in map)
            {
                if (!settings.TryGetValue(kv.Key, out var data)) continue;
                var objs = AssetDatabase.LoadAllAssetsAtPath(kv.Value);
                if (objs == null || objs.Length == 0) { notes.Add("settings asset not found: " + kv.Value); continue; }
                applier.Apply(objs[0], (Dictionary<string, object>)data, SkipSettings);
            }
            if (settings.TryGetValue("PlayerSettings", out var ps) && ps is Dictionary<string, object> p)
            {
                if (p.TryGetValue("productName", out var pn)) PlayerSettings.productName = (string)pn;
                if (p.TryGetValue("companyName", out var cn) && !string.IsNullOrEmpty((string)cn)) PlayerSettings.companyName = (string)cn;
                if (p.TryGetValue("defaultScreenWidth", out var w)) PlayerSettings.defaultScreenWidth = Convert.ToInt32(w);
                if (p.TryGetValue("defaultScreenHeight", out var h)) PlayerSettings.defaultScreenHeight = Convert.ToInt32(h);
                if (p.TryGetValue("runInBackground", out var rb)) PlayerSettings.runInBackground = Convert.ToInt64(rb is bool b ? (b ? 1 : 0) : rb) != 0;
                if (p.TryGetValue("fullscreenMode", out var fm)) PlayerSettings.fullScreenMode = (FullScreenMode)Convert.ToInt32(fm);
                if (p.TryGetValue("m_ActiveColorSpace", out var cs)) PlayerSettings.colorSpace = Convert.ToInt32(cs) == 1 ? ColorSpace.Linear : ColorSpace.Gamma;
            }
            AssetDatabase.SaveAssets();
        }

        // ================================================================ textures & file assets
#pragma warning disable 618
        static void ConfigureTextures()
        {
            AssetDatabase.StartAssetEditing();
            try
            {
                foreach (var kv in textures)
                {
                    var t = (Dictionary<string, object>)kv.Value;
                    var ti = AssetImporter.GetAtPath(kv.Key) as TextureImporter;
                    if (ti == null) { notes.Add("texture not imported: " + kv.Key); continue; }
                    var sprites = (List<object>)t["sprites"];
                    int w = Convert.ToInt32(t["width"]), h = Convert.ToInt32(t["height"]);
                    ti.filterMode = (FilterMode)Convert.ToInt32(t["filterMode"]);
                    ti.wrapModeU = (TextureWrapMode)Convert.ToInt32(t["wrapU"]);
                    ti.wrapModeV = (TextureWrapMode)Convert.ToInt32(t["wrapV"]);
                    ti.anisoLevel = Convert.ToInt32(t["aniso"]);
                    ti.mipmapEnabled = (bool)t["mipmaps"];
                    ti.isReadable = (bool)t["readable"];
                    ti.sRGBTexture = (bool)t["sRGB"];
                    ti.npotScale = TextureImporterNPOTScale.None;
                    ti.maxTextureSize = Mathf.Clamp(Mathf.NextPowerOfTwo(Math.Max(w, h)), 32, 16384);
                    if (sprites.Count > 0)
                    {
                        ti.textureType = TextureImporterType.Sprite;
                        ti.alphaIsTransparency = true;
                        ti.mipmapEnabled = false;
                        var first = (Dictionary<string, object>)sprites[0];
                        ti.spritePixelsPerUnit = (float)Convert.ToDouble(first["ppu"]);
                        var r0 = (List<object>)first["rect"];
                        bool single = sprites.Count == 1 && Convert.ToDouble(r0[0]) == 0 && Convert.ToDouble(r0[1]) == 0
                                      && Math.Abs(Convert.ToDouble(r0[2]) - w) < 0.5 && Math.Abs(Convert.ToDouble(r0[3]) - h) < 0.5
                                      && Path.GetFileNameWithoutExtension(kv.Key) == (string)first["name"];
                        if (single)
                        {
                            ti.spriteImportMode = SpriteImportMode.Single;
                            var settingsT = new TextureImporterSettings();
                            ti.ReadTextureSettings(settingsT);
                            settingsT.spriteAlignment = (int)SpriteAlignment.Custom;
                            settingsT.spritePivot = V2(first["pivot"]);
                            settingsT.spriteBorder = V4(first["border"]);
                            ti.SetTextureSettings(settingsT);
                        }
                        else
                        {
                            ti.spriteImportMode = SpriteImportMode.Multiple;
                            ti.spritesheet = sprites.Cast<Dictionary<string, object>>().Select(s => new SpriteMetaData
                            {
                                name = (string)s["name"],
                                rect = RectFrom(s["rect"]),
                                alignment = (int)SpriteAlignment.Custom,
                                pivot = V2(s["pivot"]),
                                border = V4(s["border"]),
                            }).ToArray();
                        }
                    }
                    ti.SaveAndReimport();
                }
            }
            finally
            {
                AssetDatabase.StopAssetEditing();
            }
        }
#pragma warning restore 618

        static void MapFileAssets()
        {
            foreach (var kv in assets)
            {
                var a = (Dictionary<string, object>)kv.Value;
                var kind = (string)a["kind"];
                if (kind == "file")
                {
                    var o = AssetDatabase.LoadMainAssetAtPath((string)a["path"]);
                    if (o == null) notes.Add("missing imported file: " + a["path"]);
                    else global[kv.Key] = o;
                }
                else if (kind == "sprite")
                {
                    var name = (string)a["name"];
                    var s = AssetDatabase.LoadAllAssetsAtPath((string)a["path"]).OfType<Sprite>().FirstOrDefault(x => x.name == name);
                    if (s == null) notes.Add($"sprite not found: {a["path"]}#{name}");
                    else global[kv.Key] = s;
                }
            }
        }

        // ================================================================ meshes / materials
        static void CreateMeshes()
        {
            foreach (var kv in assets)
            {
                var a = (Dictionary<string, object>)kv.Value;
                if ((string)a["kind"] != "mesh") continue;
                var d = (Dictionary<string, object>)MiniJson.Parse(File.ReadAllText((string)a["data"]));
                var m = new Mesh { name = (string)a["name"] };
                var v = Floats(d["vertices"]);
                int n = v.Length / 3;
                if (n > 65535) m.indexFormat = UnityEngine.Rendering.IndexFormat.UInt32;
                m.vertices = Vec3s(v);
                var nr = Floats(d["normals"]);
                if (nr.Length == n * 3) m.normals = Vec3s(nr);
                var tg = Floats(d["tangents"]);
                if (tg.Length == n * 4) m.tangents = Enumerable.Range(0, n).Select(i => new Vector4(tg[i * 4], tg[i * 4 + 1], tg[i * 4 + 2], tg[i * 4 + 3])).ToArray();
                var col = Floats(d["colors"]);
                if (col.Length == n * 4) m.colors = Enumerable.Range(0, n).Select(i => new Color(col[i * 4], col[i * 4 + 1], col[i * 4 + 2], col[i * 4 + 3])).ToArray();
                var uvs = (List<object>)d["uv"];
                for (int ch = 0; ch < uvs.Count; ch++)
                {
                    var uv = Floats(uvs[ch]);
                    if (uv.Length == n * 2) m.SetUVs(ch, Enumerable.Range(0, n).Select(i => new Vector2(uv[i * 2], uv[i * 2 + 1])).ToList());
                }
                var subs = (List<object>)d["submeshes"];
                m.subMeshCount = subs.Count;
                for (int s = 0; s < subs.Count; s++) m.SetTriangles(((List<object>)subs[s]).Select(x => Convert.ToInt32(x)).ToArray(), s);
                m.RecalculateBounds();
                var path = (string)a["path"];
                EnsureDir(path);
                AssetDatabase.CreateAsset(m, path);
                global[kv.Key] = m;
            }
        }

        static void CreateMaterials()
        {
            foreach (var kv in assets)
            {
                var a = (Dictionary<string, object>)kv.Value;
                if ((string)a["kind"] != "material") continue;
                var name = (string)a["name"];
                var shaderKey = a.TryGetValue("shader", out var sk) ? sk as string : null;
                var shaderName = shaderKey != null && assets.TryGetValue(shaderKey, out var se) ? (string)((Dictionary<string, object>)se)["name"] : null;
                // engine-provided default materials map back to the editor's built-ins
                if (name.StartsWith("Default-") || name.StartsWith("Sprites-"))
                {
                    var builtin = TryBuiltin<Material>(name + ".mat");
                    if (builtin != null && (shaderName == null || builtin.shader.name == shaderName)) { global[kv.Key] = builtin; continue; }
                }
                var shader = string.IsNullOrEmpty(shaderName) ? null : Shader.Find(shaderName);
                if (shader == null)
                {
                    notes.Add($"shader '{shaderName}' unavailable for material {name}; using fallback");
                    shader = Shader.Find("Standard") ?? Shader.Find("Universal Render Pipeline/Lit") ?? Shader.Find("Sprites/Default");
                }
                var mat = new Material(shader) { name = name };
                var path = (string)a["path"];
                EnsureDir(path);
                AssetDatabase.CreateAsset(mat, path);
                global[kv.Key] = mat;
            }
        }

        // ================================================================ scriptable/native asset shells
        static void CreateAssetShells()
        {
            foreach (var kv in assets)
            {
                var a = (Dictionary<string, object>)kv.Value;
                var kind = (string)a["kind"];
                Object o = null;
                if (kind == "scriptable")
                {
                    var t = ScriptType(a.TryGetValue("script", out var s) ? s as string : null);
                    if (t == null || !typeof(ScriptableObject).IsAssignableFrom(t))
                    {
                        missingScripts.Add($"{a["path"]} (script {ScriptLabel(s as string)})");
                        continue;
                    }
                    o = ScriptableObject.CreateInstance(t);
                }
                else if (kind == "native")
                {
                    var t = UnityType((string)a["type"]);
                    if (t == null || t.GetConstructor(Type.EmptyTypes) == null) { unknownTypes.Add((string)a["type"]); continue; }
                    o = (Object)Activator.CreateInstance(t);
                }
                else continue;
                o.name = (string)a["name"];
                var path = (string)a["path"];
                EnsureDir(path);
                AssetDatabase.CreateAsset(o, path);
                global[kv.Key] = o;
            }
        }

        static void ApplyAssetData()
        {
            local = null;
            foreach (var kv in assets)
            {
                var a = (Dictionary<string, object>)kv.Value;
                var kind = (string)a["kind"];
                if (kind != "scriptable" && kind != "native" && kind != "material") continue;
                if (!global.TryGetValue(kv.Key, out var o) || o == null) continue;
                if (kind == "material" && !AssetDatabase.GetAssetPath(o).StartsWith("Assets/")) continue; // built-in
                applier.Apply(o, (Dictionary<string, object>)a["data"], SkipAsset);
                EditorUtility.SetDirty(o);
            }
            AssetDatabase.SaveAssets();
        }

        // ================================================================ hierarchy
        static GameObject BuildHierarchy(string goKey, Dictionary<string, Object> map)
        {
            var g = (Dictionary<string, object>)gameObjects[goKey];
            var go = new GameObject((string)g["name"]);
            map[goKey] = go;
            go.layer = Convert.ToInt32(g["layer"]);
            var tag = (string)g["tag"];
            if (UnityEditorInternal.InternalEditorUtility.tags.Contains(tag)) go.tag = tag;
            else notes.Add($"tag '{tag}' missing; {go.name} left Untagged");

            foreach (var ckObj in (List<object>)g["components"])
            {
                var ck = (string)ckObj;
                var c = (Dictionary<string, object>)components[ck];
                var typeName = (string)c["type"];
                if (typeName == "Transform") { map[ck] = go.transform; continue; }
                if (typeName == "RectTransform") { map[ck] = go.AddComponent<RectTransform>(); continue; }
                Type t;
                if (typeName == "MonoBehaviour")
                {
                    var sk = c.TryGetValue("script", out var s) ? s as string : null;
                    t = ScriptType(sk);
                    if (t == null) { missingScripts.Add($"{GoName(goKey)} (script {ScriptLabel(sk)})"); continue; }
                }
                else
                {
                    t = UnityType(typeName);
                    if (t == null) { unknownTypes.Add(typeName); continue; }
                }
                Component comp = null;
                try { comp = go.AddComponent(t); } catch (Exception e) { notes.Add($"AddComponent {t.Name} on {go.name}: {e.Message}"); }
                if (comp == null)
                {
                    // already added through [RequireComponent] or a disallow-multiple duplicate
                    comp = go.GetComponents(t).FirstOrDefault(x => !map.ContainsValue(x));
                }
                if (comp != null) map[ck] = comp;
                else if (typeName == "MonoBehaviour") missingScripts.Add($"{GoName(goKey)} ({t.FullName} could not be attached - no MonoScript for its assembly?)");
                else notes.Add($"could not add {t.Name} to {go.name}");
            }
            foreach (var child in (List<object>)g["children"])
            {
                var cgo = BuildHierarchy((string)child, map);
                cgo.transform.SetParent(go.transform, false);
            }
            return go;
        }

        static string GoName(string goKey) => gameObjects.TryGetValue(goKey, out var g) ? (string)((Dictionary<string, object>)g)["name"] : goKey;

        static void ApplyHierarchyData(string goKey, Dictionary<string, Object> map)
        {
            var g = (Dictionary<string, object>)gameObjects[goKey];
            foreach (var ckObj in (List<object>)g["components"])
            {
                var ck = (string)ckObj;
                if (!map.TryGetValue(ck, out var comp) || comp == null) continue;
                var c = (Dictionary<string, object>)components[ck];
                if (c.TryGetValue("data", out var d) && d is Dictionary<string, object> data)
                    applier.Apply(comp, data, SkipComponent);
            }
            foreach (var child in (List<object>)g["children"]) ApplyHierarchyData((string)child, map);
            if (map[goKey] is GameObject go) go.SetActive((bool)g["active"]);
        }

        // collect keys of a saved hierarchy in the same order BuildHierarchy visits them
        static void MapSaved(string goKey, GameObject go, Dictionary<string, Object> map)
        {
            var g = (Dictionary<string, object>)gameObjects[goKey];
            map[goKey] = go;
            var used = new HashSet<Component>();
            foreach (var ckObj in (List<object>)g["components"])
            {
                var ck = (string)ckObj;
                var c = (Dictionary<string, object>)components[ck];
                var typeName = (string)c["type"];
                Type t = typeName == "MonoBehaviour" ? ScriptType(c.TryGetValue("script", out var s) ? s as string : null)
                       : typeName == "Transform" || typeName == "RectTransform" ? typeof(Transform) : UnityType(typeName);
                if (t == null) continue;
                var comp = go.GetComponents(t).FirstOrDefault(x => !used.Contains(x));
                if (comp != null) { used.Add(comp); map[ck] = comp; }
            }
            var children = (List<object>)g["children"];
            for (int i = 0; i < children.Count && i < go.transform.childCount; i++)
                MapSaved((string)children[i], go.transform.GetChild(i).gameObject, map);
        }

        // ================================================================ prefabs
        static List<Dictionary<string, object>> Prefabs() => ((List<object>)root["prefabs"]).Cast<Dictionary<string, object>>().ToList();

        static void BuildPrefabStructure()
        {
            foreach (var p in Prefabs())
            {
                var map = new Dictionary<string, Object>();
                var rootKey = (string)p["root"];
                var go = BuildHierarchy(rootKey, map);
                var path = (string)p["path"];
                EnsureDir(path);
                var saved = PrefabUtility.SaveAsPrefabAsset(go, path);
                Object.DestroyImmediate(go);
                if (saved == null) { notes.Add("failed to save prefab " + path); continue; }
                var savedMap = new Dictionary<string, Object>();
                MapSaved(rootKey, saved, savedMap);
                foreach (var kv in savedMap) global[kv.Key] = kv.Value;
            }
        }

        static void ApplyPrefabData()
        {
            foreach (var p in Prefabs())
            {
                var path = (string)p["path"];
                var rootKey = (string)p["root"];
                if (!File.Exists(path)) continue;
                var contents = PrefabUtility.LoadPrefabContents(path);
                try
                {
                    local = new Dictionary<string, Object>();
                    MapSaved(rootKey, contents, local);
                    ApplyHierarchyData(rootKey, local);
                    PrefabUtility.SaveAsPrefabAsset(contents, path);
                }
                finally
                {
                    PrefabUtility.UnloadPrefabContents(contents);
                    local = null;
                }
            }
        }

        // ================================================================ scenes
        static void BuildScenes()
        {
            var buildScenes = new List<EditorBuildSettingsScene>();
            foreach (var so in (List<object>)root["scenes"])
            {
                var s = (Dictionary<string, object>)so;
                var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
                local = new Dictionary<string, Object>();
                var roots = ((List<object>)s["roots"]).Cast<string>().ToList();
                foreach (var r in roots) BuildHierarchy(r, local);
                foreach (var r in roots) ApplyHierarchyData(r, local);
                if (s.TryGetValue("renderSettings", out var rs) && rs is Dictionary<string, object> rsd) ApplyRenderSettings(rsd);
                var path = (string)s["path"];
                EnsureDir(path);
                EditorSceneManager.SaveScene(scene, path);
                buildScenes.Add(new EditorBuildSettingsScene(path, true));
                local = null;
            }
            EditorBuildSettings.scenes = buildScenes.ToArray();
            if (buildScenes.Count > 0) EditorSceneManager.OpenScene(buildScenes[0].path);
        }

        // ================================================================ runtime bundles
        // Rebuilds each original StreamingAssets bundle from the recovered assets (same bundle
        // name, same asset paths). make_project.py then re-applies the recorded obfuscation and
        // replaces the original file, so the game's own loader keeps working.
        [MenuItem("Tools/Game Rebuild/Repack Runtime Bundles")]
        public static void RepackInteractive()
        {
            root = (Dictionary<string, object>)MiniJson.Parse(File.ReadAllText(DataPath));
            assets = Dict(root, "assets");
            BuildBundles();
        }

        static void BuildBundles()
        {
            if (!root.TryGetValue("bundles", out var bo) || !(bo is List<object> list) || list.Count == 0) return;
            var prefabPaths = Prefabs().ToDictionary(p => (string)p["root"], p => (string)p["path"]);
            var builds = new List<AssetBundleBuild>();
            var outList = new List<object>();
            var compressions = new HashSet<string>();
            foreach (Dictionary<string, object> b in list)
            {
                var names = new List<string>();
                foreach (string key in (List<object>)b["assets"])
                {
                    string path = null;
                    if (prefabPaths.TryGetValue(key, out var pp)) path = pp;
                    else if (assets.TryGetValue(key, out var ao) && ((Dictionary<string, object>)ao).TryGetValue("path", out var ap)) path = (string)ap;
                    if (path != null && File.Exists(path) && !names.Contains(path)) names.Add(path);
                    else if (path == null) notes.Add($"bundle {b["name"]}: asset {key} has no project path");
                }
                if (names.Count == 0) { notes.Add($"bundle {b["name"]}: nothing to repack"); continue; }
                builds.Add(new AssetBundleBuild { assetBundleName = (string)b["name"], assetNames = names.ToArray() });
                compressions.Add((string)b["compression"]);
                outList.Add(new Dictionary<string, object> { { "name", b["name"] }, { "source", b["source"] }, { "file", "RebuildData/repack/" + ((string)b["name"]).ToLowerInvariant() } });
            }
            if (builds.Count == 0) return;
            var opts = compressions.Count == 1 && compressions.Contains("none") ? BuildAssetBundleOptions.UncompressedAssetBundle
                     : compressions.Count == 1 && compressions.Contains("lzma") ? BuildAssetBundleOptions.None
                     : BuildAssetBundleOptions.ChunkBasedCompression;
            Directory.CreateDirectory("RebuildData/repack");
            var manifest = BuildPipeline.BuildAssetBundles("RebuildData/repack", builds.ToArray(), opts, EditorUserBuildSettings.activeBuildTarget);
            if (manifest == null) { notes.Add("bundle repack failed (see editor log)"); return; }
            File.WriteAllText("RebuildData/repack/repack.json", MiniJson.Serialize(outList));
        }

        static void ApplyRenderSettings(Dictionary<string, object> data)
        {
            var m = typeof(RenderSettings).GetMethod("GetRenderSettings", BindingFlags.NonPublic | BindingFlags.Static);
            var rs = m?.Invoke(null, null) as Object;
            if (rs == null) { notes.Add("RenderSettings object not reachable; skipped"); return; }
            applier.Apply(rs, data, SkipSettings);
        }

        // ================================================================ resolution
        static Object Resolve(string key)
        {
            if (key == null) return null;
            if (local != null && local.TryGetValue(key, out var lo)) return lo;
            if (global.TryGetValue(key, out var go)) return go;
            if (assets.TryGetValue(key, out var ao))
            {
                var a = (Dictionary<string, object>)ao;
                var kind = (string)a["kind"];
                Object found = null;
                if (kind == "builtin" || kind == "shader") found = Builtin((string)a["type"], (string)a["name"]);
                else if (kind == "osfont") found = Font.CreateDynamicFontFromOSFont(((List<object>)a["fontNames"]).Cast<string>().ToArray(), 16);
                if (found == null && kind == "builtin") builtinUnmapped.Add($"{key} ({a["type"]} '{a["name"]}')");
                global[key] = found;
                return found;
            }
            if (scripts.ContainsKey(key)) return MonoScriptFor(ScriptType(key));
            return null;
        }

        static Object Builtin(string type, string name)
        {
            switch (type)
            {
                case "Shader": return Shader.Find(name);
                case "Material": return TryBuiltin<Material>(name + ".mat");
                case "Font": return Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
                case "Mesh":
                    foreach (var n in new[] { name + ".fbx", "New-" + name + ".fbx" })
                    {
                        var m = TryBuiltinResource<Mesh>(n);
                        if (m != null) return m;
                    }
                    return null;
                case "Sprite": return TryBuiltin<Sprite>("UI/Skin/" + name + ".psd");
                case "Texture2D": return TryBuiltin<Texture2D>("UI/Skin/" + name + ".psd") ?? TryBuiltin<Texture2D>(name + ".png");
            }
            return null;
        }

        static readonly HashSet<string> knownBuiltinExtra = new HashSet<string>
        {
            "Sprites-Default.mat", "Sprites-Mask.mat", "Default-Material.mat", "Default-Diffuse.mat", "Default-Line.mat",
            "Default-Particle.mat", "Default-ParticleSystem.mat", "Default-Skybox.mat", "Default-Terrain-Standard.mat",
            "Default-Terrain-Diffuse.mat", "Default-Terrain-Specular.mat", "Default-UIMaterial.mat",
            "UI/Skin/UISprite.psd", "UI/Skin/Background.psd", "UI/Skin/InputFieldBackground.psd", "UI/Skin/Knob.psd",
            "UI/Skin/Checkmark.psd", "UI/Skin/DropdownArrow.psd", "UI/Skin/UIMask.psd",
        };

        static T TryBuiltin<T>(string path) where T : Object
        {
            // unknown names make Unity log errors, so only ask for paths that exist
            if (!knownBuiltinExtra.Contains(path)) return null;
            try { return AssetDatabase.GetBuiltinExtraResource<T>(path); } catch { return null; }
        }

        static T TryBuiltinResource<T>(string path) where T : Object
        {
            var known = new HashSet<string> { "Cube.fbx", "New-Sphere.fbx", "New-Capsule.fbx", "New-Cylinder.fbx", "New-Plane.fbx", "Quad.fbx", "Plane.fbx", "Sphere.fbx", "Capsule.fbx", "Cylinder.fbx" };
            if (!known.Contains(path)) return null;
            try { return Resources.GetBuiltinResource<T>(path); } catch { return null; }
        }

        static MonoScript MonoScriptFor(Type t)
        {
            if (t == null) return null;
            foreach (var ms in MonoImporter.GetAllRuntimeMonoScripts())
                if (ms != null && ms.GetClass() == t) return ms;
            return null;
        }

        static string ScriptLabel(string key)
        {
            if (key == null || !scripts.TryGetValue(key, out var so)) return "<unknown>";
            var s = (Dictionary<string, object>)so;
            var ns = (string)s["namespace"];
            return (string.IsNullOrEmpty(ns) ? "" : ns + ".") + s["class"] + " @ " + s["assembly"];
        }

        static Type ScriptType(string key)
        {
            if (key == null || !scripts.TryGetValue(key, out var so)) return null;
            var s = (Dictionary<string, object>)so;
            var ns = (string)s["namespace"];
            var full = (string.IsNullOrEmpty(ns) ? "" : ns + ".") + s["class"];
            var asm = ((string)s["assembly"]).Replace(".dll", "");
            var cacheKey = asm + "|" + full;
            if (typeCache.TryGetValue(cacheKey, out var cached)) return cached;
            Type found = null;
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var a in assemblies.Where(a => a.GetName().Name == asm).Concat(assemblies))
            {
                Type t = null;
                try { t = a.GetType(full, false); } catch { }
                if (t != null && typeof(Object).IsAssignableFrom(t)) { found = t; break; }
            }
            typeCache[cacheKey] = found;
            return found;
        }

        static Type UnityType(string name)
        {
            if (unityTypes == null)
            {
                unityTypes = new Dictionary<string, Type>();
                foreach (var a in AppDomain.CurrentDomain.GetAssemblies())
                {
                    var an = a.GetName().Name;
                    if (!an.StartsWith("UnityEngine")) continue;
                    Type[] types;
                    try { types = a.GetTypes(); } catch (ReflectionTypeLoadException e) { types = e.Types.Where(x => x != null).ToArray(); }
                    foreach (var t in types)
                        if (typeof(Object).IsAssignableFrom(t) && !unityTypes.ContainsKey(t.Name)) unityTypes[t.Name] = t;
                }
                if (unityTypes.TryGetValue("PhysicsMaterial", out var pm) && !unityTypes.ContainsKey("PhysicMaterial")) unityTypes["PhysicMaterial"] = pm;
                if (unityTypes.TryGetValue("PhysicMaterial", out var pm2) && !unityTypes.ContainsKey("PhysicsMaterial")) unityTypes["PhysicsMaterial"] = pm2;
            }
            return unityTypes.TryGetValue(name, out var r) ? r : null;
        }

        // ================================================================ utils
        static Dictionary<string, object> Dict(Dictionary<string, object> d, string k) =>
            d.TryGetValue(k, out var v) && v is Dictionary<string, object> r ? r : new Dictionary<string, object>();

        static float[] Floats(object o) => ((List<object>)o).Select(x => (float)Convert.ToDouble(x)).ToArray();

        static Vector3[] Vec3s(float[] f) => Enumerable.Range(0, f.Length / 3).Select(i => new Vector3(f[i * 3], f[i * 3 + 1], f[i * 3 + 2])).ToArray();

        static Vector2 V2(object o)
        {
            var l = (List<object>)o;
            return new Vector2((float)Convert.ToDouble(l[0]), (float)Convert.ToDouble(l[1]));
        }

        static Vector4 V4(object o)
        {
            var l = (List<object>)o;
            return new Vector4((float)Convert.ToDouble(l[0]), (float)Convert.ToDouble(l[1]), (float)Convert.ToDouble(l[2]), (float)Convert.ToDouble(l[3]));
        }

        static Rect RectFrom(object o)
        {
            var l = (List<object>)o;
            return new Rect((float)Convert.ToDouble(l[0]), (float)Convert.ToDouble(l[1]), (float)Convert.ToDouble(l[2]), (float)Convert.ToDouble(l[3]));
        }

        static void EnsureDir(string assetPath)
        {
            var dir = System.IO.Path.GetDirectoryName(assetPath);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
                AssetDatabase.Refresh();
            }
        }

        static void WriteReport()
        {
            report["missingScripts"] = missingScripts.Distinct().ToList();
            report["unknownComponentTypes"] = unknownTypes.Distinct().ToList();
            var unresolved = new Dictionary<string, int>();
            if (applier != null)
                foreach (var kv in applier.Unresolved)
                    if (!builtinUnmapped.Any(b => b.StartsWith(kv.Key + " "))) unresolved[kv.Key] = kv.Value;
            report["unresolvedReferences"] = unresolved;
            report["builtinUnmapped"] = builtinUnmapped.ToList();
            report["unsupportedProperties"] = applier != null ? applier.Unsupported : new Dictionary<string, int>();
            report["referencesAssigned"] = applier != null ? applier.Assigned : 0;
            report["notes"] = notes.Distinct().ToList();
            report["consoleErrors"] = logErrors;
            report["consoleWarnings"] = logWarnings;
            report["consoleErrorMessages"] = errorMessages;
            File.WriteAllText(ReportPath, MiniJson.Serialize(report));
            Debug.Log("[GameRebuild] report written to " + ReportPath);
        }
    }
}
