namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001B2")]
public class Ene_Bos07 : Ene_BosBase
{
	[CompilerGenerated]
	[Token(Token = "0x20001B9")]
	private struct <>c__DisplayClass125_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ECD")]
		public InGameManager gm; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000ECE")]
		public Ene_Bos07 <>4__this; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000ECF")]
		public Vector3 playerPos; //Field offset: 0x10

	}

	[Token(Token = "0x20001B5")]
	private enum Boss07BT : int
	{
		legSLaser3 = 0,
		legBullet = 1,
		leg1Way = 2,
		leg2Way = 3,
		body3way = 4,
		armBulletH = 5,
		bodyShotCenter = 6,
		bodyShotSide = 7,
		face = 8,
		laser = 9,
	}

	[Token(Token = "0x20001B6")]
	private enum Boss07MZ : int
	{
		muzzle_body_upper_01 = 0,
		muzzle_body_upper_02 = 1,
		muzzle_body_under_1 = 2,
		muzzle_body_under_3 = 3,
		muzzle_body_leg40 = 4,
		muzzle_body_leg42_1 = 5,
		muzzle_body_leg60 = 6,
		muzzle_body_leg62_1 = 7,
		cover_muzzle_1 = 8,
		cover_muzzle_2 = 9,
		cover_muzzle_3 = 10,
		muzzle_body_upper_02_target = 11,
		body_battery01 = 12,
		body_battery03 = 13,
		body_battery04 = 14,
		body_battery06 = 15,
		body_battery07 = 16,
		body_battery09 = 17,
	}

	[Token(Token = "0x20001B3")]
	private enum Boss07State : int
	{
		EntryWait = 0,
		PT2 = 1,
		PT3 = 2,
		PT4 = 3,
		PT5 = 4,
		PT6 = 5,
		PT7 = 6,
		Destruction = 100,
	}

	[Token(Token = "0x20001B7")]
	private struct LegArcs
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EC0")]
		private float <thigh>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000EC1")]
		private float <knee>k__BackingField; //Field offset: 0x4
		[CompilerGenerated]
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000EC2")]
		private float <toe>k__BackingField; //Field offset: 0x8

		[Token(Token = "0x170001EE")]
		public private float knee
		{
			[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000D5D")]
			 get { } //Length: 388
			[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
			[CompilerGenerated]
			[Token(Token = "0x6000D5E")]
			private set { } //Length: 6
		}

		[Token(Token = "0x170001ED")]
		public private float thigh
		{
			[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000D5B")]
			 get { } //Length: 5
			[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000D5C")]
			private set { } //Length: 5
		}

		[Token(Token = "0x170001EF")]
		public private float toe
		{
			[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000D5F")]
			 get { } //Length: 229
			[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
			[CompilerGenerated]
			[Token(Token = "0x6000D60")]
			private set { } //Length: 6
		}

		[Address(RVA = "0x1DB7900", Offset = "0x1DB6D00", Length = "0xF")]
		[Token(Token = "0x6000D5A")]
		public LegArcs(float _thigh, float _knee, float _toe) { }

		[Address(RVA = "0x1DB78E0", Offset = "0x1DB6CE0", Length = "0x1A")]
		[IsReadOnly]
		[Token(Token = "0x6000D61")]
		public float Get(int tindex) { }

		[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000D5D")]
		public float get_knee() { }

		[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000D5B")]
		public float get_thigh() { }

		[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000D5F")]
		public float get_toe() { }

		[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000D5E")]
		private void set_knee(float value) { }

		[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000D5C")]
		private void set_thigh(float value) { }

		[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000D60")]
		private void set_toe(float value) { }

	}

	[Token(Token = "0x20001B8")]
	private enum LegPattern : int
	{
		None = -1,
		A = 0,
		B = 1,
		C = 2,
		C_WindUp = 3,
		C_Throw1 = 4,
		C_Throw2 = 5,
		Reach = 6,
		Reach2 = 7,
	}

	[Token(Token = "0x20001B4")]
	private enum PartsKind : int
	{
		MainBody = 0,
		Leg40 = 1,
		Leg60 = 2,
		Arm40 = 3,
		Arm60 = 4,
		FaceCover = 5,
	}

	[Token(Token = "0x4000E3A")]
	private static readonly String[] btNames; //Field offset: 0x0
	[Token(Token = "0x4000E49")]
	private static readonly LegArcs[] _legArcs; //Field offset: 0x8
	[Token(Token = "0x4000E64")]
	private static readonly Vector3 _arm40StartPos; //Field offset: 0x10
	[Token(Token = "0x4000E65")]
	private static readonly Vector3 _arm40EndPos; //Field offset: 0x1C
	[Token(Token = "0x4000E66")]
	private static readonly Vector3 _arm40SlidePos; //Field offset: 0x28
	[Token(Token = "0x4000E67")]
	private static readonly Vector3 _arm40FallPos; //Field offset: 0x34
	[Token(Token = "0x4000E68")]
	private static readonly Quaternion _armFallRot; //Field offset: 0x40
	[Token(Token = "0x4000E69")]
	private static readonly Quaternion _LtoR; //Field offset: 0x50
	[Token(Token = "0x4000E6A")]
	private static readonly Quaternion _RtoL; //Field offset: 0x60
	[Token(Token = "0x4000E6B")]
	private static readonly Vector3 _arm60StartPos; //Field offset: 0x70
	[Token(Token = "0x4000E6C")]
	private static readonly Vector3 _arm60EndPos; //Field offset: 0x7C
	[Token(Token = "0x4000E6D")]
	private static readonly Vector3 _arm60SlidePos; //Field offset: 0x88
	[Token(Token = "0x4000E6E")]
	private static readonly Vector3 _arm60FallPos; //Field offset: 0x94
	[Token(Token = "0x4000E6F")]
	private static readonly Vector3 _mainBodyHome; //Field offset: 0xA0
	[Token(Token = "0x4000E70")]
	private static readonly Vector3 _mainBodyBack; //Field offset: 0xAC
	[Token(Token = "0x4000E71")]
	private static readonly Vector3 _mode6Position; //Field offset: 0xB8
	[Token(Token = "0x4000E72")]
	private static readonly float _EntryNoHitTime; //Field offset: 0xC4
	[Token(Token = "0x4000E73")]
	private static readonly float LungeWindUpDistance; //Field offset: 0xC8
	[Token(Token = "0x4000E74")]
	private static readonly float LungeThrowDistance; //Field offset: 0xCC
	[Token(Token = "0x4000E75")]
	private static readonly float LungeWindUpRate; //Field offset: 0xD0
	[Token(Token = "0x4000E76")]
	private static readonly Vector3 LungeVector; //Field offset: 0xD4
	[Token(Token = "0x4000E77")]
	private static readonly float Pattern2_LegChangeTime; //Field offset: 0xE0
	[Token(Token = "0x4000E78")]
	private static readonly float Pattern2_AttackInterval; //Field offset: 0xE4
	[Token(Token = "0x4000E79")]
	private static readonly float Pattern2_AttackTime; //Field offset: 0xE8
	[Token(Token = "0x4000E7A")]
	private static readonly int Pattern2_FireCount; //Field offset: 0xEC
	[Token(Token = "0x4000E7B")]
	private static readonly float Pattern2_muzzleRadius; //Field offset: 0xF0
	[Token(Token = "0x4000E7C")]
	private static readonly float Pattern2_HomingSpeed; //Field offset: 0xF4
	[Token(Token = "0x4000E7D")]
	private static readonly float Pattern3_LegChangeTime; //Field offset: 0xF8
	[Token(Token = "0x4000E7E")]
	private static readonly float Pattern3_LegWindUpTime; //Field offset: 0xFC
	[Token(Token = "0x4000E7F")]
	private static readonly float Pattern3_LegWaitTime; //Field offset: 0x100
	[Token(Token = "0x4000E80")]
	private static readonly float Pattern3_LegSwingTime; //Field offset: 0x104
	[Token(Token = "0x4000E81")]
	private static readonly float Pattern3_LegEndTime; //Field offset: 0x108
	[Token(Token = "0x4000E82")]
	private static readonly float LegFire1WayTime; //Field offset: 0x10C
	[Token(Token = "0x4000E83")]
	private static readonly float LegFire2WayTime; //Field offset: 0x110
	[Token(Token = "0x4000E84")]
	private static readonly float BatteryFire3Way1Time; //Field offset: 0x114
	[Token(Token = "0x4000E85")]
	private static readonly float BatteryFire3Way2Time; //Field offset: 0x118
	[Token(Token = "0x4000E86")]
	private static readonly float BatteryFire3Way3Time; //Field offset: 0x11C
	[Token(Token = "0x4000E87")]
	private static readonly float Pattern4_ArmChangeTime; //Field offset: 0x120
	[Token(Token = "0x4000E88")]
	private static readonly float Pattern4_CircuitTime; //Field offset: 0x124
	[Token(Token = "0x4000E89")]
	private static readonly float Pattern4_FaceRotateSpeedMin; //Field offset: 0x128
	[Token(Token = "0x4000E8A")]
	private static readonly float Pattern4_FaceRotateSpeedMax; //Field offset: 0x12C
	[Token(Token = "0x4000E8B")]
	private static readonly float Pattern4_HomingAttackTime; //Field offset: 0x130
	[Token(Token = "0x4000E8C")]
	private static readonly float Pattern4_HomingAttackInterval; //Field offset: 0x134
	[Token(Token = "0x4000E8D")]
	private static readonly float Pattern4_BatteryAttackTime; //Field offset: 0x138
	[Token(Token = "0x4000E8E")]
	private static readonly float Pattern4_CoverAttackInterval; //Field offset: 0x13C
	[Token(Token = "0x4000E8F")]
	private static readonly float Pattern4_CoverAttackCount; //Field offset: 0x140
	[Token(Token = "0x4000E90")]
	private static readonly float Pattern6_CircuitTime; //Field offset: 0x144
	[Token(Token = "0x4000E91")]
	private static readonly float Pattern6_HomingTime; //Field offset: 0x148
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4000E38")]
	private Boss07State _bos07state; //Field offset: 0x270
	[FieldOffset(Offset = "0x274")]
	[Token(Token = "0x4000E39")]
	private float _localTime; //Field offset: 0x274
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4000E3B")]
	private readonly int MuzzleCount; //Field offset: 0x278
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4000E3C")]
	private Transform[] _muzzles; //Field offset: 0x280
	[FieldOffset(Offset = "0x288")]
	[SerializeField]
	[Token(Token = "0x4000E3D")]
	private Transform[] _legs40; //Field offset: 0x288
	[FieldOffset(Offset = "0x290")]
	[SerializeField]
	[Token(Token = "0x4000E3E")]
	private Transform[] _legs60; //Field offset: 0x290
	[FieldOffset(Offset = "0x298")]
	[SerializeField]
	[Token(Token = "0x4000E3F")]
	private Transform[] _batteries; //Field offset: 0x298
	[FieldOffset(Offset = "0x2A0")]
	[SerializeField]
	[Token(Token = "0x4000E40")]
	private Transform _arm40; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A8")]
	[SerializeField]
	[Token(Token = "0x4000E41")]
	private Transform _arm60; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2B0")]
	[SerializeField]
	[Token(Token = "0x4000E42")]
	private Transform _turretPivot; //Field offset: 0x2B0
	[FieldOffset(Offset = "0x2B8")]
	[SerializeField]
	[Token(Token = "0x4000E43")]
	private Transform _faceCover; //Field offset: 0x2B8
	[FieldOffset(Offset = "0x2C0")]
	[SerializeField]
	[Token(Token = "0x4000E44")]
	private Transform _mainBody; //Field offset: 0x2C0
	[FieldOffset(Offset = "0x2C8")]
	[SerializeField]
	[Token(Token = "0x4000E45")]
	private AnimationCurve _lungeBodyCurve; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2D0")]
	[SerializeField]
	[Token(Token = "0x4000E46")]
	private AnimationCurve _lungeArmCurve; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x4000E47")]
	private int _legCount; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2DC")]
	[Token(Token = "0x4000E48")]
	private bool _isReverseMove; //Field offset: 0x2DC
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x4000E4A")]
	private Quaternion[] _leg40start; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x4000E4B")]
	private Quaternion[] _leg40end; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x4000E4C")]
	private Quaternion[] _leg60start; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x4000E4D")]
	private Quaternion[] _leg60end; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x4000E4E")]
	private bool _isLeftMove; //Field offset: 0x300
	[FieldOffset(Offset = "0x301")]
	[Token(Token = "0x4000E4F")]
	private bool _isRightMove; //Field offset: 0x301
	[FieldOffset(Offset = "0x302")]
	[Token(Token = "0x4000E50")]
	private bool _isLegBroken; //Field offset: 0x302
	[FieldOffset(Offset = "0x303")]
	[Token(Token = "0x4000E51")]
	private bool _isArmBroken; //Field offset: 0x303
	[FieldOffset(Offset = "0x304")]
	[Token(Token = "0x4000E52")]
	private bool _prevLeftLegBroken; //Field offset: 0x304
	[FieldOffset(Offset = "0x305")]
	[Token(Token = "0x4000E53")]
	private bool _prevRightLegBroken; //Field offset: 0x305
	[FieldOffset(Offset = "0x308")]
	[Token(Token = "0x4000E54")]
	private float _leg40DamagedPower; //Field offset: 0x308
	[FieldOffset(Offset = "0x30C")]
	[Token(Token = "0x4000E55")]
	private float _leg60DamagedPower; //Field offset: 0x30C
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x4000E56")]
	private float _attackCount; //Field offset: 0x310
	[FieldOffset(Offset = "0x314")]
	[Token(Token = "0x4000E57")]
	private bool _isLeftAttack; //Field offset: 0x314
	[FieldOffset(Offset = "0x315")]
	[Token(Token = "0x4000E58")]
	private bool _isRightAttack; //Field offset: 0x315
	[FieldOffset(Offset = "0x318")]
	[Token(Token = "0x4000E59")]
	private float _batteryFireTime; //Field offset: 0x318
	[FieldOffset(Offset = "0x31C")]
	[Token(Token = "0x4000E5A")]
	private float _lungeRate; //Field offset: 0x31C
	[FieldOffset(Offset = "0x320")]
	[Token(Token = "0x4000E5B")]
	private float _lungeRateLast; //Field offset: 0x320
	[FieldOffset(Offset = "0x324")]
	[Token(Token = "0x4000E5C")]
	private float _circuitTime; //Field offset: 0x324
	[FieldOffset(Offset = "0x328")]
	[Token(Token = "0x4000E5D")]
	private float _circuitEaseRate; //Field offset: 0x328
	[FieldOffset(Offset = "0x32C")]
	[Token(Token = "0x4000E5E")]
	private float _faceCoverSpeed; //Field offset: 0x32C
	[FieldOffset(Offset = "0x330")]
	[Token(Token = "0x4000E5F")]
	private float _homingStartAngle; //Field offset: 0x330
	[FieldOffset(Offset = "0x334")]
	[Token(Token = "0x4000E60")]
	private float _homingTargetAngle; //Field offset: 0x334
	[FieldOffset(Offset = "0x338")]
	[Token(Token = "0x4000E61")]
	private float _homingTime; //Field offset: 0x338
	[FieldOffset(Offset = "0x33C")]
	[Token(Token = "0x4000E62")]
	private float _homingDuration; //Field offset: 0x33C
	[FieldOffset(Offset = "0x340")]
	[Token(Token = "0x4000E63")]
	private Vector3 _lastLocalPosition; //Field offset: 0x340

	[Address(RVA = "0x1DA7580", Offset = "0x1DA6980", Length = "0x982")]
	[Token(Token = "0x6000D53")]
	private static Ene_Bos07() { }

	[Address(RVA = "0x1DA7F10", Offset = "0x1DA7310", Length = "0xFF")]
	[Token(Token = "0x6000D52")]
	public Ene_Bos07() { }

	[Address(RVA = "0x1DA67D0", Offset = "0x1DA5BD0", Length = "0x78")]
	[CompilerGenerated]
	[Token(Token = "0x6000D55")]
	internal static Vector3 <GetTangentPoints>g__Rotate|126_0(Vector3 vector, float angleRad) { }

	[Address(RVA = "0x1DA6850", Offset = "0x1DA5C50", Length = "0x706")]
	[CompilerGenerated]
	[Token(Token = "0x6000D54")]
	private void <HomingLeg>g__calc|125_0(float deltaTime, Transform selfNode, Transform parentNode, float defaultRotate, bool isLeftLeg, float minAngle, float maxAngle, ref <>c__DisplayClass125_0 unnamed_param_7) { }

	[Address(RVA = "0x1DA6F60", Offset = "0x1DA6360", Length = "0xF1")]
	[CompilerGenerated]
	[Token(Token = "0x6000D56")]
	private void <PatternMove4>g__UpdateMoveTime|129_0(float deltaTime, float loopTime) { }

	[Address(RVA = "0x1DA7060", Offset = "0x1DA6460", Length = "0xCB")]
	[CompilerGenerated]
	[Token(Token = "0x6000D59")]
	private void <PatternMove6>g__HomingBody|131_2(float deltaTime) { }

	[Address(RVA = "0x1DA7130", Offset = "0x1DA6530", Length = "0x350")]
	[CompilerGenerated]
	[Token(Token = "0x6000D58")]
	private void <PatternMove6>g__SetHomingAngle|131_1(bool isHoming, float duration) { }

	[Address(RVA = "0x1DA7490", Offset = "0x1DA6890", Length = "0xE1")]
	[CompilerGenerated]
	[Token(Token = "0x6000D57")]
	private bool <PatternMove6>g__UpdateCircuitMove|131_0(float deltaTime) { }

	[Address(RVA = "0x1DA07E0", Offset = "0x1D9FBE0", Length = "0x123")]
	[Token(Token = "0x6000D2F")]
	public virtual float AddDamageParts(float damage, int parts, int pno, bool isExboost) { }

	[Address(RVA = "0x1DA0910", Offset = "0x1D9FD10", Length = "0x2D0")]
	[Token(Token = "0x6000D46")]
	private void BCFire(bool beam, bool bullet) { }

	[Address(RVA = "0x1DA0BF0", Offset = "0x1D9FFF0", Length = "0x130")]
	[Token(Token = "0x6000D47")]
	private void BCMove(float moveRate, Vector3 positionOffset) { }

	[Address(RVA = "0x1DA0D30", Offset = "0x1DA0130", Length = "0x248")]
	[Token(Token = "0x6000D34")]
	private void CheckNextState() { }

	[Address(RVA = "0x1DA0FA0", Offset = "0x1DA03A0", Length = "0x1DD")]
	[Token(Token = "0x6000D3E")]
	private void FaceCoverRotate(float rot) { }

	[Address(RVA = "0x1DA1180", Offset = "0x1DA0580", Length = "0x4E")]
	[Token(Token = "0x6000D3F")]
	protected virtual String[] GetBossBT() { }

	[Address(RVA = "0x1DA11D0", Offset = "0x1DA05D0", Length = "0x2E")]
	[Token(Token = "0x6000D40")]
	private Transform GetMuzzle(Boss07MZ mz) { }

	[Address(RVA = "0x1DA1200", Offset = "0x1DA0600", Length = "0xDB")]
	[Token(Token = "0x6000D51")]
	protected virtual Vector3 GetSmallBombPosition() { }

	[Address(RVA = "0x1D7E4B0", Offset = "0x1D7D8B0", Length = "0x25")]
	[Token(Token = "0x6000D2D")]
	public virtual void GetStart() { }

	[Address(RVA = "0x1DA12E0", Offset = "0x1DA06E0", Length = "0x275")]
	[Token(Token = "0x6000D49")]
	private bool GetTangentPoints(Vector3 a, Vector3 b, float r, out Vector3 contact1, out Vector3 contact2) { }

	[Address(RVA = "0x1DA1560", Offset = "0x1DA0960", Length = "0x2E3")]
	[Token(Token = "0x6000D48")]
	private void HomingLeg(float deltaTime) { }

	[Address(RVA = "0x1DA1850", Offset = "0x1DA0C50", Length = "0x496")]
	[Token(Token = "0x6000D2B")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1DA1D80", Offset = "0x1DA1180", Length = "0x53")]
	[Token(Token = "0x6000D3C")]
	private bool IsArmBroken() { }

	[Address(RVA = "0x1DA1CF0", Offset = "0x1DA10F0", Length = "0x89")]
	[Token(Token = "0x6000D33")]
	private bool IsArmBrokenOrDifficultyUp() { }

	[Address(RVA = "0x1DA1DE0", Offset = "0x1DA11E0", Length = "0x53")]
	[Token(Token = "0x6000D3B")]
	private bool IsBothLegBroken() { }

	[Address(RVA = "0x1DA1E40", Offset = "0x1DA1240", Length = "0x53")]
	[Token(Token = "0x6000D3A")]
	private bool IsEitherLegBroken() { }

	[Address(RVA = "0x1DA1EA0", Offset = "0x1DA12A0", Length = "0x34")]
	[Token(Token = "0x6000D3D")]
	private bool IsFireOK() { }

	[Address(RVA = "0x1DA1EE0", Offset = "0x1DA12E0", Length = "0x27")]
	[Token(Token = "0x6000D38")]
	private bool IsLeftLegBroken() { }

	[Address(RVA = "0x1DA1F10", Offset = "0x1DA1310", Length = "0x89")]
	[Token(Token = "0x6000D32")]
	private bool IsLegBrokenOrDifficultyUp() { }

	[Address(RVA = "0x1DA1FA0", Offset = "0x1DA13A0", Length = "0x27")]
	[Token(Token = "0x6000D39")]
	private bool IsRightLegBroken() { }

	[Address(RVA = "0x1DA1FD0", Offset = "0x1DA13D0", Length = "0xA5A")]
	[Token(Token = "0x6000D4B")]
	private void LegOrBatteryFire(float deltaTime) { }

	[Address(RVA = "0x1DA2A30", Offset = "0x1DA1E30", Length = "0x39")]
	[Token(Token = "0x6000D30")]
	public virtual void OnPartsBreak(int parts) { }

	[Address(RVA = "0x1DA2A70", Offset = "0x1DA1E70", Length = "0x488")]
	[Token(Token = "0x6000D45")]
	private void PatternMove2(float deltaTime) { }

	[Address(RVA = "0x1DA3140", Offset = "0x1DA2540", Length = "0x274")]
	[Token(Token = "0x6000D4A")]
	private void PatternMove3(float deltaTime) { }

	[Address(RVA = "0x1DA3D30", Offset = "0x1DA3130", Length = "0x91A")]
	[Token(Token = "0x6000D4C")]
	private void PatternMove4(float deltaTime) { }

	[Address(RVA = "0x1DA4650", Offset = "0x1DA3A50", Length = "0x58D")]
	[Token(Token = "0x6000D4D")]
	private void PatternMove5(float deltaTime) { }

	[Address(RVA = "0x1DA4BE0", Offset = "0x1DA3FE0", Length = "0x51B")]
	[Token(Token = "0x6000D4E")]
	private void PatternMove6(float deltaTime) { }

	[Address(RVA = "0x1DA5100", Offset = "0x1DA4500", Length = "0x2B7")]
	[Token(Token = "0x6000D4F")]
	private void PatternMove7(float deltaTime) { }

	[Address(RVA = "0x1DA53C0", Offset = "0x1DA47C0", Length = "0x5D5")]
	[Token(Token = "0x6000D50")]
	private void PatternMoveDestruction(float deltaTime) { }

	[Address(RVA = "0x1DA59A0", Offset = "0x1DA4DA0", Length = "0x2DA")]
	[Token(Token = "0x6000D44")]
	private void PatternMoveEntryWait(float deltaTime) { }

	[Address(RVA = "0x1DA5F60", Offset = "0x1DA5360", Length = "0x57")]
	[Token(Token = "0x6000D42")]
	private void ProgressLegPattern(float rate) { }

	[Address(RVA = "0x1DA5C80", Offset = "0x1DA5080", Length = "0x2D4")]
	[Token(Token = "0x6000D43")]
	private void ProgressLegPatternSeparately(float rate1, float rate2, float rate3) { }

	[Address(RVA = "0x1DA5FC0", Offset = "0x1DA53C0", Length = "0x13E")]
	[Token(Token = "0x6000D2C")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1DA6100", Offset = "0x1DA5500", Length = "0x50")]
	[Token(Token = "0x6000D37")]
	private void SetArmBroken() { }

	[Address(RVA = "0x1DA6160", Offset = "0x1DA5560", Length = "0x4E")]
	[Token(Token = "0x6000D36")]
	private void SetLegBroken() { }

	[Address(RVA = "0x1DA61B0", Offset = "0x1DA55B0", Length = "0x85")]
	[Token(Token = "0x6000D35")]
	private void SetState(Boss07State tstate) { }

	[Address(RVA = "0x1DA6240", Offset = "0x1DA5640", Length = "0x358")]
	[Token(Token = "0x6000D41")]
	private void SetupLegPattern(LegPattern leftPattern, LegPattern rightPattern) { }

	[Address(RVA = "0x1DA65A0", Offset = "0x1DA59A0", Length = "0x154")]
	[Token(Token = "0x6000D31")]
	protected virtual void StateExec(float dt) { }

	[Address(RVA = "0x1DA6710", Offset = "0x1DA5B10", Length = "0xB6")]
	[Token(Token = "0x6000D2E")]
	public virtual void ToDestroid() { }

}

