namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000177")]
internal sealed class SelectAwaitWithCancellation : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x2000178")]
	private sealed class _SelectAwaitWithCancellation : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EFF")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F00")]
		private readonly Func<TSource, CancellationToken, UniTask`1<TResult>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F01")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F02")]
		private int state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F03")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F04")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F05")]
		private Awaiter<TResult> awaiter2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F06")]
		private Action moveNextAction; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F07")]
		private TResult <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700003A")]
		public private override TResult Current
		{
			[Address(RVA = "0x160BA40", Offset = "0x160AE40", Length = "0xAF")]
			[CompilerGenerated]
			[Token(Token = "0x6000705")]
			 get { } //Length: 175
			[Address(RVA = "0x160BBA0", Offset = "0x160AFA0", Length = "0xBC")]
			[CompilerGenerated]
			[Token(Token = "0x6000706")]
			private set { } //Length: 188
		}

		[Address(RVA = "0x160B660", Offset = "0x160AA60", Length = "0x1E2")]
		[Token(Token = "0x6000704")]
		public _SelectAwaitWithCancellation(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<TResult>> selector, CancellationToken cancellationToken) { }

		[Address(RVA = "0x160A080", Offset = "0x1609480", Length = "0xED")]
		[Token(Token = "0x6000709")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x160BA40", Offset = "0x160AE40", Length = "0xAF")]
		[CompilerGenerated]
		[Token(Token = "0x6000705")]
		public override TResult get_Current() { }

		[Address(RVA = "0x160A440", Offset = "0x1609840", Length = "0x8CB")]
		[Token(Token = "0x6000708")]
		private void MoveNext() { }

		[Address(RVA = "0x160A350", Offset = "0x1609750", Length = "0xE3")]
		[Token(Token = "0x6000707")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x160BBA0", Offset = "0x160AFA0", Length = "0xBC")]
		[CompilerGenerated]
		[Token(Token = "0x6000706")]
		private void set_Current(TResult value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000EFD")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000EFE")]
	private readonly Func<TSource, CancellationToken, UniTask`1<TResult>> selector; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6000702")]
	public SelectAwaitWithCancellation`2(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<TResult>> selector) { }

	[Address(RVA = "0xF59060", Offset = "0xF58460", Length = "0x97")]
	[Token(Token = "0x6000703")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

