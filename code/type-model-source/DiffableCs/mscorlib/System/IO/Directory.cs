namespace System.IO;

[Token(Token = "0x200065B")]
public static class Directory
{

	[Address(RVA = "0x1FD41D0", Offset = "0x1FD35D0", Length = "0x150")]
	[Token(Token = "0x6002F5E")]
	public static DirectoryInfo CreateDirectory(string path) { }

	[Address(RVA = "0x1FD4330", Offset = "0x1FD3730", Length = "0x91")]
	[Token(Token = "0x6002F6A")]
	public static void Delete(string path) { }

	[Address(RVA = "0x1FD43F0", Offset = "0x1FD37F0", Length = "0x7F")]
	[Token(Token = "0x6002F66")]
	public static IEnumerable<String> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption) { }

	[Address(RVA = "0x1FD43D0", Offset = "0x1FD37D0", Length = "0x20")]
	[Token(Token = "0x6002F67")]
	public static IEnumerable<String> EnumerateDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions) { }

	[Address(RVA = "0x1FD4470", Offset = "0x1FD3870", Length = "0xA3")]
	[Token(Token = "0x6002F5F")]
	public static bool Exists(string path) { }

	[Address(RVA = "0x1FD4520", Offset = "0x1FD3920", Length = "0x7")]
	[Token(Token = "0x6002F69")]
	public static string GetCurrentDirectory() { }

	[Address(RVA = "0x1FD4530", Offset = "0x1FD3930", Length = "0xEF")]
	[Token(Token = "0x6002F63")]
	public static String[] GetDirectories(string path) { }

	[Address(RVA = "0x1FD4620", Offset = "0x1FD3A20", Length = "0x6F")]
	[Token(Token = "0x6002F64")]
	public static String[] GetDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions) { }

	[Address(RVA = "0x1FD4690", Offset = "0x1FD3A90", Length = "0xDF")]
	[Token(Token = "0x6002F60")]
	public static String[] GetFiles(string path, string searchPattern) { }

	[Address(RVA = "0x1FD4770", Offset = "0x1FD3B70", Length = "0xAC")]
	[Token(Token = "0x6002F61")]
	public static String[] GetFiles(string path, string searchPattern, SearchOption searchOption) { }

	[Address(RVA = "0x1FD4820", Offset = "0x1FD3C20", Length = "0x6F")]
	[Token(Token = "0x6002F62")]
	public static String[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions) { }

	[Address(RVA = "0x1FD4890", Offset = "0x1FD3C90", Length = "0x90")]
	[Token(Token = "0x6002F6B")]
	internal static string InsecureGetCurrentDirectory() { }

	[Address(RVA = "0x1FD4930", Offset = "0x1FD3D30", Length = "0x234")]
	[Token(Token = "0x6002F65")]
	internal static IEnumerable<String> InternalEnumeratePaths(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options) { }

	[Address(RVA = "0x1FD4B70", Offset = "0x1FD3F70", Length = "0xAD")]
	[Token(Token = "0x6002F68")]
	internal static string InternalGetDirectoryRoot(string path) { }

}

