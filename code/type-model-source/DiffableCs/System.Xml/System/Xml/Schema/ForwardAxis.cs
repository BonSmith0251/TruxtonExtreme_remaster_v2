namespace System.Xml.Schema;

[Token(Token = "0x200014D")]
internal class ForwardAxis
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000707")]
	private DoubleLinkAxis _topNode; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000708")]
	private DoubleLinkAxis _rootNode; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000709")]
	private bool _isAttribute; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x400070A")]
	private bool _isDss; //Field offset: 0x21
	[FieldOffset(Offset = "0x22")]
	[Token(Token = "0x400070B")]
	private bool _isSelfAxis; //Field offset: 0x22

	[Token(Token = "0x170003B9")]
	internal bool IsAttribute
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x6000E6D")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170003BA")]
	internal bool IsDss
	{
		[Address(RVA = "0x1E08E00", Offset = "0x1E08200", Length = "0x5")]
		[Token(Token = "0x6000E6E")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170003BB")]
	internal bool IsSelfAxis
	{
		[Address(RVA = "0x25832A0", Offset = "0x25826A0", Length = "0x5")]
		[Token(Token = "0x6000E6F")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170003B7")]
	internal DoubleLinkAxis RootNode
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000E6B")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170003B8")]
	internal DoubleLinkAxis TopNode
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000E6C")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x2583110", Offset = "0x2582510", Length = "0x18D")]
	[Token(Token = "0x6000E70")]
	public ForwardAxis(DoubleLinkAxis axis, bool isdesorself) { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x6000E6D")]
	internal bool get_IsAttribute() { }

	[Address(RVA = "0x1E08E00", Offset = "0x1E08200", Length = "0x5")]
	[Token(Token = "0x6000E6E")]
	internal bool get_IsDss() { }

	[Address(RVA = "0x25832A0", Offset = "0x25826A0", Length = "0x5")]
	[Token(Token = "0x6000E6F")]
	internal bool get_IsSelfAxis() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000E6B")]
	internal DoubleLinkAxis get_RootNode() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000E6C")]
	internal DoubleLinkAxis get_TopNode() { }

}

