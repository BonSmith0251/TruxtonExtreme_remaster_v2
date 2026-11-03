namespace System.Text.RegularExpressions;

[Token(Token = "0x20000E5")]
internal sealed class RegexCharClass
{
	[IsReadOnly]
	[Token(Token = "0x20000E6")]
	private struct LowerCaseMapping
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003B0")]
		public readonly char ChMin; //Field offset: 0x0
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x40003B1")]
		public readonly char ChMax; //Field offset: 0x2
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40003B2")]
		public readonly int LcOp; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40003B3")]
		public readonly int Data; //Field offset: 0x8

		[Address(RVA = "0x2617FD0", Offset = "0x26173D0", Length = "0x14")]
		[Token(Token = "0x6000537")]
		internal LowerCaseMapping(char chMin, char chMax, int lcOp, int data) { }

	}

	[IsReadOnly]
	[Token(Token = "0x20000E8")]
	private struct SingleRange
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003B5")]
		public readonly char First; //Field offset: 0x0
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x40003B6")]
		public readonly char Last; //Field offset: 0x2

		[Address(RVA = "0x1F77C20", Offset = "0x1F77020", Length = "0x9")]
		[Token(Token = "0x600053B")]
		internal SingleRange(char first, char last) { }

	}

	[Token(Token = "0x20000E7")]
	private sealed class SingleRangeComparer : IComparer<SingleRange>
	{
		[Token(Token = "0x40003B4")]
		public static readonly SingleRangeComparer Instance; //Field offset: 0x0

		[Address(RVA = "0x262AA40", Offset = "0x2629E40", Length = "0x67")]
		[Token(Token = "0x600053A")]
		private static SingleRangeComparer() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000538")]
		private SingleRangeComparer() { }

		[Address(RVA = "0x262AA00", Offset = "0x2629E00", Length = "0x37")]
		[Token(Token = "0x6000539")]
		public override int Compare(SingleRange x, SingleRange y) { }

	}

	[Token(Token = "0x400039D")]
	private static readonly string s_internalRegexIgnoreCase; //Field offset: 0x0
	[Token(Token = "0x400039E")]
	private static readonly string s_space; //Field offset: 0x8
	[Token(Token = "0x400039F")]
	private static readonly string s_notSpace; //Field offset: 0x10
	[Token(Token = "0x40003A0")]
	private static readonly string s_word; //Field offset: 0x18
	[Token(Token = "0x40003A1")]
	private static readonly string s_notWord; //Field offset: 0x20
	[Token(Token = "0x40003A2")]
	public static readonly string SpaceClass; //Field offset: 0x28
	[Token(Token = "0x40003A3")]
	public static readonly string NotSpaceClass; //Field offset: 0x30
	[Token(Token = "0x40003A4")]
	public static readonly string WordClass; //Field offset: 0x38
	[Token(Token = "0x40003A5")]
	public static readonly string NotWordClass; //Field offset: 0x40
	[Token(Token = "0x40003A6")]
	public static readonly string DigitClass; //Field offset: 0x48
	[Token(Token = "0x40003A7")]
	public static readonly string NotDigitClass; //Field offset: 0x50
	[Token(Token = "0x40003A8")]
	private static readonly Dictionary<String, String> s_definedCategories; //Field offset: 0x58
	[Token(Token = "0x40003A9")]
	private static readonly String[][] s_propTable; //Field offset: 0x60
	[Token(Token = "0x40003AA")]
	private static readonly LowerCaseMapping[] s_lcTable; //Field offset: 0x68
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003AB")]
	private List<SingleRange> _rangelist; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003AC")]
	private StringBuilder _categories; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003AD")]
	private bool _canonical; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x40003AE")]
	private bool _negate; //Field offset: 0x21
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003AF")]
	private RegexCharClass _subtractor; //Field offset: 0x28

	[Token(Token = "0x170000DC")]
	public bool CanMerge
	{
		[Address(RVA = "0x26227B0", Offset = "0x2621BB0", Length = "0x12")]
		[Token(Token = "0x6000512")]
		 get { } //Length: 18
	}

	[Token(Token = "0x170000DD")]
	public bool Negate
	{
		[Address(RVA = "0x1EA5240", Offset = "0x1EA4640", Length = "0x4")]
		[Token(Token = "0x6000513")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x261CB80", Offset = "0x261BF80", Length = "0x5AED")]
	[Token(Token = "0x6000536")]
	private static RegexCharClass() { }

	[Address(RVA = "0x2622670", Offset = "0x2621A70", Length = "0xB5")]
	[Token(Token = "0x6000510")]
	public RegexCharClass() { }

	[Address(RVA = "0x2622730", Offset = "0x2621B30", Length = "0x75")]
	[Token(Token = "0x6000511")]
	private RegexCharClass(bool negate, List<SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction) { }

	[Address(RVA = "0x261A930", Offset = "0x2619D30", Length = "0x1E")]
	[Token(Token = "0x600051A")]
	private void AddCategory(string category) { }

	[Address(RVA = "0x261A6A0", Offset = "0x2619AA0", Length = "0x28B")]
	[Token(Token = "0x6000519")]
	public void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern) { }

	[Address(RVA = "0x261AB70", Offset = "0x2619F70", Length = "0xC")]
	[Token(Token = "0x6000514")]
	public void AddChar(char c) { }

	[Address(RVA = "0x261A950", Offset = "0x2619D50", Length = "0x211")]
	[Token(Token = "0x6000515")]
	public void AddCharClass(RegexCharClass cc) { }

	[Address(RVA = "0x261AB80", Offset = "0x2619F80", Length = "0xB0")]
	[Token(Token = "0x600051F")]
	public void AddDigit(bool ecma, bool negate, string pattern) { }

	[Address(RVA = "0x261AE90", Offset = "0x261A290", Length = "0x149")]
	[Token(Token = "0x600051B")]
	public void AddLowercase(CultureInfo culture) { }

	[Address(RVA = "0x261AC30", Offset = "0x261A030", Length = "0x258")]
	[Token(Token = "0x600051C")]
	private void AddLowercaseRange(char chMin, char chMax, CultureInfo culture) { }

	[Address(RVA = "0x261AFE0", Offset = "0x261A3E0", Length = "0x100")]
	[Token(Token = "0x6000518")]
	public void AddRange(char first, char last) { }

	[Address(RVA = "0x261B0F0", Offset = "0x261A4F0", Length = "0x22E")]
	[Token(Token = "0x6000516")]
	private void AddSet(string set) { }

	[Address(RVA = "0x261B320", Offset = "0x261A720", Length = "0x123")]
	[Token(Token = "0x600051E")]
	public void AddSpace(bool ecma, bool negate) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x6000517")]
	public void AddSubtraction(RegexCharClass sub) { }

	[Address(RVA = "0x261B450", Offset = "0x261A850", Length = "0x123")]
	[Token(Token = "0x600051D")]
	public void AddWord(bool ecma, bool negate) { }

	[Address(RVA = "0x261B580", Offset = "0x261A980", Length = "0x22C")]
	[Token(Token = "0x6000534")]
	private void Canonicalize() { }

	[Address(RVA = "0x261B880", Offset = "0x261AC80", Length = "0x154")]
	[Token(Token = "0x600052C")]
	private static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	[Address(RVA = "0x261B7B0", Offset = "0x261ABB0", Length = "0xCD")]
	[Token(Token = "0x600052D")]
	private static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i) { }

	[Address(RVA = "0x261BD10", Offset = "0x261B110", Length = "0x5C")]
	[Token(Token = "0x6000529")]
	public static bool CharInClass(char ch, string set) { }

	[Address(RVA = "0x261B9E0", Offset = "0x261ADE0", Length = "0x1FA")]
	[Token(Token = "0x600052B")]
	private static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	[Address(RVA = "0x261BBE0", Offset = "0x261AFE0", Length = "0x12C")]
	[Token(Token = "0x600052A")]
	private static bool CharInClassRecursive(char ch, string set, int start) { }

	[Address(RVA = "0x26227B0", Offset = "0x2621BB0", Length = "0x12")]
	[Token(Token = "0x6000512")]
	public bool get_CanMerge() { }

	[Address(RVA = "0x261BD70", Offset = "0x261B170", Length = "0x51")]
	[Token(Token = "0x6000533")]
	private SingleRange GetRangeAt(int i) { }

	[Address(RVA = "0x261BDD0", Offset = "0x261B1D0", Length = "0x9D")]
	[Token(Token = "0x6000527")]
	public static bool IsECMAWordChar(char ch) { }

	[Address(RVA = "0x261BE70", Offset = "0x261B270", Length = "0xDD")]
	[Token(Token = "0x6000522")]
	public static bool IsEmpty(string charClass) { }

	[Address(RVA = "0x261BF50", Offset = "0x261B350", Length = "0xC6")]
	[Token(Token = "0x6000521")]
	public static bool IsMergeable(string charClass) { }

	[Address(RVA = "0x261C020", Offset = "0x261B420", Length = "0x26")]
	[Token(Token = "0x6000526")]
	private static bool IsNegated(string set) { }

	[Address(RVA = "0x261C190", Offset = "0x261B590", Length = "0x13E")]
	[Token(Token = "0x6000523")]
	public static bool IsSingleton(string set) { }

	[Address(RVA = "0x261C050", Offset = "0x261B450", Length = "0x13F")]
	[Token(Token = "0x6000524")]
	public static bool IsSingletonInverse(string set) { }

	[Address(RVA = "0x261C2D0", Offset = "0x261B6D0", Length = "0x5D")]
	[Token(Token = "0x6000525")]
	private static bool IsSubtraction(string charClass) { }

	[Address(RVA = "0x261C330", Offset = "0x261B730", Length = "0xC3")]
	[Token(Token = "0x6000528")]
	public static bool IsWordChar(char ch) { }

	[Address(RVA = "0x261C400", Offset = "0x261B800", Length = "0x82")]
	[Token(Token = "0x600052E")]
	private static string NegateCategory(string category) { }

	[Address(RVA = "0x261C6D0", Offset = "0x261BAD0", Length = "0x4C")]
	[Token(Token = "0x600052F")]
	public static RegexCharClass Parse(string charClass) { }

	[Address(RVA = "0x261C490", Offset = "0x261B890", Length = "0x23F")]
	[Token(Token = "0x6000530")]
	private static RegexCharClass ParseRecursive(string charClass, int start) { }

	[Address(RVA = "0x261C720", Offset = "0x261BB20", Length = "0x3C")]
	[Token(Token = "0x6000531")]
	private int RangeCount() { }

	[Address(RVA = "0x1EA5240", Offset = "0x1EA4640", Length = "0x4")]
	[Token(Token = "0x6000513")]
	public void set_Negate(bool value) { }

	[Address(RVA = "0x261C760", Offset = "0x261BB60", Length = "0x243")]
	[Token(Token = "0x6000535")]
	private static string SetFromProperty(string capname, bool invert, string pattern) { }

	[Address(RVA = "0x261C9B0", Offset = "0x261BDB0", Length = "0x1F")]
	[Token(Token = "0x6000520")]
	public static char SingletonChar(string set) { }

	[Address(RVA = "0x261C9D0", Offset = "0x261BDD0", Length = "0x1AF")]
	[Token(Token = "0x6000532")]
	public string ToStringClass() { }

}

