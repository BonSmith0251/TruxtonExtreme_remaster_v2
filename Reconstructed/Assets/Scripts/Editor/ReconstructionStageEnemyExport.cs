using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Raw export of the original stage enemy timelines for tools/stage_enemies/build_stage_enemies.py.
// For each BGxxStage: the root ControlTrack clips (to place mainTL and the _ge timeline in stage time), every clip of the
// InGame.Kernel tracks in those timelines (TLEntry, EnemyEntry, EnemyWave, EventEntry, Area, BGM, BGSlideRange), and
// for each TLEntry the wave timeline it instantiates (its _timelinePrefab's director) with the same clip detail. Clip and
// EnemyData/RouteLUT fields are read through Unity serialization (EditorJsonUtility / SerializedObject); no recovered
// InGame.Kernel method runs (they are throw-null stubs). Batch: -executeMethod ReconstructionStageEnemyExport.Export
public static class ReconstructionStageEnemyExport
{
    const string Output="D:/Games/TruxtonExRecon/extraction/stage-enemies";
    [Serializable] class Clip {public bool muted;public double easeIn,easeOut,blendIn,blendOut;public string track,trackType,clipType,name,asset;public double start,duration,timeScale,clipIn;public string json,reference,referenceGuid,waveGuid;}
    [Serializable] class Timeline {public string name,guid;public List<Clip> clips=new List<Clip>();}
    [Serializable] class Placed {public string director,timeline;public double start,duration,timeScale,clipIn;}
    [Serializable] class Stage {public string stage;public List<Placed> rootClips=new List<Placed>();public List<Timeline> timelines=new List<Timeline>();}
    [Serializable] class Named {public string guid,path,json;}
    [Serializable] class Dump {public List<Stage> stages=new List<Stage>();public List<Timeline> waves=new List<Timeline>();public List<Named> enemyData=new List<Named>(),routes=new List<Named>();}

    static readonly HashSet<string> EnemyRefs=new HashSet<string>();

    public static void Export()
    {
        Directory.CreateDirectory(Output);
        var dump=new Dump();
        var waves=new Dictionary<string,Timeline>();
        for(int i=1;i<=8;i++)
        {
            string key="BG"+i.ToString("00");
            var prefab=AssetDatabase.LoadAssetAtPath<GameObject>("Assets/OriginalGame/Samples/Prefabs/Reference/Stage/"+key+"Stage.prefab");
            var instance=(GameObject)PrefabUtility.InstantiatePrefab(prefab);
            try
            {
                var stage=new Stage{stage=key};
                var root=instance.GetComponent<PlayableDirector>();
                foreach(var track in ((TimelineAsset)root.playableAsset).GetOutputTracks().OfType<ControlTrack>())
                    foreach(var clip in track.GetClips())
                    {
                        var go=((ControlPlayableAsset)clip.asset).sourceGameObject.Resolve(root);
                        var d=go?go.GetComponent<PlayableDirector>():null;
                        if(!d||!(d.playableAsset is TimelineAsset tl))continue;
                        stage.rootClips.Add(new Placed{director=go.name,timeline=tl.name,start=clip.start,duration=clip.duration,timeScale=clip.timeScale,clipIn=clip.clipIn});
                        stage.timelines.Add(Read(tl,waves));
                    }
                dump.stages.Add(stage);
            }
            finally{UnityEngine.Object.DestroyImmediate(instance);}
        }
        dump.waves.AddRange(waves.Values);
        // EnemyWaveClip bonus spawns name their EnemyData (_enemyDataName) instead of referencing it: export them all.
        foreach(string g in AssetDatabase.FindAssets("t:ScriptableObject",new[]{"Assets/OriginalGame/Samples/EnemyData"}))EnemyRefs.Add(AssetDatabase.GUIDToAssetPath(g));
        foreach(string path in EnemyRefs.OrderBy(x=>x))
        {
            var so=AssetDatabase.LoadAssetAtPath<ScriptableObject>(path);
            if(!so)continue;
            dump.enemyData.Add(new Named{guid=AssetDatabase.AssetPathToGUID(path),path=path,json=EditorJsonUtility.ToJson(so)});
        }
        foreach(string guid in AssetDatabase.FindAssets("t:ScriptableObject",new[]{"Assets/OriginalGame/InGame/RouteLUT"}))
        {
            string path=AssetDatabase.GUIDToAssetPath(guid);var so=AssetDatabase.LoadAssetAtPath<ScriptableObject>(path);
            if(so)dump.routes.Add(new Named{guid=guid,path=path,json=EditorJsonUtility.ToJson(so)});
        }
        File.WriteAllText(Output+"/raw-stage-timelines.json",JsonUtility.ToJson(dump));
        Debug.Log("STAGE_ENEMY_EXPORT stages="+dump.stages.Count+" waves="+waves.Count+" enemyData="+dump.enemyData.Count+" routes="+dump.routes.Count);
        if(Application.isBatchMode)ReconstructionExit.Quit(0);
    }

