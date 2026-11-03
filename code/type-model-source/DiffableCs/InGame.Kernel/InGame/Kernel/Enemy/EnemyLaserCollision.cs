namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000161")]
public class EnemyLaserCollision : InGameCollisionBase, InGameBulletInterface, IPrefabBankObject
{
	[Token(Token = "0x2000162")]
	private enum LaserState : int
	{
		None = 0,
		FirstTime = 1,
		Charge = 2,
		Fire = 3,
		Dissolve = 4,
		Done = 5,
	}

	[Token(Token = "0x40009E1")]
	private static readonly float nLaserMaxLength; //Field offset: 0x0
	[Token(Token = "0x40009E2")]
	private static readonly int _DissolveThreshold; //Field offset: 0x4
	[Token(Token = "0x40009E3")]
	private static readonly int _TintColor; //Field offset: 0x8
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40009E4")]
	private Vector3 _baseLaserDirection; //Field offset: 0xA0
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x40009E5")]
	private Vector3 _startPosition; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40009E6")]
	private Vector3 _endPosition; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x40009E7")]
	private Vector3 _emitPositionLocal; //Field offset: 0xC4
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40009E8")]
	private Vector3 _emitOffsetPosition; //Field offset: 0xD0
	[FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x40009E9")]
	private Vector3 _lastEmitPosition; //Field offset: 0xDC
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40009EA")]
	private Vector3 _lastDir; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40009EB")]
	private Vector3[] _baseSizes; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40009EC")]
	private bool _isSelfDirection; //Field offset: 0x100
	[FieldOffset(Offset = "0x101")]
	[Token(Token = "0x40009ED")]
	private bool _isAliveLaser; //Field offset: 0x101
	[FieldOffset(Offset = "0x102")]
	[Token(Token = "0x40009EE")]
	private bool _isInArea; //Field offset: 0x102
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40009EF")]
	private InGameEnemyMoveBase _moveModel; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40009F0")]
	private Transform _emitterTransform; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40009F1")]
	private Transform _directionTransform; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40009F2")]
	private Transform _gameRoot; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40009F3")]
	private InGameCollisionModel _laserCollision; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	[Token(Token = "0x40009F4")]
	private LineRenderer _laserLine; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	[Token(Token = "0x40009F5")]
	private float _laserWidth; //Field offset: 0x138
	[FieldOffset(Offset = "0x13C")]
	[SerializeField]
	[Token(Token = "0x40009F6")]
	private float _collisionWidth; //Field offset: 0x13C
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x40009F7")]
	private float _chargeTime; //Field offset: 0x140
	[FieldOffset(Offset = "0x144")]
	[SerializeField]
	[Token(Token = "0x40009F8")]
	private float _firstHitDamage; //Field offset: 0x144
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	[Token(Token = "0x40009F9")]
	private float _ContinuesHitDamage; //Field offset: 0x148
	[FieldOffset(Offset = "0x14C")]
	[SerializeField]
	[Token(Token = "0x40009FA")]
	private float nDissolveTimeMax; //Field offset: 0x14C
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	[Token(Token = "0x40009FB")]
	private ParticleSystem _chargeEffect; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	[Token(Token = "0x40009FC")]
	private ParticleSystem _emitterEffect; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	[Token(Token = "0x40009FD")]
	private InGameObjectAlpha _muzzleEffects; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[SerializeField]
	[Token(Token = "0x40009FE")]
	private InGameEffectSwapper _edgeEffects; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[SerializeField]
	[Token(Token = "0x40009FF")]
	private Material _laserBeamMaterial; //Field offset: 0x170
	[FieldOffset(Offset = "0x178")]
	[SerializeField]
	[Token(Token = "0x4000A00")]
	private LaserSoundRequestData _firstSound; //Field offset: 0x178
	[FieldOffset(Offset = "0x180")]
	[SerializeField]
	[Token(Token = "0x4000A01")]
	private LaserSoundRequestData _loopSound; //Field offset: 0x180
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4000A02")]
	private Action<Int32> _endAction; //Field offset: 0x188
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000A03")]
	private Color _lineColor; //Field offset: 0x190
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000A04")]
	private float _speed; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A4")]
	[Token(Token = "0x4000A05")]
	private float _edgeBlockRate; //Field offset: 0x1A4
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000A06")]
	private float _edgeFireRate; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1AC")]
	[Token(Token = "0x4000A07")]
	private float _distance; //Field offset: 0x1AC
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000A08")]
	private Quaternion _baseRotate; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000A09")]
	private float _irradiationTime; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C4")]
	[Token(Token = "0x4000A0A")]
	private float _chargePassed; //Field offset: 0x1C4
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000A0B")]
	private float _dissolveTime; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1CC")]
	[Token(Token = "0x4000A0C")]
	private float _runtimeDissolveTimeMax; //Field offset: 0x1CC
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000A0D")]
	private float _cancelDissolveTime; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D4")]
	[Token(Token = "0x4000A0E")]
	private int _nFireKind; //Field offset: 0x1D4
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4000A0F")]
	private int _poolIndex; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1DC")]
	[Token(Token = "0x4000A10")]
	private LaserState _laserState; //Field offset: 0x1DC

	[Token(Token = "0x170001C7")]
	public virtual bool IsPrgoressMove
	{
		[Address(RVA = "0x1D6ACB0", Offset = "0x1D6A0B0", Length = "0x45")]
		[Token(Token = "0x6000AC4")]
		 get { } //Length: 69
	}

	[Token(Token = "0x170001C8")]
	private LaserState LState
	{
		[Address(RVA = "0x1D6AD00", Offset = "0x1D6A100", Length = "0x7")]
		[Token(Token = "0x6000ADC")]
		private get { } //Length: 7
	}

	[Address(RVA = "0x1D69940", Offset = "0x1D68D40", Length = "0x22A")]
	[Token(Token = "0x6000AD4")]
	private bool _blockPositionUpdate(Vector3 wpos, Vector3 ldir, float tdt) { }

	[Address(RVA = "0x1D69D80", Offset = "0x1D69180", Length = "0x245")]
	[Token(Token = "0x6000AD6")]
	private HybridCollisionBridge _getBlockObject(Vector3 spos) { }

	[Address(RVA = "0x1D69FD0", Offset = "0x1D693D0", Length = "0x163")]
	[Token(Token = "0x6000AAC")]
	protected virtual Vector3 _getCurrentPosition() { }

	[Address(RVA = "0x1D6A140", Offset = "0x1D69540", Length = "0xAD")]
	[Token(Token = "0x6000AC8")]
	private Vector3 _getEmitterPosition() { }

	[Address(RVA = "0x1D5EFD0", Offset = "0x1D5E3D0", Length = "0x21")]
	[Token(Token = "0x6000AD7")]
	private float _getEnemyDistance(Vector3 p1, Vector3 p2) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000AD0")]
	private void _hideCollisionDebugDisplayIfDisabled() { }

	[Address(RVA = "0x1D6A1F0", Offset = "0x1D695F0", Length = "0x197")]
	[Token(Token = "0x6000AD8")]
	private void _laserBeamDissolve(float a) { }

	[Address(RVA = "0x1D68EE0", Offset = "0x1D682E0", Length = "0x1A4")]
	[Token(Token = "0x6000ACF")]
	private void _LaserEnd() { }

	[Address(RVA = "0x1D69090", Offset = "0x1D68490", Length = "0x648")]
	[Token(Token = "0x6000AC2")]
	protected void _LaserMoveUpdate(bool isGrowing, float tdt) { }

	[Address(RVA = "0x1D6A390", Offset = "0x1D69790", Length = "0x7")]
	[Token(Token = "0x6000ADA")]
	private void _setLaserState(LaserState s) { }

	[Address(RVA = "0x1D6A3A0", Offset = "0x1D697A0", Length = "0xBC")]
	[Token(Token = "0x6000AD3")]
	private void _setStateDissolve() { }

	[Address(RVA = "0x1D696E0", Offset = "0x1D68AE0", Length = "0x255")]
	[Token(Token = "0x6000ABE")]
	private void _StartMove(Vector3 tDir, float tSpeed) { }

	[Address(RVA = "0x1D6A460", Offset = "0x1D69860", Length = "0xF2")]
	[Token(Token = "0x6000ADB")]
	private void _stopSounds() { }

	[Address(RVA = "0x1D6A560", Offset = "0x1D69960", Length = "0x4B6")]
	[Token(Token = "0x6000AD1")]
	private void _updateCollisionShape() { }

	[Address(RVA = "0x1D6AA20", Offset = "0x1D69E20", Length = "0x1E6")]
	[Token(Token = "0x6000AD2")]
	private void _updateLaserPosition(Vector3 spos, Vector3 tdir) { }

	[Address(RVA = "0x1D69B70", Offset = "0x1D68F70", Length = "0x8F")]
	[Token(Token = "0x6000ADE")]
	private static EnemyLaserCollision() { }

	[Address(RVA = "0x1D69C00", Offset = "0x1D69000", Length = "0x17D")]
	[Token(Token = "0x6000ADD")]
	public EnemyLaserCollision() { }

	[Address(RVA = "0x1D67C30", Offset = "0x1D67030", Length = "0x1F")]
	[Token(Token = "0x6000AA6")]
	public virtual void CallDisabled() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000AC3")]
	public override BulletColorType ColorType() { }

	[Address(RVA = "0x1D67C50", Offset = "0x1D67050", Length = "0x7")]
	[Token(Token = "0x6000AB0")]
	public void EndMove() { }

	[Address(RVA = "0x1D6AC10", Offset = "0x1D6A010", Length = "0x96")]
	[Token(Token = "0x6000AC9")]
	private void fireLaser() { }

	[Address(RVA = "0x1D6ACB0", Offset = "0x1D6A0B0", Length = "0x45")]
	[Token(Token = "0x6000AC4")]
	public virtual bool get_IsPrgoressMove() { }

	[Address(RVA = "0x1D6AD00", Offset = "0x1D6A100", Length = "0x7")]
	[Token(Token = "0x6000ADC")]
	private LaserState get_LState() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000AC6")]
	public override GameObject GetObject() { }

	[Address(RVA = "0x1D67C60", Offset = "0x1D67060", Length = "0x4A9")]
	[Token(Token = "0x6000AA8")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D68110", Offset = "0x1D67510", Length = "0x22")]
	[Token(Token = "0x6000ABA")]
	public virtual bool IsAlive() { }

	[Address(RVA = "0x1CC9FE0", Offset = "0x1CC93E0", Length = "0x7")]
	[Token(Token = "0x6000AB8")]
	public override bool IsEnableScript() { }

	[Address(RVA = "0x1D6AD10", Offset = "0x1D6A110", Length = "0xB")]
	[Token(Token = "0x6000AD9")]
	private bool isFirstFire() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000AB7")]
	public override bool IsLaser() { }

	[Address(RVA = "0x1D68140", Offset = "0x1D67540", Length = "0x3A")]
	[Token(Token = "0x6000ACC")]
	private bool IsLaserCancel() { }

	[Address(RVA = "0x1D68180", Offset = "0x1D67580", Length = "0x90")]
	[Token(Token = "0x6000ACD")]
	private bool IsLaserEndMode() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000AB9")]
	public virtual bool IsNoDamaged() { }

	[Address(RVA = "0x1D68220", Offset = "0x1D67620", Length = "0x2C")]
	[Token(Token = "0x6000ACE")]
	private bool IsUpdatePosition() { }

	[Address(RVA = "0x1CCE430", Offset = "0x1CCD830", Length = "0x7")]
	[Token(Token = "0x6000ADF")]
	private override void KANAI.Kernel.IPrefabBankObject.SetupCache() { }

	[Address(RVA = "0x1D68250", Offset = "0x1D67650", Length = "0x3A")]
	[Token(Token = "0x6000ACB")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1D68290", Offset = "0x1D67690", Length = "0x12D")]
	[Token(Token = "0x6000AAA")]
	protected virtual void OnHitProgress(CollisionOrder aData) { }

	[Address(RVA = "0x1D683C0", Offset = "0x1D677C0", Length = "0x12D")]
	[Token(Token = "0x6000AAB")]
	protected virtual void OnStayProgress(CollisionOrder aData) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000AAF")]
	public override void ProgressBullet(float dt) { }

	[Address(RVA = "0x1D6AD20", Offset = "0x1D6A120", Length = "0x3DD")]
	[Token(Token = "0x6000ACA")]
	private void progressLaser(float tdt) { }

	[Address(RVA = "0x1D649F0", Offset = "0x1D63DF0", Length = "0x13")]
	[Token(Token = "0x6000AA9")]
	public override void RefreshRoot(Transform gmr) { }

	[Address(RVA = "0x1D684F0", Offset = "0x1D678F0", Length = "0x147")]
	[Token(Token = "0x6000ABB")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1D64A10", Offset = "0x1D63E10", Length = "0x2D")]
	[Token(Token = "0x6000AC5")]
	public override void SetActiveBank(bool tactive) { }

	[Address(RVA = "0x1D68640", Offset = "0x1D67A40", Length = "0x12")]
	[Token(Token = "0x6000AC0")]
	public void SetCancelDissolveTime(float seconds) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000AB4")]
	public override void SetCauseOfDeath(int playerNo, attackType atkType, bool isExboost) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000AB2")]
	public override void SetCurveData(AnimationCurve _curve, float r, float range) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000AB1")]
	public override void SetCurveType(float r, float range) { }

	[Address(RVA = "0x1D68660", Offset = "0x1D67A60", Length = "0x122")]
	[Token(Token = "0x6000AB6")]
	public override void SetEmitterInformation(InGameEnemyMoveBase _m, Transform _temit, Transform _tdir, int nFire, bool isSelf) { }

	[Address(RVA = "0x1D68790", Offset = "0x1D67B90", Length = "0x9")]
	[Token(Token = "0x6000AB5")]
	public override void SetIrradiationTime(float t) { }

	[Address(RVA = "0x1D5E140", Offset = "0x1D5D540", Length = "0x16")]
	[Token(Token = "0x6000ABD")]
	public override void SetOffsetPosition(Vector3 pos) { }

	[Address(RVA = "0x1D687A0", Offset = "0x1D67BA0", Length = "0x34")]
	[Token(Token = "0x6000AAD")]
	public override void SetPoolAction(Action<Int32> _pool, int pindex) { }

	[Address(RVA = "0x1D687E0", Offset = "0x1D67BE0", Length = "0x35")]
	[Token(Token = "0x6000ABF")]
	public void SetSoundId(ID chageId, ID loopId) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000AB3")]
	public void SetTargetTransform(InGameCollisionBase t) { }

	[Address(RVA = "0x1D68820", Offset = "0x1D67C20", Length = "0xAC")]
	[Token(Token = "0x6000AAE")]
	public override void StartMove(Vector3 s, Vector3 tdir, float tspeed, MoveType moveType) { }

	[Address(RVA = "0x1D688D0", Offset = "0x1D67CD0", Length = "0xA5")]
	[Token(Token = "0x6000AA7")]
	public virtual void Terminate() { }

	[Address(RVA = "0x1D68980", Offset = "0x1D67D80", Length = "0x3E")]
	[Token(Token = "0x6000ABC")]
	public virtual void ToDestroid() { }

	[Address(RVA = "0x1D689C0", Offset = "0x1D67DC0", Length = "0xFC")]
	[Token(Token = "0x6000AC7")]
	private bool UpdateIsInAreaFlag() { }

	[Address(RVA = "0x1D68E10", Offset = "0x1D68210", Length = "0xCA")]
	[Token(Token = "0x6000AC1")]
	private void UpdateLaserDir(Vector3 tdir) { }

	[Address(RVA = "0x1D68AC0", Offset = "0x1D67EC0", Length = "0x34F")]
	[Token(Token = "0x6000AD5")]
	private void UpdateLaserDirSelf(Quaternion enemyRoot) { }

}

