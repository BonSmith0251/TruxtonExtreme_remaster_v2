namespace System.Xml.Serialization;

[DefaultMember("Item")]
[Token(Token = "0x2000106")]
public class XmlAnyElementAttributes : CollectionBase
{

	[Token(Token = "0x17000313")]
	public XmlAnyElementAttribute Item
	{
		[Address(RVA = "0x254FC50", Offset = "0x254F050", Length = "0x122")]
		[Token(Token = "0x6000C36")]
		 get { } //Length: 290
	}

	[Token(Token = "0x17000314")]
	internal int Order
	{
		[Address(RVA = "0x254FD80", Offset = "0x254F180", Length = "0x190")]
		[Token(Token = "0x6000C39")]
		internal get { } //Length: 400
	}

	[Address(RVA = "0x1E3EFC0", Offset = "0x1E3E3C0", Length = "0x7")]
	[Token(Token = "0x6000C3A")]
	public XmlAnyElementAttributes() { }

	[Address(RVA = "0x254FB80", Offset = "0x254EF80", Length = "0xC5")]
	[Token(Token = "0x6000C37")]
	public int Add(XmlAnyElementAttribute attribute) { }

	[Address(RVA = "0x254F9A0", Offset = "0x254EDA0", Length = "0x1D1")]
	[Token(Token = "0x6000C38")]
	internal void AddKeyHash(StringBuilder sb) { }

	[Address(RVA = "0x254FC50", Offset = "0x254F050", Length = "0x122")]
	[Token(Token = "0x6000C36")]
	public XmlAnyElementAttribute get_Item(int index) { }

	[Address(RVA = "0x254FD80", Offset = "0x254F180", Length = "0x190")]
	[Token(Token = "0x6000C39")]
	internal int get_Order() { }

}

