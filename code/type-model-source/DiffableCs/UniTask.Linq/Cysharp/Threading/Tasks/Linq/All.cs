namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000022")]
internal static class All
{
	[CompilerGenerated]
	[Token(Token = "0x2000023")]
	private struct <AllAsync>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A9")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AA")]
		public AsyncUniTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AB")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AC")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AD")]
		public Func<TSource, Boolean> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AE")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AF")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B0")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B1")]
		private bool <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B2")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B3")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0xA647F0", Offset = "0xA63BF0", Length = "0x6FA")]
		[Token(Token = "0x6000231")]
		private override void MoveNext() { }

		[Address(RVA = "0xA64EF0", Offset = "0xA642F0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000232")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000024")]
	private struct <AllAwaitAsync>d__1 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B4")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B5")]
		public AsyncUniTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B6")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B7")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B8")]
		public Func<TSource, UniTask`1<Boolean>> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B9")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000BA")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000BB")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000BC")]
		private bool <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000BD")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000BE")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0xA64F40", Offset = "0xA64340", Length = "0x85C")]
		[Token(Token = "0x6000233")]
		private override void MoveNext() { }

		[Address(RVA = "0xA657A0", Offset = "0xA64BA0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000234")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000025")]
	private struct <AllAwaitWithCancellationAsync>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000BF")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C0")]
		public AsyncUniTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C1")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C2")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C3")]
		public Func<TSource, CancellationToken, UniTask`1<Boolean>> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C4")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C5")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C6")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C7")]
		private bool <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C8")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C9")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0xA657F0", Offset = "0xA64BF0", Length = "0x879")]
		[Token(Token = "0x6000235")]
		private override void MoveNext() { }

		[Address(RVA = "0xA66070", Offset = "0xA65470", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000236")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x6E17F0", Offset = "0x6E0BF0", Length = "0x123")]
	[AsyncStateMachine(typeof(<AllAsync>d__0`1))]
	[Token(Token = "0x600022E")]
	internal static UniTask<Boolean> AllAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Boolean> predicate, CancellationToken cancellationToken) { }

	[Address(RVA = "0x6E17F0", Offset = "0x6E0BF0", Length = "0x123")]
	[AsyncStateMachine(typeof(<AllAwaitAsync>d__1`1))]
	[Token(Token = "0x600022F")]
	internal static UniTask<Boolean> AllAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Boolean>> predicate, CancellationToken cancellationToken) { }

	[Address(RVA = "0x6E17F0", Offset = "0x6E0BF0", Length = "0x123")]
	[AsyncStateMachine(typeof(<AllAwaitWithCancellationAsync>d__2`1))]
	[Token(Token = "0x6000230")]
	internal static UniTask<Boolean> AllAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Boolean>> predicate, CancellationToken cancellationToken) { }

}

