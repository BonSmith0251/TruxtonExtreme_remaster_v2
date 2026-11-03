namespace System.Xml.Schema;

[Flags]
[Token(Token = "0x200024D")]
public enum XmlSchemaValidationFlags : int
{
	None = 0,
	ProcessInlineSchema = 1,
	ProcessSchemaLocation = 2,
	ReportValidationWarnings = 4,
	ProcessIdentityConstraints = 8,
	AllowXmlAttributes = 16,
}

