namespace System.Xml.Schema;

[DefaultMember("Item")]
[Obsolete("Use System.Xml.Schema.XmlSchemaSet for schema compilation and validation. https://go.microsoft.com/fwlink/?linkid=14202")]
[Token(Token = "0x2000202")]
public sealed class XmlSchemaCollection : ICollection, IEnumerable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B0C")]
	private Hashtable collection; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B0D")]
	private XmlNameTable nameTable; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B0E")]
	private SchemaNames schemaNames; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B0F")]
	private ReaderWriterLock wLock; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B10")]
	private int timeout; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000B11")]
	private bool isThreadSafe; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B12")]
	private ValidationEventHandler validationEventHandler; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B13")]
	private XmlResolver xmlResolver; //Field offset: 0x40

	[Token(Token = "0x1700058F")]
	public int Count
	{
		[Address(RVA = "0x24898A0", Offset = "0x2488CA0", Length = "0x2A")]
		[Token(Token = "0x60014AB")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000596")]
	internal ValidationEventHandler EventHandler
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x60014BA")]
		internal get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x60014BB")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000592")]
	public XmlSchema Item
	{
		[Address(RVA = "0x2489AA0", Offset = "0x2488EA0", Length = "0xA3")]
		[Token(Token = "0x60014AE")]
		 get { } //Length: 163
	}

	[Token(Token = "0x17000590")]
	public XmlNameTable NameTable
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60014AC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000595")]
	private override int System.Collections.ICollection.Count
	{
		[Address(RVA = "0x24898A0", Offset = "0x2488CA0", Length = "0x2A")]
		[Token(Token = "0x60014B4")]
		private get { } //Length: 42
	}

	[Token(Token = "0x17000593")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60014B2")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000594")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x60014B3")]
		private get { } //Length: 4
	}

	[Token(Token = "0x17000591")]
	internal XmlResolver XmlResolver
	{
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[Token(Token = "0x60014AD")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x2489960", Offset = "0x2488D60", Length = "0x130")]
	[Token(Token = "0x60014AA")]
	public XmlSchemaCollection(XmlNameTable nametable) { }

	[Address(RVA = "0x2489040", Offset = "0x2488440", Length = "0x136")]
	[Token(Token = "0x60014B9")]
	private void Add(string ns, XmlSchemaCollectionNode node) { }

	[Address(RVA = "0x2489310", Offset = "0x2488710", Length = "0x17A")]
	[Token(Token = "0x60014B8")]
	private XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile, XmlResolver resolver) { }

	[Address(RVA = "0x2489180", Offset = "0x2488580", Length = "0x181")]
	[Token(Token = "0x60014B7")]
	internal XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile) { }

	[Address(RVA = "0x24898A0", Offset = "0x2488CA0", Length = "0x2A")]
	[Token(Token = "0x60014AB")]
	public int get_Count() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x60014BA")]
	internal ValidationEventHandler get_EventHandler() { }

	[Address(RVA = "0x2489AA0", Offset = "0x2488EA0", Length = "0xA3")]
	[Token(Token = "0x60014AE")]
	public XmlSchema get_Item(string ns) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60014AC")]
	public XmlNameTable get_NameTable() { }

	[Address(RVA = "0x2489490", Offset = "0x2488890", Length = "0x85")]
	[Token(Token = "0x60014B0")]
	public XmlSchemaCollectionEnumerator GetEnumerator() { }

	[Address(RVA = "0x2489520", Offset = "0x2488920", Length = "0xA3")]
	[Token(Token = "0x60014B5")]
	internal SchemaInfo GetSchemaInfo(string ns) { }

	[Address(RVA = "0x24895D0", Offset = "0x24889D0", Length = "0xB3")]
	[Token(Token = "0x60014B6")]
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x60014BB")]
	internal void set_EventHandler(ValidationEventHandler value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x60014AD")]
	internal void set_XmlResolver(XmlResolver value) { }

	[Address(RVA = "0x2489690", Offset = "0x2488A90", Length = "0x20C")]
	[Token(Token = "0x60014B1")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x24898A0", Offset = "0x2488CA0", Length = "0x2A")]
	[Token(Token = "0x60014B4")]
	private override int System.Collections.ICollection.get_Count() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60014B2")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x60014B3")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0x24898D0", Offset = "0x2488CD0", Length = "0x85")]
	[Token(Token = "0x60014AF")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

