namespace KANAI.UI;

[ExecuteAlways]
[RequireComponent(typeof(CanvasRenderer))]
[Token(Token = "0x200002E")]
public class UILineRenderer : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400014B")]
	private Color _lineColor; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400014C")]
	private List<Vector3> _points; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Range(0.001, 100)]
	[SerializeField]
	[Token(Token = "0x400014D")]
	private float _lineWidth; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400014E")]
	private Mesh _lineMesh; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400014F")]
	private CanvasRenderer _renderer; //Field offset: 0x48

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000139")]
	private void _canvasDraw() { }

	[Address(RVA = "0x1E225E0", Offset = "0x1E219E0", Length = "0x8A")]
	[Token(Token = "0x600013A")]
	public UILineRenderer() { }

	[Address(RVA = "0x1E222B0", Offset = "0x1E216B0", Length = "0x47")]
	[Token(Token = "0x6000136")]
	private void Awake() { }

	[Address(RVA = "0x1E22300", Offset = "0x1E21700", Length = "0x37")]
	[Token(Token = "0x6000133")]
	public void Initialize(List<Vector3> lists, float width = 1) { }

	[Address(RVA = "0x1E22340", Offset = "0x1E21740", Length = "0x7E")]
	[Token(Token = "0x6000138")]
	private void OnDestroy() { }

	[Address(RVA = "0x1E223C0", Offset = "0x1E217C0", Length = "0x2B")]
	[Token(Token = "0x6000134")]
	public void SetColor(Color c) { }

	[Address(RVA = "0x1E223F0", Offset = "0x1E217F0", Length = "0x6D")]
	[Token(Token = "0x6000137")]
	private void Start() { }

	[Address(RVA = "0x1E22460", Offset = "0x1E21860", Length = "0x17B")]
	[Token(Token = "0x6000135")]
	public void UpdateLine() { }

}

