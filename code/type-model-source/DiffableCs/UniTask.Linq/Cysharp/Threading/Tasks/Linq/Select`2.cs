namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200016F")]
internal sealed class Select : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x2000170")]
	private sealed class _Select : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ED3")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ED4")]
		private readonly Func<TSource, TResult> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ED5")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ED6")]
		private int state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ED7")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ED8")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ED9")]
		private Action moveNextAction; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EDA")]
		private TResult <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000036")]
		public private override TResult Current
		{
			[Address(RVA = "0x15F6270", Offset = "0x15F5670", Length = "0xAF")]
			[CompilerGenerated]
			[Token(Token = "0x60006E5")]
			 get { } //Length: 175
			[Address(RVA = "0x15F63D0", Offset = "0x15F57D0", Length = "0xBC")]
			[CompilerGenerated]
			[Token(Token = "0x60006E6")]
			private set { } //Length: 188
		}

		[Address(RVA = "0x1615A30", Offset = "0x1614E30", Length = "0x1E2")]
		[Token(Token = "0x60006E4")]
		public _Select(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TResult> selector, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1614790", Offset = "0x1613B90", Length = "0xED")]
		[Token(Token = "0x60006E9")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x15F6270", Offset = "0x15F5670", Length = "0xAF")]
		[CompilerGenerated]
		[Token(Token = "0x60006E5")]
		public override TResult get_Current() { }

		[Address(RVA = "0x1615180", Offset = "0x1614580", Length = "0x6BD")]
		[Token(Token = "0x60006E8")]
		private void MoveNext() { }

		[Address(RVA = "0x1614880", Offset = "0x1613C80", Length = "0xE3")]
		[Token(Token = "0x60006E7")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x15F63D0", Offset = "0x15F57D0", Length = "0xBC")]
		[CompilerGenerated]
		[Token(Token = "0x60006E6")]
		private void set_Current(TResult value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000ED1")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000ED2")]
	private readonly Func<TSource, TResult> selector; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x60006E2")]
	public Select`2(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TResult> selector) { }

	[Address(RVA = "0xF59060", Offset = "0xF58460", Length = "0x97")]
	[Token(Token = "0x60006E3")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

