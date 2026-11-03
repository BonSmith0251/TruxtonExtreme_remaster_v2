namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x20001D0")]
internal class XObjectWrapper : IXmlNode
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400081C")]
	private readonly XObject _xmlObject; //Field offset: 0x10

	[Nullable(1)]
	[Token(Token = "0x17000299")]
	public override List<IXmlNode> Attributes
	{
		[Address(RVA = "0x21B3380", Offset = "0x21B2780", Length = "0x4E")]
		[NullableContext(1)]
		[Token(Token = "0x6000F8D")]
		 get { } //Length: 78
	}

	[Nullable(1)]
	[Token(Token = "0x17000298")]
	public override List<IXmlNode> ChildNodes
	{
		[Address(RVA = "0x21B33D0", Offset = "0x21B27D0", Length = "0x4E")]
		[NullableContext(1)]
		[Token(Token = "0x6000F8C")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000297")]
	public override string LocalName
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000F8B")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700029C")]
	public override string NamespaceUri
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000F92")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000296")]
	public override XmlNodeType NodeType
	{
		[Address(RVA = "0x21B3420", Offset = "0x21B2820", Length = "0x20")]
		[Token(Token = "0x6000F8A")]
		 get { } //Length: 32
	}

	[Token(Token = "0x1700029A")]
	public override IXmlNode ParentNode
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000F8E")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700029B")]
	public override string Value
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000F8F")]
		 get { } //Length: 3
		[Address(RVA = "0x21B3440", Offset = "0x21B2840", Length = "0x3E")]
		[Token(Token = "0x6000F90")]
		 set { } //Length: 62
	}

	[Token(Token = "0x17000295")]
	public override object WrappedNode
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000F89")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000F88")]
	public XObjectWrapper(XObject xmlObject) { }

	[Address(RVA = "0x21B3340", Offset = "0x21B2740", Length = "0x3E")]
	[NullableContext(1)]
	[Token(Token = "0x6000F91")]
	public override IXmlNode AppendChild(IXmlNode newChild) { }

	[Address(RVA = "0x21B3380", Offset = "0x21B2780", Length = "0x4E")]
	[NullableContext(1)]
	[Token(Token = "0x6000F8D")]
	public override List<IXmlNode> get_Attributes() { }

	[Address(RVA = "0x21B33D0", Offset = "0x21B27D0", Length = "0x4E")]
	[NullableContext(1)]
	[Token(Token = "0x6000F8C")]
	public override List<IXmlNode> get_ChildNodes() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000F8B")]
	public override string get_LocalName() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000F92")]
	public override string get_NamespaceUri() { }

	[Address(RVA = "0x21B3420", Offset = "0x21B2820", Length = "0x20")]
	[Token(Token = "0x6000F8A")]
	public override XmlNodeType get_NodeType() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000F8E")]
	public override IXmlNode get_ParentNode() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000F8F")]
	public override string get_Value() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000F89")]
	public override object get_WrappedNode() { }

	[Address(RVA = "0x21B3440", Offset = "0x21B2840", Length = "0x3E")]
	[Token(Token = "0x6000F90")]
	public override void set_Value(string value) { }

}

