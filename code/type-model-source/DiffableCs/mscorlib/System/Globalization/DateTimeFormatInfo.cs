namespace System.Globalization;

[Token(Token = "0x2000544")]
public sealed class DateTimeFormatInfo : IFormatProvider, ICloneable
{
	[Token(Token = "0x2000545")]
	public class TokenHashValue
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400156F")]
		internal string tokenString; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001570")]
		internal TokenType tokenType; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4001571")]
		internal int tokenValue; //Field offset: 0x1C

		[Address(RVA = "0x16B7820", Offset = "0x16B6C20", Length = "0x52")]
		[Token(Token = "0x60026AE")]
		internal TokenHashValue(string tokenString, TokenType tokenType, int tokenValue) { }

	}

	[Token(Token = "0x400151D")]
	private static DateTimeFormatInfo s_invariantInfo; //Field offset: 0x0
	[Token(Token = "0x400155C")]
	internal const string KoreanYearSuff = "년"; //Field offset: 0x0
	[Token(Token = "0x400155B")]
	internal const string CJKDaySuff = "日"; //Field offset: 0x0
	[Token(Token = "0x400155A")]
	internal const string CJKMonthSuff = "月"; //Field offset: 0x0
	[Token(Token = "0x4001559")]
	internal const string CJKYearSuff = "年"; //Field offset: 0x0
	[Token(Token = "0x4001558")]
	internal const string IgnorableComma = ","; //Field offset: 0x0
	[Token(Token = "0x4001557")]
	internal const string IgnorablePeriod = "."; //Field offset: 0x0
	[Token(Token = "0x400155D")]
	internal const string KoreanMonthSuff = "월"; //Field offset: 0x0
	[Token(Token = "0x4001556")]
	private const string invariantTimeSeparator = ":"; //Field offset: 0x0
	[Token(Token = "0x4001554")]
	private const string dateSeparatorOrTimeZoneOffset = "-"; //Field offset: 0x0
	[Token(Token = "0x4001553")]
	private const int SECOND_PRIME = 197; //Field offset: 0x0
	[Token(Token = "0x4001552")]
	private const int TOKEN_HASH_SIZE = 199; //Field offset: 0x0
	[Token(Token = "0x4001550")]
	internal const DateTimeStyles InvalidDateTimeStyles = -256; //Field offset: 0x0
	[Token(Token = "0x400154D")]
	internal const string RoundtripDateTimeUnfixed = "yyyy'-'MM'-'ddTHH':'mm':'ss zzz"; //Field offset: 0x0
	[Token(Token = "0x400154C")]
	internal const string RoundtripFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK"; //Field offset: 0x0
	[Token(Token = "0x4001555")]
	private const string invariantDateSeparator = "/"; //Field offset: 0x0
	[Token(Token = "0x4001548")]
	private const int DEFAULT_ALL_DATETIMES_SIZE = 132; //Field offset: 0x0
	[Token(Token = "0x400155E")]
	internal const string KoreanDaySuff = "일"; //Field offset: 0x0
	[Token(Token = "0x400152D")]
	private const string universalSortableDateTimePattern = "yyyy'-'MM'-'dd HH':'mm':'ss'Z'"; //Field offset: 0x0
	[Token(Token = "0x400156C")]
	internal const string EnglishLangName = "en"; //Field offset: 0x0
	[Token(Token = "0x400156B")]
	internal const string JapaneseLangName = "ja"; //Field offset: 0x0
	[Token(Token = "0x400156A")]
	internal const string KoreanLangName = "ko"; //Field offset: 0x0
	[Token(Token = "0x4001569")]
	internal const string ZuluName = "Z"; //Field offset: 0x0
	[Token(Token = "0x4001568")]
	internal const string GMTName = "GMT"; //Field offset: 0x0
	[Token(Token = "0x4001567")]
	internal const string LocalTimeMark = "T"; //Field offset: 0x0
	[Token(Token = "0x400155F")]
	internal const string KoreanHourSuff = "시"; //Field offset: 0x0
	[Token(Token = "0x4001566")]
	internal const string JapaneseEraStart = "元"; //Field offset: 0x0
	[Token(Token = "0x4001564")]
	internal const string CJKMinuteSuff = "分"; //Field offset: 0x0
	[Token(Token = "0x4001563")]
	internal const string ChineseHourSuff = "时"; //Field offset: 0x0
	[Token(Token = "0x4001562")]
	internal const string CJKHourSuff = "時"; //Field offset: 0x0
	[Token(Token = "0x4001561")]
	internal const string KoreanSecondSuff = "초"; //Field offset: 0x0
	[Token(Token = "0x4001560")]
	internal const string KoreanMinuteSuff = "분"; //Field offset: 0x0
	[Token(Token = "0x400152B")]
	private const string rfc1123Pattern = "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'"; //Field offset: 0x0
	[Token(Token = "0x400152C")]
	private const string sortableDateTimePattern = "yyyy'-'MM'-'dd'T'HH':'mm':'ss"; //Field offset: 0x0
	[Token(Token = "0x4001565")]
	internal const string CJKSecondSuff = "秒"; //Field offset: 0x0
	[Token(Token = "0x400154B")]
	private static readonly Char[] s_monthSpaces; //Field offset: 0x8
	[Token(Token = "0x400156D")]
	private static DateTimeFormatInfo s_jajpDTFI; //Field offset: 0x10
	[Token(Token = "0x400156E")]
	private static DateTimeFormatInfo s_zhtwDTFI; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400151E")]
	private CultureData _cultureData; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400151F")]
	private string _name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001520")]
	private string _langName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001521")]
	private CompareInfo _compareInfo; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001522")]
	private CultureInfo _cultureInfo; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001523")]
	private string amDesignator; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001524")]
	private string pmDesignator; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001525")]
	private string dateSeparator; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001526")]
	private string generalShortTimePattern; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001527")]
	private string generalLongTimePattern; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001528")]
	private string timeSeparator; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001529")]
	private string monthDayPattern; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400152A")]
	private string dateTimeOffsetPattern; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400152E")]
	private Calendar calendar; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400152F")]
	private int firstDayOfWeek; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4001530")]
	private int calendarWeekRule; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001531")]
	private string fullDateTimePattern; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001532")]
	private String[] abbreviatedDayNames; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001533")]
	private String[] m_superShortDayNames; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001534")]
	private String[] dayNames; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4001535")]
	private String[] abbreviatedMonthNames; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001536")]
	private String[] monthNames; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4001537")]
	private String[] genitiveMonthNames; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4001538")]
	private String[] m_genitiveAbbreviatedMonthNames; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4001539")]
	private String[] leapYearMonthNames; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400153A")]
	private string longDatePattern; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400153B")]
	private string shortDatePattern; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400153C")]
	private string yearMonthPattern; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400153D")]
	private string longTimePattern; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400153E")]
	private string shortTimePattern; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400153F")]
	private String[] allYearMonthPatterns; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4001540")]
	private String[] allShortDatePatterns; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4001541")]
	private String[] allLongDatePatterns; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4001542")]
	private String[] allShortTimePatterns; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4001543")]
	private String[] allLongTimePatterns; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4001544")]
	private String[] m_eraNames; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4001545")]
	private String[] m_abbrevEraNames; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4001546")]
	private String[] m_abbrevEnglishEraNames; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4001547")]
	private CalendarId[] optionalCalendars; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4001549")]
	internal bool _isReadOnly; //Field offset: 0x140
	[FieldOffset(Offset = "0x144")]
	[Token(Token = "0x400154A")]
	private DateTimeFormatFlags formatFlags; //Field offset: 0x144
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x400154E")]
	private string _fullTimeSpanPositivePattern; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x400154F")]
	private string _fullTimeSpanNegativePattern; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4001551")]
	private TokenHashValue[] _dtfiTokenHash; //Field offset: 0x158

	[Token(Token = "0x1700055B")]
	public String[] AbbreviatedDayNames
	{
		[Address(RVA = "0x1F5AB00", Offset = "0x1F59F00", Length = "0x8C")]
		[Token(Token = "0x600267A")]
		 get { } //Length: 140
	}

	[Token(Token = "0x1700054A")]
	internal String[] AbbreviatedEnglishEraNames
	{
		[Address(RVA = "0x1F5AB90", Offset = "0x1F59F90", Length = "0x76")]
		[Token(Token = "0x6002669")]
		internal get { } //Length: 118
	}

	[Token(Token = "0x17000549")]
	internal String[] AbbreviatedEraNames
	{
		[Address(RVA = "0x1F5AC10", Offset = "0x1F5A010", Length = "0x76")]
		[Token(Token = "0x6002667")]
		internal get { } //Length: 118
	}

	[Token(Token = "0x1700055D")]
	public String[] AbbreviatedMonthNames
	{
		[Address(RVA = "0x1F5AC90", Offset = "0x1F5A090", Length = "0x8C")]
		[Token(Token = "0x600267C")]
		 get { } //Length: 140
	}

	[Token(Token = "0x17000564")]
	private String[] AllLongDatePatterns
	{
		[Address(RVA = "0x1F5AD20", Offset = "0x1F5A120", Length = "0xAB")]
		[Token(Token = "0x600268D")]
		private get { } //Length: 171
	}

	[Token(Token = "0x17000565")]
	private String[] AllLongTimePatterns
	{
		[Address(RVA = "0x1F5ADD0", Offset = "0x1F5A1D0", Length = "0xA0")]
		[Token(Token = "0x600268E")]
		private get { } //Length: 160
	}

	[Token(Token = "0x17000562")]
	private String[] AllShortDatePatterns
	{
		[Address(RVA = "0x1F5AE80", Offset = "0x1F5A280", Length = "0xAB")]
		[Token(Token = "0x600268B")]
		private get { } //Length: 171
	}

	[Token(Token = "0x17000563")]
	private String[] AllShortTimePatterns
	{
		[Address(RVA = "0x1F5AF30", Offset = "0x1F5A330", Length = "0xA0")]
		[Token(Token = "0x600268C")]
		private get { } //Length: 160
	}

	[Token(Token = "0x17000561")]
	private String[] AllYearMonthPatterns
	{
		[Address(RVA = "0x1F5AFE0", Offset = "0x1F5A3E0", Length = "0xAB")]
		[Token(Token = "0x600268A")]
		private get { } //Length: 171
	}

	[Token(Token = "0x17000545")]
	public string AMDesignator
	{
		[Address(RVA = "0x1F5AAC0", Offset = "0x1F59EC0", Length = "0x39")]
		[Token(Token = "0x6002661")]
		 get { } //Length: 57
	}

	[Token(Token = "0x17000546")]
	public Calendar Calendar
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x6002662")]
		 get { } //Length: 5
		[Address(RVA = "0x1F5CBF0", Offset = "0x1F5BFF0", Length = "0x6D9")]
		[Token(Token = "0x6002663")]
		 set { } //Length: 1753
	}

	[Token(Token = "0x1700056F")]
	internal CompareInfo CompareInfo
	{
		[Address(RVA = "0x1F5B090", Offset = "0x1F5A490", Length = "0x12A")]
		[Token(Token = "0x6002698")]
		internal get { } //Length: 298
	}

	[Token(Token = "0x17000541")]
	private CultureInfo Culture
	{
		[Address(RVA = "0x1F5B200", Offset = "0x1F5A600", Length = "0x99")]
		[Token(Token = "0x600264F")]
		private get { } //Length: 153
	}

	[Token(Token = "0x17000540")]
	private string CultureName
	{
		[Address(RVA = "0x1F5B1C0", Offset = "0x1F5A5C0", Length = "0x39")]
		[Token(Token = "0x600264E")]
		private get { } //Length: 57
	}

	[Token(Token = "0x17000544")]
	public static DateTimeFormatInfo CurrentInfo
	{
		[Address(RVA = "0x1F5B2A0", Offset = "0x1F5A6A0", Length = "0x101")]
		[Token(Token = "0x600265D")]
		 get { } //Length: 257
	}

	[Token(Token = "0x1700054B")]
	public string DateSeparator
	{
		[Address(RVA = "0x1F5B3B0", Offset = "0x1F5A7B0", Length = "0x6A")]
		[Token(Token = "0x600266A")]
		 get { } //Length: 106
	}

	[Token(Token = "0x17000557")]
	internal string DateTimeOffsetPattern
	{
		[Address(RVA = "0x1F5B420", Offset = "0x1F5A820", Length = "0x258")]
		[Token(Token = "0x6002676")]
		internal get { } //Length: 600
	}

	[Token(Token = "0x1700055C")]
	public String[] DayNames
	{
		[Address(RVA = "0x1F5B680", Offset = "0x1F5AA80", Length = "0x8C")]
		[Token(Token = "0x600267B")]
		 get { } //Length: 140
	}

	[Token(Token = "0x17000548")]
	internal String[] EraNames
	{
		[Address(RVA = "0x1F5B710", Offset = "0x1F5AB10", Length = "0x76")]
		[Token(Token = "0x6002665")]
		internal get { } //Length: 118
	}

	[Token(Token = "0x17000570")]
	internal DateTimeFormatFlags FormatFlags
	{
		[Address(RVA = "0x1F5B790", Offset = "0x1F5AB90", Length = "0x17")]
		[Token(Token = "0x600269A")]
		internal get { } //Length: 23
	}

	[Token(Token = "0x1700054C")]
	public string FullDateTimePattern
	{
		[Address(RVA = "0x1F5B7B0", Offset = "0x1F5ABB0", Length = "0xC3")]
		[Token(Token = "0x600266B")]
		 get { } //Length: 195
	}

	[Token(Token = "0x1700056E")]
	internal string FullTimeSpanNegativePattern
	{
		[Address(RVA = "0x1F5B880", Offset = "0x1F5AC80", Length = "0x140")]
		[Token(Token = "0x6002697")]
		internal get { } //Length: 320
	}

	[Token(Token = "0x1700056D")]
	internal string FullTimeSpanPositivePattern
	{
		[Address(RVA = "0x1F5B9D0", Offset = "0x1F5ADD0", Length = "0xEA")]
		[Token(Token = "0x6002696")]
		internal get { } //Length: 234
	}

	[Token(Token = "0x17000556")]
	internal string GeneralLongTimePattern
	{
		[Address(RVA = "0x1F5BAC0", Offset = "0x1F5AEC0", Length = "0xB7")]
		[Token(Token = "0x6002675")]
		internal get { } //Length: 183
	}

	[Token(Token = "0x17000555")]
	internal string GeneralShortTimePattern
	{
		[Address(RVA = "0x1F5BB80", Offset = "0x1F5AF80", Length = "0xB7")]
		[Token(Token = "0x6002674")]
		internal get { } //Length: 183
	}

	[Token(Token = "0x17000571")]
	internal bool HasForceTwoDigitYears
	{
		[Address(RVA = "0x1F5BC40", Offset = "0x1F5B040", Length = "0x36")]
		[Token(Token = "0x600269C")]
		internal get { } //Length: 54
	}

	[Token(Token = "0x17000560")]
	internal bool HasSpacesInDayNames
	{
		[Address(RVA = "0x1F5BC80", Offset = "0x1F5B080", Length = "0x2E")]
		[Token(Token = "0x600267F")]
		internal get { } //Length: 46
	}

	[Token(Token = "0x1700055F")]
	internal bool HasSpacesInMonthNames
	{
		[Address(RVA = "0x1F5BCB0", Offset = "0x1F5B0B0", Length = "0x2E")]
		[Token(Token = "0x600267E")]
		internal get { } //Length: 46
	}

	[Token(Token = "0x17000572")]
	internal bool HasYearMonthAdjustment
	{
		[Address(RVA = "0x1F5BCE0", Offset = "0x1F5B0E0", Length = "0x2E")]
		[Token(Token = "0x600269D")]
		internal get { } //Length: 46
	}

	[Token(Token = "0x17000543")]
	public static DateTimeFormatInfo InvariantInfo
	{
		[Address(RVA = "0x1F5BD10", Offset = "0x1F5B110", Length = "0x10C")]
		[Token(Token = "0x600265C")]
		 get { } //Length: 268
	}

	[Token(Token = "0x1700056B")]
	public bool IsReadOnly
	{
		[Address(RVA = "0x1F5BE20", Offset = "0x1F5B220", Length = "0x8D")]
		[Token(Token = "0x6002694")]
		 get { } //Length: 141
	}

	[Token(Token = "0x17000542")]
	private string LanguageName
	{
		[Address(RVA = "0x1F5BEB0", Offset = "0x1F5B2B0", Length = "0x39")]
		[Token(Token = "0x6002650")]
		private get { } //Length: 57
	}

	[Token(Token = "0x1700054D")]
	public string LongDatePattern
	{
		[Address(RVA = "0x1F5BEF0", Offset = "0x1F5B2F0", Length = "0x54")]
		[Token(Token = "0x600266C")]
		 get { } //Length: 84
	}

	[Token(Token = "0x1700054E")]
	public string LongTimePattern
	{
		[Address(RVA = "0x1F5BF50", Offset = "0x1F5B350", Length = "0x84")]
		[Token(Token = "0x600266D")]
		 get { } //Length: 132
	}

	[Token(Token = "0x1700054F")]
	public string MonthDayPattern
	{
		[Address(RVA = "0x1F5BFE0", Offset = "0x1F5B3E0", Length = "0x6A")]
		[Token(Token = "0x600266E")]
		 get { } //Length: 106
	}

	[Token(Token = "0x1700056C")]
	public String[] MonthGenitiveNames
	{
		[Address(RVA = "0x1F5C050", Offset = "0x1F5B450", Length = "0xCC")]
		[Token(Token = "0x6002695")]
		 get { } //Length: 204
	}

	[Token(Token = "0x1700055E")]
	public String[] MonthNames
	{
		[Address(RVA = "0x1F5C120", Offset = "0x1F5B520", Length = "0x8C")]
		[Token(Token = "0x600267D")]
		 get { } //Length: 140
	}

	[Token(Token = "0x17000547")]
	private CalendarId[] OptionalCalendars
	{
		[Address(RVA = "0x1F5C1B0", Offset = "0x1F5B5B0", Length = "0x4B")]
		[Token(Token = "0x6002664")]
		private get { } //Length: 75
	}

	[Token(Token = "0x17000550")]
	public string PMDesignator
	{
		[Address(RVA = "0x1F5C200", Offset = "0x1F5B600", Length = "0x39")]
		[Token(Token = "0x600266F")]
		 get { } //Length: 57
	}

	[Token(Token = "0x17000551")]
	public string RFC1123Pattern
	{
		[Address(RVA = "0x1F5C240", Offset = "0x1F5B640", Length = "0x2C")]
		[Token(Token = "0x6002670")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000552")]
	public string ShortDatePattern
	{
		[Address(RVA = "0x1F5C270", Offset = "0x1F5B670", Length = "0x54")]
		[Token(Token = "0x6002671")]
		 get { } //Length: 84
	}

	[Token(Token = "0x17000553")]
	public string ShortTimePattern
	{
		[Address(RVA = "0x1F5C2D0", Offset = "0x1F5B6D0", Length = "0x84")]
		[Token(Token = "0x6002672")]
		 get { } //Length: 132
	}

	[Token(Token = "0x17000554")]
	public string SortableDateTimePattern
	{
		[Address(RVA = "0x1F5C360", Offset = "0x1F5B760", Length = "0x2C")]
		[Token(Token = "0x6002673")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000558")]
	public string TimeSeparator
	{
		[Address(RVA = "0x1F5C390", Offset = "0x1F5B790", Length = "0x39")]
		[Token(Token = "0x6002677")]
		 get { } //Length: 57
	}

	[Token(Token = "0x17000568")]
	private String[] UnclonedLongDatePatterns
	{
		[Address(RVA = "0x1F5C3D0", Offset = "0x1F5B7D0", Length = "0x76")]
		[Token(Token = "0x6002691")]
		private get { } //Length: 118
	}

	[Token(Token = "0x1700056A")]
	private String[] UnclonedLongTimePatterns
	{
		[Address(RVA = "0x1F5C450", Offset = "0x1F5B850", Length = "0x4B")]
		[Token(Token = "0x6002693")]
		private get { } //Length: 75
	}

	[Token(Token = "0x17000567")]
	private String[] UnclonedShortDatePatterns
	{
		[Address(RVA = "0x1F5C4A0", Offset = "0x1F5B8A0", Length = "0x76")]
		[Token(Token = "0x6002690")]
		private get { } //Length: 118
	}

	[Token(Token = "0x17000569")]
	private String[] UnclonedShortTimePatterns
	{
		[Address(RVA = "0x1F5C520", Offset = "0x1F5B920", Length = "0x4B")]
		[Token(Token = "0x6002692")]
		private get { } //Length: 75
	}

	[Token(Token = "0x17000566")]
	private String[] UnclonedYearMonthPatterns
	{
		[Address(RVA = "0x1F5C570", Offset = "0x1F5B970", Length = "0x76")]
		[Token(Token = "0x600268F")]
		private get { } //Length: 118
	}

	[Token(Token = "0x17000559")]
	public string UniversalSortableDateTimePattern
	{
		[Address(RVA = "0x1F5C5F0", Offset = "0x1F5B9F0", Length = "0x2C")]
		[Token(Token = "0x6002678")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700055A")]
	public string YearMonthPattern
	{
		[Address(RVA = "0x1F5C620", Offset = "0x1F5BA20", Length = "0x54")]
		[Token(Token = "0x6002679")]
		 get { } //Length: 84
	}

	[Address(RVA = "0x1F5A720", Offset = "0x1F59B20", Length = "0x95")]
	[Token(Token = "0x60026AD")]
	private static DateTimeFormatInfo() { }

	[Address(RVA = "0x1F5A7C0", Offset = "0x1F59BC0", Length = "0x281")]
	[Token(Token = "0x6002659")]
	public DateTimeFormatInfo() { }

	[Address(RVA = "0x1F5AA50", Offset = "0x1F59E50", Length = "0x61")]
	[Token(Token = "0x600265A")]
	internal DateTimeFormatInfo(CultureData cultureData, Calendar cal) { }

	[Address(RVA = "0x1F55970", Offset = "0x1F54D70", Length = "0xCD")]
	[Token(Token = "0x60026A5")]
	private void AddMonthNames(TokenHashValue[] temp, string monthPostfix) { }

	[Address(RVA = "0x1F55A40", Offset = "0x1F54E40", Length = "0x32")]
	[Token(Token = "0x60026A1")]
	private void ClearTokenHashTable() { }

	[Address(RVA = "0x1F55A80", Offset = "0x1F54E80", Length = "0x142")]
	[Token(Token = "0x6002660")]
	public override object Clone() { }

	[Address(RVA = "0x1F55BD0", Offset = "0x1F54FD0", Length = "0x117")]
	[Token(Token = "0x60026AC")]
	private bool CompareStringIgnoreCaseOptimized(string string1, int offset1, int length1, string string2, int offset2, int length2) { }

	[Address(RVA = "0x1F55CF0", Offset = "0x1F550F0", Length = "0xC55")]
	[Token(Token = "0x60026A2")]
	internal TokenHashValue[] CreateTokenHashTable() { }

	[Address(RVA = "0x1F5AB00", Offset = "0x1F59F00", Length = "0x8C")]
	[Token(Token = "0x600267A")]
	public String[] get_AbbreviatedDayNames() { }

	[Address(RVA = "0x1F5AB90", Offset = "0x1F59F90", Length = "0x76")]
	[Token(Token = "0x6002669")]
	internal String[] get_AbbreviatedEnglishEraNames() { }

	[Address(RVA = "0x1F5AC10", Offset = "0x1F5A010", Length = "0x76")]
	[Token(Token = "0x6002667")]
	internal String[] get_AbbreviatedEraNames() { }

	[Address(RVA = "0x1F5AC90", Offset = "0x1F5A090", Length = "0x8C")]
	[Token(Token = "0x600267C")]
	public String[] get_AbbreviatedMonthNames() { }

	[Address(RVA = "0x1F5AD20", Offset = "0x1F5A120", Length = "0xAB")]
	[Token(Token = "0x600268D")]
	private String[] get_AllLongDatePatterns() { }

	[Address(RVA = "0x1F5ADD0", Offset = "0x1F5A1D0", Length = "0xA0")]
	[Token(Token = "0x600268E")]
	private String[] get_AllLongTimePatterns() { }

	[Address(RVA = "0x1F5AE80", Offset = "0x1F5A280", Length = "0xAB")]
	[Token(Token = "0x600268B")]
	private String[] get_AllShortDatePatterns() { }

	[Address(RVA = "0x1F5AF30", Offset = "0x1F5A330", Length = "0xA0")]
	[Token(Token = "0x600268C")]
	private String[] get_AllShortTimePatterns() { }

	[Address(RVA = "0x1F5AFE0", Offset = "0x1F5A3E0", Length = "0xAB")]
	[Token(Token = "0x600268A")]
	private String[] get_AllYearMonthPatterns() { }

	[Address(RVA = "0x1F5AAC0", Offset = "0x1F59EC0", Length = "0x39")]
	[Token(Token = "0x6002661")]
	public string get_AMDesignator() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x6002662")]
	public Calendar get_Calendar() { }

	[Address(RVA = "0x1F5B090", Offset = "0x1F5A490", Length = "0x12A")]
	[Token(Token = "0x6002698")]
	internal CompareInfo get_CompareInfo() { }

	[Address(RVA = "0x1F5B200", Offset = "0x1F5A600", Length = "0x99")]
	[Token(Token = "0x600264F")]
	private CultureInfo get_Culture() { }

	[Address(RVA = "0x1F5B1C0", Offset = "0x1F5A5C0", Length = "0x39")]
	[Token(Token = "0x600264E")]
	private string get_CultureName() { }

	[Address(RVA = "0x1F5B2A0", Offset = "0x1F5A6A0", Length = "0x101")]
	[Token(Token = "0x600265D")]
	public static DateTimeFormatInfo get_CurrentInfo() { }

	[Address(RVA = "0x1F5B3B0", Offset = "0x1F5A7B0", Length = "0x6A")]
	[Token(Token = "0x600266A")]
	public string get_DateSeparator() { }

	[Address(RVA = "0x1F5B420", Offset = "0x1F5A820", Length = "0x258")]
	[Token(Token = "0x6002676")]
	internal string get_DateTimeOffsetPattern() { }

	[Address(RVA = "0x1F5B680", Offset = "0x1F5AA80", Length = "0x8C")]
	[Token(Token = "0x600267B")]
	public String[] get_DayNames() { }

	[Address(RVA = "0x1F5B710", Offset = "0x1F5AB10", Length = "0x76")]
	[Token(Token = "0x6002665")]
	internal String[] get_EraNames() { }

	[Address(RVA = "0x1F5B790", Offset = "0x1F5AB90", Length = "0x17")]
	[Token(Token = "0x600269A")]
	internal DateTimeFormatFlags get_FormatFlags() { }

	[Address(RVA = "0x1F5B7B0", Offset = "0x1F5ABB0", Length = "0xC3")]
	[Token(Token = "0x600266B")]
	public string get_FullDateTimePattern() { }

	[Address(RVA = "0x1F5B880", Offset = "0x1F5AC80", Length = "0x140")]
	[Token(Token = "0x6002697")]
	internal string get_FullTimeSpanNegativePattern() { }

	[Address(RVA = "0x1F5B9D0", Offset = "0x1F5ADD0", Length = "0xEA")]
	[Token(Token = "0x6002696")]
	internal string get_FullTimeSpanPositivePattern() { }

	[Address(RVA = "0x1F5BAC0", Offset = "0x1F5AEC0", Length = "0xB7")]
	[Token(Token = "0x6002675")]
	internal string get_GeneralLongTimePattern() { }

	[Address(RVA = "0x1F5BB80", Offset = "0x1F5AF80", Length = "0xB7")]
	[Token(Token = "0x6002674")]
	internal string get_GeneralShortTimePattern() { }

	[Address(RVA = "0x1F5BC40", Offset = "0x1F5B040", Length = "0x36")]
	[Token(Token = "0x600269C")]
	internal bool get_HasForceTwoDigitYears() { }

	[Address(RVA = "0x1F5BC80", Offset = "0x1F5B080", Length = "0x2E")]
	[Token(Token = "0x600267F")]
	internal bool get_HasSpacesInDayNames() { }

	[Address(RVA = "0x1F5BCB0", Offset = "0x1F5B0B0", Length = "0x2E")]
	[Token(Token = "0x600267E")]
	internal bool get_HasSpacesInMonthNames() { }

	[Address(RVA = "0x1F5BCE0", Offset = "0x1F5B0E0", Length = "0x2E")]
	[Token(Token = "0x600269D")]
	internal bool get_HasYearMonthAdjustment() { }

	[Address(RVA = "0x1F5BD10", Offset = "0x1F5B110", Length = "0x10C")]
	[Token(Token = "0x600265C")]
	public static DateTimeFormatInfo get_InvariantInfo() { }

	[Address(RVA = "0x1F5BE20", Offset = "0x1F5B220", Length = "0x8D")]
	[Token(Token = "0x6002694")]
	public bool get_IsReadOnly() { }

	[Address(RVA = "0x1F5BEB0", Offset = "0x1F5B2B0", Length = "0x39")]
	[Token(Token = "0x6002650")]
	private string get_LanguageName() { }

	[Address(RVA = "0x1F5BEF0", Offset = "0x1F5B2F0", Length = "0x54")]
	[Token(Token = "0x600266C")]
	public string get_LongDatePattern() { }

	[Address(RVA = "0x1F5BF50", Offset = "0x1F5B350", Length = "0x84")]
	[Token(Token = "0x600266D")]
	public string get_LongTimePattern() { }

	[Address(RVA = "0x1F5BFE0", Offset = "0x1F5B3E0", Length = "0x6A")]
	[Token(Token = "0x600266E")]
	public string get_MonthDayPattern() { }

	[Address(RVA = "0x1F5C050", Offset = "0x1F5B450", Length = "0xCC")]
	[Token(Token = "0x6002695")]
	public String[] get_MonthGenitiveNames() { }

	[Address(RVA = "0x1F5C120", Offset = "0x1F5B520", Length = "0x8C")]
	[Token(Token = "0x600267D")]
	public String[] get_MonthNames() { }

	[Address(RVA = "0x1F5C1B0", Offset = "0x1F5B5B0", Length = "0x4B")]
	[Token(Token = "0x6002664")]
	private CalendarId[] get_OptionalCalendars() { }

	[Address(RVA = "0x1F5C200", Offset = "0x1F5B600", Length = "0x39")]
	[Token(Token = "0x600266F")]
	public string get_PMDesignator() { }

	[Address(RVA = "0x1F5C240", Offset = "0x1F5B640", Length = "0x2C")]
	[Token(Token = "0x6002670")]
	public string get_RFC1123Pattern() { }

	[Address(RVA = "0x1F5C270", Offset = "0x1F5B670", Length = "0x54")]
	[Token(Token = "0x6002671")]
	public string get_ShortDatePattern() { }

	[Address(RVA = "0x1F5C2D0", Offset = "0x1F5B6D0", Length = "0x84")]
	[Token(Token = "0x6002672")]
	public string get_ShortTimePattern() { }

	[Address(RVA = "0x1F5C360", Offset = "0x1F5B760", Length = "0x2C")]
	[Token(Token = "0x6002673")]
	public string get_SortableDateTimePattern() { }

	[Address(RVA = "0x1F5C390", Offset = "0x1F5B790", Length = "0x39")]
	[Token(Token = "0x6002677")]
	public string get_TimeSeparator() { }

	[Address(RVA = "0x1F5C3D0", Offset = "0x1F5B7D0", Length = "0x76")]
	[Token(Token = "0x6002691")]
	private String[] get_UnclonedLongDatePatterns() { }

	[Address(RVA = "0x1F5C450", Offset = "0x1F5B850", Length = "0x4B")]
	[Token(Token = "0x6002693")]
	private String[] get_UnclonedLongTimePatterns() { }

	[Address(RVA = "0x1F5C4A0", Offset = "0x1F5B8A0", Length = "0x76")]
	[Token(Token = "0x6002690")]
	private String[] get_UnclonedShortDatePatterns() { }

	[Address(RVA = "0x1F5C520", Offset = "0x1F5B920", Length = "0x4B")]
	[Token(Token = "0x6002692")]
	private String[] get_UnclonedShortTimePatterns() { }

	[Address(RVA = "0x1F5C570", Offset = "0x1F5B970", Length = "0x76")]
	[Token(Token = "0x600268F")]
	private String[] get_UnclonedYearMonthPatterns() { }

	[Address(RVA = "0x1F5C5F0", Offset = "0x1F5B9F0", Length = "0x2C")]
	[Token(Token = "0x6002678")]
	public string get_UniversalSortableDateTimePattern() { }

	[Address(RVA = "0x1F5C620", Offset = "0x1F5BA20", Length = "0x54")]
	[Token(Token = "0x6002679")]
	public string get_YearMonthPattern() { }

	[Address(RVA = "0x1F56950", Offset = "0x1F55D50", Length = "0x10A")]
	[Token(Token = "0x6002683")]
	public string GetAbbreviatedDayName(DayOfWeek dayofweek) { }

	[Address(RVA = "0x1F56A60", Offset = "0x1F55E60", Length = "0x166")]
	[Token(Token = "0x6002668")]
	public string GetAbbreviatedEraName(int era) { }

	[Address(RVA = "0x1F56BD0", Offset = "0x1F55FD0", Length = "0x101")]
	[Token(Token = "0x6002687")]
	public string GetAbbreviatedMonthName(int month) { }

	[Address(RVA = "0x1F56CE0", Offset = "0x1F560E0", Length = "0x484")]
	[Token(Token = "0x6002685")]
	public String[] GetAllDateTimePatterns(char format) { }

	[Address(RVA = "0x1F571C0", Offset = "0x1F565C0", Length = "0x155")]
	[Token(Token = "0x6002684")]
	private static String[] GetCombinedPatterns(String[] patterns1, String[] patterns2, string connectString) { }

	[Address(RVA = "0x1F57320", Offset = "0x1F56720", Length = "0x10A")]
	[Token(Token = "0x6002686")]
	public string GetDayName(DayOfWeek dayofweek) { }

	[Address(RVA = "0x1F57430", Offset = "0x1F56830", Length = "0x13C")]
	[Token(Token = "0x6002666")]
	public string GetEraName(int era) { }

	[Address(RVA = "0x1F57570", Offset = "0x1F56970", Length = "0x80")]
	[Token(Token = "0x600265F")]
	public override object GetFormat(Type formatType) { }

	[Address(RVA = "0x1F575F0", Offset = "0x1F569F0", Length = "0x1C5")]
	[Token(Token = "0x600265E")]
	public static DateTimeFormatInfo GetInstance(IFormatProvider provider) { }

	[Address(RVA = "0x1F577C0", Offset = "0x1F56BC0", Length = "0x1AF")]
	[Token(Token = "0x600269F")]
	internal static DateTimeFormatInfo GetJapaneseCalendarDTFI() { }

	[Address(RVA = "0x1F57970", Offset = "0x1F56D70", Length = "0x1C4")]
	[Token(Token = "0x6002689")]
	private static String[] GetMergedPatterns(String[] patterns, string defaultPattern) { }

	[Address(RVA = "0x1F57B40", Offset = "0x1F56F40", Length = "0x101")]
	[Token(Token = "0x6002688")]
	public string GetMonthName(int month) { }

	[Address(RVA = "0x1F57C50", Offset = "0x1F57050", Length = "0x1AF")]
	[Token(Token = "0x60026A0")]
	internal static DateTimeFormatInfo GetTaiwanCalendarDTFI() { }

	[Address(RVA = "0x1F57E00", Offset = "0x1F57200", Length = "0x35D")]
	[Token(Token = "0x600269B")]
	private DateTimeFormatFlags InitializeFormatFlags() { }

	[Address(RVA = "0x1F58160", Offset = "0x1F57560", Length = "0x1B4")]
	[Token(Token = "0x600265B")]
	private void InitializeOverridableProperties(CultureData cultureData, int calendarId) { }

	[Address(RVA = "0x1F58320", Offset = "0x1F57720", Length = "0x257")]
	[Token(Token = "0x60026AA")]
	private void InsertAtCurrentHashNode(TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe) { }

	[Address(RVA = "0x1F58580", Offset = "0x1F57980", Length = "0x425")]
	[Token(Token = "0x60026AB")]
	private void InsertHash(TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue) { }

	[Address(RVA = "0x1F5C6F0", Offset = "0x1F5BAF0", Length = "0x14")]
	[Token(Token = "0x6002651")]
	private String[] internalGetAbbreviatedDayOfWeekNames() { }

	[Address(RVA = "0x1F5C680", Offset = "0x1F5BA80", Length = "0x6C")]
	[Token(Token = "0x6002652")]
	private String[] internalGetAbbreviatedDayOfWeekNamesCore() { }

	[Address(RVA = "0x1F5C780", Offset = "0x1F5BB80", Length = "0x14")]
	[Token(Token = "0x6002655")]
	private String[] internalGetAbbreviatedMonthNames() { }

	[Address(RVA = "0x1F5C710", Offset = "0x1F5BB10", Length = "0x6C")]
	[Token(Token = "0x6002656")]
	private String[] internalGetAbbreviatedMonthNamesCore() { }

	[Address(RVA = "0x1F5C810", Offset = "0x1F5BC10", Length = "0x14")]
	[Token(Token = "0x6002653")]
	private String[] internalGetDayOfWeekNames() { }

	[Address(RVA = "0x1F5C7A0", Offset = "0x1F5BBA0", Length = "0x6C")]
	[Token(Token = "0x6002654")]
	private String[] internalGetDayOfWeekNamesCore() { }

	[Address(RVA = "0x1F5C830", Offset = "0x1F5BC30", Length = "0xE6")]
	[Token(Token = "0x6002681")]
	private String[] internalGetGenitiveMonthNames(bool abbreviated) { }

	[Address(RVA = "0x1F5C920", Offset = "0x1F5BD20", Length = "0x76")]
	[Token(Token = "0x6002682")]
	internal String[] internalGetLeapYearMonthNames() { }

	[Address(RVA = "0x1F5C9A0", Offset = "0x1F5BDA0", Length = "0x1B0")]
	[Token(Token = "0x6002680")]
	internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated) { }

	[Address(RVA = "0x1F5CBD0", Offset = "0x1F5BFD0", Length = "0x14")]
	[Token(Token = "0x6002657")]
	private String[] internalGetMonthNames() { }

	[Address(RVA = "0x1F5CB60", Offset = "0x1F5BF60", Length = "0x6C")]
	[Token(Token = "0x6002658")]
	private String[] internalGetMonthNamesCore() { }

	[Address(RVA = "0x1F589B0", Offset = "0x1F57DB0", Length = "0x110")]
	[Token(Token = "0x60026A8")]
	private bool IsAllowedJapaneseTokenFollowedByNonSpaceLetter(string tokenString, char nextCh) { }

	[Address(RVA = "0x1F58AD0", Offset = "0x1F57ED0", Length = "0x19")]
	[Token(Token = "0x60026A7")]
	private static bool IsHebrewChar(char ch) { }

	[Address(RVA = "0x1F58AF0", Offset = "0x1F57EF0", Length = "0x121")]
	[Token(Token = "0x60026A4")]
	private static bool IsJapaneseCalendar(Calendar calendar) { }

	[Address(RVA = "0x1F58C20", Offset = "0x1F58020", Length = "0xF2B")]
	[Token(Token = "0x60026A3")]
	private void PopulateSpecialTokenHashTable(TokenHashValue[] temp, ref bool useDateSepAsIgnorableSymbol) { }

	[Address(RVA = "0x1F5CBF0", Offset = "0x1F5BFF0", Length = "0x6D9")]
	[Token(Token = "0x6002663")]
	public void set_Calendar(Calendar value) { }

	[Address(RVA = "0x1F59B50", Offset = "0x1F58F50", Length = "0x7F1")]
	[Token(Token = "0x60026A9")]
	internal bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str) { }

	[Address(RVA = "0x1F5A350", Offset = "0x1F59750", Length = "0x151")]
	[Token(Token = "0x60026A6")]
	private static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number) { }

	[Address(RVA = "0x1F5A4B0", Offset = "0x1F598B0", Length = "0x125")]
	[Token(Token = "0x6002699")]
	internal static void ValidateStyles(DateTimeStyles style, string parameterName) { }

	[Address(RVA = "0x1F5A5E0", Offset = "0x1F599E0", Length = "0x13A")]
	[Token(Token = "0x600269E")]
	internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName) { }

}

