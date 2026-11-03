# Unity m_Script fileID of a class inside a managed DLL = first int32 (LE) of MD4("s\0\0\0" + namespace + "." + class).
# usage: C:\Python311\python.exe -I script_fileid.py <prefab> ; prints the class of every InGame.Kernel m_Script fileID.
import struct, sys, json, re
def md4(msg):
    def F(x, y, z): return (x & y) | (~x & z)
    def G(x, y, z): return (x & y) | (x & z) | (y & z)
    def H(x, y, z): return x ^ y ^ z
    def rol(v, s): v &= 0xffffffff; return ((v << s) | (v >> (32 - s))) & 0xffffffff
    ml = len(msg) * 8; msg += b'\x80' + b'\0' * ((55 - len(msg)) % 64) + struct.pack('<Q', ml)
    a, b, c, d = 0x67452301, 0xefcdab89, 0x98badcfe, 0x10325476
    for i in range(0, len(msg), 64):
        X = struct.unpack('<16I', msg[i:i+64]); A, B, C, D = a, b, c, d
        for k in range(16):
            s = (3, 7, 11, 19)[k % 4]; A, B, C, D = D, rol(A + F(B, C, D) + X[k], s), B, C
        for k in range(16):
            s = (3, 5, 9, 13)[k % 4]; idx = (k % 4) * 4 + k // 4
            A, B, C, D = D, rol(A + G(B, C, D) + X[idx] + 0x5A827999, s), B, C
        for k in range(16):
            s = (3, 9, 11, 15)[k % 4]; idx = (0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15)[k]
            A, B, C, D = D, rol(A + H(B, C, D) + X[idx] + 0x6ED9EBA1, s), B, C
        a, b, c, d = (a + A) & 0xffffffff, (b + B) & 0xffffffff, (c + C) & 0xffffffff, (d + D) & 0xffffffff
    return struct.pack('<4I', a, b, c, d)
def fileid(full):
    ns, _, name = full.rpartition('.')
    return struct.unpack('<i', md4(b's\0\0\0' + (ns + name).encode())[:4])[0]
assert md4(b'abc').hex() == 'a448017aaf21d8525fc10ae87aa6729d'
types = [json.loads(l)['type'] for l in open(r'D:\games\TruxtonExRecon\code\types.jsonl', encoding='utf-8') if '"InGame.Kernel"' in l]
table = {fileid(t): t for t in types if '/' not in t and '<' not in t}
if __name__ == '__main__':
    for p in sys.argv[1:]:
        print('==', p)
        for m in re.finditer(r'm_Script: \{fileID: (-?\d+), guid: e1f38f7444bde25d3daf9193fd376658', open(p, encoding='utf-8').read()):
            print('  ', m.group(1), table.get(int(m.group(1)), '?'))
