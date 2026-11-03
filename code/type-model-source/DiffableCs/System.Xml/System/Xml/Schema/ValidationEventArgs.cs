namespace System.Xml.Schema;

[Token(Token = "0x20001E4")]
public class ValidationEventArgs : EventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A43")]
	private XmlSchemaException ex; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A44")]
	private XmlSeverityType severity; //Field offset: 0x18

	[Token(Token = "0x17000536")]
	public XmlSchemaException Exception
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600136E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000535")]
	public XmlSeverityType Severity
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x600136D")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x24788F0", Offset = "0x2477CF0", Length = "0x6D")]
	[Token(Token = "0x600136B")]
	internal ValidationEventArgs(XmlSchemaException ex) { }

	[Address(RVA = "0x2478960", Offset = "0x2477D60", Length = "0x76")]
	[Token(Token = "0x600136C")]
	internal ValidationEventArgs(XmlSchemaException ex, XmlSeverityType severity) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600136E")]
	public XmlSchemaException get_Exception() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x600136D")]
	public XmlSeverityType get_Severity() { }

}

