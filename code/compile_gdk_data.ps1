param([string]$Root='D:\Games\TruxtonExRecon\code',[string]$Editor='C:\Program Files\Unity 2023.2.22f1\Editor')
$ErrorActionPreference='Stop'
$refs=@('/nologo','/target:library','/nostdlib',('/out:'+$Root+'\gdk-edition-data\Unity.Microsoft.GDK.dll'),('/reference:'+$Editor+'\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll'))
$refs+=Get-ChildItem -LiteralPath ($Editor+'\Data\NetStandard\ref\2.1.0') -Filter '*.dll'|ForEach-Object {'/reference:'+$_.FullName}
$refs+=$Root+'\gdk-edition-data\GdkEditionAsset.cs'
& ($Editor+'\Data\MonoBleedingEdge\bin\mono.exe') ($Editor+'\Data\MonoBleedingEdge\lib\mono\4.5\csc.exe') $refs *> ($Root+'\gdk-edition-data\compile.log')
if($LASTEXITCODE -ne 0){throw 'GDK data shell compilation failed; inspect compile.log'}
