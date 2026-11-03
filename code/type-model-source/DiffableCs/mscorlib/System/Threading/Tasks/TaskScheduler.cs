namespace System.Threading.Tasks;

[DebuggerDisplay("Id={Id}")]
[DebuggerTypeProxy(typeof(SystemThreadingTasks_TaskSchedulerDebugView))]
[Token(Token = "0x2000285")]
public abstract class TaskScheduler
{
	[Token(Token = "0x2000286")]
	public sealed class SystemThreadingTasks_TaskSchedulerDebugView
	{

	}

	[Token(Token = "0x4000B3C")]
	private static readonly TaskScheduler s_defaultTaskScheduler; //Field offset: 0x0
	[Token(Token = "0x4000B3D")]
	internal static int s_taskSchedulerIdCounter; //Field offset: 0x8
	[Token(Token = "0x4000B3F")]
	private static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException; //Field offset: 0x10
	[Token(Token = "0x4000B40")]
	private static readonly Lock _unobservedTaskExceptionLockObject; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B3E")]
	private int m_taskSchedulerId; //Field offset: 0x10

	[Token(Token = "0x170001FC")]
	public static TaskScheduler Current
	{
		[Address(RVA = "0x20B7BE0", Offset = "0x20B6FE0", Length = "0x9C")]
		[Token(Token = "0x6001509")]
		 get { } //Length: 156
	}

	[Token(Token = "0x170001FB")]
	public static TaskScheduler Default
	{
		[Address(RVA = "0x20B7C80", Offset = "0x20B7080", Length = "0x4E")]
		[Token(Token = "0x6001508")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170001FE")]
	public int Id
	{
		[Address(RVA = "0x20B7CD0", Offset = "0x20B70D0", Length = "0x9D")]
		[Token(Token = "0x600150C")]
		 get { } //Length: 157
	}

	[Token(Token = "0x170001FD")]
	internal static TaskScheduler InternalCurrent
	{
		[Address(RVA = "0x20B7D70", Offset = "0x20B7170", Length = "0xD7")]
		[Token(Token = "0x600150A")]
		internal get { } //Length: 215
	}

	[Token(Token = "0x170001FA")]
	internal override bool RequiresAtomicStartTransition
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001506")]
		internal get { } //Length: 3
	}

	[Address(RVA = "0x20B7AE0", Offset = "0x20B6EE0", Length = "0xF5")]
	[Token(Token = "0x600150F")]
	private static TaskScheduler() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001507")]
	protected TaskScheduler() { }

	[Address(RVA = "0x20B7550", Offset = "0x20B6950", Length = "0xD9")]
	[Token(Token = "0x600150B")]
	public static TaskScheduler FromCurrentSynchronizationContext() { }

	[Address(RVA = "0x20B7BE0", Offset = "0x20B6FE0", Length = "0x9C")]
	[Token(Token = "0x6001509")]
	public static TaskScheduler get_Current() { }

	[Address(RVA = "0x20B7C80", Offset = "0x20B7080", Length = "0x4E")]
	[Token(Token = "0x6001508")]
	public static TaskScheduler get_Default() { }

	[Address(RVA = "0x20B7CD0", Offset = "0x20B70D0", Length = "0x9D")]
	[Token(Token = "0x600150C")]
	public int get_Id() { }

	[Address(RVA = "0x20B7D70", Offset = "0x20B7170", Length = "0xD7")]
	[Token(Token = "0x600150A")]
	internal static TaskScheduler get_InternalCurrent() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6001506")]
	internal override bool get_RequiresAtomicStartTransition() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001505")]
	internal override void NotifyWorkItemProgress() { }

	[Address(RVA = "0x20B7630", Offset = "0x20B6A30", Length = "0x147")]
	[Token(Token = "0x600150E")]
	internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea) { }

	[Token(Token = "0x6001501")]
	protected private abstract void QueueTask(Task task) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6001504")]
	protected private override bool TryDequeue(Task task) { }

	[Address(RVA = "0x20B7780", Offset = "0x20B6B80", Length = "0x7B")]
	[Token(Token = "0x600150D")]
	protected bool TryExecuteTask(Task task) { }

	[Token(Token = "0x6001502")]
	protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

	[Address(RVA = "0x20B7800", Offset = "0x20B6C00", Length = "0x2D5")]
	[Token(Token = "0x6001503")]
	internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued) { }

}

