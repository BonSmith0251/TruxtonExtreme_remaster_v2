import json,gzip,pathlib
r=pathlib.Path(r'D:\Games\TruxtonExRecon');e=r/'extraction';objects={}
for x in map(json.loads,gzip.open(e/'objects.jsonl.gz','rt')):
 if x['cab'] in ['level0','level1']:objects[x['id']]=x
scripts={x['id']:x for x in json.loads((e/'monoscripts.json').read_text())};scriptrefs={}
for ln in gzip.open(e/'references.jsonl.gz','rt'):
 if 'TATSUJIN EXTREME_Data/level' in ln[:150]:
  x=json.loads(ln)
  if x['owner'] in objects and x['property']=='.m_Script':scriptrefs[x['owner']]=x.get('targets',[])
for x in map(json.loads,gzip.open(r/'evidence/managed-layouts/additional-references.jsonl.gz','rt')):
 if x['owner'] in objects and x['property']=='.m_Script':scriptrefs[x['owner']]=[x['target']]
trees={}
for ln in gzip.open(e/'typetrees.jsonl.gz','rt'):
 if 'TATSUJIN EXTREME_Data/level' in ln[:130]:
  x=json.loads(ln)
  if x['id'] in objects:trees[x['id']]=x['tree']
for x in map(json.loads,gzip.open(r/'evidence/managed-layouts/recovered.jsonl.gz','rt')):
 if x['id'] in objects:trees[x['id']]=x['tree']
result={}
for level in ['level0','level1']:
 prefix='TATSUJIN EXTREME_Data/'+level+'::'+level+'::';nodes={}
 def key(p):
  assert p['m_FileID']==0,p
  return prefix+str(p['m_PathID'])
 def namepath(tid):
  t=trees[tid];go=trees[key(t['m_GameObject'])];father=t['m_Father'];return (namepath(key(father))+'/' if str(father['m_PathID'])!='0' else '')+go['m_Name']
 for oid,o in objects.items():
  if o['cab']!=level or o['type']!='GameObject':continue
  g=trees[oid];comps=[key(c['component']) for c in g['m_Component']];tid=next(c for c in comps if objects[c]['type'] in ['Transform','RectTransform']);t=trees[tid];path=namepath(tid);ct=[]
  for cid in comps:
   typ=objects[cid]['type']
   if typ=='MonoBehaviour':
    s=scripts[scriptrefs[cid][0]];typ=(s['m_Namespace']+'.' if s['m_Namespace'] else '')+s['m_ClassName']
   else:typ='UnityEngine.'+typ
   ct.append(typ)
  father=t['m_Father'];parent=key(father) if str(father['m_PathID'])!='0' else None
  sibling=next((i for i,p in enumerate(trees[parent]['m_Children']) if key(p)==tid),None) if parent else None
  nodes[path]={'source_id':oid,'transform_id':tid,'name':g['m_Name'],'path':path,'parent':namepath(parent) if parent else None,'sibling':sibling,'layer':g['m_Layer'],'active':bool(g['m_IsActive']),'transformType':'UnityEngine.'+objects[tid]['type'],'localPosition':t['m_LocalPosition'],'localRotation':t['m_LocalRotation'],'localScale':t['m_LocalScale'],'components':ct,'rect':{k:t[k] for k in ['m_AnchorMin','m_AnchorMax','m_AnchoredPosition','m_SizeDelta','m_Pivot'] if k in t}}
 result[level]={'objects':len(nodes),'hierarchy':list(nodes.values()),'root_sibling_order':'Not present in source Transform trees; not inferred from PathID'}
(r/'verification/source-boot-hierarchies.json').write_text(json.dumps(result,indent=2));print(json.dumps({k:{'objects':v['objects'],'paths':[n['path'] for n in v['hierarchy']]} for k,v in result.items()},indent=2))
