namespace System.Xml;

[Extension]
[Token(Token = "0x2000007")]
internal static class AsyncHelper
{
	[Token(Token = "0x4000003")]
	public static readonly Task DoneTask; //Field offset: 0x0
	[Token(Token = "0x4000004")]
	public static readonly Task<Boolean> DoneTaskTrue; //Field offset: 0x8
	[Token(Token = "0x4000005")]
	public static readonly Task<Boolean> DoneTaskFalse; //Field offset: 0x10
	[Token(Token = "0x4000006")]
	public static readonly Task<Int32> DoneTaskZero; //Field offset: 0x18

	[Address(RVA = "0x23ED920", Offset = "0x23ECD20", Length = "0x140")]
	[Token(Token = "0x6000006")]
	private static AsyncHelper() { }

}

