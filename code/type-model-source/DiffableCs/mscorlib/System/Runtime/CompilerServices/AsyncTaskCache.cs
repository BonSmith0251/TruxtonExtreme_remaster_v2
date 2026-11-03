namespace System.Runtime.CompilerServices;

[Token(Token = "0x200049F")]
internal static class AsyncTaskCache
{
	[Token(Token = "0x4001274")]
	internal static readonly Task<Boolean> TrueTask; //Field offset: 0x0
	[Token(Token = "0x4001275")]
	internal static readonly Task<Boolean> FalseTask; //Field offset: 0x8
	[Token(Token = "0x4001276")]
	internal static readonly Task<Int32>[] Int32Tasks; //Field offset: 0x10

	[Address(RVA = "0x1F32690", Offset = "0x1F31A90", Length = "0x1C9")]
	[Token(Token = "0x6002145")]
	private static AsyncTaskCache() { }

	[Address(RVA = "0x7359E0", Offset = "0x734DE0", Length = "0x99")]
	[Token(Token = "0x6002144")]
	internal static Task<TResult> CreateCacheableTask(TResult result) { }

	[Address(RVA = "0x1F32580", Offset = "0x1F31980", Length = "0x10D")]
	[Token(Token = "0x6002143")]
	private static Task<Int32>[] CreateInt32Tasks() { }

}

