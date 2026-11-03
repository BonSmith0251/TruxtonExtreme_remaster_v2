namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
[Token(Token = "0x2000153")]
public class ValidationEventArgs : EventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000656")]
	private readonly JsonSchemaException _ex; //Field offset: 0x10

	[Token(Token = "0x170001C8")]
	public JsonSchemaException Exception
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000ADA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001CA")]
	public string Message
	{
		[Address(RVA = "0x2171280", Offset = "0x2170680", Length = "0x2A")]
		[Token(Token = "0x6000ADC")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001C9")]
	public string Path
	{
		[Address(RVA = "0x21712B0", Offset = "0x21706B0", Length = "0x153")]
		[Token(Token = "0x6000ADB")]
		 get { } //Length: 339
	}

	[Address(RVA = "0x21711F0", Offset = "0x21705F0", Length = "0x83")]
	[Token(Token = "0x6000AD9")]
	internal ValidationEventArgs(JsonSchemaException ex) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000ADA")]
	public JsonSchemaException get_Exception() { }

	[Address(RVA = "0x2171280", Offset = "0x2170680", Length = "0x2A")]
	[Token(Token = "0x6000ADC")]
	public string get_Message() { }

	[Address(RVA = "0x21712B0", Offset = "0x21706B0", Length = "0x153")]
	[Token(Token = "0x6000ADB")]
	public string get_Path() { }

}

