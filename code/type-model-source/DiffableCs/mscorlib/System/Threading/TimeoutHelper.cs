namespace System.Threading;

[Token(Token = "0x2000207")]
internal static class TimeoutHelper
{

	[Address(RVA = "0x20A6360", Offset = "0x20A5760", Length = "0x7")]
	[Token(Token = "0x60011CE")]
	public static uint GetTime() { }

	[Address(RVA = "0x20A6370", Offset = "0x20A5770", Length = "0x3E")]
	[Token(Token = "0x60011CF")]
	public static int UpdateTimeOut(uint startTime, int originalWaitMillisecondsTimeout) { }

}

