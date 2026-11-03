namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x200007C")]
internal static class FixedStringUtils
{
	[Token(Token = "0x200007D")]
	public struct UintFloatUnion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003A0")]
		public uint uintValue; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003A1")]
		public float floatValue; //Field offset: 0x0

	}


	[Address(RVA = "0x28C6D10", Offset = "0x28C6110", Length = "0x132")]
	[Token(Token = "0x60006C6")]
	internal static ParseError Base10ToBase2(ref float output, ulong mantissa10, int exponent10) { }

	[Address(RVA = "0x28C6E50", Offset = "0x28C6250", Length = "0x12B")]
	[Token(Token = "0x60006C7")]
	internal static void Base2ToBase10(ref ulong mantissa10, ref int exponent10, float input) { }

}

