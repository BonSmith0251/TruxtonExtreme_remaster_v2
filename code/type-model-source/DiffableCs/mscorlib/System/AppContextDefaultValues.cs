namespace System;

[Token(Token = "0x200019C")]
internal static class AppContextDefaultValues
{
	[Token(Token = "0x4000669")]
	internal static readonly string SwitchEnforceJapaneseEraYearRanges; //Field offset: 0x0
	[Token(Token = "0x400066A")]
	internal static readonly string SwitchFormatJapaneseFirstYearAsANumber; //Field offset: 0x8
	[Token(Token = "0x400066B")]
	internal static readonly string SwitchEnforceLegacyJapaneseDateParsing; //Field offset: 0x10

	[Address(RVA = "0x20799F0", Offset = "0x2078DF0", Length = "0xE8")]
	[Token(Token = "0x6000F10")]
	private static AppContextDefaultValues() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F0E")]
	public static void PopulateDefaultValues() { }

	[Address(RVA = "0x20799E0", Offset = "0x2078DE0", Length = "0x6")]
	[Token(Token = "0x6000F0F")]
	public static bool TryGetSwitchOverride(string switchName, out bool overrideValue) { }

}

