namespace System.Data.Common;

[Token(Token = "0x20000CB")]
internal sealed class DateTimeStorage : DataStorage
{
	[Token(Token = "0x4000475")]
	private static readonly DateTime s_defaultValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000476")]
	private DateTime[] _values; //Field offset: 0x50

	[Address(RVA = "0x23B2B00", Offset = "0x23B1F00", Length = "0x6C")]
	[Token(Token = "0x6000B48")]
	private static DateTimeStorage() { }

	[Address(RVA = "0x23B2B70", Offset = "0x23B1F70", Length = "0x10E")]
	[Token(Token = "0x6000B3A")]
	internal DateTimeStorage(DataColumn column) { }

	[Address(RVA = "0x23B1780", Offset = "0x23B0B80", Length = "0x42C")]
	[Token(Token = "0x6000B3B")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23B1D30", Offset = "0x23B1130", Length = "0x16F")]
	[Token(Token = "0x6000B3C")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23B1BB0", Offset = "0x23B0FB0", Length = "0x176")]
	[Token(Token = "0x6000B3D")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23B1EA0", Offset = "0x23B12A0", Length = "0xE0")]
	[Token(Token = "0x6000B44")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23B1F90", Offset = "0x23B1390", Length = "0xF7")]
	[Token(Token = "0x6000B3E")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23B2090", Offset = "0x23B1490", Length = "0xA7")]
	[Token(Token = "0x6000B43")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23B22B0", Offset = "0x23B16B0", Length = "0x81")]
	[Token(Token = "0x6000B3F")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23B2140", Offset = "0x23B1540", Length = "0x168")]
	[Token(Token = "0x6000B46")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23B2380", Offset = "0x23B1780", Length = "0x10E")]
	[Token(Token = "0x6000B40")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23B2340", Offset = "0x23B1740", Length = "0x37")]
	[Token(Token = "0x6000B45")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23B27B0", Offset = "0x23B1BB0", Length = "0x347")]
	[Token(Token = "0x6000B41")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23B2490", Offset = "0x23B1890", Length = "0xD7")]
	[Token(Token = "0x6000B42")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23B2570", Offset = "0x23B1970", Length = "0x23E")]
	[Token(Token = "0x6000B47")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

