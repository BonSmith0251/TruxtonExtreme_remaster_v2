namespace System.IO;

[ComVisible(True)]
[Token(Token = "0x200067F")]
public static class Path
{
	[CompilerGenerated]
	[Token(Token = "0x2000680")]
	private sealed class <>c
	{
		[Token(Token = "0x4001A51")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4001A52")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"First", "FirstLength", "Second", "SecondLength", "HasSeparator"})]
		public static SpanAction<Char, ValueTuple`5<IntPtr, Int32, IntPtr, Int32, Boolean>> <>9__59_0; //Field offset: 0x8
		[Token(Token = "0x4001A53")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"First", "FirstLength", "Second", "SecondLength", "Third", "ThirdLength", "FirstHasSeparator", "ThirdHasSeparator", null})]
		public static SpanAction<Char, ValueTuple`8<IntPtr, Int32, IntPtr, Int32, IntPtr, Int32, Boolean, ValueTuple`1<Boolean>>> <>9__60_0; //Field offset: 0x10

		[Address(RVA = "0x20049B0", Offset = "0x2003DB0", Length = "0x67")]
		[Token(Token = "0x60030F1")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60030F2")]
		public <>c() { }

		[Address(RVA = "0x2004240", Offset = "0x2003640", Length = "0x1C9")]
		[Token(Token = "0x60030F3")]
		internal void <JoinInternal>b__59_0(Span<Char> destination, ValueTuple<IntPtr, Int32, IntPtr, Int32, Boolean> state) { }

		[Address(RVA = "0x2004410", Offset = "0x2003810", Length = "0x2AE")]
		[Token(Token = "0x60030F4")]
		internal void <JoinInternal>b__60_0(Span<Char> destination, ValueTuple<IntPtr, Int32, IntPtr, Int32, IntPtr, Int32, Boolean, ValueTuple`1<Boolean>> state) { }

	}

	[Obsolete("see GetInvalidPathChars and GetInvalidFileNameChars methods.")]
	[Token(Token = "0x4001A47")]
	public static readonly Char[] InvalidPathChars; //Field offset: 0x0
	[Token(Token = "0x4001A48")]
	public static readonly char AltDirectorySeparatorChar; //Field offset: 0x8
	[Token(Token = "0x4001A49")]
	public static readonly char DirectorySeparatorChar; //Field offset: 0xA
	[Token(Token = "0x4001A4A")]
	public static readonly char PathSeparator; //Field offset: 0xC
	[Token(Token = "0x4001A4B")]
	internal static readonly string DirectorySeparatorStr; //Field offset: 0x10
	[Token(Token = "0x4001A4C")]
	public static readonly char VolumeSeparatorChar; //Field offset: 0x18
	[Token(Token = "0x4001A4D")]
	internal static readonly Char[] PathSeparatorChars; //Field offset: 0x20
	[Token(Token = "0x4001A4E")]
	private static readonly bool dirEqualsVolume; //Field offset: 0x28
	[Token(Token = "0x4001A4F")]
	internal static readonly Char[] trimEndCharsWindows; //Field offset: 0x30
	[Token(Token = "0x4001A50")]
	internal static readonly Char[] trimEndCharsUnix; //Field offset: 0x38

	[Address(RVA = "0x1FFDB00", Offset = "0x1FFCF00", Length = "0x310")]
	[Token(Token = "0x60030E6")]
	private static Path() { }

	[Address(RVA = "0x1FF9560", Offset = "0x1FF8960", Length = "0x725")]
	[Token(Token = "0x60030E9")]
	private static string CanonicalizePath(string path) { }

	[Address(RVA = "0x1FF9C90", Offset = "0x1FF9090", Length = "0x21C")]
	[Token(Token = "0x60030D0")]
	public static string ChangeExtension(string path, string extension) { }

	[Address(RVA = "0x1FF9EB0", Offset = "0x1FF92B0", Length = "0x461")]
	[Token(Token = "0x60030D2")]
	internal static string CleanPath(string s) { }

	[Address(RVA = "0x1FFA320", Offset = "0x1FF9720", Length = "0x321")]
	[Token(Token = "0x60030D1")]
	public static string Combine(string path1, string path2) { }

	[Address(RVA = "0x1FFA840", Offset = "0x1FF9C40", Length = "0x381")]
	[Token(Token = "0x60030EA")]
	public static string Combine(String[] paths) { }

	[Address(RVA = "0x1FFA650", Offset = "0x1FF9A50", Length = "0x1E4")]
	[Token(Token = "0x60030EB")]
	public static string Combine(string path1, string path2, string path3) { }

	[Address(RVA = "0x1FFDE20", Offset = "0x1FFD220", Length = "0x98")]
	[Token(Token = "0x60030E5")]
	private static int findExtension(string path) { }

	[Address(RVA = "0x1FFDEC0", Offset = "0x1FFD2C0", Length = "0x5")]
	[Token(Token = "0x60030E1")]
	private static string get_temp_path() { }

	[Address(RVA = "0x1FFABD0", Offset = "0x1FF9FD0", Length = "0xD5")]
	[Token(Token = "0x60030D4")]
	public static ReadOnlySpan<Char> GetDirectoryName(ReadOnlySpan<Char> path) { }

