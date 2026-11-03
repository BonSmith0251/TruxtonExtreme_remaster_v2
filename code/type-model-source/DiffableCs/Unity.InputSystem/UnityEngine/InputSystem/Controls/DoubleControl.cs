namespace UnityEngine.InputSystem.Controls;

[Token(Token = "0x2000221")]
public class DoubleControl : InputControl<Double>
{

	[Address(RVA = "0x290EAA0", Offset = "0x290DEA0", Length = "0x72")]
	[Token(Token = "0x6001415")]
	public DoubleControl() { }

	[Address(RVA = "0x290E9D0", Offset = "0x290DDD0", Length = "0x5A")]
	[Token(Token = "0x6001416")]
	public virtual double ReadUnprocessedValueFromState(Void* statePtr) { }

	[Address(RVA = "0x290EA30", Offset = "0x290DE30", Length = "0x6A")]
	[Token(Token = "0x6001417")]
	public virtual void WriteValueIntoState(double value, Void* statePtr) { }

}

