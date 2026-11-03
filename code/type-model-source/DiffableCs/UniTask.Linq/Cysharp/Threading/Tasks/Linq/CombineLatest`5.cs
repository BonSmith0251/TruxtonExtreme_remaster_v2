namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000065")]
internal class CombineLatest : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x2000066")]
	private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x2000067")]
		private struct <DisposeAsync>d__43 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000389")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400038A")]
			public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400038B")]
			public _CombineLatest<T1, T2, T3, T4, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400038C")]
			private Awaiter <>u__1; //Field offset: 0x0

			[Address(RVA = "0x16E9D00", Offset = "0x16E9100", Length = "0x7F2")]
			[Token(Token = "0x600031E")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x600031F")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x4000367")]
		private static readonly Action<Object> Completed1Delegate; //Field offset: 0x0
		[Token(Token = "0x4000368")]
		private static readonly Action<Object> Completed2Delegate; //Field offset: 0x0
		[Token(Token = "0x4000369")]
		private static readonly Action<Object> Completed3Delegate; //Field offset: 0x0
		[Token(Token = "0x400036A")]
		private static readonly Action<Object> Completed4Delegate; //Field offset: 0x0
		[Token(Token = "0x400036B")]
		private const int CompleteCount = 4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400037C")]
		private IUniTaskAsyncEnumerator<T3> enumerator3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400037D")]
		private Awaiter<Boolean> awaiter3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400037E")]
		private bool hasCurrent3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400037F")]
		private bool running3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000380")]
		private T3 current3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000383")]
		private bool hasCurrent4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000382")]
		private Awaiter<Boolean> awaiter4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400037B")]
		private T2 current2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000384")]
		private bool running4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000385")]
		private T4 current4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000386")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000381")]
		private IUniTaskAsyncEnumerator<T4> enumerator4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400037A")]
		private bool running2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000377")]
		private IUniTaskAsyncEnumerator<T2> enumerator2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000378")]
		private Awaiter<Boolean> awaiter2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000387")]
		private bool syncRunning; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000376")]
		private T1 current1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000375")]
		private bool running1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000374")]
		private bool hasCurrent1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000373")]
		private Awaiter<Boolean> awaiter1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000372")]
		private IUniTaskAsyncEnumerator<T1> enumerator1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000371")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000370")]
		private readonly Func<T1, T2, T3, T4, TResult> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400036F")]
		private readonly IUniTaskAsyncEnumerable<T4> source4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400036E")]
		private readonly IUniTaskAsyncEnumerable<T3> source3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400036D")]
		private readonly IUniTaskAsyncEnumerable<T2> source2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400036C")]
		private readonly IUniTaskAsyncEnumerable<T1> source1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000379")]
		private bool hasCurrent2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000388")]
		private TResult result; //Field offset: 0x0

		[Token(Token = "0x1700000A")]
		public override TResult Current
		{
			[Address(RVA = "0x157F520", Offset = "0x157E920", Length = "0xB0")]
			[Token(Token = "0x6000315")]
			 get { } //Length: 176
		}

		[Address(RVA = "0x157CF60", Offset = "0x157C360", Length = "0x342")]
		[Token(Token = "0x600031D")]
		private static _CombineLatest() { }

		[Address(RVA = "0x157F250", Offset = "0x157E650", Length = "0x219")]
		[Token(Token = "0x6000314")]
		public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, Func<T1, T2, T3, T4, TResult> resultSelector, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15561B0", Offset = "0x15555B0", Length = "0x789")]
		[Token(Token = "0x6000317")]
		private static void Completed1(object state) { }

		[Address(RVA = "0x155AD50", Offset = "0x155A150", Length = "0x78A")]
		[Token(Token = "0x6000318")]
		private static void Completed2(object state) { }

		[Address(RVA = "0x155D340", Offset = "0x155C740", Length = "0x78A")]
		[Token(Token = "0x6000319")]
		private static void Completed3(object state) { }

		[Address(RVA = "0x155F180", Offset = "0x155E580", Length = "0x78A")]
		[Token(Token = "0x600031A")]
		private static void Completed4(object state) { }

		[Address(RVA = "0x1568C00", Offset = "0x1568000", Length = "0xA7")]
		[AsyncStateMachine(typeof(<DisposeAsync>d__43))]
		[Token(Token = "0x600031C")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x157F520", Offset = "0x157E920", Length = "0xB0")]
		[Token(Token = "0x6000315")]
		public override TResult get_Current() { }

		[Address(RVA = "0x1568F70", Offset = "0x1568370", Length = "0x1890")]
		[Token(Token = "0x6000316")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x157AC90", Offset = "0x157A090", Length = "0x44D")]
		[Token(Token = "0x600031B")]
		private bool TrySetResult() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000362")]
	private readonly IUniTaskAsyncEnumerable<T1> source1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000363")]
	private readonly IUniTaskAsyncEnumerable<T2> source2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000364")]
	private readonly IUniTaskAsyncEnumerable<T3> source3; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000365")]
	private readonly IUniTaskAsyncEnumerable<T4> source4; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000366")]
	private readonly Func<T1, T2, T3, T4, TResult> resultSelector; //Field offset: 0x0

	[Address(RVA = "0x16D8D00", Offset = "0x16D8100", Length = "0x8F")]
	[Token(Token = "0x6000312")]
	public CombineLatest`5(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, Func<T1, T2, T3, T4, TResult> resultSelector) { }

	[Address(RVA = "0x16D8C40", Offset = "0x16D8040", Length = "0xB9")]
	[Token(Token = "0x6000313")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

