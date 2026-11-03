import json,gzip,pathlib,math,datetime,re
r=pathlib.Path(r'D:\Games\TruxtonExRecon');e=r/'extraction';trees={}
for ln in gzip.open(e/'typetrees.jsonl.gz','rt'):
 if 'TATSUJIN EXTREME_Data/level' in ln[:130]:
  x=json.loads(ln);trees[x['id']]=x['tree']
for x in map(json.loads,gzip.open(r/'evidence/managed-layouts/recovered.jsonl.gz','rt')):
 if 'TATSUJIN EXTREME_Data/level' in x['id']:trees[x['id']]=x['tree']
expected=json.loads((r/'verification/source-boot-hierarchies.json').read_text());actual=json.loads((r/'evidence/scene-integration/original-deep-audit.json').read_text());out=[]
def flat(v,p=''):
 if isinstance(v,dict):
  if 'm_FileID' in v and 'm_PathID' in v:yield p,'reference',v
  else:
   for k,x in v.items():yield from flat(x,p+'.'+k if p else k)
 elif isinstance(v,list):
  yield p+'.Array.size','number',len(v)
  for i,x in enumerate(v):yield from flat(x,p+'.Array.data['+str(i)+']')
 else:yield p,'string' if isinstance(v,str) else 'number',v
for level,scene in [('level0','Assets/OriginalRecovered/Scenes/Boot.unity'),('level1','Assets/OriginalRecovered/Scenes/BootTXE.unity')]:
 a=next(x for x in actual['scenes'] if x['path']==scene);byid={x['globalId']:x for x in a['objects']}
 def path(n):return path(byid[n['parent']])+'/'+n['name'] if n['parent'] else n['name']
 target={path(n):n for n in a['objects']};mapping={};pairs=[];prefix='TATSUJIN EXTREME_Data/'+level+'::'+level+'::'
 for n in expected[level]['hierarchy']:
  if n['path'] not in target:continue
  go=target[n['path']];mapping[n['source_id']]=go['globalId'];srccomps=trees[n['source_id']]['m_Component']
  for i,c in enumerate(srccomps):
   sid=prefix+str(c['component']['m_PathID'])
   if i<len(go['components']):mapping[sid]=go['components'][i]['globalId'];pairs.append((n['path'],sid,go['components'][i]))
 differences=[];missing=[];unverifiedrefs=[];checked=0;localrefs=0;nullrefs=0;scriptrefs=0
 for pathstr,sid,c in pairs:
  fields={x['path']:x for x in c['fields']}
  for prop,kind,value in flat(trees[sid]):
   if prop=='m_Script':scriptrefs+=1;continue
   if prop not in fields:missing.append({'object':pathstr,'source_component':sid,'field':prop,'source_value':value});continue
   dest=fields[prop];dv=dest['value'];match=None
   if kind=='reference':
    if str(value['m_PathID'])=='0':match=dv=='null(instance=0)';nullrefs+=1
    elif value['m_FileID']==0 and prefix+str(value['m_PathID']) in mapping:match=dv==mapping[prefix+str(value['m_PathID'])];localrefs+=1
    else:unverifiedrefs.append({'object':pathstr,'source_component':sid,'field':prop,'source':value,'target':dv});continue
   elif kind=='string':match=value==dv
   elif dest['type']=='Boolean':match=bool(value)==(dv=='True')
   elif dest['type'] in ['Integer','Enum','ArraySize','LayerMask','Float']:
    try:match=math.isclose(float(value),float(dv),rel_tol=1e-6,abs_tol=1e-5)
    except (TypeError,ValueError):continue
   else:continue
   checked+=1
   if not match:differences.append({'object':pathstr,'source_component':sid,'field':prop,'source':value,'target':dv,'target_type':dest['type']})
 out.append({'scene':scene,'component_pairs':len(pairs),'fields_checked':checked,'local_references_checked':localrefs,'null_references_checked':nullrefs,'script_references_covered_by_type_check':scriptrefs,'differences':differences,'source_fields_not_exposed_at_same_path':missing,'external_references_without_verified_identity_map':unverifiedrefs})
for result in out:
 text=(r/'Reconstructed'/result['scene']).read_text()
 blocks={block.splitlines()[0].split('&')[1]:block for block in re.split(r'^--- !u!',text,flags=re.M)[1:]}
 for diff in result['differences']:
  pid=diff['source_component'].rsplit('::',1)[1];block=blocks.get(pid,'')
  if not block.startswith('224 '):continue
  parts=diff['field'].split('.')
  if len(parts)!=2:continue
  line=next((line for line in block.splitlines() if line.strip().startswith(parts[0]+':')), '')
  match=re.search(r'\b'+re.escape(parts[1])+r':\s*([-+0-9.eE]+)',line)
  if match:
   value=float(match[1]);diff['target_serialized_value']=value;diff['source_value_preserved_in_target_yaml']=math.isclose(value,float(diff['source']),abs_tol=1e-5,rel_tol=1e-6)
   if diff['source_value_preserved_in_target_yaml']:diff['classification']='RectTransform value differs after editor load; original serialized value remains preserved. Loaded layout has not been compared with original rendering.'
report={'utc':datetime.datetime.now(datetime.timezone.utc).isoformat(),'phase':'Provisional: final target freeze and rerun required','unity':actual['unity'],'results':out,'limitations':['Original24Bootobjects only; source-component correspondence uses unique hierarchy paths and component order, independently checked by companion hierarchy comparator.','Primitive scalar/vector component leaves plus array sizes and scene-local/original-null references tested; external identity map absent and script GUID migration assessed by component type instead.','Float toleranceabs1e-5/rel1e-6; scene settings and whole-prefab fidelity outside scope.']};(r/'verification/boot-field-comparison.json').write_text(json.dumps(report,indent=2));print(json.dumps([{'scene':x['scene'],'checked':x['fields_checked'],'diff':len(x['differences']),'missing':len(x['source_fields_not_exposed_at_same_path']),'unverifiedrefs':len(x['external_references_without_verified_identity_map']),'samples':x['differences'][:12]} for x in out],indent=2))
