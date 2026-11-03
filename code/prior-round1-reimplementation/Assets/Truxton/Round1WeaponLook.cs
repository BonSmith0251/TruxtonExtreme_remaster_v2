using System.Collections.Generic;
using UnityEngine;

// How the player's shots look, from the original (WeaponNormalShot/WeaponGrowShot, sp_eff_pshot_* SpriteAnime materials,
// PlayerMuzzle, sp_eff_plaser_* laser prefabs):
// - shot sprites show the material's inner frame region (sp_eff_pshot_20 0.9 wide, _50 0.7x0.7, _60 0.6 wide), two
//   frames side by side, sized per weapon (URP has no One/OneMinusSrcColor blend; PlayerBullet.mat stays additive);
// - every volley plays the weapon's muzzle flash (pf_eff_p_muzzle10..70 by arm kind) at each firing emitter, at most once
//   per 0.05 s per emitter (PlayerMuzzle.Fire);
// - lasers draw the original strip textures (main + sub, black adds its dark underlay) scrolling along the beam, the
//   thunder laser on a jagged path, with the looping laser muzzle at the start and pf_eff_p_hitN0_tip at the end.
public partial class Round1Weapon
{
    static readonly Vector4[] ShotFrames={new Vector4(1,1,0,0),new Vector4(.9f,1,.05f,0),new Vector4(1,1,0,0),new Vector4(1,1,0,0),new Vector4(.7f,.7f,.15f,.15f),new Vector4(.6f,1,.2f,0),new Vector4(1,1,0,0)};
    static readonly Vector2[] ShotSizes={new Vector2(4.9f,6.5f),new Vector2(10.8f,24),new Vector2(5,5),new Vector2(5,5),new Vector2(8,8),new Vector2(6,10),new Vector2(5,5)};
    const float MuzzleHold=.05f,LaserWidth=18,LaserScroll=2.5f;
    sealed class AttachedEffect { public GameObject go;public ParticleSystem[] systems;public Transform follow;public float next;public bool looping,on,used; }
    readonly Dictionary<string,AttachedEffect> attachedEffects=new Dictionary<string,AttachedEffect>();
    readonly List<LineRenderer[]> beamLayers=new List<LineRenderer[]>();
    Material laserAdd,laserDark;
    public int MuzzleFlashes { get; private set; }
    public int LaserEffectsOn { get {int n=0;foreach(var fx in attachedEffects.Values)if(fx.looping && fx.on)n++;return n;} }
    public static string MuzzleEffect(Round1Arms arms)=>"pf_eff_p_muzzle"+((int)arms+1)*10;
    public static string TipEffect(Round1Arms arms)=>"pf_eff_p_hit"+((int)arms+1)*10+"_tip";
    public static Vector2 ShotSize(Round1Arms arms)=>ShotSizes[(int)arms];
    float EffectScale=>Vector3.Distance(player.WorldPoint(Vector2.zero),player.WorldPoint(Vector2.up))/SourceHeight;
    Quaternion EffectRotation=>player.stageCamera.transform.rotation*Quaternion.Euler(-90,0,0);

