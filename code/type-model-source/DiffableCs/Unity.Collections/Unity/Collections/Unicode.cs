namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x20000E8")]
public struct Unicode
{
	[GenerateTestsForBurstCompatibility]
	[Token(Token = "0x20000E9")]
	internal struct Rune
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000456")]
		public int value; //Field offset: 0x0

		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x6000A2E")]
		public Rune(int codepoint) { }

		[Address(RVA = "0x28CD180", Offset = "0x28CC580", Length = "0x7F")]
		[ExcludeFromBurstCompatTesting("Takes managed object")]
		[Token(Token = "0x6000A31")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x6000A32")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x28CD200", Offset = "0x28CC600", Length = "0xA")]
		[Token(Token = "0x6000A35")]
		internal bool IsAscii() { }

		[Address(RVA = "0x28CD220", Offset = "0x28CC620", Length = "0xF")]
		[Token(Token = "0x6000A34")]
		public static bool IsDigit(Rune r) { }

		[Address(RVA = "0x28CD210", Offset = "0x28CC610", Length = "0xF")]
		[Token(Token = "0x6000A37")]
		internal bool IsDigit() { }

		[Address(RVA = "0x28CD230", Offset = "0x28CC630", Length = "0xA")]
		[Token(Token = "0x6000A36")]
		internal bool IsLatin1() { }

		[Address(RVA = "0x28CD240", Offset = "0x28CC640", Length = "0x65")]
		[Token(Token = "0x6000A38")]
		internal bool IsWhiteSpace() { }

		[Address(RVA = "0x28CD2B0", Offset = "0x28CC6B0", Length = "0x33")]
		[Token(Token = "0x6000A3B")]
		public int LengthInUtf8Bytes() { }

		[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
		[Token(Token = "0x6000A30")]
		public static bool op_Equality(Rune lhs, Rune rhs) { }

		[Address(RVA = "0x60A370", Offset = "0x609770", Length = "0x4")]
		[Token(Token = "0x6000A2F")]
		public static Rune op_Implicit(char codepoint) { }

		[Address(RVA = "0x639780", Offset = "0x638B80", Length = "0x6")]
		[Token(Token = "0x6000A33")]
		public static bool op_Inequality(Rune lhs, Rune rhs) { }

		[Address(RVA = "0x28CD2F0", Offset = "0x28CC6F0", Length = "0x19")]
		[Token(Token = "0x6000A39")]
		internal Rune ToLowerAscii() { }

		[Address(RVA = "0x28CD310", Offset = "0x28CC710", Length = "0x1B")]
		[Token(Token = "0x6000A3A")]
		internal Rune ToUpperAscii() { }

	}

	[Token(Token = "0x4000455")]
	public const int kMaximumValidCodePoint = 1114111; //Field offset: 0x0

	[Token(Token = "0x1700012E")]
	public static Rune BadRune
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000A20")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700012D")]
	public static Rune ReplacementCharacter
	{
		[Address(RVA = "0x28D0E60", Offset = "0x28D0260", Length = "0x6")]
		[Token(Token = "0x6000A1F")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x28D0580", Offset = "0x28CF980", Length = "0x36")]
	[Token(Token = "0x6000A2D")]
	private static int CountRunes(Byte* utf8Buffer, int utf8Length, int maxRunes = 2147483647) { }

	[Address(RVA = "0x28D05C0", Offset = "0x28CF9C0", Length = "0x25")]
	[Token(Token = "0x6000A22")]
	private static int FindUtf8CharStartInReverse(Byte* ptr, ref int index) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000A20")]
	public static Rune get_BadRune() { }

	[Address(RVA = "0x28D0E60", Offset = "0x28D0260", Length = "0x6")]
	[Token(Token = "0x6000A1F")]
	public static Rune get_ReplacementCharacter() { }

	[Address(RVA = "0x1F90A50", Offset = "0x1F8FE50", Length = "0x19")]
	[Token(Token = "0x6000A24")]
	private static bool IsLeadingSurrogate(char c) { }

	[Address(RVA = "0x1F90C50", Offset = "0x1F90050", Length = "0x19")]
	[Token(Token = "0x6000A25")]
	private static bool IsTrailingSurrogate(char c) { }

	[Address(RVA = "0x28D05F0", Offset = "0x28CF9F0", Length = "0xA")]
	[Token(Token = "0x6000A1D")]
	public static bool IsValidCodePoint(int codepoint) { }

	[Address(RVA = "0x28D0600", Offset = "0x28CFA00", Length = "0xA")]
	[Token(Token = "0x6000A1E")]
	public static bool NotTrailer(byte b) { }

	[Address(RVA = "0x28D0610", Offset = "0x28CFA10", Length = "0x24")]
	[Token(Token = "0x6000A27")]
	internal static ConversionError UcsToUcs(out Rune rune, Rune* buffer, ref int index, int capacity) { }

	[Address(RVA = "0x28D0640", Offset = "0x28CFA40", Length = "0x99")]
	[Token(Token = "0x6000A29")]
	public static ConversionError UcsToUtf16(Char* buffer, ref int index, int capacity, Rune rune) { }

	[Address(RVA = "0x28D06E0", Offset = "0x28CFAE0", Length = "0x104")]
	[Token(Token = "0x6000A28")]
	public static ConversionError UcsToUtf8(Byte* buffer, ref int index, int capacity, Rune rune) { }

	[Address(RVA = "0x28D07F0", Offset = "0x28CFBF0", Length = "0xB3")]
	[Token(Token = "0x6000A26")]
	public static ConversionError Utf16ToUcs(out Rune rune, Char* buffer, ref int index, int capacity) { }

	[Address(RVA = "0x28D08B0", Offset = "0x28CFCB0", Length = "0x12A")]
	[Token(Token = "0x6000A2A")]
	public static ConversionError Utf16ToUtf8(Char* utf16Buffer, int utf16Length, Byte* utf8Buffer, out int utf8Length, int utf8Capacity) { }

	[Address(RVA = "0x28D0A50", Offset = "0x28CFE50", Length = "0x24A")]
	[Token(Token = "0x6000A21")]
	public static ConversionError Utf8ToUcs(out Rune rune, Byte* buffer, ref int index, int capacity) { }

	[Address(RVA = "0x28D09E0", Offset = "0x28CFDE0", Length = "0x6F")]
	[Token(Token = "0x6000A23")]
	internal static ConversionError Utf8ToUcsReverse(out Rune rune, Byte* buffer, ref int index, int capacity) { }

	[Address(RVA = "0x28D0CA0", Offset = "0x28D00A0", Length = "0xFC")]
	[Token(Token = "0x6000A2C")]
	public static ConversionError Utf8ToUtf16(Byte* utf8Buffer, int utf8Length, Char* utf16Buffer, out int utf16Length, int utf16Capacity) { }

	[Address(RVA = "0x28D0DA0", Offset = "0x28D01A0", Length = "0xB6")]
	[Token(Token = "0x6000A2B")]
	public static ConversionError Utf8ToUtf8(Byte* srcBuffer, int srcLength, Byte* destBuffer, out int destLength, int destCapacity) { }

}

