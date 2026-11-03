# Print Pf_Ene_Bos01 transforms with root-space position (prefab space, before the spawn yaw) and forward vector.
import re,sys,math
sys.path.insert(0,'.')
from prefab_paths import tr,go_name,path,docs
def q(s):
    d=dict((k.strip(),float(v)) for k,v in (p.split(':') for p in s.split(',')))
    return (d.get('x',0),d.get('y',0),d.get('z',0),d.get('w',1)) if 'w' in d else (d['x'],d['y'],d['z'])
def qmul(a,b):
    ax,ay,az,aw=a; bx,by,bz,bw=b
    return (aw*bx+ax*bw+ay*bz-az*by, aw*by-ax*bz+ay*bw+az*bx, aw*bz+ax*by-ay*bx+az*bw, aw*bw-ax*bx-ay*by-az*bz)
def qrot(r,v):
    x,y,z,w=r; vx,vy,vz=v
    # v' = q v q*
    ix= w*vx+y*vz-z*vy; iy= w*vy+z*vx-x*vz; iz= w*vz+x*vy-y*vx; iw=-x*vx-y*vy-z*vz
    return (ix*w+iw*-x+iy*-z-iz*-y, iy*w+iw*-y+iz*-x-ix*-z, iz*w+iw*-z+ix*-y-iy*-x)
cache={}
def world(fid):
    if fid in cache: return cache[fid]
    t=tr[fid]; p=q(t['pos']); r=q(t['rot']); s=q(t['scale'])
    if t['father'] in tr:
        pp,pr,ps=world(t['father'])
        sp=(p[0]*ps[0],p[1]*ps[1],p[2]*ps[2])
        rp=qrot(pr,sp); res=((pp[0]+rp[0],pp[1]+rp[1],pp[2]+rp[2]),qmul(pr,r),(ps[0]*s[0],ps[1]*s[1],ps[2]*s[2]))
    else: res=((0,0,0),r,s)
    cache[fid]=res; return res
pat=sys.argv[1] if len(sys.argv)>1 else ''
rows=[]
for fid in tr:
    pth=path(fid)
    if re.search(pat,pth):
        p,r,s=world(fid); f=qrot(r,(0,0,1))
        rows.append((pth,p,f))
for pth,p,f in sorted(rows):
    print('%-70s pos=(%.2f,%.2f,%.2f) fwd=(%.2f,%.2f,%.2f)'%(pth,*p,*f))
