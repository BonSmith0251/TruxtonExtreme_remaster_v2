namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000062")]
internal class CombineLatest : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x2000063")]
	private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x2000064")]
		private struct <DisposeAsync>d__35 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400035E")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400035F")]
			public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000360")]
			public _CombineLatest<T1, T2, T3, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000361")]
			private Awaiter <>u__1; //Field offset: 0x0

			[Address(RVA = "0x16E96E0", Offset = "0x16E8AE0", Length = "0x60F")]
			[Token(Token = "0x6000310")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x6000311")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x4000343")]
		private static readonly Action<Object> Completed1Delegate; //Field offset: 0x0
		[Token(Token = "0x4000344")]
		private static readonly Action<Object> Completed2Delegate; //Field offset: 0x0
		[Token(Token = "0x4000345")]
		private static readonly Action<Object> Completed3Delegate; //Field offset: 0x0
		[Token(Token = "0x4000346")]
		private const int CompleteCount = 3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400035B")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400035A")]
		private T3 current3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000359")]
		private bool running3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000358")]
		private bool hasCurrent3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000357")]
		private Awaiter<Boolean> awaiter3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000356")]
		private IUniTaskAsyncEnumerator<T3> enumerator3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000355")]
		private T2 current2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000354")]
		private bool running2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000353")]
		private bool hasCurrent2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000352")]
		private Awaiter<Boolean> awaiter2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000350")]
		private T1 current1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400035C")]
		private bool syncRunning; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400034F")]
		private bool running1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400034E")]
		private bool hasCurrent1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400034D")]
		private Awaiter<Boolean> awaiter1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400034C")]
		private IUniTaskAsyncEnumerator<T1> enumerator1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400034B")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400034A")]
		private readonly Func<T1, T2, T3, TResult> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000349")]
		private readonly IUniTaskAsyncEnumerable<T3> source3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000348")]
		private readonly IUniTaskAsyncEnumerable<T2> source2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000347")]
		private readonly IUniTaskAsyncEnumerable<T1> source1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000351")]
		private IUniTaskAsyncEnumerator<T2> enumerator2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400035D")]
		private TResult result; //Field offset: 0x0

		[Token(Token = "0x17000009")]
		public override TResult Current
		{
			[Address(RVA = "0x157F680", Offset = "0x157EA80", Length = "0xB0")]
			[Token(Token = "0x6000308")]
			 get { } //Length: 176
		}

		[Address(RVA = "0x157C820", Offset = "0x157BC20", Length = "0x268")]
		[Token(Token = "0x600030F")]
		private static _CombineLatest() { }

		[Address(RVA = "0x157DF90", Offset = "0x157D390", Length = "0x1C9")]
		[Token(Token = "0x6000307")]
		public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, Func<T1, T2, T3, TResult> resultSelector, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15570D0", Offset = "0x15564D0", Length = "0x783")]
		[Token(Token = "0x600030A")]
		private static void Completed1(object state) { }

		[Address(RVA = "0x1557860", Offset = "0x1556C60", Length = "0x784")]
		[Token(Token = "0x600030B")]
		private static void Completed2(object state) { }

		[Address(RVA = "0x155E260", Offset = "0x155D660", Length = "0x784")]
		[Token(Token = "0x600030C")]
		private static void Completed3(object state) { }

		[Address(RVA = "0x1568E10", Offset = "0x1568210", Length = "0xA7")]
		[AsyncStateMachine(typeof(<DisposeAsync>d__35))]
		[Token(Token = "0x600030E")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x157F680", Offset = "0x157EA80", Length = "0xB0")]
		[Token(Token = "0x6000308")]
		public override TResult get_Current() { }

		[Address(RVA = "0x1572F40", Offset = "0x1572340", Length = "0x12C0")]
		[Token(Token = "0x6000309")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x1579430", Offset = "0x1578830", Length = "0x381")]
		[Token(Token = "0x600030D")]
		private bool TrySetResult() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400033F")]
	private readonly IUniTaskAsyncEnumerable<T1> source1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000340")]
	private readonly IUniTaskAsyncEnumerable<T2> source2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000341")]
	private readonly IUniTaskAsyncEnumerable<T3> source3; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000342")]
	private readonly Func<T1, T2, T3, TResult> resultSelector; //Field offset: 0x0

	[Address(RVA = "0x16D8BC0", Offset = "0x16D7FC0", Length = "0x7D")]
	[Token(Token = "0x6000305")]
	public CombineLatest`4(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, Func<T1, T2, T3, TResult> resultSelector) { }

	[Address(RVA = "0xF59100", Offset = "0xF58500", Length = "0xB1")]
	[Token(Token = "0x6000306")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

