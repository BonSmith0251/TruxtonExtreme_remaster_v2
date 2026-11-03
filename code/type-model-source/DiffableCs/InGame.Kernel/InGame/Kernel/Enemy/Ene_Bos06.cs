namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001A9")]
public class Ene_Bos06 : Ene_BosBase
{
	[CompilerGenerated]
	[Token(Token = "0x20001B1")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000E36")]
		public Ene_Bos06 <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000E37")]
		public int targetIndex; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000D29")]
		public <>c__DisplayClass6_0() { }

		[Address(RVA = "0x1DB8DE0", Offset = "0x1DB81E0", Length = "0x66")]
		[Token(Token = "0x6000D2A")]
		internal PartsKind <GetHormingTarget>b__0() { }

	}

	[Token(Token = "0x20001B0")]
	private class BatteryMovement
	{
		[Token(Token = "0x4000E25")]
		private static readonly float _LaserInterval; //Field offset: 0x0
		[Token(Token = "0x4000E26")]
		private static readonly float _LaserFollowStartTime; //Field offset: 0x4
		[Token(Token = "0x4000E27")]
		private static readonly float _LaserFollowStopTime; //Field offset: 0x8
		[Token(Token = "0x4000E28")]
		private static readonly float _LaserCallTime; //Field offset: 0xC
		[Token(Token = "0x4000E29")]
		private static readonly float _LaserFollowTime; //Field offset: 0x10
		[Token(Token = "0x4000E2A")]
		private static readonly float _FloatingCycleTime; //Field offset: 0x14
		[Token(Token = "0x4000E2B")]
		private static readonly float _FloatingCycleDistance; //Field offset: 0x18
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000E2C")]
		private bool _enable; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000E2D")]
		private float _timer; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000E2E")]
		private float _startAngle; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000E2F")]
		private float _targetAngle; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000E30")]
		private float _float; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000E31")]
		private Transform _cover; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000E32")]
		private Transform _battery; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000E33")]
		private Transform _muzzle; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000E34")]
		private Transform _target; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000E35")]
		private Action<Transform, Transform> _callLaser; //Field offset: 0x48

		[Address(RVA = "0x1DA03C0", Offset = "0x1D9F7C0", Length = "0xBF")]
		[Token(Token = "0x6000D28")]
		private static BatteryMovement() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000D27")]
		public BatteryMovement() { }

		[Address(RVA = "0x1D9F990", Offset = "0x1D9ED90", Length = "0x18")]
		[Token(Token = "0x6000D24")]
		public void Attack(float delay) { }

		[Address(RVA = "0x1D9F9B0", Offset = "0x1D9EDB0", Length = "0x168")]
		[Token(Token = "0x6000D26")]
		private float GetTargetDegAngle(Vector3 selfPosition, Vector3 playerSkyPosition) { }

		[Address(RVA = "0x1D9FB20", Offset = "0x1D9EF20", Length = "0x1BE")]
		[Token(Token = "0x6000D22")]
		public void Initialize(Action<Transform, Transform> callLaser, Transform cover, Transform battery, Transform muzzle, Transform target) { }

		[Address(RVA = "0x1D9FCE0", Offset = "0x1D9F0E0", Length = "0x662")]
		[Token(Token = "0x6000D25")]
		public void Progress(float deltaTime, Vector3 playerSkyPosition) { }

		[Address(RVA = "0x1DA0350", Offset = "0x1D9F750", Length = "0x69")]
		[Token(Token = "0x6000D23")]
		public void Terminate() { }

	}

	[Token(Token = "0x20001AC")]
	private enum Boss06BT : int
	{
		laser01 = 0,
		sideWay = 1,
		core0 = 2,
		core1 = 3,
		core2 = 4,
		core3 = 5,
		core4 = 6,
		bind0 = 7,
		core1short = 8,
		side1 = 9,
		side2 = 10,
		btMax = 11,
	}

