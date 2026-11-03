using System;
using UnityEngine;

// Playback of the extracted BG03 camera and activation tracks. Enemy AI is separate.
public class Round1Playback : MonoBehaviour
{
    [Serializable] public class Activation { public GameObject target; public Vector2[] windows; }
    public GameObject cameraRail;
    public AnimationClip cameraMotion;
    public Activation[] activationTracks;
    public float duration=600;
    public float startTime=0;
    [Range(0,600)] public float elapsed;
    public bool playing=true;
    public bool showControls=true;
    public Round1PlayerController player;
    public Round1Weapon weapon;
    [Range(0.1f,4)] public float speed=1;

    void Start() { Seek(startTime); }
    void Update()
    {
        if((Input.GetKeyDown(KeyCode.P)||Input.GetKeyDown(KeyCode.Escape)) && (!weapon || (!weapon.GameOver && !weapon.RoundCleared)))playing=!playing;
        if(Input.GetKeyDown(KeyCode.Home)){if(weapon)weapon.Restart();else Seek(0);}
        if(Input.GetKeyDown(KeyCode.PageDown))Seek(elapsed-5);
        if(Input.GetKeyDown(KeyCode.PageUp))Seek(elapsed+5);
        Advance(Time.deltaTime);
    }
    // The original director keeps time in a double. Summing 1/60 steps into the float field drifts by about
    // 58 ms over 420 s and makes cues fire a frame late, so accumulate in a double and resync after outside writes.
    double exactElapsed;
    public void Advance(float dt)
    {
        if(!playing || (weapon && weapon.intro && weapon.intro.Active))return;
        if(Math.Abs(exactElapsed-elapsed)>.001)exactElapsed=elapsed;
        exactElapsed+=Mathf.Max(0,dt)*(double)speed;SetTime((float)exactElapsed,false);
    }
    public void Seek(float time){SetTime(time,true);}
    void SetTime(float time,bool explicitSeek)
    {
        float previous=elapsed;
        elapsed=Mathf.Clamp(time,0,duration);
        var boss=weapon && weapon.combat?weapon.combat.boss:null;
        float presentation=boss?boss.PresentationTime(elapsed):elapsed;
        if(cameraMotion && cameraRail)cameraMotion.SampleAnimation(cameraRail,presentation);
        if(activationTracks!=null)foreach(var track in activationTracks)
        {
            if(!track.target)continue;
            bool active=false;
            foreach(var window in track.windows)if(presentation>=window.x && presentation<window.y){active=true;break;}
            if(track.target.activeSelf!=active)track.target.SetActive(active);
        }
        Shader.SetGlobalFloat("_TruxtonTime",presentation);
        if(player)player.Place();
        if(explicitSeek && weapon && (elapsed<previous-0.001f || elapsed-previous>0.5f))weapon.OnTimelineSeek(previous,elapsed);
        if(elapsed>=duration && (!boss || !boss.HoldsStage))playing=false;
    }
    void OnGUI()
    {
        if(!showControls)return;
        GUILayout.BeginArea(new Rect(16,16,470,144),GUI.skin.box);
        GUILayout.Label("ROUND 1  /  VOLCANO");
        GUILayout.Label("WASD / Arrows: move    Shift: precision    R: reset ship");
        GUILayout.Label("Space / Z / Left mouse: fire    P: pause");
        GUILayout.Label($"{elapsed:000.0} / {duration:000} s    PgUp / PgDn: seek    Home: restart");
        float value=GUILayout.HorizontalSlider(elapsed,0,duration);
        if(Mathf.Abs(value-elapsed)>0.01f)Seek(value);
        GUILayout.EndArea();
    }
}
