namespace System.Data.Common;

[Token(Token = "0x20000D4")]
internal sealed class SqlByteStorage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400047F")]
	private SqlByte[] _values; //Field offset: 0x50

	[Address(RVA = "0x23BB760", Offset = "0x23BAB60", Length = "0x12F")]
	[Token(Token = "0x6000BBF")]
	public SqlByteStorage(DataColumn column) { }

	[Address(RVA = "0x23BA0D0", Offset = "0x23B94D0", Length = "0xCE8")]
	[Token(Token = "0x6000BC0")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23BAE90", Offset = "0x23BA290", Length = "0x98")]
	[Token(Token = "0x6000BC1")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23BADE0", Offset = "0x23BA1E0", Length = "0xAE")]
	[Token(Token = "0x6000BC2")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23BAF30", Offset = "0x23BA330", Length = "0x1AF")]
	[Token(Token = "0x6000BCA")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23BB0E0", Offset = "0x23BA4E0", Length = "0x6B")]
	[Token(Token = "0x6000BC3")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23BB150", Offset = "0x23BA550", Length = "0x1CF")]
	[Token(Token = "0x6000BC9")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23BB430", Offset = "0x23BA830", Length = "0x3B")]
	[Token(Token = "0x6000BC4")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23BB320", Offset = "0x23BA720", Length = "0x103")]
	[Token(Token = "0x6000BCC")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23BB4B0", Offset = "0x23BA8B0", Length = "0x6B")]
	[Token(Token = "0x6000BC5")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23BB470", Offset = "0x23BA870", Length = "0x37")]
	[Token(Token = "0x6000BCB")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23BB520", Offset = "0x23BA920", Length = "0x73")]
	[Token(Token = "0x6000BC6")]
	public virtual bool IsNull(int record) { }

	[Address(RVA = "0x23BB710", Offset = "0x23BAB10", Length = "0x40")]
	[Token(Token = "0x6000BC7")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23BB5A0", Offset = "0x23BA9A0", Length = "0xCA")]
	[Token(Token = "0x6000BC8")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23BB670", Offset = "0x23BAA70", Length = "0x9F")]
	[Token(Token = "0x6000BCD")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

