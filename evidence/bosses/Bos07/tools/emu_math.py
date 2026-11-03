# Emulate CRT float functions in GameAssembly.dll to identify them (read-only).
import struct, sys
from unicorn import *
from unicorn.x86_const import *
b=open(r'D:\games\Truxton Extreme\GameAssembly.dll','rb').read()
pe=struct.unpack_from('<I',b,0x3c)[0]; ns=struct.unpack_from('<H',b,pe+6)[0]; osz=struct.unpack_from('<H',b,pe+20)[0]; opt=pe+24
BASE=0x180000000
uc=Uc(UC_ARCH_X86,UC_MODE_64)
img=struct.unpack_from('<I',b,opt+56)[0]
uc.mem_map(BASE,(img+0xfff)&~0xfff)
for i in range(ns):
    off=opt+osz+i*40; vs,va,sz,ptr=struct.unpack_from('<4I',b,off+8)
    uc.mem_write(BASE+va,b[ptr:ptr+sz])
STACK=0x7000000; uc.mem_map(STACK,0x100000)
def call(rva,x,y=None):
    uc.reg_write(UC_X86_REG_RSP,STACK+0x80000)
    uc.mem_write(STACK+0x80000,struct.pack('<Q',0xdead0000))
    uc.reg_write(UC_X86_REG_XMM0,struct.unpack('<I',struct.pack('<f',x))[0])
    if y is not None: uc.reg_write(UC_X86_REG_XMM1,struct.unpack('<I',struct.pack('<f',y))[0])
    try: uc.emu_start(BASE+rva,0xdead0000,count=200000)
    except UcError as e: return 'err %s rip=%x'%(e,uc.reg_read(UC_X86_REG_RIP))
    return struct.unpack('<f',struct.pack('<I',uc.reg_read(UC_X86_REG_XMM0)&0xffffffff))[0]
if sys.argv[1]=='2':
    for a in sys.argv[2:]:
        r=int(a,16); print(a,[call(r,x,y) for x,y in ((1.0,0.0),(0.0,1.0),(1.0,1.0))])
    sys.exit()
for a in sys.argv[1:]:
    r=int(a,16); print(a,[call(r,x) for x in (0.0,0.5,1.5707964,2.0)])
