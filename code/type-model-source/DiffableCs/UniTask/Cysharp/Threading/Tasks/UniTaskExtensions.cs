namespace Cysharp.Threading.Tasks;

[Extension]
[Token(Token = "0x200010D")]
public static class UniTaskExtensions
{
	[CompilerGenerated]
	[Token(Token = "0x2000116")]
	private sealed class <>c
	{
		[Token(Token = "0x400040E")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400040F")]
		public static Action<Task, Object> <>9__1_0; //Field offset: 0x8
		[Token(Token = "0x4000410")]
		public static Action<Object> <>9__3_0; //Field offset: 0x10
		[Token(Token = "0x4000411")]
		public static Action<Object> <>9__16_0; //Field offset: 0x18

		[Address(RVA = "0x273F350", Offset = "0x273E750", Length = "0x67")]
		[Token(Token = "0x6000704")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000705")]
		public <>c() { }

		[Address(RVA = "0x273E4F0", Offset = "0x273D8F0", Length = "0x20E")]
		[Token(Token = "0x6000707")]
		internal void <AsTask>b__3_0(object state) { }

		[Address(RVA = "0x273E700", Offset = "0x273DB00", Length = "0x158")]
		[Token(Token = "0x6000706")]
		internal void <AsUniTask>b__1_0(Task x, object state) { }

		[Address(RVA = "0x273E860", Offset = "0x273DC60", Length = "0x176")]
		[Token(Token = "0x6000708")]
		internal void <Forget>b__16_0(object state) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000117")]
	private sealed class <>c__0
	{
		[Token(Token = "0x4000412")]
		public static readonly <>c__0<T> <>9; //Field offset: 0x0
		[Token(Token = "0x4000413")]
		public static Action<Task`1<T>, Object> <>9__0_0; //Field offset: 0x0

		[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
		[Token(Token = "0x6000709")]
		private static <>c__0`1() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600070A")]
		public <>c__0`1() { }

		[Address(RVA = "0xA50690", Offset = "0xA4FA90", Length = "0x206")]
		[Token(Token = "0x600070B")]
		internal void <AsUniTask>b__0_0(Task<T> x, object state) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000118")]
	private sealed class <>c__19
	{
		[Token(Token = "0x4000414")]
		public static readonly <>c__19<T> <>9; //Field offset: 0x0
		[Token(Token = "0x4000415")]
		public static Action<Object> <>9__19_0; //Field offset: 0x0

		[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
		[Token(Token = "0x600070C")]
		private static <>c__19`1() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600070D")]
		public <>c__19`1() { }

		[Address(RVA = "0xA517F0", Offset = "0xA50BF0", Length = "0x1C5")]
		[Token(Token = "0x600070E")]
		internal void <Forget>b__19_0(object state) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000119")]
	private sealed class <>c__2
	{
		[Token(Token = "0x4000416")]
		public static readonly <>c__2<T> <>9; //Field offset: 0x0
		[Token(Token = "0x4000417")]
		public static Action<Object> <>9__2_0; //Field offset: 0x0

		[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
		[Token(Token = "0x600070F")]
		private static <>c__2`1() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000710")]
		public <>c__2`1() { }

		[Address(RVA = "0xA51C10", Offset = "0xA51010", Length = "0x39B")]
		[Token(Token = "0x6000711")]
		internal void <AsTask>b__2_0(object state) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200011A")]
	private struct <ContinueWith>d__22 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000418")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000419")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400041A")]
		public Action<T> continuationFunction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400041B")]
		public UniTask<T> task; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400041C")]
		private Action<T> <>7__wrap1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400041D")]
		private Awaiter<T> <>u__1; //Field offset: 0x0

		[Address(RVA = "0x1144F80", Offset = "0x1144380", Length = "0x821")]
		[Token(Token = "0x6000712")]
		private override void MoveNext() { }

		[Address(RVA = "0x113D7A0", Offset = "0x113CBA0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000713")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200011B")]
	private struct <ContinueWith>d__23 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400041E")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400041F")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000420")]
		public Func<T, UniTask> continuationFunction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000421")]
		public UniTask<T> task; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000422")]
		private Func<T, UniTask> <>7__wrap1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000423")]
		private Awaiter<T> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000424")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x11457B0", Offset = "0x1144BB0", Length = "0xAF7")]
		[Token(Token = "0x6000714")]
		private override void MoveNext() { }

		[Address(RVA = "0x113D7A0", Offset = "0x113CBA0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000715")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200011C")]
	private struct <ContinueWith>d__24 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000425")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000426")]
		public AsyncUniTaskMethodBuilder<TR> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000427")]
		public Func<T, TR> continuationFunction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000428")]
		public UniTask<T> task; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000429")]
		private Func<T, TR> <>7__wrap1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400042A")]
		private Awaiter<T> <>u__1; //Field offset: 0x0

		[Address(RVA = "0x11462B0", Offset = "0x11456B0", Length = "0x90F")]
		[Token(Token = "0x6000716")]
		private override void MoveNext() { }

		[Address(RVA = "0x1146BD0", Offset = "0x1145FD0", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x6000717")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200011D")]
	private struct <ContinueWith>d__25 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400042B")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400042C")]
		public AsyncUniTaskMethodBuilder<TR> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400042D")]
		public Func<T, UniTask`1<TR>> continuationFunction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400042E")]
		public UniTask<T> task; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400042F")]
		private Func<T, UniTask`1<TR>> <>7__wrap1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000430")]
		private Awaiter<T> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000431")]
		private Awaiter<TR> <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1146CA0", Offset = "0x11460A0", Length = "0xDD6")]
		[Token(Token = "0x6000718")]
		private override void MoveNext() { }

		[Address(RVA = "0x1147A80", Offset = "0x1146E80", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x6000719")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200011E")]
	private struct <ContinueWith>d__26 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000432")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000433")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000434")]
		public UniTask task; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000435")]
		public Action continuationFunction; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000436")]
		private Awaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x273A110", Offset = "0x2739510", Length = "0x296")]
		[Token(Token = "0x600071A")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x600071B")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200011F")]
	private struct <ContinueWith>d__27 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000437")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000438")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000439")]
		public UniTask task; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400043A")]
		public Func<UniTask> continuationFunction; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400043B")]
		private Awaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x273A3B0", Offset = "0x27397B0", Length = "0x331")]
		[Token(Token = "0x600071C")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x600071D")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000120")]
	private struct <ContinueWith>d__28 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400043C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400043D")]
		public AsyncUniTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400043E")]
		public UniTask task; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400043F")]
		public Func<T> continuationFunction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000440")]
		private Awaiter <>u__1; //Field offset: 0x0

		[Address(RVA = "0x1147B50", Offset = "0x1146F50", Length = "0x6B2")]
		[Token(Token = "0x600071E")]
		private override void MoveNext() { }

		[Address(RVA = "0x1148210", Offset = "0x1147610", Length = "0xC1")]
		[DebuggerHidden]
		[Token(Token = "0x600071F")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000121")]
	private struct <ContinueWith>d__29 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000441")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000442")]
		public AsyncUniTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000443")]
		public UniTask task; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000444")]
		public Func<UniTask`1<T>> continuationFunction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000445")]
		private Awaiter <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000446")]
		private Awaiter<T> <>u__2; //Field offset: 0x0

		[Address(RVA = "0x11482E0", Offset = "0x11476E0", Length = "0xAFC")]
		[Token(Token = "0x6000720")]
		private override void MoveNext() { }

		[Address(RVA = "0x1146BD0", Offset = "0x1145FD0", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x6000721")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000122")]
	private struct <ForgetCoreWithCatch>d__18 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000447")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000448")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000449")]
		public UniTask task; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400044A")]
		public bool handleExceptionOnMainThread; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400044B")]
		public Action<Exception> exceptionHandler; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400044C")]
		private object <>7__wrap1; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400044D")]
		private int <>7__wrap2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400044E")]
		private Awaiter <>u__1; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400044F")]
		private Exception <ex>5__4; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000450")]
		private Awaiter <>u__2; //Field offset: 0x58

		[Address(RVA = "0x273AAF0", Offset = "0x2739EF0", Length = "0x5D1")]
		[Token(Token = "0x6000722")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000723")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000123")]
	private struct <ForgetCoreWithCatch>d__21 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000451")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000452")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000453")]
		public UniTask<T> task; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000454")]
		public bool handleExceptionOnMainThread; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000455")]
		public Action<Exception> exceptionHandler; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000456")]
		private object <>7__wrap1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000457")]
		private int <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000458")]
		private Awaiter<T> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000459")]
		private Exception <ex>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400045A")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x16FE790", Offset = "0x16FDB90", Length = "0xC5F")]
		[Token(Token = "0x6000724")]
		private override void MoveNext() { }

		[Address(RVA = "0x113D7A0", Offset = "0x113CBA0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000725")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000124")]
	private struct <Timeout>d__12 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400045B")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400045C")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400045D")]
		public TimeSpan timeout; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400045E")]
		public DelayType delayType; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400045F")]
		public PlayerLoopTiming timeoutCheckTiming; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000460")]
		public UniTask task; //Field offset: 0x28
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000461")]
		public CancellationTokenSource taskCancellationTokenSource; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000462")]
		private CancellationTokenSource <delayCancellationTokenSource>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000463")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"winArgumentIndex", "result1", "result2"})]
		private Awaiter<ValueTuple<Int32, Boolean, Boolean>> <>u__1; //Field offset: 0x48

		[Address(RVA = "0x273D6C0", Offset = "0x273CAC0", Length = "0x556")]
		[Token(Token = "0x6000726")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000727")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000125")]
	private struct <Timeout>d__13 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000464")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000465")]
		public AsyncUniTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000466")]
		public TimeSpan timeout; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000467")]
		public DelayType delayType; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000468")]
		public PlayerLoopTiming timeoutCheckTiming; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000469")]
		public UniTask<T> task; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400046A")]
		public CancellationTokenSource taskCancellationTokenSource; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400046B")]
		private CancellationTokenSource <delayCancellationTokenSource>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400046C")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"winArgumentIndex", "result1", "result2", "IsCanceled", "Result"})]
		private Awaiter<ValueTuple<Int32, ValueTuple`2<Boolean, T>, Boolean>> <>u__1; //Field offset: 0x0

		[Address(RVA = "0x1B5D290", Offset = "0x1B5C690", Length = "0x1086")]
		[Token(Token = "0x6000728")]
		private override void MoveNext() { }

		[Address(RVA = "0x1B5E320", Offset = "0x1B5D720", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x6000729")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000126")]
	private struct <TimeoutWithoutException>d__14 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400046D")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400046E")]
		public AsyncUniTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400046F")]
		public TimeSpan timeout; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000470")]
		public DelayType delayType; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000471")]
		public PlayerLoopTiming timeoutCheckTiming; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000472")]
		public UniTask task; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000473")]
		public CancellationTokenSource taskCancellationTokenSource; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000474")]
		private CancellationTokenSource <delayCancellationTokenSource>5__2; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000475")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"winArgumentIndex", "result1", "result2"})]
		private Awaiter<ValueTuple<Int32, Boolean, Boolean>> <>u__1; //Field offset: 0x50

		[Address(RVA = "0x273DC20", Offset = "0x273D020", Length = "0x5A5")]
		[Token(Token = "0x600072A")]
		private override void MoveNext() { }

		[Address(RVA = "0x273E1D0", Offset = "0x273D5D0", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x600072B")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000127")]
	private struct <TimeoutWithoutException>d__15 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000476")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000477")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"IsTimeout", "Result"})]
		public AsyncUniTaskMethodBuilder<ValueTuple`2<Boolean, T>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000478")]
		public TimeSpan timeout; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000479")]
		public DelayType delayType; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400047A")]
		public PlayerLoopTiming timeoutCheckTiming; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400047B")]
		public UniTask<T> task; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400047C")]
		public CancellationTokenSource taskCancellationTokenSource; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400047D")]
		private CancellationTokenSource <delayCancellationTokenSource>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400047E")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"winArgumentIndex", "result1", "result2", "IsCanceled", "Result"})]
		private Awaiter<ValueTuple<Int32, ValueTuple`2<Boolean, T>, Boolean>> <>u__1; //Field offset: 0x0

		[Address(RVA = "0x1B5E3F0", Offset = "0x1B5D7F0", Length = "0x135A")]
		[Token(Token = "0x600072C")]
		private override void MoveNext() { }

		[Address(RVA = "0x1B5F750", Offset = "0x1B5EB50", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x600072D")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000128")]
	private struct <Unwrap>d__30 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400047F")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000480")]
		public AsyncUniTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000481")]
		public UniTask<UniTask`1<T>> task; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000482")]
		private Awaiter<UniTask<T>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000483")]
		private Awaiter<T> <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1B72610", Offset = "0x1B71A10", Length = "0xB19")]
		[Token(Token = "0x600072E")]
		private override void MoveNext() { }

		[Address(RVA = "0xA5BDA0", Offset = "0xA5B1A0", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x600072F")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000129")]
	private struct <Unwrap>d__31 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000484")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000485")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000486")]
		public UniTask<UniTask> task; //Field offset: 0x18
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000487")]
		private Awaiter<UniTask> <>u__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000488")]
		private Awaiter <>u__2; //Field offset: 0x58

		[Address(RVA = "0x273FAC0", Offset = "0x273EEC0", Length = "0x59A")]
		[Token(Token = "0x6000730")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000731")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200012A")]
	private struct <Unwrap>d__32 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000489")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400048A")]
		public AsyncUniTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400048B")]
		public Task<UniTask`1<T>> task; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400048C")]
		private TaskAwaiter<UniTask`1<T>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400048D")]
		private Awaiter<T> <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1B73130", Offset = "0x1B72530", Length = "0xA79")]
		[Token(Token = "0x6000732")]
		private override void MoveNext() { }

		[Address(RVA = "0x1B5F750", Offset = "0x1B5EB50", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x6000733")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200012B")]
	private struct <Unwrap>d__33 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400048E")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400048F")]
		public AsyncUniTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000490")]
		public Task<UniTask`1<T>> task; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000491")]
		public bool continueOnCapturedContext; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000492")]
		private ConfiguredTaskAwaiter<UniTask<T>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000493")]
		private Awaiter<T> <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1B73BB0", Offset = "0x1B72FB0", Length = "0xB4D")]
		[Token(Token = "0x6000734")]
		private override void MoveNext() { }

		[Address(RVA = "0x1B74700", Offset = "0x1B73B00", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x6000735")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200012C")]
	private struct <Unwrap>d__34 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000494")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000495")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000496")]
		public Task<UniTask> task; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000497")]
		private TaskAwaiter<UniTask> <>u__1; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000498")]
		private Awaiter <>u__2; //Field offset: 0x28

		[Address(RVA = "0x2740060", Offset = "0x273F460", Length = "0x3F4")]
		[Token(Token = "0x6000736")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000737")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200012D")]
	private struct <Unwrap>d__35 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000499")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400049A")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400049B")]
		public Task<UniTask> task; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400049C")]
		public bool continueOnCapturedContext; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400049D")]
		private ConfiguredTaskAwaiter<UniTask> <>u__1; //Field offset: 0x28
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400049E")]
		private Awaiter <>u__2; //Field offset: 0x38

		[Address(RVA = "0x2740460", Offset = "0x273F860", Length = "0x408")]
		[Token(Token = "0x6000738")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000739")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200012E")]
	private struct <Unwrap>d__36 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400049F")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A0")]
		public AsyncUniTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A1")]
		public UniTask<Task`1<T>> task; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A2")]
		private Awaiter<Task<T>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A3")]
		private TaskAwaiter<T> <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1B747D0", Offset = "0x1B73BD0", Length = "0x9A9")]
		[Token(Token = "0x600073A")]
		private override void MoveNext() { }

		[Address(RVA = "0x1B5F750", Offset = "0x1B5EB50", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x600073B")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200012F")]
	private struct <Unwrap>d__37 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A4")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A5")]
		public AsyncUniTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A6")]
		public UniTask<Task`1<T>> task; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A7")]
		public bool continueOnCapturedContext; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A8")]
		private Awaiter<Task<T>> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A9")]
		private ConfiguredTaskAwaiter<T> <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1B75180", Offset = "0x1B74580", Length = "0xA54")]
		[Token(Token = "0x600073C")]
		private override void MoveNext() { }

		[Address(RVA = "0x1B74700", Offset = "0x1B73B00", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x600073D")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000130")]
	private struct <Unwrap>d__38 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004AA")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40004AB")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004AC")]
		public UniTask<Task> task; //Field offset: 0x18
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40004AD")]
		private Awaiter<Task> <>u__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40004AE")]
		private TaskAwaiter <>u__2; //Field offset: 0x48

		[Address(RVA = "0x2740870", Offset = "0x273FC70", Length = "0x3CA")]
		[Token(Token = "0x600073E")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x600073F")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000131")]
	private struct <Unwrap>d__39 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004AF")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40004B0")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004B1")]
		public UniTask<Task> task; //Field offset: 0x18
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40004B2")]
		public bool continueOnCapturedContext; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40004B3")]
		private Awaiter<Task> <>u__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40004B4")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50

		[Address(RVA = "0x2740C40", Offset = "0x2740040", Length = "0x3DE")]
		[Token(Token = "0x6000740")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000741")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x200010E")]
	private sealed class AttachExternalCancellationSource : IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x200010F")]
		private struct <RunTask>d__5 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40003EA")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x40003EB")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40003EC")]
			public UniTask task; //Field offset: 0x10
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x40003ED")]
			public AttachExternalCancellationSource <>4__this; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x40003EE")]
			private Awaiter <>u__1; //Field offset: 0x28

			[Address(RVA = "0x273CF40", Offset = "0x273C340", Length = "0x3CD")]
			[Token(Token = "0x60006E9")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x60006EA")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x40003E6")]
		private static readonly Action<Object> cancellationCallbackDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003E7")]
		private CancellationToken cancellationToken; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40003E8")]
		private CancellationTokenRegistration tokenRegistration; //Field offset: 0x18
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40003E9")]
		private UniTaskCompletionSourceCore<AsyncUnit> core; //Field offset: 0x30

		[Address(RVA = "0x272E7C0", Offset = "0x272DBC0", Length = "0x89")]
		[Token(Token = "0x60006E8")]
		private static AttachExternalCancellationSource() { }

		[Address(RVA = "0x272E850", Offset = "0x272DC50", Length = "0x199")]
		[Token(Token = "0x60006E1")]
		public AttachExternalCancellationSource(UniTask task, CancellationToken cancellationToken) { }

		[Address(RVA = "0x272E540", Offset = "0x272D940", Length = "0x75")]
		[Token(Token = "0x60006E3")]
		private static void CancellationCallback(object state) { }

		[Address(RVA = "0x272E5C0", Offset = "0x272D9C0", Length = "0x49")]
		[Token(Token = "0x60006E4")]
		public override void GetResult(short token) { }

		[Address(RVA = "0x272E610", Offset = "0x272DA10", Length = "0x49")]
		[Token(Token = "0x60006E5")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x272E660", Offset = "0x272DA60", Length = "0x70")]
		[Token(Token = "0x60006E6")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x272E6D0", Offset = "0x272DAD0", Length = "0xAC")]
		[AsyncStateMachine(typeof(<RunTask>d__5))]
		[Token(Token = "0x60006E2")]
		private UniTaskVoid RunTask(UniTask task) { }

		[Address(RVA = "0x272E780", Offset = "0x272DB80", Length = "0x3A")]
		[Token(Token = "0x60006E7")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x2000110")]
	private sealed class AttachExternalCancellationSource : IUniTaskSource<T>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x2000111")]
		private struct <RunTask>d__5 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40003F3")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40003F4")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40003F5")]
			public UniTask<T> task; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40003F6")]
			public AttachExternalCancellationSource<T> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40003F7")]
			private Awaiter<T> <>u__1; //Field offset: 0x0

			[Address(RVA = "0x197F480", Offset = "0x197E880", Length = "0x903")]
			[Token(Token = "0x60006F4")]
			private override void MoveNext() { }

			[Address(RVA = "0x113D7A0", Offset = "0x113CBA0", Length = "0x5A")]
			[DebuggerHidden]
			[Token(Token = "0x60006F5")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x40003EF")]
		private static readonly Action<Object> cancellationCallbackDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003F0")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003F1")]
		private CancellationTokenRegistration tokenRegistration; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003F2")]
		private UniTaskCompletionSourceCore<T> core; //Field offset: 0x0

		[Address(RVA = "0x1634D10", Offset = "0x1634110", Length = "0xEA")]
		[Token(Token = "0x60006F3")]
		private static AttachExternalCancellationSource`1() { }

		[Address(RVA = "0x1634E00", Offset = "0x1634200", Length = "0x22A")]
		[Token(Token = "0x60006EB")]
		public AttachExternalCancellationSource`1(UniTask<T> task, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1634660", Offset = "0x1633A60", Length = "0x143")]
		[Token(Token = "0x60006ED")]
		private static void CancellationCallback(object state) { }

		[Address(RVA = "0x16347B0", Offset = "0x1633BB0", Length = "0xD1")]
		[Token(Token = "0x60006EE")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x1634890", Offset = "0x1633C90", Length = "0xEB")]
		[Token(Token = "0x60006EF")]
		public override T GetResult(short token) { }

		[Address(RVA = "0x1634980", Offset = "0x1633D80", Length = "0x64")]
		[Token(Token = "0x60006F0")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x16349F0", Offset = "0x1633DF0", Length = "0x8F")]
		[Token(Token = "0x60006F1")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x1634A80", Offset = "0x1633E80", Length = "0x222")]
		[AsyncStateMachine(typeof(<RunTask>d__5))]
		[Token(Token = "0x60006EC")]
		private UniTaskVoid RunTask(UniTask<T> task) { }

		[Address(RVA = "0x1634CB0", Offset = "0x16340B0", Length = "0x54")]
		[Token(Token = "0x60006F2")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x2000112")]
	private sealed class ToCoroutineEnumerator : IEnumerator
	{
		[CompilerGenerated]
		[Token(Token = "0x2000113")]
		private struct <RunTask>d__6 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40003FD")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x40003FE")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40003FF")]
			public UniTask task; //Field offset: 0x10
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000400")]
			public ToCoroutineEnumerator <>4__this; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4000401")]
			private Awaiter <>u__1; //Field offset: 0x28

			[Address(RVA = "0x273D310", Offset = "0x273C710", Length = "0x3A8")]
			[Token(Token = "0x60006FB")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x60006FC")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003F8")]
		private bool completed; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40003F9")]
		private UniTask task; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40003FA")]
		private Action<Exception> exceptionHandler; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40003FB")]
		private bool isStarted; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40003FC")]
		private ExceptionDispatchInfo exception; //Field offset: 0x38

		[Token(Token = "0x1700004F")]
		public override object Current
		{
			[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
			[Token(Token = "0x60006F8")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x2739B70", Offset = "0x2738F70", Length = "0x54")]
		[Token(Token = "0x60006F6")]
		public ToCoroutineEnumerator(UniTask task, Action<Exception> exceptionHandler) { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60006F8")]
		public override object get_Current() { }

		[Address(RVA = "0x27399C0", Offset = "0x2738DC0", Length = "0xF7")]
		[Token(Token = "0x60006F9")]
		public override bool MoveNext() { }

		[Address(RVA = "0x2739AC0", Offset = "0x2738EC0", Length = "0xAC")]
		[AsyncStateMachine(typeof(<RunTask>d__6))]
		[Token(Token = "0x60006F7")]
		private UniTaskVoid RunTask(UniTask task) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60006FA")]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[Token(Token = "0x2000114")]
	private sealed class ToCoroutineEnumerator : IEnumerator
	{
		[CompilerGenerated]
		[Token(Token = "0x2000115")]
		private struct <RunTask>d__8 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000409")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400040A")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400040B")]
			public UniTask<T> task; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400040C")]
			public ToCoroutineEnumerator<T> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400040D")]
			private Awaiter<T> <>u__1; //Field offset: 0x0

			[Address(RVA = "0x1980810", Offset = "0x197FC10", Length = "0x3BA")]
			[Token(Token = "0x6000702")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x6000703")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000402")]
		private bool completed; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000403")]
		private Action<T> resultHandler; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000404")]
		private Action<Exception> exceptionHandler; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000405")]
		private bool isStarted; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000406")]
		private UniTask<T> task; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000407")]
		private object current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000408")]
		private ExceptionDispatchInfo exception; //Field offset: 0x0

		[Token(Token = "0x17000050")]
		public override object Current
		{
			[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
			[Token(Token = "0x60006FF")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x108F6F0", Offset = "0x108EAF0", Length = "0x71")]
		[Token(Token = "0x60006FD")]
		public ToCoroutineEnumerator`1(UniTask<T> task, Action<T> resultHandler, Action<Exception> exceptionHandler) { }

		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60006FF")]
		public override object get_Current() { }

		[Address(RVA = "0x108F190", Offset = "0x108E590", Length = "0xF9")]
		[Token(Token = "0x6000700")]
		public override bool MoveNext() { }

		[Address(RVA = "0x108F290", Offset = "0x108E690", Length = "0xA5")]
		[AsyncStateMachine(typeof(<RunTask>d__8))]
		[Token(Token = "0x60006FE")]
		private UniTaskVoid RunTask(UniTask<T> task) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000701")]
		private override void System.Collections.IEnumerator.Reset() { }

	}


	[Address(RVA = "0x9CA8E0", Offset = "0x9C9CE0", Length = "0x482")]
	[Extension]
	[Token(Token = "0x600069D")]
	public static Task<T> AsTask(UniTask<T> task) { }

	[Address(RVA = "0x2741C20", Offset = "0x2741020", Length = "0x3C5")]
	[Extension]
	[Token(Token = "0x600069E")]
	public static Task AsTask(UniTask task) { }

	[Address(RVA = "0x9CAD70", Offset = "0x9CA170", Length = "0x28F")]
	[Extension]
	[Token(Token = "0x600069B")]
	public static UniTask<T> AsUniTask(Task<T> task, bool useCurrentSynchronizationContext = true) { }

	[Address(RVA = "0x2741FF0", Offset = "0x27413F0", Length = "0x1C5")]
	[Extension]
	[Token(Token = "0x600069C")]
	public static UniTask AsUniTask(Task task, bool useCurrentSynchronizationContext = true) { }

	[Address(RVA = "0x27421C0", Offset = "0x27415C0", Length = "0x30D")]
	[Extension]
	[Token(Token = "0x60006A1")]
	public static UniTask AttachExternalCancellation(UniTask task, CancellationToken cancellationToken) { }

	[Address(RVA = "0x9CB000", Offset = "0x9CA400", Length = "0x31C")]
	[Extension]
	[Token(Token = "0x60006A2")]
	public static UniTask<T> AttachExternalCancellation(UniTask<T> task, CancellationToken cancellationToken) { }

	[Address(RVA = "0x9CB590", Offset = "0x9CA990", Length = "0x256")]
	[AsyncStateMachine(typeof(<ContinueWith>d__29`1))]
	[Extension]
	[Token(Token = "0x60006B6")]
	public static UniTask<T> ContinueWith(UniTask task, Func<UniTask`1<T>> continuationFunction) { }

	[Address(RVA = "0x9CB590", Offset = "0x9CA990", Length = "0x256")]
	[AsyncStateMachine(typeof(<ContinueWith>d__28`1))]
	[Extension]
	[Token(Token = "0x60006B5")]
	public static UniTask<T> ContinueWith(UniTask task, Func<T> continuationFunction) { }

	[Address(RVA = "0x27425C0", Offset = "0x27419C0", Length = "0xE6")]
	[AsyncStateMachine(typeof(<ContinueWith>d__27))]
	[Extension]
	[Token(Token = "0x60006B4")]
	public static UniTask ContinueWith(UniTask task, Func<UniTask> continuationFunction) { }

	[Address(RVA = "0x27424D0", Offset = "0x27418D0", Length = "0xE6")]
	[AsyncStateMachine(typeof(<ContinueWith>d__26))]
	[Extension]
	[Token(Token = "0x60006B3")]
	public static UniTask ContinueWith(UniTask task, Action continuationFunction) { }

	[Address(RVA = "0x9CB320", Offset = "0x9CA720", Length = "0x26F")]
	[AsyncStateMachine(typeof(<ContinueWith>d__25`2))]
	[Extension]
	[Token(Token = "0x60006B2")]
	public static UniTask<TR> ContinueWith(UniTask<T> task, Func<T, UniTask`1<TR>> continuationFunction) { }

	[Address(RVA = "0x9CB320", Offset = "0x9CA720", Length = "0x26F")]
	[AsyncStateMachine(typeof(<ContinueWith>d__24`2))]
	[Extension]
	[Token(Token = "0x60006B1")]
	public static UniTask<TR> ContinueWith(UniTask<T> task, Func<T, TR> continuationFunction) { }

	[Address(RVA = "0x9CB7F0", Offset = "0x9CABF0", Length = "0x202")]
	[AsyncStateMachine(typeof(<ContinueWith>d__22`1))]
	[Extension]
	[Token(Token = "0x60006AF")]
	public static UniTask ContinueWith(UniTask<T> task, Action<T> continuationFunction) { }

	[Address(RVA = "0x9CB7F0", Offset = "0x9CABF0", Length = "0x202")]
	[AsyncStateMachine(typeof(<ContinueWith>d__23`1))]
	[Extension]
	[Token(Token = "0x60006B0")]
	public static UniTask ContinueWith(UniTask<T> task, Func<T, UniTask> continuationFunction) { }

	[Address(RVA = "0x2742890", Offset = "0x2741C90", Length = "0x27D")]
	[Extension]
	[Token(Token = "0x60006A9")]
	public static void Forget(UniTask task) { }

	[Address(RVA = "0x2742780", Offset = "0x2741B80", Length = "0x10E")]
	[Extension]
	[Token(Token = "0x60006AA")]
	public static void Forget(UniTask task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread = true) { }

	[Address(RVA = "0x9CBC30", Offset = "0x9CB030", Length = "0x2DC")]
	[Extension]
	[Token(Token = "0x60006AC")]
	public static void Forget(UniTask<T> task) { }

	[Address(RVA = "0x9CBF10", Offset = "0x9CB310", Length = "0x106")]
	[Extension]
	[Token(Token = "0x60006AD")]
	public static void Forget(UniTask<T> task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread = true) { }

	[Address(RVA = "0x27426B0", Offset = "0x2741AB0", Length = "0xCF")]
	[AsyncStateMachine(typeof(<ForgetCoreWithCatch>d__18))]
	[Token(Token = "0x60006AB")]
	private static UniTaskVoid ForgetCoreWithCatch(UniTask task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread) { }

	[Address(RVA = "0x9CBA00", Offset = "0x9CAE00", Length = "0x22F")]
	[AsyncStateMachine(typeof(<ForgetCoreWithCatch>d__21`1))]
	[Token(Token = "0x60006AE")]
	private static UniTaskVoid ForgetCoreWithCatch(UniTask<T> task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread) { }

	[Address(RVA = "0x9CCF50", Offset = "0x9CC350", Length = "0xD99")]
	[Extension]
	[Token(Token = "0x60006D1")]
	public static Awaiter<ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple`7<T8, T9, T10, T11, T12, T13, T14>>> GetAwaiter(ValueTuple<UniTask`1<T1>, UniTask`1<T2>, UniTask`1<T3>, UniTask`1<T4>, UniTask`1<T5>, UniTask`1<T6>, UniTask`1<T7>, ValueTuple`7<UniTask`1<T8>, UniTask`1<T9>, UniTask`1<T10>, UniTask`1<T11>, UniTask`1<T12>, UniTask`1<T13>, UniTask`1<T14>>> tasks) { }

	[Address(RVA = "0x9CDCF0", Offset = "0x9CD0F0", Length = "0xC7C")]
	[Extension]
	[Token(Token = "0x60006D0")]
	public static Awaiter<ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple`6<T8, T9, T10, T11, T12, T13>>> GetAwaiter(ValueTuple<UniTask`1<T1>, UniTask`1<T2>, UniTask`1<T3>, UniTask`1<T4>, UniTask`1<T5>, UniTask`1<T6>, UniTask`1<T7>, ValueTuple`6<UniTask`1<T8>, UniTask`1<T9>, UniTask`1<T10>, UniTask`1<T11>, UniTask`1<T12>, UniTask`1<T13>>> tasks) { }

	[Address(RVA = "0x9CE970", Offset = "0x9CDD70", Length = "0xB62")]
	[Extension]
	[Token(Token = "0x60006CF")]
	public static Awaiter<ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple`5<T8, T9, T10, T11, T12>>> GetAwaiter(ValueTuple<UniTask`1<T1>, UniTask`1<T2>, UniTask`1<T3>, UniTask`1<T4>, UniTask`1<T5>, UniTask`1<T6>, UniTask`1<T7>, ValueTuple`5<UniTask`1<T8>, UniTask`1<T9>, UniTask`1<T10>, UniTask`1<T11>, UniTask`1<T12>>> tasks) { }

	[Address(RVA = "0x9CF4E0", Offset = "0x9CE8E0", Length = "0xA4B")]
	[Extension]
	[Token(Token = "0x60006CE")]
	public static Awaiter<ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple`4<T8, T9, T10, T11>>> GetAwaiter(ValueTuple<UniTask`1<T1>, UniTask`1<T2>, UniTask`1<T3>, UniTask`1<T4>, UniTask`1<T5>, UniTask`1<T6>, UniTask`1<T7>, ValueTuple`4<UniTask`1<T8>, UniTask`1<T9>, UniTask`1<T10>, UniTask`1<T11>>> tasks) { }

	[Address(RVA = "0x9D1090", Offset = "0x9D0490", Length = "0x712")]
	[Extension]
	[Token(Token = "0x60006CB")]
	public static Awaiter<ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple`1<T8>>> GetAwaiter(ValueTuple<UniTask`1<T1>, UniTask`1<T2>, UniTask`1<T3>, UniTask`1<T4>, UniTask`1<T5>, UniTask`1<T6>, UniTask`1<T7>, ValueTuple`1<UniTask`1<T8>>> tasks) { }

	[Address(RVA = "0x9D0870", Offset = "0x9CFC70", Length = "0x820")]
	[Extension]
	[Token(Token = "0x60006CC")]
	public static Awaiter<ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple`2<T8, T9>>> GetAwaiter(ValueTuple<UniTask`1<T1>, UniTask`1<T2>, UniTask`1<T3>, UniTask`1<T4>, UniTask`1<T5>, UniTask`1<T6>, UniTask`1<T7>, ValueTuple`2<UniTask`1<T8>, UniTask`1<T9>>> tasks) { }

	[Address(RVA = "0x9CC020", Offset = "0x9CB420", Length = "0xF2A")]
	[Extension]
	[Token(Token = "0x60006D2")]
	public static Awaiter<ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple`8<T8, T9, T10, T11, T12, T13, T14, ValueTuple`1<T15>>>> GetAwaiter(ValueTuple<UniTask`1<T1>, UniTask`1<T2>, UniTask`1<T3>, UniTask`1<T4>, UniTask`1<T5>, UniTask`1<T6>, UniTask`1<T7>, ValueTuple`8<UniTask`1<T8>, UniTask`1<T9>, UniTask`1<T10>, UniTask`1<T11>, UniTask`1<T12>, UniTask`1<T13>, UniTask`1<T14>, ValueTuple`1<UniTask`1<T15>>>> tasks) { }

	[Address(RVA = "0x9D17B0", Offset = "0x9D0BB0", Length = "0x5E8")]
	[Extension]
	[Token(Token = "0x60006CA")]
	public static Awaiter<ValueTuple<T1, T2, T3, T4, T5, T6, T7>> GetAwaiter(ValueTuple<UniTask`1<T1>, UniTask`1<T2>, UniTask`1<T3>, UniTask`1<T4>, UniTask`1<T5>, UniTask`1<T6>, UniTask`1<T7>> tasks) { }

	[Address(RVA = "0x9D1DA0", Offset = "0x9D11A0", Length = "0x52C")]
	[Extension]
	[Token(Token = "0x60006C9")]
	public static Awaiter<ValueTuple<T1, T2, T3, T4, T5, T6>> GetAwaiter(ValueTuple<UniTask`1<T1>, UniTask`1<T2>, UniTask`1<T3>, UniTask`1<T4>, UniTask`1<T5>, UniTask`1<T6>> tasks) { }

	[Address(RVA = "0x9CFF30", Offset = "0x9CF330", Length = "0x937")]
	[Extension]
	[Token(Token = "0x60006CD")]
	public static Awaiter<ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple`3<T8, T9, T10>>> GetAwaiter(ValueTuple<UniTask`1<T1>, UniTask`1<T2>, UniTask`1<T3>, UniTask`1<T4>, UniTask`1<T5>, UniTask`1<T6>, UniTask`1<T7>, ValueTuple`3<UniTask`1<T8>, UniTask`1<T9>, UniTask`1<T10>>> tasks) { }

	[Address(RVA = "0x2745390", Offset = "0x2744790", Length = "0x18D")]
	[Extension]
	[Token(Token = "0x60006D3")]
	public static Awaiter GetAwaiter(ValueTuple<UniTask, UniTask> tasks) { }

	[Address(RVA = "0x27466A0", Offset = "0x2745AA0", Length = "0x1DF")]
	[Extension]
	[Token(Token = "0x60006D6")]
	public static Awaiter GetAwaiter(ValueTuple<UniTask, UniTask, UniTask, UniTask, UniTask> tasks) { }

	[Address(RVA = "0x2744840", Offset = "0x2743C40", Length = "0x1B8")]
	[Extension]
	[Token(Token = "0x60006D5")]
	public static Awaiter GetAwaiter(ValueTuple<UniTask, UniTask, UniTask, UniTask> tasks) { }

	[Address(RVA = "0x2744640", Offset = "0x2743A40", Length = "0x1FE")]
	[Extension]
	[Token(Token = "0x60006D7")]
	public static Awaiter GetAwaiter(ValueTuple<UniTask, UniTask, UniTask, UniTask, UniTask, UniTask> tasks) { }

	[Address(RVA = "0x2743CC0", Offset = "0x27430C0", Length = "0x97C")]
	[Extension]
	[Token(Token = "0x60006DE")]
	public static Awaiter GetAwaiter(ValueTuple<UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, ValueTuple`6<UniTask, UniTask, UniTask, UniTask, UniTask, UniTask>> tasks) { }

	[Address(RVA = "0x2746880", Offset = "0x2745C80", Length = "0x889")]
	[Extension]
	[Token(Token = "0x60006DD")]
	public static Awaiter GetAwaiter(ValueTuple<UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, ValueTuple`5<UniTask, UniTask, UniTask, UniTask, UniTask>> tasks) { }

	[Address(RVA = "0x2744C30", Offset = "0x2744030", Length = "0x752")]
	[Extension]
	[Token(Token = "0x60006DC")]
	public static Awaiter GetAwaiter(ValueTuple<UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, ValueTuple`4<UniTask, UniTask, UniTask, UniTask>> tasks) { }

	[Address(RVA = "0x2745520", Offset = "0x2744920", Length = "0x637")]
	[Extension]
	[Token(Token = "0x60006DB")]
	public static Awaiter GetAwaiter(ValueTuple<UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, ValueTuple`3<UniTask, UniTask, UniTask>> tasks) { }

	[Address(RVA = "0x2743A50", Offset = "0x2742E50", Length = "0x26A")]
	[Extension]
	[Token(Token = "0x60006DA")]
	public static Awaiter GetAwaiter(ValueTuple<UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, ValueTuple`2<UniTask, UniTask>> tasks) { }

	[Address(RVA = "0x2743800", Offset = "0x2742C00", Length = "0x244")]
	[Extension]
	[Token(Token = "0x60006D9")]
	public static Awaiter GetAwaiter(ValueTuple<UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, ValueTuple`1<UniTask>> tasks) { }

	[Address(RVA = "0x9D22D0", Offset = "0x9D16D0", Length = "0x479")]
	[Extension]
	[Token(Token = "0x60006C8")]
	public static Awaiter<ValueTuple<T1, T2, T3, T4, T5>> GetAwaiter(ValueTuple<UniTask`1<T1>, UniTask`1<T2>, UniTask`1<T3>, UniTask`1<T4>, UniTask`1<T5>> tasks) { }

	[Address(RVA = "0x2744A00", Offset = "0x2743E00", Length = "0x221")]
	[Extension]
	[Token(Token = "0x60006D8")]
	public static Awaiter GetAwaiter(ValueTuple<UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask> tasks) { }

	[Address(RVA = "0x2743660", Offset = "0x2742A60", Length = "0x199")]
	[Extension]
	[Token(Token = "0x60006D4")]
	public static Awaiter GetAwaiter(ValueTuple<UniTask, UniTask, UniTask> tasks) { }

	[Address(RVA = "0x9D2750", Offset = "0x9D1B50", Length = "0x3D9")]
	[Extension]
	[Token(Token = "0x60006C7")]
	public static Awaiter<ValueTuple<T1, T2, T3, T4>> GetAwaiter(ValueTuple<UniTask`1<T1>, UniTask`1<T2>, UniTask`1<T3>, UniTask`1<T4>> tasks) { }

	[Address(RVA = "0x2745B60", Offset = "0x2744F60", Length = "0xB3B")]
	[Extension]
	[Token(Token = "0x60006E0")]
	public static Awaiter GetAwaiter(ValueTuple<UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, ValueTuple`8<UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, ValueTuple`1<UniTask>>> tasks) { }

	[Address(RVA = "0x9D2E80", Offset = "0x9D2280", Length = "0x29E")]
	[Extension]
	[Token(Token = "0x60006C5")]
	public static Awaiter<ValueTuple<T1, T2>> GetAwaiter(ValueTuple<UniTask`1<T1>, UniTask`1<T2>> tasks) { }

	[Address(RVA = "0x9D3120", Offset = "0x9D2520", Length = "0xD1")]
	[Extension]
	[Token(Token = "0x60006C4")]
	public static Awaiter<T[]> GetAwaiter(IEnumerable<UniTask`1<T>> tasks) { }

	[Address(RVA = "0x9D3120", Offset = "0x9D2520", Length = "0xD1")]
	[Extension]
	[Token(Token = "0x60006C3")]
	public static Awaiter<T[]> GetAwaiter(UniTask<T>[] tasks) { }

	[Address(RVA = "0x2747110", Offset = "0x2746510", Length = "0x7B")]
	[Extension]
	[Token(Token = "0x60006C2")]
	public static Awaiter GetAwaiter(IEnumerable<UniTask> tasks) { }

	[Address(RVA = "0x2742B10", Offset = "0x2741F10", Length = "0x11D")]
	[Extension]
	[Token(Token = "0x60006C1")]
	public static Awaiter GetAwaiter(UniTask[] tasks) { }

	[Address(RVA = "0x2742C30", Offset = "0x2742030", Length = "0xA20")]
	[Extension]
	[Token(Token = "0x60006DF")]
	public static Awaiter GetAwaiter(ValueTuple<UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, ValueTuple`7<UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask>> tasks) { }

	[Address(RVA = "0x9D2B30", Offset = "0x9D1F30", Length = "0x342")]
	[Extension]
	[Token(Token = "0x60006C6")]
	public static Awaiter<ValueTuple<T1, T2, T3>> GetAwaiter(ValueTuple<UniTask`1<T1>, UniTask`1<T2>, UniTask`1<T3>> tasks) { }

	[Address(RVA = "0x27472D0", Offset = "0x27466D0", Length = "0x118")]
	[AsyncStateMachine(typeof(<Timeout>d__12))]
	[Extension]
	[Token(Token = "0x60006A5")]
	public static UniTask Timeout(UniTask task, TimeSpan timeout, DelayType delayType = 0, PlayerLoopTiming timeoutCheckTiming = 8, CancellationTokenSource taskCancellationTokenSource = null) { }

	[Address(RVA = "0x9D3560", Offset = "0x9D2960", Length = "0x33E")]
	[AsyncStateMachine(typeof(<Timeout>d__13`1))]
	[Extension]
	[Token(Token = "0x60006A6")]
	public static UniTask<T> Timeout(UniTask<T> task, TimeSpan timeout, DelayType delayType = 0, PlayerLoopTiming timeoutCheckTiming = 8, CancellationTokenSource taskCancellationTokenSource = null) { }

	[Address(RVA = "0x2747190", Offset = "0x2746590", Length = "0x139")]
	[AsyncStateMachine(typeof(<TimeoutWithoutException>d__14))]
	[Extension]
	[Token(Token = "0x60006A7")]
	public static UniTask<Boolean> TimeoutWithoutException(UniTask task, TimeSpan timeout, DelayType delayType = 0, PlayerLoopTiming timeoutCheckTiming = 8, CancellationTokenSource taskCancellationTokenSource = null) { }

	[Address(RVA = "0x9D3200", Offset = "0x9D2600", Length = "0x35C")]
	[AsyncStateMachine(typeof(<TimeoutWithoutException>d__15`1))]
	[Extension]
	[Token(Token = "0x60006A8")]
	public static UniTask<ValueTuple`2<Boolean, T>> TimeoutWithoutException(UniTask<T> task, TimeSpan timeout, DelayType delayType = 0, PlayerLoopTiming timeoutCheckTiming = 8, CancellationTokenSource taskCancellationTokenSource = null) { }

	[Address(RVA = "0x27473F0", Offset = "0x27467F0", Length = "0x220")]
	[Extension]
	[Token(Token = "0x600069F")]
	public static AsyncLazy ToAsyncLazy(UniTask task) { }

	[Address(RVA = "0x9CA270", Offset = "0x9C9670", Length = "0xC3")]
	[Extension]
	[Token(Token = "0x60006A0")]
	public static AsyncLazy<T> ToAsyncLazy(UniTask<T> task) { }

	[Address(RVA = "0x9D38A0", Offset = "0x9D2CA0", Length = "0xA0")]
	[Extension]
	[Token(Token = "0x60006A3")]
	public static IEnumerator ToCoroutine(UniTask<T> task, Action<T> resultHandler = null, Action<Exception> exceptionHandler = null) { }

	[Address(RVA = "0x2747610", Offset = "0x2746A10", Length = "0x83")]
	[Extension]
	[Token(Token = "0x60006A4")]
	public static IEnumerator ToCoroutine(UniTask task, Action<Exception> exceptionHandler = null) { }

	[Address(RVA = "0x9D3EA0", Offset = "0x9D32A0", Length = "0x20F")]
	[AsyncStateMachine(typeof(<Unwrap>d__32`1))]
	[Extension]
	[Token(Token = "0x60006B9")]
	public static UniTask<T> Unwrap(Task<UniTask`1<T>> task) { }

	[Address(RVA = "0x2747790", Offset = "0x2746B90", Length = "0xE7")]
	[AsyncStateMachine(typeof(<Unwrap>d__31))]
	[Extension]
	[Token(Token = "0x60006B8")]
	public static UniTask Unwrap(UniTask<UniTask> task) { }

	[Address(RVA = "0x9D3C40", Offset = "0x9D3040", Length = "0x251")]
	[AsyncStateMachine(typeof(<Unwrap>d__33`1))]
	[Extension]
	[Token(Token = "0x60006BA")]
	public static UniTask<T> Unwrap(Task<UniTask`1<T>> task, bool continueOnCapturedContext) { }

	[Address(RVA = "0x2747980", Offset = "0x2746D80", Length = "0xC3")]
	[AsyncStateMachine(typeof(<Unwrap>d__34))]
	[Extension]
	[Token(Token = "0x60006BB")]
	public static UniTask Unwrap(Task<UniTask> task) { }

	[Address(RVA = "0x27476A0", Offset = "0x2746AA0", Length = "0xE3")]
	[AsyncStateMachine(typeof(<Unwrap>d__35))]
	[Extension]
	[Token(Token = "0x60006BC")]
	public static UniTask Unwrap(Task<UniTask> task, bool continueOnCapturedContext) { }

	[Address(RVA = "0x9D40B0", Offset = "0x9D34B0", Length = "0x25E")]
	[AsyncStateMachine(typeof(<Unwrap>d__37`1))]
	[Extension]
	[Token(Token = "0x60006BE")]
	public static UniTask<T> Unwrap(UniTask<Task`1<T>> task, bool continueOnCapturedContext) { }

	[Address(RVA = "0x2747A50", Offset = "0x2746E50", Length = "0xDF")]
	[AsyncStateMachine(typeof(<Unwrap>d__38))]
	[Extension]
	[Token(Token = "0x60006BF")]
	public static UniTask Unwrap(UniTask<Task> task) { }

	[Address(RVA = "0x2747880", Offset = "0x2746C80", Length = "0xF1")]
	[AsyncStateMachine(typeof(<Unwrap>d__39))]
	[Extension]
	[Token(Token = "0x60006C0")]
	public static UniTask Unwrap(UniTask<Task> task, bool continueOnCapturedContext) { }

	[Address(RVA = "0x9D4310", Offset = "0x9D3710", Length = "0x22E")]
	[AsyncStateMachine(typeof(<Unwrap>d__30`1))]
	[Extension]
	[Token(Token = "0x60006B7")]
	public static UniTask<T> Unwrap(UniTask<UniTask`1<T>> task) { }

	[Address(RVA = "0x9D3A20", Offset = "0x9D2E20", Length = "0x21C")]
	[AsyncStateMachine(typeof(<Unwrap>d__36`1))]
	[Extension]
	[Token(Token = "0x60006BD")]
	public static UniTask<T> Unwrap(UniTask<Task`1<T>> task) { }

}

