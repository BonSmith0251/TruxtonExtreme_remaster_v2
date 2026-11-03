import struct,sys
exec(open('dis.py').read().split("if __name__")[0])
tab=int(sys.argv[1],16); n=int(sys.argv[2]); first=int(sys.argv[3])
for i in range(n):
    print(first+i, hex(struct.unpack_from('<I',b,raw(tab)+4*i)[0]))
