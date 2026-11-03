namespace UnityEngine.InputSystem.Controls;

[InputControlLayout(hideInUI = True)]
[Token(Token = "0x200022A")]
public class TouchPhaseControl : InputControl<TouchPhase>
{

	[Address(RVA = "0x291FF20", Offset = "0x291F320", Length = "0x72")]
	[Token(Token = "0x600146A")]
	public TouchPhaseControl() { }

	[Address(RVA = "0x291FE50", Offset = "0x291F250", Length = "0x65")]
	[Token(Token = "0x600146B")]
	public virtual TouchPhase ReadUnprocessedValueFromState(Void* statePtr) { }

	[Address(RVA = "0x291FEC0", Offset = "0x291F2C0", Length = "0x5F")]
	[Token(Token = "0x600146C")]
	public virtual void WriteValueIntoState(TouchPhase value, Void* statePtr) { }

}

