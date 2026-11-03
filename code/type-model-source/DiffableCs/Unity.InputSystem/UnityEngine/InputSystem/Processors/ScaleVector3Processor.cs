namespace UnityEngine.InputSystem.Processors;

[Token(Token = "0x20001F8")]
public class ScaleVector3Processor : InputProcessor<Vector3>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B0E")]
	[Tooltip("Scale factor to multiply the incoming Vector3's X component by.")]
	public float x; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000B0F")]
	[Tooltip("Scale factor to multiply the incoming Vector3's Y component by.")]
	public float y; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B10")]
	[Tooltip("Scale factor to multiply the incoming Vector3's Z component by.")]
	public float z; //Field offset: 0x18

	[Address(RVA = "0x2A16440", Offset = "0x2A15840", Length = "0x4E")]
	[Token(Token = "0x600127E")]
	public ScaleVector3Processor() { }

	[Address(RVA = "0x2A16350", Offset = "0x2A15750", Length = "0x32")]
	[Token(Token = "0x600127C")]
	public virtual Vector3 Process(Vector3 value, InputControl control) { }

	[Address(RVA = "0x2A16390", Offset = "0x2A15790", Length = "0xA7")]
	[Token(Token = "0x600127D")]
	public virtual string ToString() { }

}

