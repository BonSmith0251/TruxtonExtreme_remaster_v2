namespace System.Data.Common;

[Token(Token = "0x20000C6")]
internal sealed class ByteStorage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000439")]
	private Byte[] _values; //Field offset: 0x50

	[Address(RVA = "0x23AC0A0", Offset = "0x23AB4A0", Length = "0xC5")]
	[Token(Token = "0x6000ADF")]
	internal ByteStorage(DataColumn column) { }

	[Address(RVA = "0x23AB100", Offset = "0x23AA500", Length = "0x714")]
	[Token(Token = "0x6000AE0")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23AB920", Offset = "0x23AAD20", Length = "0x79")]
	[Token(Token = "0x6000AE1")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23AB840", Offset = "0x23AAC40", Length = "0xD0")]
	[Token(Token = "0x6000AE2")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23AB9A0", Offset = "0x23AADA0", Length = "0x75")]
	[Token(Token = "0x6000AE9")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23ABA20", Offset = "0x23AAE20", Length = "0xEA")]
	[Token(Token = "0x6000AE3")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23ABB10", Offset = "0x23AAF10", Length = "0x5F")]
	[Token(Token = "0x6000AE8")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23ABC80", Offset = "0x23AB080", Length = "0x82")]
	[Token(Token = "0x6000AE4")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23ABB70", Offset = "0x23AAF70", Length = "0x103")]
	[Token(Token = "0x6000AEB")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23ABD50", Offset = "0x23AB150", Length = "0x75")]
	[Token(Token = "0x6000AE5")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23ABD10", Offset = "0x23AB110", Length = "0x37")]
	[Token(Token = "0x6000AEA")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23ABF70", Offset = "0x23AB370", Length = "0x12C")]
	[Token(Token = "0x6000AE6")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23ABDD0", Offset = "0x23AB1D0", Length = "0xD7")]
	[Token(Token = "0x6000AE7")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23ABEB0", Offset = "0x23AB2B0", Length = "0xBC")]
	[Token(Token = "0x6000AEC")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

