import json,pathlib,collections,UnityPy
r=pathlib.Path(r'D:\Games\TruxtonExRecon\code'); game=pathlib.Path(r'D:\games\Truxton Extreme'); d=json.loads((r/'script-attachment-coverage.json').read_text()); grouped=collections.defaultdict(list)
for x in d['missingMetadataAttachments']:grouped[x['reference']['owner'].split('::')[0]].append(x)
out=r/'missing-type-shells';out.mkdir(exist_ok=True);records=[]
for rel,rows in grouped.items():
 env=UnityPy.load(str(game/rel)); wanted={int(x['reference']['owner'].split('::')[-1]):x for x in rows}
 for obj in env.objects:
  if obj.path_id not in wanted:continue
  row=wanted[obj.path_id];name=row['type']['fullType'];record=dict(source=row['reference']['owner'],type=row['type'],structure=obj.dump_typetree_structure(),values=obj.read_typetree());records.append(record)
 (out/'source-layouts.json').write_text(json.dumps(records,indent=2),encoding='utf-8')
 del env
print('\n'.join(x['type']['fullType']+'\n'+x['structure'] for x in records))
