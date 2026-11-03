namespace System.Xml.Schema;

[Token(Token = "0x20001F4")]
public sealed class XmlAtomicValue : XPathItem, ICloneable
{
	[Token(Token = "0x20001F6")]
	private class NamespacePrefixForQName : IXmlNamespaceResolver
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000AC8")]
		public string prefix; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000AC9")]
		public string ns; //Field offset: 0x18

		[Address(RVA = "0x24788A0", Offset = "0x2477CA0", Length = "0x4E")]
		[Token(Token = "0x600140B")]
		public NamespacePrefixForQName(string prefix, string ns) { }

		[Address(RVA = "0x2478790", Offset = "0x2477B90", Length = "0x93")]
		[Token(Token = "0x600140E")]
		public override IDictionary<String, String> GetNamespacesInScope(XmlNamespaceScope scope) { }

		[Address(RVA = "0x2478830", Offset = "0x2477C30", Length = "0x31")]
		[Token(Token = "0x600140C")]
		public override string LookupNamespace(string prefix) { }

		[Address(RVA = "0x2478870", Offset = "0x2477C70", Length = "0x2B")]
		[Token(Token = "0x600140D")]
		public override string LookupPrefix(string namespaceName) { }

	}

	[Token(Token = "0x20001F5")]
	private struct Union
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AC3")]
		public bool boolVal; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AC4")]
		public double dblVal; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AC5")]
		public long i64Val; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AC6")]
		public int i32Val; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AC7")]
		public DateTime dtVal; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000ABE")]
	private XmlSchemaType xmlType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000ABF")]
	private object objVal; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000AC0")]
	private TypeCode clrType; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000AC1")]
	private Union unionVal; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000AC2")]
	private NamespacePrefixForQName nsPrefix; //Field offset: 0x30

	[Token(Token = "0x1700053D")]
	public virtual object TypedValue
	{
		[Address(RVA = "0x2487250", Offset = "0x2486650", Length = "0x205")]
		[Token(Token = "0x6001401")]
		 get { } //Length: 517
	}

	[Token(Token = "0x17000543")]
	public virtual string Value
	{
		[Address(RVA = "0x24879F0", Offset = "0x2486DF0", Length = "0x131")]
		[Token(Token = "0x6001408")]
		 get { } //Length: 305
	}

	[Token(Token = "0x1700053E")]
	public virtual bool ValueAsBoolean
	{
		[Address(RVA = "0x2487460", Offset = "0x2486860", Length = "0x10D")]
		[Token(Token = "0x6001402")]
		 get { } //Length: 269
	}

	[Token(Token = "0x1700053F")]
	public virtual DateTime ValueAsDateTime
	{
		[Address(RVA = "0x2487570", Offset = "0x2486970", Length = "0x10D")]
		[Token(Token = "0x6001403")]
		 get { } //Length: 269
	}

	[Token(Token = "0x17000540")]
	public virtual double ValueAsDouble
	{
		[Address(RVA = "0x2487680", Offset = "0x2486A80", Length = "0x10D")]
		[Token(Token = "0x6001404")]
		 get { } //Length: 269
	}

	[Token(Token = "0x17000541")]
	public virtual int ValueAsInt
	{
		[Address(RVA = "0x2487790", Offset = "0x2486B90", Length = "0x10D")]
		[Token(Token = "0x6001405")]
		 get { } //Length: 269
	}

	[Token(Token = "0x17000542")]
	public virtual long ValueAsLong
	{
		[Address(RVA = "0x24878A0", Offset = "0x2486CA0", Length = "0x10D")]
		[Token(Token = "0x6001406")]
		 get { } //Length: 269
	}

	[Token(Token = "0x1700053C")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x24879B0", Offset = "0x2486DB0", Length = "0x33")]
		[Token(Token = "0x6001400")]
		 get { } //Length: 51
	}

	[Token(Token = "0x1700053B")]
	public virtual XmlSchemaType XmlType
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60013FF")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x24868D0", Offset = "0x2485CD0", Length = "0x98")]
	[Token(Token = "0x60013F5")]
	internal XmlAtomicValue(XmlSchemaType xmlType, bool value) { }

	[Address(RVA = "0x2486970", Offset = "0x2485D70", Length = "0xE9")]
	[Token(Token = "0x60013FC")]
	internal XmlAtomicValue(XmlSchemaType xmlType, object value) { }

	[Address(RVA = "0x2486A60", Offset = "0x2485E60", Length = "0x233")]
	[Token(Token = "0x60013FB")]
	internal XmlAtomicValue(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x2487020", Offset = "0x2486420", Length = "0xE9")]
	[Token(Token = "0x60013FA")]
	internal XmlAtomicValue(XmlSchemaType xmlType, string value) { }

	[Address(RVA = "0x2486DE0", Offset = "0x24861E0", Length = "0x23B")]
	[Token(Token = "0x60013FD")]
	internal XmlAtomicValue(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x2486D40", Offset = "0x2486140", Length = "0x96")]
	[Token(Token = "0x60013F8")]
	internal XmlAtomicValue(XmlSchemaType xmlType, int value) { }

	[Address(RVA = "0x24871B0", Offset = "0x24865B0", Length = "0x98")]
	[Token(Token = "0x60013F7")]
	internal XmlAtomicValue(XmlSchemaType xmlType, double value) { }

	[Address(RVA = "0x2487110", Offset = "0x2486510", Length = "0x97")]
	[Token(Token = "0x60013F6")]
	internal XmlAtomicValue(XmlSchemaType xmlType, DateTime value) { }

	[Address(RVA = "0x2486CA0", Offset = "0x24860A0", Length = "0x97")]
	[Token(Token = "0x60013F9")]
	internal XmlAtomicValue(XmlSchemaType xmlType, long value) { }

	[Address(RVA = "0x2487250", Offset = "0x2486650", Length = "0x205")]
	[Token(Token = "0x6001401")]
	public virtual object get_TypedValue() { }

	[Address(RVA = "0x24879F0", Offset = "0x2486DF0", Length = "0x131")]
	[Token(Token = "0x6001408")]
	public virtual string get_Value() { }

	[Address(RVA = "0x2487460", Offset = "0x2486860", Length = "0x10D")]
	[Token(Token = "0x6001402")]
	public virtual bool get_ValueAsBoolean() { }

	[Address(RVA = "0x2487570", Offset = "0x2486970", Length = "0x10D")]
	[Token(Token = "0x6001403")]
	public virtual DateTime get_ValueAsDateTime() { }

	[Address(RVA = "0x2487680", Offset = "0x2486A80", Length = "0x10D")]
	[Token(Token = "0x6001404")]
	public virtual double get_ValueAsDouble() { }

	[Address(RVA = "0x2487790", Offset = "0x2486B90", Length = "0x10D")]
	[Token(Token = "0x6001405")]
	public virtual int get_ValueAsInt() { }

	[Address(RVA = "0x24878A0", Offset = "0x2486CA0", Length = "0x10D")]
	[Token(Token = "0x6001406")]
	public virtual long get_ValueAsLong() { }

	[Address(RVA = "0x24879B0", Offset = "0x2486DB0", Length = "0x33")]
	[Token(Token = "0x6001400")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60013FF")]
	public virtual XmlSchemaType get_XmlType() { }

	[Address(RVA = "0x2486600", Offset = "0x2485A00", Length = "0xA3")]
	[Token(Token = "0x600140A")]
	private string GetPrefixFromQName(string value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x60013FE")]
	private override object System.ICloneable.Clone() { }

	[Address(RVA = "0x1D214A0", Offset = "0x1D208A0", Length = "0x14")]
	[Token(Token = "0x6001409")]
	public virtual string ToString() { }

	[Address(RVA = "0x24866B0", Offset = "0x2485AB0", Length = "0x21E")]
	[Token(Token = "0x6001407")]
	public virtual object ValueAs(Type type, IXmlNamespaceResolver nsResolver) { }

}

