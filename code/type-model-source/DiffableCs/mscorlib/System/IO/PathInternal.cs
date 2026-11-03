namespace System.IO;

[Token(Token = "0x2000642")]
internal static class PathInternal
{
	[Token(Token = "0x40018F4")]
	private static readonly bool s_isCaseSensitive; //Field offset: 0x0

	[Token(Token = "0x17000750")]
	internal static bool IsCaseSensitive
	{
		[Address(RVA = "0x1FDDC40", Offset = "0x1FDD040", Length = "0x4E")]
		[Token(Token = "0x6002E7D")]
		internal get { } //Length: 78
	}

	[Address(RVA = "0x1FDDC00", Offset = "0x1FDD000", Length = "0x3C")]
	[Token(Token = "0x6002E80")]
	private static PathInternal() { }

	[Address(RVA = "0x1FDCB50", Offset = "0x1FDBF50", Length = "0x87")]
	[Token(Token = "0x6002E78")]
	internal static bool EndsInDirectorySeparator(ReadOnlySpan<Char> path) { }

	[Address(RVA = "0x1FDCBE0", Offset = "0x1FDBFE0", Length = "0x51")]
	[Token(Token = "0x6002E70")]
	internal static bool EndsWithPeriodOrSpace(string path) { }

	[Address(RVA = "0x1FDCCE0", Offset = "0x1FDC0E0", Length = "0x148")]
	[Token(Token = "0x6002E72")]
	internal static string EnsureExtendedPrefix(string path) { }

	[Address(RVA = "0x1FDCC40", Offset = "0x1FDC040", Length = "0x9F")]
	[Token(Token = "0x6002E71")]
	internal static string EnsureExtendedPrefixIfNeeded(string path) { }

	[Address(RVA = "0x1FDDC40", Offset = "0x1FDD040", Length = "0x4E")]
	[Token(Token = "0x6002E7D")]
	internal static bool get_IsCaseSensitive() { }

	[Address(RVA = "0x1FDCE30", Offset = "0x1FDC230", Length = "0x1B9")]
	[Token(Token = "0x6002E7E")]
	private static bool GetIsCaseSensitive() { }

	[Address(RVA = "0x1FDCFF0", Offset = "0x1FDC3F0", Length = "0x3D9")]
	[Token(Token = "0x6002E76")]
	internal static int GetRootLength(ReadOnlySpan<Char> path) { }

	[Address(RVA = "0x1FDD4C0", Offset = "0x1FDC8C0", Length = "0x1B3")]
	[Token(Token = "0x6002E73")]
	internal static bool IsDevice(ReadOnlySpan<Char> path) { }

	[Address(RVA = "0x1FDD3D0", Offset = "0x1FDC7D0", Length = "0xE3")]
	[Token(Token = "0x6002E74")]
	internal static bool IsDeviceUNC(ReadOnlySpan<Char> path) { }

	[Address(RVA = "0x1FDD680", Offset = "0x1FDCA80", Length = "0x11")]
	[Token(Token = "0x6002E77")]
	internal static bool IsDirectorySeparator(char c) { }

	[Address(RVA = "0x1FDD6A0", Offset = "0x1FDCAA0", Length = "0x7C")]
	[Token(Token = "0x6002E75")]
	internal static bool IsExtended(ReadOnlySpan<Char> path) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002E7F")]
	public static bool IsPartiallyQualified(string path) { }

	[Address(RVA = "0x1FDD720", Offset = "0x1FDCB20", Length = "0x66")]
	[Token(Token = "0x6002E7C")]
	internal static bool IsRoot(ReadOnlySpan<Char> path) { }

	[Address(RVA = "0x1FDD790", Offset = "0x1FDCB90", Length = "0x1D")]
	[Token(Token = "0x6002E6F")]
	internal static bool IsValidDriveChar(char value) { }

	[Address(RVA = "0x1FDD7B0", Offset = "0x1FDCBB0", Length = "0x7C")]
	[Token(Token = "0x6002E79")]
	internal static bool StartsWithDirectorySeparator(ReadOnlySpan<Char> path) { }

	[Address(RVA = "0x1FDD830", Offset = "0x1FDCC30", Length = "0x206")]
	[Token(Token = "0x6002E7A")]
	internal static string TrimEndingDirectorySeparator(string path) { }

	[Address(RVA = "0x1FDDA40", Offset = "0x1FDCE40", Length = "0x1BE")]
	[Token(Token = "0x6002E7B")]
	internal static ReadOnlySpan<Char> TrimEndingDirectorySeparator(ReadOnlySpan<Char> path) { }

}

