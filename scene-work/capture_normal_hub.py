from pathlib import Path
import ctypes,ctypes.wintypes as w,subprocess,time,json
from PIL import ImageGrab
r=Path(r'D:\Games\TruxtonExRecon');out=r/'evidence/scene-integration';out.mkdir(exist_ok=True)
u=ctypes.windll.user32
try:u.SetProcessDPIAware()
except:pass
si=subprocess.STARTUPINFO();si.dwFlags|=subprocess.STARTF_USESHOWWINDOW;si.wShowWindow=0
p=subprocess.Popen([str(r/'Build/TruxtonExRecon.exe'),'-force-d3d11','-screen-fullscreen','0','-screen-width','1280','-screen-height','720','-logFile',str(out/'normal-player.log')],startupinfo=si,stdin=subprocess.DEVNULL,stdout=subprocess.DEVNULL,stderr=subprocess.DEVNULL)
class RECT(ctypes.Structure):_fields_=[('l',w.LONG),('t',w.LONG),('r',w.LONG),('b',w.LONG)]
class POINT(ctypes.Structure):_fields_=[('x',w.LONG),('y',w.LONG)]
found=[]
CB=ctypes.WINFUNCTYPE(w.BOOL,w.HWND,w.LPARAM)
def enum(hwnd,param):
 pid=w.DWORD();u.GetWindowThreadProcessId(hwnd,ctypes.byref(pid));rect=RECT();u.GetClientRect(hwnd,ctypes.byref(rect))
 if pid.value==p.pid and rect.r>500 and rect.b>300:found.append(int(hwnd))
 return True
cb=CB(enum)
for i in range(60):
 u.EnumWindows(cb,0)
 if found:break
 if p.poll() is not None:raise RuntimeError('Player exited '+str(p.returncode))
 time.sleep(.5)
if not found:raise RuntimeError('No game window')
hwnd=found[0];u.ShowWindow(hwnd,1);u.SetWindowPos(hwnd,-1,40,40,0,0,0x0001|0x0010|0x0040);u.SetForegroundWindow(hwnd);time.sleep(4)
rect=RECT();u.GetClientRect(hwnd,ctypes.byref(rect));pt=POINT(0,0);u.ClientToScreen(hwnd,ctypes.byref(pt));bbox=(pt.x,pt.y,pt.x+rect.r,pt.y+rect.b)
ImageGrab.grab(bbox=bbox).save(out/'normal-hub.png')
(out/'normal-window.json').write_text(json.dumps({'pid':p.pid,'hwnd':hwnd,'client':[rect.r,rect.b],'bbox':bbox,'launch':'normal startup; no reconstruction-capture flag'},indent=2));print('Normal Hub captured',p.pid,hwnd,bbox)
