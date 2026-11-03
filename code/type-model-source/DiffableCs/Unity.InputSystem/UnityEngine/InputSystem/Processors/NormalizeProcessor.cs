namespace UnityEngine.InputSystem.Processors;

[Token(Token = "0x20001F3")]
public class NormalizeProcessor : InputProcessor<Single>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B08")]
	public float min; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000B09")]
	public float max; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B0A")]
	public float zero; //Field offset: 0x18

	[Address(RVA = "0x2A139A0", Offset = "0x2A12DA0", Length = "0x39")]
	[Token(Token = "0x600126F")]
	public NormalizeProcessor() { }

	[Address(RVA = "0x2A136C0", Offset = "0x2A12AC0", Length = "0x4F")]
	[Token(Token = "0x600126D")]
	internal static float Denormalize(float value, float min, float max, float zero) { }

	[Address(RVA = "0x2A13710", Offset = "0x2A12B10", Length = "0xE9")]
	[Token(Token = "0x600126C")]
	public static float Normalize(float value, float min, float max, float zero) { }

	[Address(RVA = "0x2A13800", Offset = "0x2A12C00", Length = "0xEE")]
	[Token(Token = "0x600126B")]
	public virtual float Process(float value, InputControl control) { }

	[Address(RVA = "0x2A138F0", Offset = "0x2A12CF0", Length = "0xA7")]
	[Token(Token = "0x600126E")]
	public virtual string ToString() { }

}

