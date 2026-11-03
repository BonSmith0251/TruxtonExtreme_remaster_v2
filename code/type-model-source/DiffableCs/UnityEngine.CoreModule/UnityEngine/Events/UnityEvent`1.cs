namespace UnityEngine.Events;

[Token(Token = "0x2000244")]
public class UnityEvent : UnityEventBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007AD")]
	private Object[] m_InvokeArray; //Field offset: 0x0

	[Address(RVA = "0x11A1600", Offset = "0x11A0A00", Length = "0x5C")]
	[RequiredByNativeCode]
	[Token(Token = "0x600180F")]
	public UnityEvent`1() { }

	[Address(RVA = "0x119FC50", Offset = "0x119F050", Length = "0xBC")]
	[Token(Token = "0x6001810")]
	public void AddListener(UnityAction<T0> call) { }

	[Address(RVA = "0x11A0190", Offset = "0x119F590", Length = "0x113")]
	[Token(Token = "0x6001812")]
	protected virtual MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	[Address(RVA = "0x11A03D0", Offset = "0x119F7D0", Length = "0x7D")]
	[Token(Token = "0x6001813")]
	internal virtual BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	[Address(RVA = "0x11A0450", Offset = "0x119F850", Length = "0x8F")]
	[Token(Token = "0x6001814")]
	private static BaseInvokableCall GetDelegate(UnityAction<T0> action) { }

	[Address(RVA = "0x11A0760", Offset = "0x119FB60", Length = "0x284")]
	[Token(Token = "0x6001815")]
	public void Invoke(T0 arg0) { }

	[Address(RVA = "0x11A13D0", Offset = "0x11A07D0", Length = "0x48")]
	[Token(Token = "0x6001811")]
	public void RemoveListener(UnityAction<T0> call) { }

}

