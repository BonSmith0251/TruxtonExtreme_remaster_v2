namespace UnityEngine.Events;

[Token(Token = "0x200023A")]
internal class InvokableCall : BaseInvokableCall
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000797")]
	private UnityAction<T1, T2, T3, T4> Delegate; //Field offset: 0x0

	[Address(RVA = "0xA9CC10", Offset = "0xA9C010", Length = "0x129")]
	[Token(Token = "0x60017D7")]
	public InvokableCall`4(object target, MethodInfo theFunction) { }

	[Address(RVA = "0xA9A670", Offset = "0xA99A70", Length = "0x61")]
	[Token(Token = "0x60017D9")]
	public virtual bool Find(object targetObj, MethodInfo method) { }

	[Address(RVA = "0xA9C850", Offset = "0xA9BC50", Length = "0x3B6")]
	[Token(Token = "0x60017D8")]
	public virtual void Invoke(Object[] args) { }

}

