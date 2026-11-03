namespace System.Data.Common;

[Token(Token = "0x20000D2")]
internal static class SqlConvert
{

	[Address(RVA = "0x23BCD50", Offset = "0x23BC150", Length = "0x10D0")]
	[Token(Token = "0x6000BAE")]
	public static object ChangeType2(object value, StorageType stype, Type type, IFormatProvider formatProvider) { }

	[Address(RVA = "0x23BE810", Offset = "0x23BDC10", Length = "0x1BA")]
	[Token(Token = "0x6000BAD")]
	public static object ChangeTypeForDefaultValue(object value, Type type, IFormatProvider formatProvider) { }

	[Address(RVA = "0x23BE9D0", Offset = "0x23BDDD0", Length = "0x254")]
	[Token(Token = "0x6000BAF")]
	public static object ChangeTypeForXML(object value, Type type) { }

	[Address(RVA = "0x23C0910", Offset = "0x23BFD10", Length = "0x75")]
	[Token(Token = "0x6000BAC")]
	public static DateTimeOffset ConvertStringToDateTimeOffset(string value, IFormatProvider formatProvider) { }

	[Address(RVA = "0x23C0990", Offset = "0x23BFD90", Length = "0x1BE")]
	[Token(Token = "0x6000BA8")]
	public static SqlBinary ConvertToSqlBinary(object value) { }

	[Address(RVA = "0x23C0B50", Offset = "0x23BFF50", Length = "0x1AC")]
	[Token(Token = "0x6000BA6")]
	public static SqlBoolean ConvertToSqlBoolean(object value) { }

	[Address(RVA = "0x23C0D00", Offset = "0x23C0100", Length = "0x1B2")]
	[Token(Token = "0x6000B9D")]
	public static SqlByte ConvertToSqlByte(object value) { }

	[Address(RVA = "0x23C0EC0", Offset = "0x23C02C0", Length = "0x131")]
	[Token(Token = "0x6000BAB")]
	public static SqlBytes ConvertToSqlBytes(object value) { }

	[Address(RVA = "0x23C1000", Offset = "0x23C0400", Length = "0x131")]
	[Token(Token = "0x6000BAA")]
	public static SqlChars ConvertToSqlChars(object value) { }

	[Address(RVA = "0x23C1140", Offset = "0x23C0540", Length = "0x1F7")]
	[Token(Token = "0x6000BA5")]
	public static SqlDateTime ConvertToSqlDateTime(object value) { }

	[Address(RVA = "0x23C1340", Offset = "0x23C0740", Length = "0x118")]
	[Token(Token = "0x6000BA2")]
	public static SqlDecimal ConvertToSqlDecimal(object value) { }

	[Address(RVA = "0x23C19D0", Offset = "0x23C0DD0", Length = "0x3D0")]
	[Token(Token = "0x6000BA1")]
	public static SqlDouble ConvertToSqlDouble(object value) { }

	[Address(RVA = "0x23C2130", Offset = "0x23C1530", Length = "0x1CD")]
	[Token(Token = "0x6000BA7")]
	public static SqlGuid ConvertToSqlGuid(object value) { }

	[Address(RVA = "0x23C2300", Offset = "0x23C1700", Length = "0x275")]
	[Token(Token = "0x6000B9E")]
	public static SqlInt16 ConvertToSqlInt16(object value) { }

	[Address(RVA = "0x23C2580", Offset = "0x23C1980", Length = "0x38F")]
	[Token(Token = "0x6000B9F")]
	public static SqlInt32 ConvertToSqlInt32(object value) { }

	[Address(RVA = "0x23C2910", Offset = "0x23C1D10", Length = "0x480")]
	[Token(Token = "0x6000BA0")]
	public static SqlInt64 ConvertToSqlInt64(object value) { }

	[Address(RVA = "0x23C2DB0", Offset = "0x23C21B0", Length = "0x5CC")]
	[Token(Token = "0x6000BA4")]
	public static SqlMoney ConvertToSqlMoney(object value) { }

	[Address(RVA = "0x23C33B0", Offset = "0x23C27B0", Length = "0x6A8")]
	[Token(Token = "0x6000BA3")]
	public static SqlSingle ConvertToSqlSingle(object value) { }

	[Address(RVA = "0x23C3AB0", Offset = "0x23C2EB0", Length = "0x1DA")]
	[Token(Token = "0x6000BA9")]
	public static SqlString ConvertToSqlString(object value) { }

}

