namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001DE")]
public class Ene_Lc01 : PawnEnemyGround
{
	[Token(Token = "0x20001DF")]
	private class coverAction
	{
		[Token(Token = "0x400109D")]
		private static readonly Quaternion _openRotate; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400109E")]
		private Transform _coverTransform; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400109F")]
		private EnePartsGroup _eneParts; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40010A0")]
		private EnemyCollisionModel _collision; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40010A1")]
		private float _bulletTimer1; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40010A2")]
		private float _bulletTimerLoop; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40010A3")]
		private float _openTime; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40010A4")]
		private float _openRate; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40010A5")]
		private bool _isOpen; //Field offset: 0x38
		[FieldOffset(Offset = "0x39")]
		[Token(Token = "0x40010A6")]
		private bool _isMoving; //Field offset: 0x39
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x40010A7")]
		private float _timer; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40010A8")]
		public bool _isDead; //Field offset: 0x40

		[Token(Token = "0x1700020B")]
		public Transform CoverTransform
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x6000E90")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700020E")]
		public bool IsCore
		{
			[Address(RVA = "0x1DD1CF0", Offset = "0x1DD10F0", Length = "0x50")]
			[Token(Token = "0x6000E93")]
			 get { } //Length: 80
		}

		[Token(Token = "0x1700020D")]
		public bool IsMoving
		{
			[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
			[Token(Token = "0x6000E92")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700020C")]
		public bool IsOpen
		{
			[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
			[Token(Token = "0x6000E91")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x1DD1BF0", Offset = "0x1DD0FF0", Length = "0x5C")]
		[Token(Token = "0x6000E94")]
		private static coverAction() { }

		[Address(RVA = "0x1DD1C50", Offset = "0x1DD1050", Length = "0x9A")]
		[Token(Token = "0x6000E89")]
		public coverAction(Transform _p, EnePartsGroup _e, EnemyCollisionModel _c, float _timer1, float _timerl, float _otime) { }

		[Address(RVA = "0x1DD1640", Offset = "0x1DD0A40", Length = "0x9E")]
		[Token(Token = "0x6000E8D")]
		public void CoreAction(InGameManager gm, Vector3 pos, BulletTemplate bt, float tstep) { }

		[Address(RVA = "0x1DD16E0", Offset = "0x1DD0AE0", Length = "0x21A")]
		[Token(Token = "0x6000E8C")]
		public bool CoverAction(float tstep, bool isDeadEnd) { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000E90")]
		public Transform get_CoverTransform() { }

		[Address(RVA = "0x1DD1CF0", Offset = "0x1DD10F0", Length = "0x50")]
		[Token(Token = "0x6000E93")]
		public bool get_IsCore() { }

		[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
		[Token(Token = "0x6000E92")]
		public bool get_IsMoving() { }

		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[Token(Token = "0x6000E91")]
		public bool get_IsOpen() { }

		[Address(RVA = "0x1DD1900", Offset = "0x1DD0D00", Length = "0x33")]
		[Token(Token = "0x6000E8F")]
		public bool IsBreakParts() { }

		[Address(RVA = "0x1DD1940", Offset = "0x1DD0D40", Length = "0xFE")]
		[Token(Token = "0x6000E8E")]
		public void PartsSetHitSwitch(bool flg) { }

		[Address(RVA = "0x1DD1A40", Offset = "0x1DD0E40", Length = "0xD4")]
		[Token(Token = "0x6000E8A")]
		public void Reset() { }

		[Address(RVA = "0x1DD1B20", Offset = "0x1DD0F20", Length = "0xCA")]
		[Token(Token = "0x6000E8B")]
		public void SwitchMoving(InGameManager gm, Vector3 pos, BulletTemplate bt, bool isDeadEnd) { }

	}

	[Token(Token = "0x20001E3")]
	private class ExpData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40010BA")]
		public Transform _expTrans; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40010BB")]
		public string _expName; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40010BC")]
		public float _expTime; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40010BD")]
		public bool _isFinished; //Field offset: 0x24

		[Address(RVA = "0x1D37C50", Offset = "0x1D37050", Length = "0x36")]
		[Token(Token = "0x6000E96")]
		public ExpData() { }

	}

	[Token(Token = "0x20001E1")]
	private enum LC01Move : int
	{
		None = -1,
		MoveWait = 0,
		MoveAcc = 1,
		Moving = 2,
		MoveDec = 3,
	}

	[Token(Token = "0x20001E0")]
	private enum LC01State : int
	{
		StartWait = 0,
		Main = 1,
		DeadWait = 2,
		EndWait = 3,
	}

	[Token(Token = "0x20001E2")]
	private class PartsData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40010B4")]
		public Transform _cover; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40010B5")]
		public Transform _muzzle; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40010B6")]
		public int _bulletNo; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40010B7")]
		public float _bulletTime1st; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40010B8")]
		public float _bulletTimeLoop; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40010B9")]
		public float _openTime; //Field offset: 0x2C

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000E95")]
		public PartsData() { }

	}

	[Token(Token = "0x400108A")]
	private const float AccSpeed = 0.002; //Field offset: 0x0
	[Token(Token = "0x4001096")]
	private const float MoveDistanceZ = 430; //Field offset: 0x0
	[Token(Token = "0x4001093")]
	private const float CraterScale = 1.95; //Field offset: 0x0
	[Token(Token = "0x4001092")]
	private const float ScaleTime = 0.6; //Field offset: 0x0
	[Token(Token = "0x400108F")]
	private const float DeadTime = 2; //Field offset: 0x0
	[Token(Token = "0x400108D")]
	private const float MinSpeed = 0; //Field offset: 0x0
	[Token(Token = "0x400107F")]
	private static readonly String[] btNames; //Field offset: 0x0
	[Token(Token = "0x400108C")]
	private const float MaxSpeed = 0.05; //Field offset: 0x0
	[Token(Token = "0x400108B")]
	private const float DecSpeed = 0.005; //Field offset: 0x0
	[Token(Token = "0x4001089")]
	private const float StopZ = 15; //Field offset: 0x0
	[Token(Token = "0x4001088")]
	private const float MoveZ = -5; //Field offset: 0x0
	[Token(Token = "0x4001097")]
	private static readonly Vector3 MoveRange; //Field offset: 0x8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4001078")]
	private readonly int _OffsetID; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[SerializeField]
	[Token(Token = "0x4001079")]
	private Material _tankMaterialBase; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x400107A")]
	private Material _tankMaterial; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[SerializeField]
	[Token(Token = "0x400107B")]
	private Renderer[] _tankRollRenderers; //Field offset: 0x218
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x400107C")]
	private coverAction[] _covers; //Field offset: 0x220
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x400107D")]
	private LC01State _state; //Field offset: 0x228
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x400107E")]
	private LC01Move _move; //Field offset: 0x22C
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4001080")]
	protected BulletTemplate[] btemplates; //Field offset: 0x230
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4001081")]
	private readonly Vector3 _expOffset; //Field offset: 0x238
	[FieldOffset(Offset = "0x244")]
	[Token(Token = "0x4001082")]
	private Vector3 _lcStartPosition; //Field offset: 0x244
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4001083")]
	private float _rangeRate; //Field offset: 0x250
	[FieldOffset(Offset = "0x254")]
	[Token(Token = "0x4001084")]
	private int _tankSEId; //Field offset: 0x254
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4001085")]
	private bool _isCoreDead; //Field offset: 0x258
	[FieldOffset(Offset = "0x259")]
	[Token(Token = "0x4001086")]
	private bool _isDeadEnd; //Field offset: 0x259
	[FieldOffset(Offset = "0x25C")]
	[Token(Token = "0x4001087")]
	private int _turrets; //Field offset: 0x25C
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400108E")]
	private float _speed; //Field offset: 0x260
	[FieldOffset(Offset = "0x264")]
	[Token(Token = "0x4001090")]
	private float _deadTimer; //Field offset: 0x264
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4001091")]
	private float _expTimer; //Field offset: 0x268
	[FieldOffset(Offset = "0x26C")]
	[Token(Token = "0x4001094")]
	private float _scale; //Field offset: 0x26C
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4001095")]
	private float _scaleTimer; //Field offset: 0x270
	[FieldOffset(Offset = "0x274")]
	[Token(Token = "0x4001098")]
	private readonly int TankRollID; //Field offset: 0x274
	[FieldOffset(Offset = "0x278")]
	[SerializeField]
	[Token(Token = "0x4001099")]
	private PartsData[] _partsData; //Field offset: 0x278
	[FieldOffset(Offset = "0x280")]
	[SerializeField]
	[Token(Token = "0x400109A")]
	private Transform _coreModel; //Field offset: 0x280
	[FieldOffset(Offset = "0x288")]
	[SerializeField]
	[Token(Token = "0x400109B")]
	private Transform _craterModel; //Field offset: 0x288
	[FieldOffset(Offset = "0x290")]
	[SerializeField]
	[Token(Token = "0x400109C")]
	private ExpData[] _expData; //Field offset: 0x290

	[Address(RVA = "0x1DBE730", Offset = "0x1DBDB30", Length = "0xA86")]
	[Token(Token = "0x6000E82")]
	private void _moveState() { }

	[Address(RVA = "0x1DBE510", Offset = "0x1DBD910", Length = "0x150")]
	[Token(Token = "0x6000E88")]
	private static Ene_Lc01() { }

	[Address(RVA = "0x1DBE670", Offset = "0x1DBDA70", Length = "0xBE")]
	[Token(Token = "0x6000E87")]
	public Ene_Lc01() { }

	[Address(RVA = "0x1DBCE60", Offset = "0x1DBC260", Length = "0x133")]
	[Token(Token = "0x6000E85")]
	private void CheckDestroyTurret(InGameManager gm) { }

	[Address(RVA = "0x1DBCFA0", Offset = "0x1DBC3A0", Length = "0x20F")]
	[Token(Token = "0x6000E80")]
	private void CreateFX(int no) { }

	[Address(RVA = "0x1DBD1B0", Offset = "0x1DBC5B0", Length = "0x2C3")]
	[Token(Token = "0x6000E7F")]
	private void DestroyParts() { }

	[Address(RVA = "0x1DBD480", Offset = "0x1DBC880", Length = "0xA8")]
	[Token(Token = "0x6000E86")]
	public virtual List<String> GetBulletTemplates() { }

	[Address(RVA = "0x1DBD540", Offset = "0x1DBC940", Length = "0x1DF")]
	[Token(Token = "0x6000E78")]
	private void Init() { }

	[Address(RVA = "0x1DBD980", Offset = "0x1DBCD80", Length = "0x300")]
	[Token(Token = "0x6000E74")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1DBD720", Offset = "0x1DBCB20", Length = "0x25D")]
	[Token(Token = "0x6000E76")]
	public virtual void InitializeToPlay() { }

	[Address(RVA = "0x1DBD530", Offset = "0x1DBC930", Length = "0xB")]
	[Token(Token = "0x6000E7B")]
	private void InitTankSE() { }

	[Address(RVA = "0x1DBDC90", Offset = "0x1DBD090", Length = "0xB")]
	[Token(Token = "0x6000E7E")]
	private bool IsCoreDead() { }

	[Address(RVA = "0x1DBDCA0", Offset = "0x1DBD0A0", Length = "0x20")]
	[Token(Token = "0x6000E81")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1DBDCC0", Offset = "0x1DBD0C0", Length = "0x3CD")]
	[Token(Token = "0x6000E83")]
	private void MoveMuzzles(InGameManager gm, float tstep) { }

	[Address(RVA = "0x1DBE090", Offset = "0x1DBD490", Length = "0xB4")]
	[Token(Token = "0x6000E84")]
	private void MoveTank(float tstep) { }

	[Address(RVA = "0x1DBE150", Offset = "0x1DBD550", Length = "0xB6")]
	[Token(Token = "0x6000E7C")]
	private void PlayTankSE() { }

	[Address(RVA = "0x1DBE210", Offset = "0x1DBD610", Length = "0x20")]
	[Token(Token = "0x6000E77")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1DBE230", Offset = "0x1DBD630", Length = "0x56")]
	[Token(Token = "0x6000E7A")]
	private void SetCraterScale() { }

	[Address(RVA = "0x1DBE290", Offset = "0x1DBD690", Length = "0x94")]
	[Token(Token = "0x6000E79")]
	private void SetTankModel(bool flg) { }

	[Address(RVA = "0x1DBE330", Offset = "0x1DBD730", Length = "0xB1")]
	[Token(Token = "0x6000E7D")]
	private void StopTankSE(bool flg = false) { }

	[Address(RVA = "0x1DBE3F0", Offset = "0x1DBD7F0", Length = "0x117")]
	[Token(Token = "0x6000E75")]
	public virtual void Terminate() { }

}

