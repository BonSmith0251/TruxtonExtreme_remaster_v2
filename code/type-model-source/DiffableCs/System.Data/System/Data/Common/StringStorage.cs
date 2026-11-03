namespace System.Data.Common;

[Token(Token = "0x20000E5")]
internal sealed class StringStorage : DataStorage
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000493")]
	private String[] _values; //Field offset: 0x50

	[Address(RVA = "0x23D54B0", Offset = "0x23D48B0", Length = "0xBD")]
	[Token(Token = "0x6000CB4")]
	public StringStorage(DataColumn column) { }

	[Address(RVA = "0x23D4CE0", Offset = "0x23D40E0", Length = "0x2AC")]
	[Token(Token = "0x6000CB5")]
	public virtual object Aggregate(Int32[] recordNos, AggregateType kind) { }

	[Address(RVA = "0x23D5020", Offset = "0x23D4420", Length = "0x76")]
	[Token(Token = "0x6000CB6")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23D4F90", Offset = "0x23D4390", Length = "0x89")]
	[Token(Token = "0x6000CB7")]
	public virtual int CompareValueTo(int recordNo, object value) { }

	[Address(RVA = "0x23D50A0", Offset = "0x23D44A0", Length = "0x2E")]
	[Token(Token = "0x6000CC0")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23D50D0", Offset = "0x23D44D0", Length = "0x2E")]
	[Token(Token = "0x6000CB8")]
	public virtual object ConvertValue(object value) { }

	[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
	[Token(Token = "0x6000CBF")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23BBEF0", Offset = "0x23BB2F0", Length = "0x48")]
	[Token(Token = "0x6000CB9")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23D5100", Offset = "0x23D4500", Length = "0x11A")]
	[Token(Token = "0x6000CC2")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23895F0", Offset = "0x23889F0", Length = "0x34")]
	[Token(Token = "0x6000CBA")]
	public virtual object Get(int recordNo) { }

	[Address(RVA = "0x23D5220", Offset = "0x23D4620", Length = "0x37")]
	[Token(Token = "0x6000CC1")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23D5260", Offset = "0x23D4660", Length = "0x38")]
	[Token(Token = "0x6000CBB")]
	public virtual int GetStringLength(int record) { }

	[Address(RVA = "0x2389630", Offset = "0x2388A30", Length = "0x2F")]
	[Token(Token = "0x6000CBC")]
	public virtual bool IsNull(int record) { }

	[Address(RVA = "0x23D5410", Offset = "0x23D4810", Length = "0x92")]
	[Token(Token = "0x6000CBD")]
	public virtual void Set(int record, object value) { }

	[Address(RVA = "0x23D52A0", Offset = "0x23D46A0", Length = "0xCA")]
	[Token(Token = "0x6000CBE")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23D5370", Offset = "0x23D4770", Length = "0x9F")]
	[Token(Token = "0x6000CC3")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

