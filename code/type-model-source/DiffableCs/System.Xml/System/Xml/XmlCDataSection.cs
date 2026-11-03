namespace System.Xml;

[Token(Token = "0x200008F")]
public class XmlCDataSection : XmlCharacterData
{

	[Token(Token = "0x170001D3")]
	internal virtual bool IsText
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000796")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170001D0")]
	public virtual string LocalName
	{
		[Address(RVA = "0x25137F0", Offset = "0x2512BF0", Length = "0x2D")]
		[Token(Token = "0x6000790")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170001CF")]
	public virtual string Name
	{
		[Address(RVA = "0x25137F0", Offset = "0x2512BF0", Length = "0x2D")]
		[Token(Token = "0x600078F")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170001D1")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
		[Token(Token = "0x6000791")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001D2")]
	public virtual XmlNode ParentNode
	{
		[Address(RVA = "0x2513820", Offset = "0x2512C20", Length = "0x93")]
		[Token(Token = "0x6000792")]
		 get { } //Length: 147
	}

	[Address(RVA = "0x25137A0", Offset = "0x2512BA0", Length = "0x4B")]
	[Token(Token = "0x600078E")]
	protected private XmlCDataSection(string data, XmlDocument doc) { }

	[Address(RVA = "0x25136E0", Offset = "0x2512AE0", Length = "0x68")]
	[Token(Token = "0x6000793")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000796")]
	internal virtual bool get_IsText() { }

	[Address(RVA = "0x25137F0", Offset = "0x2512BF0", Length = "0x2D")]
	[Token(Token = "0x6000790")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x25137F0", Offset = "0x2512BF0", Length = "0x2D")]
	[Token(Token = "0x600078F")]
	public virtual string get_Name() { }

	[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
	[Token(Token = "0x6000791")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x2513820", Offset = "0x2512C20", Length = "0x93")]
	[Token(Token = "0x6000792")]
	public virtual XmlNode get_ParentNode() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000795")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x2513750", Offset = "0x2512B50", Length = "0x45")]
	[Token(Token = "0x6000794")]
	public virtual void WriteTo(XmlWriter w) { }

}

