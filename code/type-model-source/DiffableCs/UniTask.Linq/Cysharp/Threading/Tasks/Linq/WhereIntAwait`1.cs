namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000220")]
internal sealed class WhereIntAwait : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x2000221")]
	private sealed class _WhereAwait : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013F1")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013F2")]
		private readonly Func<TSource, Int32, UniTask`1<Boolean>> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013F3")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013F4")]
		private int state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013F5")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013F6")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013F7")]
		private Awaiter<Boolean> awaiter2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013F8")]
		private Action moveNextAction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013F9")]
		private int index; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013FA")]
		private TSource <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000058")]
		public private override TSource Current
		{
			[Address(RVA = "0x160BAF0", Offset = "0x160AEF0", Length = "0xAF")]
			[CompilerGenerated]
			[Token(Token = "0x600092D")]
			 get { } //Length: 175
			[Address(RVA = "0x160BC60", Offset = "0x160B060", Length = "0xBC")]
			[CompilerGenerated]
			[Token(Token = "0x600092E")]
			private set { } //Length: 188
		}

		[Address(RVA = "0x1623A20", Offset = "0x1622E20", Length = "0x1E2")]
		[Token(Token = "0x600092C")]
		public _WhereAwait(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, UniTask`1<Boolean>> predicate, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1621D80", Offset = "0x1621180", Length = "0xED")]
		[Token(Token = "0x6000931")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x160BAF0", Offset = "0x160AEF0", Length = "0xAF")]
		[CompilerGenerated]
		[Token(Token = "0x600092D")]
		public override TSource get_Current() { }

		[Address(RVA = "0x1622050", Offset = "0x1621450", Length = "0xC0A")]
		[Token(Token = "0x6000930")]
		private void MoveNext() { }

		[Address(RVA = "0x1621F60", Offset = "0x1621360", Length = "0xE3")]
		[Token(Token = "0x600092F")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x160BC60", Offset = "0x160B060", Length = "0xBC")]
		[CompilerGenerated]
		[Token(Token = "0x600092E")]
		private void set_Current(TSource value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013EF")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013F0")]
	private readonly Func<TSource, Int32, UniTask`1<Boolean>> predicate; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x600092A")]
	public WhereIntAwait`1(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, UniTask`1<Boolean>> predicate) { }

	[Address(RVA = "0xF59060", Offset = "0xF58460", Length = "0x97")]
	[Token(Token = "0x600092B")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

