namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200017E")]
internal sealed class SelectManyAwait : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x200017F")]
	private sealed class _SelectManyAwait : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x2000180")]
		private struct <DisposeAsync>d__32 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000F44")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000F45")]
			public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000F46")]
			public _SelectManyAwait<TSource, TCollection, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000F47")]
			private Awaiter <>u__1; //Field offset: 0x0

			[Address(RVA = "0x16E8E80", Offset = "0x16E8280", Length = "0x42B")]
			[Token(Token = "0x6000732")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x6000733")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x4000F30")]
		private static readonly Action<Object> sourceMoveNextCoreDelegate; //Field offset: 0x0
		[Token(Token = "0x4000F31")]
		private static readonly Action<Object> selectedSourceMoveNextCoreDelegate; //Field offset: 0x0
		[Token(Token = "0x4000F32")]
		private static readonly Action<Object> selectedEnumeratorDisposeAsyncCoreDelegate; //Field offset: 0x0
		[Token(Token = "0x4000F33")]
		private static readonly Action<Object> selectorAwaitCoreDelegate; //Field offset: 0x0
		[Token(Token = "0x4000F34")]
		private static readonly Action<Object> resultSelectorAwaitCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F41")]
		private Awaiter<IUniTaskAsyncEnumerable<TCollection>> collectionSelectorAwaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F40")]
		private Awaiter selectedDisposeAsyncAwaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F3F")]
		private Awaiter<Boolean> selectedAwaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F3E")]
		private Awaiter<Boolean> sourceAwaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F3D")]
		private IUniTaskAsyncEnumerator<TCollection> selectedEnumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F3C")]
		private IUniTaskAsyncEnumerator<TSource> sourceEnumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F39")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F3A")]
		private TSource sourceCurrent; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F42")]
		private Awaiter<TResult> resultSelectorAwaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F38")]
		private readonly Func<TSource, TCollection, UniTask`1<TResult>> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F37")]
		private readonly Func<TSource, Int32, UniTask`1<IUniTaskAsyncEnumerable`1<TCollection>>> selector2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F36")]
		private readonly Func<TSource, UniTask`1<IUniTaskAsyncEnumerable`1<TCollection>>> selector1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F35")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F3B")]
		private int sourceIndex; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F43")]
		private TResult <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700003D")]
		public private override TResult Current
		{
			[Address(RVA = "0x1610220", Offset = "0x160F620", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x6000726")]
			 get { } //Length: 176
			[Address(RVA = "0x16102D0", Offset = "0x160F6D0", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x6000727")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x1612360", Offset = "0x1611760", Length = "0x3E3")]
		[Token(Token = "0x6000731")]
		private static _SelectManyAwait() { }

		[Address(RVA = "0x1610050", Offset = "0x160F450", Length = "0x1C9")]
		[Token(Token = "0x6000725")]
		public _SelectManyAwait(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<IUniTaskAsyncEnumerable`1<TCollection>>> selector1, Func<TSource, Int32, UniTask`1<IUniTaskAsyncEnumerable`1<TCollection>>> selector2, Func<TSource, TCollection, UniTask`1<TResult>> resultSelector, CancellationToken cancellationToken) { }

		[Address(RVA = "0x160D680", Offset = "0x160CA80", Length = "0xA7")]
		[AsyncStateMachine(typeof(<DisposeAsync>d__32))]
		[Token(Token = "0x6000730")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x1610220", Offset = "0x160F620", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x6000726")]
		public override TResult get_Current() { }

		[Address(RVA = "0x1610390", Offset = "0x160F790", Length = "0x20D")]
		[Token(Token = "0x6000728")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x16105A0", Offset = "0x160F9A0", Length = "0x35D")]
		[Token(Token = "0x600072A")]
		private void MoveNextSelected() { }

		[Address(RVA = "0x1610900", Offset = "0x160FD00", Length = "0x35C")]
		[Token(Token = "0x6000729")]
		private void MoveNextSource() { }

		[Address(RVA = "0x1610C60", Offset = "0x1610060", Length = "0x2EB")]
		[Token(Token = "0x600072F")]
		private static void ResultSelectorAwaitCore(object state) { }

		[Address(RVA = "0x160E2F0", Offset = "0x160D6F0", Length = "0x1C1")]
		[Token(Token = "0x600072D")]
		private static void SelectedEnumeratorDisposeAsyncCore(object state) { }

		[Address(RVA = "0x160E4C0", Offset = "0x160D8C0", Length = "0x2BC")]
		[Token(Token = "0x600072E")]
		private static void SelectorAwaitCore(object state) { }

		[Address(RVA = "0x1610F50", Offset = "0x1610350", Length = "0xA46")]
		[Token(Token = "0x600072C")]
		private static void SeletedSourceMoveNextCore(object state) { }

		[Address(RVA = "0x16102D0", Offset = "0x160F6D0", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x6000727")]
		private void set_Current(TResult value) { }

		[Address(RVA = "0x16119A0", Offset = "0x1610DA0", Length = "0x9B2")]
		[Token(Token = "0x600072B")]
		private static void SourceMoveNextCore(object state) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000F2C")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000F2D")]
	private readonly Func<TSource, UniTask`1<IUniTaskAsyncEnumerable`1<TCollection>>> selector1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000F2E")]
	private readonly Func<TSource, Int32, UniTask`1<IUniTaskAsyncEnumerable`1<TCollection>>> selector2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000F2F")]
	private readonly Func<TSource, TCollection, UniTask`1<TResult>> resultSelector; //Field offset: 0x0

	[Address(RVA = "0xF59240", Offset = "0xF58640", Length = "0x7E")]
	[Token(Token = "0x6000722")]
	public SelectManyAwait`3(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<IUniTaskAsyncEnumerable`1<TCollection>>> selector, Func<TSource, TCollection, UniTask`1<TResult>> resultSelector) { }

	[Address(RVA = "0xF591C0", Offset = "0xF585C0", Length = "0x7E")]
	[Token(Token = "0x6000723")]
	public SelectManyAwait`3(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, UniTask`1<IUniTaskAsyncEnumerable`1<TCollection>>> selector, Func<TSource, TCollection, UniTask`1<TResult>> resultSelector) { }

	[Address(RVA = "0xF59100", Offset = "0xF58500", Length = "0xB1")]
	[Token(Token = "0x6000724")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

