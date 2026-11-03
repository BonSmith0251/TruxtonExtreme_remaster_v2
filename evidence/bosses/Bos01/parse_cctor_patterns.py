# Parse WingAttackCommand arrays (Time, Cannon, IsLaser) built in Ene_Bos01..cctor (0x1d7bf30) from dis_all.txt.
import re,struct,json
L=open('dis_all.txt',encoding='utf8').read().split('\n')
s=[i for i,l in enumerate(L) if '===== Ene_Bos01::.cctor' in l][0]
e=[i for i,l in enumerate(L) if '===== Ene_Bos01::.ctor' in l][0]
L=L[s:e]
BITS={1:'L4',2:'L3',4:'L2',8:'L1',16:'R4',32:'R3',64:'R2',128:'R1',256:'BodyL',512:'BodyR',1024:'Core',2048:'WL5',4096:'WL4',8192:'WL3',16384:'WL2',32768:'WL1',65536:'WR5',131072:'WR4',262144:'WR3',524288:'WR2',1048576:'WR1'}
def bitname(v):
    return '|'.join(n for b,n in sorted(BITS.items()) if v&b) or 'none'
def imm(x):
    x=x.strip()
    if x in('eax','rax','al'): return 0
    return int(x,16) if x.startswith('0x') else int(x)
arrays=[];cur=None;t=c=lz=None;pending=None
for l in L:
    m=re.search(r'mov\s+edx, (0x[0-9a-f]+|\d+)$',l.split(' ;')[0])
    if m: pending=imm(m.group(1))
    if 'call     0x4dfe00' in l and pending is not None:
        cur=dict(count=pending,items=[]);arrays.append(cur);pending=None
    if cur is None: continue
    m=re.search(r'mov\s+dword ptr \[rbp - 0x20\], (\S+)',l)
    if m: t=struct.unpack('<f',struct.pack('<I',imm(m.group(1))))[0]
    m=re.search(r'mov\s+qword ptr \[rbp - 0x1c\], (\S+)',l)
    if m: c=imm(m.group(1))
    m=re.search(r'mov\s+byte ptr \[rbp - 0x18\], (\S+)',l)
    if m: lz=imm(m.group(1))
    m=re.search(r'movsd\s+qword ptr \[rdx \+ (0x[0-9a-f]+)\], xmm0',l)
    if m: cur['items'].append(dict(Time=t,Cannon=c,CannonName=bitname(c),IsLaser=bool(lz)))
    m=re.search(r'mov\s+qword ptr \[rcx \+ (0x[0-9a-f]+)\], (rdx|rbx|rax)',l)
    if m and 'static' not in cur: cur['static']=m.group(1)
names={'0x68':'_pattern1','0x70':'_pattern2','0x78':'_pattern3','0x80':'_pattern4','0x88':'_pattern5','0x90':'_allPatterns'}
out=[]
arrays=[a for a in arrays if a['items'] or a.get('static')=='0x90']
for a in arrays:
    a['field']=names.get(a.get('static'),a.get('static')); out.append(a)
    print(a['field'],a['count'],len(a['items']))
    for it in a['items']: print('   t=%-5g %-22s laser=%s'%(it['Time'],it['CannonName'],it['IsLaser']))
json.dump(out,open('wing_patterns.json','w'),indent=1)
