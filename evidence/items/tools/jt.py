import sys, struct
sys.path.insert(0, r'D:\games\TruxtonExRecon\evidence\bosses\Bos08\tools')
import il2
base=0  # rdx = image base-relative: lea rdx,[rip-0x1d70018] -> rdx = 0 (RVA space)
addr=int(sys.argv[1],16); n=int(sys.argv[2]); first=int(sys.argv[3])
d=il2.rd(addr,4*n)
for i in range(n):
    v=struct.unpack_from('<i',d,4*i)[0]
    print(first+i, hex(v))
