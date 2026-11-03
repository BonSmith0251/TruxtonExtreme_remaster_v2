from pathlib import Path
import argparse,datetime,hashlib,json,os,shutil,subprocess
ROOT=Path(__file__).resolve().parents[1]
PROJECT=ROOT/'Reconstructed'
UNITY=Path(r'C:\Program Files\Unity 2023.2.22f1\Editor\Unity.exe')
def sha(p):
 h=hashlib.sha256()
 with p.open('rb') as f:
  for b in iter(lambda:f.read(8*1024*1024),b''):h.update(b)
 return h.hexdigest()
def inside(p):
 if not p.resolve().is_relative_to(ROOT.resolve()):raise RuntimeError('Path outside recovery workspace: '+str(p))
def main():
 ap=argparse.ArgumentParser();ap.add_argument('--unity',type=Path,default=UNITY);args=ap.parse_args()
 src=PROJECT/'Assets/StreamingAssets';held=ROOT/'temp/build-streamingassets-hold';meta=Path(str(src)+'.meta');heldmeta=Path(str(held)+'.meta')
 inside(src);inside(held)
 if (PROJECT/'Temp/UnityLockfile').exists() or (PROJECT/'Temp/UnityLockFile').exists():raise RuntimeError('Target editor lock exists; close the target editor before building')
 if held.exists() or heldmeta.exists():raise RuntimeError('An earlier build hold exists; restore it before rerunning: '+str(held))
 expected=json.loads((ROOT/'scene-work/media-copy-ledger.json').read_text())
 for row in expected:
  if sha(src/row['relative'])!=row['sha256']:raise RuntimeError('Project movie differs from preserved source hash: '+row['relative'])
 before=[{'path':str(p.relative_to(src)),'bytes':p.stat().st_size,'sha256':sha(p)} for p in src.rglob('*') if p.is_file() and p.suffix!='.meta']
 held.parent.mkdir(parents=True,exist_ok=True)
 log=ROOT/'scene-work/reproducible-build.log';status=None;process=None
 try:
  shutil.move(str(src),held)
  if meta.exists():shutil.move(str(meta),heldmeta)
  env=os.environ.copy();env.update(TEMP=str(ROOT/'temp'),TMP=str(ROOT/'temp'),BEE_CACHE_DIRECTORY=str(ROOT/'temp/bee-cache'))
  si=subprocess.STARTUPINFO();si.dwFlags|=subprocess.STARTF_USESHOWWINDOW;si.wShowWindow=0
  process=subprocess.Popen([str(args.unity),'-batchmode','-quit','-projectPath',str(PROJECT),'-executeMethod','ReconstructionEditor.Build','-logFile',str(log)],cwd=PROJECT,env=env,startupinfo=si)
  status=process.wait()
 except BaseException:
  if process is not None and process.poll() is None:
   process.terminate();process.wait()
  raise
 finally:
  if held.exists() and src.exists():
   unexpected=ROOT/'temp'/('unexpected-streamingassets-'+datetime.datetime.now().strftime('%Y%m%d-%H%M%S'));inside(unexpected);shutil.move(str(src),unexpected)
   if meta.exists():shutil.move(str(meta),str(unexpected)+'.meta')
  if held.exists():shutil.move(str(held),src)
  if heldmeta.exists():
   if meta.exists():meta.unlink()
   shutil.move(str(heldmeta),meta)
 if status!=0:raise RuntimeError('Unity build failed; project StreamingAssets restored. See '+str(log))
 build=json.loads((ROOT/'evidence/scene-integration/build-result.json').read_text())
 if build['result']!='Succeeded':raise RuntimeError('Build report did not succeed; StreamingAssets restored')
 dest=ROOT/'Build/TruxtonExRecon_Data/StreamingAssets';verified=[]
 for row in before:
  p=src/row['path'];out=dest/row['path'];inside(out);out.parent.mkdir(parents=True,exist_ok=True)
  if sha(p)!=row['sha256']:raise RuntimeError('Restored project payload changed: '+str(p))
  if out.exists():out.unlink()
  shutil.copy2(p,out)
  if os.path.samefile(p,out) or sha(out)!=row['sha256']:raise RuntimeError('Player payload independence/hash check failed: '+str(out))
  verified.append(row)
 report={'timeUTC':datetime.datetime.now(datetime.timezone.utc).isoformat(),'unity':str(args.unity),'build':build,'nativeMovieHashesVerified':len(expected),'allStreamingPayloadHashesVerified':len(verified),'payloads':verified,'workaround':'Held target StreamingAssets outside Assets during BuildPipeline; restored in finally; independent postbuild file copies. Original Bee zero-byte-copy root cause unknown.'}
 (ROOT/'evidence/scene-integration/build-reproduction-result.json').write_text(json.dumps(report,indent=2));print('SUCCESS:',ROOT/'Build/TruxtonExRecon.exe','; payload hashes',len(verified))
if __name__=='__main__':main()