	[Token(Token = "0x20001AD")]
	private enum Boss06MZ : int
	{
		muzzle_core_core = 0,
		muzzle_core_battery = 1,
		muzzle_top_core = 2,
		muzzle_body_core_40 = 3,
		muzzle_body_core_60 = 4,
		muzzle_batteryL = 5,
		muzzle_batteryR = 6,
		targetL = 7,
		targetR = 8,
		bindD = 9,
		bindU = 10,
	}

	[Token(Token = "0x20001AA")]
	private enum Boss06State : int
	{
		None = -1,
		EntryWait = 0,
		PT1 = 1,
		PT3Break = 2,
		PT6Bind = 3,
		PT7Change = 4,
		PT8 = 5,
		Destruction = 100,
	}

	[Token(Token = "0x20001AE")]
	private class CoreMovement
	{
		[Token(Token = "0x20001AF")]
		private enum Mode : int
		{
			Home = 0,
			ToEvacuate1 = 1,
			ToEvacuate2 = 2,
			Evacuated = 3,
			ToCombat = 4,
			Combat = 5,
		}

		[Token(Token = "0x4000E07")]
		private static readonly float _EvacuateDelay; //Field offset: 0x0
		[Token(Token = "0x4000E10")]
		private const int DefaultFirePatternCount = 2; //Field offset: 0x0
		[Token(Token = "0x4000E11")]
		private const int ExtendedFirePatternCount = 4; //Field offset: 0x0
		[Token(Token = "0x4000E08")]
		private static readonly float _EvacuateTime; //Field offset: 0x4
		[Token(Token = "0x4000E09")]
		private static readonly float _RotatePerSecond; //Field offset: 0x8
		[Token(Token = "0x4000E0A")]
		private static readonly float _FloatingCycleTime; //Field offset: 0xC
		[Token(Token = "0x4000E0B")]
		private static readonly float _FloatingCycleDistance; //Field offset: 0x10
		[Token(Token = "0x4000E0C")]
		private static readonly float _CombatTime; //Field offset: 0x14
		[Token(Token = "0x4000E0D")]
		private static readonly float _CircuitTime; //Field offset: 0x18
		[Token(Token = "0x4000E0E")]
		private static readonly float _CircuitRadius; //Field offset: 0x1C
		[Token(Token = "0x4000E0F")]
		private static readonly float _CircuitFireTiming; //Field offset: 0x20
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000E12")]
		private Mode _mode; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000E13")]
		private float _timer; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000E14")]
		private float _rotation; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000E15")]
		private float _float; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000E16")]
		private float _acceleration; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000E17")]
		private int _fireCount; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000E18")]
		private int _firePatternCount; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000E19")]
		private Transform _coreBody; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000E1A")]
		private EnePartsGroup _corePart; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000E1B")]
		private CancellationTokenSource _animationTaskToken; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000E1C")]
		private Action<Int32, Boss06MZ, Single> _callBT; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000E1D")]
		private EnemyMover _mover; //Field offset: 0x50

		[Address(RVA = "0x1D8ADA0", Offset = "0x1D8A1A0", Length = "0xE1")]
		[Token(Token = "0x6000D21")]
		private static CoreMovement() { }

		[Address(RVA = "0x1D8AE90", Offset = "0x1D8A290", Length = "0xE")]
		[Token(Token = "0x6000D20")]
		public CoreMovement() { }

		[Address(RVA = "0x1D89FD0", Offset = "0x1D893D0", Length = "0xA")]
		[Token(Token = "0x6000D1C")]
		public void AddAdditionalPattern() { }

		[Address(RVA = "0x1D89FE0", Offset = "0x1D893E0", Length = "0x17B")]
		[Token(Token = "0x6000D1B")]
		public void Combat() { }

		[Address(RVA = "0x1D8A160", Offset = "0x1D89560", Length = "0x3C")]
		[Token(Token = "0x6000D1A")]
		public void Evacuate() { }

