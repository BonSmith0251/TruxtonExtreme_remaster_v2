namespace UnityEngine.Events;

[Token(Token = "0x2000239")]
internal class InvokableCall : BaseInvokableCall
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000796")]
	private UnityAction<T1, T2, T3> Delegate; //Field offset: 0x0

	[Token(Token = "0x1400000C")]
	protected event UnityAction<T1, T2, T3> Delegate
	{
		[Address(RVA = "0xA9B690", Offset = "0xA9AA90", Length = "0xC0")]
		[CompilerGenerated]
		[Token(Token = "0x60017D0")]
		 add { } //Length: 192
		[Address(RVA = "0xA9B760", Offset = "0xA9AB60", Length = "0xC0")]
		[CompilerGenerated]
		[Token(Token = "0x60017D1")]
		 remove { } //Length: 192
	}

	[Address(RVA = "0xA9BE40", Offset = "0xA9B240", Length = "0x12A")]
	[Token(Token = "0x60017D2")]
	public InvokableCall`3(object target, MethodInfo theFunction) { }

	[Address(RVA = "0xA9BF70", Offset = "0xA9B370", Length = "0xE0")]
	[Token(Token = "0x60017D3")]
	public InvokableCall`3(UnityAction<T1, T2, T3> action) { }

	[Address(RVA = "0xA9B690", Offset = "0xA9AA90", Length = "0xC0")]
	[CompilerGenerated]
	[Token(Token = "0x60017D0")]
	protected void add_Delegate(UnityAction<T1, T2, T3> value) { }

	[Address(RVA = "0xA9A670", Offset = "0xA99A70", Length = "0x61")]
	[Token(Token = "0x60017D6")]
	public virtual bool Find(object targetObj, MethodInfo method) { }

	[Address(RVA = "0xA9C600", Offset = "0xA9BA00", Length = "0x245")]
	[Token(Token = "0x60017D4")]
	public virtual void Invoke(Object[] args) { }

	[Address(RVA = "0xA9C590", Offset = "0xA9B990", Length = "0x6F")]
	[Token(Token = "0x60017D5")]
	public void Invoke(T1 args0, T2 args1, T3 args2) { }

	[Address(RVA = "0xA9B760", Offset = "0xA9AB60", Length = "0xC0")]
	[CompilerGenerated]
	[Token(Token = "0x60017D1")]
	protected void remove_Delegate(UnityAction<T1, T2, T3> value) { }

}

