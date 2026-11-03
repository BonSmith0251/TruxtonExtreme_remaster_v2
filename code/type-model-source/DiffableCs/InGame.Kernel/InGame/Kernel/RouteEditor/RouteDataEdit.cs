namespace InGame.Kernel.RouteEditor;

[Token(Token = "0x2000108")]
public class RouteDataEdit : MonoBehaviour
{
	[Token(Token = "0x2000109")]
	internal enum CircleDirection : int
	{
		XY = 0,
		XZ = 1,
		YZ = 2,
	}

	[Token(Token = "0x400073D")]
	private const string _basePath = "Assets/Samples/RouteData"; //Field offset: 0x0
	[Token(Token = "0x400073E")]
	private const float speedCoefficient = 100; //Field offset: 0x0
	[Token(Token = "0x400073F")]
	private const int _dataVersionMaster = 539099681; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000740")]
	private int _dataVersion; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Range(0.1, 180)]
	[SerializeField]
	[Token(Token = "0x4000741")]
	private float _duration; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000742")]
	private Vector3 _rotate; //Field offset: 0x28
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000743")]
	private PathType _pathKind; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000744")]
	private LookAtType _lookAtType; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x4000745")]
	private Ease _easeKind; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000746")]
	private string _routeName; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000747")]
	private List<Vector3> _routeDatas; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000748")]
	private List<RouteEvent> _eventDatas; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000749")]
	public bool isMoveSpeedMode; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Range(0.01, 20)]
	[SerializeField]
	[Token(Token = "0x400074A")]
	public float _moveSpeedValue; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x400074B")]
	public string DammyObjectName; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400074C")]
	private string _filename; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400074D")]
	private bool _isLoad; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400074E")]
	private double _dummyDistance; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400074F")]
	private string _currentRouteName; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000750")]
	private GameObject _currentRouteObject; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000751")]
	private List<String> _enemyObjectNames; //Field offset: 0x90

	[Token(Token = "0x17000180")]
	public double Distance
	{
		[Address(RVA = "0x1D509C0", Offset = "0x1D4FDC0", Length = "0x6")]
		[Token(Token = "0x6000840")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000177")]
	public float Duration
	{
		[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
		[Token(Token = "0x6000837")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700017B")]
	public Ease easeKind
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x600083B")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700017D")]
	public List<RouteEvent> eventDatas
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x600083D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700017E")]
	public string filename
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x600083E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700017F")]
	public bool IsLoad
	{
		[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
		[Token(Token = "0x600083F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700017A")]
	public LookAtType lookAtType
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x600083A")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000179")]
	public PathType pathKind
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x6000839")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000178")]
	public Vector3 Rotate
	{
		[Address(RVA = "0x1D509D0", Offset = "0x1D4FDD0", Length = "0x13")]
		[Token(Token = "0x6000838")]
		 get { } //Length: 19
	}

	[Token(Token = "0x1700017C")]
	public List<Vector3> routeDatas
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x600083C")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1D50200", Offset = "0x1D4F600", Length = "0x387")]
	[Token(Token = "0x6000834")]
	private double _getDistance() { }

	[Address(RVA = "0x1D50590", Offset = "0x1D4F990", Length = "0x428")]
	[Token(Token = "0x6000835")]
	private void _import(RouteData data) { }

	[Address(RVA = "0x1D50020", Offset = "0x1D4F420", Length = "0x1DC")]
	[Token(Token = "0x6000841")]
	public RouteDataEdit() { }

	[Address(RVA = "0x1D4F3B0", Offset = "0x1D4E7B0", Length = "0xC4")]
	[Token(Token = "0x6000823")]
	public void AddPosition(Vector3 pos, bool isBuffer = true) { }

	[Address(RVA = "0x1D4F480", Offset = "0x1D4E880", Length = "0x25")]
	[Token(Token = "0x600081F")]
	private void Awake() { }

	[Address(RVA = "0x1D4F4B0", Offset = "0x1D4E8B0", Length = "0x5A")]
	[Token(Token = "0x600082C")]
	public void ClearPosition(bool isReload = false) { }

	[Address(RVA = "0x1D4F510", Offset = "0x1D4E910", Length = "0x18C")]
	[Token(Token = "0x6000836")]
	public RouteData ExportData() { }

	[Address(RVA = "0x1D509C0", Offset = "0x1D4FDC0", Length = "0x6")]
	[Token(Token = "0x6000840")]
	public double get_Distance() { }

	[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
	[Token(Token = "0x6000837")]
	public float get_Duration() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x600083B")]
	public Ease get_easeKind() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x600083D")]
	public List<RouteEvent> get_eventDatas() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x600083E")]
	public string get_filename() { }

	[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
	[Token(Token = "0x600083F")]
	public bool get_IsLoad() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x600083A")]
	public LookAtType get_lookAtType() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x6000839")]
	public PathType get_pathKind() { }

	[Address(RVA = "0x1D509D0", Offset = "0x1D4FDD0", Length = "0x13")]
	[Token(Token = "0x6000838")]
	public Vector3 get_Rotate() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x600083C")]
	public List<Vector3> get_routeDatas() { }

	[Address(RVA = "0x1D4F6A0", Offset = "0x1D4EAA0", Length = "0x3C")]
	[Token(Token = "0x600082A")]
	public int GetEventCount() { }

	[Address(RVA = "0x1D4F6E0", Offset = "0x1D4EAE0", Length = "0xB")]
	[Token(Token = "0x6000832")]
	private RouteDataFlag GetFlag() { }

	[Address(RVA = "0x1D4F6F0", Offset = "0x1D4EAF0", Length = "0xF3")]
	[Token(Token = "0x600082B")]
	public Vector3[] GetPosition() { }

	[Address(RVA = "0x1D4F7F0", Offset = "0x1D4EBF0", Length = "0x3C")]
	[Token(Token = "0x6000829")]
	public int GetRouteCount() { }

	[Address(RVA = "0x1D4F830", Offset = "0x1D4EC30", Length = "0x73")]
	[Token(Token = "0x6000822")]
	public bool IsRouteData() { }

	[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
	[Token(Token = "0x6000820")]
	public bool Load() { }

	[Address(RVA = "0x1D4F8B0", Offset = "0x1D4ECB0", Length = "0x5")]
	[Token(Token = "0x6000828")]
	public void Loaded() { }

	[Address(RVA = "0x1D4F8C0", Offset = "0x1D4ECC0", Length = "0x5")]
	[Token(Token = "0x6000830")]
	private void OnValidate() { }

	[Address(RVA = "0x1D4F8D0", Offset = "0x1D4ECD0", Length = "0x4B")]
	[Token(Token = "0x6000826")]
	public void RefreshData() { }

	[Address(RVA = "0x1D4F8C0", Offset = "0x1D4ECC0", Length = "0x5")]
	[Token(Token = "0x6000827")]
	public void ReLoad() { }

	[Address(RVA = "0x1D4F920", Offset = "0x1D4ED20", Length = "0x76")]
	[Token(Token = "0x6000824")]
	public void RemovePosition(int index) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000821")]
	public bool Save(string _vname) { }

	[Address(RVA = "0x1D4F9A0", Offset = "0x1D4EDA0", Length = "0xF2")]
	[Token(Token = "0x6000833")]
	private void SetFlag(RouteDataFlag _flag) { }

	[Address(RVA = "0x1D4FAA0", Offset = "0x1D4EEA0", Length = "0xE4")]
	[Token(Token = "0x6000825")]
	public Vector3 Tail() { }

	[Address(RVA = "0x1D4FB90", Offset = "0x1D4EF90", Length = "0x97")]
	[Token(Token = "0x6000831")]
	private void Update() { }

	[Address(RVA = "0x1D4FC30", Offset = "0x1D4F030", Length = "0x142")]
	[Token(Token = "0x600082D")]
	public void XFlip() { }

	[Address(RVA = "0x1D4FD80", Offset = "0x1D4F180", Length = "0x142")]
	[Token(Token = "0x600082E")]
	public void YFlip() { }

	[Address(RVA = "0x1D4FED0", Offset = "0x1D4F2D0", Length = "0x142")]
	[Token(Token = "0x600082F")]
	public void ZFlip() { }

}

