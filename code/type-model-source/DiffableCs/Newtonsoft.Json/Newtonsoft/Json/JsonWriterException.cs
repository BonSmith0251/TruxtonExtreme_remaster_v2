namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000082")]
public class JsonWriterException : JsonException
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Nullable(2)]
	[Token(Token = "0x400032A")]
	private readonly string <Path>k__BackingField; //Field offset: 0x90

	[Nullable(2)]
	[Token(Token = "0x170000AB")]
	public string Path
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x60004C5")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x212A7D0", Offset = "0x2129BD0", Length = "0x7")]
	[Token(Token = "0x60004C6")]
	public JsonWriterException() { }

	[Address(RVA = "0x212A7E0", Offset = "0x2129BE0", Length = "0x8")]
	[Token(Token = "0x60004C7")]
	public JsonWriterException(string message) { }

	[Address(RVA = "0x212A780", Offset = "0x2129B80", Length = "0x8")]
	[Token(Token = "0x60004C8")]
	public JsonWriterException(string message, Exception innerException) { }

	[Address(RVA = "0x212A760", Offset = "0x2129B60", Length = "0x1F")]
	[Token(Token = "0x60004C9")]
	public JsonWriterException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x212A790", Offset = "0x2129B90", Length = "0x3E")]
	[Token(Token = "0x60004CA")]
	public JsonWriterException(string message, string path, Exception innerException) { }

	[Address(RVA = "0x212A680", Offset = "0x2129A80", Length = "0xD0")]
	[Token(Token = "0x60004CB")]
	internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex) { }

	[Address(RVA = "0x212A5C0", Offset = "0x21299C0", Length = "0xBB")]
	[Token(Token = "0x60004CC")]
	internal static JsonWriterException Create(string path, string message, Exception ex) { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[CompilerGenerated]
	[NullableContext(2)]
	[Token(Token = "0x60004C5")]
	public string get_Path() { }

}

