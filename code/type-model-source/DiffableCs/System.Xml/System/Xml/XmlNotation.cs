namespace System.Xml;

[Token(Token = "0x20000AB")]
public class XmlNotation : XmlNode
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004AA")]
	private string publicId; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004AB")]
	private string systemId; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004AC")]
	private string name; //Field offset: 0x28

	[Token(Token = "0x17000299")]
	public virtual string InnerXml
	{
		[Address(RVA = "0x2541610", Offset = "0x2540A10", Length = "0x5F")]
		[Token(Token = "0x6000998")]
		 set { } //Length: 95
	}

	[Token(Token = "0x17000298")]
	public virtual bool IsReadOnly
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000997")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000296")]
	public virtual string LocalName
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000994")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000295")]
	public virtual string Name
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000993")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000297")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x9DCC70", Offset = "0x9DC070", Length = "0x6")]
		[Token(Token = "0x6000995")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x25414F0", Offset = "0x25408F0", Length = "0x11D")]
	[Token(Token = "0x6000992")]
	internal XmlNotation(string name, string publicId, string systemId, XmlDocument doc) { }

	[Address(RVA = "0x2541490", Offset = "0x2540890", Length = "0x5F")]
	[Token(Token = "0x6000996")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000997")]
	public virtual bool get_IsReadOnly() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000994")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000993")]
	public virtual string get_Name() { }

	[Address(RVA = "0x9DCC70", Offset = "0x9DC070", Length = "0x6")]
	[Token(Token = "0x6000995")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x2541610", Offset = "0x2540A10", Length = "0x5F")]
	[Token(Token = "0x6000998")]
	public virtual void set_InnerXml(string value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600099A")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000999")]
	public virtual void WriteTo(XmlWriter w) { }

}

