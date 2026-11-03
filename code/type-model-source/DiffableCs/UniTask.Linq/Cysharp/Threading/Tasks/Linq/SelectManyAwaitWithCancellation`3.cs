namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000181")]
internal sealed class SelectManyAwaitWithCancellation : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x2000182")]
	private sealed class _SelectManyAwaitWithCancellation : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x2000183")]
		private struct <DisposeAsync>d__32 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000F60")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000F61")]
			public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000F62")]
			public _SelectManyAwaitWithCancellation<TSource, TCollection, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000F63")]
			private Awaiter <>u__1; //Field offset: 0x0

			[Address(RVA = "0x16E92B0", Offset = "0x16E86B0", Length = "0x42B")]
			[Token(Token = "0x6000744")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x6000745")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x4000F4C")]
		private static readonly Action<Object> sourceMoveNextCoreDelegate; //Field offset: 0x0
		[Token(Token = "0x4000F4D")]
		private static readonly Action<Object> selectedSourceMoveNextCoreDelegate; //Field offset: 0x0
		[Token(Token = "0x4000F4E")]
		private static readonly Action<Object> selectedEnumeratorDisposeAsyncCoreDelegate; //Field offset: 0x0
		[Token(Token = "0x4000F4F")]
		private static readonly Action<Object> selectorAwaitCoreDelegate; //Field offset: 0x0
		[Token(Token = "0x4000F50")]
		private static readonly Action<Object> resultSelectorAwaitCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F5D")]
		private Awaiter<IUniTaskAsyncEnumerable<TCollection>> collectionSelectorAwaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F5C")]
		private Awaiter selectedDisposeAsyncAwaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F5B")]
		private Awaiter<Boolean> selectedAwaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F5A")]
		private Awaiter<Boolean> sourceAwaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F59")]
		private IUniTaskAsyncEnumerator<TCollection> selectedEnumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F58")]
		private IUniTaskAsyncEnumerator<TSource> sourceEnumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F55")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F56")]
		private TSource sourceCurrent; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F5E")]
		private Awaiter<TResult> resultSelectorAwaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F54")]
		private readonly Func<TSource, TCollection, CancellationToken, UniTask`1<TResult>> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F53")]
		private readonly Func<TSource, Int32, CancellationToken, UniTask`1<IUniTaskAsyncEnumerable`1<TCollection>>> selector2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F52")]
		private readonly Func<TSource, CancellationToken, UniTask`1<IUniTaskAsyncEnumerable`1<TCollection>>> selector1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F51")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F57")]
		private int sourceIndex; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F5F")]
		private TResult <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700003E")]
		public private override TResult Current
		{
			[Address(RVA = "0x1610220", Offset = "0x160F620", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x6000738")]
			 get { } //Length: 176
			[Address(RVA = "0x16102D0", Offset = "0x160F6D0", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x6000739")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x160FC60", Offset = "0x160F060", Length = "0x3E3")]
		[Token(Token = "0x6000743")]
		private static _SelectManyAwaitWithCancellation() { }

		[Address(RVA = "0x1610050", Offset = "0x160F450", Length = "0x1C9")]
		[Token(Token = "0x6000737")]
		public _SelectManyAwaitWithCancellation(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<IUniTaskAsyncEnumerable`1<TCollection>>> selector1, Func<TSource, Int32, CancellationToken, UniTask`1<IUniTaskAsyncEnumerable`1<TCollection>>> selector2, Func<TSource, TCollection, CancellationToken, UniTask`1<TResult>> resultSelector, CancellationToken cancellationToken) { }

		[Address(RVA = "0x160D680", Offset = "0x160CA80", Length = "0xA7")]
		[AsyncStateMachine(typeof(<DisposeAsync>d__32))]
		[Token(Token = "0x6000742")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x1610220", Offset = "0x160F620", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x6000738")]
		public override TResult get_Current() { }

		[Address(RVA = "0x160D730", Offset = "0x160CB30", Length = "0x20D")]
		[Token(Token = "0x600073A")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x160D940", Offset = "0x160CD40", Length = "0x35D")]
		[Token(Token = "0x600073C")]
		private void MoveNextSelected() { }

		[Address(RVA = "0x160DCA0", Offset = "0x160D0A0", Length = "0x35C")]
		[Token(Token = "0x600073B")]
		private void MoveNextSource() { }

		[Address(RVA = "0x160E000", Offset = "0x160D400", Length = "0x2EB")]
		[Token(Token = "0x6000741")]
		private static void ResultSelectorAwaitCore(object state) { }

		[Address(RVA = "0x160E2F0", Offset = "0x160D6F0", Length = "0x1C1")]
		[Token(Token = "0x600073F")]
		private static void SelectedEnumeratorDisposeAsyncCore(object state) { }

		[Address(RVA = "0x160E4C0", Offset = "0x160D8C0", Length = "0x2BC")]
		[Token(Token = "0x6000740")]
		private static void SelectorAwaitCore(object state) { }

		[Address(RVA = "0x160E780", Offset = "0x160DB80", Length = "0xA93")]
		[Token(Token = "0x600073E")]
		private static void SeletedSourceMoveNextCore(object state) { }

		[Address(RVA = "0x16102D0", Offset = "0x160F6D0", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x6000739")]
		private void set_Current(TResult value) { }

		[Address(RVA = "0x160F220", Offset = "0x160E620", Length = "0xA3B")]
		[Token(Token = "0x600073D")]
		private static void SourceMoveNextCore(object state) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000F48")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000F49")]
	private readonly Func<TSource, CancellationToken, UniTask`1<IUniTaskAsyncEnumerable`1<TCollection>>> selector1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000F4A")]
	private readonly Func<TSource, Int32, CancellationToken, UniTask`1<IUniTaskAsyncEnumerable`1<TCollection>>> selector2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000F4B")]
	private readonly Func<TSource, TCollection, CancellationToken, UniTask`1<TResult>> resultSelector; //Field offset: 0x0

	[Address(RVA = "0xF59240", Offset = "0xF58640", Length = "0x7E")]
	[Token(Token = "0x6000734")]
	public SelectManyAwaitWithCancellation`3(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<IUniTaskAsyncEnumerable`1<TCollection>>> selector, Func<TSource, TCollection, CancellationToken, UniTask`1<TResult>> resultSelector) { }

	[Address(RVA = "0xF591C0", Offset = "0xF585C0", Length = "0x7E")]
	[Token(Token = "0x6000735")]
	public SelectManyAwaitWithCancellation`3(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, CancellationToken, UniTask`1<IUniTaskAsyncEnumerable`1<TCollection>>> selector, Func<TSource, TCollection, CancellationToken, UniTask`1<TResult>> resultSelector) { }

	[Address(RVA = "0xF59100", Offset = "0xF58500", Length = "0xB1")]
	[Token(Token = "0x6000736")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

