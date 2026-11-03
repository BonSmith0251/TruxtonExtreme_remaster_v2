namespace System.Xml.Schema;

[Token(Token = "0x2000149")]
internal class AxisElement
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006FB")]
	internal DoubleLinkAxis curNode; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006FC")]
	internal int rootDepth; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40006FD")]
	internal int curDepth; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006FE")]
	internal bool isMatch; //Field offset: 0x20

	[Token(Token = "0x170003B2")]
	internal DoubleLinkAxis CurNode
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000E53")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x257B190", Offset = "0x257A590", Length = "0x49")]
	[Token(Token = "0x6000E54")]
	internal AxisElement(DoubleLinkAxis node, int depth) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000E53")]
	internal DoubleLinkAxis get_CurNode() { }

	[Address(RVA = "0x257AEA0", Offset = "0x257A2A0", Length = "0x189")]
	[Token(Token = "0x6000E57")]
	internal bool MoveToChild(string name, string URN, int depth, ForwardAxis parent) { }

	[Address(RVA = "0x257B030", Offset = "0x257A430", Length = "0x144")]
	[Token(Token = "0x6000E56")]
	internal void MoveToParent(int depth, ForwardAxis parent) { }

	[Address(RVA = "0x257B180", Offset = "0x257A580", Length = "0x7")]
	[Token(Token = "0x6000E55")]
	internal void SetDepth(int depth) { }

}

