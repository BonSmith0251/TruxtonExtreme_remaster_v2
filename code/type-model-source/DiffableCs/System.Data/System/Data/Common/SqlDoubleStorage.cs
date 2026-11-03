namespace System.Data.Common;

[Token(Token = "0x20000D9")]
internal sealed class SqlDoubleStorage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000484")]
	private SqlDouble[] _values; //Field offset: 0x50

	[Address(RVA = "0x23C9E10", Offset = "0x23C9210", Length = "0x136")]
	[Token(Token = "0x6000C08")]
	public SqlDoubleStorage(DataColumn column) { }

	[Address(RVA = "0x23C8750", Offset = "0x23C7B50", Length = "0x9C")]
	[Token(Token = "0x6000C09")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23C94A0", Offset = "0x23C88A0", Length = "0xB4")]
	[Token(Token = "0x6000C0A")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23C93E0", Offset = "0x23C87E0", Length = "0xBC")]
	[Token(Token = "0x6000C0B")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23C9560", Offset = "0x23C8960", Length = "0x1A5")]
	[Token(Token = "0x6000C13")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23C9710", Offset = "0x23C8B10", Length = "0x74")]
	[Token(Token = "0x6000C0C")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23C9790", Offset = "0x23C8B90", Length = "0x1EE")]
	[Token(Token = "0x6000C12")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23C9AB0", Offset = "0x23C8EB0", Length = "0x47")]
	[Token(Token = "0x6000C0D")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23C9980", Offset = "0x23C8D80", Length = "0x127")]
	[Token(Token = "0x6000C15")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23C9B40", Offset = "0x23C8F40", Length = "0x71")]
	[Token(Token = "0x6000C0E")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23C9B00", Offset = "0x23C8F00", Length = "0x37")]
	[Token(Token = "0x6000C14")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23C9BC0", Offset = "0x23C8FC0", Length = "0x76")]
	[Token(Token = "0x6000C0F")]
	public virtual bool IsNull(int record) { }

	[Address(RVA = "0x23C9DB0", Offset = "0x23C91B0", Length = "0x55")]
	[Token(Token = "0x6000C10")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23C9C40", Offset = "0x23C9040", Length = "0xCA")]
	[Token(Token = "0x6000C11")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23C9D10", Offset = "0x23C9110", Length = "0x9F")]
	[Token(Token = "0x6000C16")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

