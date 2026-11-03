namespace System;

[Token(Token = "0x200010B")]
internal static class Marvin
{
	[CompilerGenerated]
	[Token(Token = "0x4000407")]
	private static readonly ulong <DefaultSeed>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x1700008A")]
	public static ulong DefaultSeed
	{
		[Address(RVA = "0x2029C90", Offset = "0x2029090", Length = "0x4E")]
		[CompilerGenerated]
		[Token(Token = "0x6000844")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x2025B80", Offset = "0x2024F80", Length = "0x19")]
	[Token(Token = "0x6000843")]
	private static uint _rotl(uint value, int shift) { }

	[Address(RVA = "0x2029C50", Offset = "0x2029050", Length = "0x3A")]
	[Token(Token = "0x6000846")]
	private static Marvin() { }

	[Address(RVA = "0x2029630", Offset = "0x2028A30", Length = "0x9C")]
	[Token(Token = "0x6000842")]
	private static void Block(ref uint rp0, ref uint rp1) { }

	[Address(RVA = "0x20296D0", Offset = "0x2028AD0", Length = "0x9A")]
	[Token(Token = "0x6000840")]
	public static int ComputeHash32(ReadOnlySpan<Byte> data, ulong seed) { }

	[Address(RVA = "0x2029770", Offset = "0x2028B70", Length = "0x184")]
	[Token(Token = "0x6000841")]
	public static int ComputeHash32(ref byte data, int count, ulong seed) { }

	[Address(RVA = "0x2029C40", Offset = "0x2029040", Length = "0x6")]
	[Token(Token = "0x6000845")]
	private static ulong GenerateSeed() { }

	[Address(RVA = "0x2029C90", Offset = "0x2029090", Length = "0x4E")]
	[CompilerGenerated]
	[Token(Token = "0x6000844")]
	public static ulong get_DefaultSeed() { }

}

