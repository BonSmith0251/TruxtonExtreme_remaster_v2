namespace System.Xml.Schema;

[Token(Token = "0x20001CA")]
public class XmlSchemaInferenceException : XmlSchemaException
{

	[Address(RVA = "0x2434600", Offset = "0x2433A00", Length = "0x1F")]
	[Token(Token = "0x60011AC")]
	protected XmlSchemaInferenceException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x2434620", Offset = "0x2433A20", Length = "0xA")]
	[Token(Token = "0x60011AE")]
	public XmlSchemaInferenceException() { }

	[Address(RVA = "0x2434540", Offset = "0x2433940", Length = "0xB2")]
	[Token(Token = "0x60011AF")]
	internal XmlSchemaInferenceException(string res, string arg) { }

	[Address(RVA = "0x2434510", Offset = "0x2433910", Length = "0x2F")]
	[Token(Token = "0x60011B0")]
	internal XmlSchemaInferenceException(string res, int lineNumber, int linePosition) { }

	[Address(RVA = "0x24344F0", Offset = "0x24338F0", Length = "0x1F")]
	[Token(Token = "0x60011AD")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

