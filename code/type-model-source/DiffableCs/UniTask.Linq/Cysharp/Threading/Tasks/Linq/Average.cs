namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000030")]
internal static class Average
{
	[CompilerGenerated]
	[Token(Token = "0x2000031")]
	private struct <AverageAsync>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000114")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000115")]
		public AsyncUniTaskMethodBuilder<Double> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000116")]
		public IUniTaskAsyncEnumerable<Int32> source; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000117")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000118")]
		private long <count>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000119")]
		private int <sum>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400011A")]
		private IUniTaskAsyncEnumerator<Int32> <e>5__4; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400011B")]
		private object <>7__wrap4; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400011C")]
		private int <>7__wrap5; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400011D")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x58
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400011E")]
		private Awaiter <>u__2; //Field offset: 0x68

		[Address(RVA = "0x2754390", Offset = "0x2753790", Length = "0x716")]
		[Token(Token = "0x6000291")]
		private override void MoveNext() { }

		[Address(RVA = "0x2754AB0", Offset = "0x2753EB0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000292")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000032")]
	private struct <AverageAsync>d__1 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400011F")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000120")]
		public AsyncUniTaskMethodBuilder<Double> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000121")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000122")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000123")]
		public Func<TSource, Int32> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000124")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000125")]
		private int <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000126")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000127")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000128")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000129")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400012A")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0xA69300", Offset = "0xA68700", Length = "0x783")]
		[Token(Token = "0x6000293")]
		private override void MoveNext() { }

		[Address(RVA = "0xA69A90", Offset = "0xA68E90", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000294")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000033")]
	private struct <AverageAsync>d__12 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400012B")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400012C")]
		public AsyncUniTaskMethodBuilder<Double> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400012D")]
		public IUniTaskAsyncEnumerable<Double> source; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400012E")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400012F")]
		private long <count>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000130")]
		private double <sum>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000131")]
		private IUniTaskAsyncEnumerator<Double> <e>5__4; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000132")]
		private object <>7__wrap4; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000133")]
		private int <>7__wrap5; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000134")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x58
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000135")]
		private Awaiter <>u__2; //Field offset: 0x68

		[Address(RVA = "0x2754B00", Offset = "0x2753F00", Length = "0x6DB")]
		[Token(Token = "0x6000295")]
		private override void MoveNext() { }

		[Address(RVA = "0x27551E0", Offset = "0x27545E0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000296")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000034")]
	private struct <AverageAsync>d__13 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000136")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000137")]
		public AsyncUniTaskMethodBuilder<Double> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000138")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000139")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400013A")]
		public Func<TSource, Double> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400013B")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400013C")]
		private double <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400013D")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400013E")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400013F")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000140")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000141")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0xA68310", Offset = "0xA67710", Length = "0x750")]
		[Token(Token = "0x6000297")]
		private override void MoveNext() { }

		[Address(RVA = "0xA68A70", Offset = "0xA67E70", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000298")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000035")]
	private struct <AverageAsync>d__16 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000142")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000143")]
		public AsyncUniTaskMethodBuilder<Decimal> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000144")]
		public IUniTaskAsyncEnumerable<Decimal> source; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000145")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000146")]
		private long <count>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000147")]
		private decimal <sum>5__3; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000148")]
		private IUniTaskAsyncEnumerator<Decimal> <e>5__4; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000149")]
		private object <>7__wrap4; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400014A")]
		private int <>7__wrap5; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400014B")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x68
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400014C")]
		private Awaiter <>u__2; //Field offset: 0x78

		[Address(RVA = "0x2755230", Offset = "0x2754630", Length = "0x7E9")]
		[Token(Token = "0x6000299")]
		private override void MoveNext() { }

		[Address(RVA = "0x2755A20", Offset = "0x2754E20", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x600029A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000036")]
	private struct <AverageAsync>d__17 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400014D")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400014E")]
		public AsyncUniTaskMethodBuilder<Decimal> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400014F")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000150")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000151")]
		public Func<TSource, Decimal> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000152")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000153")]
		private decimal <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000154")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000155")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000156")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000157")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000158")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0xA68AC0", Offset = "0xA67EC0", Length = "0x7E7")]
		[Token(Token = "0x600029B")]
		private override void MoveNext() { }

		[Address(RVA = "0xA692B0", Offset = "0xA686B0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x600029C")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000037")]
	private struct <AverageAsync>d__20 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000159")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400015A")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Double>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400015B")]
		public IUniTaskAsyncEnumerable<Nullable`1<Int32>> source; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400015C")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400015D")]
		private long <count>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400015E")]
		private Nullable<Int32> <sum>5__3; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400015F")]
		private IUniTaskAsyncEnumerator<Nullable`1<Int32>> <e>5__4; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000160")]
		private object <>7__wrap4; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000161")]
		private int <>7__wrap5; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000162")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x60
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000163")]
		private Awaiter <>u__2; //Field offset: 0x70

		[Address(RVA = "0x2755A70", Offset = "0x2754E70", Length = "0x80B")]
		[Token(Token = "0x600029D")]
		private override void MoveNext() { }

		[Address(RVA = "0x2756280", Offset = "0x2755680", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x600029E")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000038")]
	private struct <AverageAsync>d__21 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000164")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000165")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Double>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000166")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000167")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000168")]
		public Func<TSource, Nullable`1<Int32>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000169")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400016A")]
		private Nullable<Int32> <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400016B")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400016C")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400016D")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400016E")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400016F")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0xA69AE0", Offset = "0xA68EE0", Length = "0x865")]
		[Token(Token = "0x600029F")]
		private override void MoveNext() { }

		[Address(RVA = "0xA6A350", Offset = "0xA69750", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002A0")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000039")]
	private struct <AverageAsync>d__24 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000170")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000171")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Double>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000172")]
		public IUniTaskAsyncEnumerable<Nullable`1<Int64>> source; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000173")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000174")]
		private long <count>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000175")]
		private Nullable<Int64> <sum>5__3; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000176")]
		private IUniTaskAsyncEnumerator<Nullable`1<Int64>> <e>5__4; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000177")]
		private object <>7__wrap4; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000178")]
		private int <>7__wrap5; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000179")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x68
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400017A")]
		private Awaiter <>u__2; //Field offset: 0x78

		[Address(RVA = "0x27562D0", Offset = "0x27556D0", Length = "0x89F")]
		[Token(Token = "0x60002A1")]
		private override void MoveNext() { }

		[Address(RVA = "0x2756B80", Offset = "0x2755F80", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002A2")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003A")]
	private struct <AverageAsync>d__25 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400017B")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400017C")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Double>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400017D")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400017E")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400017F")]
		public Func<TSource, Nullable`1<Int64>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000180")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000181")]
		private Nullable<Int64> <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000182")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000183")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000184")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000185")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000186")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0xA6A3A0", Offset = "0xA697A0", Length = "0x86F")]
		[Token(Token = "0x60002A3")]
		private override void MoveNext() { }

		[Address(RVA = "0xA6AC20", Offset = "0xA6A020", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002A4")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003B")]
	private struct <AverageAsync>d__28 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000187")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000188")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Single>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000189")]
		public IUniTaskAsyncEnumerable<Nullable`1<Single>> source; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400018A")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400018B")]
		private long <count>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400018C")]
		private Nullable<Single> <sum>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400018D")]
		private IUniTaskAsyncEnumerator<Nullable`1<Single>> <e>5__4; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400018E")]
		private object <>7__wrap4; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400018F")]
		private int <>7__wrap5; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000190")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x58
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000191")]
		private Awaiter <>u__2; //Field offset: 0x68

		[Address(RVA = "0x2756BD0", Offset = "0x2755FD0", Length = "0x808")]
		[Token(Token = "0x60002A5")]
		private override void MoveNext() { }

		[Address(RVA = "0x27573E0", Offset = "0x27567E0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002A6")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003C")]
	private struct <AverageAsync>d__29 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000192")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000193")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Single>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000194")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000195")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000196")]
		public Func<TSource, Nullable`1<Single>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000197")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000198")]
		private Nullable<Single> <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000199")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400019A")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400019B")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400019C")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400019D")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0xA6AC70", Offset = "0xA6A070", Length = "0x922")]
		[Token(Token = "0x60002A7")]
		private override void MoveNext() { }

		[Address(RVA = "0xA6B5A0", Offset = "0xA6A9A0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002A8")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003D")]
	private struct <AverageAsync>d__32 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400019E")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400019F")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Double>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001A0")]
		public IUniTaskAsyncEnumerable<Nullable`1<Double>> source; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001A1")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40001A2")]
		private long <count>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40001A3")]
		private Nullable<Double> <sum>5__3; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40001A4")]
		private IUniTaskAsyncEnumerator<Nullable`1<Double>> <e>5__4; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40001A5")]
		private object <>7__wrap4; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40001A6")]
		private int <>7__wrap5; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40001A7")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x68
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40001A8")]
		private Awaiter <>u__2; //Field offset: 0x78

		[Address(RVA = "0x2757430", Offset = "0x2756830", Length = "0x823")]
		[Token(Token = "0x60002A9")]
		private override void MoveNext() { }

		[Address(RVA = "0x2757C60", Offset = "0x2757060", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002AA")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003E")]
	private struct <AverageAsync>d__33 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001A9")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001AA")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Double>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001AB")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001AC")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001AD")]
		public Func<TSource, Nullable`1<Double>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001AE")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001AF")]
		private Nullable<Double> <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B0")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B1")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B2")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B3")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B4")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0xA6B5F0", Offset = "0xA6A9F0", Length = "0x82A")]
		[Token(Token = "0x60002AB")]
		private override void MoveNext() { }

		[Address(RVA = "0xA6BE20", Offset = "0xA6B220", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002AC")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003F")]
	private struct <AverageAsync>d__36 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B5")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001B6")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Decimal>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001B7")]
		public IUniTaskAsyncEnumerable<Nullable`1<Decimal>> source; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40001B8")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40001B9")]
		private long <count>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40001BA")]
		private Nullable<Decimal> <sum>5__3; //Field offset: 0x48
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40001BB")]
		private IUniTaskAsyncEnumerator<Nullable`1<Decimal>> <e>5__4; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40001BC")]
		private object <>7__wrap4; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40001BD")]
		private int <>7__wrap5; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40001BE")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x78
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40001BF")]
		private Awaiter <>u__2; //Field offset: 0x88

		[Address(RVA = "0x2757CB0", Offset = "0x27570B0", Length = "0x97C")]
		[Token(Token = "0x60002AD")]
		private override void MoveNext() { }

		[Address(RVA = "0x2758630", Offset = "0x2757A30", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002AE")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000040")]
	private struct <AverageAsync>d__37 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001C0")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001C1")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Decimal>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001C2")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001C3")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001C4")]
		public Func<TSource, Nullable`1<Decimal>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001C5")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001C6")]
		private Nullable<Decimal> <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001C7")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001C8")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001C9")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001CA")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001CB")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0xA6BE70", Offset = "0xA6B270", Length = "0xA74")]
		[Token(Token = "0x60002AF")]
		private override void MoveNext() { }

		[Address(RVA = "0xA6C8F0", Offset = "0xA6BCF0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002B0")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000041")]
	private struct <AverageAsync>d__4 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001CC")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001CD")]
		public AsyncUniTaskMethodBuilder<Double> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001CE")]
		public IUniTaskAsyncEnumerable<Int64> source; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001CF")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001D0")]
		private long <count>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40001D1")]
		private long <sum>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40001D2")]
		private IUniTaskAsyncEnumerator<Int64> <e>5__4; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40001D3")]
		private object <>7__wrap4; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40001D4")]
		private int <>7__wrap5; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40001D5")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x58
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40001D6")]
		private Awaiter <>u__2; //Field offset: 0x68

		[Address(RVA = "0x2758680", Offset = "0x2757A80", Length = "0x72F")]
		[Token(Token = "0x60002B1")]
		private override void MoveNext() { }

		[Address(RVA = "0x2758DC0", Offset = "0x27581C0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002B2")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000042")]
	private struct <AverageAsync>d__5 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001D7")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001D8")]
		public AsyncUniTaskMethodBuilder<Double> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001D9")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001DA")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001DB")]
		public Func<TSource, Int64> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001DC")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001DD")]
		private long <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001DE")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001DF")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001E0")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001E1")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001E2")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0xA6C940", Offset = "0xA6BD40", Length = "0x799")]
		[Token(Token = "0x60002B3")]
		private override void MoveNext() { }

		[Address(RVA = "0xA6D0E0", Offset = "0xA6C4E0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002B4")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000043")]
	private struct <AverageAsync>d__8 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001E3")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001E4")]
		public AsyncUniTaskMethodBuilder<Single> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001E5")]
		public IUniTaskAsyncEnumerable<Single> source; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001E6")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001E7")]
		private long <count>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40001E8")]
		private float <sum>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40001E9")]
		private IUniTaskAsyncEnumerator<Single> <e>5__4; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40001EA")]
		private object <>7__wrap4; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40001EB")]
		private int <>7__wrap5; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40001EC")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x58
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40001ED")]
		private Awaiter <>u__2; //Field offset: 0x68

		[Address(RVA = "0x2758E10", Offset = "0x2758210", Length = "0x6DB")]
		[Token(Token = "0x60002B5")]
		private override void MoveNext() { }

		[Address(RVA = "0x27594F0", Offset = "0x27588F0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002B6")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000044")]
	private struct <AverageAsync>d__9 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001EE")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001EF")]
		public AsyncUniTaskMethodBuilder<Single> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001F0")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001F1")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001F2")]
		public Func<TSource, Single> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001F3")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001F4")]
		private float <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001F5")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001F6")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001F7")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001F8")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001F9")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0xA6D130", Offset = "0xA6C530", Length = "0x750")]
		[Token(Token = "0x60002B7")]
		private override void MoveNext() { }

		[Address(RVA = "0xA6D890", Offset = "0xA6CC90", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002B8")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000045")]
	private struct <AverageAwaitAsync>d__10 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001FA")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001FB")]
		public AsyncUniTaskMethodBuilder<Single> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001FC")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001FD")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001FE")]
		public Func<TSource, UniTask`1<Single>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001FF")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000200")]
		private float <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000201")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000202")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000203")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000204")]
		private float <>7__wrap6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000205")]
		private Awaiter<Single> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000206")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000207")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0xA6D8E0", Offset = "0xA6CCE0", Length = "0x93B")]
		[Token(Token = "0x60002B9")]
		private override void MoveNext() { }

		[Address(RVA = "0xA6E220", Offset = "0xA6D620", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002BA")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000046")]
	private struct <AverageAwaitAsync>d__14 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000208")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000209")]
		public AsyncUniTaskMethodBuilder<Double> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400020A")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400020B")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400020C")]
		public Func<TSource, UniTask`1<Double>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400020D")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400020E")]
		private double <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400020F")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000210")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000211")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000212")]
		private double <>7__wrap6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000213")]
		private Awaiter<Double> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000214")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000215")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0xA6E270", Offset = "0xA6D670", Length = "0x977")]
		[Token(Token = "0x60002BB")]
		private override void MoveNext() { }

		[Address(RVA = "0xA6EBF0", Offset = "0xA6DFF0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002BC")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000047")]
	private struct <AverageAwaitAsync>d__18 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000216")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000217")]
		public AsyncUniTaskMethodBuilder<Decimal> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000218")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000219")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400021A")]
		public Func<TSource, UniTask`1<Decimal>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400021B")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400021C")]
		private decimal <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400021D")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400021E")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400021F")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000220")]
		private decimal <>7__wrap6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000221")]
		private Awaiter<Decimal> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000222")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000223")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0xA6EC40", Offset = "0xA6E040", Length = "0xA4B")]
		[Token(Token = "0x60002BD")]
		private override void MoveNext() { }

		[Address(RVA = "0xA6F690", Offset = "0xA6EA90", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002BE")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000048")]
	private struct <AverageAwaitAsync>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000224")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000225")]
		public AsyncUniTaskMethodBuilder<Double> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000226")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000227")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000228")]
		public Func<TSource, UniTask`1<Int32>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000229")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400022A")]
		private int <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400022B")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400022C")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400022D")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400022E")]
		private int <>7__wrap6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400022F")]
		private Awaiter<Int32> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000230")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000231")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0xA70CF0", Offset = "0xA700F0", Length = "0x916")]
		[Token(Token = "0x60002BF")]
		private override void MoveNext() { }

		[Address(RVA = "0xA71610", Offset = "0xA70A10", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002C0")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000049")]
	private struct <AverageAwaitAsync>d__22 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000232")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000233")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Double>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000234")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000235")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000236")]
		public Func<TSource, UniTask`1<Nullable`1<Int32>>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000237")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000238")]
		private Nullable<Int32> <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000239")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400023A")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400023B")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400023C")]
		private Awaiter<Nullable<Int32>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400023D")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400023E")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0xA6F6E0", Offset = "0xA6EAE0", Length = "0xA95")]
		[Token(Token = "0x60002C1")]
		private override void MoveNext() { }

		[Address(RVA = "0xA70180", Offset = "0xA6F580", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002C2")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004A")]
	private struct <AverageAwaitAsync>d__26 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400023F")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000240")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Double>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000241")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000242")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000243")]
		public Func<TSource, UniTask`1<Nullable`1<Int64>>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000244")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000245")]
		private Nullable<Int64> <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000246")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000247")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000248")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000249")]
		private Awaiter<Nullable<Int64>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400024A")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400024B")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0xA701D0", Offset = "0xA6F5D0", Length = "0xACE")]
		[Token(Token = "0x60002C3")]
		private override void MoveNext() { }

		[Address(RVA = "0xA70CA0", Offset = "0xA700A0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002C4")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004B")]
	private struct <AverageAwaitAsync>d__30 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400024C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400024D")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Single>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400024E")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400024F")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000250")]
		public Func<TSource, UniTask`1<Nullable`1<Single>>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000251")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000252")]
		private Nullable<Single> <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000253")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000254")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000255")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000256")]
		private Awaiter<Nullable<Single>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000257")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000258")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x1132DF0", Offset = "0x11321F0", Length = "0x9E3")]
		[Token(Token = "0x60002C5")]
		private override void MoveNext() { }

		[Address(RVA = "0x11337E0", Offset = "0x1132BE0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002C6")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004C")]
	private struct <AverageAwaitAsync>d__34 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000259")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400025A")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Double>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400025B")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400025C")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400025D")]
		public Func<TSource, UniTask`1<Nullable`1<Double>>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400025E")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400025F")]
		private Nullable<Double> <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000260")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000261")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000262")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000263")]
		private Awaiter<Nullable<Double>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000264")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000265")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x1133830", Offset = "0x1132C30", Length = "0x9B0")]
		[Token(Token = "0x60002C7")]
		private override void MoveNext() { }

		[Address(RVA = "0x11341F0", Offset = "0x11335F0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002C8")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004D")]
	private struct <AverageAwaitAsync>d__38 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000266")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000267")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Decimal>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000268")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000269")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400026A")]
		public Func<TSource, UniTask`1<Nullable`1<Decimal>>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400026B")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400026C")]
		private Nullable<Decimal> <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400026D")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400026E")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400026F")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000270")]
		private Awaiter<Nullable<Decimal>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000271")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000272")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x1134240", Offset = "0x1133640", Length = "0xBC1")]
		[Token(Token = "0x60002C9")]
		private override void MoveNext() { }

		[Address(RVA = "0x1134E10", Offset = "0x1134210", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002CA")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004E")]
	private struct <AverageAwaitAsync>d__6 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000273")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000274")]
		public AsyncUniTaskMethodBuilder<Double> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000275")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000276")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000277")]
		public Func<TSource, UniTask`1<Int64>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000278")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000279")]
		private long <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400027A")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400027B")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400027C")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400027D")]
		private long <>7__wrap6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400027E")]
		private Awaiter<Int64> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400027F")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000280")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x1134E60", Offset = "0x1134260", Length = "0x91E")]
		[Token(Token = "0x60002CB")]
		private override void MoveNext() { }

		[Address(RVA = "0x1135780", Offset = "0x1134B80", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002CC")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004F")]
	private struct <AverageAwaitWithCancellationAsync>d__11 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000281")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000282")]
		public AsyncUniTaskMethodBuilder<Single> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000283")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000284")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000285")]
		public Func<TSource, CancellationToken, UniTask`1<Single>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000286")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000287")]
		private float <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000288")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000289")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400028A")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400028B")]
		private float <>7__wrap6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400028C")]
		private Awaiter<Single> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400028D")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400028E")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x11357D0", Offset = "0x1134BD0", Length = "0x9FC")]
		[Token(Token = "0x60002CD")]
		private override void MoveNext() { }

		[Address(RVA = "0x11361D0", Offset = "0x11355D0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002CE")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000050")]
	private struct <AverageAwaitWithCancellationAsync>d__15 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400028F")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000290")]
		public AsyncUniTaskMethodBuilder<Double> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000291")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000292")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000293")]
		public Func<TSource, CancellationToken, UniTask`1<Double>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000294")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000295")]
		private double <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000296")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000297")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000298")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000299")]
		private double <>7__wrap6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400029A")]
		private Awaiter<Double> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400029B")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400029C")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x1136220", Offset = "0x1135620", Length = "0x9A9")]
		[Token(Token = "0x60002CF")]
		private override void MoveNext() { }

		[Address(RVA = "0x1136BD0", Offset = "0x1135FD0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002D0")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000051")]
	private struct <AverageAwaitWithCancellationAsync>d__19 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400029D")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400029E")]
		public AsyncUniTaskMethodBuilder<Decimal> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400029F")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002A0")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002A1")]
		public Func<TSource, CancellationToken, UniTask`1<Decimal>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002A2")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002A3")]
		private decimal <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002A4")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002A5")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002A6")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002A7")]
		private decimal <>7__wrap6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002A8")]
		private Awaiter<Decimal> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002A9")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002AA")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x1136C20", Offset = "0x1136020", Length = "0xB19")]
		[Token(Token = "0x60002D1")]
		private override void MoveNext() { }

		[Address(RVA = "0x1137740", Offset = "0x1136B40", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002D2")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000052")]
	private struct <AverageAwaitWithCancellationAsync>d__23 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002AB")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002AC")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Double>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002AD")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002AE")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002AF")]
		public Func<TSource, CancellationToken, UniTask`1<Nullable`1<Int32>>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002B0")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002B1")]
		private Nullable<Int32> <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002B2")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002B3")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002B4")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002B5")]
		private Awaiter<Nullable<Int32>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002B6")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002B7")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x1137790", Offset = "0x1136B90", Length = "0xAAC")]
		[Token(Token = "0x60002D3")]
		private override void MoveNext() { }

		[Address(RVA = "0x1138240", Offset = "0x1137640", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002D4")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000053")]
	private struct <AverageAwaitWithCancellationAsync>d__27 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002B8")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002B9")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Double>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002BA")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002BB")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002BC")]
		public Func<TSource, CancellationToken, UniTask`1<Nullable`1<Int64>>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002BD")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002BE")]
		private Nullable<Int64> <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002BF")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002C0")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002C1")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002C2")]
		private Awaiter<Nullable<Int64>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002C3")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002C4")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x1138290", Offset = "0x1137690", Length = "0xAE2")]
		[Token(Token = "0x60002D5")]
		private override void MoveNext() { }

		[Address(RVA = "0x1138D80", Offset = "0x1138180", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002D6")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000054")]
	private struct <AverageAwaitWithCancellationAsync>d__3 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002C5")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002C6")]
		public AsyncUniTaskMethodBuilder<Double> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002C7")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002C8")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002C9")]
		public Func<TSource, CancellationToken, UniTask`1<Int32>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002CA")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002CB")]
		private int <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002CC")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002CD")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002CE")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002CF")]
		private int <>7__wrap6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002D0")]
		private Awaiter<Int32> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002D1")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002D2")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x113AEA0", Offset = "0x113A2A0", Length = "0x921")]
		[Token(Token = "0x60002D7")]
		private override void MoveNext() { }

		[Address(RVA = "0x113B7D0", Offset = "0x113ABD0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002D8")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000055")]
	private struct <AverageAwaitWithCancellationAsync>d__31 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002D3")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002D4")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Single>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002D5")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002D6")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002D7")]
		public Func<TSource, CancellationToken, UniTask`1<Nullable`1<Single>>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002D8")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002D9")]
		private Nullable<Single> <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002DA")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002DB")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002DC")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002DD")]
		private Awaiter<Nullable<Single>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002DE")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002DF")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x1138DD0", Offset = "0x11381D0", Length = "0xA03")]
		[Token(Token = "0x60002D9")]
		private override void MoveNext() { }

		[Address(RVA = "0x11397E0", Offset = "0x1138BE0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002DA")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000056")]
	private struct <AverageAwaitWithCancellationAsync>d__35 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002E0")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002E1")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Double>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002E2")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002E3")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002E4")]
		public Func<TSource, CancellationToken, UniTask`1<Nullable`1<Double>>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002E5")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002E6")]
		private Nullable<Double> <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002E7")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002E8")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002E9")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002EA")]
		private Awaiter<Nullable<Double>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002EB")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002EC")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x1139830", Offset = "0x1138C30", Length = "0x9D1")]
		[Token(Token = "0x60002DB")]
		private override void MoveNext() { }

		[Address(RVA = "0x113A210", Offset = "0x1139610", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002DC")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000057")]
	private struct <AverageAwaitWithCancellationAsync>d__39 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002ED")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002EE")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Decimal>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002EF")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002F0")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002F1")]
		public Func<TSource, CancellationToken, UniTask`1<Nullable`1<Decimal>>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002F2")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002F3")]
		private Nullable<Decimal> <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002F4")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002F5")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002F6")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002F7")]
		private Awaiter<Nullable<Decimal>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002F8")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002F9")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x113A260", Offset = "0x1139660", Length = "0xBE5")]
		[Token(Token = "0x60002DD")]
		private override void MoveNext() { }

		[Address(RVA = "0x113AE50", Offset = "0x113A250", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002DE")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000058")]
	private struct <AverageAwaitWithCancellationAsync>d__7 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002FA")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002FB")]
		public AsyncUniTaskMethodBuilder<Double> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002FC")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002FD")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002FE")]
		public Func<TSource, CancellationToken, UniTask`1<Int64>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002FF")]
		private long <count>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000300")]
		private long <sum>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000301")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000302")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000303")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000304")]
		private long <>7__wrap6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000305")]
		private Awaiter<Int64> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000306")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000307")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x113B820", Offset = "0x113AC20", Length = "0x948")]
		[Token(Token = "0x60002DF")]
		private override void MoveNext() { }

		[Address(RVA = "0x113C170", Offset = "0x113B570", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60002E0")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x27519B0", Offset = "0x2750DB0", Length = "0x139")]
	[AsyncStateMachine(typeof(<AverageAsync>d__0))]
	[Token(Token = "0x6000269")]
	public static UniTask<Double> AverageAsync(IUniTaskAsyncEnumerable<Int32> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x796510", Offset = "0x795910", Length = "0x124")]
	[AsyncStateMachine(typeof(<AverageAsync>d__33`1))]
	[Token(Token = "0x600028A")]
	public static UniTask<Nullable`1<Double>> AverageAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Nullable`1<Double>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x7963E0", Offset = "0x7957E0", Length = "0x124")]
	[AsyncStateMachine(typeof(<AverageAsync>d__17`1))]
	[Token(Token = "0x600027A")]
	public static UniTask<Decimal> AverageAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Decimal> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2751390", Offset = "0x2750790", Length = "0x131")]
	[AsyncStateMachine(typeof(<AverageAsync>d__16))]
	[Token(Token = "0x6000279")]
	public static UniTask<Decimal> AverageAsync(IUniTaskAsyncEnumerable<Decimal> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x796160", Offset = "0x795560", Length = "0x12C")]
	[AsyncStateMachine(typeof(<AverageAsync>d__29`1))]
	[Token(Token = "0x6000286")]
	public static UniTask<Nullable`1<Single>> AverageAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Nullable`1<Single>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2750FD0", Offset = "0x27503D0", Length = "0x131")]
	[AsyncStateMachine(typeof(<AverageAsync>d__24))]
	[Token(Token = "0x6000281")]
	public static UniTask<Nullable`1<Double>> AverageAsync(IUniTaskAsyncEnumerable<Nullable`1<Int64>> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x796640", Offset = "0x795A40", Length = "0x12C")]
	[AsyncStateMachine(typeof(<AverageAsync>d__13`1))]
	[Token(Token = "0x6000276")]
	public static UniTask<Double> AverageAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Double> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2751600", Offset = "0x2750A00", Length = "0x139")]
	[AsyncStateMachine(typeof(<AverageAsync>d__12))]
	[Token(Token = "0x6000275")]
	public static UniTask<Double> AverageAsync(IUniTaskAsyncEnumerable<Double> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x796510", Offset = "0x795910", Length = "0x124")]
	[AsyncStateMachine(typeof(<AverageAsync>d__25`1))]
	[Token(Token = "0x6000282")]
	public static UniTask<Nullable`1<Double>> AverageAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Nullable`1<Int64>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x27514D0", Offset = "0x27508D0", Length = "0x12E")]
	[AsyncStateMachine(typeof(<AverageAsync>d__20))]
	[Token(Token = "0x600027D")]
	public static UniTask<Nullable`1<Double>> AverageAsync(IUniTaskAsyncEnumerable<Nullable`1<Int32>> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x796290", Offset = "0x795690", Length = "0x14B")]
	[AsyncStateMachine(typeof(<AverageAsync>d__21`1))]
	[Token(Token = "0x600027E")]
	public static UniTask<Nullable`1<Double>> AverageAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Nullable`1<Int32>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2751740", Offset = "0x2750B40", Length = "0x12E")]
	[AsyncStateMachine(typeof(<AverageAsync>d__8))]
	[Token(Token = "0x6000271")]
	public static UniTask<Single> AverageAsync(IUniTaskAsyncEnumerable<Single> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2751250", Offset = "0x2750650", Length = "0x135")]
	[AsyncStateMachine(typeof(<AverageAsync>d__36))]
	[Token(Token = "0x600028D")]
	public static UniTask<Nullable`1<Decimal>> AverageAsync(IUniTaskAsyncEnumerable<Nullable`1<Decimal>> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2751AF0", Offset = "0x2750EF0", Length = "0x131")]
	[AsyncStateMachine(typeof(<AverageAsync>d__32))]
	[Token(Token = "0x6000289")]
	public static UniTask<Nullable`1<Double>> AverageAsync(IUniTaskAsyncEnumerable<Nullable`1<Double>> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x796640", Offset = "0x795A40", Length = "0x12C")]
	[AsyncStateMachine(typeof(<AverageAsync>d__5`1))]
	[Token(Token = "0x600026E")]
	public static UniTask<Double> AverageAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int64> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2751870", Offset = "0x2750C70", Length = "0x139")]
	[AsyncStateMachine(typeof(<AverageAsync>d__4))]
	[Token(Token = "0x600026D")]
	public static UniTask<Double> AverageAsync(IUniTaskAsyncEnumerable<Int64> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x796770", Offset = "0x795B70", Length = "0x142")]
	[AsyncStateMachine(typeof(<AverageAsync>d__37`1))]
	[Token(Token = "0x600028E")]
	public static UniTask<Nullable`1<Decimal>> AverageAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Nullable`1<Decimal>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2751110", Offset = "0x2750510", Length = "0x139")]
	[AsyncStateMachine(typeof(<AverageAsync>d__28))]
	[Token(Token = "0x6000285")]
	public static UniTask<Nullable`1<Single>> AverageAsync(IUniTaskAsyncEnumerable<Nullable`1<Single>> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x796640", Offset = "0x795A40", Length = "0x12C")]
	[AsyncStateMachine(typeof(<AverageAsync>d__1`1))]
	[Token(Token = "0x600026A")]
	public static UniTask<Double> AverageAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x7968C0", Offset = "0x795CC0", Length = "0x123")]
	[AsyncStateMachine(typeof(<AverageAsync>d__9`1))]
	[Token(Token = "0x6000272")]
	public static UniTask<Single> AverageAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Single> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x796C70", Offset = "0x796070", Length = "0x12B")]
	[AsyncStateMachine(typeof(<AverageAwaitAsync>d__22`1))]
	[Token(Token = "0x600027F")]
	public static UniTask<Nullable`1<Double>> AverageAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Nullable`1<Int32>>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x796DA0", Offset = "0x7961A0", Length = "0x133")]
	[AsyncStateMachine(typeof(<AverageAwaitAsync>d__26`1))]
	[Token(Token = "0x6000283")]
	public static UniTask<Nullable`1<Double>> AverageAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Nullable`1<Int64>>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x796DA0", Offset = "0x7961A0", Length = "0x133")]
	[AsyncStateMachine(typeof(<AverageAwaitAsync>d__34`1))]
	[Token(Token = "0x600028B")]
	public static UniTask<Nullable`1<Double>> AverageAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Nullable`1<Double>>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x796B30", Offset = "0x795F30", Length = "0x138")]
	[AsyncStateMachine(typeof(<AverageAwaitAsync>d__18`1))]
	[Token(Token = "0x600027B")]
	public static UniTask<Decimal> AverageAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Decimal>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x796EE0", Offset = "0x7962E0", Length = "0x136")]
	[AsyncStateMachine(typeof(<AverageAwaitAsync>d__14`1))]
	[Token(Token = "0x6000277")]
	public static UniTask<Double> AverageAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Double>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x797020", Offset = "0x796420", Length = "0x127")]
	[AsyncStateMachine(typeof(<AverageAwaitAsync>d__10`1))]
	[Token(Token = "0x6000273")]
	public static UniTask<Single> AverageAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Single>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x796EE0", Offset = "0x7962E0", Length = "0x136")]
	[AsyncStateMachine(typeof(<AverageAwaitAsync>d__6`1))]
	[Token(Token = "0x600026F")]
	public static UniTask<Double> AverageAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Int64>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x797150", Offset = "0x796550", Length = "0x130")]
	[AsyncStateMachine(typeof(<AverageAwaitAsync>d__2`1))]
	[Token(Token = "0x600026B")]
	public static UniTask<Double> AverageAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Int32>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x797280", Offset = "0x796680", Length = "0x157")]
	[AsyncStateMachine(typeof(<AverageAwaitAsync>d__38`1))]
	[Token(Token = "0x600028F")]
	public static UniTask<Nullable`1<Decimal>> AverageAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Nullable`1<Decimal>>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x7969F0", Offset = "0x795DF0", Length = "0x136")]
	[AsyncStateMachine(typeof(<AverageAwaitAsync>d__30`1))]
	[Token(Token = "0x6000287")]
	public static UniTask<Nullable`1<Single>> AverageAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Nullable`1<Single>>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x796DA0", Offset = "0x7961A0", Length = "0x133")]
	[AsyncStateMachine(typeof(<AverageAwaitWithCancellationAsync>d__35`1))]
	[Token(Token = "0x600028C")]
	public static UniTask<Nullable`1<Double>> AverageAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Nullable`1<Double>>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x796B30", Offset = "0x795F30", Length = "0x138")]
	[AsyncStateMachine(typeof(<AverageAwaitWithCancellationAsync>d__19`1))]
	[Token(Token = "0x600027C")]
	public static UniTask<Decimal> AverageAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Decimal>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x796DA0", Offset = "0x7961A0", Length = "0x133")]
	[AsyncStateMachine(typeof(<AverageAwaitWithCancellationAsync>d__27`1))]
	[Token(Token = "0x6000284")]
	public static UniTask<Nullable`1<Double>> AverageAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Nullable`1<Int64>>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x796C70", Offset = "0x796070", Length = "0x12B")]
	[AsyncStateMachine(typeof(<AverageAwaitWithCancellationAsync>d__23`1))]
	[Token(Token = "0x6000280")]
	public static UniTask<Nullable`1<Double>> AverageAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Nullable`1<Int32>>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x796EE0", Offset = "0x7962E0", Length = "0x136")]
	[AsyncStateMachine(typeof(<AverageAwaitWithCancellationAsync>d__15`1))]
	[Token(Token = "0x6000278")]
	public static UniTask<Double> AverageAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Double>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x797020", Offset = "0x796420", Length = "0x127")]
	[AsyncStateMachine(typeof(<AverageAwaitWithCancellationAsync>d__11`1))]
	[Token(Token = "0x6000274")]
	public static UniTask<Single> AverageAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Single>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x796EE0", Offset = "0x7962E0", Length = "0x136")]
	[AsyncStateMachine(typeof(<AverageAwaitWithCancellationAsync>d__7`1))]
	[Token(Token = "0x6000270")]
	public static UniTask<Double> AverageAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Int64>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x797150", Offset = "0x796550", Length = "0x130")]
	[AsyncStateMachine(typeof(<AverageAwaitWithCancellationAsync>d__3`1))]
	[Token(Token = "0x600026C")]
	public static UniTask<Double> AverageAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Int32>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x7969F0", Offset = "0x795DF0", Length = "0x136")]
	[AsyncStateMachine(typeof(<AverageAwaitWithCancellationAsync>d__31`1))]
	[Token(Token = "0x6000288")]
	public static UniTask<Nullable`1<Single>> AverageAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Nullable`1<Single>>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x797280", Offset = "0x796680", Length = "0x157")]
	[AsyncStateMachine(typeof(<AverageAwaitWithCancellationAsync>d__39`1))]
	[Token(Token = "0x6000290")]
	public static UniTask<Nullable`1<Decimal>> AverageAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Nullable`1<Decimal>>> selector, CancellationToken cancellationToken) { }

}