		[Address(RVA = "0x1D8A1A0", Offset = "0x1D895A0", Length = "0x11F")]
		[Token(Token = "0x6000D18")]
		public void Initialize(CancellationToken token, Transform body, EnePartsGroup part, Action<Int32, Boss06MZ, Single> callBT, EnemyMover mover) { }

		[Address(RVA = "0x1D8A2C0", Offset = "0x1D896C0", Length = "0x8")]
		[Token(Token = "0x6000D1E")]
		public bool IsCombat() { }

		[Address(RVA = "0x1D8A2D0", Offset = "0x1D896D0", Length = "0x8")]
		[Token(Token = "0x6000D1D")]
		public bool IsEvacuated() { }

		[Address(RVA = "0x1D8A2E0", Offset = "0x1D896E0", Length = "0xA28")]
		[Token(Token = "0x6000D1F")]
		public void Progress(float deltaTime) { }

		[Address(RVA = "0x1D8AD20", Offset = "0x1D8A120", Length = "0x74")]
		[Token(Token = "0x6000D19")]
		public void Terminate() { }

	}

	[Token(Token = "0x20001AB")]
	private enum PartsKind : int
	{
		MainBody = 0,
		TopBody = 1,
		LeftBody = 2,
		RightBody = 3,
		CoreBody = 4,
	}

