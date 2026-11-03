namespace System.Data.Common;

[Token(Token = "0x20000D6")]
internal sealed class SqlCharsStorage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000481")]
	private SqlChars[] _values; //Field offset: 0x50

	[Address(RVA = "0x23BCC60", Offset = "0x23BC060", Length = "0xE1")]
	[Token(Token = "0x6000BDC")]
	public SqlCharsStorage(DataColumn column) { }

	[Address(RVA = "0x23BC350", Offset = "0x23BB750", Length = "0x178")]
	[Token(Token = "0x6000BDD")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000BDE")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000BDF")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23BC4D0", Offset = "0x23BB8D0", Length = "0x1AF")]
	[Token(Token = "0x6000BE6")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23BC680", Offset = "0x23BBA80", Length = "0x20A")]
	[Token(Token = "0x6000BE5")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23BBEF0", Offset = "0x23BB2F0", Length = "0x48")]
	[Token(Token = "0x6000BE0")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23BC890", Offset = "0x23BBC90", Length = "0x11A")]
	[Token(Token = "0x6000BE8")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23BBF80", Offset = "0x23BB380", Length = "0x2B")]
	[Token(Token = "0x6000BE1")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23BC9B0", Offset = "0x23BBDB0", Length = "0x37")]
	[Token(Token = "0x6000BE7")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23BBFB0", Offset = "0x23BB3B0", Length = "0x36")]
	[Token(Token = "0x6000BE2")]
	public virtual bool IsNull(int record) { }

	[Address(RVA = "0x23BCB60", Offset = "0x23BBF60", Length = "0xF2")]
	[Token(Token = "0x6000BE3")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23BC9F0", Offset = "0x23BBDF0", Length = "0xCA")]
	[Token(Token = "0x6000BE4")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23BCAC0", Offset = "0x23BBEC0", Length = "0x9F")]
	[Token(Token = "0x6000BE9")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

