namespace UnityEngine.Events;

[Token(Token = "0x2000236")]
internal class InvokableCall : BaseInvokableCall
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000793")]
	private UnityAction Delegate; //Field offset: 0x10

	[Token(Token = "0x14000009")]
	private event UnityAction Delegate
	{
		[Address(RVA = "0x3079C40", Offset = "0x3079040", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60017BB")]
		private add { } //Length: 158
		[Address(RVA = "0x3079CE0", Offset = "0x30790E0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60017BC")]
		private remove { } //Length: 158
	}

	[Address(RVA = "0x3079A50", Offset = "0x3078E50", Length = "0x1EF")]
	[Token(Token = "0x60017BD")]
	public InvokableCall(object target, MethodInfo theFunction) { }

	[Address(RVA = "0x3079A20", Offset = "0x3078E20", Length = "0x2F")]
	[Token(Token = "0x60017BE")]
	public InvokableCall(UnityAction action) { }

	[Address(RVA = "0x3079C40", Offset = "0x3079040", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60017BB")]
	private void add_Delegate(UnityAction value) { }

	[Address(RVA = "0xA9A670", Offset = "0xA99A70", Length = "0x61")]
	[Token(Token = "0x60017C1")]
	public virtual bool Find(object targetObj, MethodInfo method) { }

	[Address(RVA = "0x3079970", Offset = "0x3078D70", Length = "0xAC")]
	[Token(Token = "0x60017BF")]
	public virtual void Invoke(Object[] args) { }

	[Address(RVA = "0x3079970", Offset = "0x3078D70", Length = "0xAC")]
	[Token(Token = "0x60017C0")]
	public void Invoke() { }

	[Address(RVA = "0x3079CE0", Offset = "0x30790E0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60017BC")]
	private void remove_Delegate(UnityAction value) { }

}

