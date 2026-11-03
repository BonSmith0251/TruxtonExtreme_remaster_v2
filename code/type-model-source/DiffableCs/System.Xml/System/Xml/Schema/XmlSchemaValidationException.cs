namespace System.Xml.Schema;

[Token(Token = "0x200024B")]
public class XmlSchemaValidationException : XmlSchemaException
{

	[Address(RVA = "0x2434600", Offset = "0x2433A00", Length = "0x1F")]
	[Token(Token = "0x60016D7")]
	protected XmlSchemaValidationException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x2434620", Offset = "0x2433A20", Length = "0xA")]
	[Token(Token = "0x60016D9")]
	public XmlSchemaValidationException() { }

	[Address(RVA = "0x24A2BF0", Offset = "0x24A1FF0", Length = "0xCF")]
	[Token(Token = "0x60016DA")]
	internal XmlSchemaValidationException(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	[Address(RVA = "0x248DFC0", Offset = "0x248D3C0", Length = "0x38")]
	[Token(Token = "0x60016DB")]
	internal XmlSchemaValidationException(string res, String[] args, string sourceUri, int lineNumber, int linePosition) { }

	[Address(RVA = "0x24A2BB0", Offset = "0x24A1FB0", Length = "0x3D")]
	[Token(Token = "0x60016DC")]
	internal XmlSchemaValidationException(string res, String[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition) { }

	[Address(RVA = "0x24344F0", Offset = "0x24338F0", Length = "0x1F")]
	[Token(Token = "0x60016D8")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

