namespace System;

[Token(Token = "0x200010C")]
public static class Math
{
	[Token(Token = "0x4000408")]
	private static double doubleRoundLimit; //Field offset: 0x0
	[Token(Token = "0x4000409")]
	private static Double[] roundPower10Double; //Field offset: 0x8

	[Address(RVA = "0x202B440", Offset = "0x202A840", Length = "0xAC")]
	[Token(Token = "0x6000885")]
	private static Math() { }

	[Address(RVA = "0x202A5E0", Offset = "0x20299E0", Length = "0x8")]
	[Token(Token = "0x6000872")]
	public static float Abs(float value) { }

	[Address(RVA = "0x202A5F0", Offset = "0x20299F0", Length = "0x8")]
	[Token(Token = "0x6000871")]
	public static double Abs(double value) { }

	[Address(RVA = "0x202A590", Offset = "0x2029990", Length = "0x47")]
	[Token(Token = "0x6000847")]
	public static int Abs(int value) { }

	[Address(RVA = "0x202A540", Offset = "0x2029940", Length = "0x4B")]
	[Token(Token = "0x6000848")]
	public static long Abs(long value) { }

	[Address(RVA = "0x202A600", Offset = "0x2029A00", Length = "0x65")]
	[Token(Token = "0x6000849")]
	public static decimal Abs(decimal value) { }

	[Address(RVA = "0x202A670", Offset = "0x2029A70", Length = "0x5")]
	[Token(Token = "0x6000873")]
	public static double Acos(double d) { }

	[Address(RVA = "0x202A680", Offset = "0x2029A80", Length = "0x5")]
	[Token(Token = "0x6000874")]
	public static double Asin(double d) { }

	[Address(RVA = "0x202A6A0", Offset = "0x2029AA0", Length = "0x5")]
	[Token(Token = "0x6000875")]
	public static double Atan(double d) { }

	[Address(RVA = "0x202A690", Offset = "0x2029A90", Length = "0x5")]
	[Token(Token = "0x6000876")]
	public static double Atan2(double y, double x) { }

	[Address(RVA = "0x202A6B0", Offset = "0x2029AB0", Length = "0x5")]
	[Token(Token = "0x6000877")]
	public static double Ceiling(double a) { }

	[Address(RVA = "0x202A810", Offset = "0x2029C10", Length = "0x94")]
	[Token(Token = "0x600084C")]
	public static int Clamp(int value, int min, int max) { }

	[Address(RVA = "0x202A770", Offset = "0x2029B70", Length = "0x9E")]
	[Token(Token = "0x600084D")]
	public static long Clamp(long value, long min, long max) { }

	[Address(RVA = "0x202A6C0", Offset = "0x2029AC0", Length = "0xA1")]
	[Token(Token = "0x600084E")]
	public static float Clamp(float value, float min, float max) { }

	[Address(RVA = "0x202A8B0", Offset = "0x2029CB0", Length = "0x5")]
	[Token(Token = "0x6000878")]
	public static double Cos(double d) { }

	[Address(RVA = "0x202A8C0", Offset = "0x2029CC0", Length = "0x5")]
	[Token(Token = "0x6000879")]
	public static double Cosh(double value) { }

	[Address(RVA = "0x202A8D0", Offset = "0x2029CD0", Length = "0x17")]
	[Token(Token = "0x600084B")]
	public static int DivRem(int a, int b, out int result) { }

	[Address(RVA = "0x202A8F0", Offset = "0x2029CF0", Length = "0x5")]
	[Token(Token = "0x600087A")]
	public static double Exp(double d) { }

	[Address(RVA = "0x202A900", Offset = "0x2029D00", Length = "0x5")]
	[Token(Token = "0x600087B")]
	public static double Floor(double d) { }

	[Address(RVA = "0x202A930", Offset = "0x2029D30", Length = "0xFC")]
	[Token(Token = "0x600084F")]
	public static double Log(double a, double newBase) { }

	[Address(RVA = "0x202A920", Offset = "0x2029D20", Length = "0x5")]
	[Token(Token = "0x600087C")]
	public static double Log(double d) { }

	[Address(RVA = "0x202A910", Offset = "0x2029D10", Length = "0x5")]
	[Token(Token = "0x600087D")]
	public static double Log10(double d) { }

