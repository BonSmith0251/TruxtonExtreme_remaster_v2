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
            text.text=text.text.Replace("HOME   Restart     F2   Respawn every pickup","HOME   Restart")+"\nF4   Toggle autopilot";
        Refresh();
    }
    void LateUpdate(){if(Input.GetKeyDown(KeyCode.F1))ToggleHelp();Refresh();}
    public void TogglePause(){if(!weapon.GameOver && !weapon.RoundCleared)weapon.player.playback.playing=!weapon.player.playback.playing;Refresh();}
    public void Restart(){weapon.Restart();Refresh();}
    public void Bomb(){weapon.UseBomb();Refresh();}
    public void Change(){weapon.UseChange();Refresh();}
    public void ToggleHelp(){helpPanel.SetActive(!helpPanel.activeSelf);ShowPickupLabels=helpPanel.activeSelf;}
    public void Refresh()
    {
        if(!weapon)return;
        weapon.player.stageCamera.rect=new Rect(0,0,1,1);
        score.SetText(weapon.Score.ToString());highScore.SetText(weapon.HighScore.ToString());
        lives.SetText("X"+Mathf.Max(0,weapon.Lives-1));powerLevel.SetText(weapon.Level.ToString());bombLevel.SetText(weapon.BombLevel.ToString());changes.SetText("X"+weapon.ChangeCharges.ToString("D2"));
        // The reference EX/Pi gauge belongs to a system not yet implemented by the remaster.
        // Leave it empty rather than misrepresenting score, bomb stock or change charges.
        if(extraMeter)extraMeter.enabled=false;
        weaponName.SetText(weapon.PatternName,Round1Weapon.Tints[(int)weapon.Arms]);
        var pilot=weapon.autopilot;
        message.SetText(weapon.Notification.Length>0?weapon.Notification:pilot && pilot.enabled && pilot.automatic?"AUTO - "+pilot.Activity+" / F4":"MANUAL / F4 AUTO");
        for(int i=0;i<powerLamps.Length;i++)powerLamps[i].enabled=i<weapon.Level-1;
        for(int i=0;i<bombLamps.Length;i++)bombLamps[i].enabled=i<weapon.BombLevel;
        for(int i=0;i<bombIcons.Length;i++)bombIcons[i].enabled=i<weapon.Bombs;
        for(int i=0;i<speedLamps.Length;i++)speedLamps[i].enabled=i<weapon.SpeedLevel;
        bool paused=!weapon.player.playback.playing;
        pausePanel.SetActive(paused || weapon.GameOver);
        stateLabel.SetText(weapon.RoundCleared?"ROUND CLEAR":weapon.GameOver?"GAME OVER":"PAUSED");
        if(stateHint)stateHint.text=weapon.RoundCleared || weapon.GameOver?"HOME / ENTER or RESTART to play again":"P / Esc to resume     Home to restart";
        var boss=weapon.combat?weapon.combat.boss:null;
        if(bossPanel)
        {
            bool visible=boss && boss.ShowGauge;bossPanel.SetActive(visible);
            if(visible)
            {
                string text=boss.State==Round1Boss.EncounterState.Warning?"WARNING - BOSS APPROACHING":boss.State==Round1Boss.EncounterState.Defeating?"BOSS DESTROYED":"ROUND 1 BOSS";
                bossCaption.SetText(text);bossMeter.uvRect=new Rect(0,0,boss.HealthRatio,1);
                bossMeter.rectTransform.sizeDelta=new Vector2(656*boss.HealthRatio,20);
            }
        }
        bombButton.interactable=weapon.CanAct && weapon.Bombs>0 && !weapon.BombActive;
        changeButton.interactable=weapon.CanAct && weapon.ChangeCharges>0;
        pauseButton.interactable=!weapon.GameOver && !weapon.RoundCleared;
    }
    void OnDestroy(){ShowPickupLabels=false;}
}
