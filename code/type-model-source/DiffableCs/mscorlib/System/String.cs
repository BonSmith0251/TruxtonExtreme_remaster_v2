namespace System;

[DefaultMember("Chars")]
[Token(Token = "0x200008D")]
public sealed class string : IComparable, IEnumerable, IEnumerable<Char>, IComparable<String>, IEquatable<String>, IConvertible, ICloneable
{
	[Token(Token = "0x200008F")]
	private struct ProbabilisticMap
	{

	}

	[Token(Token = "0x200008E")]
	private enum TrimType : int
	{
		Head = 0,
		Tail = 1,
		Both = 2,
	}

	[Token(Token = "0x4000241")]
	private const int StackallocIntBufferSizeLimit = 128; //Field offset: 0x0
	[Token(Token = "0x4000242")]
	private const int PROBABILISTICMAP_BLOCK_INDEX_MASK = 7; //Field offset: 0x0
	[Token(Token = "0x4000243")]
	private const int PROBABILISTICMAP_BLOCK_INDEX_SHIFT = 3; //Field offset: 0x0
	[Token(Token = "0x4000244")]
	private const int PROBABILISTICMAP_SIZE = 8; //Field offset: 0x0
	[Token(Token = "0x4000247")]
	public static readonly string Empty; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000245")]
	private int _stringLength; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000246")]
	private char _firstChar; //Field offset: 0x14

	[Token(Token = "0x17000037")]
	public char Chars
	{
		[Address(RVA = "0x1E88D10", Offset = "0x1E88110", Length = "0x42")]
		[Intrinsic]
		[Token(Token = "0x6000319")]
		 get { } //Length: 66
	}

