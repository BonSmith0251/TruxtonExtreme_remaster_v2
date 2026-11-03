"""Diagnostic reproducer of a REJECTED unaligned generated header. Do not use its fields as validated evidence."""
import sys,json
from pathlib import Path
sys.path.insert(0,r'D:\Games\TruxtonExRecon\tools\typetree-deps')
import UnityPy
from UnityPy.helpers.TypeTreeGenerator import TypeTreeGenerator
from UnityPy.helpers.TypeTreeNode import TypeTreeNode
base=Path(r'D:\games\Truxton Extreme\TATSUJIN EXTREME_Data')
g=TypeTreeGenerator('6000.3.7f1',generator='AssetsTools')
g.load_local_dll_folder(r'D:\Games\TruxtonExRecon\code\metadata-assemblies')
print('loaded',len(g.get_loaded_dll_names()),flush=True)
e=UnityPy.load(str(base/'globalgamemanagers.assets'));e.typetree_generator=g
obj=next(x for x in e.objects if x.path_id==3829)
head=obj.parse_monobehaviour_head();s=head.m_Script.deref_parse_as_object();full=s.m_Namespace+'.'+s.m_ClassName
print('script',s.m_AssemblyName,full,flush=True)
nodes=json.loads(g.get_nodes_as_json(s.m_AssemblyName,full));print('nodes',str(nodes)[:700],flush=True)
node=obj.generate_monobehaviour_node();tree=obj.read_typetree(nodes=node,check_read=True);print('PASS',list(tree),flush=True)
Path(r'D:\Games\TruxtonExRecon\evidence\managed-layouts\pipeline-probe-rejected-wrong-script.json').write_text(json.dumps(tree,indent=2))
