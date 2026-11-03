namespace UnityEngine.InputSystem.Processors;

[Token(Token = "0x20001F7")]
public class ScaleVector2Processor : InputProcessor<Vector2>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B0C")]
	[Tooltip("Scale factor to multiply the incoming Vector2's X component by.")]
	public float x; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000B0D")]
	[Tooltip("Scale factor to multiply the incoming Vector2's Y component by.")]
	public float y; //Field offset: 0x14

	[Address(RVA = "0x2A16300", Offset = "0x2A15700", Length = "0x47")]
	[Token(Token = "0x600127B")]
	public ScaleVector2Processor() { }

	[Address(RVA = "0x2A16240", Offset = "0x2A15640", Length = "0x24")]
	[Token(Token = "0x6001279")]
	public virtual Vector2 Process(Vector2 value, InputControl control) { }

	[Address(RVA = "0x2A16270", Offset = "0x2A15670", Length = "0x84")]
	[Token(Token = "0x600127A")]
	public virtual string ToString() { }

}

