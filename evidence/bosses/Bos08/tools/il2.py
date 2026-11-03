# Read-only helpers: PE mapping, IL2CPP v39 metadata, metadata-usage decoding. Bos08 spec work.
import struct, json, pathlib
GAME = pathlib.Path(r'D:\games\Truxton Extreme')
b = (GAME/'GameAssembly.dll').read_bytes()
pe = struct.unpack_from('<I', b, 0x3c)[0]; ns = struct.unpack_from('<H', b, pe+6)[0]; osz = struct.unpack_from('<H', b, pe+20)[0]
opt = pe+24; IMAGEBASE = struct.unpack_from('<Q', b, opt+24)[0]
SECT = []
for i in range(ns):
    off = opt+osz+i*40; name = b[off:off+8].rstrip(b'\0').decode(); vs, va, sz, ptr = struct.unpack_from('<4I', b, off+8)
    ch = struct.unpack_from('<I', b, off+36)[0]
    SECT.append((name, va, max(vs, sz), ptr, sz, ch))
def sect_of(rva):
    for s in SECT:
        if s[1] <= rva < s[1]+s[2]: return s
def raw(rva):
    s = sect_of(rva)
    if s is None or rva-s[1] >= s[4]: return None
    return s[3]+rva-s[1]
def rd(rva, n):
    o = raw(rva); return None if o is None else b[o:o+n]
def q(rva):
    d = rd(rva, 8); return None if d is None else struct.unpack('<Q', d)[0]

mb = open(GAME/'TATSUJIN EXTREME_Data'/'il2cpp_data'/'Metadata'/'global-metadata.dat', 'rb').read()
H = [struct.unpack_from('<3i', mb, 8+12*i) for i in range(31)]
lo, ls, lc = H[0]; do = H[1][0]
offs = struct.unpack_from('<%di' % lc, mb, lo)
LIT = [mb[do+offs[i]:do+(offs[i+1] if i+1 < lc else do+H[1][1]-do)].decode('utf-8', 'replace') for i in range(lc)]
def lit(i):
    return LIT[i] if 0 <= i < len(LIT) else None
SO = H[2][0]
def mstr(i):
    e = mb.index(b'\0', SO+i); return mb[SO+i:e].decode('utf-8', 'replace')
MO, MS, MC = H[5]
def methoddef(i):
    if not 0 <= i < MC: return None
    name, decl = struct.unpack_from('<IH', mb, MO+32*i)
    return mstr(name), decl
