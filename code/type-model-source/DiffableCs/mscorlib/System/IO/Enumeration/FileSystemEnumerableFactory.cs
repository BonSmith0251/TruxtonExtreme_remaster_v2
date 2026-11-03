namespace System.IO.Enumeration;

[Token(Token = "0x200068C")]
internal static class FileSystemEnumerableFactory
{
	[CompilerGenerated]
	[Token(Token = "0x200068E")]
	private sealed class <>c
	{
		[Token(Token = "0x4001A72")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4001A73")]
		public static FindTransform<String> <>9__3_0; //Field offset: 0x8
		[Token(Token = "0x4001A74")]
		public static FindTransform<String> <>9__4_0; //Field offset: 0x10
		[Token(Token = "0x4001A75")]
		public static FindTransform<String> <>9__5_0; //Field offset: 0x18

		[Address(RVA = "0x2004A90", Offset = "0x2003E90", Length = "0x67")]
		[Token(Token = "0x600314C")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600314D")]
		public <>c() { }

		[Address(RVA = "0x2004730", Offset = "0x2003B30", Length = "0xA")]
		[Token(Token = "0x600314F")]
		internal string <UserDirectories>b__4_0(ref FileSystemEntry entry) { }

		[Address(RVA = "0x2004730", Offset = "0x2003B30", Length = "0xA")]
		[Token(Token = "0x6003150")]
		internal string <UserEntries>b__5_0(ref FileSystemEntry entry) { }

		[Address(RVA = "0x2004730", Offset = "0x2003B30", Length = "0xA")]
		[Token(Token = "0x600314E")]
		internal string <UserFiles>b__3_0(ref FileSystemEntry entry) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200068D")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001A70")]
		public string expression; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001A71")]
		public EnumerationOptions options; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600314A")]
		public <>c__DisplayClass3_0() { }

		[Address(RVA = "0x2004790", Offset = "0x2003B90", Length = "0xB4")]
		[Token(Token = "0x600314B")]
		internal bool <UserFiles>b__1(ref FileSystemEntry entry) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200068F")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001A76")]
		public string expression; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001A77")]
		public EnumerationOptions options; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6003151")]
		public <>c__DisplayClass4_0() { }

		[Address(RVA = "0x2004850", Offset = "0x2003C50", Length = "0xB4")]
		[Token(Token = "0x6003152")]
		internal bool <UserDirectories>b__1(ref FileSystemEntry entry) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000690")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001A78")]
		public string expression; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001A79")]
		public EnumerationOptions options; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6003153")]
		public <>c__DisplayClass5_0() { }

		[Address(RVA = "0x2004910", Offset = "0x2003D10", Length = "0x94")]
		[Token(Token = "0x6003154")]
		internal bool <UserEntries>b__1(ref FileSystemEntry entry) { }

	}

	[Token(Token = "0x4001A6F")]
	private static readonly Char[] s_unixEscapeChars; //Field offset: 0x0

	[Address(RVA = "0x1FF6810", Offset = "0x1FF5C10", Length = "0x8C")]
	[Token(Token = "0x6003149")]
	private static FileSystemEnumerableFactory() { }

	[Address(RVA = "0x1FF5910", Offset = "0x1FF4D10", Length = "0x2B8")]
	[Token(Token = "0x6003145")]
	private static bool MatchesPattern(string expression, ReadOnlySpan<Char> name, EnumerationOptions options) { }

	[Address(RVA = "0x1FF5BD0", Offset = "0x1FF4FD0", Length = "0x607")]
	[Token(Token = "0x6003144")]
	internal static void NormalizeInputs(ref string directory, ref string expression, EnumerationOptions options) { }

	[Address(RVA = "0x1FF61E0", Offset = "0x1FF55E0", Length = "0x207")]
	[Token(Token = "0x6003147")]
	internal static IEnumerable<String> UserDirectories(string directory, string expression, EnumerationOptions options) { }

	[Address(RVA = "0x1FF63F0", Offset = "0x1FF57F0", Length = "0x207")]
	[Token(Token = "0x6003148")]
	internal static IEnumerable<String> UserEntries(string directory, string expression, EnumerationOptions options) { }

	[Address(RVA = "0x1FF6600", Offset = "0x1FF5A00", Length = "0x207")]
	[Token(Token = "0x6003146")]
	internal static IEnumerable<String> UserFiles(string directory, string expression, EnumerationOptions options) { }

}

