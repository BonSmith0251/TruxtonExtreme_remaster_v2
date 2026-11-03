namespace System.Data.Common;

[Token(Token = "0x20000DA")]
internal sealed class SqlGuidStorage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000485")]
	private SqlGuid[] _values; //Field offset: 0x50

	[Address(RVA = "0x23CAA70", Offset = "0x23C9E70", Length = "0x128")]
	[Token(Token = "0x6000C17")]
	public SqlGuidStorage(DataColumn column) { }

	[Address(RVA = "0x23C9F50", Offset = "0x23C9350", Length = "0x1B7")]
	[Token(Token = "0x6000C18")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23CA1C0", Offset = "0x23C95C0", Length = "0x98")]
	[Token(Token = "0x6000C19")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23CA110", Offset = "0x23C9510", Length = "0xAE")]
	[Token(Token = "0x6000C1A")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23CA260", Offset = "0x23C9660", Length = "0x1A5")]
	[Token(Token = "0x6000C22")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23CA410", Offset = "0x23C9810", Length = "0x6B")]
	[Token(Token = "0x6000C1B")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23CA480", Offset = "0x23C9880", Length = "0x1DB")]
	[Token(Token = "0x6000C21")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23B9C60", Offset = "0x23B9060", Length = "0x4A")]
	[Token(Token = "0x6000C1C")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23CA660", Offset = "0x23C9A60", Length = "0x11A")]
	[Token(Token = "0x6000C24")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23CA7C0", Offset = "0x23C9BC0", Length = "0x6B")]
	[Token(Token = "0x6000C1D")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23CA780", Offset = "0x23C9B80", Length = "0x37")]
	[Token(Token = "0x6000C23")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23CA830", Offset = "0x23C9C30", Length = "0x73")]
	[Token(Token = "0x6000C1E")]
	public virtual bool IsNull(int record) { }

	[Address(RVA = "0x23CAA20", Offset = "0x23C9E20", Length = "0x4E")]
	[Token(Token = "0x6000C1F")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23CA8B0", Offset = "0x23C9CB0", Length = "0xCA")]
	[Token(Token = "0x6000C20")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23CA980", Offset = "0x23C9D80", Length = "0x9F")]
	[Token(Token = "0x6000C25")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

