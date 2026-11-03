namespace System.Data.Common;

[Token(Token = "0x20000E7")]
internal sealed class UInt16Storage : DataStorage
{
	[Token(Token = "0x4000496")]
	private static readonly ushort s_defaultValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000497")]
	private UInt16[] _values; //Field offset: 0x50

	[Address(RVA = "0x23D7FB0", Offset = "0x23D73B0", Length = "0xE2")]
	[Token(Token = "0x6000CD4")]
	public UInt16Storage(DataColumn column) { }

	[Address(RVA = "0x23D6F60", Offset = "0x23D6360", Length = "0x770")]
	[Token(Token = "0x6000CD5")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23D77F0", Offset = "0x23D6BF0", Length = "0xB6")]
	[Token(Token = "0x6000CD6")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23D76F0", Offset = "0x23D6AF0", Length = "0xFF")]
	[Token(Token = "0x6000CD7")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23D78B0", Offset = "0x23D6CB0", Length = "0x75")]
	[Token(Token = "0x6000CDE")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23D7930", Offset = "0x23D6D30", Length = "0xDF")]
	[Token(Token = "0x6000CD8")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23D7A10", Offset = "0x23D6E10", Length = "0x60")]
	[Token(Token = "0x6000CDD")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23D7B70", Offset = "0x23D6F70", Length = "0x5F")]
	[Token(Token = "0x6000CD9")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23D7A70", Offset = "0x23D6E70", Length = "0xFB")]
	[Token(Token = "0x6000CE0")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23D7C10", Offset = "0x23D7010", Length = "0xB6")]
	[Token(Token = "0x6000CDA")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23D7BD0", Offset = "0x23D6FD0", Length = "0x37")]
	[Token(Token = "0x6000CDF")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23D7E70", Offset = "0x23D7270", Length = "0x131")]
	[Token(Token = "0x6000CDB")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23D7CD0", Offset = "0x23D70D0", Length = "0xD7")]
	[Token(Token = "0x6000CDC")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23D7DB0", Offset = "0x23D71B0", Length = "0xBC")]
	[Token(Token = "0x6000CE1")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

