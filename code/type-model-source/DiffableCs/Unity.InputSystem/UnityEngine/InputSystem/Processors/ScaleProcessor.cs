namespace UnityEngine.InputSystem.Processors;

[Token(Token = "0x20001F6")]
public class ScaleProcessor : InputProcessor<Single>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B0B")]
	[Tooltip("Scale factor to multiply incoming float values by.")]
	public float factor; //Field offset: 0x10

	[Address(RVA = "0x2A16200", Offset = "0x2A15600", Length = "0x40")]
	[Token(Token = "0x6001278")]
	public ScaleProcessor() { }

	[Address(RVA = "0x2A16190", Offset = "0x2A15590", Length = "0x9")]
	[Token(Token = "0x6001276")]
	public virtual float Process(float value, InputControl control) { }

	[Address(RVA = "0x2A161A0", Offset = "0x2A155A0", Length = "0x59")]
	[Token(Token = "0x6001277")]
	public virtual string ToString() { }

}

