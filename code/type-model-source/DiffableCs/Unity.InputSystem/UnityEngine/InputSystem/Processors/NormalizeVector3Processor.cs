namespace UnityEngine.InputSystem.Processors;

[Token(Token = "0x20001F5")]
public class NormalizeVector3Processor : InputProcessor<Vector3>
{

	[Address(RVA = "0x2A13BC0", Offset = "0x2A12FC0", Length = "0x39")]
	[Token(Token = "0x6001275")]
	public NormalizeVector3Processor() { }

	[Address(RVA = "0x2A13A70", Offset = "0x2A12E70", Length = "0x11C")]
	[Token(Token = "0x6001273")]
	public virtual Vector3 Process(Vector3 value, InputControl control) { }

	[Address(RVA = "0x2A13B90", Offset = "0x2A12F90", Length = "0x2C")]
	[Token(Token = "0x6001274")]
	public virtual string ToString() { }

}

