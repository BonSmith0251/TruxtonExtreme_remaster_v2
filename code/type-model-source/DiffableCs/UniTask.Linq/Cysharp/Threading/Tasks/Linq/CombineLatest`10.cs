namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000074")]
internal class CombineLatest0 : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x2000075")]
	private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x2000076")]
		private struct <DisposeAsync>d__83 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40004D8")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40004D9")]
			public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40004DA")]
			public _CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40004DB")]
			private Awaiter <>u__1; //Field offset: 0x0

			[Address(RVA = "0x16ED7C0", Offset = "0x16ECBC0", Length = "0x1018")]
			[Token(Token = "0x6000373")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x6000374")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x4000493")]
		private static readonly Action<Object> Completed1Delegate; //Field offset: 0x0
		[Token(Token = "0x4000494")]
		private static readonly Action<Object> Completed2Delegate; //Field offset: 0x0
		[Token(Token = "0x4000495")]
		private static readonly Action<Object> Completed3Delegate; //Field offset: 0x0
		[Token(Token = "0x4000496")]
		private static readonly Action<Object> Completed4Delegate; //Field offset: 0x0
		[Token(Token = "0x4000497")]
		private static readonly Action<Object> Completed5Delegate; //Field offset: 0x0
		[Token(Token = "0x4000498")]
		private static readonly Action<Object> Completed6Delegate; //Field offset: 0x0
		[Token(Token = "0x4000499")]
		private static readonly Action<Object> Completed7Delegate; //Field offset: 0x0
		[Token(Token = "0x400049A")]
		private static readonly Action<Object> Completed8Delegate; //Field offset: 0x0
		[Token(Token = "0x400049B")]
		private static readonly Action<Object> Completed9Delegate; //Field offset: 0x0
		[Token(Token = "0x400049C")]
		private const int CompleteCount = 9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C6")]
		private IUniTaskAsyncEnumerator<T7> enumerator7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C5")]
		private T6 current6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C4")]
		private bool running6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C3")]
		private bool hasCurrent6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C2")]
		private Awaiter<Boolean> awaiter6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004BD")]
		private Awaiter<Boolean> awaiter5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C0")]
		private T5 current5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004BF")]
		private bool running5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004BE")]
		private bool hasCurrent5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C7")]
		private Awaiter<Boolean> awaiter7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004BC")]
		private IUniTaskAsyncEnumerator<T5> enumerator5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C1")]
		private IUniTaskAsyncEnumerator<T6> enumerator6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C8")]
		private bool hasCurrent7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004CD")]
		private bool hasCurrent8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004CA")]
		private T7 current7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004CB")]
		private IUniTaskAsyncEnumerator<T8> enumerator8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004CC")]
		private Awaiter<Boolean> awaiter8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004BB")]
		private T4 current4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004CE")]
		private bool running8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004CF")]
		private T8 current8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004D0")]
		private IUniTaskAsyncEnumerator<T9> enumerator9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004D1")]
		private Awaiter<Boolean> awaiter9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004D2")]
		private bool hasCurrent9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004D3")]
		private bool running9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004D4")]
		private T9 current9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004D5")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C9")]
		private bool running7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004BA")]
		private bool running4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B5")]
		private bool running3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B8")]
		private Awaiter<Boolean> awaiter4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400049D")]
		private readonly IUniTaskAsyncEnumerable<T1> source1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400049E")]
		private readonly IUniTaskAsyncEnumerable<T2> source2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400049F")]
		private readonly IUniTaskAsyncEnumerable<T3> source3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A0")]
		private readonly IUniTaskAsyncEnumerable<T4> source4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A1")]
		private readonly IUniTaskAsyncEnumerable<T5> source5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A2")]
		private readonly IUniTaskAsyncEnumerable<T6> source6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A3")]
		private readonly IUniTaskAsyncEnumerable<T7> source7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A4")]
		private readonly IUniTaskAsyncEnumerable<T8> source8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A5")]
		private readonly IUniTaskAsyncEnumerable<T9> source9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A6")]
		private readonly Func0<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A7")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A8")]
		private IUniTaskAsyncEnumerator<T1> enumerator1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A9")]
		private Awaiter<Boolean> awaiter1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004AA")]
		private bool hasCurrent1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004AB")]
		private bool running1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004AC")]
		private T1 current1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004AD")]
		private IUniTaskAsyncEnumerator<T2> enumerator2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004AE")]
		private Awaiter<Boolean> awaiter2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004AF")]
		private bool hasCurrent2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B0")]
		private bool running2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B1")]
		private T2 current2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B2")]
		private IUniTaskAsyncEnumerator<T3> enumerator3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B3")]
		private Awaiter<Boolean> awaiter3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B4")]
		private bool hasCurrent3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004D6")]
		private bool syncRunning; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B6")]
		private T3 current3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B7")]
		private IUniTaskAsyncEnumerator<T4> enumerator4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B9")]
		private bool hasCurrent4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004D7")]
		private TResult result; //Field offset: 0x0

		[Token(Token = "0x1700000F")]
		public override TResult Current
		{
			[Address(RVA = "0x157F940", Offset = "0x157ED40", Length = "0xB0")]
			[Token(Token = "0x6000365")]
			 get { } //Length: 176
		}

		[Address(RVA = "0x157D870", Offset = "0x157CC70", Length = "0x71B")]
		[Token(Token = "0x6000372")]
		private static _CombineLatest() { }

		[Address(RVA = "0x157E6F0", Offset = "0x157DAF0", Length = "0x3B8")]
		[Token(Token = "0x6000364")]
		public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, Func0<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> resultSelector, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1556940", Offset = "0x1555D40", Length = "0x789")]
		[Token(Token = "0x6000367")]
		private static void Completed1(object state) { }

		[Address(RVA = "0x15596A0", Offset = "0x1558AA0", Length = "0x78A")]
		[Token(Token = "0x6000368")]
		private static void Completed2(object state) { }

		[Address(RVA = "0x155B4E0", Offset = "0x155A8E0", Length = "0x790")]
		[Token(Token = "0x6000369")]
		private static void Completed3(object state) { }

		[Address(RVA = "0x1560850", Offset = "0x155FC50", Length = "0x790")]
		[Token(Token = "0x600036A")]
		private static void Completed4(object state) { }

		[Address(RVA = "0x1562E70", Offset = "0x1562270", Length = "0x790")]
		[Token(Token = "0x600036B")]
		private static void Completed5(object state) { }

		[Address(RVA = "0x1564550", Offset = "0x1563950", Length = "0x790")]
		[Token(Token = "0x600036C")]
		private static void Completed6(object state) { }

		[Address(RVA = "0x1565C30", Offset = "0x1565030", Length = "0x790")]
		[Token(Token = "0x600036D")]
		private static void Completed7(object state) { }

		[Address(RVA = "0x1567AB0", Offset = "0x1566EB0", Length = "0x790")]
		[Token(Token = "0x600036E")]
		private static void Completed8(object state) { }

		[Address(RVA = "0x1568250", Offset = "0x1567650", Length = "0x790")]
		[Token(Token = "0x600036F")]
		private static void Completed9(object state) { }

		[Address(RVA = "0x1568D60", Offset = "0x1568160", Length = "0xA7")]
		[AsyncStateMachine(typeof(<DisposeAsync>d__83))]
		[Token(Token = "0x6000371")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x157F940", Offset = "0x157ED40", Length = "0xB0")]
		[Token(Token = "0x6000365")]
		public override TResult get_Current() { }

		[Address(RVA = "0x156FCE0", Offset = "0x156F0E0", Length = "0x3258")]
		[Token(Token = "0x6000366")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x157B390", Offset = "0x157A790", Length = "0x887")]
		[Token(Token = "0x6000370")]
		private bool TrySetResult() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000489")]
	private readonly IUniTaskAsyncEnumerable<T1> source1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400048A")]
	private readonly IUniTaskAsyncEnumerable<T2> source2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400048B")]
	private readonly IUniTaskAsyncEnumerable<T3> source3; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400048C")]
	private readonly IUniTaskAsyncEnumerable<T4> source4; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400048D")]
	private readonly IUniTaskAsyncEnumerable<T5> source5; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400048E")]
	private readonly IUniTaskAsyncEnumerable<T6> source6; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400048F")]
	private readonly IUniTaskAsyncEnumerable<T7> source7; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000490")]
	private readonly IUniTaskAsyncEnumerable<T8> source8; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000491")]
	private readonly IUniTaskAsyncEnumerable<T9> source9; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000492")]
	private readonly Func0<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> resultSelector; //Field offset: 0x0

	[Address(RVA = "0x16D7A40", Offset = "0x16D6E40", Length = "0xEC")]
	[Token(Token = "0x6000362")]
	public CombineLatest`10(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, Func0<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> resultSelector) { }

	[Address(RVA = "0x16D7920", Offset = "0x16D6D20", Length = "0x11C")]
	[Token(Token = "0x6000363")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

