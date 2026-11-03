namespace System.Xml;

[Token(Token = "0x20000B0")]
public class XmlWhitespace : XmlCharacterData
{

	[Token(Token = "0x170002B3")]
	internal virtual bool IsText
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60009D2")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170002AF")]
	public virtual string LocalName
	{
		[Address(RVA = "0x2542040", Offset = "0x2541440", Length = "0x2D")]
		[Token(Token = "0x60009CA")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170002AE")]
	public virtual string Name
	{
		[Address(RVA = "0x2542040", Offset = "0x2541440", Length = "0x2D")]
		[Token(Token = "0x60009C9")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170002B0")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x20482B0", Offset = "0x20476B0", Length = "0x6")]
		[Token(Token = "0x60009CB")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170002B1")]
	public virtual XmlNode ParentNode
	{
		[Address(RVA = "0x25419F0", Offset = "0x2540DF0", Length = "0xA3")]
		[Token(Token = "0x60009CC")]
		 get { } //Length: 163
	}

	[Token(Token = "0x170002B2")]
	public virtual string Value
	{
		[Address(RVA = "0x2513920", Offset = "0x2512D20", Length = "0x14")]
		[Token(Token = "0x60009CD")]
		 get { } //Length: 20
		[Address(RVA = "0x2542070", Offset = "0x2541470", Length = "0x95")]
		[Token(Token = "0x60009CE")]
		 set { } //Length: 149
	}

	[Address(RVA = "0x2541F90", Offset = "0x2541390", Length = "0xAF")]
	[Token(Token = "0x60009C8")]
	protected private XmlWhitespace(string strData, XmlDocument doc) { }

	[Address(RVA = "0x2541ED0", Offset = "0x25412D0", Length = "0x68")]
	[Token(Token = "0x60009CF")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60009D2")]
	internal virtual bool get_IsText() { }

	[Address(RVA = "0x2542040", Offset = "0x2541440", Length = "0x2D")]
	[Token(Token = "0x60009CA")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x2542040", Offset = "0x2541440", Length = "0x2D")]
	[Token(Token = "0x60009C9")]
	public virtual string get_Name() { }

	[Address(RVA = "0x20482B0", Offset = "0x20476B0", Length = "0x6")]
	[Token(Token = "0x60009CB")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x25419F0", Offset = "0x2540DF0", Length = "0xA3")]
	[Token(Token = "0x60009CC")]
	public virtual XmlNode get_ParentNode() { }

	[Address(RVA = "0x2513920", Offset = "0x2512D20", Length = "0x14")]
	[Token(Token = "0x60009CD")]
	public virtual string get_Value() { }

	[Address(RVA = "0x2542070", Offset = "0x2541470", Length = "0x95")]
	[Token(Token = "0x60009CE")]
	public virtual void set_Value(string value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60009D1")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x2541F40", Offset = "0x2541340", Length = "0x45")]
	[Token(Token = "0x60009D0")]
	public virtual void WriteTo(XmlWriter w) { }

}

