import json,pathlib,ctypes,struct,collections
r=pathlib.Path(r'D:\Games\TruxtonExRecon\code\simple-native-recovery');rows=json.loads((r/'candidates.json').read_text());types={}
for line in (r.parent/'types.jsonl').open(encoding='utf8'):
 t=json.loads(line);types[(t['assembly'],t['type'])]=t
scalar={'System.Boolean':ctypes.c_bool,'System.Byte':ctypes.c_uint8,'System.SByte':ctypes.c_int8,'System.Char':ctypes.c_uint16,'System.UInt16':ctypes.c_uint16,'System.Int16':ctypes.c_int16,'System.Int32':ctypes.c_int32,'System.UInt32':ctypes.c_uint32,'System.Int64':ctypes.c_int64,'System.UInt64':ctypes.c_uint64,'System.Single':ctypes.c_float,'System.Double':ctypes.c_double}
va=ctypes.windll.kernel32.VirtualAlloc;va.restype=ctypes.c_void_p;va.argtypes=[ctypes.c_void_p,ctypes.c_size_t,ctypes.c_uint32,ctypes.c_uint32];vf=ctypes.windll.kernel32.VirtualFree;vf.argtypes=[ctypes.c_void_p,ctypes.c_size_t,ctypes.c_uint32]
results=[]
for m in rows:
 data=bytes.fromhex(m['nativeBytes']);code=va(None,4096,0x3000,0x40)
 if not code:raise OSError('VirtualAlloc')
 try:
  ctypes.memmove(code,data,len(data));field=m['field'];kind=m['kind']
  if field:
   typ=field['type'];enum=types.get((m['assembly'],typ));under=next((f['type'] for f in enum['fields'] if f['name']=='value__'),typ) if enum and enum['baseType']=='System.Enum' else typ
   cty=scalar.get(under,ctypes.c_void_p);offset=int(next(a['fields']['Offset'] for a in field['attributes'] if a['type']=='Cpp2ILInjected.FieldOffsetAttribute'),16)
   vals=([False,True] if under=='System.Boolean' else [0.0,-0.0,0.25,-13.5,1024.125] if under in ['System.Single','System.Double'] else [0,1,0x12345678] if cty==ctypes.c_void_p else [0,1,7,127])
   if under in ['System.Int16','System.Int32','System.Int64','System.SByte']:vals += [-1,-17]
   mem=ctypes.create_string_buffer(offset+32);ptr=ctypes.addressof(mem);fn=ctypes.WINFUNCTYPE(cty,ctypes.c_void_p)(code) if kind=='instance_field_getter' else ctypes.WINFUNCTYPE(None,ctypes.c_void_p,cty)(code)
   for val in vals:
    ctypes.memset(ptr,0xA5,len(mem));cell=cty.from_address(ptr+offset)
    if kind=='instance_field_getter':
     cell.value=val;before=bytes(mem);got=fn(ptr);want=cell.value
     if got!=want:raise AssertionError((m['signature'],val,got,want))
     if bytes(mem)!=before:raise AssertionError('Getter mutated memory')
    else:
     before=bytes(mem);fn(ptr,val);want=cty(val).value;got=cell.value
     if got!=want:raise AssertionError((m['signature'],val,got,want))
     after=bytes(mem)
     if before[:offset]!=after[:offset] or before[offset+ctypes.sizeof(cty):]!=after[offset+ctypes.sizeof(cty):]:raise AssertionError('Setter changed another field')
   results.append(dict(signature=m['signature'],status='pass',nativeCases=len(vals),offset=offset,managedType=typ))
  else:
   fn=ctypes.WINFUNCTYPE(ctypes.c_int32,ctypes.c_void_p)(code);got=fn(None)
   if got!=m['constant']:raise AssertionError((m['signature'],got,m['constant']))
   results.append(dict(signature=m['signature'],status='pass',nativeCases=1,constant=got))
 finally:vf(code,0,0x8000)
(r/'native-execution-check.json').write_text(json.dumps(dict(tool='ctypes Win64 ABI; execute only the exact reviewed one-instruction+ret fragments on synthetic memory, never load original DLL',methods=len(results),cases=sum(x['nativeCases'] for x in results),results=results),indent=2));print('Native fragment checks',len(results),'methods',sum(x['nativeCases'] for x in results),'cases passed')
