namespace System.IO;

[Token(Token = "0x2000635")]
internal static class FileSystem
{
	[Token(Token = "0x2000636")]
	private class UnitySafeFindHandle : SafeFindHandle
	{
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40018CB")]
		private readonly IntPtr m_Handle; //Field offset: 0x20

		[Token(Token = "0x17000742")]
		public IntPtr Handle
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x6002E24")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000743")]
		public virtual bool IsInvalid
		{
			[Address(RVA = "0x17D6B30", Offset = "0x17D5F30", Length = "0x9")]
			[Token(Token = "0x6002E25")]
			 get { } //Length: 9
		}

		[Address(RVA = "0x1FEA620", Offset = "0x1FE9A20", Length = "0x26")]
		[Token(Token = "0x6002E23")]
		public UnitySafeFindHandle(IntPtr handle) { }

		[Address(RVA = "0x1FEA600", Offset = "0x1FE9A00", Length = "0x15")]
		[Token(Token = "0x6002E26")]
		protected virtual void Dispose(bool disposing) { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6002E24")]
		public IntPtr get_Handle() { }

		[Address(RVA = "0x17D6B30", Offset = "0x17D5F30", Length = "0x9")]
		[Token(Token = "0x6002E25")]
		public virtual bool get_IsInvalid() { }

	}


	[Address(RVA = "0x1FD5E20", Offset = "0x1FD5220", Length = "0x5")]
	[Token(Token = "0x6002E1A")]
	private static bool BrokeredCreateDirectory(string path) { }

	[Address(RVA = "0x1FD5E20", Offset = "0x1FD5220", Length = "0x5")]
	[Token(Token = "0x6002E1E")]
	private static bool BrokeredDeleteFile(string path) { }

	[Address(RVA = "0x1FD5E30", Offset = "0x1FD5230", Length = "0x5")]
	[Token(Token = "0x6002E1F")]
	private static IntPtr BrokeredFindFirstFile(string searchPath, ref string resultFilePath, ref uint attributes) { }

	[Address(RVA = "0x1FD5E40", Offset = "0x1FD5240", Length = "0x5")]
	[Token(Token = "0x6002E20")]
	private static bool BrokeredFindNextFile(IntPtr handle, ref string resultFilePath, ref uint attributes) { }

	[Address(RVA = "0x1FD5E50", Offset = "0x1FD5250", Length = "0x5")]
	[Token(Token = "0x6002E1C")]
	private static bool BrokeredGetFileAttributes(string path, ref WIN32_FILE_ATTRIBUTE_DATA data) { }

	[Address(RVA = "0x1FD5E60", Offset = "0x1FD5260", Length = "0x5")]
	[Token(Token = "0x6002E1D")]
	private static IntPtr BrokeredOpenFile(string lpFileName, int dwDesiredAccess, int dwShareMode, int dwCreationDisposition, int dwFlagsAndAttributes) { }

	[Address(RVA = "0x1FD5E20", Offset = "0x1FD5220", Length = "0x5")]
	[Token(Token = "0x6002E1B")]
	private static bool BrokeredRemoveDirectory(string path) { }

	[Address(RVA = "0x1FD5E70", Offset = "0x1FD5270", Length = "0x5")]
	[Token(Token = "0x6002E21")]
	private static int BrokeredSafeFindHandleDispose(IntPtr handle) { }

	[Address(RVA = "0x1FD5E80", Offset = "0x1FD5280", Length = "0x59A")]
	[Token(Token = "0x6002E07")]
	public static void CreateDirectory(string fullPath) { }

	[Address(RVA = "0x1FD6420", Offset = "0x1FD5820", Length = "0x81")]
	[Token(Token = "0x6002E08")]
	public static void DeleteFile(string fullPath) { }

	[Address(RVA = "0x1FD6500", Offset = "0x1FD5900", Length = "0x4E")]
	[Token(Token = "0x6002E0A")]
	private static bool DirectoryExists(string path, out int lastError) { }

	[Address(RVA = "0x1FD64B0", Offset = "0x1FD58B0", Length = "0x45")]
	[Token(Token = "0x6002E09")]
	public static bool DirectoryExists(string fullPath) { }

	[Address(RVA = "0x1FD6550", Offset = "0x1FD5950", Length = "0x47")]
	[Token(Token = "0x6002E0C")]
	public static bool FileExists(string fullPath) { }

	[Address(RVA = "0x1FD65A0", Offset = "0x1FD59A0", Length = "0x45A")]
	[Token(Token = "0x6002E0B")]
	internal static int FillAttributeInfo(string path, ref WIN32_FILE_ATTRIBUTE_DATA data, bool returnErrorOnNotFound) { }

	[Address(RVA = "0x1FD6A00", Offset = "0x1FD5E00", Length = "0x61")]
	[Token(Token = "0x6002E0D")]
	public static FileAttributes GetAttributes(string fullPath) { }

	[Address(RVA = "0x1FD6A70", Offset = "0x1FD5E70", Length = "0x14A")]
	[Token(Token = "0x6002E0F")]
	private static void GetFindData(string fullPath, ref WIN32_FIND_DATA findData) { }

	[Address(RVA = "0x1FD6BC0", Offset = "0x1FD5FC0", Length = "0x16")]
	[Token(Token = "0x6002E10")]
	private static bool IsNameSurrogateReparsePoint(ref WIN32_FIND_DATA data) { }

	[Address(RVA = "0x1FD7520", Offset = "0x1FD6920", Length = "0xCE")]
	[Token(Token = "0x6002E0E")]
	public static void RemoveDirectory(string fullPath, bool recursive) { }

	[Address(RVA = "0x1FD6BE0", Offset = "0x1FD5FE0", Length = "0x11C")]
	[Token(Token = "0x6002E12")]
	private static void RemoveDirectoryInternal(string fullPath, bool topLevel, bool allowDirectoryNotEmpty = false) { }

	[Address(RVA = "0x1FD6D00", Offset = "0x1FD6100", Length = "0x81C")]
	[Token(Token = "0x6002E11")]
	private static void RemoveDirectoryRecursive(string fullPath, ref WIN32_FIND_DATA findData, bool topLevel) { }

	[Address(RVA = "0x1FD75F0", Offset = "0x1FD69F0", Length = "0x6E")]
	[Token(Token = "0x6002E22")]
	private static string RemoveExtendedPathPrefix(string path) { }

	[Address(RVA = "0x1FD7660", Offset = "0x1FD6A60", Length = "0x91")]
	[Token(Token = "0x6002E13")]
	private static bool UnityCreateDirectory(string name) { }

	[Address(RVA = "0x1FD7700", Offset = "0x1FD6B00", Length = "0xCF")]
	[Token(Token = "0x6002E16")]
	internal static IntPtr UnityCreateFile_IntPtr(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes) { }

	[Address(RVA = "0x1FD77D0", Offset = "0x1FD6BD0", Length = "0xD5")]
	[Token(Token = "0x6002E17")]
	private static bool UnityDeleteFile(string path) { }

	[Address(RVA = "0x1FD78B0", Offset = "0x1FD6CB0", Length = "0x1AD")]
	[Token(Token = "0x6002E18")]
	private static SafeFindHandle UnityFindFirstFile(string path, ref WIN32_FIND_DATA findData) { }

	[Address(RVA = "0x1FD7A60", Offset = "0x1FD6E60", Length = "0xF8")]
	[Token(Token = "0x6002E19")]
	private static bool UnityFindNextFile(SafeFindHandle handle, ref WIN32_FIND_DATA findData) { }

	[Address(RVA = "0x1FD7B60", Offset = "0x1FD6F60", Length = "0x15D")]
	[Token(Token = "0x6002E15")]
	private static bool UnityGetFileAttributesEx(string path, ref WIN32_FILE_ATTRIBUTE_DATA data) { }

	[Address(RVA = "0x1FD7CC0", Offset = "0x1FD70C0", Length = "0xD5")]
	[Token(Token = "0x6002E14")]
	private static bool UnityRemoveDirectory(string fullPath) { }

}

