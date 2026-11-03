namespace System.Xml.Schema;

[Token(Token = "0x200022B")]
public class XmlSchemaKeyref : XmlSchemaIdentityConstraint
{
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000B8F")]
	private XmlQualifiedName refer; //Field offset: 0x78

	[Token(Token = "0x17000603")]
	[XmlAttribute("refer")]
	public XmlQualifiedName Refer
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x60015C8")]
		 get { } //Length: 5
		[Address(RVA = "0x248F3D0", Offset = "0x248E7D0", Length = "0xA0")]
		[Token(Token = "0x60015C9")]
		 set { } //Length: 160
	}

	[Address(RVA = "0x248F2D0", Offset = "0x248E6D0", Length = "0xFC")]
	[Token(Token = "0x60015CA")]
	public XmlSchemaKeyref() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x60015C8")]
	public XmlQualifiedName get_Refer() { }

	[Address(RVA = "0x248F3D0", Offset = "0x248E7D0", Length = "0xA0")]
	[Token(Token = "0x60015C9")]
	public void set_Refer(XmlQualifiedName value) { }

}

