//Type is in global namespace

[Token(Token = "0x2000002")]
internal static class Interop
{
	[Token(Token = "0x2000028")]
	public class Advapi32
	{

		[Address(RVA = "0x1E5A980", Offset = "0x1E59D80", Length = "0x78")]
		[Token(Token = "0x600002F")]
		internal static int RegCloseKey(IntPtr hKey) { }

		[Address(RVA = "0x1E5AA00", Offset = "0x1E59E00", Length = "0x18D")]
		[Token(Token = "0x6000030")]
		internal static int RegEnumKeyEx(SafeRegistryHandle hKey, int dwIndex, Char[] lpName, ref int lpcbName, Int32[] lpReserved, out StringBuilder lpClass, Int32[] lpcbClass, Int64[] lpftLastWriteTime) { }

		[Address(RVA = "0x1E5AB90", Offset = "0x1E59F90", Length = "0x166")]
		[Token(Token = "0x6000031")]
		internal static int RegOpenKeyEx(SafeRegistryHandle hKey, string lpSubKey, int ulOptions, int samDesired, out SafeRegistryHandle hkResult) { }

		[Address(RVA = "0x1E5AD00", Offset = "0x1E5A100", Length = "0x21F")]
		[Token(Token = "0x6000032")]
		internal static int RegQueryInfoKey(SafeRegistryHandle hKey, out StringBuilder lpClass, Int32[] lpcbClass, IntPtr lpReserved_MustBeZero, ref int lpcSubKeys, Int32[] lpcbMaxSubKeyLen, Int32[] lpcbMaxClassLen, ref int lpcValues, Int32[] lpcbMaxValueNameLen, Int32[] lpcbMaxValueLen, Int32[] lpcbSecurityDescriptor, Int32[] lpftLastWriteTime) { }

		[Address(RVA = "0x1E5B180", Offset = "0x1E5A580", Length = "0x19C")]
		[Token(Token = "0x6000033")]
		internal static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, Int32[] lpReserved, ref int lpType, out Byte[] lpData, ref int lpcbData) { }

