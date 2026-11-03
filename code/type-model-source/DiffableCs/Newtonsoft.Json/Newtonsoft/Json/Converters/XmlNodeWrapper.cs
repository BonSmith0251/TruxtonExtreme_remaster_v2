namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x20001C3")]
internal class XmlNodeWrapper : IXmlNode
{
	[FieldOffset(Offset = "0x10")]
	[Nullable(1)]
	[Token(Token = "0x4000816")]
	private readonly XmlNode _node; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x4000817")]
	private List<IXmlNode> _childNodes; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x4000818")]
	private List<IXmlNode> _attributes; //Field offset: 0x20

	[Nullable(1)]
	[Token(Token = "0x17000264")]
	public override List<IXmlNode> Attributes
	{
		[Address(RVA = "0x21BAED0", Offset = "0x21BA2D0", Length = "0x44F")]
		[NullableContext(1)]
		[Token(Token = "0x6000F28")]
		 get { } //Length: 1103
	}

	[Nullable(1)]
	[Token(Token = "0x17000262")]
	public override List<IXmlNode> ChildNodes
	{
		[Address(RVA = "0x21BB320", Offset = "0x21BA720", Length = "0x3CF")]
		[NullableContext(1)]
		[Token(Token = "0x6000F25")]
		 get { } //Length: 975
	}

	[Token(Token = "0x17000265")]
	private bool HasAttributes
	{
		[Address(RVA = "0x21BB6F0", Offset = "0x21BAAF0", Length = "0xB2")]
		[Token(Token = "0x6000F29")]
		private get { } //Length: 178
	}

	[Token(Token = "0x17000263")]
	protected override bool HasChildNodes
	{
		[Address(RVA = "0x21BB7B0", Offset = "0x21BABB0", Length = "0x2A")]
		[Token(Token = "0x6000F26")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000261")]
	public override string LocalName
	{
		[Address(RVA = "0x21BB7E0", Offset = "0x21BABE0", Length = "0x2A")]
		[Token(Token = "0x6000F24")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000268")]
	public override string NamespaceUri
	{
		[Address(RVA = "0x21BB810", Offset = "0x21BAC10", Length = "0x2A")]
		[Token(Token = "0x6000F2E")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000260")]
	public override XmlNodeType NodeType
	{
		[Address(RVA = "0x1F29870", Offset = "0x1F28C70", Length = "0x2A")]
		[Token(Token = "0x6000F23")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000266")]
	public override IXmlNode ParentNode
	{
		[Address(RVA = "0x21BB840", Offset = "0x21BAC40", Length = "0xA1")]
		[Token(Token = "0x6000F2A")]
		 get { } //Length: 161
	}

	[Token(Token = "0x17000267")]
	public override string Value
	{
		[Address(RVA = "0x21A98A0", Offset = "0x21A8CA0", Length = "0x2A")]
		[Token(Token = "0x6000F2B")]
		 get { } //Length: 42
		[Address(RVA = "0x21BB8F0", Offset = "0x21BACF0", Length = "0x93")]
		[Token(Token = "0x6000F2C")]
		 set { } //Length: 147
	}

	[Token(Token = "0x1700025F")]
	public override object WrappedNode
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000F22")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[NullableContext(1)]
	[Token(Token = "0x6000F21")]
	public XmlNodeWrapper(XmlNode node) { }

	[Address(RVA = "0x21BAC20", Offset = "0x21BA020", Length = "0xBE")]
	[NullableContext(1)]
	[Token(Token = "0x6000F2D")]
	public override IXmlNode AppendChild(IXmlNode newChild) { }

	[Address(RVA = "0x21BAED0", Offset = "0x21BA2D0", Length = "0x44F")]
	[NullableContext(1)]
	[Token(Token = "0x6000F28")]
	public override List<IXmlNode> get_Attributes() { }

	[Address(RVA = "0x21BB320", Offset = "0x21BA720", Length = "0x3CF")]
	[NullableContext(1)]
	[Token(Token = "0x6000F25")]
	public override List<IXmlNode> get_ChildNodes() { }

	[Address(RVA = "0x21BB6F0", Offset = "0x21BAAF0", Length = "0xB2")]
	[Token(Token = "0x6000F29")]
	private bool get_HasAttributes() { }

	[Address(RVA = "0x21BB7B0", Offset = "0x21BABB0", Length = "0x2A")]
	[Token(Token = "0x6000F26")]
	protected override bool get_HasChildNodes() { }

	[Address(RVA = "0x21BB7E0", Offset = "0x21BABE0", Length = "0x2A")]
	[Token(Token = "0x6000F24")]
	public override string get_LocalName() { }

	[Address(RVA = "0x21BB810", Offset = "0x21BAC10", Length = "0x2A")]
	[Token(Token = "0x6000F2E")]
	public override string get_NamespaceUri() { }

	[Address(RVA = "0x1F29870", Offset = "0x1F28C70", Length = "0x2A")]
	[Token(Token = "0x6000F23")]
	public override XmlNodeType get_NodeType() { }

	[Address(RVA = "0x21BB840", Offset = "0x21BAC40", Length = "0xA1")]
	[Token(Token = "0x6000F2A")]
	public override IXmlNode get_ParentNode() { }

	[Address(RVA = "0x21A98A0", Offset = "0x21A8CA0", Length = "0x2A")]
	[Token(Token = "0x6000F2B")]
	public override string get_Value() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000F22")]
	public override object get_WrappedNode() { }

	[Address(RVA = "0x21BB8F0", Offset = "0x21BACF0", Length = "0x93")]
	[Token(Token = "0x6000F2C")]
	public override void set_Value(string value) { }

	[Address(RVA = "0x21BACE0", Offset = "0x21BA0E0", Length = "0x1ED")]
	[NullableContext(1)]
	[Token(Token = "0x6000F27")]
	internal static IXmlNode WrapNode(XmlNode node) { }

}

