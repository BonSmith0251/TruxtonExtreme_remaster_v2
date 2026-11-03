import json,sys
pat=sys.argv[1]
for line in open(r'D:\games\TruxtonExRecon\code\methods.jsonl',encoding='utf-8-sig'):
    m=json.loads(line)
    if pat not in m['type']: continue
    a=[x for x in m['attributes'] if x['type']=='Cpp2ILInjected.AddressAttribute']
    f=a[0]['fields'] if a else {}
    print(f.get('RVA'),f.get('Length'),m['type'],m['signature'].split('::')[-1])
