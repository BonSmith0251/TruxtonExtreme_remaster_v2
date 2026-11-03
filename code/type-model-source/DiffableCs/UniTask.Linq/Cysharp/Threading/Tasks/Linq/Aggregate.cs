namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000018")]
internal static class Aggregate
{
	[CompilerGenerated]
	[Token(Token = "0x2000019")]
	private struct <AggregateAsync>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002D")]
		public AsyncUniTaskMethodBuilder<TSource> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002E")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002F")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000030")]
		public Func<TSource, TSource, TSource> accumulator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000031")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000032")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000033")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000034")]
		private TSource <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000035")]
		private TSource <value>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000036")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000037")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0xA55CF0", Offset = "0xA550F0", Length = "0x17A0")]
		[Token(Token = "0x600021C")]
		private override void MoveNext() { }

		[Address(RVA = "0xA574A0", Offset = "0xA568A0", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x600021D")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200001A")]
	private struct <AggregateAsync>d__1 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000038")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000039")]
		public AsyncUniTaskMethodBuilder<TAccumulate> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003A")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003B")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003C")]
		public TAccumulate seed; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003D")]
		public Func<TAccumulate, TSource, TAccumulate> accumulator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003E")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003F")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000040")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000041")]
		private TAccumulate <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000042")]
		private TAccumulate <value>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000043")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000044")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0xA57570", Offset = "0xA56970", Length = "0x1545")]
		[Token(Token = "0x600021E")]
		private override void MoveNext() { }

		[Address(RVA = "0xA58AC0", Offset = "0xA57EC0", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x600021F")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200001B")]
	private struct <AggregateAsync>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000045")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000046")]
		public AsyncUniTaskMethodBuilder<TResult> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000047")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000048")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000049")]
		public TAccumulate seed; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004A")]
		public Func<TAccumulate, TSource, TAccumulate> accumulator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004B")]
		public Func<TAccumulate, TResult> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004C")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004D")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004E")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004F")]
		private TResult <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000050")]
		private TAccumulate <value>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000051")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000052")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0xA58B90", Offset = "0xA57F90", Length = "0x167B")]
		[Token(Token = "0x6000220")]
		private override void MoveNext() { }

		[Address(RVA = "0xA5A210", Offset = "0xA59610", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x6000221")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200001C")]
	private struct <AggregateAwaitAsync>d__3 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000053")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000054")]
		public AsyncUniTaskMethodBuilder<TSource> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000055")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000056")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000057")]
		public Func<TSource, TSource, UniTask`1<TSource>> accumulator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000058")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000059")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005A")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005B")]
		private TSource <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005C")]
		private TSource <value>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005D")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005E")]
		private Awaiter<TSource> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005F")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0xA5A2E0", Offset = "0xA596E0", Length = "0x1ABC")]
		[Token(Token = "0x6000222")]
		private override void MoveNext() { }

		[Address(RVA = "0xA5BDA0", Offset = "0xA5B1A0", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x6000223")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200001D")]
	private struct <AggregateAwaitAsync>d__4 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000060")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000061")]
		public AsyncUniTaskMethodBuilder<TAccumulate> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000062")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000063")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000064")]
		public TAccumulate seed; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000065")]
		public Func<TAccumulate, TSource, UniTask`1<TAccumulate>> accumulator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000066")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000067")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000068")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000069")]
		private TAccumulate <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006A")]
		private TAccumulate <value>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006B")]
		private Awaiter<TAccumulate> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006C")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006D")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0xA5BE70", Offset = "0xA5B270", Length = "0x179F")]
		[Token(Token = "0x6000224")]
		private override void MoveNext() { }

		[Address(RVA = "0xA5D620", Offset = "0xA5CA20", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x6000225")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200001E")]
	private struct <AggregateAwaitAsync>d__5 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006E")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006F")]
		public AsyncUniTaskMethodBuilder<TResult> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000070")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000071")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000072")]
		public TAccumulate seed; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000073")]
		public Func<TAccumulate, TSource, UniTask`1<TAccumulate>> accumulator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000074")]
		public Func<TAccumulate, UniTask`1<TResult>> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000075")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000076")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000077")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000078")]
		private TResult <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000079")]
		private TAccumulate <value>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007A")]
		private Awaiter<TAccumulate> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007B")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007C")]
		private Awaiter<TResult> <>u__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007D")]
		private Awaiter <>u__4; //Field offset: 0x0

		[Address(RVA = "0xA5D6F0", Offset = "0xA5CAF0", Length = "0x1E53")]
		[Token(Token = "0x6000226")]
		private override void MoveNext() { }

		[Address(RVA = "0xA5F550", Offset = "0xA5E950", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x6000227")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200001F")]
	private struct <AggregateAwaitWithCancellationAsync>d__6 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007E")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007F")]
		public AsyncUniTaskMethodBuilder<TSource> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000080")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000081")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000082")]
		public Func<TSource, TSource, CancellationToken, UniTask`1<TSource>> accumulator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000083")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000084")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000085")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000086")]
		private TSource <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000087")]
		private TSource <value>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000088")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000089")]
		private Awaiter<TSource> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400008A")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0xA5F620", Offset = "0xA5EA20", Length = "0x1AF5")]
		[Token(Token = "0x6000228")]
		private override void MoveNext() { }

		[Address(RVA = "0xA5BDA0", Offset = "0xA5B1A0", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x6000229")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000020")]
	private struct <AggregateAwaitWithCancellationAsync>d__7 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400008B")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400008C")]
		public AsyncUniTaskMethodBuilder<TAccumulate> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400008D")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400008E")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400008F")]
		public TAccumulate seed; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000090")]
		public Func<TAccumulate, TSource, CancellationToken, UniTask`1<TAccumulate>> accumulator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000091")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000092")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000093")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000094")]
		private TAccumulate <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000095")]
		private TAccumulate <value>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000096")]
		private Awaiter<TAccumulate> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000097")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000098")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0xA61120", Offset = "0xA60520", Length = "0x17ED")]
		[Token(Token = "0x600022A")]
		private override void MoveNext() { }

		[Address(RVA = "0xA5D620", Offset = "0xA5CA20", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x600022B")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000021")]
	private struct <AggregateAwaitWithCancellationAsync>d__8 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000099")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400009A")]
		public AsyncUniTaskMethodBuilder<TResult> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400009B")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400009C")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400009D")]
		public TAccumulate seed; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400009E")]
		public Func<TAccumulate, TSource, CancellationToken, UniTask`1<TAccumulate>> accumulator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400009F")]
		public Func<TAccumulate, CancellationToken, UniTask`1<TResult>> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A0")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A1")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A2")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A3")]
		private TResult <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A4")]
		private TAccumulate <value>5__6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A5")]
		private Awaiter<TAccumulate> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A6")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A7")]
		private Awaiter<TResult> <>u__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A8")]
		private Awaiter <>u__4; //Field offset: 0x0

		[Address(RVA = "0xA62910", Offset = "0xA61D10", Length = "0x1ED9")]
		[Token(Token = "0x600022C")]
		private override void MoveNext() { }

		[Address(RVA = "0xA5F550", Offset = "0xA5E950", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x600022D")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x6E1550", Offset = "0x6E0950", Length = "0x29A")]
	[AsyncStateMachine(typeof(<AggregateAsync>d__0`1))]
	[Token(Token = "0x6000213")]
	internal static UniTask<TSource> AggregateAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TSource, TSource> accumulator, CancellationToken cancellationToken) { }

	[Address(RVA = "0x6E1220", Offset = "0x6E0620", Length = "0x330")]
	[AsyncStateMachine(typeof(<AggregateAsync>d__1`2))]
	[Token(Token = "0x6000214")]
	internal static UniTask<TAccumulate> AggregateAsync(IUniTaskAsyncEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> accumulator, CancellationToken cancellationToken) { }

	[Address(RVA = "0x6E0EA0", Offset = "0x6E02A0", Length = "0x377")]
	[AsyncStateMachine(typeof(<AggregateAsync>d__2`3))]
	[Token(Token = "0x6000215")]
	internal static UniTask<TResult> AggregateAsync(IUniTaskAsyncEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> accumulator, Func<TAccumulate, TResult> resultSelector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x6E1550", Offset = "0x6E0950", Length = "0x29A")]
	[AsyncStateMachine(typeof(<AggregateAwaitAsync>d__3`1))]
	[Token(Token = "0x6000216")]
	internal static UniTask<TSource> AggregateAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TSource, UniTask`1<TSource>> accumulator, CancellationToken cancellationToken) { }

	[Address(RVA = "0x6E1220", Offset = "0x6E0620", Length = "0x330")]
	[AsyncStateMachine(typeof(<AggregateAwaitAsync>d__4`2))]
	[Token(Token = "0x6000217")]
	internal static UniTask<TAccumulate> AggregateAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, UniTask`1<TAccumulate>> accumulator, CancellationToken cancellationToken) { }

	[Address(RVA = "0x6E0EA0", Offset = "0x6E02A0", Length = "0x377")]
	[AsyncStateMachine(typeof(<AggregateAwaitAsync>d__5`3))]
	[Token(Token = "0x6000218")]
	internal static UniTask<TResult> AggregateAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, UniTask`1<TAccumulate>> accumulator, Func<TAccumulate, UniTask`1<TResult>> resultSelector, CancellationToken cancellationToken) { }

	[Address(RVA = "0x6E1550", Offset = "0x6E0950", Length = "0x29A")]
	[AsyncStateMachine(typeof(<AggregateAwaitWithCancellationAsync>d__6`1))]
	[Token(Token = "0x6000219")]
	internal static UniTask<TSource> AggregateAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TSource, CancellationToken, UniTask`1<TSource>> accumulator, CancellationToken cancellationToken) { }

	[Address(RVA = "0x6E1220", Offset = "0x6E0620", Length = "0x330")]
	[AsyncStateMachine(typeof(<AggregateAwaitWithCancellationAsync>d__7`2))]
	[Token(Token = "0x600021A")]
	internal static UniTask<TAccumulate> AggregateAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, CancellationToken, UniTask`1<TAccumulate>> accumulator, CancellationToken cancellationToken) { }

	[Address(RVA = "0x6E0EA0", Offset = "0x6E02A0", Length = "0x377")]
	[AsyncStateMachine(typeof(<AggregateAwaitWithCancellationAsync>d__8`3))]
	[Token(Token = "0x600021B")]
	internal static UniTask<TResult> AggregateAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, CancellationToken, UniTask`1<TAccumulate>> accumulator, Func<TAccumulate, CancellationToken, UniTask`1<TResult>> resultSelector, CancellationToken cancellationToken) { }

}

