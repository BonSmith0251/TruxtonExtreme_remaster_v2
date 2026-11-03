namespace System.Xml.Serialization;

[DefaultMember("Item")]
[Token(Token = "0x2000110")]
public class XmlElementAttributes : CollectionBase
{

	[Token(Token = "0x17000340")]
	public XmlElementAttribute Item
	{
		[Address(RVA = "0x2562DF0", Offset = "0x25621F0", Length = "0xA9")]
		[Token(Token = "0x6000C83")]
		 get { } //Length: 169
	}

	[Token(Token = "0x17000341")]
	internal int Order
	{
		[Address(RVA = "0x2562EA0", Offset = "0x25622A0", Length = "0x190")]
		[Token(Token = "0x6000C86")]
		internal get { } //Length: 400
	}

	[Address(RVA = "0x1E3EFC0", Offset = "0x1E3E3C0", Length = "0x7")]
	[Token(Token = "0x6000C87")]
	public XmlElementAttributes() { }

	[Address(RVA = "0x2562D80", Offset = "0x2562180", Length = "0x61")]
	[Token(Token = "0x6000C84")]
	public int Add(XmlElementAttribute attribute) { }

	[Address(RVA = "0x2562B60", Offset = "0x2561F60", Length = "0x211")]
	[Token(Token = "0x6000C85")]
	internal void AddKeyHash(StringBuilder sb) { }

	[Address(RVA = "0x2562DF0", Offset = "0x25621F0", Length = "0xA9")]
	[Token(Token = "0x6000C83")]
	public XmlElementAttribute get_Item(int index) { }

	[Address(RVA = "0x2562EA0", Offset = "0x25622A0", Length = "0x190")]
	[Token(Token = "0x6000C86")]
	internal int get_Order() { }

}

