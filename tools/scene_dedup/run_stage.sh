#!/bin/bash
# Dedups one stage prefab (Assets/OriginalGame/.../Stage/BGxxStage.prefab) with SceneDedup and proves it unchanged:
# render StagePlay_BGxx before, apply with -dedupRemap 1 (stage PlayableDirector bindings) and the TXE_GraphicData
# library (the game's own prefabs are reused wherever their content repeats), render after and compare,
# then check every fileID other assets hold into the prefab still exists. One Unity process per step.
# Usage: run_stage.sh BG02   (evidence in evidence/scene-dedup/BG02, backup in Backups/before-scene-dedup-*)
set -u
STAGE="$1"
ROOT="D:/games/TruxtonExRecon"; PROJ="$ROOT/Reconstructed"; O="$ROOT/evidence/scene-dedup/$STAGE"
UNITY="/c/Program Files/Unity 2023.2.22f1/Editor/Unity.exe"
PREFAB="Assets/OriginalGame/Samples/Prefabs/Reference/Stage/${STAGE}Stage.prefab"
SCENE="Assets/Scenes/StagePlay/StagePlay_${STAGE}.unity"
# The game's own prefabs (TXE_GraphicData, flat rips): copies matching one become its instances, shared project-wide.
LIBRARY="Assets/OriginalGame/TXE_GraphicData"
# New prefabs for the other repeats: one folder and manifest for all stages, so a repeat common to stages is one prefab.
SHARED="Assets/OriginalGame/Samples/Prefabs/Reference/Stage/Dedup/Shared"
mkdir -p "$O"; FAIL=0

run() # name, extra args...
{
    local name="$1"; shift
    timeout 3600 "$UNITY" -batchmode -quit -projectPath "$PROJ" -logFile "$O/$name.log" "$@" >/dev/null 2>&1
    local code=$?
    bash "$ROOT/tools/common/crash_report.sh" "$O/$name.log" $code
    grep -a "SceneDedup\]" "$O/$name.log" | sort -u
    [ $code -eq 0 ] || FAIL=1
}

if [ ! -f "$O/render-before/render-report.json" ]; then
    run render-before -executeMethod SceneDedup.RenderBatch -dedupRenderScene "$SCENE" -dedupRenderOut "$O/render-before"
fi
[ $FAIL -eq 0 ] || { echo "$STAGE: render-before failed"; exit 1; }
run apply -executeMethod SceneDedup.RunBatch -dedupMode apply -dedupRemap 1 -dedupTargets "$PREFAB" \
    -dedupReport "$O/apply.json" -dedupBackup "$ROOT/Backups" \
    -dedupLibrary "$LIBRARY" -dedupLibraryCache "$ROOT/evidence/scene-dedup/library-signatures.json" -dedupOutRoot "$SHARED"
python -I -c "
import json,sys;r=json.load(open(sys.argv[1]))['reports'][0]
print('$STAGE apply: passed',r['passed'],'digestMatch',r['digestMatch'],'restored',r['restored'],'copies',r['copiesReplaced'],
      'bytes',r['before']['fileBytes'],'->',r['after']['fileBytes'] if r['after'] else '-','error',r['error'] or '-')
sys.exit(0 if r['passed'] and r['digestMatch'] else 1)" "$O/apply.json" || { echo "$STAGE: apply failed"; exit 1; }
run render-after -executeMethod SceneDedup.RenderBatch -dedupRenderScene "$SCENE" -dedupRenderOut "$O/render-after" \
    -dedupCompareWith "$O/render-before"
python -I -c "
import json,sys;r=json.load(open(sys.argv[1]))
print('$STAGE frames:',' '.join('%s %.4f%%'%(f['file'][:4],100*f['changedFraction']) for f in r['frames']),'passed',r['passed'])
sys.exit(0 if r['passed'] else 1)" "$O/render-after/render-report.json" || FAIL=1

cd "$PROJ"; G=$(grep -o "guid: [0-9a-f]*" "$PREFAB.meta" | cut -d' ' -f2); MISS=0
for f in $(grep -rl --include=*.unity --include=*.prefab --include=*.asset --include=*.playable "guid: $G" Assets); do
    for id in $(grep -o "fileID: -\?[0-9]*, guid: $G" "$f" | cut -d' ' -f2 | tr -d , | sort -u); do
        [ "$id" = 100100000 ] && continue
        grep -q "&$id\b" "$PREFAB" || { MISS=$((MISS+1)); echo "  $f: missing $id"; }
    done
done
echo "$STAGE references: $MISS missing"; [ $MISS -eq 0 ] || FAIL=1
[ $FAIL -eq 0 ] && echo "$STAGE: PASS" || echo "$STAGE: FAIL"
exit $FAIL
