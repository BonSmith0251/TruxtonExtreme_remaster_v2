namespace UnityEngine.InputSystem.Controls;

[InputControlLayout(hideInUI = True)]
[Token(Token = "0x200022B")]
public class TouchPressControl : ButtonControl
{

	[Address(RVA = "0x290E9C0", Offset = "0x290DDC0", Length = "0x7")]
	[Token(Token = "0x6001470")]
	public TouchPressControl() { }

	[Address(RVA = "0x291FFA0", Offset = "0x291F3A0", Length = "0x120")]
	[Token(Token = "0x600146D")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x29200C0", Offset = "0x291F4C0", Length = "0x87")]
	[Token(Token = "0x600146E")]
	public virtual float ReadUnprocessedValueFromState(Void* statePtr) { }

	[Address(RVA = "0x2920150", Offset = "0x291F550", Length = "0x3E")]
	[Token(Token = "0x600146F")]
	public virtual void WriteValueIntoState(float value, Void* statePtr) { }

}