		[Address(RVA = "0x1E5AF20", Offset = "0x1E5A320", Length = "0x121")]
		[Token(Token = "0x6000034")]
		internal static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, Int32[] lpReserved, ref int lpType, ref int lpData, ref int lpcbData) { }

		[Address(RVA = "0x1E5B050", Offset = "0x1E5A450", Length = "0x121")]
		[Token(Token = "0x6000035")]
		internal static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, Int32[] lpReserved, ref int lpType, ref long lpData, ref int lpcbData) { }

		[Address(RVA = "0x1E5B320", Offset = "0x1E5A720", Length = "0x1AD")]
		[Token(Token = "0x6000036")]
		internal static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, Int32[] lpReserved, ref int lpType, out Char[] lpData, ref int lpcbData) { }

	}

	[Token(Token = "0x2000017")]
	public class BCrypt
	{
		[Token(Token = "0x2000018")]
		public enum NTSTATUS : uint
		{
			STATUS_SUCCESS = 0,
			STATUS_NOT_FOUND = 3221226021,
			STATUS_INVALID_PARAMETER = 3221225485,
			STATUS_NO_MEMORY = 3221225495,
		}


		[Address(RVA = "0x1E5B9B0", Offset = "0x1E5ADB0", Length = "0xA2")]
		[Token(Token = "0x6000026")]
		internal static NTSTATUS BCryptGenRandom(IntPtr hAlgorithm, Byte* pbBuffer, int cbBuffer, int dwFlags) { }

	}

	[Token(Token = "0x200001A")]
	public enum BOOL : int
	{
		FALSE = 0,
		TRUE = 1,
	}

	[Token(Token = "0x200001B")]
	public enum BOOLEAN : byte
	{
		FALSE = 0,
		TRUE = 1,
	}

	[Token(Token = "0x2000003")]
	public static class Kernel32
	{
		[Token(Token = "0x2000010")]
		public enum FILE_INFO_BY_HANDLE_CLASS : uint
		{
			FileBasicInfo = 0,
			FileStandardInfo = 1,
			FileNameInfo = 2,
			FileRenameInfo = 3,
			FileDispositionInfo = 4,
			FileAllocationInfo = 5,
			FileEndOfFileInfo = 6,
			FileStreamInfo = 7,
			FileCompressionInfo = 8,
			FileAttributeTagInfo = 9,
			FileIdBothDirectoryInfo = 10,
			FileIdBothDirectoryRestartInfo = 11,
			FileIoPriorityHintInfo = 12,
			FileRemoteProtocolInfo = 13,
			FileFullDirectoryInfo = 14,
			FileFullDirectoryRestartInfo = 15,
		}

		[Token(Token = "0x2000011")]
		public struct FILE_TIME
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000040")]
			internal uint dwLowDateTime; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x4000041")]
			internal uint dwHighDateTime; //Field offset: 0x4

		}

		[Token(Token = "0x2000012")]
		public enum FINDEX_INFO_LEVELS : uint
		{
			FindExInfoStandard = 0,
			FindExInfoBasic = 1,
			FindExInfoMaxInfoLevel = 2,
		}

		[Token(Token = "0x2000013")]
		public enum FINDEX_SEARCH_OPS : uint
		{
			FindExSearchNameMatch = 0,
			FindExSearchLimitToDirectories = 1,
			FindExSearchLimitToDevices = 2,
			FindExSearchMaxSearchOp = 3,
		}

		[Token(Token = "0x2000014")]
		public enum GET_FILEEX_INFO_LEVELS : uint
		{
			GetFileExInfoStandard = 0,
			GetFileExMaxInfoLevel = 1,
		}

		[Token(Token = "0x2000007")]
		public struct REG_TZI_FORMAT
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400000D")]
			internal int Bias; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x400000E")]
			internal int StandardBias; //Field offset: 0x4
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x400000F")]
			internal int DaylightBias; //Field offset: 0x8
			[FieldOffset(Offset = "0xC")]
			[Token(Token = "0x4000010")]
			internal SYSTEMTIME StandardDate; //Field offset: 0xC
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x4000011")]
			internal SYSTEMTIME DaylightDate; //Field offset: 0x1C

			[Address(RVA = "0x1E63FE0", Offset = "0x1E633E0", Length = "0x27")]
			[Token(Token = "0x600001F")]
			internal REG_TZI_FORMAT(in TIME_ZONE_INFORMATION tzi) { }

		}

		[Token(Token = "0x2000015")]
		public struct SECURITY_ATTRIBUTES
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400004E")]
			internal uint nLength; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x400004F")]
			internal IntPtr lpSecurityDescriptor; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000050")]
			internal BOOL bInheritHandle; //Field offset: 0x10

		}

		[Token(Token = "0x2000008")]
		public struct SYSTEMTIME
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000012")]
			internal ushort Year; //Field offset: 0x0
			[FieldOffset(Offset = "0x2")]
			[Token(Token = "0x4000013")]
			internal ushort Month; //Field offset: 0x2
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x4000014")]
			internal ushort DayOfWeek; //Field offset: 0x4
			[FieldOffset(Offset = "0x6")]
			[Token(Token = "0x4000015")]
			internal ushort Day; //Field offset: 0x6
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000016")]
			internal ushort Hour; //Field offset: 0x8
			[FieldOffset(Offset = "0xA")]
			[Token(Token = "0x4000017")]
			internal ushort Minute; //Field offset: 0xA
			[FieldOffset(Offset = "0xC")]
			[Token(Token = "0x4000018")]
			internal ushort Second; //Field offset: 0xC
			[FieldOffset(Offset = "0xE")]
			[Token(Token = "0x4000019")]
			internal ushort Milliseconds; //Field offset: 0xE

			[Address(RVA = "0x1E64B60", Offset = "0x1E63F60", Length = "0x53")]
			[Token(Token = "0x6000020")]
			internal bool Equals(in SYSTEMTIME other) { }

		}

		[Token(Token = "0x2000009")]
		public struct TIME_DYNAMIC_ZONE_INFORMATION
		{
			[CompilerGenerated]
			[Token(Token = "0x200000B")]
			[UnsafeValueType]
			internal struct <DaylightName>e__FixedBuffer
			{
				[FieldOffset(Offset = "0x0")]
				[Token(Token = "0x4000024")]
				public char FixedElementField; //Field offset: 0x0

			}

			[CompilerGenerated]
			[Token(Token = "0x200000A")]
			[UnsafeValueType]
			internal struct <StandardName>e__FixedBuffer
			{
				[FieldOffset(Offset = "0x0")]
				[Token(Token = "0x4000023")]
				public char FixedElementField; //Field offset: 0x0

			}

			[CompilerGenerated]
			[Token(Token = "0x200000C")]
			[UnsafeValueType]
			internal struct <TimeZoneKeyName>e__FixedBuffer
			{
				[FieldOffset(Offset = "0x0")]
				[Token(Token = "0x4000025")]
				public char FixedElementField; //Field offset: 0x0

			}

			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400001A")]
			internal int Bias; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[FixedBuffer(typeof(char), 32)]
			[Token(Token = "0x400001B")]
			internal <StandardName>e__FixedBuffer StandardName; //Field offset: 0x4
			[FieldOffset(Offset = "0x44")]
			[Token(Token = "0x400001C")]
			internal SYSTEMTIME StandardDate; //Field offset: 0x44
			[FieldOffset(Offset = "0x54")]
			[Token(Token = "0x400001D")]
			internal int StandardBias; //Field offset: 0x54
			[FieldOffset(Offset = "0x58")]
			[FixedBuffer(typeof(char), 32)]
			[Token(Token = "0x400001E")]
			internal <DaylightName>e__FixedBuffer DaylightName; //Field offset: 0x58
			[FieldOffset(Offset = "0x98")]
			[Token(Token = "0x400001F")]
			internal SYSTEMTIME DaylightDate; //Field offset: 0x98
			[FieldOffset(Offset = "0xA8")]
			[Token(Token = "0x4000020")]
			internal int DaylightBias; //Field offset: 0xA8
			[FieldOffset(Offset = "0xAC")]
			[FixedBuffer(typeof(char), 128)]
			[Token(Token = "0x4000021")]
			internal <TimeZoneKeyName>e__FixedBuffer TimeZoneKeyName; //Field offset: 0xAC
			[FieldOffset(Offset = "0x1AC")]
			[Token(Token = "0x4000022")]
			internal byte DynamicDaylightTimeDisabled; //Field offset: 0x1AC

			[Address(RVA = "0x1E6E790", Offset = "0x1E6DB90", Length = "0x11")]
			[Token(Token = "0x6000021")]
			internal string GetTimeZoneKeyName() { }

		}

		[Token(Token = "0x200000D")]
		public struct TIME_ZONE_INFORMATION
		{
			[CompilerGenerated]
			[Token(Token = "0x200000F")]
			[UnsafeValueType]
			internal struct <DaylightName>e__FixedBuffer
			{
				[FieldOffset(Offset = "0x0")]
				[Token(Token = "0x400002E")]
				public char FixedElementField; //Field offset: 0x0

			}

			[CompilerGenerated]
			[Token(Token = "0x200000E")]
			[UnsafeValueType]
			internal struct <StandardName>e__FixedBuffer
			{
				[FieldOffset(Offset = "0x0")]
				[Token(Token = "0x400002D")]
				public char FixedElementField; //Field offset: 0x0

			}

			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000026")]
			internal int Bias; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[FixedBuffer(typeof(char), 32)]
			[Token(Token = "0x4000027")]
			internal <StandardName>e__FixedBuffer StandardName; //Field offset: 0x4
			[FieldOffset(Offset = "0x44")]
			[Token(Token = "0x4000028")]
			internal SYSTEMTIME StandardDate; //Field offset: 0x44
			[FieldOffset(Offset = "0x54")]
			[Token(Token = "0x4000029")]
			internal int StandardBias; //Field offset: 0x54
			[FieldOffset(Offset = "0x58")]
			[FixedBuffer(typeof(char), 32)]
			[Token(Token = "0x400002A")]
			internal <DaylightName>e__FixedBuffer DaylightName; //Field offset: 0x58
			[FieldOffset(Offset = "0x98")]
			[Token(Token = "0x400002B")]
			internal SYSTEMTIME DaylightDate; //Field offset: 0x98
			[FieldOffset(Offset = "0xA8")]
			[Token(Token = "0x400002C")]
			internal int DaylightBias; //Field offset: 0xA8

			[Address(RVA = "0x1E6E7D0", Offset = "0x1E6DBD0", Length = "0x118")]
			[Token(Token = "0x6000022")]
			internal TIME_ZONE_INFORMATION(in TIME_DYNAMIC_ZONE_INFORMATION dtzi) { }

			[Address(RVA = "0x1E6E7B0", Offset = "0x1E6DBB0", Length = "0xE")]
			[Token(Token = "0x6000024")]
			internal string GetDaylightName() { }

			[Address(RVA = "0x1E6E7C0", Offset = "0x1E6DBC0", Length = "0xE")]
			[Token(Token = "0x6000023")]
			internal string GetStandardName() { }

		}

		[Token(Token = "0x2000016")]
		public struct WIN32_FILE_ATTRIBUTE_DATA
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000051")]
			internal int dwFileAttributes; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x4000052")]
			internal FILE_TIME ftCreationTime; //Field offset: 0x4
			[FieldOffset(Offset = "0xC")]
			[Token(Token = "0x4000053")]
			internal FILE_TIME ftLastAccessTime; //Field offset: 0xC
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x4000054")]
			internal FILE_TIME ftLastWriteTime; //Field offset: 0x14
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x4000055")]
			internal uint nFileSizeHigh; //Field offset: 0x1C
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000056")]
			internal uint nFileSizeLow; //Field offset: 0x20

			[Address(RVA = "0x1E6EAE0", Offset = "0x1E6DEE0", Length = "0x29")]
			[Token(Token = "0x6000025")]
			internal void PopulateFrom(ref WIN32_FIND_DATA findData) { }

		}

		[Token(Token = "0x2000004")]
		public struct WIN32_FIND_DATA
		{
			[CompilerGenerated]
			[Token(Token = "0x2000006")]
			[UnsafeValueType]
			internal struct <_cAlternateFileName>e__FixedBuffer
			{
				[FieldOffset(Offset = "0x0")]
				[Token(Token = "0x400000C")]
				public char FixedElementField; //Field offset: 0x0

			}

			[CompilerGenerated]
			[Token(Token = "0x2000005")]
			[UnsafeValueType]
			internal struct <_cFileName>e__FixedBuffer
			{
				[FieldOffset(Offset = "0x0")]
				[Token(Token = "0x400000B")]
				public char FixedElementField; //Field offset: 0x0

			}

			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000001")]
			internal uint dwFileAttributes; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x4000002")]
			internal FILE_TIME ftCreationTime; //Field offset: 0x4
			[FieldOffset(Offset = "0xC")]
			[Token(Token = "0x4000003")]
			internal FILE_TIME ftLastAccessTime; //Field offset: 0xC
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x4000004")]
			internal FILE_TIME ftLastWriteTime; //Field offset: 0x14
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x4000005")]
			internal uint nFileSizeHigh; //Field offset: 0x1C
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000006")]
			internal uint nFileSizeLow; //Field offset: 0x20
			[FieldOffset(Offset = "0x24")]
			[Token(Token = "0x4000007")]
			internal uint dwReserved0; //Field offset: 0x24
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4000008")]
			internal uint dwReserved1; //Field offset: 0x28
			[FieldOffset(Offset = "0x2C")]
			[FixedBuffer(typeof(char), 260)]
			[Token(Token = "0x4000009")]
			private <_cFileName>e__FixedBuffer _cFileName; //Field offset: 0x2C
			[FieldOffset(Offset = "0x234")]
			[FixedBuffer(typeof(char), 14)]
			[Token(Token = "0x400000A")]
			private <_cAlternateFileName>e__FixedBuffer _cAlternateFileName; //Field offset: 0x234

			[Token(Token = "0x17000001")]
			internal ReadOnlySpan<Char> cFileName
			{
				[Address(RVA = "0x1E6EBD0", Offset = "0x1E6DFD0", Length = "0x221")]
				[Token(Token = "0x600001D")]
				internal get { } //Length: 545
			}

			[Address(RVA = "0x1E6EBD0", Offset = "0x1E6DFD0", Length = "0x221")]
			[Token(Token = "0x600001D")]
			internal ReadOnlySpan<Char> get_cFileName() { }

			[Address(RVA = "0x1E6EB10", Offset = "0x1E6DF10", Length = "0xB1")]
			[Token(Token = "0x600001E")]
			internal void SetFileName(string fileName) { }

		}


		[Address(RVA = "0x1E5CAE0", Offset = "0x1E5BEE0", Length = "0x84")]
		[Token(Token = "0x6000009")]
		internal static bool CloseHandle(IntPtr handle) { }

		[Address(RVA = "0x1E5CC10", Offset = "0x1E5C010", Length = "0xE1")]
		[Token(Token = "0x600000B")]
		internal static bool CreateDirectory(string path, ref SECURITY_ATTRIBUTES lpSecurityAttributes) { }

		[Address(RVA = "0x1E5CB70", Offset = "0x1E5BF70", Length = "0x9F")]
		[Token(Token = "0x600000A")]
		private static bool CreateDirectoryPrivate(string path, ref SECURITY_ATTRIBUTES lpSecurityAttributes) { }

		[Address(RVA = "0x1E5CDE0", Offset = "0x1E5C1E0", Length = "0x116")]
		[Token(Token = "0x600000D")]
		internal static IntPtr CreateFile_IntPtr(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes) { }

		[Address(RVA = "0x1E5CD00", Offset = "0x1E5C100", Length = "0xE0")]
		[Token(Token = "0x600000C")]
		private static IntPtr CreateFilePrivate(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, SECURITY_ATTRIBUTES* securityAttrs, FileMode dwCreationDisposition, int dwFlagsAndAttributes, IntPtr hTemplateFile) { }

		[Address(RVA = "0x1E5CFA0", Offset = "0x1E5C3A0", Length = "0xD1")]
		[Token(Token = "0x600000F")]
		internal static bool DeleteFile(string path) { }

		[Address(RVA = "0x1E5CF00", Offset = "0x1E5C300", Length = "0x93")]
		[Token(Token = "0x600000E")]
		private static bool DeleteFilePrivate(string path) { }

		[Address(RVA = "0x1E5D120", Offset = "0x1E5C520", Length = "0x10F")]
		[Token(Token = "0x6000003")]
		internal static bool DeleteVolumeMountPoint(string mountPoint) { }

		[Address(RVA = "0x1E5D080", Offset = "0x1E5C480", Length = "0x93")]
		[Token(Token = "0x6000002")]
		internal static bool DeleteVolumeMountPointPrivate(string mountPoint) { }

		[Address(RVA = "0x1E5D350", Offset = "0x1E5C750", Length = "0x12A")]
		[Token(Token = "0x6000011")]
		internal static SafeFindHandle FindFirstFile(string fileName, ref WIN32_FIND_DATA data) { }

		[Address(RVA = "0x1E5D230", Offset = "0x1E5C630", Length = "0x115")]
		[Token(Token = "0x6000010")]
		private static SafeFindHandle FindFirstFileExPrivate(string lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, ref WIN32_FIND_DATA lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, IntPtr lpSearchFilter, int dwAdditionalFlags) { }

		[Address(RVA = "0x1E5D480", Offset = "0x1E5C880", Length = "0xDA")]
		[Token(Token = "0x6000012")]
		internal static bool FindNextFile(SafeFindHandle hndFindFile, ref WIN32_FIND_DATA lpFindFileData) { }

		[Address(RVA = "0x1E5D560", Offset = "0x1E5C960", Length = "0xE2")]
		[Token(Token = "0x6000013")]
		private static int FormatMessage(int dwFlags, IntPtr lpSource, uint dwMessageId, int dwLanguageId, Char* lpBuffer, int nSize, IntPtr[] arguments) { }

		[Address(RVA = "0x1E5D650", Offset = "0x1E5CA50", Length = "0x84")]
		[Token(Token = "0x6000004")]
		internal static bool FreeLibrary(IntPtr hModule) { }

		[Address(RVA = "0x1E5D6E0", Offset = "0x1E5CAE0", Length = "0x81")]
		[Token(Token = "0x6000007")]
		internal static uint GetDynamicTimeZoneInformation(out TIME_DYNAMIC_ZONE_INFORMATION pTimeZoneInformation) { }

		[Address(RVA = "0x1E5D820", Offset = "0x1E5CC20", Length = "0xEF")]
		[Token(Token = "0x6000018")]
		internal static bool GetFileAttributesEx(string name, GET_FILEEX_INFO_LEVELS fileInfoLevel, ref WIN32_FILE_ATTRIBUTE_DATA lpFileInformation) { }

		[Address(RVA = "0x1E5D770", Offset = "0x1E5CB70", Length = "0xAC")]
		[Token(Token = "0x6000017")]
		private static bool GetFileAttributesExPrivate(string name, GET_FILEEX_INFO_LEVELS fileInfoLevel, ref WIN32_FILE_ATTRIBUTE_DATA lpFileInformation) { }

		[Address(RVA = "0x1E5D910", Offset = "0x1E5CD10", Length = "0xAC")]
		[Token(Token = "0x6000019")]
		public static bool GetFileInformationByHandleEx(IntPtr hFile, FILE_INFO_BY_HANDLE_CLASS FileInformationClass, IntPtr lpFileInformation, uint dwBufferSize) { }

		[Address(RVA = "0x1E5D9C0", Offset = "0x1E5CDC0", Length = "0x132")]
		[Token(Token = "0x6000006")]
		internal static bool GetFileMUIPath(uint flags, string filePath, out StringBuilder language, ref int languageLength, out StringBuilder fileMuiPath, ref int fileMuiPathLength, ref long enumerator) { }

		[Address(RVA = "0x1E5DC60", Offset = "0x1E5D060", Length = "0xC")]
		[Token(Token = "0x6000014")]
		internal static string GetMessage(int errorCode) { }

		[Address(RVA = "0x1E5DB00", Offset = "0x1E5CF00", Length = "0x160")]
		[Token(Token = "0x6000015")]
		internal static string GetMessage(IntPtr moduleHandle, int errorCode) { }

		[Address(RVA = "0x1E5DC70", Offset = "0x1E5D070", Length = "0x81")]
		[Token(Token = "0x6000008")]
		internal static uint GetTimeZoneInformation(out TIME_ZONE_INFORMATION lpTimeZoneInformation) { }

		[Address(RVA = "0x1E5DD00", Offset = "0x1E5D100", Length = "0xEB")]
		[Token(Token = "0x6000005")]
		internal static SafeLibraryHandle LoadLibraryEx(string libFilename, IntPtr reserved, int flags) { }

		[Address(RVA = "0x1E5DE90", Offset = "0x1E5D290", Length = "0xD1")]
		[Token(Token = "0x600001B")]
		internal static bool RemoveDirectory(string path) { }

		[Address(RVA = "0x1E5DDF0", Offset = "0x1E5D1F0", Length = "0x93")]
		[Token(Token = "0x600001A")]
		private static bool RemoveDirectoryPrivate(string path) { }

		[Address(RVA = "0x1E5DF70", Offset = "0x1E5D370", Length = "0x91")]
		[Token(Token = "0x600001C")]
		internal static bool SetThreadErrorMode(uint dwNewMode, out uint lpOldMode) { }

		[Address(RVA = "0x1E5E010", Offset = "0x1E5D410", Length = "0x292")]
		[Token(Token = "0x6000016")]
		private static bool TryGetErrorMessage(IntPtr moduleHandle, int errorCode, Span<Char> buffer, out string errorMsg) { }

	}

	[Token(Token = "0x200001C")]
	public struct LongFileTime
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000062")]
		internal long TicksSince1601; //Field offset: 0x0

	}

	[Token(Token = "0x200001E")]
	public class NtDll
	{
		[Token(Token = "0x2000025")]
		internal enum CreateDisposition : uint
		{
			FILE_SUPERSEDE = 0,
			FILE_OPEN = 1,
			FILE_CREATE = 2,
			FILE_OPEN_IF = 3,
			FILE_OVERWRITE = 4,
			FILE_OVERWRITE_IF = 5,
		}

		[Token(Token = "0x2000026")]
		internal enum CreateOptions : uint
		{
			FILE_DIRECTORY_FILE = 1,
			FILE_WRITE_THROUGH = 2,
			FILE_SEQUENTIAL_ONLY = 4,
			FILE_NO_INTERMEDIATE_BUFFERING = 8,
			FILE_SYNCHRONOUS_IO_ALERT = 16,
			FILE_SYNCHRONOUS_IO_NONALERT = 32,
			FILE_NON_DIRECTORY_FILE = 64,
			FILE_CREATE_TREE_CONNECTION = 128,
			FILE_COMPLETE_IF_OPLOCKED = 256,
			FILE_NO_EA_KNOWLEDGE = 512,
			FILE_RANDOM_ACCESS = 2048,
			FILE_DELETE_ON_CLOSE = 4096,
			FILE_OPEN_BY_FILE_ID = 8192,
			FILE_OPEN_FOR_BACKUP_INTENT = 16384,
			FILE_NO_COMPRESSION = 32768,
			FILE_OPEN_REQUIRING_OPLOCK = 65536,
			FILE_DISALLOW_EXCLUSIVE = 131072,
			FILE_SESSION_AWARE = 262144,
			FILE_RESERVE_OPFILTER = 1048576,
			FILE_OPEN_REPARSE_POINT = 2097152,
			FILE_OPEN_NO_RECALL = 4194304,
		}

		[Flags]
		[Token(Token = "0x2000027")]
		internal enum DesiredAccess : uint
		{
			FILE_READ_DATA = 1,
			FILE_LIST_DIRECTORY = 1,
			FILE_WRITE_DATA = 2,
			FILE_ADD_FILE = 2,
			FILE_APPEND_DATA = 4,
			FILE_ADD_SUBDIRECTORY = 4,
			FILE_CREATE_PIPE_INSTANCE = 4,
			FILE_READ_EA = 8,
			FILE_WRITE_EA = 16,
			FILE_EXECUTE = 32,
			FILE_TRAVERSE = 32,
			FILE_DELETE_CHILD = 64,
			FILE_READ_ATTRIBUTES = 128,
			FILE_WRITE_ATTRIBUTES = 256,
			FILE_ALL_ACCESS = 983551,
			DELETE = 65536,
			READ_CONTROL = 131072,
			WRITE_DAC = 262144,
			WRITE_OWNER = 524288,
			SYNCHRONIZE = 1048576,
			STANDARD_RIGHTS_READ = 131072,
			STANDARD_RIGHTS_WRITE = 131072,
			STANDARD_RIGHTS_EXECUTE = 131072,
			FILE_GENERIC_READ = 2147483648,
			FILE_GENERIC_WRITE = 1073741824,
			FILE_GENERIC_EXECUTE = 536870912,
		}

		[Token(Token = "0x200001F")]
		internal struct FILE_FULL_DIR_INFORMATION
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000066")]
			public uint NextEntryOffset; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x4000067")]
			public uint FileIndex; //Field offset: 0x4
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000068")]
			public LongFileTime CreationTime; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000069")]
			public LongFileTime LastAccessTime; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400006A")]
			public LongFileTime LastWriteTime; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400006B")]
			public LongFileTime ChangeTime; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x400006C")]
			public long EndOfFile; //Field offset: 0x28
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x400006D")]
			public long AllocationSize; //Field offset: 0x30
			[FieldOffset(Offset = "0x38")]
			[Token(Token = "0x400006E")]
			public FileAttributes FileAttributes; //Field offset: 0x38
			[FieldOffset(Offset = "0x3C")]
			[Token(Token = "0x400006F")]
			public uint FileNameLength; //Field offset: 0x3C
			[FieldOffset(Offset = "0x40")]
			[Token(Token = "0x4000070")]
			public uint EaSize; //Field offset: 0x40
			[FieldOffset(Offset = "0x44")]
			[Token(Token = "0x4000071")]
			private char _fileName; //Field offset: 0x44

			[Token(Token = "0x17000002")]
			public ReadOnlySpan<Char> FileName
			{
				[Address(RVA = "0x1E5C960", Offset = "0x1E5BD60", Length = "0x67")]
				[Token(Token = "0x600002C")]
				 get { } //Length: 103
			}

			[Address(RVA = "0x1E5C960", Offset = "0x1E5BD60", Length = "0x67")]
			[Token(Token = "0x600002C")]
			public ReadOnlySpan<Char> get_FileName() { }

			[Address(RVA = "0x1E5C940", Offset = "0x1E5BD40", Length = "0x12")]
			[Token(Token = "0x600002D")]
			public static FILE_FULL_DIR_INFORMATION* GetNextInfo(FILE_FULL_DIR_INFORMATION* info) { }

		}

		[Token(Token = "0x2000020")]
		internal enum FILE_INFORMATION_CLASS : uint
		{
			FileDirectoryInformation = 1,
			FileFullDirectoryInformation = 2,
			FileBothDirectoryInformation = 3,
			FileBasicInformation = 4,
			FileStandardInformation = 5,
			FileInternalInformation = 6,
			FileEaInformation = 7,
			FileAccessInformation = 8,
			FileNameInformation = 9,
			FileRenameInformation = 10,
			FileLinkInformation = 11,
			FileNamesInformation = 12,
			FileDispositionInformation = 13,
			FilePositionInformation = 14,
			FileFullEaInformation = 15,
			FileModeInformation = 16,
			FileAlignmentInformation = 17,
			FileAllInformation = 18,
			FileAllocationInformation = 19,
			FileEndOfFileInformation = 20,
			FileAlternateNameInformation = 21,
			FileStreamInformation = 22,
			FilePipeInformation = 23,
			FilePipeLocalInformation = 24,
			FilePipeRemoteInformation = 25,
			FileMailslotQueryInformation = 26,
			FileMailslotSetInformation = 27,
			FileCompressionInformation = 28,
			FileObjectIdInformation = 29,
			FileCompletionInformation = 30,
			FileMoveClusterInformation = 31,
			FileQuotaInformation = 32,
			FileReparsePointInformation = 33,
			FileNetworkOpenInformation = 34,
			FileAttributeTagInformation = 35,
			FileTrackingInformation = 36,
			FileIdBothDirectoryInformation = 37,
			FileIdFullDirectoryInformation = 38,
			FileValidDataLengthInformation = 39,
			FileShortNameInformation = 40,
			FileIoCompletionNotificationInformation = 41,
			FileIoStatusBlockRangeInformation = 42,
			FileIoPriorityHintInformation = 43,
			FileSfioReserveInformation = 44,
			FileSfioVolumeInformation = 45,
			FileHardLinkInformation = 46,
			FileProcessIdsUsingFileInformation = 47,
			FileNormalizedNameInformation = 48,
			FileNetworkPhysicalNameInformation = 49,
			FileIdGlobalTxDirectoryInformation = 50,
			FileIsRemoteDeviceInformation = 51,
			FileUnusedInformation = 52,
			FileNumaNodeInformation = 53,
			FileStandardLinkInformation = 54,
			FileRemoteProtocolInformation = 55,
			FileRenameInformationBypassAccessCheck = 56,
			FileLinkInformationBypassAccessCheck = 57,
			FileVolumeNameInformation = 58,
			FileIdInformation = 59,
			FileIdExtdDirectoryInformation = 60,
			FileReplaceCompletionInformation = 61,
			FileHardLinkFullIdInformation = 62,
			FileIdExtdBothDirectoryInformation = 63,
			FileDispositionInformationEx = 64,
			FileRenameInformationEx = 65,
			FileRenameInformationExBypassAccessCheck = 66,
			FileDesiredStorageClassInformation = 67,
			FileStatInformation = 68,
		}

		[Token(Token = "0x2000021")]
		internal struct IO_STATUS_BLOCK
		{
			[Token(Token = "0x2000022")]
			internal struct IO_STATUS
			{
				[FieldOffset(Offset = "0x0")]
				[Token(Token = "0x40000B9")]
				public uint Status; //Field offset: 0x0
				[FieldOffset(Offset = "0x0")]
				[Token(Token = "0x40000BA")]
				public IntPtr Pointer; //Field offset: 0x0

			}

			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40000B7")]
			public IO_STATUS Status; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x40000B8")]
			public IntPtr Information; //Field offset: 0x8

		}

		[Token(Token = "0x2000023")]
		internal struct OBJECT_ATTRIBUTES
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40000BB")]
			public uint Length; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x40000BC")]
			public IntPtr RootDirectory; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40000BD")]
			public UNICODE_STRING* ObjectName; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40000BE")]
			public ObjectAttributes Attributes; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x40000BF")]
			public Void* SecurityDescriptor; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x40000C0")]
			public Void* SecurityQualityOfService; //Field offset: 0x28

			[Address(RVA = "0x1E63FB0", Offset = "0x1E633B0", Length = "0x1D")]
			[Token(Token = "0x600002E")]
			public OBJECT_ATTRIBUTES(UNICODE_STRING* objectName, ObjectAttributes attributes, IntPtr rootDirectory) { }

		}

		[Flags]
		[Token(Token = "0x2000024")]
		internal enum ObjectAttributes : uint
		{
			OBJ_INHERIT = 2,
			OBJ_PERMANENT = 16,
			OBJ_EXCLUSIVE = 32,
			OBJ_CASE_INSENSITIVE = 64,
			OBJ_OPENIF = 128,
			OBJ_OPENLINK = 256,
		}


		[Address(RVA = "0x1E63AA0", Offset = "0x1E62EA0", Length = "0x28B")]
		[Token(Token = "0x6000029")]
		internal static ValueTuple<Int32, IntPtr> CreateFile(ReadOnlySpan<Char> path, IntPtr rootDirectory, CreateDisposition createDisposition, DesiredAccess desiredAccess = 2148532224, FileShare shareAccess = 7, FileAttributes fileAttributes = 0, CreateOptions createOptions = 32, ObjectAttributes objectAttributes = 64) { }

		[Address(RVA = "0x1E63D30", Offset = "0x1E63130", Length = "0xF8")]
		[Token(Token = "0x6000028")]
		private static int NtCreateFile(out IntPtr FileHandle, DesiredAccess DesiredAccess, ref OBJECT_ATTRIBUTES ObjectAttributes, out IO_STATUS_BLOCK IoStatusBlock, Int64* AllocationSize, FileAttributes FileAttributes, FileShare ShareAccess, CreateDisposition CreateDisposition, CreateOptions CreateOptions, Void* EaBuffer, uint EaLength) { }

		[Address(RVA = "0x1E63E30", Offset = "0x1E63230", Length = "0xFE")]
		[Token(Token = "0x600002A")]
		public static int NtQueryDirectoryFile(IntPtr FileHandle, IntPtr Event, IntPtr ApcRoutine, IntPtr ApcContext, out IO_STATUS_BLOCK IoStatusBlock, IntPtr FileInformation, uint Length, FILE_INFORMATION_CLASS FileInformationClass, BOOLEAN ReturnSingleEntry, UNICODE_STRING* FileName, BOOLEAN RestartScan) { }

		[Address(RVA = "0x1E63F30", Offset = "0x1E63330", Length = "0x76")]
		[Token(Token = "0x600002B")]
		public static uint RtlNtStatusToDosError(int Status) { }

	}

	[Token(Token = "0x200001D")]
	public struct UNICODE_STRING
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000063")]
		internal ushort Length; //Field offset: 0x0
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x4000064")]
		internal ushort MaximumLength; //Field offset: 0x2
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000065")]
		internal IntPtr Buffer; //Field offset: 0x8

	}

	[Token(Token = "0x2000019")]
	public class User32
	{

		[Address(RVA = "0x1E6E9B0", Offset = "0x1E6DDB0", Length = "0x12E")]
		[Token(Token = "0x6000027")]
		internal static int LoadString(SafeLibraryHandle handle, int id, out StringBuilder buffer, int bufferLength) { }

	}


	[Address(RVA = "0x1E5C9D0", Offset = "0x1E5BDD0", Length = "0x10C")]
	[Token(Token = "0x6000001")]
	internal static void GetRandomBytes(Byte* buffer, int length) { }

}

