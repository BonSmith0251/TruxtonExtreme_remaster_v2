"""Print an IL2CPP switch jump table (int32 RVAs relative to image base). Usage: python -I jt.py <tableRVA hex> <count>"""
import struct, sys
b = open(r'D:\games\Truxton Extreme\GameAssembly.dll', 'rb').read()
pe = struct.unpack_from('<I', b, 0x3c)[0]; ns = struct.unpack_from('<H', b, pe + 6)[0]; osz = struct.unpack_from('<H', b, pe + 20)[0]; opt = pe + 24
t = int(sys.argv[1], 16)
for i in range(ns):
    off = opt + osz + i * 40; vs, va, sz, ptr = struct.unpack_from('<4I', b, off + 8)
    if va <= t < va + sz: p = ptr + t - va
for i, v in enumerate(struct.unpack_from('<%dI' % int(sys.argv[2]), b, p)): print(i, hex(v))
