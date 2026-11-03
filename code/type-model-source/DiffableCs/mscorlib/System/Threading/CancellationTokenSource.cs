namespace System.Threading;

[Token(Token = "0x2000209")]
public class CancellationTokenSource : IDisposable
{
	[Token(Token = "0x200020A")]
	private sealed class Linked1CancellationTokenSource : CancellationTokenSource
	{
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40009B5")]
		private readonly CancellationTokenRegistration _reg1; //Field offset: 0x40

		[Address(RVA = "0x209F570", Offset = "0x209E970", Length = "0x13A")]
		[Token(Token = "0x60011F0")]
		internal Linked1CancellationTokenSource(CancellationToken token1) { }

		[Address(RVA = "0x209F530", Offset = "0x209E930", Length = "0x3F")]
		[Token(Token = "0x60011F1")]
		protected virtual void Dispose(bool disposing) { }

	}

	[Token(Token = "0x200020B")]
	private sealed class Linked2CancellationTokenSource : CancellationTokenSource
	{
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40009B6")]
		private readonly CancellationTokenRegistration _reg1; //Field offset: 0x40
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40009B7")]
		private readonly CancellationTokenRegistration _reg2; //Field offset: 0x58

		[Address(RVA = "0x209F700", Offset = "0x209EB00", Length = "0x1C8")]
		[Token(Token = "0x60011F2")]
		internal Linked2CancellationTokenSource(CancellationToken token1, CancellationToken token2) { }

		[Address(RVA = "0x209F6B0", Offset = "0x209EAB0", Length = "0x4A")]
		[Token(Token = "0x60011F3")]
		protected virtual void Dispose(bool disposing) { }

	}

	[Token(Token = "0x200020C")]
	private sealed class LinkedNCancellationTokenSource : CancellationTokenSource
	{
		[CompilerGenerated]
		[Token(Token = "0x200020D")]
		private sealed class <>c
		{
			[Token(Token = "0x40009BA")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x20A8980", Offset = "0x20A7D80", Length = "0x67")]
			[Token(Token = "0x60011F7")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60011F8")]
			public <>c() { }

			[Address(RVA = "0x20A8900", Offset = "0x20A7D00", Length = "0x75")]
			[Token(Token = "0x60011F9")]
			internal void <.cctor>b__4_0(object s) { }

		}

		[Token(Token = "0x40009B8")]
		internal static readonly Action<Object> s_linkedTokenCancelDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40009B9")]
		private CancellationTokenRegistration[] _linkingRegistrations; //Field offset: 0x40

		[Address(RVA = "0x209F970", Offset = "0x209ED70", Length = "0xC8")]
		[Token(Token = "0x60011F6")]
		private static LinkedNCancellationTokenSource() { }

		[Address(RVA = "0x209FA40", Offset = "0x209EE40", Length = "0x208")]
		[Token(Token = "0x60011F4")]
		internal LinkedNCancellationTokenSource(CancellationToken[] tokens) { }

		[Address(RVA = "0x209F8D0", Offset = "0x209ECD0", Length = "0x91")]
		[Token(Token = "0x60011F5")]
		protected virtual void Dispose(bool disposing) { }

	}

	[Token(Token = "0x40009AA")]
	internal static readonly CancellationTokenSource s_canceledSource; //Field offset: 0x0
	[Token(Token = "0x40009AB")]
	internal static readonly CancellationTokenSource s_neverCanceledSource; //Field offset: 0x8
	[Token(Token = "0x40009AC")]
	private static readonly int s_nLists; //Field offset: 0x10
	[Token(Token = "0x40009B4")]
	private static readonly TimerCallback s_timerCallback; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009AD")]
	private ManualResetEvent _kernelEvent; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009AE")]
	private SparselyPopulatedArray<CancellationCallbackInfo>[] _registeredCallbacksLists; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009AF")]
	private int _state; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40009B0")]
	private int _threadIDExecutingCallbacks; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009B1")]
	private bool _disposed; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40009B2")]
	private CancellationCallbackInfo _executingCallback; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40009B3")]
	private Timer _timer; //Field offset: 0x38

	[Token(Token = "0x1700019B")]
	internal CancellationCallbackInfo ExecutingCallback
	{
		[Address(RVA = "0x1FAA310", Offset = "0x1FA9710", Length = "0x18")]
		[Token(Token = "0x60011DC")]
		internal get { } //Length: 24
	}

	[Token(Token = "0x17000197")]
	internal bool IsCancellationCompleted
	{
		[Address(RVA = "0x2095A10", Offset = "0x2094E10", Length = "0x1A")]
		[Token(Token = "0x60011D7")]
		internal get { } //Length: 26
	}

	[Token(Token = "0x17000196")]
	public bool IsCancellationRequested
	{
		[Address(RVA = "0x2095A30", Offset = "0x2094E30", Length = "0x1A")]
		[Token(Token = "0x60011D6")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000198")]
	internal bool IsDisposed
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x60011D8")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000199")]
	internal int ThreadIDExecutingCallbacks
	{
		[Address(RVA = "0x2095A50", Offset = "0x2094E50", Length = "0x16")]
		[Token(Token = "0x60011D9")]
		internal get { } //Length: 22
		[Address(RVA = "0x2095AD0", Offset = "0x2094ED0", Length = "0x22")]
		[Token(Token = "0x60011DA")]
		internal set { } //Length: 34
	}

