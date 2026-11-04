using UnityEngine;
using UnityEngine.UI;

[DefaultExecutionOrder(300)]
public class Round1Hud : MonoBehaviour
{
    public Round1Weapon weapon;
    public Canvas canvas;
    public Round1HudText score,highScore,lives,powerLevel,bombLevel,changes,weaponName,message,stateLabel;
    public RawImage[] powerLamps,bombLamps,bombIcons,speedLamps;
    public RawImage extraMeter;
    public GameObject pausePanel,helpPanel;
    public Button pauseButton,restartButton,bombButton,changeButton,helpButton;
    public GameObject bossPanel;
    public RawImage bossMeter;
    public Round1HudText bossCaption;
    public Text stateHint;
    public static bool ShowPickupLabels { get; private set; }
    void Start()
    {
        pauseButton.onClick.AddListener(TogglePause);restartButton.onClick.AddListener(Restart);
        bombButton.onClick.AddListener(Bomb);changeButton.onClick.AddListener(Change);helpButton.onClick.AddListener(ToggleHelp);
        if(helpPanel)foreach(var text in helpPanel.GetComponentsInChildren<Text>(true))
            text.text=text.text.Replace("HOME   Restart     F2   Respawn every pickup","HOME   Restart").Replace("C   Use change charge","C   Speed   Q / E   Speed down / up")+"\nF4   Toggle autopilot";
        // The original has no weapon-change stock: the slot shows the speed level and the capacity speed items have opened.
        if(canvas)foreach(var text in canvas.GetComponentsInChildren<Text>(true))if(text.text=="Change charges")text.text="Speed";
        Refresh();
    }
    void LateUpdate(){if(Input.GetKeyDown(KeyCode.F1) && !ArcadeMachine.Running)ToggleHelp();Refresh();}
    public void TogglePause(){if(!weapon.GameOver && !weapon.RoundCleared)weapon.player.playback.playing=!weapon.player.playback.playing;Refresh();}
    public void Restart(){weapon.Restart();Refresh();}
    public void Bomb(){weapon.UseBomb();Refresh();}
    public void Change(){weapon.ChangeSpeed();Refresh();}
    public void ToggleHelp(){helpPanel.SetActive(!helpPanel.activeSelf);ShowPickupLabels=helpPanel.activeSelf;}
    public void Refresh()
    {
        if(!weapon)return;
        weapon.player.stageCamera.rect=new Rect(0,0,1,1);
        score.SetText(weapon.Score.ToString());highScore.SetText(weapon.HighScore.ToString());
        lives.SetText("X"+Mathf.Max(0,weapon.Lives-1));powerLevel.SetText(weapon.Level.ToString());bombLevel.SetText(weapon.BombLevel.ToString());changes.SetText(weapon.SpeedLevel+"/"+(weapon.SpeedCapacity+1));
        // The reference EX/Pi gauge belongs to a system not yet implemented by the remaster.
        // Leave it empty rather than misrepresenting score, bomb stock or change charges.
        if(extraMeter)extraMeter.enabled=false;
        weaponName.SetText(weapon.PatternName,Round1Weapon.Tints[(int)weapon.Arms]);
        var pilot=weapon.autopilot;
        message.SetText(weapon.Notification.Length>0?weapon.Notification:ArcadeMachine.Running?ArcadeMachine.HudLine:pilot && pilot.enabled && pilot.automatic?"AUTO - "+pilot.Activity+" / F4":"MANUAL / F4 AUTO");
        // PlayerUI.SetValue -> InGameValueLevel: the lamps are the items toward the next level, the number is the level.
        for(int i=0;i<powerLamps.Length;i++)powerLamps[i].enabled=i<weapon.PowerItems;
        for(int i=0;i<bombLamps.Length;i++)bombLamps[i].enabled=i<weapon.BombLevel;
        for(int i=0;i<bombIcons.Length;i++)bombIcons[i].enabled=i<weapon.Bombs;
        for(int i=0;i<speedLamps.Length;i++)speedLamps[i].enabled=i<weapon.SpeedLevel;
        bool paused=!weapon.player.playback.playing;
        // A cleared or lost round shows Round1StageEnd's banner instead of the pause panel.
        pausePanel.SetActive((paused || weapon.GameOver) && !(Round1StageEnd.Handles && (weapon.GameOver || weapon.RoundCleared)));
        stateLabel.SetText(weapon.RoundCleared?"ROUND CLEAR":weapon.GameOver?"GAME OVER":"PAUSED");
        if(stateHint)stateHint.text=weapon.RoundCleared || weapon.GameOver?"HOME / ENTER or RESTART to play again":"P / Esc to resume     Home to restart";
        var boss=weapon.combat?weapon.combat.boss:null;
        if(bossPanel)
        {
            bool visible=boss && boss.ShowGauge;bossPanel.SetActive(visible);
            if(visible)
            {
                string text=boss.State==RoundBoss.EncounterState.Warning?"WARNING - BOSS APPROACHING":boss.State==RoundBoss.EncounterState.Defeating?"BOSS DESTROYED":boss.Caption;
                bossCaption.SetText(text);bossMeter.uvRect=new Rect(0,0,boss.HealthRatio,1);
                bossMeter.rectTransform.sizeDelta=new Vector2(656*boss.HealthRatio,20);
            }
        }
        bombButton.interactable=weapon.CanAct && weapon.Bombs>0 && !weapon.BombActive;
        changeButton.interactable=weapon.CanAct && weapon.SpeedCapacity>0;
        pauseButton.interactable=!weapon.GameOver && !weapon.RoundCleared;
    }
    void OnDestroy(){ShowPickupLabels=false;}
}
