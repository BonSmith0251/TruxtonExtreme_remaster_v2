namespace System.Threading.Tasks;

[Token(Token = "0x200027A")]
internal sealed class ContinuationResultTaskFromResultTask : Task<TResult>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B24")]
	private Task<TAntecedentResult> m_antecedent; //Field offset: 0x0

	[Address(RVA = "0x17C6EB0", Offset = "0x17C62B0", Length = "0xD8")]
	[Token(Token = "0x60014C3")]
	public ContinuationResultTaskFromResultTask`2(Task<TAntecedentResult> antecedent, Delegate function, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }

	[Address(RVA = "0x17C69D0", Offset = "0x17C5DD0", Length = "0xF6")]
	[Token(Token = "0x60014C4")]
	internal virtual void InnerInvoke() { }

}

