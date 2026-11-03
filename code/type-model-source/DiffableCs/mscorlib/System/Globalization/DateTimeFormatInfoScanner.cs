namespace System.Globalization;

[Token(Token = "0x2000548")]
internal class DateTimeFormatInfoScanner
{
	[Token(Token = "0x2000549")]
	private enum FoundDatePattern : int
	{
		None = 0,
		FoundYearPatternFlag = 1,
		FoundMonthPatternFlag = 2,
		FoundDayPatternFlag = 4,
		FoundYMDPatternFlag = 7,
	}

	[Token(Token = "0x4001595")]
	private static Dictionary<String, String> s_knownWords; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001594")]
	internal List<String> m_dateWords; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001596")]
	private FoundDatePattern _ymdFlags; //Field offset: 0x18

	[Token(Token = "0x17000573")]
	private static Dictionary<String, String> KnownWords
	{
		[Address(RVA = "0x1F732E0", Offset = "0x1F726E0", Length = "0x410")]
		[Token(Token = "0x60026AF")]
		private get { } //Length: 1040
	}

	[Address(RVA = "0x1F73260", Offset = "0x1F72660", Length = "0x77")]
	[Token(Token = "0x60026BE")]
	public DateTimeFormatInfoScanner() { }

	[Address(RVA = "0x1F72140", Offset = "0x1F71540", Length = "0x220")]
	[Token(Token = "0x60026B1")]
	internal void AddDateWordOrPostfix(string formatPostfix, string str) { }

	[Address(RVA = "0x1F72370", Offset = "0x1F71770", Length = "0x202")]
	[Token(Token = "0x60026B2")]
	internal int AddDateWords(string pattern, int index, string formatPostfix) { }

	[Address(RVA = "0x1F72580", Offset = "0x1F71980", Length = "0xF4")]
	[Token(Token = "0x60026B4")]
	internal void AddIgnorableSymbols(string text) { }

	[Address(RVA = "0x1F72680", Offset = "0x1F71A80", Length = "0x248")]
	[Token(Token = "0x60026BD")]
	private static bool ArrayElementsBeginWithDigit(String[] array) { }

	[Address(RVA = "0x1F728D0", Offset = "0x1F71CD0", Length = "0xB8")]
	[Token(Token = "0x60026BC")]
	private static bool ArrayElementsHaveSpace(String[] array) { }

	[Address(RVA = "0x1F72990", Offset = "0x1F71D90", Length = "0xA1")]
	[Token(Token = "0x60026BB")]
	private static bool EqualStringArrays(String[] array1, String[] array2) { }

	[Address(RVA = "0x1F732E0", Offset = "0x1F726E0", Length = "0x410")]
	[Token(Token = "0x60026AF")]
	private static Dictionary<String, String> get_KnownWords() { }

	[Address(RVA = "0x1F72A40", Offset = "0x1F71E40", Length = "0x2A9")]
	[Token(Token = "0x60026B6")]
	internal String[] GetDateWordsOfDTFI(DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x1F72CF0", Offset = "0x1F720F0", Length = "0x124")]
	[Token(Token = "0x60026B7")]
	internal static FORMATFLAGS GetFormatFlagGenitiveMonth(String[] monthNames, String[] genitveMonthNames, String[] abbrevMonthNames, String[] genetiveAbbrevMonthNames) { }

	[Address(RVA = "0x1F72E20", Offset = "0x1F72220", Length = "0xE")]
	[Token(Token = "0x60026BA")]
	internal static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID) { }

	[Address(RVA = "0x1F72E30", Offset = "0x1F72230", Length = "0x36")]
	[Token(Token = "0x60026B9")]
	internal static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(String[] dayNames, String[] abbrevDayNames) { }

	[Address(RVA = "0x1F72E70", Offset = "0x1F72270", Length = "0xBC")]
	[Token(Token = "0x60026B8")]
	internal static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(String[] monthNames, String[] genitveMonthNames, String[] abbrevMonthNames, String[] genetiveAbbrevMonthNames) { }

	[Address(RVA = "0x1F72F30", Offset = "0x1F72330", Length = "0x20C")]
	[Token(Token = "0x60026B5")]
	internal void ScanDateWord(string pattern) { }

	[Address(RVA = "0x1F73140", Offset = "0x1F72540", Length = "0x69")]
	[Token(Token = "0x60026B3")]
	internal static int ScanRepeatChar(string pattern, char ch, int index, out int count) { }

	[Address(RVA = "0x1F731B0", Offset = "0x1F725B0", Length = "0xA2")]
	[Token(Token = "0x60026B0")]
	internal static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex) { }

}

