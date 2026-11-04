using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

// The original item rules (evidence/items/SPEC.md) on the BG03 stage's ship, in edit mode: power items (3 per level,
// full, then the 5000 bonus), the bonus multiplier, weapon colours, speed capacity, bomb and life caps, death losses,
// the item table with a pending extend, and the floating item's drift and lifetime.
// Batch: -executeMethod ReconstructionItemRulesCheck.Run   -> ../verification/powerup-20261104/item-rules.txt
public static class ReconstructionItemRulesCheck
{
    static readonly List<string> lines=new List<string>();
    static bool all=true;
    static void Expect(string what,bool ok,string detail=""){lines.Add((ok?"PASS ":"FAIL ")+what+(detail.Length>0?"  ("+detail+")":""));all&=ok;}

    public static void Run()
    {
        const string output="../verification/powerup-20261104";Directory.CreateDirectory(output);
        int code=1;
        try
        {
            EditorSceneManager.OpenScene("Assets/Scenes/StagePlay/StagePlay_BG03.unity",OpenSceneMode.Single);
            var w=UnityEngine.Object.FindFirstObjectByType<Round1Weapon>();
            w.Initialize();w.ResetRun();
            Check(w);
            code=all?0:1;
        }
        catch(Exception e){lines.Add("FAIL exception "+e);all=false;}
        lines.Add(all?"ItemRulesCheck: PASSED":"ItemRulesCheck: FAILED");
        File.WriteAllLines(output+"/item-rules.txt",lines);foreach(var l in lines)Debug.Log("ItemRulesCheck "+l);
        ReconstructionExit.Quit(code);
    }
    static void Set(Round1Weapon w,string property,object value)=>typeof(Round1Weapon).GetProperty(property).SetValue(w,value);
    static void Die(Round1Weapon w)
    {
        Set(w,"Lives",w.Lives-1);
        typeof(Round1Weapon).GetMethod("ClearByDead",System.Reflection.BindingFlags.Instance|System.Reflection.BindingFlags.NonPublic).Invoke(w,null);
    }
    static void Check(Round1Weapon w)
    {
        var P=Round1PickupKind.Power;
        Expect("start",w.Level==1 && w.PowerItems==0 && w.SpeedLevel==1 && w.SpeedCapacity==0 && w.Bombs==3 && w.Lives==3 && w.BombLevel==1,
            $"L{w.Level} items {w.PowerItems} speed {w.SpeedLevel}/{w.SpeedCapacity} bombs {w.Bombs} lives {w.Lives}");
        w.ApplyPickup(P);w.ApplyPickup(P);
        Expect("two power items stay on level 1",w.Level==1 && w.PowerItems==2,$"L{w.Level} items {w.PowerItems}");
        w.ApplyPickup(P);
        Expect("third power item -> level 2",w.Level==2 && w.PowerItems==0,$"L{w.Level} items {w.PowerItems}");
        for(int i=0;i<6;i++)w.ApplyPickup(P);
        Expect("9 items -> top level 4",w.Level==4 && w.PowerItems==0 && w.Score==0,$"L{w.Level} items {w.PowerItems} score {w.Score}");
        for(int i=0;i<3;i++)w.ApplyPickup(P);
        Expect("3 more -> full, no score",w.Level==4 && w.PowerItems==3 && w.Score==0,$"items {w.PowerItems} score {w.Score}");
        w.ApplyPickup(P);
        Expect("power when full -> 5000 x1",w.Score==5000 && w.BonusMultiplier==1,$"score {w.Score} mul {w.BonusMultiplier}");
        w.ApplyPickup(P);
        Expect("next -> 5000 x2",w.Score==15000 && w.BonusMultiplier==2,$"score {w.Score}");
        w.ApplyPickup(Round1PickupKind.Red);
        Expect("current colour -> bonus x3, weapon kept",w.Score==30000 && w.Arms==Round1Arms.Red,$"score {w.Score} arms {w.Arms}");
        w.ApplyPickup(Round1PickupKind.Blue);
        Expect("other colour -> weapon changes, level kept, no bonus",w.Arms==Round1Arms.Blue && w.Level==4 && w.PowerItems==3 && w.Score==30000);
        for(int i=0;i<20;i++)w.ApplyPickup(P);
        Expect("multiplier caps at 10",w.BonusMultiplier==10,$"mul {w.BonusMultiplier}");
        int score=w.Score;
        for(int i=0;i<5;i++)w.ApplyPickup(Round1PickupKind.SpeedUp);
        Expect("5 speed items -> capacity 5, top speed 3.0",w.SpeedCapacity==5 && w.SpeedLevel==6 && Mathf.Approximately(w.player.SpeedMultiplier,3) && w.Score==score,
            $"speed {w.SpeedLevel}/{w.SpeedCapacity} x{w.player.SpeedMultiplier}");
        w.ApplyPickup(Round1PickupKind.SpeedUp);
        Expect("sixth speed item -> bonus",w.Score==score+50000,$"+{w.Score-score}");
        Expect("speed selectable 0..capacity",w.SetSpeed(0) && w.SpeedLevel==1 && Mathf.Approximately(w.player.SpeedMultiplier,1) && !w.SetSpeed(0));
        w.SetSpeed(5);
        for(int i=0;i<7;i++)w.ApplyPickup(Round1PickupKind.BombStock);
        Expect("bomb item +1, cap 10",w.Bombs==10,$"bombs {w.Bombs}");
        score=w.Score;w.ApplyPickup(Round1PickupKind.BombStock);
        Expect("bomb item at 10 -> bonus",w.Bombs==10 && w.Score==score+50000);
        w.ApplyPickup(Round1PickupKind.OneUp);w.ApplyPickup(Round1PickupKind.TwoUp);
        Expect("1UP/2UP add ships",w.Lives==6,$"lives {w.Lives}");

        Die(w);
        Expect("death at full top level keeps the level, loses full",w.Level==4 && w.PowerItems==0,$"L{w.Level} items {w.PowerItems}");
        Expect("death: capacity -1, speed clamped, multiplier 0, bombs kept",w.SpeedCapacity==4 && w.SpeedLevel==5 && w.BonusMultiplier==0 && w.Bombs==10,
            $"speed {w.SpeedLevel}/{w.SpeedCapacity} mul {w.BonusMultiplier} bombs {w.Bombs}");
        w.ApplyPickup(P);Die(w);
        Expect("death keeps the item progress, level -1",w.Level==3 && w.PowerItems==1,$"L{w.Level} items {w.PowerItems}");
        Set(w,"Bombs",1);Die(w);
        Expect("death tops bombs up to 3",w.Bombs==3,$"bombs {w.Bombs}");
        Expect("weapon survives death",w.Arms==Round1Arms.Blue);

        // Item table: the death above reset it to the start.
        var drawn=new List<Round1PickupKind>();for(int i=0;i<3;i++)drawn.Add(w.NextTableItem());
        Expect("table starts power, speed, power",drawn[0]==P && drawn[1]==Round1PickupKind.SpeedUp && drawn[2]==P,string.Join(",",drawn));
        w.GrantExtend();var extend=w.NextTableItem();var after=w.NextTableItem();
        Expect("pending extend -> 1UP, table not advanced",extend==Round1PickupKind.OneUp && after==P && w.PendingExtends==0,$"{extend},{after}");
        score=w.Score;w.ApplyPickup(Round1PickupKind.Bonus,true);
        Expect("ground score item -> 5000 + 5000 bonus",w.Score==score+10000,$"+{w.Score-score}");

        // Floating item: 200 units down in 25 s with ease-out, not collectable for 0.1 s, gone 2 s after leaving the area.
        var item=w.SpawnDroppedPickup(Round1PickupKind.SpeedUp,new Vector2(.5f,.9f),100);
        item.Evaluate(100.05f);bool early=item.Available;
        item.Evaluate(112.5f);float y=item.Position.y;
        Expect("item drifts with ease-out",early && Mathf.Abs(y-(.9f-.75f))<.001f,$"y at 12.5 s {y:0.000}");
        var low=w.SpawnDroppedPickup(Round1PickupKind.Power,new Vector2(.5f,.5f),150);   // below -0.15 from ~10.2 s
        low.Evaluate(161);bool out1=low.Available;float y2=low.Position.y;
        low.Evaluate(162.9f);bool out2=low.Available;low.Evaluate(163.1f);bool out3=low.Available;
        Expect("item removed 2 s after leaving the play area",out1 && out2 && !out3 && y2<-.15f,$"y {y2:0.000} at 11 s, {out1}/{out2}/{out3}");
        var stay=w.SpawnDroppedPickup(Round1PickupKind.Power,new Vector2(.5f,1.1f),200);
        stay.Evaluate(224.9f);bool alive=stay.Available;stay.Evaluate(225.1f);
        Expect("item ends with its 25 s route",alive && !stay.Available);

        // Awaken (AWAKEN.md): the unlock raises the top level by 1 or 2; shots stay level 4's, the awaken body changes.
        w.awakenUnlock=0;w.ResetRun();
        for(int i=0;i<30;i++)w.ApplyPickup(P);
        Expect("locked: top level 4, awaken body 0",w.Level==4 && w.AwakenBody==0 && w.BombLevel==1 && w.BonusMax==10,$"L{w.Level} body {w.AwakenBody}");
        w.awakenUnlock=2;w.ResetRun();int shots4=w.CountShots(w.Arms,4);
        for(int i=0;i<12;i++)w.ApplyPickup(P);
        Expect("unlocked x1 step: level 5 = awaken body 1",w.Level==5 && w.AwakenBody==1 && w.BombLevel==2 && w.BonusMax==11 && w.ShotLevel==4,$"L{w.Level} body {w.AwakenBody}");
        for(int i=0;i<3;i++)w.ApplyPickup(P);
        Expect("unlocked x2: level 6, body 2, bomb 3, bonus cap 12, level-4 shots",w.Level==6 && w.AwakenBody==2 && w.BombLevel==3 && w.BonusMax==12 && w.ShotLevel==4 && w.ShotsAtLevel==shots4,
            $"L{w.Level} body {w.AwakenBody} shots {w.ShotsAtLevel}/{shots4}");
        for(int i=0;i<3;i++)w.ApplyPickup(P);score=w.Score;w.ApplyPickup(P);
        Expect("level 6 full -> bonus",w.PowerItems==3 && w.Score>score,$"items {w.PowerItems}");
        Die(w);Expect("death at full level 6 keeps it",w.Level==6 && w.PowerItems==0);
        Die(w);Expect("next death -> level 5",w.Level==5);
        w.awakenUnlock=0;

        // Separate speed up / down buttons (_playerControllSpeedChange): one level, no wrap, 0..capacity.
        w.ResetRun();for(int i=0;i<2;i++)w.ApplyPickup(Round1PickupKind.SpeedUp);
        bool playing=w.player.playback.playing;w.player.playback.playing=true;
        if(w.intro)w.intro.Cancel();w.player.CancelSpawn();
        if(w.CanAct)
        {
            bool up=w.SpeedUp();int atTop=w.SpeedLevel;bool down1=w.SpeedDown(),down2=w.SpeedDown();bool down3=w.SpeedDown();
            Expect("speed up/down step one level within 0..capacity",!up && atTop==3 && down1 && down2 && !down3 && w.SpeedLevel==1,$"up {up} top {atTop} downs {down1}/{down2}/{down3} level {w.SpeedLevel}");
            bool u1=w.SpeedUp(),u2=w.SpeedUp(),u3=w.SpeedUp();
            Expect("speed up stops at the capacity",u1 && u2 && !u3 && w.SpeedLevel==3);
        }
        else Expect("speed buttons testable (CanAct)",false,"CanAct false in edit mode");
        w.player.playback.playing=playing;

        // Rank (RANK.md): bounds ClampBase[stage] + 100 x round; arcade amounts; bullet speed and repeat scales.
        w.ResetRun();
        Expect("rank starts 0 in [-10, 30] (BG03)",w.RankPoint==0 && w.RankMin==-10 && w.RankMax==30,$"{w.RankPoint} [{w.RankMin},{w.RankMax}]");
        for(int i=0;i<3;i++)w.ApplyPickup(P);float r=w.RankPoint;
        w.ApplyPickup(P);w.ApplyPickup(P);
        Expect("power-level rise +0.1, sub-steps nothing",Mathf.Approximately(r,.1f) && Mathf.Approximately(w.RankPoint,.1f),$"{r} {w.RankPoint}");
        w.ApplyPickup(Round1PickupKind.BombStock);
        Expect("bomb-stock item +0.1",Mathf.Approximately(w.RankPoint,.2f),$"{w.RankPoint}");
        Die(w);Expect("death does not reset the rank",Mathf.Approximately(w.RankPoint,.2f));
        w.SetupRank(0,0,30);
        Expect("rank 30: bullets x1.075, repeats x0.994",Mathf.Abs(w.RankBulletSpeedScale-1.075f)<1e-4f && Mathf.Abs(w.RankRepeatScale-.994f)<1e-4f,$"{w.RankBulletSpeedScale} {w.RankRepeatScale}");
        w.SetupRank(7,1,500);
        Expect("BG08 round 2 bounds [160, 200], clamped",w.RankMin==160 && w.RankMax==200 && w.RankPoint==200,$"[{w.RankMin},{w.RankMax}] {w.RankPoint}");
        w.SetupRank(0,0,-10);
        Expect("negative rank slows bullets (x0.991)",Mathf.Abs(w.RankBulletSpeedScale-.991f)<1e-4f,$"{w.RankBulletSpeedScale}");
    }
}
