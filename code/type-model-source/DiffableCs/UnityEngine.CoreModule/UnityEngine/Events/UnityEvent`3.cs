namespace UnityEngine.Events;

[Token(Token = "0x2000248")]
public class UnityEvent : UnityEventBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007AF")]
	private Object[] m_InvokeArray; //Field offset: 0x0

	[Address(RVA = "0x11A4FA0", Offset = "0x11A43A0", Length = "0x5C")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001821")]
	public UnityEvent`3() { }

	[Address(RVA = "0x11A3F00", Offset = "0x11A3300", Length = "0xBC")]
	[Token(Token = "0x6001822")]
	public void AddListener(UnityAction<T0, T1, T2> call) { }

	[Address(RVA = "0x11A41B0", Offset = "0x11A35B0", Length = "0x1EB")]
	[Token(Token = "0x6001824")]
	protected virtual MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	[Address(RVA = "0x11A43A0", Offset = "0x11A37A0", Length = "0x7D")]
	[Token(Token = "0x6001825")]
	internal virtual BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	[Address(RVA = "0x11A4420", Offset = "0x11A3820", Length = "0x8F")]
	[Token(Token = "0x6001826")]
	private static BaseInvokableCall GetDelegate(UnityAction<T0, T1, T2> action) { }

	[Address(RVA = "0x11A45F0", Offset = "0x11A39F0", Length = "0x37F")]
	[Token(Token = "0x6001827")]
	public void Invoke(T0 arg0, T1 arg1, T2 arg2) { }

	[Address(RVA = "0x11A13D0", Offset = "0x11A07D0", Length = "0x48")]
	[Token(Token = "0x6001823")]
	public void RemoveListener(UnityAction<T0, T1, T2> call) { }

}