    Vector3 BulletScale(Bullet b){var s=ShotSizes[(int)b.kind];return new Vector3(s.x*(b.napalm?2.2f:1),s.y,1)*b.size;}
    Vector4 BulletFrame(Bullet b)
    {
        var f=ShotFrames[(int)b.kind];int frame=(int)(b.age/Round1WeaponBehavior.Current.profiles[(int)b.kind].textureSeconds)%2;
        return new Vector4(f.x*.5f,f.y,f.z*.5f+frame*.5f,f.w);
    }
    AttachedEffect Attached(string name,int slot,bool looping)
    {
        string key=name+"#"+slot;if(attachedEffects.TryGetValue(key,out var fx))return fx;
        var prefab=combat && combat.effects!=null?combat.effects.Prefab(name):null;if(!prefab)return null;
        var go=Instantiate(prefab,poolRoot);go.name=key;go.transform.localScale=Vector3.one*EffectScale;
        fx=new AttachedEffect{go=go,systems=go.GetComponentsInChildren<ParticleSystem>(true),looping=looping};
        foreach(var ps in fx.systems){var main=ps.main;main.playOnAwake=false;ps.Stop(true,ParticleSystemStopBehavior.StopEmittingAndClear);}
        attachedEffects[key]=fx;return fx;
    }
    void MuzzleFlash(int muzzle)
    {
        if(emitters==null || muzzle<0 || muzzle>=emitters.Length || !emitters[muzzle])return;
        var fx=Attached(MuzzleEffect(Arms),muzzle,false);if(fx==null)return;
        float now=player.playback.elapsed;fx.follow=emitters[muzzle];fx.go.transform.SetPositionAndRotation(fx.follow.position,EffectRotation);
        if(now<fx.next)return;fx.next=now+MuzzleHold;
        foreach(var ps in fx.systems){ps.Clear(false);ps.Play(false);}
        MuzzleFlashes++;
    }
    void LoopEffect(string name,int slot,Vector2 at)
    {
        var fx=Attached(name,slot,true);if(fx==null)return;
        fx.go.transform.SetPositionAndRotation(player.WorldPoint(at),EffectRotation);fx.used=true;
        if(!fx.on){fx.on=true;foreach(var ps in fx.systems)ps.Play(false);}
    }
    void HideBeamLayers()
    {
        foreach(var layers in beamLayers)if(layers!=null)foreach(var l in layers)if(l)l.enabled=false;
        foreach(var fx in attachedEffects.Values)if(fx.looping)fx.used=false;
    }
    // Every frame after the step: muzzle flashes follow their emitters, laser effects no beam used this frame stop.
    void PlaceShotEffects()
    {
        foreach(var fx in attachedEffects.Values)
        {
            if(fx.follow)fx.go.transform.SetPositionAndRotation(fx.follow.position,EffectRotation);
            if(fx.looping && fx.on && !fx.used){fx.on=false;foreach(var ps in fx.systems)ps.Stop(false,ParticleSystemStopBehavior.StopEmitting);}
        }
    }
    static Material LaserMaterial(bool dark)
    {
        var m=new Material(Shader.Find("Universal Render Pipeline/Unlit"));m.SetColor("_BaseColor",Color.white);
        m.SetFloat("_Surface",1);m.SetFloat("_Blend",dark?0:2);m.SetFloat("_SrcBlend",5);m.SetFloat("_DstBlend",dark?10:1);m.SetFloat("_SrcBlendAlpha",0);m.SetFloat("_DstBlendAlpha",1);m.SetFloat("_ZWrite",0);m.SetFloat("_Cull",0);
        m.EnableKeyword("_SURFACE_TYPE_TRANSPARENT");m.SetOverrideTag("RenderType","Transparent");m.renderQueue=dark?3090:3101;return m;
    }
    // Returns false when the original strips are missing, so the caller keeps the plain tinted line.
    bool StyleBeam(int index,LineRenderer line,Vector2 start,Vector2 end)
    {
        var look=Round1ShotLook.Current;int kind=(int)Arms;
        if(!look || look.laserMain==null || look.laserMain.Length<=kind || !look.laserMain[kind])return false;
        if(!laserAdd){laserAdd=LaserMaterial(false);laserDark=LaserMaterial(true);}
        while(beamLayers.Count<=index)beamLayers.Add(null);
        if(beamLayers[index]==null)
        {
            var layers=new LineRenderer[2];
            for(int i=0;i<2;i++)
            {
                var go=new GameObject(line.name+(i==0?" sub":" dark"));go.transform.SetParent(line.transform,false);
                var l=go.AddComponent<LineRenderer>();l.useWorldSpace=true;l.alignment=LineAlignment.View;l.textureMode=LineTextureMode.Stretch;l.enabled=false;layers[i]=l;
            }
            beamLayers[index]=layers;
        }
        float width=LaserWidth*(index>=16?.5f:1)*(Arms==Round1Arms.Black?1.3f:1),now=player.playback.elapsed;
        bool thunder=Arms==Round1Arms.Blue;int count=thunder?14:2;
        Vector2 along=end-start;along.x*=ShotAspect;Vector2 side=new Vector2(-along.y,along.x).normalized;side.x/=ShotAspect;
        int step=Mathf.FloorToInt(now*30);
        var points=new Vector3[count];
        for(int i=0;i<count;i++)
        {
            float t=i/(count-1f);var p=Vector2.Lerp(start,end,t);
            if(thunder && i>0 && i<count-1){float n=Mathf.Repeat(Mathf.Sin((index*31+i*17+step*13)*12.9898f)*43758.5453f,1)*2-1;p+=side*n*.012f;}
            points[i]=player.WorldPoint(p);
        }
        float length=Vector3.Distance(points[0],points[count-1]);float tiles=Mathf.Max(.05f,length/(width*4)); // the strips are 4:1
        Style(line,laserAdd,look.laserMain[kind],points,width,new Vector4(tiles,1,-now*LaserScroll,0));
        var sub=look.laserSub!=null && look.laserSub.Length>kind?look.laserSub[kind]:null;
        var dark=look.laserDark!=null && look.laserDark.Length>kind?look.laserDark[kind]:null;
        var layer=beamLayers[index];
        if(sub)Style(layer[0],laserAdd,sub,points,width,new Vector4(tiles,1,-now*LaserScroll*1.6f+.37f,0));else layer[0].enabled=false;
        if(dark)Style(layer[1],laserDark,dark,points,width*1.2f,new Vector4(tiles,1,-now*LaserScroll*.7f,0));else layer[1].enabled=false;
        if(index<16)LoopEffect(MuzzleEffect(Arms),100+index,start);
        LoopEffect(TipEffect(Arms),200+index,end);
        return true;
    }
    void Style(LineRenderer l,Material material,Texture2D texture,Vector3[] points,float width,Vector4 st)
    {
        l.sharedMaterial=material;l.textureMode=LineTextureMode.Stretch;l.numCapVertices=0;
        if(l.widthCurve.length!=1 || l.widthCurve.keys[0].value!=1)l.widthCurve=AnimationCurve.Constant(0,1,1);
        l.widthMultiplier=width;l.positionCount=points.Length;l.SetPositions(points);
        tint.Clear();tint.SetTexture("_BaseMap",texture);tint.SetColor("_BaseColor",Color.white);tint.SetVector("_BaseMap_ST",st);l.SetPropertyBlock(tint);l.enabled=true;
    }
    void ReleaseShotLook()
    {
        foreach(var m in new[]{laserAdd,laserDark})if(m){if(Application.isPlaying)Destroy(m);else DestroyImmediate(m);}
        laserAdd=laserDark=null;attachedEffects.Clear();beamLayers.Clear();
    }
}
