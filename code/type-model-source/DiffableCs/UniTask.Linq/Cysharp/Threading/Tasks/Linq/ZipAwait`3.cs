namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000229")]
internal sealed class ZipAwait : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x200022A")]
	private sealed class _ZipAwait : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x200022B")]
		private struct <DisposeAsync>d__21 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001434")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001435")]
			public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001436")]
			public _ZipAwait<TFirst, TSecond, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001437")]
			private Awaiter <>u__1; //Field offset: 0x0

			[Address(RVA = "0x16E7DC0", Offset = "0x16E71C0", Length = "0x42B")]
			[Token(Token = "0x6000959")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x600095A")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x4001427")]
		private static readonly Action<Object> firstMoveNextCoreDelegate; //Field offset: 0x0
		[Token(Token = "0x4001428")]
		private static readonly Action<Object> secondMoveNextCoreDelegate; //Field offset: 0x0
		[Token(Token = "0x4001429")]
		private static readonly Action<Object> resultAwaitCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400142A")]
		private readonly IUniTaskAsyncEnumerable<TFirst> first; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400142B")]
		private readonly IUniTaskAsyncEnumerable<TSecond> second; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400142C")]
		private readonly Func<TFirst, TSecond, UniTask`1<TResult>> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400142D")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400142E")]
		private IUniTaskAsyncEnumerator<TFirst> firstEnumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400142F")]
		private IUniTaskAsyncEnumerator<TSecond> secondEnumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001430")]
		private Awaiter<Boolean> firstAwaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001431")]
		private Awaiter<Boolean> secondAwaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001432")]
		private Awaiter<TResult> resultAwaiter; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001433")]
		private TResult <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700005C")]
		public private override TResult Current
		{
			[Address(RVA = "0x1629120", Offset = "0x1628520", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x6000951")]
			 get { } //Length: 176
			[Address(RVA = "0x16291D0", Offset = "0x16285D0", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x6000952")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x162A800", Offset = "0x1629C00", Length = "0x265")]
		[Token(Token = "0x6000958")]
		private static _ZipAwait() { }

		[Address(RVA = "0x157ED70", Offset = "0x157E170", Length = "0x170")]
		[Token(Token = "0x6000950")]
		public _ZipAwait(IUniTaskAsyncEnumerable<TFirst> first, IUniTaskAsyncEnumerable<TSecond> second, Func<TFirst, TSecond, UniTask`1<TResult>> resultSelector, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1627840", Offset = "0x1626C40", Length = "0xA7")]
		[AsyncStateMachine(typeof(<DisposeAsync>d__21))]
		[Token(Token = "0x6000957")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x1629290", Offset = "0x1628690", Length = "0x456")]
		[Token(Token = "0x6000954")]
		private static void FirstMoveNextCore(object state) { }

		[Address(RVA = "0x1629120", Offset = "0x1628520", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x6000951")]
		public override TResult get_Current() { }

		[Address(RVA = "0x16296F0", Offset = "0x1628AF0", Length = "0x568")]
		[Token(Token = "0x6000953")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x1629C60", Offset = "0x1629060", Length = "0x3A7")]
		[Token(Token = "0x6000956")]
		private static void ResultAwaitCore(object state) { }

		[Address(RVA = "0x162A010", Offset = "0x1629410", Length = "0x7E8")]
		[Token(Token = "0x6000955")]
		private static void SecondMoveNextCore(object state) { }

		[Address(RVA = "0x16291D0", Offset = "0x16285D0", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x6000952")]
		private void set_Current(TResult value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001424")]
	private readonly IUniTaskAsyncEnumerable<TFirst> first; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001425")]
	private readonly IUniTaskAsyncEnumerable<TSecond> second; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001426")]
	private readonly Func<TFirst, TSecond, UniTask`1<TResult>> resultSelector; //Field offset: 0x0

	[Address(RVA = "0xA96E10", Offset = "0xA96210", Length = "0x6B")]
	[Token(Token = "0x600094E")]
	public ZipAwait`3(IUniTaskAsyncEnumerable<TFirst> first, IUniTaskAsyncEnumerable<TSecond> second, Func<TFirst, TSecond, UniTask`1<TResult>> resultSelector) { }

	[Address(RVA = "0x1550FD0", Offset = "0x15503D0", Length = "0x9C")]
	[Token(Token = "0x600094F")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

