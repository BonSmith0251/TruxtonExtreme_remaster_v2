namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000020")]
public class JsonException : Exception
{

	[Address(RVA = "0x20CCFD0", Offset = "0x20CC3D0", Length = "0x49")]
	[Token(Token = "0x6000095")]
	public JsonException() { }

	[Address(RVA = "0x20CD020", Offset = "0x20CC420", Length = "0x59")]
	[Token(Token = "0x6000096")]
	public JsonException(string message) { }

	[Address(RVA = "0x20CD080", Offset = "0x20CC480", Length = "0x69")]
	[Token(Token = "0x6000097")]
	public JsonException(string message, Exception innerException) { }

	[Address(RVA = "0x20CD0F0", Offset = "0x20CC4F0", Length = "0x74")]
	[Token(Token = "0x6000098")]
	public JsonException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x20CCF00", Offset = "0x20CC300", Length = "0xCA")]
	[Token(Token = "0x6000099")]
	internal static JsonException Create(IJsonLineInfo lineInfo, string path, string message) { }

}

