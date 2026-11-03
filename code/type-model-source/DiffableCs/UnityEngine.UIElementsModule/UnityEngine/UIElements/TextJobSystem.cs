namespace UnityEngine.UIElements;

[Token(Token = "0x20004B0")]
internal class TextJobSystem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000FE7")]
	internal UITKTextJobSystem m_UITKTextJobSystem; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FE8")]
	private ATGTextJobSystem m_ATGTextJobSystem; //Field offset: 0x18

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60023A6")]
	public TextJobSystem() { }

	[Address(RVA = "0x32AC7A0", Offset = "0x32ABBA0", Length = "0x3CE")]
	[Token(Token = "0x60023A4")]
	internal void GenerateText(MeshGenerationContext mgc, TextElement textElement) { }

	[Address(RVA = "0x32ACB70", Offset = "0x32ABF70", Length = "0x8A")]
	[Token(Token = "0x60023A5")]
	internal void PrepareShapingBeforeLayout(BaseVisualElementPanel panel) { }

}

