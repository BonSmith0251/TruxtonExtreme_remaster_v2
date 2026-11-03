namespace System;

[IsReadOnly]
[Token(Token = "0x20000C1")]
public struct byte : IComparable, IConvertible, IFormattable, IComparable<Byte>, IEquatable<Byte>, ISpanFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002A6")]
	private readonly byte m_value; //Field offset: 0x0

	[Address(RVA = "0x1F8EB10", Offset = "0x1F8DF10", Length = "0xAA")]
	[Token(Token = "0x6000464")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x1F8EB00", Offset = "0x1F8DF00", Length = "0x9")]
	[Token(Token = "0x6000465")]
	public override int CompareTo(byte value) { }

	[Address(RVA = "0x1F8EBC0", Offset = "0x1F8DFC0", Length = "0x59")]
	[Token(Token = "0x6000466")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1F8DB50", Offset = "0x1F8CF50", Length = "0x6")]
	[NonVersionable]
	[Token(Token = "0x6000467")]
	public override bool Equals(byte obj) { }

	[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
	[Token(Token = "0x6000468")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x9E1830", Offset = "0x9E0C30", Length = "0x6")]
	[Token(Token = "0x6000474")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x1F8EE10", Offset = "0x1F8E210", Length = "0xA4")]
	[Token(Token = "0x6000469")]
	public static byte Parse(string s, IFormatProvider provider) { }

	[Address(RVA = "0x1F8ED50", Offset = "0x1F8E150", Length = "0xB6")]
	[Token(Token = "0x600046A")]
	public static byte Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[Address(RVA = "0x1F8EC20", Offset = "0x1F8E020", Length = "0x123")]
	[Token(Token = "0x600046B")]
	private static byte Parse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info) { }

	[Address(RVA = "0x1F8EEC0", Offset = "0x1F8E2C0", Length = "0x48")]
	[Token(Token = "0x6000475")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
	[Token(Token = "0x6000478")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x1F8EF10", Offset = "0x1F8E310", Length = "0x46")]
	[Token(Token = "0x6000476")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x1F8EF60", Offset = "0x1F8E360", Length = "0x84")]
	[Token(Token = "0x6000482")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x1F8EFF0", Offset = "0x1F8E3F0", Length = "0x99")]
	[Token(Token = "0x6000481")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x1F8F090", Offset = "0x1F8E490", Length = "0x4B")]
	[Token(Token = "0x6000480")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x1F8F0E0", Offset = "0x1F8E4E0", Length = "0x46")]
	[Token(Token = "0x6000479")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x1F8F130", Offset = "0x1F8E530", Length = "0x45")]
	[Token(Token = "0x600047B")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x1F8F180", Offset = "0x1F8E580", Length = "0x46")]
	[Token(Token = "0x600047D")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x1F8F1D0", Offset = "0x1F8E5D0", Length = "0x7A")]
	[Token(Token = "0x6000477")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x1F8F250", Offset = "0x1F8E650", Length = "0x4A")]
	[Token(Token = "0x600047F")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x1F8F2A0", Offset = "0x1F8E6A0", Length = "0x85")]
	[Token(Token = "0x6000483")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x1F8F330", Offset = "0x1F8E730", Length = "0x46")]
	[Token(Token = "0x600047A")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x1F8F380", Offset = "0x1F8E780", Length = "0x45")]
	[Token(Token = "0x600047C")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x1F8F3D0", Offset = "0x1F8E7D0", Length = "0x46")]
	[Token(Token = "0x600047E")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x1F8F420", Offset = "0x1F8E820", Length = "0x8B")]
	[Token(Token = "0x6000471")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x1F8F580", Offset = "0x1F8E980", Length = "0xBA")]
	[Token(Token = "0x6000470")]
	public string ToString(string format) { }

	[Address(RVA = "0x1F8F640", Offset = "0x1F8EA40", Length = "0x7F")]
	[Token(Token = "0x600046F")]
	public virtual string ToString() { }

	[Address(RVA = "0x1F8F4B0", Offset = "0x1F8E8B0", Length = "0xC7")]
	[Token(Token = "0x6000472")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x1F8F6C0", Offset = "0x1F8EAC0", Length = "0xA1")]
	[Token(Token = "0x6000473")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[Address(RVA = "0x1F8F770", Offset = "0x1F8EB70", Length = "0xAD")]
	[Token(Token = "0x600046E")]
	private static bool TryParse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info, out byte result) { }

	[Address(RVA = "0x1F8F820", Offset = "0x1F8EC20", Length = "0x10B")]
	[Token(Token = "0x600046D")]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out byte result) { }

	[Address(RVA = "0x1F8F930", Offset = "0x1F8ED30", Length = "0xF2")]
	[Token(Token = "0x600046C")]
	public static bool TryParse(string s, out byte result) { }

}

