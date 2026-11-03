namespace System;

[CLSCompliant(False)]
[Token(Token = "0x20000F4")]
public interface IConvertible
{

	[Token(Token = "0x600079A")]
	public TypeCode GetTypeCode() { }

	[Token(Token = "0x600079B")]
	public bool ToBoolean(IFormatProvider provider) { }

	[Token(Token = "0x600079E")]
	public byte ToByte(IFormatProvider provider) { }

	[Token(Token = "0x600079C")]
	public char ToChar(IFormatProvider provider) { }

	[Token(Token = "0x60007A8")]
	public DateTime ToDateTime(IFormatProvider provider) { }

	[Token(Token = "0x60007A7")]
	public decimal ToDecimal(IFormatProvider provider) { }

	[Token(Token = "0x60007A6")]
	public double ToDouble(IFormatProvider provider) { }

	[Token(Token = "0x600079F")]
	public short ToInt16(IFormatProvider provider) { }

	[Token(Token = "0x60007A1")]
	public int ToInt32(IFormatProvider provider) { }

	[Token(Token = "0x60007A3")]
	public long ToInt64(IFormatProvider provider) { }

	[Token(Token = "0x600079D")]
	public sbyte ToSByte(IFormatProvider provider) { }

	[Token(Token = "0x60007A5")]
	public float ToSingle(IFormatProvider provider) { }

	[Token(Token = "0x60007A9")]
	public string ToString(IFormatProvider provider) { }

	[Token(Token = "0x60007AA")]
	public object ToType(Type conversionType, IFormatProvider provider) { }

	[Token(Token = "0x60007A0")]
	public ushort ToUInt16(IFormatProvider provider) { }

	[Token(Token = "0x60007A2")]
	public uint ToUInt32(IFormatProvider provider) { }

	[Token(Token = "0x60007A4")]
	public ulong ToUInt64(IFormatProvider provider) { }

}

