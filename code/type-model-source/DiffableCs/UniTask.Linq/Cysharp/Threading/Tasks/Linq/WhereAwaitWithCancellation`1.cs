namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000222")]
internal sealed class WhereAwaitWithCancellation : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x2000223")]
	private sealed class _WhereAwaitWithCancellation : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013FD")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013FE")]
		private readonly Func<TSource, CancellationToken, UniTask`1<Boolean>> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013FF")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001400")]
		private int state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001401")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001402")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001403")]
		private Awaiter<Boolean> awaiter2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001404")]
		private Action moveNextAction; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001405")]
		private TSource <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000059")]
		public private override TSource Current
		{
			[Address(RVA = "0x160BA40", Offset = "0x160AE40", Length = "0xAF")]
			[CompilerGenerated]
			[Token(Token = "0x6000935")]
			 get { } //Length: 175
			[Address(RVA = "0x160BBA0", Offset = "0x160AFA0", Length = "0xBC")]
			[CompilerGenerated]
			[Token(Token = "0x6000936")]
			private set { } //Length: 188
		}

		[Address(RVA = "0x1627650", Offset = "0x1626A50", Length = "0x1E2")]
		[Token(Token = "0x6000934")]
		public _WhereAwaitWithCancellation(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Boolean>> predicate, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1625780", Offset = "0x1624B80", Length = "0xED")]
		[Token(Token = "0x6000939")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x160BA40", Offset = "0x160AE40", Length = "0xAF")]
		[CompilerGenerated]
		[Token(Token = "0x6000935")]
		public override TSource get_Current() { }

		[Address(RVA = "0x1625A50", Offset = "0x1624E50", Length = "0xCE3")]
		[Token(Token = "0x6000938")]
		private void MoveNext() { }

		[Address(RVA = "0x1625870", Offset = "0x1624C70", Length = "0xE3")]
		[Token(Token = "0x6000937")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x160BBA0", Offset = "0x160AFA0", Length = "0xBC")]
		[CompilerGenerated]
		[Token(Token = "0x6000936")]
		private void set_Current(TSource value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013FB")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013FC")]
	private readonly Func<TSource, CancellationToken, UniTask`1<Boolean>> predicate; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6000932")]
	public WhereAwaitWithCancellation`1(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Boolean>> predicate) { }

	[Address(RVA = "0xF59060", Offset = "0xF58460", Length = "0x97")]
	[Token(Token = "0x6000933")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

