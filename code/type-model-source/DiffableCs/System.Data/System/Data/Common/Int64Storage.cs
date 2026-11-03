namespace System.Data.Common;

[Token(Token = "0x20000D0")]
internal sealed class Int64Storage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400047C")]
	private Int64[] _values; //Field offset: 0x50

	[Address(RVA = "0x23B8300", Offset = "0x23B7700", Length = "0xC9")]
	[Token(Token = "0x6000B81")]
	internal Int64Storage(DataColumn column) { }

	[Address(RVA = "0x23B72F0", Offset = "0x23B66F0", Length = "0x784")]
	[Token(Token = "0x6000B82")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23B7B80", Offset = "0x23B6F80", Length = "0x7C")]
	[Token(Token = "0x6000B83")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23B7AA0", Offset = "0x23B6EA0", Length = "0xDF")]
	[Token(Token = "0x6000B84")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23B7C00", Offset = "0x23B7000", Length = "0x75")]
	[Token(Token = "0x6000B8B")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23B7C80", Offset = "0x23B7080", Length = "0xEB")]
	[Token(Token = "0x6000B85")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23B7D70", Offset = "0x23B7170", Length = "0x60")]
	[Token(Token = "0x6000B8A")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23B7ED0", Offset = "0x23B72D0", Length = "0x81")]
	[Token(Token = "0x6000B86")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23B7DD0", Offset = "0x23B71D0", Length = "0xFD")]
	[Token(Token = "0x6000B8D")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23B7FA0", Offset = "0x23B73A0", Length = "0x71")]
	[Token(Token = "0x6000B87")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23B7F60", Offset = "0x23B7360", Length = "0x37")]
	[Token(Token = "0x6000B8C")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23B81C0", Offset = "0x23B75C0", Length = "0x131")]
	[Token(Token = "0x6000B88")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23B8020", Offset = "0x23B7420", Length = "0xD7")]
	[Token(Token = "0x6000B89")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23B8100", Offset = "0x23B7500", Length = "0xBC")]
	[Token(Token = "0x6000B8E")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

