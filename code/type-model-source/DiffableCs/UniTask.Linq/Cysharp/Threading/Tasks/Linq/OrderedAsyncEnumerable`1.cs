namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000156")]
internal abstract class OrderedAsyncEnumerable : IUniTaskOrderedAsyncEnumerable<TElement>, IUniTaskAsyncEnumerable<TElement>
{
	[Token(Token = "0x2000157")]
	private class _OrderedAsyncEnumerator : MoveNextSource, IUniTaskAsyncEnumerator<TElement>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x2000158")]
		private struct <CreateSortSource>d__11 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E73")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E74")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E75")]
			public _OrderedAsyncEnumerator<TElement> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E76")]
			private Awaiter<TElement[]> <>u__1; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E77")]
			private Awaiter<Int32[]> <>u__2; //Field offset: 0x0

			[Address(RVA = "0x1153730", Offset = "0x1152B30", Length = "0xAF8")]
			[Token(Token = "0x6000693")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x6000694")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E6D")]
		protected readonly OrderedAsyncEnumerable<TElement> parent; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E6E")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E6F")]
		private TElement[] buffer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E70")]
		private Int32[] map; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E71")]
		private int index; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E72")]
		private TElement <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700002C")]
		public private override TElement Current
		{
			[Address(RVA = "0x1607750", Offset = "0x1606B50", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x600068E")]
			 get { } //Length: 176
			[Address(RVA = "0x1607800", Offset = "0x1606C00", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x600068F")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x1607680", Offset = "0x1606A80", Length = "0xC9")]
		[Token(Token = "0x600068D")]
		public _OrderedAsyncEnumerator(OrderedAsyncEnumerable<TElement> parent, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1607230", Offset = "0x1606630", Length = "0x8D")]
		[AsyncStateMachine(typeof(<CreateSortSource>d__11))]
		[Token(Token = "0x6000691")]
		private UniTaskVoid CreateSortSource() { }

		[Address(RVA = "0xA53C30", Offset = "0xA53030", Length = "0xA")]
		[Token(Token = "0x6000692")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x1607750", Offset = "0x1606B50", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x600068E")]
		public override TElement get_Current() { }

		[Address(RVA = "0x16072C0", Offset = "0x16066C0", Length = "0x3B6")]
		[Token(Token = "0x6000690")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x1607800", Offset = "0x1606C00", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x600068F")]
		private void set_Current(TElement value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E6C")]
	protected readonly IUniTaskAsyncEnumerable<TElement> source; //Field offset: 0x0

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000687")]
	public OrderedAsyncEnumerable`1(IUniTaskAsyncEnumerable<TElement> source) { }

	[Address(RVA = "0x6A00F0", Offset = "0x69F4F0", Length = "0xB5")]
	[Token(Token = "0x6000688")]
	public override IUniTaskOrderedAsyncEnumerable<TElement> CreateOrderedEnumerable(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }

	[Address(RVA = "0x6A00F0", Offset = "0x69F4F0", Length = "0xB5")]
	[Token(Token = "0x6000689")]
	public override IUniTaskOrderedAsyncEnumerable<TElement> CreateOrderedEnumerable(Func<TElement, UniTask`1<TKey>> keySelector, IComparer<TKey> comparer, bool descending) { }

	[Address(RVA = "0x6A00F0", Offset = "0x69F4F0", Length = "0xB5")]
	[Token(Token = "0x600068A")]
	public override IUniTaskOrderedAsyncEnumerable<TElement> CreateOrderedEnumerable(Func<TElement, CancellationToken, UniTask`1<TKey>> keySelector, IComparer<TKey> comparer, bool descending) { }

	[Token(Token = "0x600068B")]
	internal abstract AsyncEnumerableSorter<TElement> GetAsyncEnumerableSorter(AsyncEnumerableSorter<TElement> next, CancellationToken cancellationToken) { }

	[Address(RVA = "0xE12090", Offset = "0xE11490", Length = "0x7E")]
	[Token(Token = "0x600068C")]
	public override IUniTaskAsyncEnumerator<TElement> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

