param([string]$Root='D:\Games\TruxtonExRecon\code',[string]$Editor='C:\Program Files\Unity 2023.2.22f1\Editor',[string]$Target='D:\Games\TruxtonExRecon\Reconstructed')
$ErrorActionPreference='Stop'
$work=$Root+'\outgame-load-diagnostic'
$evidence=Get-Content -Raw -LiteralPath ($work+'\field-compatibility-evidence.json')|ConvertFrom-Json
if((Get-FileHash -LiteralPath ($Target+'\Assets\OriginalRecovered\Plugins\OutGame.dll')).Hash.ToLowerInvariant() -ne $evidence.targetOutGameSha256){throw 'Target OutGame changed; refresh the matching metadata token inventory before rerunning this probe.'}
& ($Editor+'\Data\MonoBleedingEdge\bin\mono.exe') ($Editor+'\Data\MonoBleedingEdge\lib\mono\4.5\csc.exe') /nologo /target:exe /reference:System.Web.Extensions.dll ('/out:'+$work+'\LoadTypesProbe.exe') ($work+'\LoadTypesProbe.cs')
if($LASTEXITCODE -ne 0){throw 'Reflection probe compilation failed'}
& ($Editor+'\Data\MonoBleedingEdge\bin\mono.exe') ($work+'\LoadTypesProbe.exe') $Target $Editor $work *> ($work+'\mono-probe.log')
if($LASTEXITCODE -ne 0){throw 'Reflection probe execution failed'}

