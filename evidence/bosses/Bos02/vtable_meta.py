# Read the real Ene_Bos02 vtable from global-metadata.dat (v39): typedef stride 82, vtableMethods, methods stride 32.
import struct,sys
mb=open(r'D:\games\Truxton Extreme\TATSUJIN EXTREME_Data\il2cpp_data\Metadata\global-metadata.dat','rb').read()
so=0x99994
def s(i):
    e=mb.index(b'\0',so+i); return mb[so+i:e].decode('utf8','replace')
TD=0xcda2e0; TDS=82; NTD=18350
def td(k):
    r=mb[TD+k*TDS:TD+(k+1)*TDS]
    name,ns,byv,decl,par=struct.unpack_from('<5i',r,0)
    vstart=struct.unpack_from('<i',r,50)[0]; vcount=struct.unpack_from('<H',r,68)[0]
    return dict(name=s(name),ns=s(ns),vstart=vstart,vcount=vcount)
M=0x376fd8; MS=32
def meth(i):
    name,decl=struct.unpack_from('<2i',mb,M+i*MS)
    return s(name), decl
VM=0xbeea50
name=sys.argv[1] if len(sys.argv)>1 else 'Ene_Bos02'
for k in range(NTD):
    t=td(k)
    if t['name']==name:
        print(t)
        for j in range(t['vcount']):
            e=struct.unpack_from('<I',mb,VM+4*(t['vstart']+j))[0]
            typ=(e>>29)&7; idx=(e&0x1FFFFFFE)>>1
            if typ==3 or True:
                try:
                    mn,dt=meth(idx); dn=td(dt)['name'] if 0<=dt<NTD else '?'
                except Exception as ex: mn,dn='?','?'
            print(hex(0x138+16*j), j, typ, idx, dn+'::'+mn)
        break
