namespace System;

[IsReadOnly]
[Token(Token = "0x2000101")]
public struct int : IComparable, IConvertible, IFormattable, IComparable<Int32>, IEquatable<Int32>, ISpanFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003F0")]
	private readonly int m_value; //Field offset: 0x0

	[Address(RVA = "0x2026FA0", Offset = "0x20263A0", Length = "0xAF")]
	[Token(Token = "0x60007DA")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x2027050", Offset = "0x2026450", Length = "0x12")]
	[Token(Token = "0x60007DB")]
	public override int CompareTo(int value) { }

	[Address(RVA = "0x2027070", Offset = "0x2026470", Length = "0x58")]
	[Token(Token = "0x60007DC")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[NonVersionable]
	[Token(Token = "0x60007DD")]
	public override bool Equals(int obj) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x60007DE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x20270D0", Offset = "0x20264D0", Length = "0x6")]
	[Token(Token = "0x60007ED")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x20272A0", Offset = "0x20266A0", Length = "0x88")]
	[Token(Token = "0x60007E8")]
	public static int Parse(ReadOnlySpan<Char> s, NumberStyles style = 7, IFormatProvider provider = null) { }

	[Address(RVA = "0x20271B0", Offset = "0x20265B0", Length = "0xEA")]
	[Token(Token = "0x60007E7")]
	public static int Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[Address(RVA = "0x2027330", Offset = "0x2026730", Length = "0xD8")]
	[Token(Token = "0x60007E6")]
	public static int Parse(string s, IFormatProvider provider) { }

	[Address(RVA = "0x2027410", Offset = "0x2026810", Length = "0xDA")]
	[Token(Token = "0x60007E5")]
	public static int Parse(string s, NumberStyles style) { }

	[Address(RVA = "0x20270E0", Offset = "0x20264E0", Length = "0xC9")]
	[Token(Token = "0x60007E4")]
	public static int Parse(string s) { }

	[Address(RVA = "0x20274F0", Offset = "0x20268F0", Length = "0x4A")]
	[Token(Token = "0x60007EE")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x2027540", Offset = "0x2026940", Length = "0x4A")]
	[Token(Token = "0x60007F1")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x2027590", Offset = "0x2026990", Length = "0x4A")]
	[Token(Token = "0x60007EF")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x20275E0", Offset = "0x20269E0", Length = "0x84")]
	[Token(Token = "0x60007FB")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x2027670", Offset = "0x2026A70", Length = "0x66")]
	[Token(Token = "0x60007FA")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x20276E0", Offset = "0x2026AE0", Length = "0x4A")]
	[Token(Token = "0x60007F9")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x2027730", Offset = "0x2026B30", Length = "0x4A")]
	[Token(Token = "0x60007F2")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x60007F4")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x2027780", Offset = "0x2026B80", Length = "0x4A")]
	[Token(Token = "0x60007F6")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x20277D0", Offset = "0x2026BD0", Length = "0x4A")]
	[Token(Token = "0x60007F0")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x2027820", Offset = "0x2026C20", Length = "0x4A")]
	[Token(Token = "0x60007F8")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x2027870", Offset = "0x2026C70", Length = "0x84")]
	[Token(Token = "0x60007FC")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x2027900", Offset = "0x2026D00", Length = "0x4A")]
	[Token(Token = "0x60007F3")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x2027950", Offset = "0x2026D50", Length = "0x4A")]
	[Token(Token = "0x60007F5")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x20279A0", Offset = "0x2026DA0", Length = "0x4A")]
	[Token(Token = "0x60007F7")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x2027BC0", Offset = "0x2026FC0", Length = "0xC6")]
	[Token(Token = "0x60007E2")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x2027A70", Offset = "0x2026E70", Length = "0x8A")]
	[Token(Token = "0x60007E1")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x2027B00", Offset = "0x2026F00", Length = "0xB9")]
	[Token(Token = "0x60007E0")]
	public string ToString(string format) { }

	[Address(RVA = "0x20279F0", Offset = "0x2026DF0", Length = "0x7E")]
	[Token(Token = "0x60007DF")]
	public virtual string ToString() { }

	[Address(RVA = "0x2027C90", Offset = "0x2027090", Length = "0xA0")]
	[Token(Token = "0x60007E3")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[Address(RVA = "0x2027DD0", Offset = "0x20271D0", Length = "0x113")]
	[Token(Token = "0x60007EA")]
	public static bool TryParse(ReadOnlySpan<Char> s, out int result) { }

	[Address(RVA = "0x2027FE0", Offset = "0x20273E0", Length = "0x169")]
	[Token(Token = "0x60007E9")]
	public static bool TryParse(string s, out int result) { }

	[Address(RVA = "0x2027D30", Offset = "0x2027130", Length = "0x9F")]
	[Token(Token = "0x60007EC")]
	public static bool TryParse(ReadOnlySpan<Char> s, NumberStyles style, IFormatProvider provider, out int result) { }

	[Address(RVA = "0x2027EF0", Offset = "0x20272F0", Length = "0xF0")]
	[Token(Token = "0x60007EB")]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out int result) { }

}

