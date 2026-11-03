namespace System.Text;

[Token(Token = "0x20002B2")]
internal static class StringBuilderCache
{
	[ThreadStatic]
	[Token(Token = "0x4000BAA")]
	private static StringBuilder t_cachedInstance; //Field offset: 0x80000000

	[Address(RVA = "0x1E8FFA0", Offset = "0x1E8F3A0", Length = "0xDD")]
	[Token(Token = "0x600164A")]
	public static StringBuilder Acquire(int capacity = 16) { }

	[Address(RVA = "0x1E90080", Offset = "0x1E8F480", Length = "0x94")]
	[Token(Token = "0x600164C")]
	public static string GetStringAndRelease(StringBuilder sb) { }

	[Address(RVA = "0x1E90120", Offset = "0x1E8F520", Length = "0x76")]
	[Token(Token = "0x600164B")]
	public static void Release(StringBuilder sb) { }

}

