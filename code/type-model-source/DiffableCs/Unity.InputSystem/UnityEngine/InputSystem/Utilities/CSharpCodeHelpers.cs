namespace UnityEngine.InputSystem.Utilities;

[Token(Token = "0x200023F")]
internal static class CSharpCodeHelpers
{

	[Address(RVA = "0x290DAA0", Offset = "0x290CEA0", Length = "0xE7")]
	[Token(Token = "0x600150B")]
	public static bool IsEmptyOrProperIdentifier(string name) { }

	[Address(RVA = "0x290DB90", Offset = "0x290CF90", Length = "0xB7")]
	[Token(Token = "0x600150C")]
	public static bool IsEmptyOrProperNamespaceName(string name) { }

	[Address(RVA = "0x290DC50", Offset = "0x290D050", Length = "0xCC")]
	[Token(Token = "0x600150A")]
	public static bool IsProperIdentifier(string name) { }

	[Address(RVA = "0x290DD20", Offset = "0x290D120", Length = "0x214")]
	[Token(Token = "0x600150D")]
	public static string MakeIdentifier(string name, string suffix = "") { }

	[Address(RVA = "0x290DF40", Offset = "0x290D340", Length = "0xD0")]
	[Token(Token = "0x600150E")]
	public static string MakeTypeName(string name, string suffix = "") { }

}

