namespace Mono.Math;

[Token(Token = "0x2000055")]
public class BigInteger
{
	[Token(Token = "0x2000058")]
	private sealed class Kernel
	{

		[Address(RVA = "0x1E4CA00", Offset = "0x1E4BE00", Length = "0x14B")]
		[Token(Token = "0x6000214")]
		public static Sign Compare(BigInteger bi1, BigInteger bi2) { }

		[Address(RVA = "0x1E4CB50", Offset = "0x1E4BF50", Length = "0x258")]
		[Token(Token = "0x6000217")]
		public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

		[Address(RVA = "0x1E4B720", Offset = "0x1E4AB20", Length = "0x58")]
		[Token(Token = "0x6000216")]
		public static uint DwordMod(BigInteger n, uint d) { }

		[Address(RVA = "0x1E4CDB0", Offset = "0x1E4C1B0", Length = "0x2DA")]
		[Token(Token = "0x6000219")]
		public static BigInteger LeftShift(BigInteger bi, int n) { }

		[Address(RVA = "0x1E4D090", Offset = "0x1E4C490", Length = "0x116")]
		[Token(Token = "0x6000212")]
		public static void MinusEq(BigInteger big, BigInteger small) { }

		[Address(RVA = "0x1E4DAD0", Offset = "0x1E4CED0", Length = "0x11D")]
		[Token(Token = "0x600021D")]
		public static uint modInverse(BigInteger bi, uint modulus) { }

		[Address(RVA = "0x1E4DBF0", Offset = "0x1E4CFF0", Length = "0x965")]
		[Token(Token = "0x600021E")]
		public static BigInteger modInverse(BigInteger bi, BigInteger modulus) { }

		[Address(RVA = "0x1E4E560", Offset = "0x1E4D960", Length = "0x7EE")]
		[Token(Token = "0x6000218")]
		public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

		[Address(RVA = "0x1E4D2F0", Offset = "0x1E4C6F0", Length = "0x11B")]
		[Token(Token = "0x600021B")]
		public static void Multiply(UInt32[] x, uint xOffset, uint xLen, UInt32[] y, uint yOffset, uint yLen, UInt32[] d, uint dOffset) { }

		[Address(RVA = "0x1E4D1B0", Offset = "0x1E4C5B0", Length = "0x135")]
		[Token(Token = "0x600021C")]
		public static void MultiplyMod2p32pmod(UInt32[] x, int xOffset, int xLen, UInt32[] y, int yOffest, int yLen, UInt32[] d, int dOffset, int mod) { }

		[Address(RVA = "0x1E4D410", Offset = "0x1E4C810", Length = "0x1B5")]
		[Token(Token = "0x6000213")]
		public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

		[Address(RVA = "0x1E4D5D0", Offset = "0x1E4C9D0", Length = "0x232")]
		[Token(Token = "0x600021A")]
		public static BigInteger RightShift(BigInteger bi, int n) { }

		[Address(RVA = "0x1E4D810", Offset = "0x1E4CC10", Length = "0xA8")]
		[Token(Token = "0x6000215")]
		public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

		[Address(RVA = "0x1E4D8C0", Offset = "0x1E4CCC0", Length = "0x206")]
		[Token(Token = "0x6000211")]
		public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	}

	[Token(Token = "0x2000057")]
	internal sealed class ModulusRing
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400024F")]
		private BigInteger mod; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000250")]
		private BigInteger constant; //Field offset: 0x18

		[Address(RVA = "0x1E51B60", Offset = "0x1E50F60", Length = "0x158")]
		[Token(Token = "0x600020B")]
		public ModulusRing(BigInteger modulus) { }

		[Address(RVA = "0x1E50FF0", Offset = "0x1E503F0", Length = "0x485")]
		[Token(Token = "0x600020C")]
		public void BarrettReduction(BigInteger x) { }

		[Address(RVA = "0x1E51480", Offset = "0x1E50880", Length = "0x20F")]
		[Token(Token = "0x600020E")]
		public BigInteger Difference(BigInteger a, BigInteger b) { }

		[Address(RVA = "0x1E51690", Offset = "0x1E50A90", Length = "0x2C0")]
		[Token(Token = "0x600020D")]
		public BigInteger Multiply(BigInteger a, BigInteger b) { }

		[Address(RVA = "0x1E519E0", Offset = "0x1E50DE0", Length = "0x178")]
		[Token(Token = "0x600020F")]
		public BigInteger Pow(BigInteger a, BigInteger k) { }

