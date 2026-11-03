namespace System.Xml;

[Token(Token = "0x20000AC")]
public class XmlProcessingInstruction : XmlLinkedNode
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004AD")]
	private string target; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004AE")]
	private string data; //Field offset: 0x28

	[Token(Token = "0x1700029D")]
	public string Data
	{
		[Address(RVA = "0x2541760", Offset = "0x2540B60", Length = "0xDA")]
		[Token(Token = "0x60009A0")]
		 set { } //Length: 218
	}

	[Token(Token = "0x1700029E")]
	public virtual string InnerText
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60009A1")]
		 get { } //Length: 5
		[Address(RVA = "0x2541840", Offset = "0x2540C40", Length = "0x8")]
		[Token(Token = "0x60009A2")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700029B")]
	public virtual string LocalName
	{
		[Address(RVA = "0x23326B0", Offset = "0x2331AB0", Length = "0x14")]
		[Token(Token = "0x600099D")]
		 get { } //Length: 20
	}

	[Token(Token = "0x1700029A")]
	public virtual string Name
	{
		[Address(RVA = "0x2513900", Offset = "0x2512D00", Length = "0x1E")]
		[Token(Token = "0x600099C")]
		 get { } //Length: 30
	}

	[Token(Token = "0x1700029F")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x9E1910", Offset = "0x9E0D10", Length = "0x6")]
		[Token(Token = "0x60009A3")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700029C")]
	public virtual string Value
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x600099E")]
		 get { } //Length: 5
		[Address(RVA = "0x2541840", Offset = "0x2540C40", Length = "0x8")]
		[Token(Token = "0x600099F")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x2541700", Offset = "0x2540B00", Length = "0x52")]
	[Token(Token = "0x600099B")]
	protected private XmlProcessingInstruction(string target, string data, XmlDocument doc) { }

	[Address(RVA = "0x2541670", Offset = "0x2540A70", Length = "0x4A")]
	[Token(Token = "0x60009A4")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60009A1")]
	public virtual string get_InnerText() { }

	[Address(RVA = "0x23326B0", Offset = "0x2331AB0", Length = "0x14")]
	[Token(Token = "0x600099D")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x2513900", Offset = "0x2512D00", Length = "0x1E")]
	[Token(Token = "0x600099C")]
	public virtual string get_Name() { }

	[Address(RVA = "0x9E1910", Offset = "0x9E0D10", Length = "0x6")]
	[Token(Token = "0x60009A3")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x600099E")]
	public virtual string get_Value() { }

	[Address(RVA = "0x2541760", Offset = "0x2540B60", Length = "0xDA")]
	[Token(Token = "0x60009A0")]
	public void set_Data(string value) { }

	[Address(RVA = "0x2541840", Offset = "0x2540C40", Length = "0x8")]
	[Token(Token = "0x60009A2")]
	public virtual void set_InnerText(string value) { }

	[Address(RVA = "0x2541840", Offset = "0x2540C40", Length = "0x8")]
	[Token(Token = "0x600099F")]
	public virtual void set_Value(string value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60009A6")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x25416C0", Offset = "0x2540AC0", Length = "0x34")]
	[Token(Token = "0x60009A5")]
	public virtual void WriteTo(XmlWriter w) { }

}

