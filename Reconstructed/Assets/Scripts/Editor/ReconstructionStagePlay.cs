using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

// Builds Assets/Scenes/StagePlay/StagePlay_BGxx.unity: the playable Round 1 / Stage01 scene (player, weapons,
// combat, enemy fire, HUD, intro, sound) with BG03 swapped for the ORIGINAL stage prefab played by StagePresentation and
// the wave player fed with that stage's original schedule (Resources/StageEnemies/BGxx.json). BG03 keeps its
// reconstructed boss; other stages clear at their boss time. The template scene is never saved.
// Batch: -executeMethod ReconstructionStagePlay.Build (STAGE_PLAY_ONLY=BG01 limits it to one stage)
public static class ReconstructionStagePlay
{
    const string Template="Assets/Scenes/Round1/Stage01.unity";
    const string Folder="Assets/Scenes/StagePlay";
    const string Evidence="D:/Games/TruxtonExRecon/verification/stage-play";

    [Serializable] class Area {public string name;public float start,end;}
    [Serializable] class BossData {public Area[] areas;}
    [Serializable] class Built {public string stage,scene,camera,oldCamera;public float duration,bossAt,clearAt,spawnCutoff;public int models,visualsImported,visualsOriginal,remappedReferences;public bool boss;public List<string> notes=new List<string>();}
    [Serializable] class Report {public List<Built> stages=new List<Built>();}

    public static void Build()
    {
        Directory.CreateDirectory(Folder);Directory.CreateDirectory(Evidence);
        string only=Environment.GetEnvironmentVariable("STAGE_PLAY_ONLY");
        var report=new Report();
        foreach(int i in Enumerable.Range(1,8))
        {
            string key="BG"+i.ToString("00");
            if(!string.IsNullOrEmpty(only)&&only!=key)continue;
            report.stages.Add(BuildStage(key,i));
        }
        var scenes=EditorBuildSettings.scenes.ToList();
        foreach(var b in report.stages)if(!scenes.Any(s=>s.path==b.scene))scenes.Add(new EditorBuildSettingsScene(b.scene,true));
        EditorBuildSettings.scenes=scenes.ToArray();
        File.WriteAllText(Evidence+"/build"+(string.IsNullOrEmpty(only)?"":"-"+only)+".json",JsonUtility.ToJson(report,true));
        Debug.Log("STAGE_PLAY_BUILD "+string.Join(" ",report.stages.Select(s=>s.stage+":"+s.scene)));
        if(Application.isBatchMode)ReconstructionExit.Quit(0);
    }

