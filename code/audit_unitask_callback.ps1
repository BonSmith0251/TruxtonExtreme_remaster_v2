$ErrorActionPreference='Stop'
Add-Type -Path 'D:\games\Endless Rails 1-0\game\recovery\tools\ilspycmd\tools\net6.0\any\Mono.Cecil.dll'
$root='D:\Games\TruxtonExRecon\code\unitask-callback-compat'
$plugins='D:\Games\TruxtonExRecon\Reconstructed\Assets\OriginalRecovered\Plugins'
$rows=@(); $methods=@()
foreach($file in Get-ChildItem $plugins -Filter *.dll){
$a=[Mono.Cecil.AssemblyDefinition]::ReadAssembly($file.FullName)
foreach($t in $a.MainModule.GetTypeReferences()) {if($t.FullName -match 'ParticleUpdateJobScheduled'){ $rows+= [pscustomobject]@{assembly=$a.Name.Name; kind='TypeRef'; value=$t.FullName} }}
foreach($r in $a.MainModule.GetMemberReferences()){if($r.FullName -match 'ParticleUpdateJobScheduled'){ $rows+= [pscustomobject]@{assembly=$a.Name.Name; kind='MemberRef'; value=$r.FullName} }}
if($a.Name.Name -eq 'UniTask') {foreach($t in $a.MainModule.Types){foreach($m in $t.Methods){if($m.FullName -match 'ParticleUpdateJobScheduled'){ $methods += [pscustomobject]@{type=$t.FullName;method=$m.FullName;token=$m.MetadataToken.ToString();flags=$m.Attributes.ToString(); il=@($m.Body.Instructions | ForEach-Object {if($null -ne $_){$_.ToString()}})}}}}}
$a.Dispose()
}
[pscustomobject]@{refs=$rows;methods=$methods} | ConvertTo-Json -Depth 12 | Set-Content -LiteralPath "$root\reference-audit.json" -Encoding UTF8
$rows | Format-Table -AutoSize
$methods | Select-Object type,method,token | Format-Table -AutoSize

