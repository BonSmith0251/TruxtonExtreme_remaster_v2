namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000AC")]
internal sealed class Do : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x20000AD")]
	private sealed class _Do : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
	{
		[Token(Token = "0x4000825")]
		private static readonly Action<Object> MoveNextCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000826")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000827")]
		private readonly Action<TSource> onNext; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000828")]
		private readonly Action<Exception> onError; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000829")]
		private readonly Action onCompleted; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400082A")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400082B")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400082C")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400082D")]
		private TSource <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700001D")]
		public private override TSource Current
		{
			[Address(RVA = "0x100A140", Offset = "0x1009540", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x600046A")]
			 get { } //Length: 176
			[Address(RVA = "0x100A2A0", Offset = "0x10096A0", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x600046B")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x15F78D0", Offset = "0x15F6CD0", Length = "0xEA")]
		[Token(Token = "0x6000471")]
		private static _Do() { }

		[Address(RVA = "0x15F79C0", Offset = "0x15F6DC0", Length = "0x1AE")]
		[Token(Token = "0x6000469")]
		public _Do(IUniTaskAsyncEnumerable<TSource> source, Action<TSource> onNext, Action<Exception> onError, Action onCompleted, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15F6B30", Offset = "0x15F5F30", Length = "0xE7")]
		[Token(Token = "0x600046D")]
		private void CallTrySetExceptionAfterNotification(Exception ex) { }

		[Address(RVA = "0x15F6C20", Offset = "0x15F6020", Length = "0x12B")]
		[Token(Token = "0x6000470")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x100A140", Offset = "0x1009540", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x600046A")]
		public override TSource get_Current() { }

		[Address(RVA = "0x15F6D50", Offset = "0x15F6150", Length = "0x58B")]
		[Token(Token = "0x600046C")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x15F72E0", Offset = "0x15F66E0", Length = "0x5E8")]
		[Token(Token = "0x600046F")]
		private static void MoveNextCore(object state) { }

		[Address(RVA = "0x100A2A0", Offset = "0x10096A0", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x600046B")]
		private void set_Current(TSource value) { }

		[Address(RVA = "0x6EAA30", Offset = "0x6E9E30", Length = "0x10B")]
		[Token(Token = "0x600046E")]
		private bool TryGetResultWithNotification(Awaiter<T> awaiter, out T result) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000821")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000822")]
	private readonly Action<TSource> onNext; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000823")]
	private readonly Action<Exception> onError; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000824")]
	private readonly Action onCompleted; //Field offset: 0x0

	[Address(RVA = "0x16D8BC0", Offset = "0x16D7FC0", Length = "0x7D")]
	[Token(Token = "0x6000467")]
	public Do`1(IUniTaskAsyncEnumerable<TSource> source, Action<TSource> onNext, Action<Exception> onError, Action onCompleted) { }

	[Address(RVA = "0x193CE60", Offset = "0x193C260", Length = "0xB1")]
	[Token(Token = "0x6000468")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

