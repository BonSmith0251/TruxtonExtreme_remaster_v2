namespace System;

[IsReadOnly]
[Token(Token = "0x20000C3")]
public struct char : IComparable, IComparable<Char>, IEquatable<Char>, IConvertible
{
	[Token(Token = "0x40002A9")]
	private static readonly Byte[] s_categoryForLatin1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002A8")]
	private readonly char m_value; //Field offset: 0x0

	[Address(RVA = "0x1F920B0", Offset = "0x1F914B0", Length = "0x80")]
	[Token(Token = "0x60004C5")]
	private static Char() { }

	[Address(RVA = "0x1F90240", Offset = "0x1F8F640", Length = "0x7")]
	[Token(Token = "0x6000493")]
	internal static bool CheckLetter(UnicodeCategory uc) { }

	[Address(RVA = "0x1F90230", Offset = "0x1F8F630", Length = "0xF")]
	[Token(Token = "0x600049B")]
	internal static bool CheckLetterOrDigit(UnicodeCategory uc) { }

	[Address(RVA = "0x1F90250", Offset = "0x1F8F650", Length = "0xA")]
	[Token(Token = "0x60004B4")]
	internal static bool CheckNumber(UnicodeCategory uc) { }

	[Address(RVA = "0x1F90260", Offset = "0x1F8F660", Length = "0xA")]
	[Token(Token = "0x6000499")]
	internal static bool CheckPunctuation(UnicodeCategory uc) { }

	[Address(RVA = "0x1F90270", Offset = "0x1F8F670", Length = "0xA")]
	[Token(Token = "0x60004B7")]
	internal static bool CheckSeparator(UnicodeCategory uc) { }