	[Token(Token = "0x4000DA8")]
	private static readonly String[] btNames; //Field offset: 0x0
	[Token(Token = "0x4000DA9")]
	private static readonly int MuzzleCount; //Field offset: 0x8
	[Token(Token = "0x4000DB2")]
	private static readonly Vector3 BodyCoreHomePosition; //Field offset: 0xC
	[Token(Token = "0x4000DB3")]
	private static readonly Vector3 BodyCoreAttackPosition; //Field offset: 0x18
	[Token(Token = "0x4000DB4")]
	private static readonly Vector3 BodyCoreSafePosition; //Field offset: 0x24
	[Token(Token = "0x4000DB5")]
	private static readonly Quaternion LaserRotateBodyL; //Field offset: 0x30
	[Token(Token = "0x4000DB6")]
	private static readonly Quaternion LaserRotateBodyR; //Field offset: 0x40
	[Token(Token = "0x4000DB7")]
	private static readonly int CoreAnimeHash; //Field offset: 0x50
	[Token(Token = "0x4000DCA")]
	private static readonly float _EntryNoHitTime; //Field offset: 0x54
	[Token(Token = "0x4000DCB")]
	private static readonly float _Pattern1FireTime; //Field offset: 0x58
	[Token(Token = "0x4000DCC")]
	private static readonly float _Pattern1FireDelay; //Field offset: 0x5C
	[Token(Token = "0x4000DCD")]
	private static readonly float _Pattern1FireInterval; //Field offset: 0x60
	[Token(Token = "0x4000DCE")]
	private static readonly float _Pattern1FireStart; //Field offset: 0x64
	[Token(Token = "0x4000DCF")]
	private static readonly int _Pattern1FireCount; //Field offset: 0x68
	[Token(Token = "0x4000DD0")]
	private static readonly float _Pattern1CircleMoveWidth; //Field offset: 0x6C
	[Token(Token = "0x4000DD1")]
	private static readonly float _Pattern1CircleMoveHeight; //Field offset: 0x70
	[Token(Token = "0x4000DD2")]
	private static readonly Vector3 _LeftSlidePosition; //Field offset: 0x74
	[Token(Token = "0x4000DD3")]
	private static readonly Vector3 _RightSlidePosition; //Field offset: 0x80
	[Token(Token = "0x4000DD4")]
	private static readonly float _SlideStep; //Field offset: 0x8C
	[Token(Token = "0x4000DD5")]
	private static readonly float _Pattern2FireInterval; //Field offset: 0x90
	[Token(Token = "0x4000DD6")]
	private static readonly int _Pattern2FireCount; //Field offset: 0x94
	[Token(Token = "0x4000DD7")]
	private static readonly Single[] _Pattern2FireAngles; //Field offset: 0x98
	[Token(Token = "0x4000DD8")]
	private static readonly float _Pattern2CircleMoveWidth; //Field offset: 0xA0
	[Token(Token = "0x4000DD9")]
	private static readonly float _Pattern2CircleMoveHeight; //Field offset: 0xA4
	[Token(Token = "0x4000DDA")]
	private static readonly float _BaseDistance; //Field offset: 0xA8
	[Token(Token = "0x4000DDB")]
	private static readonly Vector3 _BodyLeftBasePosition; //Field offset: 0xAC
	[Token(Token = "0x4000DDC")]
	private static readonly Vector3 _BodyRightBasePosition; //Field offset: 0xB8
	[Token(Token = "0x4000DDD")]
	private static readonly float _PinchMoveDistance; //Field offset: 0xC4
	[Token(Token = "0x4000DDE")]
	private static readonly Quaternion _PartsBreakRotation; //Field offset: 0xC8
	[FieldOffset(Offset = "0x270")]
	[SerializeField]
	[Token(Token = "0x4000DAA")]
	private Transform[] _muzzles; //Field offset: 0x270
	[FieldOffset(Offset = "0x278")]
	[SerializeField]
	[Token(Token = "0x4000DAB")]
	private Transform _laserL; //Field offset: 0x278
	[FieldOffset(Offset = "0x280")]
	[SerializeField]
	[Token(Token = "0x4000DAC")]
	private Transform _laserR; //Field offset: 0x280
	[FieldOffset(Offset = "0x288")]
	[SerializeField]
	[Token(Token = "0x4000DAD")]
	private Transform _bodyL; //Field offset: 0x288
	[FieldOffset(Offset = "0x290")]
	[SerializeField]
	[Token(Token = "0x4000DAE")]
	private Transform _bodyR; //Field offset: 0x290
	[FieldOffset(Offset = "0x298")]
	[SerializeField]
	[Token(Token = "0x4000DAF")]
	private Transform _bodyCore; //Field offset: 0x298
	[FieldOffset(Offset = "0x2A0")]
	[SerializeField]
	[Token(Token = "0x4000DB0")]
	private ParticleSystem _bindEffect; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A8")]
	[SerializeField]
	[Token(Token = "0x4000DB1")]
	private AnimationCurve _easingCurve; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2B0")]
	[Token(Token = "0x4000DB8")]
	private Boss06State _bos06state; //Field offset: 0x2B0
	[FieldOffset(Offset = "0x2B4")]
	[Token(Token = "0x4000DB9")]
	private int _repeatCount; //Field offset: 0x2B4
	[FieldOffset(Offset = "0x2B8")]
	[Token(Token = "0x4000DBA")]
	private float _localTime; //Field offset: 0x2B8
	[FieldOffset(Offset = "0x2BC")]
	[Token(Token = "0x4000DBB")]
	private float _playerSlider; //Field offset: 0x2BC
	[FieldOffset(Offset = "0x2C0")]
	[Token(Token = "0x4000DBC")]
	private float _pinchTargetPositionZ; //Field offset: 0x2C0
	[FieldOffset(Offset = "0x2C4")]
	[Token(Token = "0x4000DBD")]
	private float _pinchHomePositionZ; //Field offset: 0x2C4
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x4000DBE")]
	private bool _isCoverOpen; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x4000DBF")]
	private CancellationTokenSource _bulletToken; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x4000DC0")]
	private int _circuitCount; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2DC")]
	[Token(Token = "0x4000DC1")]
	private float _batteryAngle; //Field offset: 0x2DC
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x4000DC2")]
	private bool _enableSideAttack; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E1")]
	[Token(Token = "0x4000DC3")]
	private bool _isSideAttackLeft; //Field offset: 0x2E1
	[FieldOffset(Offset = "0x2E4")]
	[Token(Token = "0x4000DC4")]
	private float _sideAttackTime; //Field offset: 0x2E4
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x4000DC5")]
	private bool _isLeftBodyBroken; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2E9")]
	[Token(Token = "0x4000DC6")]
	private bool _isRightBodyBroken; //Field offset: 0x2E9
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x4000DC7")]
	private CoreMovement _coreMovement; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x4000DC8")]
	private BatteryMovement _leftBattery; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x4000DC9")]
	private BatteryMovement _rightBattery; //Field offset: 0x300

