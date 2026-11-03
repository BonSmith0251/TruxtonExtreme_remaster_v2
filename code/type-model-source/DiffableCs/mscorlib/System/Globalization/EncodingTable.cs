namespace System.Globalization;

[Token(Token = "0x2000575")]
internal static class EncodingTable
{
	[Token(Token = "0x40016F2")]
	internal static InternalEncodingDataItem[] encodingDataPtr; //Field offset: 0x0
	[Token(Token = "0x40016F3")]
	internal static InternalCodePageDataItem[] codePageDataPtr; //Field offset: 0x8
	[Token(Token = "0x40016F4")]
	private static int lastEncodingItem; //Field offset: 0x10
	[Token(Token = "0x40016F5")]
	private static Dictionary<String, Int32> hashByName; //Field offset: 0x18
	[Token(Token = "0x40016F6")]
	private static Dictionary<Int32, CodePageDataItem> hashByCodePage; //Field offset: 0x20

	[Address(RVA = "0x1FAFFD0", Offset = "0x1FAF3D0", Length = "0xA765")]
	[Token(Token = "0x6002870")]
	private static EncodingTable() { }

	[Address(RVA = "0x1FAF9E0", Offset = "0x1FAEDE0", Length = "0x33")]
	[Token(Token = "0x600286E")]
	private static InternalEncodingDataItem ENC(string name, ushort cp) { }

	[Address(RVA = "0x1FAFA20", Offset = "0x1FAEE20", Length = "0x2BD")]
	[Token(Token = "0x6002873")]
	internal static CodePageDataItem GetCodePageDataItem(int codepage) { }

	[Address(RVA = "0x1FAFCE0", Offset = "0x1FAF0E0", Length = "0x245")]
	[Token(Token = "0x6002872")]
	internal static int GetCodePageFromName(string name) { }

	[Address(RVA = "0x1FAFF30", Offset = "0x1FAF330", Length = "0x5B")]
	[Token(Token = "0x600286D")]
	private static int GetNumEncodingItems() { }

	[Address(RVA = "0x1FBA740", Offset = "0x1FB9B40", Length = "0x29C")]
	[Token(Token = "0x6002871")]
	private static int internalGetCodePageFromName(string name) { }

	[Address(RVA = "0x1FAFF90", Offset = "0x1FAF390", Length = "0x31")]
	[Token(Token = "0x600286F")]
	private static InternalCodePageDataItem MapCodePageDataItem(ushort cp, ushort fcp, string names, uint flags) { }

}

