namespace InGame.Kernel.Player;

[Token(Token = "0x2000132")]
public class WeaponLaserCollision : WeaponCollisionBase
{
	[Token(Token = "0x2000133")]
	internal class VfxSet
	{
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x40008C3")]
		public VisualEffect _vfx; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Token(Token = "0x40008C4")]
		public float _normalThickness; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Token(Token = "0x40008C5")]
		public float _normalNoisePower; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Token(Token = "0x40008C6")]
		public float _normalNoiseSpeed; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Token(Token = "0x40008C7")]
		public Texture _normalTex; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Token(Token = "0x40008C8")]
		public float _exBoostThickness; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Token(Token = "0x40008C9")]
		public float _exBoostNoisePower; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Token(Token = "0x40008CA")]
		public float _exBoostNoiseSpeed; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Token(Token = "0x40008CB")]
		public Texture _exBoostTex; //Field offset: 0x40

		[Address(RVA = "0x1D74600", Offset = "0x1D73A00", Length = "0x2A")]
		[Token(Token = "0x60009A6")]
		public VfxSet() { }

	}

	[Token(Token = "0x40008B0")]
	private const float nLaserWaveStart = 100; //Field offset: 0x0
	[Token(Token = "0x40008AF")]
	private const float nLaserMaxLength = 360; //Field offset: 0x0
	[Token(Token = "0x40008AC")]
	protected static readonly float _laserLimitZ; //Field offset: 0x0
	[Token(Token = "0x40008AE")]
	protected static Vector3 _laserLimitD; //Field offset: 0x4
	[Token(Token = "0x40008B1")]
	private static readonly Vector2 _texScale; //Field offset: 0x10
	[Token(Token = "0x40008B2")]
	private static readonly Vector2 _texScaleBoost; //Field offset: 0x18
	[Token(Token = "0x40008B3")]
	private static readonly Vector3 _playerLockOnScale; //Field offset: 0x20
	[Token(Token = "0x40008BD")]
	private static readonly int _vfxPropPos1; //Field offset: 0x2C
	[Token(Token = "0x40008BE")]
	private static readonly int _vfxPropPos2; //Field offset: 0x30
	[Token(Token = "0x40008BF")]
	private static readonly int _vfxPropPos3; //Field offset: 0x34
	[Token(Token = "0x40008C0")]
	private static readonly int _vfxPropPos4; //Field offset: 0x38
	[Token(Token = "0x40008C1")]
	private static readonly int _vfxPropTexTiling; //Field offset: 0x3C
	[Token(Token = "0x40008C2")]
	private static readonly int _vfxPropDeltaTime; //Field offset: 0x40
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400088C")]
	protected Vector3 _localDirection; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x400088D")]
	protected Vector3 _lockOnPosition; //Field offset: 0xC4
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400088E")]
	private Vector3 _laserDirection; //Field offset: 0xD0
	[FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x400088F")]
	private Vector3 _collisionDirection; //Field offset: 0xDC
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000890")]
	protected Vector3 _startPosition; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x4000891")]
	protected Vector3 _endPosition; //Field offset: 0xF4
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x4000892")]
	private EffectCode _hitEffectCode; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x4000893")]
	private InGameObject _inGameObject; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x4000894")]
	private InGameObject _laserMainObject; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Token(Token = "0x4000895")]
	protected InGameEffectSwapper _laserTips; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x4000896")]
	private ID _lockOnSE; //Field offset: 0x120
	[FieldOffset(Offset = "0x124")]
	[Token(Token = "0x4000897")]
	private float _tipRate; //Field offset: 0x124
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000898")]
	protected float _speed; //Field offset: 0x128
	[FieldOffset(Offset = "0x12C")]
	[Token(Token = "0x4000899")]
	private float _distance; //Field offset: 0x12C
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x400089A")]
	private float _waveSwap; //Field offset: 0x130
	[FieldOffset(Offset = "0x134")]
	[Token(Token = "0x400089B")]
	private float _wave0; //Field offset: 0x134
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x400089C")]
	private float _wave1; //Field offset: 0x138
	[FieldOffset(Offset = "0x13C")]
	[Token(Token = "0x400089D")]
	private float _mostNearLockOnDistance; //Field offset: 0x13C
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400089E")]
	protected HybridCollisionBridge _lockOnEnemy; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x400089F")]
	private Transform _laserTipsRoot; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x40008A0")]
	private bool _isChildLaser; //Field offset: 0x150
	[FieldOffset(Offset = "0x151")]
	[Token(Token = "0x40008A1")]
	private bool _isBlocked; //Field offset: 0x151
	[FieldOffset(Offset = "0x152")]
	[Token(Token = "0x40008A2")]
	private bool _isWaveSwitch; //Field offset: 0x152
	[FieldOffset(Offset = "0x153")]
	[Token(Token = "0x40008A3")]
	protected bool _isLockOn; //Field offset: 0x153
	[FieldOffset(Offset = "0x154")]
	[Token(Token = "0x40008A4")]
	private bool _isPlayerLockon; //Field offset: 0x154
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x40008A5")]
	private Vector2 _tiling; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x40008A6")]
	private Vector3 _lpos1; //Field offset: 0x160
	[FieldOffset(Offset = "0x16C")]
	[Token(Token = "0x40008A7")]
	private Vector3 _lpos2; //Field offset: 0x16C
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x40008A8")]
	private Vector3 _lpos3; //Field offset: 0x178
	[FieldOffset(Offset = "0x184")]
	[Token(Token = "0x40008A9")]
	private Vector3 _lpos4; //Field offset: 0x184
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x40008AA")]
	private Vector3 _hitEffectPosition; //Field offset: 0x190
	[FieldOffset(Offset = "0x19C")]
	[Token(Token = "0x40008AB")]
	private bool _isDisplayHitEffect; //Field offset: 0x19C
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x40008AD")]
	protected Vector3 _laserLimitS; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1AC")]
	[SerializeField]
	[Token(Token = "0x40008B4")]
	private bool _useVfxGraph; //Field offset: 0x1AC
	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	[Token(Token = "0x40008B5")]
	private List<VisualEffect> _vfxGraphs; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	[Token(Token = "0x40008B6")]
	private GameObject _vfxRoot; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	[Token(Token = "0x40008B7")]
	private Transform _vfxScale; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[SerializeField]
	[Token(Token = "0x40008B8")]
	private Transform _vfxRotate; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[SerializeField]
	[Token(Token = "0x40008B9")]
	private GameObject _vfxNormal; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D8")]
	[SerializeField]
	[Token(Token = "0x40008BA")]
	private GameObject _vfxExBoost; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E0")]
	[SerializeField]
	[Token(Token = "0x40008BB")]
	private float _texTilingLength; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E4")]
	[Token(Token = "0x40008BC")]
	private float _vfxTime; //Field offset: 0x1E4

	[Token(Token = "0x170001B6")]
	protected bool IsBlocked
	{
		[Address(RVA = "0x1D5FD70", Offset = "0x1D5F170", Length = "0x8")]
		[Token(Token = "0x60009A2")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001B5")]
	protected bool IsChildLaser
	{
		[Address(RVA = "0x1D5FD80", Offset = "0x1D5F180", Length = "0x8")]
		[Token(Token = "0x60009A1")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001B7")]
	protected bool IsLockOn
	{
		[Address(RVA = "0x1D5FD90", Offset = "0x1D5F190", Length = "0x8")]
		[Token(Token = "0x60009A3")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001B4")]
	public Transform LaserTipsRoot
	{
		[Address(RVA = "0x1D5FDB0", Offset = "0x1D5F1B0", Length = "0x8")]
		[Token(Token = "0x60009A0")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001B3")]
	protected float LDistance
	{
		[Address(RVA = "0x1D5FDA0", Offset = "0x1D5F1A0", Length = "0x9")]
		[Token(Token = "0x600099F")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x1D5E9A0", Offset = "0x1D5DDA0", Length = "0xE5")]
	[Token(Token = "0x600099D")]
	private void _ChangeTipEffect(bool isHit) { }

	[Address(RVA = "0x1D5EF00", Offset = "0x1D5E300", Length = "0xC5")]
	[Token(Token = "0x600099B")]
	protected float _getBlockStep(HybridCollisionBridge _moreNear) { }

	[Address(RVA = "0x1D5EFD0", Offset = "0x1D5E3D0", Length = "0x21")]
	[Token(Token = "0x600099C")]
	private float _getEnemyDistance(Vector3 p1, Vector3 p2) { }

	[Address(RVA = "0x1D5F000", Offset = "0x1D5E400", Length = "0x1E5")]
	[Token(Token = "0x6000999")]
	private HybridCollisionBridge _getMostNearTarget(Vector3 spos) { }

	[Address(RVA = "0x1D5F1F0", Offset = "0x1D5E5F0", Length = "0x29E")]
	[Token(Token = "0x6000992")]
	private void _hitEffectOnLaser() { }

	[Address(RVA = "0x1D5F490", Offset = "0x1D5E890", Length = "0x147")]
	[Token(Token = "0x6000990")]
	private void _updateCollisionShape(Vector3 tpos) { }

	[Address(RVA = "0x1D5F5E0", Offset = "0x1D5E9E0", Length = "0x208")]
	[Token(Token = "0x6000991")]
	private void _updateLaserLineAndTip() { }

	[Address(RVA = "0x1D5F7F0", Offset = "0x1D5EBF0", Length = "0x57F")]
	[Token(Token = "0x6000988")]
	private void _updateVfxParameter(float dt) { }

	[Address(RVA = "0x1D5EA90", Offset = "0x1D5DE90", Length = "0x1BF")]
	[Token(Token = "0x60009A5")]
	private static WeaponLaserCollision() { }

	[Address(RVA = "0x1D5EC50", Offset = "0x1D5E050", Length = "0x2A9")]
	[Token(Token = "0x60009A4")]
	public WeaponLaserCollision() { }

	[Address(RVA = "0x1D5C560", Offset = "0x1D5B960", Length = "0xC4")]
	[Token(Token = "0x600099E")]
	private void ChangeEffect() { }

	[Address(RVA = "0x1D5C630", Offset = "0x1D5BA30", Length = "0x19")]
	[Token(Token = "0x6000998")]
	protected override void ClearLockOnTarget() { }

	[Address(RVA = "0x1D5C650", Offset = "0x1D5BA50", Length = "0x16")]
	[Token(Token = "0x6000981")]
	protected virtual float ContiniousDamage() { }

	[Address(RVA = "0x1D5C670", Offset = "0x1D5BA70", Length = "0x7")]
	[Token(Token = "0x6000987")]
	public override void EndMove() { }

	[Address(RVA = "0x1D5C680", Offset = "0x1D5BA80", Length = "0x16")]
	[Token(Token = "0x6000980")]
	protected virtual float FirstDamage() { }

	[Address(RVA = "0x1D5FD70", Offset = "0x1D5F170", Length = "0x8")]
	[Token(Token = "0x60009A2")]
	protected bool get_IsBlocked() { }

	[Address(RVA = "0x1D5FD80", Offset = "0x1D5F180", Length = "0x8")]
	[Token(Token = "0x60009A1")]
	protected bool get_IsChildLaser() { }

	[Address(RVA = "0x1D5FD90", Offset = "0x1D5F190", Length = "0x8")]
	[Token(Token = "0x60009A3")]
	protected bool get_IsLockOn() { }

	[Address(RVA = "0x1D5FDB0", Offset = "0x1D5F1B0", Length = "0x8")]
	[Token(Token = "0x60009A0")]
	public Transform get_LaserTipsRoot() { }

	[Address(RVA = "0x1D5FDA0", Offset = "0x1D5F1A0", Length = "0x9")]
	[Token(Token = "0x600099F")]
	protected float get_LDistance() { }

	[Address(RVA = "0x1D5C6A0", Offset = "0x1D5BAA0", Length = "0x142")]
	[Token(Token = "0x600098C")]
	protected Vector3 GetLaserDirection() { }

	[Address(RVA = "0x1D5C7F0", Offset = "0x1D5BBF0", Length = "0x1A4")]
	[Token(Token = "0x6000997")]
	protected override Vector3 GetLockOnPosition() { }

	[Address(RVA = "0x1D5CB70", Offset = "0x1D5BF70", Length = "0x86")]
	[Token(Token = "0x600097C")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D5C9A0", Offset = "0x1D5BDA0", Length = "0x1CE")]
	[Token(Token = "0x600097D")]
	public void InitializeLasers() { }

	[Address(RVA = "0x1D5CC00", Offset = "0x1D5C000", Length = "0x12")]
	[Token(Token = "0x600098A")]
	public virtual bool IsAlive() { }

	[Address(RVA = "0x1D5CC20", Offset = "0x1D5C020", Length = "0x68")]
	[Token(Token = "0x600099A")]
	private bool IsKeepLockOn(HybridCollisionBridge _lockon) { }

	[Address(RVA = "0x1D5CC90", Offset = "0x1D5C090", Length = "0x53")]
	[Token(Token = "0x6000996")]
	protected override bool IsLockOnEnemy() { }

	[Address(RVA = "0x1D5CCF0", Offset = "0x1D5C0F0", Length = "0x183")]
	[Token(Token = "0x6000995")]
	protected override bool IsLockOnTarget(HybridCollisionBridge tbridge) { }

	[Address(RVA = "0x1D5CE80", Offset = "0x1D5C280", Length = "0x30F")]
	[Token(Token = "0x6000989")]
	public override void LaserEnd() { }

	[Address(RVA = "0x1D5D190", Offset = "0x1D5C590", Length = "0x154")]
	[Token(Token = "0x600097F")]
	protected virtual void OnHitProgress(CollisionOrder aData) { }

	[Address(RVA = "0x1D5D710", Offset = "0x1D5CB10", Length = "0x807")]
	[Token(Token = "0x6000983")]
	public override void Progress(float dt, Vector3 wpos, Transform _root) { }

	[Address(RVA = "0x1D5D2F0", Offset = "0x1D5C6F0", Length = "0x3A1")]
	[Token(Token = "0x6000985")]
	protected override void ProgressDirection(Transform _root, HybridCollisionBridge _moreNear, Vector3 lpos, float lSpeed) { }

	[Address(RVA = "0x1D5D6A0", Offset = "0x1D5CAA0", Length = "0x70")]
	[Token(Token = "0x6000986")]
	protected override void ProgressLockOn() { }

	[Address(RVA = "0x1D5DF20", Offset = "0x1D5D320", Length = "0x7")]
	[Token(Token = "0x600098E")]
	public void SetChildLaserFlag(bool isChild) { }

	[Address(RVA = "0x1D5DF30", Offset = "0x1D5D330", Length = "0x18E")]
	[Token(Token = "0x600098F")]
	protected void SetDistance(float tdist) { }

	[Address(RVA = "0x1D5E0C0", Offset = "0x1D5D4C0", Length = "0x7D")]
	[Token(Token = "0x600098B")]
	public virtual void SetExBoost(bool isExBoost) { }

	[Address(RVA = "0x1D5E140", Offset = "0x1D5D540", Length = "0x16")]
	[Token(Token = "0x600098D")]
	public void SetLaserDirection(Vector3 ldir) { }

	[Address(RVA = "0x1D5E160", Offset = "0x1D5D560", Length = "0x3D4")]
	[Token(Token = "0x6000982")]
	public override void StartMove(Vector3 tDir, float tSpeed) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000984")]
	public override void StopMuzzle() { }

	[Address(RVA = "0x1D5E540", Offset = "0x1D5D940", Length = "0x30")]
	[Token(Token = "0x600097E")]
	public virtual void Terminate() { }

	[Address(RVA = "0x1D5E8C0", Offset = "0x1D5DCC0", Length = "0xDF")]
	[Token(Token = "0x6000994")]
	protected override bool UpdateLockonDir(Vector3 lpos) { }

	[Address(RVA = "0x1D5E580", Offset = "0x1D5D980", Length = "0x33C")]
	[Token(Token = "0x6000993")]
	protected void UpdateLockOnTarget(HybridCollisionBridge _moreNear) { }

}

