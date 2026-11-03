namespace System.Xml;

[Token(Token = "0x2000054")]
internal class XmlTextEncoder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001CF")]
	private TextWriter textWriter; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001D0")]
	private bool inAttribute; //Field offset: 0x18
	[FieldOffset(Offset = "0x1A")]
	[Token(Token = "0x40001D1")]
	private char quoteChar; //Field offset: 0x1A
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001D2")]
	private StringBuilder attrValue; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001D3")]
	private bool cacheAttrValue; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001D4")]
	private XmlCharType xmlCharType; //Field offset: 0x30

	[Token(Token = "0x170000BB")]
	internal string AttributeValue
	{
		[Address(RVA = "0x24FCE40", Offset = "0x24FC240", Length = "0x46")]
		[Token(Token = "0x60003A4")]
		internal get { } //Length: 70
	}

	[Token(Token = "0x170000BA")]
	internal char QuoteChar
	{
		[Address(RVA = "0x24FCE90", Offset = "0x24FC290", Length = "0x5")]
		[Token(Token = "0x60003A1")]
		internal set { } //Length: 5
	}

	[Address(RVA = "0x24FCDF0", Offset = "0x24FC1F0", Length = "0x4D")]
	[Token(Token = "0x60003A0")]
	internal XmlTextEncoder(TextWriter textWriter) { }

	[Address(RVA = "0x24FB780", Offset = "0x24FAB80", Length = "0x35")]
	[Token(Token = "0x60003A3")]
	internal void EndAttribute() { }

	[Address(RVA = "0x24FCE40", Offset = "0x24FC240", Length = "0x46")]
	[Token(Token = "0x60003A4")]
	internal string get_AttributeValue() { }

	[Address(RVA = "0x24FCE90", Offset = "0x24FC290", Length = "0x5")]
	[Token(Token = "0x60003A1")]
	internal void set_QuoteChar(char value) { }

	[Address(RVA = "0x24FB7C0", Offset = "0x24FABC0", Length = "0x8A")]
	[Token(Token = "0x60003A2")]
	internal void StartAttribute(bool cacheAttrValue) { }

	[Address(RVA = "0x24FC800", Offset = "0x24FBC00", Length = "0x5E3")]
	[Token(Token = "0x60003A6")]
	internal void Write(Char[] array, int offset, int count) { }

	[Address(RVA = "0x24FC2B0", Offset = "0x24FB6B0", Length = "0x54C")]
	[Token(Token = "0x60003A8")]
	internal void Write(string text) { }

	[Address(RVA = "0x24FB960", Offset = "0x24FAD60", Length = "0x13A")]
	[Token(Token = "0x60003AB")]
	internal void WriteCharEntity(char ch) { }

	[Address(RVA = "0x24FB8C0", Offset = "0x24FACC0", Length = "0x9F")]
	[Token(Token = "0x60003AF")]
	private void WriteCharEntityImpl(string strVal) { }

	[Address(RVA = "0x24FB850", Offset = "0x24FAC50", Length = "0x67")]
	[Token(Token = "0x60003AE")]
	private void WriteCharEntityImpl(char ch) { }

	[Address(RVA = "0x24FBB30", Offset = "0x24FAF30", Length = "0x73")]
	[Token(Token = "0x60003AC")]
	internal void WriteEntityRef(string name) { }

	[Address(RVA = "0x24FBAA0", Offset = "0x24FAEA0", Length = "0x81")]
	[Token(Token = "0x60003B0")]
	private void WriteEntityRefImpl(string name) { }

	[Address(RVA = "0x24FBDD0", Offset = "0x24FB1D0", Length = "0x1BF")]
	[Token(Token = "0x60003AA")]
	internal void WriteRaw(Char[] array, int offset, int count) { }

	[Address(RVA = "0x24FBBB0", Offset = "0x24FAFB0", Length = "0x212")]
	[Token(Token = "0x60003A9")]
	internal void WriteRawWithSurrogateChecking(string text) { }

	[Address(RVA = "0x24FBF90", Offset = "0x24FB390", Length = "0xAF")]
	[Token(Token = "0x60003AD")]
	private void WriteStringFragment(string str, int offset, int count, Char[] helperBuffer) { }

	[Address(RVA = "0x24FC1E0", Offset = "0x24FB5E0", Length = "0xC7")]
	[Token(Token = "0x60003A5")]
	internal void WriteSurrogateChar(char lowChar, char highChar) { }

	[Address(RVA = "0x24FC040", Offset = "0x24FB440", Length = "0x190")]
	[Token(Token = "0x60003A7")]
	internal void WriteSurrogateCharEntity(char lowChar, char highChar) { }

}

