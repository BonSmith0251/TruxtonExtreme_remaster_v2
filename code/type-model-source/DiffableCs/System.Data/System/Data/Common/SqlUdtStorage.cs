namespace System.Data.Common;

[Token(Token = "0x20000E3")]
internal sealed class SqlUdtStorage : DataStorage
{
	[CompilerGenerated]
	[Token(Token = "0x20000E4")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000492")]
		public Type type; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000CB2")]
		public <>c__DisplayClass6_0() { }

		[Address(RVA = "0x23D6E20", Offset = "0x23D6220", Length = "0x137")]
		[Token(Token = "0x6000CB3")]
		internal object <GetStaticNullForUdtType>b__0(Type t) { }

	}

	[Token(Token = "0x4000491")]
	private static readonly ConcurrentDictionary<Type, Object> s_typeToNull; //Field offset: 0x0
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400048E")]
	private Object[] _values; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400048F")]
	private readonly bool _implementsIXmlSerializable; //Field offset: 0x58
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x4000490")]
	private readonly bool _implementsIComparable; //Field offset: 0x59

	[Address(RVA = "0x23D4830", Offset = "0x23D3C30", Length = "0x84")]
	[Token(Token = "0x6000CB1")]
	private static SqlUdtStorage() { }

	[Address(RVA = "0x23D4A40", Offset = "0x23D3E40", Length = "0x29E")]
	[Token(Token = "0x6000C9F")]
	public SqlUdtStorage(DataColumn column, Type type) { }

	[Address(RVA = "0x23D48C0", Offset = "0x23D3CC0", Length = "0x178")]
	[Token(Token = "0x6000CA0")]
	private SqlUdtStorage(DataColumn column, Type type, object nullValue) { }

	[Address(RVA = "0x23D35C0", Offset = "0x23D29C0", Length = "0x31")]
	[Token(Token = "0x6000CA3")]
	public virtual object Aggregate(Int32[] records, AggregateType kind) { }

	[Address(RVA = "0x23D3880", Offset = "0x23D2C80", Length = "0x3E")]
	[Token(Token = "0x6000CA4")]
	public virtual int Compare(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23D3600", Offset = "0x23D2A00", Length = "0x273")]
	[Token(Token = "0x6000CA5")]
	public virtual int CompareValueTo(int recordNo1, object value) { }

	[Address(RVA = "0x23D39D0", Offset = "0x23D2DD0", Length = "0x216")]
	[Token(Token = "0x6000CAC")]
	public virtual string ConvertObjectToXml(object value) { }

	[Address(RVA = "0x23D38C0", Offset = "0x23D2CC0", Length = "0x105")]
	[Token(Token = "0x6000CAD")]
	public virtual void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	[Address(RVA = "0x23D3E30", Offset = "0x23D3230", Length = "0x23D")]
	[Token(Token = "0x6000CAA")]
	public virtual object ConvertXmlToObject(string s) { }

	[Address(RVA = "0x23D3BF0", Offset = "0x23D2FF0", Length = "0x23A")]
	[Token(Token = "0x6000CAB")]
	public virtual object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	[Address(RVA = "0x23D41F0", Offset = "0x23D35F0", Length = "0x9F")]
	[Token(Token = "0x6000CA6")]
	public virtual void Copy(int recordNo1, int recordNo2) { }

	[Address(RVA = "0x23D4070", Offset = "0x23D3470", Length = "0x174")]
	[Token(Token = "0x6000CAF")]
	protected virtual void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	[Address(RVA = "0x23BBF80", Offset = "0x23BB380", Length = "0x2B")]
	[Token(Token = "0x6000CA7")]
	public virtual object Get(int recordNo) { }

	[Address(RVA = "0x23D4290", Offset = "0x23D3690", Length = "0x37")]
	[Token(Token = "0x6000CAE")]
	protected virtual object GetEmptyStorage(int recordCount) { }

	[Address(RVA = "0x23D42D0", Offset = "0x23D36D0", Length = "0x119")]
	[Token(Token = "0x6000CA1")]
	internal static object GetStaticNullForUdtType(Type type) { }

	[Address(RVA = "0x23D43F0", Offset = "0x23D37F0", Length = "0xAD")]
	[Token(Token = "0x6000CA2")]
	public virtual bool IsNull(int record) { }

	[Address(RVA = "0x23D4620", Offset = "0x23D3A20", Length = "0x209")]
	[Token(Token = "0x6000CA8")]
	public virtual void Set(int recordNo, object value) { }

	[Address(RVA = "0x23D44A0", Offset = "0x23D38A0", Length = "0xD7")]
	[Token(Token = "0x6000CA9")]
	public virtual void SetCapacity(int capacity) { }

	[Address(RVA = "0x23D4580", Offset = "0x23D3980", Length = "0x9F")]
	[Token(Token = "0x6000CB0")]
	protected virtual void SetStorage(object store, BitArray nullbits) { }

}

