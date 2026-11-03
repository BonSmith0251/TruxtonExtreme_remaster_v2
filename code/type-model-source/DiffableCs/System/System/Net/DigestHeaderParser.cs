namespace System.Net;

[Token(Token = "0x2000298")]
internal class DigestHeaderParser
{
	[Token(Token = "0x4000A85")]
	private static String[] keywords; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A82")]
	private string header; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A83")]
	private int length; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000A84")]
	private int pos; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A86")]
	private String[] values; //Field offset: 0x20

	[Token(Token = "0x170003A2")]
	public string Algorithm
	{
		[Address(RVA = "0x1F73FC0", Offset = "0x1F733C0", Length = "0x27")]
		[Token(Token = "0x6001146")]
		 get { } //Length: 39
	}

	[Token(Token = "0x170003A1")]
	public string Nonce
	{
		[Address(RVA = "0x1F73F90", Offset = "0x1F73390", Length = "0x27")]
		[Token(Token = "0x6001145")]
		 get { } //Length: 39
	}

	[Token(Token = "0x170003A0")]
	public string Opaque
	{
		[Address(RVA = "0x1F73F30", Offset = "0x1F73330", Length = "0x27")]
		[Token(Token = "0x6001144")]
		 get { } //Length: 39
	}

	[Token(Token = "0x170003A3")]
	public string QOP
	{
		[Address(RVA = "0x1F73FF0", Offset = "0x1F733F0", Length = "0x27")]
		[Token(Token = "0x6001147")]
		 get { } //Length: 39
	}

	[Token(Token = "0x1700039F")]
	public string Realm
	{
		[Address(RVA = "0x1F74020", Offset = "0x1F73420", Length = "0x27")]
		[Token(Token = "0x6001143")]
		 get { } //Length: 39
	}

	[Address(RVA = "0x26BEAC0", Offset = "0x26BDEC0", Length = "0x148")]
	[Token(Token = "0x600114C")]
	private static DigestHeaderParser() { }

	[Address(RVA = "0x26BEC10", Offset = "0x26BE010", Length = "0xBD")]
	[Token(Token = "0x6001142")]
	public DigestHeaderParser(string header) { }

	[Address(RVA = "0x1F73FC0", Offset = "0x1F733C0", Length = "0x27")]
	[Token(Token = "0x6001146")]
	public string get_Algorithm() { }

	[Address(RVA = "0x1F73F90", Offset = "0x1F73390", Length = "0x27")]
	[Token(Token = "0x6001145")]
	public string get_Nonce() { }

	[Address(RVA = "0x1F73F30", Offset = "0x1F73330", Length = "0x27")]
	[Token(Token = "0x6001144")]
	public string get_Opaque() { }

	[Address(RVA = "0x1F73FF0", Offset = "0x1F733F0", Length = "0x27")]
	[Token(Token = "0x6001147")]
	public string get_QOP() { }

	[Address(RVA = "0x1F74020", Offset = "0x1F73420", Length = "0x27")]
	[Token(Token = "0x6001143")]
	public string get_Realm() { }

	[Address(RVA = "0x26BE530", Offset = "0x26BD930", Length = "0xD2")]
	[Token(Token = "0x600114A")]
	private string GetKey() { }

	[Address(RVA = "0x26BE610", Offset = "0x26BDA10", Length = "0x276")]
	[Token(Token = "0x600114B")]
	private bool GetKeywordAndValue(out string key, out string value) { }

	[Address(RVA = "0x26BE890", Offset = "0x26BDC90", Length = "0x1BB")]
	[Token(Token = "0x6001148")]
	public bool Parse() { }

	[Address(RVA = "0x26BEA50", Offset = "0x26BDE50", Length = "0x68")]
	[Token(Token = "0x6001149")]
	private void SkipWhitespace() { }

}

