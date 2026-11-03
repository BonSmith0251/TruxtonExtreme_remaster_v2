namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001CC")]
public class Ene_Bos08C : Ene_BosBase
{
	[CompilerGenerated]
	[Token(Token = "0x20001D2")]
	private sealed class <>c__DisplayClass76_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000FFD")]
		public Vector3 capturedPosition; //Field offset: 0x10
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000FFE")]
		public Vector3 capturedDirection; //Field offset: 0x1C
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000FFF")]
		public BowFollowerInfo follower; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001000")]
		public Ene_Bos08C <>4__this; //Field offset: 0x30

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000DF6")]
		public <>c__DisplayClass76_0() { }

		[Address(RVA = "0x1DD1470", Offset = "0x1DD0870", Length = "0x153")]
		[Token(Token = "0x6000DF7")]
		internal void <FireBowBullet>b__0(InGameBulletInterface bullet) { }

	}

	[Token(Token = "0x20001CF")]
	private enum Boss08BulletType : int
	{
		StraightFront = 0,
		ArcSide = 1,
		CoreWay = 2,
		Bow = 3,
	}

	[Token(Token = "0x20001CE")]
	private enum Boss08Muzzle : int
	{
		MuzzleTop = 0,
		MuzzleFront = 1,
		FrontEdge = 2,
		MuzzleBack = 3,
		BackEdge = 4,
	}

	[Token(Token = "0x20001CD")]
	private enum Boss08State : int
	{
		EntryWait = 0,
		PT1 = 1,
		Destruction = 100,
	}

	[Token(Token = "0x20001D1")]
	private class BowFollowerInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000FF8")]
		public InGameBulletBow Bullet; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000FF9")]
		public float RemainingFollowTime; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000FFA")]
		public float AngleOffset; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000FFB")]
		public int TargetPlayerIndex; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000FFC")]
		public bool HasFired; //Field offset: 0x24

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000DF5")]
		public BowFollowerInfo() { }

	}

	[Token(Token = "0x20001D0")]
	private enum PartsKind : int
	{
		Core = 0,
	}

	[Token(Token = "0x4000FBD")]
	private static readonly Vector3 _homePosition; //Field offset: 0x0
	[Token(Token = "0x4000FD4")]
	private const float PhaseOneBowSpreadAngle = 360; //Field offset: 0x0
	[Token(Token = "0x4000FD3")]
	private const int PhaseOneBowDirectionCount = 8; //Field offset: 0x0
	[Token(Token = "0x4000FD2")]
	private const float PhaseOneBowFireDelay = 0; //Field offset: 0x0
	[Token(Token = "0x4000FD0")]
	private const float PhaseOneBowSpawnOffsetDistance = 20; //Field offset: 0x0
	[Token(Token = "0x4000FCF")]
	private const float PhaseOneEightWayBurstDurationSeconds = 3; //Field offset: 0x0
	[Token(Token = "0x4000FCE")]
	private const float PhaseOneEightWayMinIntervalSeconds = 0.1; //Field offset: 0x0
	[Token(Token = "0x4000FCD")]
	private const float PhaseOneEightWayBaseIntervalSeconds = 0.5; //Field offset: 0x0
	[Token(Token = "0x4000FCC")]
	private const float PhaseOneHomingHardIntervalBaseSeconds = 1.5; //Field offset: 0x0
	[Token(Token = "0x4000FCB")]
	private const float PhaseOneHomingDelaySeconds = 1; //Field offset: 0x0
	[Token(Token = "0x4000FCA")]
	private const float PhaseOneLaserFadeSeconds = 0.5; //Field offset: 0x0
	[Token(Token = "0x4000FC9")]
	private const float PhaseOneLaserChargeSeconds = 1; //Field offset: 0x0
	[Token(Token = "0x4000FD1")]
	private const float PhaseOneBowFollowDuration = 2; //Field offset: 0x0
	[Token(Token = "0x4000FC7")]
	private const float PhaseOneLaserIdleSecondsNormal = 3; //Field offset: 0x0
	[Token(Token = "0x4000FC6")]
	private const float PhaseOneMaxYawSpeed = 90; //Field offset: 0x0
	[Token(Token = "0x4000FC5")]
	private const float PhaseOneMovementEaseDuration = 1.2; //Field offset: 0x0
	[Token(Token = "0x4000FC4")]
	private const float PhaseOneMoveCycleSeconds = 12; //Field offset: 0x0
	[Token(Token = "0x4000FC3")]
	private const float PhaseOneMoveAmplitude = 60; //Field offset: 0x0
	[Token(Token = "0x4000FC8")]
	private const float PhaseOneLaserIdleSecondsHard = 0.5; //Field offset: 0x0
	[Token(Token = "0x4000FBE")]
	private static readonly Quaternion _homeStartRotate; //Field offset: 0xC
	[Token(Token = "0x4000FBF")]
	private static readonly String[] _bulletTemplateNames; //Field offset: 0x20
	[Token(Token = "0x4000FC0")]
	private static readonly String[] _muzzleNodeNames; //Field offset: 0x28
	[Token(Token = "0x4000FC1")]
	private static readonly Single[] _arcAngles; //Field offset: 0x30
	[Token(Token = "0x4000FC2")]
	private static readonly int MuzzleCount; //Field offset: 0x38
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4000FD5")]
	private Boss08State _currentState; //Field offset: 0x270
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4000FD6")]
	private Transform[] _muzzles; //Field offset: 0x278
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4000FD7")]
	private float _localTime; //Field offset: 0x280
	[FieldOffset(Offset = "0x284")]
	[Token(Token = "0x4000FD8")]
	private int _laserSeId; //Field offset: 0x284
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4000FD9")]
	private float _phaseOneMovePhase; //Field offset: 0x288
	[FieldOffset(Offset = "0x28C")]
	[Token(Token = "0x4000FDA")]
	private float _phaseOneEaseTimer; //Field offset: 0x28C
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4000FDB")]
	private float _phaseOneYaw; //Field offset: 0x290
	[FieldOffset(Offset = "0x294")]
	[Token(Token = "0x4000FDC")]
	private float _phaseOneHomingTimer; //Field offset: 0x294
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x4000FDD")]
	private float _phaseOneLaserTimer; //Field offset: 0x298
	[FieldOffset(Offset = "0x29C")]
	[Token(Token = "0x4000FDE")]
	private bool _phaseOnePendingHoming; //Field offset: 0x29C
	[FieldOffset(Offset = "0x29D")]
	[Token(Token = "0x4000FDF")]
	private bool _phaseOneNextHoming; //Field offset: 0x29D
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x4000FE0")]
	private float _phaseOneEightWayTimer; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A4")]
	[Token(Token = "0x4000FE1")]
	private float _phaseOneEightWayInterval; //Field offset: 0x2A4
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x4000FE2")]
	private bool _phaseOneEightWayBurstActive; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2AC")]
	[Token(Token = "0x4000FE3")]
	private float _phaseOneEightWayBurstRemain; //Field offset: 0x2AC
	[FieldOffset(Offset = "0x2B0")]
	[Token(Token = "0x4000FE4")]
	private bool _isLaserFiring; //Field offset: 0x2B0
	[FieldOffset(Offset = "0x2B1")]
	[Token(Token = "0x4000FE5")]
	private bool _isHighDifficulty; //Field offset: 0x2B1
	[FieldOffset(Offset = "0x2B8")]
	[Token(Token = "0x4000FE6")]
	private readonly List<BowFollowerInfo> _bowFollowers; //Field offset: 0x2B8

	[Address(RVA = "0x1DB7690", Offset = "0x1DB6A90", Length = "0x185")]
	[Token(Token = "0x6000DE0")]
	private void _clearBowFollowers(bool disableBullet) { }

	[Address(RVA = "0x1DB7300", Offset = "0x1DB6700", Length = "0x38D")]
	[Token(Token = "0x6000DF4")]
	private static Ene_Bos08C() { }

	[Address(RVA = "0x1DB7820", Offset = "0x1DB6C20", Length = "0xB9")]
	[Token(Token = "0x6000DF3")]
	public Ene_Bos08C() { }

	[Address(RVA = "0x1DB3950", Offset = "0x1DB2D50", Length = "0x82")]
	[Token(Token = "0x6000DD5")]
	public virtual void CallDisabled() { }

	[Address(RVA = "0x1DB39E0", Offset = "0x1DB2DE0", Length = "0x43")]
	[Token(Token = "0x6000DDC")]
	private void CheckNextState() { }

	[Address(RVA = "0x1DB3A30", Offset = "0x1DB2E30", Length = "0x7C1")]
	[Token(Token = "0x6000DEF")]
	private void FireBowBullet() { }

	[Address(RVA = "0x1DB4200", Offset = "0x1DB3600", Length = "0xBD")]
	[Token(Token = "0x6000DEE")]
	private void FireEightWayBullets() { }

	[Address(RVA = "0x1DB42C0", Offset = "0x1DB36C0", Length = "0x1F1")]
	[Token(Token = "0x6000DEB")]
	private void FireFrontAndBackLasers() { }

	[Address(RVA = "0x1DB44C0", Offset = "0x1DB38C0", Length = "0x280")]
	[Token(Token = "0x6000DED")]
	private void FireHomingBullets() { }

	[Address(RVA = "0x1DB4750", Offset = "0x1DB3B50", Length = "0x9")]
	[Token(Token = "0x6000DD9")]
	public virtual float GetBattileTime() { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000DDA")]
	protected virtual int GetBonusTimeKind() { }

	[Address(RVA = "0x1DB4760", Offset = "0x1DB3B60", Length = "0x4F")]
	[Token(Token = "0x6000DDF")]
	protected virtual String[] GetBossBT() { }

	[Address(RVA = "0x5AA980", Offset = "0x5A9D80", Length = "0x4A")]
	[Token(Token = "0x6000DF1")]
	protected virtual Vector3 GetDifferenceVector() { }

	[Address(RVA = "0x1D8C230", Offset = "0x1D8B630", Length = "0x2E")]
	[Token(Token = "0x6000DDE")]
	private Transform GetMuzzle(Boss08Muzzle muzzle) { }

	[Address(RVA = "0x1D7E4B0", Offset = "0x1D7D8B0", Length = "0x25")]
	[Token(Token = "0x6000DD4")]
	public virtual void GetStart() { }

	[Address(RVA = "0x1DB47B0", Offset = "0x1DB3BB0", Length = "0x77")]
	[Token(Token = "0x6000DF2")]
	private void HandleDestroyedResult() { }

	[Address(RVA = "0x1DB4970", Offset = "0x1DB3D70", Length = "0x39E")]
	[Token(Token = "0x6000DD2")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1DB4830", Offset = "0x1DB3C30", Length = "0x138")]
	[Token(Token = "0x6000DE3")]
	private void InitializePhaseOnePattern() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000DD8")]
	public virtual bool IsPoseRecord() { }

	[Address(RVA = "0x1DB4D10", Offset = "0x1DB4110", Length = "0x7C0")]
	[Token(Token = "0x6000DF0")]
	private void PatternMoveDestruction(float dt) { }

	[Address(RVA = "0x1DB54E0", Offset = "0x1DB48E0", Length = "0x367")]
	[Token(Token = "0x6000DE1")]
	private void PatternMoveEntryWait(float dt) { }

	[Address(RVA = "0x1DB5850", Offset = "0x1DB4C50", Length = "0x6E7")]
	[Token(Token = "0x6000DE2")]
	private void PatternMovePhaseOne(float deltaTime) { }

	[Address(RVA = "0x1DB6030", Offset = "0x1DB5430", Length = "0xF9")]
	[Token(Token = "0x6000DEA")]
	private void RefreshEightWayInterval() { }

	[Address(RVA = "0x1DB5F40", Offset = "0x1DB5340", Length = "0xEC")]
	[Token(Token = "0x6000DD3")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1DAB240", Offset = "0x1DAA640", Length = "0x39")]
	[Token(Token = "0x6000DDB")]
	private void SetState(Boss08State nextState) { }

	[Address(RVA = "0x1DB6130", Offset = "0x1DB5530", Length = "0xFD")]
	[Token(Token = "0x6000DE8")]
	private void StartPhaseOneEightWayBurst() { }

	[Address(RVA = "0x1DB6230", Offset = "0x1DB5630", Length = "0x2D")]
	[Token(Token = "0x6000DDD")]
	protected virtual void StateExec(float dt) { }

	[Address(RVA = "0x1DB6260", Offset = "0x1DB5660", Length = "0xBE")]
	[Token(Token = "0x6000DEC")]
	private void StopLaserSe(bool isFast = false) { }

	[Address(RVA = "0x1DB6320", Offset = "0x1DB5720", Length = "0x4B")]
	[Token(Token = "0x6000DD6")]
	protected virtual void TimeupAction() { }

	[Address(RVA = "0x1DB6370", Offset = "0x1DB5770", Length = "0x133")]
	[Token(Token = "0x6000DD7")]
	public virtual void ToDestroid() { }

	[Address(RVA = "0x1DB64B0", Offset = "0x1DB58B0", Length = "0x68A")]
	[Token(Token = "0x6000DE7")]
	private void UpdateBowFollowers(float dt) { }

	[Address(RVA = "0x1DB6B40", Offset = "0x1DB5F40", Length = "0x1C1")]
	[Token(Token = "0x6000DE6")]
	private void UpdatePhaseOneEightWay(float dt) { }

	[Address(RVA = "0x1DB6D10", Offset = "0x1DB6110", Length = "0x11A")]
	[Token(Token = "0x6000DE9")]
	private void UpdatePhaseOneHomingIndependent(float dt) { }

	[Address(RVA = "0x1DB6E30", Offset = "0x1DB6230", Length = "0x287")]
	[Token(Token = "0x6000DE5")]
	private void UpdatePhaseOneLaserCycle(float dt, float fireDuration, float idleDuration, bool allowLaserLinkedHoming) { }

	[Address(RVA = "0x1DB70C0", Offset = "0x1DB64C0", Length = "0x231")]
	[Token(Token = "0x6000DE4")]
	private void UpdatePhaseOneMovement(float dt, float amplitude, float cycleSeconds, float easeDuration, float maxYawSpeed) { }

}

