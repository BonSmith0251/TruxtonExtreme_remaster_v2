namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000026")]
internal static class Any
{
	[CompilerGenerated]
	[Token(Token = "0x2000027")]
	private struct <AnyAsync>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000CA")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000CB")]
		public AsyncUniTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000CC")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000CD")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000CE")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000CF")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000D0")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000D1")]
		private bool <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000D2")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000D3")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0xA66460", Offset = "0xA65860", Length = "0x580")]
		[Token(Token = "0x600023B")]
		private override void MoveNext() { }

		[Address(RVA = "0xA669F0", Offset = "0xA65DF0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x600023C")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000028")]
	private struct <AnyAsync>d__1 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000D4")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000D5")]
		public AsyncUniTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000D6")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000D7")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000D8")]
		public Func<TSource, Boolean> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000D9")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000DA")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000DB")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000DC")]
		private bool <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000DD")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000DE")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0xA66A40", Offset = "0xA65E40", Length = "0x6FA")]
		[Token(Token = "0x600023D")]
		private override void MoveNext() { }

		[Address(RVA = "0xA67140", Offset = "0xA66540", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x600023E")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000029")]
	private struct <AnyAwaitAsync>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000DF")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000E0")]
		public AsyncUniTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000E1")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000E2")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000E3")]
		public Func<TSource, UniTask`1<Boolean>> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000E4")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000E5")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000E6")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000E7")]
		private bool <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000E8")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000E9")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0xA67190", Offset = "0xA66590", Length = "0x85C")]
		[Token(Token = "0x600023F")]
		private override void MoveNext() { }

		[Address(RVA = "0xA679F0", Offset = "0xA66DF0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000240")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002A")]
	private struct <AnyAwaitWithCancellationAsync>d__3 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000EA")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000EB")]
		public AsyncUniTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000EC")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000ED")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000EE")]
		public Func<TSource, CancellationToken, UniTask`1<Boolean>> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000EF")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000F0")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000F1")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000F2")]
		private bool <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000F3")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000F4")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0xA67A40", Offset = "0xA66E40", Length = "0x879")]
		[Token(Token = "0x6000241")]
		private override void MoveNext() { }

		[Address(RVA = "0xA682C0", Offset = "0xA676C0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000242")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x768A90", Offset = "0x767E90", Length = "0x127")]
	[AsyncStateMachine(typeof(<AnyAsync>d__0`1))]
	[Token(Token = "0x6000237")]
	internal static UniTask<Boolean> AnyAsync(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x6E17F0", Offset = "0x6E0BF0", Length = "0x123")]
	[AsyncStateMachine(typeof(<AnyAsync>d__1`1))]
	[Token(Token = "0x6000238")]
	internal static UniTask<Boolean> AnyAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Boolean> predicate, CancellationToken cancellationToken) { }

	[Address(RVA = "0x6E17F0", Offset = "0x6E0BF0", Length = "0x123")]
	[AsyncStateMachine(typeof(<AnyAwaitAsync>d__2`1))]
	[Token(Token = "0x6000239")]
	internal static UniTask<Boolean> AnyAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Boolean>> predicate, CancellationToken cancellationToken) { }

	[Address(RVA = "0x6E17F0", Offset = "0x6E0BF0", Length = "0x123")]
	[AsyncStateMachine(typeof(<AnyAwaitWithCancellationAsync>d__3`1))]
	[Token(Token = "0x600023A")]
	internal static UniTask<Boolean> AnyAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Boolean>> predicate, CancellationToken cancellationToken) { }

}

