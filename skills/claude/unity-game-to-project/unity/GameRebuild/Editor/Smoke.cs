// Smoke checks for a rebuilt project.
//   Validate:    -executeMethod GameRebuild.Smoke.Validate     -> RebuildData/smoke_validate.json
//   BuildPlayer: -executeMethod GameRebuild.Smoke.BuildPlayer -buildPath <exe path>
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace GameRebuild
{
    public static class Smoke
    {
        [MenuItem("Tools/Game Rebuild/Validate Project")]
        public static void ValidateInteractive() => DoValidate();

        public static void Validate()
        {
            int problems = DoValidate();
            EditorApplication.Exit(problems == 0 ? 0 : 2);
        }

        static int DoValidate()
        {
            var result = new Dictionary<string, object>();
            var scenes = new List<object>();
            int problems = 0;
            result["compileFailed"] = EditorUtility.scriptCompilationFailed;
            if (EditorUtility.scriptCompilationFailed) problems++;

            foreach (var s in EditorBuildSettings.scenes)
            {
                var scene = EditorSceneManager.OpenScene(s.path, OpenSceneMode.Single);
                var stats = Inspect(scene.GetRootGameObjects());
                stats["path"] = s.path;
                problems += (int)stats["missingScripts"] + (int)stats["brokenRefs"];
                scenes.Add(stats);
            }
            result["scenes"] = scenes;

            var prefabs = new List<object>();
            foreach (var guid in AssetDatabase.FindAssets("t:Prefab", new[] { "Assets" }))
            {
                var path = AssetDatabase.GUIDToAssetPath(guid);
                var go = AssetDatabase.LoadAssetAtPath<GameObject>(path);
                if (go == null) continue;
                var stats = Inspect(new[] { go });
                if ((int)stats["missingScripts"] + (int)stats["brokenRefs"] == 0) continue;
                stats["path"] = path;
                problems += (int)stats["missingScripts"] + (int)stats["brokenRefs"];
                prefabs.Add(stats);
            }
            result["prefabsWithProblems"] = prefabs;
            result["problems"] = problems;
            Directory.CreateDirectory("RebuildData");
            File.WriteAllText("RebuildData/smoke_validate.json", MiniJson.Serialize(result));
            Debug.Log("[GameRebuild] validate: " + problems + " problem(s)");
            return problems;
        }

        static Dictionary<string, object> Inspect(IEnumerable<GameObject> roots)
        {
            int objects = 0, comps = 0, missing = 0, broken = 0, refs = 0;
            var brokenList = new List<object>();
            foreach (var r in roots)
                foreach (var t in r.GetComponentsInChildren<Transform>(true))
                {
                    objects++;
                    missing += GameObjectUtility.GetMonoBehavioursWithMissingScriptCount(t.gameObject);
                    foreach (var c in t.GetComponents<Component>())
                    {
                        if (c == null) continue;
                        comps++;
                        var it = new SerializedObject(c).GetIterator();
                        while (it.Next(true))
                        {
                            if (it.propertyType != SerializedPropertyType.ObjectReference) continue;
                            if (it.objectReferenceValue != null) refs++;
                            else if (it.objectReferenceInstanceIDValue != 0)
                            {
                                broken++;
                                if (brokenList.Count < 25) brokenList.Add($"{t.name}/{c.GetType().Name}.{it.propertyPath}");
                            }
                        }
                    }
                }
            return new Dictionary<string, object>
            {
                { "gameObjects", objects }, { "components", comps }, { "missingScripts", missing },
                { "brokenRefs", broken }, { "liveRefs", refs }, { "brokenList", brokenList },
            };
        }

        public static void BuildPlayer()
        {
            var args = Environment.GetCommandLineArgs();
            string path = null;
            for (int i = 0; i < args.Length - 1; i++) if (args[i] == "-buildPath") path = args[i + 1];
            path = path ?? Path.GetFullPath("Builds/Game.exe");
            var target = EditorUserBuildSettings.activeBuildTarget;
            var report = BuildPipeline.BuildPlayer(new BuildPlayerOptions
            {
                scenes = EditorBuildSettings.scenes.Where(s => s.enabled).Select(s => s.path).ToArray(),
                locationPathName = path,
                target = target,
                options = BuildOptions.None,
            });
            Debug.Log($"[GameRebuild] build {report.summary.result}: {path} ({report.summary.totalErrors} errors, {report.summary.totalSize / 1e6:0.0} MB)");
            EditorApplication.Exit(report.summary.result == UnityEditor.Build.Reporting.BuildResult.Succeeded ? 0 : 1);
        }
    }
}
