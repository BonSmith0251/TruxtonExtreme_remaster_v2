namespace System.Xml.Schema;

[Token(Token = "0x200022C")]
public class XmlSchemaImport : XmlSchemaExternal
{
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000B90")]
	private string ns; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000B91")]
	private XmlSchemaAnnotation annotation; //Field offset: 0x70

	[Token(Token = "0x17000604")]
	[XmlAttribute("namespace", DataType = "anyURI")]
	public string Namespace
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x60015CC")]
		 get { } //Length: 5
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[Token(Token = "0x60015CD")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x248EFB0", Offset = "0x248E3B0", Length = "0x1D")]
	[Token(Token = "0x60015CB")]
	public XmlSchemaImport() { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[Token(Token = "0x60015CE")]
	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x60015CC")]
	public string get_Namespace() { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[Token(Token = "0x60015CD")]
	public void set_Namespace(string value) { }

}

