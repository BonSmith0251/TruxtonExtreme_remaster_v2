namespace UnityEngine.InputSystem.Controls;

[Token(Token = "0x2000225")]
public class IntegerControl : InputControl<Int32>
{

	[Address(RVA = "0x2919810", Offset = "0x2918C10", Length = "0x72")]
	[Token(Token = "0x600142B")]
	public IntegerControl() { }

	[Address(RVA = "0x29195F0", Offset = "0x29189F0", Length = "0xDE")]
	[Token(Token = "0x600142E")]
	protected virtual FourCC CalculateOptimizedControlDataType() { }

	[Address(RVA = "0x29196D0", Offset = "0x2918AD0", Length = "0x95")]
	[Token(Token = "0x600142C")]
	public virtual int ReadUnprocessedValueFromState(Void* statePtr) { }

	[Address(RVA = "0x2919770", Offset = "0x2918B70", Length = "0x97")]
	[Token(Token = "0x600142D")]
	public virtual void WriteValueIntoState(int value, Void* statePtr) { }

}

