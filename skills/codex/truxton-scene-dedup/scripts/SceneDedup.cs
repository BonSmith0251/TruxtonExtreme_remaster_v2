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
//   [-dedupOutRoot <folder for new prefabs>] [-dedupBackup <folder>] [-dedupMinCount 2] [-dedupTolerance 0]
public static class SceneDedup
{
    [Serializable] public class Occurrence{public string path,blocked;}
    [Serializable] public class Group{public string name,prefab,signature;public int count,replaceable,objectsEach,height;public bool planned,applied,reused,redundant;public List<Occurrence> occurrences=new();}
    [Serializable] public class Stats{public int gameObjects,components,prefabInstances;public long fileBytes;}
    [Serializable] public class Report{public string target,mode,error,backup;public bool passed,digestMatch,restored;public Stats before,after;public int groupsFound,groupsPlanned,copiesPlanned,groupsApplied,copiesReplaced;public List<Group> groups=new();public List<string> digestMismatches=new();}
    [Serializable] class Batch{public List<Report> reports=new();}
    [Serializable] class Manifest{public List<Entry> entries=new();}
    [Serializable] class Entry{public string signature,prefab;}

    class Node{public GameObject go;public Node parent;public List<Node> children=new();public string key;public bool instanceRoot,insideInstance,heavy,pinned;public int height,size;public Group group;public string blocked;}
    class Raw{public string hash;public Object[] refs;}

    static readonly HashSet<string> Meta=new(){"m_ObjectHideFlags","m_CorrespondingSourceObject","m_PrefabInstance","m_PrefabAsset","m_GameObject","m_Father","m_Children","m_Component","m_RootOrder"};
    // Root-only values become instance overrides, so they are left out of the signature.
    static readonly HashSet<string> RootOnly=new(){"m_Name","m_IsActive","m_LocalPosition","m_LocalRotation","m_LocalScale","m_LocalEulerAnglesHint","m_ConstrainProportionsScale","m_AnchorMin","m_AnchorMax","m_AnchoredPosition","m_SizeDelta","m_Pivot"};

    static double tolerance;static int minCount=2;
    static Node top;static Dictionary<int,(Node node,int component)> lookup;static Dictionary<(int,bool),Raw> raws;

