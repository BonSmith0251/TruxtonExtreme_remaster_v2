import json,sys
want=sys.argv[1:]
for l in open(r'D:\games\TruxtonExRecon\code\types.jsonl',encoding='utf-8-sig'):
    d=json.loads(l)
    if any(d['type']==w or d['type'].startswith(w+'/') for w in want):
        print('==',d['type'],'base',d['baseType'])
        for f in d['fields']:
            off=''
            for a in f['attributes']:
                if a['type'].endswith('FieldOffsetAttribute'): off=a['fields']['Offset']
            ser='S' if any('SerializeField' in a['type'] for a in f['attributes']) else ''
            print(f"  {off:>6} {ser:1} {f['flags'][:20]:20} {f['type']:50} {f['name']} {f['constant'] if f['constant'] is not None else ''}")
