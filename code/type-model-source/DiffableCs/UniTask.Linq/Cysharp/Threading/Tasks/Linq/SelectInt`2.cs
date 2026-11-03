namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000171")]
internal sealed class SelectInt : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x2000172")]
	private sealed class _Select : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EDD")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EDE")]
		private readonly Func<TSource, Int32, TResult> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EDF")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EE0")]
		private int state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EE1")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EE2")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EE3")]
		private Action moveNextAction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EE4")]
		private int index; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EE5")]
		private TResult <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000037")]
		public private override TResult Current
		{
			[Address(RVA = "0x160BA40", Offset = "0x160AE40", Length = "0xAF")]
			[CompilerGenerated]
			[Token(Token = "0x60006ED")]
			 get { } //Length: 175
			[Address(RVA = "0x160BBA0", Offset = "0x160AFA0", Length = "0xBC")]
			[CompilerGenerated]
			[Token(Token = "0x60006EE")]
			private set { } //Length: 188
		}

		[Address(RVA = "0x1615840", Offset = "0x1614C40", Length = "0x1E2")]
		[Token(Token = "0x60006EC")]
		public _Select(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, TResult> selector, CancellationToken cancellationToken) { }

		[Address(RVA = "0x16146A0", Offset = "0x1613AA0", Length = "0xED")]
		[Token(Token = "0x60006F1")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x160BA40", Offset = "0x160AE40", Length = "0xAF")]
		[CompilerGenerated]
		[Token(Token = "0x60006ED")]
		public override TResult get_Current() { }

		[Address(RVA = "0x1614A60", Offset = "0x1613E60", Length = "0x718")]
		[Token(Token = "0x60006F0")]
		private void MoveNext() { }

		[Address(RVA = "0x1614970", Offset = "0x1613D70", Length = "0xE3")]
		[Token(Token = "0x60006EF")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x160BBA0", Offset = "0x160AFA0", Length = "0xBC")]
		[CompilerGenerated]
		[Token(Token = "0x60006EE")]
		private void set_Current(TResult value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000EDB")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000EDC")]
	private readonly Func<TSource, Int32, TResult> selector; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x60006EA")]
	public SelectInt`2(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, TResult> selector) { }

	[Address(RVA = "0xF59060", Offset = "0xF58460", Length = "0x97")]
	[Token(Token = "0x60006EB")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

