namespace InGame.Kernel.Enemy;

[Token(Token = "0x200021C")]
public class PawnEnemy : InGameCollisionBase, IDamagedObject, IPrefabBankObject
{
	[CompilerGenerated]
	[Token(Token = "0x2000222")]
	private sealed class <>c
	{
		[Token(Token = "0x400133E")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400133F")]
		public static Comparison<IEnemyUpdater> <>9__0_0; //Field offset: 0x8
		[Token(Token = "0x4001340")]
		public static Func<Record, Boolean> <>9__2_0; //Field offset: 0x10
		[Token(Token = "0x4001341")]
		public static DieCallback <>9__197_0; //Field offset: 0x18

		[Address(RVA = "0x1D1ABA0", Offset = "0x1D19FA0", Length = "0x67")]
		[Token(Token = "0x6001069")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600106A")]
		public <>c() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600106D")]
		internal void <.ctor>b__197_0(PawnEnemy a) { }

		[Address(RVA = "0x1D1A9A0", Offset = "0x1D19DA0", Length = "0x81")]
		[Token(Token = "0x600106B")]
		internal int <Initialize>b__0_0(IEnemyUpdater a, IEnemyUpdater b) { }

		[Address(RVA = "0x1D1AA30", Offset = "0x1D19E30", Length = "0x20")]
		[Token(Token = "0x600106C")]
		internal bool <SetRecords>b__2_0(Record pdata) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000223")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001342")]
		public EnePartsGroup aParts; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600106E")]
		public <>c__DisplayClass2_0() { }

		[Address(RVA = "0x1D1AB00", Offset = "0x1D19F00", Length = "0x2E")]
		[Token(Token = "0x600106F")]
		internal bool <SetRecords>b__1(Record pdata) { }

	}

	[Token(Token = "0x200021F")]
	internal sealed class DieCallback : MulticastDelegate
	{

		[Address(RVA = "0x5BC6F0", Offset = "0x5BBAF0", Length = "0x124")]
		[Token(Token = "0x600105D")]
		public DieCallback(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6A0", Offset = "0x5BBAA0", Length = "0x21")]
		[Token(Token = "0x600105F")]
		public override IAsyncResult BeginInvoke(PawnEnemy p, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6001060")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x600105E")]
		public override void Invoke(PawnEnemy p) { }

	}

	[Token(Token = "0x200021E")]
	internal enum Division : int
	{
		none = 0,
		Ground = 1,
		Sky = 2,
		GroundSky = 3,
	}

	[Token(Token = "0x2000221")]
	internal struct EnemyChildData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400133B")]
		public string _childName; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400133C")]
		public Transform _childNode; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400133D")]
		public int _childCount; //Field offset: 0x10

