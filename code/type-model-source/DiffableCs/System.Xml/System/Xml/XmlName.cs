namespace System.Xml;

[Token(Token = "0x200009F")]
internal class XmlName : IXmlSchemaInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000477")]
	private string prefix; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000478")]
	private string localName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000479")]
	private string ns; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400047A")]
	private string name; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400047B")]
	private int hashCode; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400047C")]
	internal XmlDocument ownerDoc; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400047D")]
	internal XmlName next; //Field offset: 0x40

	[Token(Token = "0x1700023E")]
	public int HashCode
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x60008B6")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000242")]
	public override bool IsDefault
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60008BA")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000243")]
	public override bool IsNil
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60008BB")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700023B")]
	public string LocalName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60008B3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000244")]
	public override XmlSchemaSimpleType MemberType
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60008BC")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000240")]
	public string Name
	{
		[Address(RVA = "0x2537C20", Offset = "0x2537020", Length = "0x19E")]
		[Token(Token = "0x60008B8")]
		 get { } //Length: 414
	}

	[Token(Token = "0x1700023C")]
	public string NamespaceURI
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60008B4")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700023F")]
	public XmlDocument OwnerDocument
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x60008B7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700023D")]
	public string Prefix
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60008B5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000247")]
	public override XmlSchemaAttribute SchemaAttribute
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60008BF")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000246")]
	public override XmlSchemaElement SchemaElement
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60008BE")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000245")]
	public override XmlSchemaType SchemaType
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60008BD")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000241")]
	public override XmlSchemaValidity Validity
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60008B9")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x2537B70", Offset = "0x2536F70", Length = "0xA9")]
	[Token(Token = "0x60008B2")]
	internal XmlName(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next) { }

	[Address(RVA = "0x25379F0", Offset = "0x2536DF0", Length = "0x10D")]
	[Token(Token = "0x60008B1")]
	public static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	[Address(RVA = "0xA53AA0", Offset = "0xA52EA0", Length = "0x7")]
	[Token(Token = "0x60008C0")]
	public override bool Equals(IXmlSchemaInfo schemaInfo) { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x60008B6")]
	public int get_HashCode() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60008BA")]
	public override bool get_IsDefault() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60008BB")]
	public override bool get_IsNil() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60008B3")]
	public string get_LocalName() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60008BC")]
	public override XmlSchemaSimpleType get_MemberType() { }

	[Address(RVA = "0x2537C20", Offset = "0x2537020", Length = "0x19E")]
	[Token(Token = "0x60008B8")]
	public string get_Name() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60008B4")]
	public string get_NamespaceURI() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x60008B7")]
	public XmlDocument get_OwnerDocument() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60008B5")]
	public string get_Prefix() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60008BF")]
	public override XmlSchemaAttribute get_SchemaAttribute() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60008BE")]
	public override XmlSchemaElement get_SchemaElement() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60008BD")]
	public override XmlSchemaType get_SchemaType() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60008B9")]
	public override XmlSchemaValidity get_Validity() { }

	[Address(RVA = "0x2537B00", Offset = "0x2536F00", Length = "0x6C")]
	[Token(Token = "0x60008C1")]
	public static int GetHashCode(string name) { }

}

