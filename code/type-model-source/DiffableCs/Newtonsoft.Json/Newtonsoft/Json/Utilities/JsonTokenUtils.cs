namespace Newtonsoft.Json.Utilities;

[Token(Token = "0x20000D4")]
internal static class JsonTokenUtils
{

	[Address(RVA = "0x212A580", Offset = "0x2129980", Length = "0xA")]
	[Token(Token = "0x600065B")]
	internal static bool IsEndToken(JsonToken token) { }

	[Address(RVA = "0x212A590", Offset = "0x2129990", Length = "0x15")]
	[Token(Token = "0x600065D")]
	internal static bool IsPrimitiveToken(JsonToken token) { }

	[Address(RVA = "0x212A5B0", Offset = "0x21299B0", Length = "0xA")]
	[Token(Token = "0x600065C")]
	internal static bool IsStartToken(JsonToken token) { }

}

