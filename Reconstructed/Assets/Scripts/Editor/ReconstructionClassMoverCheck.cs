using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using UnityEngine;

// Verification only: replays the class-mover tracks of the Python frame model (evidence/movers/Ene_<Class>/sims/*.txt,
// written by evidence/movers/Ene_St01/tools/movers_sim.py) through Round1EventStack's class movers (St01, Ss01, So01).
// Pass per sim: max position error < 0.05 source units, max yaw error < 0.5 deg, end frame within 1 frame.
// Writes D:/games/TruxtonExRecon/verification/movers/class-check.json and exits 0 (all pass) or 1.
// Run: Unity.exe -batchmode -projectPath ... -executeMethod ReconstructionClassMoverCheck.Run
public static class ReconstructionClassMoverCheck
{
    const string Root="D:/games/TruxtonExRecon/";
    const float MaxPositionError=.05f,MaxYawError=.5f;
    // mg01_sim.py takes the lookAt-1 tangent as a +0.002 forward difference, Round1EventStack (like air_sim.py) as a
    // +-0.01 central one: on the tight route loops the noses differ by up to ~3 deg. Not a native difference.
    const float MgYawError=4f;
    // Mk01's (and X01's route-mode ease 7) InOutSine runs through the 0.1 deg Cosf table: mk01_sim.py forms the index in double, the port (like the
    // native code) in float32, so one table step can differ: up to 0.5*0.00175*120 = 0.105 units on the 120-unit legs.
    const float MkPositionError=.11f;
    // m7_sim.py moves Sq01's stack SplineMove with the exact InOutSine (air_sim.ease), the port with the native Cosf table
    // (Ene_Sq01/SPEC.md: Ease(7)); on the 388.6-unit move_sq01_dl the two curves are up to 0.339 units apart.
    const float Sq01PositionError=.34f;
    // sim file, stage, definition name, spawn, indexValue
    static readonly (string file,string stage,string definition,Vector3 spawn,int index)[] Sims={
        ("Ene_St01/sims/st01_BG01_t5_spawn_0_100.txt","BG01","default_St01",new Vector3(0,0,100),1),
        ("Ene_St01/sims/st01_index0_blowback.txt","BG01","default_St01",new Vector3(0,0,100),0),
        ("Ene_Ss01/sims/ss01_BG06_t365.txt","BG06","ene_ss01",new Vector3(0,0,0),0),
        ("Ene_So01/sims/so01_1_BG01_t35_clip80.txt","BG01","ene_so01_1",new Vector3(54.41f,0,116.95f),0),
        ("Ene_Mg01/sims/mg01_1a_BG04.txt","BG04","ene_mg01_1a",new Vector3(-226,0,-15),1),
        ("Ene_Mk01/sims/mk01a_BG05.txt","BG05","ene_mk01a",new Vector3(-30,0,150),0),
        ("Ene_Mk01/sims/mk01b_BG05.txt","BG05","ene_mk01b",new Vector3(30,0,150),1),
        // SplineMover route mode (evidence/movers/tools/m7_sim.py --json tracks)
        ("Ene_Mx02/sims/mx02_1a_BG08_t5.json","BG08","ene_mx02_1a",new Vector3(0,0,105),0),
        ("Ene_X01/sims/x01_BG01_t260.json","BG01","ene_x01",new Vector3(0,0,150),0),
        ("Ene_Mp02/sims/mp02a_BG01_idx2.json","BG01","ene_mp02a",new Vector3(-220,0,0),2),
        ("Ene_Mp02/sims/mp02b_BG01_idx1.json","BG01","ene_mp02b",new Vector3(40,0,150),1),
        // stack + route (evidence/movers/Ene_Sf01/sf01_sim.py)
        ("Ene_Sf01/sims/sf01_5b3_BG05.json","BG05","ene_sf01_5b3",new Vector3(20,0,120),0),
        ("Ene_Sf01/sims/sr01_1b_BG06.json","BG06","ene_sr01_1b",new Vector3(-50,0,98),0),
        // class programs: the definition's empty events replaced by the class's static list (m7_sim.py)
        ("Ene_Sq01/sims/sq01_BG06_idx2.json","BG06","ene_sq01",new Vector3(20,0,100),2),
        ("Ene_Sq01/sims/sq01_BG06_idx3.json","BG06","ene_sq01",new Vector3(-20,0,100),3),
        ("Ene_Mb01/sims/mb01_BG06_t7.json","BG06","ene_mb01",new Vector3(-50,0,140),0),
    };
    static readonly Vector3 Player=new Vector3(0,0,-49);

