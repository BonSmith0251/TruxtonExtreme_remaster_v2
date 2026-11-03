namespace InGame.Kernel.Enemy;

[Token(Token = "0x200019E")]
public class Ene_Bos05 : Ene_BosBase
{
	[CompilerGenerated]
	[Token(Token = "0x20001A6")]
	private sealed class <>c__DisplayClass123_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000D83")]
		public bool isLeftSide; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000CEB")]
		public <>c__DisplayClass123_0() { }

		[Address(RVA = "0x1D9F830", Offset = "0x1D9EC30", Length = "0xEC")]
		[Token(Token = "0x6000CEC")]
		internal void <_callLaser>g___generateCallback|0(InGameBulletInterface iblt) { }

	}

	[Token(Token = "0x20001A1")]
	private enum AttackId : int
	{
		FrontA = 0,
		FrontB = 1,
		Berry = 2,
		Eyes = 3,
		Legs = 4,
		Laser = 5,
		Max = 6,
	}

	[Token(Token = "0x20001A0")]
	private enum AttackPhase : int
	{
		First = 0,
		Second = 1,
		Max = 2,
	}

	[Token(Token = "0x20001A3")]
	private enum Boss05MZ : int
	{
		muzzle_body20 = 0,
		muzzle_body21 = 1,
		muzzle_turret_laser = 2,
		turret_edge = 3,
	}

	[Token(Token = "0x200019F")]
	private enum Boss05State : int
	{
		EntryWait = 0,
		PT1Shot = 1,
		PT4Laser = 2,
		PT6Belly = 3,
		GrowArm = 4,
		Destruction = 100,
	}

	[Token(Token = "0x20001A4")]
	internal class Ene_Bos05_Leg
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000D78")]
		public Transform _muzzle; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000D79")]
		public MeshRenderer _upper; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000D7A")]
		public MeshRenderer _lower; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000CEA")]
		public Ene_Bos05_Leg() { }

	}

	[Token(Token = "0x20001A5")]
	private enum LegId : int
	{
		leg10 = 0,
		leg40 = 1,
		leg70 = 2,
		leg30 = 3,
		leg60 = 4,
		leg90 = 5,
		maxLeg = 6,
	}

	[Token(Token = "0x20001A2")]
	private enum PartsKind : int
	{
		MainBody = 0,
		Arm40 = 1,
		Arm60 = 2,
		Leg40 = 3,
		Leg60 = 4,
	}

	[Token(Token = "0x4000D05")]
	private static readonly String[2] _BulletTemplateNames; //Field offset: 0x0
	[Token(Token = "0x4000D4F")]
	private const float _LaserCancelDissolveTime = 0.2; //Field offset: 0x0
	[Token(Token = "0x4000D06")]
	private static readonly float _LegHP66; //Field offset: 0x8
	[Token(Token = "0x4000D07")]
	private static readonly float _LegHP33; //Field offset: 0xC
	[Token(Token = "0x4000D08")]
	private static readonly float _LegHP00; //Field offset: 0x10
	[Token(Token = "0x4000D09")]
	private static readonly float _PhaseEventSecondElapsedTime; //Field offset: 0x14
	[Token(Token = "0x4000D0A")]
	private static readonly TimeSteps _PhaseEventSecondDifficulty; //Field offset: 0x18
	[Token(Token = "0x4000D0B")]
	private static readonly string _MuzzlePackTurret; //Field offset: 0x20
	[Token(Token = "0x4000D0C")]
	private static readonly String[] _Boss05ClipDatas; //Field offset: 0x28
	[Token(Token = "0x4000D0D")]
	private static readonly EnemyChildData[] _Bos05childdatas; //Field offset: 0x30
	[Token(Token = "0x4000D0E")]
	private static readonly int MuzzleCount; //Field offset: 0x38
	[Token(Token = "0x4000D10")]
	private static readonly Single[] _LegAngle; //Field offset: 0x40
	[Token(Token = "0x4000D38")]
	private static readonly float PI2; //Field offset: 0x48
	[Token(Token = "0x4000D39")]
	private static readonly float _EntryNoHitTime; //Field offset: 0x4C
	[Token(Token = "0x4000D3A")]
	private static readonly float _FloatHorizonTime; //Field offset: 0x50
	[Token(Token = "0x4000D3B")]
	private static readonly float _FloatHorizonDistance; //Field offset: 0x54
	[Token(Token = "0x4000D3C")]
	private static readonly float _FloatVerticalTime; //Field offset: 0x58
	[Token(Token = "0x4000D3D")]
	private static readonly float _FloatVerticalDistance; //Field offset: 0x5C
	[Token(Token = "0x4000D3E")]
	private static readonly float _FloatAutoRecoverTime; //Field offset: 0x60
	[Token(Token = "0x4000D3F")]
	private static readonly float _ShotWait1_Turret; //Field offset: 0x64
	[Token(Token = "0x4000D40")]
	private static readonly float _ShotWait2_Leg; //Field offset: 0x68
	[Token(Token = "0x4000D41")]
	private static readonly float _ShotWait3_Body; //Field offset: 0x6C
	[Token(Token = "0x4000D42")]
	private static readonly Vector3 _arm40Inner; //Field offset: 0x70
	[Token(Token = "0x4000D43")]
	private static readonly Vector3 _arm60Inner; //Field offset: 0x7C
	[Token(Token = "0x4000D44")]
	private static readonly Vector3 _armMeshInner; //Field offset: 0x88
	[Token(Token = "0x4000D45")]
	private static readonly float _LaserPositonX; //Field offset: 0x94
	[Token(Token = "0x4000D46")]
	private static readonly float _ArmFireInterval; //Field offset: 0x98
	[Token(Token = "0x4000D47")]
	private static readonly float _LaserStartPositionMoveTime; //Field offset: 0x9C
	[Token(Token = "0x4000D48")]
	private static readonly float _LaserEndPositionMoveTime; //Field offset: 0xA0
	[Token(Token = "0x4000D49")]
	private static readonly float _LaserTurretWaitTime; //Field offset: 0xA4
	[Token(Token = "0x4000D4A")]
	private static readonly float _LaserTurretMoveTime; //Field offset: 0xA8
	[Token(Token = "0x4000D4B")]
	private static readonly float _TurretRestoreSpeed; //Field offset: 0xAC
	[Token(Token = "0x4000D4C")]
	private static readonly float _LaserTurretChargeTime; //Field offset: 0xB0
	[Token(Token = "0x4000D4D")]
	private static readonly float _LaserHomingTime; //Field offset: 0xB4
	[Token(Token = "0x4000D4E")]
	private static readonly float _LaserEndTime; //Field offset: 0xB8
	[Token(Token = "0x4000D50")]
	private static readonly float _LaserStartAngle; //Field offset: 0xBC
	[Token(Token = "0x4000D51")]
	private static readonly float _LaserEndAngle; //Field offset: 0xC0
	[Token(Token = "0x4000D52")]
	private static readonly int _ArmGenerateLimitCount; //Field offset: 0xC4
	[Token(Token = "0x4000D53")]
	private static readonly bool _ArmDestroyCountResetAfterLaser; //Field offset: 0xC8
	[Token(Token = "0x4000D54")]
	private static readonly int _ArmLimitCount1; //Field offset: 0xCC
	[Token(Token = "0x4000D55")]
	private static readonly int _ArmLimitCount2; //Field offset: 0xD0
	[Token(Token = "0x4000D56")]
	private static readonly float _BellyTurnTime; //Field offset: 0xD4
	[Token(Token = "0x4000D57")]
	private static readonly float _BellyTurnAngleX; //Field offset: 0xD8
	[Token(Token = "0x4000D58")]
	private static readonly float _BellyFireInternval; //Field offset: 0xDC
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4000D0F")]
	private Transform[] _muzzles; //Field offset: 0x270
	[FieldOffset(Offset = "0x278")]
	[SerializeField]
	[Token(Token = "0x4000D11")]
	private Ene_Bos05_Leg[] _BreakableLegs; //Field offset: 0x278
	[FieldOffset(Offset = "0x280")]
	[SerializeField]
	[Token(Token = "0x4000D12")]
	private Transform _Turret; //Field offset: 0x280
	[FieldOffset(Offset = "0x288")]
	[SerializeField]
	[Token(Token = "0x4000D13")]
	private Transform _Arm40; //Field offset: 0x288
	[FieldOffset(Offset = "0x290")]
	[SerializeField]
	[Token(Token = "0x4000D14")]
	private Transform _Arm60; //Field offset: 0x290
	[FieldOffset(Offset = "0x298")]
	[SerializeField]
	[Token(Token = "0x4000D15")]
	private Transform _Arm40Mesh; //Field offset: 0x298
	[FieldOffset(Offset = "0x2A0")]
	[SerializeField]
	[Token(Token = "0x4000D16")]
	private Transform _Arm60Mesh; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A8")]
	[SerializeField]
	[Token(Token = "0x4000D17")]
	private Transform _Arm40Scale; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2B0")]
	[SerializeField]
	[Token(Token = "0x4000D18")]
	private Transform _Arm60Scale; //Field offset: 0x2B0
	[FieldOffset(Offset = "0x2B8")]
	[Token(Token = "0x4000D19")]
	private Boss05State _bos05state; //Field offset: 0x2B8
	[FieldOffset(Offset = "0x2BC")]
	[Token(Token = "0x4000D1A")]
	private int _armSEId; //Field offset: 0x2BC
	[FieldOffset(Offset = "0x2C0")]
	[Token(Token = "0x4000D1B")]
	private float _localTime; //Field offset: 0x2C0
	[FieldOffset(Offset = "0x2C4")]
	[Token(Token = "0x4000D1C")]
	private HitPState _lastHPState; //Field offset: 0x2C4
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x4000D1D")]
	private AttackPhase _attackPhase; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x4000D1E")]
	private List<String> _bulletTemplateList; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x4000D1F")]
	private Int32[2] _bulletTemplateTable; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x4000D20")]
	private float _turretRY; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E4")]
	[Token(Token = "0x4000D21")]
	private float _turretStartY; //Field offset: 0x2E4
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x4000D22")]
	private float _turretTargetY; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2EC")]
	[Token(Token = "0x4000D23")]
	private float _turretMoveWait; //Field offset: 0x2EC
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x4000D24")]
	private float _turretPassd; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F4")]
	[Token(Token = "0x4000D25")]
	private float _laserTime; //Field offset: 0x2F4
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x4000D26")]
	private Vector3 _centerPosition; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x304")]
	[Token(Token = "0x4000D27")]
	private float _floatTimerX; //Field offset: 0x304
	[FieldOffset(Offset = "0x308")]
	[Token(Token = "0x4000D28")]
	private float _floatTimerZ; //Field offset: 0x308
	[FieldOffset(Offset = "0x30C")]
	[Token(Token = "0x4000D29")]
	private float _floatSpeed; //Field offset: 0x30C
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x4000D2A")]
	private Vector3 _overridePosition; //Field offset: 0x310
	[FieldOffset(Offset = "0x31C")]
	[Token(Token = "0x4000D2B")]
	private float _overridePositionRate; //Field offset: 0x31C
	[FieldOffset(Offset = "0x320")]
	[Token(Token = "0x4000D2C")]
	private bool _isArmPurged; //Field offset: 0x320
	[FieldOffset(Offset = "0x321")]
	[Token(Token = "0x4000D2D")]
	private bool _isLeftMove; //Field offset: 0x321
	[FieldOffset(Offset = "0x322")]
	[Token(Token = "0x4000D2E")]
	private bool _isLaserMove; //Field offset: 0x322
	[FieldOffset(Offset = "0x324")]
	[Token(Token = "0x4000D2F")]
	private float _laserMoveRate; //Field offset: 0x324
	[FieldOffset(Offset = "0x328")]
	[Token(Token = "0x4000D30")]
	private float _laserWaitTime; //Field offset: 0x328
	[FieldOffset(Offset = "0x32C")]
	[Token(Token = "0x4000D31")]
	private float _armFireInterval; //Field offset: 0x32C
	[FieldOffset(Offset = "0x330")]
	[Token(Token = "0x4000D32")]
	private int _arm40DestroyCount; //Field offset: 0x330
	[FieldOffset(Offset = "0x334")]
	[Token(Token = "0x4000D33")]
	private int _arm60DestroyCount; //Field offset: 0x334
	[FieldOffset(Offset = "0x338")]
	[Token(Token = "0x4000D34")]
	private int _armCount; //Field offset: 0x338
	[FieldOffset(Offset = "0x33C")]
	[Token(Token = "0x4000D35")]
	private bool _isFired; //Field offset: 0x33C
	[FieldOffset(Offset = "0x340")]
	[Token(Token = "0x4000D36")]
	private float _legHitPoint40; //Field offset: 0x340
	[FieldOffset(Offset = "0x344")]
	[Token(Token = "0x4000D37")]
	private float _legHitPoint60; //Field offset: 0x344
	[FieldOffset(Offset = "0x348")]
	[Token(Token = "0x4000D59")]
	private int _fireCount; //Field offset: 0x348

	[Address(RVA = "0x1D99690", Offset = "0x1D98A90", Length = "0xAAF")]
	[Token(Token = "0x6000CDE")]
	private void _callArmClips(float deltaTime) { }

	[Address(RVA = "0x1D9A140", Offset = "0x1D99540", Length = "0x1BC")]
	[Token(Token = "0x6000CDD")]
	private float _callLaser(bool isLeftSide) { }

	[Address(RVA = "0x1D9A300", Offset = "0x1D99700", Length = "0x95C")]
	[Token(Token = "0x6000CE9")]
	private static Ene_Bos05() { }

	[Address(RVA = "0x1D9AC60", Offset = "0x1D9A060", Length = "0xE5")]
	[Token(Token = "0x6000CE8")]
	public Ene_Bos05() { }

	[Address(RVA = "0x1D92FA0", Offset = "0x1D923A0", Length = "0x4F")]
	[Token(Token = "0x6000CC4")]
	public virtual float AddDamageParts(float damage, int partNo, int playerNo, bool isExboost) { }

	[Address(RVA = "0x1D94A30", Offset = "0x1D93E30", Length = "0x20F")]
	[Token(Token = "0x6000CD9")]
	private void BreakAllLegs() { }

	[Address(RVA = "0x1D94C40", Offset = "0x1D94040", Length = "0x12")]
	[Token(Token = "0x6000CDC")]
	public void BreakArm(bool leftArm) { }

	[Address(RVA = "0x1D94E80", Offset = "0x1D94280", Length = "0x1E5")]
	[Token(Token = "0x6000CD8")]
	private void BreakLeg(LegId legId) { }

	[Address(RVA = "0x1D94C60", Offset = "0x1D94060", Length = "0x21E")]
	[Token(Token = "0x6000CDB")]
	private bool BreakLegFire() { }

	[Address(RVA = "0x1D95070", Offset = "0x1D94470", Length = "0x3ED")]
	[Token(Token = "0x6000CC6")]
	private void BreakParts(int partNo) { }

	[Address(RVA = "0x1D95460", Offset = "0x1D94860", Length = "0x8D")]
	[Token(Token = "0x6000CC7")]
	private void CancelLaser() { }

	[Address(RVA = "0x1D954F0", Offset = "0x1D948F0", Length = "0x27")]
	[Token(Token = "0x6000CC8")]
	private void CheckHPEvent() { }

	[Address(RVA = "0x1D95520", Offset = "0x1D94920", Length = "0x99")]
	[Token(Token = "0x6000CCB")]
	private void CheckNextState() { }

	[Address(RVA = "0x1D955C0", Offset = "0x1D949C0", Length = "0xB2")]
	[Token(Token = "0x6000CC9")]
	private void CheckTimeEvent() { }

	[Address(RVA = "0x1D95680", Offset = "0x1D94A80", Length = "0x56")]
	[Token(Token = "0x6000CD3")]
	protected virtual String[] GetBossBT() { }

	[Address(RVA = "0x1D956E0", Offset = "0x1D94AE0", Length = "0x4F")]
	[Token(Token = "0x6000CD5")]
	protected virtual String[] GetBossCD() { }

	[Address(RVA = "0x1D95730", Offset = "0x1D94B30", Length = "0x4A")]
	[Token(Token = "0x6000CD4")]
	private BulletTemplate GetBulletTemplate(AttackPhase phase, AttackId attack) { }

	[Address(RVA = "0x1D95780", Offset = "0x1D94B80", Length = "0x2E")]
	[Token(Token = "0x6000CD7")]
	private Transform GetMuzzle(Boss05MZ mz) { }

	[Address(RVA = "0x1D957B0", Offset = "0x1D94BB0", Length = "0x157")]
	[Token(Token = "0x6000CE7")]
	protected virtual Vector3 GetSmallBombPosition() { }

	[Address(RVA = "0x1D95910", Offset = "0x1D94D10", Length = "0x7F")]
	[Token(Token = "0x6000CC0")]
	public virtual void GetStart() { }

	[Address(RVA = "0x1D95990", Offset = "0x1D94D90", Length = "0x232")]
	[Token(Token = "0x6000CCA")]
	private void HalfInterruptEvent() { }

	[Address(RVA = "0x1D95BD0", Offset = "0x1D94FD0", Length = "0x54B")]
	[Token(Token = "0x6000CBE")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D96120", Offset = "0x1D95520", Length = "0x34")]
	[Token(Token = "0x6000CCD")]
	private bool IsFireOK() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000CC2")]
	public virtual bool IsPoseRecord() { }

	[Address(RVA = "0x1D96160", Offset = "0x1D95560", Length = "0x2D6")]
	[Token(Token = "0x6000CE0")]
	private Vector3 MoveAround(float deltaTime, bool enableHorizon, bool enableVertical) { }

	[Address(RVA = "0x1D96440", Offset = "0x1D95840", Length = "0x50")]
	[Token(Token = "0x6000CC5")]
	public virtual void OnPartsBreak(int partNo) { }

	[Address(RVA = "0x1D96490", Offset = "0x1D95890", Length = "0x15B")]
	[Token(Token = "0x6000CE1")]
	private void PatternEntry(float deltaTime) { }

	[Address(RVA = "0x1D965F0", Offset = "0x1D959F0", Length = "0x42C")]
	[Token(Token = "0x6000CE2")]
	private void PatternMove1(float deltaTime) { }

	[Address(RVA = "0x1D96A20", Offset = "0x1D95E20", Length = "0xDD4")]
	[Token(Token = "0x6000CE3")]
	private void PatternMove4(float deltaTime) { }

	[Address(RVA = "0x1D97840", Offset = "0x1D96C40", Length = "0x610")]
	[Token(Token = "0x6000CE4")]
	private void PatternMove6(float deltaTime) { }

	[Address(RVA = "0x1D97E60", Offset = "0x1D97260", Length = "0x5E0")]
	[Token(Token = "0x6000CE6")]
	private void PatternMoveDestruction(float dt) { }

	[Address(RVA = "0x1D98450", Offset = "0x1D97850", Length = "0x606")]
	[Token(Token = "0x6000CE5")]
	private void PatternMoveGrowArm(float deltaTime) { }

	[Address(RVA = "0x1D98C40", Offset = "0x1D98040", Length = "0x93")]
	[Token(Token = "0x6000CDA")]
	private void ResetBreakLegs() { }

	[Address(RVA = "0x1D98CE0", Offset = "0x1D980E0", Length = "0x72")]
	[Token(Token = "0x6000CDF")]
	private void ResetMoveAround() { }

	[Address(RVA = "0x1D98A60", Offset = "0x1D97E60", Length = "0x1D4")]
	[Token(Token = "0x6000CBF")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1D98D60", Offset = "0x1D98160", Length = "0xA0")]
	[Token(Token = "0x6000CCE")]
	private void SetPartAttribute(PartsKind partNo, EnemyCollisionAttribute attribute, bool isSet) { }

	[Address(RVA = "0x1D98E10", Offset = "0x1D98210", Length = "0x11")]
	[Token(Token = "0x6000CCC")]
	private void SetState(Boss05State tstate) { }

	[Address(RVA = "0x1D98E30", Offset = "0x1D98230", Length = "0x84")]
	[Token(Token = "0x6000CCF")]
	private void ShowArms(bool isLeft, bool isShow) { }

	[Address(RVA = "0x1D98EC0", Offset = "0x1D982C0", Length = "0x29B")]
	[Token(Token = "0x6000CC3")]
	protected virtual void StateExec(float dt) { }

	[Address(RVA = "0x1D99160", Offset = "0x1D98560", Length = "0x4F")]
	[Token(Token = "0x6000CD6")]
	public virtual EnemyChildData[] SubEnemys() { }

	[Address(RVA = "0x1D991B0", Offset = "0x1D985B0", Length = "0xE7")]
	[Token(Token = "0x6000CC1")]
	public virtual void ToDestroid() { }

	[Address(RVA = "0x1D992A0", Offset = "0x1D986A0", Length = "0x1C2")]
	[Token(Token = "0x6000CD2")]
	private void TurretLookAt(float deltaTime, EasingType easingType, bool toHome = false) { }

	[Address(RVA = "0x1D99470", Offset = "0x1D98870", Length = "0x113")]
	[Token(Token = "0x6000CD0")]
	private bool TurretRotate(float deltaTime, EasingType easingType) { }

	[Address(RVA = "0x1D99590", Offset = "0x1D98990", Length = "0xF5")]
	[Token(Token = "0x6000CD1")]
	private bool TurretToFront(float stepAngle) { }

}

