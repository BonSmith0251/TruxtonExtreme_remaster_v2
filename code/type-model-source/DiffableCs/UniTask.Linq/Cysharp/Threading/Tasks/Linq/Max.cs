namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000F0")]
internal static class Max
{
	[CompilerGenerated]
	[Token(Token = "0x20000F1")]
	private struct <MaxAsync>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A23")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A24")]
		public AsyncUniTaskMethodBuilder<TSource> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A25")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A26")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A27")]
		private TSource <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A28")]
		private Comparer<TSource> <comparer>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A29")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A2A")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A2B")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A2C")]
		private TSource <>7__wrap6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A2D")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A2E")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1811B40", Offset = "0x1810F40", Length = "0x18AC")]
		[Token(Token = "0x6000589")]
		private override void MoveNext() { }

		[Address(RVA = "0x18133F0", Offset = "0x18127F0", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x600058A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000F2")]
	private struct <MaxAsync>d__1 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A2F")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A30")]
		public AsyncUniTaskMethodBuilder<TResult> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A31")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A32")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A33")]
		public Func<TSource, TResult> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A34")]
		private TResult <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A35")]
		private Comparer<TResult> <comparer>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A36")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A37")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A38")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A39")]
		private TResult <>7__wrap6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A3A")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A3B")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1814890", Offset = "0x1813C90", Length = "0x1AD6")]
		[Token(Token = "0x600058B")]
		private override void MoveNext() { }

		[Address(RVA = "0x1816370", Offset = "0x1815770", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x600058C")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000F3")]
	private struct <MaxAsync>d__12 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A3C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000A3D")]
		public AsyncUniTaskMethodBuilder<Single> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A3E")]
		public IUniTaskAsyncEnumerable<Single> source; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000A3F")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000A40")]
		private float <value>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000A41")]
		private IUniTaskAsyncEnumerator<Single> <e>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000A42")]
		private object <>7__wrap3; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000A43")]
		private int <>7__wrap4; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000A44")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000A45")]
		private Awaiter <>u__2; //Field offset: 0x60

		[Address(RVA = "0x2759540", Offset = "0x2758940", Length = "0x720")]
		[Token(Token = "0x600058D")]
		private override void MoveNext() { }

		[Address(RVA = "0x2759C70", Offset = "0x2759070", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x600058E")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000F4")]
	private struct <MaxAsync>d__13 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A46")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A47")]
		public AsyncUniTaskMethodBuilder<Single> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A48")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A49")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A4A")]
		public Func<TSource, Single> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A4B")]
		private float <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A4C")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A4D")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A4E")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A4F")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A50")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x18134C0", Offset = "0x18128C0", Length = "0x988")]
		[Token(Token = "0x600058F")]
		private override void MoveNext() { }

		[Address(RVA = "0x1813E50", Offset = "0x1813250", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000590")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000F5")]
	private struct <MaxAsync>d__16 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A51")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000A52")]
		public AsyncUniTaskMethodBuilder<Double> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A53")]
		public IUniTaskAsyncEnumerable<Double> source; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000A54")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000A55")]
		private double <value>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000A56")]
		private IUniTaskAsyncEnumerator<Double> <e>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000A57")]
		private object <>7__wrap3; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000A58")]
		private int <>7__wrap4; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000A59")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000A5A")]
		private Awaiter <>u__2; //Field offset: 0x60

		[Address(RVA = "0x2759CC0", Offset = "0x27590C0", Length = "0x721")]
		[Token(Token = "0x6000591")]
		private override void MoveNext() { }

		[Address(RVA = "0x275A3F0", Offset = "0x27597F0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000592")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000F6")]
	private struct <MaxAsync>d__17 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A5B")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A5C")]
		public AsyncUniTaskMethodBuilder<Double> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A5D")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A5E")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A5F")]
		public Func<TSource, Double> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A60")]
		private double <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A61")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A62")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A63")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A64")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A65")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1813EA0", Offset = "0x18132A0", Length = "0x98F")]
		[Token(Token = "0x6000593")]
		private override void MoveNext() { }

		[Address(RVA = "0x1814840", Offset = "0x1813C40", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000594")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000F7")]
	private struct <MaxAsync>d__20 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A66")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000A67")]
		public AsyncUniTaskMethodBuilder<Decimal> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000A68")]
		public IUniTaskAsyncEnumerable<Decimal> source; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000A69")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000A6A")]
		private decimal <value>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000A6B")]
		private IUniTaskAsyncEnumerator<Decimal> <e>5__3; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000A6C")]
		private object <>7__wrap3; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000A6D")]
		private int <>7__wrap4; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000A6E")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x60
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000A6F")]
		private Awaiter <>u__2; //Field offset: 0x70

		[Address(RVA = "0x275A440", Offset = "0x2759840", Length = "0x810")]
		[Token(Token = "0x6000595")]
		private override void MoveNext() { }

		[Address(RVA = "0x275AC60", Offset = "0x275A060", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000596")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000F8")]
	private struct <MaxAsync>d__21 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A70")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A71")]
		public AsyncUniTaskMethodBuilder<Decimal> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A72")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A73")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A74")]
		public Func<TSource, Decimal> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A75")]
		private decimal <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A76")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A77")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A78")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A79")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A7A")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1816440", Offset = "0x1815840", Length = "0x9E4")]
		[Token(Token = "0x6000597")]
		private override void MoveNext() { }

		[Address(RVA = "0x1816E30", Offset = "0x1816230", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6000598")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000F9")]
	private struct <MaxAsync>d__24 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A7B")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000A7C")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Int32>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A7D")]
		public IUniTaskAsyncEnumerable<Nullable`1<Int32>> source; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000A7E")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000A7F")]
		private Nullable<Int32> <value>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000A80")]
		private IUniTaskAsyncEnumerator<Nullable`1<Int32>> <e>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000A81")]
		private object <>7__wrap3; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000A82")]
		private int <>7__wrap4; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4000A83")]
		private Nullable<Int32> <>7__wrap5; //Field offset: 0x4C
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000A84")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x58
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000A85")]
		private Awaiter <>u__2; //Field offset: 0x68

		[Address(RVA = "0x275ACB0", Offset = "0x275A0B0", Length = "0x790")]
		[Token(Token = "0x6000599")]
		private override void MoveNext() { }

		[Address(RVA = "0x275B450", Offset = "0x275A850", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x600059A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000FA")]
	private struct <MaxAsync>d__25 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A86")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A87")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Int32>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A88")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A89")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A8A")]
		public Func<TSource, Nullable`1<Int32>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A8B")]
		private Nullable<Int32> <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A8C")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A8D")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A8E")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A8F")]
		private Nullable<Int32> <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A90")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A91")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1816E80", Offset = "0x1816280", Length = "0xA1B")]
		[Token(Token = "0x600059B")]
		private override void MoveNext() { }

		[Address(RVA = "0x18178A0", Offset = "0x1816CA0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x600059C")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000FB")]
	private struct <MaxAsync>d__28 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A92")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000A93")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Int64>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000A94")]
		public IUniTaskAsyncEnumerable<Nullable`1<Int64>> source; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000A95")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000A96")]
		private Nullable<Int64> <value>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000A97")]
		private IUniTaskAsyncEnumerator<Nullable`1<Int64>> <e>5__3; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000A98")]
		private object <>7__wrap3; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000A99")]
		private int <>7__wrap4; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000A9A")]
		private Nullable<Int64> <>7__wrap5; //Field offset: 0x60
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000A9B")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x70
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000A9C")]
		private Awaiter <>u__2; //Field offset: 0x80

		[Address(RVA = "0x275B4A0", Offset = "0x275A8A0", Length = "0x889")]
		[Token(Token = "0x600059D")]
		private override void MoveNext() { }

		[Address(RVA = "0x275BD30", Offset = "0x275B130", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x600059E")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000FC")]
	private struct <MaxAsync>d__29 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A9D")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A9E")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Int64>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A9F")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AA0")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AA1")]
		public Func<TSource, Nullable`1<Int64>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AA2")]
		private Nullable<Int64> <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AA3")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AA4")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AA5")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AA6")]
		private Nullable<Int64> <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AA7")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AA8")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x18178F0", Offset = "0x1816CF0", Length = "0xAD1")]
		[Token(Token = "0x600059F")]
		private override void MoveNext() { }

		[Address(RVA = "0x18183D0", Offset = "0x18177D0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005A0")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000FD")]
	private struct <MaxAsync>d__32 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AA9")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000AAA")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Single>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000AAB")]
		public IUniTaskAsyncEnumerable<Nullable`1<Single>> source; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000AAC")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000AAD")]
		private Nullable<Single> <value>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000AAE")]
		private IUniTaskAsyncEnumerator<Nullable`1<Single>> <e>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000AAF")]
		private object <>7__wrap3; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000AB0")]
		private int <>7__wrap4; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4000AB1")]
		private Nullable<Single> <>7__wrap5; //Field offset: 0x4C
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000AB2")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x58
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000AB3")]
		private Awaiter <>u__2; //Field offset: 0x68

		[Address(RVA = "0x275BD80", Offset = "0x275B180", Length = "0x79E")]
		[Token(Token = "0x60005A1")]
		private override void MoveNext() { }

		[Address(RVA = "0x275C520", Offset = "0x275B920", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005A2")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000FE")]
	private struct <MaxAsync>d__33 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AB4")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AB5")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Single>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AB6")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AB7")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AB8")]
		public Func<TSource, Nullable`1<Single>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AB9")]
		private Nullable<Single> <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ABA")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ABB")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ABC")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ABD")]
		private Nullable<Single> <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ABE")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ABF")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1818420", Offset = "0x1817820", Length = "0xACE")]
		[Token(Token = "0x60005A3")]
		private override void MoveNext() { }

		[Address(RVA = "0x1818EF0", Offset = "0x18182F0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005A4")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000FF")]
	private struct <MaxAsync>d__36 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AC0")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000AC1")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Double>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000AC2")]
		public IUniTaskAsyncEnumerable<Nullable`1<Double>> source; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000AC3")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000AC4")]
		private Nullable<Double> <value>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000AC5")]
		private IUniTaskAsyncEnumerator<Nullable`1<Double>> <e>5__3; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000AC6")]
		private object <>7__wrap3; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000AC7")]
		private int <>7__wrap4; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000AC8")]
		private Nullable<Double> <>7__wrap5; //Field offset: 0x60
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000AC9")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x70
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000ACA")]
		private Awaiter <>u__2; //Field offset: 0x80

		[Address(RVA = "0x275C570", Offset = "0x275B970", Length = "0x898")]
		[Token(Token = "0x60005A5")]
		private override void MoveNext() { }

		[Address(RVA = "0x275CE10", Offset = "0x275C210", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005A6")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000100")]
	private struct <MaxAsync>d__37 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ACB")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ACC")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Double>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ACD")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ACE")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ACF")]
		public Func<TSource, Nullable`1<Double>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AD0")]
		private Nullable<Double> <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AD1")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AD2")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AD3")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AD4")]
		private Nullable<Double> <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AD5")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AD6")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1818F40", Offset = "0x1818340", Length = "0xAE1")]
		[Token(Token = "0x60005A7")]
		private override void MoveNext() { }

		[Address(RVA = "0x1819A30", Offset = "0x1818E30", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005A8")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000101")]
	private struct <MaxAsync>d__4 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AD7")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000AD8")]
		public AsyncUniTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000AD9")]
		public IUniTaskAsyncEnumerable<Int32> source; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000ADA")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000ADB")]
		private int <value>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000ADC")]
		private IUniTaskAsyncEnumerator<Int32> <e>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000ADD")]
		private object <>7__wrap3; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000ADE")]
		private int <>7__wrap4; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000ADF")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000AE0")]
		private Awaiter <>u__2; //Field offset: 0x60

		[Address(RVA = "0x275D750", Offset = "0x275CB50", Length = "0x71C")]
		[Token(Token = "0x60005A9")]
		private override void MoveNext() { }

		[Address(RVA = "0x275DE70", Offset = "0x275D270", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005AA")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000102")]
	private struct <MaxAsync>d__40 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AE1")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000AE2")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Decimal>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000AE3")]
		public IUniTaskAsyncEnumerable<Nullable`1<Decimal>> source; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000AE4")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000AE5")]
		private Nullable<Decimal> <value>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000AE6")]
		private IUniTaskAsyncEnumerator<Nullable`1<Decimal>> <e>5__3; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000AE7")]
		private object <>7__wrap3; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000AE8")]
		private int <>7__wrap4; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000AE9")]
		private Nullable<Decimal> <>7__wrap5; //Field offset: 0x70
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000AEA")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x88
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000AEB")]
		private Awaiter <>u__2; //Field offset: 0x98

		[Address(RVA = "0x275CE60", Offset = "0x275C260", Length = "0x89C")]
		[Token(Token = "0x60005AB")]
		private override void MoveNext() { }

		[Address(RVA = "0x275D700", Offset = "0x275CB00", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005AC")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000103")]
	private struct <MaxAsync>d__41 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AEC")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AED")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Decimal>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AEE")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AEF")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AF0")]
		public Func<TSource, Nullable`1<Decimal>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AF1")]
		private Nullable<Decimal> <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AF2")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AF3")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AF4")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AF5")]
		private Nullable<Decimal> <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AF6")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AF7")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1819A80", Offset = "0x1818E80", Length = "0xBAA")]
		[Token(Token = "0x60005AD")]
		private override void MoveNext() { }

		[Address(RVA = "0x181A630", Offset = "0x1819A30", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005AE")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000104")]
	private struct <MaxAsync>d__5 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AF8")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AF9")]
		public AsyncUniTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AFA")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AFB")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AFC")]
		public Func<TSource, Int32> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AFD")]
		private int <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AFE")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AFF")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B00")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B01")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B02")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x181A680", Offset = "0x1819A80", Length = "0xA2E")]
		[Token(Token = "0x60005AF")]
		private override void MoveNext() { }

		[Address(RVA = "0x181B0B0", Offset = "0x181A4B0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005B0")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000105")]
	private struct <MaxAsync>d__8 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B03")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000B04")]
		public AsyncUniTaskMethodBuilder<Int64> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B05")]
		public IUniTaskAsyncEnumerable<Int64> source; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000B06")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000B07")]
		private long <value>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000B08")]
		private IUniTaskAsyncEnumerator<Int64> <e>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000B09")]
		private object <>7__wrap3; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000B0A")]
		private int <>7__wrap4; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000B0B")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000B0C")]
		private Awaiter <>u__2; //Field offset: 0x60

		[Address(RVA = "0x275DEC0", Offset = "0x275D2C0", Length = "0x71F")]
		[Token(Token = "0x60005B1")]
		private override void MoveNext() { }

		[Address(RVA = "0x275E5F0", Offset = "0x275D9F0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005B2")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000106")]
	private struct <MaxAsync>d__9 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B0D")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B0E")]
		public AsyncUniTaskMethodBuilder<Int64> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B0F")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B10")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B11")]
		public Func<TSource, Int64> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B12")]
		private long <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B13")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B14")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B15")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B16")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B17")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x181B100", Offset = "0x181A500", Length = "0x98C")]
		[Token(Token = "0x60005B3")]
		private override void MoveNext() { }

		[Address(RVA = "0x181BA90", Offset = "0x181AE90", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005B4")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000107")]
	private struct <MaxAwaitAsync>d__10 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B18")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B19")]
		public AsyncUniTaskMethodBuilder<Int64> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B1A")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B1B")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B1C")]
		public Func<TSource, UniTask`1<Int64>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B1D")]
		private long <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B1E")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B1F")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B20")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B21")]
		private Awaiter<Int64> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B22")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B23")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x181BAE0", Offset = "0x181AEE0", Length = "0xC6B")]
		[Token(Token = "0x60005B5")]
		private override void MoveNext() { }

		[Address(RVA = "0x181C750", Offset = "0x181BB50", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005B6")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000108")]
	private struct <MaxAwaitAsync>d__14 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B24")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B25")]
		public AsyncUniTaskMethodBuilder<Single> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B26")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B27")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B28")]
		public Func<TSource, UniTask`1<Single>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B29")]
		private float <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B2A")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B2B")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B2C")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B2D")]
		private Awaiter<Single> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B2E")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B2F")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x181C7A0", Offset = "0x181BBA0", Length = "0xBF1")]
		[Token(Token = "0x60005B7")]
		private override void MoveNext() { }

		[Address(RVA = "0x181D3A0", Offset = "0x181C7A0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005B8")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000109")]
	private struct <MaxAwaitAsync>d__18 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B30")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B31")]
		public AsyncUniTaskMethodBuilder<Double> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B32")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B33")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B34")]
		public Func<TSource, UniTask`1<Double>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B35")]
		private double <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B36")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B37")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B38")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B39")]
		private Awaiter<Double> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B3A")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B3B")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x181D3F0", Offset = "0x181C7F0", Length = "0xC6D")]
		[Token(Token = "0x60005B9")]
		private override void MoveNext() { }

		[Address(RVA = "0x181E060", Offset = "0x181D460", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005BA")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200010A")]
	private struct <MaxAwaitAsync>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B3C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B3D")]
		public AsyncUniTaskMethodBuilder<TResult> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B3E")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B3F")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B40")]
		public Func<TSource, UniTask`1<TResult>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B41")]
		private TResult <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B42")]
		private Comparer<TResult> <comparer>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B43")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B44")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B45")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B46")]
		private TResult <>7__wrap6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B47")]
		private Awaiter<TResult> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B48")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B49")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x181FBA0", Offset = "0x181EFA0", Length = "0x2272")]
		[Token(Token = "0x60005BB")]
		private override void MoveNext() { }

		[Address(RVA = "0x1821E20", Offset = "0x1821220", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x60005BC")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200010B")]
	private struct <MaxAwaitAsync>d__22 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B4A")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B4B")]
		public AsyncUniTaskMethodBuilder<Decimal> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B4C")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B4D")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B4E")]
		public Func<TSource, UniTask`1<Decimal>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B4F")]
		private decimal <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B50")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B51")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B52")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B53")]
		private Awaiter<Decimal> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B54")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B55")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x181E0B0", Offset = "0x181D4B0", Length = "0xD1F")]
		[Token(Token = "0x60005BD")]
		private override void MoveNext() { }

		[Address(RVA = "0x181EDE0", Offset = "0x181E1E0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005BE")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200010C")]
	private struct <MaxAwaitAsync>d__26 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B56")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B57")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Int32>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B58")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B59")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B5A")]
		public Func<TSource, UniTask`1<Nullable`1<Int32>>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B5B")]
		private Nullable<Int32> <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B5C")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B5D")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B5E")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B5F")]
		private Nullable<Int32> <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B60")]
		private Awaiter<Nullable<Int32>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B61")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B62")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x181EE30", Offset = "0x181E230", Length = "0xD0F")]
		[Token(Token = "0x60005BF")]
		private override void MoveNext() { }

		[Address(RVA = "0x181FB50", Offset = "0x181EF50", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005C0")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200010D")]
	private struct <MaxAwaitAsync>d__30 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B63")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B64")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Int64>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B65")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B66")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B67")]
		public Func<TSource, UniTask`1<Nullable`1<Int64>>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B68")]
		private Nullable<Int64> <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B69")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B6A")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B6B")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B6C")]
		private Nullable<Int64> <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B6D")]
		private Awaiter<Nullable<Int64>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B6E")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B6F")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x18C1BF0", Offset = "0x18C0FF0", Length = "0xD3B")]
		[Token(Token = "0x60005C1")]
		private override void MoveNext() { }

		[Address(RVA = "0x18C2930", Offset = "0x18C1D30", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005C2")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200010E")]
	private struct <MaxAwaitAsync>d__34 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B70")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B71")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Single>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B72")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B73")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B74")]
		public Func<TSource, UniTask`1<Nullable`1<Single>>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B75")]
		private Nullable<Single> <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B76")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B77")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B78")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B79")]
		private Nullable<Single> <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B7A")]
		private Awaiter<Nullable<Single>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B7B")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B7C")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x18C2980", Offset = "0x18C1D80", Length = "0xD0F")]
		[Token(Token = "0x60005C3")]
		private override void MoveNext() { }

		[Address(RVA = "0x18C36A0", Offset = "0x18C2AA0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005C4")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200010F")]
	private struct <MaxAwaitAsync>d__38 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B7D")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B7E")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Double>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B7F")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B80")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B81")]
		public Func<TSource, UniTask`1<Nullable`1<Double>>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B82")]
		private Nullable<Double> <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B83")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B84")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B85")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B86")]
		private Nullable<Double> <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B87")]
		private Awaiter<Nullable<Double>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B88")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B89")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x18C36F0", Offset = "0x18C2AF0", Length = "0xD5B")]
		[Token(Token = "0x60005C5")]
		private override void MoveNext() { }

		[Address(RVA = "0x18C4450", Offset = "0x18C3850", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005C6")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000110")]
	private struct <MaxAwaitAsync>d__42 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B8A")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B8B")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Decimal>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B8C")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B8D")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B8E")]
		public Func<TSource, UniTask`1<Nullable`1<Decimal>>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B8F")]
		private Nullable<Decimal> <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B90")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B91")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B92")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B93")]
		private Nullable<Decimal> <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B94")]
		private Awaiter<Nullable<Decimal>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B95")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B96")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x18C44A0", Offset = "0x18C38A0", Length = "0xED0")]
		[Token(Token = "0x60005C7")]
		private override void MoveNext() { }

		[Address(RVA = "0x18C5380", Offset = "0x18C4780", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005C8")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000111")]
	private struct <MaxAwaitAsync>d__6 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B97")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B98")]
		public AsyncUniTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B99")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B9A")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B9B")]
		public Func<TSource, UniTask`1<Int32>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B9C")]
		private int <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B9D")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B9E")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B9F")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BA0")]
		private Awaiter<Int32> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BA1")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BA2")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x18C53D0", Offset = "0x18C47D0", Length = "0xC8C")]
		[Token(Token = "0x60005C9")]
		private override void MoveNext() { }

		[Address(RVA = "0x18C6060", Offset = "0x18C5460", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005CA")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000112")]
	private struct <MaxAwaitWithCancellationAsync>d__11 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BA3")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BA4")]
		public AsyncUniTaskMethodBuilder<Int64> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BA5")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BA6")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BA7")]
		public Func<TSource, CancellationToken, UniTask`1<Int64>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BA8")]
		private long <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BA9")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BAA")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BAB")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BAC")]
		private Awaiter<Int64> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BAD")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BAE")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x18C60B0", Offset = "0x18C54B0", Length = "0xCC5")]
		[Token(Token = "0x60005CB")]
		private override void MoveNext() { }

		[Address(RVA = "0x18C6D80", Offset = "0x18C6180", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005CC")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000113")]
	private struct <MaxAwaitWithCancellationAsync>d__15 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BAF")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BB0")]
		public AsyncUniTaskMethodBuilder<Single> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BB1")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BB2")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BB3")]
		public Func<TSource, CancellationToken, UniTask`1<Single>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BB4")]
		private float <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BB5")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BB6")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BB7")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BB8")]
		private Awaiter<Single> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BB9")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BBA")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x18C6DD0", Offset = "0x18C61D0", Length = "0xC19")]
		[Token(Token = "0x60005CD")]
		private override void MoveNext() { }

		[Address(RVA = "0x18C79F0", Offset = "0x18C6DF0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005CE")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000114")]
	private struct <MaxAwaitWithCancellationAsync>d__19 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BBB")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BBC")]
		public AsyncUniTaskMethodBuilder<Double> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BBD")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BBE")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BBF")]
		public Func<TSource, CancellationToken, UniTask`1<Double>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BC0")]
		private double <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BC1")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BC2")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BC3")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BC4")]
		private Awaiter<Double> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BC5")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BC6")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x18C7A40", Offset = "0x18C6E40", Length = "0xCC7")]
		[Token(Token = "0x60005CF")]
		private override void MoveNext() { }

		[Address(RVA = "0x18C8710", Offset = "0x18C7B10", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005D0")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000115")]
	private struct <MaxAwaitWithCancellationAsync>d__23 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BC7")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BC8")]
		public AsyncUniTaskMethodBuilder<Decimal> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BC9")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BCA")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BCB")]
		public Func<TSource, CancellationToken, UniTask`1<Decimal>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BCC")]
		private decimal <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BCD")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BCE")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BCF")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BD0")]
		private Awaiter<Decimal> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BD1")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BD2")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x18C8760", Offset = "0x18C7B60", Length = "0xD53")]
		[Token(Token = "0x60005D1")]
		private override void MoveNext() { }

		[Address(RVA = "0x18C94C0", Offset = "0x18C88C0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005D2")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000116")]
	private struct <MaxAwaitWithCancellationAsync>d__27 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BD3")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BD4")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Int32>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BD5")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BD6")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BD7")]
		public Func<TSource, CancellationToken, UniTask`1<Nullable`1<Int32>>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BD8")]
		private Nullable<Int32> <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BD9")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BDA")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BDB")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BDC")]
		private Nullable<Int32> <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BDD")]
		private Awaiter<Nullable<Int32>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BDE")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BDF")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x18C9510", Offset = "0x18C8910", Length = "0xD36")]
		[Token(Token = "0x60005D3")]
		private override void MoveNext() { }

		[Address(RVA = "0x18CA250", Offset = "0x18C9650", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005D4")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000117")]
	private struct <MaxAwaitWithCancellationAsync>d__3 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BE0")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BE1")]
		public AsyncUniTaskMethodBuilder<TResult> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BE2")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BE3")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BE4")]
		public Func<TSource, CancellationToken, UniTask`1<TResult>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BE5")]
		private TResult <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BE6")]
		private Comparer<TResult> <comparer>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BE7")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BE8")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BE9")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BEA")]
		private TResult <>7__wrap6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BEB")]
		private Awaiter<TResult> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BEC")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BED")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x18CCC20", Offset = "0x18CC020", Length = "0x230C")]
		[Token(Token = "0x60005D5")]
		private override void MoveNext() { }

		[Address(RVA = "0x1821E20", Offset = "0x1821220", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x60005D6")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000118")]
	private struct <MaxAwaitWithCancellationAsync>d__31 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BEE")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BEF")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Int64>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BF0")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BF1")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BF2")]
		public Func<TSource, CancellationToken, UniTask`1<Nullable`1<Int64>>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BF3")]
		private Nullable<Int64> <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BF4")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BF5")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BF6")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BF7")]
		private Nullable<Int64> <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BF8")]
		private Awaiter<Nullable<Int64>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BF9")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BFA")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x18CA2A0", Offset = "0x18C96A0", Length = "0xD94")]
		[Token(Token = "0x60005D7")]
		private override void MoveNext() { }

		[Address(RVA = "0x18CB040", Offset = "0x18CA440", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005D8")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000119")]
	private struct <MaxAwaitWithCancellationAsync>d__35 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BFB")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BFC")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Single>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BFD")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BFE")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BFF")]
		public Func<TSource, CancellationToken, UniTask`1<Nullable`1<Single>>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C00")]
		private Nullable<Single> <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C01")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C02")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C03")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C04")]
		private Nullable<Single> <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C05")]
		private Awaiter<Nullable<Single>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C06")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C07")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x18CB090", Offset = "0x18CA490", Length = "0xD36")]
		[Token(Token = "0x60005D9")]
		private override void MoveNext() { }

		[Address(RVA = "0x18CBDD0", Offset = "0x18CB1D0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005DA")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200011A")]
	private struct <MaxAwaitWithCancellationAsync>d__39 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C08")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C09")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Double>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C0A")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C0B")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C0C")]
		public Func<TSource, CancellationToken, UniTask`1<Nullable`1<Double>>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C0D")]
		private Nullable<Double> <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C0E")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C0F")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C10")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C11")]
		private Nullable<Double> <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C12")]
		private Awaiter<Nullable<Double>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C13")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C14")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x18CBE20", Offset = "0x18CB220", Length = "0xDA4")]
		[Token(Token = "0x60005DB")]
		private override void MoveNext() { }

		[Address(RVA = "0x18CCBD0", Offset = "0x18CBFD0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005DC")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200011B")]
	private struct <MaxAwaitWithCancellationAsync>d__43 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C15")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C16")]
		public AsyncUniTaskMethodBuilder<Nullable`1<Decimal>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C17")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C18")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C19")]
		public Func<TSource, CancellationToken, UniTask`1<Nullable`1<Decimal>>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C1A")]
		private Nullable<Decimal> <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C1B")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C1C")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C1D")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C1E")]
		private Nullable<Decimal> <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C1F")]
		private Awaiter<Nullable<Decimal>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C20")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C21")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x18CEF30", Offset = "0x18CE330", Length = "0xF32")]
		[Token(Token = "0x60005DD")]
		private override void MoveNext() { }

		[Address(RVA = "0x18CFE70", Offset = "0x18CF270", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005DE")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200011C")]
	private struct <MaxAwaitWithCancellationAsync>d__7 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C22")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C23")]
		public AsyncUniTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C24")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C25")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C26")]
		public Func<TSource, CancellationToken, UniTask`1<Int32>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C27")]
		private int <value>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C28")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C29")]
		private object <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C2A")]
		private int <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C2B")]
		private Awaiter<Int32> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C2C")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C2D")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x18CFEC0", Offset = "0x18CF2C0", Length = "0xCB4")]
		[Token(Token = "0x60005DF")]
		private override void MoveNext() { }

		[Address(RVA = "0x18D0B80", Offset = "0x18CFF80", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60005E0")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x865850", Offset = "0x864C50", Length = "0x24C")]
	[AsyncStateMachine(typeof(<MaxAsync>d__0`1))]
	[Token(Token = "0x600055D")]
	public static UniTask<TSource> MaxAsync(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x865480", Offset = "0x864880", Length = "0x149")]
	[AsyncStateMachine(typeof(<MaxAsync>d__41`1))]
	[Token(Token = "0x6000586")]
	public static UniTask<Nullable`1<Decimal>> MaxAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Nullable`1<Decimal>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x27521A0", Offset = "0x27515A0", Length = "0x13B")]
	[AsyncStateMachine(typeof(<MaxAsync>d__40))]
	[Token(Token = "0x6000585")]
	public static UniTask<Nullable`1<Decimal>> MaxAsync(IUniTaskAsyncEnumerable<Nullable`1<Decimal>> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x8655D0", Offset = "0x8649D0", Length = "0x127")]
	[AsyncStateMachine(typeof(<MaxAsync>d__37`1))]
	[Token(Token = "0x6000582")]
	public static UniTask<Nullable`1<Double>> MaxAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Nullable`1<Double>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2751F20", Offset = "0x2751320", Length = "0x136")]
	[AsyncStateMachine(typeof(<MaxAsync>d__36))]
	[Token(Token = "0x6000581")]
	public static UniTask<Nullable`1<Double>> MaxAsync(IUniTaskAsyncEnumerable<Nullable`1<Double>> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x796160", Offset = "0x795560", Length = "0x12C")]
	[AsyncStateMachine(typeof(<MaxAsync>d__33`1))]
	[Token(Token = "0x600057E")]
	public static UniTask<Nullable`1<Single>> MaxAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Nullable`1<Single>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2751CA0", Offset = "0x27510A0", Length = "0x139")]
	[AsyncStateMachine(typeof(<MaxAsync>d__32))]
	[Token(Token = "0x600057D")]
	public static UniTask<Nullable`1<Single>> MaxAsync(IUniTaskAsyncEnumerable<Nullable`1<Single>> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x865AA0", Offset = "0x864EA0", Length = "0x127")]
	[AsyncStateMachine(typeof(<MaxAsync>d__29`1))]
	[Token(Token = "0x600057A")]
	public static UniTask<Nullable`1<Int64>> MaxAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Nullable`1<Int64>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x27527B0", Offset = "0x2751BB0", Length = "0x136")]
	[AsyncStateMachine(typeof(<MaxAsync>d__28))]
	[Token(Token = "0x6000579")]
	public static UniTask<Nullable`1<Int64>> MaxAsync(IUniTaskAsyncEnumerable<Nullable`1<Int64>> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x8650F0", Offset = "0x8644F0", Length = "0x12C")]
	[AsyncStateMachine(typeof(<MaxAsync>d__25`1))]
	[Token(Token = "0x6000576")]
	public static UniTask<Nullable`1<Int32>> MaxAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Nullable`1<Int32>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x27522E0", Offset = "0x27516E0", Length = "0x139")]
	[AsyncStateMachine(typeof(<MaxAsync>d__24))]
	[Token(Token = "0x6000575")]
	public static UniTask<Nullable`1<Int32>> MaxAsync(IUniTaskAsyncEnumerable<Nullable`1<Int32>> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2752680", Offset = "0x2751A80", Length = "0x12E")]
	[AsyncStateMachine(typeof(<MaxAsync>d__20))]
	[Token(Token = "0x6000571")]
	public static UniTask<Decimal> MaxAsync(IUniTaskAsyncEnumerable<Decimal> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x865220", Offset = "0x864620", Length = "0x12C")]
	[AsyncStateMachine(typeof(<MaxAsync>d__17`1))]
	[Token(Token = "0x600056E")]
	public static UniTask<Double> MaxAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Double> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2752060", Offset = "0x2751460", Length = "0x136")]
	[AsyncStateMachine(typeof(<MaxAsync>d__16))]
	[Token(Token = "0x600056D")]
	public static UniTask<Double> MaxAsync(IUniTaskAsyncEnumerable<Double> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x865700", Offset = "0x864B00", Length = "0x14B")]
	[AsyncStateMachine(typeof(<MaxAsync>d__21`1))]
	[Token(Token = "0x6000572")]
	public static UniTask<Decimal> MaxAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Decimal> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x863C70", Offset = "0x863070", Length = "0x12C")]
	[AsyncStateMachine(typeof(<MaxAsync>d__9`1))]
	[Token(Token = "0x6000566")]
	public static UniTask<Int64> MaxAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int64> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x7B8E30", Offset = "0x7B8230", Length = "0x123")]
	[AsyncStateMachine(typeof(<MaxAsync>d__5`1))]
	[Token(Token = "0x6000562")]
	public static UniTask<Int32> MaxAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2751DE0", Offset = "0x27511E0", Length = "0x136")]
	[AsyncStateMachine(typeof(<MaxAsync>d__8))]
	[Token(Token = "0x6000565")]
	public static UniTask<Int64> MaxAsync(IUniTaskAsyncEnumerable<Int64> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x6E1550", Offset = "0x6E0950", Length = "0x29A")]
	[AsyncStateMachine(typeof(<MaxAsync>d__1`2))]
	[Token(Token = "0x600055E")]
	public static UniTask<TResult> MaxAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TResult> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2752420", Offset = "0x2751820", Length = "0x12B")]
	[AsyncStateMachine(typeof(<MaxAsync>d__4))]
	[Token(Token = "0x6000561")]
	public static UniTask<Int32> MaxAsync(IUniTaskAsyncEnumerable<Int32> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2752550", Offset = "0x2751950", Length = "0x12B")]
	[AsyncStateMachine(typeof(<MaxAsync>d__12))]
	[Token(Token = "0x6000569")]
	public static UniTask<Single> MaxAsync(IUniTaskAsyncEnumerable<Single> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x865350", Offset = "0x864750", Length = "0x123")]
	[AsyncStateMachine(typeof(<MaxAsync>d__13`1))]
	[Token(Token = "0x600056A")]
	public static UniTask<Single> MaxAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Single> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x6E1550", Offset = "0x6E0950", Length = "0x29A")]
	[AsyncStateMachine(typeof(<MaxAwaitAsync>d__2`2))]
	[Token(Token = "0x600055F")]
	public static UniTask<TResult> MaxAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<TResult>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x865D00", Offset = "0x865100", Length = "0x160")]
	[AsyncStateMachine(typeof(<MaxAwaitAsync>d__42`1))]
	[Token(Token = "0x6000587")]
	public static UniTask<Nullable`1<Decimal>> MaxAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Nullable`1<Decimal>>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x865E60", Offset = "0x865260", Length = "0x12F")]
	[AsyncStateMachine(typeof(<MaxAwaitAsync>d__22`1))]
	[Token(Token = "0x6000573")]
	public static UniTask<Decimal> MaxAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Decimal>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x865BD0", Offset = "0x864FD0", Length = "0x130")]
	[AsyncStateMachine(typeof(<MaxAwaitAsync>d__10`1))]
	[Token(Token = "0x6000567")]
	public static UniTask<Int64> MaxAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Int64>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x7969F0", Offset = "0x795DF0", Length = "0x136")]
	[AsyncStateMachine(typeof(<MaxAwaitAsync>d__34`1))]
	[Token(Token = "0x600057F")]
	public static UniTask<Nullable`1<Single>> MaxAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Nullable`1<Single>>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x866330", Offset = "0x865730", Length = "0x136")]
	[AsyncStateMachine(typeof(<MaxAwaitAsync>d__26`1))]
	[Token(Token = "0x6000577")]
	public static UniTask<Nullable`1<Int32>> MaxAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Nullable`1<Int32>>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x866470", Offset = "0x865870", Length = "0x134")]
	[AsyncStateMachine(typeof(<MaxAwaitAsync>d__38`1))]
	[Token(Token = "0x6000583")]
	public static UniTask<Nullable`1<Double>> MaxAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Nullable`1<Double>>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x865F90", Offset = "0x865390", Length = "0x127")]
	[AsyncStateMachine(typeof(<MaxAwaitAsync>d__14`1))]
	[Token(Token = "0x600056B")]
	public static UniTask<Single> MaxAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Single>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x8661F0", Offset = "0x8655F0", Length = "0x134")]
	[AsyncStateMachine(typeof(<MaxAwaitAsync>d__30`1))]
	[Token(Token = "0x600057B")]
	public static UniTask<Nullable`1<Int64>> MaxAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Nullable`1<Int64>>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x8660C0", Offset = "0x8654C0", Length = "0x127")]
	[AsyncStateMachine(typeof(<MaxAwaitAsync>d__6`1))]
	[Token(Token = "0x6000563")]
	public static UniTask<Int32> MaxAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Int32>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x797150", Offset = "0x796550", Length = "0x130")]
	[AsyncStateMachine(typeof(<MaxAwaitAsync>d__18`1))]
	[Token(Token = "0x600056F")]
	public static UniTask<Double> MaxAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Double>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x866470", Offset = "0x865870", Length = "0x134")]
	[AsyncStateMachine(typeof(<MaxAwaitWithCancellationAsync>d__39`1))]
	[Token(Token = "0x6000584")]
	public static UniTask<Nullable`1<Double>> MaxAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Nullable`1<Double>>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x6E1550", Offset = "0x6E0950", Length = "0x29A")]
	[AsyncStateMachine(typeof(<MaxAwaitWithCancellationAsync>d__3`2))]
	[Token(Token = "0x6000560")]
	public static UniTask<TResult> MaxAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<TResult>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x865F90", Offset = "0x865390", Length = "0x127")]
	[AsyncStateMachine(typeof(<MaxAwaitWithCancellationAsync>d__15`1))]
	[Token(Token = "0x600056C")]
	public static UniTask<Single> MaxAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Single>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x8660C0", Offset = "0x8654C0", Length = "0x127")]
	[AsyncStateMachine(typeof(<MaxAwaitWithCancellationAsync>d__7`1))]
	[Token(Token = "0x6000564")]
	public static UniTask<Int32> MaxAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Int32>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x8661F0", Offset = "0x8655F0", Length = "0x134")]
	[AsyncStateMachine(typeof(<MaxAwaitWithCancellationAsync>d__31`1))]
	[Token(Token = "0x600057C")]
	public static UniTask<Nullable`1<Int64>> MaxAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Nullable`1<Int64>>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x866330", Offset = "0x865730", Length = "0x136")]
	[AsyncStateMachine(typeof(<MaxAwaitWithCancellationAsync>d__27`1))]
	[Token(Token = "0x6000578")]
	public static UniTask<Nullable`1<Int32>> MaxAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Nullable`1<Int32>>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x865E60", Offset = "0x865260", Length = "0x12F")]
	[AsyncStateMachine(typeof(<MaxAwaitWithCancellationAsync>d__23`1))]
	[Token(Token = "0x6000574")]
	public static UniTask<Decimal> MaxAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Decimal>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x865BD0", Offset = "0x864FD0", Length = "0x130")]
	[AsyncStateMachine(typeof(<MaxAwaitWithCancellationAsync>d__11`1))]
	[Token(Token = "0x6000568")]
	public static UniTask<Int64> MaxAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Int64>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x797150", Offset = "0x796550", Length = "0x130")]
	[AsyncStateMachine(typeof(<MaxAwaitWithCancellationAsync>d__19`1))]
	[Token(Token = "0x6000570")]
	public static UniTask<Double> MaxAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Double>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x7969F0", Offset = "0x795DF0", Length = "0x136")]
	[AsyncStateMachine(typeof(<MaxAwaitWithCancellationAsync>d__35`1))]
	[Token(Token = "0x6000580")]
	public static UniTask<Nullable`1<Single>> MaxAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Nullable`1<Single>>> selector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x865D00", Offset = "0x865100", Length = "0x160")]
	[AsyncStateMachine(typeof(<MaxAwaitWithCancellationAsync>d__43`1))]
	[Token(Token = "0x6000588")]
	public static UniTask<Nullable`1<Decimal>> MaxAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Nullable`1<Decimal>>> selector, CancellationToken cancellationToken) { }

}

