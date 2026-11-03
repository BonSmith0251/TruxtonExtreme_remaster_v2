namespace System.Threading.Tasks;

[Token(Token = "0x2000278")]
internal sealed class ContinuationTaskFromTask : Task
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B22")]
	private Task m_antecedent; //Field offset: 0x50

	[Address(RVA = "0x20ADDE0", Offset = "0x20AD1E0", Length = "0x127")]
	[Token(Token = "0x60014BF")]
	public ContinuationTaskFromTask(Task antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }

	[Address(RVA = "0x20ADCD0", Offset = "0x20AD0D0", Length = "0x102")]
	[Token(Token = "0x60014C0")]
	internal virtual void InnerInvoke() { }

}

