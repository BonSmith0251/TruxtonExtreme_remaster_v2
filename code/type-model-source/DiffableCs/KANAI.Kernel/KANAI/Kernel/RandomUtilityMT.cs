namespace KANAI.Kernel;

[Token(Token = "0x2000032")]
public static class RandomUtilityMT
{
	[Token(Token = "0x40000D0")]
	private const int N = 624; //Field offset: 0x0
	[Token(Token = "0x40000D1")]
	private const int M = 397; //Field offset: 0x0
	[Token(Token = "0x40000D2")]
	private const uint MATRIX_A = 2567483615; //Field offset: 0x0
	[Token(Token = "0x40000D3")]
	private const uint UPPER_MASK = 2147483648; //Field offset: 0x0
	[Token(Token = "0x40000D4")]
	private const uint LOWER_MASK = 2147483647; //Field offset: 0x0
	[Token(Token = "0x40000D5")]
	private static UInt32[] mt; //Field offset: 0x0
	[Token(Token = "0x40000D6")]
	private static UInt32[] mag01; //Field offset: 0x8
	[Token(Token = "0x40000D7")]
	private static int mti; //Field offset: 0x10

	[Address(RVA = "0x1DF07A0", Offset = "0x1DEFBA0", Length = "0xD8")]
	[Token(Token = "0x60001A4")]
	private static RandomUtilityMT() { }

	[Address(RVA = "0x1DF0880", Offset = "0x1DEFC80", Length = "0x392")]
	[Token(Token = "0x6000197")]
	private static uint genrand_int32() { }

	[Address(RVA = "0x1DF0C20", Offset = "0x1DF0020", Length = "0x2F2")]
	[Token(Token = "0x6000196")]
	public static void init_by_array(UInt32[] init_key) { }

	[Address(RVA = "0x1DF0F20", Offset = "0x1DF0320", Length = "0x13F")]
	[Token(Token = "0x6000195")]
	private static void init_genrand(uint s) { }

	[Address(RVA = "0x1DF0040", Offset = "0x1DEF440", Length = "0xAE")]
	[Token(Token = "0x6000198")]
	public static void Initialize(int seed) { }

	[Address(RVA = "0x1DF0250", Offset = "0x1DEF650", Length = "0x45")]
	[Token(Token = "0x600019A")]
	public static int Make() { }

	[Address(RVA = "0x1DF00F0", Offset = "0x1DEF4F0", Length = "0x85")]
	[Token(Token = "0x600019B")]
	public static float Make01() { }

	[Address(RVA = "0x1DF0180", Offset = "0x1DEF580", Length = "0x40")]
	[Token(Token = "0x6000199")]
	public static uint Make32() { }

	[Address(RVA = "0x1DF01C0", Offset = "0x1DEF5C0", Length = "0x83")]
	[Token(Token = "0x600019D")]
	public static int MakeSign() { }

	[Address(RVA = "0x1DF02A0", Offset = "0x1DEF6A0", Length = "0x86")]
	[Token(Token = "0x600019C")]
	public static double NextDouble() { }

	[Address(RVA = "0x1DF04F0", Offset = "0x1DEF8F0", Length = "0xA4")]
	[Token(Token = "0x600019E")]
	public static int Range(int t0, int t1) { }

	[Address(RVA = "0x1DF0690", Offset = "0x1DEFA90", Length = "0x108")]
	[Token(Token = "0x600019F")]
	public static float Range(float t0, float t1) { }

	[Address(RVA = "0x1DF0410", Offset = "0x1DEF810", Length = "0xD1")]
	[Token(Token = "0x60001A0")]
	public static Vector3 Range(Vector3 tmin, Vector3 tmax) { }

	[Address(RVA = "0x1DF0630", Offset = "0x1DEFA30", Length = "0x52")]
	[Token(Token = "0x60001A1")]
	public static float Range(float tv) { }

	[Address(RVA = "0x1DF05A0", Offset = "0x1DEF9A0", Length = "0x8E")]
	[Token(Token = "0x60001A2")]
	public static Vector3 Range(Vector3 tvec) { }

	[Address(RVA = "0x1DF0330", Offset = "0x1DEF730", Length = "0xDC")]
	[Token(Token = "0x60001A3")]
	public static Vector3 RangeD(Vector3 tvec) { }

}

