namespace System.Xml.Linq;

[Token(Token = "0x200000D")]
public class XDocument : XContainer
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000016")]
	private XDeclaration _declaration; //Field offset: 0x30

	[Token(Token = "0x1700000E")]
	public XDeclaration Declaration
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600004B")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x600004C")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700000F")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x20270D0", Offset = "0x20264D0", Length = "0x6")]
		[Token(Token = "0x600004D")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000010")]
	public XElement Root
	{
		[Address(RVA = "0x240B3B0", Offset = "0x240A7B0", Length = "0x39")]
		[Token(Token = "0x600004E")]
		 get { } //Length: 57
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000049")]
	public XDocument() { }

	[Address(RVA = "0x240B2E0", Offset = "0x240A6E0", Length = "0xC0")]
	[Token(Token = "0x600004A")]
	public XDocument(XDocument other) { }

	[Address(RVA = "0x240ABA0", Offset = "0x2409FA0", Length = "0x4E")]
	[Token(Token = "0x6000050")]
	internal virtual void AddAttribute(XAttribute a) { }

	[Address(RVA = "0x240AB50", Offset = "0x2409F50", Length = "0x4E")]
	[Token(Token = "0x6000051")]
	internal virtual void AddAttributeSkipNotify(XAttribute a) { }

	[Address(RVA = "0x240ABF0", Offset = "0x2409FF0", Length = "0xEB")]
	[Token(Token = "0x6000052")]
	internal virtual XNode CloneNode() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600004B")]
	public XDeclaration get_Declaration() { }

	[Address(RVA = "0x20270D0", Offset = "0x20264D0", Length = "0x6")]
	[Token(Token = "0x600004D")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x240B3B0", Offset = "0x240A7B0", Length = "0x39")]
	[Token(Token = "0x600004E")]
	public XElement get_Root() { }

	[Address(RVA = "0x9E6AC0", Offset = "0x9E5EC0", Length = "0xCE")]
	[Token(Token = "0x6000053")]
	private T GetFirstNode() { }

	[Address(RVA = "0x240ACE0", Offset = "0x240A0E0", Length = "0x72")]
	[Token(Token = "0x6000054")]
	internal static bool IsWhitespace(string s) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x600004C")]
	public void set_Declaration(XDeclaration value) { }

	[Address(RVA = "0x240AD60", Offset = "0x240A160", Length = "0x139")]
	[Token(Token = "0x6000056")]
	private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter) { }

	[Address(RVA = "0x240AEA0", Offset = "0x240A2A0", Length = "0x22A")]
	[Token(Token = "0x6000055")]
	internal virtual void ValidateNode(XNode node, XNode previous) { }

	[Address(RVA = "0x240B0D0", Offset = "0x240A4D0", Length = "0xB2")]
	[Token(Token = "0x6000057")]
	internal virtual void ValidateString(string s) { }

	[Address(RVA = "0x240B190", Offset = "0x240A590", Length = "0x146")]
	[Token(Token = "0x600004F")]
	public virtual void WriteTo(XmlWriter writer) { }

}

