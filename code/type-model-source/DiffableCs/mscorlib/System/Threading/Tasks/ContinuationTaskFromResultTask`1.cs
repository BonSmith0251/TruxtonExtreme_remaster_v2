namespace System.Threading.Tasks;

[Token(Token = "0x2000279")]
internal sealed class ContinuationTaskFromResultTask : Task
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B23")]
	private Task<TAntecedentResult> m_antecedent; //Field offset: 0x0

	[Address(RVA = "0x17C8200", Offset = "0x17C7600", Length = "0xC2")]
	[Token(Token = "0x60014C1")]
	public ContinuationTaskFromResultTask`1(Task<TAntecedentResult> antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }

	[Address(RVA = "0x17C6F90", Offset = "0x17C6390", Length = "0xF2")]
	[Token(Token = "0x60014C2")]
	internal virtual void InnerInvoke() { }

}

