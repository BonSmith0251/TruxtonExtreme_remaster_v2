namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000CC")]
internal sealed class GroupByAwaitWithCancellation : IUniTaskAsyncEnumerable<IGrouping`2<TKey, TElement>>
{
	[Token(Token = "0x20000CD")]
	private sealed class _GroupByAwaitWithCancellation : MoveNextSource, IUniTaskAsyncEnumerator<IGrouping`2<TKey, TElement>>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x20000CE")]
		private struct <CreateLookup>d__12 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000902")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000903")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000904")]
			public _GroupByAwaitWithCancellation<TSource, TKey, TElement> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000905")]
			private Awaiter<ILookup<TKey, TElement>> <>u__1; //Field offset: 0x0

			[Address(RVA = "0x11527A0", Offset = "0x1151BA0", Length = "0x453")]
			[Token(Token = "0x60004D9")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x60004DA")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008FB")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008FC")]
		private readonly Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008FD")]
		private readonly Func<TSource, CancellationToken, UniTask`1<TElement>> elementSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008FE")]
		private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008FF")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000900")]
		private IEnumerator<IGrouping`2<TKey, TElement>> groupEnumerator; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000901")]
		private IGrouping<TKey, TElement> <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000023")]
		public private override IGrouping<TKey, TElement> Current
		{
			[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60004D3")]
			 get { } //Length: 5
			[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60004D4")]
			private set { } //Length: 13
		}

		[Address(RVA = "0x15FAEC0", Offset = "0x15FA2C0", Length = "0x91")]
		[Token(Token = "0x60004D2")]
		public _GroupByAwaitWithCancellation(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector, Func<TSource, CancellationToken, UniTask`1<TElement>> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15FA070", Offset = "0x15F9470", Length = "0x7F")]
		[AsyncStateMachine(typeof(<CreateLookup>d__12))]
		[Token(Token = "0x60004D6")]
		private UniTaskVoid CreateLookup() { }

		[Address(RVA = "0x15FA1B0", Offset = "0x15F95B0", Length = "0x5F")]
		[Token(Token = "0x60004D8")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60004D3")]
		public override IGrouping<TKey, TElement> get_Current() { }

		[Address(RVA = "0x15FA380", Offset = "0x15F9780", Length = "0x119")]
		[Token(Token = "0x60004D5")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60004D4")]
		private void set_Current(IGrouping<TKey, TElement> value) { }

		[Address(RVA = "0x15FAC90", Offset = "0x15FA090", Length = "0x11F")]
		[Token(Token = "0x60004D7")]
		private void SourceMoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008F7")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008F8")]
	private readonly Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008F9")]
	private readonly Func<TSource, CancellationToken, UniTask`1<TElement>> elementSelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008FA")]
	private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0

	[Address(RVA = "0x16D8BC0", Offset = "0x16D7FC0", Length = "0x7D")]
	[Token(Token = "0x60004D0")]
	public GroupByAwaitWithCancellation`3(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector, Func<TSource, CancellationToken, UniTask`1<TElement>> elementSelector, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0xF59100", Offset = "0xF58500", Length = "0xB1")]
	[Token(Token = "0x60004D1")]
	public override IUniTaskAsyncEnumerator<IGrouping`2<TKey, TElement>> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