	[Token(Token = "0x1700019A")]
	public CancellationToken Token
	{
		[Address(RVA = "0x2095A70", Offset = "0x2094E70", Length = "0x5B")]
		[Token(Token = "0x60011DB")]
		 get { } //Length: 91
	}

	[Address(RVA = "0x2095810", Offset = "0x2094C10", Length = "0x1BC")]
	[Token(Token = "0x60011EF")]
	private static CancellationTokenSource() { }

	[Address(RVA = "0x20959D0", Offset = "0x2094DD0", Length = "0x31")]
	[Token(Token = "0x60011DD")]
	public CancellationTokenSource() { }

	[Address(RVA = "0x2094220", Offset = "0x2093620", Length = "0x50")]
	[Token(Token = "0x60011DE")]
	public void Cancel() { }

	[Address(RVA = "0x20941C0", Offset = "0x20935C0", Length = "0x5E")]
	[Token(Token = "0x60011DF")]
	public void Cancel(bool throwOnFirstException) { }

	[Address(RVA = "0x2094000", Offset = "0x2093400", Length = "0x1BF")]
	[Token(Token = "0x60011E0")]
	public void CancelAfter(int millisecondsDelay) { }

	[Address(RVA = "0x2094300", Offset = "0x2093700", Length = "0x1FE")]
	[Token(Token = "0x60011EA")]
	private void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args) { }

	[Address(RVA = "0x2094280", Offset = "0x2093680", Length = "0x7E")]
	[Token(Token = "0x60011E9")]
	private void CancellationCallbackCoreWork_OnSyncContext(object obj) { }

	[Address(RVA = "0x20947C0", Offset = "0x2093BC0", Length = "0x371")]
	[Token(Token = "0x60011ED")]
	public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken[] tokens) { }

	[Address(RVA = "0x2094B40", Offset = "0x2093F40", Length = "0xC1")]
	[Token(Token = "0x60011EC")]
	internal static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token) { }

	[Address(RVA = "0x2094500", Offset = "0x2093900", Length = "0x2B8")]
	[Token(Token = "0x60011EB")]
	public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2) { }

	[Address(RVA = "0x2094C80", Offset = "0x2094080", Length = "0xA5")]
	[Token(Token = "0x60011E3")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x2094C10", Offset = "0x2094010", Length = "0x61")]
	[Token(Token = "0x60011E2")]
	public override void Dispose() { }

	[Address(RVA = "0x2094D30", Offset = "0x2094130", Length = "0x464")]
	[Token(Token = "0x60011E8")]
	private void ExecuteCallbackHandlers(bool throwOnFirstException) { }

	[Address(RVA = "0x1FAA310", Offset = "0x1FA9710", Length = "0x18")]
	[Token(Token = "0x60011DC")]
	internal CancellationCallbackInfo get_ExecutingCallback() { }

	[Address(RVA = "0x2095A10", Offset = "0x2094E10", Length = "0x1A")]
	[Token(Token = "0x60011D7")]
	internal bool get_IsCancellationCompleted() { }

	[Address(RVA = "0x2095A30", Offset = "0x2094E30", Length = "0x1A")]
	[Token(Token = "0x60011D6")]
	public bool get_IsCancellationRequested() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x60011D8")]
	internal bool get_IsDisposed() { }

	[Address(RVA = "0x2095A50", Offset = "0x2094E50", Length = "0x16")]
	[Token(Token = "0x60011D9")]
	internal int get_ThreadIDExecutingCallbacks() { }

	[Address(RVA = "0x2095A70", Offset = "0x2094E70", Length = "0x5B")]
	[Token(Token = "0x60011DB")]
	public CancellationToken get_Token() { }

	[Address(RVA = "0x20951A0", Offset = "0x20945A0", Length = "0x34F")]
	[Token(Token = "0x60011E6")]
	internal CancellationTokenRegistration InternalRegister(Action<Object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext) { }

	[Address(RVA = "0x20954F0", Offset = "0x20948F0", Length = "0xA3")]
	[Token(Token = "0x60011E7")]
	private void NotifyCancellation(bool throwOnFirstException) { }

	[Address(RVA = "0x2095AD0", Offset = "0x2094ED0", Length = "0x22")]
	[Token(Token = "0x60011DA")]
	internal void set_ThreadIDExecutingCallbacks(int value) { }

	[Address(RVA = "0x20955A0", Offset = "0x20949A0", Length = "0x44")]
	[Token(Token = "0x60011E4")]
	internal void ThrowIfDisposed() { }

	[Address(RVA = "0x20955F0", Offset = "0x20949F0", Length = "0x50")]
	[Token(Token = "0x60011E5")]
	private static void ThrowObjectDisposedException() { }

	[Address(RVA = "0x2095650", Offset = "0x2094A50", Length = "0xEB")]
	[Token(Token = "0x60011E1")]
	private static void TimerCallbackLogic(object obj) { }

	[Address(RVA = "0x2095740", Offset = "0x2094B40", Length = "0xC6")]
	[Token(Token = "0x60011EE")]
	internal void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo) { }

}

