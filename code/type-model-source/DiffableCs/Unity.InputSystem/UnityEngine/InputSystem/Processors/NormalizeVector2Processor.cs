namespace UnityEngine.InputSystem.Processors;

[Token(Token = "0x20001F4")]
public class NormalizeVector2Processor : InputProcessor<Vector2>
{

	[Address(RVA = "0x2A13A30", Offset = "0x2A12E30", Length = "0x39")]
	[Token(Token = "0x6001272")]
	public NormalizeVector2Processor() { }

	[Address(RVA = "0x2A139E0", Offset = "0x2A12DE0", Length = "0x1A")]
	[Token(Token = "0x6001270")]
	public virtual Vector2 Process(Vector2 value, InputControl control) { }

	[Address(RVA = "0x2A13A00", Offset = "0x2A12E00", Length = "0x2C")]
	[Token(Token = "0x6001271")]
	public virtual string ToString() { }

}

