namespace System.Diagnostics;

[Token(Token = "0x2000100")]
internal static class TraceInternal
{
	[ThreadStatic]
	[Token(Token = "0x4000470")]
	private static int indentLevel; //Field offset: 0x80000000
	[Token(Token = "0x400046D")]
	private static string appName; //Field offset: 0x0
	[Token(Token = "0x400046E")]
	private static TraceListenerCollection listeners; //Field offset: 0x8
	[Token(Token = "0x400046F")]
	private static bool autoFlush; //Field offset: 0x10
	[Token(Token = "0x4000471")]
	private static int indentSize; //Field offset: 0x14
	[Token(Token = "0x4000472")]
	internal static readonly object critSec; //Field offset: 0x18

	[Token(Token = "0x170000F2")]
	public static bool AutoFlush
	{
		[Address(RVA = "0x263E630", Offset = "0x263DA30", Length = "0x5A")]
		[Token(Token = "0x6000630")]
		 get { } //Length: 90
	}

	[Token(Token = "0x170000F3")]
	public static int IndentLevel
	{
		[Address(RVA = "0x263E690", Offset = "0x263DA90", Length = "0x48")]
		[Token(Token = "0x6000631")]
		 get { } //Length: 72
	}

	[Token(Token = "0x170000F4")]
	public static int IndentSize
	{
		[Address(RVA = "0x263E6E0", Offset = "0x263DAE0", Length = "0x58")]
		[Token(Token = "0x6000632")]
		 get { } //Length: 88
	}

	[Token(Token = "0x170000F1")]
	public static TraceListenerCollection Listeners
	{
		[Address(RVA = "0x263E740", Offset = "0x263DB40", Length = "0x313")]
		[Token(Token = "0x600062F")]
		 get { } //Length: 787
	}

	[Address(RVA = "0x263E580", Offset = "0x263D980", Length = "0xA7")]
	[Token(Token = "0x6000634")]
	private static TraceInternal() { }

	[Address(RVA = "0x263E630", Offset = "0x263DA30", Length = "0x5A")]
	[Token(Token = "0x6000630")]
	public static bool get_AutoFlush() { }

	[Address(RVA = "0x263E690", Offset = "0x263DA90", Length = "0x48")]
	[Token(Token = "0x6000631")]
	public static int get_IndentLevel() { }

	[Address(RVA = "0x263E6E0", Offset = "0x263DAE0", Length = "0x58")]
	[Token(Token = "0x6000632")]
	public static int get_IndentSize() { }

	[Address(RVA = "0x263E740", Offset = "0x263DB40", Length = "0x313")]
	[Token(Token = "0x600062F")]
	public static TraceListenerCollection get_Listeners() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000633")]
	private static void InitializeSettings() { }

}