    [Serializable] public class SimResult
    {
        public string sim,definition,model,error="",unityEndReason;
        public bool passed;
        public int rowsCompared,pythonEndFrame,unityEndFrame,maxPositionErrorFrame,maxYawErrorFrame;public float yawAtMax,pythonYawAtMax;
        public float maxPositionError,maxYawError;
    }
    [Serializable] public class Report { public bool passed;public string generated;public List<SimResult> sims=new List<SimResult>(); }

    public static void Run()
    {
        var report=new Report{generated=DateTime.Now.ToString("s")};bool all=true;
        foreach(var s in Sims)
        {
            var r=new SimResult{sim=s.file,definition=s.definition};
            try{Check(s,r);}catch(Exception e){r.error=e.ToString();r.passed=false;}
            all&=r.passed;report.sims.Add(r);
            Debug.Log($"[ClassMoverCheck] {s.file}: {(r.passed?"pass":"FAIL")} rows {r.rowsCompared} pos {r.maxPositionError:0.0000} yaw {r.maxYawError:0.00} end {r.pythonEndFrame}/{r.unityEndFrame} yawframe {r.maxYawErrorFrame} {r.yawAtMax:0.0}/{r.pythonYawAtMax:0.0} {r.error}");
        }
        report.passed=all;
        Directory.CreateDirectory(Root+"verification/movers");
        File.WriteAllText(Root+"verification/movers/class-check.json",JsonUtility.ToJson(report,true));
        ReconstructionExit.Quit(all?0:1);
    }

