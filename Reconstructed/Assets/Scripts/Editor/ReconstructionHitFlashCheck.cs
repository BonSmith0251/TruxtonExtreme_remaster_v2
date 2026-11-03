using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

// Hit flash and damage blink on enemies outside BG03 (Round1Effects): spawns each model the way the stages do (stub
// behaviours stripped), then renders it plain, on a hit flash, and at the peak of the half-HP damage blink, and reads the
// material values that drew it. A model passes when it blinks and both the flash and the blink brighten or tint the
// render. Batch: -executeMethod ReconstructionHitFlashCheck.Run [HITFLASH_OUT=<dir>] (default ../evidence/hit-flash).
public static class ReconstructionHitFlashCheck
{
    static readonly string[] Models={
        "Assets/OriginalGame/Pf_EneObj_Meteo_Sa01.prefab","Assets/OriginalGame/Pf_EneObj_Meteo_Ma01.prefab",
        "Assets/OriginalGame/Pf_EneObj_Meteo_La01.prefab","Assets/OriginalGame/Pf_EneObj_Meteo_Sa02.prefab",
        "Assets/OriginalGame/Pf_EneObj_Meteo_Ma02.prefab","Assets/OriginalGame/Pf_EneObj_Meteo_La02.prefab",
        "Assets/Prefabs/Enemies/Pf_EneObj_Meteo_La02.prefab",
        "Assets/OriginalGame/Samples/Prefabs/Reference/Enemy/Pf_Ene_Mp01.prefab","Assets/OriginalGame/Pf_Ene_So01.prefab",
        "Assets/OriginalGame/Pf_Ene_St01.prefab","Assets/OriginalGame/Samples/Prefabs/Reference/Enemy/Pf_Ene_Mq01.prefab",
        "Assets/OriginalGame/Samples/Prefabs/Reference/Enemy/Pf_Ene_Mj01h.prefab"};
    static readonly int FadeColorId=Shader.PropertyToID("_FadeColor"),EmissionColorId=Shader.PropertyToID("_EmissionColor");

    public static void Run()
    {
        var output=Environment.GetEnvironmentVariable("HITFLASH_OUT")??"../evidence/hit-flash";Directory.CreateDirectory(output);
        var lines=new List<string>();bool all=true;
        try
        {
            EditorSceneManager.NewScene(NewSceneSetup.EmptyScene,NewSceneMode.Single);
            var light=new GameObject("Light").AddComponent<Light>();light.type=LightType.Directional;light.transform.rotation=Quaternion.Euler(50,-30,0);
            var cam=new GameObject("Camera").AddComponent<Camera>();cam.clearFlags=CameraClearFlags.SolidColor;cam.backgroundColor=new Color(.1f,.12f,.18f);
            var holder=new GameObject("holder");holder.SetActive(false);
            foreach(var path in Models)
            {
                var prefab=AssetDatabase.LoadAssetAtPath<GameObject>(path);
                if(!prefab){lines.Add(path+": MISSING");all=false;continue;}
                var go=UnityEngine.Object.Instantiate(prefab,holder.transform);go.name=prefab.name;StageEnemies.StripStubBehaviours(go);
                go.transform.SetParent(null,false);go.SetActive(true);
                foreach(var ps in go.GetComponentsInChildren<ParticleSystem>(true))ps.gameObject.SetActive(false);
                var bounds=new Bounds(go.transform.position,Vector3.zero);
                foreach(var r in go.GetComponentsInChildren<Renderer>())if(!(r is ParticleSystemRenderer))bounds.Encapsulate(r.bounds);
                float size=Mathf.Max(1,bounds.extents.magnitude);
                cam.transform.position=bounds.center+new Vector3(0,.6f,-1)*size*2.2f;cam.transform.LookAt(bounds.center);
                cam.nearClipPlane=size*.05f;cam.farClipPlane=size*10;

                var fx=new Round1Effects();
                var t=new Round1Combat.Target{id=1,visual=go,template=prefab,health=100,maxHealth=100,active=true};
                bool blinks=fx.Blinks(t);
                string tag=Path.GetFileNameWithoutExtension(path)+(path.StartsWith("Assets/Prefabs/")?"_imported":"");
                var plain=Render(cam,Path.Combine(output,tag+"_0plain.png"));
                fx.Flash(t);fx.Blink(t,0);
                var flash=Render(cam,Path.Combine(output,tag+"_1flash.png"));string flashValue=Value(go);
                fx.Blink(t,.2f);fx.Blink(t,0); // the flash fades out
                t.health=20;fx.Blink(t,.4f);    // 20 % HP: timer 0.4 / (0.2 / 0.5) = 1, the blink's peak
                var blink=Render(cam,Path.Combine(output,tag+"_2blink.png"));string blinkValue=Value(go);
                t.health=100;fx.Blink(t,0);
                var back=Render(cam,null);
                float dFlash=flash.lum-plain.lum,dBlink=blink.red-plain.red,dBack=Mathf.Abs(back.lum-plain.lum);
                bool ok=blinks&&dFlash>.02f&&dBlink>.02f&&dBack<.002f;all&=ok;
                lines.Add($"{(ok?"PASS":"FAIL")} {tag}: blinks {blinks}, flash +{dFlash:0.000} lum, blink +{dBlink:0.000} red, restored {dBack:0.0000}; flash {flashValue}; blink {blinkValue}");
                UnityEngine.Object.DestroyImmediate(go);
            }
        }
        catch(Exception e){lines.Add("ERROR "+e);all=false;}
        lines.Insert(0,all?"PASS hit flash check":"FAIL hit flash check");
        File.WriteAllLines(Path.Combine(output,"hit-flash-check.txt"),lines);
        foreach(var l in lines)Debug.Log("[HitFlashCheck] "+l);
        ReconstructionExit.Quit(all?0:1);
    }

    // The first material's flash inputs: TXE_Lit's _FadeColor, else the URP emission the remaster mixes in.
    static string Value(GameObject go)
    {
        var r=go.GetComponentsInChildren<Renderer>().FirstOrDefault(x=>!(x is ParticleSystemRenderer));var m=r?r.sharedMaterial:null;
        if(!m)return "no material";
        return m.shader.name+(m.HasProperty(FadeColorId)?" _FadeColor="+m.GetColor(FadeColorId):" _EmissionColor="+m.GetColor(EmissionColorId));
    }

    // Mean luminance and red excess of the object's pixels (those differing from the clear colour).
    static (float lum,float red) Render(Camera cam,string file)
    {
        const int W=320,H=240;
        var rt=new RenderTexture(W,H,24,RenderTextureFormat.ARGB32);rt.Create();cam.targetTexture=rt;cam.Render();cam.targetTexture=null;
        RenderTexture.active=rt;var image=new Texture2D(W,H,TextureFormat.RGBA32,false);image.ReadPixels(new Rect(0,0,W,H),0,0);image.Apply();RenderTexture.active=null;
        if(file!=null)File.WriteAllBytes(file,image.EncodeToPNG());
        var bg=cam.backgroundColor;float lum=0,red=0;int n=0;
        foreach(var c in image.GetPixels())
        {
            if(Mathf.Abs(c.r-bg.r)+Mathf.Abs(c.g-bg.g)+Mathf.Abs(c.b-bg.b)<.02f)continue;
            lum+=.2126f*c.r+.7152f*c.g+.0722f*c.b;red+=c.r-(c.g+c.b)*.5f;n++;
        }
        UnityEngine.Object.DestroyImmediate(image);rt.Release();UnityEngine.Object.DestroyImmediate(rt);
        return n==0?(0,0):(lum/n,red/n);
    }
}
