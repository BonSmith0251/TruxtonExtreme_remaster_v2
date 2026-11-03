namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000175")]
internal sealed class SelectIntAwait : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x2000176")]
	private sealed class _SelectAwait : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EF3")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EF4")]
		private readonly Func<TSource, Int32, UniTask`1<TResult>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EF5")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EF6")]
		private int state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EF7")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EF8")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EF9")]
		private Awaiter<TResult> awaiter2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EFA")]
		private Action moveNextAction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EFB")]
		private int index; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EFC")]
		private TResult <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000039")]
		public private override TResult Current
		{
			[Address(RVA = "0x160BAF0", Offset = "0x160AEF0", Length = "0xAF")]
			[CompilerGenerated]
			[Token(Token = "0x60006FD")]
			 get { } //Length: 175
			[Address(RVA = "0x160BC60", Offset = "0x160B060", Length = "0xBC")]
			[CompilerGenerated]
			[Token(Token = "0x60006FE")]
			private set { } //Length: 188
		}

		[Address(RVA = "0x160D490", Offset = "0x160C890", Length = "0x1E2")]
		[Token(Token = "0x60006FC")]
		public _SelectAwait(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, UniTask`1<TResult>> selector, CancellationToken cancellationToken) { }

		[Address(RVA = "0x160BE10", Offset = "0x160B210", Length = "0xED")]
		[Token(Token = "0x6000701")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x160BAF0", Offset = "0x160AEF0", Length = "0xAF")]
		[CompilerGenerated]
		[Token(Token = "0x60006FD")]
		public override TResult get_Current() { }

		[Address(RVA = "0x160C980", Offset = "0x160BD80", Length = "0x914")]
		[Token(Token = "0x6000700")]
		private void MoveNext() { }

		[Address(RVA = "0x160BF00", Offset = "0x160B300", Length = "0xE3")]
		[Token(Token = "0x60006FF")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x160BC60", Offset = "0x160B060", Length = "0xBC")]
		[CompilerGenerated]
		[Token(Token = "0x60006FE")]
		private void set_Current(TResult value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000EF1")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000EF2")]
	private readonly Func<TSource, Int32, UniTask`1<TResult>> selector; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x60006FA")]
	public SelectIntAwait`2(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, UniTask`1<TResult>> selector) { }

	[Address(RVA = "0xF59060", Offset = "0xF58460", Length = "0x97")]
	[Token(Token = "0x60006FB")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

