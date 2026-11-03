from pathlib import Path
import ctypes,ctypes.wintypes as w,subprocess,time,json
from PIL import ImageGrab
r=Path(r'D:\Games\TruxtonExRecon');out=r/'evidence/scene-integration';u=ctypes.windll.user32;u.SetProcessDPIAware()
class POINT(ctypes.Structure):_fields_=[('x',w.LONG),('y',w.LONG)]
class RECT(ctypes.Structure):_fields_=[('l',w.LONG),('t',w.LONG),('r',w.LONG),('b',w.LONG)]
u.GetWindowThreadProcessId.argtypes=[w.HWND,ctypes.POINTER(w.DWORD)];u.GetClientRect.argtypes=[w.HWND,ctypes.POINTER(RECT)];u.ClientToScreen.argtypes=[w.HWND,ctypes.POINTER(POINT)];u.SetWindowPos.argtypes=[w.HWND,w.HWND,ctypes.c_int,ctypes.c_int,ctypes.c_int,ctypes.c_int,w.UINT];u.PostMessageW.argtypes=[w.HWND,w.UINT,w.WPARAM,w.LPARAM];u.ShowWindow.argtypes=[w.HWND,ctypes.c_int];u.SetForegroundWindow.argtypes=[w.HWND]
si=subprocess.STARTUPINFO();si.dwFlags|=subprocess.STARTF_USESHOWWINDOW;si.wShowWindow=0
p=subprocess.Popen([str(r/'Build/TruxtonExRecon.exe'),'-force-d3d11','-screen-fullscreen','0','-screen-width','1280','-screen-height','720','-logFile',str(out/'normal-player-v3.log')],cwd=r/'Build',startupinfo=si,stdin=subprocess.DEVNULL,stdout=subprocess.DEVNULL,stderr=subprocess.DEVNULL)
handles=[];CB=ctypes.WINFUNCTYPE(w.BOOL,w.HWND,w.LPARAM)
def enum(hwnd,param):
 pid=w.DWORD();u.GetWindowThreadProcessId(hwnd,ctypes.byref(pid));a=RECT();u.GetClientRect(hwnd,ctypes.byref(a))
 if pid.value==p.pid and a.r>500 and a.b>300:handles.append(int(hwnd))
 return True
cb=CB(enum)
for _ in range(60):
 u.EnumWindows(cb,0)
 if handles:break
 if p.poll() is not None:raise RuntimeError('Player exited before window '+str(p.returncode))
 time.sleep(.5)
if not handles:raise RuntimeError('Owned player has no client window')
hwnd=w.HWND(handles[0]);old=POINT();u.GetCursorPos(ctypes.byref(old))
def owned():
 pid=w.DWORD();u.GetWindowThreadProcessId(hwnd,ctypes.byref(pid));assert pid.value==p.pid

def capture(name):
 owned();a=RECT();origin=POINT();u.GetClientRect(hwnd,ctypes.byref(a));u.ClientToScreen(hwnd,ctypes.byref(origin));box=(origin.x,origin.y,origin.x+a.r,origin.y+a.b);ImageGrab.grab(bbox=box).save(out/name);return box
try:
 owned();u.ShowWindow(hwnd,9);u.SetWindowPos(hwnd,w.HWND(-1),40,40,0,0,0x0001|0x0040);u.SetForegroundWindow(hwnd);time.sleep(4);hubbox=capture('normal-hub-clean.png')
 origin=POINT();u.ClientToScreen(hwnd,ctypes.byref(origin));x,y=440,192;u.SetCursorPos(origin.x+x,origin.y+y);lparam=(y<<16)|x;owned();u.PostMessageW(hwnd,0x200,0,lparam);u.PostMessageW(hwnd,0x201,1,lparam);time.sleep(.15);u.PostMessageW(hwnd,0x202,0,lparam);time.sleep(.5);u.SetCursorPos(old.x,old.y)
 time.sleep(27);gamebox=capture('normal-round1-gameplay.png')
 report={'revision':'reconstruction-2023.2.22f1-native-assets-v3','pid':p.pid,'hwnd':handles[0],'startup':'normal Hub without reconstruction-capture flag','hubScreenshot':'normal-hub-clean.png','hubClientBounds':hubbox,'button':'actual GUI button clicked atclient440,192 viaownedHWNDmessages','waitAfterButtonSeconds':27,'gameplayScreenshot':'normal-round1-gameplay.png','gameplayClientBounds':gamebox,'networkPermissionGrantedByAutomation':False,'playerLogicModifiedForNormalEntryTest':False};(out/'normal-entry-v3.json').write_text(json.dumps(report,indent=2));print('Normal Hub and post-intro button transition captured',p.pid,handles[0])
finally:
 u.SetCursorPos(old.x,old.y);u.SetWindowPos(hwnd,w.HWND(-2),0,0,0,0,0x0001|0x0002|0x0010);owned();u.PostMessageW(hwnd,0x10,0,0)
 try:p.wait(timeout=10)
 except subprocess.TimeoutExpired:p.terminate();p.wait()
