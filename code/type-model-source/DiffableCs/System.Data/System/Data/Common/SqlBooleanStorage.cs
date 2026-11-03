namespace System.Data.Common;

[Token(Token = "0x20000E1")]
internal sealed class SqlBooleanStorage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400048C")]
	private SqlBoolean[] _values; //Field offset: 0x50

	[Address(RVA = "0x23C8620", Offset = "0x23C7A20", Length = "0x128")]
	[Token(Token = "0x6000C82")]
	public SqlBooleanStorage(DataColumn column) { }

	[Address(RVA = "0x23C7900", Offset = "0x23C6D00", Length = "0x39B")]
	[Token(Token = "0x6000C83")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23C7D50", Offset = "0x23C7150", Length = "0x97")]
	[Token(Token = "0x6000C84")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23C7CA0", Offset = "0x23C70A0", Length = "0xAD")]
	[Token(Token = "0x6000C85")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23C7DF0", Offset = "0x23C71F0", Length = "0x1A5")]
	[Token(Token = "0x6000C8D")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23C7FA0", Offset = "0x23C73A0", Length = "0x6A")]
	[Token(Token = "0x6000C86")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23C8010", Offset = "0x23C7410", Length = "0x1D6")]
	[Token(Token = "0x6000C8C")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23C8300", Offset = "0x23C7700", Length = "0x3A")]
	[Token(Token = "0x6000C87")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23C81F0", Offset = "0x23C75F0", Length = "0x102")]
	[Token(Token = "0x6000C8F")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23C8380", Offset = "0x23C7780", Length = "0x6A")]
	[Token(Token = "0x6000C88")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23C8340", Offset = "0x23C7740", Length = "0x37")]
	[Token(Token = "0x6000C8E")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23C83F0", Offset = "0x23C77F0", Length = "0x72")]
	[Token(Token = "0x6000C89")]
	public virtual bool IsNull(int record) { }

	[Address(RVA = "0x23C85E0", Offset = "0x23C79E0", Length = "0x3F")]
	[Token(Token = "0x6000C8A")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23C8470", Offset = "0x23C7870", Length = "0xCA")]
	[Token(Token = "0x6000C8B")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23C8540", Offset = "0x23C7940", Length = "0x9F")]
	[Token(Token = "0x6000C90")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

