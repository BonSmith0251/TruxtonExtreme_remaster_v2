# Dump the death/damage bullet templates and selectors from the extracted enemy-attacks.json (read-only).
# usage: python -I templates.py
import json
J = r'D:\games\TruxtonExRecon\Reconstructed\Assets\Resources\StageCombat\enemy-attacks.json'
d = json.load(open(J, encoding='utf-8-sig'))
P = {p['name']: p for p in d['patterns']}; S = {s['name']: s for s in d['selectors']}
SEL = ['sj01_fired_sel', 'sh01_fired_sel', 'bsc01_fired_sel', 'bma01_fired_sel']
BT = ['sg01_fired', 'mg01_fired', 'mi01_fired', 'mo01_fired', 'bg04_grass_fired', 'bg05Tree', 'Sepper0_3way', 'Seppers_3way']
K = ['bulletName', 'bulletType', 'nArc', 'nStartArc', 'nRandomArc', 'nLimitArc', 'nSpeed', 'nRapidCount', 'nRapidDistance', 'nRapidInflation', 'nRapidWaySwitch', 'nRapidArcSwitch', 'isTarget', 'isRapidTarget', 'isSelfDir', 'isReverse']
for s in SEL:
    if s in S:
        print('SEL', s, [(c['pmode'], c['_btName'], c['_rate']) for c in S[s]['choices']])
        for c in S[s]['choices']:
            if c['_btName'] and c['_btName'] not in BT: BT.append(c['_btName'])
    else: print('SEL', s, 'MISSING')
print('name | ' + ' | '.join(K))
for b in BT:
    p = P.get(b) or P.get('Regident/' + b)
    print(b, '|', ' | '.join(str(p.get(k)) for k in K) if p else 'MISSING')
