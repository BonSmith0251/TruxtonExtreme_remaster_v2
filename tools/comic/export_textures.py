"""Decode selected Comic atlas textures using bounded stream range reads; retain source identities."""
import argparse,json,struct,io,hashlib,collections,time
from pathlib import Path
import numpy as np
from recover_comic import XorPath,inventory
import UnityPy
from UnityPy.export.Texture2DConverter import parse_image_data

def index_bundle(path,version):
 xp=XorPath(path,version)
 with xp.open('rb') as f:
  inventory.cstring(f);inventory.unpack(f,'>I');inventory.cstring(f);inventory.cstring(f)
  size,compressed,raw,flags=inventory.unpack(f,'>QIII');f.seek((f.tell()+15)&~15);start=f.tell()
  if flags&0x80:f.seek(size-compressed)
  info=io.BytesIO(inventory.decompress(f.read(compressed),raw,flags))
  if not flags&0x80:start=f.tell()
  if flags&0x200:start=(start+15)&~15
  info.read(16);n,=inventory.unpack(info,'>I');blocks=[];roff=0;coff=start
  for i in range(n):
   r,c,fl=inventory.unpack(info,'>IIH');blocks.append((roff,coff,r,c,fl));roff+=r;coff+=c
  n,=inventory.unpack(info,'>I');nodes={}
  for i in range(n):
   off,sz,fl=inventory.unpack(info,'>QQI');name=inventory.cstring(info);nodes[name]={'offset':off,'size':sz,'flags':fl}
 return xp,blocks,nodes

def read_range(xp,blocks,start,size):
 out=bytearray(size);consumed=0
 with xp.open('rb') as f:
  for ro,co,rs,cs,fl in blocks:
   if ro>=start+size or ro+rs<=start:continue
   f.seek(co);b=inventory.decompress(f.read(cs),rs,fl);lo=max(start,ro);hi=min(start+size,ro+rs)
   out[lo-start:hi-start]=b[lo-ro:hi-ro];consumed+=hi-lo
 if consumed!=size:raise ValueError(f'Incomplete stream: {consumed}/{size}')
 return out

def main():
 p=argparse.ArgumentParser();p.add_argument('--inventory',required=True);p.add_argument('--objects',required=True);p.add_argument('--out',required=True);p.add_argument('--limit',type=int,default=0);a=p.parse_args()
 inv=json.loads(Path(a.inventory).read_text());sources={r['source']:r for r in inv['sources'] if r.get('status')=='serialized nodes decoded'}
 rows=[json.loads(l) for l in Path(a.objects).open()];rows=[r for r in rows if r['type']=='Texture2D'];out=Path(a.out);out.mkdir(parents=True,exist_ok=True);count=0;last=None
 with (out/'textures.jsonl').open('a') as ledger:
  for row in rows:
   if a.limit and count>=a.limit:break
   rid=hashlib.sha256((row['source']+'|'+row['serialized_file']+'|'+row['path_id']).encode()).hexdigest()[:24];dest=out/(rid+'.png')
   if dest.exists():continue
   record=dict(row);record['output']=str(dest)
   try:
    if last!=row['source']:
     xp,blocks,nodes=index_bundle(Path(row['source']),sources[row['source']]['header_version']);last=row['source']
    d=row['details'];s=d['m_StreamData'];node=nodes[s['path'].split('/')[-1]]
    offset=int(s['offset']);size=int(s['size']);assert 0<=offset<=offset+size<=node['size']
    payload=read_range(xp,blocks,node['offset']+offset,size)
    img=parse_image_data(payload,d['m_Width'],d['m_Height'],d['m_TextureFormat'],(6000,3,7,1),19)
    img.save(dest,compress_level=3);record.update(status='decoded',bytes=dest.stat().st_size,sha256=hashlib.sha256(dest.read_bytes()).hexdigest(),decoded_mip=0)
    del img,payload
   except Exception as e:record.update(status='failed',error=repr(e))
   ledger.write(json.dumps(record)+'\n');ledger.flush();count+=1;print(count,record['name'],record['status'],record.get('bytes',0),flush=True)
if __name__=='__main__':main()
