from pathlib import Path
import struct

def md4(data):
 n=len(data);data+=b'\x80'+b'\0'*((55-n)%64)+struct.pack('<Q',n*8);state=[0x67452301,0xefcdab89,0x98badcfe,0x10325476]
 for off in range(0,len(data),64):
  x=struct.unpack('<16I',data[off:off+64]);a,b,c,d=state
  for round in range(3):
   order=list(range(16)) if round==0 else [i for j in range(4) for i in range(j,16,4)] if round==1 else [0,8,4,12,2,10,6,14,1,9,5,13,3,11,7,15]
   shifts=[[3,7,11,19],[3,5,9,13],[3,9,11,15]][round]
   for i,k in enumerate(order):
    f=(b&c)|(~b&d) if round==0 else (b&c)|(b&d)|(c&d) if round==1 else b^c^d
    v=(a+f+x[k]+[0,0x5a827999,0x6ed9eba1][round])&0xffffffff;s=shifts[i%4];v=((v<<s)|(v>>(32-s)))&0xffffffff;a,b,c,d=d,v,b,c
  state=[(v+w)&0xffffffff for v,w in zip(state,[a,b,c,d])]
 return struct.pack('<4I',*state)
print(md4(b'').hex())
print(int.from_bytes(md4(b's\0\0\0UnityEngine.Rendering.UniversalUniversalRenderPipelineAsset')[:4],'little',signed=True))
