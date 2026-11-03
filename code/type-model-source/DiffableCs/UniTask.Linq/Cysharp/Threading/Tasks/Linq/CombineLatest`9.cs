namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000071")]
internal class CombineLatest : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x2000072")]
	private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x2000073")]
		private struct <DisposeAsync>d__75 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000485")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000486")]
			public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000487")]
			public _CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000488")]
			private Awaiter <>u__1; //Field offset: 0x0

			[Address(RVA = "0x16EC8A0", Offset = "0x16EBCA0", Length = "0xEFC")]
			[Token(Token = "0x6000360")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x6000361")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x4000447")]
		private static readonly Action<Object> Completed1Delegate; //Field offset: 0x0
		[Token(Token = "0x4000448")]
		private static readonly Action<Object> Completed2Delegate; //Field offset: 0x0
		[Token(Token = "0x4000449")]
		private static readonly Action<Object> Completed3Delegate; //Field offset: 0x0
		[Token(Token = "0x400044A")]
		private static readonly Action<Object> Completed4Delegate; //Field offset: 0x0
		[Token(Token = "0x400044B")]
		private static readonly Action<Object> Completed5Delegate; //Field offset: 0x0
		[Token(Token = "0x400044C")]
		private static readonly Action<Object> Completed6Delegate; //Field offset: 0x0
		[Token(Token = "0x400044D")]
		private static readonly Action<Object> Completed7Delegate; //Field offset: 0x0
		[Token(Token = "0x400044E")]
		private static readonly Action<Object> Completed8Delegate; //Field offset: 0x0
		[Token(Token = "0x400044F")]
		private const int CompleteCount = 8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000474")]
		private Awaiter<Boolean> awaiter6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000473")]
		private IUniTaskAsyncEnumerator<T6> enumerator6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000472")]
		private T5 current5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000471")]
		private bool running5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400046C")]
		private bool running4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400046F")]
		private Awaiter<Boolean> awaiter5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400046E")]
		private IUniTaskAsyncEnumerator<T5> enumerator5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400046D")]
		private T4 current4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000475")]
		private bool hasCurrent6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000470")]
		private bool hasCurrent5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000476")]
		private bool running6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400047B")]
		private bool running7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000478")]
		private IUniTaskAsyncEnumerator<T7> enumerator7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000479")]
		private Awaiter<Boolean> awaiter7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400047A")]
		private bool hasCurrent7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400046B")]
		private bool hasCurrent4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400047C")]
		private T7 current7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400047D")]
		private IUniTaskAsyncEnumerator<T8> enumerator8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400047E")]
		private Awaiter<Boolean> awaiter8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400047F")]
		private bool hasCurrent8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000480")]
		private bool running8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000481")]
		private T8 current8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000482")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000477")]
		private T6 current6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400046A")]
		private Awaiter<Boolean> awaiter4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000465")]
		private Awaiter<Boolean> awaiter3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000468")]
		private T3 current3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000450")]
		private readonly IUniTaskAsyncEnumerable<T1> source1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000451")]
		private readonly IUniTaskAsyncEnumerable<T2> source2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000452")]
		private readonly IUniTaskAsyncEnumerable<T3> source3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000453")]
		private readonly IUniTaskAsyncEnumerable<T4> source4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000454")]
		private readonly IUniTaskAsyncEnumerable<T5> source5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000455")]
		private readonly IUniTaskAsyncEnumerable<T6> source6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000456")]
		private readonly IUniTaskAsyncEnumerable<T7> source7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000457")]
		private readonly IUniTaskAsyncEnumerable<T8> source8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000458")]
		private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000459")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400045A")]
		private IUniTaskAsyncEnumerator<T1> enumerator1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000469")]
		private IUniTaskAsyncEnumerator<T4> enumerator4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400045B")]
		private Awaiter<Boolean> awaiter1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400045D")]
		private bool running1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400045E")]
		private T1 current1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400045F")]
		private IUniTaskAsyncEnumerator<T2> enumerator2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000460")]
		private Awaiter<Boolean> awaiter2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000461")]
		private bool hasCurrent2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000462")]
		private bool running2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000463")]
		private T2 current2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000464")]
		private IUniTaskAsyncEnumerator<T3> enumerator3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000483")]
		private bool syncRunning; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000466")]
		private bool hasCurrent3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000467")]
		private bool running3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400045C")]
		private bool hasCurrent1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000484")]
		private TResult result; //Field offset: 0x0

		[Token(Token = "0x1700000E")]
		public override TResult Current
		{
			[Address(RVA = "0x157F470", Offset = "0x157E870", Length = "0xB0")]
			[Token(Token = "0x6000353")]
			 get { } //Length: 176
		}

		[Address(RVA = "0x157BC20", Offset = "0x157B020", Length = "0x656")]
		[Token(Token = "0x600035F")]
		private static _CombineLatest() { }

		[Address(RVA = "0x157EEE0", Offset = "0x157E2E0", Length = "0x365")]
		[Token(Token = "0x6000352")]
		public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> resultSelector, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1554370", Offset = "0x1553770", Length = "0x789")]
		[Token(Token = "0x6000355")]
		private static void Completed1(object state) { }

		[Address(RVA = "0x1558F10", Offset = "0x1558310", Length = "0x78A")]
		[Token(Token = "0x6000356")]
		private static void Completed2(object state) { }

		[Address(RVA = "0x155BC80", Offset = "0x155B080", Length = "0x790")]
		[Token(Token = "0x6000357")]
		private static void Completed3(object state) { }

		[Address(RVA = "0x1560FF0", Offset = "0x15603F0", Length = "0x790")]
		[Token(Token = "0x6000358")]
		private static void Completed4(object state) { }

		[Address(RVA = "0x15626D0", Offset = "0x1561AD0", Length = "0x790")]
		[Token(Token = "0x6000359")]
		private static void Completed5(object state) { }

		[Address(RVA = "0x1565490", Offset = "0x1564890", Length = "0x790")]
		[Token(Token = "0x600035A")]
		private static void Completed6(object state) { }

		[Address(RVA = "0x1566B70", Offset = "0x1565F70", Length = "0x790")]
		[Token(Token = "0x600035B")]
		private static void Completed7(object state) { }

		[Address(RVA = "0x1567310", Offset = "0x1566710", Length = "0x790")]
		[Token(Token = "0x600035C")]
		private static void Completed8(object state) { }

		[Address(RVA = "0x1568CB0", Offset = "0x15680B0", Length = "0xA7")]
		[AsyncStateMachine(typeof(<DisposeAsync>d__75))]
		[Token(Token = "0x600035E")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x157F470", Offset = "0x157E870", Length = "0xB0")]
		[Token(Token = "0x6000353")]
		public override TResult get_Current() { }

		[Address(RVA = "0x156A810", Offset = "0x1569C10", Length = "0x2D08")]
		[Token(Token = "0x6000354")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x1579DE0", Offset = "0x15791E0", Length = "0x7BD")]
		[Token(Token = "0x600035D")]
		private bool TrySetResult() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400043E")]
	private readonly IUniTaskAsyncEnumerable<T1> source1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400043F")]
	private readonly IUniTaskAsyncEnumerable<T2> source2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000440")]
	private readonly IUniTaskAsyncEnumerable<T3> source3; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000441")]
	private readonly IUniTaskAsyncEnumerable<T4> source4; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000442")]
	private readonly IUniTaskAsyncEnumerable<T5> source5; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000443")]
	private readonly IUniTaskAsyncEnumerable<T6> source6; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000444")]
	private readonly IUniTaskAsyncEnumerable<T7> source7; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000445")]
	private readonly IUniTaskAsyncEnumerable<T8> source8; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000446")]
	private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> resultSelector; //Field offset: 0x0

	[Address(RVA = "0x16D9210", Offset = "0x16D8610", Length = "0xD7")]
	[Token(Token = "0x6000350")]
	public CombineLatest`9(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> resultSelector) { }

	[Address(RVA = "0x16D9100", Offset = "0x16D8500", Length = "0x103")]
	[Token(Token = "0x6000351")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

