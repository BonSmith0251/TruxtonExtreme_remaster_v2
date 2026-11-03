namespace System.Threading.Tasks;

[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}")]
[DebuggerTypeProxy(typeof(SystemThreadingTasks_TaskDebugView))]
[Token(Token = "0x2000269")]
public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x200026D")]
	private sealed class <>c
	{
		[Token(Token = "0x4000AF8")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000AF9")]
		public static Action<Object> <>9__247_0; //Field offset: 0x8
		[Token(Token = "0x4000AFA")]
		public static TimerCallback <>9__247_1; //Field offset: 0x10

		[Address(RVA = "0x20C45A0", Offset = "0x20C39A0", Length = "0x67")]
		[Token(Token = "0x60014A5")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60014A6")]
		public <>c() { }

		[Address(RVA = "0x20C40D0", Offset = "0x20C34D0", Length = "0x50")]
		[Token(Token = "0x60014A9")]
		internal ContingentProperties <.cctor>b__271_0() { }

		[Address(RVA = "0x20C4120", Offset = "0x20C3520", Length = "0x2E")]
		[Token(Token = "0x60014AA")]
		internal bool <.cctor>b__271_1(Task t) { }

		[Address(RVA = "0xA53AA0", Offset = "0xA52EA0", Length = "0x7")]
		[Token(Token = "0x60014AB")]
		internal bool <.cctor>b__271_2(object tc) { }

		[Address(RVA = "0x20C3EF0", Offset = "0x20C32F0", Length = "0x62")]
		[Token(Token = "0x60014A7")]
		internal void <Delay>b__247_0(object state) { }

		[Address(RVA = "0x20C3F60", Offset = "0x20C3360", Length = "0x62")]
		[Token(Token = "0x60014A8")]
		internal void <Delay>b__247_1(object state) { }

	}

	[Token(Token = "0x200026A")]
	public class ContingentProperties
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000AED")]
		internal ExecutionContext m_capturedContext; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000AEE")]
		internal ManualResetEventSlim m_completionEvent; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000AEF")]
		internal TaskExceptionHolder m_exceptionsHolder; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000AF0")]
		internal CancellationToken m_cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000AF1")]
		internal object m_cancellationRegistration; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000AF2")]
		internal int m_internalCancellationRequested; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000AF3")]
		internal int m_completionCountdown; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000AF4")]
		internal LowLevelListWithIList<Task> m_exceptionalChildren; //Field offset: 0x40

		[Address(RVA = "0x20ADCA0", Offset = "0x20AD0A0", Length = "0x24")]
		[Token(Token = "0x600149F")]
		public ContingentProperties() { }

		[Address(RVA = "0x20ADBC0", Offset = "0x20ACFC0", Length = "0x29")]
		[Token(Token = "0x600149D")]
		internal void SetCompleted() { }

		[Address(RVA = "0x20ADBF0", Offset = "0x20ACFF0", Length = "0xAD")]
		[Token(Token = "0x600149E")]
		internal void UnregisterCancellationCallback() { }

	}

	[Token(Token = "0x200026C")]
	private sealed class DelayPromise : Task<VoidTaskResult>
	{
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000AF5")]
		internal readonly CancellationToken Token; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000AF6")]
		internal CancellationTokenRegistration Registration; //Field offset: 0x60
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000AF7")]
		internal Timer Timer; //Field offset: 0x78

		[Address(RVA = "0x20B1170", Offset = "0x20B0570", Length = "0xA0")]
		[Token(Token = "0x60014A3")]
		internal DelayPromise(CancellationToken token) { }

		[Address(RVA = "0x20B1060", Offset = "0x20B0460", Length = "0x10D")]
		[Token(Token = "0x60014A4")]
		internal void Complete() { }

	}

	[Token(Token = "0x200026B")]
	private sealed class SetOnInvokeMres : ManualResetEventSlim, ITaskCompletionAction
	{

		[Token(Token = "0x170001F4")]
		public override bool InvokeMayRunArbitraryCode
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60014A2")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x20B4D70", Offset = "0x20B4170", Length = "0x4F")]
		[Token(Token = "0x60014A0")]
		internal SetOnInvokeMres() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60014A2")]
		public override bool get_InvokeMayRunArbitraryCode() { }

		[Address(RVA = "0x20B4D60", Offset = "0x20B4160", Length = "0x7")]
		[Token(Token = "0x60014A1")]
		public override void Invoke(Task completingTask) { }

	}

	[ThreadStatic]
	[Token(Token = "0x4000AE3")]
	internal static Task t_currentTask; //Field offset: 0x80000000
	[ThreadStatic]
	[Token(Token = "0x4000AE4")]
	private static StackGuard t_stackGuard; //Field offset: 0x80000008
	[Token(Token = "0x4000AD7")]
	internal static int s_taskIdCounter; //Field offset: 0x0
	[Token(Token = "0x4000ADF")]
	private static readonly object s_taskCompletionSentinel; //Field offset: 0x8
	[Token(Token = "0x4000AE0")]
	internal static bool s_asyncDebuggingEnabled; //Field offset: 0x10
	[Token(Token = "0x4000AE2")]
	private static readonly Action<Object> s_taskCancelCallback; //Field offset: 0x18
	[Token(Token = "0x4000AE5")]
	private static readonly Func<ContingentProperties> s_createContingentProperties; //Field offset: 0x20
	[CompilerGenerated]
	[Token(Token = "0x4000AE6")]
	private static readonly TaskFactory <Factory>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[Token(Token = "0x4000AE7")]
	private static readonly Task <CompletedTask>k__BackingField; //Field offset: 0x30
	[Token(Token = "0x4000AE8")]
	private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate; //Field offset: 0x38
	[Token(Token = "0x4000AE9")]
	private static ContextCallback s_ecCallback; //Field offset: 0x40
	[Token(Token = "0x4000AEA")]
	private static readonly Predicate<Object> s_IsTaskContinuationNullPredicate; //Field offset: 0x48
	[Token(Token = "0x4000AEB")]
	private static readonly Dictionary<Int32, Task> s_currentActiveTasks; //Field offset: 0x50
	[Token(Token = "0x4000AEC")]
	private static readonly object s_activeTasksLock; //Field offset: 0x58
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000AD8")]
	private int m_taskId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000AD9")]
	internal Delegate m_action; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000ADA")]
	internal object m_stateObject; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000ADB")]
	internal TaskScheduler m_taskScheduler; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000ADC")]
	internal readonly Task m_parent; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000ADD")]
	internal int m_stateFlags; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000ADE")]
	private object m_continuationObject; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000AE1")]
	internal ContingentProperties m_contingentProperties; //Field offset: 0x48

	[Token(Token = "0x170001E9")]
	public override object AsyncState
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6001445")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001E3")]
	internal CancellationToken CancellationToken
	{
		[Address(RVA = "0x20BFBC0", Offset = "0x20BEFC0", Length = "0x26")]
		[Token(Token = "0x600143E")]
		internal get { } //Length: 38
	}

	[Token(Token = "0x170001F1")]
	internal ExecutionContext CapturedContext
	{
		[Address(RVA = "0x20BFBF0", Offset = "0x20BEFF0", Length = "0x74")]
		[Token(Token = "0x600144D")]
		internal get { } //Length: 116
		[Address(RVA = "0x20C0460", Offset = "0x20BF860", Length = "0x8A")]
		[Token(Token = "0x600144E")]
		internal set { } //Length: 138
	}

	[Token(Token = "0x170001EE")]
	internal ManualResetEventSlim CompletedEvent
	{
		[Address(RVA = "0x20BFC70", Offset = "0x20BF070", Length = "0x19E")]
		[Token(Token = "0x600144A")]
		internal get { } //Length: 414
	}

	[Token(Token = "0x170001ED")]
	public static Task CompletedTask
	{
		[Address(RVA = "0x20BFE10", Offset = "0x20BF210", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x6001449")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001E7")]
	public TaskCreationOptions CreationOptions
	{
		[Address(RVA = "0x20BFE60", Offset = "0x20BF260", Length = "0x4B")]
		[Token(Token = "0x6001443")]
		 get { } //Length: 75
	}

	[Token(Token = "0x170001DE")]
	internal static StackGuard CurrentStackGuard
	{
		[Address(RVA = "0x20BFEB0", Offset = "0x20BF2B0", Length = "0xBE")]
		[Token(Token = "0x6001437")]
		internal get { } //Length: 190
	}

	[Token(Token = "0x170001DF")]
	public AggregateException Exception
	{
		[Address(RVA = "0x20BFFE0", Offset = "0x20BF3E0", Length = "0x41")]
		[Token(Token = "0x6001438")]
		 get { } //Length: 65
	}

	[Token(Token = "0x170001EF")]
	internal bool ExceptionRecorded
	{
		[Address(RVA = "0x20BFF70", Offset = "0x20BF370", Length = "0x60")]
		[Token(Token = "0x600144B")]
		internal get { } //Length: 96
	}

	[Token(Token = "0x170001EB")]
	internal TaskScheduler ExecutingTaskScheduler
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6001447")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170001EC")]
	public static TaskFactory Factory
	{
		[Address(RVA = "0x20C0030", Offset = "0x20BF430", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x6001448")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001DC")]
	public int Id
	{
		[Address(RVA = "0x20C0080", Offset = "0x20BF480", Length = "0x96")]
		[Token(Token = "0x6001434")]
		 get { } //Length: 150
	}

	[Token(Token = "0x170001DD")]
	internal static Task InternalCurrent
	{
		[Address(RVA = "0x20C0120", Offset = "0x20BF520", Length = "0x49")]
		[Token(Token = "0x6001435")]
		internal get { } //Length: 73
	}

	[Token(Token = "0x170001E1")]
	public bool IsCanceled
	{
		[Address(RVA = "0x20C0170", Offset = "0x20BF570", Length = "0x23")]
		[Token(Token = "0x600143A")]
		 get { } //Length: 35
	}

	[Token(Token = "0x170001E4")]
	internal bool IsCancellationAcknowledged
	{
		[Address(RVA = "0x20C01A0", Offset = "0x20BF5A0", Length = "0x1D")]
		[Token(Token = "0x600143F")]
		internal get { } //Length: 29
	}

	[Token(Token = "0x170001E2")]
	internal bool IsCancellationRequested
	{
		[Address(RVA = "0x20C01C0", Offset = "0x20BF5C0", Length = "0x7F")]
		[Token(Token = "0x600143B")]
		internal get { } //Length: 127
	}

	[Token(Token = "0x170001E5")]
	public override bool IsCompleted
	{
		[Address(RVA = "0x20C0270", Offset = "0x20BF670", Length = "0x51")]
		[Token(Token = "0x6001440")]
		 get { } //Length: 81
	}

	[Token(Token = "0x170001E6")]
	public bool IsCompletedSuccessfully
	{
		[Address(RVA = "0x20C0240", Offset = "0x20BF640", Length = "0x23")]
		[Token(Token = "0x6001442")]
		 get { } //Length: 35
	}

	[Token(Token = "0x170001F3")]
	internal bool IsDelegateInvoked
	{
		[Address(RVA = "0x20C02D0", Offset = "0x20BF6D0", Length = "0x1D")]
		[Token(Token = "0x600145A")]
		internal get { } //Length: 29
	}

	[Token(Token = "0x170001F2")]
	internal bool IsExceptionObservedByParent
	{
		[Address(RVA = "0x20C02F0", Offset = "0x20BF6F0", Length = "0x1D")]
		[Token(Token = "0x6001459")]
		internal get { } //Length: 29
	}

	[Token(Token = "0x170001F0")]
	public bool IsFaulted
	{
		[Address(RVA = "0x20C0310", Offset = "0x20BF710", Length = "0x1D")]
		[Token(Token = "0x600144C")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170001DB")]
	internal bool IsWaitNotificationEnabled
	{
		[Address(RVA = "0x20C0360", Offset = "0x20BF760", Length = "0x1D")]
		[Token(Token = "0x600142E")]
		internal get { } //Length: 29
	}

	[Token(Token = "0x170001D9")]
	internal bool IsWaitNotificationEnabledOrNotRanToCompletion
	{
		[Address(RVA = "0x20C0330", Offset = "0x20BF730", Length = "0x23")]
		[Token(Token = "0x600142C")]
		internal get { } //Length: 35
	}

	[Token(Token = "0x170001D8")]
	internal TaskCreationOptions Options
	{
		[Address(RVA = "0x20C0380", Offset = "0x20BF780", Length = "0x4B")]
		[Token(Token = "0x6001426")]
		internal get { } //Length: 75
	}

	[Token(Token = "0x170001DA")]
	internal override bool ShouldNotifyDebuggerOfWaitCompletion
	{
		[Address(RVA = "0x20C0360", Offset = "0x20BF760", Length = "0x1D")]
		[Token(Token = "0x600142D")]
		internal get { } //Length: 29
	}

	[Token(Token = "0x170001E0")]
	public TaskStatus Status
	{
		[Address(RVA = "0x20C03D0", Offset = "0x20BF7D0", Length = "0x82")]
		[Token(Token = "0x6001439")]
		 get { } //Length: 130
	}

	[Token(Token = "0x170001E8")]
	private override WaitHandle System.IAsyncResult.AsyncWaitHandle
	{
		[Address(RVA = "0x20BE240", Offset = "0x20BD640", Length = "0x210")]
		[Token(Token = "0x6001444")]
		private get { } //Length: 528
	}

	[Token(Token = "0x170001EA")]
	private override bool System.IAsyncResult.CompletedSynchronously
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001446")]
		private get { } //Length: 3
	}

	[Address(RVA = "0x20BF3D0", Offset = "0x20BE7D0", Length = "0x404")]
	[Token(Token = "0x600149C")]
	private static Task() { }

	[Address(RVA = "0x20BF8B0", Offset = "0x20BECB0", Length = "0xE7")]
	[Token(Token = "0x600141F")]
	internal Task(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	[Address(RVA = "0x20BFB10", Offset = "0x20BEF10", Length = "0xA1")]
	[Token(Token = "0x600141E")]
	public Task(Action action, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20BF7E0", Offset = "0x20BEBE0", Length = "0xCC")]
	[Token(Token = "0x600141B")]
	internal Task(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct) { }

	[Address(RVA = "0x20BF9A0", Offset = "0x20BEDA0", Length = "0x22")]
	[Token(Token = "0x600141C")]
	internal Task() { }

	[Address(RVA = "0x20BF9D0", Offset = "0x20BEDD0", Length = "0x130")]
	[Token(Token = "0x600141D")]
	internal Task(object state, TaskCreationOptions creationOptions, bool promiseStyle) { }

	[Address(RVA = "0x20B83C0", Offset = "0x20B77C0", Length = "0x6A")]
	[Token(Token = "0x600147F")]
	internal void AddCompletionAction(ITaskCompletionAction action) { }

	[Address(RVA = "0x20B8430", Offset = "0x20B7830", Length = "0x79")]
	[Token(Token = "0x6001480")]
	private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers) { }

	[Address(RVA = "0x20B87E0", Offset = "0x20B7BE0", Length = "0xB")]
	[Token(Token = "0x6001452")]
	internal void AddException(object exceptionObject) { }

	[Address(RVA = "0x20B84B0", Offset = "0x20B78B0", Length = "0x32A")]
	[Token(Token = "0x6001453")]
	internal void AddException(object exceptionObject, bool representsCancellation) { }

	[Address(RVA = "0x20B87F0", Offset = "0x20B7BF0", Length = "0x372")]
	[Token(Token = "0x600145F")]
	internal void AddExceptionsFromChildren() { }

	[Address(RVA = "0x20B8B70", Offset = "0x20B7F70", Length = "0xF5")]
	[Token(Token = "0x6001431")]
	internal void AddNewChild() { }

	[Address(RVA = "0x20B8F60", Offset = "0x20B8360", Length = "0xD1")]
	[Token(Token = "0x6001482")]
	private bool AddTaskContinuation(object tc, bool addBeforeOthers) { }

	[Address(RVA = "0x20B8C70", Offset = "0x20B8070", Length = "0x2E3")]
	[Token(Token = "0x6001481")]
	private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers) { }

	[Address(RVA = "0x20B9040", Offset = "0x20B8440", Length = "0x142")]
	[FriendAccessAllowed]
	[Token(Token = "0x6001498")]
	internal static bool AddToActiveTasks(Task task) { }

	[Address(RVA = "0x20B9190", Offset = "0x20B8590", Length = "0x2C8")]
	[Token(Token = "0x6001421")]
	private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation) { }

	[Address(RVA = "0x20B9520", Offset = "0x20B8920", Length = "0xB1")]
	[Token(Token = "0x6001428")]
	internal bool AtomicStateUpdate(int newBits, int illegalBits) { }

	[Address(RVA = "0x20B9460", Offset = "0x20B8860", Length = "0xB2")]
	[Token(Token = "0x6001429")]
	internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags) { }

	[Address(RVA = "0x20B95E0", Offset = "0x20B89E0", Length = "0xC8")]
	[Token(Token = "0x6001474")]
	internal void CancellationCleanupLogic() { }

	[Address(RVA = "0x20B96B0", Offset = "0x20B8AB0", Length = "0x20")]
	[Token(Token = "0x6001467")]
	public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	[Address(RVA = "0x20B9A90", Offset = "0x20B8E90", Length = "0x299")]
	[Token(Token = "0x6001479")]
	private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }

	[Address(RVA = "0x20B9990", Offset = "0x20B8D90", Length = "0xFA")]
	[Token(Token = "0x6001478")]
	public Task ContinueWith(Action<Task> continuationAction) { }

	[Address(RVA = "0x20B9940", Offset = "0x20B8D40", Length = "0x1E")]
	[Token(Token = "0x600147A")]
	public Task ContinueWith(Action<Task, Object> continuationAction, object state, TaskScheduler scheduler) { }

	[Address(RVA = "0x20B9960", Offset = "0x20B8D60", Length = "0x29")]
	[Token(Token = "0x600147B")]
	public Task ContinueWith(Action<Task, Object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	[Address(RVA = "0x20B9D30", Offset = "0x20B9130", Length = "0x29B")]
	[Token(Token = "0x600147C")]
	private Task ContinueWith(Action<Task, Object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }

	[Address(RVA = "0x20B96D0", Offset = "0x20B8AD0", Length = "0x261")]
	[Token(Token = "0x600147E")]
	internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options) { }

	[Address(RVA = "0x20B9FD0", Offset = "0x20B93D0", Length = "0x159")]
	[Token(Token = "0x600147D")]
	internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions) { }

	[Address(RVA = "0x20BA280", Offset = "0x20B9680", Length = "0x126")]
	[Token(Token = "0x6001492")]
	public static Task Delay(TimeSpan delay) { }

	[Address(RVA = "0x20BA3B0", Offset = "0x20B97B0", Length = "0x5DE")]
	[Token(Token = "0x6001495")]
	public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20BA230", Offset = "0x20B9630", Length = "0x4A")]
	[Token(Token = "0x6001494")]
	public static Task Delay(int millisecondsDelay) { }

	[Address(RVA = "0x20BA130", Offset = "0x20B9530", Length = "0xF5")]
	[Token(Token = "0x6001493")]
	public static Task Delay(TimeSpan delay, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20BAB00", Offset = "0x20B9F00", Length = "0x61")]
	[Token(Token = "0x600144F")]
	public override void Dispose() { }

	[Address(RVA = "0x20BA990", Offset = "0x20B9D90", Length = "0x169")]
	[Token(Token = "0x6001450")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x20BAB70", Offset = "0x20B9F70", Length = "0xB2")]
	[Token(Token = "0x6001432")]
	internal void DisregardChild() { }

	[Address(RVA = "0x20BAD20", Offset = "0x20BA120", Length = "0xFA")]
	[Token(Token = "0x600143C")]
	internal ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection) { }

	[Address(RVA = "0x20BAC30", Offset = "0x20BA030", Length = "0xE8")]
	[Token(Token = "0x600143D")]
	private ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection) { }

	[Address(RVA = "0x20BB200", Offset = "0x20BA600", Length = "0x3A")]
	[Token(Token = "0x6001460")]
	private void Execute() { }

	[Address(RVA = "0x20BAE20", Offset = "0x20BA220", Length = "0x1B0")]
	[Token(Token = "0x6001462")]
	internal bool ExecuteEntry(bool bPreventDoubleExecution) { }

	[Address(RVA = "0x20BAFD0", Offset = "0x20BA3D0", Length = "0x225")]
	[Token(Token = "0x600149B")]
	private void ExecuteWithThreadLocal(ref Task currentTaskSlot) { }

	[Address(RVA = "0x20BB240", Offset = "0x20BA640", Length = "0x83")]
	[Token(Token = "0x6001463")]
	private static void ExecutionContextCallback(object obj) { }

	[Address(RVA = "0x20BBA60", Offset = "0x20BAE60", Length = "0x183")]
	[Token(Token = "0x600145B")]
	internal void Finish(bool bUserDelegateExecuted) { }

	[Address(RVA = "0x20BB2D0", Offset = "0x20BA6D0", Length = "0x593")]
	[Token(Token = "0x6001476")]
	internal void FinishContinuations() { }

	[Address(RVA = "0x20BB870", Offset = "0x20BAC70", Length = "0xA3")]
	[Token(Token = "0x600145D")]
	internal void FinishStageThree() { }

	[Address(RVA = "0x20BB920", Offset = "0x20BAD20", Length = "0x13F")]
	[Token(Token = "0x600145C")]
	internal void FinishStageTwo() { }

	[Address(RVA = "0x9410C0", Offset = "0x9404C0", Length = "0x139")]
	[Token(Token = "0x600148A")]
	public static Task<TResult> FromCanceled(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20BBBF0", Offset = "0x20BAFF0", Length = "0x49")]
	[Token(Token = "0x6001488")]
	public static Task FromCanceled(CancellationToken cancellationToken) { }

	[Address(RVA = "0x9416F0", Offset = "0x940AF0", Length = "0xCB")]
	[Token(Token = "0x600148B")]
	internal static Task<TResult> FromCancellation(OperationCanceledException exception) { }

	[Address(RVA = "0x941260", Offset = "0x940660", Length = "0xF8")]
	[Token(Token = "0x6001489")]
	internal static Task<TResult> FromCancellation(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20BBC40", Offset = "0x20BB040", Length = "0xE7")]
	[Token(Token = "0x6001487")]
	internal static Task FromCancellation(CancellationToken cancellationToken) { }

	[Address(RVA = "0x20BBD30", Offset = "0x20BB130", Length = "0x5A")]
	[Token(Token = "0x6001485")]
	public static Task FromException(Exception exception) { }

	[Address(RVA = "0x941A60", Offset = "0x940E60", Length = "0xC4")]
	[Token(Token = "0x6001486")]
	public static Task<TResult> FromException(Exception exception) { }

	[Address(RVA = "0x942040", Offset = "0x941440", Length = "0x6E")]
	[Token(Token = "0x6001484")]
	public static Task<TResult> FromResult(TResult result) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6001445")]
	public override object get_AsyncState() { }

	[Address(RVA = "0x20BFBC0", Offset = "0x20BEFC0", Length = "0x26")]
	[Token(Token = "0x600143E")]
	internal CancellationToken get_CancellationToken() { }

	[Address(RVA = "0x20BFBF0", Offset = "0x20BEFF0", Length = "0x74")]
	[Token(Token = "0x600144D")]
	internal ExecutionContext get_CapturedContext() { }

	[Address(RVA = "0x20BFC70", Offset = "0x20BF070", Length = "0x19E")]
	[Token(Token = "0x600144A")]
	internal ManualResetEventSlim get_CompletedEvent() { }

	[Address(RVA = "0x20BFE10", Offset = "0x20BF210", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x6001449")]
	public static Task get_CompletedTask() { }

	[Address(RVA = "0x20BFE60", Offset = "0x20BF260", Length = "0x4B")]
	[Token(Token = "0x6001443")]
	public TaskCreationOptions get_CreationOptions() { }

	[Address(RVA = "0x20BFEB0", Offset = "0x20BF2B0", Length = "0xBE")]
	[Token(Token = "0x6001437")]
	internal static StackGuard get_CurrentStackGuard() { }

	[Address(RVA = "0x20BFFE0", Offset = "0x20BF3E0", Length = "0x41")]
	[Token(Token = "0x6001438")]
	public AggregateException get_Exception() { }

	[Address(RVA = "0x20BFF70", Offset = "0x20BF370", Length = "0x60")]
	[Token(Token = "0x600144B")]
	internal bool get_ExceptionRecorded() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6001447")]
	internal TaskScheduler get_ExecutingTaskScheduler() { }

	[Address(RVA = "0x20C0030", Offset = "0x20BF430", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x6001448")]
	public static TaskFactory get_Factory() { }

	[Address(RVA = "0x20C0080", Offset = "0x20BF480", Length = "0x96")]
	[Token(Token = "0x6001434")]
	public int get_Id() { }

	[Address(RVA = "0x20C0120", Offset = "0x20BF520", Length = "0x49")]
	[Token(Token = "0x6001435")]
	internal static Task get_InternalCurrent() { }

	[Address(RVA = "0x20C0170", Offset = "0x20BF570", Length = "0x23")]
	[Token(Token = "0x600143A")]
	public bool get_IsCanceled() { }

	[Address(RVA = "0x20C01A0", Offset = "0x20BF5A0", Length = "0x1D")]
	[Token(Token = "0x600143F")]
	internal bool get_IsCancellationAcknowledged() { }

	[Address(RVA = "0x20C01C0", Offset = "0x20BF5C0", Length = "0x7F")]
	[Token(Token = "0x600143B")]
	internal bool get_IsCancellationRequested() { }

	[Address(RVA = "0x20C0270", Offset = "0x20BF670", Length = "0x51")]
	[Token(Token = "0x6001440")]
	public override bool get_IsCompleted() { }

	[Address(RVA = "0x20C0240", Offset = "0x20BF640", Length = "0x23")]
	[Token(Token = "0x6001442")]
	public bool get_IsCompletedSuccessfully() { }

	[Address(RVA = "0x20C02D0", Offset = "0x20BF6D0", Length = "0x1D")]
	[Token(Token = "0x600145A")]
	internal bool get_IsDelegateInvoked() { }

	[Address(RVA = "0x20C02F0", Offset = "0x20BF6F0", Length = "0x1D")]
	[Token(Token = "0x6001459")]
	internal bool get_IsExceptionObservedByParent() { }

	[Address(RVA = "0x20C0310", Offset = "0x20BF710", Length = "0x1D")]
	[Token(Token = "0x600144C")]
	public bool get_IsFaulted() { }

	[Address(RVA = "0x20C0360", Offset = "0x20BF760", Length = "0x1D")]
	[Token(Token = "0x600142E")]
	internal bool get_IsWaitNotificationEnabled() { }

	[Address(RVA = "0x20C0330", Offset = "0x20BF730", Length = "0x23")]
	[Token(Token = "0x600142C")]
	internal bool get_IsWaitNotificationEnabledOrNotRanToCompletion() { }

	[Address(RVA = "0x20C0380", Offset = "0x20BF780", Length = "0x4B")]
	[Token(Token = "0x6001426")]
	internal TaskCreationOptions get_Options() { }

	[Address(RVA = "0x20C0360", Offset = "0x20BF760", Length = "0x1D")]
	[Token(Token = "0x600142D")]
	internal override bool get_ShouldNotifyDebuggerOfWaitCompletion() { }

	[Address(RVA = "0x20C03D0", Offset = "0x20BF7D0", Length = "0x82")]
	[Token(Token = "0x6001439")]
	public TaskStatus get_Status() { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x6001466")]
	public TaskAwaiter GetAwaiter() { }

	[Address(RVA = "0x20BBD90", Offset = "0x20BB190", Length = "0x34")]
	[Token(Token = "0x6001456")]
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	[Address(RVA = "0x20BBDD0", Offset = "0x20BB1D0", Length = "0x218")]
	[Token(Token = "0x6001455")]
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	[Address(RVA = "0x20BBFF0", Offset = "0x20BB3F0", Length = "0x1F7")]
	[Token(Token = "0x6001454")]
	private AggregateException GetExceptions(bool includeTaskCanceledExceptions) { }

	[Address(RVA = "0x20BC1F0", Offset = "0x20BB5F0", Length = "0x10D")]
	[Token(Token = "0x6001465")]
	private void HandleException(Exception unhandledException) { }

	[Address(RVA = "0x20BC300", Offset = "0x20BB700", Length = "0x96")]
	[Token(Token = "0x6001464")]
	internal override void InnerInvoke() { }

	[Address(RVA = "0x20BC3A0", Offset = "0x20BB7A0", Length = "0x1CC")]
	[Token(Token = "0x6001470")]
	internal bool InternalCancel(bool bCancelNonExecutingOnly) { }

	[Address(RVA = "0x20BC570", Offset = "0x20BB970", Length = "0x8C")]
	[Token(Token = "0x6001436")]
	internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions) { }

	[Address(RVA = "0x20BC600", Offset = "0x20BBA00", Length = "0x193")]
	[Token(Token = "0x6001433")]
	internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions) { }

	[Address(RVA = "0x20BC7A0", Offset = "0x20BBBA0", Length = "0x4C3")]
	[Token(Token = "0x600146D")]
	internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20BCC70", Offset = "0x20BC070", Length = "0xA")]
	[Token(Token = "0x6001441")]
	private static bool IsCompletedMethod(int flags) { }

	[Address(RVA = "0x20BCC80", Offset = "0x20BC080", Length = "0x3A")]
	[Token(Token = "0x6001477")]
	private void LogFinishCompletionNotification() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600149A")]
	public override void MarkAborted(ThreadAbortException e) { }

	[Address(RVA = "0x20BCCC0", Offset = "0x20BC0C0", Length = "0x13")]
	[Token(Token = "0x6001430")]
	internal bool MarkStarted() { }

	[Address(RVA = "0x20BCD40", Offset = "0x20BC140", Length = "0x23")]
	[Token(Token = "0x600142F")]
	private void NotifyDebuggerOfWaitCompletion() { }

	[Address(RVA = "0x20BCCE0", Offset = "0x20BC0E0", Length = "0x5B")]
	[Token(Token = "0x600142B")]
	internal bool NotifyDebuggerOfWaitCompletionIfNecessary() { }

	[Address(RVA = "0x60A370", Offset = "0x609770", Length = "0x4")]
	[Token(Token = "0x6001427")]
	internal static TaskCreationOptions OptionsMethod(int flags) { }

	[Address(RVA = "0x20BCD70", Offset = "0x20BC170", Length = "0x1CF")]
	[Token(Token = "0x600145E")]
	internal void ProcessChildCompletion(Task childTask) { }

	[Address(RVA = "0x20BD090", Offset = "0x20BC490", Length = "0xB1")]
	[Token(Token = "0x6001471")]
	internal void RecordInternalCancellationRequest() { }

	[Address(RVA = "0x20BD000", Offset = "0x20BC400", Length = "0x89")]
	[Token(Token = "0x6001472")]
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord) { }

	[Address(RVA = "0x20BCF40", Offset = "0x20BC340", Length = "0xB6")]
	[Token(Token = "0x6001473")]
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException) { }

	[Address(RVA = "0x20BD150", Offset = "0x20BC550", Length = "0x269")]
	[Token(Token = "0x6001483")]
	internal void RemoveContinuation(object continuationObject) { }

	[Address(RVA = "0x20BD3C0", Offset = "0x20BC7C0", Length = "0x122")]
	[FriendAccessAllowed]
	[Token(Token = "0x6001499")]
	internal static void RemoveFromActiveTasks(int taskId) { }

	[Address(RVA = "0x20BD720", Offset = "0x20BCB20", Length = "0x233")]
	[Token(Token = "0x600148F")]
	public static Task Run(Func<Task> function, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20BD4F0", Offset = "0x20BC8F0", Length = "0x1D4")]
	[Token(Token = "0x600148C")]
	public static Task Run(Action action) { }

	[Address(RVA = "0x9427A0", Offset = "0x941BA0", Length = "0x289")]
	[Token(Token = "0x6001491")]
	public static Task<TResult> Run(Func<Task`1<TResult>> function, CancellationToken cancellationToken) { }

	[Address(RVA = "0x942590", Offset = "0x941990", Length = "0xC1")]
	[Token(Token = "0x600148D")]
	public static Task<TResult> Run(Func<TResult> function) { }

	[Address(RVA = "0x942730", Offset = "0x941B30", Length = "0x63")]
	[Token(Token = "0x6001490")]
	public static Task<TResult> Run(Func<Task`1<TResult>> function) { }

	[Address(RVA = "0x20BD6D0", Offset = "0x20BCAD0", Length = "0x4C")]
	[Token(Token = "0x600148E")]
	public static Task Run(Func<Task> function) { }

	[Address(RVA = "0x20BD960", Offset = "0x20BCD60", Length = "0x172")]
	[Token(Token = "0x6001451")]
	internal void ScheduleAndStart(bool needsProtection) { }

	[Address(RVA = "0x20C0460", Offset = "0x20BF860", Length = "0x8A")]
	[Token(Token = "0x600144E")]
	internal void set_CapturedContext(ExecutionContext value) { }

	[Address(RVA = "0x20BDAE0", Offset = "0x20BCEE0", Length = "0x2C")]
	[Token(Token = "0x6001475")]
	private void SetCancellationAcknowledged() { }

	[Address(RVA = "0x20BDB10", Offset = "0x20BCF10", Length = "0x1B6")]
	[Token(Token = "0x6001468")]
	internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext) { }

	[Address(RVA = "0x20BDCD0", Offset = "0x20BD0D0", Length = "0xD0")]
	[Token(Token = "0x600142A")]
	internal void SetNotificationForWaitCompletion(bool enabled) { }

	[Address(RVA = "0x20BDDA0", Offset = "0x20BD1A0", Length = "0x33E")]
	[Token(Token = "0x600146E")]
	private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20BE0E0", Offset = "0x20BD4E0", Length = "0x15E")]
	[Token(Token = "0x600146F")]
	private bool SpinWait(int millisecondsTimeout) { }

	[Address(RVA = "0x20BE240", Offset = "0x20BD640", Length = "0x210")]
	[Token(Token = "0x6001444")]
	private override WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6001446")]
	private override bool System.IAsyncResult.get_CompletedSynchronously() { }

	[Address(RVA = "0x20BE460", Offset = "0x20BD860", Length = "0xA")]
	[Token(Token = "0x6001461")]
	private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	[Address(RVA = "0x20BE470", Offset = "0x20BD870", Length = "0xE9")]
	[Token(Token = "0x6001422")]
	private static void TaskCancelCallback(object o) { }

	[Address(RVA = "0x20BE560", Offset = "0x20BD960", Length = "0x2D8")]
	[Token(Token = "0x6001420")]
	internal void TaskConstructorCore(Delegate action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	[Address(RVA = "0x20BE840", Offset = "0x20BDC40", Length = "0x49")]
	[Token(Token = "0x6001457")]
	internal void ThrowIfExceptional(bool includeTaskCanceledExceptions) { }

	[Address(RVA = "0x20BE8A0", Offset = "0x20BDCA0", Length = "0xE5")]
	[Token(Token = "0x6001424")]
	internal bool TrySetCanceled(CancellationToken tokenToRecord, object cancellationException) { }

	[Address(RVA = "0x20BE890", Offset = "0x20BDC90", Length = "0xB")]
	[Token(Token = "0x6001423")]
	internal bool TrySetCanceled(CancellationToken tokenToRecord) { }

	[Address(RVA = "0x20BE990", Offset = "0x20BDD90", Length = "0xF1")]
	[Token(Token = "0x6001425")]
	internal bool TrySetException(object exceptionObject) { }

	[Address(RVA = "0x20BEA90", Offset = "0x20BDE90", Length = "0x100")]
	[Token(Token = "0x6001458")]
	internal void UpdateExceptionObservedStatus() { }

	[Address(RVA = "0x20BEBA0", Offset = "0x20BDFA0", Length = "0xFD")]
	[Token(Token = "0x600146A")]
	public void Wait() { }

	[Address(RVA = "0x20BECA0", Offset = "0x20BE0A0", Length = "0x16A")]
	[Token(Token = "0x600146B")]
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20BF0E0", Offset = "0x20BE4E0", Length = "0x241")]
	[Token(Token = "0x6001496")]
	public static Task<Task> WhenAny(Task[] tasks) { }

	[Address(RVA = "0x20BEE10", Offset = "0x20BE210", Length = "0x2CC")]
	[Token(Token = "0x6001497")]
	public static Task<Task> WhenAny(IEnumerable<Task> tasks) { }

	[Address(RVA = "0x20BF330", Offset = "0x20BE730", Length = "0x9B")]
	[Token(Token = "0x600146C")]
	private bool WrappedTryRunInline() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6001469")]
	public static YieldAwaitable Yield() { }

}

