"""Run the native-pipeline diagnostic and restore exact graphics/quality settings after Unity exits."""
from pathlib import Path
import argparse, datetime, hashlib, json, os, subprocess
ROOT = Path(__file__).resolve().parents[1]
PROJECT = ROOT / 'Reconstructed'
UNITY = Path(r'C:\Program Files\Unity 2023.2.22f1\Editor\Unity.exe')

def digest(data):
    return hashlib.sha256(data).hexdigest()

def main():
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument('--unity', type=Path, default=UNITY)
    args = parser.parse_args()
    if (PROJECT / 'Temp/UnityLockfile').exists():
        raise RuntimeError('Close the target editor before running this diagnostic.')
    paths = [PROJECT / 'ProjectSettings' / name for name in ('GraphicsSettings.asset', 'QualitySettings.asset')]
    for path in paths:
        if not path.resolve().is_relative_to(PROJECT.resolve()):
            raise RuntimeError('Settings path leaves the target project.')
    originals = {path: path.read_bytes() for path in paths}
    stamp = datetime.datetime.now(datetime.timezone.utc).strftime('%Y%m%dT%H%M%S%fZ')
    run = ROOT / 'verification/native-pipeline-safe-runs' / stamp
    run.mkdir(parents=True, exist_ok=False)
    for path, data in originals.items():
        (run / (path.name + '.before')).write_bytes(data)
    env = os.environ.copy()
    env.update(TEMP=str(ROOT / 'temp'), TMP=str(ROOT / 'temp'), BEE_CACHE_DIRECTORY=str(ROOT / 'temp/bee-cache'))
    status = None
    process = None
    changes = []
    try:
        startup = subprocess.STARTUPINFO()
        startup.dwFlags |= subprocess.STARTF_USESHOWWINDOW
        startup.wShowWindow = 0
        process = subprocess.Popen([str(args.unity), '-batchmode', '-projectPath', str(PROJECT),
            '-force-d3d11', '-executeMethod', 'ReconstructionStagePreviewVerification.RunWithRecoveredPipeline',
            '-logFile', str(run / 'editor.log')], cwd=PROJECT, env=env, startupinfo=startup)
        status = process.wait()
    finally:
        if process is not None and process.poll() is None:
            process.terminate()
            process.wait()
        for path, data in originals.items():
            after = path.read_bytes() if path.exists() else b''
            (run / (path.name + '.after-probe')).write_bytes(after)
            path.write_bytes(data)
            restored = digest(path.read_bytes())
            if restored != digest(data):
                raise RuntimeError('Settings restoration failed: ' + str(path))
            changes.append({'path': str(path.relative_to(PROJECT)), 'before': digest(data),
                            'after_probe': digest(after), 'restored': restored})
        (run / 'restoration.json').write_text(json.dumps({'unity_exit': status, 'settings': changes}, indent=2))
    if status != 0:
        raise RuntimeError('Diagnostic failed; exact settings restored. See ' + str(run))
    print('Diagnostic completed; exact settings restored. Evidence:', run)

if __name__ == '__main__':
    main()