	[Address(RVA = "0x1D9E8F0", Offset = "0x1D9DCF0", Length = "0x18F")]
	[Token(Token = "0x6000D07")]
	private void _callBT(int btIndex, Boss06MZ mz, float angle = 0) { }

	[Address(RVA = "0x1D9EA80", Offset = "0x1D9DE80", Length = "0x207")]
	[Token(Token = "0x6000D08")]
	private void _callLaserBT() { }

	[Address(RVA = "0x1D9F4C0", Offset = "0x1D9E8C0", Length = "0x27B")]
	[Token(Token = "0x6000D09")]
	private void _moveCircle(float circleRate, float circleWidth, float circleHeight, float slideDeltaTime) { }

	[Address(RVA = "0x1D9EC90", Offset = "0x1D9E090", Length = "0x6B2")]
	[Token(Token = "0x6000D16")]
	private static Ene_Bos06() { }

	[Address(RVA = "0x1D9F350", Offset = "0x1D9E750", Length = "0x16B")]
	[Token(Token = "0x6000D15")]
	public Ene_Bos06() { }

	[Address(RVA = "0x1D9E6C0", Offset = "0x1D9DAC0", Length = "0x229")]
	[CompilerGenerated]
	[Token(Token = "0x6000D17")]
	private bool <PatternMovePT6Bind>g__coverMoveX|86_0(bool isReverse) { }

	[Address(RVA = "0x1D9AD50", Offset = "0x1D9A150", Length = "0xE4")]
	[Token(Token = "0x6000D06")]
	private void BatteryMove(float angle) { }

	[Address(RVA = "0x1D9AE40", Offset = "0x1D9A240", Length = "0x30")]
	[Token(Token = "0x6000CFA")]
	public virtual void CallDisabled() { }

	[Address(RVA = "0x1D9AE80", Offset = "0x1D9A280", Length = "0xA7")]
	[Token(Token = "0x6000D11")]
	private void CallLaser(Transform muzzle, Transform target) { }

	[Address(RVA = "0x1D9AF30", Offset = "0x1D9A330", Length = "0x111")]
	[Token(Token = "0x6000CFD")]
	private bool CheckCoverBreak() { }

	[Address(RVA = "0x1D9B050", Offset = "0x1D9A450", Length = "0xAC")]
	[Token(Token = "0x6000CFF")]
	private void CheckNextState() { }

	[Address(RVA = "0x1D9B100", Offset = "0x1D9A500", Length = "0x28")]
	[Token(Token = "0x6000D0B")]
	private void CheckSideAttack() { }

	[Address(RVA = "0x1D9B130", Offset = "0x1D9A530", Length = "0xE9")]
	[Token(Token = "0x6000CFE")]
	private bool CoverBreak() { }

	[Address(RVA = "0x1D9B220", Offset = "0x1D9A620", Length = "0xC0")]
	[Token(Token = "0x6000D0D")]
	private void CoverPartsHitType(bool isLaserMode) { }

	[Address(RVA = "0x1D9B2F0", Offset = "0x1D9A6F0", Length = "0x4E")]
	[Token(Token = "0x6000D03")]
	protected virtual String[] GetBossBT() { }

	[Address(RVA = "0x1D79300", Offset = "0x1D78700", Length = "0x7")]
	[Token(Token = "0x6000D00")]
	protected virtual string GetDebugString() { }

