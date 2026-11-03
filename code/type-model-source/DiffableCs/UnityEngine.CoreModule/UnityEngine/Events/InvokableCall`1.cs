namespace UnityEngine.Events;

[Token(Token = "0x2000237")]
internal class InvokableCall : BaseInvokableCall
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000794")]
	private UnityAction<T1> Delegate; //Field offset: 0x0

	[Token(Token = "0x1400000A")]
	protected event UnityAction<T1> Delegate
	{
		[Address(RVA = "0xA9B690", Offset = "0xA9AA90", Length = "0xC0")]
		[CompilerGenerated]
		[Token(Token = "0x60017C2")]
		 add { } //Length: 192
		[Address(RVA = "0xA9B760", Offset = "0xA9AB60", Length = "0xC0")]
		[CompilerGenerated]
		[Token(Token = "0x60017C3")]
		 remove { } //Length: 192
	}

	[Address(RVA = "0xA9B450", Offset = "0xA9A850", Length = "0xE3")]
	[Token(Token = "0x60017C4")]
	public InvokableCall`1(object target, MethodInfo theFunction) { }

	[Address(RVA = "0xA9B400", Offset = "0xA9A800", Length = "0x48")]
	[Token(Token = "0x60017C5")]
	public InvokableCall`1(UnityAction<T1> action) { }

	[Address(RVA = "0xA9B690", Offset = "0xA9AA90", Length = "0xC0")]
	[CompilerGenerated]
	[Token(Token = "0x60017C2")]
	protected void add_Delegate(UnityAction<T1> value) { }

	[Address(RVA = "0xA9A670", Offset = "0xA99A70", Length = "0x61")]
	[Token(Token = "0x60017C8")]
	public virtual bool Find(object targetObj, MethodInfo method) { }

	[Address(RVA = "0xA9AC80", Offset = "0xA9A080", Length = "0x125")]
	[Token(Token = "0x60017C6")]
	public virtual void Invoke(Object[] args) { }

	[Address(RVA = "0xA9A730", Offset = "0xA99B30", Length = "0x53")]
	[Token(Token = "0x60017C7")]
	public override void Invoke(T1 args0) { }

	[Address(RVA = "0xA9B760", Offset = "0xA9AB60", Length = "0xC0")]
	[CompilerGenerated]
	[Token(Token = "0x60017C3")]
	protected void remove_Delegate(UnityAction<T1> value) { }

}

