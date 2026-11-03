namespace System.Data.Common;

[Token(Token = "0x20000CA")]
internal sealed class DateTimeOffsetStorage : DataStorage
{
	[Token(Token = "0x4000473")]
	private static readonly DateTimeOffset s_defaultValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000474")]
	private DateTimeOffset[] _values; //Field offset: 0x50

	[Address(RVA = "0x23B1600", Offset = "0x23B0A00", Length = "0x6B")]
	[Token(Token = "0x6000B39")]
	private static DateTimeOffsetStorage() { }

	[Address(RVA = "0x23B1670", Offset = "0x23B0A70", Length = "0x10E")]
	[Token(Token = "0x6000B2B")]
	internal DateTimeOffsetStorage(DataColumn column) { }

	[Address(RVA = "0x23B0660", Offset = "0x23AFA60", Length = "0x46D")]
	[Token(Token = "0x6000B2C")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23B0C70", Offset = "0x23B0070", Length = "0x1D1")]
	[Token(Token = "0x6000B2D")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23B0AD0", Offset = "0x23AFED0", Length = "0x19C")]
	[Token(Token = "0x6000B2E")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23B0E50", Offset = "0x23B0250", Length = "0x8C")]
	[Token(Token = "0x6000B35")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23B0EE0", Offset = "0x23B02E0", Length = "0x8E")]
	[Token(Token = "0x6000B2F")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23B0F70", Offset = "0x23B0370", Length = "0x75")]
	[Token(Token = "0x6000B34")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23B1120", Offset = "0x23B0520", Length = "0x8E")]
	[Token(Token = "0x6000B30")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23B0FF0", Offset = "0x23B03F0", Length = "0x122")]
	[Token(Token = "0x6000B37")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23B11F0", Offset = "0x23B05F0", Length = "0x137")]
	[Token(Token = "0x6000B31")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23B11B0", Offset = "0x23B05B0", Length = "0x37")]
	[Token(Token = "0x6000B36")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23B14D0", Offset = "0x23B08D0", Length = "0x122")]
	[Token(Token = "0x6000B32")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23B1330", Offset = "0x23B0730", Length = "0xD7")]
	[Token(Token = "0x6000B33")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23B1410", Offset = "0x23B0810", Length = "0xBC")]
	[Token(Token = "0x6000B38")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

