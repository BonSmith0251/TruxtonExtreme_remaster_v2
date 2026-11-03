namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000186")]
internal static class SingleOperator
{
	[CompilerGenerated]
	[Token(Token = "0x2000187")]
	private struct <SingleAsync>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F74")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F75")]
		public AsyncUniTaskMethodBuilder<TSource> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F76")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F77")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F78")]
		public bool defaultIfEmpty; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F79")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F7A")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F7B")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F7C")]
		private TSource <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F7D")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F7E")]
		private TSource <v>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F7F")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x19D7E60", Offset = "0x19D7260", Length = "0x1398")]
		[Token(Token = "0x600074D")]
		private override void MoveNext() { }

		[Address(RVA = "0x16F34C0", Offset = "0x16F28C0", Length = "0xC1")]
		[DebuggerHidden]
		[Token(Token = "0x600074E")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000188")]
	private struct <SingleAsync>d__1 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F80")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F81")]
		public AsyncUniTaskMethodBuilder<TSource> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F82")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F83")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F84")]
		public Func<TSource, Boolean> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F85")]
		public bool defaultIfEmpty; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F86")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F87")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F88")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F89")]
		private TSource <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F8A")]
		private TSource <value>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F8B")]
		private bool <found>5__7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F8C")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F8D")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x19D9200", Offset = "0x19D8600", Length = "0x1382")]
		[Token(Token = "0x600074F")]
		private override void MoveNext() { }

		[Address(RVA = "0xA574A0", Offset = "0xA568A0", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x6000750")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000189")]
	private struct <SingleAwaitAsync>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F8E")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F8F")]
		public AsyncUniTaskMethodBuilder<TSource> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F90")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F91")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F92")]
		public Func<TSource, UniTask`1<Boolean>> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F93")]
		public bool defaultIfEmpty; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F94")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F95")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F96")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F97")]
		private TSource <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F98")]
		private TSource <value>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F99")]
		private bool <found>5__7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F9A")]
		private TSource <v>5__8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F9B")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F9C")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x19DA590", Offset = "0x19D9990", Length = "0x169E")]
		[Token(Token = "0x6000751")]
		private override void MoveNext() { }

		[Address(RVA = "0xA574A0", Offset = "0xA568A0", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x6000752")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200018A")]
	private struct <SingleAwaitWithCancellationAsync>d__3 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F9D")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F9E")]
		public AsyncUniTaskMethodBuilder<TSource> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F9F")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FA0")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FA1")]
		public Func<TSource, CancellationToken, UniTask`1<Boolean>> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FA2")]
		public bool defaultIfEmpty; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FA3")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FA4")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FA5")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FA6")]
		private TSource <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FA7")]
		private TSource <value>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FA8")]
		private bool <found>5__7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FA9")]
		private TSource <v>5__8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FAA")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FAB")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x19DBC30", Offset = "0x19DB030", Length = "0x16D6")]
		[Token(Token = "0x6000753")]
		private override void MoveNext() { }

		[Address(RVA = "0xA574A0", Offset = "0xA568A0", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x6000754")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x7F17D0", Offset = "0x7F0BD0", Length = "0x299")]
	[AsyncStateMachine(typeof(<SingleAsync>d__0`1))]
	[Token(Token = "0x6000749")]
	public static UniTask<TSource> SingleAsync(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken, bool defaultIfEmpty) { }

	[Address(RVA = "0x7F14E0", Offset = "0x7F08E0", Length = "0x2E1")]
	[AsyncStateMachine(typeof(<SingleAsync>d__1`1))]
	[Token(Token = "0x600074A")]
	public static UniTask<TSource> SingleAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Boolean> predicate, CancellationToken cancellationToken, bool defaultIfEmpty) { }

	[Address(RVA = "0x7F14E0", Offset = "0x7F08E0", Length = "0x2E1")]
	[AsyncStateMachine(typeof(<SingleAwaitAsync>d__2`1))]
	[Token(Token = "0x600074B")]
	public static UniTask<TSource> SingleAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Boolean>> predicate, CancellationToken cancellationToken, bool defaultIfEmpty) { }

	[Address(RVA = "0x7F14E0", Offset = "0x7F08E0", Length = "0x2E1")]
	[AsyncStateMachine(typeof(<SingleAwaitWithCancellationAsync>d__3`1))]
	[Token(Token = "0x600074C")]
	public static UniTask<TSource> SingleAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Boolean>> predicate, CancellationToken cancellationToken, bool defaultIfEmpty) { }

}

