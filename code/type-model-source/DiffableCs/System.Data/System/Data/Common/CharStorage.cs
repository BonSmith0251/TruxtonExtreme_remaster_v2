namespace System.Data.Common;

[Token(Token = "0x20000C7")]
internal sealed class CharStorage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400043A")]
	private Char[] _values; //Field offset: 0x50

	[Address(RVA = "0x23ACD80", Offset = "0x23AC180", Length = "0xC1")]
	[Token(Token = "0x6000AED")]
	internal CharStorage(DataColumn column) { }

	[Address(RVA = "0x23AC170", Offset = "0x23AB570", Length = "0x2F1")]
	[Token(Token = "0x6000AEE")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23AC570", Offset = "0x23AB970", Length = "0x93")]
	[Token(Token = "0x6000AEF")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23AC470", Offset = "0x23AB870", Length = "0xFE")]
	[Token(Token = "0x6000AF0")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23AC610", Offset = "0x23ABA10", Length = "0x75")]
	[Token(Token = "0x6000AF7")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23AC690", Offset = "0x23ABA90", Length = "0xEB")]
	[Token(Token = "0x6000AF1")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23AC780", Offset = "0x23ABB80", Length = "0x60")]
	[Token(Token = "0x6000AF6")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23AC8F0", Offset = "0x23ABCF0", Length = "0x83")]
	[Token(Token = "0x6000AF2")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23AC7E0", Offset = "0x23ABBE0", Length = "0x104")]
	[Token(Token = "0x6000AF9")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23AC9C0", Offset = "0x23ABDC0", Length = "0x77")]
	[Token(Token = "0x6000AF3")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23AC980", Offset = "0x23ABD80", Length = "0x37")]
	[Token(Token = "0x6000AF8")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23ACBE0", Offset = "0x23ABFE0", Length = "0x193")]
	[Token(Token = "0x6000AF4")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23ACA40", Offset = "0x23ABE40", Length = "0xD7")]
	[Token(Token = "0x6000AF5")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23ACB20", Offset = "0x23ABF20", Length = "0xBC")]
	[Token(Token = "0x6000AFA")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

