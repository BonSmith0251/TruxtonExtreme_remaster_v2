import json,sys
pat=sys.argv[1]
for l in open(r'D:/games/TruxtonExRecon/code/types.jsonl',encoding='utf8'):
    d=json.loads(l)
    t=d.get('type','')
    if pat in t:
        print('==',t,'base',d.get('baseType'))
        for f in d.get('fields',[]):
            off=[a['fields'].get('Offset') for a in f.get('attributes',[]) if a['type'].endswith('FieldOffsetAttribute')]
            print('  ',off[0] if off else '-', f['flags'][:30], f['type'], f['name'], f.get('constant'))
