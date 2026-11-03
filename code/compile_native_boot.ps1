param([string]$Root='D:\Games\TruxtonExRecon\code',[string]$Editor='C:\Program Files\Unity 2023.2.22f1\Editor')
$ErrorActionPreference='Stop'
$refs=@('/nologo','/target:library','/nostdlib',('/out:'+$Root+'\native-reconstructed-source\BootTXE.compile-check.dll'),('/reference:'+$Editor+'\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll'),('/reference:'+$Root+'\integration-stubs\Assets\OriginalRecovered\Plugins\KANAI.Kernel.dll'),('/reference:'+$Editor+'\Data\NetStandard\compat\2.1.0\shims\netfx\mscorlib.dll'))
$refs+=Get-ChildItem -LiteralPath ($Editor+'\Data\NetStandard\ref\2.1.0') -Filter '*.dll'|ForEach-Object {'/reference:'+$_.FullName}
$refs+=$Root+'\native-reconstructed-source\BootTXE.cs'
& ($Editor+'\Data\MonoBleedingEdge\bin\mono.exe') ($Editor+'\Data\MonoBleedingEdge\lib\mono\4.5\csc.exe') $refs *> ($Root+'\native-reconstructed-source\compile.log')
if($LASTEXITCODE -ne 0){throw 'BootTXE source compilation failed; inspect compile.log'}
