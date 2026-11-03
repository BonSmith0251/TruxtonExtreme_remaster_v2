namespace Mono.Btls;

[Token(Token = "0x200008C")]
internal static class MonoBtlsUtils
{
	[Token(Token = "0x400016F")]
	private static Byte[] emailOid; //Field offset: 0x0

	[Address(RVA = "0x2602D60", Offset = "0x2602160", Length = "0x8C")]
	[Token(Token = "0x6000275")]
	private static MonoBtlsUtils() { }

	[Address(RVA = "0x2602520", Offset = "0x2601920", Length = "0x608")]
	[Token(Token = "0x6000273")]
	private static bool AppendEntry(StringBuilder sb, MonoBtlsX509Name name, int index, string separator, bool quotes) { }

	[Address(RVA = "0x2602B70", Offset = "0x2601F70", Length = "0x78")]
	[Token(Token = "0x6000272")]
	public static bool Compare(Byte[] a, Byte[] b) { }

	[Address(RVA = "0x2602BF0", Offset = "0x2601FF0", Length = "0x162")]
	[Token(Token = "0x6000274")]
	public static string FormatName(MonoBtlsX509Name name, bool reversed, string separator, bool quotes) { }

}

