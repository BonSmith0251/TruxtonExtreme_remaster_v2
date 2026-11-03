namespace System.Data.Common;

[Token(Token = "0x20000E9")]
internal sealed class UInt64Storage : DataStorage
{
	[Token(Token = "0x400049A")]
	private static readonly ulong s_defaultValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400049B")]
	private UInt64[] _values; //Field offset: 0x50

	[Address(RVA = "0x23DA2F0", Offset = "0x23D96F0", Length = "0xE2")]
	[Token(Token = "0x6000CF0")]
	public UInt64Storage(DataColumn column) { }

	[Address(RVA = "0x23D91C0", Offset = "0x23D85C0", Length = "0x7E8")]
	[Token(Token = "0x6000CF1")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23D9AD0", Offset = "0x23D8ED0", Length = "0x115")]
	[Token(Token = "0x6000CF2")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23D99D0", Offset = "0x23D8DD0", Length = "0xFF")]
	[Token(Token = "0x6000CF3")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23D9BF0", Offset = "0x23D8FF0", Length = "0x75")]
	[Token(Token = "0x6000CFA")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23D9C70", Offset = "0x23D9070", Length = "0xDF")]
	[Token(Token = "0x6000CF4")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23D9D50", Offset = "0x23D9150", Length = "0x60")]
	[Token(Token = "0x6000CF9")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23D9EB0", Offset = "0x23D92B0", Length = "0x5D")]
	[Token(Token = "0x6000CF5")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23D9DB0", Offset = "0x23D91B0", Length = "0xF9")]
	[Token(Token = "0x6000CFC")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23D9F50", Offset = "0x23D9350", Length = "0xB8")]
	[Token(Token = "0x6000CF6")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23D9F10", Offset = "0x23D9310", Length = "0x37")]
	[Token(Token = "0x6000CFB")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23DA1B0", Offset = "0x23D95B0", Length = "0x131")]
	[Token(Token = "0x6000CF7")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23DA010", Offset = "0x23D9410", Length = "0xD7")]
	[Token(Token = "0x6000CF8")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23DA0F0", Offset = "0x23D94F0", Length = "0xBC")]
	[Token(Token = "0x6000CFD")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

