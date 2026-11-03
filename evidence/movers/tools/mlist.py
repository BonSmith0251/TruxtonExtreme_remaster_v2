# List methods (RVA, length, signature) of types whose name ends with any argument. Read-only.
import sys, json
want = sys.argv[1:]
for line in open(r'D:\games\TruxtonExRecon\code\methods.jsonl', encoding='utf-8-sig'):
    m = json.loads(line); t = m['type']
    if not any(t == w or t.endswith('.' + w) or t.endswith('/' + w) or ('.'+w+'/') in t or t.startswith(w+'/') for w in want): continue
    a = [x for x in m['attributes'] if x['type'] == 'Cpp2ILInjected.AddressAttribute']
    r = a[0]['fields'].get('RVA') if a else None; n = a[0]['fields'].get('Length') if a else None
    print('%-10s %-6s %s :: %s' % (r, n, t, m['signature'].split('::')[-1]))
