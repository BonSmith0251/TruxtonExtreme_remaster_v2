namespace AEAsAnimation;

[RequireComponent(typeof(CanvasRenderer))]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x200004F")]
public class AELineImage : MaskableGraphic
{
	[Token(Token = "0x2000050")]
	internal enum LineMode : int
	{
		CENTER = 0,
		OUTER = 1,
		INNER = 2,
	}

	[Token(Token = "0x40001D1")]
	private const float DefaultAaWidth = 5; //Field offset: 0x0
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40001D0")]
	private List<LayerShapeBezierData> _points; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40001D2")]
	private float _aaWidth; //Field offset: 0xE8

	[Address(RVA = "0x5C3150", Offset = "0x5C2550", Length = "0x11")]
	[Token(Token = "0x6000145")]
	public AELineImage() { }

	[Address(RVA = "0x5C1E10", Offset = "0x5C1210", Length = "0x670")]
	[Token(Token = "0x6000144")]
	public void Create(List<Vector2> points, float size, LineMode linemode = 0) { }

	[Address(RVA = "0x5C2490", Offset = "0x5C1890", Length = "0xC1D")]
	[Token(Token = "0x6000142")]
	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	[Address(RVA = "0x5C30B0", Offset = "0x5C24B0", Length = "0x9E")]
	[Token(Token = "0x6000143")]
	public void Setup(AEMaskProcessor data, AVLayerStyleStrokeData stroke) { }

}

