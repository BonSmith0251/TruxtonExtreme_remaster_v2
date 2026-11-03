namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000163")]
public class EnemyLaserCollision2 : InGameCollisionBase, InGameBulletInterface, IPrefabBankObject
{
	[Token(Token = "0x2000164")]
	private enum LaserState : int
	{
		None = 0,
		FirstTime = 1,
		Fire = 2,
		Dissolve = 3,
		Done = 4,
	}

	[Token(Token = "0x4000A18")]
	private static readonly Rect laserScreenArea; //Field offset: 0x0
	[Token(Token = "0x4000A40")]
	private const float nLaserMaxLength = 400; //Field offset: 0x0
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000A19")]
	private readonly int _vfxPropPos1; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000A1A")]
	private readonly int _vfxPropPos2; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000A1B")]
	private readonly int _vfxPropPos3; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000A1C")]
	private readonly int _vfxPropPos4; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000A1D")]
	private readonly int _vfxPropTexTiling; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4000A1E")]
	private readonly int _vfxPropDeltaTime; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000A1F")]
	private Vector3 _baseLaserDirection; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x4000A20")]
	private Vector3 _startPosition; //Field offset: 0xC4
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000A21")]
	private Vector3 _endPosition; //Field offset: 0xD0
	[FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x4000A22")]
	private Vector3 _emitPositionLocal; //Field offset: 0xDC
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000A23")]
	private Vector3 _emitOffsetPosition; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000A24")]
	private Vector3[] _baseSizes; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000A25")]
	private bool _isSelfDirection; //Field offset: 0x100
	[FieldOffset(Offset = "0x101")]
	[Token(Token = "0x4000A26")]
	private bool _isAliveLaser; //Field offset: 0x101
	[FieldOffset(Offset = "0x102")]
	[Token(Token = "0x4000A27")]
	private bool _isInArea; //Field offset: 0x102
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000A28")]
	private InGameEnemyMoveBase _moveModel; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000A29")]
	private Transform _emitterTransform; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000A2A")]
	private Transform _directionTransform; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000A2B")]
	private Transform _gameRoot; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000A2C")]
	private InGameCollisionModel _laserCollision; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	[Token(Token = "0x4000A2D")]
	private float _collisionWidth; //Field offset: 0x130
	[FieldOffset(Offset = "0x134")]
	[SerializeField]
	[Token(Token = "0x4000A2E")]
	private float _firstHitDamage; //Field offset: 0x134
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	[Token(Token = "0x4000A2F")]
	private float _ContinuesHitDamage; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x4000A30")]
	private ParticleSystem _emitterEffect; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	[Token(Token = "0x4000A31")]
	private InGameEffect _muzzleEffects; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	[Token(Token = "0x4000A32")]
	private InGameEffectSwapper _edgeEffects; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	[Token(Token = "0x4000A33")]
	private float _dissolveTimeMax; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	[Token(Token = "0x4000A34")]
	private LaserSoundRequestData _loopSound; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000A35")]
	private Action<Int32> _endAction; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4000A36")]
	private float _speed; //Field offset: 0x170
	[FieldOffset(Offset = "0x174")]
	[Token(Token = "0x4000A37")]
	private float _edgeBlockRate; //Field offset: 0x174
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4000A38")]
	private float _edgeFireRate; //Field offset: 0x178
	[FieldOffset(Offset = "0x17C")]
	[Token(Token = "0x4000A39")]
	private float _laserRotY; //Field offset: 0x17C
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4000A3A")]
	private float _distance; //Field offset: 0x180
	[FieldOffset(Offset = "0x184")]
	[Token(Token = "0x4000A3B")]
	private Quaternion _baseRotate; //Field offset: 0x184
	[FieldOffset(Offset = "0x194")]
	[Token(Token = "0x4000A3C")]
	private float _irradiationTime; //Field offset: 0x194
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000A3D")]
	private float _dissolveTime; //Field offset: 0x198
	[FieldOffset(Offset = "0x19C")]
	[Token(Token = "0x4000A3E")]
	private int _nFireKind; //Field offset: 0x19C
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000A3F")]
	private int _poolIndex; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A4")]
	[Token(Token = "0x4000A41")]
	private LaserState _laserState; //Field offset: 0x1A4
	[FieldOffset(Offset = "0x1A8")]
	[SerializeField]
	[Token(Token = "0x4000A42")]
	private bool _useVfxGraph; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	[Token(Token = "0x4000A43")]
	private List<VisualEffect> _vfxGraphs; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	[Token(Token = "0x4000A44")]
	private GameObject _vfxRoot; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	[Token(Token = "0x4000A45")]
	private Transform _vfxScale; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[SerializeField]
	[Token(Token = "0x4000A46")]
	private Transform _vfxRotate; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[SerializeField]
	[Token(Token = "0x4000A47")]
	private float _texTilingLength; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D4")]
	[Token(Token = "0x4000A48")]
	private float _vfxTime; //Field offset: 0x1D4

	[Token(Token = "0x170001C9")]
	private LaserState LState
	{
		[Address(RVA = "0x1D67C10", Offset = "0x1D67010", Length = "0x7")]
		[Token(Token = "0x6000B10")]
		private get { } //Length: 7
	}

	[Address(RVA = "0x1D66160", Offset = "0x1D65560", Length = "0x1FB")]
	[Token(Token = "0x6000B08")]
	private bool _blockPositionUpdate(Vector3 wpos, Vector3 ldir, float tdt) { }

	[Address(RVA = "0x1D66530", Offset = "0x1D65930", Length = "0x245")]
	[Token(Token = "0x6000B0A")]
	private HybridCollisionBridge _getBlockObject(Vector3 spos) { }

	[Address(RVA = "0x1D66780", Offset = "0x1D65B80", Length = "0x167")]
	[Token(Token = "0x6000AE6")]
	protected virtual Vector3 _getCurrentPosition() { }

	[Address(RVA = "0x1D668F0", Offset = "0x1D65CF0", Length = "0x196")]
	[Token(Token = "0x6000AFF")]
	private Vector3 _getEmitterPosition() { }

	[Address(RVA = "0x1D5EFD0", Offset = "0x1D5E3D0", Length = "0x21")]
	[Token(Token = "0x6000B0B")]
	private float _getEnemyDistance(Vector3 p1, Vector3 p2) { }

	[Address(RVA = "0x1D66A90", Offset = "0x1D65E90", Length = "0xE7")]
	[Token(Token = "0x6000B0C")]
	private void _laserBeamDissolve(float a) { }

	[Address(RVA = "0x1D65310", Offset = "0x1D64710", Length = "0x293")]
	[Token(Token = "0x6000B04")]
	private void _LaserEnd() { }

	[Address(RVA = "0x1D655B0", Offset = "0x1D649B0", Length = "0x8EA")]
	[Token(Token = "0x6000AFA")]
	protected void _LaserMoveUpdate(bool isGrowing, float tdt) { }

	[Address(RVA = "0x1D66B80", Offset = "0x1D65F80", Length = "0x7")]
	[Token(Token = "0x6000B0E")]
	private void _setLaserState(LaserState s) { }

	[Address(RVA = "0x1D66B90", Offset = "0x1D65F90", Length = "0x15")]
	[Token(Token = "0x6000B07")]
	private void _setStateDissolve() { }

	[Address(RVA = "0x1D65EA0", Offset = "0x1D652A0", Length = "0x2B0")]
	[Token(Token = "0x6000AF9")]
	private void _StartMove(Vector3 tDir, float tSpeed) { }

	[Address(RVA = "0x1D66BB0", Offset = "0x1D65FB0", Length = "0x7C")]
	[Token(Token = "0x6000B0F")]
	private void _stopSounds() { }

	[Address(RVA = "0x1D66C30", Offset = "0x1D66030", Length = "0x464")]
	[Token(Token = "0x6000B05")]
	private void _updateCollisionShape() { }

	[Address(RVA = "0x1D670A0", Offset = "0x1D664A0", Length = "0x191")]
	[Token(Token = "0x6000B06")]
	private void _updateLaserPosition(Vector3 spos, Vector3 tdir) { }

	[Address(RVA = "0x1D67240", Offset = "0x1D66640", Length = "0x3E2")]
	[Token(Token = "0x6000B09")]
	private float _updateLaserRot(Quaternion baserot) { }

	[Address(RVA = "0x1D67630", Offset = "0x1D66A30", Length = "0x530")]
	[Token(Token = "0x6000B02")]
	private void _updateVfxParameter() { }

	[Address(RVA = "0x1D66360", Offset = "0x1D65760", Length = "0x3E")]
	[Token(Token = "0x6000B12")]
	private static EnemyLaserCollision2() { }

	[Address(RVA = "0x1D663A0", Offset = "0x1D657A0", Length = "0x18F")]
	[Token(Token = "0x6000B11")]
	public EnemyLaserCollision2() { }

	[Address(RVA = "0x1D64290", Offset = "0x1D63690", Length = "0x1F")]
	[Token(Token = "0x6000AE0")]
	public virtual void CallDisabled() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000AFB")]
	public override BulletColorType ColorType() { }

	[Address(RVA = "0x1D642B0", Offset = "0x1D636B0", Length = "0x7")]
	[Token(Token = "0x6000AE9")]
	public void EndMove() { }

	[Address(RVA = "0x1D67B70", Offset = "0x1D66F70", Length = "0x96")]
	[Token(Token = "0x6000B00")]
	private void fireLaser() { }

	[Address(RVA = "0x1D67C10", Offset = "0x1D67010", Length = "0x7")]
	[Token(Token = "0x6000B10")]
	private LaserState get_LState() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000AFD")]
	public override GameObject GetObject() { }

	[Address(RVA = "0x1D642C0", Offset = "0x1D636C0", Length = "0x313")]
	[Token(Token = "0x6000AE3")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D645E0", Offset = "0x1D639E0", Length = "0x22")]
	[Token(Token = "0x6000AF5")]
	public virtual bool IsAlive() { }

	[Address(RVA = "0x1CC9FE0", Offset = "0x1CC93E0", Length = "0x7")]
	[Token(Token = "0x6000AF2")]
	public override bool IsEnableScript() { }

	[Address(RVA = "0x1D67C20", Offset = "0x1D67020", Length = "0xB")]
	[Token(Token = "0x6000B0D")]
	private bool isFirstFire() { }

	[Address(RVA = "0x1D64610", Offset = "0x1D63A10", Length = "0xB")]
	[Token(Token = "0x6000AF4")]
	private bool IsGrowing() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000AF1")]
	public override bool IsLaser() { }

	[Address(RVA = "0x1D64620", Offset = "0x1D63A20", Length = "0xA5")]
	[Token(Token = "0x6000B03")]
	private bool IsLaserSkipMode() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000AF3")]
	public virtual bool IsNoDamaged() { }

	[Address(RVA = "0x1CCE430", Offset = "0x1CCD830", Length = "0x7")]
	[Token(Token = "0x6000B13")]
	private override void KANAI.Kernel.IPrefabBankObject.SetupCache() { }

	[Address(RVA = "0x1D646D0", Offset = "0x1D63AD0", Length = "0x12D")]
	[Token(Token = "0x6000AE4")]
	protected virtual void OnHitProgress(CollisionOrder aData) { }

	[Address(RVA = "0x1D64800", Offset = "0x1D63C00", Length = "0x12D")]
	[Token(Token = "0x6000AE5")]
	protected virtual void OnStayProgress(CollisionOrder aData) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000AEE")]
	public override void ProgressBullet(float dt) { }

	[Address(RVA = "0x1D649F0", Offset = "0x1D63DF0", Length = "0x13")]
	[Token(Token = "0x6000AE1")]
	public override void RefreshRoot(Transform gmr) { }

	[Address(RVA = "0x1D64930", Offset = "0x1D63D30", Length = "0xBD")]
	[Token(Token = "0x6000AF6")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1D64A10", Offset = "0x1D63E10", Length = "0x2D")]
	[Token(Token = "0x6000AFC")]
	public override void SetActiveBank(bool tactive) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000AED")]
	public override void SetCauseOfDeath(int playerNo, attackType atkType, bool isExboost) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000AEB")]
	public override void SetCurveData(AnimationCurve _curve, float r, float range) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000AEA")]
	public override void SetCurveType(float r, float range) { }

	[Address(RVA = "0x1D64A40", Offset = "0x1D63E40", Length = "0x13C")]
	[Token(Token = "0x6000AF0")]
	public override void SetEmitterInformation(InGameEnemyMoveBase _m, Transform _temit, Transform _tdir, int nFire, bool isSelf) { }

	[Address(RVA = "0x1D64B80", Offset = "0x1D63F80", Length = "0x9")]
	[Token(Token = "0x6000AEF")]
	public override void SetIrradiationTime(float t) { }

	[Address(RVA = "0x1D64B90", Offset = "0x1D63F90", Length = "0x16")]
	[Token(Token = "0x6000AF8")]
	public override void SetOffsetPosition(Vector3 pos) { }

	[Address(RVA = "0x1D64BB0", Offset = "0x1D63FB0", Length = "0x34")]
	[Token(Token = "0x6000AE7")]
	public override void SetPoolAction(Action<Int32> _pool, int pindex) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000AEC")]
	public void SetTargetTransform(InGameCollisionBase t) { }

	[Address(RVA = "0x1D64BF0", Offset = "0x1D63FF0", Length = "0xAC")]
	[Token(Token = "0x6000AE8")]
	public override void StartMove(Vector3 s, Vector3 tdir, float tspeed, MoveType moveType) { }

	[Address(RVA = "0x1D64CA0", Offset = "0x1D640A0", Length = "0x38")]
	[Token(Token = "0x6000AE2")]
	public virtual void Terminate() { }

	[Address(RVA = "0x1D64CE0", Offset = "0x1D640E0", Length = "0x3E")]
	[Token(Token = "0x6000AF7")]
	public virtual void ToDestroid() { }

	[Address(RVA = "0x1D64F60", Offset = "0x1D64360", Length = "0x3A1")]
	[Token(Token = "0x6000B01")]
	private void Update() { }

	[Address(RVA = "0x1D64D20", Offset = "0x1D64120", Length = "0x23D")]
	[Token(Token = "0x6000AFE")]
	private bool UpdateIsInAreaFlag() { }

}

