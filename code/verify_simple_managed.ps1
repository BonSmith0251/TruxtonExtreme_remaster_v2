param([string]$Root='D:\Games\TruxtonExRecon\code',[string]$Editor='C:\Program Files\Unity 2023.2.22f1\Editor',[string]$Target='D:\Games\TruxtonExRecon\Reconstructed')
$ErrorActionPreference='Stop'
$work=$Root+'\simple-native-recovery'
& ($Editor+'\Data\MonoBleedingEdge\bin\mono.exe') ($Editor+'\Data\MonoBleedingEdge\lib\mono\4.5\csc.exe') /nologo /target:exe /reference:System.Web.Extensions.dll ('/out:'+$work+'\VerifyManaged.exe') ($work+'\VerifyManaged.cs')
if($LASTEXITCODE -ne 0){throw 'Managed fixture harness compilation failed'}
& ($Editor+'\Data\MonoBleedingEdge\bin\mono.exe') ($work+'\VerifyManaged.exe') $work ($Target+'\Assets\OriginalRecovered\Plugins') ($Target+'\Library\ScriptAssemblies') ($Editor+'\Data\Managed\UnityEngine') *> ($work+'\managed-execution.log')
if($LASTEXITCODE -ne 0){throw 'Managed native-body fixtures failed; inspect managed-execution-check.json and log'}