    public static void RunBatch()
    {
        var args=Environment.GetCommandLineArgs();
        string Arg(string name,string fallback=null){int i=Array.IndexOf(args,name);return i>=0&&i+1<args.Length?args[i+1]:fallback;}
        var targets=(Arg("-dedupTargets")??"").Split(';').Select(s=>s.Trim()).Where(s=>s.Length>0).ToArray();
        bool apply=Arg("-dedupMode","report")=="apply";
        minCount=int.Parse(Arg("-dedupMinCount","2"));tolerance=double.Parse(Arg("-dedupTolerance","0"),CultureInfo.InvariantCulture);
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
        bool isPrefab=path.EndsWith(".prefab");GameObject contents=null;
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
                var copies=nodes.Where(n=>n.group==g&&n.blocked==null).ToList();
                var entry=manifest.entries.Find(e=>e.signature==g.signature&&File.Exists(e.prefab));
                GameObject asset;
                if(entry!=null){asset=AssetDatabase.LoadAssetAtPath<GameObject>(entry.prefab);g.reused=true;}
                else
                {
                    var file=Unique(outRoot,g.name);
                    asset=PrefabUtility.SaveAsPrefabAsset(copies[0].go,file,out bool saved);
                    if(!saved||!asset)throw new Exception("could not save "+file);
                    Normalize(file);asset=AssetDatabase.LoadAssetAtPath<GameObject>(file);
                    manifest.entries.Add(entry=new Entry{signature=g.signature,prefab=file});
                }
                g.prefab=entry.prefab;
                foreach(var c in copies){Swap(c.go,asset);report.copiesReplaced++;}
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
                if(a!=b&&report.digestMismatches.Count<40)report.digestMismatches.Add(k+(a==null?" (added)":b==null?" (missing)":" (changed)"));
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
        var sb=new StringBuilder(o.GetType().FullName);var refs=new List<Object>();
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
                    else if(EditorUtility.IsPersistent(r)){AssetDatabase.TryGetGUIDAndLocalFileIdentifier(r,out string guid,out long id);sb.Append("A:").Append(guid).Append(':').Append(id);}
                    else{sb.Append('\u0001').Append(refs.Count);refs.Add(r);}
                    enter=false;break;
            }
        }
        return raws[(o.GetInstanceID(),asRoot)]=new Raw{hash=Hash(sb.ToString()),refs=refs.ToArray()};
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
        foreach(var n in nodes.Where(n=>!n.instanceRoot&&!n.insideInstance&&n.heavy))
        {
            var sig=Signature(n,out bool outbound);
            if(outbound)n.blocked="references objects outside itself";
            else
            {
                var inside=new[]{n}.Concat(All(n)).ToList();
                if(inside.Any(x=>x.pinned))n.blocked="referenced by another asset (scene override or stripped reference)";
                else{var r=inside.SelectMany(x=>referrers.TryGetValue(x,out var l)?l:new List<Node>()).FirstOrDefault(s=>!Within(s,n));if(r!=null)n.blocked="referenced by "+r.go.name;}
            }
            (bySig.TryGetValue(sig,out var list)?list:bySig[sig]=new()).Add(n);
        }

        var groups=new List<Group>();
        foreach(var kv in bySig.Where(kv=>kv.Value.Count>=2))
        {
            var first=kv.Value[0];
            var g=new Group{signature=kv.Key,count=kv.Value.Count,replaceable=kv.Value.Count(n=>n.blocked==null),objectsEach=first.size,height=first.height,name=BaseName(kv.Value)};
            foreach(var n in kv.Value){n.group=g;g.occurrences.Add(new Occurrence{path=PathOf(n),blocked=n.blocked});}
            groups.Add(g);
        }
        report.groupsFound=groups.Count;

        // Biggest first: a group that only ever appears once inside every copy of one bigger kept group adds nothing.
        var kept=new HashSet<Node>();var chosen=new List<Group>();
        foreach(var g in groups.Where(g=>g.replaceable>=minCount).OrderByDescending(g=>g.height).ThenByDescending(g=>g.objectsEach))
        {
            var copies=nodes.Where(n=>n.group==g&&n.blocked==null).ToList();
            var owners=copies.Select(n=>{var a=n.parent;while(a!=null&&!kept.Contains(a))a=a.parent;return a;}).ToList();
            var owner=owners[0]?.group;
            bool redundant=owners.All(a=>a!=null&&a.group==owner)&&owners.Distinct().Count()==copies.Count&&copies.Count==owner.replaceable;
            if(redundant){g.redundant=true;continue;}
            foreach(var n in copies)kept.Add(n);chosen.Add(g);g.planned=true;
        }
        report.groupsPlanned=chosen.Count;report.copiesPlanned=chosen.Sum(g=>g.replaceable);
        report.groups=groups.OrderByDescending(g=>g.count*g.objectsEach).ToList();
        return chosen;
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
    static void Normalize(string file)
    {
        var root=PrefabUtility.LoadPrefabContents(file);
        root.name=Path.GetFileNameWithoutExtension(file);root.SetActive(true);
        if(!(root.transform is RectTransform)){root.transform.localPosition=Vector3.zero;root.transform.localRotation=Quaternion.identity;}
        PrefabUtility.SaveAsPrefabAsset(root,file);PrefabUtility.UnloadPrefabContents(root);
    }

    static void Swap(GameObject old,GameObject asset)
    {
        var parent=old.transform.parent;int index=old.transform.GetSiblingIndex();
        var made=parent?(GameObject)PrefabUtility.InstantiatePrefab(asset,parent):(GameObject)PrefabUtility.InstantiatePrefab(asset,old.scene);
        made.transform.SetSiblingIndex(index);
        Copy(old,made);Copy(old.transform,made.transform);
        Object.DestroyImmediate(old);
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
