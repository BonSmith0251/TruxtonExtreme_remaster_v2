namespace Mono.Net.Security;

[Token(Token = "0x200004A")]
internal abstract class AsyncProtocolRequest
{
	[CompilerGenerated]
	[Token(Token = "0x200004D")]
	private struct <InnerRead>d__25 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000BB")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000BC")]
		public AsyncTaskMethodBuilder<Nullable`1<Int32>> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000BD")]
		public AsyncProtocolRequest <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000BE")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000BF")]
		private Nullable<Int32> <totalRead>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000C0")]
		private int <requestedSize>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000C1")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x40

		[Address(RVA = "0x22CBB70", Offset = "0x22CAF70", Length = "0x45F")]
		[Token(Token = "0x60000C8")]
		private override void MoveNext() { }

		[Address(RVA = "0x22CBFE0", Offset = "0x22CB3E0", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x60000C9")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004C")]
	private struct <ProcessOperation>d__24 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B3")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000B4")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000B5")]
		public CancellationToken cancellationToken; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000B6")]
		public AsyncProtocolRequest <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000B7")]
		private AsyncOperationStatus <status>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40000B8")]
		private AsyncOperationStatus <newStatus>5__3; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000B9")]
		private ConfiguredTaskAwaiter<Nullable<Int32>> <>u__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40000BA")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x48

		[Address(RVA = "0x22CD1A0", Offset = "0x22CC5A0", Length = "0x67E")]
		[Token(Token = "0x60000C6")]
		private override void MoveNext() { }

		[Address(RVA = "0x22CD820", Offset = "0x22CCC20", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x60000C7")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200004B")]
	private struct <StartOperation>d__23 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AE")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<AsyncProtocolResult> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000B0")]
		public AsyncProtocolRequest <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000B1")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000B2")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x22CD880", Offset = "0x22CCC80", Length = "0x3D7")]
		[Token(Token = "0x60000C4")]
		private override void MoveNext() { }

		[Address(RVA = "0x22CDC60", Offset = "0x22CD060", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x60000C5")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x40000AD")]
	private static int next_id; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000A6")]
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000A7")]
	private readonly bool <RunSynchronously>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000A8")]
	private int <UserResult>k__BackingField; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000A9")]
	private int Started; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40000AA")]
	private int RequestedSize; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000AB")]
	private int WriteRequested; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000AC")]
	private readonly object locker; //Field offset: 0x30

	[Token(Token = "0x1700001E")]
	public string Name
	{
		[Address(RVA = "0x22BAAA0", Offset = "0x22B9EA0", Length = "0x30")]
		[Token(Token = "0x60000B9")]
		 get { } //Length: 48
	}

	[Token(Token = "0x1700001C")]
	public MobileAuthenticatedStream Parent
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60000B7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700001D")]
	public bool RunSynchronously
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60000B8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700001F")]
	public int UserResult
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60000BA")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60000BB")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x22BAA00", Offset = "0x22B9E00", Length = "0x96")]
	[Token(Token = "0x60000BC")]
	public AsyncProtocolRequest(MobileAuthenticatedStream parent, bool sync) { }

	[Address(RVA = "0x22BAAA0", Offset = "0x22B9EA0", Length = "0x30")]
	[Token(Token = "0x60000B9")]
	public string get_Name() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60000B7")]
	public MobileAuthenticatedStream get_Parent() { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60000B8")]
	public bool get_RunSynchronously() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000BA")]
	public int get_UserResult() { }

	[Address(RVA = "0x22BA580", Offset = "0x22B9980", Length = "0x12A")]
	[AsyncStateMachine(typeof(<InnerRead>d__25))]
	[Token(Token = "0x60000C1")]
	private Task<Nullable`1<Int32>> InnerRead(CancellationToken cancellationToken) { }

	[Address(RVA = "0x22BA6B0", Offset = "0x22B9AB0", Length = "0x102")]
	[AsyncStateMachine(typeof(<ProcessOperation>d__24))]
	[Token(Token = "0x60000C0")]
	private Task ProcessOperation(CancellationToken cancellationToken) { }

	[Address(RVA = "0x22BA7C0", Offset = "0x22B9BC0", Length = "0x8B")]
	[Token(Token = "0x60000BD")]
	internal void RequestRead(int size) { }

	[Address(RVA = "0x22BA850", Offset = "0x22B9C50", Length = "0x8")]
	[Token(Token = "0x60000BE")]
	internal void RequestWrite() { }

	[Token(Token = "0x60000C2")]
	protected abstract AsyncOperationStatus Run(AsyncOperationStatus status) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000BB")]
	protected void set_UserResult(int value) { }

	[Address(RVA = "0x22BA860", Offset = "0x22B9C60", Length = "0x121")]
	[AsyncStateMachine(typeof(<StartOperation>d__23))]
	[Token(Token = "0x60000BF")]
	internal Task<AsyncProtocolResult> StartOperation(CancellationToken cancellationToken) { }

	[Address(RVA = "0x22BA990", Offset = "0x22B9D90", Length = "0x67")]
	[Token(Token = "0x60000C3")]
	public virtual string ToString() { }

}

