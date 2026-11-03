namespace System.Data.Common;

[Token(Token = "0x20000DF")]
internal sealed class SqlSingleStorage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400048A")]
	private SqlSingle[] _values; //Field offset: 0x50

	[Address(RVA = "0x23D2320", Offset = "0x23D1720", Length = "0x126")]
	[Token(Token = "0x6000C62")]
	public SqlSingleStorage(DataColumn column) { }

	[Address(RVA = "0x23D0D00", Offset = "0x23D0100", Length = "0xCA8")]
	[Token(Token = "0x6000C63")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23D1A80", Offset = "0x23D0E80", Length = "0x98")]
	[Token(Token = "0x6000C64")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23D19D0", Offset = "0x23D0DD0", Length = "0xAE")]
	[Token(Token = "0x6000C65")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23D1B20", Offset = "0x23D0F20", Length = "0x1A5")]
	[Token(Token = "0x6000C6D")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23D1CD0", Offset = "0x23D10D0", Length = "0x6B")]
	[Token(Token = "0x6000C66")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23D1D40", Offset = "0x23D1140", Length = "0x1DB")]
	[Token(Token = "0x6000C6C")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23CD6C0", Offset = "0x23CCAC0", Length = "0x39")]
	[Token(Token = "0x6000C67")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23D1F20", Offset = "0x23D1320", Length = "0x103")]
	[Token(Token = "0x6000C6F")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23D2070", Offset = "0x23D1470", Length = "0x6B")]
	[Token(Token = "0x6000C68")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23D2030", Offset = "0x23D1430", Length = "0x37")]
	[Token(Token = "0x6000C6E")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23D20E0", Offset = "0x23D14E0", Length = "0x73")]
	[Token(Token = "0x6000C69")]
	public virtual bool IsNull(int record) { }

	[Address(RVA = "0x23D22D0", Offset = "0x23D16D0", Length = "0x40")]
	[Token(Token = "0x6000C6A")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23D2160", Offset = "0x23D1560", Length = "0xCA")]
	[Token(Token = "0x6000C6B")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23D2230", Offset = "0x23D1630", Length = "0x9F")]
	[Token(Token = "0x6000C70")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

