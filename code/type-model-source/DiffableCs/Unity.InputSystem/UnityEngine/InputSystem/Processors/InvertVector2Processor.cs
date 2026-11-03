namespace UnityEngine.InputSystem.Processors;

[Token(Token = "0x20001F1")]
public class InvertVector2Processor : InputProcessor<Vector2>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B03")]
	public bool invertX; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4000B04")]
	public bool invertY; //Field offset: 0x11

	[Address(RVA = "0x2A11A10", Offset = "0x2A10E10", Length = "0x3F")]
	[Token(Token = "0x6001267")]
	public InvertVector2Processor() { }

	[Address(RVA = "0x2A11930", Offset = "0x2A10D30", Length = "0x58")]
	[Token(Token = "0x6001265")]
	public virtual Vector2 Process(Vector2 value, InputControl control) { }

	[Address(RVA = "0x2A11990", Offset = "0x2A10D90", Length = "0x7E")]
	[Token(Token = "0x6001266")]
	public virtual string ToString() { }

}

