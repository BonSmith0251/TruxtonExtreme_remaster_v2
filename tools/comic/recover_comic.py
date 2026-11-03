"""Read-only Comic wrapper recovery. Known UnityFS header yields cyclic32 XOR key; strict block/node decoding validates it. No source writes."""
import io, json, struct, importlib.util, argparse, collections, gzip
from pathlib import Path
import numpy as np
import UnityPy
spec=importlib.util.spec_from_file_location('inventory',r'C:\Users\Administrator\.codex\skills\truxton-asset-extraction\scripts\inventory_assets.py')
inventory=importlib.util.module_from_spec(spec);spec.loader.exec_module(inventory)
class XorReader:
 def __init__(self,path,key):self.f=path.open('rb');self.key=key
 def __enter__(self):return self
 def __exit__(self,*args):self.f.close()
 def tell(self):return self.f.tell()
 def seek(self,*args):return self.f.seek(*args)
 def read(self,n=-1):
  pos=self.f.tell();b=self.f.read(n)
  if not b:return b
  a=np.frombuffer(b,dtype=np.uint8).copy()
  k=np.frombuffer(self.key,dtype=np.uint8)
  np.bitwise_xor(a,k[(np.arange(len(a),dtype=np.uint32)+(pos%32))%32],out=a)
  return a.tobytes()
class XorPath:
 def __init__(self,p,version):
  self.path=p;header=b'UnityFS\0'+struct.pack('>I',8)+b'5.x.x\0'+version.encode()+b'\0'+b'\0'*3
  assert len(header)==32
  with p.open('rb') as f:self.key=bytes(a^b for a,b in zip(f.read(32),header))
 def open(self,mode):assert mode=='rb';return XorReader(self.path,self.key)
 def stat(self):return self.path.stat()
def main():
 p=argparse.ArgumentParser();p.add_argument('--source',required=True);p.add_argument('--out',required=True);a=p.parse_args()
 root=Path(a.source);out=Path(a.out);out.mkdir(exist_ok=True,parents=True);records=[];totals=collections.Counter()
 with (out/'objects.jsonl').open('w') as of, gzip.open(out/'raw-typetrees.jsonl.gz','wt') as trees:
  for i,path in enumerate(sorted(root.glob('*.bundle'))):
   r={'source':str(path),'bytes':path.stat().st_size,'transform':'cyclic XOR32; key inferred from validated UnityFS8 header','status':'failed'}
   for version in ['6000.3.7f1','6000.3.6f1']:
    try:
     xp=XorPath(path,version);header,buffers=inventory.bundle_metadata(xp);r['header']=header;r['status']='serialized nodes decoded';r['payload_status']='resource blocks not yet decoded';r['header_version']=version
     for cab,b in buffers.items():
      inventory.scan_serialized(bytes(b),str(path),cab,of,r)
      env=UnityPy.load(bytes(b))
      for obj in env.objects:
       try:tree=obj.read_typetree();trees.write(json.dumps({'source':str(path),'serialized_file':cab,'path_id':str(obj.path_id),'type':obj.type.name,'tree':tree},default=lambda x:list(x) if isinstance(x,bytes) else str(x))+'\n')
       except Exception as e:pass
     totals.update(r.get('counts',{}));break
    except Exception as e:r.setdefault('attempts',[]).append({'version':version,'error':repr(e)})
   records.append(r);of.flush();print(i+1,path.name,r['status'],dict(r.get('counts',{})),flush=True)
   (out/'inventory.json').write_text(json.dumps({'sources':records,'counts':dict(totals),'source_count':len(records),'final':False},indent=2))
 (out/'inventory.json').write_text(json.dumps({'sources':records,'counts':dict(totals),'source_count':len(records),'final':True},indent=2))
if __name__=='__main__':main()
