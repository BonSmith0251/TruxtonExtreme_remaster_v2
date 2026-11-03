namespace KANAI.Kernel;

[Token(Token = "0x2000031")]
public static class RandomUtility
{
	[Token(Token = "0x40000CD")]
	public const int DefaultSeed = 5489; //Field offset: 0x0
	[Token(Token = "0x40000CE")]
	private static Random _rng; //Field offset: 0x0
	[Token(Token = "0x40000CF")]
	private static bool _initialized; //Field offset: 0x4

	[Address(RVA = "0x1DF1060", Offset = "0x1DF0460", Length = "0x9C")]
	[Token(Token = "0x6000194")]
	public static Quaternion GetRandom() { }

	[Address(RVA = "0x1DF1100", Offset = "0x1DF0500", Length = "0x11A")]
	[Token(Token = "0x6000188")]
	public static void Initialize(int seed = 5489) { }

	[Address(RVA = "0x1DF1350", Offset = "0x1DF0750", Length = "0x57")]
	[Token(Token = "0x600018A")]
	public static int Make() { }

	[Address(RVA = "0x1DF1220", Offset = "0x1DF0620", Length = "0x67")]
	[Token(Token = "0x600018B")]
	public static float Make01() { }

	[Address(RVA = "0x1DF1290", Offset = "0x1DF0690", Length = "0x53")]
	[Token(Token = "0x6000189")]
	public static uint Make32() { }

	[Address(RVA = "0x1DF12F0", Offset = "0x1DF06F0", Length = "0x60")]
	[Token(Token = "0x600018D")]
	public static int MakeSign() { }

	[Address(RVA = "0x1DF13B0", Offset = "0x1DF07B0", Length = "0x8B")]
	[Token(Token = "0x600018C")]
	public static double NextDouble() { }

	[Address(RVA = "0x1DF1780", Offset = "0x1DF0B80", Length = "0xAA")]
	[Token(Token = "0x600018E")]
	public static int Range(int t0, int t1) { }

	[Address(RVA = "0x1DF1830", Offset = "0x1DF0C30", Length = "0x9B")]
	[Token(Token = "0x600018F")]
	public static float Range(float t0, float t1) { }

	[Address(RVA = "0x1DF1660", Offset = "0x1DF0A60", Length = "0xA0")]
	[Token(Token = "0x6000190")]
	public static Vector3 Range(Vector3 tmin, Vector3 tmax) { }

	[Address(RVA = "0x1DF1700", Offset = "0x1DF0B00", Length = "0x78")]
	[Token(Token = "0x6000191")]
	public static float Range(float tv) { }

	[Address(RVA = "0x1DF14F0", Offset = "0x1DF08F0", Length = "0x164")]
	[Token(Token = "0x6000192")]
	public static Vector3 Range(Vector3 tvec) { }

	[Address(RVA = "0x1DF1440", Offset = "0x1DF0840", Length = "0xA7")]
	[Token(Token = "0x6000193")]
	public static Vector3 RangeD(Vector3 tvec) { }

}

