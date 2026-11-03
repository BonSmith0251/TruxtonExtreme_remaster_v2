namespace System;

[ComVisible(True)]
[Token(Token = "0x200019F")]
public static class Environment
{
	[ComVisible(True)]
	[Token(Token = "0x20001A0")]
	internal enum SpecialFolder : int
	{
		MyDocuments = 5,
		Desktop = 0,
		MyComputer = 17,
		Programs = 2,
		Personal = 5,
		Favorites = 6,
		Startup = 7,
		Recent = 8,
		SendTo = 9,
		StartMenu = 11,
		MyMusic = 13,
		DesktopDirectory = 16,
		Templates = 21,
		ApplicationData = 26,
		LocalApplicationData = 28,
		InternetCache = 32,
		Cookies = 33,
		History = 34,
		CommonApplicationData = 35,
		System = 37,
		ProgramFiles = 38,
		MyPictures = 39,
		CommonProgramFiles = 43,
		MyVideos = 14,
		NetworkShortcuts = 19,
		Fonts = 20,
		CommonStartMenu = 22,
		CommonPrograms = 23,
		CommonStartup = 24,
		CommonDesktopDirectory = 25,
		PrinterShortcuts = 27,
		Windows = 36,
		UserProfile = 40,
		SystemX86 = 41,
		ProgramFilesX86 = 42,
		CommonProgramFilesX86 = 44,
		CommonTemplates = 45,
		CommonDocuments = 46,
		CommonAdminTools = 47,
		AdminTools = 48,
		CommonMusic = 53,
		CommonPictures = 54,
		CommonVideos = 55,
		Resources = 56,
		LocalizedResources = 57,
		CommonOemLinks = 58,
		CDBurning = 59,
	}

	[Token(Token = "0x20001A1")]
	internal enum SpecialFolderOption : int
	{
		None = 0,
		DoNotVerify = 16384,
		Create = 32768,
	}

	[Token(Token = "0x4000682")]
	private const string mono_corlib_version = "1A5E0066-58DC-428A-B21C-0AD6CDAE2789"; //Field offset: 0x0
	[Token(Token = "0x4000683")]
	private static string nl; //Field offset: 0x0
	[Token(Token = "0x4000684")]
	private static OperatingSystem os; //Field offset: 0x8

