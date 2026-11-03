namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000E6")]
internal static class Last
{
	[CompilerGenerated]
	[Token(Token = "0x20000E7")]
	private struct <LastAsync>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009C0")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009C1")]
		public AsyncUniTaskMethodBuilder<TSource> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009C2")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009C3")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009C4")]
		public bool defaultIfEmpty; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009C5")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009C6")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009C7")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009C8")]
		private TSource <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009C9")]
		private TSource <value>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009CA")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009CB")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1809F80", Offset = "0x1809380", Length = "0x16FB")]
		[Token(Token = "0x6000549")]
		private override void MoveNext() { }

		[Address(RVA = "0x16F34C0", Offset = "0x16F28C0", Length = "0xC1")]
		[DebuggerHidden]
		[Token(Token = "0x600054A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E8")]
	private struct <LastAsync>d__1 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009CC")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009CD")]
		public AsyncUniTaskMethodBuilder<TSource> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009CE")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009CF")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009D0")]
		public Func<TSource, Boolean> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009D1")]
		public bool defaultIfEmpty; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009D2")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009D3")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009D4")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009D5")]
		private TSource <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009D6")]
		private TSource <value>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009D7")]
		private bool <found>5__7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009D8")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009D9")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x180B680", Offset = "0x180AA80", Length = "0x484")]
		[Token(Token = "0x600054B")]
		private override void MoveNext() { }

		[Address(RVA = "0xA574A0", Offset = "0xA568A0", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x600054C")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E9")]
	private struct <LastAwaitAsync>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009DA")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009DB")]
		public AsyncUniTaskMethodBuilder<TSource> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009DC")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009DD")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009DE")]
		public Func<TSource, UniTask`1<Boolean>> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009DF")]
		public bool defaultIfEmpty; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009E0")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009E1")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009E2")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009E3")]
		private TSource <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009E4")]
		private TSource <value>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009E5")]
		private bool <found>5__7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009E6")]
		private TSource <v>5__8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009E7")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009E8")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x180CC60", Offset = "0x180C060", Length = "0x16F6")]
		[Token(Token = "0x600054D")]
		private override void MoveNext() { }

		[Address(RVA = "0xA574A0", Offset = "0xA568A0", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x600054E")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000EA")]
	private struct <LastAwaitWithCancellationAsync>d__3 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009E9")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009EA")]
		public AsyncUniTaskMethodBuilder<TSource> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009EB")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009EC")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009ED")]
		public Func<TSource, CancellationToken, UniTask`1<Boolean>> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009EE")]
		public bool defaultIfEmpty; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009EF")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009F0")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009F1")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009F2")]
		private TSource <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009F3")]
		private TSource <value>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009F4")]
		private bool <found>5__7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009F5")]
		private TSource <v>5__8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009F6")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009F7")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x180E360", Offset = "0x180D760", Length = "0x172F")]
		[Token(Token = "0x600054F")]
		private override void MoveNext() { }

		[Address(RVA = "0xA574A0", Offset = "0xA568A0", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x6000550")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x7F17D0", Offset = "0x7F0BD0", Length = "0x299")]
	[AsyncStateMachine(typeof(<LastAsync>d__0`1))]
	[Token(Token = "0x6000545")]
	public static UniTask<TSource> LastAsync(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken, bool defaultIfEmpty) { }

	[Address(RVA = "0x7F14E0", Offset = "0x7F08E0", Length = "0x2E1")]
	[AsyncStateMachine(typeof(<LastAsync>d__1`1))]
	[Token(Token = "0x6000546")]
	public static UniTask<TSource> LastAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Boolean> predicate, CancellationToken cancellationToken, bool defaultIfEmpty) { }

	[Address(RVA = "0x7F14E0", Offset = "0x7F08E0", Length = "0x2E1")]
	[AsyncStateMachine(typeof(<LastAwaitAsync>d__2`1))]
	[Token(Token = "0x6000547")]
	public static UniTask<TSource> LastAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Boolean>> predicate, CancellationToken cancellationToken, bool defaultIfEmpty) { }

	[Address(RVA = "0x7F14E0", Offset = "0x7F08E0", Length = "0x2E1")]
	[AsyncStateMachine(typeof(<LastAwaitWithCancellationAsync>d__3`1))]
	[Token(Token = "0x6000548")]
	public static UniTask<TSource> LastAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Boolean>> predicate, CancellationToken cancellationToken, bool defaultIfEmpty) { }

}

