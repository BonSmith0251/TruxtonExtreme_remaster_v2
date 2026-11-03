namespace Mono.Math;

[Token(Token = "0x200006B")]
internal class BigInteger
{
	[Token(Token = "0x200006E")]
	private sealed class Kernel
	{

		[Address(RVA = "0x1E4CA00", Offset = "0x1E4BE00", Length = "0x14B")]
		[Token(Token = "0x60001D4")]
		public static Sign Compare(BigInteger bi1, BigInteger bi2) { }

		[Address(RVA = "0x1E734D0", Offset = "0x1E728D0", Length = "0x258")]
		[Token(Token = "0x60001D7")]
		public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

		[Address(RVA = "0x1E4B720", Offset = "0x1E4AB20", Length = "0x58")]
		[Token(Token = "0x60001D6")]
		public static uint DwordMod(BigInteger n, uint d) { }

		[Address(RVA = "0x1E73730", Offset = "0x1E72B30", Length = "0x2DA")]
		[Token(Token = "0x60001D9")]
		public static BigInteger LeftShift(BigInteger bi, int n) { }

		[Address(RVA = "0x1E4D090", Offset = "0x1E4C490", Length = "0x116")]
		[Token(Token = "0x60001D2")]
		public static void MinusEq(BigInteger big, BigInteger small) { }

		[Address(RVA = "0x1E74950", Offset = "0x1E73D50", Length = "0x11D")]
		[Token(Token = "0x60001DE")]
		public static uint modInverse(BigInteger bi, uint modulus) { }

		[Address(RVA = "0x1E73FE0", Offset = "0x1E733E0", Length = "0x965")]
		[Token(Token = "0x60001DF")]
		public static BigInteger modInverse(BigInteger bi, BigInteger modulus) { }

		[Address(RVA = "0x1E74A70", Offset = "0x1E73E70", Length = "0x7EE")]
		[Token(Token = "0x60001D8")]
		public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

		[Address(RVA = "0x1E4D2F0", Offset = "0x1E4C6F0", Length = "0x11B")]
		[Token(Token = "0x60001DC")]
		public static void Multiply(UInt32[] x, uint xOffset, uint xLen, UInt32[] y, uint yOffset, uint yLen, UInt32[] d, uint dOffset) { }

		[Address(RVA = "0x1E73A10", Offset = "0x1E72E10", Length = "0x170")]
		[Token(Token = "0x60001DB")]
		public static BigInteger MultiplyByDword(BigInteger n, uint f) { }

		[Address(RVA = "0x1E4D1B0", Offset = "0x1E4C5B0", Length = "0x135")]
		[Token(Token = "0x60001DD")]
		public static void MultiplyMod2p32pmod(UInt32[] x, int xOffset, int xLen, UInt32[] y, int yOffest, int yLen, UInt32[] d, int dOffset, int mod) { }

		[Address(RVA = "0x1E4D410", Offset = "0x1E4C810", Length = "0x1B5")]
		[Token(Token = "0x60001D3")]
		public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

		[Address(RVA = "0x1E73B90", Offset = "0x1E72F90", Length = "0x232")]
		[Token(Token = "0x60001DA")]
		public static BigInteger RightShift(BigInteger bi, int n) { }

		[Address(RVA = "0x1E4D810", Offset = "0x1E4CC10", Length = "0xA8")]
		[Token(Token = "0x60001D5")]
		public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

		[Address(RVA = "0x1E73DD0", Offset = "0x1E731D0", Length = "0x206")]
		[Token(Token = "0x60001D1")]
		public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	}

	[Token(Token = "0x200006D")]
	public sealed class ModulusRing
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000201")]
		private BigInteger mod; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000202")]
		private BigInteger constant; //Field offset: 0x18

		[Address(RVA = "0x1E75DD0", Offset = "0x1E751D0", Length = "0x158")]
		[Token(Token = "0x60001CB")]
		public ModulusRing(BigInteger modulus) { }

		[Address(RVA = "0x1E75260", Offset = "0x1E74660", Length = "0x485")]
		[Token(Token = "0x60001CC")]
		public void BarrettReduction(BigInteger x) { }

		[Address(RVA = "0x1E756F0", Offset = "0x1E74AF0", Length = "0x20F")]
		[Token(Token = "0x60001CE")]
		public BigInteger Difference(BigInteger a, BigInteger b) { }

		[Address(RVA = "0x1E75900", Offset = "0x1E74D00", Length = "0x2C0")]
		[Token(Token = "0x60001CD")]
		public BigInteger Multiply(BigInteger a, BigInteger b) { }

		[Address(RVA = "0x1E75BD0", Offset = "0x1E74FD0", Length = "0x178")]
		[Token(Token = "0x60001CF")]
		public BigInteger Pow(BigInteger a, BigInteger k) { }

