namespace System.Xml;

[Token(Token = "0x20000AE")]
public class XmlText : XmlCharacterData
{

	[Token(Token = "0x170002AB")]
	internal virtual bool IsText
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60009BD")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170002A7")]
	public virtual string LocalName
	{
		[Address(RVA = "0x2541BD0", Offset = "0x2540FD0", Length = "0x2D")]
		[Token(Token = "0x60009B5")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170002A6")]
	public virtual string Name
	{
		[Address(RVA = "0x2541BD0", Offset = "0x2540FD0", Length = "0x2D")]
		[Token(Token = "0x60009B4")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170002A8")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
		[Token(Token = "0x60009B6")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170002A9")]
	public virtual XmlNode ParentNode
	{
		[Address(RVA = "0x2513820", Offset = "0x2512C20", Length = "0x93")]
		[Token(Token = "0x60009B7")]
		 get { } //Length: 147
	}

	[Token(Token = "0x170002AA")]
	public virtual string Value
	{
		[Address(RVA = "0x2513920", Offset = "0x2512D20", Length = "0x14")]
		[Token(Token = "0x60009B9")]
		 get { } //Length: 20
		[Address(RVA = "0x2541C00", Offset = "0x2541000", Length = "0xBA")]
		[Token(Token = "0x60009BA")]
		 set { } //Length: 186
	}

	[Address(RVA = "0x2541BC0", Offset = "0x2540FC0", Length = "0xB")]
	[Token(Token = "0x60009B2")]
	internal XmlText(string strData) { }

	[Address(RVA = "0x2541BB0", Offset = "0x2540FB0", Length = "0x8")]
	[Token(Token = "0x60009B3")]
	protected private XmlText(string strData, XmlDocument doc) { }

	[Address(RVA = "0x2541B40", Offset = "0x2540F40", Length = "0x68")]
	[Token(Token = "0x60009B8")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60009BD")]
	internal virtual bool get_IsText() { }

	[Address(RVA = "0x2541BD0", Offset = "0x2540FD0", Length = "0x2D")]
	[Token(Token = "0x60009B5")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x2541BD0", Offset = "0x2540FD0", Length = "0x2D")]
	[Token(Token = "0x60009B4")]
	public virtual string get_Name() { }

	[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
	[Token(Token = "0x60009B6")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x2513820", Offset = "0x2512C20", Length = "0x93")]
	[Token(Token = "0x60009B7")]
	public virtual XmlNode get_ParentNode() { }

	[Address(RVA = "0x2513920", Offset = "0x2512D20", Length = "0x14")]
	[Token(Token = "0x60009B9")]
	public virtual string get_Value() { }

	[Address(RVA = "0x2541C00", Offset = "0x2541000", Length = "0xBA")]
	[Token(Token = "0x60009BA")]
	public virtual void set_Value(string value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60009BC")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x25418C0", Offset = "0x2540CC0", Length = "0x45")]
	[Token(Token = "0x60009BB")]
	public virtual void WriteTo(XmlWriter w) { }

}

