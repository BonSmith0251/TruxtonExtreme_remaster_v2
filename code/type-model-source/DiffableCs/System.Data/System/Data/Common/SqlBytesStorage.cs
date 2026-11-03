namespace System.Data.Common;

[Token(Token = "0x20000D5")]
internal sealed class SqlBytesStorage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000480")]
	private SqlBytes[] _values; //Field offset: 0x50

	[Address(RVA = "0x23BC260", Offset = "0x23BB660", Length = "0xE1")]
	[Token(Token = "0x6000BCE")]
	public SqlBytesStorage(DataColumn column) { }

	[Address(RVA = "0x23BB890", Offset = "0x23BAC90", Length = "0x178")]
	[Token(Token = "0x6000BCF")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000BD0")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000BD1")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23BBA10", Offset = "0x23BAE10", Length = "0x1AF")]
	[Token(Token = "0x6000BD8")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23BBBC0", Offset = "0x23BAFC0", Length = "0x200")]
	[Token(Token = "0x6000BD7")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23BBEF0", Offset = "0x23BB2F0", Length = "0x48")]
	[Token(Token = "0x6000BD2")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23BBDD0", Offset = "0x23BB1D0", Length = "0x11A")]
	[Token(Token = "0x6000BDA")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23BBF80", Offset = "0x23BB380", Length = "0x2B")]
	[Token(Token = "0x6000BD3")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23BBF40", Offset = "0x23BB340", Length = "0x37")]
	[Token(Token = "0x6000BD9")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23BBFB0", Offset = "0x23BB3B0", Length = "0x36")]
	[Token(Token = "0x6000BD4")]
	public virtual bool IsNull(int record) { }

	[Address(RVA = "0x23BC160", Offset = "0x23BB560", Length = "0xF2")]
	[Token(Token = "0x6000BD5")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23BBFF0", Offset = "0x23BB3F0", Length = "0xCA")]
	[Token(Token = "0x6000BD6")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23BC0C0", Offset = "0x23BB4C0", Length = "0x9F")]
	[Token(Token = "0x6000BDB")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