    static bool Muted(TrackAsset t){for(;t;t=t.parent as TrackAsset)if(t.muted)return true;return false;}
    static Timeline Read(TimelineAsset tl,Dictionary<string,Timeline> cache)
    {
        string guid=AssetDatabase.AssetPathToGUID(AssetDatabase.GetAssetPath(tl));
        var t=new Timeline{name=tl.name,guid=guid};
        foreach(var track in tl.GetOutputTracks())
        {
            if(StagePresentation.IsTimelineTrack(track))continue;
            // TimelineClip.easeIn/OutDuration consult the asset's clipCaps (a stub here) and read 0; take the serialized values.
            var clipArray=new SerializedObject(track).FindProperty("m_Clips");int clipIndex=0;
            foreach(var clip in track.GetClips())
            {
                var a=clip.asset;
                var serialized=clipArray!=null&&clipIndex<clipArray.arraySize?clipArray.GetArrayElementAtIndex(clipIndex):null;clipIndex++;
                var c=new Clip{easeIn=serialized!=null?serialized.FindPropertyRelative("m_EaseInDuration").doubleValue:0,easeOut=serialized!=null?serialized.FindPropertyRelative("m_EaseOutDuration").doubleValue:0,
                    blendIn=serialized!=null?serialized.FindPropertyRelative("m_BlendInDuration").doubleValue:0,blendOut=serialized!=null?serialized.FindPropertyRelative("m_BlendOutDuration").doubleValue:0,muted=Muted(track),track=track.name,trackType=track.GetType().Name,clipType=a?a.GetType().Name:null,name=clip.displayName,asset=a?a.name:null,
                    start=clip.start,duration=clip.duration,timeScale=clip.timeScale,clipIn=clip.clipIn,json=a?EditorJsonUtility.ToJson(a):null};
                if(a)
                {
                    var so=new SerializedObject(a);
                    var enemy=so.FindProperty("_enemyData");
                    if(enemy!=null&&enemy.objectReferenceValue){string p=AssetDatabase.GetAssetPath(enemy.objectReferenceValue);c.reference=p;c.referenceGuid=AssetDatabase.AssetPathToGUID(p);EnemyRefs.Add(p);}
                    var wave=so.FindProperty("_timelinePrefab");
                    if(wave!=null&&wave.objectReferenceValue is GameObject waveGo)
                    {
                        c.reference=AssetDatabase.GetAssetPath(waveGo);
                        var d=waveGo.GetComponent<PlayableDirector>();
                        if(d&&d.playableAsset is TimelineAsset waveTl)
                        {
                            string wg=AssetDatabase.AssetPathToGUID(AssetDatabase.GetAssetPath(waveTl));
                            if(!cache.TryGetValue(wg,out var w)){w=Read(waveTl,cache);cache[wg]=w;}
                            c.waveGuid=wg;
                        }
                    }
                }
                t.clips.Add(c);
            }
        }
        if(!cache.ContainsKey(guid))cache[guid]=t;
        return t;
    }
}
