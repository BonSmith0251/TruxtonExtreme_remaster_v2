namespace System;

[Token(Token = "0x20000C7")]
public sealed class DBNull : ISerializable, IConvertible
{
	[Token(Token = "0x40002B5")]
	public static readonly DBNull Value; //Field offset: 0x0

	[Address(RVA = "0x20065D0", Offset = "0x20059D0", Length = "0x67")]
	[Token(Token = "0x60005D5")]
	private static DBNull() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60005C0")]
	private DBNull() { }

	[Address(RVA = "0x2006640", Offset = "0x2005A40", Length = "0x55")]
	[Token(Token = "0x60005C1")]
	private DBNull(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x20060F0", Offset = "0x20054F0", Length = "0x10")]
	[Token(Token = "0x60005C2")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x60005C5")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x2006100", Offset = "0x2005500", Length = "0x4E")]
	[Token(Token = "0x60005C6")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x2006150", Offset = "0x2005550", Length = "0x4E")]
	[Token(Token = "0x60005C9")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x20061A0", Offset = "0x20055A0", Length = "0x4E")]
	[Token(Token = "0x60005C7")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x20061F0", Offset = "0x20055F0", Length = "0x4E")]
	[Token(Token = "0x60005D3")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x2006240", Offset = "0x2005640", Length = "0x4E")]
	[Token(Token = "0x60005D2")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x2006290", Offset = "0x2005690", Length = "0x4E")]
	[Token(Token = "0x60005D1")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x20062E0", Offset = "0x20056E0", Length = "0x4E")]
	[Token(Token = "0x60005CA")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x2006330", Offset = "0x2005730", Length = "0x4E")]
	[Token(Token = "0x60005CC")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x2006380", Offset = "0x2005780", Length = "0x4E")]
	[Token(Token = "0x60005CE")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x20063D0", Offset = "0x20057D0", Length = "0x4E")]
	[Token(Token = "0x60005C8")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x2006420", Offset = "0x2005820", Length = "0x4E")]
	[Token(Token = "0x60005D0")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x2006470", Offset = "0x2005870", Length = "0x69")]
	[Token(Token = "0x60005D4")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x20064E0", Offset = "0x20058E0", Length = "0x4E")]
	[Token(Token = "0x60005CB")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x2006530", Offset = "0x2005930", Length = "0x4E")]
	[Token(Token = "0x60005CD")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x2006580", Offset = "0x2005980", Length = "0x4E")]
	[Token(Token = "0x60005CF")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x60005C4")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x60005C3")]
	public virtual string ToString() { }

}

