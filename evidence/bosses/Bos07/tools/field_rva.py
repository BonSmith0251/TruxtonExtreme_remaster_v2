# Read <PrivateImplementationDetails> field RVA data from global-metadata.dat (v39) by field name (read-only).
import struct, sys
mb=open(r'D:\games\Truxton Extreme\TATSUJIN EXTREME_Data\il2cpp_data\Metadata\global-metadata.dat','rb').read()
sec=[struct.unpack_from('<3i',mb,8+12*i) for i in range(30)]
names=['stringLiteral','stringLiteralData','string','events','properties','methods','parameterDefaultValues','fieldDefaultValues','fieldAndParameterDefaultValueData','fieldMarshaledSizes','parameters','fields']
S=dict(zip(names,sec))
str_off=S['string'][0]
def cstr(i):
    o=str_off+i; e=mb.index(b'\0',o); return mb[o:e].decode('utf-8','replace')
fo,fs,fc=S['fields']; esz=fs//fc if fc else 0
print('fields',fo,fs,fc,'entry',esz, 'fdv',S['fieldDefaultValues'])
want=sys.argv[1:]
hits={}
for i in range(fc):
    nameIdx=struct.unpack_from('<i',mb,fo+i*esz)[0]
    try: n=cstr(nameIdx)
    except Exception: continue
    if n in want: hits[i]=n
print(hits)
do,ds,dc=S['fieldDefaultValues']; dsz=ds//dc
dat=S['fieldAndParameterDefaultValueData'][0]
ents=[struct.unpack_from('<3i',mb,do+k*dsz) for k in range(dc)]
idxs=sorted(e[2] for e in ents)
for e in ents:
    if e[0] in hits:
        start=e[2]; nxt=min([x for x in idxs if x>start] or [start+64])
        raw=mb[dat+start:dat+nxt]
        print(hits[e[0]], 'dataIndex',start,'len',len(raw), struct.unpack_from('<%di'%(len(raw)//4),raw))
