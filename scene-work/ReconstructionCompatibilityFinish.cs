using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
public static class ReconstructionCompatibilityFinish
{
    [Serializable] class Change {public string asset,sourceShader,targetShader,status,unsupported;}
    [Serializable] class Report {public List<Change> materialChanges=new List<Change>();public int comicImagesReplaced;public string comicScope="User explicitly excluded Comic content; one shared transparent1x1 image substitutes ComicPlayer page display.";}
    public static void Run()
    {
        var report=new Report();var lit=AssetDatabase.LoadAssetAtPath<Shader>("Packages/com.unity.render-pipelines.universal/Shaders/Lit.shader");if(!lit)throw new Exception("Real target URP Lit shader missing");
        foreach(string id in AssetDatabase.FindAssets("t:Material",new[]{"Assets/OriginalRecovered"}))
        {
            string path=AssetDatabase.GUIDToAssetPath(id);var m=AssetDatabase.LoadAssetAtPath<Material>(path);if(!m||!m.shader)continue;string source=m.shader.name;
            if(source=="RecoveredStub/TATSUJIN/TXE_Lit")
            {
                m.shader=lit;EditorUtility.SetDirty(m);report.materialChanges.Add(new Change{asset=path,sourceShader="TATSUJIN/TXE_Lit",targetShader=lit.name,status="Approximate compatible replacement: original property schema agrees with URP Lit standard maps, colors, PBR, blend/depth fields; authoring shader is unrecovered",unsupported="Original _FogUSE, _RimColor, _RimFactor and _FadeColor behavior is not implemented; target lighting differs"});
            }
            else if(source=="RecoveredStub/Shader Graphs/sg_emission_flicker_fogswitch")
            {
                var albedo=m.GetTexture("_Tx_Albedo");var normal=m.GetTexture("_Tx_Normal");var metallic=m.GetTexture("_Tx_Metsllic");var occlusion=m.GetTexture("_Tx_Occlusion");var emission=m.GetTexture("_Tx_Emission");var color=m.GetColor("_EmissionColir");float smooth=m.GetFloat("_Smoothness");
                m.shader=lit;m.SetTexture("_BaseMap",albedo);m.SetColor("_BaseColor",Color.white);m.SetTexture("_BumpMap",normal);m.SetTexture("_MetallicGlossMap",metallic);m.SetTexture("_OcclusionMap",occlusion);m.SetTexture("_EmissionMap",emission);m.SetColor("_EmissionColor",color);m.SetFloat("_Smoothness",smooth);if(normal)m.EnableKeyword("_NORMALMAP");if(metallic)m.EnableKeyword("_METALLICSPECGLOSSMAP");if(emission)m.EnableKeyword("_EMISSION");EditorUtility.SetDirty(m);
                report.materialChanges.Add(new Change{asset=path,sourceShader="Shader Graphs/sg_emission_flicker_fogswitch",targetShader=lit.name,status="Approximate static material: map slots and emission color recovered from original properties; previous independent remaster helper establishes corresponding PBR slots",unsupported="Flicker timing/mask and fog-switch behavior remain unrecovered"});
            }
        }
        string blankPath="Assets/Reconstruction/ComicBlank.png";var importer=AssetImporter.GetAtPath(blankPath) as TextureImporter;importer.textureType=TextureImporterType.Sprite;importer.spriteImportMode=SpriteImportMode.Single;importer.spritePixelsPerUnit=100;importer.alphaIsTransparency=true;importer.SaveAndReimport();var blank=AssetDatabase.LoadAssetAtPath<Sprite>(blankPath);if(!blank)throw new Exception("Comic placeholder sprite not imported");
        string prefab="Assets/OriginalRecovered/OutGame/Reference/Presenter/ComicPlayPresenter.prefab";var root=PrefabUtility.LoadPrefabContents(prefab);
        try{foreach(var image in root.GetComponentsInChildren<Image>(true))if(image.gameObject.name=="ComicPlayer"){image.sprite=blank;report.comicImagesReplaced++;}PrefabUtility.SaveAsPrefabAsset(root,prefab);}finally{PrefabUtility.UnloadPrefabContents(root);}
        AssetDatabase.SaveAssets();
        string output=Path.GetFullPath(Path.Combine(Application.dataPath,"../../evidence/scene-integration"));Directory.CreateDirectory(output);File.WriteAllText(Path.Combine(output,"material-and-comic-compatibility.json"),JsonUtility.ToJson(report,true));
        ReconstructionAssetAudit.Run();
    }
}
