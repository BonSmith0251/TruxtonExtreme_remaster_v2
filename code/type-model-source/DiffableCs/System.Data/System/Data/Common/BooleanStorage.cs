namespace System.Data.Common;

[Token(Token = "0x20000C5")]
internal sealed class BooleanStorage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000438")]
	private Boolean[] _values; //Field offset: 0x50

	[Address(RVA = "0x23AB030", Offset = "0x23AA430", Length = "0xC5")]
	[Token(Token = "0x6000AD1")]
	internal BooleanStorage(DataColumn column) { }

	[Address(RVA = "0x23AA4E0", Offset = "0x23A98E0", Length = "0x2AD")]
	[Token(Token = "0x6000AD2")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23AA880", Offset = "0x23A9C80", Length = "0x99")]
	[Token(Token = "0x6000AD3")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23AA790", Offset = "0x23A9B90", Length = "0xE7")]
	[Token(Token = "0x6000AD4")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23AA920", Offset = "0x23A9D20", Length = "0x75")]
	[Token(Token = "0x6000ADB")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23AA9A0", Offset = "0x23A9DA0", Length = "0xEA")]
	[Token(Token = "0x6000AD5")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23AAA90", Offset = "0x23A9E90", Length = "0x5F")]
	[Token(Token = "0x6000ADA")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23AAC10", Offset = "0x23AA010", Length = "0x83")]
	[Token(Token = "0x6000AD6")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23AAAF0", Offset = "0x23A9EF0", Length = "0x112")]
	[Token(Token = "0x6000ADD")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23AACE0", Offset = "0x23AA0E0", Length = "0x77")]
	[Token(Token = "0x6000AD7")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23AACA0", Offset = "0x23AA0A0", Length = "0x37")]
	[Token(Token = "0x6000ADC")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23AAF00", Offset = "0x23AA300", Length = "0x12C")]
	[Token(Token = "0x6000AD8")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23AAD60", Offset = "0x23AA160", Length = "0xD7")]
	[Token(Token = "0x6000AD9")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23AAE40", Offset = "0x23AA240", Length = "0xBC")]
	[Token(Token = "0x6000ADE")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

