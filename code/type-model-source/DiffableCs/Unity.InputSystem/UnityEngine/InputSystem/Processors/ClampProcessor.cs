namespace UnityEngine.InputSystem.Processors;

[Token(Token = "0x20001ED")]
public class ClampProcessor : InputProcessor<Single>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B01")]
	public float min; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000B02")]
	public float max; //Field offset: 0x14

	[Address(RVA = "0x2A01810", Offset = "0x2A00C10", Length = "0x39")]
	[Token(Token = "0x6001259")]
	public ClampProcessor() { }

	[Address(RVA = "0x2A01760", Offset = "0x2A00B60", Length = "0x18")]
	[Token(Token = "0x6001257")]
	public virtual float Process(float value, InputControl control) { }

	[Address(RVA = "0x2A01780", Offset = "0x2A00B80", Length = "0x84")]
	[Token(Token = "0x6001258")]
	public virtual string ToString() { }

}

