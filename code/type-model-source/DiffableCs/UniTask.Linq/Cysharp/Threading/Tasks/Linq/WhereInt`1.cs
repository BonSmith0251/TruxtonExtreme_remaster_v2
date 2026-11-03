namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200021C")]
internal sealed class WhereInt : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x200021D")]
	private sealed class _Where : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013DB")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013DC")]
		private readonly Func<TSource, Int32, Boolean> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013DD")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013DE")]
		private int state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013DF")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013E0")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013E1")]
		private Action moveNextAction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013E2")]
		private int index; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013E3")]
		private TSource <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000056")]
		public private override TSource Current
		{
			[Address(RVA = "0x160BA40", Offset = "0x160AE40", Length = "0xAF")]
			[CompilerGenerated]
			[Token(Token = "0x600091D")]
			 get { } //Length: 175
			[Address(RVA = "0x160BBA0", Offset = "0x160AFA0", Length = "0xBC")]
			[CompilerGenerated]
			[Token(Token = "0x600091E")]
			private set { } //Length: 188
		}

		[Address(RVA = "0x16254A0", Offset = "0x16248A0", Length = "0x1E2")]
		[Token(Token = "0x600091C")]
		public _Where(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, Boolean> predicate, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1623D00", Offset = "0x1623100", Length = "0xED")]
		[Token(Token = "0x6000921")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x160BA40", Offset = "0x160AE40", Length = "0xAF")]
		[CompilerGenerated]
		[Token(Token = "0x600091D")]
		public override TSource get_Current() { }

		[Address(RVA = "0x1623FD0", Offset = "0x16233D0", Length = "0x9C8")]
		[Token(Token = "0x6000920")]
		private void MoveNext() { }

		[Address(RVA = "0x1623EE0", Offset = "0x16232E0", Length = "0xE3")]
		[Token(Token = "0x600091F")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x160BBA0", Offset = "0x160AFA0", Length = "0xBC")]
		[CompilerGenerated]
		[Token(Token = "0x600091E")]
		private void set_Current(TSource value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013D9")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40013DA")]
	private readonly Func<TSource, Int32, Boolean> predicate; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x600091A")]
	public WhereInt`1(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, Boolean> predicate) { }

	[Address(RVA = "0xF59060", Offset = "0xF58460", Length = "0x97")]
	[Token(Token = "0x600091B")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

