namespace System.Net;

[DefaultMember("Item")]
[Token(Token = "0x2000263")]
internal class HeaderInfoTable
{
	[Token(Token = "0x40009B6")]
	private static Hashtable HeaderHashTable; //Field offset: 0x0
	[Token(Token = "0x40009B7")]
	private static HeaderInfo UnknownHeaderInfo; //Field offset: 0x8
	[Token(Token = "0x40009B8")]
	private static HeaderParser SingleParser; //Field offset: 0x10
	[Token(Token = "0x40009B9")]
	private static HeaderParser MultiParser; //Field offset: 0x18

	[Token(Token = "0x17000350")]
	internal HeaderInfo Item
	{
		[Address(RVA = "0x26C7330", Offset = "0x26C6730", Length = "0xE9")]
		[Token(Token = "0x6001017")]
		internal get { } //Length: 233
	}

	[Address(RVA = "0x26C4CE0", Offset = "0x26C40E0", Length = "0x2649")]
	[Token(Token = "0x6001016")]
	private static HeaderInfoTable() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001018")]
	public HeaderInfoTable() { }

	[Address(RVA = "0x26C7330", Offset = "0x26C6730", Length = "0xE9")]
	[Token(Token = "0x6001017")]
	internal HeaderInfo get_Item(string name) { }

	[Address(RVA = "0x26C4A50", Offset = "0x26C3E50", Length = "0x20D")]
	[Token(Token = "0x6001015")]
	private static String[] ParseMultiValue(string value) { }

	[Address(RVA = "0x26C4C60", Offset = "0x26C4060", Length = "0x71")]
	[Token(Token = "0x6001014")]
	private static String[] ParseSingleValue(string value) { }

}