		[Address(RVA = "0x1E51960", Offset = "0x1E50D60", Length = "0x79")]
		[CLSCompliant(False)]
		[Token(Token = "0x6000210")]
		public BigInteger Pow(uint b, BigInteger exp) { }

	}

	[Token(Token = "0x2000056")]
	internal enum Sign : int
	{
		Negative = -1,
		Zero = 0,
		Positive = 1,
	}

	[Token(Token = "0x4000249")]
	internal static readonly UInt32[] smallPrimes; //Field offset: 0x0
	[Token(Token = "0x400024A")]
	private static RandomNumberGenerator rng; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000247")]
	private uint length; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000248")]
	private UInt32[] data; //Field offset: 0x18

	[Token(Token = "0x17000086")]
	private static RandomNumberGenerator Rng
	{
		[Address(RVA = "0x1E4B1D0", Offset = "0x1E4A5D0", Length = "0xDB")]
		[Token(Token = "0x60001EE")]
		private get { } //Length: 219
	}

	[Address(RVA = "0x1E4ABE0", Offset = "0x1E49FE0", Length = "0x8C")]
	[Token(Token = "0x600020A")]
	private static BigInteger() { }

	[Address(RVA = "0x1E4B070", Offset = "0x1E4A470", Length = "0x80")]
	[CLSCompliant(False)]
	[Token(Token = "0x60001E4")]
	public BigInteger(uint ui) { }

	[Address(RVA = "0x1E4ADD0", Offset = "0x1E4A1D0", Length = "0x292")]
	[Token(Token = "0x60001E3")]
	public BigInteger(Byte[] inData) { }

	[Address(RVA = "0x1E4AD60", Offset = "0x1E4A160", Length = "0x69")]
	[CLSCompliant(False)]
	[Token(Token = "0x60001E0")]
	public BigInteger(Sign sign, uint len) { }

	[Address(RVA = "0x1E4AC70", Offset = "0x1E4A070", Length = "0xE1")]
	[Token(Token = "0x60001E1")]
	public BigInteger(BigInteger bi) { }

	[Address(RVA = "0x1E4B100", Offset = "0x1E4A500", Length = "0xC4")]
	[CLSCompliant(False)]
	[Token(Token = "0x60001E2")]
	public BigInteger(BigInteger bi, uint len) { }

	[Address(RVA = "0x1E49BC0", Offset = "0x1E48FC0", Length = "0xA2")]
	[Token(Token = "0x60001F1")]
	public int BitCount() { }

	[Address(RVA = "0x1E49C70", Offset = "0x1E49070", Length = "0x54")]
	[Token(Token = "0x6000202")]
	public void Clear() { }

	[Address(RVA = "0x1E49CD0", Offset = "0x1E490D0", Length = "0x158")]
	[Token(Token = "0x6000205")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x1E49E30", Offset = "0x1E49230", Length = "0x6E")]
	[Token(Token = "0x6000208")]
	public static BigInteger GeneratePseudoPrime(int bits) { }

	[Address(RVA = "0x1E4A090", Offset = "0x1E49490", Length = "0x10A")]
	[Token(Token = "0x60001F0")]
	public static BigInteger GenerateRandom(int bits) { }

	[Address(RVA = "0x1E49EA0", Offset = "0x1E492A0", Length = "0x1E3")]
	[Token(Token = "0x60001EF")]
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	[Address(RVA = "0x1E4B1D0", Offset = "0x1E4A5D0", Length = "0xDB")]
	[Token(Token = "0x60001EE")]
	private static RandomNumberGenerator get_Rng() { }

	[Address(RVA = "0x1E4A1A0", Offset = "0x1E495A0", Length = "0x1CA")]
	[Token(Token = "0x60001F6")]
	public Byte[] GetBytes() { }

	[Address(RVA = "0x1E4A370", Offset = "0x1E49770", Length = "0x3E")]
	[Token(Token = "0x6000203")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1E4A3B0", Offset = "0x1E497B0", Length = "0x9F")]
	[Token(Token = "0x6000209")]
	public void Incr2() { }

	[Address(RVA = "0x1E4A450", Offset = "0x1E49850", Length = "0xEB")]
	[Token(Token = "0x60001F5")]
	public int LowestSetBit() { }

	[Address(RVA = "0x1E4A540", Offset = "0x1E49940", Length = "0x8")]
	[Token(Token = "0x6000206")]
	public BigInteger ModInverse(BigInteger modulus) { }

	[Address(RVA = "0x1E4A550", Offset = "0x1E49950", Length = "0x85")]
	[Token(Token = "0x6000207")]
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	[Address(RVA = "0x1E4A5E0", Offset = "0x1E499E0", Length = "0x49")]
	[Token(Token = "0x6000201")]
	private void Normalize() { }

	[Address(RVA = "0x1E4B2B0", Offset = "0x1E4A6B0", Length = "0x2B")]
	[Token(Token = "0x60001EA")]
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	[Address(RVA = "0x1E4B2E0", Offset = "0x1E4A6E0", Length = "0x7C")]
	[CLSCompliant(False)]
	[Token(Token = "0x60001F7")]
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	[Address(RVA = "0x1E4B360", Offset = "0x1E4A760", Length = "0xB5")]
	[Token(Token = "0x60001F9")]
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	[Address(RVA = "0x1E4B440", Offset = "0x1E4A840", Length = "0x16")]
	[Token(Token = "0x60001FB")]
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	[Address(RVA = "0x1E4B420", Offset = "0x1E4A820", Length = "0x16")]
	[Token(Token = "0x60001FD")]
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[Address(RVA = "0x1E4B460", Offset = "0x1E4A860", Length = "0x52")]
	[CLSCompliant(False)]
	[Token(Token = "0x60001E5")]
	public static BigInteger op_Implicit(uint value) { }

	[Address(RVA = "0x1E4B4C0", Offset = "0x1E4A8C0", Length = "0x9F")]
	[Token(Token = "0x60001E6")]
	public static BigInteger op_Implicit(int value) { }

	[Address(RVA = "0x1E4B560", Offset = "0x1E4A960", Length = "0xB5")]
	[Token(Token = "0x60001FA")]
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	[Address(RVA = "0x1E4B620", Offset = "0x1E4AA20", Length = "0x7C")]
	[CLSCompliant(False)]
	[Token(Token = "0x60001F8")]
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	[Address(RVA = "0x1E4B6A0", Offset = "0x1E4AAA0", Length = "0x8")]
	[Token(Token = "0x60001EC")]
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	[Address(RVA = "0x1E4B6D0", Offset = "0x1E4AAD0", Length = "0x14")]
	[Token(Token = "0x60001FC")]
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	[Address(RVA = "0x1E4B6B0", Offset = "0x1E4AAB0", Length = "0x16")]
	[Token(Token = "0x60001FE")]
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[Address(RVA = "0x1E4B720", Offset = "0x1E4AB20", Length = "0x58")]
	[CLSCompliant(False)]
	[Token(Token = "0x60001E8")]
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	[Address(RVA = "0x1E4B6F0", Offset = "0x1E4AAF0", Length = "0x2B")]
	[Token(Token = "0x60001E9")]
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	[Address(RVA = "0x1E4B780", Offset = "0x1E4AB80", Length = "0x30F")]
	[Token(Token = "0x60001EB")]
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	[Address(RVA = "0x1E4BA90", Offset = "0x1E4AE90", Length = "0x8")]
	[Token(Token = "0x60001ED")]
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	[Address(RVA = "0x1E4BAA0", Offset = "0x1E4AEA0", Length = "0x2DB")]
	[Token(Token = "0x60001E7")]
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	[Address(RVA = "0x1E4A630", Offset = "0x1E49A30", Length = "0x43")]
	[CLSCompliant(False)]
	[Token(Token = "0x60001F3")]
	public void SetBit(uint bitNum) { }

	[Address(RVA = "0x1E4A680", Offset = "0x1E49A80", Length = "0x5F")]
	[CLSCompliant(False)]
	[Token(Token = "0x60001F4")]
	public void SetBit(uint bitNum, bool value) { }

	[Address(RVA = "0x1E4A6E0", Offset = "0x1E49AE0", Length = "0x9E")]
	[Token(Token = "0x60001F2")]
	public bool TestBit(int bitNum) { }

	[Address(RVA = "0x1E4AB40", Offset = "0x1E49F40", Length = "0x49")]
	[CLSCompliant(False)]
	[Token(Token = "0x60001FF")]
	public string ToString(uint radix) { }

	[Address(RVA = "0x1E4AB90", Offset = "0x1E49F90", Length = "0x41")]
	[Token(Token = "0x6000204")]
	public virtual string ToString() { }

	[Address(RVA = "0x1E4A780", Offset = "0x1E49B80", Length = "0x3B2")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000200")]
	public string ToString(uint radix, string characterSet) { }

}

