namespace UnityEngine.InputSystem.Utilities;

[Extension]
[Token(Token = "0x2000254")]
internal static class NumberHelpers
{

	[Address(RVA = "0x2924720", Offset = "0x2923B20", Length = "0x17")]
	[Extension]
	[Token(Token = "0x60015CE")]
	public static int AlignToMultipleOf(int number, int alignment) { }

	[Address(RVA = "0x2924760", Offset = "0x2923B60", Length = "0x1C")]
	[Extension]
	[Token(Token = "0x60015CF")]
	public static long AlignToMultipleOf(long number, long alignment) { }

	[Address(RVA = "0x2924740", Offset = "0x2923B40", Length = "0x18")]
	[Extension]
	[Token(Token = "0x60015D0")]
	public static uint AlignToMultipleOf(uint number, uint alignment) { }

	[Address(RVA = "0x2924780", Offset = "0x2923B80", Length = "0x9A")]
	[Token(Token = "0x60015D1")]
	public static bool Approximately(double a, double b) { }

	[Address(RVA = "0x2924820", Offset = "0x2923C20", Length = "0x48")]
	[Token(Token = "0x60015D2")]
	public static float IntToNormalizedFloat(int value, int minValue, int maxValue) { }

	[Address(RVA = "0x2924870", Offset = "0x2923C70", Length = "0x46")]
	[Token(Token = "0x60015D3")]
	public static int NormalizedFloatToInt(float value, int intMinValue, int intMaxValue) { }

	[Address(RVA = "0x2921430", Offset = "0x2920830", Length = "0x61")]
	[Token(Token = "0x60015D5")]
	public static uint NormalizedFloatToUInt(float value, uint uintMinValue, uint uintMaxValue) { }

	[Address(RVA = "0x29248C0", Offset = "0x2923CC0", Length = "0x97")]
	[Token(Token = "0x60015D6")]
	public static uint RemapUIntBitsToNormalizeFloatToUIntBits(uint value, uint inBitSize, uint outBitSize) { }

	[Address(RVA = "0x29214A0", Offset = "0x29208A0", Length = "0x50")]
	[Token(Token = "0x60015D4")]
	public static float UIntToNormalizedFloat(uint value, uint minValue, uint maxValue) { }

}

