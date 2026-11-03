namespace Unity.Burst;

[Token(Token = "0x200001E")]
internal static class BurstString
{
	[Token(Token = "0x2000026")]
	internal enum CutoffMode : int
	{
		Unique = 0,
		TotalLength = 1,
		FractionLength = 2,
	}

	[Token(Token = "0x2000023")]
	internal struct FormatOptions
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000EA")]
		public NumberFormatKind Kind; //Field offset: 0x0
		[FieldOffset(Offset = "0x1")]
		[Token(Token = "0x40000EB")]
		public sbyte AlignAndSize; //Field offset: 0x1
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x40000EC")]
		public byte Specifier; //Field offset: 0x2
		[FieldOffset(Offset = "0x3")]
		[Token(Token = "0x40000ED")]
		public bool Lowercase; //Field offset: 0x3

		[Token(Token = "0x17000017")]
		public bool Uppercase
		{
			[Address(RVA = "0x23F2A80", Offset = "0x23F1E80", Length = "0x8")]
			[Token(Token = "0x60000CA")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x131FF40", Offset = "0x131F340", Length = "0x13")]
		[Token(Token = "0x60000C9")]
		public FormatOptions(NumberFormatKind kind, sbyte alignAndSize, byte specifier, bool lowercase) { }

		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x60000CB")]
		public int EncodeToRaw() { }

		[Address(RVA = "0x23F2A80", Offset = "0x23F1E80", Length = "0x8")]
		[Token(Token = "0x60000CA")]
		public bool get_Uppercase() { }

		[Address(RVA = "0x27C45F0", Offset = "0x27C39F0", Length = "0x11")]
		[Token(Token = "0x60000CC")]
		public int GetBase() { }

		[Address(RVA = "0x27C4610", Offset = "0x27C3A10", Length = "0x3A0")]
		[Token(Token = "0x60000CD")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x2000021")]
	private struct NumberBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000E0")]
		private readonly Byte* _buffer; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000E1")]
		public NumberBufferKind Kind; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40000E2")]
		public int DigitsCount; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000E3")]
		public int Scale; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40000E4")]
		public readonly bool IsNegative; //Field offset: 0x14

		[Address(RVA = "0x27E5590", Offset = "0x27E4990", Length = "0x1A")]
		[Token(Token = "0x60000C7")]
		public NumberBuffer(NumberBufferKind kind, Byte* buffer, int digitsCount, int scale, bool isNegative) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x60000C8")]
		public Byte* GetDigitsPointer() { }

	}

	[Token(Token = "0x2000020")]
	private enum NumberBufferKind : int
	{
		Integer = 0,
		Float = 1,
	}

	[Token(Token = "0x2000022")]
	internal enum NumberFormatKind : byte
	{
		General = 0,
		Decimal = 1,
		DecimalForceSigned = 2,
		Hexadecimal = 3,
	}

	[Token(Token = "0x200001F")]
	public class PreserveAttribute : Attribute
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60000C6")]
		public PreserveAttribute() { }

	}

	[Token(Token = "0x2000027")]
	internal enum PrintFloatFormat : int
	{
		Positional = 0,
		Scientific = 1,
	}

	[Token(Token = "0x2000024")]
	internal struct tBigInt
	{
		[CompilerGenerated]
		[Token(Token = "0x2000025")]
		[UnsafeValueType]
		internal struct <m_blocks>e__FixedBuffer
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40000F1")]
			public uint FixedElementField; //Field offset: 0x0

		}

		[Token(Token = "0x40000EE")]
		private const int c_BigInt_MaxBlocks = 35; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000EF")]
		public int m_length; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[FixedBuffer(typeof(uint), 35)]
		[Token(Token = "0x40000F0")]
		public <m_blocks>e__FixedBuffer m_blocks; //Field offset: 0x4

		[Address(RVA = "0x27E5CD0", Offset = "0x27E50D0", Length = "0x8")]
		[Token(Token = "0x60000CF")]
		public uint GetBlock(int idx) { }

		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x60000CE")]
		public int GetLength() { }

		[Address(RVA = "0x27E5CE0", Offset = "0x27E50E0", Length = "0xC")]
		[Token(Token = "0x60000D4")]
		public uint GetU32() { }

		[Address(RVA = "0x23E3B10", Offset = "0x23E2F10", Length = "0x7")]
		[Token(Token = "0x60000D1")]
		public bool IsZero() { }

		[Address(RVA = "0x27E5CF0", Offset = "0x27E50F0", Length = "0x11")]
		[Token(Token = "0x60000D3")]
		public void SetU32(uint val) { }

		[Address(RVA = "0x27E5D10", Offset = "0x27E5110", Length = "0x2D")]
		[Token(Token = "0x60000D2")]
		public void SetU64(ulong val) { }

		[Address(RVA = "0x1CA23C0", Offset = "0x1CA17C0", Length = "0x7")]
		[Token(Token = "0x60000D0")]
		public void SetZero() { }

	}