    static void Check((string file,string stage,string definition,Vector3 spawn,int index) s,SimResult r)
    {
        var data=JsonUtility.FromJson<Round1EnemyWaves.Data>(File.ReadAllText(Root+"Reconstructed/Assets/Resources/StageEnemies/"+s.stage+".json"));
        var d=Array.Find(data.definitions,x=>x.name==s.definition);if(d==null)throw new Exception("no definition "+s.definition);
        r.model=d.model;var pl=d.placements[0];d=Round1EventStack.WithClassProgram(d,d.model,s.index);var routes=new Dictionary<string,Round1EnemyWaves.Route>();
        foreach(var route in data.routes)routes[route.name]=route;
        foreach(var route in JsonUtility.FromJson<Round1EnemyWaves.Data>(File.ReadAllText(Root+"Reconstructed/Assets/Resources/StageEnemies/class-routes.json")).routes)
            if(!routes.ContainsKey(route.name))routes[route.name]=route;
        var stack=new Round1EventStack(d,s.spawn,pl.rotate.y,pl.moveSpeed,routes,d.model,1,()=>Player,s.index);
        // Track rows: frame t x y z yaw ... (state after `frame` steps); the removal event gives the end time.
        var rows=new List<(int frame,float x,float z,float yaw)>();bool track=false;float removed=-1;
        if(s.file.EndsWith(".json"))
        {   // {"end": ..., "frames": n, "track": [[t, x, y, z, yaw, speed], ...]}: row i is after i+1 steps; the end comes one step later
            var text=File.ReadAllText(Root+"evidence/movers/"+s.file);int i=0;
            foreach(System.Text.RegularExpressions.Match t in System.Text.RegularExpressions.Regex.Matches(text,@"\[([-\d.e]+), ([-\d.e]+), ([-\d.e]+), ([-\d.e]+), ([-\d.e]+), ([-\d.e]+)(?:, [-\d.e]+)*\]"))
                rows.Add((++i,P(t.Groups[2].Value),P(t.Groups[4].Value),P(t.Groups[5].Value)));
            if(text.Contains("route-end"))removed=i/60f;
            else if(text.Contains("events-exhausted") || text.Contains("finish-destroy"))removed=(i-1)/60f;   // stack ends: the last row is the removal step
        }
        else foreach(var line in File.ReadAllLines(Root+"evidence/movers/"+s.file))
        {
            if(line.StartsWith("-- track")){track=true;continue;}
            var m=System.Text.RegularExpressions.Regex.Match(line,@"^\s+t=\s*([\d.]+) pos=\(\s*([-\d.]+),\s*([-\d.]+)\) yaw=\s*([-\d.]+)");
            var tr=System.Text.RegularExpressions.Regex.Match(line,@"^\s+\(([-\d.]+), ([-\d.]+), ([-\d.]+), ([-\d.]+), \d+\)");
            if(tr.Success){rows.Add((Mathf.RoundToInt(P(tr.Groups[1].Value)*60),P(tr.Groups[2].Value),P(tr.Groups[3].Value),P(tr.Groups[4].Value)));continue;}
            if(m.Success){rows.Add((Mathf.RoundToInt(P(m.Groups[1].Value)*60),P(m.Groups[2].Value),P(m.Groups[3].Value),P(m.Groups[4].Value)));continue;}
            if(line.Contains("EndRoute")){removed=P(line.Trim().Split(' ')[0])-1f/60;continue;}   // mg01_sim stamps the end after the step
            var f=line.Split((char[])null,StringSplitOptions.RemoveEmptyEntries);
            if(!track){if(line.Contains("CallDisabled") || line.Contains("removed"))removed=float.Parse(f[0],CultureInfo.InvariantCulture);continue;}
            if(f.Length<6 || !int.TryParse(f[0],out int frame))continue;
            rows.Add((frame,P(f[2]),P(f[4]),P(f[5])));
        }
        int k=0;
        for(int step=1;k<rows.Count && step<=20000 && !stack.Ended;step++)
        {
            stack.Step();
            while(k<rows.Count && rows[k].frame==step)
            {
                var row=rows[k++];var p=stack.Position;
                float e=new Vector2(p.x-row.x,p.z-row.z).magnitude,ye=Mathf.Abs(Mathf.DeltaAngle(stack.Yaw+(stack.ChildEulers.TryGetValue("pf_ene_sf01",out var ce)?ce.y:0),row.yaw));   // sf01_sim: root + child yaw
                if(e>r.maxPositionError){r.maxPositionError=e;r.maxPositionErrorFrame=step;}
                if(ye>r.maxYawError){r.maxYawError=ye;r.maxYawErrorFrame=step;r.yawAtMax=stack.Yaw;r.pythonYawAtMax=row.yaw;}r.rowsCompared++;
            }
        }
        while(!stack.Ended && stack.Frame<20000)stack.Step();
        r.unityEndFrame=stack.Frame;r.unityEndReason=stack.EndReason;
        r.pythonEndFrame=removed<0?-1:Mathf.RoundToInt(removed*60)+1;   // the removal happens in the step that starts at t
        r.passed=r.rowsCompared>0 && r.maxPositionError<(s.file.Contains("Mk01") || s.file.Contains("X01")?MkPositionError:s.file.Contains("Sq01")?Sq01PositionError:MaxPositionError) && r.maxYawError<(s.file.Contains("Mg01")?MgYawError:MaxYawError) && Mathf.Abs(r.unityEndFrame-r.pythonEndFrame)<=1;
    }
    static float P(string v)=>float.Parse(v,CultureInfo.InvariantCulture);
}
