namespace System.Net;

[Token(Token = "0x20002B4")]
internal class ServicePointScheduler
{
	[CompilerGenerated]
	[Token(Token = "0x20002B8")]
	private struct <RunScheduler>d__32 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B77")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000B78")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B79")]
		public ServicePointScheduler <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000B7A")]
		private ValueTuple<ConnectionGroup, WebOperation>[] <operationArray>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000B7B")]
		private ValueTuple<ConnectionGroup, WebConnection, Task>[] <idleArray>5__3; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000B7C")]
		private List<Task> <taskList>5__4; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000B7D")]
		private Task<Boolean> <schedulerTask>5__5; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000B7E")]
		private bool <finalCleanup>5__6; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000B7F")]
		private ConfiguredTaskAwaiter<Task> <>u__1; //Field offset: 0x50

		[Address(RVA = "0x25D2F60", Offset = "0x25D2360", Length = "0x1066")]
		[Token(Token = "0x6001260")]
		private override void MoveNext() { }

		[Address(RVA = "0x25D3FD0", Offset = "0x25D33D0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6001261")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002B9")]
	private struct <WaitAsync>d__46 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B80")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000B81")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B82")]
		public int millisecondTimeout; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000B83")]
		public Task workerTask; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000B84")]
		private CancellationTokenSource <cts>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000B85")]
		private Task <timeoutTask>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000B86")]
		private ConfiguredTaskAwaiter<Task> <>u__1; //Field offset: 0x40

		[Address(RVA = "0x25D55C0", Offset = "0x25D49C0", Length = "0x530")]
		[Token(Token = "0x6001262")]
		private override void MoveNext() { }

		[Address(RVA = "0x25D5B00", Offset = "0x25D4F00", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6001263")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x20002B6")]
	private class AsyncManualResetEvent
	{
		[CompilerGenerated]
		[Token(Token = "0x20002B7")]
		private sealed class <>c
		{
			[Token(Token = "0x4000B75")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000B76")]
			public static Func<Object, Boolean> <>9__4_0; //Field offset: 0x8

			[Address(RVA = "0x25D5550", Offset = "0x25D4950", Length = "0x67")]
			[Token(Token = "0x600125D")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600125E")]
			public <>c() { }

			[Address(RVA = "0x25D5450", Offset = "0x25D4850", Length = "0x85")]
			[Token(Token = "0x600125F")]
			internal bool <Set>b__4_0(object s) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000B74")]
		private TaskCompletionSource<Boolean> m_tcs; //Field offset: 0x10

		[Address(RVA = "0x25C6140", Offset = "0x25C5540", Length = "0x99")]
		[Token(Token = "0x600125C")]
		public AsyncManualResetEvent(bool state) { }

		[Address(RVA = "0x25C5CC0", Offset = "0x25C50C0", Length = "0xB4")]
		[Token(Token = "0x600125B")]
		public void Reset() { }

		[Address(RVA = "0x25C5D80", Offset = "0x25C5180", Length = "0x255")]
		[Token(Token = "0x600125A")]
		public void Set() { }

		[Address(RVA = "0x25C5FE0", Offset = "0x25C53E0", Length = "0x153")]
		[Token(Token = "0x6001259")]
		public Task<Boolean> WaitAsync(int millisecondTimeout) { }

	}

	[Token(Token = "0x20002B5")]
	private class ConnectionGroup
	{
		[Token(Token = "0x4000B70")]
		private static int nextId; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000B6E")]
		private readonly ServicePointScheduler <Scheduler>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000B6F")]
		private readonly string <Name>k__BackingField; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B71")]
		public readonly int ID; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000B72")]
		private LinkedList<WebConnection> connections; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000B73")]
		private LinkedList<WebOperation> queue; //Field offset: 0x30

		[Token(Token = "0x170003F5")]
		public ServicePointScheduler Scheduler
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001250")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x25C6EF0", Offset = "0x25C62F0", Length = "0x110")]
		[Token(Token = "0x6001251")]
		public ConnectionGroup(ServicePointScheduler scheduler, string name) { }

		[Address(RVA = "0x25C6690", Offset = "0x25C5A90", Length = "0xED")]
		[Token(Token = "0x6001254")]
		public void Cleanup() { }

		[Address(RVA = "0x25C6780", Offset = "0x25C5B80", Length = "0x1CB")]
		[Token(Token = "0x6001258")]
		public ValueTuple<WebConnection, Boolean> CreateOrReuseConnection(WebOperation operation, bool force) { }

		[Address(RVA = "0x25C6950", Offset = "0x25C5D50", Length = "0x53")]
		[Token(Token = "0x6001255")]
		public void EnqueueOperation(WebOperation operation) { }

		[Address(RVA = "0x25C69B0", Offset = "0x25C5DB0", Length = "0x30D")]
		[Token(Token = "0x6001257")]
		public WebConnection FindIdleConnection(WebOperation operation) { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001250")]
		public ServicePointScheduler get_Scheduler() { }

		[Address(RVA = "0x25C6CC0", Offset = "0x25C60C0", Length = "0x11A")]
		[Token(Token = "0x6001256")]
		public WebOperation GetNextOperation() { }

		[Address(RVA = "0x25C6DE0", Offset = "0x25C61E0", Length = "0x63")]
		[Token(Token = "0x6001252")]
		public bool IsEmpty() { }

		[Address(RVA = "0x25C6E50", Offset = "0x25C6250", Length = "0x9F")]
		[Token(Token = "0x6001253")]
		public void RemoveConnection(WebConnection connection) { }

	}

	[Token(Token = "0x4000B6B")]
	private static int nextId; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B60")]
	private ServicePoint <ServicePoint>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B61")]
	private int running; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000B62")]
	private int maxIdleTime; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B63")]
	private AsyncManualResetEvent schedulerEvent; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B64")]
	private ConnectionGroup defaultGroup; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B65")]
	private Dictionary<String, ConnectionGroup> groups; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B66")]
	private LinkedList<ValueTuple`2<ConnectionGroup, WebOperation>> operations; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B67")]
	private LinkedList<ValueTuple`3<ConnectionGroup, WebConnection, Task>> idleConnections; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B68")]
	private int currentConnections; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000B69")]
	private int connectionLimit; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B6A")]
	private DateTime idleSince; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B6C")]
	public readonly int ID; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000B6D")]
	private readonly string <ME>k__BackingField; //Field offset: 0x60

	[Token(Token = "0x170003F4")]
	public int MaxIdleTime
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x600123E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170003F3")]
	private ServicePoint ServicePoint
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600123C")]
		private get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600123D")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x25CB590", Offset = "0x25CA990", Length = "0x224")]
	[Token(Token = "0x600123F")]
	public ServicePointScheduler(ServicePoint servicePoint, int connectionLimit, int maxIdleTime) { }

	[Address(RVA = "0x25CAF10", Offset = "0x25CA310", Length = "0xE0")]
	[CompilerGenerated]
	[Token(Token = "0x600124F")]
	private Task <Run>b__31_0() { }

	[Address(RVA = "0x25CA2F0", Offset = "0x25C96F0", Length = "0x1CF")]
	[Token(Token = "0x6001242")]
	private void Cleanup() { }

	[Address(RVA = "0x25CA4C0", Offset = "0x25C98C0", Length = "0x43")]
	[Token(Token = "0x6001245")]
	private void CloseIdleConnection(ConnectionGroup group, WebConnection connection) { }

	[Address(RVA = "0x25CA510", Offset = "0x25C9910", Length = "0x13E")]
	[Token(Token = "0x6001249")]
	private void FinalCleanup() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x600123E")]
	public int get_MaxIdleTime() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600123C")]
	private ServicePoint get_ServicePoint() { }

	[Address(RVA = "0x25CA650", Offset = "0x25C9A50", Length = "0x1F7")]
	[Token(Token = "0x600124B")]
	private ConnectionGroup GetConnectionGroup(string name) { }

	[Address(RVA = "0x25CA850", Offset = "0x25C9C50", Length = "0x21")]
	[Token(Token = "0x600124D")]
	private void OnConnectionClosed(WebConnection connection) { }

	[Address(RVA = "0x25CA880", Offset = "0x25C9C80", Length = "0xB")]
	[Token(Token = "0x600124C")]
	private void OnConnectionCreated(WebConnection connection) { }

	[Address(RVA = "0x25CA890", Offset = "0x25C9C90", Length = "0x287")]
	[Token(Token = "0x6001244")]
	private bool OperationCompleted(ConnectionGroup group, WebOperation operation) { }

	[Address(RVA = "0x25CAB20", Offset = "0x25C9F20", Length = "0xC2")]
	[Token(Token = "0x6001248")]
	private void RemoveIdleConnection(WebConnection connection) { }

	[Address(RVA = "0x25CABF0", Offset = "0x25C9FF0", Length = "0xC2")]
	[Token(Token = "0x6001247")]
	private void RemoveOperation(WebOperation operation) { }

	[Address(RVA = "0x25CAFF0", Offset = "0x25CA3F0", Length = "0xC3")]
	[Token(Token = "0x6001240")]
	public void Run() { }

	[Address(RVA = "0x25CAF10", Offset = "0x25CA310", Length = "0xE0")]
	[AsyncStateMachine(typeof(<RunScheduler>d__32))]
	[Token(Token = "0x6001241")]
	private Task RunScheduler() { }

	[Address(RVA = "0x25CACC0", Offset = "0x25CA0C0", Length = "0x243")]
	[Token(Token = "0x6001243")]
	private void RunSchedulerIteration() { }

	[Address(RVA = "0x25CB0C0", Offset = "0x25CA4C0", Length = "0x202")]
	[Token(Token = "0x6001246")]
	private bool SchedulerIteration(ConnectionGroup group) { }

	[Address(RVA = "0x25CB2D0", Offset = "0x25CA6D0", Length = "0x198")]
	[Token(Token = "0x600124A")]
	public void SendRequest(WebOperation operation, string groupName) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600123D")]
	private void set_ServicePoint(ServicePoint value) { }

	[Address(RVA = "0x25CB470", Offset = "0x25CA870", Length = "0x11C")]
	[AsyncStateMachine(typeof(<WaitAsync>d__46))]
	[Token(Token = "0x600124E")]
	public static Task<Boolean> WaitAsync(Task workerTask, int millisecondTimeout) { }

}

