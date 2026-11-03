import json,pathlib,math,datetime
r=pathlib.Path(r'D:\Games\TruxtonExRecon');expected=json.loads((r/'verification/source-boot-hierarchies.json').read_text());actual=json.loads((r/'evidence/scene-integration/editor-scene-audit.json').read_text());result=[]
for level,scene in [('level0','Assets/OriginalRecovered/Scenes/Boot.unity'),('level1','Assets/OriginalRecovered/Scenes/BootTXE.unity')]:
 a=next(x for x in actual['scenes'] if x['path']==scene);en={x['path']:x for x in expected[level]['hierarchy']};an={x['path']:x for x in a['hierarchy']};diff=[]
 if len(an)!=len(a['hierarchy']):diff.append({'field':'duplicate target paths'})
 for p,e in en.items():
  if p not in an:diff.append({'path':p,'field':'missing object'});continue
  v=an[p]
  for key in ['name','parent','layer','active','transformType']:
   if (e[key] or None)!=(v[key] or None):diff.append({'path':p,'field':key,'source':e[key],'target':v[key]})
  if e['parent'] is not None and e['sibling']!=v['sibling']:diff.append({'path':p,'field':'sibling','source':e['sibling'],'target':v['sibling']})
  for key in ['localPosition','localRotation','localScale']:
   if any(not math.isclose(e[key][k],v[key][k],rel_tol=1e-6,abs_tol=1e-5) for k in e[key]):diff.append({'path':p,'field':key,'source':e[key],'target':v[key]})
  types=[c.split(',')[0] for c in v['components']]
  if e['components']!=types:diff.append({'path':p,'field':'component order/types','source':e['components'],'target':types})
 for p in an.keys()-en.keys():diff.append({'path':p,'field':'extra object'})
 result.append({'source':level,'scene':scene,'source_objects':len(en),'target_objects':a['objects'],'missingScripts':a['missingScripts'],'missingReferences':a['missingReferences'],'differences':diff,'tested_fields_match':not diff})
out={'utc':datetime.datetime.now(datetime.timezone.utc).isoformat(),'target_audit_time':actual['time'],'unity':actual['unity'],'results':result,'limitations':['Tests24originalBootGameObjects only; no2150prefab fidelity claim.','Component types and order are checked; metadata stub behaviors are not original methods.','Serialized component values, UnityEvents, RectTransform anchors/pivots and scene lighting are not emitted by this Editor audit and remain unverified.','Local transforms compare withabs1e-5/rel1e-6 float tolerance; original two scenes each contain one root.']};(r/'verification/boot-hierarchy-comparison.json').write_text(json.dumps(out,indent=2));print(json.dumps(out,indent=2))
