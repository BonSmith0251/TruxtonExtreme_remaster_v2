using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEditor.Rendering;

// Compiles every pass of every recovered shader (files marked by tools/shader_recovery/build_shaders.py) and records
// errors/warnings. Batch: -executeMethod ReconstructionShaderRecoveryCheck.Run
public static class ReconstructionShaderRecoveryCheck
{
    const string Marker="// TRUXTON-RECOVERED-SHADER ";
    const string Output="D:/Games/TruxtonExRecon/verification/shader-recovery";
    [Serializable] class Entry {public string path,shader;public int passes,errors,warnings;public bool hasError;public List<string> messages=new List<string>();}
    [Serializable] class Report {public string utc,unity;public int shaders,failed,materials;public List<Entry> entries=new List<Entry>();public List<string> materialFailures=new List<string>();}

    public static void Run()
    {
        Directory.CreateDirectory(Output);
        var report=new Report{utc=DateTime.UtcNow.ToString("O"),unity=Application.unityVersion};
        foreach(string guid in AssetDatabase.FindAssets("t:Shader",new[]{"Assets"}))
        {
            string path=AssetDatabase.GUIDToAssetPath(guid);
            if(!path.EndsWith(".shader")||!File.ReadLines(path).FirstOrDefault()?.StartsWith(Marker)==true)continue;
            var shader=AssetDatabase.LoadAssetAtPath<Shader>(path);
            var e=new Entry{path=path,shader=shader?shader.name:"(failed to load)"};
            report.entries.Add(e);
            if(!shader){e.hasError=true;continue;}
            var material=new Material(shader);
            e.passes=material.passCount;
            for(int p=0;p<material.passCount;p++)ShaderUtil.CompilePass(material,p,true);
            UnityEngine.Object.DestroyImmediate(material);
            foreach(var m in ShaderUtil.GetShaderMessages(shader))
            {
                if(m.severity==ShaderCompilerMessageSeverity.Error)e.errors++;else e.warnings++;
                if(e.messages.Count<20)e.messages.Add(m.severity+" line "+m.line+": "+m.message+" "+m.messageDetails.Split('\n')[0]);
            }
            e.hasError=ShaderUtil.ShaderHasError(shader)||e.errors>0;
        }
        // Every material that uses a recovered shader: compile each pass with the material's own keywords.
        var recovered=new HashSet<Shader>(report.entries.Select(x=>AssetDatabase.LoadAssetAtPath<Shader>(x.path)).Where(x=>x));
        foreach(string guid in AssetDatabase.FindAssets("t:Material",new[]{"Assets"}))
        {
            var material=AssetDatabase.LoadAssetAtPath<Material>(AssetDatabase.GUIDToAssetPath(guid));
            if(!material||!recovered.Contains(material.shader))continue;
            report.materials++;
            for(int p=0;p<material.passCount;p++)ShaderUtil.CompilePass(material,p,true);
            if(ShaderUtil.ShaderHasError(material.shader)&&report.materialFailures.Count<40)report.materialFailures.Add(AssetDatabase.GetAssetPath(material)+" ["+string.Join(" ",material.shaderKeywords)+"]");
        }
        foreach(var e in report.entries)
        {
            var shader=AssetDatabase.LoadAssetAtPath<Shader>(e.path);if(!shader)continue;
            int errors=ShaderUtil.GetShaderMessages(shader).Count(m=>m.severity==ShaderCompilerMessageSeverity.Error);
            if(errors>e.errors){e.errors=errors;e.hasError=true;foreach(var m in ShaderUtil.GetShaderMessages(shader))if(e.messages.Count<20)e.messages.Add("material variant: "+m.message+" "+m.messageDetails.Split('\n')[0]);}
        }
        report.shaders=report.entries.Count;report.failed=report.entries.Count(x=>x.hasError);
        File.WriteAllText(Output+"/compile-check.json",JsonUtility.ToJson(report,true));
        Debug.Log("SHADER_RECOVERY_CHECK shaders="+report.shaders+" failed="+report.failed+" materials="+report.materials+" materialFailures="+report.materialFailures.Count);
        if(Application.isBatchMode)ReconstructionExit.Quit(report.failed==0?0:1);
    }
}
