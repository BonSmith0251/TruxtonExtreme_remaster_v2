namespace System.Threading.Tasks;

[Token(Token = "0x200027B")]
internal abstract class TaskContinuation
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60014C7")]
	protected TaskContinuation() { }

	[Address(RVA = "0x20B5810", Offset = "0x20B4C10", Length = "0xF6")]
	[Token(Token = "0x60014C6")]
	protected static void InlineIfPossibleOrElseQueue(Task task, bool needsProtection) { }

	[Token(Token = "0x60014C5")]
	internal abstract void Run(Task completedTask, bool bCanInlineContinuationTask) { }

}

