namespace UnityEngine;

[AsyncMethodBuilder(typeof(AwaitableAsyncMethodBuilder))]
[NativeHeader("Runtime/Mono/DelayedCallAwaitable.h")]
[NativeHeader("Runtime/Mono/AsyncOperationAwaitable.h")]
[NativeHeader("Runtime/Mono/Awaitable.h")]
[Token(Token = "0x2000192")]
public class Awaitable : IEnumerator
{
	[CompilerGenerated]
	[Token(Token = "0x200019B")]
	private sealed class <>c
	{
		[Token(Token = "0x4000651")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000652")]
		public static Action<Object> <>9__26_0; //Field offset: 0x8
		[Token(Token = "0x4000653")]
		public static Func<Awaitable> <>9__76_1; //Field offset: 0x10

		[Address(RVA = "0x3073C90", Offset = "0x3073090", Length = "0x67")]
		[Token(Token = "0x60012C6")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60012C7")]
		public <>c() { }

		[Address(RVA = "0x3073A80", Offset = "0x3072E80", Length = "0x148")]
		[Token(Token = "0x60012C9")]
		internal ObjectPool<Awaitable> <.cctor>b__76_0() { }

		[Address(RVA = "0x3073BD0", Offset = "0x3072FD0", Length = "0x49")]
		[Token(Token = "0x60012CA")]
		internal Awaitable <.cctor>b__76_1() { }

		[Address(RVA = "0x30736D0", Offset = "0x3072AD0", Length = "0x72")]
		[Token(Token = "0x60012C8")]
		internal void <WireupCancellation>b__26_0(object coroutine) { }

	}

	[Token(Token = "0x2000198")]
	private struct AwaitableAndFrameIndex
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400064C")]
		private readonly Awaitable <Awaitable>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400064D")]
		private readonly int <FrameIndex>k__BackingField; //Field offset: 0x8

		[Token(Token = "0x170002D6")]
		public Awaitable Awaitable
		{
			[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x60012BE")]
			 get { } //Length: 4
		}

		[Token(Token = "0x170002D7")]
		public int FrameIndex
		{
			[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x60012BF")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60012BE")]
		public Awaitable get_Awaitable() { }

		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60012BF")]
		public int get_FrameIndex() { }

	}

	[ExcludeFromDocs]
	[Token(Token = "0x2000194")]
	internal struct AwaitableAsyncMethodBuilder
	{
		[Token(Token = "0x2000195")]
		private interface IStateMachineBox : IDisposable
		{

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000646")]
		private IStateMachineBox _stateMachineBox; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000647")]
		private Awaitable _resultingCoroutine; //Field offset: 0x8

	}

	[IsReadOnly]
	[Token(Token = "0x2000197")]
	private struct AwaitableHandle
	{
		[Token(Token = "0x400064A")]
		public static AwaitableHandle ManagedHandle; //Field offset: 0x0
		[Token(Token = "0x400064B")]
		public static AwaitableHandle NullHandle; //Field offset: 0x8
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000649")]
		private readonly IntPtr _handle; //Field offset: 0x0

		[Token(Token = "0x170002D5")]
		public bool IsManaged
		{
			[Address(RVA = "0x3055B30", Offset = "0x3054F30", Length = "0x5A")]
			[Token(Token = "0x60012B9")]
			 get { } //Length: 90
		}

		[Token(Token = "0x170002D4")]
		public bool IsNull
		{
			[Address(RVA = "0x1F12030", Offset = "0x1F11430", Length = "0x8")]
			[Token(Token = "0x60012B8")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x3055AC0", Offset = "0x3054EC0", Length = "0x6C")]
		[Token(Token = "0x60012BD")]
		private static AwaitableHandle() { }

		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[Token(Token = "0x60012BA")]
		public AwaitableHandle(IntPtr handle) { }

		[Address(RVA = "0x3055B30", Offset = "0x3054F30", Length = "0x5A")]
		[Token(Token = "0x60012B9")]
		public bool get_IsManaged() { }

		[Address(RVA = "0x1F12030", Offset = "0x1F11430", Length = "0x8")]
		[Token(Token = "0x60012B8")]
		public bool get_IsNull() { }

		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x60012BB")]
		public static IntPtr op_Implicit(AwaitableHandle handle) { }

		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x60012BC")]
		public static AwaitableHandle op_Implicit(IntPtr handle) { }

	}

	[ExcludeFromDocs]
	[Token(Token = "0x2000196")]
	internal struct Awaiter : INotifyCompletion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000648")]
		private readonly Awaitable _awaited; //Field offset: 0x0

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x60012B5")]
		internal Awaiter(Awaitable awaited) { }

		[Address(RVA = "0x3057F70", Offset = "0x3057370", Length = "0x1C")]
		[Token(Token = "0x60012B7")]
		public void GetResult() { }

		[Address(RVA = "0x1649AD0", Offset = "0x1648ED0", Length = "0x1D")]
		[Token(Token = "0x60012B6")]
		public override void OnCompleted(Action continuation) { }

	}

	[Token(Token = "0x2000193")]
	public enum AwaiterCompletionThreadAffinity : int
	{
		None = 0,
		MainThread = 1,
		BackgroundThread = 2,
	}

	[Token(Token = "0x2000199")]
	private class DoubleBufferedAwaitableList
	{
		[CompilerGenerated]
		[Token(Token = "0x200019A")]
		private sealed class <>c__DisplayClass4_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000650")]
			public Awaitable item; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60012C4")]
			public <>c__DisplayClass4_0() { }

			[Address(RVA = "0x3073C80", Offset = "0x3073080", Length = "0xB")]
			[Token(Token = "0x60012C5")]
			internal bool <Remove>b__0(AwaitableAndFrameIndex x) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400064E")]
		private List<AwaitableAndFrameIndex> _awaitables; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400064F")]
		private List<AwaitableAndFrameIndex> _scratch; //Field offset: 0x18

		[Address(RVA = "0x305E5C0", Offset = "0x305D9C0", Length = "0xA5")]
		[Token(Token = "0x60012C3")]
		public DoubleBufferedAwaitableList() { }

		[Address(RVA = "0x305E200", Offset = "0x305D600", Length = "0x5F")]
		[Token(Token = "0x60012C2")]
		public void Clear() { }

		[Address(RVA = "0x305E260", Offset = "0x305D660", Length = "0xD6")]
		[Token(Token = "0x60012C1")]
		public void Remove(Awaitable item) { }

		[Address(RVA = "0x305E340", Offset = "0x305D740", Length = "0x278")]
		[Token(Token = "0x60012C0")]
		public void SwapAndComplete() { }

	}

	[Token(Token = "0x4000634")]
	private static readonly ThreadLocal<ObjectPool`1<Awaitable>> _pool; //Field offset: 0x0
	[Token(Token = "0x400063C")]
	private static bool _nextFrameAndEndOfFrameWiredUp; //Field offset: 0x8
	[Token(Token = "0x400063D")]
	private static CancellationTokenRegistration _nextFrameAndEndOfFrameWiredUpCTRegistration; //Field offset: 0x10
	[Token(Token = "0x400063E")]
	private static readonly DoubleBufferedAwaitableList _nextFrameAwaitables; //Field offset: 0x28
	[Token(Token = "0x400063F")]
	private static readonly DoubleBufferedAwaitableList _endOfFrameAwaitables; //Field offset: 0x30
	[Token(Token = "0x4000640")]
	private static SynchronizationContext _synchronizationContext; //Field offset: 0x38
	[Token(Token = "0x4000641")]
	private static int _mainThreadId; //Field offset: 0x40
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000633")]
	private SpinLock _spinLock; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000635")]
	private AwaitableHandle _handle; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000636")]
	private ExceptionDispatchInfo _exceptionToRethrow; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000637")]
	private bool _managedAwaitableDone; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000638")]
	private AwaiterCompletionThreadAffinity _completionThreadAffinity; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000639")]
	private Action _continuation; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400063A")]
	private Nullable<CancellationTokenRegistration> _cancelTokenRegistration; //Field offset: 0x38
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400063B")]
	private DoubleBufferedAwaitableList _managedCompletionQueue; //Field offset: 0x58

	[Token(Token = "0x170002D1")]
	public bool IsCompleted
	{
		[Address(RVA = "0x3057A70", Offset = "0x3056E70", Length = "0x1E3")]
		[Token(Token = "0x60012A9")]
		 get { } //Length: 483
	}

	[Token(Token = "0x170002CF")]
	private bool IsCompletedNoLock
	{
		[Address(RVA = "0x3057930", Offset = "0x3056D30", Length = "0x13D")]
		[Token(Token = "0x60012A7")]
		private get { } //Length: 317
	}

	[Token(Token = "0x170002D2")]
	internal bool IsDettachedOrCompleted
	{
		[Address(RVA = "0x3057C60", Offset = "0x3057060", Length = "0x1F6")]
		[Token(Token = "0x60012AA")]
		internal get { } //Length: 502
	}

	[Token(Token = "0x170002D0")]
	private bool IsLogicallyCompletedNoLock
	{
		[Address(RVA = "0x3057E60", Offset = "0x3057260", Length = "0x10D")]
		[Token(Token = "0x60012A8")]
		private get { } //Length: 269
	}

	[Token(Token = "0x170002D3")]
	private override object System.Collections.IEnumerator.Current
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60012AF")]
		private get { } //Length: 3
	}

	[Address(RVA = "0x3057750", Offset = "0x3056B50", Length = "0x1C4")]
	[Token(Token = "0x60012B4")]
	private static Awaitable() { }

	[Address(RVA = "0x3057920", Offset = "0x3056D20", Length = "0xC")]
	[Token(Token = "0x600129D")]
	private Awaitable() { }

	[Address(RVA = "0x3055B90", Offset = "0x3054F90", Length = "0x42")]
	[FreeFunction("Scripting::Awaitables::AttachManagedWrapper", IsThreadSafe = True)]
	[Token(Token = "0x6001299")]
	private static void AttachManagedGCHandleToNativeAwaitable(IntPtr nativeAwaitable, UIntPtr gcHandle) { }

	[Address(RVA = "0x3055C20", Offset = "0x3055020", Length = "0x209")]
	[Token(Token = "0x60012A6")]
	public void Cancel() { }

	[Address(RVA = "0x3055BE0", Offset = "0x3054FE0", Length = "0x33")]
	[FreeFunction("Scripting::Awaitables::Cancel", IsThreadSafe = True)]
	[Token(Token = "0x600129B")]
	private static void CancelNativeAwaitable(IntPtr nativeAwaitable) { }

	[Address(RVA = "0x3055E30", Offset = "0x3055230", Length = "0x94")]
	[Token(Token = "0x60012AB")]
	private AwaitableHandle CheckPointerValidity() { }

	[Address(RVA = "0x3055ED0", Offset = "0x30552D0", Length = "0x59")]
	[Token(Token = "0x60012A3")]
	private static void DoRunContinuationOnSynchonizationContext(object continuation) { }

	[Address(RVA = "0x3055F70", Offset = "0x3055370", Length = "0x237")]
	[Token(Token = "0x6001294")]
	public static Awaitable FromAsyncOperation(AsyncOperation op, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x3055F30", Offset = "0x3055330", Length = "0x33")]
	[FreeFunction("Scripting::Awaitables::FromAsyncOperation", ThrowsException = True)]
	[Token(Token = "0x6001295")]
	private static IntPtr FromAsyncOperationInternal(IntPtr asyncOperation) { }

	[Address(RVA = "0x30561B0", Offset = "0x30555B0", Length = "0x195")]
	[Token(Token = "0x600129E")]
	private static Awaitable FromNativeAwaitableHandle(IntPtr nativeHandle, CancellationToken cancellationToken) { }

	[Address(RVA = "0x3057A70", Offset = "0x3056E70", Length = "0x1E3")]
	[Token(Token = "0x60012A9")]
	public bool get_IsCompleted() { }

	[Address(RVA = "0x3057930", Offset = "0x3056D30", Length = "0x13D")]
	[Token(Token = "0x60012A7")]
	private bool get_IsCompletedNoLock() { }

	[Address(RVA = "0x3057C60", Offset = "0x3057060", Length = "0x1F6")]
	[Token(Token = "0x60012AA")]
	internal bool get_IsDettachedOrCompleted() { }

	[Address(RVA = "0x3057E60", Offset = "0x3057260", Length = "0x10D")]
	[Token(Token = "0x60012A8")]
	private bool get_IsLogicallyCompletedNoLock() { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[ExcludeFromDocs]
	[Token(Token = "0x6001296")]
	public Awaiter GetAwaiter() { }

	[Address(RVA = "0x3056350", Offset = "0x3055750", Length = "0x33")]
	[FreeFunction("Scripting::Awaitables::IsCompleted", IsThreadSafe = True)]
	[Token(Token = "0x600129C")]
	private static int IsNativeAwaitableCompleted(IntPtr nativeAwaitable) { }

	[Address(RVA = "0x3056390", Offset = "0x3055790", Length = "0xCD")]
	[Token(Token = "0x60012A0")]
	private static bool MatchCompletionThreadAffinity(AwaiterCompletionThreadAffinity awaiterCompletionThreadAffinity) { }

	[Address(RVA = "0x3056460", Offset = "0x3055860", Length = "0x125")]
	[RequiredByNativeCode]
	[Token(Token = "0x60012B0")]
	private static void OnDelayedCallManagerCleared() { }

	[Address(RVA = "0x3056590", Offset = "0x3055990", Length = "0x5F")]
	[RequiredByNativeCode]
	[Token(Token = "0x60012B2")]
	private static void OnEndOfFrame() { }

	[Address(RVA = "0x30565F0", Offset = "0x30559F0", Length = "0x5F")]
	[RequiredByNativeCode]
	[Token(Token = "0x60012B1")]
	private static void OnUpdate() { }

	[Address(RVA = "0x3056650", Offset = "0x3055A50", Length = "0x470")]
	[Token(Token = "0x60012A5")]
	internal void PropagateExceptionAndRelease() { }

	[Address(RVA = "0x3056AD0", Offset = "0x3055ED0", Length = "0x14A")]
	[Token(Token = "0x60012A4")]
	internal void RaiseManagedCompletion() { }

	[Address(RVA = "0x3056C20", Offset = "0x3056020", Length = "0x152")]
	[Token(Token = "0x60012A1")]
	internal void RaiseManagedCompletion(Exception exception) { }

	[Address(RVA = "0x3056D80", Offset = "0x3056180", Length = "0x33")]
	[FreeFunction("Scripting::Awaitables::Release", IsThreadSafe = True)]
	[Token(Token = "0x600129A")]
	private static void ReleaseNativeAwaitable(IntPtr nativeAwaitable) { }

	[Address(RVA = "0x3056DC0", Offset = "0x30561C0", Length = "0xF5")]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6001298")]
	private void RunContinuation() { }

	[Address(RVA = "0x3056EC0", Offset = "0x30562C0", Length = "0x159")]
	[Token(Token = "0x60012A2")]
	private void RunOrScheduleContinuation(AwaiterCompletionThreadAffinity awaiterCompletionThreadAffinity, Action continuation) { }

	[Address(RVA = "0x3057020", Offset = "0x3056420", Length = "0x22D")]
	[Token(Token = "0x60012AC")]
	internal void SetContinuation(Action continuation) { }

	[Address(RVA = "0x3057250", Offset = "0x3056650", Length = "0xDF")]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6001297")]
	private void SetExceptionFromNative(Exception ex) { }

	[Address(RVA = "0x3057330", Offset = "0x3056730", Length = "0x8D")]
	[Token(Token = "0x60012B3")]
	internal static void SetSynchronizationContext(UnitySynchronizationContext synchronizationContext) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60012AF")]
	private override object System.Collections.IEnumerator.get_Current() { }

	[Address(RVA = "0x30573C0", Offset = "0x30567C0", Length = "0x2E")]
	[Token(Token = "0x60012AD")]
	private override bool System.Collections.IEnumerator.MoveNext() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60012AE")]
	private override void System.Collections.IEnumerator.Reset() { }

	[Address(RVA = "0x30573F0", Offset = "0x30567F0", Length = "0x359")]
	[Token(Token = "0x600129F")]
	private static void WireupCancellation(Awaitable awaitable, CancellationToken cancellationToken) { }

}

