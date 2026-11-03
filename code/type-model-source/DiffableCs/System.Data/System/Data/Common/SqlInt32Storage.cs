namespace System.Data.Common;

[Token(Token = "0x20000DC")]
internal sealed class SqlInt32Storage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000487")]
	private SqlInt32[] _values; //Field offset: 0x50

	[Address(RVA = "0x23CD9F0", Offset = "0x23CCDF0", Length = "0x128")]
	[Token(Token = "0x6000C35")]
	public SqlInt32Storage(DataColumn column) { }

	[Address(RVA = "0x23CC350", Offset = "0x23CB750", Length = "0xCE8")]
	[Token(Token = "0x6000C36")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23CD110", Offset = "0x23CC510", Length = "0x98")]
	[Token(Token = "0x6000C37")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23CD060", Offset = "0x23CC460", Length = "0xAE")]
	[Token(Token = "0x6000C38")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23CD1B0", Offset = "0x23CC5B0", Length = "0x1A5")]
	[Token(Token = "0x6000C40")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23CD360", Offset = "0x23CC760", Length = "0x6B")]
	[Token(Token = "0x6000C39")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23CD3D0", Offset = "0x23CC7D0", Length = "0x1DB")]
	[Token(Token = "0x6000C3F")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23CD6C0", Offset = "0x23CCAC0", Length = "0x39")]
	[Token(Token = "0x6000C3A")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23CD5B0", Offset = "0x23CC9B0", Length = "0x103")]
	[Token(Token = "0x6000C42")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23CD740", Offset = "0x23CCB40", Length = "0x6B")]
	[Token(Token = "0x6000C3B")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23CD700", Offset = "0x23CCB00", Length = "0x37")]
	[Token(Token = "0x6000C41")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23CD7B0", Offset = "0x23CCBB0", Length = "0x73")]
	[Token(Token = "0x6000C3C")]
	public virtual bool IsNull(int record) { }

	[Address(RVA = "0x23CD9A0", Offset = "0x23CCDA0", Length = "0x40")]
	[Token(Token = "0x6000C3D")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23CD830", Offset = "0x23CCC30", Length = "0xCA")]
	[Token(Token = "0x6000C3E")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23CD900", Offset = "0x23CCD00", Length = "0x9F")]
	[Token(Token = "0x6000C43")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

