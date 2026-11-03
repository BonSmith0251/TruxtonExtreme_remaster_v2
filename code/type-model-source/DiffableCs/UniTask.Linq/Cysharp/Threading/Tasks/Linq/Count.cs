namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200008F")]
internal static class Count
{
	[CompilerGenerated]
	[Token(Token = "0x2000090")]
	private struct <CountAsync>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000794")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000795")]
		public AsyncUniTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000796")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000797")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000798")]
		private int <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000799")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400079A")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400079B")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400079C")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400079D")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1149AA0", Offset = "0x1148EA0", Length = "0x5BD")]
		[Token(Token = "0x6000410")]
		private override void MoveNext() { }

		[Address(RVA = "0x114A060", Offset = "0x1149460", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000411")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000091")]
	private struct <CountAsync>d__1 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400079E")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400079F")]
		public AsyncUniTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007A0")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007A1")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007A2")]
		public Func<TSource, Boolean> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007A3")]
		private int <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007A4")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007A5")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007A6")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007A7")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007A8")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x114A0B0", Offset = "0x11494B0", Length = "0x6FF")]
		[Token(Token = "0x6000412")]
		private override void MoveNext() { }

		[Address(RVA = "0x114A7C0", Offset = "0x1149BC0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000413")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000092")]
	private struct <CountAwaitAsync>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007A9")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007AA")]
		public AsyncUniTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007AB")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007AC")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007AD")]
		public Func<TSource, UniTask`1<Boolean>> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007AE")]
		private int <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007AF")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007B0")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007B1")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007B2")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007B3")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x114A810", Offset = "0x1149C10", Length = "0x7FB")]
		[Token(Token = "0x6000414")]
		private override void MoveNext() { }

		[Address(RVA = "0x114B010", Offset = "0x114A410", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000415")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000093")]
	private struct <CountAwaitWithCancellationAsync>d__3 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007B4")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007B5")]
		public AsyncUniTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007B6")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007B7")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007B8")]
		public Func<TSource, CancellationToken, UniTask`1<Boolean>> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007B9")]
		private int <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007BA")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007BB")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007BC")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007BD")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007BE")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x114B060", Offset = "0x114A460", Length = "0x81F")]
		[Token(Token = "0x6000416")]
		private override void MoveNext() { }

		[Address(RVA = "0x114B890", Offset = "0x114AC90", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000417")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x7B8F60", Offset = "0x7B8360", Length = "0x121")]
	[AsyncStateMachine(typeof(<CountAsync>d__0`1))]
	[Token(Token = "0x600040C")]
	internal static UniTask<Int32> CountAsync(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x7B8E30", Offset = "0x7B8230", Length = "0x123")]
	[AsyncStateMachine(typeof(<CountAsync>d__1`1))]
	[Token(Token = "0x600040D")]
	internal static UniTask<Int32> CountAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Boolean> predicate, CancellationToken cancellationToken) { }

	[Address(RVA = "0x7B8E30", Offset = "0x7B8230", Length = "0x123")]
	[AsyncStateMachine(typeof(<CountAwaitAsync>d__2`1))]
	[Token(Token = "0x600040E")]
	internal static UniTask<Int32> CountAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Boolean>> predicate, CancellationToken cancellationToken) { }

	[Address(RVA = "0x7B8E30", Offset = "0x7B8230", Length = "0x123")]
	[AsyncStateMachine(typeof(<CountAwaitWithCancellationAsync>d__3`1))]
	[Token(Token = "0x600040F")]
	internal static UniTask<Int32> CountAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Boolean>> predicate, CancellationToken cancellationToken) { }

}

