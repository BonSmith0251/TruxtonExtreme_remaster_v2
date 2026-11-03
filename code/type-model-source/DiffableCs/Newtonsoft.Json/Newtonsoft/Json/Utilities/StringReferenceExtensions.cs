namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20000EF")]
internal static class StringReferenceExtensions
{

	[Address(RVA = "0x2152920", Offset = "0x2151D20", Length = "0x9E")]
	[Extension]
	[Token(Token = "0x6000700")]
	public static bool EndsWith(StringReference s, string text) { }

	[Address(RVA = "0x21529C0", Offset = "0x2151DC0", Length = "0x81")]
	[Extension]
	[Token(Token = "0x60006FE")]
	public static int IndexOf(StringReference s, char c, int startIndex, int length) { }

	[Address(RVA = "0x2152A50", Offset = "0x2151E50", Length = "0x87")]
	[Extension]
	[Token(Token = "0x60006FF")]
	public static bool StartsWith(StringReference s, string text) { }

}

