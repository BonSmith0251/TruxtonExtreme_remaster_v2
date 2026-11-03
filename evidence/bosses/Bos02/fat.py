# fat.py <TypeFullName> <hexoff>... : field at offset along the base chain
import json,sys
types={}
for l in open(r'D:\games\TruxtonExRecon\code\types.jsonl',encoding='utf-8-sig'):
    d=json.loads(l); types[d['type']]=d
want=[int(x,16) for x in sys.argv[2:]]
t=sys.argv[1]
while t in types:
    for f in types[t]['fields']:
        o=[a['fields'].get('Offset') for a in f['attributes'] if a['type'].endswith('FieldOffsetAttribute')]
        if o and 'Static' not in f['flags'] and int(o[0],16) in want: print(t,o[0],f['type'],f['name'])
    t=types[t]['baseType']
