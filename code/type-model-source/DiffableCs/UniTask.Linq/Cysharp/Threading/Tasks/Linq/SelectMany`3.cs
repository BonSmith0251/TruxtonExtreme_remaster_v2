namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200017B")]
internal sealed class SelectMany : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x200017C")]
	private sealed class _SelectMany : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x200017D")]
		private struct <DisposeAsync>d__26 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000F28")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000F29")]
			public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000F2A")]
			public _SelectMany<TSource, TCollection, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000F2B")]
			private Awaiter <>u__1; //Field offset: 0x0

			[Address(RVA = "0x16E8620", Offset = "0x16E7A20", Length = "0x42B")]
			[Token(Token = "0x6000720")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x6000721")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x4000F18")]
		private static readonly Action<Object> sourceMoveNextCoreDelegate; //Field offset: 0x0
		[Token(Token = "0x4000F19")]
		private static readonly Action<Object> selectedSourceMoveNextCoreDelegate; //Field offset: 0x0
		[Token(Token = "0x4000F1A")]
		private static readonly Action<Object> selectedEnumeratorDisposeAsyncCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F1B")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F1C")]
		private readonly Func<TSource, IUniTaskAsyncEnumerable`1<TCollection>> selector1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F1D")]
		private readonly Func<TSource, Int32, IUniTaskAsyncEnumerable`1<TCollection>> selector2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F1E")]
		private readonly Func<TSource, TCollection, TResult> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F1F")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F20")]
		private TSource sourceCurrent; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F21")]
		private int sourceIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F22")]
		private IUniTaskAsyncEnumerator<TSource> sourceEnumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F23")]
		private IUniTaskAsyncEnumerator<TCollection> selectedEnumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F24")]
		private Awaiter<Boolean> sourceAwaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F25")]
		private Awaiter<Boolean> selectedAwaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F26")]
		private Awaiter selectedDisposeAsyncAwaiter; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F27")]
		private TResult <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700003C")]
		public private override TResult Current
		{
			[Address(RVA = "0x1614530", Offset = "0x1613930", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x6000716")]
			 get { } //Length: 176
			[Address(RVA = "0x16145E0", Offset = "0x16139E0", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x6000717")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x1614100", Offset = "0x1613500", Length = "0x265")]
		[Token(Token = "0x600071F")]
		private static _SelectMany() { }

		[Address(RVA = "0x1614370", Offset = "0x1613770", Length = "0x1C0")]
		[Token(Token = "0x6000715")]
		public _SelectMany(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, IUniTaskAsyncEnumerable`1<TCollection>> selector1, Func<TSource, Int32, IUniTaskAsyncEnumerable`1<TCollection>> selector2, Func<TSource, TCollection, TResult> resultSelector, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1568E10", Offset = "0x1568210", Length = "0xA7")]
		[AsyncStateMachine(typeof(<DisposeAsync>d__26))]
		[Token(Token = "0x600071E")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x1614530", Offset = "0x1613930", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x6000716")]
		public override TResult get_Current() { }

		[Address(RVA = "0x1612750", Offset = "0x1611B50", Length = "0x20A")]
		[Token(Token = "0x6000718")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x1612960", Offset = "0x1611D60", Length = "0x35D")]
		[Token(Token = "0x600071A")]
		private void MoveNextSelected() { }

		[Address(RVA = "0x1612CC0", Offset = "0x16120C0", Length = "0x35C")]
		[Token(Token = "0x6000719")]
		private void MoveNextSource() { }

		[Address(RVA = "0x1613020", Offset = "0x1612420", Length = "0x1C1")]
		[Token(Token = "0x600071D")]
		private static void SelectedEnumeratorDisposeAsyncCore(object state) { }

		[Address(RVA = "0x16131F0", Offset = "0x16125F0", Length = "0x785")]
		[Token(Token = "0x600071C")]
		private static void SeletedSourceMoveNextCore(object state) { }

		[Address(RVA = "0x16145E0", Offset = "0x16139E0", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x6000717")]
		private void set_Current(TResult value) { }

		[Address(RVA = "0x1613980", Offset = "0x1612D80", Length = "0x776")]
		[Token(Token = "0x600071B")]
		private static void SourceMoveNextCore(object state) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000F14")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000F15")]
	private readonly Func<TSource, IUniTaskAsyncEnumerable`1<TCollection>> selector1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000F16")]
	private readonly Func<TSource, Int32, IUniTaskAsyncEnumerable`1<TCollection>> selector2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000F17")]
	private readonly Func<TSource, TCollection, TResult> resultSelector; //Field offset: 0x0

	[Address(RVA = "0xF59240", Offset = "0xF58640", Length = "0x7E")]
	[Token(Token = "0x6000712")]
	public SelectMany`3(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, IUniTaskAsyncEnumerable`1<TCollection>> selector, Func<TSource, TCollection, TResult> resultSelector) { }

	[Address(RVA = "0xF591C0", Offset = "0xF585C0", Length = "0x7E")]
	[Token(Token = "0x6000713")]
	public SelectMany`3(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, IUniTaskAsyncEnumerable`1<TCollection>> selector, Func<TSource, TCollection, TResult> resultSelector) { }

	[Address(RVA = "0xF59100", Offset = "0xF58500", Length = "0xB1")]
	[Token(Token = "0x6000714")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

