namespace System.Xml;

[Token(Token = "0x20000A0")]
internal sealed class XmlNameEx : XmlName
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400047E")]
	private byte flags; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400047F")]
	private XmlSchemaSimpleType memberType; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000480")]
	private XmlSchemaType schemaType; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000481")]
	private object decl; //Field offset: 0x60

	[Token(Token = "0x17000249")]
	public virtual bool IsDefault
	{
		[Address(RVA = "0x25378A0", Offset = "0x2536CA0", Length = "0x8")]
		[Token(Token = "0x60008C4")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700024A")]
	public virtual bool IsNil
	{
		[Address(RVA = "0x25378B0", Offset = "0x2536CB0", Length = "0x8")]
		[Token(Token = "0x60008C5")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700024B")]
	public virtual XmlSchemaSimpleType MemberType
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60008C6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700024E")]
	public virtual XmlSchemaAttribute SchemaAttribute
	{
		[Address(RVA = "0x25378C0", Offset = "0x2536CC0", Length = "0x72")]
		[Token(Token = "0x60008C9")]
		 get { } //Length: 114
	}

	[Token(Token = "0x1700024D")]
	public virtual XmlSchemaElement SchemaElement
	{
		[Address(RVA = "0x2537940", Offset = "0x2536D40", Length = "0x72")]
		[Token(Token = "0x60008C8")]
		 get { } //Length: 114
	}

	[Token(Token = "0x1700024C")]
	public virtual XmlSchemaType SchemaType
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x60008C7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000248")]
	public virtual XmlSchemaValidity Validity
	{
		[Address(RVA = "0x25379C0", Offset = "0x2536DC0", Length = "0x2B")]
		[Token(Token = "0x60008C3")]
		 get { } //Length: 43
	}

	[Address(RVA = "0x25376F0", Offset = "0x2536AF0", Length = "0x1AB")]
	[Token(Token = "0x60008C2")]
	internal XmlNameEx(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	[Address(RVA = "0x25374A0", Offset = "0x25368A0", Length = "0x1DD")]
	[Token(Token = "0x60008CD")]
	public virtual bool Equals(IXmlSchemaInfo schemaInfo) { }

	[Address(RVA = "0x25378A0", Offset = "0x2536CA0", Length = "0x8")]
	[Token(Token = "0x60008C4")]
	public virtual bool get_IsDefault() { }

	[Address(RVA = "0x25378B0", Offset = "0x2536CB0", Length = "0x8")]
	[Token(Token = "0x60008C5")]
	public virtual bool get_IsNil() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60008C6")]
	public virtual XmlSchemaSimpleType get_MemberType() { }

	[Address(RVA = "0x25378C0", Offset = "0x2536CC0", Length = "0x72")]
	[Token(Token = "0x60008C9")]
	public virtual XmlSchemaAttribute get_SchemaAttribute() { }

	[Address(RVA = "0x2537940", Offset = "0x2536D40", Length = "0x72")]
	[Token(Token = "0x60008C8")]
	public virtual XmlSchemaElement get_SchemaElement() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x60008C7")]
	public virtual XmlSchemaType get_SchemaType() { }

	[Address(RVA = "0x25379C0", Offset = "0x2536DC0", Length = "0x2B")]
	[Token(Token = "0x60008C3")]
	public virtual XmlSchemaValidity get_Validity() { }

	[Address(RVA = "0x2537680", Offset = "0x2536A80", Length = "0x21")]
	[Token(Token = "0x60008CB")]
	public void SetIsDefault(bool value) { }

	[Address(RVA = "0x25376B0", Offset = "0x2536AB0", Length = "0x21")]
	[Token(Token = "0x60008CC")]
	public void SetIsNil(bool value) { }

	[Address(RVA = "0x25376E0", Offset = "0x2536AE0", Length = "0xC")]
	[Token(Token = "0x60008CA")]
	public void SetValidity(XmlSchemaValidity value) { }

}

