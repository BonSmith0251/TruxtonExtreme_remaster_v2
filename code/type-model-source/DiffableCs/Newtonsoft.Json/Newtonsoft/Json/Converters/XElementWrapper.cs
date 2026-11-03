namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001D2")]
internal class XElementWrapper : XContainerWrapper, IXmlElement, IXmlNode
{
	[FieldOffset(Offset = "0x20")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x400081D")]
	private List<IXmlNode> _attributes; //Field offset: 0x20

	[Token(Token = "0x170002A3")]
	public virtual List<IXmlNode> Attributes
	{
		[Address(RVA = "0x21B2BB0", Offset = "0x21B1FB0", Length = "0x468")]
		[Token(Token = "0x6000F9D")]
		 get { } //Length: 1128
	}

	[Token(Token = "0x170002A2")]
	private XElement Element
	{
		[Address(RVA = "0x21B3020", Offset = "0x21B2420", Length = "0x6B")]
		[Token(Token = "0x6000F9A")]
		private get { } //Length: 107
	}

	[Token(Token = "0x170002A7")]
	public override bool IsEmpty
	{
		[Address(RVA = "0x21B3090", Offset = "0x21B2490", Length = "0x76")]
		[Token(Token = "0x6000FA5")]
		 get { } //Length: 118
	}

	[Nullable(2)]
	[Token(Token = "0x170002A5")]
	public virtual string LocalName
	{
		[Address(RVA = "0x21B3110", Offset = "0x21B2510", Length = "0x7A")]
		[NullableContext(2)]
		[Token(Token = "0x6000FA2")]
		 get { } //Length: 122
	}

	[Nullable(2)]
	[Token(Token = "0x170002A6")]
	public virtual string NamespaceUri
	{
		[Address(RVA = "0x21B3190", Offset = "0x21B2590", Length = "0x7C")]
		[NullableContext(2)]
		[Token(Token = "0x6000FA3")]
		 get { } //Length: 124
	}

	[Nullable(2)]
	[Token(Token = "0x170002A4")]
	public virtual string Value
	{
		[Address(RVA = "0x21B3210", Offset = "0x21B2610", Length = "0x76")]
		[NullableContext(2)]
		[Token(Token = "0x6000FA0")]
		 get { } //Length: 118
		[Address(RVA = "0x21B3290", Offset = "0x21B2690", Length = "0xA1")]
		[NullableContext(2)]
		[Token(Token = "0x6000FA1")]
		 set { } //Length: 161
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000F9B")]
	public XElementWrapper(XElement element) { }

	[Address(RVA = "0x21B2690", Offset = "0x21B1A90", Length = "0x39")]
	[Token(Token = "0x6000F9F")]
	public virtual IXmlNode AppendChild(IXmlNode newChild) { }

	[Address(RVA = "0x21B2BB0", Offset = "0x21B1FB0", Length = "0x468")]
	[Token(Token = "0x6000F9D")]
	public virtual List<IXmlNode> get_Attributes() { }

	[Address(RVA = "0x21B3020", Offset = "0x21B2420", Length = "0x6B")]
	[Token(Token = "0x6000F9A")]
	private XElement get_Element() { }

	[Address(RVA = "0x21B3090", Offset = "0x21B2490", Length = "0x76")]
	[Token(Token = "0x6000FA5")]
	public override bool get_IsEmpty() { }

	[Address(RVA = "0x21B3110", Offset = "0x21B2510", Length = "0x7A")]
	[NullableContext(2)]
	[Token(Token = "0x6000FA2")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x21B3190", Offset = "0x21B2590", Length = "0x7C")]
	[NullableContext(2)]
	[Token(Token = "0x6000FA3")]
	public virtual string get_NamespaceUri() { }

	[Address(RVA = "0x21B3210", Offset = "0x21B2610", Length = "0x76")]
	[NullableContext(2)]
	[Token(Token = "0x6000FA0")]
	public virtual string get_Value() { }

	[Address(RVA = "0x21B26D0", Offset = "0x21B1AD0", Length = "0x9A")]
	[Token(Token = "0x6000FA4")]
	public override string GetPrefixOfNamespace(string namespaceUri) { }

	[Address(RVA = "0x21B2770", Offset = "0x21B1B70", Length = "0x33B")]
	[Token(Token = "0x6000F9E")]
	private bool HasImplicitNamespaceAttribute(string namespaceUri) { }

	[Address(RVA = "0x21B3290", Offset = "0x21B2690", Length = "0xA1")]
	[NullableContext(2)]
	[Token(Token = "0x6000FA1")]
	public virtual void set_Value(string value) { }

	[Address(RVA = "0x21B2AB0", Offset = "0x21B1EB0", Length = "0xFF")]
	[Token(Token = "0x6000F9C")]
	public override void SetAttributeNode(IXmlNode attribute) { }

}

