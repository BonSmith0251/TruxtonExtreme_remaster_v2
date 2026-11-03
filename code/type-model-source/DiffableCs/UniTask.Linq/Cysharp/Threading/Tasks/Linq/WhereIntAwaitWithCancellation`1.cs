namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000224")]
internal sealed class WhereIntAwaitWithCancellation : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x2000225")]
	private sealed class _WhereAwaitWithCancellation : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001408")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001409")]
		private readonly Func<TSource, Int32, CancellationToken, UniTask`1<Boolean>> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400140A")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400140B")]
		private int state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400140C")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400140D")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400140E")]
		private Awaiter<Boolean> awaiter2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400140F")]
		private Action moveNextAction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001410")]
		private int index; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001411")]
		private TSource <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700005A")]
		public private override TSource Current
		{
			[Address(RVA = "0x160BAF0", Offset = "0x160AEF0", Length = "0xAF")]
			[CompilerGenerated]
			[Token(Token = "0x600093D")]
			 get { } //Length: 175
			[Address(RVA = "0x160BC60", Offset = "0x160B060", Length = "0xBC")]
			[CompilerGenerated]
			[Token(Token = "0x600093E")]
			private set { } //Length: 188
		}

		[Address(RVA = "0x1627460", Offset = "0x1626860", Length = "0x1E2")]
		[Token(Token = "0x600093C")]
		public _WhereAwaitWithCancellation(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, CancellationToken, UniTask`1<Boolean>> predicate, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1625690", Offset = "0x1624A90", Length = "0xED")]
		[Token(Token = "0x6000941")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x160BAF0", Offset = "0x160AEF0", Length = "0xAF")]
		[CompilerGenerated]
		[Token(Token = "0x600093D")]
		public override TSource get_Current() { }

		[Address(RVA = "0x1626740", Offset = "0x1625B40", Length = "0xD16")]
		[Token(Token = "0x6000940")]
		private void MoveNext() { }

		[Address(RVA = "0x1625960", Offset = "0x1624D60", Length = "0xE3")]
		[Token(Token = "0x600093F")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x160BC60", Offset = "0x160B060", Length = "0xBC")]
		[CompilerGenerated]
		[Token(Token = "0x600093E")]
		private void set_Current(TSource value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001406")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001407")]
	private readonly Func<TSource, Int32, CancellationToken, UniTask`1<Boolean>> predicate; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x600093A")]
	public WhereIntAwaitWithCancellation`1(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, CancellationToken, UniTask`1<Boolean>> predicate) { }

	[Address(RVA = "0xF59060", Offset = "0xF58460", Length = "0x97")]
	[Token(Token = "0x600093B")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

