import json, struct, sys

# Unity script fileID for a class inside a DLL: first 4 bytes (LE int32) of MD4("s\0\0\0" + namespace + name).
def md4(msg):
    def F(x, y, z): return (x & y) | (~x & z)
    def G(x, y, z): return (x & y) | (x & z) | (y & z)
    def H(x, y, z): return x ^ y ^ z
    rol = lambda v, s: ((v << s) | (v >> (32 - s))) & 0xffffffff
    m = bytearray(msg)
    ml = len(m) * 8
    m.append(0x80)
    while len(m) % 64 != 56:
        m.append(0)
    m += struct.pack('<Q', ml)
    a, b, c, d = 0x67452301, 0xefcdab89, 0x98badcfe, 0x10325476
    for i in range(0, len(m), 64):
        X = struct.unpack('<16I', m[i:i + 64])
        A, B, C, D = a, b, c, d
        for k in range(16):
            s = [3, 7, 11, 19][k % 4]
            A = rol((A + F(B, C, D) + X[k]) & 0xffffffff, s); A, B, C, D = D, A, B, C
        for k in range(16):
            s = [3, 5, 9, 13][k % 4]
            A = rol((A + G(B, C, D) + X[(k % 4) * 4 + k // 4] + 0x5a827999) & 0xffffffff, s); A, B, C, D = D, A, B, C
        order = [0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15]
        for k in range(16):
            s = [3, 9, 11, 15][k % 4]
            A = rol((A + H(B, C, D) + X[order[k]] + 0x6ed9eba1) & 0xffffffff, s); A, B, C, D = D, A, B, C
        a, b, c, d = (a + A) & 0xffffffff, (b + B) & 0xffffffff, (c + C) & 0xffffffff, (d + D) & 0xffffffff
    return struct.pack('<4I', a, b, c, d)

def file_id(ns, name):
    return struct.unpack('<i', md4(('s\0\0\0' + ns + name).encode('utf-8'))[:4])[0]

assert md4(b'abc').hex() == 'a448017aaf21d8525fc10ae87aa6729d'
want = set(int(x) for x in sys.argv[2:])
for line in open(sys.argv[1], encoding='utf-8'):
    t = json.loads(line)
    full = t['type']
    ns, _, name = full.rpartition('.')
    fid = file_id(ns, name)
    if fid in want:
        print(fid, t['assembly'], full, 'base=' + str(t.get('baseType')), 'fields=' + ','.join(f.get('name', '?') for f in t.get('fields', []))[:400])
