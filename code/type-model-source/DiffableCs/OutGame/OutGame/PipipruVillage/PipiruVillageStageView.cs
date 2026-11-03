namespace OutGame.PipipruVillage;

[Token(Token = "0x2000101")]
public class PipiruVillageStageView : MonoBehaviour, IDisposable
{
	[Token(Token = "0x4000417")]
	public const float TotalLayerAnimeTime = 2; //Field offset: 0x0
	[Token(Token = "0x4000418")]
	public const float LayerAnimeTime = 1; //Field offset: 0x0
	[Token(Token = "0x4000419")]
	public const float TotalDelayTime = 1; //Field offset: 0x0
	[Token(Token = "0x400041A")]
	public const float ObjectAnimeTime = 1; //Field offset: 0x0
	[Token(Token = "0x400041B")]
	public const float ScaleMin = 1E-06; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400041C")]
	private float _stageScale; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x400041D")]
	private Rect _cameraMoveRange; //Field offset: 0x24
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x400041E")]
	private Rect _scrollRange; //Field offset: 0x34
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x400041F")]
	private float _scrollSpeedSideRate; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000420")]
	private float _scrollSpeedVirticalRate; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000421")]
	private Camera _mainCamera; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000422")]
	private Action<Vector3, Single> OnSetCamera; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000423")]
	private int _stageNum; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000424")]
	private int _availableLevel; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000425")]
	private int _prevAvailableLevel; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000426")]
	private int _startLevel; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000427")]
	private int _endLevel; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000428")]
	private Dictionary<Int32, List`1<PipiruVillageStageObjectLevel>> _levelObjectDict; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000429")]
	private Dictionary<Int32, PipiruVillageStageObjectLayer> _layerObjectDict; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400042A")]
	private Vector3 _baseScrollPos; //Field offset: 0x88

	[Token(Token = "0x14000004")]
	public event Action<Vector3, Single> OnSetCamera
	{
		[Address(RVA = "0x21F32B0", Offset = "0x21F26B0", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x600066F")]
		 add { } //Length: 172
		[Address(RVA = "0x21F3360", Offset = "0x21F2760", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6000670")]
		 remove { } //Length: 172
	}

	[Address(RVA = "0x21F1E50", Offset = "0x21F1250", Length = "0x202")]
	[Token(Token = "0x600066E")]
	private void _attention(float param) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000669")]
	private void _environmental() { }

	[Address(RVA = "0x21F20F0", Offset = "0x21F14F0", Length = "0x13D")]
	[Token(Token = "0x6000663")]
	private void _initializeObjects() { }

	[Address(RVA = "0x21F2230", Offset = "0x21F1630", Length = "0x5B1")]
	[Token(Token = "0x6000664")]
	private void _initializeObjects(Transform stageObjects) { }

	[Address(RVA = "0x21F27F0", Offset = "0x21F1BF0", Length = "0xF")]
	[Token(Token = "0x600066B")]
	private bool _isDisplayLayerObject(int requestLevel) { }

	[Address(RVA = "0x21F2800", Offset = "0x21F1C00", Length = "0x2D")]
	[Token(Token = "0x600066A")]
	private bool _isDisplayLevelObject(int requestLevel, int objectLevel, int localLeaveLevel = -1) { }

	[Address(RVA = "0x21F2830", Offset = "0x21F1C30", Length = "0x3CB")]
	[Token(Token = "0x600066D")]
	private ValueTuple<Single, Single> _scroll(Vector3 deltaPos) { }

	[Address(RVA = "0x21F2C00", Offset = "0x21F2000", Length = "0x233")]
	[Token(Token = "0x6000665")]
	private void _setLayerDelayTime() { }

	[Address(RVA = "0x21F2E40", Offset = "0x21F2240", Length = "0x461")]
	[Token(Token = "0x6000668")]
	public void _updateStageObject(float deltaTime, int requestLevel) { }

	[Address(RVA = "0x21F2060", Offset = "0x21F1460", Length = "0x8C")]
	[Token(Token = "0x6000671")]
	public PipiruVillageStageView() { }

	[Address(RVA = "0x21F1940", Offset = "0x21F0D40", Length = "0x7F")]
	[Token(Token = "0x600066C")]
	public void AcceptActions(RequestActions action, float param) { }

	[Address(RVA = "0x21F32B0", Offset = "0x21F26B0", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x600066F")]
	public void add_OnSetCamera(Action<Vector3, Single> value) { }

	[Address(RVA = "0x21F19C0", Offset = "0x21F0DC0", Length = "0x8F")]
	[Token(Token = "0x6000662")]
	public override void Dispose() { }

	[Address(RVA = "0x21F1A50", Offset = "0x21F0E50", Length = "0xC8")]
	[Token(Token = "0x6000667")]
	public static int ExtractLayerFromObjectName(string objectName) { }

	[Address(RVA = "0x21F1B20", Offset = "0x21F0F20", Length = "0xC8")]
	[Token(Token = "0x6000666")]
	public static int ExtractLevelFromObjectName(string objectName) { }

	[Address(RVA = "0x21F1BF0", Offset = "0x21F0FF0", Length = "0x210")]
	[Token(Token = "0x600065F")]
	public void Initialize(int stageNum, int availableLevel, int prevAvailableLevel) { }

	[Address(RVA = "0x21F3360", Offset = "0x21F2760", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6000670")]
	public void remove_OnSetCamera(Action<Vector3, Single> value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000660")]
	public void StartContent() { }

	[Address(RVA = "0x21F1E10", Offset = "0x21F1210", Length = "0x31")]
	[Token(Token = "0x6000661")]
	public void UpdateContent(int requestLevel) { }

}

