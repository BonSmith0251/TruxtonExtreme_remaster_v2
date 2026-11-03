namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200022C")]
internal sealed class ZipAwaitWithCancellation : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x200022D")]
	private sealed class _ZipAwaitWithCancellation : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x200022E")]
		private struct <DisposeAsync>d__21 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001448")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001449")]
			public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400144A")]
			public _ZipAwaitWithCancellation<TFirst, TSecond, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400144B")]
			private Awaiter <>u__1; //Field offset: 0x0

			[Address(RVA = "0x16E81F0", Offset = "0x16E75F0", Length = "0x42B")]
			[Token(Token = "0x6000966")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x6000967")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x400143B")]
		private static readonly Action<Object> firstMoveNextCoreDelegate; //Field offset: 0x0
		[Token(Token = "0x400143C")]
		private static readonly Action<Object> secondMoveNextCoreDelegate; //Field offset: 0x0
		[Token(Token = "0x400143D")]
		private static readonly Action<Object> resultAwaitCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400143E")]
		private readonly IUniTaskAsyncEnumerable<TFirst> first; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400143F")]
		private readonly IUniTaskAsyncEnumerable<TSecond> second; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001440")]
		private readonly Func<TFirst, TSecond, CancellationToken, UniTask`1<TResult>> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001441")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001442")]
		private IUniTaskAsyncEnumerator<TFirst> firstEnumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001443")]
		private IUniTaskAsyncEnumerator<TSecond> secondEnumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001444")]
		private Awaiter<Boolean> firstAwaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001445")]
		private Awaiter<Boolean> secondAwaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001446")]
		private Awaiter<TResult> resultAwaiter; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001447")]
		private TResult <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700005D")]
		public private override TResult Current
		{
			[Address(RVA = "0x1629120", Offset = "0x1628520", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x600095E")]
			 get { } //Length: 176
			[Address(RVA = "0x16291D0", Offset = "0x16285D0", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x600095F")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x1628EB0", Offset = "0x16282B0", Length = "0x265")]
		[Token(Token = "0x6000965")]
		private static _ZipAwaitWithCancellation() { }

		[Address(RVA = "0x157ED70", Offset = "0x157E170", Length = "0x170")]
		[Token(Token = "0x600095D")]
		public _ZipAwaitWithCancellation(IUniTaskAsyncEnumerable<TFirst> first, IUniTaskAsyncEnumerable<TSecond> second, Func<TFirst, TSecond, CancellationToken, UniTask`1<TResult>> resultSelector, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1627840", Offset = "0x1626C40", Length = "0xA7")]
		[AsyncStateMachine(typeof(<DisposeAsync>d__21))]
		[Token(Token = "0x6000964")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x16278F0", Offset = "0x1626CF0", Length = "0x456")]
		[Token(Token = "0x6000961")]
		private static void FirstMoveNextCore(object state) { }

		[Address(RVA = "0x1629120", Offset = "0x1628520", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x600095E")]
		public override TResult get_Current() { }

		[Address(RVA = "0x1627D50", Offset = "0x1627150", Length = "0x568")]
		[Token(Token = "0x6000960")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x16282C0", Offset = "0x16276C0", Length = "0x3A7")]
		[Token(Token = "0x6000963")]
		private static void ResultAwaitCore(object state) { }

		[Address(RVA = "0x1628670", Offset = "0x1627A70", Length = "0x837")]
		[Token(Token = "0x6000962")]
		private static void SecondMoveNextCore(object state) { }

		[Address(RVA = "0x16291D0", Offset = "0x16285D0", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x600095F")]
		private void set_Current(TResult value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001438")]
	private readonly IUniTaskAsyncEnumerable<TFirst> first; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001439")]
	private readonly IUniTaskAsyncEnumerable<TSecond> second; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400143A")]
	private readonly Func<TFirst, TSecond, CancellationToken, UniTask`1<TResult>> resultSelector; //Field offset: 0x0

	[Address(RVA = "0xA96E10", Offset = "0xA96210", Length = "0x6B")]
	[Token(Token = "0x600095B")]
	public ZipAwaitWithCancellation`3(IUniTaskAsyncEnumerable<TFirst> first, IUniTaskAsyncEnumerable<TSecond> second, Func<TFirst, TSecond, CancellationToken, UniTask`1<TResult>> resultSelector) { }

	[Address(RVA = "0x1550FD0", Offset = "0x15503D0", Length = "0x9C")]
	[Token(Token = "0x600095C")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

