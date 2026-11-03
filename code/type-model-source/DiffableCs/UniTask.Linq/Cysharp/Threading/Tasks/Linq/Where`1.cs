namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200021A")]
internal sealed class Where : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x200021B")]
	private sealed class _Where : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013D1")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013D2")]
		private readonly Func<TSource, Boolean> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013D3")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013D4")]
		private int state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013D5")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013D6")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013D7")]
		private Action moveNextAction; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013D8")]
		private TSource <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000055")]
		public private override TSource Current
		{
			[Address(RVA = "0x15F6270", Offset = "0x15F5670", Length = "0xAF")]
			[CompilerGenerated]
			[Token(Token = "0x6000915")]
			 get { } //Length: 175
			[Address(RVA = "0x15F63D0", Offset = "0x15F57D0", Length = "0xBC")]
			[CompilerGenerated]
			[Token(Token = "0x6000916")]
			private set { } //Length: 188
		}

		[Address(RVA = "0x16252B0", Offset = "0x16246B0", Length = "0x1E2")]
		[Token(Token = "0x6000914")]
		public _Where(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Boolean> predicate, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1623C10", Offset = "0x1623010", Length = "0xED")]
		[Token(Token = "0x6000919")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x15F6270", Offset = "0x15F5670", Length = "0xAF")]
		[CompilerGenerated]
		[Token(Token = "0x6000915")]
		public override TSource get_Current() { }

		[Address(RVA = "0x16249A0", Offset = "0x1623DA0", Length = "0x90E")]
		[Token(Token = "0x6000918")]
		private void MoveNext() { }

		[Address(RVA = "0x1623DF0", Offset = "0x16231F0", Length = "0xE3")]
		[Token(Token = "0x6000917")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x15F63D0", Offset = "0x15F57D0", Length = "0xBC")]
		[CompilerGenerated]
		[Token(Token = "0x6000916")]
		private void set_Current(TSource value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013CF")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013D0")]
	private readonly Func<TSource, Boolean> predicate; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6000912")]
	public Where`1(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[Address(RVA = "0xF59060", Offset = "0xF58460", Length = "0x97")]
	[Token(Token = "0x6000913")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

