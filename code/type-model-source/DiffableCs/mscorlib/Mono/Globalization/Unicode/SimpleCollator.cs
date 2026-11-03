namespace Mono.Globalization.Unicode;

[Token(Token = "0x2000057")]
internal class SimpleCollator : ISimpleCollator
{
	[Token(Token = "0x2000058")]
	public struct Context
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400018D")]
		public readonly CompareOptions Option; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400018E")]
		public readonly Byte* NeverMatchFlags; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400018F")]
		public readonly Byte* AlwaysMatchFlags; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000190")]
		public Byte* Buffer1; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000191")]
		public Byte* Buffer2; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000192")]
		public int PrevCode; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000193")]
		public Byte* PrevSortKey; //Field offset: 0x30

		[Address(RVA = "0x1E5C070", Offset = "0x1E5B470", Length = "0x2D")]
		[Token(Token = "0x6000102")]
		public Context(CompareOptions opt, Byte* alwaysMatchFlags, Byte* neverMatchFlags, Byte* buffer1, Byte* buffer2, Byte* prev1) { }

	}

	[Token(Token = "0x200005A")]
	private struct Escape
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000196")]
		public string Source; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000197")]
		public int Index; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000198")]
		public int Start; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000199")]
		public int End; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400019A")]
		public int Optional; //Field offset: 0x14

	}

	[Token(Token = "0x200005B")]
	private enum ExtenderType : int
	{
		None = 0,
		Simple = 1,
		Voiced = 2,
		Conditional = 3,
		Buggy = 4,
	}

	[Token(Token = "0x2000059")]
	private struct PreviousInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000194")]
		public int Code; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000195")]
		public Byte* SortKey; //Field offset: 0x8

		[Address(RVA = "0x1E63FD0", Offset = "0x1E633D0", Length = "0xF")]
		[Token(Token = "0x6000103")]
		public PreviousInfo(bool dummy) { }

	}

	[Token(Token = "0x4000181")]
	private static SimpleCollator invariant; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000182")]
	private readonly TextInfo textInfo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000183")]
	private readonly CodePointIndexer cjkIndexer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000184")]
	private readonly Contraction[] contractions; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000185")]
	private readonly Level2Map[] level2Maps; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000186")]
	private readonly Byte[] unsafeFlags; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000187")]
	private readonly Byte* cjkCatTable; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000188")]
	private readonly Byte* cjkLv1Table; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000189")]
	private readonly Byte* cjkLv2Table; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400018A")]
	private readonly CodePointIndexer cjkLv2Indexer; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400018B")]
	private readonly int lcid; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400018C")]
	private readonly bool frenchSort; //Field offset: 0x5C

	[Address(RVA = "0x1E6AA90", Offset = "0x1E69E90", Length = "0x9F")]
	[Token(Token = "0x6000101")]
	private static SimpleCollator() { }

	[Address(RVA = "0x1E6AB30", Offset = "0x1E69F30", Length = "0x4A1")]
	[Token(Token = "0x60000D2")]
	public SimpleCollator(CultureInfo culture) { }

	[Address(RVA = "0x1E653C0", Offset = "0x1E647C0", Length = "0x94")]
	[Token(Token = "0x60000D5")]
	private byte Category(int cp) { }

	[Address(RVA = "0x1E65460", Offset = "0x1E64860", Length = "0x1E")]
	[Token(Token = "0x60000EA")]
	private void ClearBuffer(Byte* buffer, int size) { }

	[Address(RVA = "0x1E66630", Offset = "0x1E65A30", Length = "0xF4")]
	[Token(Token = "0x60000E9")]
	internal int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	[Address(RVA = "0x1E65480", Offset = "0x1E64880", Length = "0x18")]
	[Token(Token = "0x60000EC")]
	private int CompareFlagPair(bool b1, bool b2) { }

	[Address(RVA = "0x1E654A0", Offset = "0x1E648A0", Length = "0x118D")]
	[Token(Token = "0x60000EB")]
	private int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, out bool targetConsumed, out bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, ref Context ctx) { }

	[Address(RVA = "0x1E66730", Offset = "0x1E65B30", Length = "0x53A")]
	[Token(Token = "0x60000E6")]
	private void FillSortKeyRaw(int i, ExtenderType ext, SortKeyBuffer buf, CompareOptions opt) { }

	[Address(RVA = "0x1E66C70", Offset = "0x1E66070", Length = "0xC1")]
	[Token(Token = "0x60000E7")]
	private void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf) { }

	[Address(RVA = "0x1E66D40", Offset = "0x1E66140", Length = "0x20F")]
	[Token(Token = "0x60000E0")]
	private int FilterExtender(int i, ExtenderType ext, CompareOptions opt) { }

	[Address(RVA = "0x1E66F50", Offset = "0x1E66350", Length = "0x94")]
	[Token(Token = "0x60000DD")]
	private int FilterOptions(int i, CompareOptions opt) { }

	[Address(RVA = "0x1E67340", Offset = "0x1E66740", Length = "0xD5")]
	[Token(Token = "0x60000D9")]
	private Contraction GetContraction(string s, int start, int end) { }

	[Address(RVA = "0x1E67200", Offset = "0x1E66600", Length = "0x131")]
	[Token(Token = "0x60000DA")]
	private Contraction GetContraction(string s, int start, int end, Contraction[] clist) { }

	[Address(RVA = "0x1E67420", Offset = "0x1E66820", Length = "0xB9")]
	[Token(Token = "0x60000DE")]
	private ExtenderType GetExtenderType(int i) { }

	[Address(RVA = "0x1E674E0", Offset = "0x1E668E0", Length = "0x97")]
	[Token(Token = "0x60000D4")]
	private static CultureInfo GetNeutralCulture(CultureInfo info) { }

	[Address(RVA = "0x1E679F0", Offset = "0x1E66DF0", Length = "0xE5")]
	[Token(Token = "0x60000E3")]
	public override SortKey GetSortKey(string s, CompareOptions options) { }

	[Address(RVA = "0x1E67580", Offset = "0x1E66980", Length = "0xF3")]
	[Token(Token = "0x60000E4")]
	public SortKey GetSortKey(string s, int start, int length, CompareOptions options) { }

	[Address(RVA = "0x1E67680", Offset = "0x1E66A80", Length = "0x360")]
	[Token(Token = "0x60000E5")]
	private void GetSortKey(string s, int start, int end, SortKeyBuffer buf, CompareOptions opt) { }

	[Address(RVA = "0x1E67AE0", Offset = "0x1E66EE0", Length = "0x1FE")]
	[Token(Token = "0x60000DC")]
	private Contraction GetTailContraction(string s, int start, int end, Contraction[] clist) { }

	[Address(RVA = "0x1E67CE0", Offset = "0x1E670E0", Length = "0xD5")]
	[Token(Token = "0x60000DB")]
	private Contraction GetTailContraction(string s, int start, int end) { }

	[Address(RVA = "0x1E67FC0", Offset = "0x1E673C0", Length = "0x503")]
	[Token(Token = "0x60000F7")]
	private int IndexOf(string s, string target, int start, int length, Byte* targetSortKey, ref Context ctx) { }

	[Address(RVA = "0x1E684D0", Offset = "0x1E678D0", Length = "0x2CE")]
	[Token(Token = "0x60000F3")]
	public override int IndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	[Address(RVA = "0x1E67E80", Offset = "0x1E67280", Length = "0x7B")]
	[Token(Token = "0x60000F5")]
	private int IndexOfOrdinal(string s, char target, int start, int length) { }

	[Address(RVA = "0x1E67DC0", Offset = "0x1E671C0", Length = "0xB9")]
	[Token(Token = "0x60000F4")]
	private int IndexOfOrdinal(string s, string target, int start, int length) { }

	[Address(RVA = "0x1E67F00", Offset = "0x1E67300", Length = "0xBB")]
	[Token(Token = "0x60000F6")]
	private int IndexOfSortKey(string s, int start, int length, Byte* sortkey, char target, int ti, bool noLv4, ref Context ctx) { }

	[Address(RVA = "0x1E687A0", Offset = "0x1E67BA0", Length = "0x7F")]
	[Token(Token = "0x60000D8")]
	private static bool IsHalfKana(int cp, CompareOptions opt) { }

	[Address(RVA = "0x1E68820", Offset = "0x1E67C20", Length = "0x82")]
	[Token(Token = "0x60000E1")]
	private static bool IsIgnorable(int i, CompareOptions opt) { }

	[Address(RVA = "0x1E68930", Offset = "0x1E67D30", Length = "0x30")]
	[Token(Token = "0x60000ED")]
	public override bool IsPrefix(string src, string target, CompareOptions opt) { }

	[Address(RVA = "0x1E68970", Offset = "0x1E67D70", Length = "0xF1")]
	[Token(Token = "0x60000EE")]
	public bool IsPrefix(string s, string target, int start, int length, CompareOptions opt) { }

	[Address(RVA = "0x1E688B0", Offset = "0x1E67CB0", Length = "0x7F")]
	[Token(Token = "0x60000EF")]
	private bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, ref Context ctx) { }

	[Address(RVA = "0x1E68A70", Offset = "0x1E67E70", Length = "0x6A")]
	[Token(Token = "0x60000E2")]
	private bool IsSafe(int i) { }

	[Address(RVA = "0x1E68AE0", Offset = "0x1E67EE0", Length = "0xBB")]
	[Token(Token = "0x60000F1")]
	public bool IsSuffix(string s, string target, int start, int length, CompareOptions opt) { }

	[Address(RVA = "0x1E68BA0", Offset = "0x1E67FA0", Length = "0xBA")]
	[Token(Token = "0x60000F0")]
	public override bool IsSuffix(string src, string target, CompareOptions opt) { }

	[Address(RVA = "0x1E69460", Offset = "0x1E68860", Length = "0x1A7")]
	[Token(Token = "0x60000F8")]
	public override int LastIndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	[Address(RVA = "0x1E68E80", Offset = "0x1E68280", Length = "0x5D1")]
	[Token(Token = "0x60000FB")]
	private int LastIndexOf(string s, string target, int start, int length, Byte* targetSortKey, ref Context ctx) { }

	[Address(RVA = "0x1E68C60", Offset = "0x1E68060", Length = "0x144")]
	[Token(Token = "0x60000F9")]
	private int LastIndexOfOrdinal(string s, string target, int start, int length) { }

	[Address(RVA = "0x1E68DB0", Offset = "0x1E681B0", Length = "0xC7")]
	[Token(Token = "0x60000FA")]
	private int LastIndexOfSortKey(string s, int start, int orgStart, int length, Byte* sortkey, int ti, bool noLv4, ref Context ctx) { }

	[Address(RVA = "0x1E69610", Offset = "0x1E68A10", Length = "0x94")]
	[Token(Token = "0x60000D6")]
	private byte Level1(int cp) { }

	[Address(RVA = "0x1E696B0", Offset = "0x1E68AB0", Length = "0x18E")]
	[Token(Token = "0x60000D7")]
	private byte Level2(int cp, ExtenderType ext) { }

	[Address(RVA = "0x1E69E30", Offset = "0x1E69230", Length = "0x1EB")]
	[Token(Token = "0x60000FF")]
	private bool MatchesBackward(string s, ref int idx, int end, int orgStart, int ti, Byte* sortkey, bool noLv4, ref Context ctx) { }

	[Address(RVA = "0x1E69840", Offset = "0x1E68C40", Length = "0x5E7")]
	[Token(Token = "0x6000100")]
	private bool MatchesBackwardCore(string s, ref int idx, int end, int orgStart, int ti, Byte* sortkey, bool noLv4, ExtenderType ext, ref Contraction ct, ref Context ctx) { }

	[Address(RVA = "0x1E6A400", Offset = "0x1E69800", Length = "0x1E0")]
	[Token(Token = "0x60000FC")]
	private bool MatchesForward(string s, ref int idx, int end, int ti, Byte* sortkey, bool noLv4, ref Context ctx) { }

	[Address(RVA = "0x1E6A020", Offset = "0x1E69420", Length = "0x3DF")]
	[Token(Token = "0x60000FD")]
	private bool MatchesForwardCore(string s, ref int idx, int end, int ti, Byte* sortkey, bool noLv4, ExtenderType ext, ref Contraction ct, ref Context ctx) { }

	[Address(RVA = "0x1E6A5F0", Offset = "0x1E699F0", Length = "0x1CD")]
	[Token(Token = "0x60000FE")]
	private bool MatchesPrimitive(CompareOptions opt, Byte* source, int si, ExtenderType ext, Byte* target, int ti, bool noLv4) { }

	[Address(RVA = "0x1E6A7C0", Offset = "0x1E69BC0", Length = "0x13A")]
	[Token(Token = "0x60000F2")]
	private int QuickIndexOf(string s, string target, int start, int length, out bool testWasUnable) { }

	[Address(RVA = "0x1E6A900", Offset = "0x1E69D00", Length = "0x156")]
	[Token(Token = "0x60000D3")]
	private void SetCJKTable(CultureInfo culture, ref CodePointIndexer cjkIndexer, ref Byte* catTable, ref Byte* lv1Table, ref CodePointIndexer lv2Indexer, ref Byte* lv2Table) { }

	[Address(RVA = "0x1E6AA60", Offset = "0x1E69E60", Length = "0xE")]
	[Token(Token = "0x60000E8")]
	private override int System.Globalization.ISimpleCollator.Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	[Address(RVA = "0x1E6AA70", Offset = "0x1E69E70", Length = "0x15")]
	[Token(Token = "0x60000DF")]
	private static byte ToDashTypeValue(ExtenderType ext, CompareOptions opt) { }

}

