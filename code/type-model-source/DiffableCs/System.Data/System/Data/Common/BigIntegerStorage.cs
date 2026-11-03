namespace System.Data.Common;

[Token(Token = "0x20000C4")]
internal sealed class BigIntegerStorage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000437")]
	private BigInteger[] _values; //Field offset: 0x50

	[Address(RVA = "0x23AA3A0", Offset = "0x23A97A0", Length = "0x134")]
	[Token(Token = "0x6000AC1")]
	internal BigIntegerStorage(DataColumn column) { }

	[Address(RVA = "0x23A8AC0", Offset = "0x23A7EC0", Length = "0x31")]
	[Token(Token = "0x6000AC2")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23A8C70", Offset = "0x23A8070", Length = "0x141")]
	[Token(Token = "0x6000AC3")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23A8B00", Offset = "0x23A7F00", Length = "0x161")]
	[Token(Token = "0x6000AC4")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23A8DC0", Offset = "0x23A81C0", Length = "0x6C6")]
	[Token(Token = "0x6000AC6")]
	internal static object ConvertFromBigInteger(BigInteger value, Type type, IFormatProvider formatProvider) { }

	[Address(RVA = "0x23A9490", Offset = "0x23A8890", Length = "0xCA")]
	[Token(Token = "0x6000ACD")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23A9560", Offset = "0x23A8960", Length = "0x6B3")]
	[Token(Token = "0x6000AC5")]
	internal static BigInteger ConvertToBigInteger(object value, IFormatProvider formatProvider) { }

	[Address(RVA = "0x23A9C20", Offset = "0x23A9020", Length = "0x95")]
	[Token(Token = "0x6000AC7")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23A9CC0", Offset = "0x23A90C0", Length = "0xA0")]
	[Token(Token = "0x6000ACC")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23A9EA0", Offset = "0x23A92A0", Length = "0xA2")]
	[Token(Token = "0x6000AC8")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23A9D60", Offset = "0x23A9160", Length = "0x13B")]
	[Token(Token = "0x6000ACF")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23A9F90", Offset = "0x23A9390", Length = "0xE6")]
	[Token(Token = "0x6000AC9")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23A9F50", Offset = "0x23A9350", Length = "0x37")]
	[Token(Token = "0x6000ACE")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23AA220", Offset = "0x23A9620", Length = "0x172")]
	[Token(Token = "0x6000ACA")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23AA080", Offset = "0x23A9480", Length = "0xD7")]
	[Token(Token = "0x6000ACB")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23AA160", Offset = "0x23A9560", Length = "0xBC")]
	[Token(Token = "0x6000AD0")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

