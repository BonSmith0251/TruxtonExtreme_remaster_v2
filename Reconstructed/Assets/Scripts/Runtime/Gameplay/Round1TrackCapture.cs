using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using UnityEngine;

// Checker capture: records every source-spawned enemy in source units and stage seconds so the remaster
// can be compared with the original game's recording (truxton-track/1). Inactive unless a capture run
// sets Active; the hooks in Round1EnemyWaves/Round1EnemyAttacks are then the only effect.
public sealed class Round1TrackCapture
{
    public static Round1TrackCapture Active;
    public sealed class Sample { public float t,x,y,z,pitch,yaw,roll; }
    public sealed class Mark { public float t;public string type,muzzle; }
    public sealed class Instance
    {
        public int id,index,ordinal;public string key,eventId,definitionId,definition,model,reason;
        public float cue,spawn,despawn=float.NaN,hp;
        public readonly List<Sample> samples=new List<Sample>();public readonly List<Mark> events=new List<Mark>();
    }
    public readonly List<Instance> instances=new List<Instance>();
    public readonly List<string> notes=new List<string>();
    readonly Dictionary<int,Instance> live=new Dictionary<int,Instance>();
    readonly Dictionary<string,int> ordinals=new Dictionary<string,int>();

    public void Birth(int id,Round1EnemyWaves.Event cue,Round1EnemyWaves.Definition definition,string model,float spawn,float health)
    {
        ordinals.TryGetValue(cue.id,out int ordinal);ordinals[cue.id]=ordinal+1;
        var i=new Instance{id=id,index=cue.indexValue,ordinal=ordinal,eventId=cue.id,definitionId=definition.id,definition=definition.name,model=model,
            cue=cue.start,spawn=spawn,hp=health,key="cue"+cue.start.ToString("0.###",CultureInfo.InvariantCulture)+"#"+ordinal};
        live[id]=i;instances.Add(i);
    }
    // An enemy outside the wave schedule (the Round 1 boss): keyed by its definition and spawn time.
    public void BirthUnscheduled(int id,string definition,string model,float spawn,float health)
    {
        var i=new Instance{id=id,index=0,ordinal=0,eventId=definition,definitionId=definition,definition=definition,model=model,cue=spawn,spawn=spawn,hp=health,
            key=definition+"@"+spawn.ToString("0.###",CultureInfo.InvariantCulture)};
        live[id]=i;instances.Add(i);
    }
    public void Record(int id,float t,Vector3 source,Quaternion rotation)
    {
        if(!live.TryGetValue(id,out var i))return;
        if(i.samples.Count>0 && i.samples[i.samples.Count-1].t>=t)return;
        var e=rotation.eulerAngles;
        i.samples.Add(new Sample{t=t,x=source.x,y=source.y,z=source.z,pitch=e.x,yaw=e.y,roll=e.z});
    }
    public void End(int id,bool killed)
    {
        if(!live.TryGetValue(id,out var i))return;live.Remove(id);
        i.reason=killed?"killed":"exit";i.despawn=i.samples.Count>0?i.samples[i.samples.Count-1].t:i.spawn;
        if(killed)i.events.Add(new Mark{t=i.despawn,type="killed"});
    }
    public void Fire(int id,float t,string type,string muzzle)
    {
        if(live.TryGetValue(id,out var i))i.events.Add(new Mark{t=t,type=type,muzzle=muzzle});
    }
    public void CloseAll(string reason)
    {
        foreach(var i in live.Values){i.reason=reason;i.despawn=i.samples.Count>0?i.samples[i.samples.Count-1].t:i.spawn;}
        live.Clear();
    }

    // All instances in one document; extractor/unity-checker/build_capture.py cuts it into subjects.
    public string ToJson(string project,float seconds,string playerPath)
    {
        var s=new StringBuilder(1<<20);
        s.Append("{\"schema\":\"truxton-remaster-capture/1\",\"frame\":\"source-xz\",\"timeBase\":\"stage-seconds\",\"stage\":\"BG03\",\"round\":1,");
        s.Append("\"project\":").Append(Str(project)).Append(",\"seconds\":").Append(Num(seconds)).Append(",\"playerPath\":").Append(Str(playerPath));
        s.Append(",\"notes\":[");for(int n=0;n<notes.Count;n++){if(n>0)s.Append(',');s.Append(Str(notes[n]));}
        s.Append("],\"instances\":[\n");
        for(int n=0;n<instances.Count;n++)
        {
            var i=instances[n];if(n>0)s.Append(",\n");
            s.Append("{\"key\":").Append(Str(i.key)).Append(",\"cue\":").Append(Num(i.cue)).Append(",\"index\":").Append(i.index)
             .Append(",\"event\":").Append(Str(i.eventId)).Append(",\"enemyData\":").Append(Str(i.definition)).Append(",\"identity\":").Append(Str(i.definitionId))
             .Append(",\"model\":").Append(Str(i.model)).Append(",\"spawn\":").Append(Num(i.spawn)).Append(",\"despawn\":").Append(Num(i.despawn))
             .Append(",\"despawnReason\":").Append(Str(i.reason)).Append(",\"hp\":").Append(Num(i.hp)).Append(",\"samples\":[");
            for(int k=0;k<i.samples.Count;k++)
            {
                var p=i.samples[k];if(k>0)s.Append(',');
                s.Append("{\"t\":").Append(Num(p.t)).Append(",\"x\":").Append(Num(p.x)).Append(",\"y\":").Append(Num(p.y)).Append(",\"z\":").Append(Num(p.z))
                 .Append(",\"pitch\":").Append(Num(p.pitch)).Append(",\"yaw\":").Append(Num(p.yaw)).Append(",\"roll\":").Append(Num(p.roll)).Append('}');
            }
            s.Append("],\"events\":[");
            for(int k=0;k<i.events.Count;k++)
            {
                var e=i.events[k];if(k>0)s.Append(',');
                s.Append("{\"t\":").Append(Num(e.t)).Append(",\"type\":").Append(Str(e.type)).Append(",\"muzzle\":null,\"muzzleName\":").Append(Str(e.muzzle)).Append('}');
            }
            s.Append("]}");
        }
        return s.Append("\n]}\n").ToString();
    }
    static string Num(float v)=>float.IsNaN(v) || float.IsInfinity(v)?"null":Math.Round(v,4).ToString("0.####",CultureInfo.InvariantCulture);
    static string Str(string v)
    {
        if(v==null)return "null";
        var s=new StringBuilder("\"");
        foreach(char c in v)
        {
            if(c=='"' || c=='\\')s.Append('\\').Append(c);
            else if(c<' ')s.Append("\\u").Append(((int)c).ToString("x4"));
            else s.Append(c);
        }
        return s.Append('"').ToString();
    }
}
