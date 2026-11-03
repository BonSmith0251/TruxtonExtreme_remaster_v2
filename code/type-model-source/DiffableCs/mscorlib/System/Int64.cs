namespace System;

[IsReadOnly]
[Token(Token = "0x2000102")]
public struct long : IComparable, IConvertible, IFormattable, IComparable<Int64>, IEquatable<Int64>, ISpanFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003F1")]
	private readonly long m_value; //Field offset: 0x0

	[Address(RVA = "0x2028150", Offset = "0x2027550", Length = "0xB1")]
	[Token(Token = "0x60007FD")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x2028210", Offset = "0x2027610", Length = "0x14")]
	[Token(Token = "0x60007FE")]
	public override int CompareTo(long value) { }

	[Address(RVA = "0x2028230", Offset = "0x2027630", Length = "0x5A")]
	[Token(Token = "0x60007FF")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[NonVersionable]
	[Token(Token = "0x6000800")]
	public override bool Equals(long obj) { }

	[Address(RVA = "0x2028290", Offset = "0x2027690", Length = "0xA")]
	[Token(Token = "0x6000801")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x20282A0", Offset = "0x20276A0", Length = "0x6")]
	[Token(Token = "0x600080B")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x20283A0", Offset = "0x20277A0", Length = "0xD8")]
	[Token(Token = "0x6000807")]
	public static long Parse(string s, IFormatProvider provider) { }

	[Address(RVA = "0x20282B0", Offset = "0x20276B0", Length = "0xEA")]
	[Token(Token = "0x6000808")]
	public static long Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[Address(RVA = "0x2028480", Offset = "0x2027880", Length = "0x4C")]
	[Token(Token = "0x600080C")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x20284D0", Offset = "0x20278D0", Length = "0x4C")]
	[Token(Token = "0x600080F")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x2028520", Offset = "0x2027920", Length = "0x4C")]
	[Token(Token = "0x600080D")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x2028570", Offset = "0x2027970", Length = "0x84")]
	[Token(Token = "0x6000819")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x2028600", Offset = "0x2027A00", Length = "0x68")]
	[Token(Token = "0x6000818")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x2028670", Offset = "0x2027A70", Length = "0x4C")]
	[Token(Token = "0x6000817")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x20286C0", Offset = "0x2027AC0", Length = "0x4C")]
	[Token(Token = "0x6000810")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x2028710", Offset = "0x2027B10", Length = "0x4C")]
	[Token(Token = "0x6000812")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6000814")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x2028760", Offset = "0x2027B60", Length = "0x4C")]
	[Token(Token = "0x600080E")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x20287B0", Offset = "0x2027BB0", Length = "0x4C")]
	[Token(Token = "0x6000816")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x2028800", Offset = "0x2027C00", Length = "0x86")]
	[Token(Token = "0x600081A")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x2028890", Offset = "0x2027C90", Length = "0x4C")]
	[Token(Token = "0x6000811")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x20288E0", Offset = "0x2027CE0", Length = "0x4C")]
	[Token(Token = "0x6000813")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x2028930", Offset = "0x2027D30", Length = "0x4C")]
	[Token(Token = "0x6000815")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x2028A90", Offset = "0x2027E90", Length = "0xC8")]
	[Token(Token = "0x6000805")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x2028B60", Offset = "0x2027F60", Length = "0xBB")]
	[Token(Token = "0x6000804")]
	public string ToString(string format) { }

	[Address(RVA = "0x2028980", Offset = "0x2027D80", Length = "0x80")]
	[Token(Token = "0x6000802")]
	public virtual string ToString() { }

	[Address(RVA = "0x2028A00", Offset = "0x2027E00", Length = "0x8C")]
	[Token(Token = "0x6000803")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x2028C20", Offset = "0x2028020", Length = "0xA2")]
	[Token(Token = "0x6000806")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[Address(RVA = "0x2028E40", Offset = "0x2028240", Length = "0xF1")]
	[Token(Token = "0x600080A")]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result) { }

	[Address(RVA = "0x2028CD0", Offset = "0x20280D0", Length = "0x16A")]
	[Token(Token = "0x6000809")]
	public static bool TryParse(string s, out long result) { }

}

