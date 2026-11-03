namespace System.Data.Common;

[Token(Token = "0x20000E6")]
internal sealed class TimeSpanStorage : DataStorage
{
	[Token(Token = "0x4000494")]
	private static readonly TimeSpan s_defaultValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000495")]
	private TimeSpan[] _values; //Field offset: 0x50

	[Address(RVA = "0x23D6CA0", Offset = "0x23D60A0", Length = "0x6B")]
	[Token(Token = "0x6000CD3")]
	private static TimeSpanStorage() { }

	[Address(RVA = "0x23D6D10", Offset = "0x23D6110", Length = "0x10E")]
	[Token(Token = "0x6000CC4")]
	public TimeSpanStorage(DataColumn column) { }

	[Address(RVA = "0x23D5570", Offset = "0x23D4970", Length = "0x8C")]
	[Token(Token = "0x6000CC5")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23D6270", Offset = "0x23D5670", Length = "0x16F")]
	[Token(Token = "0x6000CC6")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23D60D0", Offset = "0x23D54D0", Length = "0x193")]
	[Token(Token = "0x6000CC7")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23D63E0", Offset = "0x23D57E0", Length = "0x81")]
	[Token(Token = "0x6000CCF")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23D6470", Offset = "0x23D5870", Length = "0x1D4")]
	[Token(Token = "0x6000CC8")]
	private static TimeSpan ConvertToTimeSpan(object value) { }

	[Address(RVA = "0x23D6650", Offset = "0x23D5A50", Length = "0xA0")]
	[Token(Token = "0x6000CC9")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23D66F0", Offset = "0x23D5AF0", Length = "0x6C")]
	[Token(Token = "0x6000CCE")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23D6870", Offset = "0x23D5C70", Length = "0x5D")]
	[Token(Token = "0x6000CCA")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23D6760", Offset = "0x23D5B60", Length = "0x103")]
	[Token(Token = "0x6000CD1")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23D6910", Offset = "0x23D5D10", Length = "0xFF")]
	[Token(Token = "0x6000CCB")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23D68D0", Offset = "0x23D5CD0", Length = "0x37")]
	[Token(Token = "0x6000CD0")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23D6BB0", Offset = "0x23D5FB0", Length = "0xE0")]
	[Token(Token = "0x6000CCC")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23D6A10", Offset = "0x23D5E10", Length = "0xD7")]
	[Token(Token = "0x6000CCD")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23D6AF0", Offset = "0x23D5EF0", Length = "0xBC")]
	[Token(Token = "0x6000CD2")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

