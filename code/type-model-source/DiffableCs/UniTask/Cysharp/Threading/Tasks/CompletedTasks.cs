namespace Cysharp.Threading.Tasks;

[Token(Token = "0x20000F1")]
internal static class CompletedTasks
{
	[Token(Token = "0x40003A7")]
	public static readonly UniTask<AsyncUnit> AsyncUnit; //Field offset: 0x0
	[Token(Token = "0x40003A8")]
	public static readonly UniTask<Boolean> True; //Field offset: 0x10
	[Token(Token = "0x40003A9")]
	public static readonly UniTask<Boolean> False; //Field offset: 0x20
	[Token(Token = "0x40003AA")]
	public static readonly UniTask<Int32> Zero; //Field offset: 0x30
	[Token(Token = "0x40003AB")]
	public static readonly UniTask<Int32> MinusOne; //Field offset: 0x40
	[Token(Token = "0x40003AC")]
	public static readonly UniTask<Int32> One; //Field offset: 0x50

	[Address(RVA = "0x27319E0", Offset = "0x2730DE0", Length = "0x235")]
	[Token(Token = "0x6000617")]
	private static CompletedTasks() { }

}

