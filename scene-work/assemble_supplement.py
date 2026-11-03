from pathlib import Path
import shutil,json,hashlib
source=Path(r"C:\Users\Administrator\Documents\TruxtonRemaster")
target=Path(r"D:\Games\TruxtonExRecon\Reconstructed")
target.mkdir(parents=True,exist_ok=True)
ledger=[]
for folder in ["Assets/Truxton","Assets/TruxtonGameplay","Assets/TruxtonImported","Assets/Resources","Assets/StreamingAssets","ProjectSettings","Packages"]:
 for f in (source/folder).rglob("*"):
  if not f.is_file(): continue
  rel=f.relative_to(source); dest=target/rel; dest.parent.mkdir(parents=True,exist_ok=True);shutil.copy2(f,dest)
  ledger.append({"source":str(f),"target":str(rel),"bytes":f.stat().st_size,"provenance":"independent-remaster supplemental Round1, not original logic recovery"})
for name in ["Assets/DefaultVolumeProfile.asset","Assets/DefaultVolumeProfile.asset.meta","Assets/UniversalRenderPipelineGlobalSettings.asset","Assets/UniversalRenderPipelineGlobalSettings.asset.meta"]:
 shutil.copy2(source/name,target/name)
(target/"Assets/Editor").mkdir(parents=True,exist_ok=True)
Path(r"D:\Games\TruxtonExRecon\scene-work\supplement-copy-ledger.json").write_text(json.dumps(ledger,indent=2))
print(len(ledger),sum(r["bytes"] for r in ledger))
