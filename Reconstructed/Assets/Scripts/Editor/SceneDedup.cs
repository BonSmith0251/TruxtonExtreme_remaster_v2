using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object=UnityEngine.Object;

// Finds GameObject subtrees that are copies of each other (same components, values, assets and child layout;
// only the root's name, placement and active flag differ), saves one prefab per group and swaps every copy for
// an instance of it. Smaller groups are done first, so bigger prefabs nest them. Copies that are referenced
// from outside themselves (scene overrides, other scripts) or reference outside themselves are left alone.
// After saving, the target is reloaded and every GameObject/component is compared with the original;
// on any difference the backup is restored.
//
// Batch: Unity.exe -batchmode -projectPath <p> -executeMethod SceneDedup.RunBatch
//   -dedupTargets "Assets/a.prefab;Assets/b.unity"  -dedupMode report|apply  -dedupReport <json>
//   [-dedupOutRoot <folder for new prefabs>] [-dedupBackup <folder>] [-dedupMinCount 2] [-dedupTolerance 0] [-dedupRemap 0|1]
// -dedupRemap 1: a copy referenced from elsewhere in the same target (a PlayableDirector's timeline bindings) is still
// replaced, and those references are re-pointed to the same object of the new instance. Referrers inside another copy
// keep the copy blocked (they may be swapped themselves).
// -dedupLibrary "Assets/A;Assets/B" [-dedupLibraryCache <json>]: existing prefabs (the game's own, flattened by the rip)
// whose content a subtree matches are used for it, even for a single copy, instead of a new prefab, so every target
// shares them. Library signatures are taken from the prefabs as they are (flat) and cached. A subtree whose values differ
// (the rip merged a nested instance's overrides and added components into it, e.g. layer 14 and an added script on the
// enemy meteors' model) matches by structure: child names in order, component types and the assets they use, the root's
// own components left out. Where several library prefabs match, the one named like the copy wins (else, for an exact
// match, the first outside Models/); a structural match with no name match is used only when it is the only one. Library copies are
// converted in place (PrefabUtility.ConvertToPrefabInstance): extra components become added-component overrides and the
// objects keep their identity, so references to them stay; copies inside a bigger library copy are left to that prefab.
public static class SceneDedup
{
    [Serializable] public class Occurrence{public string path,blocked;}
    [Serializable] public class Group{public string name,prefab,signature;public int count,replaceable,objectsEach,height;public string library;public bool bare,planned,applied,reused,redundant;public List<Occurrence> occurrences=new();}
    [Serializable] public class Stats{public int gameObjects,components,prefabInstances;public long fileBytes;}
    [Serializable] public class Report{public string target,mode,error,backup;public bool passed,digestMatch,restored;public Stats before,after;public int groupsFound,groupsPlanned,copiesPlanned,groupsApplied,copiesReplaced;public List<Group> groups=new();public List<string> digestMismatches=new();}
    [Serializable] class Batch{public List<Report> reports=new();}
    [Serializable] class Manifest{public List<Entry> entries=new();}
    [Serializable] class Entry{public string signature,prefab;}

    class Node{public GameObject go;public Node parent;public List<Node> children=new();public string key;public bool instanceRoot,insideInstance,heavy,pinned;public int height,size;public Group group;public string blocked,bare;public bool covered,refBlocked;public List<Node> referrers;}
    class Raw{public string hash,assets;public Object[] refs;}

    static readonly HashSet<string> Meta=new(){"m_ObjectHideFlags","m_CorrespondingSourceObject","m_PrefabInstance","m_PrefabAsset","m_GameObject","m_Father","m_Children","m_Component","m_RootOrder"};
    // Root-only values become instance overrides, so they are left out of the signature.
    static readonly HashSet<string> RootOnly=new(){"m_Name","m_IsActive","m_LocalPosition","m_LocalRotation","m_LocalScale","m_LocalEulerAnglesHint","m_ConstrainProportionsScale","m_AnchorMin","m_AnchorMax","m_AnchoredPosition","m_SizeDelta","m_Pivot"};

    static double tolerance;static int minCount=2;static bool remap,targetIsPrefab;
    static Dictionary<string,List<string>> library=new();
    static Node top;static Dictionary<int,(Node node,int component)> lookup;static Dictionary<(int,bool),Raw> raws;

    public static void RunBatch()
    {
        var args=Environment.GetCommandLineArgs();
        string Arg(string name,string fallback=null){int i=Array.IndexOf(args,name);return i>=0&&i+1<args.Length?args[i+1]:fallback;}
        var targets=(Arg("-dedupTargets")??"").Split(';').Select(s=>s.Trim()).Where(s=>s.Length>0).ToArray();
        bool apply=Arg("-dedupMode","report")=="apply";
        minCount=int.Parse(Arg("-dedupMinCount","2"));remap=Arg("-dedupRemap","0")=="1";tolerance=double.Parse(Arg("-dedupTolerance","0"),CultureInfo.InvariantCulture);
        LoadLibrary(Arg("-dedupLibrary"),Arg("-dedupLibraryCache"));
        var batch=new Batch();
        foreach(var target in targets)batch.reports.Add(Run(target,apply,Arg("-dedupOutRoot"),Arg("-dedupBackup")));
        var output=Arg("-dedupReport","scene-dedup-report.json");
        File.WriteAllText(output,JsonUtility.ToJson(batch,true));
        foreach(var r in batch.reports)Debug.Log($"[SceneDedup] {r.target}: {(r.passed?"PASS":"FAIL")} {r.mode}: groups planned {r.groupsPlanned}/{r.groupsFound} applied {r.groupsApplied}, copies {r.copiesReplaced}/{r.copiesPlanned}, objects {r.before?.gameObjects}->{r.after?.gameObjects??r.before?.gameObjects}, bytes {r.before?.fileBytes}->{r.after?.fileBytes??r.before?.fileBytes} {r.error}");
        EditorApplication.Exit(targets.Length>0&&batch.reports.All(r=>r.passed)?0:1);
    }