	[Token(Token = "0x2000028")]
	internal struct tFloatUnion32
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000F9")]
		public float m_floatingPoint; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000FA")]
		public uint m_integer; //Field offset: 0x0

		[Address(RVA = "0x27E5D40", Offset = "0x27E5140", Length = "0x9")]
		[Token(Token = "0x60000D6")]
		public uint GetExponent() { }

		[Address(RVA = "0x27E5D50", Offset = "0x27E5150", Length = "0x8")]
		[Token(Token = "0x60000D7")]
		public uint GetMantissa() { }

		[Address(RVA = "0x209A540", Offset = "0x2099940", Length = "0x6")]
		[Token(Token = "0x60000D5")]
		public bool IsNegative() { }

	}

	[Token(Token = "0x2000029")]
	internal struct tFloatUnion64
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000FB")]
		public double m_floatingPoint; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000FC")]
		public ulong m_integer; //Field offset: 0x0

		[Address(RVA = "0x27E5D60", Offset = "0x27E5160", Length = "0xD")]
		[Token(Token = "0x60000D9")]
		public uint GetExponent() { }

		[Address(RVA = "0x27E5D70", Offset = "0x27E5170", Length = "0x11")]
		[Token(Token = "0x60000DA")]
		public ulong GetMantissa() { }

		[Address(RVA = "0x27E5D90", Offset = "0x27E5190", Length = "0x11")]
		[Token(Token = "0x60000D8")]
		public bool IsNegative() { }

	}

	[Token(Token = "0x40000D2")]
	private static readonly Char[] SplitByColon; //Field offset: 0x0
	[Token(Token = "0x40000D7")]
	private const int SinglePrecision = 9; //Field offset: 0x0
	[Token(Token = "0x40000D8")]
	private const int DoublePrecision = 17; //Field offset: 0x0
	[Token(Token = "0x40000D9")]
	internal const int SingleNumberBufferLength = 10; //Field offset: 0x0
	[Token(Token = "0x40000DA")]
	internal const int DoubleNumberBufferLength = 18; //Field offset: 0x0
	[Token(Token = "0x40000DB")]
	private const int SinglePrecisionCustomFormat = 7; //Field offset: 0x0
	[Token(Token = "0x40000DC")]
	private const int DoublePrecisionCustomFormat = 15; //Field offset: 0x0
	[Token(Token = "0x40000D3")]
	private static readonly Byte[] logTable; //Field offset: 0x8
	[Token(Token = "0x40000D4")]
	private static readonly UInt32[] g_PowerOf10_U32; //Field offset: 0x10
	[Token(Token = "0x40000D5")]
	private static readonly Byte[] InfinityString; //Field offset: 0x18
	[Token(Token = "0x40000D6")]
	private static readonly Byte[] NanString; //Field offset: 0x20

	[Address(RVA = "0x27C3F80", Offset = "0x27C3380", Length = "0x226")]
	[Token(Token = "0x60000C5")]
	private static BurstString() { }

	[Address(RVA = "0x27BF250", Offset = "0x27BE650", Length = "0x32")]
	[Token(Token = "0x60000AA")]
	private static bool AlignLeft(Byte* dest, ref int destIndex, int destLength, int align, int length) { }

	[Address(RVA = "0x27BF290", Offset = "0x27BE690", Length = "0x94")]
	[Token(Token = "0x60000A9")]
	private static bool AlignRight(Byte* dest, ref int destIndex, int destLength, int align, int length) { }

	[Address(RVA = "0x27BF400", Offset = "0x27BE800", Length = "0x85")]
	[Token(Token = "0x60000B1")]
	private static void BigInt_Add(out tBigInt pResult, in tBigInt lhs, in tBigInt rhs) { }

	[Address(RVA = "0x27BF330", Offset = "0x27BE730", Length = "0xC5")]
	[Token(Token = "0x60000B2")]
	private static void BigInt_Add_internal(out tBigInt pResult, in tBigInt pLarge, in tBigInt pSmall) { }

	[Address(RVA = "0x27BF490", Offset = "0x27BE890", Length = "0x5F")]
	[Token(Token = "0x60000B0")]
	private static int BigInt_Compare(in tBigInt lhs, in tBigInt rhs) { }

	[Address(RVA = "0x27BF4F0", Offset = "0x27BE8F0", Length = "0x1D4")]
	[Token(Token = "0x60000BD")]
	private static uint BigInt_DivideWithRemainder_MaxQuotient9(ref tBigInt pDividend, in tBigInt divisor) { }

	[Address(RVA = "0x27BFC70", Offset = "0x27BF070", Length = "0x85")]
	[Token(Token = "0x60000B3")]
	private static void BigInt_Multiply(out tBigInt pResult, in tBigInt lhs, in tBigInt rhs) { }

	[Address(RVA = "0x27BFBF0", Offset = "0x27BEFF0", Length = "0x7A")]
	[Token(Token = "0x60000B5")]
	private static void BigInt_Multiply(out tBigInt pResult, in tBigInt lhs, uint rhs) { }

	[Address(RVA = "0x27BFAF0", Offset = "0x27BEEF0", Length = "0xF1")]
	[Token(Token = "0x60000B4")]
	private static void BigInt_Multiply_internal(out tBigInt pResult, in tBigInt pLarge, in tBigInt pSmall) { }

	[Address(RVA = "0x27BF6D0", Offset = "0x27BEAD0", Length = "0x38")]
	[Token(Token = "0x60000B8")]
	private static void BigInt_Multiply10(ref tBigInt pResult) { }

	[Address(RVA = "0x27BF710", Offset = "0x27BEB10", Length = "0x61")]
	[Token(Token = "0x60000B6")]
	private static void BigInt_Multiply2(out tBigInt pResult, in tBigInt input) { }

	[Address(RVA = "0x27BF780", Offset = "0x27BEB80", Length = "0x47")]
	[Token(Token = "0x60000B7")]
	private static void BigInt_Multiply2(ref tBigInt pResult) { }

	[Address(RVA = "0x27BF7D0", Offset = "0x27BEBD0", Length = "0x317")]
	[Token(Token = "0x60000BB")]
	private static void BigInt_MultiplyPow10(out tBigInt pResult, in tBigInt input, uint exponent) { }

	[Address(RVA = "0x27BFD00", Offset = "0x27BF100", Length = "0x269")]
	[Token(Token = "0x60000BA")]
	private static void BigInt_Pow10(out tBigInt pResult, uint exponent) { }

	[Address(RVA = "0x27BFF70", Offset = "0x27BF370", Length = "0x5D")]
	[Token(Token = "0x60000BC")]
	private static void BigInt_Pow2(out tBigInt pResult, uint exponent) { }

	[Address(RVA = "0x27BFFD0", Offset = "0x27BF3D0", Length = "0x19A")]
	[Token(Token = "0x60000BE")]
	private static void BigInt_ShiftLeft(ref tBigInt pResult, uint shift) { }

	[Address(RVA = "0x27C0170", Offset = "0x27BF570", Length = "0x2B7")]
	[Token(Token = "0x60000C4")]
	private static void ConvertDoubleToString(Byte* dest, ref int destIndex, int destLength, double value, FormatOptions formatOptions) { }

	[Address(RVA = "0x27C0430", Offset = "0x27BF830", Length = "0x297")]
	[Token(Token = "0x60000C3")]
	private static void ConvertFloatToString(Byte* dest, ref int destIndex, int destLength, float value, FormatOptions formatOptions) { }

	[Address(RVA = "0x27C06D0", Offset = "0x27BFAD0", Length = "0x1BC")]
	[Token(Token = "0x60000A3")]
	private static void ConvertIntegerToString(Byte* dest, ref int destIndex, int destLength, long value, FormatOptions options) { }

	[Address(RVA = "0x27C0890", Offset = "0x27BFC90", Length = "0x1A2")]
	[Token(Token = "0x60000A1")]
	private static void ConvertUnsignedIntegerToString(Byte* dest, ref int destIndex, int destLength, ulong value, FormatOptions options) { }

	[Address(RVA = "0x27C0A40", Offset = "0x27BFE40", Length = "0x23")]
	[Preserve]
	[Token(Token = "0x6000093")]
	public static void CopyFixedString(Byte* dest, int destLength, Byte* src, int srcLength) { }

	[Address(RVA = "0x27C0A70", Offset = "0x27BFE70", Length = "0x1334")]
	[Token(Token = "0x60000BF")]
	private static uint Dragon4(ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, CutoffMode cutoffMode, uint cutoffNumber, Byte* pOutBuffer, uint bufferSize, out int pOutExponent) { }

	[Address(RVA = "0x27C3070", Offset = "0x27C2470", Length = "0x7F")]
	[Preserve]
	[Token(Token = "0x600009B")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, uint value, int formatOptionsRaw) { }

	[Address(RVA = "0x27C2F70", Offset = "0x27C2370", Length = "0x100")]
	[Preserve]
	[Token(Token = "0x6000094")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, Byte* src, int srcLength, int formatOptionsRaw) { }

	[Address(RVA = "0x27C33C0", Offset = "0x27C27C0", Length = "0x7F")]
	[Preserve]
	[Token(Token = "0x6000095")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, float value, int formatOptionsRaw) { }

	[Address(RVA = "0x27C30F0", Offset = "0x27C24F0", Length = "0x7F")]
	[Preserve]
	[Token(Token = "0x6000096")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, double value, int formatOptionsRaw) { }

	[Address(RVA = "0x27C3170", Offset = "0x27C2570", Length = "0x172")]
	[Preserve]
	[Token(Token = "0x6000097")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, bool value, int formatOptionsRaw) { }

	[Address(RVA = "0x27C29E0", Offset = "0x27C1DE0", Length = "0x1D2")]
	[Preserve]
	[Token(Token = "0x6000098")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, char value, int formatOptionsRaw) { }

	[Address(RVA = "0x27C3440", Offset = "0x27C2840", Length = "0xB1")]
	[Preserve]
	[Token(Token = "0x6000099")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, byte value, int formatOptionsRaw) { }

	[Address(RVA = "0x27C32F0", Offset = "0x27C26F0", Length = "0xC7")]
	[Preserve]
	[Token(Token = "0x60000A0")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, long value, int formatOptionsRaw) { }

	[Address(RVA = "0x27C2DD0", Offset = "0x27C21D0", Length = "0xC7")]
	[Preserve]
	[Token(Token = "0x600009F")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, int value, int formatOptionsRaw) { }

	[Address(RVA = "0x27C2EA0", Offset = "0x27C22A0", Length = "0xC9")]
	[Preserve]
	[Token(Token = "0x600009E")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, short value, int formatOptionsRaw) { }

	[Address(RVA = "0x27C2D00", Offset = "0x27C2100", Length = "0xC9")]
	[Preserve]
	[Token(Token = "0x600009D")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, sbyte value, int formatOptionsRaw) { }

	[Address(RVA = "0x27C2BC0", Offset = "0x27C1FC0", Length = "0x7F")]
	[Preserve]
	[Token(Token = "0x600009C")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, ulong value, int formatOptionsRaw) { }

	[Address(RVA = "0x27C2C40", Offset = "0x27C2040", Length = "0xB1")]
	[Preserve]
	[Token(Token = "0x600009A")]
	public static void Format(Byte* dest, ref int destIndex, int destLength, ushort value, int formatOptionsRaw) { }

	[Address(RVA = "0x27C1DB0", Offset = "0x27C11B0", Length = "0xA5")]
	[Token(Token = "0x60000A5")]
	private static void FormatDecimalOrHexadecimal(Byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int zeroPadding, bool outputPositiveSign) { }

	[Address(RVA = "0x27C1E60", Offset = "0x27C1260", Length = "0x18D")]
	[Token(Token = "0x60000AC")]
	private static void FormatGeneral(Byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int nMaxDigits, byte expChar) { }

	[Address(RVA = "0x27C1FF0", Offset = "0x27C13F0", Length = "0x1E5")]
	[Token(Token = "0x60000C2")]
	private static void FormatInfinityNaN(Byte* dest, ref int destIndex, int destLength, ulong mantissa, bool isNegative, FormatOptions formatOptions) { }

	[Address(RVA = "0x27C21E0", Offset = "0x27C15E0", Length = "0x3A4")]
	[Token(Token = "0x60000A4")]
	private static void FormatNumber(Byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int nMaxDigits, FormatOptions options) { }

	[Address(RVA = "0x27C2590", Offset = "0x27C1990", Length = "0x21D")]
	[Token(Token = "0x60000C0")]
	private static int FormatPositional(Byte* pOutBuffer, uint bufferSize, ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, int precision) { }

	[Address(RVA = "0x27C27B0", Offset = "0x27C1BB0", Length = "0x22E")]
	[Token(Token = "0x60000C1")]
	private static int FormatScientific(Byte* pOutBuffer, uint bufferSize, ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, int precision) { }

	[Address(RVA = "0x27C41B0", Offset = "0x27C35B0", Length = "0x1C9")]
	[Token(Token = "0x60000B9")]
	private static tBigInt g_PowerOf10_Big(int i) { }

	[Address(RVA = "0x27C3500", Offset = "0x27C2900", Length = "0x13F")]
	[Token(Token = "0x60000AB")]
	private static int GetLengthForFormatGeneral(ref NumberBuffer number, int nMaxDigits) { }

	[Address(RVA = "0x27C3640", Offset = "0x27C2A40", Length = "0x30")]
	[Token(Token = "0x60000A2")]
	private static int GetLengthIntegerToString(long value, int basis, int zeroPadding) { }

	[Address(RVA = "0x27C3670", Offset = "0x27C2A70", Length = "0x169")]
	[Token(Token = "0x60000AF")]
	private static uint LogBase2(uint val) { }

	[Address(RVA = "0x27C37E0", Offset = "0x27C2BE0", Length = "0x1B9")]
	[Token(Token = "0x60000A7")]
	private static void OptsSplit(string fullFormat, out string padding, out string format) { }

	[Address(RVA = "0x27C39A0", Offset = "0x27C2DA0", Length = "0x457")]
	[Token(Token = "0x60000A8")]
	public static FormatOptions ParseFormatToFormatOptions(string fullFormat) { }

	[Address(RVA = "0x27C3E00", Offset = "0x27C3200", Length = "0x111")]
	[Token(Token = "0x60000AD")]
	private static void RoundNumber(ref NumberBuffer number, int pos, bool isCorrectlyRounded) { }

	[Address(RVA = "0x27C3F20", Offset = "0x27C3320", Length = "0x23")]
	[Token(Token = "0x60000AE")]
	private static bool ShouldRoundUp(Byte* dig, int i, bool isCorrectlyRounded) { }

	[Address(RVA = "0x27C3F50", Offset = "0x27C3350", Length = "0x25")]
	[Token(Token = "0x60000A6")]
	private static byte ValueToIntegerChar(int value, bool uppercase) { }

}

