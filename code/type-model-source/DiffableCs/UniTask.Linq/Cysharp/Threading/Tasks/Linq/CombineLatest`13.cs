namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200007D")]
internal class CombineLatest3 : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x200007E")]
	private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x200007F")]
		private struct <DisposeAsync>d__107 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000601")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000602")]
			public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000603")]
			public _CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000604")]
			private Awaiter <>u__1; //Field offset: 0x0

			[Address(RVA = "0x1155060", Offset = "0x1154460", Length = "0x142C")]
			[Token(Token = "0x60003B2")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x60003B3")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x40005A7")]
		private static readonly Action<Object> Completed1Delegate; //Field offset: 0x0
		[Token(Token = "0x40005B3")]
		private const int CompleteCount = 12; //Field offset: 0x0
		[Token(Token = "0x40005B2")]
		private static readonly Action<Object> Completed12Delegate; //Field offset: 0x0
		[Token(Token = "0x40005B1")]
		private static readonly Action<Object> Completed11Delegate; //Field offset: 0x0
		[Token(Token = "0x40005AF")]
		private static readonly Action<Object> Completed9Delegate; //Field offset: 0x0
		[Token(Token = "0x40005AE")]
		private static readonly Action<Object> Completed8Delegate; //Field offset: 0x0
		[Token(Token = "0x40005B0")]
		private static readonly Action<Object> Completed10Delegate; //Field offset: 0x0
		[Token(Token = "0x40005AC")]
		private static readonly Action<Object> Completed6Delegate; //Field offset: 0x0
		[Token(Token = "0x40005AB")]
		private static readonly Action<Object> Completed5Delegate; //Field offset: 0x0
		[Token(Token = "0x40005AA")]
		private static readonly Action<Object> Completed4Delegate; //Field offset: 0x0
		[Token(Token = "0x40005A9")]
		private static readonly Action<Object> Completed3Delegate; //Field offset: 0x0
		[Token(Token = "0x40005A8")]
		private static readonly Action<Object> Completed2Delegate; //Field offset: 0x0
		[Token(Token = "0x40005AD")]
		private static readonly Action<Object> Completed7Delegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005E5")]
		private IUniTaskAsyncEnumerator<T8> enumerator8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005EA")]
		private IUniTaskAsyncEnumerator<T9> enumerator9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005E9")]
		private T8 current8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005E8")]
		private bool running8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005E7")]
		private bool hasCurrent8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005E6")]
		private Awaiter<Boolean> awaiter8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005E4")]
		private T7 current7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005DD")]
		private bool hasCurrent6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005E2")]
		private bool hasCurrent7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005E1")]
		private Awaiter<Boolean> awaiter7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005E0")]
		private IUniTaskAsyncEnumerator<T7> enumerator7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005DF")]
		private T6 current6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005DE")]
		private bool running6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005EB")]
		private Awaiter<Boolean> awaiter9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005DC")]
		private Awaiter<Boolean> awaiter6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005E3")]
		private bool running7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005EC")]
		private bool hasCurrent9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005F3")]
		private T10 current10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005EE")]
		private T9 current9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005FE")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005FD")]
		private T12 current12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005FC")]
		private bool running12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005FB")]
		private bool hasCurrent12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005FA")]
		private Awaiter<Boolean> awaiter12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005F9")]
		private IUniTaskAsyncEnumerator<T12> enumerator12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005F8")]
		private T11 current11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005ED")]
		private bool running9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005F7")]
		private bool running11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005F5")]
		private Awaiter<Boolean> awaiter11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005F4")]
		private IUniTaskAsyncEnumerator<T11> enumerator11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005DB")]
		private IUniTaskAsyncEnumerator<T6> enumerator6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005F2")]
		private bool running10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005F1")]
		private bool hasCurrent10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005F0")]
		private Awaiter<Boolean> awaiter10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005EF")]
		private IUniTaskAsyncEnumerator<T10> enumerator10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005F6")]
		private bool hasCurrent11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005DA")]
		private T5 current5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005D3")]
		private bool hasCurrent4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005D8")]
		private bool hasCurrent5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005C3")]
		private Awaiter<Boolean> awaiter1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005C2")]
		private IUniTaskAsyncEnumerator<T1> enumerator1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005C1")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005C0")]
		private readonly Func3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005BF")]
		private readonly IUniTaskAsyncEnumerable<T12> source12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005BE")]
		private readonly IUniTaskAsyncEnumerable<T11> source11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005BD")]
		private readonly IUniTaskAsyncEnumerable<T10> source10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005C4")]
		private bool hasCurrent1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005BC")]
		private readonly IUniTaskAsyncEnumerable<T9> source9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005BA")]
		private readonly IUniTaskAsyncEnumerable<T7> source7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005B9")]
		private readonly IUniTaskAsyncEnumerable<T6> source6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005B8")]
		private readonly IUniTaskAsyncEnumerable<T5> source5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005B7")]
		private readonly IUniTaskAsyncEnumerable<T4> source4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005B6")]
		private readonly IUniTaskAsyncEnumerable<T3> source3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005B5")]
		private readonly IUniTaskAsyncEnumerable<T2> source2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005B4")]
		private readonly IUniTaskAsyncEnumerable<T1> source1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005BB")]
		private readonly IUniTaskAsyncEnumerable<T8> source8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005D9")]
		private bool running5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005C5")]
		private bool running1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005C7")]
		private IUniTaskAsyncEnumerator<T2> enumerator2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005D7")]
		private Awaiter<Boolean> awaiter5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005D6")]
		private IUniTaskAsyncEnumerator<T5> enumerator5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005D5")]
		private T4 current4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005D4")]
		private bool running4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005FF")]
		private bool syncRunning; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005D2")]
		private Awaiter<Boolean> awaiter4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005D1")]
		private IUniTaskAsyncEnumerator<T4> enumerator4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005C6")]
		private T1 current1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005D0")]
		private T3 current3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005CE")]
		private bool hasCurrent3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005CD")]
		private Awaiter<Boolean> awaiter3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005CC")]
		private IUniTaskAsyncEnumerator<T3> enumerator3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005CB")]
		private T2 current2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005CA")]
		private bool running2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005C9")]
		private bool hasCurrent2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005C8")]
		private Awaiter<Boolean> awaiter2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005CF")]
		private bool running3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000600")]
		private TResult result; //Field offset: 0x0

		[Token(Token = "0x17000012")]
		public override TResult Current
		{
			[Address(RVA = "0x15C59E0", Offset = "0x15C4DE0", Length = "0xB0")]
			[Token(Token = "0x60003A1")]
			 get { } //Length: 176
		}

		[Address(RVA = "0x15C2850", Offset = "0x15C1C50", Length = "0x96A")]
		[Token(Token = "0x60003B1")]
		private static _CombineLatest() { }

		[Address(RVA = "0x15C4940", Offset = "0x15C3D40", Length = "0x4B1")]
		[Token(Token = "0x60003A0")]
		public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, IUniTaskAsyncEnumerable<T12> source12, Func3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> resultSelector, CancellationToken cancellationToken) { }

		[Address(RVA = "0x158B0C0", Offset = "0x158A4C0", Length = "0x789")]
		[Token(Token = "0x60003A3")]
		private static void Completed1(object state) { }

		[Address(RVA = "0x157F9F0", Offset = "0x157EDF0", Length = "0x790")]
		[Token(Token = "0x60003AC")]
		private static void Completed10(object state) { }

		[Address(RVA = "0x1583E90", Offset = "0x1583290", Length = "0x790")]
		[Token(Token = "0x60003AD")]
		private static void Completed11(object state) { }

		[Address(RVA = "0x1584DD0", Offset = "0x15841D0", Length = "0x790")]
		[Token(Token = "0x60003AE")]
		private static void Completed12(object state) { }

		[Address(RVA = "0x158C770", Offset = "0x158BB70", Length = "0x790")]
		[Token(Token = "0x60003A4")]
		private static void Completed2(object state) { }

		[Address(RVA = "0x158F530", Offset = "0x158E930", Length = "0x790")]
		[Token(Token = "0x60003A5")]
		private static void Completed3(object state) { }

		[Address(RVA = "0x1592A90", Offset = "0x1591E90", Length = "0x790")]
		[Token(Token = "0x60003A6")]
		private static void Completed4(object state) { }

		[Address(RVA = "0x1596790", Offset = "0x1595B90", Length = "0x790")]
		[Token(Token = "0x60003A7")]
		private static void Completed5(object state) { }

		[Address(RVA = "0x1597E70", Offset = "0x1597270", Length = "0x790")]
		[Token(Token = "0x60003A8")]
		private static void Completed6(object state) { }

		[Address(RVA = "0x159C310", Offset = "0x159B710", Length = "0x790")]
		[Token(Token = "0x60003A9")]
		private static void Completed7(object state) { }

		[Address(RVA = "0x159E930", Offset = "0x159DD30", Length = "0x790")]
		[Token(Token = "0x60003AA")]
		private static void Completed8(object state) { }

		[Address(RVA = "0x15A0F50", Offset = "0x15A0350", Length = "0x790")]
		[Token(Token = "0x60003AB")]
		private static void Completed9(object state) { }

		[Address(RVA = "0x15A3620", Offset = "0x15A2A20", Length = "0xA7")]
		[AsyncStateMachine(typeof(<DisposeAsync>d__107))]
		[Token(Token = "0x60003B0")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x15C59E0", Offset = "0x15C4DE0", Length = "0xB0")]
		[Token(Token = "0x60003A1")]
		public override TResult get_Current() { }

		[Address(RVA = "0x15AC2D0", Offset = "0x15AB6D0", Length = "0x3ECB")]
		[Token(Token = "0x60003A2")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x15BB9B0", Offset = "0x15BADB0", Length = "0xB25")]
		[Token(Token = "0x60003AF")]
		private bool TrySetResult() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400059A")]
	private readonly IUniTaskAsyncEnumerable<T1> source1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400059B")]
	private readonly IUniTaskAsyncEnumerable<T2> source2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400059C")]
	private readonly IUniTaskAsyncEnumerable<T3> source3; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400059D")]
	private readonly IUniTaskAsyncEnumerable<T4> source4; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400059E")]
	private readonly IUniTaskAsyncEnumerable<T5> source5; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400059F")]
	private readonly IUniTaskAsyncEnumerable<T6> source6; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005A0")]
	private readonly IUniTaskAsyncEnumerable<T7> source7; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005A1")]
	private readonly IUniTaskAsyncEnumerable<T8> source8; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005A2")]
	private readonly IUniTaskAsyncEnumerable<T9> source9; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005A3")]
	private readonly IUniTaskAsyncEnumerable<T10> source10; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005A4")]
	private readonly IUniTaskAsyncEnumerable<T11> source11; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005A5")]
	private readonly IUniTaskAsyncEnumerable<T12> source12; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005A6")]
	private readonly Func3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> resultSelector; //Field offset: 0x0

	[Address(RVA = "0x16D8160", Offset = "0x16D7560", Length = "0x12B")]
	[Token(Token = "0x600039E")]
	public CombineLatest`13(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, IUniTaskAsyncEnumerable<T12> source12, Func3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> resultSelector) { }

	[Address(RVA = "0x16D7FF0", Offset = "0x16D73F0", Length = "0x16D")]
	[Token(Token = "0x600039F")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