    static Built BuildStage(string key,int number)
    {
        var b=new Built{stage=key,scene=Folder+"/StagePlay_"+key+".unity"};
        var scene=EditorSceneManager.OpenScene(Template,OpenSceneMode.Single);
        var playback=UnityEngine.Object.FindFirstObjectByType<Round1Playback>();
        var player=UnityEngine.Object.FindFirstObjectByType<Round1PlayerController>();
        var combat=UnityEngine.Object.FindFirstObjectByType<Round1Combat>();
        var waves=combat.GetComponent<Round1EnemyWaves>();
        var boss=UnityEngine.Object.FindFirstObjectByType<Round1Boss>(FindObjectsInactive.Include); // BG03 template boss
        var oldCamera=player.stageCamera;b.oldCamera=Path(oldCamera?oldCamera.transform:null);

        // The original stage, driven by Round1Playback's clock.
        var stagePrefab=AssetDatabase.LoadAssetAtPath<GameObject>("Assets/OriginalGame/Samples/Prefabs/Reference/Stage/"+key+"Stage.prefab");
        var stageGo=(GameObject)PrefabUtility.InstantiatePrefab(stagePrefab,scene);
        var presentationGo=new GameObject("StagePresentation (driven by Round1 Playback)");
        var presentation=presentationGo.AddComponent<StagePresentation>();
        presentation.stage=stageGo.GetComponent<UnityEngine.Playables.PlayableDirector>();presentation.externallyDriven=true;presentation.showControls=false;presentation.playing=false;presentation.loop=false;
        var camera=stageGo.GetComponentsInChildren<Camera>(true).FirstOrDefault();
        b.camera=Path(camera?camera.transform:null);b.duration=MeasureDuration(stagePrefab);

        // Re-point every serialized reference from the old camera (and its GameObject/Transform) to the stage rail camera.
        if(oldCamera&&camera)b.remappedReferences=Remap(scene,oldCamera,camera);
        player.stageCamera=camera;EditorUtility.SetDirty(player);

        // Remove the remaster's BG03 and its camera rig (anything left that is not the stage we just placed).
        foreach(var root in scene.GetRootGameObjects())
        {
            var source=PrefabUtility.GetCorrespondingObjectFromOriginalSource(root);
            string path=source?AssetDatabase.GetAssetPath(source):"";
            if(path.EndsWith("/BG03.prefab")){b.notes.Add("removed "+root.name+" ("+path+")");UnityEngine.Object.DestroyImmediate(root);}
        }
        if(oldCamera&&oldCamera!=camera){b.notes.Add("removed old camera "+b.oldCamera);UnityEngine.Object.DestroyImmediate(oldCamera.gameObject);}

        // Schedule and visuals.
        var schedule=AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Resources/StageEnemies/"+key+".json");
        var data=JsonUtility.FromJson<StageEnemies.StageData>(schedule.text);
        var defs=data.definitions.ToDictionary(d=>d.id);
        var bossEvent=data.events.Where(e=>defs[e.enemy].model.StartsWith("Pf_Ene_Bos")).OrderBy(e=>e.start).FirstOrDefault();
        b.bossAt=bossEvent!=null?bossEvent.start:-1;
        waves.schedule=schedule;
        var visuals=new List<Round1EnemyWaves.Visual>();
        // Models a native class summons itself (Ene_Mn01h._createChildren: 13 Pf_Ene_Mn01c) are not in the timelines.
        var modelNames=data.models.Select(m=>m.name).ToList();
        if(modelNames.Contains("Pf_Ene_Mn01") && !modelNames.Contains("Pf_Ene_Mn01c"))modelNames.Add("Pf_Ene_Mn01c");
        foreach(var name in modelNames)
        {
            var prefab=FindPrefab(name,out bool imported);
            if(!prefab){b.notes.Add("no prefab "+name);continue;}
            if(imported)b.visualsImported++;else b.visualsOriginal++;
            visuals.Add(new Round1EnemyWaves.Visual{name=name,prefab=prefab});
        }
        waves.visuals=visuals.ToArray();b.models=visuals.Count;
        waves.gameModeMask=Round1EnemyWaves.StoryAMask;
        bool keepBoss=key=="BG03";
        waves.spawnCutoff=keepBoss?418:(b.bossAt>0?b.bossAt-2:b.duration);b.spawnCutoff=waves.spawnCutoff;
        EditorUtility.SetDirty(waves);

        combat.bg03Schedules=keepBoss;
        // Ground enemies (BGxx_ge): BG03 keeps its validated GroundEnemyLibrary; other stages get their own data
        // (tools/stage_enemies/build_ground_enemies.py), the Animator/turret table and prefabs, plus BG03's ground items.
        if(!keepBoss)
        {
            var ground=combat.GetComponent<Round1GroundEnemies>();
            var groundSource=AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Resources/StageEnemies/Ground/"+key+".json");
            if(groundSource)
            {
                if(!ground)ground=combat.gameObject.AddComponent<Round1GroundEnemies>();
                ground.source=groundSource;ground.animationSource=AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Resources/StageEnemies/ground-animations.json");
                var gdata=JsonUtility.FromJson<Round1GroundEnemies.Data>(groundSource.text);var gvisuals=new List<Round1EnemyWaves.Visual>();
                foreach(var m in gdata.definitions.Select(d=>d.model).Distinct())
                {var p=FindPrefab(m,out _);if(p)gvisuals.Add(new Round1EnemyWaves.Visual{name=m,prefab=p});else b.notes.Add("no ground prefab "+m);}
                var library=Resources.Load<Round1GroundEnemyLibrary>("Truxton/GroundEnemyLibrary");
                if(library)foreach(var p in library.prefabs)if(p.prefab&&p.name.StartsWith("Pf_item_"))gvisuals.Add(new Round1EnemyWaves.Visual{name=p.name,prefab=p.prefab});
                ground.visuals=gvisuals.ToArray();combat.groundEnemies=ground;EditorUtility.SetDirty(ground);
                b.notes.Add("ground: "+gdata.clips.Length+" clips, "+gdata.definitions.Length+" definitions, "+gvisuals.Count+" prefabs");
            }
            else if(ground){UnityEngine.Object.DestroyImmediate(ground);combat.groundEnemies=null;}
            // Item carriers (EventEntryClip _eventType 1 on BGxxMain and its waves; tools/stage_enemies/build_pickups.py).
            var carriers=AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Resources/StageEnemies/Pickups/"+key+".json");
            var drones=combat.GetComponent<Round1PickupDrones>();
            if(carriers)
            {
                if(!drones)drones=combat.gameObject.AddComponent<Round1PickupDrones>();
                drones.schedule=carriers;combat.pickupDrones=drones;EditorUtility.SetDirty(drones);
                b.notes.Add("pickups: "+JsonUtility.FromJson<Round1PickupDrones.Data>(carriers.text).events.Length+" carriers");
            }
            else if(drones){UnityEngine.Object.DestroyImmediate(drones);combat.pickupDrones=null;}
        }
        if(keepBoss){b.boss=true;b.clearAt=-1;}
        else
        {
            if(boss){b.notes.Add("removed BG03 boss encounter");UnityEngine.Object.DestroyImmediate(boss.gameObject);}
            // The stage's own boss encounter (StageBoss): forms from the schedule's boss events, frame from the BOSS areas.
            var stageData=JsonUtility.FromJson<BossData>(schedule.text);
            var forms=new List<StageBoss.Form>();
            foreach(var e in data.events.Where(e=>defs[e.enemy].model.StartsWith("Pf_Ene_Bos")).OrderBy(e=>e.start))
            {
                var d=defs[e.enemy];var place=d.placements.Length>0?d.placements[0]:null;
                var rest=d.position+e.offset+(place!=null?place.offset:Vector3.zero);rest.z=Mathf.Min(rest.z,50);rest.y=0; // [I] generic fight: off-screen/background starts (Bos01 z 200, Bos08A y -500 z 12300) hold on the game plane
                var row=StageCombatData.Get(d.model);
                forms.Add(new StageBoss.Form{model=d.model,definition=d.name,prefab=FindPrefab(d.model,out _),spawnTime=e.start,rest=rest,rotate=(place!=null?place.rotate:Vector3.zero)+e.rotate,health=row!=null&&row.health>0?row.health:100000});
            }
            // Ene_Bos08B spawns Ene_Bos08C itself (CallEnemyClip ene_boss08c at its own position + (0,0,-30)) when the story
            // actor is Chria or unknown: the reconstruction plays that full A -> B -> C path (evidence/bosses/Bos08/SPEC.md).
            var formB=forms.FirstOrDefault(x=>x.model=="Pf_Ene_Bos08B");var prefabC=formB!=null?FindPrefab("Pf_Ene_Bos08C",out _):null;
            if(prefabC){var rowC=StageCombatData.Get("Pf_Ene_Bos08C");forms.Add(new StageBoss.Form{model="Pf_Ene_Bos08C",definition="ene_boss08c",prefab=prefabC,spawnTime=0,rest=new Vector3(0,0,50),health=rowC!=null&&rowC.health>0?rowC.health:250000});}
            var bossGo=new GameObject("Stage boss encounter ("+string.Join(", ",forms.Select(x=>x.model))+")");
            // Native-spec subclass when one exists (Pf_Ene_Bos07 -> Bos07Boss, Pf_Ene_Bos08A -> Bos08Boss), else the generic fight.
            string cls=forms.Count>0?forms[0].model.Replace("Pf_Ene_","").TrimEnd('A','B','C')+"Boss":"";
            var bossType=typeof(StageBoss).Assembly.GetType(cls);if(bossType==null||!typeof(StageBoss).IsAssignableFrom(bossType))bossType=typeof(StageBoss);
            var stageBoss=(StageBoss)bossGo.AddComponent(bossType);b.notes.Add("boss class "+bossType.Name);
            stageBoss.minionPrefabs=stageBoss.MinionModels.Select(m=>FindPrefab(m,out _)).Where(p=>p).ToArray();
            if(stageBoss.minionPrefabs.Length<stageBoss.MinionModels.Length)b.notes.Add("missing minion prefabs: "+string.Join(", ",stageBoss.MinionModels.Where(m=>!FindPrefab(m,out _))));stageBoss.combat=combat;stageBoss.forms=forms.ToArray();stageBoss.caption="STAGE "+number+" BOSS";
            var st=stageData.areas?.FirstOrDefault(a=>a.name.EndsWith("_BOSSST"));var lp=stageData.areas?.FirstOrDefault(a=>a.name.EndsWith("_BOSSLP"));
            stageBoss.warningTime=st!=null?st.start:(forms.Count>0?forms[0].spawnTime-2:-1);
            if(lp!=null){stageBoss.loopStart=lp.start;stageBoss.loopEnd=lp.end;}
            combat.boss=stageBoss;combat.clearAt=-1;b.clearAt=-1;b.boss=forms.Count>0;
            b.notes.Add("stage boss: "+string.Join(", ",forms.Select(x=>x.model+"@"+x.spawnTime+" hp "+x.health+" rest "+x.rest))+" warning "+stageBoss.warningTime+" loop "+stageBoss.loopStart+"-"+stageBoss.loopEnd);
        }
        EditorUtility.SetDirty(combat);

        playback.presentation=presentation;playback.cameraRail=null;playback.cameraMotion=null;playback.activationTracks=new Round1Playback.Activation[0];
        playback.duration=b.duration;playback.title="STAGE "+number+"  /  "+key+"  (original timeline and enemy schedule)";
        EditorUtility.SetDirty(playback);
        ReconstructionStageRenderSettings.Install(scene,key);   // the stage's own fog/skybox/ambient (InGameBGObject.UpdateSkyBox)

        EditorSceneManager.SaveScene(scene,b.scene);
        return b;
    }

