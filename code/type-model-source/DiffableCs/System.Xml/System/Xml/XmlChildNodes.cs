namespace System.Xml;

[Token(Token = "0x2000092")]
internal class XmlChildNodes : XmlNodeList
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000428")]
	private XmlNode container; //Field offset: 0x10

	[Token(Token = "0x170001D9")]
	public virtual int Count
	{
		[Address(RVA = "0x2513D90", Offset = "0x2513190", Length = "0x5B")]
		[Token(Token = "0x60007A7")]
		 get { } //Length: 91
	}

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x60007A5")]
	public XmlChildNodes(XmlNode container) { }

	[Address(RVA = "0x2513D90", Offset = "0x2513190", Length = "0x5B")]
	[Token(Token = "0x60007A7")]
	public virtual int get_Count() { }

	[Address(RVA = "0x2513C20", Offset = "0x2513020", Length = "0xFF")]
	[Token(Token = "0x60007A8")]
	public virtual IEnumerator GetEnumerator() { }

	[Address(RVA = "0x2513D20", Offset = "0x2513120", Length = "0x6C")]
	[Token(Token = "0x60007A6")]
	public virtual XmlNode Item(int i) { }

}

