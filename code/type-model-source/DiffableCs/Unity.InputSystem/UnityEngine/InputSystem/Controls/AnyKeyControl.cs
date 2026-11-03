namespace UnityEngine.InputSystem.Controls;

[InputControlLayout(hideInUI = True)]
[Token(Token = "0x200021A")]
public class AnyKeyControl : ButtonControl
{

	[Address(RVA = "0x290CCF0", Offset = "0x290C0F0", Length = "0x65")]
	[Token(Token = "0x60013F1")]
	public AnyKeyControl() { }

	[Address(RVA = "0x290CCC0", Offset = "0x290C0C0", Length = "0x28")]
	[Token(Token = "0x60013F2")]
	public virtual float ReadUnprocessedValueFromState(Void* statePtr) { }

}

