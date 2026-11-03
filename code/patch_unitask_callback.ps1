$ErrorActionPreference='Stop'
$cecil='D:\games\Endless Rails 1-0\game\recovery\tools\ilspycmd\tools\net6.0\any\Mono.Cecil.dll'
Add-Type -Path $cecil
Add-Type -ReferencedAssemblies $cecil,'System.Web.Extensions','C:\Windows\Microsoft.NET\Framework64\v4.0.30319\netstandard.dll' -TypeDefinition @"
using System;using System.IO;using System.Linq;using System.Collections.Generic;using System.Web.Script.Serialization;using System.Security.Cryptography;using Mono.Cecil;
public static class ParticleCallbackCompat {
 static string H(string p){using(var s=File.OpenRead(p))using(var h=SHA256.Create())return BitConverter.ToString(h.ComputeHash(s)).Replace("-","").ToLowerInvariant();}
 static IEnumerable<TypeDefinition> All(TypeDefinition t){yield return t;foreach(var n in t.NestedTypes)foreach(var x in All(n))yield return x;}
 static string Shape(AssemblyDefinition a){return string.Join("\n",a.MainModule.Types.SelectMany(All).SelectMany(t=>new[]{"T:"+t.FullName+":"+t.Attributes+":"+t.BaseType}.Concat(t.Fields.Select(f=>"F:"+f.FullName+":"+f.Attributes)).Concat(t.Methods.Select(m=>"M:"+m.FullName+":"+m.Attributes+":"+(m.HasBody?string.Join(";",m.Body.Instructions):""))).Concat(t.Interfaces.Select(x=>"I:"+x.InterfaceType.FullName))));}
 public static void Run(string root,string project){
 string plugins=Path.Combine(project,"Assets/OriginalRecovered/Plugins"),source=Path.Combine(plugins,"UniTask.dll"),baseline=Path.Combine(root,"baseline/UniTask.dll"),output=Path.Combine(root,"patched/UniTask.dll");
 Directory.CreateDirectory(Path.GetDirectoryName(baseline));Directory.CreateDirectory(Path.GetDirectoryName(output));File.Copy(source,baseline,true);
 var refs=new List<object>();var calls=new List<object>();var strings=new List<object>();var audited=new List<object>();
 var files=Directory.GetFiles(Path.Combine(project,"Assets"),"*.dll",SearchOption.AllDirectories).Concat(Directory.GetFiles(Path.Combine(project,"Library/ScriptAssemblies"),"*.dll")).Distinct().ToArray();
 foreach(var file in files)using(var asm=AssemblyDefinition.ReadAssembly(file)){
 audited.Add(new{path=file,sha256=H(file),assembly=asm.Name.Name});
 foreach(var r in asm.MainModule.GetMemberReferences())if(r.FullName.Contains("ParticleUpdateJobScheduled"))refs.Add(new{assembly=asm.Name.Name,reference=r.FullName});
 foreach(var r in asm.MainModule.GetTypeReferences())if(r.FullName.Contains("ParticleUpdateJobScheduled"))refs.Add(new{assembly=asm.Name.Name,reference=r.FullName});
 foreach(var m in asm.MainModule.Types.SelectMany(All).SelectMany(t=>t.Methods).Where(m=>m.HasBody))foreach(var i in m.Body.Instructions){var mr=i.Operand as MethodReference;if(mr!=null&&mr.FullName.Contains("ParticleUpdateJobScheduled"))calls.Add(new{assembly=asm.Name.Name,caller=m.FullName,operand=mr.FullName});var s=i.Operand as string;if(s!=null&&s.Contains("ParticleUpdateJobScheduled"))strings.Add(new{assembly=asm.Name.Name,caller=m.FullName,value=s});}
 }
 if(refs.Count!=0||calls.Count!=0||strings.Count!=0)throw new Exception("Consumed trigger reference found; refuse compatibility rename.");
 var resolver=new DefaultAssemblyResolver();resolver.AddSearchDirectory(plugins);resolver.AddSearchDirectory("D:/Games/TruxtonExRecon/code/metadata-assemblies");
 string oldName="OnParticleUpdateJobScheduled",newName="UnsupportedParticleJobDataCallback";string oldSignature,newSignature;int token;string[] il;string before,after;int typeCount,methodCount;string[] assemblyRefs;
 using(var a=AssemblyDefinition.ReadAssembly(baseline,new ReaderParameters(){AssemblyResolver=resolver})){
 var t=a.MainModule.Types.Single(x=>x.FullName=="Cysharp.Threading.Tasks.Triggers.AsyncParticleUpdateJobScheduledTrigger");var m=t.Methods.Single(x=>x.Name==oldName);
 if(!m.IsPrivate||m.IsStatic||m.Parameters.Count!=1||m.Parameters[0].ParameterType.FullName!="UnityEngine.ParticleSystemJobs.ParticleSystemJobData"||m.ReturnType.FullName!="System.Void"||m.Body.Instructions.Count!=1||m.Body.Instructions[0].OpCode.Code!=Mono.Cecil.Cil.Code.Ret)throw new Exception("Unexpected callback shape");
 before=Shape(a);oldSignature=m.FullName;token=m.MetadataToken.ToInt32();il=m.Body.Instructions.Select(x=>x.ToString()).ToArray();typeCount=a.MainModule.Types.SelectMany(All).Count();methodCount=a.MainModule.Types.SelectMany(All).Sum(x=>x.Methods.Count);assemblyRefs=a.MainModule.AssemblyReferences.Select(x=>x.FullName).ToArray();m.Name=newName;newSignature=m.FullName;after=Shape(a);if(before.Replace(oldSignature,newSignature)!=after)throw new Exception("Unexpected metadata change");if(a.MainModule.AssemblyReferences.Any(x=>x.Name==a.Name.Name))throw new Exception("Self reference");a.Write(output);
 }
 using(var a=AssemblyDefinition.ReadAssembly(output)){if(Shape(a)!=after)throw new Exception("Roundtrip changed structure or IL");if(!assemblyRefs.SequenceEqual(a.MainModule.AssemblyReferences.Select(x=>x.FullName)))throw new Exception("Reference changes");}
 var report=new{classification="Compatibility-only private callback rename; unsupported optional trigger, zero behavior recovery",sourceTarget=source,baselineSha256=H(baseline),output=output,outputSha256=H(output),targetUnchanged=H(source)==H(baseline),before=oldSignature,after=newSignature,exportedMethodToken="0x"+token.ToString("X8"),beforeIL=il,afterIL=il,types=typeCount,methods=methodCount,metadataChanges="Exactly one private method name. All type/field/public API/inheritance/assembly references/method bodies unchanged.",auditedAssemblies=audited,triggerReferences=refs,directCalls=calls,reflectiveNameStrings=strings,reason="Unity2023 callback requires no parameters. Original and upstream UniTask wrongly request ParticleSystemJobData; Unity ignores it. Rename prevents invalid message registration; do not fabricate job data.",limitations="No trigger functionality restored. Async public methods remain existing metadata stubs. Static scan cannot rule out dynamically constructed reflection names in unrecovered native behavior."};
 File.WriteAllText(Path.Combine(root,"patch-proof.json"),new JavaScriptSerializer(){MaxJsonLength=int.MaxValue}.Serialize(report));Console.WriteLine("Candidate written; "+files.Length+" assemblies scanned; no references/calls/name strings; only one private method renamed. Target unchanged.");
 }
}
"@
[ParticleCallbackCompat]::Run('D:\Games\TruxtonExRecon\code\unitask-callback-compat','D:\Games\TruxtonExRecon\Reconstructed')
