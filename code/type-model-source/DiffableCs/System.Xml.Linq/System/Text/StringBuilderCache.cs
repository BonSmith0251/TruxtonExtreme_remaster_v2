namespace System.Text;

[Token(Token = "0x2000025")]
internal static class StringBuilderCache
{
	[ThreadStatic]
	[Token(Token = "0x400005E")]
	private static StringBuilder t_cachedInstance; //Field offset: 0x80000000

	[Address(RVA = "0x24067C0", Offset = "0x2405BC0", Length = "0xCA")]
	[Token(Token = "0x60000E9")]
	public static StringBuilder Acquire(int capacity = 16) { }

	[Address(RVA = "0x2406890", Offset = "0x2405C90", Length = "0x8F")]
	[Token(Token = "0x60000EB")]
	public static string GetStringAndRelease(StringBuilder sb) { }

	[Address(RVA = "0x2406920", Offset = "0x2405D20", Length = "0x71")]
	[Token(Token = "0x60000EA")]
	public static void Release(StringBuilder sb) { }

}