	[Address(RVA = "0x202AA60", Offset = "0x2029E60", Length = "0xB")]
	[CLSCompliant(False)]
	[NonVersionable]
	[Token(Token = "0x6000858")]
	public static ushort Max(ushort val1, ushort val2) { }

	[Address(RVA = "0x202AA50", Offset = "0x2029E50", Length = "0x8")]
	[CLSCompliant(False)]
	[NonVersionable]
	[Token(Token = "0x6000859")]
	public static uint Max(uint val1, uint val2) { }

	[Address(RVA = "0x202AAC0", Offset = "0x2029EC0", Length = "0xB")]
	[CLSCompliant(False)]
	[NonVersionable]
	[Token(Token = "0x600085A")]
	public static ulong Max(ulong val1, ulong val2) { }

	[Address(RVA = "0x202AA30", Offset = "0x2029E30", Length = "0xE")]
	[NonVersionable]
	[Token(Token = "0x6000850")]
	public static byte Max(byte val1, byte val2) { }

	[Address(RVA = "0x202AB00", Offset = "0x2029F00", Length = "0x8F")]
	[Token(Token = "0x6000851")]
	public static decimal Max(decimal val1, decimal val2) { }

	[Address(RVA = "0x202AA70", Offset = "0x2029E70", Length = "0x2B")]
	[Token(Token = "0x6000852")]
	public static double Max(double val1, double val2) { }

	[Address(RVA = "0x202AAB0", Offset = "0x2029EB0", Length = "0xE")]
	[CLSCompliant(False)]
	[NonVersionable]
	[Token(Token = "0x6000856")]
	public static sbyte Max(sbyte val1, sbyte val2) { }

	[Address(RVA = "0x202AAA0", Offset = "0x2029EA0", Length = "0xB")]
	[NonVersionable]
	[Token(Token = "0x6000853")]
	public static short Max(short val1, short val2) { }

	[Address(RVA = "0x202AA40", Offset = "0x2029E40", Length = "0x8")]
	[NonVersionable]
	[Token(Token = "0x6000854")]
	public static int Max(int val1, int val2) { }

	[Address(RVA = "0x202AAF0", Offset = "0x2029EF0", Length = "0xB")]
	[NonVersionable]
	[Token(Token = "0x6000855")]
	public static long Max(long val1, long val2) { }

	[Address(RVA = "0x202AAD0", Offset = "0x2029ED0", Length = "0x18")]
	[Token(Token = "0x6000857")]
	public static float Max(float val1, float val2) { }

	[Address(RVA = "0x202AC40", Offset = "0x202A040", Length = "0x8")]
	[NonVersionable]
	[Token(Token = "0x600085F")]
	public static int Min(int val1, int val2) { }

	[Address(RVA = "0x202ABA0", Offset = "0x2029FA0", Length = "0xB")]
	[CLSCompliant(False)]
	[NonVersionable]
	[Token(Token = "0x6000865")]
	public static ulong Min(ulong val1, ulong val2) { }

	[Address(RVA = "0x202AC50", Offset = "0x202A050", Length = "0x8")]
	[CLSCompliant(False)]
	[NonVersionable]
	[Token(Token = "0x6000864")]
	public static uint Min(uint val1, uint val2) { }

	[Address(RVA = "0x202AC90", Offset = "0x202A090", Length = "0xB")]
	[CLSCompliant(False)]
	[NonVersionable]
	[Token(Token = "0x6000863")]
	public static ushort Min(ushort val1, ushort val2) { }

	[Address(RVA = "0x202ACB0", Offset = "0x202A0B0", Length = "0x18")]
	[Token(Token = "0x6000862")]
	public static float Min(float val1, float val2) { }

	[Address(RVA = "0x202AB90", Offset = "0x2029F90", Length = "0xE")]
	[CLSCompliant(False)]
	[NonVersionable]
	[Token(Token = "0x6000861")]
	public static sbyte Min(sbyte val1, sbyte val2) { }

	[Address(RVA = "0x202ACA0", Offset = "0x202A0A0", Length = "0xB")]
	[NonVersionable]
	[Token(Token = "0x6000860")]
	public static long Min(long val1, long val2) { }

	[Address(RVA = "0x202AC20", Offset = "0x202A020", Length = "0xB")]
	[NonVersionable]
	[Token(Token = "0x600085E")]
	public static short Min(short val1, short val2) { }

