namespace System.Globalization;

[Token(Token = "0x2000574")]
internal class CodePageDataItem
{
	[Token(Token = "0x40016F1")]
	private static readonly Char[] sep; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40016ED")]
	internal int m_dataIndex; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40016EE")]
	internal int m_uiFamilyCodePage; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40016EF")]
	internal string m_webName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40016F0")]
	internal uint m_flags; //Field offset: 0x20

	[Token(Token = "0x170005DB")]
	public string WebName
	{
		[Address(RVA = "0x1FA8860", Offset = "0x1FA7C60", Length = "0x145")]
		[Token(Token = "0x600286B")]
		 get { } //Length: 325
	}

	[Address(RVA = "0x1FA8710", Offset = "0x1FA7B10", Length = "0x84")]
	[Token(Token = "0x600286C")]
	private static CodePageDataItem() { }

	[Address(RVA = "0x1FA87A0", Offset = "0x1FA7BA0", Length = "0xBA")]
	[Token(Token = "0x6002869")]
	internal CodePageDataItem(int dataIndex) { }

	[Address(RVA = "0x1FA8650", Offset = "0x1FA7A50", Length = "0xB0")]
	[Token(Token = "0x600286A")]
	internal static string CreateString(string pStrings, uint index) { }

	[Address(RVA = "0x1FA8860", Offset = "0x1FA7C60", Length = "0x145")]
	[Token(Token = "0x600286B")]
	public string get_WebName() { }

}

