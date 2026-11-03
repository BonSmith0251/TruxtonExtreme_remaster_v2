namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000A6")]
internal sealed class DistinctUntilChanged : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x20000A7")]
	private sealed class _DistinctUntilChanged : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007F9")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007FA")]
		private readonly Func<TSource, TKey> keySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007FB")]
		private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007FC")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007FD")]
		private int state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007FE")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007FF")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000800")]
		private Action moveNextAction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000801")]
		private TKey prev; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000802")]
		private TSource <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700001A")]
		public private override TSource Current
		{
			[Address(RVA = "0x15F6320", Offset = "0x15F5720", Length = "0xAF")]
			[CompilerGenerated]
			[Token(Token = "0x6000452")]
			 get { } //Length: 175
			[Address(RVA = "0x15F6490", Offset = "0x15F5890", Length = "0xBC")]
			[CompilerGenerated]
			[Token(Token = "0x6000453")]
			private set { } //Length: 188
		}

		[Address(RVA = "0x15F5E40", Offset = "0x15F5240", Length = "0x231")]
		[Token(Token = "0x6000451")]
		public _DistinctUntilChanged(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15F4030", Offset = "0x15F3430", Length = "0xF0")]
		[Token(Token = "0x6000456")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x15F6320", Offset = "0x15F5720", Length = "0xAF")]
		[CompilerGenerated]
		[Token(Token = "0x6000452")]
		public override TSource get_Current() { }

		[Address(RVA = "0x15F4400", Offset = "0x15F3800", Length = "0xDE6")]
		[Token(Token = "0x6000455")]
		private void MoveNext() { }

		[Address(RVA = "0x15F4220", Offset = "0x15F3620", Length = "0xE3")]
		[Token(Token = "0x6000454")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x15F6490", Offset = "0x15F5890", Length = "0xBC")]
		[CompilerGenerated]
		[Token(Token = "0x6000453")]
		private void set_Current(TSource value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007F6")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007F7")]
	private readonly Func<TSource, TKey> keySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007F8")]
	private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0

	[Address(RVA = "0xA96E10", Offset = "0xA96210", Length = "0x6B")]
	[Token(Token = "0x600044F")]
	public DistinctUntilChanged`2(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0x1550FD0", Offset = "0x15503D0", Length = "0x9C")]
	[Token(Token = "0x6000450")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