    // Renders every enabled camera of a scene at a few times (calling any public Seek(float) the scene's scripts
    // expose, with particles simulated from a fixed seed) and, with -dedupCompareWith, diffs against an earlier run.
    //   -executeMethod SceneDedup.RenderBatch -dedupRenderScene <scene> -dedupRenderOut <dir>
    //   [-dedupRenderTimes "0;30;90"] [-dedupCompareWith <dir of the before run>]
    [Serializable] class Frame{public string file;public float changedFraction;public int maxDifference;}
    [Serializable] class RenderReport{public bool passed;public string error;public List<Frame> frames=new();}
    public static void RenderBatch()
    {
        var args=Environment.GetCommandLineArgs();
        string Arg(string name,string fallback=null){int i=Array.IndexOf(args,name);return i>=0&&i+1<args.Length?args[i+1]:fallback;}
        var output=Arg("-dedupRenderOut","scene-dedup-render");var before=Arg("-dedupCompareWith");var report=new RenderReport();
        try
        {
            Directory.CreateDirectory(output);
            EditorSceneManager.OpenScene(Arg("-dedupRenderScene"),OpenSceneMode.Single);
            var seekers=Object.FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.InstanceID).Select(m=>(m,method:m.GetType().GetMethod("Seek",new[]{typeof(float)}))).Where(x=>x.method!=null).ToList();
            foreach(var time in Arg("-dedupRenderTimes","0;30;90;180").Split(';').Select(s=>float.Parse(s,CultureInfo.InvariantCulture)))
            {
                foreach(var s in seekers)s.method.Invoke(s.m,new object[]{time});
                foreach(var ps in Object.FindObjectsByType<ParticleSystem>(FindObjectsSortMode.InstanceID)){ps.Stop(false,ParticleSystemStopBehavior.StopEmittingAndClear);ps.useAutoRandomSeed=false;ps.randomSeed=1;ps.Simulate(3,false,true,true);}
                var cameras=Camera.allCameras.OrderBy(c=>c.depth).ToArray();
                for(int i=0;i<cameras.Length;i++)
                {
                    var rt=new RenderTexture(1280,720,24,RenderTextureFormat.ARGB32);rt.Create();var previous=cameras[i].targetTexture;
                    cameras[i].targetTexture=rt;cameras[i].Render();cameras[i].targetTexture=previous;
                    RenderTexture.active=rt;var image=new Texture2D(1280,720,TextureFormat.RGBA32,false);image.ReadPixels(new Rect(0,0,1280,720),0,0);image.Apply();RenderTexture.active=null;
                    var file=$"t{time:000}_cam{i}_{string.Concat(cameras[i].name.Select(ch=>char.IsLetterOrDigit(ch)?ch:'_'))}.png";
                    File.WriteAllBytes(Path.Combine(output,file),image.EncodeToPNG());
                    var frame=new Frame{file=file};report.frames.Add(frame);
                    if(before!=null)
                    {
                        var old=new Texture2D(2,2);old.LoadImage(File.ReadAllBytes(Path.Combine(before,file)));
                        var a=old.GetPixels32();var b=image.GetPixels32();int changed=0;
                        for(int p=0;p<a.Length;p++){int d=Mathf.Max(Mathf.Abs(a[p].r-b[p].r),Mathf.Abs(a[p].g-b[p].g),Mathf.Abs(a[p].b-b[p].b));frame.maxDifference=Mathf.Max(frame.maxDifference,d);if(d>8)changed++;}
                        frame.changedFraction=changed/(float)a.Length;Object.DestroyImmediate(old);
                    }
                    rt.Release();Object.DestroyImmediate(rt);Object.DestroyImmediate(image);
                }
            }
            report.passed=before==null||report.frames.All(f=>f.changedFraction<.001f);
        }
        catch(Exception e){report.error=e.Message;Debug.LogException(e);}
        File.WriteAllText(Path.Combine(output,"render-report.json"),JsonUtility.ToJson(report,true));
        Debug.Log($"[SceneDedup] render {(report.passed?"PASS":"FAIL")} {report.frames.Count} frames, worst changed {(report.frames.Count>0?report.frames.Max(f=>f.changedFraction):0):P3} {report.error}");
        EditorApplication.Exit(report.passed?0:1);
    }

    [MenuItem("Tools/Scene Dedup/Report Selected Prefab or Open Scene")] static void MenuReport()=>Menu(false);
    [MenuItem("Tools/Scene Dedup/Apply To Selected Prefab or Open Scene")] static void MenuApply()=>Menu(true);
    static void Menu(bool apply)
    {
        var path=Selection.activeObject?AssetDatabase.GetAssetPath(Selection.activeObject):"";
        if(!path.EndsWith(".prefab"))path=SceneManager.GetActiveScene().path;
        if(apply&&!EditorUtility.DisplayDialog("Scene Dedup","Replace duplicated objects in "+path+" with prefab instances? A backup is made first.","Apply","Cancel"))return;
        var r=Run(path,apply,null,null);File.WriteAllText("scene-dedup-report.json",JsonUtility.ToJson(r,true));
        Debug.Log($"[SceneDedup] {path}: {(r.passed?"PASS":"FAIL")} groups {r.groupsApplied}/{r.groupsFound}, copies replaced {r.copiesReplaced} {r.error} (scene-dedup-report.json)");
    }

    public static Report Run(string path,bool apply,string outRoot,string backupRoot)
    {
        var report=new Report{target=path,mode=apply?"apply":"report"};
        bool isPrefab=path.EndsWith(".prefab");GameObject contents=null;targetIsPrefab=isPrefab;
        try
        {
            if(!File.Exists(path))throw new Exception("target not found");
            report.before=Load(path,isPrefab,ref contents);
            var digestBefore=Digest();
            var nodes=All(top).ToList();
            Pin(path,isPrefab,nodes);
            var groups=FindGroups(nodes,report);
            if(!apply){report.passed=true;return report;}
            if(groups.Count==0){report.passed=true;report.digestMatch=true;report.after=report.before;return report;}

            report.backup=Backup(path,backupRoot);
            outRoot??=Path.Combine(Path.GetDirectoryName(path),"Dedup",Path.GetFileNameWithoutExtension(path)).Replace('\\','/');
            Directory.CreateDirectory(outRoot);
            var manifestPath=Path.Combine(outRoot,"dedup-manifest.json");
            var manifest=File.Exists(manifestPath)?JsonUtility.FromJson<Manifest>(File.ReadAllText(manifestPath)):new Manifest();
            foreach(var g in groups.OrderBy(g=>g.height))
            {
                var copies=nodes.Where(n=>n.group==g&&n.blocked==null&&!n.covered).ToList();
                GameObject asset;
                if(g.library!=null){asset=AssetDatabase.LoadAssetAtPath<GameObject>(g.library);g.prefab=g.library;g.reused=true;if(!asset)throw new Exception("library prefab missing: "+g.library);}
                else
                {
                    var entry=manifest.entries.Find(e=>e.signature==g.signature&&File.Exists(e.prefab));
                    if(entry!=null){asset=AssetDatabase.LoadAssetAtPath<GameObject>(entry.prefab);g.reused=true;}
                    else
                    {
                        var file=Unique(outRoot,g.name);
                        asset=SaveNormalized(copies[0].go,file);
                        manifest.entries.Add(entry=new Entry{signature=g.signature,prefab=file});
                    }
                    g.prefab=entry.prefab;
                }
                if(g.library!=null)foreach(var c in copies){Convert(c.go,asset,c.referrers);report.copiesReplaced++;}
                else foreach(var c in copies){Swap(c.go,asset,c.referrers);report.copiesReplaced++;}
                g.applied=true;report.groupsApplied++;
            }
            File.WriteAllText(manifestPath,JsonUtility.ToJson(manifest,true));
            Save(path,isPrefab,ref contents);
            AssetDatabase.Refresh();

            report.after=Load(path,isPrefab,ref contents);
            var digestAfter=Digest();
            foreach(var k in digestBefore.Keys.Union(digestAfter.Keys))
            {
                digestBefore.TryGetValue(k,out var a);digestAfter.TryGetValue(k,out var b);
                if(a!=b&&report.digestMismatches.Count<40)report.digestMismatches.Add(k+(a==null?" (added)":b==null?" (missing)":" (changed)"+(DebugValues?" "+FirstDifference(a,b):"")));
            }
            report.digestMatch=report.digestMismatches.Count==0;
            if(!report.digestMatch)
            {
                Close(isPrefab,ref contents);Restore(path,report.backup);report.restored=true;
                throw new Exception("flattened result differs from the original; restored the backup");
            }
            report.passed=true;
        }
        catch(Exception e){report.error=e.Message;Debug.LogException(e);}
        finally{Close(isPrefab,ref contents);}
        return report;
    }

    // ---------- loading and the node tree ----------

    static Stats Load(string path,bool isPrefab,ref GameObject contents)
    {
        Close(isPrefab,ref contents);
        GameObject[] roots;
        if(isPrefab){contents=PrefabUtility.LoadPrefabContents(path);roots=new[]{contents};}
        else roots=EditorSceneManager.OpenScene(path,OpenSceneMode.Single).GetRootGameObjects();
        lookup=new();raws=new();
        top=new Node{key="",children=new()};
        for(int i=0;i<roots.Length;i++)if((roots[i].hideFlags&HideFlags.DontSave)==0)top.children.Add(Build(roots[i],top,i.ToString(),isPrefab&&i==0));
        top.size=top.children.Sum(c=>c.size);
        var stats=new Stats{fileBytes=new FileInfo(path).Length};
        foreach(var n in All(top)){stats.gameObjects++;stats.components+=n.go.GetComponents<Component>().Length;if(n.instanceRoot)stats.prefabInstances++;}
        return stats;
    }

    static Node Build(GameObject go,Node parent,string key,bool prefabRoot)
    {
        var n=new Node{go=go,parent=parent,key=key};
        n.insideInstance=parent.instanceRoot||parent.insideInstance;
        n.instanceRoot=!prefabRoot&&!n.insideInstance&&PrefabUtility.IsAnyPrefabInstanceRoot(go);
        lookup[go.GetInstanceID()]=(n,-1);
        var comps=go.GetComponents<Component>();
        for(int i=0;i<comps.Length;i++)if(comps[i])lookup[comps[i].GetInstanceID()]=(n,i);
        for(int i=0;i<go.transform.childCount;i++)
        {
            var child=go.transform.GetChild(i).gameObject;
            if((child.hideFlags&HideFlags.DontSave)==0)n.children.Add(Build(child,n,key+"/"+i,false));
        }
        n.size=1+n.children.Sum(c=>c.size);n.height=n.children.Count==0?0:1+n.children.Max(c=>c.height);
        n.heavy=n.instanceRoot||comps.Any(c=>c&&!(c is Transform))||n.children.Any(c=>c.heavy);
        return n;
    }

    static IEnumerable<Node> All(Node n){foreach(var c in n.children){yield return c;foreach(var d in All(c))yield return d;}}
    static bool Within(Node n,Node root){for(;n!=null;n=n.parent)if(n==root)return true;return false;}
    static Component[] Comps(Node n)=>n.go.GetComponents<Component>().Where(c=>c).ToArray();

    static void Close(bool isPrefab,ref GameObject contents){if(isPrefab&&contents){PrefabUtility.UnloadPrefabContents(contents);}contents=null;}
    static void Save(string path,bool isPrefab,ref GameObject contents)
    {
        if(isPrefab){PrefabUtility.SaveAsPrefabAsset(contents,path,out bool ok);if(!ok)throw new Exception("could not save "+path);}
        else if(!EditorSceneManager.SaveScene(SceneManager.GetActiveScene()))throw new Exception("could not save "+path);
    }

    // ---------- serialized values ----------

    static Raw RawOf(Object o,bool asRoot)
    {
        if(raws.TryGetValue((o.GetInstanceID(),asRoot),out var cached))return cached;
        var sb=new StringBuilder(o.GetType().FullName);var refs=new List<Object>();var assets=new StringBuilder();
        var so=new SerializedObject(o);var p=so.GetIterator();bool enter=true;
        while(p.Next(enter))
        {
            enter=true;
            if(p.depth==0&&(Meta.Contains(p.name)||asRoot&&RootOnly.Contains(p.name))){enter=false;continue;}
            sb.Append('|').Append(p.propertyPath).Append('=');
            switch(p.propertyType)
            {
                case SerializedPropertyType.Float:sb.Append(Num(p.doubleValue));break;
                case SerializedPropertyType.Integer:sb.Append(p.longValue);break;
                case SerializedPropertyType.Boolean:sb.Append(p.boolValue?1:0);break;
                case SerializedPropertyType.Enum:case SerializedPropertyType.LayerMask:case SerializedPropertyType.ArraySize:case SerializedPropertyType.Character:sb.Append(p.intValue);break;
                case SerializedPropertyType.String:sb.Append(p.stringValue);enter=false;break;
                case SerializedPropertyType.AnimationCurve:Curve(sb,p.animationCurveValue);enter=false;break;
                case SerializedPropertyType.Gradient:var gr=p.gradientValue;if(gr!=null){sb.Append((int)gr.mode);foreach(var k in gr.colorKeys)sb.Append(',').Append(Num(k.time)).Append(' ').Append(Num(k.color.r)).Append(' ').Append(Num(k.color.g)).Append(' ').Append(Num(k.color.b));foreach(var k in gr.alphaKeys)sb.Append(',').Append(Num(k.time)).Append(Num(k.alpha));}enter=false;break;
                case SerializedPropertyType.Hash128:sb.Append(p.hash128Value);break;
                case SerializedPropertyType.ObjectReference:
                    var r=p.objectReferenceValue;
                    if(!r)sb.Append(p.objectReferenceInstanceIDValue!=0?"missing":"null");
                    else if(EditorUtility.IsPersistent(r)){AssetDatabase.TryGetGUIDAndLocalFileIdentifier(r,out string guid,out long id);sb.Append("A:").Append(guid).Append(':').Append(id);assets.Append(guid).Append(':').Append(id).Append(',');}
                    else{sb.Append('\u0001').Append(refs.Count);refs.Add(r);}
                    enter=false;break;
            }
        }
        return raws[(o.GetInstanceID(),asRoot)]=new Raw{hash=DebugValues?sb.ToString():Hash(sb.ToString()),assets=assets.ToString(),refs=refs.ToArray()};
    }

    static string Num(double v)=>tolerance>0?Math.Round(v/tolerance).ToString(CultureInfo.InvariantCulture):v.ToString("R",CultureInfo.InvariantCulture);
    static void Curve(StringBuilder sb,AnimationCurve c){if(c==null)return;sb.Append((int)c.preWrapMode).Append((int)c.postWrapMode);foreach(var k in c.keys)sb.Append(',').Append(Num(k.time)).Append(' ').Append(Num(k.value)).Append(' ').Append(Num(k.inTangent)).Append(' ').Append(Num(k.outTangent)).Append(' ').Append(Num(k.inWeight)).Append(' ').Append(Num(k.outWeight)).Append(' ').Append((int)k.weightedMode);}
    static string Hash(string s){using var sha=SHA1.Create();return BitConverter.ToString(sha.ComputeHash(Encoding.UTF8.GetBytes(s))).Replace("-","").Substring(0,20);}

    // A scene-object reference written relative to root when it points inside it; otherwise marks the walk as outbound.
    static string Ref(Object r,Node root,ref bool outbound)
    {
        if(!r||!lookup.TryGetValue(r.GetInstanceID(),out var t)){outbound=true;return "X?";}
        if(root!=null&&Within(t.node,root))return "L:"+t.node.key.Substring(root.key.Length)+"#"+t.component;
        outbound=true;return "X:"+t.node.key+"#"+t.component;
    }

    static void AppendObject(StringBuilder sb,Object o,bool asRoot,Node root,ref bool outbound)
    {
        var raw=RawOf(o,asRoot);sb.Append(raw.hash);
        foreach(var r in raw.refs)sb.Append(';').Append(Ref(r,root,ref outbound));
    }

    // An existing prefab instance counts as one unit: its source prefab plus its overrides.
    static void AppendInstance(StringBuilder sb,Node n,bool asRoot,Node root,ref bool outbound)
    {
        var go=n.go;sb.Append("PI:").Append(AssetDatabase.AssetPathToGUID(PrefabUtility.GetPrefabAssetPathOfNearestInstanceRoot(go)));
        var rootSources=new HashSet<Object>{PrefabUtility.GetCorrespondingObjectFromSource(go),PrefabUtility.GetCorrespondingObjectFromSource(go.transform)};
        var mods=PrefabUtility.GetPropertyModifications(go)??new PropertyModification[0];
        foreach(var m in mods.Where(m=>m.target).Select(m=>{AssetDatabase.TryGetGUIDAndLocalFileIdentifier(m.target,out string g,out long id);return (m,id);}).OrderBy(x=>x.id).ThenBy(x=>x.m.propertyPath,StringComparer.Ordinal))
        {
            var head=m.m.propertyPath.Split('.')[0];
            if(head=="m_RootOrder"||asRoot&&rootSources.Contains(m.m.target)&&RootOnly.Contains(head))continue;
            sb.Append('|').Append(m.id).Append(':').Append(m.m.propertyPath).Append('=').Append(m.m.value);
            var r=m.m.objectReference;
            if(r){if(EditorUtility.IsPersistent(r)){AssetDatabase.TryGetGUIDAndLocalFileIdentifier(r,out string g,out long id);sb.Append("A:").Append(g).Append(':').Append(id);}else sb.Append(Ref(r,root,ref outbound));}
        }
        if(PrefabUtility.GetAddedGameObjects(go).Count+PrefabUtility.GetAddedComponents(go).Count+PrefabUtility.GetRemovedComponents(go).Count+PrefabUtility.GetRemovedGameObjects(go).Count>0)
            sb.Append("|structural:").Append(go.GetInstanceID());
    }

    static void Walk(StringBuilder sb,Node n,Node root,bool asRoot,ref bool outbound)
    {
        sb.Append('(');
        if(n.instanceRoot)AppendInstance(sb,n,asRoot,root,ref outbound);
        else
        {
            AppendObject(sb,n.go,asRoot,root,ref outbound);
            foreach(var c in Comps(n))AppendObject(sb,c,asRoot,root,ref outbound);
            foreach(var c in n.children)Walk(sb,c,root,false,ref outbound);
        }
        sb.Append(')');
    }

    static string Signature(Node n,out bool outbound){var sb=new StringBuilder();outbound=false;Walk(sb,n,n,true,ref outbound);return Hash(sb.ToString());}
    // Structure only: child names, component types and what renderers draw (meshes, materials); the root's own components
    // left out. Other references (an Animator's controller the stage timeline replaced) are left to the overrides.
    static string LooseSignature(Node n){var sb=new StringBuilder();LooseWalk(sb,n,true);return "L:"+Hash(sb.ToString());}
    static void LooseWalk(StringBuilder sb,Node n,bool asRoot)
    {
        sb.Append('(');
        if(n.instanceRoot)sb.Append("PI:").Append(AssetDatabase.AssetPathToGUID(PrefabUtility.GetPrefabAssetPathOfNearestInstanceRoot(n.go)));
        else
        {
            if(!asRoot)sb.Append(n.go.name);
            foreach(var c in Comps(n))if(!asRoot||c is Transform)sb.Append('|').Append(c.GetType().FullName).Append('=').Append(c is Renderer||c is MeshFilter?RawOf(c,false).assets:"");
            foreach(var c in n.children)LooseWalk(sb,c,false);
        }
        sb.Append(')');
    }

    // Everything about every GameObject and component, instance or not, keyed by hierarchy position.
    static Dictionary<string,string> Digest()
    {
        var d=new Dictionary<string,string>();bool unused=false;
        foreach(var n in All(top))
        {
            var sb=new StringBuilder(n.go.name);AppendObject(sb,n.go,false,top,ref unused);d[n.key]=sb.ToString();
            var comps=Comps(n);
            for(int i=0;i<comps.Length;i++){sb.Clear();AppendObject(sb,comps[i],false,top,ref unused);d[n.key+"#"+i]=sb.ToString();}
        }
        return d;
    }

    // ---------- grouping ----------

    // Objects other files point at (scene overrides, stripped references) keep their file IDs, so copies holding them stay put.
    static void Pin(string path,bool isPrefab,List<Node> nodes)
    {
        if(!isPrefab)return;
        var guid=AssetDatabase.AssetPathToGUID(path);
        var ids=new HashSet<long>();var rx=new Regex(@"fileID: (-?\d+), guid: "+guid);
        foreach(var file in Directory.EnumerateFiles("Assets","*.*",SearchOption.AllDirectories).Where(f=>Regex.IsMatch(f,@"\.(unity|prefab|asset|controller|overrideController|playable|anim)$")))
        {
            if(Path.GetFullPath(file)==Path.GetFullPath(path))continue;
            string text;try{text=File.ReadAllText(file);}catch{continue;}
            if(!text.Contains(guid))continue;
            foreach(Match m in rx.Matches(text))ids.Add(long.Parse(m.Groups[1].Value));
        }
        if(ids.Count==0)return;
        var byKey=nodes.ToDictionary(n=>n.key);
        foreach(var o in AssetDatabase.LoadAllAssetsAtPath(path))
        {
            if(!AssetDatabase.TryGetGUIDAndLocalFileIdentifier(o,out string g,out long id)||!ids.Contains(id))continue;
            var t=o is GameObject go?go.transform:o is Component c?c.transform:null;if(!t)continue;
            var key="";for(;t.parent;t=t.parent)key="/"+t.GetSiblingIndex()+key;key="0"+key;
            if(byKey.TryGetValue(key,out var n))n.pinned=true;
        }
    }

    static List<Group> FindGroups(List<Node> nodes,Report report)
    {
        // Who points at whom inside the target, so a copy referenced from outside itself can be kept.
        var referrers=new Dictionary<Node,List<Node>>();
        foreach(var n in nodes.Where(n=>!n.insideInstance))
        {
            var sources=n.instanceRoot?new Object[0]:new Object[]{n.go}.Concat(Comps(n));
            foreach(var o in sources)foreach(var r in RawOf(o,false).refs)
                if(r&&lookup.TryGetValue(r.GetInstanceID(),out var t)&&t.node!=n)(referrers.TryGetValue(t.node,out var l)?l:referrers[t.node]=new()).Add(n);
            if(n.instanceRoot)foreach(var m in PrefabUtility.GetPropertyModifications(n.go)??new PropertyModification[0])
                if(m.objectReference&&!EditorUtility.IsPersistent(m.objectReference)&&lookup.TryGetValue(m.objectReference.GetInstanceID(),out var t)&&!Within(t.node,n))(referrers.TryGetValue(t.node,out var l)?l:referrers[t.node]=new()).Add(n);
        }

        var bySig=new Dictionary<string,List<Node>>();
        // A prefab target's own root can't become an instance.
        foreach(var n in nodes.Where(n=>!n.instanceRoot&&!n.insideInstance&&n.heavy&&!(targetIsPrefab&&n.parent==top)))
        {
            var sig=Signature(n,out bool outbound);
            if(outbound)n.blocked="references objects outside itself";
            else
            {
                var inside=new[]{n}.Concat(All(n)).ToList();
                if(inside.Any(x=>x.pinned))n.blocked="referenced by another asset (scene override or stripped reference)";
                else
                {
                    var outside=inside.SelectMany(x=>referrers.TryGetValue(x,out var l)?l:new List<Node>()).Where(s=>!Within(s,n)).Distinct().ToList();
                    if(outside.Count>0){n.referrers=outside;if(!remap){n.blocked="referenced by "+outside[0].go.name;n.refBlocked=true;}}
                }
            }
            if(library.Count>0&&!outbound&&!library.ContainsKey(sig)){var loose=LooseSignature(n);if(Pick(loose,n.go.name,false)!=null)n.bare=loose;}
            (bySig.TryGetValue(sig,out var list)?list:bySig[sig]=new()).Add(n);
        }
        // A referrer inside a repeated subtree may be swapped away itself, so its target stays put.
        bool Library(KeyValuePair<string,List<Node>> kv)=>library.ContainsKey(kv.Key)||kv.Value[0].bare!=null;
        var repeated=new HashSet<Node>(bySig.Where(kv=>kv.Value.Count>=2||Library(kv)).SelectMany(kv=>kv.Value));
        foreach(var n in nodes.Where(n=>n.referrers!=null&&n.blocked==null))
        {
            var r=n.referrers.FirstOrDefault(s=>{for(var a=s;a!=null;a=a.parent)if(repeated.Contains(a))return true;return false;});
            if(r!=null){n.blocked="referenced by "+r.go.name+" (inside a copy)";n.refBlocked=true;}
        }

        var groups=new List<Group>();
        foreach(var kv in bySig.Where(kv=>kv.Value.Count>=2||Library(kv)))
        {
            var first=kv.Value[0];
            var exact=Pick(kv.Key,first.go.name,true);var lib=exact??(first.bare!=null?Pick(first.bare,first.go.name,false):null);
            if(lib!=null&&!Fits(first.go.transform,AssetDatabase.LoadAssetAtPath<GameObject>(lib)?.transform,true)){lib=null;exact=null;}
            // Converted in place, a library copy keeps its objects: references into it from the target stay valid.
            if(lib!=null)foreach(var n in kv.Value)if(n.refBlocked){n.blocked=null;n.refBlocked=false;}
            var g=new Group{signature=kv.Key,library=lib,bare=exact==null&&first.bare!=null,count=kv.Value.Count,replaceable=kv.Value.Count(n=>n.blocked==null),objectsEach=first.size,height=first.height,name=BaseName(kv.Value)};
            foreach(var n in kv.Value){n.group=g;g.occurrences.Add(new Occurrence{path=PathOf(n),blocked=n.blocked});}
            groups.Add(g);
        }
        report.groupsFound=groups.Count;

        // Biggest first: a group that only ever appears once inside every copy of one bigger kept group adds nothing.
        var kept=new HashSet<Node>();var chosen=new List<Group>();
        foreach(var g in groups.Where(g=>g.replaceable>=(g.library!=null?1:minCount)).OrderByDescending(g=>g.height).ThenByDescending(g=>g.objectsEach))
        {
            var copies=nodes.Where(n=>n.group==g&&n.blocked==null&&!n.covered).ToList();
            if(copies.Count==0){g.redundant=true;continue;}
            var owners=copies.Select(n=>{var a=n.parent;while(a!=null&&!kept.Contains(a))a=a.parent;return a;}).ToList();
            var owner=owners[0]?.group;
            bool redundant=owners.All(a=>a!=null&&a.group==owner)&&owners.Distinct().Count()==copies.Count&&copies.Count==owner.replaceable;
            // A library prefab inside a new prefab is still shared (it nests); inside a library prefab it is already there.
            if(redundant&&g.library!=null&&owner.library==null)redundant=false;
            if(redundant){g.redundant=true;continue;}
            foreach(var n in copies)kept.Add(n);chosen.Add(g);g.planned=true;
            if(g.library!=null)foreach(var n in copies)foreach(var d in All(n))d.covered=true;
        }
        report.groupsPlanned=chosen.Count;report.copiesPlanned=chosen.Sum(g=>nodes.Count(n=>n.group==g&&n.blocked==null&&!n.covered));
        report.groups=groups.OrderByDescending(g=>g.count*g.objectsEach).ToList();
        return chosen;
    }

    // Signature -> prefab for every prefab under the library folders, read flat as they are; cached as a manifest.
    static void LoadLibrary(string folders,string cache)
    {
        library.Clear();if(string.IsNullOrEmpty(folders))return;
        if(!string.IsNullOrEmpty(cache)&&File.Exists(cache)){foreach(var e in JsonUtility.FromJson<Manifest>(File.ReadAllText(cache)).entries)Add(e.signature,e.prefab);return;}
        var manifest=new Manifest();
        var paths=folders.Split(';').Select(f=>f.Trim()).Where(f=>f.Length>0).SelectMany(f=>Directory.EnumerateFiles(f,"*.prefab",SearchOption.AllDirectories)).Select(p=>p.Replace('\\','/')).OrderBy(p=>p,StringComparer.Ordinal).ToList();
        foreach(var path in paths)
        {
            GameObject root=null;
            try
            {
                root=PrefabUtility.LoadPrefabContents(path);
                lookup=new();raws=new();top=new Node{key="",children=new()};
                var n=Build(root,top,"0",true);top.children.Add(n);
                if(!n.heavy)continue;
                var sig=Signature(n,out bool outbound);
                if(outbound)continue;
                foreach(var key in new[]{sig,LooseSignature(n)}){Add(key,path);manifest.entries.Add(new Entry{signature=key,prefab=path});}
            }
            catch(Exception e){Debug.LogWarning("[SceneDedup] library skips "+path+": "+e.Message);}
            finally{if(root)PrefabUtility.UnloadPrefabContents(root);}
        }
        if(!string.IsNullOrEmpty(cache)){Directory.CreateDirectory(Path.GetDirectoryName(Path.GetFullPath(cache)));File.WriteAllText(cache,JsonUtility.ToJson(manifest,true));}
        Debug.Log("[SceneDedup] library: "+library.Count(kv=>!kv.Key.StartsWith("L:"))+" contents, "+library.Count(kv=>kv.Key.StartsWith("L:"))+" structures, of "+paths.Count+" prefabs");
    }

    // A library prefab can stand in for a copy only with the same components in the same order on every object (the
    // copy's root may add some after the prefab's): the conversion keeps the copy's components by index.
    static bool Fits(Transform copy,Transform prefab,bool isRoot)
    {
        if(!prefab||copy.childCount!=prefab.childCount)return false;
        var a=copy.GetComponents<Component>();var b=prefab.GetComponents<Component>();
        if(isRoot?b.Length>a.Length:b.Length!=a.Length)return false;
        for(int i=0;i<b.Length;i++)if(!a[i]||!b[i]||a[i].GetType()!=b[i].GetType())return false;
        for(int i=0;i<copy.childCount;i++)if(!Fits(copy.GetChild(i),prefab.GetChild(i),false))return false;
        return true;
    }

    static void Add(string key,string path){if(!library.TryGetValue(key,out var l))library[key]=l=new();if(!l.Contains(path))l.Add(path);}
    static string Pick(string key,string copyName,bool exact)
    {
        if(!library.TryGetValue(key,out var l))return null;
        var name=Regex.Replace(copyName,@"\s*\(\d+\)$","");
        var named=l.FirstOrDefault(x=>Path.GetFileNameWithoutExtension(x)==name);if(named!=null)return named;
        if(!exact)return l.Count==1?l[0]:null;
        return l.FirstOrDefault(x=>!x.Contains("/Models/"))??l[0];
    }

    // SCENE_DEDUP_DEBUG=1: keep readable values instead of hashes so a digest mismatch names the property that differs.
    static readonly bool DebugValues=Environment.GetEnvironmentVariable("SCENE_DEDUP_DEBUG")=="1";
    static string FirstDifference(string a,string b)
    {
        int i=0;while(i<a.Length&&i<b.Length&&a[i]==b[i])i++;int from=Math.Max(0,a.LastIndexOf('|',Math.Max(0,Math.Min(i,a.Length-1))));
        string Cut(string s)=>from<s.Length?s.Substring(from,Math.Min(160,s.Length-from)):"";
        return "before ["+Cut(a)+"] after ["+Cut(b)+"]";
    }

    static string PathOf(Node n){var s=n.go.name;for(var p=n.parent;p!=null&&p.go;p=p.parent)s=p.go.name+"/"+s;return s;}

    static string BaseName(List<Node> copies)
    {
        var names=copies.Select(n=>Regex.Replace(n.go.name,@"\s*\(\d+\)$","")).Distinct().ToList();
        var name=names.Count==1?names[0]:Regex.Replace(names[0],@"[_\s-]*\d+$","");
        name=string.Concat(name.Select(ch=>Path.GetInvalidFileNameChars().Contains(ch)?'_':ch)).Trim();
        return name.Length>0?name:"dedup";
    }

    // ---------- applying ----------

    static string Unique(string folder,string name)
    {
        var file=$"{folder}/{name}.prefab";
        for(int i=2;File.Exists(file);i++)file=$"{folder}/{name}__{i}.prefab";
        return file;
    }

    // New prefab roots sit at the origin, active, named after the group; each instance carries its own placement.
    // The source copy is normalized in place for one save and put back (Swap copies its own values to the instance).
    // Saving first and re-saving to normalize made the fresh prefab's second import crash natively in
    // WriteCachedMetaData (CachedWriter::Write) on the BG04/BG07/BG08 stages.
    static GameObject SaveNormalized(GameObject source,string file)
    {
        var t=source.transform;bool rect=t is RectTransform;
        string name=source.name;bool active=source.activeSelf;var position=t.localPosition;var rotation=t.localRotation;
        source.name=Path.GetFileNameWithoutExtension(file);source.SetActive(true);
        if(!rect){t.localPosition=Vector3.zero;t.localRotation=Quaternion.identity;}
        try
        {
            var asset=PrefabUtility.SaveAsPrefabAsset(source,file,out bool saved);
            if(!saved||!asset)throw new Exception("could not save "+file);
            return asset;
        }
        finally{source.name=name;source.SetActive(active);if(!rect){t.localPosition=position;t.localRotation=rotation;}}
    }

    // In place: the copy's objects become the instance's; what the prefab lacks becomes overrides. ConvertToPrefabInstance
    // alone is not exact: it skips GameObject values (the stages put every object on layer 30), does not record a reference
    // set to none (Animators whose controller the stage timeline replaced), can pair same-named children differently and
    // does not keep every object. So the copy is duplicated first, and afterwards every GameObject and component value is
    // set back from the duplicate as an override, matched by place under the copy (path, component index); references into
    // the copy, from the copy's referrers and from inside it, follow the objects by their old instance ids.
    static void Convert(GameObject copy,GameObject asset,List<Node> referrers)
    {
        var parent=copy.transform.parent;int index=copy.transform.GetSiblingIndex();
        var paths=new List<int[]>();var oldIds=new Dictionary<int,(int[] path,int component)>();
        void Note(Transform t,List<int> path)
        {
            var p=path.ToArray();paths.Add(p);oldIds[t.gameObject.GetInstanceID()]=(p,-1);
            var cs=t.GetComponents<Component>();for(int i=0;i<cs.Length;i++)if(cs[i])oldIds[cs[i].GetInstanceID()]=(p,i);
            for(int i=0;i<t.childCount;i++){path.Add(i);Note(t.GetChild(i),path);path.RemoveAt(path.Count-1);}
        }
        Note(copy.transform,new List<int>());
        var dup=Object.Instantiate(copy);dup.name=copy.name;dup.hideFlags=HideFlags.HideAndDontSave;
        try
        {
            var settings=new ConvertToPrefabInstanceSettings{componentsNotMatchedBecomesOverride=true,gameObjectsNotMatchedBecomesOverride=true,
                recordPropertyOverridesOfMatches=true,changeRootNameToAssetName=false,objectMatchMode=ObjectMatchMode.ByHierarchy,logInfo=false};
            PrefabUtility.ConvertToPrefabInstance(copy,asset,settings,InteractionMode.AutomatedAction);
            var root=copy?copy.transform:parent?parent.GetChild(index):null;
            if(!root||!PrefabUtility.IsAnyPrefabInstanceRoot(root.gameObject))throw new Exception("could not convert "+copy.name+" to "+AssetDatabase.GetAssetPath(asset));
            Transform At(Transform t,int[] path){foreach(var i in path)t=t&&i<t.childCount?t.GetChild(i):null;return t;}
            Object Resolve((int[] path,int component) at)
            {
                var t=At(root,at.path);if(!t)return null;if(at.component<0)return t.gameObject;
                var cs=t.GetComponents<Component>();return at.component<cs.Length?cs[at.component]:null;
            }
            // Duplicate's objects -> the converted ones, for references inside the copy.
            var fromDup=new Dictionary<Object,Object>();
            foreach(var p in paths)
            {
                var a=At(dup.transform,p);var b=At(root,p);if(!a||!b)throw new Exception("lost "+string.Join("/",p)+" converting "+root.name);
                fromDup[a.gameObject]=b.gameObject;var ca=a.GetComponents<Component>();var cb=b.GetComponents<Component>();
                if(ca.Length!=cb.Length)throw new Exception("component count changed at "+b.name+" converting "+root.name);
                for(int i=0;i<ca.Length;i++)if(ca[i]&&cb[i])fromDup[ca[i]]=cb[i];
            }
            foreach(var p in paths)
            {
                var a=At(dup.transform,p);var b=At(root,p);
                bool isRoot=p.Length==0;
                CopyValues(a.gameObject,b.gameObject,fromDup,isRoot);
                var ca=a.GetComponents<Component>();var cb=b.GetComponents<Component>();
                for(int i=0;i<ca.Length;i++)if(ca[i]&&cb[i]&&ca[i].GetType()==cb[i].GetType())CopyValues(ca[i],cb[i],fromDup,isRoot);
            }
            // Referrers outside the copy may still point at objects the conversion replaced (missing now): follow the old ids.
            if(referrers!=null)foreach(var c in referrers.Where(r=>r.go).SelectMany(r=>r.go.GetComponents<Component>()))
            {
                if(!c)continue;
                var so=new SerializedObject(c);var it=so.GetIterator();bool changed=false;
                while(it.Next(true))
                    if(it.propertyType==SerializedPropertyType.ObjectReference&&!it.objectReferenceValue&&oldIds.TryGetValue(it.objectReferenceInstanceIDValue,out var at))
                    {var to=Resolve(at);if(to){it.objectReferenceValue=to;changed=true;}}
                if(changed)so.ApplyModifiedPropertiesWithoutUndo();
            }
        }
        finally{Object.DestroyImmediate(dup);}
    }

    // Sets every serialized value of b to a's (references into the duplicate mapped to the converted objects) and records
    // the differences as instance overrides. Prefab/ownership fields are left alone; the root keeps its own placement.
    static void CopyValues(Object a,Object b,Dictionary<Object,Object> map,bool isRoot)
    {
        var src=new SerializedObject(a);var dst=new SerializedObject(b);var p=src.GetIterator();bool enter=true;
        while(p.Next(enter))
        {
            enter=true;
            if(p.depth==0&&(Meta.Contains(p.name)||p.name=="m_Script"||p.name=="m_PrefabInternal")){enter=false;continue;}
            if(p.propertyType==SerializedPropertyType.Generic)continue;
            var d=dst.FindProperty(p.propertyPath);if(d==null)continue;
            if(p.propertyType==SerializedPropertyType.ObjectReference)
            {
                var v=p.objectReferenceValue;var to=v&&map.TryGetValue(v,out var m)?m:v;
                if(d.objectReferenceValue!=to)d.objectReferenceValue=to;enter=false;continue;
            }
            dst.CopyFromSerializedPropertyIfDifferent(p);
            if(p.propertyType==SerializedPropertyType.String)enter=false;
        }
        dst.ApplyModifiedPropertiesWithoutUndo();
        PrefabUtility.RecordPrefabInstancePropertyModifications(b);
    }

    static void Swap(GameObject old,GameObject asset,List<Node> referrers)
    {
        var parent=old.transform.parent;int index=old.transform.GetSiblingIndex();
        var made=parent?(GameObject)PrefabUtility.InstantiatePrefab(asset,parent):(GameObject)PrefabUtility.InstantiatePrefab(asset,old.scene);
        made.transform.SetSiblingIndex(index);
        Copy(old,made);Copy(old.transform,made.transform);
        if(referrers!=null)Remap(old,made,referrers);
        Object.DestroyImmediate(old);
    }

    // Re-points the referrers' references into the old copy to the same object of the new instance.
    static void Remap(GameObject old,GameObject made,List<Node> referrers)
    {
        var map=new Dictionary<Object,Object>();Pair(old,made,map);
        foreach(var c in referrers.Where(r=>r.go).SelectMany(r=>r.go.GetComponents<Component>()))
        {
            if(!c)continue;
            var so=new SerializedObject(c);var p=so.GetIterator();bool changed=false;
            while(p.Next(true))
                if(p.propertyType==SerializedPropertyType.ObjectReference&&p.objectReferenceValue&&map.TryGetValue(p.objectReferenceValue,out var to)){p.objectReferenceValue=to;changed=true;}
            if(changed)so.ApplyModifiedPropertiesWithoutUndo();
        }
    }
    static void Pair(GameObject a,GameObject b,Dictionary<Object,Object> map)
    {
        map[a]=b;var ca=a.GetComponents<Component>();var cb=b.GetComponents<Component>();
        for(int i=0;i<ca.Length&&i<cb.Length;i++)if(ca[i]&&cb[i])map[ca[i]]=cb[i];
        for(int i=0;i<a.transform.childCount&&i<b.transform.childCount;i++)Pair(a.transform.GetChild(i).gameObject,b.transform.GetChild(i).gameObject,map);
    }

    static void Copy(Object from,Object to)
    {
        var a=new SerializedObject(from);var b=new SerializedObject(to);
        foreach(var name in RootOnly){var p=a.FindProperty(name);if(p!=null&&b.FindProperty(name)!=null)b.CopyFromSerializedProperty(p);}
        b.ApplyModifiedPropertiesWithoutUndo();
    }

    static string Backup(string path,string root)
    {
        root??=Directory.Exists("../Backups")?"../Backups":"SceneDedupBackups";
        var folder=Path.Combine(root,"before-scene-dedup-"+DateTime.Now.ToString("yyyyMMddTHHmmss"),Path.GetDirectoryName(path));
        Directory.CreateDirectory(folder);
        File.Copy(path,Path.Combine(folder,Path.GetFileName(path)),true);File.Copy(path+".meta",Path.Combine(folder,Path.GetFileName(path)+".meta"),true);
        return Path.GetFullPath(Path.Combine(folder,Path.GetFileName(path)));
    }

    static void Restore(string path,string backup){File.Copy(backup,path,true);AssetDatabase.ImportAsset(path,ImportAssetOptions.ForceUpdate);}
}
