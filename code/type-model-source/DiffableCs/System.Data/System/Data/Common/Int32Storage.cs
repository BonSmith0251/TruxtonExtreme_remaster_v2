namespace System.Data.Common;

[Token(Token = "0x20000CF")]
internal sealed class Int32Storage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400047B")]
	private Int32[] _values; //Field offset: 0x50

	[Address(RVA = "0x23B7220", Offset = "0x23B6620", Length = "0xC8")]
	[Token(Token = "0x6000B73")]
	internal Int32Storage(DataColumn column) { }

	[Address(RVA = "0x23B6220", Offset = "0x23B5620", Length = "0x78C")]
	[Token(Token = "0x6000B74")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23B6AB0", Offset = "0x23B5EB0", Length = "0x76")]
	[Token(Token = "0x6000B75")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23B69D0", Offset = "0x23B5DD0", Length = "0xDA")]
	[Token(Token = "0x6000B76")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23B6B30", Offset = "0x23B5F30", Length = "0x74")]
	[Token(Token = "0x6000B7D")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23B6BB0", Offset = "0x23B5FB0", Length = "0xEA")]
	[Token(Token = "0x6000B77")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23B6CA0", Offset = "0x23B60A0", Length = "0x5F")]
	[Token(Token = "0x6000B7C")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23B6E00", Offset = "0x23B6200", Length = "0x81")]
	[Token(Token = "0x6000B78")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23B6D00", Offset = "0x23B6100", Length = "0xFD")]
	[Token(Token = "0x6000B7F")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23B6ED0", Offset = "0x23B62D0", Length = "0x74")]
	[Token(Token = "0x6000B79")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23B6E90", Offset = "0x23B6290", Length = "0x37")]
	[Token(Token = "0x6000B7E")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23B70F0", Offset = "0x23B64F0", Length = "0x12F")]
	[Token(Token = "0x6000B7A")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23B6F50", Offset = "0x23B6350", Length = "0xD7")]
	[Token(Token = "0x6000B7B")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23B7030", Offset = "0x23B6430", Length = "0xBC")]
	[Token(Token = "0x6000B80")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