	[Address(RVA = "0x202AC60", Offset = "0x202A060", Length = "0x2B")]
	[Token(Token = "0x600085D")]
	public static double Min(double val1, double val2) { }

	[Address(RVA = "0x202ABB0", Offset = "0x2029FB0", Length = "0x70")]
	[Token(Token = "0x600085C")]
	public static decimal Min(decimal val1, decimal val2) { }

	[Address(RVA = "0x202AC30", Offset = "0x202A030", Length = "0xE")]
	[NonVersionable]
	[Token(Token = "0x600085B")]
	public static byte Min(byte val1, byte val2) { }

	[Address(RVA = "0x202ACD0", Offset = "0x202A0D0", Length = "0x5")]
	[Token(Token = "0x6000884")]
	private static double ModF(double x, Double* intptr) { }

	[Address(RVA = "0x202ACE0", Offset = "0x202A0E0", Length = "0x5")]
	[Token(Token = "0x600087E")]
	public static double Pow(double x, double y) { }

	[Address(RVA = "0x202ACF0", Offset = "0x202A0F0", Length = "0x5B")]
	[Token(Token = "0x6000868")]
	public static double Round(double value, int digits) { }

	[Address(RVA = "0x202AD50", Offset = "0x202A150", Length = "0x321")]
	[Token(Token = "0x600086A")]
	public static double Round(double value, int digits, MidpointRounding mode) { }

	[Address(RVA = "0x202B080", Offset = "0x202A480", Length = "0x5B")]
	[Token(Token = "0x6000869")]
	public static double Round(double value, MidpointRounding mode) { }

	[Address(RVA = "0x202B0E0", Offset = "0x202A4E0", Length = "0x5")]
	[Token(Token = "0x6000867")]
	public static double Round(double a) { }

	[Address(RVA = "0x202B0F0", Offset = "0x202A4F0", Length = "0x72")]
	[Token(Token = "0x6000866")]
	public static decimal Round(decimal d) { }

	[Address(RVA = "0x202B220", Offset = "0x202A620", Length = "0x85")]
	[Token(Token = "0x600086D")]
	public static int Sign(float value) { }

	[Address(RVA = "0x202B200", Offset = "0x202A600", Length = "0x11")]
	[Token(Token = "0x600086C")]
	public static int Sign(long value) { }

	[Address(RVA = "0x202B170", Offset = "0x202A570", Length = "0x88")]
	[Token(Token = "0x600086B")]
	public static int Sign(double value) { }

	[Address(RVA = "0x202B2B0", Offset = "0x202A6B0", Length = "0x5")]
	[Token(Token = "0x600087F")]
	public static double Sin(double a) { }

	[Address(RVA = "0x202B2C0", Offset = "0x202A6C0", Length = "0x5")]
	[Token(Token = "0x6000880")]
	public static double Sinh(double value) { }

	[Address(RVA = "0x202B2D0", Offset = "0x202A6D0", Length = "0x13")]
	[Token(Token = "0x6000881")]
	public static double Sqrt(double d) { }

	[Address(RVA = "0x202B2F0", Offset = "0x202A6F0", Length = "0x5")]
	[Token(Token = "0x6000882")]
	public static double Tan(double a) { }

	[Address(RVA = "0x202B300", Offset = "0x202A700", Length = "0x5")]
	[Token(Token = "0x6000883")]
	public static double Tanh(double value) { }

	[Address(RVA = "0x202B310", Offset = "0x202A710", Length = "0x4E")]
	[StackTraceHidden]
	[Token(Token = "0x600084A")]
	private static void ThrowAbsOverflow() { }

	[Address(RVA = "0x864ED0", Offset = "0x8642D0", Length = "0xA9")]
	[Token(Token = "0x6000870")]
	private static void ThrowMinMaxException(T min, T max) { }

	[Address(RVA = "0x202B360", Offset = "0x202A760", Length = "0x66")]
	[Token(Token = "0x600086F")]
	public static double Truncate(double d) { }

	[Address(RVA = "0x202B3D0", Offset = "0x202A7D0", Length = "0x6F")]
	[Token(Token = "0x600086E")]
	public static decimal Truncate(decimal d) { }

}

