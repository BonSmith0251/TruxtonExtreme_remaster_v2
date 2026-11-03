namespace UnityEngine.UI;

[Token(Token = "0x2000010")]
internal class RectangularVertexClipper
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002F")]
	private readonly Vector3[] m_WorldCorners; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000030")]
	private readonly Vector3[] m_CanvasCorners; //Field offset: 0x18

	[Address(RVA = "0x31EC830", Offset = "0x31EBC30", Length = "0x76")]
	[Token(Token = "0x600005A")]
	public RectangularVertexClipper() { }

	[Address(RVA = "0x31EC660", Offset = "0x31EBA60", Length = "0x1C8")]
	[Token(Token = "0x6000059")]
	public Rect GetCanvasRect(RectTransform t, Canvas c) { }

}

