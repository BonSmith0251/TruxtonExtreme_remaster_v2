namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200007A")]
internal class CombineLatest2 : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x200007B")]
	private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x200007C")]
		private struct <DisposeAsync>d__99 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000596")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000597")]
			public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000598")]
			public _CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000599")]
			private Awaiter <>u__1; //Field offset: 0x0

			[Address(RVA = "0x16EF9C0", Offset = "0x16EEDC0", Length = "0x12B0")]
			[Token(Token = "0x600039C")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x600039D")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x4000543")]
		private static readonly Action<Object> Completed1Delegate; //Field offset: 0x0
		[Token(Token = "0x400054E")]
		private const int CompleteCount = 11; //Field offset: 0x0
		[Token(Token = "0x400054D")]
		private static readonly Action<Object> Completed11Delegate; //Field offset: 0x0
		[Token(Token = "0x400054B")]
		private static readonly Action<Object> Completed9Delegate; //Field offset: 0x0
		[Token(Token = "0x400054A")]
		private static readonly Action<Object> Completed8Delegate; //Field offset: 0x0
		[Token(Token = "0x4000549")]
		private static readonly Action<Object> Completed7Delegate; //Field offset: 0x0
		[Token(Token = "0x400054C")]
		private static readonly Action<Object> Completed10Delegate; //Field offset: 0x0
		[Token(Token = "0x4000547")]
		private static readonly Action<Object> Completed5Delegate; //Field offset: 0x0
		[Token(Token = "0x4000546")]
		private static readonly Action<Object> Completed4Delegate; //Field offset: 0x0
		[Token(Token = "0x4000545")]
		private static readonly Action<Object> Completed3Delegate; //Field offset: 0x0
		[Token(Token = "0x4000544")]
		private static readonly Action<Object> Completed2Delegate; //Field offset: 0x0
		[Token(Token = "0x4000548")]
		private static readonly Action<Object> Completed6Delegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400057C")]
		private bool hasCurrent7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000581")]
		private bool hasCurrent8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000580")]
		private Awaiter<Boolean> awaiter8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400057F")]
		private IUniTaskAsyncEnumerator<T8> enumerator8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400057E")]
		private T7 current7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400057D")]
		private bool running7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400057B")]
		private Awaiter<Boolean> awaiter7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000575")]
		private IUniTaskAsyncEnumerator<T6> enumerator6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000579")]
		private T6 current6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000578")]
		private bool running6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000577")]
		private bool hasCurrent6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000576")]
		private Awaiter<Boolean> awaiter6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000582")]
		private bool running8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000574")]
		private T5 current5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400057A")]
		private IUniTaskAsyncEnumerator<T7> enumerator7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000583")]
		private T8 current8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000589")]
		private IUniTaskAsyncEnumerator<T10> enumerator10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000585")]
		private Awaiter<Boolean> awaiter9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000593")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000592")]
		private T11 current11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000591")]
		private bool running11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000590")]
		private bool hasCurrent11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400058F")]
		private Awaiter<Boolean> awaiter11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400058E")]
		private IUniTaskAsyncEnumerator<T11> enumerator11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000584")]
		private IUniTaskAsyncEnumerator<T9> enumerator9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400058D")]
		private T10 current10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400058B")]
		private bool hasCurrent10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400058A")]
		private Awaiter<Boolean> awaiter10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000573")]
		private bool running5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000588")]
		private T9 current9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000587")]
		private bool running9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000586")]
		private bool hasCurrent9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400058C")]
		private bool running10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000572")]
		private bool hasCurrent5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400056C")]
		private Awaiter<Boolean> awaiter4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000570")]
		private IUniTaskAsyncEnumerator<T5> enumerator5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400055C")]
		private IUniTaskAsyncEnumerator<T1> enumerator1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400055B")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400055A")]
		private readonly Func2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000559")]
		private readonly IUniTaskAsyncEnumerable<T11> source11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000558")]
		private readonly IUniTaskAsyncEnumerable<T10> source10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000557")]
		private readonly IUniTaskAsyncEnumerable<T9> source9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400055D")]
		private Awaiter<Boolean> awaiter1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000556")]
		private readonly IUniTaskAsyncEnumerable<T8> source8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000554")]
		private readonly IUniTaskAsyncEnumerable<T6> source6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000553")]
		private readonly IUniTaskAsyncEnumerable<T5> source5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000552")]
		private readonly IUniTaskAsyncEnumerable<T4> source4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000551")]
		private readonly IUniTaskAsyncEnumerable<T3> source3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000550")]
		private readonly IUniTaskAsyncEnumerable<T2> source2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400054F")]
		private readonly IUniTaskAsyncEnumerable<T1> source1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000555")]
		private readonly IUniTaskAsyncEnumerable<T7> source7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400055E")]
		private bool hasCurrent1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400055F")]
		private bool running1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000560")]
		private T1 current1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400056F")]
		private T4 current4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400056E")]
		private bool running4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400056D")]
		private bool hasCurrent4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000594")]
		private bool syncRunning; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400056B")]
		private IUniTaskAsyncEnumerator<T4> enumerator4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400056A")]
		private T3 current3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000569")]
		private bool running3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000568")]
		private bool hasCurrent3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000567")]
		private Awaiter<Boolean> awaiter3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000566")]
		private IUniTaskAsyncEnumerator<T3> enumerator3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000565")]
		private T2 current2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000564")]
		private bool running2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000563")]
		private bool hasCurrent2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000562")]
		private Awaiter<Boolean> awaiter2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000561")]
		private IUniTaskAsyncEnumerator<T2> enumerator2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000571")]
		private Awaiter<Boolean> awaiter5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000595")]
		private TResult result; //Field offset: 0x0

		[Token(Token = "0x17000011")]
		public override TResult Current
		{
			[Address(RVA = "0x15C5930", Offset = "0x15C4D30", Length = "0xB0")]
			[Token(Token = "0x600038C")]
			 get { } //Length: 176
		}

		[Address(RVA = "0x15C31C0", Offset = "0x15C25C0", Length = "0x8A5")]
		[Token(Token = "0x600039B")]
		private static _CombineLatest() { }

		[Address(RVA = "0x15C4E00", Offset = "0x15C4200", Length = "0x45E")]
		[Token(Token = "0x600038B")]
		public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, Func2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> resultSelector, CancellationToken cancellationToken) { }

		[Address(RVA = "0x158A1A0", Offset = "0x15895A0", Length = "0x789")]
		[Token(Token = "0x600038E")]
		private static void Completed1(object state) { }

		[Address(RVA = "0x1582010", Offset = "0x1581410", Length = "0x790")]
		[Token(Token = "0x6000397")]
		private static void Completed10(object state) { }

		[Address(RVA = "0x15827B0", Offset = "0x1581BB0", Length = "0x790")]
		[Token(Token = "0x6000398")]
		private static void Completed11(object state) { }

		[Address(RVA = "0x158D6B0", Offset = "0x158CAB0", Length = "0x790")]
		[Token(Token = "0x600038F")]
		private static void Completed2(object state) { }

		[Address(RVA = "0x1591B50", Offset = "0x1590F50", Length = "0x790")]
		[Token(Token = "0x6000390")]
		private static void Completed3(object state) { }

		[Address(RVA = "0x15922F0", Offset = "0x15916F0", Length = "0x790")]
		[Token(Token = "0x6000391")]
		private static void Completed4(object state) { }

		[Address(RVA = "0x15950B0", Offset = "0x15944B0", Length = "0x790")]
		[Token(Token = "0x6000392")]
		private static void Completed5(object state) { }

		[Address(RVA = "0x1598610", Offset = "0x1597A10", Length = "0x790")]
		[Token(Token = "0x6000393")]
		private static void Completed6(object state) { }

		[Address(RVA = "0x159CAB0", Offset = "0x159BEB0", Length = "0x790")]
		[Token(Token = "0x6000394")]
		private static void Completed7(object state) { }

		[Address(RVA = "0x15A0010", Offset = "0x159F410", Length = "0x790")]
		[Token(Token = "0x6000395")]
		private static void Completed8(object state) { }

		[Address(RVA = "0x15A2DD0", Offset = "0x15A21D0", Length = "0x790")]
		[Token(Token = "0x6000396")]
		private static void Completed9(object state) { }

		[Address(RVA = "0x15A38E0", Offset = "0x15A2CE0", Length = "0xA7")]
		[AsyncStateMachine(typeof(<DisposeAsync>d__99))]
		[Token(Token = "0x600039A")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x15C5930", Offset = "0x15C4D30", Length = "0xB0")]
		[Token(Token = "0x600038C")]
		public override TResult get_Current() { }

		[Address(RVA = "0x15B01A0", Offset = "0x15AF5A0", Length = "0x3BBB")]
		[Token(Token = "0x600038D")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x15BF540", Offset = "0x15BE940", Length = "0xA3D")]
		[Token(Token = "0x6000399")]
		private bool TrySetResult() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000537")]
	private readonly IUniTaskAsyncEnumerable<T1> source1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000538")]
	private readonly IUniTaskAsyncEnumerable<T2> source2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000539")]
	private readonly IUniTaskAsyncEnumerable<T3> source3; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400053A")]
	private readonly IUniTaskAsyncEnumerable<T4> source4; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400053B")]
	private readonly IUniTaskAsyncEnumerable<T5> source5; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400053C")]
	private readonly IUniTaskAsyncEnumerable<T6> source6; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400053D")]
	private readonly IUniTaskAsyncEnumerable<T7> source7; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400053E")]
	private readonly IUniTaskAsyncEnumerable<T8> source8; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400053F")]
	private readonly IUniTaskAsyncEnumerable<T9> source9; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000540")]
	private readonly IUniTaskAsyncEnumerable<T10> source10; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000541")]
	private readonly IUniTaskAsyncEnumerable<T11> source11; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000542")]
	private readonly Func2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> resultSelector; //Field offset: 0x0

	[Address(RVA = "0x16D7ED0", Offset = "0x16D72D0", Length = "0x116")]
	[Token(Token = "0x6000389")]
	public CombineLatest`12(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, Func2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> resultSelector) { }

	[Address(RVA = "0x16D7D70", Offset = "0x16D7170", Length = "0x154")]
	[Token(Token = "0x600038A")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

