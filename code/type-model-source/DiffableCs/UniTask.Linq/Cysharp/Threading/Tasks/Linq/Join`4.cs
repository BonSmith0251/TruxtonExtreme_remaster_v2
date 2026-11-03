namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000DD")]
internal sealed class Join : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x20000DE")]
	private sealed class _Join : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x20000DF")]
		private struct <CreateInnerHashSet>d__20 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000982")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000983")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000984")]
			public _Join<TOuter, TInner, TKey, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000985")]
			private Awaiter<ILookup<TKey, TInner>> <>u__1; //Field offset: 0x0

			[Address(RVA = "0x1151B70", Offset = "0x1150F70", Length = "0x60E")]
			[Token(Token = "0x6000525")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x6000526")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x4000973")]
		private static readonly Action<Object> MoveNextCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000974")]
		private readonly IUniTaskAsyncEnumerable<TOuter> outer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000975")]
		private readonly IUniTaskAsyncEnumerable<TInner> inner; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000976")]
		private readonly Func<TOuter, TKey> outerKeySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000977")]
		private readonly Func<TInner, TKey> innerKeySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000978")]
		private readonly Func<TOuter, TInner, TResult> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000979")]
		private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400097A")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400097B")]
		private ILookup<TKey, TInner> lookup; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400097C")]
		private IUniTaskAsyncEnumerator<TOuter> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400097D")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400097E")]
		private TOuter currentOuterValue; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400097F")]
		private IEnumerator<TInner> valueEnumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000980")]
		private bool continueNext; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000981")]
		private TResult <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000028")]
		public private override TResult Current
		{
			[Address(RVA = "0x1606C00", Offset = "0x1606000", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x600051D")]
			 get { } //Length: 176
			[Address(RVA = "0x1606CB0", Offset = "0x16060B0", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x600051E")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x1606B00", Offset = "0x1605F00", Length = "0xF3")]
		[Token(Token = "0x6000524")]
		private static _Join() { }

		[Address(RVA = "0x16015C0", Offset = "0x16009C0", Length = "0x251")]
		[Token(Token = "0x600051C")]
		public _Join(IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15FCB90", Offset = "0x15FBF90", Length = "0x7F")]
		[AsyncStateMachine(typeof(<CreateInnerHashSet>d__20))]
		[Token(Token = "0x6000520")]
		private UniTaskVoid CreateInnerHashSet() { }

		[Address(RVA = "0x1605800", Offset = "0x1604C00", Length = "0x19B")]
		[Token(Token = "0x6000523")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x1606C00", Offset = "0x1606000", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x600051D")]
		public override TResult get_Current() { }

		[Address(RVA = "0x16059A0", Offset = "0x1604DA0", Length = "0x161")]
		[Token(Token = "0x600051F")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x1605B10", Offset = "0x1604F10", Length = "0x6D3")]
		[Token(Token = "0x6000522")]
		private static void MoveNextCore(object state) { }

		[Address(RVA = "0x1606CB0", Offset = "0x16060B0", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x600051E")]
		private void set_Current(TResult value) { }

		[Address(RVA = "0x16061F0", Offset = "0x16055F0", Length = "0x909")]
		[Token(Token = "0x6000521")]
		private void SourceMoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400096D")]
	private readonly IUniTaskAsyncEnumerable<TOuter> outer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400096E")]
	private readonly IUniTaskAsyncEnumerable<TInner> inner; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400096F")]
	private readonly Func<TOuter, TKey> outerKeySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000970")]
	private readonly Func<TInner, TKey> innerKeySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000971")]
	private readonly Func<TOuter, TInner, TResult> resultSelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000972")]
	private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0

	[Address(RVA = "0xAC8C60", Offset = "0xAC8060", Length = "0xA1")]
	[Token(Token = "0x600051A")]
	public Join`4(IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0xAC8B90", Offset = "0xAC7F90", Length = "0xD0")]
	[Token(Token = "0x600051B")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

