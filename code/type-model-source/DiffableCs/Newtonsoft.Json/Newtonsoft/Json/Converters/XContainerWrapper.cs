namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001CF")]
internal class XContainerWrapper : XObjectWrapper
{
	[FieldOffset(Offset = "0x18")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x400081B")]
	private List<IXmlNode> _childNodes; //Field offset: 0x18

	[Token(Token = "0x17000292")]
	public virtual List<IXmlNode> ChildNodes
	{
		[Address(RVA = "0x21B1380", Offset = "0x21B0780", Length = "0x322")]
		[Token(Token = "0x6000F83")]
		 get { } //Length: 802
	}

	[Token(Token = "0x17000291")]
	private XContainer Container
	{
		[Address(RVA = "0x21B16B0", Offset = "0x21B0AB0", Length = "0x6B")]
		[Token(Token = "0x6000F81")]
		private get { } //Length: 107
	}

	[Token(Token = "0x17000293")]
	protected override bool HasChildNodes
	{
		[Address(RVA = "0x21B1720", Offset = "0x21B0B20", Length = "0x7D")]
		[Token(Token = "0x6000F84")]
		 get { } //Length: 125
	}

	[Nullable(2)]
	[Token(Token = "0x17000294")]
	public virtual IXmlNode ParentNode
	{
		[Address(RVA = "0x21B17A0", Offset = "0x21B0BA0", Length = "0xA4")]
		[NullableContext(2)]
		[Token(Token = "0x6000F85")]
		 get { } //Length: 164
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000F82")]
	public XContainerWrapper(XContainer container) { }

	[Address(RVA = "0x21B0FA0", Offset = "0x21B03A0", Length = "0xE1")]
	[Token(Token = "0x6000F87")]
	public virtual IXmlNode AppendChild(IXmlNode newChild) { }

	[Address(RVA = "0x21B1380", Offset = "0x21B0780", Length = "0x322")]
	[Token(Token = "0x6000F83")]
	public virtual List<IXmlNode> get_ChildNodes() { }

	[Address(RVA = "0x21B16B0", Offset = "0x21B0AB0", Length = "0x6B")]
	[Token(Token = "0x6000F81")]
	private XContainer get_Container() { }

	[Address(RVA = "0x21B1720", Offset = "0x21B0B20", Length = "0x7D")]
	[Token(Token = "0x6000F84")]
	protected override bool get_HasChildNodes() { }

	[Address(RVA = "0x21B17A0", Offset = "0x21B0BA0", Length = "0xA4")]
	[NullableContext(2)]
	[Token(Token = "0x6000F85")]
	public virtual IXmlNode get_ParentNode() { }

	[Address(RVA = "0x21B1090", Offset = "0x21B0490", Length = "0x2ED")]
	[Token(Token = "0x6000F86")]
	internal static IXmlNode WrapNode(XObject node) { }

}