	[Address(RVA = "0x1D9B340", Offset = "0x1D9A740", Length = "0x160")]
	[Token(Token = "0x6000CFB")]
	public virtual Vector3 GetHormingTarget(int targetIndex) { }

	[Address(RVA = "0x1D95780", Offset = "0x1D94B80", Length = "0x2E")]
	[Token(Token = "0x6000D04")]
	private Transform GetMuzzle(Boss06MZ mz) { }

	[Address(RVA = "0x1D9B4B0", Offset = "0x1D9A8B0", Length = "0x73")]
	[Token(Token = "0x6000D14")]
	protected virtual Vector3 GetSmallBombPosition() { }

	[Address(RVA = "0x1D9B530", Offset = "0x1D9A930", Length = "0x60")]
	[Token(Token = "0x6000CF7")]
	public virtual void GetStart() { }

	[Address(RVA = "0x1D9B590", Offset = "0x1D9A990", Length = "0x2E")]
	[Token(Token = "0x6000CF5")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D9B5C0", Offset = "0x1D9A9C0", Length = "0x1C")]
	[Token(Token = "0x6000CF8")]
	public virtual bool IsBomberRange() { }

	[Address(RVA = "0x1D9B5E0", Offset = "0x1D9A9E0", Length = "0x68")]
	[Token(Token = "0x6000CFC")]
	public virtual void OnPartsBreak(int parts) { }

	[Address(RVA = "0x1D9B650", Offset = "0x1D9AA50", Length = "0x630")]
	[Token(Token = "0x6000D13")]
	private void PatternMoveDestruction(float dt) { }

	[Address(RVA = "0x1D9BC90", Offset = "0x1D9B090", Length = "0x24C")]
	[Token(Token = "0x6000D05")]
	private void PatternMoveEntryWait(float deltaTime) { }

	[Address(RVA = "0x1D9BEE0", Offset = "0x1D9B2E0", Length = "0x7AE")]
	[Token(Token = "0x6000D0A")]
	private void PatternMovePT1(float deltaTime) { }

	[Address(RVA = "0x1D9C690", Offset = "0x1D9BA90", Length = "0x8A4")]
	[Token(Token = "0x6000D0E")]
	private void PatternMovePT3Break(float deltaTime) { }

	[Address(RVA = "0x1D9CF70", Offset = "0x1D9C370", Length = "0x67A")]
	[Token(Token = "0x6000D0F")]
	private void PatternMovePT6Bind(float deltaTime) { }

	[Address(RVA = "0x1D9D5F0", Offset = "0x1D9C9F0", Length = "0x3F5")]
	[Token(Token = "0x6000D10")]
	private void PatternMovePT7Change(float deltaTime) { }

	[Address(RVA = "0x1D9D9F0", Offset = "0x1D9CDF0", Length = "0xEB")]
	[Token(Token = "0x6000D12")]
	private void PatternMovePT8(float deltaTime) { }

	[Address(RVA = "0x1D9DAE0", Offset = "0x1D9CEE0", Length = "0x589")]
	[Token(Token = "0x6000CF6")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1D9E070", Offset = "0x1D9D470", Length = "0x39")]
	[Token(Token = "0x6000D02")]
	private void SetState(Boss06State state) { }

	[Address(RVA = "0x1D9E0B0", Offset = "0x1D9D4B0", Length = "0x2BD")]
	[Token(Token = "0x6000D0C")]
	private void SideAttack(float deltaTime, bool enableAttack) { }

	[Address(RVA = "0x1D9E370", Offset = "0x1D9D770", Length = "0x34")]
	[Token(Token = "0x6000D01")]
	protected virtual void StateExec(float deltaTime) { }

	[Address(RVA = "0x1D9E530", Offset = "0x1D9D930", Length = "0x185")]
	[Token(Token = "0x6000CF9")]
	public virtual void ToDestroid() { }

}

