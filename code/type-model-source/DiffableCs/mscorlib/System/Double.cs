namespace System;

[IsReadOnly]
[Token(Token = "0x20000CE")]
public struct double : IComparable, IConvertible, IFormattable, IComparable<Double>, IEquatable<Double>, ISpanFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002F6")]
	private readonly double m_value; //Field offset: 0x0

	[Address(RVA = "0x201FD80", Offset = "0x201F180", Length = "0xF7")]
	[Token(Token = "0x6000678")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x201FE80", Offset = "0x201F280", Length = "0x53")]
	[Token(Token = "0x6000679")]
	public override int CompareTo(double value) { }

	[Address(RVA = "0x201FEE0", Offset = "0x201F2E0", Length = "0x8F")]
	[Token(Token = "0x600067A")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x201FF70", Offset = "0x201F370", Length = "0x3C")]
	[Token(Token = "0x600067B")]
	public override bool Equals(double obj) { }

	[Address(RVA = "0x201FFB0", Offset = "0x201F3B0", Length = "0x30")]
	[Token(Token = "0x600067C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x9DCDA0", Offset = "0x9DC1A0", Length = "0x6")]
	[Token(Token = "0x6000688")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x201FFE0", Offset = "0x201F3E0", Length = "0x23")]
	[NonVersionable]
	[Token(Token = "0x6000672")]
	public static bool IsFinite(double d) { }

	[Address(RVA = "0x2020010", Offset = "0x201F410", Length = "0x23")]
	[NonVersionable]
	[Token(Token = "0x6000673")]
	public static bool IsInfinity(double d) { }

	[Address(RVA = "0x2020040", Offset = "0x201F440", Length = "0x23")]
	[NonVersionable]
	[Token(Token = "0x6000674")]
	public static bool IsNaN(double d) { }

	[Address(RVA = "0x2020090", Offset = "0x201F490", Length = "0xE")]
	[NonVersionable]
	[Token(Token = "0x6000675")]
	public static bool IsNegative(double d) { }

	[Address(RVA = "0x2020070", Offset = "0x201F470", Length = "0x12")]
	[NonVersionable]
	[Token(Token = "0x6000676")]
	public static bool IsNegativeInfinity(double d) { }

	[Address(RVA = "0x20200A0", Offset = "0x201F4A0", Length = "0x12")]
	[NonVersionable]
	[Token(Token = "0x6000677")]
	public static bool IsPositiveInfinity(double d) { }

	[Address(RVA = "0x20200C0", Offset = "0x201F4C0", Length = "0xD8")]
	[Token(Token = "0x6000683")]
	public static double Parse(string s, IFormatProvider provider) { }

	[Address(RVA = "0x2020290", Offset = "0x201F690", Length = "0xC9")]
	[Token(Token = "0x6000682")]
	public static double Parse(string s) { }

	[Address(RVA = "0x20201A0", Offset = "0x201F5A0", Length = "0xEA")]
	[Token(Token = "0x6000684")]
	public static double Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[Address(RVA = "0x2020360", Offset = "0x201F760", Length = "0x57")]
	[Token(Token = "0x6000689")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x20203C0", Offset = "0x201F7C0", Length = "0x57")]
	[Token(Token = "0x600068C")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x2020420", Offset = "0x201F820", Length = "0x84")]
	[Token(Token = "0x600068A")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x20204B0", Offset = "0x201F8B0", Length = "0x84")]
	[Token(Token = "0x6000696")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x2020540", Offset = "0x201F940", Length = "0x73")]
	[Token(Token = "0x6000695")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x20205C0", Offset = "0x201F9C0", Length = "0x5")]
	[Token(Token = "0x6000694")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x20205D0", Offset = "0x201F9D0", Length = "0x57")]
	[Token(Token = "0x600068D")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x2020630", Offset = "0x201FA30", Length = "0x57")]
	[Token(Token = "0x600068F")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x2020690", Offset = "0x201FA90", Length = "0x57")]
	[Token(Token = "0x6000691")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x20206F0", Offset = "0x201FAF0", Length = "0x57")]
	[Token(Token = "0x600068B")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x2020750", Offset = "0x201FB50", Length = "0x57")]
	[Token(Token = "0x6000693")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x20207B0", Offset = "0x201FBB0", Length = "0x88")]
	[Token(Token = "0x6000697")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x2020840", Offset = "0x201FC40", Length = "0x57")]
	[Token(Token = "0x600068E")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x20208A0", Offset = "0x201FCA0", Length = "0x57")]
	[Token(Token = "0x6000690")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x2020900", Offset = "0x201FD00", Length = "0x57")]
	[Token(Token = "0x6000692")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x2020A60", Offset = "0x201FE60", Length = "0x67")]
	[Token(Token = "0x600067D")]
	public virtual string ToString() { }

	[Address(RVA = "0x20209E0", Offset = "0x201FDE0", Length = "0x74")]
	[Token(Token = "0x600067E")]
	public string ToString(string format) { }

	[Address(RVA = "0x2020960", Offset = "0x201FD60", Length = "0x76")]
	[Token(Token = "0x600067F")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x2020AD0", Offset = "0x201FED0", Length = "0x84")]
	[Token(Token = "0x6000680")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x2020B60", Offset = "0x201FF60", Length = "0xBD")]
	[Token(Token = "0x6000681")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[Address(RVA = "0x2020D80", Offset = "0x2020180", Length = "0x237")]
	[Token(Token = "0x6000687")]
	private static bool TryParse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info, out double result) { }

	[Address(RVA = "0x2020C20", Offset = "0x2020020", Length = "0xB9")]
	[Token(Token = "0x6000686")]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out double result) { }

	[Address(RVA = "0x2020CE0", Offset = "0x20200E0", Length = "0x9E")]
	[Token(Token = "0x6000685")]
	public static bool TryParse(string s, out double result) { }

}

