namespace TMPro;

[Token(Token = "0x200006F")]
internal static class SetPropertyUtility
{

	[Address(RVA = "0x8EFFB0", Offset = "0x8EF3B0", Length = "0x5F")]
	[Token(Token = "0x6000405")]
	public static bool SetClass(ref T currentValue, T newValue) { }

	[Address(RVA = "0x2F041F0", Offset = "0x2F035F0", Length = "0x3E")]
	[Token(Token = "0x6000402")]
	public static bool SetColor(ref Color currentValue, Color newValue) { }

	[Address(RVA = "0x8F0010", Offset = "0x8EF410", Length = "0x196")]
	[Token(Token = "0x6000403")]
	public static bool SetEquatableStruct(ref T currentValue, T newValue) { }

	[Address(RVA = "0x8F0330", Offset = "0x8EF730", Length = "0x90")]
	[Token(Token = "0x6000404")]
	public static bool SetStruct(ref T currentValue, T newValue) { }

}

