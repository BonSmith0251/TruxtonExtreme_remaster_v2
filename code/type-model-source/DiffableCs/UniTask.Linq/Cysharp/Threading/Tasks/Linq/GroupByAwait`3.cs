namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000C6")]
internal sealed class GroupByAwait : IUniTaskAsyncEnumerable<IGrouping`2<TKey, TElement>>
{
	[Token(Token = "0x20000C7")]
	private sealed class _GroupByAwait : MoveNextSource, IUniTaskAsyncEnumerator<IGrouping`2<TKey, TElement>>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x20000C8")]
		private struct <CreateLookup>d__12 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40008E0")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40008E1")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40008E2")]
			public _GroupByAwait<TSource, TKey, TElement> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40008E3")]
			private Awaiter<ILookup<TKey, TElement>> <>u__1; //Field offset: 0x0

			[Address(RVA = "0x11527A0", Offset = "0x1151BA0", Length = "0x453")]
			[Token(Token = "0x60004C1")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x60004C2")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008D9")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008DA")]
		private readonly Func<TSource, UniTask`1<TKey>> keySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008DB")]
		private readonly Func<TSource, UniTask`1<TElement>> elementSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008DC")]
		private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008DD")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008DE")]
		private IEnumerator<IGrouping`2<TKey, TElement>> groupEnumerator; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008DF")]
		private IGrouping<TKey, TElement> <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000021")]
		public private override IGrouping<TKey, TElement> Current
		{
			[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60004BB")]
			 get { } //Length: 5
			[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60004BC")]
			private set { } //Length: 13
		}

		[Address(RVA = "0x15FAEC0", Offset = "0x15FA2C0", Length = "0x91")]
		[Token(Token = "0x60004BA")]
		public _GroupByAwait(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<TKey>> keySelector, Func<TSource, UniTask`1<TElement>> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15FA070", Offset = "0x15F9470", Length = "0x7F")]
		[AsyncStateMachine(typeof(<CreateLookup>d__12))]
		[Token(Token = "0x60004BE")]
		private UniTaskVoid CreateLookup() { }

		[Address(RVA = "0x15FB2D0", Offset = "0x15FA6D0", Length = "0x5F")]
		[Token(Token = "0x60004C0")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60004BB")]
		public override IGrouping<TKey, TElement> get_Current() { }

		[Address(RVA = "0x15FB3F0", Offset = "0x15FA7F0", Length = "0x119")]
		[Token(Token = "0x60004BD")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60004BC")]
		private void set_Current(IGrouping<TKey, TElement> value) { }

		[Address(RVA = "0x15FB970", Offset = "0x15FAD70", Length = "0x11F")]
		[Token(Token = "0x60004BF")]
		private void SourceMoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008D5")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008D6")]
	private readonly Func<TSource, UniTask`1<TKey>> keySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008D7")]
	private readonly Func<TSource, UniTask`1<TElement>> elementSelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008D8")]
	private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0

	[Address(RVA = "0x16D8BC0", Offset = "0x16D7FC0", Length = "0x7D")]
	[Token(Token = "0x60004B8")]
	public GroupByAwait`3(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<TKey>> keySelector, Func<TSource, UniTask`1<TElement>> elementSelector, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0xF59100", Offset = "0xF58500", Length = "0xB1")]
	[Token(Token = "0x60004B9")]
	public override IUniTaskAsyncEnumerator<IGrouping`2<TKey, TElement>> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

