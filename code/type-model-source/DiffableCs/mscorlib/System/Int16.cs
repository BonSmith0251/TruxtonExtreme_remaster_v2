namespace System;

[IsReadOnly]
[Token(Token = "0x2000100")]
public struct short : IComparable, IConvertible, IFormattable, IComparable<Int16>, IEquatable<Int16>, ISpanFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003EF")]
	private readonly short m_value; //Field offset: 0x0

	[Address(RVA = "0x2025F80", Offset = "0x2025380", Length = "0xAA")]
	[Token(Token = "0x60007BB")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x2026030", Offset = "0x2025430", Length = "0x9")]
	[Token(Token = "0x60007BC")]
	public override int CompareTo(short value) { }

	[Address(RVA = "0x2026040", Offset = "0x2025440", Length = "0x5A")]
	[Token(Token = "0x60007BD")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x60A240", Offset = "0x609640", Length = "0x7")]
	[NonVersionable]
	[Token(Token = "0x60007BE")]
	public override bool Equals(short obj) { }

	[Address(RVA = "0x20260A0", Offset = "0x20254A0", Length = "0xC")]
	[Token(Token = "0x60007BF")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x9E1910", Offset = "0x9E0D10", Length = "0x6")]
	[Token(Token = "0x60007CA")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x20260B0", Offset = "0x20254B0", Length = "0xA4")]
	[Token(Token = "0x60007C4")]
	public static short Parse(string s, IFormatProvider provider) { }

	[Address(RVA = "0x2026160", Offset = "0x2025560", Length = "0xB6")]
	[Token(Token = "0x60007C5")]
	public static short Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[Address(RVA = "0x2026220", Offset = "0x2025620", Length = "0x189")]
	[Token(Token = "0x60007C6")]
	private static short Parse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info) { }

	[Address(RVA = "0x20263B0", Offset = "0x20257B0", Length = "0x4C")]
	[Token(Token = "0x60007CB")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x2026400", Offset = "0x2025800", Length = "0x4C")]
	[Token(Token = "0x60007CE")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x2026450", Offset = "0x2025850", Length = "0x4C")]
	[Token(Token = "0x60007CC")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x20264A0", Offset = "0x20258A0", Length = "0x84")]
	[Token(Token = "0x60007D8")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x2026530", Offset = "0x2025930", Length = "0x68")]
	[Token(Token = "0x60007D7")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x20265A0", Offset = "0x20259A0", Length = "0x4C")]
	[Token(Token = "0x60007D6")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
	[Token(Token = "0x60007CF")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x20265F0", Offset = "0x20259F0", Length = "0x4C")]
	[Token(Token = "0x60007D1")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x2026640", Offset = "0x2025A40", Length = "0x4C")]
	[Token(Token = "0x60007D3")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x2026690", Offset = "0x2025A90", Length = "0x4C")]
	[Token(Token = "0x60007CD")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x20266E0", Offset = "0x2025AE0", Length = "0x4C")]
	[Token(Token = "0x60007D5")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x2026730", Offset = "0x2025B30", Length = "0x86")]
	[Token(Token = "0x60007D9")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x20267C0", Offset = "0x2025BC0", Length = "0x4C")]
	[Token(Token = "0x60007D0")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x2026810", Offset = "0x2025C10", Length = "0x4C")]
	[Token(Token = "0x60007D2")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x2026860", Offset = "0x2025C60", Length = "0x4C")]
	[Token(Token = "0x60007D4")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x20268B0", Offset = "0x2025CB0", Length = "0x18E")]
	[Token(Token = "0x60007C2")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x2026AD0", Offset = "0x2025ED0", Length = "0x7F")]
	[Token(Token = "0x60007C0")]
	public virtual string ToString() { }

	[Address(RVA = "0x2026A40", Offset = "0x2025E40", Length = "0x8B")]
	[Token(Token = "0x60007C1")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x2026B50", Offset = "0x2025F50", Length = "0x126")]
	[Token(Token = "0x60007C3")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[Address(RVA = "0x2026C80", Offset = "0x2026080", Length = "0xC5")]
	[Token(Token = "0x60007C9")]
	private static bool TryParse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info, out short result) { }

	[Address(RVA = "0x2026EE0", Offset = "0x20262E0", Length = "0xBB")]
	[Token(Token = "0x60007C8")]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out short result) { }

	[Address(RVA = "0x2026D50", Offset = "0x2026150", Length = "0x185")]
	[Token(Token = "0x60007C7")]
	public static bool TryParse(string s, out short result) { }

}

