namespace UnityEngine.InputSystem.Controls;

[Token(Token = "0x200021F")]
public class DiscreteButtonControl : ButtonControl
{
	[Token(Token = "0x2000220")]
	internal enum WriteMode : int
	{
		WriteDisabled = 0,
		WriteNullAndMaxValue = 1,
	}

	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000C16")]
	public int minValue; //Field offset: 0x148
	[FieldOffset(Offset = "0x14C")]
	[Token(Token = "0x4000C17")]
	public int maxValue; //Field offset: 0x14C
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000C18")]
	public int wrapAtValue; //Field offset: 0x150
	[FieldOffset(Offset = "0x154")]
	[Token(Token = "0x4000C19")]
	public int nullValue; //Field offset: 0x154
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000C1A")]
	public WriteMode writeMode; //Field offset: 0x158

	[Address(RVA = "0x290E9C0", Offset = "0x290DDC0", Length = "0x7")]
	[Token(Token = "0x6001414")]
	public DiscreteButtonControl() { }

	[Address(RVA = "0x290E680", Offset = "0x290DA80", Length = "0x120")]
	[Token(Token = "0x6001411")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x290E7A0", Offset = "0x290DBA0", Length = "0xCB")]
	[Token(Token = "0x6001412")]
	public virtual float ReadUnprocessedValueFromState(Void* statePtr) { }

	[Address(RVA = "0x290E870", Offset = "0x290DC70", Length = "0x14F")]
	[Token(Token = "0x6001413")]
	public virtual void WriteValueIntoState(float value, Void* statePtr) { }

}

