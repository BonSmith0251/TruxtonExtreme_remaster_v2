param([string]$Root='D:\Games\TruxtonExRecon\code')
$cecil='D:\games\Endless Rails 1-0\game\recovery\tools\ilspycmd\tools\net6.0\any\Mono.Cecil.dll'
Add-Type -Path $cecil
Add-Type -ReferencedAssemblies $cecil,'System.Web.Extensions','C:\Windows\Microsoft.NET\Framework64\v4.0.30319\netstandard.dll' -TypeDefinition @"
using System; using System.IO; using System.Linq; using System.Collections.Generic; using System.Web.Script.Serialization; using Mono.Cecil;
public static class Census {
 static JavaScriptSerializer json=new JavaScriptSerializer(){MaxJsonLength=int.MaxValue};
 static object Attr(CustomAttribute a) { try { return new { type=a.AttributeType.FullName, args=a.ConstructorArguments.Select(x=>Convert.ToString(x.Value)).ToArray(), fields=a.Fields.ToDictionary(x=>x.Name,x=>Convert.ToString(x.Argument.Value)), properties=a.Properties.ToDictionary(x=>x.Name,x=>Convert.ToString(x.Argument.Value))}; } catch(Exception ex) { return new {type=a.AttributeType.FullName, decodeError=ex.GetType().Name}; } }
 static IEnumerable<TypeDefinition> Types(TypeDefinition t) { yield return t; foreach(var n in t.NestedTypes) foreach(var c in Types(n)) yield return c; }
 public static void Run(string root) {
 var resolver=new DefaultAssemblyResolver(); resolver.AddSearchDirectory(Path.Combine(root,"metadata-assemblies")); var rp=new ReaderParameters(){AssemblyResolver=resolver}; var sums=new List<object>(); var statuses=new Dictionary<string,int>(); int tc=0,mc=0,fc=0;
 using(var tw=new StreamWriter(Path.Combine(root,"types.jsonl"))) using(var mw=new StreamWriter(Path.Combine(root,"methods.jsonl"))) {
 foreach(var f in Directory.GetFiles(Path.Combine(root,"metadata-assemblies"),"*.dll")) {
 using(var a=AssemblyDefinition.ReadAssembly(f,rp)) using(var rec=AssemblyDefinition.ReadAssembly(Path.Combine(root,"experimental-il-recovery",Path.GetFileName(f)),rp)) {
 int at=0,am=0,af=0; var rm=rec.MainModule.Types.SelectMany(Types).SelectMany(x=>x.Methods).ToDictionary(x=>x.MetadataToken.ToUInt32());
 foreach(var t in a.MainModule.Types.SelectMany(Types)) {
 at++; tc++; af+=t.Fields.Count; fc+=t.Fields.Count;
 tw.WriteLine(json.Serialize(new {assembly=a.Name.Name, assemblyFullName=a.Name.FullName, type=t.FullName, token=t.MetadataToken.ToString(), baseType=t.BaseType==null?null:t.BaseType.FullName, flags=t.Attributes.ToString(), interfaces=t.Interfaces.Select(x=>x.InterfaceType.FullName).ToArray(), attributes=t.CustomAttributes.Select(Attr).ToArray(), fields=t.Fields.Select(x=>new {name=x.Name,type=x.FieldType.FullName,token=x.MetadataToken.ToString(),flags=x.Attributes.ToString(),constant=x.HasConstant?Convert.ToString(x.Constant):null,attributes=x.CustomAttributes.Select(Attr).ToArray()}).ToArray(), genericParameters=t.GenericParameters.Select(x=>x.Name).ToArray(), sourceStatus="metadata_recovered", behaviorStatus="not_recovered"}));
 foreach(var m in t.Methods) {
 am++; mc++; MethodDefinition r; rm.TryGetValue(m.MetadataToken.ToUInt32(),out r); string status="no_managed_body"; string[] ins=new string[0];
 if(r!=null && r.HasBody) { ins=r.Body.Instructions.Select(x=>x.ToString()).ToArray(); status=ins.Length==2 && r.Body.Instructions[0].OpCode.Code==Mono.Cecil.Cil.Code.Ldnull && r.Body.Instructions[1].OpCode.Code==Mono.Cecil.Cil.Code.Throw?"stub_throw_null":(ins.Length==1 && r.Body.Instructions[0].OpCode.Code==Mono.Cecil.Cil.Code.Ret?"stub_or_original_empty_unverified":"candidate_il_unverified"); }
 if(!statuses.ContainsKey(status))statuses[status]=0;statuses[status]++;
 mw.WriteLine(json.Serialize(new {assembly=a.Name.Name,type=t.FullName,signature=m.FullName,token=m.MetadataToken.ToString(),flags=m.Attributes.ToString(),returnType=m.ReturnType.FullName,parameters=m.Parameters.Select(x=>new{name=x.Name,type=x.ParameterType.FullName,flags=x.Attributes.ToString()}).ToArray(),attributes=m.CustomAttributes.Select(Attr).ToArray(),status=status,ilInstructions=ins,pinvoke=m.HasPInvokeInfo && m.PInvokeInfo!=null && m.PInvokeInfo.Module!=null?m.PInvokeInfo.Module.Name:null}));
 }
 }
 sums.Add(new {assembly=a.Name.Name,types=at,methods=am,fields=af,references=a.MainModule.AssemblyReferences.Select(x=>x.FullName).ToArray()});
 }
 }
 }
 File.WriteAllText(Path.Combine(root,"metadata-coverage.json"),json.Serialize(new {assemblies=sums.Count,types=tc,methods=mc,fields=fc,statuses=statuses,assemblyCoverage=sums}));
 }
}
"@
[Census]::Run($Root)
Get-Content -LiteralPath ($Root+'\metadata-coverage.json')





