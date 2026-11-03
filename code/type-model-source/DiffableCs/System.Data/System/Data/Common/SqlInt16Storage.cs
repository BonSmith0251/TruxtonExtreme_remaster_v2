namespace System.Data.Common;

[Token(Token = "0x20000DB")]
internal sealed class SqlInt16Storage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000486")]
	private SqlInt16[] _values; //Field offset: 0x50

	[Address(RVA = "0x23CC220", Offset = "0x23CB620", Length = "0x126")]
	[Token(Token = "0x6000C26")]
	public SqlInt16Storage(DataColumn column) { }

	[Address(RVA = "0x23CABA0", Offset = "0x23C9FA0", Length = "0xCDC")]
	[Token(Token = "0x6000C27")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23CB950", Offset = "0x23CAD50", Length = "0x96")]
	[Token(Token = "0x6000C28")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23CB8A0", Offset = "0x23CACA0", Length = "0xAD")]
	[Token(Token = "0x6000C29")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23CB9F0", Offset = "0x23CADF0", Length = "0x1A5")]
	[Token(Token = "0x6000C31")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23CBBA0", Offset = "0x23CAFA0", Length = "0x6A")]
	[Token(Token = "0x6000C2A")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23CBC10", Offset = "0x23CB010", Length = "0x1D8")]
	[Token(Token = "0x6000C30")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23CBF00", Offset = "0x23CB300", Length = "0x39")]
	[Token(Token = "0x6000C2B")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23CBDF0", Offset = "0x23CB1F0", Length = "0x101")]
	[Token(Token = "0x6000C33")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23CBF80", Offset = "0x23CB380", Length = "0x69")]
	[Token(Token = "0x6000C2C")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23CBF40", Offset = "0x23CB340", Length = "0x37")]
	[Token(Token = "0x6000C32")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23CBFF0", Offset = "0x23CB3F0", Length = "0x73")]
	[Token(Token = "0x6000C2D")]
	public virtual bool IsNull(int record) { }

	[Address(RVA = "0x23CC1E0", Offset = "0x23CB5E0", Length = "0x3F")]
	[Token(Token = "0x6000C2E")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23CC070", Offset = "0x23CB470", Length = "0xCA")]
	[Token(Token = "0x6000C2F")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23CC140", Offset = "0x23CB540", Length = "0x9F")]
	[Token(Token = "0x6000C34")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

