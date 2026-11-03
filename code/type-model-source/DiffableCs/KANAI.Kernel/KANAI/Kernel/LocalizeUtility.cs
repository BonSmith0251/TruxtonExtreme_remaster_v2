namespace KANAI.Kernel;

[Token(Token = "0x200001C")]
public class LocalizeUtility
{
	[Token(Token = "0x200001D")]
	internal enum Area : int
	{
		Unknown = -1,
		En = 0,
		Jp = 1,
		Zhtw = 2,
		Zhcn = 3,
		Es = 4,
		Kr = 5,
		De = 6,
		Fr = 7,
		It = 8,
		Pt = 8,
		Eses = 9,
	}

	[Token(Token = "0x4000080")]
	public static readonly int CountLanguages; //Field offset: 0x0
	[Token(Token = "0x4000081")]
	private const Area DefaultLanguage = 0; //Field offset: 0x0
	[Token(Token = "0x4000082")]
	private static Area _appLanguage; //Field offset: 0x4
	[Token(Token = "0x4000083")]
	private static Area _currentArea; //Field offset: 0x8
	[Token(Token = "0x4000084")]
	private static readonly Dictionary<SystemLanguage, Area> _languageAreas; //Field offset: 0x10
	[Token(Token = "0x4000085")]
	private static readonly Dictionary<String, Area> _languageAreasString; //Field offset: 0x18
	[Token(Token = "0x4000086")]
	private static readonly Dictionary<Area, String> _languageNameKey; //Field offset: 0x20

	[Address(RVA = "0x1DEB1E0", Offset = "0x1DEA5E0", Length = "0x5A7")]
	[Token(Token = "0x6000100")]
	private static LocalizeUtility() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000FF")]
	public LocalizeUtility() { }

	[Address(RVA = "0x1DEA950", Offset = "0x1DE9D50", Length = "0x74")]
	[Token(Token = "0x60000F0")]
	public static Area GetApplicationArea() { }

	[Address(RVA = "0x1DEAA20", Offset = "0x1DE9E20", Length = "0x96")]
	[Token(Token = "0x60000EE")]
	public static Area GetArea(SystemLanguage s) { }

	[Address(RVA = "0x1DEA9D0", Offset = "0x1DE9DD0", Length = "0x4F")]
	[Token(Token = "0x60000FA")]
	public static string GetAreaLabel(Area area) { }

	[Address(RVA = "0x1DEAB50", Offset = "0x1DE9F50", Length = "0x86")]
	[Token(Token = "0x60000F3")]
	public static Area GetClientArea() { }

	[Address(RVA = "0x1DEAAC0", Offset = "0x1DE9EC0", Length = "0x87")]
	[Token(Token = "0x60000FB")]
	public static string GetClientAreaLabel() { }

	[Address(RVA = "0x1DEABE0", Offset = "0x1DE9FE0", Length = "0xDE")]
	[Token(Token = "0x60000EF")]
	public static string GetLanguageNameKey(Area tarea) { }

	[Address(RVA = "0x1DEAD20", Offset = "0x1DEA120", Length = "0x19")]
	[Token(Token = "0x60000F6")]
	public static bool IsLeftAlign(Area area) { }

	[Address(RVA = "0x1DEACC0", Offset = "0x1DEA0C0", Length = "0x5F")]
	[Token(Token = "0x60000F7")]
	public static bool IsLeftAlign() { }

	[Address(RVA = "0x1DEAD40", Offset = "0x1DEA140", Length = "0x7")]
	[Token(Token = "0x60000F5")]
	public static bool IsNoBreakSpace(Area area) { }

	[Address(RVA = "0x1DEADB0", Offset = "0x1DEA1B0", Length = "0x19")]
	[Token(Token = "0x60000F8")]
	public static bool IsOutlineSpacing(Area area) { }

	[Address(RVA = "0x1DEAD50", Offset = "0x1DEA150", Length = "0x5F")]
	[Token(Token = "0x60000F9")]
	public static bool IsOutlineSpacing() { }

	[Address(RVA = "0x1DEADD0", Offset = "0x1DEA1D0", Length = "0x40")]
	[Token(Token = "0x60000FD")]
	public static Area LoadLocalClientArea() { }

	[Address(RVA = "0x1DEAE10", Offset = "0x1DEA210", Length = "0x175")]
	[Token(Token = "0x60000FC")]
	public static List<String> MakeAreaLabels() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000FE")]
	public static void SaveLocalClientArea(Area tarea) { }

	[Address(RVA = "0x1DEAF90", Offset = "0x1DEA390", Length = "0xE4")]
	[Token(Token = "0x60000F2")]
	public static void SetAppLangauge(string language) { }

	[Address(RVA = "0x1DEB080", Offset = "0x1DEA480", Length = "0x53")]
	[Token(Token = "0x60000F4")]
	public static void SetClientArea(Area tarea) { }

	[Address(RVA = "0x1DEB0E0", Offset = "0x1DEA4E0", Length = "0xFB")]
	[Token(Token = "0x60000F1")]
	public static void SetDefaultAppLanguage() { }

}

