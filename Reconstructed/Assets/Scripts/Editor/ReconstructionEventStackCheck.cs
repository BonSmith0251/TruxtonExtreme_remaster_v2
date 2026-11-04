using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

// Verification only: replays the Python model's tracks (evidence/air-route-events/sims/*.json, written by
// evidence/air-route-events/tools/air_sim.py --json) through Round1EventStack and compares them frame by frame.
// Pass per sim: max position error < 0.05 source units and the same end reason with end frames within 1 frame.
// Writes D:/games/TruxtonExRecon/verification/air-route-events/check.json and exits 0 (all pass) or 1.
// Run: Unity.exe -batchmode -projectPath ... -executeMethod ReconstructionEventStackCheck.Run
public static class ReconstructionEventStackCheck
{
    static readonly string[] Sims={"sb01_BG02_left","sb01ent_ur_BG04","sc01_BG07","sg01_BG02","sp01_BG07","sv01_BG02","mn01c2_BG06","sm01_1a_BG04","sf01a_BG05","sf01b_BG05","sf01_4a_BG05","sf01_4b_BG05","TSa01_hid_h_1stp_BG05","TSa01_hid_m_1stp_BG05","TSa01_m_1stp_BG05","TSa01_run_que3_BG05"};
    const float MaxPositionError=.05f;
    // air_sim.py eases SplineMove type 7 with the exact InOutSine; the port uses the native 0.1 deg Cosf table
    // (EasingUtility.InOutSine01, Ene_Sq01/SPEC.md) indexed in float32. On sb01ent's 140.7-unit route the curves are up
    // to 0.086 apart, plus up to one table step from the float32 index: allow 0.12 for programs eased by type 7.
    const float Ease7PositionError=.12f;

    [Serializable] public class SimTrack
    {
        public string stage,definition,model,endReason;
        public float[] spawn,player,x,y,z,yaws;
        public float yaw0,speed;
        public int seed,maxFrames,frames,endFrame;
        public int[] flag0;
    }
    [Serializable] public class SimResult
    {
        public string sim,stage,definition,model,error="";
        public bool passed;
        public int framesCompared,pythonFrames,unityFrames,maxPositionErrorFrame,flag0Patched;
        public float maxPositionError,maxYawError;
        public string pythonEndReason,unityEndReason;
        public int pythonEndFrame,unityEndFrame;
        public float pythonEndTime,unityEndTime;
        public float[] unityFinalPosition;
    }
    [Serializable] public class Report
    {
        public bool passed;public string generated;public float positionTolerance=MaxPositionError;
        public List<SimResult> sims=new List<SimResult>();
    }

    public static void Run()
    {
        int code=1;
        try
        {
            string root=Path.GetFullPath(Path.Combine(Application.dataPath,"../.."));
            string simDir=Path.Combine(root,"evidence/air-route-events/sims"),outDir=Path.Combine(root,"verification/air-route-events");
            Directory.CreateDirectory(outDir);
            var report=new Report{generated=DateTime.Now.ToString("s")};
            var stages=new Dictionary<string,Round1EnemyWaves.Data>();
            bool all=true;
            foreach(string sim in Sims)
            {
                var r=new SimResult{sim=sim};
                try{Check(sim,simDir,stages,r);}
                catch(Exception ex){r.passed=false;r.error=ex.GetType().Name+": "+ex.Message;Debug.LogException(ex);}
                all&=r.passed;report.sims.Add(r);
                Debug.Log("EventStackCheck "+sim+": "+(r.passed?"PASS":"FAIL")+" frames "+r.framesCompared+" maxPos "+r.maxPositionError.ToString("F4")
                    +" maxYaw "+r.maxYawError.ToString("F3")+" end py "+r.pythonEndReason+"@"+r.pythonEndFrame+" unity "+r.unityEndReason+"@"+r.unityEndFrame+(r.error.Length>0?" error "+r.error:""));
            }
            report.passed=all;
            File.WriteAllText(Path.Combine(outDir,"check.json"),JsonUtility.ToJson(report,true));
            Debug.Log("EventStackCheck: "+(all?"PASSED":"FAILED")+" -> "+Path.Combine(outDir,"check.json"));
            code=all?0:1;
        }
        catch(Exception ex){Debug.LogException(ex);code=1;}
        ReconstructionExit.Quit(code);
    }

    static void Check(string sim,string simDir,Dictionary<string,Round1EnemyWaves.Data> stages,SimResult r)
    {
        var track=JsonUtility.FromJson<SimTrack>(File.ReadAllText(Path.Combine(simDir,sim+".json")));
        r.stage=track.stage;r.definition=track.definition;r.model=track.model;
        if(!stages.TryGetValue(track.stage,out var data))
        {
            string path=Path.Combine(Application.dataPath,"Resources/StageEnemies/"+track.stage+".json");
            data=JsonUtility.FromJson<Round1EnemyWaves.Data>(File.ReadAllText(path));stages[track.stage]=data;
        }
        var d=Array.Find(data.definitions,x=>x.name==track.definition);
        if(d==null)throw new Exception("definition "+track.definition+" not in "+track.stage);
        // The stage JSON stores flag0 as a JSON bool; ActionData.flag0 is an int. Count and repair any parse loss.
        for(int i=0;i<d.events.Length && track.flag0!=null && i<track.flag0.Length;i++)
            if(d.events[i].flag0!=track.flag0[i]){d.events[i].flag0=track.flag0[i];r.flag0Patched++;}
        var routes=new Dictionary<string,Round1EnemyWaves.Route>();
        if(data.routes!=null)foreach(var route in data.routes)if(route!=null && !string.IsNullOrEmpty(route.name))routes[route.name]=route;
        var player=new Vector3(track.player[0],track.player[1],track.player[2]);
        var stack=new Round1EventStack(d,new Vector3(track.spawn[0],track.spawn[1],track.spawn[2]),track.yaw0,track.speed,
            routes,track.model,track.seed,()=>player);
        r.pythonFrames=track.frames;
        while(stack.Frame<track.maxFrames && !stack.Ended)
        {
            stack.Step();
            int k=stack.Frame-1;
            if(k>=track.frames)continue;
            var py=new Vector3(track.x[k],track.y[k],track.z[k]);
            float e=Vector3.Distance(py,stack.Position);
            if(e>r.maxPositionError){r.maxPositionError=e;r.maxPositionErrorFrame=k+1;}
            r.maxYawError=Mathf.Max(r.maxYawError,Mathf.Abs(Mathf.DeltaAngle(track.yaws[k],stack.Yaw)));
            r.framesCompared++;
        }
        r.unityFrames=stack.Frame;
        r.pythonEndReason=track.endReason??"";r.pythonEndFrame=track.endFrame;r.pythonEndTime=track.endFrame<0?-1:track.endFrame/60f;
        r.unityEndReason=stack.Ended?stack.EndReason:"";r.unityEndFrame=stack.Ended?stack.Frame:-1;r.unityEndTime=stack.Ended?stack.Time:-1;
        r.unityFinalPosition=new[]{stack.Position.x,stack.Position.y,stack.Position.z};
        bool sameEnd=r.pythonEndReason==r.unityEndReason && Mathf.Abs(r.pythonEndFrame-r.unityEndFrame)<=1;
        bool ease7=d.placements!=null && d.placements.Length>0 && d.placements[0].easeType==7 && Array.Exists(d.events,e=>e.eventType==15);
        r.passed=r.maxPositionError<(ease7?Ease7PositionError:MaxPositionError) && sameEnd && r.framesCompared>0;
        if(!sameEnd)r.error="end differs";
    }
}
