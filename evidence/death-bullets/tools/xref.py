# List methods whose code makes a RIP-relative reference to a .data slot (e.g. a TypeInfo/MethodRef usage). Read-only.
# usage: python -I xref.py <slotRVAhex> [nameFilterRegex]
import sys, bisect, re
import numpy as np
sys.path.insert(0, r'D:\games\TruxtonExRecon\evidence\bosses\Bos08\tools')
import il2
tgt = int(sys.argv[1], 16); flt = re.compile(sys.argv[2]) if len(sys.argv) > 2 else None
starts = sorted(il2.MNAME)
def owner(rva):
    j = bisect.bisect_right(starts, rva)-1; return (starts[j], il2.MNAME[starts[j]][0]) if j >= 0 else (0, '?')
seen = set()
for name, va, vsz, ptr, rsz, ch in il2.SECT:
    if name not in ('.text', 'il2cpp'): continue
    data = bytes(il2.b[ptr:ptr+rsz])
    for a in range(4):
        cnt = (len(data)-a)//4
        d = np.frombuffer(data, dtype='<i4', count=cnt, offset=a).astype(np.int64)
        pos = va + a + 4*np.arange(cnt, dtype=np.int64)
        hits = np.nonzero(pos + 4 + d == tgt)[0]
        for h in hits:
            s, o = owner(int(pos[h]))
            if (s, o) in seen: continue
            if flt and not flt.search(o): continue
            seen.add((s, o)); print('%x %s' % (s, o))
