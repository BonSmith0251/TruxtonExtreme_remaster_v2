import argparse, collections, hashlib, json, pathlib, struct, UnityPy
p=argparse.ArgumentParser(); p.add_argument('--source',required=True); p.add_argument('--out',required=True); a=p.parse_args()
r=pathlib.Path(a.source); out=pathlib.Path(a.out); out.mkdir(parents=True,exist_ok=True)
data=r/'TATSUJIN EXTREME_Data'
def dump(name,obj): (out/name).write_text(json.dumps(obj,indent=2,ensure_ascii=False),encoding='utf-8')
def sha(p):
 h=hashlib.sha256()
 with p.open('rb') as f:
  for b in iter(lambda:f.read(1024*1024),b''): h.update(b)
 return h.hexdigest()
meta=data/'il2cpp_data/Metadata/global-metadata.dat'
settings=json.loads((data/'StreamingAssets/aa/settings.json').read_text())
report={'schema':'truxton-migration-probe/1','source_root':str(r),'tool_version':UnityPy.__version__,'source_engine':'6000.3.7f1','requested_engine':'2023.2.22f1','baseline_engine':None,'tested_engine':None,'metadata_header':struct.unpack('<II',meta.read_bytes()[:8]),'addressables_version':settings['m_AddressablesVersion'],'sources':[],'errors':[],'settings':{},'managed_header_inventory':[],'scripts':[],'warning':'MonoBehaviour rows are header-only and do not constitute full decoded fields. No Unity target run performed.'}
for name in ['globalgamemanagers','globalgamemanagers.assets','resources.assets','sharedassets1.assets']:
 path=data/name; env=UnityPy.load(str(path)); objs=list(env.objects)
 report['sources'].append({'path':str(path),'sha256':sha(path),'classes':dict(collections.Counter(o.type.name for o in objs))})
 for o in objs:
  typ=o.type.name
  if typ=='MonoScript':
   d=o.read_typetree()
   report['scripts'].append({'source':name,'path_id':str(o.path_id),'name':d.get('m_Name'),'class':d.get('m_ClassName'),'namespace':d.get('m_Namespace'),'assembly':d.get('m_AssemblyName')})
  elif typ=='MonoBehaviour':
   d=o.read_typetree(check_read=False)
   report['managed_header_inventory'].append({'source':name,'path_id':str(o.path_id),'name':d.get('m_Name'),'script':d.get('m_Script'),'game_object':d.get('m_GameObject'),'body_status':'unparsed-stripped-typetree','byte_size':o.byte_size})
  elif name=='globalgamemanagers':
   try: report['settings'][typ]=o.read_typetree()
   except Exception as e: report['errors'].append({'source':name,'path_id':str(o.path_id),'type':typ,'error':str(e)})
dump('source-compatibility-probe.json',report)
print(json.dumps({'sources':len(report['sources']),'script_headers':len(report['scripts']),'managed_headers':len(report['managed_header_inventory']),'errors':report['errors']}))
