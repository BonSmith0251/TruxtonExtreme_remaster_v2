namespace UnityEngine.Events;

[Token(Token = "0x200024A")]
public class UnityEvent : UnityEventBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007B0")]
	private Object[] m_InvokeArray; //Field offset: 0x0

	[Address(RVA = "0x11A5250", Offset = "0x11A4650", Length = "0x5C")]
	[RequiredByNativeCode]
	[Token(Token = "0x600182A")]
	public UnityEvent`4() { }

	[Address(RVA = "0x11A5000", Offset = "0x11A4400", Length = "0x24B")]
	[Token(Token = "0x600182B")]
	protected virtual MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	[Address(RVA = "0x11A1D70", Offset = "0x11A1170", Length = "0x7E")]
	[Token(Token = "0x600182C")]
	internal virtual BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

}

