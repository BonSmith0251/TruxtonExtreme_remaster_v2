namespace System.Data.Common;

[Token(Token = "0x20000CE")]
internal sealed class Int16Storage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400047A")]
	private Int16[] _values; //Field offset: 0x50

	[Address(RVA = "0x23B6150", Offset = "0x23B5550", Length = "0xC1")]
	[Token(Token = "0x6000B65")]
	internal Int16Storage(DataColumn column) { }

	[Address(RVA = "0x23B51D0", Offset = "0x23B45D0", Length = "0x7A8")]
	[Token(Token = "0x6000B66")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23B5A80", Offset = "0x23B4E80", Length = "0x69")]
	[Token(Token = "0x6000B67")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23B59A0", Offset = "0x23B4DA0", Length = "0xDF")]
	[Token(Token = "0x6000B68")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23B5AF0", Offset = "0x23B4EF0", Length = "0x75")]
	[Token(Token = "0x6000B6F")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23B5B70", Offset = "0x23B4F70", Length = "0xEB")]
	[Token(Token = "0x6000B69")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23B5C60", Offset = "0x23B5060", Length = "0x60")]
	[Token(Token = "0x6000B6E")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23AC8F0", Offset = "0x23ABCF0", Length = "0x83")]
	[Token(Token = "0x6000B6A")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23B5CC0", Offset = "0x23B50C0", Length = "0xFF")]
	[Token(Token = "0x6000B71")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23B5E00", Offset = "0x23B5200", Length = "0x77")]
	[Token(Token = "0x6000B6B")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23B5DC0", Offset = "0x23B51C0", Length = "0x37")]
	[Token(Token = "0x6000B70")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23B6020", Offset = "0x23B5420", Length = "0x12F")]
	[Token(Token = "0x6000B6C")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23B5E80", Offset = "0x23B5280", Length = "0xD7")]
	[Token(Token = "0x6000B6D")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23B5F60", Offset = "0x23B5360", Length = "0xBC")]
	[Token(Token = "0x6000B72")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

