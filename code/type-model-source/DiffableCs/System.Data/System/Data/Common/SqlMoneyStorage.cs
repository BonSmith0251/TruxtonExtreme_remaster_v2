namespace System.Data.Common;

[Token(Token = "0x20000DE")]
internal sealed class SqlMoneyStorage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000489")]
	private SqlMoney[] _values; //Field offset: 0x50

	[Address(RVA = "0x23D0BC0", Offset = "0x23CFFC0", Length = "0x138")]
	[Token(Token = "0x6000C53")]
	public SqlMoneyStorage(DataColumn column) { }

	[Address(RVA = "0x23CF3F0", Offset = "0x23CE7F0", Length = "0xDC8")]
	[Token(Token = "0x6000C54")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23D02A0", Offset = "0x23CF6A0", Length = "0xB4")]
	[Token(Token = "0x6000C55")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23D01E0", Offset = "0x23CF5E0", Length = "0xBC")]
	[Token(Token = "0x6000C56")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23D0360", Offset = "0x23CF760", Length = "0x1A5")]
	[Token(Token = "0x6000C5E")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23D0510", Offset = "0x23CF910", Length = "0x74")]
	[Token(Token = "0x6000C57")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23D0590", Offset = "0x23CF990", Length = "0x1EE")]
	[Token(Token = "0x6000C5D")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23C9AB0", Offset = "0x23C8EB0", Length = "0x47")]
	[Token(Token = "0x6000C58")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23D0780", Offset = "0x23CFB80", Length = "0x127")]
	[Token(Token = "0x6000C60")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23D08F0", Offset = "0x23CFCF0", Length = "0x71")]
	[Token(Token = "0x6000C59")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23D08B0", Offset = "0x23CFCB0", Length = "0x37")]
	[Token(Token = "0x6000C5F")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23D0970", Offset = "0x23CFD70", Length = "0x76")]
	[Token(Token = "0x6000C5A")]
	public virtual bool IsNull(int record) { }

	[Address(RVA = "0x23D0B60", Offset = "0x23CFF60", Length = "0x55")]
	[Token(Token = "0x6000C5B")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23D09F0", Offset = "0x23CFDF0", Length = "0xCA")]
	[Token(Token = "0x6000C5C")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23D0AC0", Offset = "0x23CFEC0", Length = "0x9F")]
	[Token(Token = "0x6000C61")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

