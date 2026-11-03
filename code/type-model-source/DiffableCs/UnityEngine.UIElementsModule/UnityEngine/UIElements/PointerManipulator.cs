namespace UnityEngine.UIElements;

[Token(Token = "0x20002C8")]
public abstract class PointerManipulator : MouseManipulator
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B42")]
	private int m_CurrentPointerId; //Field offset: 0x20

	[Address(RVA = "0x3406CD0", Offset = "0x34060D0", Length = "0x77")]
	[Token(Token = "0x6001368")]
	protected PointerManipulator() { }

	[Address(RVA = "0x340B4E0", Offset = "0x340A8E0", Length = "0x1EE")]
	[Token(Token = "0x6001366")]
	protected bool CanStartManipulation(IPointerEvent e) { }

	[Address(RVA = "0x340B6D0", Offset = "0x340AAD0", Length = "0x60")]
	[Token(Token = "0x6001367")]
	protected bool CanStopManipulation(IPointerEvent e) { }

}

