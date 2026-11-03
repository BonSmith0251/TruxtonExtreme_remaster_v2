namespace System;

[CLSCompliant(False)]
[IsReadOnly]
[Token(Token = "0x200014B")]
public struct uint : IComparable, IConvertible, IFormattable, IComparable<UInt32>, IEquatable<UInt32>, ISpanFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000479")]
	private readonly uint m_value; //Field offset: 0x0

	[Address(RVA = "0x2054CA0", Offset = "0x20540A0", Length = "0xAF")]
	[Token(Token = "0x6000B67")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x2054D50", Offset = "0x2054150", Length = "0x12")]
	[Token(Token = "0x6000B68")]
	public override int CompareTo(uint value) { }

	[Address(RVA = "0x2054D70", Offset = "0x2054170", Length = "0x58")]
	[Token(Token = "0x6000B69")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[NonVersionable]
	[Token(Token = "0x6000B6A")]
	public override bool Equals(uint obj) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6000B6B")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1D6CB40", Offset = "0x1D6BF40", Length = "0x6")]
	[Token(Token = "0x6000B76")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x2054DD0", Offset = "0x20541D0", Length = "0xB5")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000B71")]
	public static uint Parse(string s) { }

	[Address(RVA = "0x2054E90", Offset = "0x2054290", Length = "0xC8")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000B72")]
	public static uint Parse(string s, IFormatProvider provider) { }

	[Address(RVA = "0x2054F60", Offset = "0x2054360", Length = "0xDA")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000B73")]
	public static uint Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[Address(RVA = "0x2055040", Offset = "0x2054440", Length = "0x4A")]
	[Token(Token = "0x6000B77")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x2055090", Offset = "0x2054490", Length = "0x4A")]
	[Token(Token = "0x6000B7A")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x20550E0", Offset = "0x20544E0", Length = "0x4A")]
	[Token(Token = "0x6000B78")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x2055130", Offset = "0x2054530", Length = "0x84")]
	[Token(Token = "0x6000B84")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x20551C0", Offset = "0x20545C0", Length = "0x66")]
	[Token(Token = "0x6000B83")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x2055230", Offset = "0x2054630", Length = "0x4A")]
	[Token(Token = "0x6000B82")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x2055280", Offset = "0x2054680", Length = "0x4A")]
	[Token(Token = "0x6000B7B")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x20552D0", Offset = "0x20546D0", Length = "0x4A")]
	[Token(Token = "0x6000B7D")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x2055320", Offset = "0x2054720", Length = "0x4A")]
	[Token(Token = "0x6000B7F")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x2055370", Offset = "0x2054770", Length = "0x4A")]
	[Token(Token = "0x6000B79")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x20553C0", Offset = "0x20547C0", Length = "0x4A")]
	[Token(Token = "0x6000B81")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x2055410", Offset = "0x2054810", Length = "0x84")]
	[Token(Token = "0x6000B85")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x20554A0", Offset = "0x20548A0", Length = "0x4A")]
	[Token(Token = "0x6000B7C")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6000B7E")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x20554F0", Offset = "0x20548F0", Length = "0x4A")]
	[Token(Token = "0x6000B80")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x2055540", Offset = "0x2054940", Length = "0xC6")]
	[Token(Token = "0x6000B6F")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x20556A0", Offset = "0x2054AA0", Length = "0xB9")]
	[Token(Token = "0x6000B6E")]
	public string ToString(string format) { }

	[Address(RVA = "0x2055760", Offset = "0x2054B60", Length = "0x7E")]
	[Token(Token = "0x6000B6C")]
	public virtual string ToString() { }

	[Address(RVA = "0x2055610", Offset = "0x2054A10", Length = "0x8A")]
	[Token(Token = "0x6000B6D")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x20557E0", Offset = "0x2054BE0", Length = "0xA0")]
	[Token(Token = "0x6000B70")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[Address(RVA = "0x2055880", Offset = "0x2054C80", Length = "0xF0")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000B75")]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out uint result) { }

	[Address(RVA = "0x2055970", Offset = "0x2054D70", Length = "0xD5")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000B74")]
	public static bool TryParse(string s, out uint result) { }

}

