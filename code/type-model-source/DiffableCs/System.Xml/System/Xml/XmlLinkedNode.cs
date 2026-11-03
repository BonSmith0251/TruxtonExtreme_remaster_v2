namespace System.Xml;

[Token(Token = "0x200009D")]
public abstract class XmlLinkedNode : XmlNode
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000473")]
	internal XmlLinkedNode next; //Field offset: 0x18

	[Token(Token = "0x1700023A")]
	public virtual XmlNode NextSibling
	{
		[Address(RVA = "0x251CB30", Offset = "0x251BF30", Length = "0x5D")]
		[Token(Token = "0x6000895")]
		 get { } //Length: 93
	}

	[Token(Token = "0x17000239")]
	public virtual XmlNode PreviousSibling
	{
		[Address(RVA = "0x251CB90", Offset = "0x251BF90", Length = "0x82")]
		[Token(Token = "0x6000894")]
		 get { } //Length: 130
	}

	[Address(RVA = "0x251CB00", Offset = "0x251BF00", Length = "0x29")]
	[Token(Token = "0x6000893")]
	internal XmlLinkedNode(XmlDocument doc) { }

	[Address(RVA = "0x251CB30", Offset = "0x251BF30", Length = "0x5D")]
	[Token(Token = "0x6000895")]
	public virtual XmlNode get_NextSibling() { }

	[Address(RVA = "0x251CB90", Offset = "0x251BF90", Length = "0x82")]
	[Token(Token = "0x6000894")]
	public virtual XmlNode get_PreviousSibling() { }

}

