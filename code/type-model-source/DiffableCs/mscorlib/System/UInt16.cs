namespace System;

[CLSCompliant(False)]
[IsReadOnly]
[Token(Token = "0x200014A")]
public struct ushort : IComparable, IConvertible, IFormattable, IComparable<UInt16>, IEquatable<UInt16>, ISpanFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000478")]
	private readonly ushort m_value; //Field offset: 0x0

	[Address(RVA = "0x2053ED0", Offset = "0x20532D0", Length = "0xAA")]
	[Token(Token = "0x6000B48")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x1F90280", Offset = "0x1F8F680", Length = "0x9")]
	[Token(Token = "0x6000B49")]
	public override int CompareTo(ushort value) { }

	[Address(RVA = "0x2053F80", Offset = "0x2053380", Length = "0x5A")]
	[Token(Token = "0x6000B4A")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x60A240", Offset = "0x609640", Length = "0x7")]
	[NonVersionable]
	[Token(Token = "0x6000B4B")]
	public override bool Equals(ushort obj) { }

	[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
	[Token(Token = "0x6000B4C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x9DCBA0", Offset = "0x9DBFA0", Length = "0x6")]
	[Token(Token = "0x6000B57")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x2053FE0", Offset = "0x20533E0", Length = "0x90")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000B51")]
	public static ushort Parse(string s, IFormatProvider provider) { }

	[Address(RVA = "0x2054080", Offset = "0x2053480", Length = "0xA2")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000B52")]
	public static ushort Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[Address(RVA = "0x2054130", Offset = "0x2053530", Length = "0x123")]
	[Token(Token = "0x6000B53")]
	private static ushort Parse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info) { }

	[Address(RVA = "0x2054260", Offset = "0x2053660", Length = "0x4C")]
	[Token(Token = "0x6000B58")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x20542B0", Offset = "0x20536B0", Length = "0x4C")]
	[Token(Token = "0x6000B5B")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x2054300", Offset = "0x2053700", Length = "0x4C")]
	[Token(Token = "0x6000B59")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x2054350", Offset = "0x2053750", Length = "0x84")]
	[Token(Token = "0x6000B65")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x20543E0", Offset = "0x20537E0", Length = "0x68")]
	[Token(Token = "0x6000B64")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x2054450", Offset = "0x2053850", Length = "0x4C")]
	[Token(Token = "0x6000B63")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x20544A0", Offset = "0x20538A0", Length = "0x4C")]
	[Token(Token = "0x6000B5C")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x20544F0", Offset = "0x20538F0", Length = "0x4C")]
	[Token(Token = "0x6000B5E")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x2054540", Offset = "0x2053940", Length = "0x4C")]
	[Token(Token = "0x6000B60")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x2054590", Offset = "0x2053990", Length = "0x4C")]
	[Token(Token = "0x6000B5A")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x20545E0", Offset = "0x20539E0", Length = "0x4C")]
	[Token(Token = "0x6000B62")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x2054630", Offset = "0x2053A30", Length = "0x86")]
	[Token(Token = "0x6000B66")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
	[Token(Token = "0x6000B5D")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x20546C0", Offset = "0x2053AC0", Length = "0x4C")]
	[Token(Token = "0x6000B5F")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x2054710", Offset = "0x2053B10", Length = "0x4C")]
	[Token(Token = "0x6000B61")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x20547E0", Offset = "0x2053BE0", Length = "0xC7")]
	[Token(Token = "0x6000B4F")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x2054760", Offset = "0x2053B60", Length = "0x7F")]
	[Token(Token = "0x6000B4D")]
	public virtual string ToString() { }

	[Address(RVA = "0x20548B0", Offset = "0x2053CB0", Length = "0x8B")]
	[Token(Token = "0x6000B4E")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x2054940", Offset = "0x2053D40", Length = "0xA1")]
	[Token(Token = "0x6000B50")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[Address(RVA = "0x2054BF0", Offset = "0x2053FF0", Length = "0xA7")]
	[Token(Token = "0x6000B56")]
	private static bool TryParse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info, out ushort result) { }

	[Address(RVA = "0x2054AF0", Offset = "0x2053EF0", Length = "0xFE")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000B55")]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ushort result) { }

	[Address(RVA = "0x20549F0", Offset = "0x2053DF0", Length = "0xF8")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000B54")]
	public static bool TryParse(string s, out ushort result) { }

}

