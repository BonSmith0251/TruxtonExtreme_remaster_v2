# Read RouteLUT assets (Assets/OriginalRecovered/InGame/RouteLUT/<name>.asset) into the stage-JSON route format
# {name, times, points, tangents, upVectors, polyLength}. Read-only on the project.
# usage: C:\Python311\python.exe -I lut_routes.py <out.json> <routeName> [...]
import sys, re, json, math
DIR = r'D:\games\TruxtonExRecon\Reconstructed\Assets\OriginalRecovered\InGame\RouteLUT'
def load(name):
    txt = open(DIR + '\\' + name + '.asset', encoding='utf-8').read()
    def block(key):
        m = re.search(r'^  %s:\n((?:  - .*\n)*)' % key, txt, re.M)
        return [l[4:] for l in m.group(1).splitlines()] if m else []
    vec = lambda s: [float(x) for x in re.findall(r'[xyz]: ([-0-9.eE]+)', s)]
    t = [float(x) for x in block('_t')]
    p = [vec(s) for s in block('_positions')]; tg = [vec(s) for s in block('_tangents')]; up = [vec(s) for s in block('_upVectors')]
    L = sum(math.dist(p[i - 1], p[i]) for i in range(1, len(p)))
    return {'name': name, 'times': t, 'points': [dict(zip('xyz', v)) for v in p], 'tangents': [dict(zip('xyz', v)) for v in tg],
            'upVectors': [dict(zip('xyz', v)) for v in up], 'polyLength': L}
if __name__ == '__main__':
    out = [load(n) for n in sys.argv[2:]]
    json.dump(out, open(sys.argv[1], 'w'), indent=1)
    for r in out:
        print('%-22s n=%3d polyLen=%8.3f p0=%s pN=%s' % (r['name'], len(r['points']), r['polyLength'], tuple(r['points'][0].values()), tuple(r['points'][-1].values())))
