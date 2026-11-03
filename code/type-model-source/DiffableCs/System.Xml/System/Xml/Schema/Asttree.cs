namespace System.Xml.Schema;

[Token(Token = "0x200014E")]
internal class Asttree
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400070C")]
	private ArrayList _fAxisArray; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400070D")]
	private string _xpathexpr; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400070E")]
	private bool _isField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400070F")]
	private XmlNamespaceManager _nsmgr; //Field offset: 0x28

	[Token(Token = "0x170003BC")]
	internal ArrayList SubtreeArray
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000E71")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x257A880", Offset = "0x2579C80", Length = "0x7B")]
	[Token(Token = "0x6000E72")]
	public Asttree(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	[Address(RVA = "0x2579DE0", Offset = "0x25791E0", Length = "0x8AF")]
	[Token(Token = "0x6000E77")]
	public void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000E71")]
	internal ArrayList get_SubtreeArray() { }

	[Address(RVA = "0x257A690", Offset = "0x2579A90", Length = "0x27")]
	[Token(Token = "0x6000E74")]
	internal static bool IsAttribute(Axis ast) { }

	[Address(RVA = "0x257A6C0", Offset = "0x2579AC0", Length = "0x2A")]
	[Token(Token = "0x6000E75")]
	private static bool IsDescendantOrSelf(Axis ast) { }

	[Address(RVA = "0x257A6F0", Offset = "0x2579AF0", Length = "0x27")]
	[Token(Token = "0x6000E73")]
	private static bool IsNameTest(Axis ast) { }

	[Address(RVA = "0x257A720", Offset = "0x2579B20", Length = "0x2A")]
	[Token(Token = "0x6000E76")]
	internal static bool IsSelf(Axis ast) { }

	[Address(RVA = "0x257A750", Offset = "0x2579B50", Length = "0x12D")]
	[Token(Token = "0x6000E78")]
	private void SetURN(Axis axis, XmlNamespaceManager nsmgr) { }

}

