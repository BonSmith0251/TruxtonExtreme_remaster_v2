namespace System.Data.Common;

[Token(Token = "0x20000DD")]
internal sealed class SqlInt64Storage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000488")]
	private SqlInt64[] _values; //Field offset: 0x50

	[Address(RVA = "0x23CF2B0", Offset = "0x23CE6B0", Length = "0x138")]
	[Token(Token = "0x6000C44")]
	public SqlInt64Storage(DataColumn column) { }

	[Address(RVA = "0x23CDB20", Offset = "0x23CCF20", Length = "0xD88")]
	[Token(Token = "0x6000C45")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23CE990", Offset = "0x23CDD90", Length = "0xB4")]
	[Token(Token = "0x6000C46")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23CE8D0", Offset = "0x23CDCD0", Length = "0xBC")]
	[Token(Token = "0x6000C47")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23CEA50", Offset = "0x23CDE50", Length = "0x1A5")]
	[Token(Token = "0x6000C4F")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23CEC00", Offset = "0x23CE000", Length = "0x74")]
	[Token(Token = "0x6000C48")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23CEC80", Offset = "0x23CE080", Length = "0x1EE")]
	[Token(Token = "0x6000C4E")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23C9AB0", Offset = "0x23C8EB0", Length = "0x47")]
	[Token(Token = "0x6000C49")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23CEE70", Offset = "0x23CE270", Length = "0x127")]
	[Token(Token = "0x6000C51")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23CEFE0", Offset = "0x23CE3E0", Length = "0x71")]
	[Token(Token = "0x6000C4A")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23CEFA0", Offset = "0x23CE3A0", Length = "0x37")]
	[Token(Token = "0x6000C50")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23CF060", Offset = "0x23CE460", Length = "0x76")]
	[Token(Token = "0x6000C4B")]
	public virtual bool IsNull(int record) { }

	[Address(RVA = "0x23CF250", Offset = "0x23CE650", Length = "0x55")]
	[Token(Token = "0x6000C4C")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23CF0E0", Offset = "0x23CE4E0", Length = "0xCA")]
	[Token(Token = "0x6000C4D")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23CF1B0", Offset = "0x23CE5B0", Length = "0x9F")]
	[Token(Token = "0x6000C52")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