    // Point the shared enemy attack library at the all-stage data (tools/stage_combat/enemy_attacks.py; identical to the
    // BG03 reference for every BG03 item) and add the bullet prefabs the other stages fire. Existing entries are kept.
    public static void UpdateAttackLibrary()
    {
        const string path="Assets/Resources/Truxton/EnemyAttackLibrary.asset";
        var library=AssetDatabase.LoadAssetAtPath<Round1EnemyAttackLibrary>(path);
        var source=AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Resources/StageCombat/enemy-attacks.json");
        var data=JsonUtility.FromJson<Round1EnemyAttacks.Data>(source.text);
        var bullets=library.bullets.ToList();var added=new List<string>();var missing=new List<string>();
        foreach(string name in data.patterns.Select(p=>p.bulletName).Where(n=>!string.IsNullOrEmpty(n)&&!n.StartsWith("enemylaser")).Distinct().OrderBy(n=>n))
        {
            if(bullets.Any(b=>b.name==name))continue;
            var prefab=FindPrefab(name,out _);
            if(prefab){bullets.Add(new Round1EnemyAttackLibrary.Bullet{name=name,prefab=prefab});added.Add(name+" <- "+AssetDatabase.GetAssetPath(prefab));}
            else missing.Add(name);
        }
        library.source=source;library.bullets=bullets.ToArray();EditorUtility.SetDirty(library);AssetDatabase.SaveAssets();
        Directory.CreateDirectory(Evidence);
        File.WriteAllText(Evidence+"/attack-library.json",JsonUtility.ToJson(new LibraryReport{source=AssetDatabase.GetAssetPath(source),added=added,missing=missing,total=bullets.Count},true));
        Debug.Log("ATTACK_LIBRARY bullets="+bullets.Count+" added="+added.Count+" missing="+string.Join(",",missing));
        if(Application.isBatchMode)ReconstructionExit.Quit(missing.Count==0?0:1);
    }
    [Serializable] class LibraryReport {public string source;public int total;public List<string> added=new List<string>(),missing=new List<string>();}

