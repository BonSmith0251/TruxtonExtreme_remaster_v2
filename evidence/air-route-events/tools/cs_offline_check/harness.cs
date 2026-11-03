using System;using System.Collections.Generic;using System.IO;using System.Text.Json;using UnityEngine;
static class H{
 static Vector3 V(JsonElement e)=>new Vector3((float)e.GetProperty("x").GetDouble(),(float)e.GetProperty("y").GetDouble(),(float)e.GetProperty("z").GetDouble());
 static float F(JsonElement e,string n)=>(float)e.GetProperty(n).GetDouble();
 static int I(JsonElement e,string n)=>e.GetProperty(n).GetInt32();
 static string S(JsonElement e,string n)=>e.TryGetProperty(n,out var v)&&v.ValueKind==JsonValueKind.String?v.GetString():null;
 static int Main(string[] a){
  string simDir=a[0],stageDir=a[1];bool all=true;
  foreach(var file in Directory.GetFiles(simDir,"*.json")){
   var t=JsonDocument.Parse(File.ReadAllText(file)).RootElement;
   var st=JsonDocument.Parse(File.ReadAllText(Path.Combine(stageDir,t.GetProperty("stage").GetString()+".json"))).RootElement;
   Round1EnemyWaves.Definition d=null;
   foreach(var de in st.GetProperty("definitions").EnumerateArray()){
     if(de.GetProperty("name").GetString()!=t.GetProperty("definition").GetString())continue;
     d=new Round1EnemyWaves.Definition{name=S(de,"name"),model=S(de,"model"),attribute=I(de,"attribute"),position=V(de.GetProperty("position"))};
     var pls=new List<Round1EnemyWaves.Placement>();foreach(var p in de.GetProperty("placements").EnumerateArray())pls.Add(new Round1EnemyWaves.Placement{lookAt=I(p,"lookAt"),easeType=I(p,"easeType"),moveSpeed=F(p,"moveSpeed")});
     d.placements=pls.ToArray();
     var evs=new List<Round1EnemyWaves.ActionData>();
     foreach(var e in de.GetProperty("events").EnumerateArray())evs.Add(new Round1EnemyWaves.ActionData{eventType=I(e,"eventType"),repeatCount=I(e,"repeatCount"),intValue1=I(e,"intValue1"),
       flag0=e.GetProperty("flag0").GetBoolean()?1:0,repeatDelay=F(e,"repeatDelay"),value0=F(e,"value0"),value1=F(e,"value1"),dotime=F(e,"dotime"),randomFire=F(e,"randomFire"),
       vectorValue=V(e.GetProperty("vectorValue")),stringValue=S(e,"stringValue"),nameValue=S(e,"nameValue")});
     d.events=evs.ToArray();var rl=new List<string>();foreach(var r in de.GetProperty("routes").EnumerateArray())rl.Add(r.GetString());d.routes=rl.ToArray();
   }
   var routes=new Dictionary<string,Round1EnemyWaves.Route>();
   foreach(var r in st.GetProperty("routes").EnumerateArray()){var tl=new List<float>();foreach(var x in r.GetProperty("times").EnumerateArray())tl.Add((float)x.GetDouble());
     var pl=new List<Vector3>();foreach(var x in r.GetProperty("points").EnumerateArray())pl.Add(V(x));routes[r.GetProperty("name").GetString()]=new Round1EnemyWaves.Route{name=r.GetProperty("name").GetString(),times=tl.ToArray(),points=pl.ToArray()};}
   float[] Arr(string n){var l=new List<float>();foreach(var x in t.GetProperty(n).EnumerateArray())l.Add((float)x.GetDouble());return l.ToArray();}
   var sp=Arr("spawn");var pv=Arr("player");var X=Arr("x");var Y=Arr("y");var Z=Arr("z");var W=Arr("yaws");var player=new Vector3(pv[0],pv[1],pv[2]);
   var s=new Round1EventStack(d,new Vector3(sp[0],sp[1],sp[2]),F(t,"yaw0"),F(t,"speed"),routes,t.GetProperty("model").GetString(),I(t,"seed"),()=>player);
   int max=I(t,"maxFrames"),frames=I(t,"frames");float mp=0,my=0;int mpf=0;
   var dump=Environment.GetEnvironmentVariable("DUMP")==Path.GetFileNameWithoutExtension(file);while(s.Frame<max&&!s.Ended){s.Step();int k=s.Frame-1;if(dump&&k>=110&&k<135)Console.WriteLine($"cs {k+1} {s.Position.x:F4} {s.Position.z:F4} {s.Yaw:F3} | py {(k<frames?X[k]:0):F4} {(k<frames?Z[k]:0):F4} {(k<frames?W[k]:0):F3}");if(k>=frames)continue;float e=Vector3.Distance(new Vector3(X[k],Y[k],Z[k]),s.Position);if(e>mp){mp=e;mpf=k+1;}my=Mathf.Max(my,Mathf.Abs(Mathf.DeltaAngle(W[k],s.Yaw)));}
   string per=t.GetProperty("endReason").GetString();int pef=I(t,"endFrame");string ur=s.Ended?s.EndReason:"";int uef=s.Ended?s.Frame:-1;
   bool ok=mp<.05f&&per==ur&&Math.Abs(pef-uef)<=1;all&=ok;
   Console.WriteLine($"{Path.GetFileNameWithoutExtension(file),-18} {(ok?"PASS":"FAIL")} applies={Round1EventStack.Applies(d)} frames {frames}/{s.Frame} maxPos {mp:F5}@{mpf} maxYaw {my:F4} end py {per}@{pef} cs {ur}@{uef}");
  }
  return all?0:1;}
}
