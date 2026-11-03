namespace UnityEngine.Events;

[Token(Token = "0x2000246")]
public class UnityEvent : UnityEventBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007AE")]
	private Object[] m_InvokeArray; //Field offset: 0x0

	[Address(RVA = "0x11A3EA0", Offset = "0x11A32A0", Length = "0x5C")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001818")]
	public UnityEvent`2() { }

	[Address(RVA = "0x11A30F0", Offset = "0x11A24F0", Length = "0xBC")]
	[Token(Token = "0x6001819")]
	public void AddListener(UnityAction<T0, T1> call) { }

	[Address(RVA = "0x11A31B0", Offset = "0x11A25B0", Length = "0x183")]
	[Token(Token = "0x600181B")]
	protected virtual MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	[Address(RVA = "0x11A35E0", Offset = "0x11A29E0", Length = "0x7D")]
	[Token(Token = "0x600181C")]
	internal virtual BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	[Address(RVA = "0x11A34D0", Offset = "0x11A28D0", Length = "0x8F")]
	[Token(Token = "0x600181D")]
	private static BaseInvokableCall GetDelegate(UnityAction<T0, T1> action) { }

	[Address(RVA = "0x11A3B90", Offset = "0x11A2F90", Length = "0x2A1")]
	[Token(Token = "0x600181E")]
	public void Invoke(T0 arg0, T1 arg1) { }

	[Address(RVA = "0x11A13D0", Offset = "0x11A07D0", Length = "0x48")]
	[Token(Token = "0x600181A")]
	public void RemoveListener(UnityAction<T0, T1> call) { }

}

