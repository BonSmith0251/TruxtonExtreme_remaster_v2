namespace UnityEngine.Events;

[Token(Token = "0x200023F")]
internal class InvokableCallList
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007A4")]
	private readonly List<BaseInvokableCall> m_PersistentCalls; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007A5")]
	private readonly List<BaseInvokableCall> m_RuntimeCalls; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007A6")]
	private List<BaseInvokableCall> m_ExecutingCalls; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007A7")]
	private bool m_NeedsUpdate; //Field offset: 0x28

	[Token(Token = "0x1700038D")]
	public int Count
	{
		[Address(RVA = "0x3079920", Offset = "0x3078D20", Length = "0x48")]
		[Token(Token = "0x60017EA")]
		 get { } //Length: 72
	}

	[Address(RVA = "0x3079840", Offset = "0x3078C40", Length = "0xD7")]
	[Token(Token = "0x60017F1")]
	public InvokableCallList() { }

	[Address(RVA = "0x3079230", Offset = "0x3078630", Length = "0xB3")]
	[Token(Token = "0x60017EC")]
	public void AddListener(BaseInvokableCall call) { }

	[Address(RVA = "0x30792F0", Offset = "0x30786F0", Length = "0xB3")]
	[Token(Token = "0x60017EB")]
	public void AddPersistentInvokableCall(BaseInvokableCall call) { }

	[Address(RVA = "0x3079470", Offset = "0x3078870", Length = "0xBF")]
	[Token(Token = "0x60017EE")]
	public void Clear() { }

	[Address(RVA = "0x30793B0", Offset = "0x30787B0", Length = "0xBF")]
	[Token(Token = "0x60017EF")]
	public void ClearPersistent() { }

	[Address(RVA = "0x3079920", Offset = "0x3078D20", Length = "0x48")]
	[Token(Token = "0x60017EA")]
	public int get_Count() { }

	[Address(RVA = "0x3079530", Offset = "0x3078930", Length = "0xA6")]
	[Token(Token = "0x60017F0")]
	public List<BaseInvokableCall> PrepareInvoke() { }

	[Address(RVA = "0x30795E0", Offset = "0x30789E0", Length = "0x252")]
	[Token(Token = "0x60017ED")]
	public void RemoveListener(object targetObj, MethodInfo method) { }

}

