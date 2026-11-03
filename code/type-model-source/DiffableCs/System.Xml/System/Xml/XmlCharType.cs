namespace System.Xml;

[Token(Token = "0x20000C3")]
internal struct XmlCharType
{
	[Token(Token = "0x400054D")]
	private static object s_Lock; //Field offset: 0x0
	[Token(Token = "0x400054E")]
	private static Byte[] s_CharProperties; //Field offset: 0x8
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400054F")]
	internal Byte[] charProperties; //Field offset: 0x0

	[Token(Token = "0x170002C7")]
	public static XmlCharType Instance
	{
		[Address(RVA = "0x2550E40", Offset = "0x2550240", Length = "0x79")]
		[Token(Token = "0x6000A76")]
		 get { } //Length: 121
	}

	[Token(Token = "0x170002C6")]
	private static object StaticLock
	{
		[Address(RVA = "0x2550EC0", Offset = "0x25502C0", Length = "0x92")]
		[Token(Token = "0x6000A72")]
		private get { } //Length: 146
	}

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x6000A75")]
	private XmlCharType(Byte[] charProperties) { }

	[Address(RVA = "0x2550130", Offset = "0x254F530", Length = "0x12")]
	[Token(Token = "0x6000A86")]
	internal static int CombineSurrogateChar(int lowChar, int highChar) { }

	[Address(RVA = "0x2550E40", Offset = "0x2550240", Length = "0x79")]
	[Token(Token = "0x6000A76")]
	public static XmlCharType get_Instance() { }

	[Address(RVA = "0x2550EC0", Offset = "0x25502C0", Length = "0x92")]
	[Token(Token = "0x6000A72")]
	private static object get_StaticLock() { }

	[Address(RVA = "0x2550150", Offset = "0x254F550", Length = "0x5D2")]
	[Token(Token = "0x6000A73")]
	private static void InitInstance() { }

	[Address(RVA = "0x1E9D660", Offset = "0x1E9CA60", Length = "0xC")]
	[Token(Token = "0x6000A8D")]
	private static bool InRange(int value, int start, int end) { }

	[Address(RVA = "0x2550730", Offset = "0x254FB30", Length = "0x31")]
	[Token(Token = "0x6000A7B")]
	public bool IsCharData(char ch) { }

	[Address(RVA = "0x2012600", Offset = "0x2011A00", Length = "0xD")]
	[Token(Token = "0x6000A82")]
	public static bool IsDigit(char ch) { }

	[Address(RVA = "0x2550770", Offset = "0x254FB70", Length = "0xF")]
	[Token(Token = "0x6000A83")]
	internal static bool IsHighSurrogate(int ch) { }

	[Address(RVA = "0x2550780", Offset = "0x254FB80", Length = "0x31")]
	[Token(Token = "0x6000A7E")]
	public bool IsLetter(char ch) { }

	[Address(RVA = "0x25507C0", Offset = "0x254FBC0", Length = "0xF")]
	[Token(Token = "0x6000A84")]
	internal static bool IsLowSurrogate(int ch) { }

	[Address(RVA = "0x2550850", Offset = "0x254FC50", Length = "0x3E")]
	[Token(Token = "0x6000A81")]
	public bool IsNameCharXml4e(char ch) { }

	[Address(RVA = "0x2550890", Offset = "0x254FC90", Length = "0x3E")]
	[Token(Token = "0x6000A7A")]
	public bool IsNameSingleChar(char ch) { }

	[Address(RVA = "0x25507D0", Offset = "0x254FBD0", Length = "0x31")]
	[Token(Token = "0x6000A7F")]
	public bool IsNCNameCharXml4e(char ch) { }

	[Address(RVA = "0x2550810", Offset = "0x254FC10", Length = "0x31")]
	[Token(Token = "0x6000A78")]
	public bool IsNCNameSingleChar(char ch) { }

	[Address(RVA = "0x25508D0", Offset = "0x254FCD0", Length = "0xCF")]
	[Token(Token = "0x6000A8A")]
	internal int IsOnlyCharData(string str) { }

	[Address(RVA = "0x25509A0", Offset = "0x254FDA0", Length = "0x77")]
	[Token(Token = "0x6000A8B")]
	internal static bool IsOnlyDigits(string str, int startPos, int len) { }

	[Address(RVA = "0x2550AA0", Offset = "0x254FEA0", Length = "0x80")]
	[Token(Token = "0x6000A88")]
	internal bool IsOnlyWhitespace(string str) { }

	[Address(RVA = "0x2550A20", Offset = "0x254FE20", Length = "0x7B")]
	[Token(Token = "0x6000A89")]
	internal int IsOnlyWhitespaceWithPos(string str) { }

	[Address(RVA = "0x2550B30", Offset = "0x254FF30", Length = "0x70")]
	[Token(Token = "0x6000A7C")]
	public bool IsPubidChar(char ch) { }

	[Address(RVA = "0x2550BB0", Offset = "0x254FFB0", Length = "0x6F")]
	[Token(Token = "0x6000A8C")]
	internal int IsPublicId(string str) { }

	[Address(RVA = "0x2550C20", Offset = "0x2550020", Length = "0x3E")]
	[Token(Token = "0x6000A80")]
	public bool IsStartNCNameCharXml4e(char ch) { }

	[Address(RVA = "0x2550C60", Offset = "0x2550060", Length = "0x31")]
	[Token(Token = "0x6000A79")]
	public bool IsStartNCNameSingleChar(char ch) { }

	[Address(RVA = "0x2550CA0", Offset = "0x25500A0", Length = "0xF")]
	[Token(Token = "0x6000A85")]
	internal static bool IsSurrogate(int ch) { }

	[Address(RVA = "0x2550CB0", Offset = "0x25500B0", Length = "0x31")]
	[Token(Token = "0x6000A7D")]
	internal bool IsTextChar(char ch) { }

	[Address(RVA = "0x2550CF0", Offset = "0x25500F0", Length = "0x30")]
	[Token(Token = "0x6000A77")]
	public bool IsWhiteSpace(char ch) { }

	[Address(RVA = "0x2550D30", Offset = "0x2550130", Length = "0xC1")]
	[Token(Token = "0x6000A74")]
	private static void SetProperties(Byte[] chProps, string ranges, byte value) { }

	[Address(RVA = "0x2550E00", Offset = "0x2550200", Length = "0x37")]
	[Token(Token = "0x6000A87")]
	internal static void SplitSurrogateChar(int combinedChar, out char lowChar, out char highChar) { }

}

