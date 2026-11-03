namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200002F")]
internal abstract class AsyncEnumeratorAwaitSelectorBase : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
{
	[Token(Token = "0x400010B")]
	private static readonly Action<Object> moveNextCallbackDelegate; //Field offset: 0x0
	[Token(Token = "0x400010C")]
	private static readonly Action<Object> setCurrentCallbackDelegate; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400010D")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400010E")]
	protected CancellationToken cancellationToken; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400010F")]
	private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000110")]
	private Awaiter<Boolean> sourceMoveNext; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000111")]
	private Awaiter<TAwait> resultAwaiter; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000112")]
	private TSource <SourceCurrent>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000113")]
	private TResult <Current>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000005")]
	public override TResult Current
	{
		[Address(RVA = "0x100A140", Offset = "0x1009540", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x600025F")]
		 get { } //Length: 176
		[Address(RVA = "0x100A2A0", Offset = "0x10096A0", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x6000260")]
		 set { } //Length: 189
	}

	[Token(Token = "0x17000004")]
	protected private TSource SourceCurrent
	{
		[Address(RVA = "0x100A1F0", Offset = "0x10095F0", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x600025A")]
		 get { } //Length: 176
		[Address(RVA = "0x100A360", Offset = "0x1009760", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x600025B")]
		private set { } //Length: 189
	}

	[Address(RVA = "0x1009EC0", Offset = "0x10092C0", Length = "0x1AC")]
	[Token(Token = "0x6000268")]
	private static AsyncEnumeratorAwaitSelectorBase`3() { }

	[Address(RVA = "0x100A070", Offset = "0x1009470", Length = "0xCB")]
	[Token(Token = "0x6000257")]
	public AsyncEnumeratorAwaitSelectorBase`3(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x10088C0", Offset = "0x1007CC0", Length = "0x67")]
	[Token(Token = "0x600025C")]
	protected ValueTuple<Boolean, Boolean> ActionCompleted(bool trySetCurrentResult, out bool moveNextResult) { }

	[Address(RVA = "0x1008930", Offset = "0x1007D30", Length = "0x11B")]
	[Token(Token = "0x6000267")]
	public override UniTask DisposeAsync() { }

	[Address(RVA = "0x100A140", Offset = "0x1009540", Length = "0xB0")]
	[CompilerGenerated]
	[Token(Token = "0x600025F")]
	public override TResult get_Current() { }

	[Address(RVA = "0x100A1F0", Offset = "0x10095F0", Length = "0xB0")]
	[CompilerGenerated]
	[Token(Token = "0x600025A")]
	protected TSource get_SourceCurrent() { }

	[Address(RVA = "0x1008A50", Offset = "0x1007E50", Length = "0x50")]
	[Token(Token = "0x600025E")]
	protected ValueTuple<Boolean, Boolean> IterateFinished(out bool moveNextResult) { }

	[Address(RVA = "0x1008AA0", Offset = "0x1007EA0", Length = "0x1C2")]
	[Token(Token = "0x6000261")]
	public override UniTask<Boolean> MoveNextAsync() { }

	[Address(RVA = "0x1008C70", Offset = "0x1008070", Length = "0x20F")]
	[Token(Token = "0x6000265")]
	private static void MoveNextCallBack(object state) { }

	[Address(RVA = "0x100A2A0", Offset = "0x10096A0", Length = "0xBD")]
	[CompilerGenerated]
	[Token(Token = "0x6000260")]
	protected void set_Current(TResult value) { }

	[Address(RVA = "0x100A360", Offset = "0x1009760", Length = "0xBD")]
	[CompilerGenerated]
	[Token(Token = "0x600025B")]
	private void set_SourceCurrent(TSource value) { }

	[Address(RVA = "0x1008E80", Offset = "0x1008280", Length = "0x3F1")]
	[Token(Token = "0x6000266")]
	private static void SetCurrentCallBack(object state) { }

	[Address(RVA = "0x1009280", Offset = "0x1008680", Length = "0x4F5")]
	[Token(Token = "0x6000262")]
	protected void SourceMoveNext() { }

	[Token(Token = "0x6000258")]
	protected abstract UniTask<TAwait> TransformAsync(TSource sourceCurrent) { }

	[Address(RVA = "0x1009780", Offset = "0x1008B80", Length = "0x42E")]
	[Token(Token = "0x6000263")]
	private ValueTuple<Boolean, Boolean> TryMoveNextCore(bool sourceHasCurrent, out bool result) { }

	[Token(Token = "0x6000259")]
	protected abstract bool TrySetCurrentCore(TAwait awaitResult, out bool terminateIteration) { }

	[Address(RVA = "0x1009BB0", Offset = "0x1008FB0", Length = "0x2B1")]
	[Token(Token = "0x6000264")]
	protected bool UnwarapTask(UniTask<TAwait> taskResult, out TAwait result) { }

	[Address(RVA = "0x1009E70", Offset = "0x1009270", Length = "0x50")]
	[Token(Token = "0x600025D")]
	protected ValueTuple<Boolean, Boolean> WaitAwaitCallback(out bool moveNextResult) { }

}

