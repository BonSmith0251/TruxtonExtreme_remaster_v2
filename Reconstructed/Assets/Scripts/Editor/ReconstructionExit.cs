using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

// Clean editor exit for the verification and build scripts. EditorApplication.Exit straight after building or playing
// a stage crashed natively during shutdown, in two ways:
//  - batch builds: DestroyWorld -> GameObject::Deactivate -> ActivateAwakeRecursively, tearing down the still-open
//    stage scene (original prefabs with stripped stub scripts, hidden helper objects);
//  - GUI play checks: DestroyGfxDevice -> GeometryJobTasks::EndFrame -> CompleteFenceInternal, when Exit ran inside
//    the play-mode-changed callback with the frame's geometry jobs still in flight.
// So: leave play mode, destroy the hidden helper objects our tools created, unload the scene into an empty one, let
// the editor run a few frames (GUI), and only then exit.
public static class ReconstructionExit
{
    public static void Quit(int code)
    {
        if(Application.isBatchMode){Unload();EditorApplication.Exit(code);return;}
        int frames=0;bool unloaded=false;EditorApplication.CallbackFunction tick=null;
        tick=()=>{
            if(EditorApplication.isPlayingOrWillChangePlaymode){EditorApplication.isPlaying=false;return;}
            if(EditorApplication.isCompiling||EditorApplication.isUpdating)return;
            if(!unloaded){Unload();unloaded=true;frames=0;return;}
            if(++frames<15)return;
            EditorApplication.update-=tick;EditorApplication.Exit(code);
        };
        EditorApplication.update+=tick;
    }
    static void Unload()
    {
        // Scene-less hidden objects (HideFlags.DontSave holders and pools made by the tools) survive scene changes and
        // would otherwise be torn down by the shutdown itself.
        // Ours use DontSave without HideInHierarchy; Unity's internal objects are HideAndDontSave and are left alone.
        var leftovers=Resources.FindObjectsOfTypeAll<GameObject>().Where(g=>g&&!EditorUtility.IsPersistent(g)&&g.transform.parent==null
            &&(g.hideFlags&HideFlags.DontSaveInEditor)!=0&&(g.hideFlags&HideFlags.HideInHierarchy)==0).ToList();
        if(leftovers.Count>0)Debug.Log("ReconstructionExit: destroying "+leftovers.Count+" hidden objects: "+string.Join(", ",leftovers.Take(20).Select(g=>g.name)));
        foreach(var g in leftovers)if(g)Object.DestroyImmediate(g);
        EditorSceneManager.NewScene(NewSceneSetup.EmptyScene,NewSceneMode.Single);
    }
}
