namespace System.Xml;

[Token(Token = "0x2000090")]
public abstract class XmlCharacterData : XmlLinkedNode
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000424")]
	private string data; //Field offset: 0x20

	[Token(Token = "0x170001D6")]
	public override string Data
	{
		[Address(RVA = "0x2513900", Offset = "0x2512D00", Length = "0x1E")]
		[Token(Token = "0x600079C")]
		 get { } //Length: 30
		[Address(RVA = "0x2513940", Offset = "0x2512D40", Length = "0xDA")]
		[Token(Token = "0x600079D")]
		 set { } //Length: 218
	}

	[Token(Token = "0x170001D5")]
	public virtual string InnerText
	{
		[Address(RVA = "0x1F71DF0", Offset = "0x1F711F0", Length = "0x14")]
		[Token(Token = "0x600079A")]
		 get { } //Length: 20
		[Address(RVA = "0x240CAA0", Offset = "0x240BEA0", Length = "0x14")]
		[Token(Token = "0x600079B")]
		 set { } //Length: 20
	}

	[Token(Token = "0x170001D4")]
	public virtual string Value
	{
		[Address(RVA = "0x2513920", Offset = "0x2512D20", Length = "0x14")]
		[Token(Token = "0x6000798")]
		 get { } //Length: 20
		[Address(RVA = "0x2513A20", Offset = "0x2512E20", Length = "0x14")]
		[Token(Token = "0x6000799")]
		 set { } //Length: 20
	}

	[Address(RVA = "0x25137A0", Offset = "0x2512BA0", Length = "0x4B")]
	[Token(Token = "0x6000797")]
	protected private XmlCharacterData(string data, XmlDocument doc) { }

	[Address(RVA = "0x25138C0", Offset = "0x2512CC0", Length = "0x34")]
	[Token(Token = "0x600079E")]
	internal bool CheckOnData(string data) { }

	[Address(RVA = "0x2513900", Offset = "0x2512D00", Length = "0x1E")]
	[Token(Token = "0x600079C")]
	public override string get_Data() { }

	[Address(RVA = "0x1F71DF0", Offset = "0x1F711F0", Length = "0x14")]
	[Token(Token = "0x600079A")]
	public virtual string get_InnerText() { }

	[Address(RVA = "0x2513920", Offset = "0x2512D20", Length = "0x14")]
	[Token(Token = "0x6000798")]
	public virtual string get_Value() { }

	[Address(RVA = "0x2513940", Offset = "0x2512D40", Length = "0xDA")]
	[Token(Token = "0x600079D")]
	public override void set_Data(string value) { }

	[Address(RVA = "0x240CAA0", Offset = "0x240BEA0", Length = "0x14")]
	[Token(Token = "0x600079B")]
	public virtual void set_InnerText(string value) { }

	[Address(RVA = "0x2513A20", Offset = "0x2512E20", Length = "0x14")]
	[Token(Token = "0x6000799")]
	public virtual void set_Value(string value) { }

}

