namespace System.Threading.Tasks;

[Token(Token = "0x200026E")]
internal sealed class CompletionActionInvoker : IThreadPoolWorkItem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000AFB")]
	private readonly ITaskCompletionAction m_action; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000AFC")]
	private readonly Task m_completingTask; //Field offset: 0x18

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x60014AC")]
	internal CompletionActionInvoker(ITaskCompletionAction action, Task completingTask) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60014AE")]
	public override void MarkAborted(ThreadAbortException e) { }

	[Address(RVA = "0x20ADB70", Offset = "0x20ACF70", Length = "0x4A")]
	[Token(Token = "0x60014AD")]
	private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

}

