param([string]$Root='D:\Games\TruxtonExRecon\code',[string]$Editor='C:\Program Files\Unity 2023.2.22f1\Editor')
$ErrorActionPreference='Stop'
$refs=@('/nologo','/target:library','/nostdlib',('/reference:'+$Editor+'\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll'),('/reference:'+$Editor+'\Data\NetStandard\compat\2.1.0\shims\netfx\mscorlib.dll'))
$refs+=Get-ChildItem -LiteralPath ($Editor+'\Data\NetStandard\ref\2.1.0') -Filter '*.dll'|ForEach-Object {'/reference:'+$_.FullName}
foreach($name in @('KANAI.Kernel','KANAI.HybridCollision','KANAI.UI','KANAI.Popup','OutGame','Unity.TextMeshPro')){$refs+='/reference:'+$Root+'\metadata-assemblies\'+$name+'.dll'}
foreach($stem in @('Samples','OutGame.DebugMenu')){
 & ($Editor+'\Data\MonoBleedingEdge\bin\mono.exe') ($Editor+'\Data\MonoBleedingEdge\lib\mono\4.5\csc.exe') $refs ('/out:'+$Root+'\missing-type-shells\'+$stem+'.dll') ($Root+'\missing-type-shells\'+$stem+'.cs') *> ($Root+'\missing-type-shells\'+$stem+'.compile.log')
 if($LASTEXITCODE -ne 0){throw ('Compilation failed for '+$stem)}
}
