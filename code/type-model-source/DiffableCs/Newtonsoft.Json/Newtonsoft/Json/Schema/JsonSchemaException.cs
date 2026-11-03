namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
[Token(Token = "0x2000144")]
public class JsonSchemaException : JsonException
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000613")]
	private readonly int <LineNumber>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000614")]
	private readonly int <LinePosition>k__BackingField; //Field offset: 0x94
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000615")]
	private readonly string <Path>k__BackingField; //Field offset: 0x98

	[Token(Token = "0x170001A1")]
	public int LineNumber
	{
		[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000A58")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001A2")]
	public int LinePosition
	{
		[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000A59")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001A3")]
	public string Path
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A5A")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x212A7D0", Offset = "0x2129BD0", Length = "0x7")]
	[Token(Token = "0x6000A5B")]
	public JsonSchemaException() { }

	[Address(RVA = "0x212A7E0", Offset = "0x2129BE0", Length = "0x8")]
	[Token(Token = "0x6000A5C")]
	public JsonSchemaException(string message) { }

	[Address(RVA = "0x212A780", Offset = "0x2129B80", Length = "0x8")]
	[Token(Token = "0x6000A5D")]
	public JsonSchemaException(string message, Exception innerException) { }

	[Address(RVA = "0x212A760", Offset = "0x2129B60", Length = "0x1F")]
	[Token(Token = "0x6000A5E")]
	public JsonSchemaException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x215B140", Offset = "0x215A540", Length = "0x4D")]
	[Token(Token = "0x6000A5F")]
	internal JsonSchemaException(string message, Exception innerException, string path, int lineNumber, int linePosition) { }

	[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000A58")]
	public int get_LineNumber() { }

	[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000A59")]
	public int get_LinePosition() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A5A")]
	public string get_Path() { }

}

