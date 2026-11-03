namespace System;

[IsReadOnly]
[Token(Token = "0x20000C0")]
public struct bool : IComparable, IConvertible, IComparable<Boolean>, IEquatable<Boolean>
{
	[Token(Token = "0x40002A4")]
	public static readonly string TrueString; //Field offset: 0x0
	[Token(Token = "0x40002A5")]
	public static readonly string FalseString; //Field offset: 0x8
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002A3")]
	private readonly bool m_value; //Field offset: 0x0

	[Address(RVA = "0x1F8EA60", Offset = "0x1F8DE60", Length = "0x99")]
	[Token(Token = "0x6000463")]
	private static Boolean() { }

	[Address(RVA = "0x1F8DA00", Offset = "0x1F8CE00", Length = "0x18")]
	[Token(Token = "0x600044D")]
	public override int CompareTo(bool value) { }

	[Address(RVA = "0x1F8DA20", Offset = "0x1F8CE20", Length = "0xC9")]
	[Token(Token = "0x600044C")]
	public override int CompareTo(object obj) { }

	[Address(RVA = "0x1F8DAF0", Offset = "0x1F8CEF0", Length = "0x59")]
	[Token(Token = "0x600044A")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1F8DB50", Offset = "0x1F8CF50", Length = "0x6")]
	[NonVersionable]
	[Token(Token = "0x600044B")]
	public override bool Equals(bool obj) { }

	[Address(RVA = "0x1F8DB60", Offset = "0x1F8CF60", Length = "0x8")]
	[Token(Token = "0x6000447")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
	[Token(Token = "0x6000453")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x1F8DC10", Offset = "0x1F8D010", Length = "0x138")]
	[Token(Token = "0x600044E")]
	public static bool Parse(string value) { }

	[Address(RVA = "0x1F8DB70", Offset = "0x1F8CF70", Length = "0x94")]
	[Token(Token = "0x600044F")]
	public static bool Parse(ReadOnlySpan<Char> value) { }

	[Address(RVA = "0x1F8DD50", Offset = "0x1F8D150", Length = "0x7")]
	[Token(Token = "0x6000454")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x1F8DD60", Offset = "0x1F8D160", Length = "0x48")]
	[Token(Token = "0x6000457")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x1F8DDB0", Offset = "0x1F8D1B0", Length = "0x84")]
	[Token(Token = "0x6000455")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x1F8DE40", Offset = "0x1F8D240", Length = "0x84")]
	[Token(Token = "0x6000461")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x1F8DED0", Offset = "0x1F8D2D0", Length = "0xAA")]
	[Token(Token = "0x6000460")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x1F8DF80", Offset = "0x1F8D380", Length = "0x52")]
	[Token(Token = "0x600045F")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x1F8DFE0", Offset = "0x1F8D3E0", Length = "0x4A")]
	[Token(Token = "0x6000458")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x1F8E030", Offset = "0x1F8D430", Length = "0x4A")]
	[Token(Token = "0x600045A")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x1F8E080", Offset = "0x1F8D480", Length = "0x4A")]
	[Token(Token = "0x600045C")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x1F8E0D0", Offset = "0x1F8D4D0", Length = "0x48")]
	[Token(Token = "0x6000456")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x1F8E120", Offset = "0x1F8D520", Length = "0x51")]
	[Token(Token = "0x600045E")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x1F8E180", Offset = "0x1F8D580", Length = "0x86")]
	[Token(Token = "0x6000462")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x1F8E210", Offset = "0x1F8D610", Length = "0x4A")]
	[Token(Token = "0x6000459")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x1F8E260", Offset = "0x1F8D660", Length = "0x4A")]
	[Token(Token = "0x600045B")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x1F8E2B0", Offset = "0x1F8D6B0", Length = "0x4A")]
	[Token(Token = "0x600045D")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x1F8E350", Offset = "0x1F8D750", Length = "0x5E")]
	[Token(Token = "0x6000449")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x1F8E300", Offset = "0x1F8D700", Length = "0x49")]
	[Token(Token = "0x6000448")]
	public virtual string ToString() { }

	[Address(RVA = "0x1F8E3B0", Offset = "0x1F8D7B0", Length = "0x18A")]
	[Token(Token = "0x6000452")]
	private static ReadOnlySpan<Char> TrimWhiteSpaceAndNull(ReadOnlySpan<Char> value) { }

	[Address(RVA = "0x1F8E540", Offset = "0x1F8D940", Length = "0x474")]
	[Token(Token = "0x6000451")]
	public static bool TryParse(ReadOnlySpan<Char> value, out bool result) { }

	[Address(RVA = "0x1F8E9C0", Offset = "0x1F8DDC0", Length = "0x9A")]
	[Token(Token = "0x6000450")]
	public static bool TryParse(string value, out bool result) { }

}

