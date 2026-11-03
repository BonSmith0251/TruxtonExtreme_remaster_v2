namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x20001D1")]
internal class XAttributeWrapper : XObjectWrapper
{

	[Nullable(1)]
	[Token(Token = "0x1700029D")]
	private XAttribute Attribute
	{
		[Address(RVA = "0x21B0A00", Offset = "0x21AFE00", Length = "0x6B")]
		[NullableContext(1)]
		[Token(Token = "0x6000F93")]
		private get { } //Length: 107
	}

	[Token(Token = "0x1700029F")]
	public virtual string LocalName
	{
		[Address(RVA = "0x21B0A70", Offset = "0x21AFE70", Length = "0x7A")]
		[Token(Token = "0x6000F97")]
		 get { } //Length: 122
	}

	[Token(Token = "0x170002A0")]
	public virtual string NamespaceUri
	{
		[Address(RVA = "0x21B0AF0", Offset = "0x21AFEF0", Length = "0x7C")]
		[Token(Token = "0x6000F98")]
		 get { } //Length: 124
	}

	[Token(Token = "0x170002A1")]
	public virtual IXmlNode ParentNode
	{
		[Address(RVA = "0x21B0B70", Offset = "0x21AFF70", Length = "0xA4")]
		[Token(Token = "0x6000F99")]
		 get { } //Length: 164
	}

	[Token(Token = "0x1700029E")]
	public virtual string Value
	{
		[Address(RVA = "0x21B0C20", Offset = "0x21B0020", Length = "0x71")]
		[Token(Token = "0x6000F95")]
		 get { } //Length: 113
		[Address(RVA = "0x21B0CA0", Offset = "0x21B00A0", Length = "0xA1")]
		[Token(Token = "0x6000F96")]
		 set { } //Length: 161
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[NullableContext(1)]
	[Token(Token = "0x6000F94")]
	public XAttributeWrapper(XAttribute attribute) { }

	[Address(RVA = "0x21B0A00", Offset = "0x21AFE00", Length = "0x6B")]
	[NullableContext(1)]
	[Token(Token = "0x6000F93")]
	private XAttribute get_Attribute() { }

	[Address(RVA = "0x21B0A70", Offset = "0x21AFE70", Length = "0x7A")]
	[Token(Token = "0x6000F97")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x21B0AF0", Offset = "0x21AFEF0", Length = "0x7C")]
	[Token(Token = "0x6000F98")]
	public virtual string get_NamespaceUri() { }

	[Address(RVA = "0x21B0B70", Offset = "0x21AFF70", Length = "0xA4")]
	[Token(Token = "0x6000F99")]
	public virtual IXmlNode get_ParentNode() { }

	[Address(RVA = "0x21B0C20", Offset = "0x21B0020", Length = "0x71")]
	[Token(Token = "0x6000F95")]
	public virtual string get_Value() { }

	[Address(RVA = "0x21B0CA0", Offset = "0x21B00A0", Length = "0xA1")]
	[Token(Token = "0x6000F96")]
	public virtual void set_Value(string value) { }

}

