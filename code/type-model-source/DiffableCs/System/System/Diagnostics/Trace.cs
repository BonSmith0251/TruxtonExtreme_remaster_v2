namespace System.Diagnostics;

[Token(Token = "0x20000FC")]
public sealed class Trace
{
	[Token(Token = "0x400045C")]
	private static CorrelationManager correlationManager; //Field offset: 0x0

	[Token(Token = "0x170000E9")]
	public static bool AutoFlush
	{
		[Address(RVA = "0x2640300", Offset = "0x263F700", Length = "0x88")]
		[Token(Token = "0x6000621")]
		 get { } //Length: 136
	}

	[Token(Token = "0x170000EA")]
	public static CorrelationManager CorrelationManager
	{
		[Address(RVA = "0x2640390", Offset = "0x263F790", Length = "0xAD")]
		[Token(Token = "0x6000622")]
		 get { } //Length: 173
	}

	[Token(Token = "0x170000E8")]
	public static TraceListenerCollection Listeners
	{
		[Address(RVA = "0x2640440", Offset = "0x263F840", Length = "0x40")]
		[Token(Token = "0x6000620")]
		 get { } //Length: 64
	}

	[Address(RVA = "0x2640300", Offset = "0x263F700", Length = "0x88")]
	[Token(Token = "0x6000621")]
	public static bool get_AutoFlush() { }

	[Address(RVA = "0x2640390", Offset = "0x263F790", Length = "0xAD")]
	[Token(Token = "0x6000622")]
	public static CorrelationManager get_CorrelationManager() { }

	[Address(RVA = "0x2640440", Offset = "0x263F840", Length = "0x40")]
	[Token(Token = "0x6000620")]
	public static TraceListenerCollection get_Listeners() { }

}

