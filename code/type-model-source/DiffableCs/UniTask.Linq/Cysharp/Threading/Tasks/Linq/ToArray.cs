namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20001E9")]
internal static class ToArray
{
	[CompilerGenerated]
	[Token(Token = "0x20001EA")]
	private struct <ToArrayAsync>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001260")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001261")]
		public AsyncUniTaskMethodBuilder<TSource[]> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001262")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001263")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001264")]
		private ArrayPool<TSource> <pool>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001265")]
		private TSource[] <array>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001266")]
		private TSource[] <result>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001267")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001268")]
		private object <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001269")]
		private int <>7__wrap6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400126A")]
		private int <i>5__8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400126B")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400126C")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1B5F820", Offset = "0x1B5EC20", Length = "0xCD7")]
		[Token(Token = "0x600087C")]
		private override void MoveNext() { }

		[Address(RVA = "0x1B60500", Offset = "0x1B5F900", Length = "0x87")]
		[DebuggerHidden]
		[Token(Token = "0x600087D")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x9453C0", Offset = "0x9447C0", Length = "0x128")]
	[AsyncStateMachine(typeof(<ToArrayAsync>d__0`1))]
	[Token(Token = "0x600087B")]
	internal static UniTask<TSource[]> ToArrayAsync(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken) { }

}

