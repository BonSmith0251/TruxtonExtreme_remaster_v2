import pathlib,json,hashlib,urllib.request,struct
from capstone import Cs,CS_ARCH_X86,CS_MODE_64
r=pathlib.Path(r'D:\Games\TruxtonExRecon\code');d=r/'unitask-callback-compat'
ms=json.loads(pathlib.Path(r'D:\Games\TruxtonExRecon\extraction\monoscripts.json').read_text(encoding='utf-8-sig'));matches=[m for m in ms if 'ParticleUpdateJobScheduled' in json.dumps(m)]
assert not matches
b=pathlib.Path(r'D:\games\Truxton Extreme\GameAssembly.dll').read_bytes();h=hashlib.sha256(b).hexdigest();assert h=='b3ee81c6bf8506e8134512e14640b7bdae6092269893ccdea40f2afe758b5ab6'
raw=b[0x277AF70:0x277AF70+0xF6]; ins=[f'{i.address:016X}: {i.bytes.hex():24} {i.mnemonic} {i.op_str}' for i in Cs(CS_ARCH_X86,CS_MODE_64).disasm(raw,0x18277BB70)]
(d/'original-native-callback.txt').write_text('\n'.join(ins)+'\n')
rows=[]
for line in (r/'methods.jsonl').open(encoding='utf-8-sig'):
 m=json.loads(line)
 if m['assembly']=='UniTask' and m['type'].endswith('AsyncParticleUpdateJobScheduledTrigger'):rows.append(m)
(d/'original-method-metadata.json').write_text(json.dumps(rows,indent=2))
up={}
try:
 req=urllib.request.Request('https://api.github.com/repos/Cysharp/UniTask/commits/master',headers={'User-Agent':'UnityReconstructionEvidence'})
 commit=json.load(urllib.request.urlopen(req,timeout=20))['sha'];up['commit']=commit
 for filename in ['Runtime/Triggers/MonoBehaviourMessagesTriggers.cs','package.json']:
  url=f'https://raw.githubusercontent.com/Cysharp/UniTask/{commit}/src/UniTask/Assets/Plugins/UniTask/{filename}'
  data=urllib.request.urlopen(url,timeout=20).read();p=d/'upstream'/pathlib.Path(filename).name;p.write_bytes(data);up[filename]={'url':url,'sha256':hashlib.sha256(data).hexdigest()}
except Exception as e:up['fetch_error']=str(e)
p=json.loads((d/'patch-proof.json').read_text());proof={'sourceMonoScriptCount':len(ms),'matchingSourceMonoScripts':matches,'originalGameAssemblySha256':h,'originalMethodToken':'0x06000AC1','originalRva':'0x277BB70','originalRawOffset':'0x277AF70','nativeLength':246,'nativeBytes':raw.hex(),'upstream':up,'unity2023Contract':'https://docs.unity3d.com/ja/2023.2/ScriptReference/MonoBehaviour.OnParticleUpdateJobScheduled.html','compatibleUpstreamReplacement':'Not suitable for this fix: upstream has same invalid signature. Broad replacement needs original version/API compatibility audit and runtime testing; current task does not authorize unverified global behavior change.'}
(d/'source-proof.json').write_text(json.dumps(proof,indent=2))
print(json.dumps({'sourceMonoScripts':len(ms),'matching':len(matches),'baselineSha256':p['baselineSha256'],'candidateSha256':p['outputSha256'],'upstream':up},indent=2))
