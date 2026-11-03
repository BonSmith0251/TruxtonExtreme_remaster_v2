namespace System.IO;

[Token(Token = "0x200067C")]
internal static class MonoIO
{
	[Token(Token = "0x4001A24")]
	public static readonly IntPtr InvalidHandle; //Field offset: 0x0
	[Token(Token = "0x4001A25")]
	private static bool dump_handles; //Field offset: 0x8

	[Token(Token = "0x170007A3")]
	public static char AltDirectorySeparatorChar
	{
		[Address(RVA = "0x1FF8C70", Offset = "0x1FF8070", Length = "0x5")]
		[Token(Token = "0x60030CB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170007A0")]
	public static IntPtr ConsoleError
	{
		[Address(RVA = "0x1FF8C80", Offset = "0x1FF8080", Length = "0x5")]
		[Token(Token = "0x60030C7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700079F")]
	public static IntPtr ConsoleInput
	{
		[Address(RVA = "0x1FF8C90", Offset = "0x1FF8090", Length = "0x5")]
		[Token(Token = "0x60030C6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700079E")]
	public static IntPtr ConsoleOutput
	{
		[Address(RVA = "0x1FF8CA0", Offset = "0x1FF80A0", Length = "0x5")]
		[Token(Token = "0x60030C5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170007A2")]
	public static char DirectorySeparatorChar
	{
		[Address(RVA = "0x1FF8CB0", Offset = "0x1FF80B0", Length = "0x5")]
		[Token(Token = "0x60030CA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170007A4")]
	public static char PathSeparator
	{
		[Address(RVA = "0x1FF8CC0", Offset = "0x1FF80C0", Length = "0x5")]
		[Token(Token = "0x60030CC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170007A1")]
	public static char VolumeSeparatorChar
	{
		[Address(RVA = "0x1FF8CD0", Offset = "0x1FF80D0", Length = "0x5")]
		[Token(Token = "0x60030C9")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1FF8BF0", Offset = "0x1FF7FF0", Length = "0x75")]
	[Token(Token = "0x60030CF")]
	private static MonoIO() { }

	[Address(RVA = "0x1FF7BC0", Offset = "0x1FF6FC0", Length = "0x111")]
	[Token(Token = "0x60030BB")]
	internal static bool Cancel(SafeHandle safeHandle, out MonoIOError error) { }

	[Address(RVA = "0x1FF7BB0", Offset = "0x1FF6FB0", Length = "0x5")]
	[Token(Token = "0x60030BA")]
	private static bool Cancel_internal(IntPtr handle, out MonoIOError error) { }

	[Address(RVA = "0x1FF7CE0", Offset = "0x1FF70E0", Length = "0x5")]
	[Token(Token = "0x60030BC")]
	public static bool Close(IntPtr handle, out MonoIOError error) { }

	[Address(RVA = "0x1F659D0", Offset = "0x1F64DD0", Length = "0x5")]
	[Token(Token = "0x60030CD")]
	private static void DumpHandles() { }

	[Address(RVA = "0x1FF7CF0", Offset = "0x1FF70F0", Length = "0x5")]
	[Token(Token = "0x60030C8")]
	public static bool DuplicateHandle(IntPtr source_process_handle, IntPtr source_handle, IntPtr target_process_handle, out IntPtr target_handle, int access, int inherit, int options, out MonoIOError error) { }

	[Address(RVA = "0x1FF7D00", Offset = "0x1FF7100", Length = "0x5")]
	[Token(Token = "0x60030B7")]
	public static bool FindCloseFile(IntPtr hnd) { }

	[Address(RVA = "0x1FF8C70", Offset = "0x1FF8070", Length = "0x5")]
	[Token(Token = "0x60030CB")]
	public static char get_AltDirectorySeparatorChar() { }

	[Address(RVA = "0x1FF8C80", Offset = "0x1FF8080", Length = "0x5")]
	[Token(Token = "0x60030C7")]
	public static IntPtr get_ConsoleError() { }

	[Address(RVA = "0x1FF8C90", Offset = "0x1FF8090", Length = "0x5")]
	[Token(Token = "0x60030C6")]
	public static IntPtr get_ConsoleInput() { }

	[Address(RVA = "0x1FF8CA0", Offset = "0x1FF80A0", Length = "0x5")]
	[Token(Token = "0x60030C5")]
	public static IntPtr get_ConsoleOutput() { }

	[Address(RVA = "0x1FF8CB0", Offset = "0x1FF80B0", Length = "0x5")]
	[Token(Token = "0x60030CA")]
	public static char get_DirectorySeparatorChar() { }

	[Address(RVA = "0x1FF8CC0", Offset = "0x1FF80C0", Length = "0x5")]
	[Token(Token = "0x60030CC")]
	public static char get_PathSeparator() { }

	[Address(RVA = "0x1FF8CD0", Offset = "0x1FF80D0", Length = "0x5")]
	[Token(Token = "0x60030C9")]
	public static char get_VolumeSeparatorChar() { }

	[Address(RVA = "0x1FF7D10", Offset = "0x1FF7110", Length = "0x5")]
	[Token(Token = "0x60030B4")]
	public static string GetCurrentDirectory(out MonoIOError error) { }

	[Address(RVA = "0x1FF8410", Offset = "0x1FF7810", Length = "0xFA")]
	[Token(Token = "0x60030B2")]
	public static Exception GetException(MonoIOError error) { }

	[Address(RVA = "0x1FF7D20", Offset = "0x1FF7120", Length = "0x388")]
	[Token(Token = "0x60030B3")]
	public static Exception GetException(string path, MonoIOError error) { }

	[Address(RVA = "0x1FF8510", Offset = "0x1FF7910", Length = "0x10A")]
	[Token(Token = "0x60030B6")]
	public static MonoFileType GetFileType(SafeHandle safeHandle, out MonoIOError error) { }

	[Address(RVA = "0x1FF8620", Offset = "0x1FF7A20", Length = "0x5")]
	[Token(Token = "0x60030B5")]
	private static MonoFileType GetFileType(IntPtr handle, out MonoIOError error) { }

	[Address(RVA = "0x1FF8630", Offset = "0x1FF7A30", Length = "0x5")]
	[Token(Token = "0x60030C3")]
	private static long GetLength(IntPtr handle, out MonoIOError error) { }

	[Address(RVA = "0x1FF8640", Offset = "0x1FF7A40", Length = "0x10F")]
	[Token(Token = "0x60030C4")]
	public static long GetLength(SafeHandle safeHandle, out MonoIOError error) { }

	[Address(RVA = "0x1FF8760", Offset = "0x1FF7B60", Length = "0x86")]
	[Token(Token = "0x60030B9")]
	public static IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	[Address(RVA = "0x1FF8750", Offset = "0x1FF7B50", Length = "0x5")]
	[Token(Token = "0x60030B8")]
	private static IntPtr Open(Char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	[Address(RVA = "0x1FF87F0", Offset = "0x1FF7BF0", Length = "0x13E")]
	[Token(Token = "0x60030BE")]
	public static int Read(SafeHandle safeHandle, Byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	[Address(RVA = "0x1FF8930", Offset = "0x1FF7D30", Length = "0x5")]
	[Token(Token = "0x60030BD")]
	private static int Read(IntPtr handle, Byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	[Address(RVA = "0x1FF8940", Offset = "0x1FF7D40", Length = "0x5")]
	[Token(Token = "0x60030CE")]
	public static bool RemapPath(string path, out string newPath) { }

	[Address(RVA = "0x1FF8950", Offset = "0x1FF7D50", Length = "0x135")]
	[Token(Token = "0x60030C2")]
	public static long Seek(SafeHandle safeHandle, long offset, SeekOrigin origin, out MonoIOError error) { }

	[Address(RVA = "0x1FF8A90", Offset = "0x1FF7E90", Length = "0x5")]
	[Token(Token = "0x60030C1")]
	private static long Seek(IntPtr handle, long offset, SeekOrigin origin, out MonoIOError error) { }

	[Address(RVA = "0x1FF8BE0", Offset = "0x1FF7FE0", Length = "0x5")]
	[Token(Token = "0x60030BF")]
	private static int Write(IntPtr handle, in Byte[] src, int src_offset, int count, out MonoIOError error) { }

	[Address(RVA = "0x1FF8AA0", Offset = "0x1FF7EA0", Length = "0x13E")]
	[Token(Token = "0x60030C0")]
	public static int Write(SafeHandle safeHandle, Byte[] src, int src_offset, int count, out MonoIOError error) { }

}

