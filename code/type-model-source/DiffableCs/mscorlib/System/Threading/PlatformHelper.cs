namespace System.Threading;

[Token(Token = "0x2000206")]
internal static class PlatformHelper
{
	[Token(Token = "0x40009A5")]
	private static int s_processorCount; //Field offset: 0x0
	[Token(Token = "0x40009A6")]
	private static int s_lastProcessorCountRefreshTicks; //Field offset: 0x4
	[Token(Token = "0x40009A7")]
	internal static readonly bool IsSingleProcessor; //Field offset: 0x8

	[Token(Token = "0x17000195")]
	internal static int ProcessorCount
	{
		[Address(RVA = "0x20A2890", Offset = "0x20A1C90", Length = "0x106")]
		[Token(Token = "0x60011CC")]
		internal get { } //Length: 262
	}

	[Address(RVA = "0x20A2840", Offset = "0x20A1C40", Length = "0x43")]
	[Token(Token = "0x60011CD")]
	private static PlatformHelper() { }

	[Address(RVA = "0x20A2890", Offset = "0x20A1C90", Length = "0x106")]
	[Token(Token = "0x60011CC")]
	internal static int get_ProcessorCount() { }

}

