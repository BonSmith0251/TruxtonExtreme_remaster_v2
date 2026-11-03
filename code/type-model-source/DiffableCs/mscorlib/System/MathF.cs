namespace System;

[Token(Token = "0x200010D")]
public static class MathF
{
	[Token(Token = "0x400040A")]
	private static Single[] roundPower10Single; //Field offset: 0x0
	[Token(Token = "0x400040B")]
	private static float singleRoundLimit; //Field offset: 0x8

	[Address(RVA = "0x202A490", Offset = "0x2029890", Length = "0xA2")]
	[Token(Token = "0x6000891")]
	private static MathF() { }

	[Address(RVA = "0x2029DA0", Offset = "0x20291A0", Length = "0x51")]
	[Token(Token = "0x6000886")]
	public static float Abs(float x) { }

	[Address(RVA = "0x2029E00", Offset = "0x2029200", Length = "0x17")]
	[Token(Token = "0x600088D")]
	private static float CopySign(float x, float y) { }

	[Address(RVA = "0x2029E30", Offset = "0x2029230", Length = "0x5")]
	[Token(Token = "0x600088E")]
	public static float Floor(float x) { }

	[Address(RVA = "0x2029E20", Offset = "0x2029220", Length = "0x5")]
	[Token(Token = "0x600088F")]
	private static float FMod(float x, float y) { }

	[Address(RVA = "0x2029E40", Offset = "0x2029240", Length = "0x7D")]
	[Token(Token = "0x6000887")]
	public static float Max(float x, float y) { }

	[Address(RVA = "0x2029EC0", Offset = "0x20292C0", Length = "0x7D")]
	[Token(Token = "0x6000888")]
	public static float Min(float x, float y) { }

	[Address(RVA = "0x2029F40", Offset = "0x2029340", Length = "0x5")]
	[Token(Token = "0x6000890")]
	private static float ModF(float x, Single* intptr) { }

	[Address(RVA = "0x202A320", Offset = "0x2029720", Length = "0x11A")]
	[Intrinsic]
	[Token(Token = "0x6000889")]
	public static float Round(float x) { }

	[Address(RVA = "0x202A2C0", Offset = "0x20296C0", Length = "0x5B")]
	[Token(Token = "0x600088A")]
	public static float Round(float x, int digits) { }

	[Address(RVA = "0x2029F50", Offset = "0x2029350", Length = "0x36C")]
	[Token(Token = "0x600088B")]
	public static float Round(float x, int digits, MidpointRounding mode) { }

	[Address(RVA = "0x202A440", Offset = "0x2029840", Length = "0x50")]
	[Token(Token = "0x600088C")]
	public static int Sign(float x) { }

}

