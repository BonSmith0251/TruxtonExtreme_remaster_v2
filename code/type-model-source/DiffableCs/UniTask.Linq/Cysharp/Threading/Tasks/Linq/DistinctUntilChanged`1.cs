namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000A4")]
internal sealed class DistinctUntilChanged : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x20000A5")]
	private sealed class _DistinctUntilChanged : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007EE")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007EF")]
		private readonly IEqualityComparer<TSource> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007F0")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007F1")]
		private int state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007F2")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007F3")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007F4")]
		private Action moveNextAction; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007F5")]
		private TSource <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000019")]
		public private override TSource Current
		{
			[Address(RVA = "0x15F6270", Offset = "0x15F5670", Length = "0xAF")]
			[CompilerGenerated]
			[Token(Token = "0x600044A")]
			 get { } //Length: 175
			[Address(RVA = "0x15F63D0", Offset = "0x15F57D0", Length = "0xBC")]
			[CompilerGenerated]
			[Token(Token = "0x600044B")]
			private set { } //Length: 188
		}

		[Address(RVA = "0x15F6080", Offset = "0x15F5480", Length = "0x1E2")]
		[Token(Token = "0x6000449")]
		public _DistinctUntilChanged(IUniTaskAsyncEnumerable<TSource> source, IEqualityComparer<TSource> comparer, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15F4130", Offset = "0x15F3530", Length = "0xED")]
		[Token(Token = "0x600044E")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x15F6270", Offset = "0x15F5670", Length = "0xAF")]
		[CompilerGenerated]
		[Token(Token = "0x600044A")]
		public override TSource get_Current() { }

		[Address(RVA = "0x15F51F0", Offset = "0x15F45F0", Length = "0xC45")]
		[Token(Token = "0x600044D")]
		private void MoveNext() { }

		[Address(RVA = "0x15F4310", Offset = "0x15F3710", Length = "0xE3")]
		[Token(Token = "0x600044C")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x15F63D0", Offset = "0x15F57D0", Length = "0xBC")]
		[CompilerGenerated]
		[Token(Token = "0x600044B")]
		private void set_Current(TSource value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007EC")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007ED")]
	private readonly IEqualityComparer<TSource> comparer; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6000447")]
	public DistinctUntilChanged`1(IUniTaskAsyncEnumerable<TSource> source, IEqualityComparer<TSource> comparer) { }

	[Address(RVA = "0xF59060", Offset = "0xF58460", Length = "0x97")]
	[Token(Token = "0x6000448")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