	[Address(RVA = "0x1FFACB0", Offset = "0x1FFA0B0", Length = "0x421")]
	[Token(Token = "0x60030D3")]
	public static string GetDirectoryName(string path) { }

	[Address(RVA = "0x1FFB0E0", Offset = "0x1FFA4E0", Length = "0x10D")]
	[Token(Token = "0x60030D5")]
	public static string GetExtension(string path) { }

	[Address(RVA = "0x1FFB250", Offset = "0x1FFA650", Length = "0x15C")]
	[Token(Token = "0x60030EC")]
	public static ReadOnlySpan<Char> GetFileName(ReadOnlySpan<Char> path) { }

	[Address(RVA = "0x1FFB3B0", Offset = "0x1FFA7B0", Length = "0x10E")]
	[Token(Token = "0x60030D6")]
	public static string GetFileName(string path) { }

	[Address(RVA = "0x1FFB1F0", Offset = "0x1FFA5F0", Length = "0x56")]
	[Token(Token = "0x60030D7")]
	public static string GetFileNameWithoutExtension(string path) { }

	[Address(RVA = "0x1FFB850", Offset = "0x1FFAC50", Length = "0x57")]
	[Token(Token = "0x60030D8")]
	public static string GetFullPath(string path) { }

	[Address(RVA = "0x1FFB4C0", Offset = "0x1FFA8C0", Length = "0x49")]
	[Token(Token = "0x60030D9")]
	internal static string GetFullPathInternal(string path) { }

	[Address(RVA = "0x1FFB510", Offset = "0x1FFA910", Length = "0x256")]
	[Token(Token = "0x60030DB")]
	internal static string GetFullPathName(string path) { }

	[Address(RVA = "0x1FFB770", Offset = "0x1FFAB70", Length = "0xDF")]
	[Token(Token = "0x60030DA")]
	private static int GetFullPathName(string path, int numBufferChars, StringBuilder buffer, ref IntPtr lpFilePartOrNull) { }

	[Address(RVA = "0x1FFB8B0", Offset = "0x1FFACB0", Length = "0x7D")]
	[Token(Token = "0x60030E4")]
	public static Char[] GetInvalidPathChars() { }

	[Address(RVA = "0x1FFB930", Offset = "0x1FFAD30", Length = "0x497")]
	[Token(Token = "0x60030DF")]
	public static string GetPathRoot(string path) { }

	[Address(RVA = "0x1FFBDD0", Offset = "0x1FFB1D0", Length = "0x1FD")]
	[Token(Token = "0x60030E7")]
	private static string GetServerAndShare(string path) { }

	[Address(RVA = "0x1FFBFD0", Offset = "0x1FFB3D0", Length = "0x106")]
	[Token(Token = "0x60030E0")]
	public static string GetTempPath() { }

	[Address(RVA = "0x1FFC0E0", Offset = "0x1FFB4E0", Length = "0x6F1")]
	[Token(Token = "0x60030DD")]
	internal static string InsecureGetFullPath(string path) { }

	[Address(RVA = "0x1FFC7E0", Offset = "0x1FFBBE0", Length = "0x7F")]
	[Token(Token = "0x60030DE")]
	internal static bool IsDirectorySeparator(char c) { }

	[Address(RVA = "0x1FFCA90", Offset = "0x1FFBE90", Length = "0x119")]
	[Token(Token = "0x60030E2")]
	public static bool IsPathRooted(ReadOnlySpan<Char> path) { }

	[Address(RVA = "0x1FFC860", Offset = "0x1FFBC60", Length = "0x223")]
	[Token(Token = "0x60030E3")]
	public static bool IsPathRooted(string path) { }

	[Address(RVA = "0x1FFD250", Offset = "0x1FFC650", Length = "0xAD")]
	[Token(Token = "0x60030ED")]
	public static string Join(ReadOnlySpan<Char> path1, ReadOnlySpan<Char> path2) { }

	[Address(RVA = "0x1FFD300", Offset = "0x1FFC700", Length = "0x2A9")]
	[Token(Token = "0x60030EE")]
	public static string Join(ReadOnlySpan<Char> path1, ReadOnlySpan<Char> path2, ReadOnlySpan<Char> path3) { }

	[Address(RVA = "0x1FFCF90", Offset = "0x1FFC390", Length = "0x2B9")]
	[Token(Token = "0x60030EF")]
	private static string JoinInternal(ReadOnlySpan<Char> first, ReadOnlySpan<Char> second) { }

	[Address(RVA = "0x1FFCBB0", Offset = "0x1FFBFB0", Length = "0x3D4")]
	[Token(Token = "0x60030F0")]
	private static string JoinInternal(ReadOnlySpan<Char> first, ReadOnlySpan<Char> second, ReadOnlySpan<Char> third) { }

	[Address(RVA = "0x1FFD5B0", Offset = "0x1FFC9B0", Length = "0x2D9")]
	[Token(Token = "0x60030E8")]
	private static bool SameRoot(string root, string path) { }

	[Address(RVA = "0x1FFD890", Offset = "0x1FFCC90", Length = "0x26F")]
	[Token(Token = "0x60030DC")]
	internal static string WindowsDriveAdjustment(string path) { }

}

