namespace System.Globalization;

[ComVisible(True)]
[Token(Token = "0x200057A")]
public class CultureInfo : ICloneable, IFormatProvider
{
	[Token(Token = "0x200057B")]
	private struct Data
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001736")]
		public int ansi; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4001737")]
		public int ebcdic; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001738")]
		public int mac; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4001739")]
		public int oem; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400173A")]
		public bool right_to_left; //Field offset: 0x10
		[FieldOffset(Offset = "0x11")]
		[Token(Token = "0x400173B")]
		public byte list_sep; //Field offset: 0x11

	}

	[Token(Token = "0x200057C")]
	private sealed class OnCultureInfoChangedDelegate : MulticastDelegate
	{

		[Address(RVA = "0x1FCA570", Offset = "0x1FC9970", Length = "0xB4")]
		[Token(Token = "0x60028B4")]
		public OnCultureInfoChangedDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x60028B5")]
		public override void Invoke(string language) { }

	}

	[Token(Token = "0x400170E")]
	private static CultureInfo invariant_culture_info; //Field offset: 0x0
	[Token(Token = "0x400172F")]
	private const string MSG_READONLY = "This instance is read only"; //Field offset: 0x0
	[Token(Token = "0x400172E")]
	internal const int LOCALE_INVARIANT = 127; //Field offset: 0x0
	[Token(Token = "0x400172D")]
	private const int CalendarTypeBits = 8; //Field offset: 0x0
	[Token(Token = "0x400172C")]
	internal const int InvariantCultureId = 127; //Field offset: 0x0
	[Token(Token = "0x400170F")]
	private static object shared_table_lock; //Field offset: 0x8
	[Token(Token = "0x4001710")]
	private static CultureInfo default_current_culture; //Field offset: 0x10
	[Token(Token = "0x4001730")]
	private static CultureInfo s_DefaultThreadCurrentUICulture; //Field offset: 0x18
	[Token(Token = "0x4001731")]
	private static CultureInfo s_DefaultThreadCurrentCulture; //Field offset: 0x20
	[Token(Token = "0x4001732")]
	private static Dictionary<Int32, CultureInfo> shared_by_number; //Field offset: 0x28
	[Token(Token = "0x4001733")]
	private static Dictionary<String, CultureInfo> shared_by_name; //Field offset: 0x30
	[Token(Token = "0x4001734")]
	private static CultureInfo s_UserPreferredCultureInfoInAppX; //Field offset: 0x38
	[Token(Token = "0x4001735")]
	internal static readonly bool IsTaiwanSku; //Field offset: 0x40
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001711")]
	private bool m_isReadOnly; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001712")]
	private int cultureID; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001713")]
	private int parent_lcid; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001714")]
	private int datetime_index; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001715")]
	private int number_index; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001716")]
	private int default_calendar_type; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001717")]
	private bool m_useUserOverride; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001718")]
	internal NumberFormatInfo numInfo; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001719")]
	internal DateTimeFormatInfo dateTimeInfo; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400171A")]
	private TextInfo textInfo; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400171B")]
	internal string m_name; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400171C")]
	private string englishname; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400171D")]
	private string nativename; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400171E")]
	private string iso3lang; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400171F")]
	private string iso2lang; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001720")]
	private string win3lang; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001721")]
	private string territory; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001722")]
	private String[] native_calendar_names; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001723")]
	private CompareInfo compareInfo; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001724")]
	private readonly Void* textinfo_data; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001725")]
	private int m_dataItem; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001726")]
	private Calendar calendar; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4001727")]
	private CultureInfo parent_culture; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001728")]
	private bool constructed; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4001729")]
	internal Byte[] cached_serialized_form; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400172A")]
	internal CultureData m_cultureData; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400172B")]
	internal bool m_isInherited; //Field offset: 0xC8

	[Token(Token = "0x170005DC")]
	internal CultureData _cultureData
	{
		[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
		[Token(Token = "0x6002876")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170005DD")]
	internal bool _isInherited
	{
		[Address(RVA = "0x1D239B0", Offset = "0x1D22DB0", Length = "0x8")]
		[Token(Token = "0x6002877")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170005E2")]
	internal string _name
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x600287E")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170005E5")]
	public override Calendar Calendar
	{
		[Address(RVA = "0x1FAEAA0", Offset = "0x1FADEA0", Length = "0x98")]
		[Token(Token = "0x6002881")]
		 get { } //Length: 152
	}

	[Token(Token = "0x170005ED")]
	internal int CalendarType
	{
		[Address(RVA = "0x1FAEA00", Offset = "0x1FADE00", Length = "0x98")]
		[Token(Token = "0x60028A8")]
		internal get { } //Length: 152
	}

	[Token(Token = "0x170005E8")]
	public override CompareInfo CompareInfo
	{
		[Address(RVA = "0x1FAEB40", Offset = "0x1FADF40", Length = "0x144")]
		[Token(Token = "0x600288A")]
		 get { } //Length: 324
	}

	[Token(Token = "0x170005DF")]
	public static CultureInfo CurrentCulture
	{
		[Address(RVA = "0x1FAEC90", Offset = "0x1FAE090", Length = "0x23")]
		[Token(Token = "0x6002879")]
		 get { } //Length: 35
	}

	[Token(Token = "0x170005E0")]
	public static CultureInfo CurrentUICulture
	{
		[Address(RVA = "0x1FAECC0", Offset = "0x1FAE0C0", Length = "0x23")]
		[Token(Token = "0x600287A")]
		 get { } //Length: 35
	}

	[Token(Token = "0x170005EB")]
	public override DateTimeFormatInfo DateTimeFormat
	{
		[Address(RVA = "0x1FAECF0", Offset = "0x1FAE0F0", Length = "0x187")]
		[Token(Token = "0x600288F")]
		 get { } //Length: 391
		[Address(RVA = "0x1FAF7B0", Offset = "0x1FAEBB0", Length = "0xE3")]
		[Token(Token = "0x6002890")]
		 set { } //Length: 227
	}

	[Token(Token = "0x170005EE")]
	public static CultureInfo DefaultThreadCurrentCulture
	{
		[Address(RVA = "0x1FAEE80", Offset = "0x1FAE280", Length = "0x5A")]
		[Token(Token = "0x60028AB")]
		 get { } //Length: 90
	}

	[Token(Token = "0x170005EF")]
	public static CultureInfo DefaultThreadCurrentUICulture
	{
		[Address(RVA = "0x1FAEEE0", Offset = "0x1FAE2E0", Length = "0x5A")]
		[Token(Token = "0x60028AC")]
		 get { } //Length: 90
	}

	[Token(Token = "0x170005EC")]
	public override string EnglishName
	{
		[Address(RVA = "0x1FAEF40", Offset = "0x1FAE340", Length = "0x35")]
		[Token(Token = "0x6002891")]
		 get { } //Length: 53
	}

	[Token(Token = "0x170005DE")]
	public static CultureInfo InvariantCulture
	{
		[Address(RVA = "0x1FAEF80", Offset = "0x1FAE380", Length = "0x59")]
		[Token(Token = "0x6002878")]
		 get { } //Length: 89
	}

	[Token(Token = "0x170005E9")]
	public override bool IsNeutralCulture
	{
		[Address(RVA = "0x1FAEFE0", Offset = "0x1FAE3E0", Length = "0x3D")]
		[Token(Token = "0x600288B")]
		 get { } //Length: 61
	}

	[Token(Token = "0x170005E3")]
	public override int LCID
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x600287F")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170005E4")]
	public override string Name
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6002880")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005EA")]
	public override NumberFormatInfo NumberFormat
	{
		[Address(RVA = "0x1FAF020", Offset = "0x1FAE420", Length = "0xA5")]
		[Token(Token = "0x600288D")]
		 get { } //Length: 165
		[Address(RVA = "0x1FAF8A0", Offset = "0x1FAECA0", Length = "0xE3")]
		[Token(Token = "0x600288E")]
		 set { } //Length: 227
	}

	[Token(Token = "0x170005E6")]
	public override CultureInfo Parent
	{
		[Address(RVA = "0x1FAF0D0", Offset = "0x1FAE4D0", Length = "0x2CA")]
		[Token(Token = "0x6002882")]
		 get { } //Length: 714
	}

	[Token(Token = "0x170005F0")]
	internal string SortName
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x60028AD")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170005E1")]
	internal string Territory
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x600287D")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170005E7")]
	public override TextInfo TextInfo
	{
		[Address(RVA = "0x1FAF3A0", Offset = "0x1FAE7A0", Length = "0x150")]
		[Token(Token = "0x6002883")]
		 get { } //Length: 336
	}

	[Token(Token = "0x170005F2")]
	internal static CultureInfo UserDefaultCulture
	{
		[Address(RVA = "0x1FAF500", Offset = "0x1FAE900", Length = "0x40")]
		[Token(Token = "0x60028AF")]
		internal get { } //Length: 64
	}

	[Token(Token = "0x170005F1")]
	internal static CultureInfo UserDefaultUICulture
	{
		[Address(RVA = "0x1FAF540", Offset = "0x1FAE940", Length = "0x71")]
		[Token(Token = "0x60028AE")]
		internal get { } //Length: 113
	}

	[Address(RVA = "0x1FADF60", Offset = "0x1FAD360", Length = "0x3DB")]
	[Token(Token = "0x60028B3")]
	private static CultureInfo() { }

	[Address(RVA = "0x1FAE640", Offset = "0x1FADA40", Length = "0x1D")]
	[Token(Token = "0x60028A0")]
	private CultureInfo() { }

	[Address(RVA = "0x1FAE340", Offset = "0x1FAD740", Length = "0x2D4")]
	[Token(Token = "0x600289F")]
	private CultureInfo(string name, bool useUserOverride, bool read_only) { }

	[Address(RVA = "0x1FAE9A0", Offset = "0x1FADDA0", Length = "0x1A")]
	[Token(Token = "0x600289E")]
	public CultureInfo(string name, bool useUserOverride) { }

	[Address(RVA = "0x1FAE620", Offset = "0x1FADA20", Length = "0x1D")]
	[Token(Token = "0x600289D")]
	public CultureInfo(string name) { }

	[Address(RVA = "0x1FAE680", Offset = "0x1FADA80", Length = "0x31B")]
	[Token(Token = "0x600289C")]
	private CultureInfo(int culture, bool useUserOverride, bool read_only) { }

	[Address(RVA = "0x1FAE660", Offset = "0x1FADA60", Length = "0x1A")]
	[Token(Token = "0x600289B")]
	public CultureInfo(int culture, bool useUserOverride) { }

	[Address(RVA = "0x1FAE9C0", Offset = "0x1FADDC0", Length = "0x1D")]
	[Token(Token = "0x600289A")]
	public CultureInfo(int culture) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600288C")]
	private void CheckNeutral() { }

	[Address(RVA = "0x1FAA3B0", Offset = "0x1FA97B0", Length = "0x1CC")]
	[Token(Token = "0x6002884")]
	public override object Clone() { }

	[Address(RVA = "0x1FAAA30", Offset = "0x1FA9E30", Length = "0x1E")]
	[Token(Token = "0x6002893")]
	private void Construct() { }

	[Address(RVA = "0x1FAE9E0", Offset = "0x1FADDE0", Length = "0x5")]
	[Token(Token = "0x6002894")]
	private bool construct_internal_locale_from_lcid(int lcid) { }

	[Address(RVA = "0x1FAE9F0", Offset = "0x1FADDF0", Length = "0x5")]
	[Token(Token = "0x6002895")]
	private bool construct_internal_locale_from_name(string name) { }

	[Address(RVA = "0x1FAA580", Offset = "0x1FA9980", Length = "0x1E4")]
	[Token(Token = "0x600287B")]
	internal static CultureInfo ConstructCurrentCulture() { }

	[Address(RVA = "0x1FAA770", Offset = "0x1FA9B70", Length = "0x40")]
	[Token(Token = "0x600287C")]
	internal static CultureInfo ConstructCurrentUICulture() { }

	[Address(RVA = "0x1FAA7B0", Offset = "0x1FA9BB0", Length = "0x1D8")]
	[Token(Token = "0x6002898")]
	private void ConstructInvariant(bool read_only) { }

	[Address(RVA = "0x1FAA990", Offset = "0x1FA9D90", Length = "0x92")]
	[Token(Token = "0x60028A6")]
	private bool ConstructLocaleFromName(string name) { }

	[Address(RVA = "0x1FAAA50", Offset = "0x1FA9E50", Length = "0x1F6")]
	[Token(Token = "0x60028A9")]
	private static Calendar CreateCalendar(int calendarType) { }

	[Address(RVA = "0x1FAAC50", Offset = "0x1FAA050", Length = "0x81")]
	[Token(Token = "0x60028A4")]
	internal static CultureInfo CreateCulture(string name, bool reference) { }

	[Address(RVA = "0x1FAACE0", Offset = "0x1FAA0E0", Length = "0x9B")]
	[Token(Token = "0x60028AA")]
	private static Exception CreateNotFoundException(string name) { }

	[Address(RVA = "0x1FACF60", Offset = "0x1FAC360", Length = "0x31A")]
	[Token(Token = "0x60028A5")]
	public static CultureInfo CreateSpecificCulture(string name) { }

	[Address(RVA = "0x1FAAD80", Offset = "0x1FAA180", Length = "0x21D0")]
	[Token(Token = "0x60028A7")]
	private static CultureInfo CreateSpecificCultureFromNeutral(string name) { }

	[Address(RVA = "0x1FAD280", Offset = "0x1FAC680", Length = "0x76")]
	[Token(Token = "0x6002899")]
	private TextInfo CreateTextInfo(bool readOnly) { }

	[Address(RVA = "0x1FAD300", Offset = "0x1FAC700", Length = "0x8B")]
	[Token(Token = "0x6002885")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
	[Token(Token = "0x6002876")]
	internal CultureData get__cultureData() { }

	[Address(RVA = "0x1D239B0", Offset = "0x1D22DB0", Length = "0x8")]
	[Token(Token = "0x6002877")]
	internal bool get__isInherited() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x600287E")]
	internal string get__name() { }

	[Address(RVA = "0x1FAEAA0", Offset = "0x1FADEA0", Length = "0x98")]
	[Token(Token = "0x6002881")]
	public override Calendar get_Calendar() { }

	[Address(RVA = "0x1FAEA00", Offset = "0x1FADE00", Length = "0x98")]
	[Token(Token = "0x60028A8")]
	internal int get_CalendarType() { }

	[Address(RVA = "0x1FAEB40", Offset = "0x1FADF40", Length = "0x144")]
	[Token(Token = "0x600288A")]
	public override CompareInfo get_CompareInfo() { }

	[Address(RVA = "0x1FAF5C0", Offset = "0x1FAE9C0", Length = "0x5")]
	[Token(Token = "0x6002896")]
	private static string get_current_locale_name() { }

	[Address(RVA = "0x1FAEC90", Offset = "0x1FAE090", Length = "0x23")]
	[Token(Token = "0x6002879")]
	public static CultureInfo get_CurrentCulture() { }

	[Address(RVA = "0x1FAECC0", Offset = "0x1FAE0C0", Length = "0x23")]
	[Token(Token = "0x600287A")]
	public static CultureInfo get_CurrentUICulture() { }

	[Address(RVA = "0x1FAECF0", Offset = "0x1FAE0F0", Length = "0x187")]
	[Token(Token = "0x600288F")]
	public override DateTimeFormatInfo get_DateTimeFormat() { }

	[Address(RVA = "0x1FAEE80", Offset = "0x1FAE280", Length = "0x5A")]
	[Token(Token = "0x60028AB")]
	public static CultureInfo get_DefaultThreadCurrentCulture() { }

	[Address(RVA = "0x1FAEEE0", Offset = "0x1FAE2E0", Length = "0x5A")]
	[Token(Token = "0x60028AC")]
	public static CultureInfo get_DefaultThreadCurrentUICulture() { }

	[Address(RVA = "0x1FAEF40", Offset = "0x1FAE340", Length = "0x35")]
	[Token(Token = "0x6002891")]
	public override string get_EnglishName() { }

	[Address(RVA = "0x1FAEF80", Offset = "0x1FAE380", Length = "0x59")]
	[Token(Token = "0x6002878")]
	public static CultureInfo get_InvariantCulture() { }

	[Address(RVA = "0x1FAEFE0", Offset = "0x1FAE3E0", Length = "0x3D")]
	[Token(Token = "0x600288B")]
	public override bool get_IsNeutralCulture() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x600287F")]
	public override int get_LCID() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6002880")]
	public override string get_Name() { }

	[Address(RVA = "0x1FAF020", Offset = "0x1FAE420", Length = "0xA5")]
	[Token(Token = "0x600288D")]
	public override NumberFormatInfo get_NumberFormat() { }

	[Address(RVA = "0x1FAF0D0", Offset = "0x1FAE4D0", Length = "0x2CA")]
	[Token(Token = "0x6002882")]
	public override CultureInfo get_Parent() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x60028AD")]
	internal string get_SortName() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x600287D")]
	internal string get_Territory() { }

	[Address(RVA = "0x1FAF3A0", Offset = "0x1FAE7A0", Length = "0x150")]
	[Token(Token = "0x6002883")]
	public override TextInfo get_TextInfo() { }

	[Address(RVA = "0x1FAF500", Offset = "0x1FAE900", Length = "0x40")]
	[Token(Token = "0x60028AF")]
	internal static CultureInfo get_UserDefaultCulture() { }

	[Address(RVA = "0x1FAF540", Offset = "0x1FAE940", Length = "0x71")]
	[Token(Token = "0x60028AE")]
	internal static CultureInfo get_UserDefaultUICulture() { }

	[Address(RVA = "0x1FAD480", Offset = "0x1FAC880", Length = "0x26F")]
	[Token(Token = "0x60028A2")]
	public static CultureInfo GetCultureInfo(int culture) { }

	[Address(RVA = "0x1FAD6F0", Offset = "0x1FACAF0", Length = "0x260")]
	[Token(Token = "0x60028A3")]
	public static CultureInfo GetCultureInfo(string name) { }

	[Address(RVA = "0x1FAD390", Offset = "0x1FAC790", Length = "0xF0")]
	[Token(Token = "0x60028B2")]
	internal static CultureInfo GetCultureInfoForUserPreferredLanguageInAppX() { }

	[Address(RVA = "0x1FAD960", Offset = "0x1FACD60", Length = "0x3C9")]
	[Token(Token = "0x6002886")]
	public static CultureInfo[] GetCultures(CultureTypes types) { }

	[Address(RVA = "0x1FADD30", Offset = "0x1FAD130", Length = "0xF8")]
	[Token(Token = "0x6002892")]
	public override object GetFormat(Type formatType) { }

	[Address(RVA = "0x1FADE30", Offset = "0x1FAD230", Length = "0xB")]
	[Token(Token = "0x6002888")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1FADE40", Offset = "0x1FAD240", Length = "0x17")]
	[Token(Token = "0x6002887")]
	private Data GetTextInfoData() { }

	[Address(RVA = "0x1FADE60", Offset = "0x1FAD260", Length = "0x15")]
	[Token(Token = "0x60028B0")]
	private static void InitializeUserPreferredCultureInfoInAppX(OnCultureInfoChangedDelegate onCultureInfoChangedInAppX) { }

	[Address(RVA = "0x1FAF5D0", Offset = "0x1FAE9D0", Length = "0x1C5")]
	[Token(Token = "0x60028A1")]
	private static void insert_into_shared_tables(CultureInfo c) { }

	[Address(RVA = "0x1FAF7A0", Offset = "0x1FAEBA0", Length = "0x5")]
	[Token(Token = "0x6002897")]
	private static CultureInfo[] internal_get_cultures(bool neutral, bool specific, bool installed) { }

	[Address(RVA = "0x1FADE80", Offset = "0x1FAD280", Length = "0xD1")]
	[MonoPInvokeCallback(typeof(OnCultureInfoChangedDelegate))]
	[Token(Token = "0x60028B1")]
	private static void OnCultureInfoChangedInAppX(string language) { }

	[Address(RVA = "0x1FAF7B0", Offset = "0x1FAEBB0", Length = "0xE3")]
	[Token(Token = "0x6002890")]
	public override void set_DateTimeFormat(DateTimeFormatInfo value) { }

	[Address(RVA = "0x1FAF8A0", Offset = "0x1FAECA0", Length = "0xE3")]
	[Token(Token = "0x600288E")]
	public override void set_NumberFormat(NumberFormatInfo value) { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6002889")]
	public virtual string ToString() { }

}

