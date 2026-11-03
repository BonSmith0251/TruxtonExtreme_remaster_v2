namespace System.Xml;

[Token(Token = "0x2000094")]
public class XmlDeclaration : XmlLinkedNode
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000429")]
	private string version; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400042A")]
	private string encoding; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400042B")]
	private string standalone; //Field offset: 0x30

	[Token(Token = "0x170001DE")]
	public string Encoding
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60007B3")]
		 get { } //Length: 5
		[Address(RVA = "0x2514410", Offset = "0x2513810", Length = "0x35")]
		[Token(Token = "0x60007B4")]
		 set { } //Length: 53
	}

	[Token(Token = "0x170001E1")]
	public virtual string InnerText
	{
		[Address(RVA = "0x2514280", Offset = "0x2513680", Length = "0x159")]
		[Token(Token = "0x60007B9")]
		 get { } //Length: 345
		[Address(RVA = "0x2514450", Offset = "0x2513850", Length = "0x2D7")]
		[Token(Token = "0x60007BA")]
		 set { } //Length: 727
	}

	[Token(Token = "0x170001E3")]
	public virtual string LocalName
	{
		[Address(RVA = "0x23326B0", Offset = "0x2331AB0", Length = "0x14")]
		[Token(Token = "0x60007BC")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170001E2")]
	public virtual string Name
	{
		[Address(RVA = "0x25143E0", Offset = "0x25137E0", Length = "0x2C")]
		[Token(Token = "0x60007BB")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001E4")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x1D31610", Offset = "0x1D30A10", Length = "0x6")]
		[Token(Token = "0x60007BD")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001DF")]
	public string Standalone
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60007B5")]
		 get { } //Length: 5
		[Address(RVA = "0x2514730", Offset = "0x2513B30", Length = "0x135")]
		[Token(Token = "0x60007B6")]
		 set { } //Length: 309
	}

	[Token(Token = "0x170001E0")]
	public virtual string Value
	{
		[Address(RVA = "0x25133D0", Offset = "0x25127D0", Length = "0x14")]
		[Token(Token = "0x60007B7")]
		 get { } //Length: 20
		[Address(RVA = "0x25136C0", Offset = "0x2512AC0", Length = "0x14")]
		[Token(Token = "0x60007B8")]
		 set { } //Length: 20
	}

	[Token(Token = "0x170001DD")]
	public internal string Version
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60007B1")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60007B2")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x2514030", Offset = "0x2513430", Length = "0x24F")]
	[Token(Token = "0x60007B0")]
	protected private XmlDeclaration(string version, string encoding, string standalone, XmlDocument doc) { }

	[Address(RVA = "0x2513EE0", Offset = "0x25132E0", Length = "0x54")]
	[Token(Token = "0x60007BE")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60007B3")]
	public string get_Encoding() { }

	[Address(RVA = "0x2514280", Offset = "0x2513680", Length = "0x159")]
	[Token(Token = "0x60007B9")]
	public virtual string get_InnerText() { }

	[Address(RVA = "0x23326B0", Offset = "0x2331AB0", Length = "0x14")]
	[Token(Token = "0x60007BC")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x25143E0", Offset = "0x25137E0", Length = "0x2C")]
	[Token(Token = "0x60007BB")]
	public virtual string get_Name() { }

	[Address(RVA = "0x1D31610", Offset = "0x1D30A10", Length = "0x6")]
	[Token(Token = "0x60007BD")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60007B5")]
	public string get_Standalone() { }

	[Address(RVA = "0x25133D0", Offset = "0x25127D0", Length = "0x14")]
	[Token(Token = "0x60007B7")]
	public virtual string get_Value() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60007B1")]
	public string get_Version() { }

	[Address(RVA = "0x2513F40", Offset = "0x2513340", Length = "0x67")]
	[Token(Token = "0x60007C1")]
	private bool IsValidXmlVersion(string ver) { }

	[Address(RVA = "0x2514410", Offset = "0x2513810", Length = "0x35")]
	[Token(Token = "0x60007B4")]
	public void set_Encoding(string value) { }

	[Address(RVA = "0x2514450", Offset = "0x2513850", Length = "0x2D7")]
	[Token(Token = "0x60007BA")]
	public virtual void set_InnerText(string value) { }

	[Address(RVA = "0x2514730", Offset = "0x2513B30", Length = "0x135")]
	[Token(Token = "0x60007B6")]
	public void set_Standalone(string value) { }

	[Address(RVA = "0x25136C0", Offset = "0x2512AC0", Length = "0x14")]
	[Token(Token = "0x60007B8")]
	public virtual void set_Value(string value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60007B2")]
	internal void set_Version(string value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007C0")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x2513FB0", Offset = "0x25133B0", Length = "0x78")]
	[Token(Token = "0x60007BF")]
	public virtual void WriteTo(XmlWriter w) { }

}

