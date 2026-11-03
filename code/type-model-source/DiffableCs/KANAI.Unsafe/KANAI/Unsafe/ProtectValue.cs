namespace KANAI.Unsafe;

[Token(Token = "0x2000004")]
public class ProtectValue
{
	[Token(Token = "0x4000006")]
	private static readonly long SEED32; //Field offset: 0x0
	[Token(Token = "0x4000007")]
	private static readonly long SEED64; //Field offset: 0x8
	[Token(Token = "0x4000008")]
	private static readonly long FSEED64; //Field offset: 0x10

	[Address(RVA = "0x1E2ADF0", Offset = "0x1E2A1F0", Length = "0x78")]
	[Token(Token = "0x600000E")]
	private static ProtectValue() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600000D")]
	public ProtectValue() { }

	[Address(RVA = "0x1E2AA10", Offset = "0x1E29E10", Length = "0x5")]
	[Token(Token = "0x6000008")]
	public static int Conversion(int v, int seed) { }

	[Address(RVA = "0x1E2AB20", Offset = "0x1E29F20", Length = "0x7")]
	[Token(Token = "0x6000009")]
	public static long Conversion(long v, long seed) { }

	[Address(RVA = "0x1E2AB10", Offset = "0x1E29F10", Length = "0xB")]
	[Token(Token = "0x600000A")]
	public static float Conversion(float v, int seed) { }

	[Address(RVA = "0x1E2AB30", Offset = "0x1E29F30", Length = "0xE")]
	[Token(Token = "0x600000B")]
	public static double Conversion(double v, long seed) { }

	[Address(RVA = "0x1E2AA20", Offset = "0x1E29E20", Length = "0xEA")]
	[Token(Token = "0x600000C")]
	public static string Conversion(string s, char seed) { }

	[Address(RVA = "0x1E2AB40", Offset = "0x1E29F40", Length = "0x54")]
	[Token(Token = "0x6000003")]
	public static int Mask(int v) { }

	[Address(RVA = "0x1E2AD90", Offset = "0x1E2A190", Length = "0x58")]
	[Token(Token = "0x6000004")]
	public static long Mask(long v) { }

	[Address(RVA = "0x1E2ABA0", Offset = "0x1E29FA0", Length = "0x63")]
	[Token(Token = "0x6000005")]
	public static float Mask(float v) { }

	[Address(RVA = "0x1E2AC10", Offset = "0x1E2A010", Length = "0x66")]
	[Token(Token = "0x6000006")]
	public static double Mask(double v) { }

	[Address(RVA = "0x1E2AC80", Offset = "0x1E2A080", Length = "0x107")]
	[Token(Token = "0x6000007")]
	public static string Mask(string v) { }

}

