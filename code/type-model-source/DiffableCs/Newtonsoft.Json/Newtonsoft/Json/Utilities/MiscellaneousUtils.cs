namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20000E0")]
internal static class MiscellaneousUtils
{

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("DEBUG")]
	[NullableContext(2)]
	[Token(Token = "0x6000687")]
	public static void Assert(bool condition, string message = null) { }

	[Address(RVA = "0x212AF10", Offset = "0x212A310", Length = "0x98")]
	[Token(Token = "0x600068B")]
	public static int ByteArrayCompare(Byte[] a1, Byte[] a2) { }

	[Address(RVA = "0x212AFB0", Offset = "0x212A3B0", Length = "0xD8")]
	[Token(Token = "0x6000689")]
	public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message) { }

	[Address(RVA = "0x212B090", Offset = "0x212A490", Length = "0xB8")]
	[Token(Token = "0x600068D")]
	public static string GetLocalName(string qualifiedName) { }

	[Address(RVA = "0x212B150", Offset = "0x212A550", Length = "0xB8")]
	[Token(Token = "0x600068C")]
	public static string GetPrefix(string qualifiedName) { }

	[Address(RVA = "0x212B210", Offset = "0x212A610", Length = "0xB0")]
	[Token(Token = "0x600068E")]
	public static void GetQualifiedNameParts(string qualifiedName, out string prefix, out string localName) { }

	[Address(RVA = "0x212B2D0", Offset = "0x212A6D0", Length = "0x8B")]
	[Token(Token = "0x600068F")]
	internal static RegexOptions GetRegexOptions(string optionsText) { }

	[Address(RVA = "0x212B360", Offset = "0x212A760", Length = "0x8B")]
	[Token(Token = "0x600068A")]
	public static string ToString(object value) { }

	[Address(RVA = "0x212B3F0", Offset = "0x212A7F0", Length = "0x36F")]
	[NullableContext(2)]
	[Token(Token = "0x6000688")]
	public static bool ValueEquals(object objA, object objB) { }

}

