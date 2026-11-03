# Map Unity script fileIDs (InGame.Kernel DLL classes) to class names: MD4("s\0\0\0"+ns+name)[:4] (same rule as tools/stage_combat/enemy_attacks.py).
import struct,json,sys
def md4(msg):
    F=lambda x,y,z:(x&y)|(~x&z); G=lambda x,y,z:(x&y)|(x&z)|(y&z); H=lambda x,y,z:x^y^z
    rol=lambda v,s:((v<<s)|(v>>(32-s)))&0xffffffff
    m=bytearray(msg); ml=len(m)*8; m.append(0x80)
    while len(m)%64!=56: m.append(0)
    m+=struct.pack('<Q',ml); a,b,c,d=0x67452301,0xefcdab89,0x98badcfe,0x10325476
    for i in range(0,len(m),64):
        X=struct.unpack('<16I',m[i:i+64]); A,B,C,D=a,b,c,d
        for k in range(16): A=rol((A+F(B,C,D)+X[k])&0xffffffff,[3,7,11,19][k%4]); A,B,C,D=D,A,B,C
        for k in range(16): A=rol((A+G(B,C,D)+X[(k%4)*4+k//4]+0x5a827999)&0xffffffff,[3,5,9,13][k%4]); A,B,C,D=D,A,B,C
        for k,o in enumerate([0,8,4,12,2,10,6,14,1,9,5,13,3,11,7,15]): A=rol((A+H(B,C,D)+X[o]+0x6ed9eba1)&0xffffffff,[3,9,11,15][k%4]); A,B,C,D=D,A,B,C
        a,b,c,d=(a+A)&0xffffffff,(b+B)&0xffffffff,(c+C)&0xffffffff,(d+D)&0xffffffff
    return struct.pack('<4I',a,b,c,d)
def fid(full):
    ns,_,name=full.rpartition('.'); return struct.unpack('<i',md4(('s\0\0\0'+ns+name).encode())[:4])[0]
T={}
for l in open(r'D:/games/TruxtonExRecon/code/types.jsonl',encoding='utf8'):
    d=json.loads(l)
    if '/' not in d['type']: T[fid(d['type'])]=(d['type'],d.get('baseType'))
for a in sys.argv[1:]: print(a, T.get(int(a)))
