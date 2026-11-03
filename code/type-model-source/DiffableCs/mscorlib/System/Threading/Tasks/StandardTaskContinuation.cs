namespace System.Threading.Tasks;

[Token(Token = "0x200027C")]
internal class StandardTaskContinuation : TaskContinuation
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B25")]
	internal readonly Task m_task; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B26")]
	internal readonly TaskContinuationOptions m_options; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B27")]
	private readonly TaskScheduler m_taskScheduler; //Field offset: 0x20

	[Address(RVA = "0x20B4F40", Offset = "0x20B4340", Length = "0xC1")]
	[Token(Token = "0x60014C8")]
	internal StandardTaskContinuation(Task task, TaskContinuationOptions options, TaskScheduler scheduler) { }

	[Address(RVA = "0x20B4E00", Offset = "0x20B4200", Length = "0x13B")]
	[Token(Token = "0x60014C9")]
	internal virtual void Run(Task completedTask, bool bCanInlineContinuationTask) { }

}

