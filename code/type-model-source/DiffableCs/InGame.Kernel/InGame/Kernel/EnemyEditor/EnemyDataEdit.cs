namespace InGame.Kernel.EnemyEditor;

[Token(Token = "0x200023C")]
public class EnemyDataEdit : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x200023D")]
	private sealed class <>c
	{
		[Token(Token = "0x40013CD")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40013CE")]
		public static Comparison<RouteEvent> <>9__8_0; //Field offset: 0x8
		[Token(Token = "0x40013CF")]
		public static Comparison<RouteEvent> <>9__19_0; //Field offset: 0x10

		[Address(RVA = "0x1D1AB30", Offset = "0x1D19F30", Length = "0x67")]
		[Token(Token = "0x6001125")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001126")]
		public <>c() { }

		[Address(RVA = "0x1D1A970", Offset = "0x1D19D70", Length = "0x27")]
		[Token(Token = "0x6001128")]
		internal int <_export>b__19_0(RouteEvent a, RouteEvent b) { }

		[Address(RVA = "0x1D1A970", Offset = "0x1D19D70", Length = "0x27")]
		[Token(Token = "0x6001127")]
		internal int <Add>b__8_0(RouteEvent a, RouteEvent b) { }

	}

	[Token(Token = "0x40013B9")]
	private const string _basePath = "Assets/Samples/EnemyData"; //Field offset: 0x0
	[Token(Token = "0x40013BA")]
	private const int _dataVersionMaster = 539099684; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013BB")]
	private int _dataVersion; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x40013BC")]
	private EnemyAttribute _attribute; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40013BD")]
	private string _objectName; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40013BE")]
	private String[] _routeNames; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40013BF")]
	private Vector3 _startPosition; //Field offset: 0x38
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x40013C0")]
	private float _invincibleTime; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40013C1")]
	private float _duration; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40013C2")]
	private EnemyPlacementData[] _placementDatas; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40013C3")]
	private EnemyRepeatData[] _repeatDatas; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x40013C4")]
	private List<RouteEvent> _events; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40013C5")]
	private string _fileFullPath; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40013C6")]
	private string _filename; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40013C7")]
	private bool _isLoad; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40013C8")]
	private List<String> _enemyObjectNames; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40013C9")]
	private String[] _enemyObjectGroupNames; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40013CA")]
	private List<String> _enemyRouteNames; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40013CB")]
	private List<String> _bulletNames; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40013CC")]
	private List<String> _bulletSelecters; //Field offset: 0xA0

	[Token(Token = "0x17000236")]
	public String[] enemyObjectGroupNames
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[Token(Token = "0x6001120")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000235")]
	public List<String> enemyObjectNames
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x600111F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000237")]
	public List<String> enemyRouteNames
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x6001121")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000234")]
	public string filename
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x600111E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000233")]
	public float InvincibleTime
	{
		[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
		[Token(Token = "0x600111D")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000238")]
	public bool IsLoad
	{
		[Address(RVA = "0x1D14910", Offset = "0x1D13D10", Length = "0x5")]
		[Token(Token = "0x6001122")]
		 get { } //Length: 5
		[Address(RVA = "0x1D14EE0", Offset = "0x1D142E0", Length = "0x4")]
		[Token(Token = "0x6001123")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000231")]
	public string ObjectName
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x600111A")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x600111B")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000232")]
	public Vector3 StartPosition
	{
		[Address(RVA = "0x1D14EC0", Offset = "0x1D142C0", Length = "0x13")]
		[Token(Token = "0x600111C")]
		 get { } //Length: 19
	}

	[Address(RVA = "0x1D14AE0", Offset = "0x1D13EE0", Length = "0x1F9")]
	[Token(Token = "0x6001119")]
	private EnemyData _export() { }

	[Address(RVA = "0x1D14CE0", Offset = "0x1D140E0", Length = "0x1C2")]
	[Token(Token = "0x6001118")]
	private void _import(EnemyData data) { }

	[Address(RVA = "0x1D14940", Offset = "0x1D13D40", Length = "0x191")]
	[Token(Token = "0x6001124")]
	public EnemyDataEdit() { }

	[Address(RVA = "0x1D13FF0", Offset = "0x1D133F0", Length = "0x1AB")]
	[Token(Token = "0x600110E")]
	public void Add(RouteEvent e) { }

	[Address(RVA = "0x1D141A0", Offset = "0x1D135A0", Length = "0x1E")]
	[Token(Token = "0x6001107")]
	private void Awake() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600110F")]
	public void ClearEnemys() { }

	[Address(RVA = "0x1D141C0", Offset = "0x1D135C0", Length = "0xA4")]
	[Token(Token = "0x600110D")]
	public void ClearPosition(bool isReload = false) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600110C")]
	public List<PawnEnemy> CreateDammyEnemy(Transform root) { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[Token(Token = "0x6001120")]
	public String[] get_enemyObjectGroupNames() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x600111F")]
	public List<String> get_enemyObjectNames() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x6001121")]
	public List<String> get_enemyRouteNames() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x600111E")]
	public string get_filename() { }

	[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
	[Token(Token = "0x600111D")]
	public float get_InvincibleTime() { }

	[Address(RVA = "0x1D14910", Offset = "0x1D13D10", Length = "0x5")]
	[Token(Token = "0x6001122")]
	public bool get_IsLoad() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x600111A")]
	public string get_ObjectName() { }

	[Address(RVA = "0x1D14EC0", Offset = "0x1D142C0", Length = "0x13")]
	[Token(Token = "0x600111C")]
	public Vector3 get_StartPosition() { }

	[Address(RVA = "0x1D14270", Offset = "0x1D13670", Length = "0x47")]
	[Token(Token = "0x6001112")]
	public String[] GetBulletSelecterNames() { }

	[Address(RVA = "0x1D142C0", Offset = "0x1D136C0", Length = "0x47")]
	[Token(Token = "0x6001111")]
	public String[] GetBulletTemplateNames() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001110")]
	public String[] GetHierarchyNames() { }

	[Address(RVA = "0x1D14820", Offset = "0x1D13C20", Length = "0xCF")]
	[Token(Token = "0x6001113")]
	public Spline GetRoute(int tindex) { }

	[Address(RVA = "0x1D14310", Offset = "0x1D13710", Length = "0x49")]
	[Token(Token = "0x6001115")]
	public int GetRouteCount() { }

	[Address(RVA = "0x1D14360", Offset = "0x1D13760", Length = "0x15A")]
	[Token(Token = "0x6001114")]
	public Vector3 GetRouteOffset(int tindex) { }

	[Address(RVA = "0x1D144C0", Offset = "0x1D138C0", Length = "0x35C")]
	[Token(Token = "0x6001116")]
	public Vector3 GetRoutePosition(float rate) { }

	[Address(RVA = "0x1D148F0", Offset = "0x1D13CF0", Length = "0x19")]
	[Token(Token = "0x600110A")]
	public bool IsEnemyData() { }

	[Address(RVA = "0x1D14910", Offset = "0x1D13D10", Length = "0x5")]
	[Token(Token = "0x6001108")]
	public bool Load() { }

	[Address(RVA = "0x1D14920", Offset = "0x1D13D20", Length = "0x5")]
	[Token(Token = "0x6001117")]
	private void OnValidate() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6001109")]
	public bool Save(string _vname) { }

	[Address(RVA = "0x1D14EE0", Offset = "0x1D142E0", Length = "0x4")]
	[Token(Token = "0x6001123")]
	public void set_IsLoad(bool value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x600111B")]
	public void set_ObjectName(string value) { }

	[Address(RVA = "0x1D14930", Offset = "0x1D13D30", Length = "0x10")]
	[Token(Token = "0x600110B")]
	public void SetStartPosition(Vector3 pos) { }

}

