using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine;

// Verification only: replays the Python models of the class movers in Round1EventStackGroups (evidence/movers/Ene_<Class>/
// *_sim.py text tracks) through Round1EventStack and compares them. Ene_Mm01: root and both halves; Ene_Ml01 (no food):
// position and yaw; Ene_Mn01h: core z and _modelTop yaw; Ene_Mc01: route positions and the mc01_fire1 frames.
// Si01 and the Mn01c bits draw UnityEngine.Random values the sims choose differently: not replayed here.
// Pass per sim: max position error < 0.05 (0.11 on InOutSine routes), yaw < 0.5 deg, end frames and fire frames within 1.
// Writes D:/games/TruxtonExRecon/verification/movers/group-check.json and exits 0 (all pass) or 1.
// Run: Unity.exe -batchmode -projectPath ... -executeMethod ReconstructionGroupMoverCheck.Run
public static class ReconstructionGroupMoverCheck
{
    const string Root="D:/games/TruxtonExRecon/";
    static readonly Vector3 Player=new Vector3(0,0,-49);
    enum Kind { Mm01,Ml01,Mn01h,Mc01 }
    static readonly (string file,Kind kind,string stage,string definition,Vector3 spawn,int index,float positionError)[] Sims={
        ("Ene_Mm01/sims/mm01h_BG05_t55.txt",Kind.Mm01,"BG05","ene_mm01h",Vector3.zero,0,.05f),
        ("Ene_Mm01/sims/mm01v_BG05_t300.txt",Kind.Mm01,"BG05","ene_mm01v",Vector3.zero,1,.05f),
        ("Ene_Mm01/sims/mm0A_BG05_t33_up.txt",Kind.Mm01,"BG05","ene_mm0A",new Vector3(-40,150,0),2,.05f),
        ("Ene_Ml01/sims/ml01_BG04_nofood.txt",Kind.Ml01,"BG04","ene_ml01",new Vector3(0,0,150),0,.05f),
        ("Ene_Ml01/sims/ml01_BG04_static5.txt",Kind.Ml01,"BG04","ene_ml01",new Vector3(0,0,150),0,.05f),
        ("Ene_Mn01h/sims/mn01h_BG06_x0.txt",Kind.Mn01h,"BG06","ene_mn0X",Vector3.zero,0,.05f),
        ("Ene_Mc01/sims/mc01_1aA_BG07.txt",Kind.Mc01,"BG07","ene_mc01_1aA",new Vector3(0,0,165),0,.11f),
    };

