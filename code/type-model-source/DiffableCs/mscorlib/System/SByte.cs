namespace System;

[CLSCompliant(False)]
[IsReadOnly]
[Token(Token = "0x200012D")]
public struct sbyte : IComparable, IConvertible, IFormattable, IComparable<SByte>, IEquatable<SByte>, ISpanFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400043A")]
	private readonly sbyte m_value; //Field offset: 0x0

	[Address(RVA = "0x2047190", Offset = "0x2046590", Length = "0xAA")]
	[Token(Token = "0x60009A4")]
	public override int CompareTo(object obj) { }

	[Address(RVA = "0x2047180", Offset = "0x2046580", Length = "0x9")]
	[Token(Token = "0x60009A5")]
	public override int CompareTo(sbyte value) { }

	[Address(RVA = "0x2047240", Offset = "0x2046640", Length = "0x59")]
	[Token(Token = "0x60009A6")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1F8DB50", Offset = "0x1F8CF50", Length = "0x6")]
	[NonVersionable]
	[Token(Token = "0x60009A7")]
	public override bool Equals(sbyte obj) { }

	[Address(RVA = "0x20472A0", Offset = "0x20466A0", Length = "0xC")]
	[Token(Token = "0x60009A8")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x9E1870", Offset = "0x9E0C70", Length = "0x6")]
	[Token(Token = "0x60009B3")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x20472B0", Offset = "0x20466B0", Length = "0x90")]
	[CLSCompliant(False)]
	[Token(Token = "0x60009AD")]
	public static sbyte Parse(string s, IFormatProvider provider) { }

	[Address(RVA = "0x20474E0", Offset = "0x20468E0", Length = "0xA2")]
	[CLSCompliant(False)]
	[Token(Token = "0x60009AE")]
	public static sbyte Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[Address(RVA = "0x2047350", Offset = "0x2046750", Length = "0x187")]
	[Token(Token = "0x60009AF")]
	private static sbyte Parse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info) { }

	[Address(RVA = "0x2047590", Offset = "0x2046990", Length = "0x4C")]
	[Token(Token = "0x60009B4")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x20475E0", Offset = "0x20469E0", Length = "0x4C")]
	[Token(Token = "0x60009B7")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x2047630", Offset = "0x2046A30", Length = "0x4C")]
	[Token(Token = "0x60009B5")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x2047680", Offset = "0x2046A80", Length = "0x84")]
	[Token(Token = "0x60009C1")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x2047710", Offset = "0x2046B10", Length = "0x68")]
	[Token(Token = "0x60009C0")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x2047780", Offset = "0x2046B80", Length = "0x4C")]
	[Token(Token = "0x60009BF")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x20477D0", Offset = "0x2046BD0", Length = "0x4C")]
	[Token(Token = "0x60009B8")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x2047820", Offset = "0x2046C20", Length = "0x4")]
	[Token(Token = "0x60009BA")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x2047830", Offset = "0x2046C30", Length = "0x4C")]
	[Token(Token = "0x60009BC")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
	[Token(Token = "0x60009B6")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x2047880", Offset = "0x2046C80", Length = "0x4C")]
	[Token(Token = "0x60009BE")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x20478D0", Offset = "0x2046CD0", Length = "0x85")]
	[Token(Token = "0x60009C2")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x2047960", Offset = "0x2046D60", Length = "0x4C")]
	[Token(Token = "0x60009B9")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x20479B0", Offset = "0x2046DB0", Length = "0x4C")]
	[Token(Token = "0x60009BB")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x2047A00", Offset = "0x2046E00", Length = "0x4C")]
	[Token(Token = "0x60009BD")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x2047A50", Offset = "0x2046E50", Length = "0x18E")]
	[Token(Token = "0x60009AB")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x2047C70", Offset = "0x2047070", Length = "0x7F")]
	[Token(Token = "0x60009A9")]
	public virtual string ToString() { }

	[Address(RVA = "0x2047BE0", Offset = "0x2046FE0", Length = "0x8B")]
	[Token(Token = "0x60009AA")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x2047CF0", Offset = "0x20470F0", Length = "0x126")]
	[Token(Token = "0x60009AC")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[Address(RVA = "0x2047F20", Offset = "0x2047320", Length = "0xCA")]
	[Token(Token = "0x60009B2")]
	private static bool TryParse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info, out sbyte result) { }

	[Address(RVA = "0x2047FF0", Offset = "0x20473F0", Length = "0xB3")]
	[CLSCompliant(False)]
	[Token(Token = "0x60009B1")]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out sbyte result) { }

	[Address(RVA = "0x2047E20", Offset = "0x2047220", Length = "0xF8")]
	[CLSCompliant(False)]
	[Token(Token = "0x60009B0")]
	public static bool TryParse(string s, out sbyte result) { }

}

