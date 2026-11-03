namespace System.Xml;

[Token(Token = "0x2000093")]
public class XmlComment : XmlCharacterData
{

	[Token(Token = "0x170001DB")]
	public virtual string LocalName
	{
		[Address(RVA = "0x2513EB0", Offset = "0x25132B0", Length = "0x2D")]
		[Token(Token = "0x60007AB")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170001DA")]
	public virtual string Name
	{
		[Address(RVA = "0x2513EB0", Offset = "0x25132B0", Length = "0x2D")]
		[Token(Token = "0x60007AA")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170001DC")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x9DCBA0", Offset = "0x9DBFA0", Length = "0x6")]
		[Token(Token = "0x60007AC")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x25137A0", Offset = "0x2512BA0", Length = "0x4B")]
	[Token(Token = "0x60007A9")]
	protected private XmlComment(string comment, XmlDocument doc) { }

	[Address(RVA = "0x2513DF0", Offset = "0x25131F0", Length = "0x68")]
	[Token(Token = "0x60007AD")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x2513EB0", Offset = "0x25132B0", Length = "0x2D")]
	[Token(Token = "0x60007AB")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x2513EB0", Offset = "0x25132B0", Length = "0x2D")]
	[Token(Token = "0x60007AA")]
	public virtual string get_Name() { }

	[Address(RVA = "0x9DCBA0", Offset = "0x9DBFA0", Length = "0x6")]
	[Token(Token = "0x60007AC")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007AF")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x2513E60", Offset = "0x2513260", Length = "0x45")]
	[Token(Token = "0x60007AE")]
	public virtual void WriteTo(XmlWriter w) { }

}

