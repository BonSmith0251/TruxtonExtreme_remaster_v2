namespace System.Data.Common;

[Token(Token = "0x20000CC")]
internal sealed class DecimalStorage : DataStorage
{
	[Token(Token = "0x4000477")]
	private static readonly decimal s_defaultValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000478")]
	private Decimal[] _values; //Field offset: 0x50

	[Address(RVA = "0x23B40D0", Offset = "0x23B34D0", Length = "0xF9")]
	[Token(Token = "0x6000B49")]
	internal DecimalStorage(DataColumn column) { }

	[Address(RVA = "0x23B2C80", Offset = "0x23B2080", Length = "0xA4")]
	[Token(Token = "0x6000B4A")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23B37E0", Offset = "0x23B2BE0", Length = "0x1A3")]
	[Token(Token = "0x6000B4B")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23B3640", Offset = "0x23B2A40", Length = "0x195")]
	[Token(Token = "0x6000B4C")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23B3990", Offset = "0x23B2D90", Length = "0x8C")]
	[Token(Token = "0x6000B53")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23B3A20", Offset = "0x23B2E20", Length = "0x101")]
	[Token(Token = "0x6000B4D")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23B3B30", Offset = "0x23B2F30", Length = "0x75")]
	[Token(Token = "0x6000B52")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23B1120", Offset = "0x23B0520", Length = "0x8E")]
	[Token(Token = "0x6000B4E")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23B3BB0", Offset = "0x23B2FB0", Length = "0x122")]
	[Token(Token = "0x6000B55")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23B3D20", Offset = "0x23B3120", Length = "0x9D")]
	[Token(Token = "0x6000B4F")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23B3CE0", Offset = "0x23B30E0", Length = "0x37")]
	[Token(Token = "0x6000B54")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23B3F60", Offset = "0x23B3360", Length = "0x168")]
	[Token(Token = "0x6000B50")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23B3DC0", Offset = "0x23B31C0", Length = "0xD7")]
	[Token(Token = "0x6000B51")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23B3EA0", Offset = "0x23B32A0", Length = "0xBC")]
	[Token(Token = "0x6000B56")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

