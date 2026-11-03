namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000080")]
internal class CombineLatest4 : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x2000081")]
	private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x2000082")]
		private struct <DisposeAsync>d__115 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000674")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000675")]
			public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000676")]
			public _CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000677")]
			private Awaiter <>u__1; //Field offset: 0x0

			[Address(RVA = "0x16E2F80", Offset = "0x16E2380", Length = "0x15A8")]
			[Token(Token = "0x60003C9")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x60003CA")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x4000613")]
		private static readonly Action<Object> Completed1Delegate; //Field offset: 0x0
		[Token(Token = "0x4000620")]
		private const int CompleteCount = 13; //Field offset: 0x0
		[Token(Token = "0x400061F")]
		private static readonly Action<Object> Completed13Delegate; //Field offset: 0x0
		[Token(Token = "0x400061E")]
		private static readonly Action<Object> Completed12Delegate; //Field offset: 0x0
		[Token(Token = "0x400061C")]
		private static readonly Action<Object> Completed10Delegate; //Field offset: 0x0
		[Token(Token = "0x400061B")]
		private static readonly Action<Object> Completed9Delegate; //Field offset: 0x0
		[Token(Token = "0x400061A")]
		private static readonly Action<Object> Completed8Delegate; //Field offset: 0x0
		[Token(Token = "0x400061D")]
		private static readonly Action<Object> Completed11Delegate; //Field offset: 0x0
		[Token(Token = "0x4000618")]
		private static readonly Action<Object> Completed6Delegate; //Field offset: 0x0
		[Token(Token = "0x4000617")]
		private static readonly Action<Object> Completed5Delegate; //Field offset: 0x0
		[Token(Token = "0x4000616")]
		private static readonly Action<Object> Completed4Delegate; //Field offset: 0x0
		[Token(Token = "0x4000615")]
		private static readonly Action<Object> Completed3Delegate; //Field offset: 0x0
		[Token(Token = "0x4000614")]
		private static readonly Action<Object> Completed2Delegate; //Field offset: 0x0
		[Token(Token = "0x4000619")]
		private static readonly Action<Object> Completed7Delegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000656")]
		private bool running8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400065C")]
		private T9 current9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400065B")]
		private bool running9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400065A")]
		private bool hasCurrent9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000659")]
		private Awaiter<Boolean> awaiter9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000658")]
		private IUniTaskAsyncEnumerator<T9> enumerator9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000657")]
		private T8 current8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000655")]
		private bool hasCurrent8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400064E")]
		private IUniTaskAsyncEnumerator<T7> enumerator7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000653")]
		private IUniTaskAsyncEnumerator<T8> enumerator8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000652")]
		private T7 current7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000651")]
		private bool running7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000650")]
		private bool hasCurrent7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400064F")]
		private Awaiter<Boolean> awaiter7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400065D")]
		private IUniTaskAsyncEnumerator<T10> enumerator10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400064D")]
		private T6 current6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400064C")]
		private bool running6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000654")]
		private Awaiter<Boolean> awaiter8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400065E")]
		private Awaiter<Boolean> awaiter10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000665")]
		private bool running11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000660")]
		private bool running10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000671")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000670")]
		private T13 current13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400066F")]
		private bool running13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400066E")]
		private bool hasCurrent13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400066D")]
		private Awaiter<Boolean> awaiter13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400066C")]
		private IUniTaskAsyncEnumerator<T13> enumerator13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400066B")]
		private T12 current12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400066A")]
		private bool running12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000669")]
		private bool hasCurrent12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000668")]
		private Awaiter<Boolean> awaiter12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000667")]
		private IUniTaskAsyncEnumerator<T12> enumerator12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000666")]
		private T11 current11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400064B")]
		private bool hasCurrent6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000664")]
		private bool hasCurrent11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000663")]
		private Awaiter<Boolean> awaiter11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000662")]
		private IUniTaskAsyncEnumerator<T11> enumerator11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000661")]
		private T10 current10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400065F")]
		private bool hasCurrent10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400064A")]
		private Awaiter<Boolean> awaiter6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000643")]
		private T4 current4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000648")]
		private T5 current5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000631")]
		private Awaiter<Boolean> awaiter1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000630")]
		private IUniTaskAsyncEnumerator<T1> enumerator1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400062F")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400062E")]
		private readonly Func4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400062D")]
		private readonly IUniTaskAsyncEnumerable<T13> source13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400062C")]
		private readonly IUniTaskAsyncEnumerable<T12> source12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400062B")]
		private readonly IUniTaskAsyncEnumerable<T11> source11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400062A")]
		private readonly IUniTaskAsyncEnumerable<T10> source10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000629")]
		private readonly IUniTaskAsyncEnumerable<T9> source9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000628")]
		private readonly IUniTaskAsyncEnumerable<T8> source8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000627")]
		private readonly IUniTaskAsyncEnumerable<T7> source7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000626")]
		private readonly IUniTaskAsyncEnumerable<T6> source6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000625")]
		private readonly IUniTaskAsyncEnumerable<T5> source5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000624")]
		private readonly IUniTaskAsyncEnumerable<T4> source4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000623")]
		private readonly IUniTaskAsyncEnumerable<T3> source3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000622")]
		private readonly IUniTaskAsyncEnumerable<T2> source2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000621")]
		private readonly IUniTaskAsyncEnumerable<T1> source1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000632")]
		private bool hasCurrent1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000633")]
		private bool running1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000634")]
		private T1 current1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000635")]
		private IUniTaskAsyncEnumerator<T2> enumerator2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000647")]
		private bool running5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000646")]
		private bool hasCurrent5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000645")]
		private Awaiter<Boolean> awaiter5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000644")]
		private IUniTaskAsyncEnumerator<T5> enumerator5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000672")]
		private bool syncRunning; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000642")]
		private bool running4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000641")]
		private bool hasCurrent4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000640")]
		private Awaiter<Boolean> awaiter4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000649")]
		private IUniTaskAsyncEnumerator<T6> enumerator6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400063F")]
		private IUniTaskAsyncEnumerator<T4> enumerator4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400063D")]
		private bool running3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400063C")]
		private bool hasCurrent3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400063B")]
		private Awaiter<Boolean> awaiter3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400063A")]
		private IUniTaskAsyncEnumerator<T3> enumerator3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000639")]
		private T2 current2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000638")]
		private bool running2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000637")]
		private bool hasCurrent2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000636")]
		private Awaiter<Boolean> awaiter2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400063E")]
		private T3 current3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000673")]
		private TResult result; //Field offset: 0x0

		[Token(Token = "0x17000013")]
		public override TResult Current
		{
			[Address(RVA = "0x15C5880", Offset = "0x15C4C80", Length = "0xB0")]
			[Token(Token = "0x60003B7")]
			 get { } //Length: 176
		}

		[Address(RVA = "0x15C1320", Offset = "0x15C0720", Length = "0xA2F")]
		[Token(Token = "0x60003C8")]
		private static _CombineLatest() { }

		[Address(RVA = "0x15C3A70", Offset = "0x15C2E70", Length = "0x504")]
		[Token(Token = "0x60003B6")]
		public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, IUniTaskAsyncEnumerable<T12> source12, IUniTaskAsyncEnumerable<T13> source13, Func4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> resultSelector, CancellationToken cancellationToken) { }

		[Address(RVA = "0x158BFE0", Offset = "0x158B3E0", Length = "0x78F")]
		[Token(Token = "0x60003B9")]
		private static void Completed1(object state) { }

		[Address(RVA = "0x1580930", Offset = "0x157FD30", Length = "0x790")]
		[Token(Token = "0x60003C2")]
		private static void Completed10(object state) { }

		[Address(RVA = "0x1584630", Offset = "0x1583A30", Length = "0x790")]
		[Token(Token = "0x60003C3")]
		private static void Completed11(object state) { }

		[Address(RVA = "0x15864B0", Offset = "0x15858B0", Length = "0x790")]
		[Token(Token = "0x60003C4")]
		private static void Completed12(object state) { }

		[Address(RVA = "0x1586C50", Offset = "0x1586050", Length = "0x790")]
		[Token(Token = "0x60003C5")]
		private static void Completed13(object state) { }

		[Address(RVA = "0x158DE50", Offset = "0x158D250", Length = "0x790")]
		[Token(Token = "0x60003BA")]
		private static void Completed2(object state) { }

		[Address(RVA = "0x158FCD0", Offset = "0x158F0D0", Length = "0x790")]
		[Token(Token = "0x60003BB")]
		private static void Completed3(object state) { }

		[Address(RVA = "0x1594170", Offset = "0x1593570", Length = "0x790")]
		[Token(Token = "0x60003BC")]
		private static void Completed4(object state) { }

		[Address(RVA = "0x15976D0", Offset = "0x1596AD0", Length = "0x790")]
		[Token(Token = "0x60003BD")]
		private static void Completed5(object state) { }

		[Address(RVA = "0x1599CF0", Offset = "0x15990F0", Length = "0x790")]
		[Token(Token = "0x60003BE")]
		private static void Completed6(object state) { }

		[Address(RVA = "0x159D250", Offset = "0x159C650", Length = "0x790")]
		[Token(Token = "0x60003BF")]
		private static void Completed7(object state) { }

		[Address(RVA = "0x159E190", Offset = "0x159D590", Length = "0x790")]
		[Token(Token = "0x60003C0")]
		private static void Completed8(object state) { }

		[Address(RVA = "0x15A16F0", Offset = "0x15A0AF0", Length = "0x790")]
		[Token(Token = "0x60003C1")]
		private static void Completed9(object state) { }

		[Address(RVA = "0x15A3570", Offset = "0x15A2970", Length = "0xA7")]
		[AsyncStateMachine(typeof(<DisposeAsync>d__115))]
		[Token(Token = "0x60003C7")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x15C5880", Offset = "0x15C4C80", Length = "0xB0")]
		[Token(Token = "0x60003B7")]
		public override TResult get_Current() { }

		[Address(RVA = "0x15A3990", Offset = "0x15A2D90", Length = "0x41BB")]
		[Token(Token = "0x60003B8")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x15BC4E0", Offset = "0x15BB8E0", Length = "0xC12")]
		[Token(Token = "0x60003C6")]
		private bool TrySetResult() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000605")]
	private readonly IUniTaskAsyncEnumerable<T1> source1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000606")]
	private readonly IUniTaskAsyncEnumerable<T2> source2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000607")]
	private readonly IUniTaskAsyncEnumerable<T3> source3; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000608")]
	private readonly IUniTaskAsyncEnumerable<T4> source4; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000609")]
	private readonly IUniTaskAsyncEnumerable<T5> source5; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400060A")]
	private readonly IUniTaskAsyncEnumerable<T6> source6; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400060B")]
	private readonly IUniTaskAsyncEnumerable<T7> source7; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400060C")]
	private readonly IUniTaskAsyncEnumerable<T8> source8; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400060D")]
	private readonly IUniTaskAsyncEnumerable<T9> source9; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400060E")]
	private readonly IUniTaskAsyncEnumerable<T10> source10; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400060F")]
	private readonly IUniTaskAsyncEnumerable<T11> source11; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000610")]
	private readonly IUniTaskAsyncEnumerable<T12> source12; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000611")]
	private readonly IUniTaskAsyncEnumerable<T13> source13; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000612")]
	private readonly Func4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> resultSelector; //Field offset: 0x0

	[Address(RVA = "0x16D8420", Offset = "0x16D7820", Length = "0x140")]
	[Token(Token = "0x60003B4")]
	public CombineLatest`14(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, IUniTaskAsyncEnumerable<T12> source12, IUniTaskAsyncEnumerable<T13> source13, Func4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> resultSelector) { }

	[Address(RVA = "0x16D8290", Offset = "0x16D7690", Length = "0x18C")]
	[Token(Token = "0x60003B5")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

