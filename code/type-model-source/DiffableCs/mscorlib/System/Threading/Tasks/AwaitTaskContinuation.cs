namespace System.Threading.Tasks;

[Token(Token = "0x2000281")]
internal class AwaitTaskContinuation : TaskContinuation, IThreadPoolWorkItem
{
	[Token(Token = "0x4000B31")]
	private static ContextCallback s_invokeActionCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B2F")]
	private readonly ExecutionContext m_capturedContext; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B30")]
	protected readonly Action m_action; //Field offset: 0x18

	[Token(Token = "0x170001F7")]
	internal static bool IsValidLocationForInlining
	{
		[Address(RVA = "0x20AD7C0", Offset = "0x20ACBC0", Length = "0x12C")]
		[Token(Token = "0x60014DA")]
		internal get { } //Length: 300
	}

	[Address(RVA = "0x20AD730", Offset = "0x20ACB30", Length = "0x90")]
	[Token(Token = "0x60014D7")]
	internal AwaitTaskContinuation(Action action, bool flowExecutionContext) { }

	[Address(RVA = "0x20AD0C0", Offset = "0x20AC4C0", Length = "0xDF")]
	[Token(Token = "0x60014D8")]
	protected Task CreateTask(Action<Object> action, object state, TaskScheduler scheduler) { }

	[Address(RVA = "0x20AD7C0", Offset = "0x20ACBC0", Length = "0x12C")]
	[Token(Token = "0x60014DA")]
	internal static bool get_IsValidLocationForInlining() { }

	[Address(RVA = "0x20AD1A0", Offset = "0x20AC5A0", Length = "0xAA")]
	[Token(Token = "0x60014DD")]
	protected static ContextCallback GetInvokeActionCallback() { }

	[Address(RVA = "0x20AD250", Offset = "0x20AC650", Length = "0x6A")]
	[Token(Token = "0x60014DC")]
	private static void InvokeAction(object state) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60014E2")]
	public override void MarkAborted(ThreadAbortException e) { }

	[Address(RVA = "0x20AD4F0", Offset = "0x20AC8F0", Length = "0xB2")]
	[Token(Token = "0x60014D9")]
	internal virtual void Run(Task ignored, bool canInlineContinuationTask) { }

	[Address(RVA = "0x20AD2C0", Offset = "0x20AC6C0", Length = "0x102")]
	[Token(Token = "0x60014DE")]
	protected void RunCallback(ContextCallback callback, object state, ref Task currentTask) { }

	[Address(RVA = "0x20AD3D0", Offset = "0x20AC7D0", Length = "0x118")]
	[Token(Token = "0x60014DF")]
	internal static void RunOrScheduleAction(Action action, bool allowInlining, ref Task currentTask) { }

	[Address(RVA = "0x20AD5B0", Offset = "0x20AC9B0", Length = "0x9F")]
	[Token(Token = "0x60014DB")]
	private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	[Address(RVA = "0x20AD650", Offset = "0x20ACA50", Length = "0x49")]
	[Token(Token = "0x60014E1")]
	protected static void ThrowAsyncIfNecessary(Exception exc) { }

	[Address(RVA = "0x20AD6A0", Offset = "0x20ACAA0", Length = "0x85")]
	[Token(Token = "0x60014E0")]
	internal static void UnsafeScheduleAction(Action action) { }

}

