namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000A8")]
internal sealed class DistinctUntilChangedAwait : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x20000A9")]
	private sealed class _DistinctUntilChangedAwait : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000806")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000807")]
		private readonly Func<TSource, UniTask`1<TKey>> keySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000808")]
		private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000809")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400080A")]
		private int state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400080B")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400080C")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400080D")]
		private Awaiter<TKey> awaiter2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400080E")]
		private Action moveNextAction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400080F")]
		private TSource enumeratorCurrent; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000810")]
		private TKey prev; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000811")]
		private TSource <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700001B")]
		public private override TSource Current
		{
			[Address(RVA = "0x15F29C0", Offset = "0x15F1DC0", Length = "0xAF")]
			[CompilerGenerated]
			[Token(Token = "0x600045A")]
			 get { } //Length: 175
			[Address(RVA = "0x15F2A70", Offset = "0x15F1E70", Length = "0xBC")]
			[CompilerGenerated]
			[Token(Token = "0x600045B")]
			private set { } //Length: 188
		}

		[Address(RVA = "0x15F3DF0", Offset = "0x15F31F0", Length = "0x231")]
		[Token(Token = "0x6000459")]
		public _DistinctUntilChangedAwait(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<TKey>> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15F2B30", Offset = "0x15F1F30", Length = "0xF0")]
		[Token(Token = "0x600045E")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x15F29C0", Offset = "0x15F1DC0", Length = "0xAF")]
		[CompilerGenerated]
		[Token(Token = "0x600045A")]
		public override TSource get_Current() { }

		[Address(RVA = "0x15F2D20", Offset = "0x15F2120", Length = "0x298")]
		[Token(Token = "0x600045D")]
		private void MoveNext() { }

		[Address(RVA = "0x15F2C30", Offset = "0x15F2030", Length = "0xE3")]
		[Token(Token = "0x600045C")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x15F2A70", Offset = "0x15F1E70", Length = "0xBC")]
		[CompilerGenerated]
		[Token(Token = "0x600045B")]
		private void set_Current(TSource value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000803")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000804")]
	private readonly Func<TSource, UniTask`1<TKey>> keySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000805")]
	private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0

	[Address(RVA = "0xA96E10", Offset = "0xA96210", Length = "0x6B")]
	[Token(Token = "0x6000457")]
	public DistinctUntilChangedAwait`2(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<TKey>> keySelector, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0x1550FD0", Offset = "0x15503D0", Length = "0x9C")]
	[Token(Token = "0x6000458")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