		[Address(RVA = "0x1311700", Offset = "0x1310B00", Length = "0x43")]
		[Token(Token = "0x6001068")]
		public EnemyChildData(string tname, Transform tnode, int tcount) { }

	}

	[Token(Token = "0x200021D")]
	internal sealed class poolEventFunction : MulticastDelegate
	{

		[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
		[Token(Token = "0x6001059")]
		public poolEventFunction(object object, IntPtr method) { }

		[Address(RVA = "0x639240", Offset = "0x638640", Length = "0x22")]
		[Token(Token = "0x600105B")]
		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600105C")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
		[Token(Token = "0x600105A")]
		public override void Invoke() { }

	}

	[Token(Token = "0x2000220")]
	internal class RenderData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001337")]
		public Renderer Renderer; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001338")]
		public Material[] mats; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001339")]
		private Material[] originalMats; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400133A")]
		private int matsCount; //Field offset: 0x28

		[Address(RVA = "0x1D12590", Offset = "0x1D11990", Length = "0x2EE")]
		[Token(Token = "0x6001061")]
		public RenderData(Renderer ren) { }

		[Address(RVA = "0x1D11E10", Offset = "0x1D11210", Length = "0x110")]
		[Token(Token = "0x6001062")]
		public void Delete() { }

		[Address(RVA = "0x1D11F30", Offset = "0x1D11330", Length = "0xE3")]
		[Token(Token = "0x6001067")]
		private bool IsCreateClone(Material tmat) { }

		[Address(RVA = "0x1D12020", Offset = "0x1D11420", Length = "0x1CC")]
		[Token(Token = "0x6001064")]
		public void LerpColor(int id, float trate, Color tcolor) { }

		[Address(RVA = "0x1D121F0", Offset = "0x1D115F0", Length = "0x23E")]
		[Token(Token = "0x6001063")]
		public void ResetColor(int id0, int id1, int id2) { }

		[Address(RVA = "0x1D12430", Offset = "0x1D11830", Length = "0xB5")]
		[Token(Token = "0x6001065")]
		public void SetColor(int id, in Color col) { }

		[Address(RVA = "0x1D124F0", Offset = "0x1D118F0", Length = "0x99")]
		[Token(Token = "0x6001066")]
		public void SetFloat(int id, float prm) { }

	}

	[Token(Token = "0x4001328")]
	public static readonly int _BaseColor; //Field offset: 0x0
	[Token(Token = "0x4001329")]
	public static readonly int _FadeColor; //Field offset: 0x4
	[Token(Token = "0x400132A")]
	public static readonly int _MaterialColor; //Field offset: 0x8
	[Token(Token = "0x400132B")]
	public static readonly int _MaterialFactor; //Field offset: 0xC
	[Token(Token = "0x400132C")]
	public static readonly Color DamagedColor; //Field offset: 0x10
	[Token(Token = "0x400132D")]
	protected static readonly Color DarkColor; //Field offset: 0x20
	[Token(Token = "0x400132E")]
	protected static readonly Color DeepDarkColor; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40012FA")]
	private poolEventFunction PoolEvent; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40012FB")]
	private IEnemyUpdater[] _updateEvents; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40012FC")]
	private int _updateEventCount; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x40012FD")]
	private int _updateLateEventCount; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40012FE")]
	protected EnemyMover _mover; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40012FF")]
	private float _burnShake; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x4001300")]
	private float _burnShakePow; //Field offset: 0xC4
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4001301")]
	private float _burnShakeSpeed; //Field offset: 0xC8
	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x4001302")]
	private float _aliveTime; //Field offset: 0xCC
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4001303")]
	private float _startDelayTime; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD4")]
	[Token(Token = "0x4001304")]
	private float _delayTime; //Field offset: 0xD4
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4001305")]
	private float _DamageScored; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[Token(Token = "0x4001306")]
	private string _deadExplosion; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4001307")]
	private int _deadExplosionHash; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x4001308")]
	private string _deadBullet; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x4001309")]
	private string _deadBulletSelecter; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400130A")]
	private BulletTemplate _deadBulletCache; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x400130B")]
	private ExpSound _overplayDeadSound; //Field offset: 0x108
	[FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x400130C")]
	private int _scorePoint; //Field offset: 0x10C
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x400130D")]
	private int _pipilCount; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x400130E")]
	private int _jewelCount; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x400130F")]
	private int _bornArea; //Field offset: 0x118
	[FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x4001310")]
	private int _poolIndex; //Field offset: 0x11C
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4001311")]
	protected EnemySize _sizeType; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4001312")]
	protected Record _recordData; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4001313")]
	private attackType _causeOfDeath; //Field offset: 0x130
	[FieldOffset(Offset = "0x134")]
	[Token(Token = "0x4001314")]
	protected int _deathByPno; //Field offset: 0x134
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4001315")]
	private attackType _lastHit; //Field offset: 0x138
	[FieldOffset(Offset = "0x13C")]
	[Token(Token = "0x4001316")]
	private bool _isFirstFrame; //Field offset: 0x13C
	[FieldOffset(Offset = "0x13D")]
	[Token(Token = "0x4001317")]
	protected bool _isChildEnemy; //Field offset: 0x13D
	[FieldOffset(Offset = "0x13E")]
	[Token(Token = "0x4001318")]
	private bool _isSkipDestroyCount; //Field offset: 0x13E
	[FieldOffset(Offset = "0x13F")]
	[Token(Token = "0x4001319")]
	private bool _isExboostDead; //Field offset: 0x13F
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400131A")]
	private bool _isResultDone; //Field offset: 0x140
	[FieldOffset(Offset = "0x141")]
	[Token(Token = "0x400131B")]
	private bool _isEventDone; //Field offset: 0x141
	[FieldOffset(Offset = "0x142")]
	[Token(Token = "0x400131C")]
	private bool _isEventEnd; //Field offset: 0x142
	[FieldOffset(Offset = "0x144")]
	[Token(Token = "0x400131D")]
	protected Vector3 _shakeBaseVector; //Field offset: 0x144
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x400131E")]
	private Vector3 _shakeResultVector; //Field offset: 0x150
	[FieldOffset(Offset = "0x15C")]
	[SerializeField]
	[Token(Token = "0x400131F")]
	protected Vector3 _explosionOffset; //Field offset: 0x15C
	[FieldOffset(Offset = "0x168")]
	[SerializeField]
	[Token(Token = "0x4001320")]
	protected Transform _modelTop; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4001321")]
	private float _targetY; //Field offset: 0x170
	[FieldOffset(Offset = "0x174")]
	[Token(Token = "0x4001322")]
	private Division _division; //Field offset: 0x174
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4001323")]
	private CancellationTokenSource _token; //Field offset: 0x178
	[FieldOffset(Offset = "0x180")]
	[SerializeField]
	[Token(Token = "0x4001324")]
	protected EnePartsGroup[] PartsList; //Field offset: 0x180
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4001325")]
	private int _partsCount; //Field offset: 0x188
	[FieldOffset(Offset = "0x18C")]
	[SerializeField]
	[Token(Token = "0x4001326")]
	private bool _isSimpleCalc; //Field offset: 0x18C
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4001327")]
	protected DieCallback _dieCallback; //Field offset: 0x190
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x400132F")]
	private int RenderDataCount; //Field offset: 0x198
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4001330")]
	public RenderData[] RenderDatas; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4001331")]
	private Dictionary<Renderer, RenderData> _rendererDictionary; //Field offset: 0x1A8

	[Token(Token = "0x14000001")]
	public event poolEventFunction PoolEvent
	{
		[Address(RVA = "0x1D11B00", Offset = "0x1D10F00", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x600102B")]
		 add { } //Length: 162
		[Address(RVA = "0x1D11D60", Offset = "0x1D11160", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x600102C")]
		 remove { } //Length: 162
	}

	[Token(Token = "0x17000219")]
	public attackType CauseOfDeath
	{
		[Address(RVA = "0x1D11BF0", Offset = "0x1D10FF0", Length = "0x7")]
		[Token(Token = "0x6001033")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000213")]
	protected CancellationToken CToken
	{
		[Address(RVA = "0x1D11BC0", Offset = "0x1D10FC0", Length = "0x20")]
		[Token(Token = "0x6001029")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000214")]
	public CancellationTokenSource CTokenSource
	{
		[Address(RVA = "0x1D11BB0", Offset = "0x1D10FB0", Length = "0x8")]
		[Token(Token = "0x600102A")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000223")]
	public string DbKeyString
	{
		[Address(RVA = "0x1D11C00", Offset = "0x1D11000", Length = "0x1E")]
		[Token(Token = "0x6001040")]
		 get { } //Length: 30
	}

	[Token(Token = "0x1700021A")]
	public int DeathByPno
	{
		[Address(RVA = "0x1D11C20", Offset = "0x1D11020", Length = "0x7")]
		[Token(Token = "0x6001036")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000222")]
	public Division GetDivision
	{
		[Address(RVA = "0x1D11C30", Offset = "0x1D11030", Length = "0x7")]
		[Token(Token = "0x600103F")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000212")]
	protected bool IsCancelToken
	{
		[Address(RVA = "0x1D11C40", Offset = "0x1D11040", Length = "0x1B")]
		[Token(Token = "0x6001028")]
		 get { } //Length: 27
	}

	[Token(Token = "0x1700021D")]
	protected bool IsEventDone
	{
		[Address(RVA = "0x1D11C60", Offset = "0x1D11060", Length = "0x8")]
		[Token(Token = "0x6001039")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700021C")]
	protected override bool IsExpEffectMove
	{
		[Address(RVA = "0x1D11C70", Offset = "0x1D11070", Length = "0x31")]
		[Token(Token = "0x6001038")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700021B")]
	protected bool IsFirstFrame
	{
		[Address(RVA = "0x1D11CB0", Offset = "0x1D110B0", Length = "0x8")]
		[Token(Token = "0x6001037")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000220")]
	public Transform ModelTop
	{
		[Address(RVA = "0x1D11CC0", Offset = "0x1D110C0", Length = "0x8")]
		[Token(Token = "0x600103C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000215")]
	public EnemyMover MoverComponent
	{
		[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
		[Token(Token = "0x600102D")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000216")]
	public int PoolIndex
	{
		[Address(RVA = "0x1D11CD0", Offset = "0x1D110D0", Length = "0x7")]
		[Token(Token = "0x6001030")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000218")]
	public Record RecordData
	{
		[Address(RVA = "0x1CF2E90", Offset = "0x1CF2290", Length = "0x8")]
		[Token(Token = "0x6001032")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700021E")]
	public Vector3 ShakeResultVector
	{
		[Address(RVA = "0x1D11CE0", Offset = "0x1D110E0", Length = "0x19")]
		[Token(Token = "0x600103A")]
		 get { } //Length: 25
	}

	[Token(Token = "0x17000217")]
	public EnemySize SizeType
	{
		[Address(RVA = "0x1D11D00", Offset = "0x1D11100", Length = "0x7")]
		[Token(Token = "0x6001031")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000221")]
	public float TargetY
	{
		[Address(RVA = "0x1D11D10", Offset = "0x1D11110", Length = "0x9")]
		[Token(Token = "0x600103D")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700021F")]
	public Vector3 WorldPosition
	{
		[Address(RVA = "0x1D11D20", Offset = "0x1D11120", Length = "0x3B")]
		[Token(Token = "0x600103B")]
		 get { } //Length: 59
	}

	[Address(RVA = "0x1D10D20", Offset = "0x1D10120", Length = "0xF3")]
	[Token(Token = "0x6000FFE")]
	private bool _addPartsDamage(EnePartsGroup aparts, float damage) { }

	[Address(RVA = "0x1D10E20", Offset = "0x1D10220", Length = "0x5D7")]
	[Token(Token = "0x6001002")]
	protected override void _callDeadEffect() { }

	[Address(RVA = "0x1D117F0", Offset = "0x1D10BF0", Length = "0x12A")]
	[Token(Token = "0x6001003")]
	protected virtual Vector3 _getCurrentPosition() { }

	[Address(RVA = "0x1D11920", Offset = "0x1D10D20", Length = "0x1DB")]
	[Token(Token = "0x6001006")]
	protected override void _shakeProgress(float dt) { }

	[Address(RVA = "0x1D11400", Offset = "0x1D10800", Length = "0x11E")]
	[Token(Token = "0x6001055")]
	private static PawnEnemy() { }

	[Address(RVA = "0x1D11520", Offset = "0x1D10920", Length = "0x2CC")]
	[Token(Token = "0x6001054")]
	public PawnEnemy() { }

	[Address(RVA = "0x1CCED80", Offset = "0x1CCE180", Length = "0x14")]
	[CompilerGenerated]
	[Token(Token = "0x6001057")]
	private void <StartKickWithDelayTime>b__69_0() { }

	[Address(RVA = "0x1CCED80", Offset = "0x1CCE180", Length = "0x14")]
	[CompilerGenerated]
	[Token(Token = "0x6001058")]
	private void <StartKickWithDelayTime>b__69_1() { }

	[Address(RVA = "0x1D11B00", Offset = "0x1D10F00", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x600102B")]
	public void add_PoolEvent(poolEventFunction value) { }

	[Address(RVA = "0x1D0C670", Offset = "0x1D0BA70", Length = "0x3A2")]
	[Token(Token = "0x6000FFD")]
	public virtual float AddDamageParts(float damage, int partNo, int playerNo, bool isExboost) { }

	[Address(RVA = "0x1D0CA20", Offset = "0x1D0BE20", Length = "0xAB")]
	[Token(Token = "0x600101C")]
	public void AddDieCallback(DieCallback dm) { }

	[Address(RVA = "0x1D0CAD0", Offset = "0x1D0BED0", Length = "0x19")]
	[Token(Token = "0x6000FF9")]
	public void AddShake(float nsec, float npow, float nspeed) { }

	[Address(RVA = "0x1D0CAF0", Offset = "0x1D0BEF0", Length = "0x101")]
	[Token(Token = "0x600104C")]
	protected void BaseBlend(float trate, Color tcolor) { }

	[Address(RVA = "0x1D0CC00", Offset = "0x1D0C000", Length = "0x1BD")]
	[Token(Token = "0x6000FFB")]
	public virtual void CallDisabled() { }

	[Address(RVA = "0x1D0CDC0", Offset = "0x1D0C1C0", Length = "0x2CC")]
	[Token(Token = "0x600104E")]
	protected void CallSubEnemys(Vector3 wpos, string edname, Division tdivision, bool isGround) { }

	[Address(RVA = "0x1D0D090", Offset = "0x1D0C490", Length = "0xAB")]
	[Token(Token = "0x6000FE9")]
	public bool ClearDirtyTransform() { }

	[Address(RVA = "0x1D0D140", Offset = "0x1D0C540", Length = "0x21")]
	[Token(Token = "0x600100E")]
	public override void ClearRoute() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600101E")]
	public override void CommonEvent(int num) { }

	[Address(RVA = "0x1D0D170", Offset = "0x1D0C570", Length = "0x40")]
	[Token(Token = "0x600100F")]
	public override void CreateRouteData(EnemyData ed, Vector3 spos) { }

	[Address(RVA = "0x1D0D1B0", Offset = "0x1D0C5B0", Length = "0x48")]
	[Token(Token = "0x6001026")]
	protected void CreateToken() { }

	[Address(RVA = "0x1D0D200", Offset = "0x1D0C600", Length = "0x1B8")]
	[Token(Token = "0x6001001")]
	protected void DeadResultUpdate() { }

	[Address(RVA = "0x1D0D3C0", Offset = "0x1D0C7C0", Length = "0xAB")]
	[Token(Token = "0x600101D")]
	public void DelDieCallback(DieCallback dm) { }

	[Address(RVA = "0x1D0D470", Offset = "0x1D0C870", Length = "0x101")]
	[Token(Token = "0x600104A")]
	private void DeleteMaterial() { }

	[Address(RVA = "0x1D0D580", Offset = "0x1D0C980", Length = "0x99")]
	[Token(Token = "0x6001047")]
	protected void DisabledAllParts() { }

	[Address(RVA = "0x1D0D620", Offset = "0x1D0CA20", Length = "0x21")]
	[Token(Token = "0x600100D")]
	public override void EndRoute() { }

	[Address(RVA = "0x1D11BF0", Offset = "0x1D10FF0", Length = "0x7")]
	[Token(Token = "0x6001033")]
	public attackType get_CauseOfDeath() { }

	[Address(RVA = "0x1D11BC0", Offset = "0x1D10FC0", Length = "0x20")]
	[Token(Token = "0x6001029")]
	protected CancellationToken get_CToken() { }

	[Address(RVA = "0x1D11BB0", Offset = "0x1D10FB0", Length = "0x8")]
	[Token(Token = "0x600102A")]
	public CancellationTokenSource get_CTokenSource() { }

	[Address(RVA = "0x1D11C00", Offset = "0x1D11000", Length = "0x1E")]
	[Token(Token = "0x6001040")]
	public string get_DbKeyString() { }

	[Address(RVA = "0x1D11C20", Offset = "0x1D11020", Length = "0x7")]
	[Token(Token = "0x6001036")]
	public int get_DeathByPno() { }

	[Address(RVA = "0x1D11C30", Offset = "0x1D11030", Length = "0x7")]
	[Token(Token = "0x600103F")]
	public Division get_GetDivision() { }

	[Address(RVA = "0x1D11C40", Offset = "0x1D11040", Length = "0x1B")]
	[Token(Token = "0x6001028")]
	protected bool get_IsCancelToken() { }

	[Address(RVA = "0x1D11C60", Offset = "0x1D11060", Length = "0x8")]
	[Token(Token = "0x6001039")]
	protected bool get_IsEventDone() { }

	[Address(RVA = "0x1D11C70", Offset = "0x1D11070", Length = "0x31")]
	[Token(Token = "0x6001038")]
	protected override bool get_IsExpEffectMove() { }

	[Address(RVA = "0x1D11CB0", Offset = "0x1D110B0", Length = "0x8")]
	[Token(Token = "0x6001037")]
	protected bool get_IsFirstFrame() { }

	[Address(RVA = "0x1D11CC0", Offset = "0x1D110C0", Length = "0x8")]
	[Token(Token = "0x600103C")]
	public Transform get_ModelTop() { }

	[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
	[Token(Token = "0x600102D")]
	public EnemyMover get_MoverComponent() { }

	[Address(RVA = "0x1D11CD0", Offset = "0x1D110D0", Length = "0x7")]
	[Token(Token = "0x6001030")]
	public int get_PoolIndex() { }

	[Address(RVA = "0x1CF2E90", Offset = "0x1CF2290", Length = "0x8")]
	[Token(Token = "0x6001032")]
	public Record get_RecordData() { }

	[Address(RVA = "0x1D11CE0", Offset = "0x1D110E0", Length = "0x19")]
	[Token(Token = "0x600103A")]
	public Vector3 get_ShakeResultVector() { }

	[Address(RVA = "0x1D11D00", Offset = "0x1D11100", Length = "0x7")]
	[Token(Token = "0x6001031")]
	public EnemySize get_SizeType() { }

	[Address(RVA = "0x1D11D10", Offset = "0x1D11110", Length = "0x9")]
	[Token(Token = "0x600103D")]
	public float get_TargetY() { }

	[Address(RVA = "0x1D11D20", Offset = "0x1D11120", Length = "0x3B")]
	[Token(Token = "0x600103B")]
	public Vector3 get_WorldPosition() { }

	[Address(RVA = "0x1D0D650", Offset = "0x1D0CA50", Length = "0x11F")]
	[Token(Token = "0x6001008")]
	public override List<String> GetBulletTemplates() { }

	[Address(RVA = "0x1D0D770", Offset = "0x1D0CB70", Length = "0xAC")]
	[Token(Token = "0x6000FF6")]
	public override int GetDamageScore() { }

	[Address(RVA = "0x1D0D820", Offset = "0x1D0CC20", Length = "0x8C")]
	[Token(Token = "0x6000FF7")]
	public override int GetDeathScore() { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x6000FF4")]
	protected virtual string GetDebugString() { }

	[Address(RVA = "0x1D0D8B0", Offset = "0x1D0CCB0", Length = "0x2D")]
	[Token(Token = "0x6001004")]
	protected override Vector3 GetDifferenceVector() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6001053")]
	public override GameObject GetObject() { }

	[Address(RVA = "0x1D0DA10", Offset = "0x1D0CE10", Length = "0x40")]
	[Token(Token = "0x6001044")]
	public EnePartsGroup GetParts(int tindex) { }

	[Address(RVA = "0x1D0D8E0", Offset = "0x1D0CCE0", Length = "0x4E")]
	[Token(Token = "0x6001045")]
	public EnePartsGroup GetPartsByName(string partsName) { }

	[Address(RVA = "0x1D0D930", Offset = "0x1D0CD30", Length = "0x94")]
	[Token(Token = "0x6001043")]
	public int GetPartsIndex(string partsName) { }

	[Address(RVA = "0x1D0D9D0", Offset = "0x1D0CDD0", Length = "0x38")]
	[Token(Token = "0x6001024")]
	public EnePartsGroup GetPartsInfo(int pno) { }

	[Address(RVA = "0x1D0DA60", Offset = "0x1D0CE60", Length = "0x78")]
	[Token(Token = "0x600104D")]
	public RenderData GetRenderData(Renderer r) { }

	[Address(RVA = "0x1D0DAE0", Offset = "0x1D0CEE0", Length = "0x55")]
	[Token(Token = "0x6001051")]
	public override List<String> GetRouteNames() { }

	[Address(RVA = "0x1D0DB40", Offset = "0x1D0CF40", Length = "0x131")]
	[Token(Token = "0x6000FE5")]
	public virtual void GetStart() { }

	[Address(RVA = "0x1D0DC80", Offset = "0x1D0D080", Length = "0x1C")]
	[Token(Token = "0x6000FE6")]
	public override toleType GetTolerance(attackType at) { }

	[Address(RVA = "0x1D0DCA0", Offset = "0x1D0D0A0", Length = "0x7")]
	[Token(Token = "0x6000FF8")]
	public override void HitBlink(attackType atype) { }

	[Address(RVA = "0x1D0DFC0", Offset = "0x1D0D3C0", Length = "0x4B7")]
	[Token(Token = "0x6000FDE")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D0DCB0", Offset = "0x1D0D0B0", Length = "0x177")]
	[Token(Token = "0x6001042")]
	private void InitializePartsList() { }

	[Address(RVA = "0x1D0DE30", Offset = "0x1D0D230", Length = "0x188")]
	[Token(Token = "0x6000FE1")]
	public override void InitializeToPlay() { }

	[Address(RVA = "0x1D0E480", Offset = "0x1D0D880", Length = "0x93")]
	[Token(Token = "0x6000FE4")]
	public virtual bool IsAlive() { }

	[Address(RVA = "0x1D0E520", Offset = "0x1D0D920", Length = "0x6C")]
	[Token(Token = "0x6001048")]
	protected bool IsAllSleeping() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000FED")]
	public override bool IsBossType() { }

	[Address(RVA = "0x1D0E590", Offset = "0x1D0D990", Length = "0xF")]
	[Token(Token = "0x6001035")]
	public static bool IsCauseOfDeathByPlayer(attackType atkType) { }

	[Address(RVA = "0x1D0E5A0", Offset = "0x1D0D9A0", Length = "0xF")]
	[Token(Token = "0x6001034")]
	public static bool IsCauseOfDeathNormal(attackType atkType) { }

	[Address(RVA = "0x1D0E5B0", Offset = "0x1D0D9B0", Length = "0x22")]
	[Token(Token = "0x6001025")]
	public bool IsDelayed() { }

	[Address(RVA = "0x1D0E5E0", Offset = "0x1D0D9E0", Length = "0xB")]
	[Token(Token = "0x6000FEA")]
	public override bool IsDestroyRateTarget() { }

	[Address(RVA = "0x1D0E600", Offset = "0x1D0DA00", Length = "0x17")]
	[Token(Token = "0x6001018")]
	public virtual bool IsGround() { }

	[Address(RVA = "0x1D0E5F0", Offset = "0x1D0D9F0", Length = "0xB")]
	[Token(Token = "0x6001019")]
	public bool IsGroundDivision() { }

	[Address(RVA = "0x1D0E620", Offset = "0x1D0DA20", Length = "0x91")]
	[Token(Token = "0x6000FF1")]
	public bool IsHormingTarget() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000FEC")]
	public override bool IsObstacle() { }

	[Address(RVA = "0x1D0E6C0", Offset = "0x1D0DAC0", Length = "0x4F")]
	[Token(Token = "0x6001046")]
	protected bool IsPartsModels() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000FEE")]
	public override bool IsPhysicsMove() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000FF0")]
	public override bool IsPoseRecord() { }

	[Address(RVA = "0x1D0E710", Offset = "0x1D0DB10", Length = "0x6B")]
	[Token(Token = "0x6001005")]
	public bool IsShakeProgress() { }

	[Address(RVA = "0x1D0E780", Offset = "0x1D0DB80", Length = "0x8")]
	[Token(Token = "0x6000FEF")]
	protected virtual bool IsSimpleCalc() { }

	[Address(RVA = "0x1CCE430", Offset = "0x1CCD830", Length = "0x7")]
	[Token(Token = "0x6001056")]
	private override void KANAI.Kernel.IPrefabBankObject.SetupCache() { }

	[Address(RVA = "0x1D0E790", Offset = "0x1D0DB90", Length = "0x2E1")]
	[Token(Token = "0x6000FE7")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1D0EA80", Offset = "0x1D0DE80", Length = "0x88")]
	[Token(Token = "0x6001041")]
	private int NumberingParts() { }

	[Address(RVA = "0x1D0EB10", Offset = "0x1D0DF10", Length = "0xC3")]
	[Token(Token = "0x6000FF2")]
	protected virtual void OnHitProgress(CollisionOrder nOther) { }

	[Address(RVA = "0x1D0EBE0", Offset = "0x1D0DFE0", Length = "0xC3")]
	[Token(Token = "0x6000FF3")]
	protected virtual void OnStayProgress(CollisionOrder nOther) { }

	[Address(RVA = "0x1D0ECB0", Offset = "0x1D0E0B0", Length = "0xD6")]
	[Token(Token = "0x6000FFF")]
	protected override void PartsFlushUpdate(float delta) { }

	[Address(RVA = "0x1D0ED90", Offset = "0x1D0E190", Length = "0x13F")]
	[Token(Token = "0x600101F")]
	protected void ProgressDisable() { }

	[Address(RVA = "0x1D0EED0", Offset = "0x1D0E2D0", Length = "0x164")]
	[Token(Token = "0x6000FE8")]
	protected override void ProgressEvent(float dt, int eventCount) { }

	[Address(RVA = "0x1D0F520", Offset = "0x1D0E920", Length = "0x19")]
	[Token(Token = "0x6001027")]
	protected void ReleaseToken() { }

	[Address(RVA = "0x1D11D60", Offset = "0x1D11160", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x600102C")]
	public void remove_PoolEvent(poolEventFunction value) { }

	[Address(RVA = "0x1D0F540", Offset = "0x1D0E940", Length = "0xDA")]
	[Token(Token = "0x600104B")]
	public void ResetMaterial() { }

	[Address(RVA = "0x1D0F620", Offset = "0x1D0EA20", Length = "0x7")]
	[Token(Token = "0x6001050")]
	public override void ResetParameters() { }

	[Address(RVA = "0x1D0F040", Offset = "0x1D0E440", Length = "0x4D0")]
	[Token(Token = "0x6000FE3")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1D0F630", Offset = "0x1D0EA30", Length = "0x1E")]
	[Token(Token = "0x6001052")]
	public override void SetActiveBank(bool tactive) { }

	[Address(RVA = "0x1D0F650", Offset = "0x1D0EA50", Length = "0x2C")]
	[Token(Token = "0x6001020")]
	public void SetBornArea(int aindex, int poolIndex) { }

	[Address(RVA = "0x1D0F680", Offset = "0x1D0EA80", Length = "0x1E")]
	[Token(Token = "0x6000FF5")]
	public override void SetCauseOfDeath(int playerNo, attackType atkType, bool isExboostDead) { }

	[Address(RVA = "0x1D0F6A0", Offset = "0x1D0EAA0", Length = "0x7")]
	[Token(Token = "0x600101A")]
	public void SetChildFlag(bool v) { }

	[Address(RVA = "0x1D0F6B0", Offset = "0x1D0EAB0", Length = "0x38")]
	[Token(Token = "0x600102E")]
	protected void SetDeadExplotion(string effectName) { }

	[Address(RVA = "0x1D0F6F0", Offset = "0x1D0EAF0", Length = "0x11")]
	[Token(Token = "0x6001022")]
	public void SetDelayTime(float ndelay, float nstart) { }

	[Address(RVA = "0x1D0F710", Offset = "0x1D0EB10", Length = "0xF1")]
	[Token(Token = "0x6000FEB")]
	public bool SetDestroyResult() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001017")]
	public override void SetDropItem(Kind ditem) { }

	[Address(RVA = "0x1D0F810", Offset = "0x1D0EC10", Length = "0x13")]
	[Token(Token = "0x6001015")]
	public void SetEaseType(EasingType etype) { }

	[Address(RVA = "0x1D0F830", Offset = "0x1D0EC30", Length = "0x154")]
	[Token(Token = "0x6001007")]
	public void SetEnemyLayer(Division tdivision, bool _isChild) { }

	[Address(RVA = "0x1D0F990", Offset = "0x1D0ED90", Length = "0x13")]
	[Token(Token = "0x6001014")]
	public void SetLookAtType(LookAtType ttype) { }

	[Address(RVA = "0x1D0F9B0", Offset = "0x1D0EDB0", Length = "0x7")]
	[Token(Token = "0x600102F")]
	protected void SetOverplayDeadSound(ExpSound seID) { }

	[Address(RVA = "0x1D0F9C0", Offset = "0x1D0EDC0", Length = "0x37E")]
	[Token(Token = "0x6000FE0")]
	public override void SetRecords(Record[] records) { }

	[Address(RVA = "0x1D0FD40", Offset = "0x1D0F140", Length = "0x35")]
	[Token(Token = "0x6001011")]
	public void SetRouteData(String[] routeNames, Vector3 spos) { }

	[Address(RVA = "0x1D0FD80", Offset = "0x1D0F180", Length = "0x38")]
	[Token(Token = "0x6001013")]
	public void SetRouteMatrix(Matrix4x4 m) { }

	[Address(RVA = "0x1D0FDC0", Offset = "0x1D0F1C0", Length = "0x13")]
	[Token(Token = "0x6001016")]
	public void SetSmooth(bool value) { }

	[Address(RVA = "0x1D0FDE0", Offset = "0x1D0F1E0", Length = "0x15")]
	[Token(Token = "0x6001012")]
	public void SetSpeed(float v) { }

	[Address(RVA = "0x1D0FE00", Offset = "0x1D0F200", Length = "0x38")]
	[Token(Token = "0x6001021")]
	public void SetSuside() { }

	[Address(RVA = "0x1D0FE40", Offset = "0x1D0F240", Length = "0x9")]
	[Token(Token = "0x600103E")]
	public void SetTargetY(float ty) { }

	[Address(RVA = "0x1D0FEE0", Offset = "0x1D0F2E0", Length = "0x339")]
	[Token(Token = "0x6001049")]
	private void SetupMaterial() { }

	[Address(RVA = "0x1D0FE50", Offset = "0x1D0F250", Length = "0x87")]
	[Token(Token = "0x600100B")]
	public override void SetWakeAfterSecond(float t) { }

	[Address(RVA = "0x1D10220", Offset = "0x1D0F620", Length = "0x7")]
	[Token(Token = "0x600101B")]
	public void SkipDestroyRate(bool v) { }

	[Address(RVA = "0x1D10230", Offset = "0x1D0F630", Length = "0x11D")]
	[Token(Token = "0x6001023")]
	public void StartKickWithDelayTime() { }

	[Address(RVA = "0x1D10350", Offset = "0x1D0F750", Length = "0x8F")]
	[Token(Token = "0x600100C")]
	public void StartOverrideRoute() { }

	[Address(RVA = "0x1D104F0", Offset = "0x1D0F8F0", Length = "0xAB")]
	[Token(Token = "0x600100A")]
	public override void StartRoute(Action callback) { }

	[Address(RVA = "0x1D103E0", Offset = "0x1D0F7E0", Length = "0x10A")]
	[Token(Token = "0x6001009")]
	public override void StartRouteWithDelay(Action callback, float activeDelay, float startDelay) { }

	[Address(RVA = "0x1D105A0", Offset = "0x1D0F9A0", Length = "0xBC")]
	[Token(Token = "0x6000FFA")]
	public void StopShake() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600104F")]
	public override EnemyChildData[] SubEnemys() { }

	[Address(RVA = "0x1D10660", Offset = "0x1D0FA60", Length = "0x250")]
	[Token(Token = "0x6000FDF")]
	public virtual void Terminate() { }

	[Address(RVA = "0x1D108C0", Offset = "0x1D0FCC0", Length = "0x18F")]
	[Token(Token = "0x6000FFC")]
	public virtual void ToDestroid() { }

	[Address(RVA = "0x1D10A50", Offset = "0x1D0FE50", Length = "0x14F")]
	[Token(Token = "0x6001000")]
	protected void ToProgressEnd() { }

	[Address(RVA = "0x1D10BA0", Offset = "0x1D0FFA0", Length = "0x152")]
	[Token(Token = "0x6000FE2")]
	private void UpdateDeadBulletCache() { }

	[Address(RVA = "0x1D10D00", Offset = "0x1D10100", Length = "0x15")]
	[Token(Token = "0x6001010")]
	public void UpdateObjectData(EnemyPlacementData pdata, float speedStep) { }

}

