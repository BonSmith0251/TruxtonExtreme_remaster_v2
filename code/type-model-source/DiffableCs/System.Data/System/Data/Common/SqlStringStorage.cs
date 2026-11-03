namespace System.Data.Common;

[Token(Token = "0x20000E0")]
internal sealed class SqlStringStorage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400048B")]
	private SqlString[] _values; //Field offset: 0x50

	[Address(RVA = "0x23D3470", Offset = "0x23D2870", Length = "0x14E")]
	[Token(Token = "0x6000C71")]
	public SqlStringStorage(DataColumn column) { }

	[Address(RVA = "0x23D2450", Offset = "0x23D1850", Length = "0x32A")]
	[Token(Token = "0x6000C72")]
	public virtual object Aggregate(Int32[] recordNos, AggregateType kind) { }

	[Address(RVA = "0x23D2880", Offset = "0x23D1C80", Length = "0x79")]
	[Token(Token = "0x6000C73")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23D2900", Offset = "0x23D1D00", Length = "0x15B")]
	[Token(Token = "0x6000C74")]
	public int Compare(SqlString valueNo1, SqlString valueNo2) { }

	[Address(RVA = "0x23D2780", Offset = "0x23D1B80", Length = "0xF2")]
	[Token(Token = "0x6000C75")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23D2A60", Offset = "0x23D1E60", Length = "0x1A5")]
	[Token(Token = "0x6000C7E")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23D2C10", Offset = "0x23D2010", Length = "0x7D")]
	[Token(Token = "0x6000C76")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23D2C90", Offset = "0x23D2090", Length = "0x1FB")]
	[Token(Token = "0x6000C7D")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23D2FF0", Offset = "0x23D23F0", Length = "0x66")]
	[Token(Token = "0x6000C77")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23D2E90", Offset = "0x23D2290", Length = "0x158")]
	[Token(Token = "0x6000C80")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23D3180", Offset = "0x23D2580", Length = "0x7C")]
	[Token(Token = "0x6000C78")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23D3060", Offset = "0x23D2460", Length = "0x37")]
	[Token(Token = "0x6000C7F")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23D30A0", Offset = "0x23D24A0", Length = "0xDB")]
	[Token(Token = "0x6000C79")]
	public virtual int GetStringLength(int record) { }

	[Address(RVA = "0x23D3200", Offset = "0x23D2600", Length = "0x76")]
	[Token(Token = "0x6000C7A")]
	public virtual bool IsNull(int record) { }

	[Address(RVA = "0x23D33F0", Offset = "0x23D27F0", Length = "0x70")]
	[Token(Token = "0x6000C7B")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23D3280", Offset = "0x23D2680", Length = "0xCA")]
	[Token(Token = "0x6000C7C")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23D3350", Offset = "0x23D2750", Length = "0x9F")]
	[Token(Token = "0x6000C81")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

