import json,sys
want=sys.argv[1:]
types={}
for l in open(r'D:\games\TruxtonExRecon\code\types.jsonl',encoding='utf-8-sig'):
    d=json.loads(l); types[d['type']]=d
def dump(t):
    d=types[t]; print('==',t,'base',d['baseType'])
    for f in d['fields']:
        off=[a['fields'].get('Offset') for a in f['attributes'] if a['type'].endswith('FieldOffsetAttribute')]
        print(' ',off[0] if off else '-', f['flags'][:30].ljust(30), f['type'], f['name'], f['constant'] if f['constant'] is not None else '')
for t in want:
    if t.endswith('*'):
        for k in types:
            if k.startswith(t[:-1]): dump(k)
    else: dump(t)
