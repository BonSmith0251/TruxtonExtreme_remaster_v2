namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001D3")]
public abstract class Ene_BosBase : PawnEnemy
{
	[CompilerGenerated]
	[Token(Token = "0x20001D6")]
	private struct <ChangeBaseColor>d__47 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400104A")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400104B")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400104C")]
		public Ene_BosBase <>4__this; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400104D")]
		public float twait; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400104E")]
		public float tsecond; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400104F")]
		public bool isDark; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4001050")]
		public Color color; //Field offset: 0x2C
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4001051")]
		private float <tpassed>5__2; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4001052")]
		private Awaiter <>u__1; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4001053")]
		private Awaiter <>u__2; //Field offset: 0x50

		[Address(RVA = "0x1DD0930", Offset = "0x1DCFD30", Length = "0x50C")]
		[Token(Token = "0x6000E49")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000E4A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001D7")]
	private struct <DamageTurn>d__50 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001054")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001055")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001056")]
		public Ene_BosBase <>4__this; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001057")]
		public Quaternion trot; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001058")]
		public float tsecond; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4001059")]
		public Action _callback; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400105A")]
		private float <tpassed>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x400105B")]
		private Quaternion <baserot>5__3; //Field offset: 0x44
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x400105C")]
		private Quaternion <nrot>5__4; //Field offset: 0x54
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x400105D")]
		private Awaiter <>u__1; //Field offset: 0x64

		[Address(RVA = "0x1DD0E40", Offset = "0x1DD0240", Length = "0x5A8")]
		[Token(Token = "0x6000E4B")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000E4C")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x20001D4")]
	internal enum HitPState : int
	{
		FullHP = 0,
		HigherHP = 1,
		HighHP = 2,
		HalfHP = 3,
		LowHP = 4,
		LowerHP = 5,
		LowestHP = 6,
		LessHP = 7,
		ZeroHP = 8,
	}

	[Token(Token = "0x20001D5")]
	internal enum TimeSteps : int
	{
		Start = 0,
		Passed10 = 1,
		Passed20 = 2,
		Passed30 = 3,
		Passed40 = 4,
		Passed50 = 5,
		Passed60 = 6,
		Passed70 = 7,
		Passed80 = 8,
		Passed90 = 9,
		Passed100 = 10,
		Passed110 = 11,
		Passed120 = 12,
		Passed130 = 13,
		Passed140 = 14,
		Passed150 = 15,
		Passed160 = 16,
		Passed170 = 17,
		TimeOver = 18,
		PassedHalf = 9,
		PassedOneThird = 6,
		Last60 = 12,
		Last30 = 15,
	}

	[Token(Token = "0x400101E")]
	private static readonly Single[] hpRateRanges; //Field offset: 0x0
	[Token(Token = "0x400101F")]
	private static readonly int hpRateRangeCount; //Field offset: 0x8
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4001001")]
	private bool _isBossDead; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B1")]
	[Token(Token = "0x4001002")]
	private bool _isDamageTurned; //Field offset: 0x1B1
	[FieldOffset(Offset = "0x1B2")]
	[Token(Token = "0x4001003")]
	private bool _isBossTimeStart; //Field offset: 0x1B2
	[FieldOffset(Offset = "0x1B3")]
	[Token(Token = "0x4001004")]
	private bool _isDeadEffectCalled; //Field offset: 0x1B3
	[FieldOffset(Offset = "0x1B4")]
	[Token(Token = "0x4001005")]
	private bool _isDirectionPause; //Field offset: 0x1B4
	[FieldOffset(Offset = "0x1B5")]
	[Token(Token = "0x4001006")]
	private bool _isPlayerSideLeft; //Field offset: 0x1B5
	[FieldOffset(Offset = "0x1B6")]
	[Token(Token = "0x4001007")]
	private bool _isPlayerSideDown; //Field offset: 0x1B6
	[FieldOffset(Offset = "0x1B7")]
	[Token(Token = "0x4001008")]
	private bool _isPlayerSideCenter; //Field offset: 0x1B7
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4001009")]
	private bool _isPlayerSideBottom; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1BC")]
	[Token(Token = "0x400100A")]
	private float _bossAliveTime; //Field offset: 0x1BC
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x400100B")]
	private float _bossActionUpTime; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C4")]
	[Token(Token = "0x400100C")]
	private float _directionTimeTotal; //Field offset: 0x1C4
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x400100D")]
	private float _directionTimePassed; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1CC")]
	[Token(Token = "0x400100E")]
	private float _directionTimeScale; //Field offset: 0x1CC
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x400100F")]
	private float _repeatTimer; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D4")]
	[Token(Token = "0x4001010")]
	private float _repeatPassed; //Field offset: 0x1D4
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4001011")]
	private int _repeatTimes; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1DC")]
	[Token(Token = "0x4001012")]
	private bool _repeatLaped; //Field offset: 0x1DC
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4001013")]
	private float _smallBombBaseSecond; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E4")]
	[Token(Token = "0x4001014")]
	private float _smallBombCurrent; //Field offset: 0x1E4
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4001015")]
	private int _attackLoopCount; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1EC")]
	[Token(Token = "0x4001016")]
	protected int _patternMode; //Field offset: 0x1EC
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4001017")]
	private Vector3 _baseTargetPlayer; //Field offset: 0x1F0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1FC")]
	[Token(Token = "0x4001018")]
	private int <_enemyDataCount>k__BackingField; //Field offset: 0x1FC
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4001019")]
	protected EnemyData[] _enemyDatas; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x400101A")]
	protected BulletTemplate[] btemplates; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x400101B")]
	private PlayMode _currentPlayMode; //Field offset: 0x210
	[FieldOffset(Offset = "0x214")]
	[Token(Token = "0x400101C")]
	private PlayActor _currentActor; //Field offset: 0x214
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x400101D")]
	private bool _isTraining; //Field offset: 0x218
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4001020")]
	private HitPState _hpState; //Field offset: 0x21C
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4001021")]
	private HitPState _hpOldState; //Field offset: 0x220
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x4001022")]
	private TimeSteps _currentActStep; //Field offset: 0x224
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4001023")]
	protected Vector3 _startInGamePosition; //Field offset: 0x228
	[FieldOffset(Offset = "0x234")]
	[Token(Token = "0x4001024")]
	protected Vector3 _startVector; //Field offset: 0x234
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4001025")]
	protected Vector3 _targetVector; //Field offset: 0x240
	[FieldOffset(Offset = "0x24C")]
	[Token(Token = "0x4001026")]
	protected Quaternion _startAngle; //Field offset: 0x24C
	[FieldOffset(Offset = "0x25C")]
	[Token(Token = "0x4001027")]
	protected Quaternion _targetAngle; //Field offset: 0x25C

	[Token(Token = "0x170001FE")]
	protected private int _enemyDataCount
	{
		[Address(RVA = "0x1DBB2E0", Offset = "0x1DBA6E0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000E36")]
		 get { } //Length: 7
		[Address(RVA = "0x1D17FD0", Offset = "0x1D173D0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000E37")]
		private set { } //Length: 7
	}

	[Token(Token = "0x170001FD")]
	protected Vector3 BaseTargetSkyPosition
	{
		[Address(RVA = "0x1DBB110", Offset = "0x1DBA510", Length = "0x19")]
		[Token(Token = "0x6000E35")]
		 get { } //Length: 25
	}

	[Token(Token = "0x170001FA")]
	public float BossAliveTime
	{
		[Address(RVA = "0x1DBB130", Offset = "0x1DBA530", Length = "0x9")]
		[Token(Token = "0x6000E32")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000208")]
	protected PlayActor GetPlayActor
	{
		[Address(RVA = "0x1DBB140", Offset = "0x1DBA540", Length = "0x7")]
		[Token(Token = "0x6000E41")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000209")]
	protected HitPState HpState
	{
		[Address(RVA = "0x1DBB150", Offset = "0x1DBA550", Length = "0x7")]
		[Token(Token = "0x6000E42")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000206")]
	protected bool IsArcade
	{
		[Address(RVA = "0x1DBB160", Offset = "0x1DBA560", Length = "0xB")]
		[Token(Token = "0x6000E3F")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170001F3")]
	protected bool IsDamageTurned
	{
		[Address(RVA = "0x1DBB170", Offset = "0x1DBA570", Length = "0x8")]
		[Token(Token = "0x6000E2B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001F4")]
	protected bool IsDeadEffectCalled
	{
		[Address(RVA = "0x1DBB180", Offset = "0x1DBA580", Length = "0x8")]
		[Token(Token = "0x6000E2C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001FF")]
	protected bool IsEasyMode
	{
		[Address(RVA = "0x1DBB190", Offset = "0x1DBA590", Length = "0x17")]
		[Token(Token = "0x6000E38")]
		 get { } //Length: 23
	}

	[Token(Token = "0x170001F9")]
	protected bool IsPlayerSideBottom
	{
		[Address(RVA = "0x1D39AB0", Offset = "0x1D38EB0", Length = "0x8")]
		[Token(Token = "0x6000E31")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001F8")]
	protected bool IsPlayerSideCenter
	{
		[Address(RVA = "0x1DBB1B0", Offset = "0x1DBA5B0", Length = "0x8")]
		[Token(Token = "0x6000E30")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001F7")]
	protected bool IsPlayerSideDown
	{
		[Address(RVA = "0x1DBB1C0", Offset = "0x1DBA5C0", Length = "0x8")]
		[Token(Token = "0x6000E2F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001F5")]
	protected bool IsPlayerSideLeft
	{
		[Address(RVA = "0x1DBB1D0", Offset = "0x1DBA5D0", Length = "0x8")]
		[Token(Token = "0x6000E2D")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001F6")]
	protected bool IsPlayerSideRight
	{
		[Address(RVA = "0x1DBB1E0", Offset = "0x1DBA5E0", Length = "0xB")]
		[Token(Token = "0x6000E2E")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170001FC")]
	public bool IsRepeatLaped
	{
		[Address(RVA = "0x1DBB1F0", Offset = "0x1DBA5F0", Length = "0x8")]
		[Token(Token = "0x6000E34")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000203")]
	protected bool IsStoryA
	{
		[Address(RVA = "0x1DBB200", Offset = "0x1DBA600", Length = "0x17")]
		[Token(Token = "0x6000E3C")]
		 get { } //Length: 23
	}

	[Token(Token = "0x17000204")]
	protected bool IsStoryB
	{
		[Address(RVA = "0x1DBB220", Offset = "0x1DBA620", Length = "0x17")]
		[Token(Token = "0x6000E3D")]
		 get { } //Length: 23
	}

	[Token(Token = "0x17000205")]
	protected bool IsStoryC
	{
		[Address(RVA = "0x1DBB240", Offset = "0x1DBA640", Length = "0x17")]
		[Token(Token = "0x6000E3E")]
		 get { } //Length: 23
	}

	[Token(Token = "0x17000200")]
	protected bool IsStoryMode
	{
		[Address(RVA = "0x1DBB260", Offset = "0x1DBA660", Length = "0xB")]
		[Token(Token = "0x6000E39")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000207")]
	protected bool IsTeam
	{
		[Address(RVA = "0x1DBB270", Offset = "0x1DBA670", Length = "0xB")]
		[Token(Token = "0x6000E40")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000202")]
	protected bool IsTrophy
	{
		[Address(RVA = "0x1DBB280", Offset = "0x1DBA680", Length = "0x17")]
		[Token(Token = "0x6000E3B")]
		 get { } //Length: 23
	}

	[Token(Token = "0x17000201")]
	protected bool IsTutorial
	{
		[Address(RVA = "0x1DBB2A0", Offset = "0x1DBA6A0", Length = "0xB")]
		[Token(Token = "0x6000E3A")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170001FB")]
	public int RepeatTimes
	{
		[Address(RVA = "0x1DBB2B0", Offset = "0x1DBA6B0", Length = "0x7")]
		[Token(Token = "0x6000E33")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700020A")]
	public Vector3 StartInGamePosition
	{
		[Address(RVA = "0x1DBB2C0", Offset = "0x1DBA6C0", Length = "0x19")]
		[Token(Token = "0x6000E43")]
		 get { } //Length: 25
	}

	[Address(RVA = "0x1DBAEB0", Offset = "0x1DBA2B0", Length = "0x134")]
	[Token(Token = "0x6000E0E")]
	protected virtual void _callDeadEffect() { }

	[Address(RVA = "0x1DBAFF0", Offset = "0x1DBA3F0", Length = "0xB5")]
	[Token(Token = "0x6000E48")]
	private static Ene_BosBase() { }

	[Address(RVA = "0x1DBB0B0", Offset = "0x1DBA4B0", Length = "0x5D")]
	[Token(Token = "0x6000E47")]
	protected Ene_BosBase() { }

	[Address(RVA = "0x1DB8EC0", Offset = "0x1DB82C0", Length = "0x9C")]
	[Token(Token = "0x6000E1D")]
	protected void AddRepeatTime(float ttime) { }

	[Address(RVA = "0x1DB8F60", Offset = "0x1DB8360", Length = "0x7")]
	[Token(Token = "0x6000E24")]
	protected int AttackLoopCount() { }

	[Address(RVA = "0x1DB8F70", Offset = "0x1DB8370", Length = "0x22C")]
	[Token(Token = "0x6000E04")]
	protected List<PawnEnemy> CallEnemyClip(int tindex, Vector3 offset, poolEventFunction poolFunction = null) { }

	[Address(RVA = "0x1DB91A0", Offset = "0x1DB85A0", Length = "0x118")]
	[AsyncStateMachine(typeof(<ChangeBaseColor>d__47))]
	[Token(Token = "0x6000E27")]
	private UniTask ChangeBaseColor(bool isDark, Color color, float tsecond, float twait = 0) { }

	[Address(RVA = "0x1DB92C0", Offset = "0x1DB86C0", Length = "0x5A")]
	[Token(Token = "0x6000E29")]
	protected void ChangeColorMode(bool isDark, Color color, float fadeTime, float delayTime) { }

	[Address(RVA = "0x1DB9320", Offset = "0x1DB8720", Length = "0xC8")]
	[Token(Token = "0x6000E28")]
	protected void ChangeDarkMode(bool isDark, float tsec, float twait = 0) { }

	[Address(RVA = "0x1DB93F0", Offset = "0x1DB87F0", Length = "0x6F")]
	[Token(Token = "0x6000E23")]
	protected void ConsumeAttackLoop(int count = 1) { }

	[Address(RVA = "0x1DB9460", Offset = "0x1DB8860", Length = "0xE8")]
	[Token(Token = "0x6000E0C")]
	private void CountupBossTimer(float dt) { }

	[Address(RVA = "0x1DB95C0", Offset = "0x1DB89C0", Length = "0x6D")]
	[Token(Token = "0x6000E45")]
	protected Quaternion CurrentTargetAngle(float trate) { }

	[Address(RVA = "0x1DB9550", Offset = "0x1DB8950", Length = "0x6D")]
	[Token(Token = "0x6000E46")]
	protected Quaternion CurrentTargetAngleSlerp(float trate) { }

	[Address(RVA = "0x1DB9630", Offset = "0x1DB8A30", Length = "0xED")]
	[Token(Token = "0x6000E44")]
	protected Vector3 CurrentTargetVector(float trate, EasingType easeType = 0) { }

	[Address(RVA = "0x1DB9720", Offset = "0x1DB8B20", Length = "0x11D")]
	[AsyncStateMachine(typeof(<DamageTurn>d__50))]
	[Token(Token = "0x6000E2A")]
	protected UniTask DamageTurn(Quaternion trot, float tsecond, Action _callback = null) { }

	[Address(RVA = "0x1DBB2E0", Offset = "0x1DBA6E0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000E36")]
	protected int get__enemyDataCount() { }

	[Address(RVA = "0x1DBB110", Offset = "0x1DBA510", Length = "0x19")]
	[Token(Token = "0x6000E35")]
	protected Vector3 get_BaseTargetSkyPosition() { }

	[Address(RVA = "0x1DBB130", Offset = "0x1DBA530", Length = "0x9")]
	[Token(Token = "0x6000E32")]
	public float get_BossAliveTime() { }

	[Address(RVA = "0x1DBB140", Offset = "0x1DBA540", Length = "0x7")]
	[Token(Token = "0x6000E41")]
	protected PlayActor get_GetPlayActor() { }

	[Address(RVA = "0x1DBB150", Offset = "0x1DBA550", Length = "0x7")]
	[Token(Token = "0x6000E42")]
	protected HitPState get_HpState() { }

	[Address(RVA = "0x1DBB160", Offset = "0x1DBA560", Length = "0xB")]
	[Token(Token = "0x6000E3F")]
	protected bool get_IsArcade() { }

	[Address(RVA = "0x1DBB170", Offset = "0x1DBA570", Length = "0x8")]
	[Token(Token = "0x6000E2B")]
	protected bool get_IsDamageTurned() { }

	[Address(RVA = "0x1DBB180", Offset = "0x1DBA580", Length = "0x8")]
	[Token(Token = "0x6000E2C")]
	protected bool get_IsDeadEffectCalled() { }

	[Address(RVA = "0x1DBB190", Offset = "0x1DBA590", Length = "0x17")]
	[Token(Token = "0x6000E38")]
	protected bool get_IsEasyMode() { }

	[Address(RVA = "0x1D39AB0", Offset = "0x1D38EB0", Length = "0x8")]
	[Token(Token = "0x6000E31")]
	protected bool get_IsPlayerSideBottom() { }

	[Address(RVA = "0x1DBB1B0", Offset = "0x1DBA5B0", Length = "0x8")]
	[Token(Token = "0x6000E30")]
	protected bool get_IsPlayerSideCenter() { }

	[Address(RVA = "0x1DBB1C0", Offset = "0x1DBA5C0", Length = "0x8")]
	[Token(Token = "0x6000E2F")]
	protected bool get_IsPlayerSideDown() { }

	[Address(RVA = "0x1DBB1D0", Offset = "0x1DBA5D0", Length = "0x8")]
	[Token(Token = "0x6000E2D")]
	protected bool get_IsPlayerSideLeft() { }

	[Address(RVA = "0x1DBB1E0", Offset = "0x1DBA5E0", Length = "0xB")]
	[Token(Token = "0x6000E2E")]
	protected bool get_IsPlayerSideRight() { }

	[Address(RVA = "0x1DBB1F0", Offset = "0x1DBA5F0", Length = "0x8")]
	[Token(Token = "0x6000E34")]
	public bool get_IsRepeatLaped() { }

	[Address(RVA = "0x1DBB200", Offset = "0x1DBA600", Length = "0x17")]
	[Token(Token = "0x6000E3C")]
	protected bool get_IsStoryA() { }

	[Address(RVA = "0x1DBB220", Offset = "0x1DBA620", Length = "0x17")]
	[Token(Token = "0x6000E3D")]
	protected bool get_IsStoryB() { }

	[Address(RVA = "0x1DBB240", Offset = "0x1DBA640", Length = "0x17")]
	[Token(Token = "0x6000E3E")]
	protected bool get_IsStoryC() { }

	[Address(RVA = "0x1DBB260", Offset = "0x1DBA660", Length = "0xB")]
	[Token(Token = "0x6000E39")]
	protected bool get_IsStoryMode() { }

	[Address(RVA = "0x1DBB270", Offset = "0x1DBA670", Length = "0xB")]
	[Token(Token = "0x6000E40")]
	protected bool get_IsTeam() { }

	[Address(RVA = "0x1DBB280", Offset = "0x1DBA680", Length = "0x17")]
	[Token(Token = "0x6000E3B")]
	protected bool get_IsTrophy() { }

	[Address(RVA = "0x1DBB2A0", Offset = "0x1DBA6A0", Length = "0xB")]
	[Token(Token = "0x6000E3A")]
	protected bool get_IsTutorial() { }

	[Address(RVA = "0x1DBB2B0", Offset = "0x1DBA6B0", Length = "0x7")]
	[Token(Token = "0x6000E33")]
	public int get_RepeatTimes() { }

	[Address(RVA = "0x1DBB2C0", Offset = "0x1DBA6C0", Length = "0x19")]
	[Token(Token = "0x6000E43")]
	public Vector3 get_StartInGamePosition() { }

	[Address(RVA = "0x1DB9870", Offset = "0x1DB8C70", Length = "0x4F")]
	[Token(Token = "0x6000E03")]
	public override float GetBattileTime() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000E11")]
	protected override int GetBonusTimeKind() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000E06")]
	protected override String[] GetBossBT() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000E07")]
	protected override String[] GetBossCD() { }

	[Address(RVA = "0x1DB9840", Offset = "0x1DB8C40", Length = "0x2E")]
	[Token(Token = "0x6000E05")]
	protected BulletTemplate GetBT(int tindex) { }

	[Address(RVA = "0x1DB98C0", Offset = "0x1DB8CC0", Length = "0x15C")]
	[Token(Token = "0x6000DFA")]
	public virtual List<String> GetBulletTemplates() { }

	[Address(RVA = "0x1DB9A20", Offset = "0x1DB8E20", Length = "0x36")]
	[Token(Token = "0x6000E1A")]
	protected float GetDirectionRate() { }

	[Address(RVA = "0x1DB9A60", Offset = "0x1DB8E60", Length = "0x2D")]
	[Token(Token = "0x6000E1E")]
	protected float GetRepeatRate() { }

	[Address(RVA = "0x1D11D20", Offset = "0x1D11120", Length = "0x3B")]
	[Token(Token = "0x6000E17")]
	protected override Vector3 GetSmallBombPosition() { }

	[Address(RVA = "0x1DB9A90", Offset = "0x1DB8E90", Length = "0x3CC")]
	[Token(Token = "0x6000DF9")]
	public virtual void InitializeToPlay() { }

	[Address(RVA = "0x1DB9E60", Offset = "0x1DB9260", Length = "0x22")]
	[Token(Token = "0x6000E22")]
	protected bool IsAttackLoop() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000DFC")]
	public virtual bool IsBossType() { }

	[Address(RVA = "0x1DB9E90", Offset = "0x1DB9290", Length = "0xE1")]
	[Token(Token = "0x6000E16")]
	protected bool IsCallSmallBomb(float dt) { }

	[Address(RVA = "0x1DB9F80", Offset = "0x1DB9380", Length = "0x10")]
	[Token(Token = "0x6000E26")]
	protected bool IsChangeHpState() { }

	[Address(RVA = "0x1DB9F90", Offset = "0x1DB9390", Length = "0x20")]
	[Token(Token = "0x6000E13")]
	public virtual bool IsGamePlayArea() { }

	[Address(RVA = "0x1DB9FB0", Offset = "0x1DB93B0", Length = "0x16")]
	[Token(Token = "0x6000E0B")]
	protected bool IsOverAorB(HitPState hpstep, TimeSteps astep) { }

	[Address(RVA = "0x1DB9FD0", Offset = "0x1DB93D0", Length = "0xA")]
	[Token(Token = "0x6000E09")]
	protected bool IsOverHP(HitPState hpstep) { }

	[Address(RVA = "0x1DB9FE0", Offset = "0x1DB93E0", Length = "0xA")]
	[Token(Token = "0x6000E0A")]
	protected bool IsOverStep(TimeSteps astep) { }

	[Address(RVA = "0x1DB9FF0", Offset = "0x1DB93F0", Length = "0x1DF")]
	[Token(Token = "0x6000DFE")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1DBA1D0", Offset = "0x1DB95D0", Length = "0x1BA")]
	[Token(Token = "0x6000E01")]
	private void ProgressBossTimer(float dt) { }

	[Address(RVA = "0x1DBA430", Offset = "0x1DB9830", Length = "0x76")]
	[Token(Token = "0x6000DFF")]
	protected void ResetBossTimer(bool withPlay) { }

	[Address(RVA = "0x1DBA390", Offset = "0x1DB9790", Length = "0x99")]
	[Token(Token = "0x6000DFB")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1D17FD0", Offset = "0x1D173D0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000E37")]
	private void set__enemyDataCount(int value) { }

	[Address(RVA = "0x1DBA4B0", Offset = "0x1DB98B0", Length = "0x7")]
	[Token(Token = "0x6000E1B")]
	protected void SetDirectionPause(bool v) { }

	[Address(RVA = "0x1DBA4C0", Offset = "0x1DB98C0", Length = "0x9")]
	[Token(Token = "0x6000E19")]
	protected void SetDirectionScale(float tscale) { }

	[Address(RVA = "0x1DBA4D0", Offset = "0x1DB98D0", Length = "0x1B")]
	[Token(Token = "0x6000E18")]
	protected void SetDirectionTime(float ttime, float tscale = 1) { }

	[Address(RVA = "0x1DBA500", Offset = "0x1DB9900", Length = "0x2C")]
	[Token(Token = "0x6000E1F")]
	protected void SetLoopCount(int nmax) { }

	[Address(RVA = "0x1DBA530", Offset = "0x1DB9930", Length = "0x3E")]
	[Token(Token = "0x6000E21")]
	protected void SetLoopCount(int nmin, int nmax) { }

	[Address(RVA = "0x1DBA4F0", Offset = "0x1DB98F0", Length = "0x7")]
	[Token(Token = "0x6000E20")]
	protected void SetLoopCountDirect(int ncount) { }

	[Address(RVA = "0x1DBA570", Offset = "0x1DB9970", Length = "0xD")]
	[Token(Token = "0x6000E25")]
	protected void SetOldState() { }

	[Address(RVA = "0x1DBA580", Offset = "0x1DB9980", Length = "0x18")]
	[Token(Token = "0x6000E1C")]
	protected void SetRepeatTime(float ttime) { }

	[Address(RVA = "0x1DBA5A0", Offset = "0x1DB99A0", Length = "0x13")]
	[Token(Token = "0x6000E15")]
	protected void SetSmallBombSecond(float ttime) { }

	[Address(RVA = "0x1DBA5C0", Offset = "0x1DB99C0", Length = "0x1C2")]
	[Token(Token = "0x6000E14")]
	protected void SkyExplosionEffect(int tcode, Vector3 worldPos, int mylayer, ID seID = -1) { }

	[Token(Token = "0x6000DFD")]
	protected abstract void StateExec(float dt) { }

	[Address(RVA = "0x1DBA790", Offset = "0x1DB9B90", Length = "0x102")]
	[Token(Token = "0x6000E02")]
	protected void StopBossTimer() { }

	[Address(RVA = "0x1DBA8A0", Offset = "0x1DB9CA0", Length = "0x316")]
	[Token(Token = "0x6000DF8")]
	public virtual EnemyChildData[] SubEnemys() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000E10")]
	protected override void TimeupAction() { }

	[Address(RVA = "0x1DBAC60", Offset = "0x1DBA060", Length = "0xB9")]
	[Token(Token = "0x6000E12")]
	public virtual void ToDestroid() { }

	[Address(RVA = "0x1DBABC0", Offset = "0x1DB9FC0", Length = "0x96")]
	[Token(Token = "0x6000E0F")]
	protected void ToDestroidVib() { }

	[Address(RVA = "0x1DBAD20", Offset = "0x1DBA120", Length = "0xE9")]
	[Token(Token = "0x6000E0D")]
	protected override bool UpdateHPState() { }

	[Address(RVA = "0x1DBAE10", Offset = "0x1DBA210", Length = "0x71")]
	[Token(Token = "0x6000E00")]
	private void UpdatePlayerPositionFlag(Vector3 ppos) { }

	[Address(RVA = "0x1DBAE90", Offset = "0x1DBA290", Length = "0x12")]
	[Token(Token = "0x6000E08")]
	protected bool UptoHpStep(HitPState hpstep) { }

}

