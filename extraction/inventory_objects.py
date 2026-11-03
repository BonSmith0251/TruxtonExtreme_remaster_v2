import pathlib,sys,importlib.util,collections,json,gzip,hashlib,gc,time
import UnityPy
import math
ROOT=pathlib.Path(r'D:\games\Truxton Extreme');OUT=pathlib.Path(r'D:\Games\TruxtonExRecon\extraction');DATA=ROOT/'TATSUJIN EXTREME_Data'
spec=importlib.util.spec_from_file_location('scan',r'C:\Users\Administrator\.codex\skills\truxton-asset-extraction\scripts\inventory_assets.py');scan=importlib.util.module_from_spec(spec);spec.loader.exec_module(scan)
(OUT/'serialized').mkdir(exist_ok=True)
def wr(f,r):f.write(json.dumps(r,separators=(',',':'),ensure_ascii=True,default=str)+'\n')
def norm(x,k=''):
 if isinstance(x,float) and not math.isfinite(x):return {'$float':'NaN' if math.isnan(x) else 'Infinity' if x>0 else '-Infinity'}
 if isinstance(x,dict):return {a:norm(b,a) for a,b in x.items()}
 if isinstance(x,list):return [norm(v,k) for v in x]
 if k in ('m_PathID','pathID'):return str(x)
 if isinstance(x,bytes):return {'binary_hex':x.hex()}
 return x
def ptrs(x,p=''):
 if isinstance(x,dict):
  if 'm_FileID' in x and 'm_PathID' in x:yield p,int(x['m_FileID']),str(x['m_PathID'])
  else:
   for k,v in x.items():yield from ptrs(v,p+'.'+k)
 elif isinstance(x,list):
  for i,v in enumerate(x):yield from ptrs(v,p+'['+str(i)+']')
paths=sorted(DATA.rglob('*.bundle'))+[p for p in sorted(DATA.iterdir()) if p.is_file() and (p.suffix=='.assets' or p.name.startswith('level') or p.name=='globalgamemanagers')]+[p for p in sorted((DATA/'Resources').iterdir()) if p.is_file()]
sources=[];files=[];counts=collections.Counter();reads=collections.Counter();fail=collections.Counter();index=collections.defaultdict(list);streams=[];scripts=[]
with gzip.open(OUT/'objects.jsonl.gz','wt',encoding='utf8') as oh,gzip.open(OUT/'typetrees.jsonl.gz','wt',encoding='utf8') as th,gzip.open(OUT/'references-unresolved.jsonl.gz','wt',encoding='utf8') as rh:
 for n,path in enumerate(paths,1):
  rel=path.relative_to(ROOT).as_posix();r={'source':rel,'bytes':path.stat().st_size,'raw_preservation':'immutable original, hash in evidence/source-files-initial.json'}
  try:
   if path.suffix=='.bundle':header,buffers=scan.bundle_metadata(path);r['header']=header
   else:buffers={path.name:path.read_bytes()}
   r['status']='parsed';r['serialized']=[]
   for cab,buf in buffers.items():
    env=UnityPy.load(bytes(buf));rawid=hashlib.sha256((rel+':'+cab).encode()).hexdigest()[:24];raw=OUT/'serialized'/(rawid+'.bin.gz')
    with gzip.open(raw,'wb',compresslevel=1) as z:z.write(buf)
    for f in env.assets:
     fid=rel+'::'+cab;ext=[x.path for x in f.externals];fr={'id':fid,'source':rel,'cab':cab,'version':str(f.unity_version),'externals':ext,'objects':len(f.objects),'raw':str(raw),'raw_sha256':hashlib.sha256(buf).hexdigest()};files.append(fr);r['serialized'].append(fid)
     index[cab.lower()].append({'id':fid,'ids':set(map(str,f.objects))})
     for o in f.objects.values():
      oid=fid+'::'+str(o.path_id);typ=o.type.name;counts[typ]+=1;rec={'id':oid,'source':rel,'cab':cab,'path_id':str(o.path_id),'class_id':o.class_id,'type':typ,'offset':o.byte_start,'bytes':o.byte_size,'raw':str(raw),'read':'unattempted','import':'unattempted'}
      try:
       t=o.read_typetree();rec['read']='pass';rec['name']=t.get('m_Name','');reads[typ]+=1;wr(th,{'id':oid,'tree':norm(t)})
       if typ=='MonoScript':scripts.append({'id':oid,**{k:t.get(k) for k in ('m_Name','m_ClassName','m_Namespace','m_AssemblyName')}})
       for prop,ef,pid in ptrs(t):wr(rh,{'owner':oid,'file':fid,'property':prop,'file_id':ef,'path_id':pid,'external':ext[ef-1] if 0<ef<=len(ext) else None})
       for k in ('m_StreamData','m_Resource'):
        d=t.get(k)
        if isinstance(d,dict):
         sp=d.get('path',d.get('m_Source',''));sz=d.get('size',d.get('m_Size',0));off=d.get('offset',d.get('m_Offset',0))
         if sp and sz:streams.append({'owner':oid,'source':rel,'path':sp,'offset':off,'size':sz})
      except Exception as e:rec['read']='fail';rec['error']=str(e)[:500];fail[typ]+=1
      wr(oh,rec)
    del env
   del buffers
  except Exception as e:r['status']='failed';r['error']=str(e)
  sources.append(r);gc.collect();print(n,len(paths),path.name,r['status'],sum(counts.values()),flush=True)
  (OUT/'inventory-checkpoint.json').write_text(json.dumps({'sources_completed':n,'counts':dict(counts),'last':rel}),encoding='utf8')
refs=collections.Counter();lookup={z['id']:z for a in index.values() for z in a}
with gzip.open(OUT/'references-unresolved.jsonl.gz','rt',encoding='utf8') as ri,gzip.open(OUT/'references.jsonl.gz','wt',encoding='utf8') as ro:
 for line in ri:
  q=json.loads(line);pid=q['path_id'];ef=q['file_id'];cand=[]
  if pid=='0':q['outcome']='original-null'
  else:
   if ef==0:cand=[lookup[q['file']]]
   elif q['external']:cand=index.get(pathlib.PurePosixPath(q['external'].replace('\\','/')).name.lower(),[])
   targets=[x['id']+'::'+pid for x in cand if pid in x['ids']]
   q['outcome']='resolved' if len(targets)==1 else 'ambiguous' if targets else 'missing';q['targets']=targets
  refs[q['outcome']]+=1;wr(ro,q)
summary={'UnityPy':UnityPy.__version__,'sources':sources,'serialized_files':files,'counts':dict(counts),'objects':sum(counts.values()),'type_tree_read':dict(reads),'type_tree_fail':dict(fail),'references':dict(refs),'streams':streams,'raw_policy':'Original immutable installation fingerprinted by coordinator; raw serialized files gzip-preserved independently; opaque Comic and media referenced by source manifest, not copied','native_export':'pristine-export/ExportedProject','import':'unattempted by extraction'}
(OUT/'coverage.json').write_text(json.dumps(summary,indent=2),encoding='utf8');(OUT/'monoscripts.json').write_text(json.dumps(scripts,indent=2),encoding='utf8');print('COMPLETE',summary['objects'],dict(refs),flush=True)
