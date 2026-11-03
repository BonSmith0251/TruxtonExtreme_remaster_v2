namespace System.Data.Common;

[Token(Token = "0x20000CD")]
internal sealed class DoubleStorage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000479")]
	private Double[] _values; //Field offset: 0x50

	[Address(RVA = "0x23B5100", Offset = "0x23B4500", Length = "0xC9")]
	[Token(Token = "0x6000B57")]
	internal DoubleStorage(DataColumn column) { }

	[Address(RVA = "0x23B41D0", Offset = "0x23B35D0", Length = "0x66C")]
	[Token(Token = "0x6000B58")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23B4940", Offset = "0x23B3D40", Length = "0x87")]
	[Token(Token = "0x6000B59")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23B4860", Offset = "0x23B3C60", Length = "0xD8")]
	[Token(Token = "0x6000B5A")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23B49D0", Offset = "0x23B3DD0", Length = "0x76")]
	[Token(Token = "0x6000B61")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23B4A50", Offset = "0x23B3E50", Length = "0xEC")]
	[Token(Token = "0x6000B5B")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0x23B4B40", Offset = "0x23B3F40", Length = "0x61")]
	[Token(Token = "0x6000B60")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23B4CD0", Offset = "0x23B40D0", Length = "0x83")]
	[Token(Token = "0x6000B5C")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23B4BB0", Offset = "0x23B3FB0", Length = "0x11D")]
	[Token(Token = "0x6000B63")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23B4DA0", Offset = "0x23B41A0", Length = "0x7C")]
	[Token(Token = "0x6000B5D")]
	public virtual object Get(int record) { }

	[Address(RVA = "0x23B4D60", Offset = "0x23B4160", Length = "0x37")]
	[Token(Token = "0x6000B62")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23B4FC0", Offset = "0x23B43C0", Length = "0x132")]
	[Token(Token = "0x6000B5E")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23B4E20", Offset = "0x23B4220", Length = "0xD7")]
	[Token(Token = "0x6000B5F")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23B4F00", Offset = "0x23B4300", Length = "0xBC")]
	[Token(Token = "0x6000B64")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

