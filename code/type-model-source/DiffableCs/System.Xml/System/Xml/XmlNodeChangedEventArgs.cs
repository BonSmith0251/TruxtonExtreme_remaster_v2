namespace System.Xml;

[Token(Token = "0x20000A5")]
public class XmlNodeChangedEventArgs : EventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000488")]
	private XmlNodeChangedAction action; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000489")]
	private XmlNode node; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400048A")]
	private XmlNode oldParent; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400048B")]
	private XmlNode newParent; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400048C")]
	private string oldValue; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400048D")]
	private string newValue; //Field offset: 0x38

	[Token(Token = "0x1700026D")]
	public XmlNodeChangedAction Action
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000924")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x25389A0", Offset = "0x2537DA0", Length = "0xCA")]
	[Token(Token = "0x6000923")]
	public XmlNodeChangedEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000924")]
	public XmlNodeChangedAction get_Action() { }

}

