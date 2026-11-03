namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001AC")]
internal static class SpaceFillingCurves
{

	[Address(RVA = "0x2DF0800", Offset = "0x2DEFC00", Length = "0x36")]
	[Token(Token = "0x600094A")]
	private static uint Compact1By1(uint x) { }

	[Address(RVA = "0x2DF0840", Offset = "0x2DEFC40", Length = "0x81")]
	[Token(Token = "0x600094C")]
	public static uint2 DecodeMorton2D(uint code) { }

	[Address(RVA = "0x2DF08D0", Offset = "0x2DEFCD0", Length = "0x81")]
	[Token(Token = "0x600094B")]
	public static uint EncodeMorton2D(uint2 coord) { }

	[Address(RVA = "0x2DF0960", Offset = "0x2DEFD60", Length = "0x36")]
	[Token(Token = "0x6000949")]
	private static uint Part1By1(uint x) { }

}

