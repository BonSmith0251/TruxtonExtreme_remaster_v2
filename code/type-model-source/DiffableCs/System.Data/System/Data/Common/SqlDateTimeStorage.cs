namespace System.Data.Common;

[Token(Token = "0x20000D7")]
internal sealed class SqlDateTimeStorage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000482")]
	private SqlDateTime[] _values; //Field offset: 0x50

	[Address(RVA = "0x23C4C40", Offset = "0x23C4040", Length = "0x154")]
	[Token(Token = "0x6000BEA")]
	public SqlDateTimeStorage(DataColumn column) { }

	[Address(RVA = "0x23C3C90", Offset = "0x23C3090", Length = "0x54A")]
	[Token(Token = "0x6000BEB")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23C42B0", Offset = "0x23C36B0", Length = "0xC1")]
	[Token(Token = "0x6000BEC")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23C41E0", Offset = "0x23C35E0", Length = "0xC6")]
	[Token(Token = "0x6000BED")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23C4380", Offset = "0x23C3780", Length = "0x1AF")]
	[Token(Token = "0x6000BF5")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23C4530", Offset = "0x23C3930", Length = "0x7D")]
	[Token(Token = "0x6000BEE")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23C45B0", Offset = "0x23C39B0", Length = "0x1F2")]
	[Token(Token = "0x6000BF4")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23C48E0", Offset = "0x23C3CE0", Length = "0x4F")]
	[Token(Token = "0x6000BEF")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23C47B0", Offset = "0x23C3BB0", Length = "0x12B")]
	[Token(Token = "0x6000BF7")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23C4970", Offset = "0x23C3D70", Length = "0x7C")]
	[Token(Token = "0x6000BF0")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23C4930", Offset = "0x23C3D30", Length = "0x37")]
	[Token(Token = "0x6000BF6")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23C49F0", Offset = "0x23C3DF0", Length = "0x77")]
	[Token(Token = "0x6000BF1")]
	public virtual bool IsNull(int record) { }

	[Address(RVA = "0x23C4BE0", Offset = "0x23C3FE0", Length = "0x59")]
	[Token(Token = "0x6000BF2")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23C4A70", Offset = "0x23C3E70", Length = "0xCA")]
	[Token(Token = "0x6000BF3")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23C4B40", Offset = "0x23C3F40", Length = "0x9F")]
	[Token(Token = "0x6000BF8")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

