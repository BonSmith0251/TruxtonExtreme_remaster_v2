namespace System.Threading;

[Token(Token = "0x2000238")]
internal static class ThreadPoolGlobals
{
	[Token(Token = "0x4000A32")]
	public static int processorCount; //Field offset: 0x0
	[Token(Token = "0x4000A33")]
	public static bool vmTpInitialized; //Field offset: 0x4
	[Token(Token = "0x4000A34")]
	public static bool enableWorkerTracking; //Field offset: 0x5
	[Token(Token = "0x4000A35")]
	public static readonly ThreadPoolWorkQueue workQueue; //Field offset: 0x8

	[Address(RVA = "0x20C05D0", Offset = "0x20BF9D0", Length = "0x134")]
	[Token(Token = "0x60012FC")]
	private static ThreadPoolGlobals() { }

}

