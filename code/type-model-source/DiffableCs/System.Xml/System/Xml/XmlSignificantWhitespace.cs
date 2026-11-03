namespace System.Xml;

[Token(Token = "0x20000AD")]
public class XmlSignificantWhitespace : XmlCharacterData
{

	[Token(Token = "0x170002A5")]
	internal virtual bool IsText
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60009B1")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170002A1")]
	public virtual string LocalName
	{
		[Address(RVA = "0x25419C0", Offset = "0x2540DC0", Length = "0x2D")]
		[Token(Token = "0x60009A9")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170002A0")]
	public virtual string Name
	{
		[Address(RVA = "0x25419C0", Offset = "0x2540DC0", Length = "0x2D")]
		[Token(Token = "0x60009A8")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170002A2")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x9DCDA0", Offset = "0x9DC1A0", Length = "0x6")]
		[Token(Token = "0x60009AA")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170002A3")]
	public virtual XmlNode ParentNode
	{
		[Address(RVA = "0x25419F0", Offset = "0x2540DF0", Length = "0xA3")]
		[Token(Token = "0x60009AB")]
		 get { } //Length: 163
	}

	[Token(Token = "0x170002A4")]
	public virtual string Value
	{
		[Address(RVA = "0x2513920", Offset = "0x2512D20", Length = "0x14")]
		[Token(Token = "0x60009AD")]
		 get { } //Length: 20
		[Address(RVA = "0x2541AA0", Offset = "0x2540EA0", Length = "0x95")]
		[Token(Token = "0x60009AE")]
		 set { } //Length: 149
	}

	[Address(RVA = "0x2541910", Offset = "0x2540D10", Length = "0xAF")]
	[Token(Token = "0x60009A7")]
	protected private XmlSignificantWhitespace(string strData, XmlDocument doc) { }

	[Address(RVA = "0x2541850", Offset = "0x2540C50", Length = "0x68")]
	[Token(Token = "0x60009AC")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60009B1")]
	internal virtual bool get_IsText() { }

	[Address(RVA = "0x25419C0", Offset = "0x2540DC0", Length = "0x2D")]
	[Token(Token = "0x60009A9")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x25419C0", Offset = "0x2540DC0", Length = "0x2D")]
	[Token(Token = "0x60009A8")]
	public virtual string get_Name() { }

	[Address(RVA = "0x9DCDA0", Offset = "0x9DC1A0", Length = "0x6")]
	[Token(Token = "0x60009AA")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x25419F0", Offset = "0x2540DF0", Length = "0xA3")]
	[Token(Token = "0x60009AB")]
	public virtual XmlNode get_ParentNode() { }

	[Address(RVA = "0x2513920", Offset = "0x2512D20", Length = "0x14")]
	[Token(Token = "0x60009AD")]
	public virtual string get_Value() { }

	[Address(RVA = "0x2541AA0", Offset = "0x2540EA0", Length = "0x95")]
	[Token(Token = "0x60009AE")]
	public virtual void set_Value(string value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60009B0")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x25418C0", Offset = "0x2540CC0", Length = "0x45")]
	[Token(Token = "0x60009AF")]
	public virtual void WriteTo(XmlWriter w) { }

}

