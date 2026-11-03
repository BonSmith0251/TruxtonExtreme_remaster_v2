namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000C0")]
internal sealed class GroupBy : IUniTaskAsyncEnumerable<IGrouping`2<TKey, TElement>>
{
	[Token(Token = "0x20000C1")]
	private sealed class _GroupBy : MoveNextSource, IUniTaskAsyncEnumerator<IGrouping`2<TKey, TElement>>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x20000C2")]
		private struct <CreateLookup>d__12 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40008C0")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40008C1")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40008C2")]
			public _GroupBy<TSource, TKey, TElement> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40008C3")]
			private Awaiter<ILookup<TKey, TElement>> <>u__1; //Field offset: 0x0

			[Address(RVA = "0x11527A0", Offset = "0x1151BA0", Length = "0x453")]
			[Token(Token = "0x60004AB")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x60004AC")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008B9")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008BA")]
		private readonly Func<TSource, TKey> keySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008BB")]
		private readonly Func<TSource, TElement> elementSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008BC")]
		private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008BD")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008BE")]
		private IEnumerator<IGrouping`2<TKey, TElement>> groupEnumerator; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008BF")]
		private IGrouping<TKey, TElement> <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700001F")]
		public private override IGrouping<TKey, TElement> Current
		{
			[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60004A5")]
			 get { } //Length: 5
			[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60004A6")]
			private set { } //Length: 13
		}

		[Address(RVA = "0x15FAEC0", Offset = "0x15FA2C0", Length = "0x91")]
		[Token(Token = "0x60004A4")]
		public _GroupBy(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15FA070", Offset = "0x15F9470", Length = "0x7F")]
		[AsyncStateMachine(typeof(<CreateLookup>d__12))]
		[Token(Token = "0x60004A8")]
		private UniTaskVoid CreateLookup() { }

		[Address(RVA = "0x15FC060", Offset = "0x15FB460", Length = "0x5F")]
		[Token(Token = "0x60004AA")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60004A5")]
		public override IGrouping<TKey, TElement> get_Current() { }

		[Address(RVA = "0x15FC2F0", Offset = "0x15FB6F0", Length = "0x119")]
		[Token(Token = "0x60004A7")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60004A6")]
		private void set_Current(IGrouping<TKey, TElement> value) { }

		[Address(RVA = "0x15FC410", Offset = "0x15FB810", Length = "0x11F")]
		[Token(Token = "0x60004A9")]
		private void SourceMoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008B5")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008B6")]
	private readonly Func<TSource, TKey> keySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008B7")]
	private readonly Func<TSource, TElement> elementSelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008B8")]
	private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0

	[Address(RVA = "0x16D8BC0", Offset = "0x16D7FC0", Length = "0x7D")]
	[Token(Token = "0x60004A2")]
	public GroupBy`3(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0xF59100", Offset = "0xF58500", Length = "0xB1")]
	[Token(Token = "0x60004A3")]
	public override IUniTaskAsyncEnumerator<IGrouping`2<TKey, TElement>> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

