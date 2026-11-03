namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200002E")]
internal abstract class AsyncEnumeratorBase : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
{
	[Token(Token = "0x4000105")]
	private static readonly Action<Object> moveNextCallbackDelegate; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000106")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000107")]
	protected CancellationToken cancellationToken; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000108")]
	private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000109")]
	private Awaiter<Boolean> sourceMoveNext; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400010A")]
	private TResult <Current>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000003")]
	public override TResult Current
	{
		[Address(RVA = "0x100B0F0", Offset = "0x100A4F0", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x600024F")]
		 get { } //Length: 176
		[Address(RVA = "0x100B280", Offset = "0x100A680", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x6000250")]
		 set { } //Length: 189
	}

	[Token(Token = "0x17000002")]
	protected TSource SourceCurrent
	{
		[Address(RVA = "0x100B1A0", Offset = "0x100A5A0", Length = "0xDF")]
		[Token(Token = "0x600024E")]
		 get { } //Length: 223
	}

	[Address(RVA = "0x100AF30", Offset = "0x100A330", Length = "0xEA")]
	[Token(Token = "0x6000256")]
	private static AsyncEnumeratorBase`2() { }

	[Address(RVA = "0x100B020", Offset = "0x100A420", Length = "0xCB")]
	[Token(Token = "0x600024C")]
	public AsyncEnumeratorBase`2(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x100A420", Offset = "0x1009820", Length = "0x11B")]
	[Token(Token = "0x6000255")]
	public override UniTask DisposeAsync() { }

	[Address(RVA = "0x100B0F0", Offset = "0x100A4F0", Length = "0xB0")]
	[CompilerGenerated]
	[Token(Token = "0x600024F")]
	public override TResult get_Current() { }

	[Address(RVA = "0x100B1A0", Offset = "0x100A5A0", Length = "0xDF")]
	[Token(Token = "0x600024E")]
	protected TSource get_SourceCurrent() { }

	[Address(RVA = "0x100A540", Offset = "0x1009940", Length = "0x1D3")]
	[Token(Token = "0x6000251")]
	public override UniTask<Boolean> MoveNextAsync() { }

	[Address(RVA = "0x100A720", Offset = "0x1009B20", Length = "0x284")]
	[Token(Token = "0x6000254")]
	private static void MoveNextCallBack(object state) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000252")]
	protected override bool OnFirstIteration() { }

	[Address(RVA = "0x100B280", Offset = "0x100A680", Length = "0xBD")]
	[CompilerGenerated]
	[Token(Token = "0x6000250")]
	protected void set_Current(TResult value) { }

	[Address(RVA = "0x100A9B0", Offset = "0x1009DB0", Length = "0x576")]
	[Token(Token = "0x6000253")]
	protected void SourceMoveNext() { }

	[Token(Token = "0x600024D")]
	protected abstract bool TryMoveNextCore(bool sourceHasCurrent, out bool result) { }

}

