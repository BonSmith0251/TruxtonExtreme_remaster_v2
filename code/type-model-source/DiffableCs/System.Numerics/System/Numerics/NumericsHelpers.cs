namespace System.Numerics;

[Token(Token = "0x2000009")]
internal static class NumericsHelpers
{

	[Address(RVA = "0x23EC9D0", Offset = "0x23EBDD0", Length = "0xC")]
	[Token(Token = "0x6000071")]
	public static uint Abs(int a) { }

	[Address(RVA = "0x23DFB60", Offset = "0x23DEF60", Length = "0x69")]
	[Token(Token = "0x6000074")]
	public static int CbitHighZero(uint u) { }

	[Address(RVA = "0x23EC9E0", Offset = "0x23EBDE0", Length = "0x9C")]
	[Token(Token = "0x6000075")]
	public static int CbitHighZero(ulong uu) { }

	[Address(RVA = "0x23ECA80", Offset = "0x23EBE80", Length = "0xD")]
	[Token(Token = "0x6000072")]
	public static uint CombineHash(uint u1, uint u2) { }

	[Address(RVA = "0x23ECA80", Offset = "0x23EBE80", Length = "0xD")]
	[Token(Token = "0x6000073")]
	public static int CombineHash(int n1, int n2) { }

	[Address(RVA = "0x23ECA90", Offset = "0x23EBE90", Length = "0x91")]
	[Token(Token = "0x600006F")]
	public static void DangerousMakeTwosComplement(UInt32[] d) { }

	[Address(RVA = "0x23ECB30", Offset = "0x23EBF30", Length = "0x145")]
	[Token(Token = "0x600006E")]
	public static double GetDoubleFromParts(int sign, int exp, ulong man) { }

	[Address(RVA = "0x23ECC80", Offset = "0x23EC080", Length = "0x86")]
	[Token(Token = "0x600006D")]
	public static void GetDoubleParts(double dbl, out int sign, out int exp, out ulong man, out bool fFinite) { }

	[Address(RVA = "0x23ECD10", Offset = "0x23EC110", Length = "0xC")]
	[Token(Token = "0x6000070")]
	public static ulong MakeUlong(uint uHi, uint uLo) { }

}

