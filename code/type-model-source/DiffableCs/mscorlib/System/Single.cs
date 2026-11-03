namespace System;

[IsReadOnly]
[Token(Token = "0x200012F")]
public struct float : IComparable, IConvertible, IFormattable, IComparable<Single>, IEquatable<Single>, ISpanFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400043B")]
	private readonly float m_value; //Field offset: 0x0

	[Address(RVA = "0x20480F0", Offset = "0x20474F0", Length = "0xE0")]
	[Token(Token = "0x60009CA")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x20480B0", Offset = "0x20474B0", Length = "0x40")]
	[Token(Token = "0x60009CB")]
	public override int CompareTo(float value) { }

	[Address(RVA = "0x2048210", Offset = "0x2047610", Length = "0x7E")]
	[Token(Token = "0x60009CC")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x20481E0", Offset = "0x20475E0", Length = "0x2B")]
	[Token(Token = "0x60009CD")]
	public override bool Equals(float obj) { }

	[Address(RVA = "0x2048290", Offset = "0x2047690", Length = "0x17")]
	[Token(Token = "0x60009CE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x20482B0", Offset = "0x20476B0", Length = "0x6")]
	[Token(Token = "0x60009DA")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x20482C0", Offset = "0x20476C0", Length = "0x11")]
	[NonVersionable]
	[Token(Token = "0x60009C4")]
	public static bool IsFinite(float f) { }

	[Address(RVA = "0x20482E0", Offset = "0x20476E0", Length = "0x11")]
	[NonVersionable]
	[Token(Token = "0x60009C5")]
	public static bool IsInfinity(float f) { }

	[Address(RVA = "0x2048300", Offset = "0x2047700", Length = "0x11")]
	[NonVersionable]
	[Token(Token = "0x60009C6")]
	public static bool IsNaN(float f) { }

	[Address(RVA = "0x2048340", Offset = "0x2047740", Length = "0xD")]
	[NonVersionable]
	[Token(Token = "0x60009C7")]
	public static bool IsNegative(float f) { }

	[Address(RVA = "0x2048320", Offset = "0x2047720", Length = "0x11")]
	[NonVersionable]
	[Token(Token = "0x60009C8")]
	public static bool IsNegativeInfinity(float f) { }

	[Address(RVA = "0x2048350", Offset = "0x2047750", Length = "0x11")]
	[NonVersionable]
	[Token(Token = "0x60009C9")]
	public static bool IsPositiveInfinity(float f) { }

	[Address(RVA = "0x2048370", Offset = "0x2047770", Length = "0xDA")]
	[Token(Token = "0x60009D5")]
	public static float Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[Address(RVA = "0x2048450", Offset = "0x2047850", Length = "0xC8")]
	[Token(Token = "0x60009D4")]
	public static float Parse(string s, IFormatProvider provider) { }

	[Address(RVA = "0x2048520", Offset = "0x2047920", Length = "0x57")]
	[Token(Token = "0x60009DB")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x2048580", Offset = "0x2047980", Length = "0x57")]
	[Token(Token = "0x60009DE")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x20485E0", Offset = "0x20479E0", Length = "0x84")]
	[Token(Token = "0x60009DC")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x2048670", Offset = "0x2047A70", Length = "0x84")]
	[Token(Token = "0x60009E8")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x2048700", Offset = "0x2047B00", Length = "0x73")]
	[Token(Token = "0x60009E7")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x2048780", Offset = "0x2047B80", Length = "0x57")]
	[Token(Token = "0x60009E6")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x20487E0", Offset = "0x2047BE0", Length = "0x57")]
	[Token(Token = "0x60009DF")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x2048840", Offset = "0x2047C40", Length = "0x57")]
	[Token(Token = "0x60009E1")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x20488A0", Offset = "0x2047CA0", Length = "0x57")]
	[Token(Token = "0x60009E3")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x2048900", Offset = "0x2047D00", Length = "0x57")]
	[Token(Token = "0x60009DD")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
	[Token(Token = "0x60009E5")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x2048960", Offset = "0x2047D60", Length = "0x88")]
	[Token(Token = "0x60009E9")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x20489F0", Offset = "0x2047DF0", Length = "0x57")]
	[Token(Token = "0x60009E0")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x2048A50", Offset = "0x2047E50", Length = "0x57")]
	[Token(Token = "0x60009E2")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x2048AB0", Offset = "0x2047EB0", Length = "0x57")]
	[Token(Token = "0x60009E4")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x2048C80", Offset = "0x2048080", Length = "0x84")]
	[Token(Token = "0x60009D2")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x2048B10", Offset = "0x2047F10", Length = "0x74")]
	[Token(Token = "0x60009D1")]
	public string ToString(string format) { }

	[Address(RVA = "0x2048B90", Offset = "0x2047F90", Length = "0x76")]
	[Token(Token = "0x60009D0")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x2048C10", Offset = "0x2048010", Length = "0x67")]
	[Token(Token = "0x60009CF")]
	public virtual string ToString() { }

	[Address(RVA = "0x2048D10", Offset = "0x2048110", Length = "0xBD")]
	[Token(Token = "0x60009D3")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[Address(RVA = "0x2049000", Offset = "0x2048400", Length = "0x6A")]
	[Token(Token = "0x60009D8")]
	public static bool TryParse(ReadOnlySpan<Char> s, NumberStyles style, IFormatProvider provider, out float result) { }

	[Address(RVA = "0x2049110", Offset = "0x2048510", Length = "0xB8")]
	[Token(Token = "0x60009D7")]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result) { }

	[Address(RVA = "0x2048DD0", Offset = "0x20481D0", Length = "0x228")]
	[Token(Token = "0x60009D9")]
	private static bool TryParse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info, out float result) { }

	[Address(RVA = "0x2049070", Offset = "0x2048470", Length = "0x9D")]
	[Token(Token = "0x60009D6")]
	public static bool TryParse(string s, out float result) { }

}

