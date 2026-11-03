namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000EB")]
internal static class LongCount
{
	[CompilerGenerated]
	[Token(Token = "0x20000EC")]
	private struct <LongCountAsync>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009F8")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009F9")]
		public AsyncUniTaskMethodBuilder<Int64> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009FA")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009FB")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009FC")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009FD")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009FE")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009FF")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A00")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A01")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x180FC40", Offset = "0x180F040", Length = "0x5F6")]
		[Token(Token = "0x6000555")]
		private override void MoveNext() { }

		[Address(RVA = "0x1810240", Offset = "0x180F640", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000556")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000ED")]
	private struct <LongCountAsync>d__1 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A02")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A03")]
		public AsyncUniTaskMethodBuilder<Int64> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A04")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A05")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A06")]
		public Func<TSource, Boolean> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A07")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A08")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A09")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A0A")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A0B")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A0C")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1810290", Offset = "0x180F690", Length = "0x729")]
		[Token(Token = "0x6000557")]
		private override void MoveNext() { }

		[Address(RVA = "0x18109C0", Offset = "0x180FDC0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000558")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000EE")]
	private struct <LongCountAwaitAsync>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A0D")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A0E")]
		public AsyncUniTaskMethodBuilder<Int64> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A0F")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A10")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A11")]
		public Func<TSource, UniTask`1<Boolean>> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A12")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A13")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A14")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A15")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A16")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A17")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1810A10", Offset = "0x180FE10", Length = "0x82C")]
		[Token(Token = "0x6000559")]
		private override void MoveNext() { }

		[Address(RVA = "0x1811240", Offset = "0x1810640", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x600055A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000EF")]
	private struct <LongCountAwaitWithCancellationAsync>d__3 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A18")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A19")]
		public AsyncUniTaskMethodBuilder<Int64> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A1A")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A1B")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A1C")]
		public Func<TSource, CancellationToken, UniTask`1<Boolean>> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A1D")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A1E")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A1F")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A20")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A21")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A22")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1811290", Offset = "0x1810690", Length = "0x850")]
		[Token(Token = "0x600055B")]
		private override void MoveNext() { }

		[Address(RVA = "0x1811AF0", Offset = "0x1810EF0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x600055C")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x863B40", Offset = "0x862F40", Length = "0x12B")]
	[AsyncStateMachine(typeof(<LongCountAsync>d__0`1))]
	[Token(Token = "0x6000551")]
	internal static UniTask<Int64> LongCountAsync(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x863C70", Offset = "0x863070", Length = "0x12C")]
	[AsyncStateMachine(typeof(<LongCountAsync>d__1`1))]
	[Token(Token = "0x6000552")]
	internal static UniTask<Int64> LongCountAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Boolean> predicate, CancellationToken cancellationToken) { }

	[Address(RVA = "0x863C70", Offset = "0x863070", Length = "0x12C")]
	[AsyncStateMachine(typeof(<LongCountAwaitAsync>d__2`1))]
	[Token(Token = "0x6000553")]
	internal static UniTask<Int64> LongCountAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Boolean>> predicate, CancellationToken cancellationToken) { }

	[Address(RVA = "0x863C70", Offset = "0x863070", Length = "0x12C")]
	[AsyncStateMachine(typeof(<LongCountAwaitWithCancellationAsync>d__3`1))]
	[Token(Token = "0x6000554")]
	internal static UniTask<Int64> LongCountAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Boolean>> predicate, CancellationToken cancellationToken) { }

}

