namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200005F")]
internal class CombineLatest : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x2000060")]
	private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x2000061")]
		private struct <DisposeAsync>d__27 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400033B")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400033C")]
			public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400033D")]
			public _CombineLatest<T1, T2, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400033E")]
			private Awaiter <>u__1; //Field offset: 0x0

			[Address(RVA = "0x16E8A50", Offset = "0x16E7E50", Length = "0x42B")]
			[Token(Token = "0x6000303")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x6000304")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x4000327")]
		private static readonly Action<Object> Completed1Delegate; //Field offset: 0x0
		[Token(Token = "0x4000328")]
		private static readonly Action<Object> Completed2Delegate; //Field offset: 0x0
		[Token(Token = "0x4000329")]
		private const int CompleteCount = 2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000338")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000337")]
		private T2 current2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000336")]
		private bool running2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000335")]
		private bool hasCurrent2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000334")]
		private Awaiter<Boolean> awaiter2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000333")]
		private IUniTaskAsyncEnumerator<T2> enumerator2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000332")]
		private T1 current1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000330")]
		private bool hasCurrent1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000339")]
		private bool syncRunning; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400032F")]
		private Awaiter<Boolean> awaiter1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400032E")]
		private IUniTaskAsyncEnumerator<T1> enumerator1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400032D")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400032C")]
		private readonly Func<T1, T2, TResult> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400032B")]
		private readonly IUniTaskAsyncEnumerable<T2> source2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400032A")]
		private readonly IUniTaskAsyncEnumerable<T1> source1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000331")]
		private bool running1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400033A")]
		private TResult result; //Field offset: 0x0

		[Token(Token = "0x17000008")]
		public override TResult Current
		{
			[Address(RVA = "0x157F5D0", Offset = "0x157E9D0", Length = "0xB0")]
			[Token(Token = "0x60002FC")]
			 get { } //Length: 176
		}

		[Address(RVA = "0x157D6C0", Offset = "0x157CAC0", Length = "0x1A6")]
		[Token(Token = "0x6000302")]
		private static _CombineLatest() { }

		[Address(RVA = "0x157ED70", Offset = "0x157E170", Length = "0x170")]
		[Token(Token = "0x60002FB")]
		public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, Func<T1, T2, TResult> resultSelector, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1554B00", Offset = "0x1553F00", Length = "0x780")]
		[Token(Token = "0x60002FE")]
		private static void Completed1(object state) { }

		[Address(RVA = "0x155A5C0", Offset = "0x15599C0", Length = "0x784")]
		[Token(Token = "0x60002FF")]
		private static void Completed2(object state) { }

		[Address(RVA = "0x1568B50", Offset = "0x1567F50", Length = "0xA7")]
		[AsyncStateMachine(typeof(<DisposeAsync>d__27))]
		[Token(Token = "0x6000301")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x157F5D0", Offset = "0x157E9D0", Length = "0xB0")]
		[Token(Token = "0x60002FC")]
		public override TResult get_Current() { }

		[Address(RVA = "0x1576480", Offset = "0x1575880", Length = "0xD5D")]
		[Token(Token = "0x60002FD")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x157B0E0", Offset = "0x157A4E0", Length = "0x2AC")]
		[Token(Token = "0x6000300")]
		private bool TrySetResult() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000324")]
	private readonly IUniTaskAsyncEnumerable<T1> source1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000325")]
	private readonly IUniTaskAsyncEnumerable<T2> source2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000326")]
	private readonly Func<T1, T2, TResult> resultSelector; //Field offset: 0x0

	[Address(RVA = "0xA96E10", Offset = "0xA96210", Length = "0x6B")]
	[Token(Token = "0x60002F9")]
	public CombineLatest`3(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, Func<T1, T2, TResult> resultSelector) { }

	[Address(RVA = "0x1550FD0", Offset = "0x15503D0", Length = "0x9C")]
	[Token(Token = "0x60002FA")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

