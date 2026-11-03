namespace System.Data.Common;

[Token(Token = "0x20000D1")]
internal sealed class SByteStorage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400047D")]
	private SByte[] _values; //Field offset: 0x50

	[Address(RVA = "0x23B9360", Offset = "0x23B8760", Length = "0xC5")]
	[Token(Token = "0x6000B8F")]
	public SByteStorage(DataColumn column) { }

	[Address(RVA = "0x23B83D0", Offset = "0x23B77D0", Length = "0x724")]
	[Token(Token = "0x6000B90")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23B8C00", Offset = "0x23B8000", Length = "0xBE")]
	[Token(Token = "0x6000B91")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23B8B20", Offset = "0x23B7F20", Length = "0xD0")]
	[Token(Token = "0x6000B92")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23B8CC0", Offset = "0x23B80C0", Length = "0x75")]
	[Token(Token = "0x6000B99")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23B8D40", Offset = "0x23B8140", Length = "0xEA")]
	[Token(Token = "0x6000B93")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23B8E30", Offset = "0x23B8230", Length = "0x5F")]
	[Token(Token = "0x6000B98")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23ABC80", Offset = "0x23AB080", Length = "0x82")]
	[Token(Token = "0x6000B94")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23B8E90", Offset = "0x23B8290", Length = "0x103")]
	[Token(Token = "0x6000B9B")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23B8FE0", Offset = "0x23B83E0", Length = "0xA4")]
	[Token(Token = "0x6000B95")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23B8FA0", Offset = "0x23B83A0", Length = "0x37")]
	[Token(Token = "0x6000B9A")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23B9230", Offset = "0x23B8630", Length = "0x12C")]
	[Token(Token = "0x6000B96")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23B9090", Offset = "0x23B8490", Length = "0xD7")]
	[Token(Token = "0x6000B97")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23B9170", Offset = "0x23B8570", Length = "0xBC")]
	[Token(Token = "0x6000B9C")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

