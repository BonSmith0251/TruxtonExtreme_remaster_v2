namespace System.Xml.Serialization;

[DefaultMember("Item")]
[Token(Token = "0x2000109")]
public class XmlArrayItemAttributes : CollectionBase
{

	[Token(Token = "0x17000322")]
	public XmlArrayItemAttribute Item
	{
		[Address(RVA = "0x255EDE0", Offset = "0x255E1E0", Length = "0xA9")]
		[Token(Token = "0x6000C4C")]
		 get { } //Length: 169
	}

	[Address(RVA = "0x1E3EFC0", Offset = "0x1E3E3C0", Length = "0x7")]
	[Token(Token = "0x6000C4F")]
	public XmlArrayItemAttributes() { }

	[Address(RVA = "0x255ED70", Offset = "0x255E170", Length = "0x61")]
	[Token(Token = "0x6000C4D")]
	public int Add(XmlArrayItemAttribute attribute) { }

	[Address(RVA = "0x255EAC0", Offset = "0x255DEC0", Length = "0x2AC")]
	[Token(Token = "0x6000C4E")]
	internal void AddKeyHash(StringBuilder sb) { }

	[Address(RVA = "0x255EDE0", Offset = "0x255E1E0", Length = "0xA9")]
	[Token(Token = "0x6000C4C")]
	public XmlArrayItemAttribute get_Item(int index) { }

}