	[Address(RVA = "0x1F90290", Offset = "0x1F8F690", Length = "0xAA")]
	[Token(Token = "0x600048B")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x1F90280", Offset = "0x1F8F680", Length = "0x9")]
	[Token(Token = "0x600048C")]
	public override int CompareTo(char value) { }

	[Address(RVA = "0x1F90340", Offset = "0x1F8F740", Length = "0x10F")]
	[Token(Token = "0x60004C3")]
	public static string ConvertFromUtf32(int utf32) { }

	[Address(RVA = "0x1F90450", Offset = "0x1F8F850", Length = "0x12D")]
	[Token(Token = "0x60004C4")]
	public static int ConvertToUtf32(char highSurrogate, char lowSurrogate) { }

	[Address(RVA = "0x1F90580", Offset = "0x1F8F980", Length = "0x5A")]
	[Token(Token = "0x6000489")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x60A240", Offset = "0x609640", Length = "0x7")]
	[NonVersionable]
	[Token(Token = "0x600048A")]
	public override bool Equals(char obj) { }

	[Address(RVA = "0x1F905E0", Offset = "0x1F8F9E0", Length = "0xC")]
	[Token(Token = "0x6000488")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1F905F0", Offset = "0x1F8F9F0", Length = "0x52")]
	[Token(Token = "0x6000487")]
	private static UnicodeCategory GetLatin1UnicodeCategory(char ch) { }

	[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
	[Token(Token = "0x60004A3")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x1F90650", Offset = "0x1F8FA50", Length = "0x9A")]
	[Token(Token = "0x60004BD")]
	public static UnicodeCategory GetUnicodeCategory(char c) { }

	[Address(RVA = "0x1F906F0", Offset = "0x1F8FAF0", Length = "0x131")]
	[Token(Token = "0x60004BE")]
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	[Address(RVA = "0x1F90830", Offset = "0x1F8FC30", Length = "0x8")]
	[Token(Token = "0x6000486")]
	private static bool IsAscii(char ch) { }

	[Address(RVA = "0x1F90840", Offset = "0x1F8FC40", Length = "0xA5")]
	[Token(Token = "0x60004B3")]
	public static bool IsControl(char c) { }

	[Address(RVA = "0x1F908F0", Offset = "0x1F8FCF0", Length = "0x59")]
	[Token(Token = "0x6000492")]
	public static bool IsDigit(char c) { }

	[Address(RVA = "0x1F90950", Offset = "0x1F8FD50", Length = "0xF0")]
	[Token(Token = "0x60004C0")]
	public static bool IsHighSurrogate(string s, int index) { }

	[Address(RVA = "0x1F90A50", Offset = "0x1F8FE50", Length = "0x19")]
	[Token(Token = "0x60004BF")]
	public static bool IsHighSurrogate(char c) { }

	[Address(RVA = "0x1F90A70", Offset = "0x1F8FE70", Length = "0xC")]
	[Token(Token = "0x6000485")]
	private static bool IsLatin1(char ch) { }

	[Address(RVA = "0x1F90B50", Offset = "0x1F8FF50", Length = "0xF8")]
	[Token(Token = "0x6000494")]
	public static bool IsLetter(char c) { }

	[Address(RVA = "0x1F90A80", Offset = "0x1F8FE80", Length = "0xCB")]
	[Token(Token = "0x600049C")]
	public static bool IsLetterOrDigit(char c) { }

	[Address(RVA = "0x1F90C70", Offset = "0x1F90070", Length = "0xDB")]
	[Token(Token = "0x6000498")]
	public static bool IsLower(char c) { }

	[Address(RVA = "0x1F90C50", Offset = "0x1F90050", Length = "0x19")]
	[Token(Token = "0x60004C1")]
	public static bool IsLowSurrogate(char c) { }

	[Address(RVA = "0x1F90D50", Offset = "0x1F90150", Length = "0xFB")]
	[Token(Token = "0x60004B5")]
	public static bool IsNumber(char c) { }

	[Address(RVA = "0x1F90E50", Offset = "0x1F90250", Length = "0x18C")]
	[Token(Token = "0x60004B6")]
	public static bool IsNumber(string s, int index) { }

	[Address(RVA = "0x1F90FE0", Offset = "0x1F903E0", Length = "0xC5")]
	[Token(Token = "0x600049A")]
	public static bool IsPunctuation(char c) { }

	[Address(RVA = "0x1F910D0", Offset = "0x1F904D0", Length = "0x8C")]
	[Token(Token = "0x60004B9")]
	public static bool IsSeparator(char c) { }

	[Address(RVA = "0x1F910B0", Offset = "0x1F904B0", Length = "0x15")]
	[Token(Token = "0x60004B8")]
	private static bool IsSeparatorLatin1(char c) { }

	[Address(RVA = "0x1F91190", Offset = "0x1F90590", Length = "0xE8")]
	[Token(Token = "0x60004BB")]
	public static bool IsSurrogate(string s, int index) { }

	[Address(RVA = "0x1F91280", Offset = "0x1F90680", Length = "0x19")]
	[Token(Token = "0x60004BA")]
	public static bool IsSurrogate(char c) { }

	[Address(RVA = "0x1F91160", Offset = "0x1F90560", Length = "0x2B")]
	[Token(Token = "0x60004C2")]
	public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate) { }

	[Address(RVA = "0x1F912A0", Offset = "0x1F906A0", Length = "0xDA")]
	[Token(Token = "0x6000497")]
	public static bool IsUpper(char c) { }

	[Address(RVA = "0x1F913B0", Offset = "0x1F907B0", Length = "0x7C")]
	[Token(Token = "0x6000496")]
	public static bool IsWhiteSpace(char c) { }

	[Address(RVA = "0x1F91430", Offset = "0x1F90830", Length = "0x157")]
	[Token(Token = "0x60004BC")]
	public static bool IsWhiteSpace(string s, int index) { }

	[Address(RVA = "0x1F91380", Offset = "0x1F90780", Length = "0x2A")]
	[Token(Token = "0x6000495")]
	private static bool IsWhiteSpaceLatin1(char c) { }

	[Address(RVA = "0x1F91590", Offset = "0x1F90990", Length = "0xB1")]
	[Token(Token = "0x6000490")]
	public static char Parse(string s) { }

	[Address(RVA = "0x1F91650", Offset = "0x1F90A50", Length = "0x84")]
	[Token(Token = "0x60004A4")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x1F916E0", Offset = "0x1F90AE0", Length = "0x7F")]
	[Token(Token = "0x60004A7")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
	[Token(Token = "0x60004A5")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x1F91760", Offset = "0x1F90B60", Length = "0x84")]
	[Token(Token = "0x60004B1")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x1F917F0", Offset = "0x1F90BF0", Length = "0x84")]
	[Token(Token = "0x60004B0")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x1F91880", Offset = "0x1F90C80", Length = "0x84")]
	[Token(Token = "0x60004AF")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x1F91910", Offset = "0x1F90D10", Length = "0x7F")]
	[Token(Token = "0x60004A8")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x1F91990", Offset = "0x1F90D90", Length = "0x45")]
	[Token(Token = "0x60004AA")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x1F919E0", Offset = "0x1F90DE0", Length = "0x46")]
	[Token(Token = "0x60004AC")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x1F91A30", Offset = "0x1F90E30", Length = "0x7B")]
	[Token(Token = "0x60004A6")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x1F91AB0", Offset = "0x1F90EB0", Length = "0x84")]
	[Token(Token = "0x60004AE")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x1F91B40", Offset = "0x1F90F40", Length = "0x86")]
	[Token(Token = "0x60004B2")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x1F91BD0", Offset = "0x1F90FD0", Length = "0x46")]
	[Token(Token = "0x60004A9")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x1F91C20", Offset = "0x1F91020", Length = "0x45")]
	[Token(Token = "0x60004AB")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x1F91C70", Offset = "0x1F91070", Length = "0x46")]
	[Token(Token = "0x60004AD")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x1F91DF0", Offset = "0x1F911F0", Length = "0x86")]
	[Token(Token = "0x60004A1")]
	public static char ToLower(char c) { }

	[Address(RVA = "0x1F91D50", Offset = "0x1F91150", Length = "0x99")]
	[Token(Token = "0x60004A0")]
	public static char ToLower(char c, CultureInfo culture) { }

	[Address(RVA = "0x1F91CC0", Offset = "0x1F910C0", Length = "0x86")]
	[Token(Token = "0x60004A2")]
	public static char ToLowerInvariant(char c) { }

	[Address(RVA = "0x1F91EB0", Offset = "0x1F912B0", Length = "0x7")]
	[Token(Token = "0x600048F")]
	public static string ToString(char c) { }

	[Address(RVA = "0x1F91E80", Offset = "0x1F91280", Length = "0x2D")]
	[Token(Token = "0x600048E")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x1F91E80", Offset = "0x1F91280", Length = "0x2D")]
	[Token(Token = "0x600048D")]
	public virtual string ToString() { }

	[Address(RVA = "0x1F91F50", Offset = "0x1F91350", Length = "0x86")]
	[Token(Token = "0x600049E")]
	public static char ToUpper(char c) { }

	[Address(RVA = "0x1F91FE0", Offset = "0x1F913E0", Length = "0x99")]
	[Token(Token = "0x600049D")]
	public static char ToUpper(char c, CultureInfo culture) { }

	[Address(RVA = "0x1F91EC0", Offset = "0x1F912C0", Length = "0x86")]
	[Token(Token = "0x600049F")]
	public static char ToUpperInvariant(char c) { }

	[Address(RVA = "0x1F92080", Offset = "0x1F91480", Length = "0x2E")]
	[Token(Token = "0x6000491")]
	public static bool TryParse(string s, out char result) { }

}

