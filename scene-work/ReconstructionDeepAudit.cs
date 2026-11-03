using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
public static class ReconstructionDeepAudit
{
    [Serializable] public class Field {public string path,type,value;}
    [Serializable] public class ComponentRow {public string globalId,type,assetPath;public List<Field> fields=new List<Field>();}
    [Serializable] public class Node {public string globalId,name,parent;public int sibling,layer;public bool active;public List<ComponentRow> components=new List<ComponentRow>();}
    [Serializable] public class SceneRow {public string path;public List<Node> objects=new List<Node>();}
    [Serializable] public class AssetRow {public string path,type;}
    [Serializable] public class Count {public string type;public int count;}
    [Serializable] public class Report {public string unity;public int files;public List<Count> importedTypes=new List<Count>();public List<AssetRow> missingMainTypes=new List<AssetRow>();public List<AssetRow> opaqueDefaultAssets=new List<AssetRow>();public List<SceneRow> scenes=new List<SceneRow>();public List<ComponentRow> renderingAssets=new List<ComponentRow>();}
    public static void Run()
    {
        var report=new Report{unity=Application.unityVersion};var counts=new Dictionary<string,int>();
        foreach(string guid in AssetDatabase.FindAssets("",new[]{"Assets/OriginalRecovered"}))
        {
            string path=AssetDatabase.GUIDToAssetPath(guid);if(AssetDatabase.IsValidFolder(path))continue;report.files++;
            Type type=AssetDatabase.GetMainAssetTypeAtPath(path);if(type==null){report.missingMainTypes.Add(new AssetRow{path=path});continue;}
            if(type==typeof(DefaultAsset)&&Path.GetExtension(path)!=".dll")report.opaqueDefaultAssets.Add(new AssetRow{path=path,type=type.FullName});
            string name=type.FullName;counts.TryGetValue(name,out int n);counts[name]=n+1;
            if(name=="UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset"||name=="UnityEngine.Rendering.Universal.UniversalRendererData"||name=="UnityEngine.Rendering.Universal.UniversalRenderPipelineGlobalSettings"||name=="TXEKernel.TXERendererFeatureCopyColor")
            {
                var obj=AssetDatabase.LoadMainAssetAtPath(path);var rr=new ComponentRow{globalId=Id(obj),type=name,assetPath=path};try{var so=new SerializedObject(obj);var it=so.GetIterator();while(it.Next(true))rr.fields.Add(new Field{path=it.propertyPath,type=it.propertyType.ToString(),value=Value(it)});}catch(Exception e){rr.fields.Add(new Field{path="AUDIT_EXCEPTION",value=e.ToString()});}report.renderingAssets.Add(rr);
            }
        }
        foreach(var p in counts.OrderBy(x=>x.Key))report.importedTypes.Add(new Count{type=p.Key,count=p.Value});
        foreach(string scene in new[]{"Assets/OriginalRecovered/Scenes/Boot.unity","Assets/OriginalRecovered/Scenes/BootTXE.unity"})
        {
            var loaded=EditorSceneManager.OpenScene(scene,OpenSceneMode.Single);var row=new SceneRow{path=scene};
            foreach(var root in loaded.GetRootGameObjects())foreach(var t in root.GetComponentsInChildren<Transform>(true))
            {
                var node=new Node{globalId=Id(t.gameObject),name=t.name,parent=t.parent?Id(t.parent.gameObject):null,sibling=t.GetSiblingIndex(),layer=t.gameObject.layer,active=t.gameObject.activeSelf};
                foreach(var c in t.GetComponents<Component>())
                {
                    if(!c){node.components.Add(new ComponentRow{type="MISSING_SCRIPT"});continue;}
                    var component=new ComponentRow{globalId=Id(c),type=c.GetType().AssemblyQualifiedName};
                    try{var so=new SerializedObject(c);var prop=so.GetIterator();while(prop.Next(true))component.fields.Add(new Field{path=prop.propertyPath,type=prop.propertyType.ToString(),value=Value(prop)});}catch(Exception e){component.fields.Add(new Field{path="AUDIT_EXCEPTION",value=e.ToString()});}
                    node.components.Add(component);
                }
                row.objects.Add(node);
            }
            report.scenes.Add(row);
        }
        EditorSceneManager.OpenScene("Assets/Reconstruction/Hub.unity",OpenSceneMode.Single);
        string dest=Path.GetFullPath(Path.Combine(Application.dataPath,"../../evidence/scene-integration"));Directory.CreateDirectory(dest);File.WriteAllText(Path.Combine(dest,"original-deep-audit.json"),JsonUtility.ToJson(report,true));
    }
    static string Id(UnityEngine.Object o){return o?GlobalObjectId.GetGlobalObjectIdSlow(o).ToString():null;}
    static string Value(SerializedProperty p)
    {
        switch(p.propertyType){
        case SerializedPropertyType.Integer: return p.longValue.ToString(CultureInfo.InvariantCulture);
        case SerializedPropertyType.Boolean: return p.boolValue.ToString();
        case SerializedPropertyType.Float: return p.doubleValue.ToString("R",CultureInfo.InvariantCulture);
        case SerializedPropertyType.String: return p.stringValue;
        case SerializedPropertyType.Color: return p.colorValue.ToString("R");
        case SerializedPropertyType.ObjectReference: return p.objectReferenceValue?Id(p.objectReferenceValue):"null(instance="+p.objectReferenceInstanceIDValue+")";
        case SerializedPropertyType.Enum: return p.intValue.ToString(CultureInfo.InvariantCulture);
        case SerializedPropertyType.Vector2:return p.vector2Value.ToString("R");
        case SerializedPropertyType.Vector3:return p.vector3Value.ToString("R");
        case SerializedPropertyType.Vector4:return p.vector4Value.ToString("R");
        case SerializedPropertyType.Quaternion:return p.quaternionValue.ToString("R");
        case SerializedPropertyType.Rect:return p.rectValue.ToString();
        case SerializedPropertyType.Bounds:return p.boundsValue.ToString();
        case SerializedPropertyType.ArraySize:return p.intValue.ToString();
        case SerializedPropertyType.LayerMask:return p.intValue.ToString();
        default:return "<serialized container or native property; raw source retained>";}
    }
}
