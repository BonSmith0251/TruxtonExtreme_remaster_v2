namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20001A1")]
internal static class Subscribe
{
	[CompilerGenerated]
	[Token(Token = "0x20001A2")]
	private sealed class <>c
	{
		[Token(Token = "0x4000FF5")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x2767FE0", Offset = "0x27673E0", Length = "0x67")]
		[Token(Token = "0x60007A3")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60007A4")]
		public <>c() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60007A5")]
		internal void <.cctor>b__8_0(Exception _) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60007A6")]
		internal void <.cctor>b__8_1() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001A3")]
	private struct <SubscribeAwaitCore>d__6 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FF6")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FF7")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FF8")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FF9")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FFA")]
		public Func<TSource, UniTask> onNext; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FFB")]
		public Action onCompleted; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FFC")]
		public Action<Exception> onError; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FFD")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FFE")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FFF")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001000")]
		private Awaiter <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001001")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0

		[Address(RVA = "0x19DF030", Offset = "0x19DE430", Length = "0xC05")]
		[Token(Token = "0x60007A7")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60007A8")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001A4")]
	private struct <SubscribeAwaitCore>d__7 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001002")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001003")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001004")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001005")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001006")]
		public Func<TSource, CancellationToken, UniTask> onNext; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001007")]
		public Action onCompleted; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001008")]
		public Action<Exception> onError; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001009")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400100A")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400100B")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400100C")]
		private Awaiter <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400100D")]
		private Awaiter<Boolean> <>u__2; //Field offset: 0x0

		[Address(RVA = "0x19DFC40", Offset = "0x19DF040", Length = "0xC12")]
		[Token(Token = "0x60007A9")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60007AA")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001A5")]
	private struct <SubscribeCore>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400100E")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400100F")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001010")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001011")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001012")]
		public Action<TSource> onNext; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001013")]
		public Action onCompleted; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001014")]
		public Action<Exception> onError; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001015")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001016")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001017")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001018")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001019")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x19E0860", Offset = "0x19DFC60", Length = "0x82D")]
		[Token(Token = "0x60007AB")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60007AC")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001A6")]
	private struct <SubscribeCore>d__3 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400101A")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400101B")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400101C")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400101D")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400101E")]
		public Func<TSource, UniTaskVoid> onNext; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400101F")]
		public Action onCompleted; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001020")]
		public Action<Exception> onError; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001021")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001022")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001023")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001024")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001025")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x19E1090", Offset = "0x19E0490", Length = "0x83D")]
		[Token(Token = "0x60007AD")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60007AE")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001A7")]
	private struct <SubscribeCore>d__4 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001026")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001027")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001028")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001029")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400102A")]
		public Func<TSource, CancellationToken, UniTaskVoid> onNext; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400102B")]
		public Action onCompleted; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400102C")]
		public Action<Exception> onError; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400102D")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400102E")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400102F")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001030")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001031")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x19E18D0", Offset = "0x19E0CD0", Length = "0x858")]
		[Token(Token = "0x60007AF")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60007B0")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001A8")]
	private struct <SubscribeCore>d__5 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001032")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001033")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001034")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001035")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001036")]
		public IObserver<TSource> observer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001037")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001038")]
		private object <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001039")]
		private int <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400103A")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400103B")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x19E2130", Offset = "0x19E1530", Length = "0x812")]
		[Token(Token = "0x60007B1")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60007B2")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x4000FF3")]
	public static readonly Action<Exception> NopError; //Field offset: 0x0
	[Token(Token = "0x4000FF4")]
	public static readonly Action NopCompleted; //Field offset: 0x8

	[Address(RVA = "0x2753610", Offset = "0x2752A10", Length = "0x141")]
	[Token(Token = "0x60007A2")]
	private static Subscribe() { }

	[Address(RVA = "0x91D620", Offset = "0x91CA20", Length = "0x115")]
	[AsyncStateMachine(typeof(<SubscribeAwaitCore>d__6`1))]
	[Token(Token = "0x60007A0")]
	public static UniTaskVoid SubscribeAwaitCore(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask> onNext, Action<Exception> onError, Action onCompleted, CancellationToken cancellationToken) { }

	[Address(RVA = "0x91D620", Offset = "0x91CA20", Length = "0x115")]
	[AsyncStateMachine(typeof(<SubscribeAwaitCore>d__7`1))]
	[Token(Token = "0x60007A1")]
	public static UniTaskVoid SubscribeAwaitCore(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask> onNext, Action<Exception> onError, Action onCompleted, CancellationToken cancellationToken) { }

	[Address(RVA = "0x91D620", Offset = "0x91CA20", Length = "0x115")]
	[AsyncStateMachine(typeof(<SubscribeCore>d__2`1))]
	[Token(Token = "0x600079C")]
	public static UniTaskVoid SubscribeCore(IUniTaskAsyncEnumerable<TSource> source, Action<TSource> onNext, Action<Exception> onError, Action onCompleted, CancellationToken cancellationToken) { }

	[Address(RVA = "0x91D620", Offset = "0x91CA20", Length = "0x115")]
	[AsyncStateMachine(typeof(<SubscribeCore>d__3`1))]
	[Token(Token = "0x600079D")]
	public static UniTaskVoid SubscribeCore(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTaskVoid> onNext, Action<Exception> onError, Action onCompleted, CancellationToken cancellationToken) { }

	[Address(RVA = "0x91D620", Offset = "0x91CA20", Length = "0x115")]
	[AsyncStateMachine(typeof(<SubscribeCore>d__4`1))]
	[Token(Token = "0x600079E")]
	public static UniTaskVoid SubscribeCore(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTaskVoid> onNext, Action<Exception> onError, Action onCompleted, CancellationToken cancellationToken) { }

	[Address(RVA = "0x91D740", Offset = "0x91CB40", Length = "0xCE")]
	[AsyncStateMachine(typeof(<SubscribeCore>d__5`1))]
	[Token(Token = "0x600079F")]
	public static UniTaskVoid SubscribeCore(IUniTaskAsyncEnumerable<TSource> source, IObserver<TSource> observer, CancellationToken cancellationToken) { }

}

