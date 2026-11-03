param([string]$Root='D:\Games\TruxtonExRecon\code',[string]$Editor='C:\Program Files\Unity 2023.2.22f1\Editor',[string]$Target='D:\Games\TruxtonExRecon\Reconstructed')
$ErrorActionPreference='Stop'
$refs=@('/nologo','/target:library','/nostdlib',('/out:'+$Root+'\rendering-layer-data\compile-check.dll'),('/reference:'+$Editor+'\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll'),('/reference:'+$Editor+'\Data\Managed\UnityEngine\UnityEngine.UIModule.dll'),('/reference:'+$Target+'\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll'),('/reference:'+$Target+'\Library\ScriptAssemblies\UnityEngine.UI.dll'))
$refs+=Get-ChildItem -LiteralPath ($Editor+'\Data\NetStandard\ref\2.1.0') -Filter '*.dll'|ForEach-Object {'/reference:'+$_.FullName}
$refs+=$Root+'\rendering-layer-data\DebugUIHandlerRenderingLayerField.cs'
& ($Editor+'\Data\MonoBleedingEdge\bin\mono.exe') ($Editor+'\Data\MonoBleedingEdge\lib\mono\4.5\csc.exe') $refs *> ($Root+'\rendering-layer-data\compile.log')
if($LASTEXITCODE -ne 0){throw 'Rendering-layer field shell compilation failed; inspect compile.log'}