	[Token(Token = "0x17000149")]
	public static string CurrentDirectory
	{
		[Address(RVA = "0x20810D0", Offset = "0x20804D0", Length = "0x7")]
		[Token(Token = "0x6000F3A")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700014A")]
	public static int CurrentManagedThreadId
	{
		[Address(RVA = "0x20810E0", Offset = "0x20804E0", Length = "0x23")]
		[Token(Token = "0x6000F3B")]
		 get { } //Length: 35
	}

	[Token(Token = "0x1700014B")]
	public static bool HasShutdownStarted
	{
		[Address(RVA = "0x2081110", Offset = "0x2080510", Length = "0x5")]
		[Token(Token = "0x6000F3C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000156")]
	internal static bool IsRunningOnWindows
	{
		[Address(RVA = "0x2081120", Offset = "0x2080520", Length = "0x14")]
		[Token(Token = "0x6000F58")]
		internal get { } //Length: 20
	}

	[Token(Token = "0x17000157")]
	internal static bool IsUnix
	{
		[Address(RVA = "0x2081140", Offset = "0x2080540", Length = "0x27")]
		[Token(Token = "0x6000F5D")]
		internal get { } //Length: 39
	}

	[Token(Token = "0x1700014C")]
	public static string MachineName
	{
		[Address(RVA = "0x2081170", Offset = "0x2080570", Length = "0x5")]
		[Token(Token = "0x6000F3D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700014D")]
	public static string NewLine
	{
		[Address(RVA = "0x2081180", Offset = "0x2080580", Length = "0x76")]
		[Token(Token = "0x6000F3F")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700014F")]
	public static OperatingSystem OSVersion
	{
		[Address(RVA = "0x2081200", Offset = "0x2080600", Length = "0x29E")]
		[Token(Token = "0x6000F42")]
		 get { } //Length: 670
	}

	[Token(Token = "0x1700014E")]
	internal static PlatformID Platform
	{
		[Address(RVA = "0x20814A0", Offset = "0x20808A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000F40")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000155")]
	public static int ProcessorCount
	{
		[Address(RVA = "0x20814B0", Offset = "0x20808B0", Length = "0x5")]
		[Token(Token = "0x6000F57")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000150")]
	public static string StackTrace
	{
		[Address(RVA = "0x20814C0", Offset = "0x20808C0", Length = "0x67")]
		[Token(Token = "0x6000F44")]
		 get { } //Length: 103
	}

	[Token(Token = "0x17000151")]
	public static string SystemDirectory
	{
		[Address(RVA = "0x2081530", Offset = "0x2080930", Length = "0x24A")]
		[Token(Token = "0x6000F45")]
		 get { } //Length: 586
	}

	[Token(Token = "0x17000152")]
	public static int TickCount
	{
		[Address(RVA = "0x2081780", Offset = "0x2080B80", Length = "0x5")]
		[Token(Token = "0x6000F46")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000153")]
	public static string UserDomainName
	{
		[Address(RVA = "0x2081170", Offset = "0x2080570", Length = "0x5")]
		[Token(Token = "0x6000F47")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000154")]
	public static string UserName
	{
		[Address(RVA = "0x2081790", Offset = "0x2080B90", Length = "0x5")]
		[Token(Token = "0x6000F48")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x207FE20", Offset = "0x207F220", Length = "0x1A4")]
	[Token(Token = "0x6000F43")]
	internal static Version CreateVersionFromString(string info) { }

	[Address(RVA = "0x207FFD0", Offset = "0x207F3D0", Length = "0x5")]
	[Token(Token = "0x6000F49")]
	public static void Exit(int exitCode) { }

	[Address(RVA = "0x207FFE0", Offset = "0x207F3E0", Length = "0x3EB")]
	[Token(Token = "0x6000F4A")]
	public static string ExpandEnvironmentVariables(string name) { }

	[Address(RVA = "0x20803E0", Offset = "0x207F7E0", Length = "0x5")]
	[Token(Token = "0x6000F56")]
	internal static void FailFast(string message, Exception exception, string errorSource) { }

	[Address(RVA = "0x20803D0", Offset = "0x207F7D0", Length = "0x8")]
	[Token(Token = "0x6000F55")]
	public static void FailFast(string message, Exception exception) { }

	[Address(RVA = "0x20810D0", Offset = "0x20804D0", Length = "0x7")]
	[Token(Token = "0x6000F3A")]
	public static string get_CurrentDirectory() { }

	[Address(RVA = "0x20810E0", Offset = "0x20804E0", Length = "0x23")]
	[Token(Token = "0x6000F3B")]
	public static int get_CurrentManagedThreadId() { }

	[Address(RVA = "0x2081110", Offset = "0x2080510", Length = "0x5")]
	[Token(Token = "0x6000F3C")]
	public static bool get_HasShutdownStarted() { }

	[Address(RVA = "0x2081120", Offset = "0x2080520", Length = "0x14")]
	[Token(Token = "0x6000F58")]
	internal static bool get_IsRunningOnWindows() { }

	[Address(RVA = "0x2081140", Offset = "0x2080540", Length = "0x27")]
	[Token(Token = "0x6000F5D")]
	internal static bool get_IsUnix() { }

	[Address(RVA = "0x2081170", Offset = "0x2080570", Length = "0x5")]
	[Token(Token = "0x6000F3D")]
	public static string get_MachineName() { }

	[Address(RVA = "0x2081180", Offset = "0x2080580", Length = "0x76")]
	[Token(Token = "0x6000F3F")]
	public static string get_NewLine() { }

	[Address(RVA = "0x2081200", Offset = "0x2080600", Length = "0x29E")]
	[Token(Token = "0x6000F42")]
	public static OperatingSystem get_OSVersion() { }

	[Address(RVA = "0x20814A0", Offset = "0x20808A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000F40")]
	internal static PlatformID get_Platform() { }

	[Address(RVA = "0x20814B0", Offset = "0x20808B0", Length = "0x5")]
	[Token(Token = "0x6000F57")]
	public static int get_ProcessorCount() { }

	[Address(RVA = "0x20814C0", Offset = "0x20808C0", Length = "0x67")]
	[Token(Token = "0x6000F44")]
	public static string get_StackTrace() { }

	[Address(RVA = "0x2081530", Offset = "0x2080930", Length = "0x24A")]
	[Token(Token = "0x6000F45")]
	public static string get_SystemDirectory() { }

	[Address(RVA = "0x2081780", Offset = "0x2080B80", Length = "0x5")]
	[Token(Token = "0x6000F46")]
	public static int get_TickCount() { }

	[Address(RVA = "0x2081170", Offset = "0x2080570", Length = "0x5")]
	[Token(Token = "0x6000F47")]
	public static string get_UserDomainName() { }

	[Address(RVA = "0x2081790", Offset = "0x2080B90", Length = "0x5")]
	[Token(Token = "0x6000F48")]
	public static string get_UserName() { }

	[Address(RVA = "0x20803F0", Offset = "0x207F7F0", Length = "0x5")]
	[Token(Token = "0x6000F4B")]
	public static String[] GetCommandLineArgs() { }

	[Address(RVA = "0x2080410", Offset = "0x207F810", Length = "0x7")]
	[Token(Token = "0x6000F4E")]
	public static string GetEnvironmentVariable(string variable) { }

	[Address(RVA = "0x2080400", Offset = "0x207F800", Length = "0x5")]
	[Token(Token = "0x6000F59")]
	private static String[] GetEnvironmentVariableNames() { }

	[Address(RVA = "0x2080420", Offset = "0x207F820", Length = "0xEB")]
	[Token(Token = "0x6000F4F")]
	private static Hashtable GetEnvironmentVariablesNoCase() { }

	[Address(RVA = "0x2080510", Offset = "0x207F910", Length = "0x35")]
	[Token(Token = "0x6000F50")]
	public static string GetFolderPath(SpecialFolder folder) { }

	[Address(RVA = "0x2080550", Offset = "0x207F950", Length = "0x45")]
	[Token(Token = "0x6000F52")]
	public static string GetFolderPath(SpecialFolder folder, SpecialFolderOption option) { }

	[Address(RVA = "0x20805A0", Offset = "0x207F9A0", Length = "0x5")]
	[Token(Token = "0x6000F5A")]
	internal static string GetMachineConfigPath() { }

	[Address(RVA = "0x20805B0", Offset = "0x207F9B0", Length = "0x5")]
	[Token(Token = "0x6000F3E")]
	private static string GetNewLine() { }

	[Address(RVA = "0x20805C0", Offset = "0x207F9C0", Length = "0x5")]
	[Token(Token = "0x6000F41")]
	internal static string GetOSVersionString() { }

	[Address(RVA = "0x20805D0", Offset = "0x207F9D0", Length = "0x5")]
	[Token(Token = "0x6000F5C")]
	internal static int GetPageSize() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000F37")]
	internal static string GetResourceString(string key) { }

	[Address(RVA = "0x2080730", Offset = "0x207FB30", Length = "0x63")]
	[Token(Token = "0x6000F38")]
	internal static string GetResourceString(string key, Object[] values) { }

	[Address(RVA = "0x20805E0", Offset = "0x207F9E0", Length = "0x149")]
	[Token(Token = "0x6000F39")]
	internal static string GetResourceStringEncodingName(int codePage) { }

	[Address(RVA = "0x20807A0", Offset = "0x207FBA0", Length = "0x8B")]
	[Token(Token = "0x6000F5E")]
	internal static string GetStackTrace(Exception e, bool needFileInfo) { }

	[Address(RVA = "0x2080830", Offset = "0x207FC30", Length = "0x5")]
	[Token(Token = "0x6000F51")]
	private static string GetWindowsFolderPath(int folder) { }

	[Address(RVA = "0x20817A0", Offset = "0x2080BA0", Length = "0x9C")]
	[Token(Token = "0x6000F4D")]
	internal static string internalGetEnvironmentVariable(string variable) { }

	[Address(RVA = "0x2081840", Offset = "0x2080C40", Length = "0x5")]
	[Token(Token = "0x6000F4C")]
	internal static string internalGetEnvironmentVariable_native(IntPtr variable) { }

	[Address(RVA = "0x2081850", Offset = "0x2080C50", Length = "0x5")]
	[Token(Token = "0x6000F5B")]
	internal static string internalGetHome() { }

	[Address(RVA = "0x2080840", Offset = "0x207FC40", Length = "0x32C")]
	[Token(Token = "0x6000F53")]
	private static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback) { }

	[Address(RVA = "0x2080B70", Offset = "0x207FF70", Length = "0x240")]
	[Token(Token = "0x6000F54")]
	internal static string UnixGetFolderPath(SpecialFolder folder, SpecialFolderOption option) { }

}

