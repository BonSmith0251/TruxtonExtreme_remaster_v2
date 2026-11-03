import pathlib,json,gzip,collections,re
p=pathlib.Path(r'D:\Games\TruxtonExRecon\extraction');root=p/'pristine-export'/'ExportedProject';cov=json.loads((p/'coverage.json').read_text(encoding='utf8'));aliases=json.loads((p/'aliases.json').read_text(encoding='utf8'))
bycab=collections.defaultdict(list);obj={};bynm=collections.defaultdict(list)
for f in cov['serialized_files']:bycab[f['cab'].lower()].append(f)
with gzip.open(p/'objects.jsonl.gz','rt',encoding='utf8') as f:
 for l in f:
  r=json.loads(l);obj[r['id']]=r
export={};fallback=collections.defaultdict(list)
for meta in (root/'Assets').rglob('*.meta'):
 f=pathlib.Path(str(meta)[:-5])
 if not f.is_file():continue
 text=meta.read_text(encoding='utf8',errors='replace');m=re.search(r'^guid:\s*(\w+)',text,re.M)
 if not m:continue
 d={'path':f.relative_to(root).as_posix(),'guid':m[1]};loc=re.search(r'mainObjectFileID:\s*(-?\d+)',text)
 if loc:d['local_id']=loc[1]
 if f.suffix not in ('.png','.tga','.hdr','.exr','.ogg','.dll','.ttf'):
  with f.open('r',encoding='utf8',errors='replace') as h:head=h.read(10000)
  doc=re.search(r'^--- !u!(\d+) &(-?\d+)',head,re.M)
  if doc:d['class_id']=int(doc[1]);d['local_id']=doc[2]
  nm=re.search(r'^  m_Name: (.*)',head,re.M)
  if nm:d['name']=nm[1].strip('"')
 if 'local_id' not in d:
  d['local_id']={'.png':'2800000','.tga':'2800000','.hdr':'2800000','.exr':'2800000','.ogg':'8300000','.mat':'2100000','.shader':'4800000','.controller':'9100000','.anim':'7400000','.ttf':'12800000'}.get(f.suffix,'unknown')
 export[d['path'].lower()]=d
 for nm in set((f.stem,d.get('name',f.stem))):fallback[nm.lower()].append(d)
rows=[];statuses=collections.Counter()
for a in aliases:
 owner=a['owner'];fid=owner.rsplit('::',1)[0];file=next((x for x in cov['serialized_files'] if x['id']==fid),None);ptr=a['asset'];pid=str(ptr.get('m_PathID','0'));ef=int(ptr.get('m_FileID',0));target=None
 if file and pid!='0':
  candidates=[file] if ef==0 else bycab.get(pathlib.PurePosixPath(file['externals'][ef-1].replace('\\','/')).name.lower(),[]) if 0<ef<=len(file['externals']) else []
  ids=[x['id']+'::'+pid for x in candidates if x['id']+'::'+pid in obj]
  if len(ids)==1:target=ids[0]
 r={'source_object':target,'alias':a['alias'],'source_pointer':ptr};path=a['alias'].replace('\\','/');dest=export.get(path.lower())
 if dest:r['outcome']='exact-alias-path';r['destination']=dest
 elif target:
  o=obj[target];nm=o.get('name','');cand=fallback.get(nm.lower(),[]) if nm else []
  # Only report candidates where class is known and agrees, never guess by a shared name.
  cand=[x for x in cand if x.get('class_id')==o['class_id']]
  if len(cand)==1:r['outcome']='unique-type-name-candidate';r['destination']=cand[0]
  elif cand:r['outcome']='ambiguous';r['candidates']=cand
  else:r['outcome']='unmapped'
 else:r['outcome']='source-unresolved'
 statuses[r['outcome']]+=1;rows.append(r)
(p/'destination-map.json').write_text(json.dumps({'counts':dict(statuses),'scope':'Container aliases only. Exact alias path mapping is reliable when path retained. Unique type/name matches are conservative candidates requiring structural verification. No claim all270371 nested source objects mapped. AssetRipper tail intentionally interrupted before its partial path_id_map output.','mappings':rows},indent=2),encoding='utf8');(p/'native-guids.json').write_text(json.dumps(list(export.values()),indent=2),encoding='utf8');print(dict(statuses),'exportassets',len(export))
