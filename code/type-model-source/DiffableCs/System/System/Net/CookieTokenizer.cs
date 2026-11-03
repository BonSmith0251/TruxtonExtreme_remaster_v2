namespace System.Net;

[Token(Token = "0x2000275")]
internal class CookieTokenizer
{
	[Token(Token = "0x2000276")]
	private struct RecognizedAttribute
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A21")]
		private string m_name; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000A22")]
		private CookieToken m_token; //Field offset: 0x8

		[Token(Token = "0x1700037E")]
		internal CookieToken Token
		{
			[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
			[Token(Token = "0x6001093")]
			internal get { } //Length: 4
		}

		[Address(RVA = "0xAEE5F0", Offset = "0xAED9F0", Length = "0x26")]
		[Token(Token = "0x6001092")]
		internal RecognizedAttribute(string name, CookieToken token) { }

		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x6001093")]
		internal CookieToken get_Token() { }

		[Address(RVA = "0x26CD220", Offset = "0x26CC620", Length = "0x1F")]
		[Token(Token = "0x6001094")]
		internal bool IsEqualTo(string value) { }

	}

	[Token(Token = "0x4000A1F")]
	private static RecognizedAttribute[] RecognizedAttributes; //Field offset: 0x0
	[Token(Token = "0x4000A20")]
	private static RecognizedAttribute[] RecognizedServerAttributes; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A15")]
	private bool m_eofCookie; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000A16")]
	private int m_index; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A17")]
	private int m_length; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A18")]
	private string m_name; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A19")]
	private bool m_quoted; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000A1A")]
	private int m_start; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A1B")]
	private CookieToken m_token; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000A1C")]
	private int m_tokenLength; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A1D")]
	private string m_tokenStream; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A1E")]
	private string m_value; //Field offset: 0x40

	[Token(Token = "0x17000378")]
	internal bool EndOfCookie
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x6001081")]
		internal get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[Token(Token = "0x6001082")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000379")]
	internal bool Eof
	{
		[Address(RVA = "0x26BAA50", Offset = "0x26B9E50", Length = "0xA")]
		[Token(Token = "0x6001083")]
		internal get { } //Length: 10
	}

	[Token(Token = "0x1700037A")]
	internal string Name
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6001084")]
		internal get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6001085")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700037B")]
	internal bool Quoted
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x6001086")]
		internal get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[Token(Token = "0x6001087")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700037C")]
	internal CookieToken Token
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x6001088")]
		internal get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[Token(Token = "0x6001089")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700037D")]
	internal string Value
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x600108A")]
		internal get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[Token(Token = "0x600108B")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x26BA450", Offset = "0x26B9850", Length = "0x5A8")]
	[Token(Token = "0x6001091")]
	private static CookieTokenizer() { }

	[Address(RVA = "0x26BAA00", Offset = "0x26B9E00", Length = "0x41")]
	[Token(Token = "0x6001080")]
	internal CookieTokenizer(string tokenStream) { }

	[Address(RVA = "0x26B9CE0", Offset = "0x26B90E0", Length = "0x5D")]
	[Token(Token = "0x600108C")]
	internal string Extract() { }

	[Address(RVA = "0x26B9D40", Offset = "0x26B9140", Length = "0x249")]
	[Token(Token = "0x600108D")]
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x6001081")]
	internal bool get_EndOfCookie() { }

	[Address(RVA = "0x26BAA50", Offset = "0x26B9E50", Length = "0xA")]
	[Token(Token = "0x6001083")]
	internal bool get_Eof() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6001084")]
	internal string get_Name() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x6001086")]
	internal bool get_Quoted() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x6001088")]
	internal CookieToken get_Token() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x600108A")]
	internal string get_Value() { }

	[Address(RVA = "0x26B9F90", Offset = "0x26B9390", Length = "0x256")]
	[Token(Token = "0x600108E")]
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	[Address(RVA = "0x26BA1F0", Offset = "0x26B95F0", Length = "0x5E")]
	[Token(Token = "0x600108F")]
	internal void Reset() { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[Token(Token = "0x6001082")]
	internal void set_EndOfCookie(bool value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6001085")]
	internal void set_Name(string value) { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[Token(Token = "0x6001087")]
	internal void set_Quoted(bool value) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[Token(Token = "0x6001089")]
	internal void set_Token(CookieToken value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x600108B")]
	internal void set_Value(string value) { }

	[Address(RVA = "0x26BA250", Offset = "0x26B9650", Length = "0x1FE")]
	[Token(Token = "0x6001090")]
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

}

