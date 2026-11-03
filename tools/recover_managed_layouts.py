import sys,json,gzip,collections,hashlib
from pathlib import Path
sys.path.insert(0,r'D:\Games\TruxtonExRecon\tools\typetree-deps')
import UnityPy
from UnityPy.helpers.TypeTreeGenerator import TypeTreeGenerator
from UnityPy.helpers.TypeTreeNode import TypeTreeNode
root=Path(r'D:\Games\TruxtonExRecon');original=Path(r'D:\games\Truxton Extreme');out=root/'evidence/managed-layouts'
rows=[json.loads(l) for l in gzip.open(root/'extraction/objects.jsonl.gz','rt')];wanted=[r for r in rows if r['read']=='fail' and r['type']=='MonoBehaviour'];identities={r['id'] for r in rows}
coverage=json.loads((root/'extraction/coverage.json').read_text());cabmap=collections.defaultdict(list)
for s in coverage['serialized_files']:cabmap[s['cab'].lower()].append(s['id'])
paths=sorted({str(original/r['source']) for r in wanted}|{str(original/'TATSUJIN EXTREME_Data/globalgamemanagers.assets')})
e=UnityPy.load(*paths);g=TypeTreeGenerator('6000.3.7f1',generator='AssetsTools');g.load_local_dll_folder(str(root/'code/metadata-assemblies'));e.typetree_generator=g
assets={a.name:a for a in e.assets};cache={};outcomes=[];refcounts=collections.Counter()
def norm(v):
 if isinstance(v,dict):return {k:str(x) if k=='m_PathID' else norm(x) for k,x in v.items()}
 if isinstance(v,list):return [norm(x) for x in v]
 return v
def refs(v,p=''):
 if isinstance(v,dict):
  if 'm_FileID' in v and 'm_PathID' in v:yield p,v
  else:
   for k,x in v.items():yield from refs(x,p+'.'+k)
 elif isinstance(v,list):
  for i,x in enumerate(v):yield from refs(x,p+'['+str(i)+']')
with gzip.open(out/'recovered.jsonl.gz','wt',encoding='utf-8') as data,gzip.open(out/'additional-references.jsonl.gz','wt') as reference:
 for r in wanted:
  result={'id':r['id'],'bytes':r['bytes'],'status':'failed'}
  try:
   a=assets.get(r['cab']) or next(a for a in e.assets if a.name.endswith(r['cab']));obj=a.objects[int(r['path_id'])];head=obj.parse_monobehaviour_head();script=head.m_Script.deref_parse_as_object();full=(script.m_Namespace+'.' if script.m_Namespace else '')+script.m_ClassName;key=(script.m_AssemblyName,full)
   if key not in cache:
    nodes=json.loads(g.get_nodes_as_json(*key))
    for n in nodes:
     if n['m_Name']=='m_Enabled' and n['m_Level']==1:n['m_MetaFlag']|=16384
    cache[key]=TypeTreeNode.from_list([TypeTreeNode(n['m_Level'],n['m_Type'],n['m_Name'],0,0,m_MetaFlag=n['m_MetaFlag']) for n in nodes])
   tree=obj.read_typetree(nodes=cache[key],check_read=True)
   for field,ptr in [('m_Script',head.m_Script),('m_GameObject',head.m_GameObject)]:
    assert tree[field]['m_PathID']==ptr.path_id and tree[field]['m_FileID']==ptr.m_FileID,(field,tree[field],str(ptr))
   result.update(status='decoded',assembly=key[0],type=full,name=tree.get('m_Name'),field_count=len(tree),header_pointer_match=True,exact_consumption=True)
   data.write(json.dumps({'id':r['id'],'source':r['source'],'cab':r['cab'],'path_id':r['path_id'],'tree':norm(tree)},ensure_ascii=True)+'\n')
   for prop,ptr in refs(tree):
    pid=str(ptr['m_PathID']);fid=ptr['m_FileID'];rr={'owner':r['id'],'property':prop,'pointer':{'m_FileID':fid,'m_PathID':pid}}
    if pid=='0':rr['status']='original-null'
    else:
     if fid==0:prefix=r['source']+'::'+r['cab']
     else:
      ext=a.externals[fid-1].path.replace('\\','/').split('/')[-1].lower();candidates=cabmap.get(ext,[]);prefix=candidates[0] if len(candidates)==1 else None
     target=(prefix+'::'+pid) if prefix else None;rr.update(target=target,status='resolved' if target in identities else 'unresolved')
    refcounts[rr['status']]+=1;reference.write(json.dumps(rr)+'\n')
  except Exception as exc:result['error']=repr(exc)
  outcomes.append(result)
summary={'generator':'TypeTreeGeneratorAPI0.0.10 AssetsTools','UnityPy':UnityPy.__version__,'source_version':'6000.3.7f1','input_assemblies':'code/metadata-assemblies (matching IL2CPP metadata39)','header_repair':'m_Enabled alignment flag16384; script and owner pointers compared to native header independently','attempted':len(outcomes),'decoded':sum(x['status']=='decoded' for x in outcomes),'failed':sum(x['status']=='failed' for x in outcomes),'references':dict(refcounts),'outcomes':outcomes,'target_import':'not established by this source decoder'}
(out/'outcomes.json').write_text(json.dumps(summary,indent=2));print(json.dumps({k:v for k,v in summary.items() if k!='outcomes'}),flush=True)
