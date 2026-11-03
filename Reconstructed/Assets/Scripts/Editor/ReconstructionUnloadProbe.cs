using System;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

// Diagnostic only: opens a StagePlay scene and deactivates its objects one at a time, deepest first, writing each
// object's path to a file before touching it, to find what crashes the editor when the scene is unloaded.
// Batch: -executeMethod ReconstructionUnloadProbe.Run (UNLOAD_PROBE_SCENE=Assets/...unity)
public static class ReconstructionUnloadProbe
{
    public static void Run()
    {
        string scene=Environment.GetEnvironmentVariable("UNLOAD_PROBE_SCENE")??"Assets/Scenes/StagePlay/StagePlay_BG05.unity";
        string log="D:/Games/TruxtonExRecon/verification/stage-play/unload-probe.txt";File.WriteAllText(log,"");
        var s=EditorSceneManager.OpenScene(scene,OpenSceneMode.Single);
        foreach(var root in s.GetRootGameObjects())Visit(root.transform,log);
        File.AppendAllText(log,"DONE all deactivated\n");
        EditorApplication.Exit(0);
    }
    static void Visit(Transform t,string log)
    {
        for(int i=t.childCount-1;i>=0;i--)Visit(t.GetChild(i),log);
        string path=t.name;for(var p=t.parent;p;p=p.parent)path=p.name+"/"+path;
        using(var w=File.AppendText(log)){w.WriteLine(path+" ["+string.Join(",",t.GetComponents<Component>().Select(c=>c?c.GetType().Name:"<missing>"))+"]");w.Flush();}
        if(t.gameObject.activeSelf)t.gameObject.SetActive(false);
    }
}
