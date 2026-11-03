import json,gzip,pathlib,collections
r=pathlib.Path(r'D:\Games\TruxtonExRecon\code'); e=r.parent/'extraction'; m=json.loads((r/'monoscript-type-map.json').read_text()); byid={x['sourceMonoScript']:x for x in m}; counts=collections.Counter();missing=[]; unresolved=[]
for line in gzip.open(e/'references.jsonl.gz','rt',encoding='utf-8'):
 x=json.loads(line)
 if x['property']!='.m_Script':continue
 if x['outcome']!='resolved':unresolved.append(x);continue
 for tid in x['targets']:
  counts[tid]+=1
  row=byid.get(tid)
  if row is None or row['typeStatus']=='missing_metadata':missing.append(dict(reference=x,type=row))
for x in m:x['sourceComponentReferenceCount']=counts[x['sourceMonoScript']]
(r/'monoscript-type-map.json').write_text(json.dumps(m,indent=2))
d=dict(scriptReferenceCount=sum(counts.values()),referencedMonoScriptObjects=len(counts),missingMetadataAttachmentCount=len(missing),missingMetadataAttachments=missing,unresolvedReferences=unresolved)
(r/'script-attachment-coverage.json').write_text(json.dumps(d,indent=2))
print({k:v for k,v in d.items() if k not in ['missingMetadataAttachments','unresolvedReferences']})
print(collections.Counter((x['type']['assembly']+':'+x['type']['fullType']) if x['type'] else 'unknown' for x in missing))
