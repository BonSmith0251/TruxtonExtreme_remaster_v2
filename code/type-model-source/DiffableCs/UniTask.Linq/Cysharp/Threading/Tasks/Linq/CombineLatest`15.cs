namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000083")]
internal class CombineLatest5 : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x2000084")]
	private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x2000085")]
		private struct <DisposeAsync>d__123 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40006EF")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40006F0")]
			public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40006F1")]
			public _CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40006F2")]
			private Awaiter <>u__1; //Field offset: 0x0

			[Address(RVA = "0x16E4980", Offset = "0x16E3D80", Length = "0x1720")]
			[Token(Token = "0x60003E1")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x60003E2")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x4000687")]
		private static readonly Action<Object> Completed1Delegate; //Field offset: 0x0
		[Token(Token = "0x4000695")]
		private const int CompleteCount = 14; //Field offset: 0x0
		[Token(Token = "0x4000694")]
		private static readonly Action<Object> Completed14Delegate; //Field offset: 0x0
		[Token(Token = "0x4000693")]
		private static readonly Action<Object> Completed13Delegate; //Field offset: 0x0
		[Token(Token = "0x4000691")]
		private static readonly Action<Object> Completed11Delegate; //Field offset: 0x0
		[Token(Token = "0x4000690")]
		private static readonly Action<Object> Completed10Delegate; //Field offset: 0x0
		[Token(Token = "0x400068F")]
		private static readonly Action<Object> Completed9Delegate; //Field offset: 0x0
		[Token(Token = "0x4000692")]
		private static readonly Action<Object> Completed12Delegate; //Field offset: 0x0
		[Token(Token = "0x400068D")]
		private static readonly Action<Object> Completed7Delegate; //Field offset: 0x0
		[Token(Token = "0x400068C")]
		private static readonly Action<Object> Completed6Delegate; //Field offset: 0x0
		[Token(Token = "0x400068B")]
		private static readonly Action<Object> Completed5Delegate; //Field offset: 0x0
		[Token(Token = "0x400068A")]
		private static readonly Action<Object> Completed4Delegate; //Field offset: 0x0
		[Token(Token = "0x4000689")]
		private static readonly Action<Object> Completed3Delegate; //Field offset: 0x0
		[Token(Token = "0x4000688")]
		private static readonly Action<Object> Completed2Delegate; //Field offset: 0x0
		[Token(Token = "0x400068E")]
		private static readonly Action<Object> Completed8Delegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006CE")]
		private IUniTaskAsyncEnumerator<T9> enumerator9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006D5")]
		private bool hasCurrent10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006D4")]
		private Awaiter<Boolean> awaiter10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006D3")]
		private IUniTaskAsyncEnumerator<T10> enumerator10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006D2")]
		private T9 current9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006D1")]
		private bool running9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006D0")]
		private bool hasCurrent9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006CF")]
		private Awaiter<Boolean> awaiter9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006CD")]
		private T8 current8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006C6")]
		private bool hasCurrent7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006CB")]
		private bool hasCurrent8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006CA")]
		private Awaiter<Boolean> awaiter8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006C9")]
		private IUniTaskAsyncEnumerator<T8> enumerator8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006C8")]
		private T7 current7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006C7")]
		private bool running7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006D6")]
		private bool running10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006C5")]
		private Awaiter<Boolean> awaiter7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006C4")]
		private IUniTaskAsyncEnumerator<T7> enumerator7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006CC")]
		private bool running8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006D7")]
		private T10 current10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006DF")]
		private bool hasCurrent12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006D9")]
		private Awaiter<Boolean> awaiter11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006EC")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006EB")]
		private T14 current14; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006EA")]
		private bool running14; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006E9")]
		private bool hasCurrent14; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006E8")]
		private Awaiter<Boolean> awaiter14; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006E7")]
		private IUniTaskAsyncEnumerator<T14> enumerator14; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006E6")]
		private T13 current13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006E5")]
		private bool running13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006E4")]
		private bool hasCurrent13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006E3")]
		private Awaiter<Boolean> awaiter13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006E2")]
		private IUniTaskAsyncEnumerator<T13> enumerator13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006E1")]
		private T12 current12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006E0")]
		private bool running12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006C3")]
		private T6 current6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006DE")]
		private Awaiter<Boolean> awaiter12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006DD")]
		private IUniTaskAsyncEnumerator<T12> enumerator12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006DC")]
		private T11 current11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006DB")]
		private bool running11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006DA")]
		private bool hasCurrent11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006D8")]
		private IUniTaskAsyncEnumerator<T11> enumerator11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006C2")]
		private bool running6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006BA")]
		private IUniTaskAsyncEnumerator<T5> enumerator5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006C0")]
		private Awaiter<Boolean> awaiter6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A8")]
		private bool hasCurrent1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A7")]
		private Awaiter<Boolean> awaiter1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A6")]
		private IUniTaskAsyncEnumerator<T1> enumerator1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A5")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A4")]
		private readonly Func5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A3")]
		private readonly IUniTaskAsyncEnumerable<T14> source14; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A2")]
		private readonly IUniTaskAsyncEnumerable<T13> source13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A1")]
		private readonly IUniTaskAsyncEnumerable<T12> source12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A0")]
		private readonly IUniTaskAsyncEnumerable<T11> source11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400069F")]
		private readonly IUniTaskAsyncEnumerable<T10> source10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400069E")]
		private readonly IUniTaskAsyncEnumerable<T9> source9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400069D")]
		private readonly IUniTaskAsyncEnumerable<T8> source8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400069C")]
		private readonly IUniTaskAsyncEnumerable<T7> source7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400069B")]
		private readonly IUniTaskAsyncEnumerable<T6> source6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400069A")]
		private readonly IUniTaskAsyncEnumerable<T5> source5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000699")]
		private readonly IUniTaskAsyncEnumerable<T4> source4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000698")]
		private readonly IUniTaskAsyncEnumerable<T3> source3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000697")]
		private readonly IUniTaskAsyncEnumerable<T2> source2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000696")]
		private readonly IUniTaskAsyncEnumerable<T1> source1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006A9")]
		private bool running1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006C1")]
		private bool hasCurrent6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006AA")]
		private T1 current1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006AC")]
		private Awaiter<Boolean> awaiter2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006BF")]
		private IUniTaskAsyncEnumerator<T6> enumerator6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006BE")]
		private T5 current5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006BD")]
		private bool running5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006BC")]
		private bool hasCurrent5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006BB")]
		private Awaiter<Boolean> awaiter5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006ED")]
		private bool syncRunning; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006B9")]
		private T4 current4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006B8")]
		private bool running4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006B7")]
		private bool hasCurrent4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006B6")]
		private Awaiter<Boolean> awaiter4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006B5")]
		private IUniTaskAsyncEnumerator<T4> enumerator4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006B4")]
		private T3 current3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006B3")]
		private bool running3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006B2")]
		private bool hasCurrent3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006B1")]
		private Awaiter<Boolean> awaiter3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006B0")]
		private IUniTaskAsyncEnumerator<T3> enumerator3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006AF")]
		private T2 current2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006AE")]
		private bool running2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006AD")]
		private bool hasCurrent2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006AB")]
		private IUniTaskAsyncEnumerator<T2> enumerator2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006EE")]
		private TResult result; //Field offset: 0x0

		[Token(Token = "0x17000014")]
		public override TResult Current
		{
			[Address(RVA = "0x15C57C0", Offset = "0x15C4BC0", Length = "0xB3")]
			[Token(Token = "0x60003CE")]
			 get { } //Length: 179
		}

		[Address(RVA = "0x15C1D50", Offset = "0x15C1150", Length = "0xAF4")]
		[Token(Token = "0x60003E0")]
		private static _CombineLatest() { }

		[Address(RVA = "0x15C5260", Offset = "0x15C4660", Length = "0x557")]
		[Token(Token = "0x60003CD")]
		public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, IUniTaskAsyncEnumerable<T12> source12, IUniTaskAsyncEnumerable<T13> source13, IUniTaskAsyncEnumerable<T14> source14, Func5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> resultSelector, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1589A10", Offset = "0x1588E10", Length = "0x78F")]
		[Token(Token = "0x60003D0")]
		private static void Completed1(object state) { }

		[Address(RVA = "0x1580190", Offset = "0x157F590", Length = "0x790")]
		[Token(Token = "0x60003D9")]
		private static void Completed10(object state) { }

		[Address(RVA = "0x1582F50", Offset = "0x1582350", Length = "0x790")]
		[Token(Token = "0x60003DA")]
		private static void Completed11(object state) { }

		[Address(RVA = "0x1585570", Offset = "0x1584970", Length = "0x790")]
		[Token(Token = "0x60003DB")]
		private static void Completed12(object state) { }

		[Address(RVA = "0x1587B90", Offset = "0x1586F90", Length = "0x790")]
		[Token(Token = "0x60003DC")]
		private static void Completed13(object state) { }

		[Address(RVA = "0x1588AD0", Offset = "0x1587ED0", Length = "0x790")]
		[Token(Token = "0x60003DD")]
		private static void Completed14(object state) { }

		[Address(RVA = "0x158E5F0", Offset = "0x158D9F0", Length = "0x790")]
		[Token(Token = "0x60003D1")]
		private static void Completed2(object state) { }

		[Address(RVA = "0x1590C10", Offset = "0x1590010", Length = "0x790")]
		[Token(Token = "0x60003D2")]
		private static void Completed3(object state) { }

		[Address(RVA = "0x1593230", Offset = "0x1592630", Length = "0x790")]
		[Token(Token = "0x60003D3")]
		private static void Completed4(object state) { }

		[Address(RVA = "0x1595FF0", Offset = "0x15953F0", Length = "0x790")]
		[Token(Token = "0x60003D4")]
		private static void Completed5(object state) { }

		[Address(RVA = "0x1598DB0", Offset = "0x15981B0", Length = "0x790")]
		[Token(Token = "0x60003D5")]
		private static void Completed6(object state) { }

		[Address(RVA = "0x159B3D0", Offset = "0x159A7D0", Length = "0x790")]
		[Token(Token = "0x60003D6")]
		private static void Completed7(object state) { }

		[Address(RVA = "0x159D9F0", Offset = "0x159CDF0", Length = "0x790")]
		[Token(Token = "0x60003D7")]
		private static void Completed8(object state) { }

		[Address(RVA = "0x15A1E90", Offset = "0x15A1290", Length = "0x790")]
		[Token(Token = "0x60003D8")]
		private static void Completed9(object state) { }

		[Address(RVA = "0x15A36D0", Offset = "0x15A2AD0", Length = "0xA7")]
		[AsyncStateMachine(typeof(<DisposeAsync>d__123))]
		[Token(Token = "0x60003DF")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x15C57C0", Offset = "0x15C4BC0", Length = "0xB3")]
		[Token(Token = "0x60003CE")]
		public override TResult get_Current() { }

		[Address(RVA = "0x15B74E0", Offset = "0x15B68E0", Length = "0x44CB")]
		[Token(Token = "0x60003CF")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x15BD100", Offset = "0x15BC500", Length = "0xCF7")]
		[Token(Token = "0x60003DE")]
		private bool TrySetResult() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000678")]
	private readonly IUniTaskAsyncEnumerable<T1> source1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000679")]
	private readonly IUniTaskAsyncEnumerable<T2> source2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400067A")]
	private readonly IUniTaskAsyncEnumerable<T3> source3; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400067B")]
	private readonly IUniTaskAsyncEnumerable<T4> source4; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400067C")]
	private readonly IUniTaskAsyncEnumerable<T5> source5; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400067D")]
	private readonly IUniTaskAsyncEnumerable<T6> source6; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400067E")]
	private readonly IUniTaskAsyncEnumerable<T7> source7; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400067F")]
	private readonly IUniTaskAsyncEnumerable<T8> source8; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000680")]
	private readonly IUniTaskAsyncEnumerable<T9> source9; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000681")]
	private readonly IUniTaskAsyncEnumerable<T10> source10; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000682")]
	private readonly IUniTaskAsyncEnumerable<T11> source11; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000683")]
	private readonly IUniTaskAsyncEnumerable<T12> source12; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000684")]
	private readonly IUniTaskAsyncEnumerable<T13> source13; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000685")]
	private readonly IUniTaskAsyncEnumerable<T14> source14; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000686")]
	private readonly Func5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> resultSelector; //Field offset: 0x0

	[Address(RVA = "0x16D8710", Offset = "0x16D7B10", Length = "0x15B")]
	[Token(Token = "0x60003CB")]
	public CombineLatest`15(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, IUniTaskAsyncEnumerable<T12> source12, IUniTaskAsyncEnumerable<T13> source13, IUniTaskAsyncEnumerable<T14> source14, Func5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> resultSelector) { }

	[Address(RVA = "0x16D8560", Offset = "0x16D7960", Length = "0x1AE")]
	[Token(Token = "0x60003CC")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