    [Serializable] public class SimResult
    {
        public string sim,definition,model,error="",unityEndReason;
        public bool passed;
        public int rowsCompared,pythonEndFrame,unityEndFrame,maxPositionErrorFrame,firesCompared,fireFrameMismatches,pythonEaten,unityEaten;
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
            Debug.Log($"[GroupMoverCheck] {s.file}: {(r.passed?"pass":"FAIL")} rows {r.rowsCompared} pos {r.maxPositionError:0.0000}@{r.maxPositionErrorFrame} yaw {r.maxYawError:0.00} end {r.pythonEndFrame}/{r.unityEndFrame} ({r.unityEndReason}) fires {r.firesCompared}/{r.fireFrameMismatches} eaten {r.pythonEaten}/{r.unityEaten} {r.error}");
        }
        report.passed=all;
        Directory.CreateDirectory(Root+"verification/movers");
        File.WriteAllText(Root+"verification/movers/group-check.json",JsonUtility.ToJson(report,true));
        ReconstructionExit.Quit(all?0:1);
    }

    sealed class Row { public int frame;public Vector2[] points;public float yaw=float.NaN; }
    static readonly string Num=@"\s*(-?[\d.]+)";

    static void Check((string file,Kind kind,string stage,string definition,Vector3 spawn,int index,float positionError) s,SimResult r)
    {
        var data=JsonUtility.FromJson<Round1EnemyWaves.Data>(File.ReadAllText(Root+"Reconstructed/Assets/Resources/StageEnemies/"+s.stage+".json"));
        var d=Array.Find(data.definitions,x=>x.name==s.definition);if(d==null)throw new Exception("no definition "+s.definition);
        r.model=d.model;var pl=d.placements[0];var routes=new Dictionary<string,Round1EnemyWaves.Route>();
        foreach(var route in data.routes)routes[route.name]=route;
        var stack=new Round1EventStack(d,s.spawn,pl.rotate.y,pl.moveSpeed,routes,d.model,1,()=>Player,s.index);
        // ml01_sim.py's static foods: Pf_Ene_Sj01 that are never stepped (they stand still until eaten).
        var foods=new List<Round1EventStack>();
        if(s.file.Contains("static5"))foreach(var f in new[]{new Vector3(-40,0,40),new Vector3(-20,0,50),new Vector3(0,0,40),new Vector3(20,0,50),new Vector3(40,0,40)})
            foods.Add(new Round1EventStack(Food,f,0,0,routes,"Pf_Ene_Sj01",1,()=>Player));
        if(s.kind==Kind.Ml01)stack.SetFood(foods);

        var rows=new List<Row>();var fires=new List<int>();float removed=-1;
        foreach(var line in File.ReadAllLines(Root+"evidence/movers/"+s.file))
        {
            Match m;
            switch(s.kind)
            {
                case Kind.Mm01:   // "  0.250  st 1  root (x, z)  R (x, z)  L (x, z)"; the end: "... EndRoute ..."
                    m=Regex.Match(line,@"^\s+([\d.]+)\s+st\s*\d+\s+root \("+Num+","+Num+@"\)\s+R \("+Num+","+Num+@"\)\s+L \("+Num+","+Num+@"\)");
                    if(m.Success)rows.Add(new Row{frame=Frame(m.Groups[1].Value),points=new[]{V(m,2),V(m,4),V(m,6)}});
                    else if(line.Contains("EndRoute"))removed=P(line.Trim().Split(' ')[0]);
                    break;
                case Kind.Ml01:   // "   (0.100, 0.00, 154.17, 0.0, 50.0, 2)"; the end: "  0.167  end (state 9)"
                    m=Regex.Match(line,@"^\s+\(([\d.]+),"+Num+","+Num+","+Num+",");
                    if(m.Success)rows.Add(new Row{frame=Frame(m.Groups[1].Value),points=new[]{V(m,2)},yaw=P(m.Groups[4].Value)});
                    else if(Regex.IsMatch(line,@"^\s+[\d.]+\s+end \(state 9\)"))removed=P(line.Trim().Split(' ')[0])-1f/60;   // stamped after the step
                    else if(line.Contains("ate food"))r.pythonEaten++;
                    break;
                case Kind.Mn01h:  // "   (0.5, 99.77, 16.0, [...])"; the end: "10.550 Mn01h CallDisabled"
                    m=Regex.Match(line,@"^\s+\(([\d.]+),"+Num+","+Num+",");
                    if(m.Success)rows.Add(new Row{frame=Frame(m.Groups[1].Value),points=new[]{new Vector2(float.NaN,P(m.Groups[2].Value))},yaw=P(m.Groups[3].Value)});
                    else if(line.Contains("Mn01h CallDisabled"))removed=P(line.Trim().Split(' ')[0]);
                    break;
                case Kind.Mc01:   // "   0.500  (   0.00,  157.46)  r0", " 0.400 fire mc01_fire1 ...", "21.667 last route done -> EndRoute"
                    m=Regex.Match(line,@"^\s+([\d.]+)\s+\("+Num+","+Num+@"\)\s+r\d");
                    if(m.Success)rows.Add(new Row{frame=Frame(m.Groups[1].Value),points=new[]{V(m,2)}});
                    else if(line.Contains(" fire mc01_fire1"))fires.Add(Frame(line.Trim().Split(' ')[0])+1);   // logged at the step's start time
                    else if(line.Contains("EndRoute"))removed=P(line.Trim().Split(' ')[0]);
                    break;
            }
        }
        if(rows.Count==0)throw new Exception("no track rows parsed");

        // The port's state, per step (index = steps taken).
        var unityFires=new List<int>();var states=new List<(Vector2[] points,float yaw)>{(null,0)};
        int lastFrame=removed<0?rows[rows.Count-1].frame:20000;   // no removal in the sim: replay as long as its track
        for(int step=1;step<=lastFrame && !stack.Ended;step++)
        {
            stack.Step();
            foreach(var shot in stack.Shots)if(shot.pattern=="mc01_fire1")unityFires.Add(step);
            stack.Shots.Clear();
            var p=stack.Position;var got=new List<Vector2>{new Vector2(p.x,p.z)};
            if(s.kind==Kind.Mm01){var a=p+stack.HalfOffset(1);var b=p+stack.HalfOffset(0);got.Add(new Vector2(a.x,a.z));got.Add(new Vector2(b.x,b.z));}
            states.Add((got.ToArray(),s.kind==Kind.Mn01h?stack.CoreEuler.y:stack.Yaw));
        }
        // Mm01's state timers are float32 sums of dt (as natively); mm01_sim.py sums in double, so its 0.5 s / 1 s thresholds
        // fall one frame apart from the port's (0.5 one frame earlier, 1.0 one later): compare its rows within one frame.
        int window=s.kind==Kind.Mm01?1:0;
        foreach(var row in rows)
        {
            if(row.frame<1 || row.frame>=states.Count)continue;
            float best=float.MaxValue,bestYaw=float.MaxValue;
            for(int f=Mathf.Max(1,row.frame-window);f<=Mathf.Min(states.Count-1,row.frame+window);f++)
            {
                float e=0;
                for(int i=0;i<row.points.Length;i++){var want=row.points[i];var g=states[f].points[i];e=Mathf.Max(e,float.IsNaN(want.x)?Mathf.Abs(g.y-want.y):(g-want).magnitude);}
                best=Mathf.Min(best,e);
                if(!float.IsNaN(row.yaw))bestYaw=Mathf.Min(bestYaw,Mathf.Abs(Mathf.DeltaAngle(states[f].yaw,row.yaw)));
            }
            if(best>r.maxPositionError){r.maxPositionError=best;r.maxPositionErrorFrame=row.frame;}
            if(!float.IsNaN(row.yaw))r.maxYawError=Mathf.Max(r.maxYawError,bestYaw);
            r.rowsCompared++;
        }
        r.unityEndFrame=stack.Ended?stack.Frame:-1;r.unityEndReason=stack.EndReason;
        r.pythonEndFrame=removed<0?-1:Mathf.RoundToInt(removed*60)+1;   // the removal happens in the step that starts at t
        if(s.kind==Kind.Ml01)r.unityEaten=stack.FoodEaten;
        if(s.kind==Kind.Mc01)
        {   // every Python fire frame needs a port fire within one frame, and the counts agree up to the end
            r.firesCompared=fires.Count;
            foreach(int f in fires)if(!unityFires.Exists(u=>Mathf.Abs(u-f)<=1))r.fireFrameMismatches++;
            r.fireFrameMismatches+=Mathf.Abs(unityFires.Count-fires.Count);
        }
        r.passed=r.rowsCompared>0 && r.maxPositionError<s.positionError && r.maxYawError<.5f && Mathf.Abs(r.unityEndFrame-r.pythonEndFrame)<=1+window && r.fireFrameMismatches==0 && r.unityEaten==r.pythonEaten;
    }
    static readonly Round1EnemyWaves.Definition Food=new Round1EnemyWaves.Definition{name="static_food",model="Pf_Ene_Sj01",
        events=new Round1EnemyWaves.ActionData[0],routes=new string[0],placements=new[]{new Round1EnemyWaves.Placement()},repeats=new Round1EnemyWaves.Repeat[0]};
    static int Frame(string t)=>Mathf.RoundToInt(P(t)*60);
    static Vector2 V(Match m,int g)=>new Vector2(P(m.Groups[g].Value),P(m.Groups[g+1].Value));
    static float P(string v)=>float.Parse(v,CultureInfo.InvariantCulture);
}
