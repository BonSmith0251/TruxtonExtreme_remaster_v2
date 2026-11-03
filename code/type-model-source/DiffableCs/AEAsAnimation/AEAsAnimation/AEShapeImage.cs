namespace AEAsAnimation;

[RequireComponent(typeof(CanvasRenderer))]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x2000051")]
public class AEShapeImage : MaskableGraphic
{
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40001D7")]
	private List<LayerShapeBezierData> _points; //Field offset: 0xE0

	[Address(RVA = "0x5C4070", Offset = "0x5C3470", Length = "0x7")]
	[Token(Token = "0x6000149")]
	public AEShapeImage() { }

	[Address(RVA = "0x5C34F0", Offset = "0x5C28F0", Length = "0x40C")]
	[Token(Token = "0x6000146")]
	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	[Address(RVA = "0x5C30B0", Offset = "0x5C24B0", Length = "0x9E")]
	[Token(Token = "0x6000147")]
	public void Setup(AEMaskProcessor data) { }

	[Address(RVA = "0x5C3900", Offset = "0x5C2D00", Length = "0x764")]
	[Token(Token = "0x6000148")]
	public void SetupRect(float x, float y, float width, float height) { }

}

