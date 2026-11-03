namespace UnityEngine.Events;

[Token(Token = "0x2000242")]
public class UnityEvent : UnityEventBase
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007AC")]
	private Object[] m_InvokeArray; //Field offset: 0x28

	[Address(RVA = "0x3097330", Offset = "0x3096730", Length = "0x1F9")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001806")]
	public UnityEvent() { }

	[Address(RVA = "0x3096E10", Offset = "0x3096210", Length = "0x100")]
	[Token(Token = "0x6001807")]
	public void AddListener(UnityAction call) { }

	[Address(RVA = "0x3096F20", Offset = "0x3096320", Length = "0x83")]
	[Token(Token = "0x6001809")]
	protected virtual MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	[Address(RVA = "0x3096FB0", Offset = "0x30963B0", Length = "0x64")]
	[Token(Token = "0x600180A")]
	internal virtual BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	[Address(RVA = "0x3097020", Offset = "0x3096420", Length = "0x5E")]
	[Token(Token = "0x600180B")]
	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	[Address(RVA = "0x3097080", Offset = "0x3096480", Length = "0x25B")]
	[Token(Token = "0x600180C")]
	public void Invoke() { }

	[Address(RVA = "0x30972E0", Offset = "0x30966E0", Length = "0x49")]
	[Token(Token = "0x6001808")]
	public void RemoveListener(UnityAction call) { }

}

