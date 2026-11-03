namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000B4")]
internal static class First
{
	[CompilerGenerated]
	[Token(Token = "0x20000B5")]
	private struct <FirstAsync>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000845")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000846")]
		public AsyncUniTaskMethodBuilder<TSource> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000847")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000848")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000849")]
		public bool defaultIfEmpty; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400084A")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400084B")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400084C")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400084D")]
		private TSource <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400084E")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400084F")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x16F69F0", Offset = "0x16F5DF0", Length = "0x10A3")]
		[Token(Token = "0x6000488")]
		private override void MoveNext() { }

		[Address(RVA = "0x16F34C0", Offset = "0x16F28C0", Length = "0xC1")]
		[DebuggerHidden]
		[Token(Token = "0x6000489")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000B6")]
	private struct <FirstAsync>d__1 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000850")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000851")]
		public AsyncUniTaskMethodBuilder<TSource> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000852")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000853")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000854")]
		public Func<TSource, Boolean> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000855")]
		public bool defaultIfEmpty; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000856")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000857")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000858")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000859")]
		private TSource <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400085A")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400085B")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x16F7AA0", Offset = "0x16F6EA0", Length = "0x11E6")]
		[Token(Token = "0x600048A")]
		private override void MoveNext() { }

		[Address(RVA = "0xA574A0", Offset = "0xA568A0", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x600048B")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000B7")]
	private struct <FirstAwaitAsync>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400085C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400085D")]
		public AsyncUniTaskMethodBuilder<TSource> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400085E")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400085F")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000860")]
		public Func<TSource, UniTask`1<Boolean>> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000861")]
		public bool defaultIfEmpty; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000862")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000863")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000864")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000865")]
		private TSource <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000866")]
		private TSource <v>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000867")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000868")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x16F8C90", Offset = "0x16F8090", Length = "0x154C")]
		[Token(Token = "0x600048C")]
		private override void MoveNext() { }

		[Address(RVA = "0xA574A0", Offset = "0xA568A0", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x600048D")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000B8")]
	private struct <FirstAwaitWithCancellationAsync>d__3 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000869")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400086A")]
		public AsyncUniTaskMethodBuilder<TSource> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400086B")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400086C")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400086D")]
		public Func<TSource, CancellationToken, UniTask`1<Boolean>> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400086E")]
		public bool defaultIfEmpty; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400086F")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000870")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000871")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000872")]
		private TSource <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000873")]
		private TSource <v>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000874")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000875")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x16FA1E0", Offset = "0x16F95E0", Length = "0x1598")]
		[Token(Token = "0x600048E")]
		private override void MoveNext() { }

		[Address(RVA = "0xA574A0", Offset = "0xA568A0", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x600048F")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x7F17D0", Offset = "0x7F0BD0", Length = "0x299")]
	[AsyncStateMachine(typeof(<FirstAsync>d__0`1))]
	[Token(Token = "0x6000484")]
	public static UniTask<TSource> FirstAsync(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken, bool defaultIfEmpty) { }

	[Address(RVA = "0x7F14E0", Offset = "0x7F08E0", Length = "0x2E1")]
	[AsyncStateMachine(typeof(<FirstAsync>d__1`1))]
	[Token(Token = "0x6000485")]
	public static UniTask<TSource> FirstAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Boolean> predicate, CancellationToken cancellationToken, bool defaultIfEmpty) { }

	[Address(RVA = "0x7F14E0", Offset = "0x7F08E0", Length = "0x2E1")]
	[AsyncStateMachine(typeof(<FirstAwaitAsync>d__2`1))]
	[Token(Token = "0x6000486")]
	public static UniTask<TSource> FirstAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Boolean>> predicate, CancellationToken cancellationToken, bool defaultIfEmpty) { }

	[Address(RVA = "0x7F14E0", Offset = "0x7F08E0", Length = "0x2E1")]
	[AsyncStateMachine(typeof(<FirstAwaitWithCancellationAsync>d__3`1))]
	[Token(Token = "0x6000487")]
	public static UniTask<TSource> FirstAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Boolean>> predicate, CancellationToken cancellationToken, bool defaultIfEmpty) { }

}

