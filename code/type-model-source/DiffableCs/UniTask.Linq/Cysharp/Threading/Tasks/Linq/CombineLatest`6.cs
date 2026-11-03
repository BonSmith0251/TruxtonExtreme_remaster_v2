namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000068")]
internal class CombineLatest : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x2000069")]
	private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x200006A")]
		private struct <DisposeAsync>d__51 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40003BC")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40003BD")]
			public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40003BE")]
			public _CombineLatest<T1, T2, T3, T4, T5, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40003BF")]
			private Awaiter <>u__1; //Field offset: 0x0

			[Address(RVA = "0x16EA500", Offset = "0x16E9900", Length = "0x978")]
			[Token(Token = "0x600032D")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x600032E")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x4000393")]
		private static readonly Action<Object> Completed1Delegate; //Field offset: 0x0
		[Token(Token = "0x4000394")]
		private static readonly Action<Object> Completed2Delegate; //Field offset: 0x0
		[Token(Token = "0x4000395")]
		private static readonly Action<Object> Completed3Delegate; //Field offset: 0x0
		[Token(Token = "0x4000396")]
		private static readonly Action<Object> Completed4Delegate; //Field offset: 0x0
		[Token(Token = "0x4000397")]
		private static readonly Action<Object> Completed5Delegate; //Field offset: 0x0
		[Token(Token = "0x4000398")]
		private const int CompleteCount = 5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003AC")]
		private bool hasCurrent3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003AD")]
		private bool running3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003AE")]
		private T3 current3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003AF")]
		private IUniTaskAsyncEnumerator<T4> enumerator4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003B0")]
		private Awaiter<Boolean> awaiter4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003B1")]
		private bool hasCurrent4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003B2")]
		private bool running4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003B5")]
		private Awaiter<Boolean> awaiter5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003B4")]
		private IUniTaskAsyncEnumerator<T5> enumerator5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003AB")]
		private Awaiter<Boolean> awaiter3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003B6")]
		private bool hasCurrent5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003B7")]
		private bool running5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003B8")]
		private T5 current5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003B9")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003B3")]
		private T4 current4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003AA")]
		private IUniTaskAsyncEnumerator<T3> enumerator3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003A7")]
		private bool hasCurrent2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003A8")]
		private bool running2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000399")]
		private readonly IUniTaskAsyncEnumerable<T1> source1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400039A")]
		private readonly IUniTaskAsyncEnumerable<T2> source2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400039B")]
		private readonly IUniTaskAsyncEnumerable<T3> source3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400039C")]
		private readonly IUniTaskAsyncEnumerable<T4> source4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400039D")]
		private readonly IUniTaskAsyncEnumerable<T5> source5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400039E")]
		private readonly Func<T1, T2, T3, T4, T5, TResult> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400039F")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003A0")]
		private IUniTaskAsyncEnumerator<T1> enumerator1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003A1")]
		private Awaiter<Boolean> awaiter1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003A2")]
		private bool hasCurrent1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003A3")]
		private bool running1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003A4")]
		private T1 current1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003A5")]
		private IUniTaskAsyncEnumerator<T2> enumerator2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003A6")]
		private Awaiter<Boolean> awaiter2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003BA")]
		private bool syncRunning; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003A9")]
		private T2 current2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003BB")]
		private TResult result; //Field offset: 0x0

		[Token(Token = "0x1700000B")]
		public override TResult Current
		{
			[Address(RVA = "0x157F890", Offset = "0x157EC90", Length = "0xB0")]
			[Token(Token = "0x6000323")]
			 get { } //Length: 176
		}

		[Address(RVA = "0x157D2B0", Offset = "0x157C6B0", Length = "0x407")]
		[Token(Token = "0x600032C")]
		private static _CombineLatest() { }

		[Address(RVA = "0x157E160", Offset = "0x157D560", Length = "0x26C")]
		[Token(Token = "0x6000322")]
		public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, Func<T1, T2, T3, T4, T5, TResult> resultSelector, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1553BE0", Offset = "0x1552FE0", Length = "0x789")]
		[Token(Token = "0x6000325")]
		private static void Completed1(object state) { }

		[Address(RVA = "0x1559E30", Offset = "0x1559230", Length = "0x78A")]
		[Token(Token = "0x6000326")]
		private static void Completed2(object state) { }

		[Address(RVA = "0x155DAD0", Offset = "0x155CED0", Length = "0x78A")]
		[Token(Token = "0x6000327")]
		private static void Completed3(object state) { }

		[Address(RVA = "0x155E9F0", Offset = "0x155DDF0", Length = "0x78A")]
		[Token(Token = "0x6000328")]
		private static void Completed4(object state) { }

		[Address(RVA = "0x1561F30", Offset = "0x1561330", Length = "0x790")]
		[Token(Token = "0x6000329")]
		private static void Completed5(object state) { }

		[Address(RVA = "0x1568AA0", Offset = "0x1567EA0", Length = "0xA7")]
		[AsyncStateMachine(typeof(<DisposeAsync>d__51))]
		[Token(Token = "0x600032B")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x157F890", Offset = "0x157EC90", Length = "0xB0")]
		[Token(Token = "0x6000323")]
		public override TResult get_Current() { }

		[Address(RVA = "0x15771E0", Offset = "0x15765E0", Length = "0x1D11")]
		[Token(Token = "0x6000324")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x1578F00", Offset = "0x1578300", Length = "0x521")]
		[Token(Token = "0x600032A")]
		private bool TrySetResult() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400038D")]
	private readonly IUniTaskAsyncEnumerable<T1> source1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400038E")]
	private readonly IUniTaskAsyncEnumerable<T2> source2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400038F")]
	private readonly IUniTaskAsyncEnumerable<T3> source3; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000390")]
	private readonly IUniTaskAsyncEnumerable<T4> source4; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000391")]
	private readonly IUniTaskAsyncEnumerable<T5> source5; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000392")]
	private readonly Func<T1, T2, T3, T4, T5, TResult> resultSelector; //Field offset: 0x0

	[Address(RVA = "0xAC8C60", Offset = "0xAC8060", Length = "0xA1")]
	[Token(Token = "0x6000320")]
	public CombineLatest`6(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, Func<T1, T2, T3, T4, T5, TResult> resultSelector) { }

	[Address(RVA = "0xAC8B90", Offset = "0xAC7F90", Length = "0xD0")]
	[Token(Token = "0x6000321")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

