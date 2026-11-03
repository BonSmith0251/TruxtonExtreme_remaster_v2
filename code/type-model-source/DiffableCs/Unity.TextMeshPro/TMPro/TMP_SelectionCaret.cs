namespace TMPro;

[RequireComponent(typeof(CanvasRenderer))]
[Token(Token = "0x2000085")]
public class TMP_SelectionCaret : MaskableGraphic
{

	[Address(RVA = "0x5C4070", Offset = "0x5C3470", Length = "0x7")]
	[Token(Token = "0x6000450")]
	public TMP_SelectionCaret() { }

	[Address(RVA = "0x2F0EA70", Offset = "0x2F0DE70", Length = "0xB1")]
	[Token(Token = "0x600044E")]
	public virtual void Cull(Rect clipRect, bool validRect) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600044F")]
	protected virtual void UpdateGeometry() { }

}

