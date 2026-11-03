param([string]$Root='D:\Games\TruxtonExRecon\code',[string]$Game='D:\games\Truxton Extreme')
$ErrorActionPreference='Stop'
$binary=Join-Path $Game 'GameAssembly.dll'
$metadata=Join-Path $Game 'TATSUJIN EXTREME_Data\il2cpp_data\Metadata\global-metadata.dat'
if((Get-FileHash -LiteralPath $binary -Algorithm SHA256).Hash.ToLowerInvariant() -ne 'b3ee81c6bf8506e8134512e14640b7bdae6092269893ccdea40f2afe758b5ab6'){throw 'Original binary fingerprint differs; do not reuse this evidence.'}
if((Get-FileHash -LiteralPath $metadata -Algorithm SHA256).Hash.ToLowerInvariant() -ne '8dc5e099564bd7de4c5f7a6c6d102f4d192da9ec704729c981ab4f217493d685'){throw 'Original metadata fingerprint differs.'}
foreach($spec in @(@('dummydll','metadata-assemblies','cpp2il-metadata.log'),@('diffable-cs','type-model-source','cpp2il-source.log'),@('dll_il_recovery','experimental-il-recovery','cpp2il-il-recovery.log'))){
 & ($Root+'\tools\Cpp2IL.exe') --game-path $Game --exe-name 'TATSUJIN EXTREME' --output-as $spec[0] --use-processor attributeanalyzer,attributeinjector --output-to ($Root+'\'+$spec[1]) *> ($Root+'\'+$spec[2])
 if($LASTEXITCODE -ne 0){throw ('Cpp2IL output failed: '+$spec[0])}
}
