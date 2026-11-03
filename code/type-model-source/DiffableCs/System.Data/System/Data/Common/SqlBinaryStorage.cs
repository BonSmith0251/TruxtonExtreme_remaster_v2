namespace System.Data.Common;

[Token(Token = "0x20000D3")]
internal sealed class SqlBinaryStorage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400047E")]
	private SqlBinary[] _values; //Field offset: 0x50

	[Address(RVA = "0x23B9FA0", Offset = "0x23B93A0", Length = "0x12B")]
	[Token(Token = "0x6000BB0")]
	public SqlBinaryStorage(DataColumn column) { }

	[Address(RVA = "0x23B9430", Offset = "0x23B8830", Length = "0x1B7")]
	[Token(Token = "0x6000BB1")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23B96A0", Offset = "0x23B8AA0", Length = "0x98")]
	[Token(Token = "0x6000BB2")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23B95F0", Offset = "0x23B89F0", Length = "0xAE")]
	[Token(Token = "0x6000BB3")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23B9740", Offset = "0x23B8B40", Length = "0x1AF")]
	[Token(Token = "0x6000BBB")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23B98F0", Offset = "0x23B8CF0", Length = "0x6B")]
	[Token(Token = "0x6000BB4")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23B9960", Offset = "0x23B8D60", Length = "0x1DB")]
	[Token(Token = "0x6000BBA")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23B9C60", Offset = "0x23B9060", Length = "0x4A")]
	[Token(Token = "0x6000BB5")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23B9B40", Offset = "0x23B8F40", Length = "0x11A")]
	[Token(Token = "0x6000BBD")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23B9CF0", Offset = "0x23B90F0", Length = "0x6B")]
	[Token(Token = "0x6000BB6")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23B9CB0", Offset = "0x23B90B0", Length = "0x37")]
	[Token(Token = "0x6000BBC")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23B9D60", Offset = "0x23B9160", Length = "0x73")]
	[Token(Token = "0x6000BB7")]
	public virtual bool IsNull(int record) { }

	[Address(RVA = "0x23B9F50", Offset = "0x23B9350", Length = "0x4E")]
	[Token(Token = "0x6000BB8")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23B9DE0", Offset = "0x23B91E0", Length = "0xCA")]
	[Token(Token = "0x6000BB9")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23B9EB0", Offset = "0x23B92B0", Length = "0x9F")]
	[Token(Token = "0x6000BBE")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

