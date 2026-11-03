using UnityEngine;
public static class ReconstructionFinalPass
{
    public static void Run()
    {
        if(!System.IO.File.Exists("Assets/Scenes/StageInspection/StageInspection_BG01.unity"))ReconstructionStageInspection.Create();
        ReconstructionCompatibilityFinish.Run();
        ReconstructionDeepAudit.Run();
        Debug.Log("RECONSTRUCTION_FINAL_PASS_COMPLETE");
    }
}