	[Token(Token = "0x17000036")]
	public int Length
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x60002FD")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x1E88BE0", Offset = "0x1E87FE0", Length = "0x5")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000270")]
	public String(SByte* value, int startIndex, int length, Encoding enc) { }

	[Address(RVA = "0x1E88BE0", Offset = "0x1E87FE0", Length = "0x5")]
	[Token(Token = "0x6000265")]
	public String(Char[] value, int startIndex, int length) { }

	[Address(RVA = "0x1E88BE0", Offset = "0x1E87FE0", Length = "0x5")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000267")]
	public String(Char* value) { }

	[Address(RVA = "0x1E88BF0", Offset = "0x1E87FF0", Length = "0x1B")]
	[Token(Token = "0x6000274")]
	public String(ReadOnlySpan<Char> value) { }

	[Address(RVA = "0x1E88BE0", Offset = "0x1E87FE0", Length = "0x5")]
	[Token(Token = "0x6000272")]
	public String(char c, int count) { }

	[Address(RVA = "0x1E88BE0", Offset = "0x1E87FE0", Length = "0x5")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000269")]
	public String(Char* value, int startIndex, int length) { }

	[Address(RVA = "0x1E88BE0", Offset = "0x1E87FE0", Length = "0x5")]
	[CLSCompliant(False)]
	[Token(Token = "0x600026B")]
	public String(SByte* value) { }

	[Address(RVA = "0x1E88BE0", Offset = "0x1E87FE0", Length = "0x5")]
	[CLSCompliant(False)]
	[Token(Token = "0x600026D")]
	public String(SByte* value, int startIndex, int length) { }

	[Address(RVA = "0x1E88BE0", Offset = "0x1E87FE0", Length = "0x5")]
	[Token(Token = "0x6000263")]
	public String(Char[] value) { }

	[Address(RVA = "0x1E7CFD0", Offset = "0x1E7C3D0", Length = "0x4A")]
	[Token(Token = "0x60002EA")]
	private static bool ArrayContains(char searchChar, Char[] anyOf) { }

	[Address(RVA = "0x1E88C20", Offset = "0x1E88020", Length = "0xEC")]
	[Token(Token = "0x6000307")]
	internal static void bzero(Byte* dest, int len) { }

	[Address(RVA = "0x665340", Offset = "0x664740", Length = "0x4")]
	[Token(Token = "0x6000308")]
	internal static void bzero_aligned_1(Byte* dest, int len) { }

	[Address(RVA = "0x1E88C10", Offset = "0x1E88010", Length = "0x6")]
	[Token(Token = "0x6000309")]
	internal static void bzero_aligned_2(Byte* dest, int len) { }

	[Address(RVA = "0x1CA23C0", Offset = "0x1CA17C0", Length = "0x7")]
	[Token(Token = "0x600030A")]
	internal static void bzero_aligned_4(Byte* dest, int len) { }

	[Address(RVA = "0x604930", Offset = "0x603D30", Length = "0x8")]
	[Token(Token = "0x600030B")]
	internal static void bzero_aligned_8(Byte* dest, int len) { }

	[Address(RVA = "0x1E7D020", Offset = "0x1E7C420", Length = "0x18")]
	[Token(Token = "0x6000262")]
	internal static void CheckStringComparison(StringComparison comparisonType) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000278")]
	public override object Clone() { }

	[Address(RVA = "0x1E7D540", Offset = "0x1E7C940", Length = "0xDE")]
	[Token(Token = "0x6000248")]
	public static int Compare(string strA, string strB) { }

	[Address(RVA = "0x1E7DC40", Offset = "0x1E7D040", Length = "0xE")]
	[Token(Token = "0x6000249")]
	public static int Compare(string strA, string strB, bool ignoreCase) { }

	[Address(RVA = "0x1E7DDB0", Offset = "0x1E7D1B0", Length = "0x380")]
	[Token(Token = "0x600024A")]
	public static int Compare(string strA, string strB, StringComparison comparisonType) { }

	[Address(RVA = "0x1E7D760", Offset = "0x1E7CB60", Length = "0x4C0")]
	[Token(Token = "0x600024F")]
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) { }

	[Address(RVA = "0x1E7E210", Offset = "0x1E7D610", Length = "0xBA")]
	[Token(Token = "0x600024B")]
	public static int Compare(string strA, string strB, CultureInfo culture, CompareOptions options) { }

	[Address(RVA = "0x1E7E150", Offset = "0x1E7D550", Length = "0xBB")]
	[Token(Token = "0x600024C")]
	public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture) { }

	[Address(RVA = "0x1E7E2D0", Offset = "0x1E7D6D0", Length = "0x156")]
	[Token(Token = "0x600024D")]
	public static int Compare(string strA, int indexA, string strB, int indexB, int length) { }

	[Address(RVA = "0x1E7DC50", Offset = "0x1E7D050", Length = "0x159")]
	[Token(Token = "0x600024E")]
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase) { }

	[Address(RVA = "0x1E7D2A0", Offset = "0x1E7C6A0", Length = "0x255")]
	[Token(Token = "0x6000252")]
	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) { }

	[Address(RVA = "0x1E7D200", Offset = "0x1E7C600", Length = "0x9D")]
	[Token(Token = "0x6000251")]
	internal static int CompareOrdinal(ReadOnlySpan<Char> strA, ReadOnlySpan<Char> strB) { }

	[Address(RVA = "0x1E7D500", Offset = "0x1E7C900", Length = "0x3B")]
	[Token(Token = "0x6000250")]
	public static int CompareOrdinal(string strA, string strB) { }

	[Address(RVA = "0x1E7D040", Offset = "0x1E7C440", Length = "0x162")]
	[Token(Token = "0x6000247")]
	private static int CompareOrdinalHelper(string strA, string strB) { }

	[Address(RVA = "0x1E7D1B0", Offset = "0x1E7C5B0", Length = "0x48")]
	[Token(Token = "0x6000246")]
	private static int CompareOrdinalHelper(string strA, int indexA, int countA, string strB, int indexB, int countB) { }

	[Address(RVA = "0x1E7D620", Offset = "0x1E7CA20", Length = "0x13A")]
	[Token(Token = "0x6000253")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x1E7D540", Offset = "0x1E7C940", Length = "0xDE")]
	[Token(Token = "0x6000254")]
	public override int CompareTo(string strB) { }

	[Address(RVA = "0x1E7E980", Offset = "0x1E7DD80", Length = "0x213")]
	[Token(Token = "0x600029C")]
	public static string Concat(string str0, string str1, string str2) { }

	[Address(RVA = "0x1E7EBA0", Offset = "0x1E7DFA0", Length = "0xC4")]
	[Token(Token = "0x6000299")]
	public static string Concat(object arg0, object arg1, object arg2) { }

	[Address(RVA = "0x1E7EDF0", Offset = "0x1E7E1F0", Length = "0x383")]
	[Token(Token = "0x600029A")]
	public static string Concat(IEnumerable<String> values) { }

	[Address(RVA = "0x1E7EC70", Offset = "0x1E7E070", Length = "0x176")]
	[Token(Token = "0x600029B")]
	public static string Concat(string str0, string str1) { }

	[Address(RVA = "0x1E7E430", Offset = "0x1E7D830", Length = "0x28F")]
	[Token(Token = "0x600029D")]
	public static string Concat(string str0, string str1, string str2, string str3) { }

	[Address(RVA = "0x1E7E6C0", Offset = "0x1E7DAC0", Length = "0x2B8")]
	[Token(Token = "0x600029E")]
	public static string Concat(String[] values) { }

	[Address(RVA = "0x1E7F180", Offset = "0x1E7E580", Length = "0x17")]
	[Token(Token = "0x60002DE")]
	public bool Contains(char value, StringComparison comparisonType) { }

	[Address(RVA = "0x1E7F3A0", Offset = "0x1E7E7A0", Length = "0x1F")]
	[Token(Token = "0x60002DD")]
	public bool Contains(char value) { }

	[Address(RVA = "0x1E7F370", Offset = "0x1E7E770", Length = "0x28")]
	[Token(Token = "0x60002DC")]
	public bool Contains(string value, StringComparison comparisonType) { }

	[Address(RVA = "0x1E7F1A0", Offset = "0x1E7E5A0", Length = "0x1C7")]
	[Token(Token = "0x60002DB")]
	public bool Contains(string value) { }

	[Address(RVA = "0x1E7F610", Offset = "0x1E7EA10", Length = "0x96")]
	[Token(Token = "0x6000279")]
	public static string Copy(string str) { }

	[Address(RVA = "0x1E7F3C0", Offset = "0x1E7E7C0", Length = "0x243")]
	[Token(Token = "0x600027A")]
	public void CopyTo(int sourceIndex, Char[] destination, int destinationIndex, int count) { }

	[Address(RVA = "0x9166E0", Offset = "0x915AE0", Length = "0x156")]
	[Token(Token = "0x6000276")]
	public static string Create(int length, TState state, SpanAction<Char, TState> action) { }

	[Address(RVA = "0x1E7F6B0", Offset = "0x1E7EAB0", Length = "0x27")]
	[Token(Token = "0x6000280")]
	internal static string CreateFromChar(char c) { }

	[Address(RVA = "0x1E7FA40", Offset = "0x1E7EE40", Length = "0x17")]
	[Token(Token = "0x6000313")]
	private string CreateString(Char* value, int startIndex, int length) { }

	[Address(RVA = "0x1E7FBB0", Offset = "0x1E7EFB0", Length = "0x17")]
	[Token(Token = "0x6000314")]
	private string CreateString(Char[] val, int startIndex, int length) { }

	[Address(RVA = "0x1E7F8E0", Offset = "0x1E7ECE0", Length = "0x154")]
	[Token(Token = "0x6000312")]
	private string CreateString(Char* value) { }

	[Address(RVA = "0x1E7FBE0", Offset = "0x1E7EFE0", Length = "0x9F")]
	[Token(Token = "0x6000315")]
	private string CreateString(Char[] val) { }

	[Address(RVA = "0x1E7FBD0", Offset = "0x1E7EFD0", Length = "0xA")]
	[Token(Token = "0x6000310")]
	private string CreateString(SByte* value) { }

	[Address(RVA = "0x1E7FA90", Offset = "0x1E7EE90", Length = "0xF2")]
	[Token(Token = "0x6000316")]
	private string CreateString(char c, int count) { }

	[Address(RVA = "0x1E7FA60", Offset = "0x1E7EE60", Length = "0x2B")]
	[Token(Token = "0x6000317")]
	private string CreateString(SByte* value, int startIndex, int length, Encoding enc) { }

	[Address(RVA = "0x1E7F810", Offset = "0x1E7EC10", Length = "0xCC")]
	[Token(Token = "0x6000318")]
	private string CreateString(ReadOnlySpan<Char> value) { }

	[Address(RVA = "0x1E7FB90", Offset = "0x1E7EF90", Length = "0x17")]
	[Token(Token = "0x6000311")]
	private string CreateString(SByte* value, int startIndex, int length) { }

	[Address(RVA = "0x1E7F6E0", Offset = "0x1E7EAE0", Length = "0x5B")]
	[Token(Token = "0x600026F")]
	private static string CreateStringForSByteConstructor(Byte* pb, int numBytes) { }

	[Address(RVA = "0x1E7F740", Offset = "0x1E7EB40", Length = "0xCE")]
	[Token(Token = "0x600027F")]
	internal static string CreateStringFromEncoding(Byte* bytes, int byteLength, Encoding encoding) { }

	[Address(RVA = "0x1E7FC80", Offset = "0x1E7F080", Length = "0x2F")]
	[Token(Token = "0x60002DA")]
	private string CreateTrimmedString(int start, int end) { }

	[Address(RVA = "0x1E80210", Offset = "0x1E7F610", Length = "0xA5")]
	[Token(Token = "0x6000275")]
	private static string Ctor(ReadOnlySpan<Char> value) { }

	[Address(RVA = "0x1E80340", Offset = "0x1E7F740", Length = "0xDE")]
	[Token(Token = "0x6000273")]
	private static string Ctor(char c, int count) { }

	[Address(RVA = "0x1E80420", Offset = "0x1E7F820", Length = "0x226")]
	[Token(Token = "0x6000271")]
	private static string Ctor(SByte* value, int startIndex, int length, Encoding enc) { }

	[Address(RVA = "0x1E7FCB0", Offset = "0x1E7F0B0", Length = "0x1C4")]
	[Token(Token = "0x600026E")]
	private static string Ctor(SByte* value, int startIndex, int length) { }

	[Address(RVA = "0x1E7FFF0", Offset = "0x1E7F3F0", Length = "0x212")]
	[Token(Token = "0x600026C")]
	private static string Ctor(SByte* value) { }

	[Address(RVA = "0x1E80650", Offset = "0x1E7FA50", Length = "0x20B")]
	[Token(Token = "0x600026A")]
	private static string Ctor(Char* ptr, int startIndex, int length) { }

	[Address(RVA = "0x1E7FE80", Offset = "0x1E7F280", Length = "0x168")]
	[Token(Token = "0x6000268")]
	private static string Ctor(Char* ptr) { }

	[Address(RVA = "0x1E80860", Offset = "0x1E7FC60", Length = "0x224")]
	[Token(Token = "0x6000266")]
	private static string Ctor(Char[] value, int startIndex, int length) { }

	[Address(RVA = "0x1E802C0", Offset = "0x1E7F6C0", Length = "0x7D")]
	[Token(Token = "0x6000264")]
	private static string Ctor(Char[] value) { }

	[Address(RVA = "0x1E80DE0", Offset = "0x1E801E0", Length = "0x10A")]
	[Token(Token = "0x6000255")]
	public bool EndsWith(string value) { }

	[Address(RVA = "0x1E80A90", Offset = "0x1E7FE90", Length = "0x68")]
	[Token(Token = "0x6000256")]
	public bool EndsWith(string value, StringComparison comparisonType) { }

	[Address(RVA = "0x1E80F60", Offset = "0x1E80360", Length = "0x46")]
	[Token(Token = "0x6000257")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1E815E0", Offset = "0x1E809E0", Length = "0x2F")]
	[Token(Token = "0x6000258")]
	public override bool Equals(string value) { }

	[Address(RVA = "0x1E80FB0", Offset = "0x1E803B0", Length = "0x2F4")]
	[Token(Token = "0x6000259")]
	public bool Equals(string value, StringComparison comparisonType) { }

	[Address(RVA = "0x1E80F20", Offset = "0x1E80320", Length = "0x34")]
	[Token(Token = "0x600025A")]
	public static bool Equals(string a, string b) { }

	[Address(RVA = "0x1E812C0", Offset = "0x1E806C0", Length = "0x2FC")]
	[Token(Token = "0x600025B")]
	public static bool Equals(string a, string b, StringComparison comparisonType) { }

	[Address(RVA = "0x1E80EF0", Offset = "0x1E802F0", Length = "0x2E")]
	[Token(Token = "0x6000245")]
	private static bool EqualsHelper(string strA, string strB) { }

	[Address(RVA = "0x1E81610", Offset = "0x1E80A10", Length = "0x5")]
	[Token(Token = "0x6000303")]
	internal static string FastAllocateString(int length) { }

	[Address(RVA = "0x1E81620", Offset = "0x1E80A20", Length = "0x87")]
	[Token(Token = "0x6000298")]
	private static void FillStringChecked(string dest, int destPos, string src) { }

	[Address(RVA = "0x1E81DD0", Offset = "0x1E811D0", Length = "0x13F")]
	[Token(Token = "0x60002A1")]
	public static string Format(string format, object arg0, object arg1, object arg2) { }

	[Address(RVA = "0x1E81920", Offset = "0x1E80D20", Length = "0x1AB")]
	[Token(Token = "0x60002A6")]
	public static string Format(IFormatProvider provider, string format, Object[] args) { }

	[Address(RVA = "0x1E82050", Offset = "0x1E81450", Length = "0x163")]
	[Token(Token = "0x60002A5")]
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	[Address(RVA = "0x1E81AD0", Offset = "0x1E80ED0", Length = "0x155")]
	[Token(Token = "0x60002A4")]
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1) { }

	[Address(RVA = "0x1E817D0", Offset = "0x1E80BD0", Length = "0x14F")]
	[Token(Token = "0x60002A3")]
	public static string Format(IFormatProvider provider, string format, object arg0) { }

	[Address(RVA = "0x1E81C30", Offset = "0x1E81030", Length = "0x198")]
	[Token(Token = "0x60002A2")]
	public static string Format(string format, Object[] args) { }

	[Address(RVA = "0x1E821C0", Offset = "0x1E815C0", Length = "0x139")]
	[Token(Token = "0x60002A0")]
	public static string Format(string format, object arg0, object arg1) { }

	[Address(RVA = "0x1E81F10", Offset = "0x1E81310", Length = "0x139")]
	[Token(Token = "0x600029F")]
	public static string Format(string format, object arg0) { }

	[Address(RVA = "0x1E816B0", Offset = "0x1E80AB0", Length = "0x111")]
	[Token(Token = "0x60002A7")]
	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	[Address(RVA = "0x1E88D10", Offset = "0x1E88110", Length = "0x42")]
	[Intrinsic]
	[Token(Token = "0x6000319")]
	public char get_Chars(int index) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x60002FD")]
	public int get_Length() { }

	[Address(RVA = "0x1E82300", Offset = "0x1E81700", Length = "0x4C")]
	[Token(Token = "0x600025E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1E82300", Offset = "0x1E81700", Length = "0x4C")]
	[Token(Token = "0x600025F")]
	internal int GetLegacyNonRandomizedHashCode() { }

	[Address(RVA = "0x1E82350", Offset = "0x1E81750", Length = "0x5")]
	[Token(Token = "0x600027E")]
	internal char GetRawStringData() { }

	[Address(RVA = "0x1E82360", Offset = "0x1E81760", Length = "0x6")]
	[Token(Token = "0x6000287")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x1E82F40", Offset = "0x1E82340", Length = "0x3D8")]
	[Token(Token = "0x60002F1")]
	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	[Address(RVA = "0x1E82F10", Offset = "0x1E82310", Length = "0x23")]
	[Token(Token = "0x60002EF")]
	public int IndexOf(string value, StringComparison comparisonType) { }

	[Address(RVA = "0x1E83370", Offset = "0x1E82770", Length = "0x10")]
	[Token(Token = "0x60002DF")]
	public int IndexOf(char value) { }

	[Address(RVA = "0x1E82C10", Offset = "0x1E82010", Length = "0x1E")]
	[Token(Token = "0x60002E0")]
	public int IndexOf(char value, int startIndex) { }

	[Address(RVA = "0x1E82C30", Offset = "0x1E82030", Length = "0x290")]
	[Token(Token = "0x60002E1")]
	public int IndexOf(char value, StringComparison comparisonType) { }

	[Address(RVA = "0x1E83380", Offset = "0x1E82780", Length = "0x105")]
	[Token(Token = "0x60002E2")]
	public int IndexOf(char value, int startIndex, int count) { }

	[Address(RVA = "0x1E83330", Offset = "0x1E82730", Length = "0x20")]
	[Token(Token = "0x60002ED")]
	public int IndexOf(string value) { }

	[Address(RVA = "0x1E83350", Offset = "0x1E82750", Length = "0x20")]
	[Token(Token = "0x60002EE")]
	public int IndexOf(string value, int startIndex) { }

	[Address(RVA = "0x1E82EE0", Offset = "0x1E822E0", Length = "0x25")]
	[Token(Token = "0x60002F0")]
	public int IndexOf(string value, int startIndex, StringComparison comparisonType) { }

	[Address(RVA = "0x1E82730", Offset = "0x1E81B30", Length = "0x4C")]
	[Token(Token = "0x60002E7")]
	private int IndexOfAny(char value1, char value2, char value3, int startIndex, int count) { }

	[Address(RVA = "0x1E82780", Offset = "0x1E81B80", Length = "0x66")]
	[Token(Token = "0x60002E6")]
	private int IndexOfAny(char value1, char value2, int startIndex, int count) { }

	[Address(RVA = "0x1E82390", Offset = "0x1E81790", Length = "0x37A")]
	[Token(Token = "0x60002E5")]
	public int IndexOfAny(Char[] anyOf, int startIndex, int count) { }

	[Address(RVA = "0x1E82370", Offset = "0x1E81770", Length = "0x1E")]
	[Token(Token = "0x60002E4")]
	public int IndexOfAny(Char[] anyOf, int startIndex) { }

	[Address(RVA = "0x1E82710", Offset = "0x1E81B10", Length = "0x1E")]
	[Token(Token = "0x60002E3")]
	public int IndexOfAny(Char[] anyOf) { }

	[Address(RVA = "0x1E827F0", Offset = "0x1E81BF0", Length = "0x134")]
	[Token(Token = "0x60002E8")]
	private int IndexOfCharArray(Char[] anyOf, int startIndex, int count) { }

	[Address(RVA = "0x1E82B20", Offset = "0x1E81F20", Length = "0xE4")]
	[Token(Token = "0x60002FE")]
	internal int IndexOfUnchecked(string value, int startIndex, int count) { }

	[Address(RVA = "0x1E82930", Offset = "0x1E81D30", Length = "0x1EF")]
	[Token(Token = "0x60002FF")]
	internal int IndexOfUncheckedIgnoreCase(string value, int startIndex, int count) { }

	[Address(RVA = "0x1E83490", Offset = "0x1E82890", Length = "0xC9")]
	[Token(Token = "0x60002E9")]
	private static void InitializeProbabilisticMap(UInt32* charMap, ReadOnlySpan<Char> anyOf) { }

	[Address(RVA = "0x1E83560", Offset = "0x1E82960", Length = "0x183")]
	[Token(Token = "0x60002A8")]
	public string Insert(int startIndex, string value) { }

	[Address(RVA = "0x1E836F0", Offset = "0x1E82AF0", Length = "0x64")]
	[Token(Token = "0x600031A")]
	public static string Intern(string str) { }

	[Address(RVA = "0x1E83760", Offset = "0x1E82B60", Length = "0x5")]
	[Token(Token = "0x6000304")]
	private static string InternalIntern(string str) { }

	[Address(RVA = "0x1E83770", Offset = "0x1E82B70", Length = "0x65")]
	[Token(Token = "0x60002C8")]
	private string InternalSubString(int startIndex, int length) { }

	[Address(RVA = "0x1E837E0", Offset = "0x1E82BE0", Length = "0x1B")]
	[Token(Token = "0x60002EB")]
	private static bool IsCharBitSet(UInt32* charMap, byte value) { }

	[Address(RVA = "0x1E83800", Offset = "0x1E82C00", Length = "0x10")]
	[NonVersionable]
	[Token(Token = "0x600027C")]
	public static bool IsNullOrEmpty(string value) { }

	[Address(RVA = "0x1E83810", Offset = "0x1E82C10", Length = "0x84")]
	[Token(Token = "0x600027D")]
	public static bool IsNullOrWhiteSpace(string value) { }

	[Address(RVA = "0x1E842C0", Offset = "0x1E836C0", Length = "0x4F")]
	[Token(Token = "0x60002AF")]
	public static string Join(string separator, String[] value, int startIndex, int count) { }

	[Address(RVA = "0x1E83DA0", Offset = "0x1E831A0", Length = "0xA7")]
	[Token(Token = "0x60002AC")]
	public static string Join(string separator, String[] value) { }

	[Address(RVA = "0x1E84280", Offset = "0x1E83680", Length = "0x31")]
	[Token(Token = "0x60002AB")]
	public static string Join(char separator, String[] value, int startIndex, int count) { }

	[Address(RVA = "0x9184E0", Offset = "0x9178E0", Length = "0x49")]
	[Token(Token = "0x60002AA")]
	public static string Join(char separator, IEnumerable<T> values) { }

	[Address(RVA = "0x1E83E50", Offset = "0x1E83250", Length = "0x8A")]
	[Token(Token = "0x60002A9")]
	public static string Join(char separator, String[] value) { }

	[Address(RVA = "0x1E83EE0", Offset = "0x1E832E0", Length = "0x39D")]
	[Token(Token = "0x60002AE")]
	public static string Join(string separator, IEnumerable<String> values) { }

	[Address(RVA = "0x9182C0", Offset = "0x9176C0", Length = "0x6D")]
	[Token(Token = "0x60002AD")]
	public static string Join(string separator, IEnumerable<T> values) { }

	[Address(RVA = "0x916B10", Offset = "0x915F10", Length = "0x499")]
	[Token(Token = "0x60002B0")]
	private static string JoinCore(Char* separator, int separatorLength, IEnumerable<T> values) { }

	[Address(RVA = "0x1E838A0", Offset = "0x1E82CA0", Length = "0x4FD")]
	[Token(Token = "0x60002B1")]
	private static string JoinCore(Char* separator, int separatorLength, String[] value, int startIndex, int count) { }

	[Address(RVA = "0x1E84ED0", Offset = "0x1E842D0", Length = "0x124")]
	[Token(Token = "0x60002F4")]
	public int LastIndexOf(char value, int startIndex, int count) { }

	[Address(RVA = "0x1E84E90", Offset = "0x1E84290", Length = "0x10")]
	[Token(Token = "0x60002F2")]
	public int LastIndexOf(char value) { }

	[Address(RVA = "0x1E84E40", Offset = "0x1E84240", Length = "0x1B")]
	[Token(Token = "0x60002F3")]
	public int LastIndexOf(char value, int startIndex) { }

	[Address(RVA = "0x1E84EA0", Offset = "0x1E842A0", Length = "0x24")]
	[Token(Token = "0x60002F9")]
	public int LastIndexOf(string value) { }

	[Address(RVA = "0x1E84E10", Offset = "0x1E84210", Length = "0x22")]
	[Token(Token = "0x60002FB")]
	public int LastIndexOf(string value, int startIndex, StringComparison comparisonType) { }

	[Address(RVA = "0x1E84E60", Offset = "0x1E84260", Length = "0x29")]
	[Token(Token = "0x60002FA")]
	public int LastIndexOf(string value, StringComparison comparisonType) { }

	[Address(RVA = "0x1E849E0", Offset = "0x1E83DE0", Length = "0x40C")]
	[Token(Token = "0x60002FC")]
	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	[Address(RVA = "0x1E84340", Offset = "0x1E83740", Length = "0x278")]
	[Token(Token = "0x60002F7")]
	public int LastIndexOfAny(Char[] anyOf, int startIndex, int count) { }

	[Address(RVA = "0x1E845C0", Offset = "0x1E839C0", Length = "0x1B")]
	[Token(Token = "0x60002F6")]
	public int LastIndexOfAny(Char[] anyOf, int startIndex) { }

	[Address(RVA = "0x1E84310", Offset = "0x1E83710", Length = "0x22")]
	[Token(Token = "0x60002F5")]
	public int LastIndexOfAny(Char[] anyOf) { }

	[Address(RVA = "0x1E845E0", Offset = "0x1E839E0", Length = "0x134")]
	[Token(Token = "0x60002F8")]
	private int LastIndexOfCharArray(Char[] anyOf, int startIndex, int count) { }

	[Address(RVA = "0x1E84900", Offset = "0x1E83D00", Length = "0xDE")]
	[Token(Token = "0x6000300")]
	internal int LastIndexOfUnchecked(string value, int startIndex, int count) { }

	[Address(RVA = "0x1E84720", Offset = "0x1E83B20", Length = "0x1D8")]
	[Token(Token = "0x6000301")]
	internal int LastIndexOfUncheckedIgnoreCase(string value, int startIndex, int count) { }

	[Address(RVA = "0x1E85420", Offset = "0x1E84820", Length = "0x31E")]
	[Token(Token = "0x60002C3")]
	private void MakeSeparatorList(ReadOnlySpan<Char> separators, ref ValueListBuilder<Int32>& sepListBuilder) { }

	[Address(RVA = "0x1E851F0", Offset = "0x1E845F0", Length = "0x228")]
	[Token(Token = "0x60002C5")]
	private void MakeSeparatorList(String[] separators, ref ValueListBuilder<Int32>& sepListBuilder, ref ValueListBuilder<Int32>& lengthListBuilder) { }

	[Address(RVA = "0x1E85000", Offset = "0x1E84400", Length = "0x1EB")]
	[Token(Token = "0x60002C4")]
	private void MakeSeparatorList(string separator, ref ValueListBuilder<Int32>& sepListBuilder) { }

	[Address(RVA = "0x1E88D90", Offset = "0x1E88190", Length = "0x8")]
	[Token(Token = "0x6000306")]
	private static void memcpy(Byte* dest, Byte* src, int size) { }

	[Address(RVA = "0x1E88D60", Offset = "0x1E88160", Length = "0x6")]
	[Token(Token = "0x600030C")]
	internal static void memcpy_aligned_1(Byte* dest, Byte* src, int size) { }

	[Address(RVA = "0x1E88D70", Offset = "0x1E88170", Length = "0x7")]
	[Token(Token = "0x600030D")]
	internal static void memcpy_aligned_2(Byte* dest, Byte* src, int size) { }

	[Address(RVA = "0x1E88D80", Offset = "0x1E88180", Length = "0x5")]
	[Token(Token = "0x600030E")]
	internal static void memcpy_aligned_4(Byte* dest, Byte* src, int size) { }

	[Address(RVA = "0xE9E120", Offset = "0xE9D520", Length = "0x7")]
	[Token(Token = "0x600030F")]
	internal static void memcpy_aligned_8(Byte* dest, Byte* src, int size) { }

	[Address(RVA = "0x1E88DA0", Offset = "0x1E881A0", Length = "0xEC")]
	[Token(Token = "0x6000305")]
	private static void memset(Byte* dest, int val, int len) { }

	[Address(RVA = "0x1E85740", Offset = "0x1E84B40", Length = "0x57")]
	[Token(Token = "0x6000297")]
	public string Normalize(NormalizationForm normalizationForm) { }

	[Address(RVA = "0x1E80F20", Offset = "0x1E80320", Length = "0x34")]
	[Token(Token = "0x600025C")]
	public static bool op_Equality(string a, string b) { }

	[Address(RVA = "0x1E88E90", Offset = "0x1E88290", Length = "0x73")]
	[Token(Token = "0x6000277")]
	public static ReadOnlySpan<Char> op_Implicit(string value) { }

	[Address(RVA = "0x1E88F10", Offset = "0x1E88310", Length = "0x4B")]
	[Token(Token = "0x600025D")]
	public static bool op_Inequality(string a, string b) { }

	[Address(RVA = "0x1E857A0", Offset = "0x1E84BA0", Length = "0xF1")]
	[Token(Token = "0x60002B2")]
	public string PadLeft(int totalWidth, char paddingChar) { }

	[Address(RVA = "0x1E858A0", Offset = "0x1E84CA0", Length = "0xF8")]
	[Token(Token = "0x60002B3")]
	public string PadRight(int totalWidth, char paddingChar) { }

	[Address(RVA = "0x1E859A0", Offset = "0x1E84DA0", Length = "0x1F4")]
	[Token(Token = "0x60002B4")]
	public string Remove(int startIndex, int count) { }

	[Address(RVA = "0x1E85BA0", Offset = "0x1E84FA0", Length = "0xDF")]
	[Token(Token = "0x60002B5")]
	public string Remove(int startIndex) { }

	[Address(RVA = "0x1E86050", Offset = "0x1E85450", Length = "0xE0")]
	[Token(Token = "0x60002B6")]
	public string Replace(char oldChar, char newChar) { }

	[Address(RVA = "0x1E86140", Offset = "0x1E85540", Length = "0x286")]
	[Token(Token = "0x60002B7")]
	public string Replace(string oldValue, string newValue) { }

	[Address(RVA = "0x1E85C80", Offset = "0x1E85080", Length = "0x3CD")]
	[Token(Token = "0x60002B8")]
	private string ReplaceHelper(int oldValueLength, string newValue, ReadOnlySpan<Int32> indices) { }

	[Address(RVA = "0x1E863D0", Offset = "0x1E857D0", Length = "0x1A")]
	[Token(Token = "0x60002EC")]
	private static void SetCharBit(UInt32* charMap, byte value) { }

	[Address(RVA = "0x1E873F0", Offset = "0x1E867F0", Length = "0x4B")]
	[Token(Token = "0x60002BD")]
	public String[] Split(string separator, StringSplitOptions options = 0) { }

	[Address(RVA = "0x1E87340", Offset = "0x1E86740", Length = "0x27")]
	[Token(Token = "0x60002BE")]
	public String[] Split(String[] separator, StringSplitOptions options) { }

	[Address(RVA = "0x1E87440", Offset = "0x1E86840", Length = "0x82")]
	[Token(Token = "0x60002BB")]
	public String[] Split(Char[] separator, StringSplitOptions options) { }

	[Address(RVA = "0x1E87370", Offset = "0x1E86770", Length = "0x75")]
	[Token(Token = "0x60002BA")]
	public String[] Split(Char[] separator) { }

	[Address(RVA = "0x1E874D0", Offset = "0x1E868D0", Length = "0x77")]
	[Token(Token = "0x60002B9")]
	public String[] Split(char separator, StringSplitOptions options = 0) { }

	[Address(RVA = "0x1E86A20", Offset = "0x1E85E20", Length = "0x40A")]
	[Token(Token = "0x60002BF")]
	private String[] SplitInternal(string separator, String[] separators, int count, StringSplitOptions options) { }

	[Address(RVA = "0x1E863F0", Offset = "0x1E857F0", Length = "0x2FC")]
	[Token(Token = "0x60002BC")]
	private String[] SplitInternal(ReadOnlySpan<Char> separators, int count, StringSplitOptions options) { }

	[Address(RVA = "0x1E866F0", Offset = "0x1E85AF0", Length = "0x32E")]
	[Token(Token = "0x60002C0")]
	private String[] SplitInternal(string separator, int count, StringSplitOptions options) { }

	[Address(RVA = "0x1E86E30", Offset = "0x1E86230", Length = "0x21D")]
	[Token(Token = "0x60002C1")]
	private String[] SplitKeepEmptyEntries(ReadOnlySpan<Int32> sepList, ReadOnlySpan<Int32> lengthList, int defaultLength, int count) { }

	[Address(RVA = "0x1E87050", Offset = "0x1E86450", Length = "0x2E7")]
	[Token(Token = "0x60002C2")]
	private String[] SplitOmitEmptyEntries(ReadOnlySpan<Int32> sepList, ReadOnlySpan<Int32> lengthList, int defaultLength, int count) { }

	[Address(RVA = "0x1E875A0", Offset = "0x1E869A0", Length = "0x350")]
	[Token(Token = "0x6000261")]
	public bool StartsWith(string value, StringComparison comparisonType) { }

	[Address(RVA = "0x1E87910", Offset = "0x1E86D10", Length = "0x10E")]
	[Token(Token = "0x6000260")]
	public bool StartsWith(string value) { }

	[Address(RVA = "0x1E87550", Offset = "0x1E86950", Length = "0x4F")]
	[Token(Token = "0x6000302")]
	internal bool StartsWithOrdinalUnchecked(string value) { }

	[Address(RVA = "0x1E87A20", Offset = "0x1E86E20", Length = "0xF")]
	[Token(Token = "0x60002C6")]
	public string Substring(int startIndex) { }

	[Address(RVA = "0x1E87A30", Offset = "0x1E86E30", Length = "0x1E4")]
	[Token(Token = "0x60002C7")]
	public string Substring(int startIndex, int length) { }

	[Address(RVA = "0x1E87C20", Offset = "0x1E87020", Length = "0x54")]
	[Token(Token = "0x6000284")]
	private override IEnumerator<Char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { }

	[Address(RVA = "0x1E87C80", Offset = "0x1E87080", Length = "0x54")]
	[Token(Token = "0x6000285")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x1E87CE0", Offset = "0x1E870E0", Length = "0x59")]
	[Token(Token = "0x6000288")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x1E87D40", Offset = "0x1E87140", Length = "0x59")]
	[Token(Token = "0x600028B")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x1E87DA0", Offset = "0x1E871A0", Length = "0x59")]
	[Token(Token = "0x6000289")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x1E87E00", Offset = "0x1E87200", Length = "0x59")]
	[Token(Token = "0x6000295")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x1E87E60", Offset = "0x1E87260", Length = "0x75")]
	[Token(Token = "0x6000294")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x1E87EE0", Offset = "0x1E872E0", Length = "0x59")]
	[Token(Token = "0x6000293")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x1E87F40", Offset = "0x1E87340", Length = "0x59")]
	[Token(Token = "0x600028C")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x1E87FA0", Offset = "0x1E873A0", Length = "0x59")]
	[Token(Token = "0x600028E")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x1E88000", Offset = "0x1E87400", Length = "0x59")]
	[Token(Token = "0x6000290")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x1E88060", Offset = "0x1E87460", Length = "0x59")]
	[Token(Token = "0x600028A")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x1E880C0", Offset = "0x1E874C0", Length = "0x59")]
	[Token(Token = "0x6000292")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x1E88120", Offset = "0x1E87520", Length = "0x69")]
	[Token(Token = "0x6000296")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x1E88190", Offset = "0x1E87590", Length = "0x59")]
	[Token(Token = "0x600028D")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x1E881F0", Offset = "0x1E875F0", Length = "0x59")]
	[Token(Token = "0x600028F")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x1E88250", Offset = "0x1E87650", Length = "0x59")]
	[Token(Token = "0x6000291")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x1E882B0", Offset = "0x1E876B0", Length = "0xFA")]
	[Token(Token = "0x600027B")]
	public Char[] ToCharArray() { }

	[Address(RVA = "0x1E88440", Offset = "0x1E87840", Length = "0x86")]
	[Token(Token = "0x60002C9")]
	public string ToLower() { }

	[Address(RVA = "0x1E884D0", Offset = "0x1E878D0", Length = "0x99")]
	[Token(Token = "0x60002CA")]
	public string ToLower(CultureInfo culture) { }

	[Address(RVA = "0x1E883B0", Offset = "0x1E877B0", Length = "0x86")]
	[Token(Token = "0x60002CB")]
	public string ToLowerInvariant() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000282")]
	public virtual string ToString() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000283")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x1E88690", Offset = "0x1E87A90", Length = "0x99")]
	[Token(Token = "0x60002CD")]
	public string ToUpper(CultureInfo culture) { }

	[Address(RVA = "0x1E88600", Offset = "0x1E87A00", Length = "0x86")]
	[Token(Token = "0x60002CC")]
	public string ToUpper() { }

	[Address(RVA = "0x1E88570", Offset = "0x1E87970", Length = "0x86")]
	[Token(Token = "0x60002CE")]
	public string ToUpperInvariant() { }

	[Address(RVA = "0x1E88B40", Offset = "0x1E87F40", Length = "0x50")]
	[Token(Token = "0x60002D1")]
	public string Trim(Char[] trimChars) { }

	[Address(RVA = "0x1E88BB0", Offset = "0x1E87FB0", Length = "0x2D")]
	[Token(Token = "0x60002D0")]
	public string Trim(char trimChar) { }

	[Address(RVA = "0x1E88BA0", Offset = "0x1E87FA0", Length = "0xD")]
	[Token(Token = "0x60002CF")]
	public string Trim() { }

	[Address(RVA = "0x1E88730", Offset = "0x1E87B30", Length = "0xD")]
	[Token(Token = "0x60002D5")]
	public string TrimEnd() { }

	[Address(RVA = "0x1E887A0", Offset = "0x1E87BA0", Length = "0x2A")]
	[Token(Token = "0x60002D6")]
	public string TrimEnd(char trimChar) { }

	[Address(RVA = "0x1E88740", Offset = "0x1E87B40", Length = "0x50")]
	[Token(Token = "0x60002D7")]
	public string TrimEnd(Char[] trimChars) { }

	[Address(RVA = "0x1E887D0", Offset = "0x1E87BD0", Length = "0x172")]
	[Token(Token = "0x60002D9")]
	private string TrimHelper(Char* trimChars, int trimCharsLength, TrimType trimType) { }

	[Address(RVA = "0x1E889D0", Offset = "0x1E87DD0", Length = "0xA")]
	[Token(Token = "0x60002D2")]
	public string TrimStart() { }

	[Address(RVA = "0x1E88950", Offset = "0x1E87D50", Length = "0x2A")]
	[Token(Token = "0x60002D3")]
	public string TrimStart(char trimChar) { }

	[Address(RVA = "0x1E88980", Offset = "0x1E87D80", Length = "0x4A")]
	[Token(Token = "0x60002D4")]
	public string TrimStart(Char[] trimChars) { }

	[Address(RVA = "0x1E889E0", Offset = "0x1E87DE0", Length = "0x157")]
	[Token(Token = "0x60002D8")]
	private string TrimWhiteSpaceHelper(TrimType trimType) { }

	[Address(RVA = "0x1E88F60", Offset = "0x1E88360", Length = "0xE9")]
	[Token(Token = "0x6000286")]
	internal static int wcslen(Char* ptr) { }

	[Address(RVA = "0x79AC70", Offset = "0x79A070", Length = "0xB")]
	[Token(Token = "0x6000281")]
	internal static void wstrcpy(Char* dmem, Char* smem, int charCount) { }

}

