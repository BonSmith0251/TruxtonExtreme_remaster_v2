namespace System.Numerics;

[IsReadOnly]
[Token(Token = "0x2000003")]
public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger>
{
	[Token(Token = "0x2000004")]
	private enum GetBytesMode : int
	{
		AllocateArray = 0,
		Count = 1,
		Span = 2,
	}

	[Token(Token = "0x4000003")]
	private static readonly BigInteger s_bnMinInt; //Field offset: 0x0
	[Token(Token = "0x4000004")]
	private static readonly BigInteger s_bnOneInt; //Field offset: 0x10
	[Token(Token = "0x4000005")]
	private static readonly BigInteger s_bnZeroInt; //Field offset: 0x20
	[Token(Token = "0x4000006")]
	private static readonly BigInteger s_bnMinusOneInt; //Field offset: 0x30
	[Token(Token = "0x4000007")]
	private static readonly Byte[] s_success; //Field offset: 0x40
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000001")]
	internal readonly int _sign; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000002")]
	internal readonly UInt32[] _bits; //Field offset: 0x8

	[Token(Token = "0x17000003")]
	public bool IsZero
	{
		[Address(RVA = "0x23E3B10", Offset = "0x23E2F10", Length = "0x7")]
		[Token(Token = "0x600000F")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000002")]
	public static BigInteger MinusOne
	{
		[Address(RVA = "0x23E3B20", Offset = "0x23E2F20", Length = "0x5B")]
		[Token(Token = "0x600000E")]
		 get { } //Length: 91
	}

	[Token(Token = "0x17000001")]
	public static BigInteger Zero
	{
		[Address(RVA = "0x23E3B80", Offset = "0x23E2F80", Length = "0x5B")]
		[Token(Token = "0x600000D")]
		 get { } //Length: 91
	}

	[Address(RVA = "0x23E24E0", Offset = "0x23E18E0", Length = "0x298")]
	[Token(Token = "0x6000048")]
	private static BigInteger() { }

	[Address(RVA = "0x23E2780", Offset = "0x23E1B80", Length = "0x1D9")]
	[Token(Token = "0x600000C")]
	internal BigInteger(UInt32[] value, bool negative) { }

	[Address(RVA = "0xAEE390", Offset = "0xAED790", Length = "0x12")]
	[Token(Token = "0x600000B")]
	internal BigInteger(int n, UInt32[] rgu) { }

	[Address(RVA = "0x23E33C0", Offset = "0x23E27C0", Length = "0x6CB")]
	[Token(Token = "0x600000A")]
	public BigInteger(ReadOnlySpan<Byte> value, bool isUnsigned = false, bool isBigEndian = false) { }

	[Address(RVA = "0x23E2960", Offset = "0x23E1D60", Length = "0xE4")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000009")]
	public BigInteger(Byte[] value) { }

	[Address(RVA = "0x23E2F10", Offset = "0x23E2310", Length = "0x1E8")]
	[Token(Token = "0x6000008")]
	public BigInteger(decimal value) { }

	[Address(RVA = "0x23E3A90", Offset = "0x23E2E90", Length = "0x80")]
	[Token(Token = "0x6000002")]
	public BigInteger(int value) { }

	[Address(RVA = "0x23E3100", Offset = "0x23E2500", Length = "0x5E")]
	[Token(Token = "0x6000006")]
	public BigInteger(float value) { }

	[Address(RVA = "0x23E2A50", Offset = "0x23E1E50", Length = "0x11E")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000005")]
	public BigInteger(ulong value) { }

	[Address(RVA = "0x23E3160", Offset = "0x23E2560", Length = "0x198")]
	[Token(Token = "0x6000004")]
	public BigInteger(long value) { }

	[Address(RVA = "0x23E3300", Offset = "0x23E2700", Length = "0xB0")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000003")]
	public BigInteger(uint value) { }

	[Address(RVA = "0x23E2B70", Offset = "0x23E1F70", Length = "0x391")]
	[Token(Token = "0x6000007")]
	public BigInteger(double value) { }

	[Address(RVA = "0x23E0E50", Offset = "0x23E0250", Length = "0x1B1")]
	[Token(Token = "0x6000021")]
	private static BigInteger Add(UInt32[] leftBits, int leftSign, UInt32[] rightBits, int rightSign) { }

	[Address(RVA = "0x23E11D0", Offset = "0x23E05D0", Length = "0xA7")]
	[Token(Token = "0x6000016")]
	public int CompareTo(long other) { }

	[Address(RVA = "0x23E1010", Offset = "0x23E0410", Length = "0x1BC")]
	[Token(Token = "0x6000017")]
	public override int CompareTo(BigInteger other) { }

	[Address(RVA = "0x23E1280", Offset = "0x23E0680", Length = "0x106")]
	[Token(Token = "0x6000018")]
	public override int CompareTo(object obj) { }

	[Address(RVA = "0x23E1540", Offset = "0x23E0940", Length = "0xA8")]
	[Token(Token = "0x6000013")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x23E14B0", Offset = "0x23E08B0", Length = "0x80")]
	[Token(Token = "0x6000014")]
	public bool Equals(long other) { }

	[Address(RVA = "0x23E1390", Offset = "0x23E0790", Length = "0x111")]
	[Token(Token = "0x6000015")]
	public override bool Equals(BigInteger other) { }

	[Address(RVA = "0x23E3B10", Offset = "0x23E2F10", Length = "0x7")]
	[Token(Token = "0x600000F")]
	public bool get_IsZero() { }

	[Address(RVA = "0x23E3B20", Offset = "0x23E2F20", Length = "0x5B")]
	[Token(Token = "0x600000E")]
	public static BigInteger get_MinusOne() { }

	[Address(RVA = "0x23E3B80", Offset = "0x23E2F80", Length = "0x5B")]
	[Token(Token = "0x600000D")]
	public static BigInteger get_Zero() { }

	[Address(RVA = "0x23E15F0", Offset = "0x23E09F0", Length = "0x63")]
	[Token(Token = "0x6000047")]
	internal static int GetDiffLength(UInt32[] rgu1, UInt32[] rgu2, int cu) { }

	[Address(RVA = "0x23E1660", Offset = "0x23E0A60", Length = "0x54")]
	[Token(Token = "0x6000012")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x23E16C0", Offset = "0x23E0AC0", Length = "0xCD")]
	[Token(Token = "0x6000046")]
	private static bool GetPartsForBitManipulation(ref BigInteger x, out UInt32[] xd, out int xl) { }

	[Address(RVA = "0x23E3BE0", Offset = "0x23E2FE0", Length = "0x206")]
	[Token(Token = "0x600003A")]
	public static BigInteger op_Addition(BigInteger left, BigInteger right) { }

	[Address(RVA = "0x23E3DF0", Offset = "0x23E31F0", Length = "0x3EA")]
	[Token(Token = "0x600003C")]
	public static BigInteger op_Division(BigInteger dividend, BigInteger divisor) { }

	[Address(RVA = "0x23E41E0", Offset = "0x23E35E0", Length = "0x5A")]
	[Token(Token = "0x6000042")]
	public static bool op_Equality(BigInteger left, long right) { }

	[Address(RVA = "0x23E45C0", Offset = "0x23E39C0", Length = "0x13F")]
	[Token(Token = "0x6000034")]
	public static float op_Explicit(BigInteger value) { }

	[Address(RVA = "0x23E48D0", Offset = "0x23E3CD0", Length = "0xBB")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000033")]
	public static ulong op_Explicit(BigInteger value) { }

	[Address(RVA = "0x23E4A90", Offset = "0x23E3E90", Length = "0x121")]
	[Token(Token = "0x6000032")]
	public static long op_Explicit(BigInteger value) { }

	[Address(RVA = "0x23E4700", Offset = "0x23E3B00", Length = "0xA0")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000031")]
	public static uint op_Explicit(BigInteger value) { }

	[Address(RVA = "0x23E42C0", Offset = "0x23E36C0", Length = "0x149")]
	[Token(Token = "0x6000036")]
	public static decimal op_Explicit(BigInteger value) { }

	[Address(RVA = "0x23E4410", Offset = "0x23E3810", Length = "0x121")]
	[Token(Token = "0x6000030")]
	public static int op_Explicit(BigInteger value) { }

	[Address(RVA = "0x23E4990", Offset = "0x23E3D90", Length = "0x7E")]
	[CLSCompliant(False)]
	[Token(Token = "0x600002F")]
	public static ushort op_Explicit(BigInteger value) { }

	[Address(RVA = "0x23E4240", Offset = "0x23E3640", Length = "0x7E")]
	[Token(Token = "0x600002E")]
	public static short op_Explicit(BigInteger value) { }

	[Address(RVA = "0x23E4540", Offset = "0x23E3940", Length = "0x7C")]
	[CLSCompliant(False)]
	[Token(Token = "0x600002D")]
	public static sbyte op_Explicit(BigInteger value) { }

	[Address(RVA = "0x23E4A10", Offset = "0x23E3E10", Length = "0x7E")]
	[Token(Token = "0x600002C")]
	public static byte op_Explicit(BigInteger value) { }

	[Address(RVA = "0x23E47B0", Offset = "0x23E3BB0", Length = "0x113")]
	[Token(Token = "0x6000035")]
	public static double op_Explicit(BigInteger value) { }

	[Address(RVA = "0x23E4C10", Offset = "0x23E4010", Length = "0x20")]
	[CLSCompliant(False)]
	[Token(Token = "0x600002B")]
	public static BigInteger op_Implicit(ulong value) { }

	[Address(RVA = "0x23E4BC0", Offset = "0x23E3FC0", Length = "0x20")]
	[Token(Token = "0x6000028")]
	public static BigInteger op_Implicit(int value) { }

	[Address(RVA = "0x23E4C30", Offset = "0x23E4030", Length = "0x20")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000029")]
	public static BigInteger op_Implicit(uint value) { }

	[Address(RVA = "0x23E4CB0", Offset = "0x23E40B0", Length = "0x20")]
	[Token(Token = "0x600002A")]
	public static BigInteger op_Implicit(long value) { }

	[Address(RVA = "0x23E4C80", Offset = "0x23E4080", Length = "0x23")]
	[Token(Token = "0x6000024")]
	public static BigInteger op_Implicit(byte value) { }

	[Address(RVA = "0x23E4BE0", Offset = "0x23E3FE0", Length = "0x23")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000025")]
	public static BigInteger op_Implicit(sbyte value) { }

	[Address(RVA = "0x23E4CD0", Offset = "0x23E40D0", Length = "0x23")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000027")]
	public static BigInteger op_Implicit(ushort value) { }

	[Address(RVA = "0x23E4C50", Offset = "0x23E4050", Length = "0x23")]
	[Token(Token = "0x6000026")]
	public static BigInteger op_Implicit(short value) { }

	[Address(RVA = "0x23E4D00", Offset = "0x23E4100", Length = "0x5C")]
	[Token(Token = "0x6000043")]
	public static bool op_Inequality(BigInteger left, long right) { }

	[Address(RVA = "0x23E4D60", Offset = "0x23E4160", Length = "0x66")]
	[Token(Token = "0x600003F")]
	public static bool op_Inequality(BigInteger left, BigInteger right) { }

	[Address(RVA = "0x23E4DD0", Offset = "0x23E41D0", Length = "0x334")]
	[Token(Token = "0x6000037")]
	public static BigInteger op_LeftShift(BigInteger value, int shift) { }

	[Address(RVA = "0x23E5240", Offset = "0x23E4640", Length = "0x5F")]
	[Token(Token = "0x6000044")]
	public static bool op_LessThan(long left, BigInteger right) { }

	[Address(RVA = "0x23E52A0", Offset = "0x23E46A0", Length = "0x5D")]
	[Token(Token = "0x6000040")]
	public static bool op_LessThan(BigInteger left, long right) { }

	[Address(RVA = "0x23E51E0", Offset = "0x23E45E0", Length = "0x5F")]
	[Token(Token = "0x6000045")]
	public static bool op_LessThanOrEqual(long left, BigInteger right) { }

	[Address(RVA = "0x23E5180", Offset = "0x23E4580", Length = "0x5F")]
	[Token(Token = "0x6000041")]
	public static bool op_LessThanOrEqual(BigInteger left, long right) { }

	[Address(RVA = "0x23E5110", Offset = "0x23E4510", Length = "0x69")]
	[Token(Token = "0x600003E")]
	public static bool op_LessThanOrEqual(BigInteger left, BigInteger right) { }

	[Address(RVA = "0x23E5300", Offset = "0x23E4700", Length = "0x2FE")]
	[Token(Token = "0x600003D")]
	public static BigInteger op_Modulus(BigInteger dividend, BigInteger divisor) { }

	[Address(RVA = "0x23E5600", Offset = "0x23E4A00", Length = "0x319")]
	[Token(Token = "0x600003B")]
	public static BigInteger op_Multiply(BigInteger left, BigInteger right) { }

	[Address(RVA = "0x23E5920", Offset = "0x23E4D20", Length = "0x503")]
	[Token(Token = "0x6000038")]
	public static BigInteger op_RightShift(BigInteger value, int shift) { }

	[Address(RVA = "0x23E5E30", Offset = "0x23E5230", Length = "0x204")]
	[Token(Token = "0x6000022")]
	public static BigInteger op_Subtraction(BigInteger left, BigInteger right) { }

	[Address(RVA = "0x23E6040", Offset = "0x23E5440", Length = "0x30")]
	[Token(Token = "0x6000039")]
	public static BigInteger op_UnaryNegation(BigInteger value) { }

	[Address(RVA = "0x23E1830", Offset = "0x23E0C30", Length = "0x57")]
	[Token(Token = "0x6000011")]
	public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider) { }

	[Address(RVA = "0x23E1790", Offset = "0x23E0B90", Length = "0x98")]
	[Token(Token = "0x6000010")]
	public static BigInteger Parse(string value, IFormatProvider provider) { }

	[Address(RVA = "0x23E1890", Offset = "0x23E0C90", Length = "0x219")]
	[Token(Token = "0x6000023")]
	private static BigInteger Subtract(UInt32[] leftBits, int leftSign, UInt32[] rightBits, int rightSign) { }

	[Address(RVA = "0x23E1AB0", Offset = "0x23E0EB0", Length = "0xA2")]
	[Token(Token = "0x600001A")]
	public Byte[] ToByteArray(bool isUnsigned = false, bool isBigEndian = false) { }

	[Address(RVA = "0x23E1B60", Offset = "0x23E0F60", Length = "0x4F")]
	[Token(Token = "0x6000019")]
	public Byte[] ToByteArray() { }

	[Address(RVA = "0x23E1BB0", Offset = "0x23E0FB0", Length = "0xBC")]
	[Token(Token = "0x600001E")]
	public virtual string ToString() { }

	[Address(RVA = "0x23E1C70", Offset = "0x23E1070", Length = "0xC2")]
	[Token(Token = "0x600001F")]
	public string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x23E1D40", Offset = "0x23E1140", Length = "0xF8")]
	[Token(Token = "0x6000020")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x23E1E40", Offset = "0x23E1240", Length = "0x529")]
	[Token(Token = "0x600001D")]
	private Byte[] TryGetBytes(GetBytesMode mode, Span<Byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten) { }

	[Address(RVA = "0x23E2370", Offset = "0x23E1770", Length = "0xB6")]
	[Token(Token = "0x600001B")]
	public bool TryWriteBytes(Span<Byte> destination, out int bytesWritten, bool isUnsigned = false, bool isBigEndian = false) { }

	[Address(RVA = "0x23E2430", Offset = "0x23E1830", Length = "0xAB")]
	[Token(Token = "0x600001C")]
	internal bool TryWriteOrCountBytes(Span<Byte> destination, out int bytesWritten, bool isUnsigned = false, bool isBigEndian = false) { }

}

