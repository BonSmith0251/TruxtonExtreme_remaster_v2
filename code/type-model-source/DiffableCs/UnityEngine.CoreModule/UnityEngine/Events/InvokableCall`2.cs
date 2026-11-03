namespace UnityEngine.Events;

[Token(Token = "0x2000238")]
internal class InvokableCall : BaseInvokableCall
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000795")]
	private UnityAction<T1, T2> Delegate; //Field offset: 0x0

	[Token(Token = "0x1400000B")]
	protected event UnityAction<T1, T2> Delegate
	{
		[Address(RVA = "0xA9B690", Offset = "0xA9AA90", Length = "0xC0")]
		[CompilerGenerated]
		[Token(Token = "0x60017C9")]
		 add { } //Length: 192
		[Address(RVA = "0xA9B760", Offset = "0xA9AB60", Length = "0xC0")]
		[CompilerGenerated]
		[Token(Token = "0x60017CA")]
		 remove { } //Length: 192
	}

	[Address(RVA = "0xA9BE40", Offset = "0xA9B240", Length = "0x12A")]
	[Token(Token = "0x60017CB")]
	public InvokableCall`2(object target, MethodInfo theFunction) { }

	[Address(RVA = "0xA9BF70", Offset = "0xA9B370", Length = "0xE0")]
	[Token(Token = "0x60017CC")]
	public InvokableCall`2(UnityAction<T1, T2> action) { }

	[Address(RVA = "0xA9B690", Offset = "0xA9AA90", Length = "0xC0")]
	[CompilerGenerated]
	[Token(Token = "0x60017C9")]
	protected void add_Delegate(UnityAction<T1, T2> value) { }

	[Address(RVA = "0xA9A670", Offset = "0xA99A70", Length = "0x61")]
	[Token(Token = "0x60017CF")]
	public virtual bool Find(object targetObj, MethodInfo method) { }

	[Address(RVA = "0xA9BA80", Offset = "0xA9AE80", Length = "0x1C8")]
	[Token(Token = "0x60017CD")]
	public virtual void Invoke(Object[] args) { }

	[Address(RVA = "0xA9BDE0", Offset = "0xA9B1E0", Length = "0x59")]
	[Token(Token = "0x60017CE")]
	public void Invoke(T1 args0, T2 args1) { }

	[Address(RVA = "0xA9B760", Offset = "0xA9AB60", Length = "0xC0")]
	[CompilerGenerated]
	[Token(Token = "0x60017CA")]
	protected void remove_Delegate(UnityAction<T1, T2> value) { }

}

