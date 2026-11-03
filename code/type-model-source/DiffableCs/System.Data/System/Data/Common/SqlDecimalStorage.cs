namespace System.Data.Common;

[Token(Token = "0x20000D8")]
internal sealed class SqlDecimalStorage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000483")]
	private SqlDecimal[] _values; //Field offset: 0x50

	[Address(RVA = "0x23C6570", Offset = "0x23C5970", Length = "0x150")]
	[Token(Token = "0x6000BF9")]
	public SqlDecimalStorage(DataColumn column) { }

	[Address(RVA = "0x23C4DA0", Offset = "0x23C41A0", Length = "0xD68")]
	[Token(Token = "0x6000BFA")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23C5C00", Offset = "0x23C5000", Length = "0xBD")]
	[Token(Token = "0x6000BFB")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23C5B30", Offset = "0x23C4F30", Length = "0xC4")]
	[Token(Token = "0x6000BFC")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23C5CC0", Offset = "0x23C50C0", Length = "0x1AF")]
	[Token(Token = "0x6000C04")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23C5E70", Offset = "0x23C5270", Length = "0x7B")]
	[Token(Token = "0x6000BFD")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23C5EF0", Offset = "0x23C52F0", Length = "0x1E9")]
	[Token(Token = "0x6000C03")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23C6210", Offset = "0x23C5610", Length = "0x4D")]
	[Token(Token = "0x6000BFE")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23C60E0", Offset = "0x23C54E0", Length = "0x127")]
	[Token(Token = "0x6000C06")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23C62A0", Offset = "0x23C56A0", Length = "0x7A")]
	[Token(Token = "0x6000BFF")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23C6260", Offset = "0x23C5660", Length = "0x37")]
	[Token(Token = "0x6000C05")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23C6320", Offset = "0x23C5720", Length = "0x77")]
	[Token(Token = "0x6000C00")]
	public virtual bool IsNull(int record) { }

	[Address(RVA = "0x23C6510", Offset = "0x23C5910", Length = "0x57")]
	[Token(Token = "0x6000C01")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23C63A0", Offset = "0x23C57A0", Length = "0xCA")]
	[Token(Token = "0x6000C02")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23C6470", Offset = "0x23C5870", Length = "0x9F")]
	[Token(Token = "0x6000C07")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