TO, TS, TC = H[19]
def typedef_name(i):
    if not 0 <= i < TC: return '?'
    n, nsx = struct.unpack_from('<II', mb, TO+TS//TC*i)
    return (mstr(nsx)+'.' if nsx else '')+mstr(n)

# methods.jsonl RVA -> names
MNAME = {}
for line in open(r'D:\games\TruxtonExRecon\code\methods.jsonl', encoding='utf-8-sig'):
    m = json.loads(line)
    a = [x for x in m['attributes'] if x['type'] == 'Cpp2ILInjected.AddressAttribute']
    if not a or not a[0]['fields'].get('RVA'): continue
    r = int(a[0]['fields']['RVA'], 16)
    MNAME.setdefault(r, []).append(m['type'].split('.')[-1]+'::'+m['signature'].split('::')[-1])

REG = 0x3db4460  # Il2CppMetadataRegistration (found by typeDefinitionsSizesCount==fieldOffsetsCount==18350)
def va2rva(v): return v-IMAGEBASE
TYPES_N = q(REG+6*8); TYPES = va2rva(q(REG+7*8)); MSPEC_N = q(REG+8*8); MSPEC = va2rva(q(REG+9*8))
def type_name(ti, depth=0):
    if not 0 <= ti < TYPES_N or depth > 4: return '?type%d' % ti
    p = va2rva(q(TYPES+8*ti)); data = q(p); bits = struct.unpack('<I', rd(p+8, 4))[0]; t = (bits >> 16) & 0xff
    if t in (0x11, 0x12): return typedef_name(data & 0xffffffff)
    if t == 0x15:
        gc = va2rva(data); td = q(gc)
        return 'G<%s>' % (type_name_ptr(td, depth+1))
    if t == 0x1d: return type_name_ptr(data, depth+1)+'[]'
    if t == 0x14: return type_name_ptr(data, depth+1)+'[,]'
    return 'prim%x' % t
def type_name_ptr(va, depth=0):
    p = va2rva(va); data = q(p); bits = struct.unpack('<I', rd(p+8, 4))[0]; t = (bits >> 16) & 0xff
    if t in (0x11, 0x12): return typedef_name(data & 0xffffffff)
    if t == 0x15: return 'G<%s>' % type_name_ptr(q(va2rva(data)), depth+1)
    if t == 0x1d: return type_name_ptr(data, depth+1)+'[]'
    return 'prim%x' % t
GINST = va2rva(q(REG+3*8))
def ginst(i):
    if i < 0: return ''
    p = va2rva(q(GINST+8*i)); argc = q(p); argv = va2rva(q(p+8))
    return ','.join(type_name_ptr(q(argv+8*k)) for k in range(argc))
def mspec(i):
    md, ci, mi = struct.unpack('<3i', rd(MSPEC+12*i, 12))
    d = methoddef(md)
    if not d: return '?'
    g = ginst(ci); m = ginst(mi)
    return '%s%s::%s%s' % (typedef_name(d[1]), '<'+g+'>' if g else '', d[0], '<'+m+'>' if m else '')
def decode_usage(v):
    if v is None or not (v & 1): return None
    v &= 0xffffffff; t = v >> 29; idx = (v & 0x1FFFFFFF) >> 1
    if t == 5: return 'str:"%s"' % lit(idx)
    if t in (1, 2): return ('TypeInfo ' if t == 1 else 'Type ')+type_name(idx)
    if t == 6: return 'MethodRef '+mspec(idx)
    if t == 4:
        try:
            tn, g, fd = fieldref(idx); d = field_data(g, 48)
            return 'Field %s.%s%s' % (tn, fd[0][:12], (' data(i32)='+str(struct.unpack('<12i', d)) + ' data(f32)='+str(['%.6g' % x for x in struct.unpack('<12f', d)])) if d and len(d) == 48 else '')
        except Exception as ex: return 'Field? #%d %s' % (idx, ex)
    if t == 3:
        md = methoddef(idx); return 'MethodDef %s::%s' % (typedef_name(md[1]), md[0]) if md else 'methoddef#%d' % idx
    return 'usage t%d #%d' % (t, idx)
USAGE_NAMES={}

# ---- typedef / field resolution (v39: TypeIndex 4 bytes, TypeDefinitionIndex 2, GenericContainerIndex 2) ----
def typedef_raw(i):
    o = TO+TS//TC*i
    name, ns_, byval, decl, parent = struct.unpack_from('<IIiii', mb, o)
    gc = struct.unpack_from('<H', mb, o+20)[0]
    flags, fieldStart, methodStart = struct.unpack_from('<Iii', mb, o+22)
    counts = struct.unpack_from('<8H', mb, o+58)
    return dict(name=mstr(name), byval=byval, fieldStart=fieldStart, methodStart=methodStart, method_count=counts[0], field_count=counts[2])
FO, FS, FC = H[11]
def fielddef(i):
    n, t, tok = struct.unpack_from('<IiI', mb, FO+12*i); return mstr(n), t, tok
FRO = H[22][0]
def type_td(ti):
    p = va2rva(q(TYPES+8*ti)); data = q(p); return data & 0xffffffff
FDV = H[7]
_fdv = None
def field_default(fi):
    global _fdv
    if _fdv is None:
        _fdv = {}
        for k in range(FDV[2]):
            f, t, d = struct.unpack_from('<iii', mb, FDV[0]+12*k); _fdv[f] = (t, d)
    return _fdv.get(fi)
def fieldref(i):
    ti, fi = struct.unpack_from('<ii', mb, FRO+8*i)
    td = type_td(ti); t = typedef_raw(td); g = t['fieldStart']+fi
    return typedef_name(td), g, fielddef(g)
def field_data(gfi, n):
    d = field_default(gfi)
    if not d: return None
    return mb[H[8][0]+d[1]:H[8][0]+d[1]+n]

def find_typedef(name):
    return [i for i in range(TC) if struct.unpack_from('<I', mb, TO+82*i)[0] and mstr(struct.unpack_from('<I', mb, TO+82*i)[0]) == name]
VTO = H[17][0]
def vtable(td):
    o = TO+82*td
    vstart = struct.unpack_from('<i', mb, o+50)[0]; counts = struct.unpack_from('<8H', mb, o+58)
    out = []
    for k in range(counts[5]):
        e = struct.unpack_from('<I', mb, VTO+4*(vstart+k))[0]
        t = e >> 29; idx = (e & 0x1FFFFFFF) >> 1
        if e == 0: out.append((k, None)); continue
        if t == 3:
            md = methoddef(idx); out.append((k, '%s::%s' % (typedef_name(md[1]), md[0])))
        elif t == 6: out.append((k, 'spec '+mspec(idx)))
        else: out.append((k, 'enc %x' % e))
    return out