		[Address(RVA = "0x1E75D50", Offset = "0x1E75150", Length = "0x79")]
		[Token(Token = "0x60001D0")]
		public BigInteger Pow(uint b, BigInteger exp) { }

	}

	[Token(Token = "0x200006C")]
	internal enum Sign : int
	{
		Negative = -1,
		Zero = 0,
		Positive = 1,
	}

	[Token(Token = "0x40001FB")]
	internal static readonly UInt32[] smallPrimes; //Field offset: 0x0
	[Token(Token = "0x40001FC")]
	private static RandomNumberGenerator rng; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001F9")]
	private uint length; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001FA")]
	private UInt32[] data; //Field offset: 0x18

	[Token(Token = "0x1700002B")]
	private static RandomNumberGenerator Rng
	{
		[Address(RVA = "0x1E70640", Offset = "0x1E6FA40", Length = "0xDB")]
		[Token(Token = "0x60001AA")]
		private get { } //Length: 219
	}

	[Address(RVA = "0x1E70050", Offset = "0x1E6F450", Length = "0x8C")]
	[Token(Token = "0x60001CA")]
	private static BigInteger() { }

	[Address(RVA = "0x1E700E0", Offset = "0x1E6F4E0", Length = "0x80")]
	[Token(Token = "0x600019F")]
	public BigInteger(uint ui) { }

	[Address(RVA = "0x1E703A0", Offset = "0x1E6F7A0", Length = "0x292")]
	[Token(Token = "0x600019E")]
	public BigInteger(Byte[] inData) { }

	[Address(RVA = "0x1E70240", Offset = "0x1E6F640", Length = "0x69")]
	[Token(Token = "0x600019B")]
	public BigInteger(Sign sign, uint len) { }

	[Address(RVA = "0x1E702B0", Offset = "0x1E6F6B0", Length = "0xE1")]
	[Token(Token = "0x600019C")]
	public BigInteger(BigInteger bi) { }

	[Address(RVA = "0x1E70170", Offset = "0x1E6F570", Length = "0xC4")]
	[Token(Token = "0x600019D")]
	public BigInteger(BigInteger bi, uint len) { }

	[Address(RVA = "0x1E49BC0", Offset = "0x1E48FC0", Length = "0xA2")]
	[Token(Token = "0x60001AF")]
	public int BitCount() { }

	[Address(RVA = "0x1E49C70", Offset = "0x1E49070", Length = "0x54")]
	[Token(Token = "0x60001C1")]
	public void Clear() { }

	[Address(RVA = "0x1E6EE00", Offset = "0x1E6E200", Length = "0x158")]
	[Token(Token = "0x60001C4")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x1E6EF60", Offset = "0x1E6E360", Length = "0x6E")]
	[Token(Token = "0x60001C8")]
	public static BigInteger GeneratePseudoPrime(int bits) { }

	[Address(RVA = "0x1E6EFD0", Offset = "0x1E6E3D0", Length = "0x52")]
	[Token(Token = "0x60001AC")]
	public static BigInteger GenerateRandom(int bits) { }

	[Address(RVA = "0x1E6F030", Offset = "0x1E6E430", Length = "0x1E3")]
	[Token(Token = "0x60001AB")]
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	[Address(RVA = "0x1E70640", Offset = "0x1E6FA40", Length = "0xDB")]
	[Token(Token = "0x60001AA")]
	private static RandomNumberGenerator get_Rng() { }

	[Address(RVA = "0x1E6F220", Offset = "0x1E6E620", Length = "0x1CA")]
	[Token(Token = "0x60001B5")]
	public Byte[] GetBytes() { }

	[Address(RVA = "0x1E4A370", Offset = "0x1E49770", Length = "0x3E")]
	[Token(Token = "0x60001C2")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1E4A3B0", Offset = "0x1E497B0", Length = "0x9F")]
	[Token(Token = "0x60001C9")]
	public void Incr2() { }

	[Address(RVA = "0x1E6F3F0", Offset = "0x1E6E7F0", Length = "0x2E1")]
	[Token(Token = "0x60001C7")]
	public bool IsProbablePrime() { }

	[Address(RVA = "0x1E6F6E0", Offset = "0x1E6EAE0", Length = "0xEB")]
	[Token(Token = "0x60001B4")]
	public int LowestSetBit() { }

	[Address(RVA = "0x1E6F7D0", Offset = "0x1E6EBD0", Length = "0x8")]
	[Token(Token = "0x60001C5")]
	public BigInteger ModInverse(BigInteger modulus) { }

	[Address(RVA = "0x1E6F7E0", Offset = "0x1E6EBE0", Length = "0x85")]
	[Token(Token = "0x60001C6")]
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	[Address(RVA = "0x1E4A5E0", Offset = "0x1E499E0", Length = "0x49")]
	[Token(Token = "0x60001C0")]
	private void Normalize() { }

	[Address(RVA = "0x1E70720", Offset = "0x1E6FB20", Length = "0x2B")]
	[Token(Token = "0x60001A5")]
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	[Address(RVA = "0x1E4B2E0", Offset = "0x1E4A6E0", Length = "0x7C")]
	[Token(Token = "0x60001B6")]
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	[Address(RVA = "0x1E70750", Offset = "0x1E6FB50", Length = "0xB5")]
	[Token(Token = "0x60001B8")]
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	[Address(RVA = "0x1E4B440", Offset = "0x1E4A840", Length = "0x16")]
	[Token(Token = "0x60001BA")]
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	[Address(RVA = "0x1E4B420", Offset = "0x1E4A820", Length = "0x16")]
	[Token(Token = "0x60001BC")]
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[Address(RVA = "0x1E708B0", Offset = "0x1E6FCB0", Length = "0x52")]
	[Token(Token = "0x60001A0")]
	public static BigInteger op_Implicit(uint value) { }

	[Address(RVA = "0x1E70810", Offset = "0x1E6FC10", Length = "0x9F")]
	[Token(Token = "0x60001A1")]
	public static BigInteger op_Implicit(int value) { }

	[Address(RVA = "0x1E4B620", Offset = "0x1E4AA20", Length = "0x7C")]
	[Token(Token = "0x60001B7")]
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	[Address(RVA = "0x1E70910", Offset = "0x1E6FD10", Length = "0xB5")]
	[Token(Token = "0x60001B9")]
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	[Address(RVA = "0x1E709D0", Offset = "0x1E6FDD0", Length = "0x8")]
	[Token(Token = "0x60001A8")]
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	[Address(RVA = "0x1E4B6D0", Offset = "0x1E4AAD0", Length = "0x14")]
	[Token(Token = "0x60001BB")]
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	[Address(RVA = "0x1E4B6B0", Offset = "0x1E4AAB0", Length = "0x16")]
	[Token(Token = "0x60001BD")]
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[Address(RVA = "0x1E4B720", Offset = "0x1E4AB20", Length = "0x58")]
	[Token(Token = "0x60001A3")]
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	[Address(RVA = "0x1E709E0", Offset = "0x1E6FDE0", Length = "0x2B")]
	[Token(Token = "0x60001A4")]
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	[Address(RVA = "0x1E70A10", Offset = "0x1E6FE10", Length = "0x11F")]
	[Token(Token = "0x60001A7")]
	public static BigInteger op_Multiply(BigInteger bi, int i) { }

	[Address(RVA = "0x1E70B30", Offset = "0x1E6FF30", Length = "0x30F")]
	[Token(Token = "0x60001A6")]
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	[Address(RVA = "0x1E70E40", Offset = "0x1E70240", Length = "0x8")]
	[Token(Token = "0x60001A9")]
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	[Address(RVA = "0x1E70E50", Offset = "0x1E70250", Length = "0x2DB")]
	[Token(Token = "0x60001A2")]
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	[Address(RVA = "0x1E6F870", Offset = "0x1E6EC70", Length = "0x224")]
	[Token(Token = "0x60001AD")]
	public void Randomize(RandomNumberGenerator rng) { }

	[Address(RVA = "0x1E6FAA0", Offset = "0x1E6EEA0", Length = "0x54")]
	[Token(Token = "0x60001AE")]
	public void Randomize() { }

	[Address(RVA = "0x1E4A680", Offset = "0x1E49A80", Length = "0x5F")]
	[Token(Token = "0x60001B3")]
	public void SetBit(uint bitNum, bool value) { }

	[Address(RVA = "0x1E4A630", Offset = "0x1E49A30", Length = "0x43")]
	[Token(Token = "0x60001B2")]
	public void SetBit(uint bitNum) { }

	[Address(RVA = "0x1E6FB40", Offset = "0x1E6EF40", Length = "0x9E")]
	[Token(Token = "0x60001B1")]
	public bool TestBit(int bitNum) { }

	[Address(RVA = "0x1E6FB00", Offset = "0x1E6EF00", Length = "0x3C")]
	[Token(Token = "0x60001B0")]
	public bool TestBit(uint bitNum) { }

	[Address(RVA = "0x1E6FC30", Offset = "0x1E6F030", Length = "0x41")]
	[Token(Token = "0x60001C3")]
	public virtual string ToString() { }

	[Address(RVA = "0x1E6FBE0", Offset = "0x1E6EFE0", Length = "0x49")]
	[Token(Token = "0x60001BE")]
	public string ToString(uint radix) { }

	[Address(RVA = "0x1E6FC80", Offset = "0x1E6F080", Length = "0x3C2")]
	[Token(Token = "0x60001BF")]
	public string ToString(uint radix, string characterSet) { }

}

