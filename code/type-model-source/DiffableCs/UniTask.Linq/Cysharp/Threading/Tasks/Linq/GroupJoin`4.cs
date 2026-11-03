namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000D2")]
internal sealed class GroupJoin : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x20000D3")]
	private sealed class _GroupJoin : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x20000D4")]
		private struct <CreateLookup>d__17 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400092B")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400092C")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400092D")]
			public _GroupJoin<TOuter, TInner, TKey, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400092E")]
			private Awaiter<ILookup<TKey, TInner>> <>u__1; //Field offset: 0x0

			[Address(RVA = "0x1151B70", Offset = "0x1150F70", Length = "0x60E")]
			[Token(Token = "0x60004F3")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x60004F4")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x400091F")]
		private static readonly Action<Object> MoveNextCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000920")]
		private readonly IUniTaskAsyncEnumerable<TOuter> outer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000921")]
		private readonly IUniTaskAsyncEnumerable<TInner> inner; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000922")]
		private readonly Func<TOuter, TKey> outerKeySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000923")]
		private readonly Func<TInner, TKey> innerKeySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000924")]
		private readonly Func<TOuter, IEnumerable`1<TInner>, TResult> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000925")]
		private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000926")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000927")]
		private ILookup<TKey, TInner> lookup; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000928")]
		private IUniTaskAsyncEnumerator<TOuter> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000929")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400092A")]
		private TResult <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000025")]
		public private override TResult Current
		{
			[Address(RVA = "0x1601820", Offset = "0x1600C20", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x60004EB")]
			 get { } //Length: 176
			[Address(RVA = "0x16018D0", Offset = "0x1600CD0", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x60004EC")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x16014C0", Offset = "0x16008C0", Length = "0xF3")]
		[Token(Token = "0x60004F2")]
		private static _GroupJoin() { }

		[Address(RVA = "0x16015C0", Offset = "0x16009C0", Length = "0x251")]
		[Token(Token = "0x60004EA")]
		public _GroupJoin(IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable`1<TInner>, TResult> resultSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15FCB90", Offset = "0x15FBF90", Length = "0x7F")]
		[AsyncStateMachine(typeof(<CreateLookup>d__17))]
		[Token(Token = "0x60004EE")]
		private UniTaskVoid CreateLookup() { }

		[Address(RVA = "0x16007A0", Offset = "0x15FFBA0", Length = "0x12B")]
		[Token(Token = "0x60004F1")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x1601820", Offset = "0x1600C20", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x60004EB")]
		public override TResult get_Current() { }

		[Address(RVA = "0x16008D0", Offset = "0x15FFCD0", Length = "0x161")]
		[Token(Token = "0x60004ED")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x1600A40", Offset = "0x15FFE40", Length = "0x702")]
		[Token(Token = "0x60004F0")]
		private static void MoveNextCore(object state) { }

		[Address(RVA = "0x16018D0", Offset = "0x1600CD0", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x60004EC")]
		private void set_Current(TResult value) { }

		[Address(RVA = "0x1601150", Offset = "0x1600550", Length = "0x36D")]
		[Token(Token = "0x60004EF")]
		private void SourceMoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000919")]
	private readonly IUniTaskAsyncEnumerable<TOuter> outer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400091A")]
	private readonly IUniTaskAsyncEnumerable<TInner> inner; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400091B")]
	private readonly Func<TOuter, TKey> outerKeySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400091C")]
	private readonly Func<TInner, TKey> innerKeySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400091D")]
	private readonly Func<TOuter, IEnumerable`1<TInner>, TResult> resultSelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400091E")]
	private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0

	[Address(RVA = "0xAC8C60", Offset = "0xAC8060", Length = "0xA1")]
	[Token(Token = "0x60004E8")]
	public GroupJoin`4(IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable`1<TInner>, TResult> resultSelector, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0xAC8B90", Offset = "0xAC7F90", Length = "0xD0")]
	[Token(Token = "0x60004E9")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

