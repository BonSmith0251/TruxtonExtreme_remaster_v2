namespace System.Data.Common;

[Token(Token = "0x20000E2")]
internal sealed class SingleStorage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400048D")]
	private Single[] _values; //Field offset: 0x50

	[Address(RVA = "0x23C7830", Offset = "0x23C6C30", Length = "0xC8")]
	[Token(Token = "0x6000C91")]
	public SingleStorage(DataColumn column) { }

	[Address(RVA = "0x23C6950", Offset = "0x23C5D50", Length = "0x690")]
	[Token(Token = "0x6000C92")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23C70E0", Offset = "0x23C64E0", Length = "0x87")]
	[Token(Token = "0x6000C93")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23C7000", Offset = "0x23C6400", Length = "0xD9")]
	[Token(Token = "0x6000C94")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23C7170", Offset = "0x23C6570", Length = "0x76")]
	[Token(Token = "0x6000C9B")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23C71F0", Offset = "0x23C65F0", Length = "0xE0")]
	[Token(Token = "0x6000C95")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23C72E0", Offset = "0x23C66E0", Length = "0x61")]
	[Token(Token = "0x6000C9A")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23C7470", Offset = "0x23C6870", Length = "0x5F")]
	[Token(Token = "0x6000C96")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23C7350", Offset = "0x23C6750", Length = "0x11D")]
	[Token(Token = "0x6000C9D")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23C7510", Offset = "0x23C6910", Length = "0x5A")]
	[Token(Token = "0x6000C97")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23C74D0", Offset = "0x23C68D0", Length = "0x37")]
	[Token(Token = "0x6000C9C")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23C7710", Offset = "0x23C6B10", Length = "0x118")]
	[Token(Token = "0x6000C98")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23C7570", Offset = "0x23C6970", Length = "0xD7")]
	[Token(Token = "0x6000C99")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23C7650", Offset = "0x23C6A50", Length = "0xBC")]
	[Token(Token = "0x6000C9E")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

