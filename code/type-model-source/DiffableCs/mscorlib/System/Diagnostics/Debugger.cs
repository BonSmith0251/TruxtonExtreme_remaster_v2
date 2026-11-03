namespace System.Diagnostics;

[ComVisible(True)]
[Token(Token = "0x200058C")]
public sealed class Debugger
{
	[Token(Token = "0x4001763")]
	public static readonly string DefaultCategory; //Field offset: 0x0

	[Address(RVA = "0x1FC1910", Offset = "0x1FC0D10", Length = "0x62")]
	[Token(Token = "0x60028F1")]
	private static Debugger() { }

	[Address(RVA = "0x1E5F020", Offset = "0x1E5E420", Length = "0x5")]
	[Token(Token = "0x60028ED")]
	public static bool IsLogging() { }

	[Address(RVA = "0x1FC18B0", Offset = "0x1FC0CB0", Length = "0x59")]
	[Token(Token = "0x60028EF")]
	public static void Log(int level, string category, string message) { }

	[Address(RVA = "0x1F685D0", Offset = "0x1F679D0", Length = "0x5")]
	[Token(Token = "0x60028EE")]
	private static void Log_icall(int level, ref string category, ref string message) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60028F0")]
	public static void NotifyOfCrossThreadDependency() { }

}

