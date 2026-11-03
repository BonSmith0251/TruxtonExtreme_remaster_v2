namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001C0")]
internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000813")]
	private readonly XmlElement _element; //Field offset: 0x28

	[Token(Token = "0x17000256")]
	public override bool IsEmpty
	{
		[Address(RVA = "0x21B43E0", Offset = "0x21B37E0", Length = "0x1D")]
		[Token(Token = "0x6000F14")]
		 get { } //Length: 29
	}

	[Address(RVA = "0x21B38F0", Offset = "0x21B2CF0", Length = "0x41")]
	[Token(Token = "0x6000F11")]
	public XmlElementWrapper(XmlElement element) { }

	[Address(RVA = "0x21B43E0", Offset = "0x21B37E0", Length = "0x1D")]
	[Token(Token = "0x6000F14")]
	public override bool get_IsEmpty() { }

	[Address(RVA = "0x21B42C0", Offset = "0x21B36C0", Length = "0x2A")]
	[Token(Token = "0x6000F13")]
	public override string GetPrefixOfNamespace(string namespaceUri) { }

	[Address(RVA = "0x21B42F0", Offset = "0x21B36F0", Length = "0xE2")]
	[Token(Token = "0x6000F12")]
	public override void SetAttributeNode(IXmlNode attribute) { }

}

