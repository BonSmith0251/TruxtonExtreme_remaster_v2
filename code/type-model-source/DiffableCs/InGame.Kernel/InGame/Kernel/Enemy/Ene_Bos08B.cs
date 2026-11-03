namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001C4")]
public class Ene_Bos08B : Ene_BosBase
{
	[CompilerGenerated]
	[Token(Token = "0x20001CA")]
	private sealed class <>c
	{
		[Token(Token = "0x4000FB8")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000FB9")]
		public static Predicate<InGameBulletInterface> <>9__129_0; //Field offset: 0x8
		[Token(Token = "0x4000FBA")]
		public static Predicate<InGameBulletInterface> <>9__129_1; //Field offset: 0x10

		[Address(RVA = "0x1DB8E50", Offset = "0x1DB8250", Length = "0x67")]
		[Token(Token = "0x6000DCE")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000DCF")]
		public <>c() { }

		[Address(RVA = "0x1DB8C30", Offset = "0x1DB8030", Length = "0x71")]
		[Token(Token = "0x6000DD0")]
		internal bool <TriggerBowBullet>b__129_0(InGameBulletInterface bullet) { }

		[Address(RVA = "0x1DB8CB0", Offset = "0x1DB80B0", Length = "0x71")]
		[Token(Token = "0x6000DD1")]
		internal bool <TriggerBowBullet>b__129_1(InGameBulletInterface bullet) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001CB")]
	private struct <>c__DisplayClass126_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FBB")]
		public Ene_Bos08B <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000FBC")]
		public float deltaTime; //Field offset: 0x8

	}

	[Token(Token = "0x20001C6")]
	private enum Boss08BMZ : int
	{
		muzzle_top01 = 0,
	}

	[Token(Token = "0x20001C7")]
	private enum Boss08BT : int
	{
		pat1A = 0,
		pat2A = 1,
		pat2B = 2,
		Bow = 3,
	}

	[Token(Token = "0x20001C5")]
	private enum Boss08State : int
	{
		EntryWait = 0,
		PT1 = 1,
		PT2 = 2,
		PTBowWave = 3,
		PTBowCircle = 4,
		Destruction = 100,
	}

	[Token(Token = "0x20001C9")]
	private enum PartsKind : int
	{
		Core = 0,
		Wings = 1,
	}

	[Token(Token = "0x20001C8")]
	private enum Winds : int
	{
		P0 = 0,
		P1 = 1,
		P2 = 2,
		P3 = 3,
		P4 = 4,
		P5 = 5,
	}

	[Token(Token = "0x4000F4E")]
	private static readonly float _EntryNoHitTime; //Field offset: 0x0
	[Token(Token = "0x4000F67")]
	private const float BowWaveSpawnCount = 20; //Field offset: 0x0
	[Token(Token = "0x4000F68")]
	private const float BowWaveSpawnSeconds = 1; //Field offset: 0x0
	[Token(Token = "0x4000F69")]
	private const float BowWaveSpawnInterval = 0.05; //Field offset: 0x0
	[Token(Token = "0x4000F6A")]
	private const float BowWaveInnerAngle = -20; //Field offset: 0x0
	[Token(Token = "0x4000F6B")]
	private const float BowWaveOuterAngle = 30; //Field offset: 0x0
	[Token(Token = "0x4000F6C")]
	private const float BowWaveFireDelay = 2; //Field offset: 0x0
	[Token(Token = "0x4000F6D")]
	private const float BowCircleSpawnSeconds = 0; //Field offset: 0x0
	[Token(Token = "0x4000F63")]
	private const float PhaseTwoReturnDuration = 2; //Field offset: 0x0
	[Token(Token = "0x4000F6E")]
	private const float BowCircleCount = 60; //Field offset: 0x0
	[Token(Token = "0x4000F70")]
	private const float BowCircleArc = 6; //Field offset: 0x0
	[Token(Token = "0x4000F71")]
	private const float BowCircleArcRadius = 30; //Field offset: 0x0
	[Token(Token = "0x4000F72")]
	private const int BowCircleFireCount = 10; //Field offset: 0x0
	[Token(Token = "0x4000F73")]
	private const float BowCircleFireInterval = 0.5; //Field offset: 0x0
	[Token(Token = "0x4000F74")]
	private const float BowCircleFireDelay = 0; //Field offset: 0x0
	[Token(Token = "0x4000F77")]
	private const float HoverFrequency = 0.5; //Field offset: 0x0
	[Token(Token = "0x4000F78")]
	private const float HoverApplyTime = 1; //Field offset: 0x0
	[Token(Token = "0x4000F6F")]
	private const float BowCircleSpawnInterval = 0; //Field offset: 0x0
	[Token(Token = "0x4000F62")]
	private const float PhaseTwoArrivalThreshold = 0.1; //Field offset: 0x0
	[Token(Token = "0x4000F76")]
	private const float HoverAmplitude = 5; //Field offset: 0x0
	[Token(Token = "0x4000F60")]
	private const float PhaseTwoMaxSpeed = 150; //Field offset: 0x0
	[Token(Token = "0x4000F5F")]
	private const float PhaseTwoDecelerationDuration = 0.2; //Field offset: 0x0
	[Token(Token = "0x4000F4F")]
	private const int InvalidSeChannelId = -1; //Field offset: 0x0
	[Token(Token = "0x4000F50")]
	private const string DefaultDeadExplosionEffect = "pf_eff_explposion06"; //Field offset: 0x0
	[Token(Token = "0x4000F61")]
	private const float PhaseTwoBrakeDistance = 15; //Field offset: 0x0
	[Token(Token = "0x4000F5E")]
	private const float PhaseTwoAccelerationDuration = 0.5; //Field offset: 0x0
	[Token(Token = "0x4000F5D")]
	private const float PhaseTwoPostWaitSeconds = 1; //Field offset: 0x0
	[Token(Token = "0x4000F5C")]
	private const float PhaseTwoPreWaitSeconds = 1; //Field offset: 0x0
	[Token(Token = "0x4000F5B")]
	private const int Pattern1LoopCount = 1; //Field offset: 0x0
	[Token(Token = "0x4000F5A")]
	private const float OneRoundSecond = 12; //Field offset: 0x0
	[Token(Token = "0x4000F59")]
	private const float InfinityPathHeight = 10; //Field offset: 0x0
	[Token(Token = "0x4000F58")]
	private const float InfinityPathWidth = 60; //Field offset: 0x0
	[Token(Token = "0x4000F51")]
	private const string BossDeadExplosionEffect = "pf_eff_explposion_boss"; //Field offset: 0x0
	[Token(Token = "0x4000F52")]
	private static readonly int EntryAnimationHash; //Field offset: 0x4
	[Token(Token = "0x4000F53")]
	private static readonly String[] BossBulletTemplateNames; //Field offset: 0x8
	[Token(Token = "0x4000F54")]
	private static readonly String[] Boss08CEnemyNames; //Field offset: 0x10
	[Token(Token = "0x4000F55")]
	private static readonly Vector3 HomePosition; //Field offset: 0x18
	[Token(Token = "0x4000F56")]
	private static readonly Vector3 Boss3CPosition; //Field offset: 0x24
	[Token(Token = "0x4000F57")]
	private static readonly Vector3 Boss3COffset; //Field offset: 0x30
	[Token(Token = "0x4000F64")]
	private static readonly Vector3[] BowWaveBezierControlPoints; //Field offset: 0x40
	[Token(Token = "0x4000F65")]
	private static readonly Vector3 LeftBowOffset; //Field offset: 0x48
	[Token(Token = "0x4000F66")]
	private static readonly Vector3 RightBowOffset; //Field offset: 0x54
	[Token(Token = "0x4000F75")]
	private static readonly Vector3 BowCircleCenterOffset; //Field offset: 0x60
	[Token(Token = "0x4000F79")]
	private static readonly Quaternion[] WingBaseRotations; //Field offset: 0x70
	[Token(Token = "0x4000F7A")]
	private static readonly int WingCount; //Field offset: 0x78
	[Token(Token = "0x4000F7B")]
	private static readonly int MuzzleCount; //Field offset: 0x7C
	[FieldOffset(Offset = "0x270")]
	[FormerlySerializedAs("_wingTransform")]
	[SerializeField]
	[Token(Token = "0x4000F7C")]
	private Transform[] _wingTransforms; //Field offset: 0x270
	[FieldOffset(Offset = "0x278")]
	[SerializeField]
	[Token(Token = "0x4000F7D")]
	private ParticleSystem _hologramEffect; //Field offset: 0x278
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4000F7E")]
	private Boss08State _currentState; //Field offset: 0x280
	[FieldOffset(Offset = "0x284")]
	[Token(Token = "0x4000F7F")]
	private int _entrySeChannelId; //Field offset: 0x284
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4000F80")]
	private int _flyingSeChannelId; //Field offset: 0x288
	[FieldOffset(Offset = "0x28C")]
	[Token(Token = "0x4000F81")]
	private int _patternLoopCount; //Field offset: 0x28C
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4000F82")]
	private float _stateTimer; //Field offset: 0x290
	[FieldOffset(Offset = "0x294")]
	[Token(Token = "0x4000F83")]
	private float _modeTimer; //Field offset: 0x294
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x4000F84")]
	private float _bowArcAngle; //Field offset: 0x298
	[FieldOffset(Offset = "0x29C")]
	[Token(Token = "0x4000F85")]
	private bool _nextBowIsWave; //Field offset: 0x29C
	[FieldOffset(Offset = "0x29D")]
	[Token(Token = "0x4000F86")]
	private bool _legsOpened; //Field offset: 0x29D
	[FieldOffset(Offset = "0x29E")]
	[Token(Token = "0x4000F87")]
	private bool _isMagicCirclePlaying; //Field offset: 0x29E
	[FieldOffset(Offset = "0x29F")]
	[Token(Token = "0x4000F88")]
	private bool _hasLegCloseSequenceStarted; //Field offset: 0x29F
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x4000F89")]
	private bool _hasLegOpenSequenceStarted; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A4")]
	[Token(Token = "0x4000F8A")]
	private Quaternion _wingRotation; //Field offset: 0x2A4
	[FieldOffset(Offset = "0x2B4")]
	[Token(Token = "0x4000F8B")]
	private float _wingOpenRatio; //Field offset: 0x2B4
	[FieldOffset(Offset = "0x2B8")]
	[Token(Token = "0x4000F8C")]
	private float _currentLoopTime; //Field offset: 0x2B8
	[FieldOffset(Offset = "0x2C0")]
	[Token(Token = "0x4000F8D")]
	private Transform[] _muzzleTransforms; //Field offset: 0x2C0
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x4000F8E")]
	private Vector3 _phaseTwoTargetPosition; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2D4")]
	[Token(Token = "0x4000F8F")]
	private int _phaseTwoMoveStage; //Field offset: 0x2D4
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x4000F90")]
	private float _phaseTwoStageElapsed; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2DC")]
	[Token(Token = "0x4000F91")]
	private float _phaseTwoCurrentSpeed; //Field offset: 0x2DC
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x4000F92")]
	private float _phaseTwoDecelerationStartSpeed; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E4")]
	[Token(Token = "0x4000F93")]
	private Vector3 _phaseTwoReturnStartPosition; //Field offset: 0x2E4
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x4000F94")]
	private float _phaseTwoReturnElapsed; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F4")]
	[Token(Token = "0x4000F95")]
	private bool _hoverEnable; //Field offset: 0x2F4
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x4000F96")]
	private float _hoverTimer; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x2FC")]
	[Token(Token = "0x4000F97")]
	private Vector3 _hoverBasePosition; //Field offset: 0x2FC
	[FieldOffset(Offset = "0x308")]
	[Token(Token = "0x4000F98")]
	private float _hoverApplyRate; //Field offset: 0x308
	[FieldOffset(Offset = "0x30C")]
	[Token(Token = "0x4000F99")]
	private bool _hoverAlignPending; //Field offset: 0x30C
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x4000F9A")]
	private readonly List<InGameBulletInterface> _rightBowBullets; //Field offset: 0x310
	[FieldOffset(Offset = "0x318")]
	[Token(Token = "0x4000F9B")]
	private readonly List<InGameBulletInterface> _leftBowBullets; //Field offset: 0x318
	[FieldOffset(Offset = "0x320")]
	[Token(Token = "0x4000F9C")]
	private readonly Dictionary<InGameBulletBow, Vector3> _bowFollowerOffsets; //Field offset: 0x320
	[FieldOffset(Offset = "0x328")]
	[Token(Token = "0x4000F9D")]
	private readonly List<InGameBulletBow> _bowFollowersToRemove; //Field offset: 0x328
	[FieldOffset(Offset = "0x330")]
	[Token(Token = "0x4000F9E")]
	private bool _EntryCollisionFlag; //Field offset: 0x330
	[FieldOffset(Offset = "0x331")]
	[Token(Token = "0x4000F9F")]
	private bool _EntrySEFlag; //Field offset: 0x331

	[Address(RVA = "0x1DB30E0", Offset = "0x1DB24E0", Length = "0x5FC")]
	[Token(Token = "0x6000DCA")]
	private static Ene_Bos08B() { }

	[Address(RVA = "0x1DB36E0", Offset = "0x1DB2AE0", Length = "0x26D")]
	[Token(Token = "0x6000DC9")]
	public Ene_Bos08B() { }

	[Address(RVA = "0x1DB1CF0", Offset = "0x1DB10F0", Length = "0x2FB")]
	[CompilerGenerated]
	[Token(Token = "0x6000DCD")]
	private bool <PatternBowCircle>g__SpawnCircularBowSequence|128_0(float deltaTime) { }

	[Address(RVA = "0x1DB1FF0", Offset = "0x1DB13F0", Length = "0x8D2")]
	[CompilerGenerated]
	[Token(Token = "0x6000DCC")]
	private bool <PatternBowWave>g__SpawnWingBowSequence|126_0(float delatTime, ref <>c__DisplayClass126_0 unnamed_param_1) { }

	[Address(RVA = "0x1DB28D0", Offset = "0x1DB1CD0", Length = "0x9D")]
	[CompilerGenerated]
	[Token(Token = "0x6000DCB")]
	private void <PatternPhaseOne>g__FireWingSpreadShot|117_0() { }

	[Address(RVA = "0x1DACE00", Offset = "0x1DAC200", Length = "0xF2")]
	[Token(Token = "0x6000DAC")]
	private void ApplyDeadExplosionEffect() { }

	[Address(RVA = "0x1DACF00", Offset = "0x1DAC300", Length = "0x1A8")]
	[Token(Token = "0x6000DB5")]
	private void ApplyHover(float deltaTime) { }

	[Address(RVA = "0x1DAD0B0", Offset = "0x1DAC4B0", Length = "0x3CB")]
	[Token(Token = "0x6000DB0")]
	private void ApplyWingOpening(float openingRatio) { }

	[Address(RVA = "0x1DAD480", Offset = "0x1DAC880", Length = "0x2C")]
	[Token(Token = "0x6000DBD")]
	private void BeginPhaseTwoDeceleration() { }

	[Address(RVA = "0x1DAD4B0", Offset = "0x1DAC8B0", Length = "0x1F")]
	[Token(Token = "0x6000D9E")]
	public virtual void CallDisabled() { }

	[Address(RVA = "0x1DAD4D0", Offset = "0x1DAC8D0", Length = "0x39")]
	[Token(Token = "0x6000DA7")]
	private void ChangeState(Boss08State nextState) { }

	[Address(RVA = "0x1DAD510", Offset = "0x1DAC910", Length = "0xA8")]
	[Token(Token = "0x6000DA8")]
	private void CheckNextState() { }

	[Address(RVA = "0x1DAD5C0", Offset = "0x1DAC9C0", Length = "0x149")]
	[Token(Token = "0x6000DA0")]
	private void ClearBowBullets(bool resetBulletManager) { }

	[Address(RVA = "0x1DAD710", Offset = "0x1DACB10", Length = "0x17F")]
	[Token(Token = "0x6000DB2")]
	private bool CloseWings(float deltaTime) { }

	[Address(RVA = "0x1DAD890", Offset = "0x1DACC90", Length = "0x472")]
	[Token(Token = "0x6000DBC")]
	private bool ExecutePhaseTwoMovement(float deltaTime) { }

	[Address(RVA = "0x1DADD10", Offset = "0x1DAD110", Length = "0x53")]
	[Token(Token = "0x6000DBE")]
	private void FinalizePhaseTwoMovement() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000DAF")]
	protected virtual int GetBonusTimeKind() { }

	[Address(RVA = "0x1DADD70", Offset = "0x1DAD170", Length = "0x4F")]
	[Token(Token = "0x6000DAD")]
	protected virtual String[] GetBossBT() { }

	[Address(RVA = "0x1DADDC0", Offset = "0x1DAD1C0", Length = "0x72")]
	[Token(Token = "0x6000DAA")]
	protected virtual String[] GetBossCD() { }

	[Address(RVA = "0x5AA980", Offset = "0x5A9D80", Length = "0x4A")]
	[Token(Token = "0x6000DC8")]
	protected virtual Vector3 GetDifferenceVector() { }

	[Address(RVA = "0x1D7E390", Offset = "0x1D7D790", Length = "0x2E")]
	[Token(Token = "0x6000DAE")]
	private Transform GetMuzzle(Boss08BMZ muzzleKind) { }

	[Address(RVA = "0x1DADE40", Offset = "0x1DAD240", Length = "0xC5")]
	[Token(Token = "0x6000DC7")]
	protected virtual Vector3 GetSmallBombPosition() { }

	[Address(RVA = "0x1DADF10", Offset = "0x1DAD310", Length = "0x56")]
	[Token(Token = "0x6000D9C")]
	public virtual void GetStart() { }

	[Address(RVA = "0x1DADF70", Offset = "0x1DAD370", Length = "0x14B")]
	[Token(Token = "0x6000DC6")]
	private void HandleDestroyedResult() { }

	[Address(RVA = "0x1DAE0C0", Offset = "0x1DAD4C0", Length = "0x471")]
	[Token(Token = "0x6000D9A")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1DAE540", Offset = "0x1DAD940", Length = "0x17")]
	[Token(Token = "0x6000DB6")]
	private bool IsHoverStopped() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000DA6")]
	public virtual bool IsPoseRecord() { }

	[Address(RVA = "0x1DAE560", Offset = "0x1DAD960", Length = "0x233")]
	[Token(Token = "0x6000DBF")]
	private void MovePhaseTwoTowardsTarget(float deltaTime) { }

	[Address(RVA = "0x1DAE7A0", Offset = "0x1DADBA0", Length = "0x187")]
	[Token(Token = "0x6000DB3")]
	private bool OpenWings(float deltaTime) { }

	[Address(RVA = "0x1DAE930", Offset = "0x1DADD30", Length = "0x5CC")]
	[Token(Token = "0x6000DC3")]
	private void PatternBowCircle(float deltaTime) { }

	[Address(RVA = "0x1DAEF00", Offset = "0x1DAE300", Length = "0x24D")]
	[Token(Token = "0x6000DC1")]
	private void PatternBowWave(float deltaTime) { }

	[Address(RVA = "0x1DAF150", Offset = "0x1DAE550", Length = "0xA1F")]
	[Token(Token = "0x6000DC5")]
	private void PatternDestruction(float deltaTime) { }

	[Address(RVA = "0x1DAFB70", Offset = "0x1DAEF70", Length = "0x532")]
	[Token(Token = "0x6000DB7")]
	private void PatternEntryWait(float deltaTime) { }

	[Address(RVA = "0x1DB00B0", Offset = "0x1DAF4B0", Length = "0x3BD")]
	[Token(Token = "0x6000DB8")]
	private void PatternPhaseOne(float deltaTime) { }

	[Address(RVA = "0x1DB0470", Offset = "0x1DAF870", Length = "0x2B6")]
	[Token(Token = "0x6000DB9")]
	private void PatternPhaseTwo(float deltaTime) { }

	[Address(RVA = "0x1DB0730", Offset = "0x1DAFB30", Length = "0x137")]
	[Token(Token = "0x6000DBB")]
	private void PreparePhaseTwoTarget() { }

	[Address(RVA = "0x1DB09D0", Offset = "0x1DAFDD0", Length = "0x1BA")]
	[Token(Token = "0x6000DA1")]
	private void RegisterBowFollower(InGameBulletBow bullet) { }

	[Address(RVA = "0x1DB0B90", Offset = "0x1DAFF90", Length = "0x39A")]
	[Token(Token = "0x6000DA2")]
	private void RegisterBowFollowers(IEnumerable<InGameBulletInterface> bullets) { }

	[Address(RVA = "0x1DB0F30", Offset = "0x1DB0330", Length = "0x1F4")]
	[Token(Token = "0x6000DB4")]
	private void ResetHover() { }

	[Address(RVA = "0x1DB1130", Offset = "0x1DB0530", Length = "0x20")]
	[Token(Token = "0x6000DBA")]
	private void ResetPhaseTwoMovementState() { }

	[Address(RVA = "0x1DB0870", Offset = "0x1DAFC70", Length = "0x15D")]
	[Token(Token = "0x6000D9B")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1DB1150", Offset = "0x1DB0550", Length = "0x206")]
	[Token(Token = "0x6000DC0")]
	private bool ReturnToHomePosition(float deltaTime) { }

	[Address(RVA = "0x1DB1360", Offset = "0x1DB0760", Length = "0xB6")]
	[Token(Token = "0x6000DA5")]
	private void SetMagicCircleActive(bool isActive) { }

	[Address(RVA = "0x1DB1420", Offset = "0x1DB0820", Length = "0xAA")]
	[Token(Token = "0x6000DAB")]
	private bool ShouldCreateBossC() { }

	[Address(RVA = "0x1DB14D0", Offset = "0x1DB08D0", Length = "0x1A7")]
	[Token(Token = "0x6000DC2")]
	private List<InGameBulletInterface> SpawnBowBullets(Vector3 worldPos, Vector3 offset, float startArc) { }

	[Address(RVA = "0x1DB1680", Offset = "0x1DB0A80", Length = "0x5A")]
	[Token(Token = "0x6000DA9")]
	protected virtual void StateExec(float deltaTime) { }

	[Address(RVA = "0x1DB16E0", Offset = "0x1DB0AE0", Length = "0xA3")]
	[Token(Token = "0x6000D9F")]
	private void StopLoopingSeChannels() { }

	[Address(RVA = "0x1DB1790", Offset = "0x1DB0B90", Length = "0x116")]
	[Token(Token = "0x6000D9D")]
	public virtual void ToDestroid() { }

	[Address(RVA = "0x1DB18B0", Offset = "0x1DB0CB0", Length = "0x431")]
	[Token(Token = "0x6000DC4")]
	private bool TriggerBowBullet(int count) { }

	[Address(RVA = "0x1DB2970", Offset = "0x1DB1D70", Length = "0x89")]
	[Token(Token = "0x6000DA3")]
	private void UnregisterBowFollower(InGameBulletBow bullet) { }

	[Address(RVA = "0x1DB2A00", Offset = "0x1DB1E00", Length = "0x4F5")]
	[Token(Token = "0x6000DA4")]
	private void UpdateBowFollowerPositions() { }

	[Address(RVA = "0x1DB2F00", Offset = "0x1DB2300", Length = "0x1D4")]
	[Token(Token = "0x6000DB1")]
	private void UpdateWingRotation(float deltaTime) { }

}

