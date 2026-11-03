using UnityEngine;

// What the round (combat, waves, HUD, playback, sound) needs from a stage boss. Round1Boss (Ene_Bos03, BG03) and the
// other stages' bosses (StageBoss and its native-spec subclasses) implement it.
public abstract class RoundBoss : MonoBehaviour
{
    public enum EncounterState { Waiting, Warning, Entering, Fighting, Defeating, Cleared }
    public EncounterState State { get; protected set; }
    public abstract bool StageCleared { get; }
    // No more scheduled waves (the boss section has begun).
    public abstract bool SuppressesWaves { get; }
    public abstract bool ShowGauge { get; }
    // The stage timeline must not end while the boss is alive.
    public abstract bool HoldsStage { get; }
    public abstract float HealthRatio { get; }
    public virtual string Caption => "BOSS";
    // Stage-timeline time to present for the gameplay clock (loops the boss section while the boss lives).
    public abstract float PresentationTime(float timelineTime);
    public abstract void OnDefeated();
    public abstract void OnPartBroken(Round1Combat.Target part);
    public abstract void ResetEncounter();
    // Debug/verification: seek the stage to the boss warning (F3).
    public virtual void JumpToEncounter() {}
}