    // Prepare() changes the stage instance for the run (disabled child directors, renderer fallback); measure on a throwaway.
    static float MeasureDuration(GameObject stagePrefab)
    {
        var temp=(GameObject)PrefabUtility.InstantiatePrefab(stagePrefab);var p=temp.AddComponent<StagePresentation>();
        try{p.stage=temp.GetComponent<UnityEngine.Playables.PlayableDirector>();p.Prepare();return (float)p.Duration;}
        finally{UnityEngine.Object.DestroyImmediate(temp);}
    }
    // Prefer Round 1's converted prefab when one exists (tested in the remaster), else the original export.
    static GameObject FindPrefab(string name,out bool imported)
    {
        imported=false;
        var paths=AssetDatabase.FindAssets(name+" t:Prefab").Select(AssetDatabase.GUIDToAssetPath).Where(p=>System.IO.Path.GetFileNameWithoutExtension(p)==name).ToList();
        string remaster=paths.FirstOrDefault(p=>p.StartsWith("Assets/Prefabs/"));
        if(remaster!=null){imported=true;return AssetDatabase.LoadAssetAtPath<GameObject>(remaster);}
        string best=paths.FirstOrDefault(p=>p.StartsWith("Assets/OriginalGame/"))??paths.FirstOrDefault();
        return best==null?null:AssetDatabase.LoadAssetAtPath<GameObject>(best);
    }

