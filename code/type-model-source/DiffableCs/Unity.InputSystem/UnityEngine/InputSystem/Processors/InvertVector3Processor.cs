namespace UnityEngine.InputSystem.Processors;

[Token(Token = "0x20001F2")]
public class InvertVector3Processor : InputProcessor<Vector3>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B05")]
	public bool invertX; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4000B06")]
	public bool invertY; //Field offset: 0x11
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x4000B07")]
	public bool invertZ; //Field offset: 0x12

	[Address(RVA = "0x2A11B50", Offset = "0x2A10F50", Length = "0x43")]
	[Token(Token = "0x600126A")]
	public InvertVector3Processor() { }

	[Address(RVA = "0x2A11A50", Offset = "0x2A10E50", Length = "0x5C")]
	[Token(Token = "0x6001268")]
	public virtual Vector3 Process(Vector3 value, InputControl control) { }

	[Address(RVA = "0x2A11AB0", Offset = "0x2A10EB0", Length = "0x9E")]
	[Token(Token = "0x6001269")]
	public virtual string ToString() { }

}

