namespace Cysharp.Threading.Tasks;

[Extension]
[Token(Token = "0x2000132")]
public static class UniTaskObservableExtensions
{
	[CompilerGenerated]
	[Token(Token = "0x2000137")]
	private struct <Fire>d__3 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C4")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C5")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C6")]
		public UniTask<T> task; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C7")]
		public AsyncSubject<T> subject; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C8")]
		private Awaiter<T> <>u__1; //Field offset: 0x0

		[Address(RVA = "0x16F61B0", Offset = "0x16F55B0", Length = "0x830")]
		[Token(Token = "0x6000757")]
		private override void MoveNext() { }

		[Address(RVA = "0x113D7A0", Offset = "0x113CBA0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6000758")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000138")]
	private struct <Fire>d__4 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C9")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40004CA")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004CB")]
		public UniTask task; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004CC")]
		public AsyncSubject<AsyncUnit> subject; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40004CD")]
		private Awaiter <>u__1; //Field offset: 0x28

		[Address(RVA = "0x273A7B0", Offset = "0x2739BB0", Length = "0x334")]
		[Token(Token = "0x6000759")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x600075A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x2000134")]
	private class FirstValueToUniTaskObserver : IObserver<T>
	{
		[Token(Token = "0x40004BC")]
		private static readonly Action<Object> callback; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004BD")]
		private readonly UniTaskCompletionSource<T> promise; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004BE")]
		private readonly SingleAssignmentDisposable disposable; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004BF")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C0")]
		private readonly CancellationTokenRegistration registration; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C1")]
		private bool hasValue; //Field offset: 0x0

		[Address(RVA = "0x1BC2CD0", Offset = "0x1BC20D0", Length = "0xEA")]
		[Token(Token = "0x6000752")]
		private static FirstValueToUniTaskObserver`1() { }

		[Address(RVA = "0x1BC2DC0", Offset = "0x1BC21C0", Length = "0x172")]
		[Token(Token = "0x600074D")]
		public FirstValueToUniTaskObserver`1(UniTaskCompletionSource<T> promise, SingleAssignmentDisposable disposable, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1BC28D0", Offset = "0x1BC1CD0", Length = "0x102")]
		[Token(Token = "0x600074E")]
		private static void OnCanceled(object state) { }

		[Address(RVA = "0x1BC29E0", Offset = "0x1BC1DE0", Length = "0x100")]
		[Token(Token = "0x6000751")]
		public override void OnCompleted() { }

		[Address(RVA = "0x1BC2AF0", Offset = "0x1BC1EF0", Length = "0x94")]
		[Token(Token = "0x6000750")]
		public override void OnError(Exception error) { }

		[Address(RVA = "0x1BC2B90", Offset = "0x1BC1F90", Length = "0x13D")]
		[Token(Token = "0x600074F")]
		public override void OnNext(T value) { }

	}

	[Token(Token = "0x2000135")]
	private class ReturnObservable : IObservable<T>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C2")]
		private readonly T value; //Field offset: 0x0

		[Address(RVA = "0xF54310", Offset = "0xF53710", Length = "0x25")]
		[Token(Token = "0x6000753")]
		public ReturnObservable`1(T value) { }

		[Address(RVA = "0xF54060", Offset = "0xF53460", Length = "0x13F")]
		[Token(Token = "0x6000754")]
		public override IDisposable Subscribe(IObserver<T> observer) { }

	}

	[Token(Token = "0x2000136")]
	private class ThrowObservable : IObservable<T>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C3")]
		private readonly Exception value; //Field offset: 0x0

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000755")]
		public ThrowObservable`1(Exception value) { }

		[Address(RVA = "0x1084E70", Offset = "0x1084270", Length = "0xAE")]
		[Token(Token = "0x6000756")]
		public override IDisposable Subscribe(IObserver<T> observer) { }

	}

	[Token(Token = "0x2000133")]
	private class ToUniTaskObserver : IObserver<T>
	{
		[Token(Token = "0x40004B5")]
		private static readonly Action<Object> callback; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B6")]
		private readonly UniTaskCompletionSource<T> promise; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B7")]
		private readonly SingleAssignmentDisposable disposable; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B8")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B9")]
		private readonly CancellationTokenRegistration registration; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004BA")]
		private bool hasValue; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004BB")]
		private T latestValue; //Field offset: 0x0

		[Address(RVA = "0x1090090", Offset = "0x108F490", Length = "0xEA")]
		[Token(Token = "0x600074C")]
		private static ToUniTaskObserver`1() { }

		[Address(RVA = "0x1090180", Offset = "0x108F580", Length = "0x2AC")]
		[Token(Token = "0x6000747")]
		public ToUniTaskObserver`1(UniTaskCompletionSource<T> promise, SingleAssignmentDisposable disposable, CancellationToken cancellationToken) { }

		[Address(RVA = "0x108FB40", Offset = "0x108EF40", Length = "0x166")]
		[Token(Token = "0x6000748")]
		private static void OnCanceled(object state) { }

		[Address(RVA = "0x108FCB0", Offset = "0x108F0B0", Length = "0x219")]
		[Token(Token = "0x600074B")]
		public override void OnCompleted() { }

		[Address(RVA = "0x108FED0", Offset = "0x108F2D0", Length = "0xAC")]
		[Token(Token = "0x600074A")]
		public override void OnError(Exception error) { }

		[Address(RVA = "0x108FF80", Offset = "0x108F380", Length = "0x110")]
		[Token(Token = "0x6000749")]
		public override void OnNext(T value) { }

	}


	[Address(RVA = "0x9D4540", Offset = "0x9D3940", Length = "0x1E6")]
	[AsyncStateMachine(typeof(<Fire>d__3`1))]
	[Token(Token = "0x6000745")]
	private static UniTaskVoid Fire(AsyncSubject<T> subject, UniTask<T> task) { }

	[Address(RVA = "0x2747B30", Offset = "0x2746F30", Length = "0xAC")]
	[AsyncStateMachine(typeof(<Fire>d__4))]
	[Token(Token = "0x6000746")]
	private static UniTaskVoid Fire(AsyncSubject<AsyncUnit> subject, UniTask task) { }

	[Address(RVA = "0x9D4730", Offset = "0x9D3B30", Length = "0x291")]
	[Extension]
	[Token(Token = "0x6000743")]
	public static IObservable<T> ToObservable(UniTask<T> task) { }

	[Address(RVA = "0x2747BE0", Offset = "0x2746FE0", Length = "0x292")]
	[Extension]
	[Token(Token = "0x6000744")]
	public static IObservable<AsyncUnit> ToObservable(UniTask task) { }

	[Address(RVA = "0x9D49D0", Offset = "0x9D3DD0", Length = "0x28A")]
	[Extension]
	[Token(Token = "0x6000742")]
	public static UniTask<T> ToUniTask(IObservable<T> source, bool useFirstValue = false, CancellationToken cancellationToken = null) { }

}

