namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000086")]
internal class CombineLatest6 : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x2000087")]
	private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x2000088")]
		private struct <DisposeAsync>d__131 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000772")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000773")]
			public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000774")]
			public _CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000775")]
			private Awaiter <>u__1; //Field offset: 0x0

			[Address(RVA = "0x16E60E0", Offset = "0x16E54E0", Length = "0x1870")]
			[Token(Token = "0x60003FA")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x60003FB")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x4000703")]
		private static readonly Action<Object> Completed1Delegate; //Field offset: 0x0
		[Token(Token = "0x4000712")]
		private const int CompleteCount = 15; //Field offset: 0x0
		[Token(Token = "0x4000711")]
		private static readonly Action<Object> Completed15Delegate; //Field offset: 0x0
		[Token(Token = "0x4000710")]
		private static readonly Action<Object> Completed14Delegate; //Field offset: 0x0
		[Token(Token = "0x400070E")]
		private static readonly Action<Object> Completed12Delegate; //Field offset: 0x0
		[Token(Token = "0x400070D")]
		private static readonly Action<Object> Completed11Delegate; //Field offset: 0x0
		[Token(Token = "0x400070C")]
		private static readonly Action<Object> Completed10Delegate; //Field offset: 0x0
		[Token(Token = "0x400070B")]
		private static readonly Action<Object> Completed9Delegate; //Field offset: 0x0
		[Token(Token = "0x400070F")]
		private static readonly Action<Object> Completed13Delegate; //Field offset: 0x0
		[Token(Token = "0x4000709")]
		private static readonly Action<Object> Completed7Delegate; //Field offset: 0x0
		[Token(Token = "0x4000708")]
		private static readonly Action<Object> Completed6Delegate; //Field offset: 0x0
		[Token(Token = "0x4000707")]
		private static readonly Action<Object> Completed5Delegate; //Field offset: 0x0
		[Token(Token = "0x4000706")]
		private static readonly Action<Object> Completed4Delegate; //Field offset: 0x0
		[Token(Token = "0x4000705")]
		private static readonly Action<Object> Completed3Delegate; //Field offset: 0x0
		[Token(Token = "0x4000704")]
		private static readonly Action<Object> Completed2Delegate; //Field offset: 0x0
		[Token(Token = "0x400070A")]
		private static readonly Action<Object> Completed8Delegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000750")]
		private T9 current9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000751")]
		private IUniTaskAsyncEnumerator<T10> enumerator10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000752")]
		private Awaiter<Boolean> awaiter10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000753")]
		private bool hasCurrent10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000756")]
		private IUniTaskAsyncEnumerator<T11> enumerator11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000755")]
		private T10 current10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000757")]
		private Awaiter<Boolean> awaiter11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400074F")]
		private bool running9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000754")]
		private bool running10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400074E")]
		private bool hasCurrent9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000746")]
		private T7 current7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400074C")]
		private IUniTaskAsyncEnumerator<T9> enumerator9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400074B")]
		private T8 current8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400074A")]
		private bool running8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000749")]
		private bool hasCurrent8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000748")]
		private Awaiter<Boolean> awaiter8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000747")]
		private IUniTaskAsyncEnumerator<T8> enumerator8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000758")]
		private bool hasCurrent11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000745")]
		private bool running7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000744")]
		private bool hasCurrent7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400074D")]
		private Awaiter<Boolean> awaiter9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000759")]
		private bool running11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000761")]
		private Awaiter<Boolean> awaiter13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400075B")]
		private IUniTaskAsyncEnumerator<T12> enumerator12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400076F")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400076E")]
		private T15 current15; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400076D")]
		private bool running15; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400076C")]
		private bool hasCurrent15; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400076B")]
		private Awaiter<Boolean> awaiter15; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400076A")]
		private IUniTaskAsyncEnumerator<T15> enumerator15; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000769")]
		private T14 current14; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000768")]
		private bool running14; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000767")]
		private bool hasCurrent14; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400075A")]
		private T11 current11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000766")]
		private Awaiter<Boolean> awaiter14; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000764")]
		private T13 current13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000763")]
		private bool running13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000762")]
		private bool hasCurrent13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000743")]
		private Awaiter<Boolean> awaiter7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000760")]
		private IUniTaskAsyncEnumerator<T13> enumerator13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400075F")]
		private T12 current12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400075E")]
		private bool running12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400075D")]
		private bool hasCurrent12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400075C")]
		private Awaiter<Boolean> awaiter12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000765")]
		private IUniTaskAsyncEnumerator<T14> enumerator14; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000742")]
		private IUniTaskAsyncEnumerator<T7> enumerator7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400073A")]
		private bool hasCurrent5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000740")]
		private bool running6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000726")]
		private bool hasCurrent1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000725")]
		private Awaiter<Boolean> awaiter1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000724")]
		private IUniTaskAsyncEnumerator<T1> enumerator1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000723")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000722")]
		private readonly Func6<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000721")]
		private readonly IUniTaskAsyncEnumerable<T15> source15; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000720")]
		private readonly IUniTaskAsyncEnumerable<T14> source14; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400071F")]
		private readonly IUniTaskAsyncEnumerable<T13> source13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400071E")]
		private readonly IUniTaskAsyncEnumerable<T12> source12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000727")]
		private bool running1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400071D")]
		private readonly IUniTaskAsyncEnumerable<T11> source11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400071B")]
		private readonly IUniTaskAsyncEnumerable<T9> source9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400071A")]
		private readonly IUniTaskAsyncEnumerable<T8> source8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000719")]
		private readonly IUniTaskAsyncEnumerable<T7> source7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000718")]
		private readonly IUniTaskAsyncEnumerable<T6> source6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000717")]
		private readonly IUniTaskAsyncEnumerable<T5> source5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000716")]
		private readonly IUniTaskAsyncEnumerable<T4> source4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000715")]
		private readonly IUniTaskAsyncEnumerable<T3> source3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000714")]
		private readonly IUniTaskAsyncEnumerable<T2> source2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000713")]
		private readonly IUniTaskAsyncEnumerable<T1> source1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400071C")]
		private readonly IUniTaskAsyncEnumerable<T10> source10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000728")]
		private T1 current1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000729")]
		private IUniTaskAsyncEnumerator<T2> enumerator2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400072A")]
		private Awaiter<Boolean> awaiter2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400073F")]
		private bool hasCurrent6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400073E")]
		private Awaiter<Boolean> awaiter6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400073D")]
		private IUniTaskAsyncEnumerator<T6> enumerator6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400073C")]
		private T5 current5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400073B")]
		private bool running5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000770")]
		private bool syncRunning; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000739")]
		private Awaiter<Boolean> awaiter5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000738")]
		private IUniTaskAsyncEnumerator<T5> enumerator5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000737")]
		private T4 current4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000736")]
		private bool running4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000735")]
		private bool hasCurrent4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000734")]
		private Awaiter<Boolean> awaiter4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000733")]
		private IUniTaskAsyncEnumerator<T4> enumerator4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000732")]
		private T3 current3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000731")]
		private bool running3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000730")]
		private bool hasCurrent3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400072F")]
		private Awaiter<Boolean> awaiter3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400072E")]
		private IUniTaskAsyncEnumerator<T3> enumerator3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400072D")]
		private T2 current2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400072C")]
		private bool running2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400072B")]
		private bool hasCurrent2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000741")]
		private T6 current6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000771")]
		private TResult result; //Field offset: 0x0

		[Token(Token = "0x17000015")]
		public override TResult Current
		{
			[Address(RVA = "0x15C5A90", Offset = "0x15C4E90", Length = "0xB3")]
			[Token(Token = "0x60003E6")]
			 get { } //Length: 179
		}

		[Address(RVA = "0x15BFF80", Offset = "0x15BF380", Length = "0xBB9")]
		[Token(Token = "0x60003F9")]
		private static _CombineLatest() { }

		[Address(RVA = "0x15C4390", Offset = "0x15C3790", Length = "0x5AA")]
		[Token(Token = "0x60003E5")]
		public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, IUniTaskAsyncEnumerable<T12> source12, IUniTaskAsyncEnumerable<T13> source13, IUniTaskAsyncEnumerable<T14> source14, IUniTaskAsyncEnumerable<T15> source15, Func6<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> resultSelector, CancellationToken cancellationToken) { }

		[Address(RVA = "0x158A930", Offset = "0x1589D30", Length = "0x78F")]
		[Token(Token = "0x60003E8")]
		private static void Completed1(object state) { }

		[Address(RVA = "0x1581870", Offset = "0x1580C70", Length = "0x790")]
		[Token(Token = "0x60003F1")]
		private static void Completed10(object state) { }

		[Address(RVA = "0x15836F0", Offset = "0x1582AF0", Length = "0x790")]
		[Token(Token = "0x60003F2")]
		private static void Completed11(object state) { }

		[Address(RVA = "0x1585D10", Offset = "0x1585110", Length = "0x790")]
		[Token(Token = "0x60003F3")]
		private static void Completed12(object state) { }

		[Address(RVA = "0x15873F0", Offset = "0x15867F0", Length = "0x790")]
		[Token(Token = "0x60003F4")]
		private static void Completed13(object state) { }

		[Address(RVA = "0x1588330", Offset = "0x1587730", Length = "0x790")]
		[Token(Token = "0x60003F5")]
		private static void Completed14(object state) { }

		[Address(RVA = "0x1589270", Offset = "0x1588670", Length = "0x790")]
		[Token(Token = "0x60003F6")]
		private static void Completed15(object state) { }

		[Address(RVA = "0x158CF10", Offset = "0x158C310", Length = "0x790")]
		[Token(Token = "0x60003E9")]
		private static void Completed2(object state) { }

		[Address(RVA = "0x15913B0", Offset = "0x15907B0", Length = "0x790")]
		[Token(Token = "0x60003EA")]
		private static void Completed3(object state) { }

		[Address(RVA = "0x1594910", Offset = "0x1593D10", Length = "0x790")]
		[Token(Token = "0x60003EB")]
		private static void Completed4(object state) { }

		[Address(RVA = "0x1595850", Offset = "0x1594C50", Length = "0x790")]
		[Token(Token = "0x60003EC")]
		private static void Completed5(object state) { }

		[Address(RVA = "0x159A490", Offset = "0x1599890", Length = "0x790")]
		[Token(Token = "0x60003ED")]
		private static void Completed6(object state) { }

		[Address(RVA = "0x159BB70", Offset = "0x159AF70", Length = "0x790")]
		[Token(Token = "0x60003EE")]
		private static void Completed7(object state) { }

		[Address(RVA = "0x159F870", Offset = "0x159EC70", Length = "0x790")]
		[Token(Token = "0x60003EF")]
		private static void Completed8(object state) { }

		[Address(RVA = "0x15A2630", Offset = "0x15A1A30", Length = "0x790")]
		[Token(Token = "0x60003F0")]
		private static void Completed9(object state) { }

		[Address(RVA = "0x15A3830", Offset = "0x15A2C30", Length = "0xA7")]
		[AsyncStateMachine(typeof(<DisposeAsync>d__131))]
		[Token(Token = "0x60003F8")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x15C5A90", Offset = "0x15C4E90", Length = "0xB3")]
		[Token(Token = "0x60003E6")]
		public override TResult get_Current() { }

		[Address(RVA = "0x15A7B50", Offset = "0x15A6F50", Length = "0x477B")]
		[Token(Token = "0x60003E7")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x15BE760", Offset = "0x15BDB60", Length = "0xDD9")]
		[Token(Token = "0x60003F7")]
		private bool TrySetResult() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006F3")]
	private readonly IUniTaskAsyncEnumerable<T1> source1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006F4")]
	private readonly IUniTaskAsyncEnumerable<T2> source2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006F5")]
	private readonly IUniTaskAsyncEnumerable<T3> source3; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006F6")]
	private readonly IUniTaskAsyncEnumerable<T4> source4; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006F7")]
	private readonly IUniTaskAsyncEnumerable<T5> source5; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006F8")]
	private readonly IUniTaskAsyncEnumerable<T6> source6; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006F9")]
	private readonly IUniTaskAsyncEnumerable<T7> source7; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006FA")]
	private readonly IUniTaskAsyncEnumerable<T8> source8; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006FB")]
	private readonly IUniTaskAsyncEnumerable<T9> source9; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006FC")]
	private readonly IUniTaskAsyncEnumerable<T10> source10; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006FD")]
	private readonly IUniTaskAsyncEnumerable<T11> source11; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006FE")]
	private readonly IUniTaskAsyncEnumerable<T12> source12; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006FF")]
	private readonly IUniTaskAsyncEnumerable<T13> source13; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000700")]
	private readonly IUniTaskAsyncEnumerable<T14> source14; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000701")]
	private readonly IUniTaskAsyncEnumerable<T15> source15; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000702")]
	private readonly Func6<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> resultSelector; //Field offset: 0x0

	[Address(RVA = "0x16D8A40", Offset = "0x16D7E40", Length = "0x176")]
	[Token(Token = "0x60003E3")]
	public CombineLatest`16(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, IUniTaskAsyncEnumerable<T12> source12, IUniTaskAsyncEnumerable<T13> source13, IUniTaskAsyncEnumerable<T14> source14, IUniTaskAsyncEnumerable<T15> source15, Func6<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> resultSelector) { }

	[Address(RVA = "0x16D8870", Offset = "0x16D7C70", Length = "0x1CD")]
	[Token(Token = "0x60003E4")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

