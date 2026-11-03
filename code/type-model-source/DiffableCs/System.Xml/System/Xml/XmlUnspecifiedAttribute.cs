namespace System.Xml;

[Token(Token = "0x20000AF")]
internal class XmlUnspecifiedAttribute : XmlAttribute
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004AF")]
	private bool fSpecified; //Field offset: 0x28

	[Token(Token = "0x170002AD")]
	public virtual string InnerText
	{
		[Address(RVA = "0x2541EB0", Offset = "0x25412B0", Length = "0x1B")]
		[Token(Token = "0x60009C1")]
		 set { } //Length: 27
	}

	[Token(Token = "0x170002AC")]
	public virtual bool Specified
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x60009BF")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2541EA0", Offset = "0x25412A0", Length = "0xE")]
	[Token(Token = "0x60009BE")]
	protected private XmlUnspecifiedAttribute(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	[Address(RVA = "0x2541CC0", Offset = "0x25410C0", Length = "0x1B")]
	[Token(Token = "0x60009C5")]
	public virtual XmlNode AppendChild(XmlNode newChild) { }

	[Address(RVA = "0x2541CE0", Offset = "0x25410E0", Length = "0x144")]
	[Token(Token = "0x60009C0")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x60009BF")]
	public virtual bool get_Specified() { }

	[Address(RVA = "0x2541E30", Offset = "0x2541230", Length = "0x1B")]
	[Token(Token = "0x60009C3")]
	public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	[Address(RVA = "0x2541E50", Offset = "0x2541250", Length = "0x1B")]
	[Token(Token = "0x60009C2")]
	public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	[Address(RVA = "0x2541E70", Offset = "0x2541270", Length = "0x1B")]
	[Token(Token = "0x60009C4")]
	public virtual XmlNode RemoveChild(XmlNode oldChild) { }

	[Address(RVA = "0x2541EB0", Offset = "0x25412B0", Length = "0x1B")]
	[Token(Token = "0x60009C1")]
	public virtual void set_InnerText(string value) { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[Token(Token = "0x60009C7")]
	internal void SetSpecified(bool f) { }

	[Address(RVA = "0x2541E90", Offset = "0x2541290", Length = "0xF")]
	[Token(Token = "0x60009C6")]
	public virtual void WriteTo(XmlWriter w) { }

}

