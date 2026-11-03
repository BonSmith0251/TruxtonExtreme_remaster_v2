namespace System.Data.Common;

[Token(Token = "0x20000E8")]
internal sealed class UInt32Storage : DataStorage
{
	[Token(Token = "0x4000498")]
	private static readonly uint s_defaultValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000499")]
	private UInt32[] _values; //Field offset: 0x50

	[Address(RVA = "0x23D90E0", Offset = "0x23D84E0", Length = "0xE0")]
	[Token(Token = "0x6000CE2")]
	public UInt32Storage(DataColumn column) { }

	[Address(RVA = "0x23D80A0", Offset = "0x23D74A0", Length = "0x75C")]
	[Token(Token = "0x6000CE3")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23D8920", Offset = "0x23D7D20", Length = "0xC0")]
	[Token(Token = "0x6000CE4")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23D8820", Offset = "0x23D7C20", Length = "0xFA")]
	[Token(Token = "0x6000CE5")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23D89F0", Offset = "0x23D7DF0", Length = "0x74")]
	[Token(Token = "0x6000CEC")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23D8A70", Offset = "0x23D7E70", Length = "0xDE")]
	[Token(Token = "0x6000CE6")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23D8B50", Offset = "0x23D7F50", Length = "0x5F")]
	[Token(Token = "0x6000CEB")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23D8CB0", Offset = "0x23D80B0", Length = "0x5D")]
	[Token(Token = "0x6000CE7")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23D8BB0", Offset = "0x23D7FB0", Length = "0xF9")]
	[Token(Token = "0x6000CEE")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23D8D50", Offset = "0x23D8150", Length = "0xB2")]
	[Token(Token = "0x6000CE8")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23D8D10", Offset = "0x23D8110", Length = "0x37")]
	[Token(Token = "0x6000CED")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23D8FB0", Offset = "0x23D83B0", Length = "0x12E")]
	[Token(Token = "0x6000CE9")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23D8E10", Offset = "0x23D8210", Length = "0xD7")]
	[Token(Token = "0x6000CEA")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23D8EF0", Offset = "0x23D82F0", Length = "0xBC")]
	[Token(Token = "0x6000CEF")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