    static int Remap(UnityEngine.SceneManagement.Scene scene,Camera from,Camera to)
    {
        int n=0;
        var map=new Dictionary<UnityEngine.Object,UnityEngine.Object>{{from,to},{from.gameObject,to.gameObject},{from.transform,to.transform}};
        foreach(var root in scene.GetRootGameObjects())
            foreach(var c in root.GetComponentsInChildren<Component>(true))
            {
                // The old camera's own components go with it; re-pointing their owner links (m_GameObject) to the new
                // camera corrupted the scene in memory and crashed the editor when it was unloaded.
                if(!c||c is Transform||c.gameObject==from.gameObject)continue;
                var so=new SerializedObject(c);var it=so.GetIterator();bool changed=false;
                while(it.Next(true))
                    if(it.propertyType==SerializedPropertyType.ObjectReference&&!Structural.Contains(it.name)&&it.objectReferenceValue&&map.TryGetValue(it.objectReferenceValue,out var target))
                    {it.objectReferenceValue=target;changed=true;n++;}
                if(changed)so.ApplyModifiedPropertiesWithoutUndo();
            }
        return n;
    }
    // Ownership and prefab links, never scene references to re-point.
    static readonly HashSet<string> Structural=new HashSet<string>{"m_GameObject","m_PrefabInstance","m_CorrespondingSourceObject","m_PrefabAsset","m_Father","m_Children","m_Component"};
    static string Path(Transform t)=>!t?null:t.parent?Path(t.parent)+"/"+t.name:t.name;
}
