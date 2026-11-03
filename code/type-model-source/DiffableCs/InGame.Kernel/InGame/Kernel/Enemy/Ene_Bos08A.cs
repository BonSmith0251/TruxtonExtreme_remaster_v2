namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001BA")]
public class Ene_Bos08A : Ene_BosBase
{
	[CompilerGenerated]
	[Token(Token = "0x20001C3")]
	private sealed class <>c__DisplayClass49_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000F4B")]
		public Ene_Bos08A <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000F4C")]
		public Transform armTop; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000F4D")]
		public Action <>9__0; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000D98")]
		public <>c__DisplayClass49_0() { }

		[Address(RVA = "0x1DB8D30", Offset = "0x1DB8130", Length = "0xAA")]
		[Token(Token = "0x6000D99")]
		internal void <OnPartsBreak>b__0() { }

	}

	[Token(Token = "0x20001C1")]
	private sealed class BossArm
	{
		[CompilerGenerated]
		[Token(Token = "0x20001C2")]
		private struct <ExecuteRoutineAsync>d__12 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000F3B")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000F3C")]
			public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000F3D")]
			public BossArm <>4__this; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000F3E")]
			public float startDelay; //Field offset: 0x20
			[FieldOffset(Offset = "0x24")]
			[Token(Token = "0x4000F3F")]
			public float attackDuration; //Field offset: 0x24
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4000F40")]
			public float firstShotDelay; //Field offset: 0x28
			[FieldOffset(Offset = "0x2C")]
			[Token(Token = "0x4000F41")]
			public float rotationAmplitude; //Field offset: 0x2C
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x4000F42")]
			public float rotationFrequency; //Field offset: 0x30
			[FieldOffset(Offset = "0x34")]
			[Token(Token = "0x4000F43")]
			public float rotationDirectionSign; //Field offset: 0x34
			[FieldOffset(Offset = "0x38")]
			[Token(Token = "0x4000F44")]
			private EnePartsGroup <parts>5__2; //Field offset: 0x38
			[FieldOffset(Offset = "0x40")]
			[Token(Token = "0x4000F45")]
			private Transform <muzzle>5__3; //Field offset: 0x40
			[FieldOffset(Offset = "0x48")]
			[Token(Token = "0x4000F46")]
			private BulletTemplate <bulletTemplate>5__4; //Field offset: 0x48
			[FieldOffset(Offset = "0x50")]
			[Token(Token = "0x4000F47")]
			private float <totalDuration>5__5; //Field offset: 0x50
			[FieldOffset(Offset = "0x54")]
			[Token(Token = "0x4000F48")]
			private float <elapsed>5__6; //Field offset: 0x54
			[FieldOffset(Offset = "0x58")]
			[Token(Token = "0x4000F49")]
			private Awaiter <>u__1; //Field offset: 0x58
			[FieldOffset(Offset = "0x68")]
			[Token(Token = "0x4000F4A")]
			private float <wait>5__7; //Field offset: 0x68

			[Address(RVA = "0x1DB7920", Offset = "0x1DB6D20", Length = "0x12F0")]
			[Token(Token = "0x6000D96")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x6000D97")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000F36")]
		private readonly Ene_Bos08A _owner; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000F37")]
		private readonly BossPartId _partId; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000F38")]
		private readonly BossMuzzleId _muzzleId; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000F39")]
		private readonly Animator _animator; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000F3A")]
		private bool _isActive; //Field offset: 0x28

		[Token(Token = "0x170001F1")]
		public bool IsActive
		{
			[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
			[Token(Token = "0x6000D90")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170001F2")]
		public bool IsBroken
		{
			[Address(RVA = "0x1DA07A0", Offset = "0x1D9FBA0", Length = "0x38")]
			[Token(Token = "0x6000D91")]
			 get { } //Length: 56
		}

		[Address(RVA = "0x1DA0730", Offset = "0x1D9FB30", Length = "0x63")]
		[Token(Token = "0x6000D92")]
		public BossArm(Ene_Bos08A owner, BossPartId partId, BossMuzzleId muzzleId, Animator animator) { }

		[Address(RVA = "0x1DA0480", Offset = "0x1D9F880", Length = "0x67")]
		[Token(Token = "0x6000D94")]
		public UniTask ExecuteAsync(float startDelay, float attackDuration, float firstShotDelay, float rotationAmplitude, float rotationFrequency, float rotationDirectionSign) { }

		[Address(RVA = "0x1DA04F0", Offset = "0x1D9F8F0", Length = "0x239")]
		[AsyncStateMachine(typeof(<ExecuteRoutineAsync>d__12))]
		[Token(Token = "0x6000D95")]
		private UniTask ExecuteRoutineAsync(float startDelay, float attackDuration, float firstShotDelay, float rotationAmplitude, float rotationFrequency, float rotationDirectionSign) { }

		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x6000D90")]
		public bool get_IsActive() { }

		[Address(RVA = "0x1DA07A0", Offset = "0x1D9FBA0", Length = "0x38")]
		[Token(Token = "0x6000D91")]
		public bool get_IsBroken() { }

		[Address(RVA = "0x1CFEBC0", Offset = "0x1CFDFC0", Length = "0x5")]
		[Token(Token = "0x6000D93")]
		public void Reset() { }

	}

	[Token(Token = "0x20001BF")]
	private enum BossBulletTemplate : int
	{
		Arm = 0,
		Cover = 1,
		CoverBroken = 2,
	}

	[Token(Token = "0x20001BD")]
	private enum BossMuzzleId : int
	{
		muzzle_arm_pos01 = 0,
		muzzle_arm_pos03 = 1,
		muzzle_arm_pos04 = 2,
		muzzle_arm_pos06 = 3,
		muzzle_arm_pos07 = 4,
		muzzle_arm_pos09 = 5,
		muzzle_cover_01_1 = 6,
		muzzle_cover_01_2 = 7,
		muzzle_cover_03_1 = 8,
		muzzle_cover_03_2 = 9,
		muzzle_cover_07_1 = 10,
		muzzle_cover_07_2 = 11,
		muzzle_cover_09_1 = 12,
		muzzle_cover_09_2 = 13,
		muzzle_cover_center = 14,
	}

	[Token(Token = "0x20001BE")]
	private enum BossPartId : int
	{
		Cover01 = 0,
		Cover03 = 1,
		Cover07 = 2,
		Cover09 = 3,
		Arm1 = 4,
		Arm3 = 5,
		Arm4 = 6,
		Arm6 = 7,
		Arm7 = 8,
		Arm9 = 9,
		Core = 10,
	}

	[Token(Token = "0x20001BB")]
	private enum BossState : int
	{
		EntryWait = 0,
		PT2 = 1,
		Turn = 2,
		Destruction = 100,
	}

	[IsReadOnly]
	[Token(Token = "0x20001C0")]
	private struct CoverSideConfig
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F34")]
		public readonly BossPartId[] PartIds; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000F35")]
		public readonly BossMuzzleId[][] MuzzleGroups; //Field offset: 0x8

		[Address(RVA = "0x60E3C0", Offset = "0x60D7C0", Length = "0x32")]
		[Token(Token = "0x6000D8F")]
		public CoverSideConfig(BossPartId[] partIds, BossMuzzleId[][] muzzleGroups) { }

	}

	[Flags]
	[Token(Token = "0x20001BC")]
	private enum LeavingEffectFlag : int
	{
		None = 0,
		SE0 = 1,
		SE1 = 2,
		SE2 = 4,
		Out = 65536,
	}

	[Token(Token = "0x4000ED0")]
	private const int ActiveArmCount = 4; //Field offset: 0x0
	[Token(Token = "0x4000ED1")]
	private const int ReverseArmBaseIndex = 2; //Field offset: 0x0
	[Token(Token = "0x4000ED2")]
	private static readonly int TotalMuzzleCount; //Field offset: 0x0
	[Token(Token = "0x4000ED6")]
	public const int ArmIndexFrontLeft = 0; //Field offset: 0x0
	[Token(Token = "0x4000ED7")]
	public const int ArmIndexFrontRight = 1; //Field offset: 0x0
	[Token(Token = "0x4000ED8")]
	public const int ArmIndexMidLeft = 2; //Field offset: 0x0
	[Token(Token = "0x4000ED9")]
	public const int ArmIndexMidRight = 3; //Field offset: 0x0
	[Token(Token = "0x4000EDA")]
	public const int ArmIndexBackLeft = 4; //Field offset: 0x0
	[Token(Token = "0x4000EDB")]
	public const int ArmIndexBackRight = 5; //Field offset: 0x0
	[Token(Token = "0x4000ED3")]
	private static readonly int ArmIdleStateHash; //Field offset: 0x4
	[Token(Token = "0x4000ED4")]
	private static readonly int ArmAttackStateHash; //Field offset: 0x8
	[Token(Token = "0x4000ED5")]
	private static readonly String[] BulletTemplateNames; //Field offset: 0x10
	[Token(Token = "0x4000EDC")]
	private static readonly BossPartId[] ArmPartOrder; //Field offset: 0x18
	[Token(Token = "0x4000EDD")]
	private static readonly BossPartId[] CoverPartIds; //Field offset: 0x20
	[Token(Token = "0x4000EDE")]
	private static readonly BossMuzzleId[] ArmMuzzleOrder; //Field offset: 0x28
	[Token(Token = "0x4000EDF")]
	private static readonly EnemyChildData[] ChildEnemyDefinitions; //Field offset: 0x30
	[Token(Token = "0x4000EE0")]
	private static readonly String[] BossClipNames; //Field offset: 0x38
	[Token(Token = "0x4000EE1")]
	private static readonly String[] BossRouteNames; //Field offset: 0x40
	[Token(Token = "0x4000EEF")]
	private static readonly float _armAttackDurationSeconds; //Field offset: 0x48
	[Token(Token = "0x4000EF0")]
	private static readonly float _armAttackCooldownSeconds; //Field offset: 0x4C
	[Token(Token = "0x4000EF1")]
	private static readonly float _frontCoverShotIntervalSeconds; //Field offset: 0x50
	[Token(Token = "0x4000EF2")]
	private static readonly float _backCoverShotIntervalSeconds; //Field offset: 0x54
	[Token(Token = "0x4000EF3")]
	private static readonly float _armFirstShotDelaySeconds; //Field offset: 0x58
	[Token(Token = "0x4000EF4")]
	private static readonly float _armShotIntervalSeconds; //Field offset: 0x5C
	[Token(Token = "0x4000EF5")]
	private static readonly float _armRotationAmplitudeDeg; //Field offset: 0x60
	[Token(Token = "0x4000EF6")]
	private static readonly float _armRotationFrequencyHz; //Field offset: 0x64
	[Token(Token = "0x4000EF7")]
	private static readonly float _armAttackAnimationWait; //Field offset: 0x68
	[Token(Token = "0x4000EF8")]
	private static readonly int FA1; //Field offset: 0x6C
	[Token(Token = "0x4000EF9")]
	private static readonly int FA2; //Field offset: 0x70
	[Token(Token = "0x4000EFA")]
	private static readonly int FA3; //Field offset: 0x74
	[Token(Token = "0x4000EFB")]
	private static readonly int FA4; //Field offset: 0x78
	[Token(Token = "0x4000EFC")]
	private static readonly Int32[][] FrontArmAttackSequence; //Field offset: 0x80
	[Token(Token = "0x4000EFD")]
	private static readonly int BA1; //Field offset: 0x88
	[Token(Token = "0x4000EFE")]
	private static readonly int BA2; //Field offset: 0x8C
	[Token(Token = "0x4000EFF")]
	private static readonly int BA3; //Field offset: 0x90
	[Token(Token = "0x4000F00")]
	private static readonly int BA4; //Field offset: 0x94
	[Token(Token = "0x4000F01")]
	private static readonly Int32[][] BackArmAttackSequence; //Field offset: 0x98
	[Token(Token = "0x4000F02")]
	private static readonly BossPartId[] FrontCoverPartOrder; //Field offset: 0xA0
	[Token(Token = "0x4000F03")]
	private static readonly BossPartId[] BackCoverPartOrder; //Field offset: 0xA8
	[Token(Token = "0x4000F04")]
	private static readonly BossMuzzleId[][] FrontCoverMuzzleOrder; //Field offset: 0xB0
	[Token(Token = "0x4000F05")]
	private static readonly BossMuzzleId[][] BackCoverMuzzleOrder; //Field offset: 0xB8
	[Token(Token = "0x4000F06")]
	private static readonly CoverSideConfig FrontCoverConfig; //Field offset: 0xC0
	[Token(Token = "0x4000F07")]
	private static readonly CoverSideConfig BackCoverConfig; //Field offset: 0xD0
	[Token(Token = "0x4000F08")]
	private static readonly int CorePurgeAnimeHash; //Field offset: 0xE0
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4000EE2")]
	private BossState _currentState; //Field offset: 0x270
	[FieldOffset(Offset = "0x274")]
	[Token(Token = "0x4000EE3")]
	private float _stateTimer; //Field offset: 0x274
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4000EE4")]
	private bool _isReversed; //Field offset: 0x278
	[FieldOffset(Offset = "0x27C")]
	[Token(Token = "0x4000EE5")]
	private LeavingEffectFlag _leavingEffectFlag; //Field offset: 0x27C
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4000EE6")]
	private Transform[] _muzzlePoints; //Field offset: 0x280
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4000EE7")]
	private BossArm[] _arms; //Field offset: 0x288
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4000EE8")]
	private int _armPatternIndex; //Field offset: 0x290
	[FieldOffset(Offset = "0x294")]
	[Token(Token = "0x4000EE9")]
	private bool _isArmPatternLooped; //Field offset: 0x294
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x4000EEA")]
	private int _backCoverShotIndex; //Field offset: 0x298
	[FieldOffset(Offset = "0x29C")]
	[Token(Token = "0x4000EEB")]
	private float _coverShotTimer; //Field offset: 0x29C
	[FieldOffset(Offset = "0x2A0")]
	[SerializeField]
	[Token(Token = "0x4000EEC")]
	private Animator[] _armAnimes; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A8")]
	[SerializeField]
	[Token(Token = "0x4000EED")]
	private Animator _coreAnime; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2B0")]
	[SerializeField]
	[Token(Token = "0x4000EEE")]
	private GameObject _bodyTop; //Field offset: 0x2B0

	[Token(Token = "0x170001F0")]
	private Int32[][] CurrentArmAttackSequence
	{
		[Address(RVA = "0x1DACD70", Offset = "0x1DAC170", Length = "0x8D")]
		[Token(Token = "0x6000D73")]
		private get { } //Length: 141
	}

	[Address(RVA = "0x1DACC80", Offset = "0x1DAC080", Length = "0xEC")]
	[Token(Token = "0x6000D8B")]
	private bool _destroyedResult() { }

	[Address(RVA = "0x1DABC30", Offset = "0x1DAB030", Length = "0xFF9")]
	[Token(Token = "0x6000D8E")]
	private static Ene_Bos08A() { }

	[Address(RVA = "0x1DACC30", Offset = "0x1DAC030", Length = "0x49")]
	[Token(Token = "0x6000D8D")]
	public Ene_Bos08A() { }

	[Address(RVA = "0x1DA8010", Offset = "0x1DA7410", Length = "0x84")]
	[Token(Token = "0x6000D7D")]
	private void AdvanceArmPatternIndex() { }

	[Address(RVA = "0x1DA80A0", Offset = "0x1DA74A0", Length = "0x15E")]
	[Token(Token = "0x6000D6B")]
	private void BreakRemainingCovers() { }

	[Address(RVA = "0x1DA8200", Offset = "0x1DA7600", Length = "0xEB")]
	[Token(Token = "0x6000D68")]
	private void CheckNextState() { }

	[Address(RVA = "0x1DA82F0", Offset = "0x1DA76F0", Length = "0x186")]
	[Token(Token = "0x6000D81")]
	private void FireBackCoverShotSequential(BulletTemplate bulletTemplate) { }

	[Address(RVA = "0x1DA8480", Offset = "0x1DA7880", Length = "0x11A")]
	[Token(Token = "0x6000D85")]
	private void FireCoverMuzzleGroup(BossMuzzleId[] muzzleGroup, BulletTemplate bulletTemplate) { }

	[Address(RVA = "0x1DA85A0", Offset = "0x1DA79A0", Length = "0x2D4")]
	[Token(Token = "0x6000D7F")]
	private void FireCoverShotBurst() { }

	[Address(RVA = "0x1DA8880", Offset = "0x1DA7C80", Length = "0x10C")]
	[Token(Token = "0x6000D80")]
	private void FireCoverShotForSide(CoverSideConfig coverConfig, BulletTemplate bulletTemplate) { }

	[Address(RVA = "0x1DACD70", Offset = "0x1DAC170", Length = "0x8D")]
	[Token(Token = "0x6000D73")]
	private Int32[][] get_CurrentArmAttackSequence() { }

	[Address(RVA = "0x1DA8990", Offset = "0x1DA7D90", Length = "0x4F")]
	[Token(Token = "0x6000D71")]
	protected virtual String[] GetBossBT() { }

	[Address(RVA = "0x1DA89E0", Offset = "0x1DA7DE0", Length = "0x4F")]
	[Token(Token = "0x6000D6F")]
	protected virtual String[] GetBossCD() { }

	[Address(RVA = "0x1DA8A30", Offset = "0x1DA7E30", Length = "0xD2")]
	[Token(Token = "0x6000D87")]
	private float GetCoverShotIntervalSeconds() { }

	[Address(RVA = "0x1DA8B10", Offset = "0x1DA7F10", Length = "0xAA")]
	[Token(Token = "0x6000D84")]
	private CoverSideConfig GetCurrentCoverSideConfig() { }

	[Address(RVA = "0x1DA11D0", Offset = "0x1DA05D0", Length = "0x2E")]
	[Token(Token = "0x6000D72")]
	private Transform GetMuzzle(BossMuzzleId muzzleId) { }

	[Address(RVA = "0x1DA8BC0", Offset = "0x1DA7FC0", Length = "0x2A")]
	[Token(Token = "0x6000D88")]
	private float GetRotationSignForArm(int armIndex) { }

	[Address(RVA = "0x1DA8BF0", Offset = "0x1DA7FF0", Length = "0x8A")]
	[Token(Token = "0x6000D70")]
	public virtual List<String> GetRouteNames() { }

	[Address(RVA = "0x1DA8C80", Offset = "0x1DA8080", Length = "0x6D")]
	[Token(Token = "0x6000D8C")]
	protected virtual Vector3 GetSmallBombPosition() { }

	[Address(RVA = "0x1DA8CF0", Offset = "0x1DA80F0", Length = "0xF8")]
	[Token(Token = "0x6000D82")]
	private bool HasAnyActiveCoverOnCurrentSide() { }

	[Address(RVA = "0x1DA8DF0", Offset = "0x1DA81F0", Length = "0xED")]
	[Token(Token = "0x6000D7E")]
	private bool HasAnyAttackableArm() { }

	[Address(RVA = "0x1DA8EE0", Offset = "0x1DA82E0", Length = "0x80")]
	[Token(Token = "0x6000D75")]
	private bool HasAvailableMuzzle(BossMuzzleId[] muzzleGroup) { }

	[Address(RVA = "0x1DA8F70", Offset = "0x1DA8370", Length = "0x5AE")]
	[Token(Token = "0x6000D62")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1DA9520", Offset = "0x1DA8920", Length = "0x8C")]
	[Token(Token = "0x6000D83")]
	private bool IsAnyCoverAvailable(CoverSideConfig coverConfig) { }

	[Address(RVA = "0x1DA95B0", Offset = "0x1DA89B0", Length = "0x54")]
	[Token(Token = "0x6000D7B")]
	private bool IsArmAttackRunning() { }

	[Address(RVA = "0x1DA9610", Offset = "0x1DA8A10", Length = "0x25")]
	[Token(Token = "0x6000D86")]
	private bool IsCoverAvailable(BossPartId coverPart) { }

	[Address(RVA = "0x1DA9640", Offset = "0x1DA8A40", Length = "0x24")]
	[Token(Token = "0x6000D6C")]
	private bool IsPartBroken(BossPartId partId) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000D65")]
	public virtual bool IsPoseRecord() { }

	[Address(RVA = "0x1DA9670", Offset = "0x1DA8A70", Length = "0x73")]
	[Token(Token = "0x6000D6D")]
	private bool IsReverseMove() { }

	[Address(RVA = "0x1DA96F0", Offset = "0x1DA8AF0", Length = "0x81")]
	[Token(Token = "0x6000D78")]
	private bool IsStoppedArea() { }

	[Address(RVA = "0x1DA9780", Offset = "0x1DA8B80", Length = "0x6D8")]
	[Token(Token = "0x6000D66")]
	public virtual void OnPartsBreak(int parts) { }

	[Address(RVA = "0x1DA9E70", Offset = "0x1DA9270", Length = "0x496")]
	[Token(Token = "0x6000D79")]
	private void PatternMove2(float dt) { }

	[Address(RVA = "0x1DAA310", Offset = "0x1DA9710", Length = "0x8BB")]
	[Token(Token = "0x6000D8A")]
	private void PatternMoveDestruction(float dt) { }

	[Address(RVA = "0x1DAABD0", Offset = "0x1DA9FD0", Length = "0x167")]
	[Token(Token = "0x6000D74")]
	private void PatternMoveEntryWait(float dt) { }

	[Address(RVA = "0x1DAAD40", Offset = "0x1DAA140", Length = "0x2F2")]
	[Token(Token = "0x6000D89")]
	private void PatternMoveTurn(float dt) { }

	[Address(RVA = "0x1DAB1D0", Offset = "0x1DAA5D0", Length = "0x66")]
	[Token(Token = "0x6000D6A")]
	private void ResetArmStatus() { }

	[Address(RVA = "0x1DAB040", Offset = "0x1DAA440", Length = "0x184")]
	[Token(Token = "0x6000D63")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1DAB240", Offset = "0x1DAA640", Length = "0x39")]
	[Token(Token = "0x6000D67")]
	private void SetState(BossState nextState) { }

	[Address(RVA = "0x1DAB280", Offset = "0x1DAA680", Length = "0x1B9")]
	[Token(Token = "0x6000D69")]
	protected virtual void StateExec(float dt) { }

	[Address(RVA = "0x1DAB440", Offset = "0x1DAA840", Length = "0x4F")]
	[Token(Token = "0x6000D6E")]
	public virtual EnemyChildData[] SubEnemys() { }

	[Address(RVA = "0x1DAB490", Offset = "0x1DAA890", Length = "0x224")]
	[Token(Token = "0x6000D64")]
	public virtual void ToDestroid() { }

	[Address(RVA = "0x1DAB6C0", Offset = "0x1DAAAC0", Length = "0x14A")]
	[Token(Token = "0x6000D7A")]
	private bool TryBeginArmAttack() { }

	[Address(RVA = "0x1DAB810", Offset = "0x1DAAC10", Length = "0x108")]
	[Token(Token = "0x6000D76")]
	private bool TryGetAvailableMuzzle(BossMuzzleId muzzleId, out Transform muzzle) { }

	[Address(RVA = "0x1DAB940", Offset = "0x1DAAD40", Length = "0x18")]
	[Token(Token = "0x6000D77")]
	private bool TryGetCoverPartFromMuzzle(BossMuzzleId muzzleId, out BossPartId coverPart) { }

	[Address(RVA = "0x1DAB9C0", Offset = "0x1DAADC0", Length = "0x263")]
	[Token(Token = "0x6000D7C")]
	private bool TryStartArmPattern() { }

}

