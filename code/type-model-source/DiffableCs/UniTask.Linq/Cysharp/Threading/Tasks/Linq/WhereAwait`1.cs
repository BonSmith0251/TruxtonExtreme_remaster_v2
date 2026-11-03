namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200021E")]
internal sealed class WhereAwait : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x200021F")]
	private sealed class _WhereAwait : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013E6")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013E7")]
		private readonly Func<TSource, UniTask`1<Boolean>> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013E8")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013E9")]
		private int state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013EA")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013EB")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013EC")]
		private Awaiter<Boolean> awaiter2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013ED")]
		private Action moveNextAction; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013EE")]
		private TSource <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000057")]
		public private override TSource Current
		{
			[Address(RVA = "0x160BA40", Offset = "0x160AE40", Length = "0xAF")]
			[CompilerGenerated]
			[Token(Token = "0x6000925")]
			 get { } //Length: 175
			[Address(RVA = "0x160BBA0", Offset = "0x160AFA0", Length = "0xBC")]
			[CompilerGenerated]
			[Token(Token = "0x6000926")]
			private set { } //Length: 188
		}

		[Address(RVA = "0x1623830", Offset = "0x1622C30", Length = "0x1E2")]
		[Token(Token = "0x6000924")]
		public _WhereAwait(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Boolean>> predicate, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1621C90", Offset = "0x1621090", Length = "0xED")]
		[Token(Token = "0x6000929")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x160BA40", Offset = "0x160AE40", Length = "0xAF")]
		[CompilerGenerated]
		[Token(Token = "0x6000925")]
		public override TSource get_Current() { }

		[Address(RVA = "0x1622C60", Offset = "0x1622060", Length = "0xBC5")]
		[Token(Token = "0x6000928")]
		private void MoveNext() { }

		[Address(RVA = "0x1621E70", Offset = "0x1621270", Length = "0xE3")]
		[Token(Token = "0x6000927")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x160BBA0", Offset = "0x160AFA0", Length = "0xBC")]
		[CompilerGenerated]
		[Token(Token = "0x6000926")]
		private void set_Current(TSource value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013E4")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013E5")]
	private readonly Func<TSource, UniTask`1<Boolean>> predicate; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6000922")]
	public WhereAwait`1(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Boolean>> predicate) { }

	[Address(RVA = "0xF59060", Offset = "0xF58460", Length = "0x97")]
	[Token(Token = "0x6000923")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

