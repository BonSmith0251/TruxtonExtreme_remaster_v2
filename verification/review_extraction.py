import collections,gzip,hashlib,json,pathlib,re,datetime
root=pathlib.Path(r'D:\Games\TruxtonExRecon'); ex=root/'extraction'; dest=root/'verification'
coverage=json.loads((ex/'coverage.json').read_text()); ids=set(); duplicate_ids=[]; counts=collections.Counter(); reads=collections.Counter(); failures=[]; maxends=collections.defaultdict(int)
with gzip.open(ex/'objects.jsonl.gz','rt',encoding='utf-8') as f:
 for line in f:
  x=json.loads(line)
  if x['id'] in ids:duplicate_ids.append(x['id'])
  ids.add(x['id']);counts[x['type']]+=1;reads[x['read']]+=1;maxends[x['raw']]=max(maxends[x['raw']],x['offset']+x['bytes'])
  if x['read']!='pass':failures.append(x)
refs=collections.Counter(); invalid_refs=[]
with gzip.open(ex/'references.jsonl.gz','rt',encoding='utf-8') as f:
 for line in f:
  x=json.loads(line);refs[x['outcome']]+=1
  if x['outcome']=='resolved' and (not x.get('targets') or any(t not in ids for t in x['targets'])):invalid_refs.append(x)
raw=[]
for sf in coverage['serialized_files']:
 h=hashlib.sha256(); size=0
 with gzip.open(sf['raw'],'rb') as f:
  while b:=f.read(1024*1024):h.update(b);size+=len(b)
 raw.append({'source':sf['id'],'bytes':size,'sha256_match':h.hexdigest()==sf['raw_sha256'],'object_ranges_fit':maxends[sf['raw']]<=size})
assets=ex/'pristine-export/ExportedProject/Assets'; guids=collections.defaultdict(list)
for p in assets.rglob('*.meta'):
 m=re.search(r'^guid: ([0-9a-f]{32})',p.read_text(encoding='utf-8-sig',errors='replace'),re.M)
 if m:guids[m[1]].append(str(p.relative_to(assets)))
unknown=collections.defaultdict(list); yamlcounts=collections.Counter(); zeromono=[]; builtins={'0000000000000000e000000000000000','0000000000000000f000000000000000','00000000000000000000000000000000'}
for p in assets.rglob('*'):
 if p.suffix not in {'.unity','.prefab','.asset','.mat','.controller','.anim','.playable','.lighting','.mixer'}:continue
 t=p.read_text(encoding='utf-8-sig',errors='replace')
 if not t.startswith('%YAML'):continue
 yamlcounts[p.suffix]+=1
 for guid in set(re.findall(r'guid: ([0-9a-f]{32})',t)):
  if guid not in guids and guid not in builtins:unknown[guid].append(str(p.relative_to(assets)))
 for seg in re.split(r'^--- !u!',t,flags=re.M)[1:]:
  if seg.startswith('114 ') and re.search(r'm_Script: \{fileID: 0\}',seg):zeromono.append({'file':str(p.relative_to(assets)),'id':seg.splitlines()[0]})
streams=json.loads((ex/'stream-coverage.json').read_text())['streams']; badstream=[x for x in streams if not (x['offset']>=0 and x['size']>=0 and x['offset']+x['size']<=x['stream_bytes'])]
report={'utc':datetime.datetime.now(datetime.timezone.utc).isoformat(),'scope':'Independent source/extraction ledger and pristine export review; target not opened; no rendering/runtime verdict','source_objects':len(ids),'object_types':counts,'read_status':reads,'duplicate_object_ids':duplicate_ids,'references':refs,'invalid_resolved_targets':invalid_refs,'raw_serialized_checks':raw,'source_status':collections.Counter(x['status'] for x in coverage['sources']),'typetree_failures':failures,'stream_ranges':len(streams),'invalid_stream_ranges':badstream,'pristine_meta_guid_count':len(guids),'pristine_duplicate_guids':{k:v for k,v in guids.items() if len(v)>1},'pristine_yaml_files':yamlcounts,'pristine_unknown_guids':dict(unknown),'pristine_null_monoscript_attachments':zeromono,'limitations':['Source ledger covers readable typetrees only; failed object properties/PPtrs unknown.','Export collection count and alias path map do not demonstrate full nested object mapping.','Pristine static missing GUID checks do not include package-provided GUIDs or importer subasset resolution.','Raw hash matches validate retained extraction against its recorded hash; coordinator owns final original file hashes.','Original managed method behavior and compiled shader behavior remain unrecovered; supplemental Round1 runtime does not satisfy whole-game fidelity.']}
(dest/'independent-extraction-review.json').write_text(json.dumps(report,indent=2),encoding='utf-8')
print(json.dumps({k:v for k,v in report.items() if k not in {'typetree_failures','raw_serialized_checks','pristine_unknown_guids'}},indent=2))
print('raw valid',sum(x['sha256_match'] and x['object_ranges_fit'] for x in raw),'/',len(raw),'unknown GUIDs',len(unknown))
