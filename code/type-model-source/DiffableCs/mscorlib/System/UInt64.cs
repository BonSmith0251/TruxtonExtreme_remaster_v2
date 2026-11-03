namespace System;

[CLSCompliant(False)]
[IsReadOnly]
[Token(Token = "0x200014C")]
public struct ulong : IComparable, IConvertible, IFormattable, IComparable<UInt64>, IEquatable<UInt64>, ISpanFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400047A")]
	private readonly ulong m_value; //Field offset: 0x0

	[Address(RVA = "0x2055A70", Offset = "0x2054E70", Length = "0xB1")]
	[Token(Token = "0x6000B86")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x2055A50", Offset = "0x2054E50", Length = "0x14")]
	[Token(Token = "0x6000B87")]
	public override int CompareTo(ulong value) { }

	[Address(RVA = "0x2055B30", Offset = "0x2054F30", Length = "0x5A")]
	[Token(Token = "0x6000B88")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[NonVersionable]
	[Token(Token = "0x6000B89")]
	public override bool Equals(ulong obj) { }

	[Address(RVA = "0x2055B90", Offset = "0x2054F90", Length = "0xA")]
	[Token(Token = "0x6000B8A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x9DCC70", Offset = "0x9DC070", Length = "0x6")]
	[Token(Token = "0x6000B94")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x2055BA0", Offset = "0x2054FA0", Length = "0xC8")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000B90")]
	public static ulong Parse(string s, IFormatProvider provider) { }

	[Address(RVA = "0x2055C70", Offset = "0x2055070", Length = "0xDA")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000B91")]
	public static ulong Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[Address(RVA = "0x2055D50", Offset = "0x2055150", Length = "0x4C")]
	[Token(Token = "0x6000B95")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x2055DA0", Offset = "0x20551A0", Length = "0x4C")]
	[Token(Token = "0x6000B98")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x2055DF0", Offset = "0x20551F0", Length = "0x4C")]
	[Token(Token = "0x6000B96")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x2055E40", Offset = "0x2055240", Length = "0x84")]
	[Token(Token = "0x6000BA2")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x2055ED0", Offset = "0x20552D0", Length = "0x68")]
	[Token(Token = "0x6000BA1")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x2055F40", Offset = "0x2055340", Length = "0x4C")]
	[Token(Token = "0x6000BA0")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x2055F90", Offset = "0x2055390", Length = "0x4C")]
	[Token(Token = "0x6000B99")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x2055FE0", Offset = "0x20553E0", Length = "0x4C")]
	[Token(Token = "0x6000B9B")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x2056030", Offset = "0x2055430", Length = "0x4C")]
	[Token(Token = "0x6000B9D")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x2056080", Offset = "0x2055480", Length = "0x4C")]
	[Token(Token = "0x6000B97")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x20560D0", Offset = "0x20554D0", Length = "0x4C")]
	[Token(Token = "0x6000B9F")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x2056120", Offset = "0x2055520", Length = "0x86")]
	[Token(Token = "0x6000BA3")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x20561B0", Offset = "0x20555B0", Length = "0x4C")]
	[Token(Token = "0x6000B9A")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x2056200", Offset = "0x2055600", Length = "0x4C")]
	[Token(Token = "0x6000B9C")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6000B9E")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x2056310", Offset = "0x2055710", Length = "0xC8")]
	[Token(Token = "0x6000B8E")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x2056250", Offset = "0x2055650", Length = "0xBB")]
	[Token(Token = "0x6000B8D")]
	public string ToString(string format) { }

	[Address(RVA = "0x2056470", Offset = "0x2055870", Length = "0x80")]
	[Token(Token = "0x6000B8B")]
	public virtual string ToString() { }

	[Address(RVA = "0x20563E0", Offset = "0x20557E0", Length = "0x8C")]
	[Token(Token = "0x6000B8C")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x20564F0", Offset = "0x20558F0", Length = "0xA2")]
	[Token(Token = "0x6000B8F")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[Address(RVA = "0x20565A0", Offset = "0x20559A0", Length = "0xF1")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000B93")]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ulong result) { }

	[Address(RVA = "0x20566A0", Offset = "0x2055AA0", Length = "0xD6")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000B92")]
	public static bool TryParse(string s, out ulong result) { }

}

