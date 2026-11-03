namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x2000211")]
public class FloatRangeParameter : VolumeParameter<Vector2>
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000993")]
	public float min; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000994")]
	public float max; //Field offset: 0x24

	[Token(Token = "0x170001F7")]
	public virtual Vector2 value
	{
		[Address(RVA = "0xABEC50", Offset = "0xABE050", Length = "0x13")]
		[Token(Token = "0x6000F3D")]
		 get { } //Length: 19
		[Address(RVA = "0x2C5C010", Offset = "0x2C5B410", Length = "0x26")]
		[Token(Token = "0x6000F3E")]
		 set { } //Length: 38
	}

	[Address(RVA = "0x2C5BF90", Offset = "0x2C5B390", Length = "0x7D")]
	[Token(Token = "0x6000F3F")]
	public FloatRangeParameter(Vector2 value, float min, float max, bool overrideState = false) { }

	[Address(RVA = "0xABEC50", Offset = "0xABE050", Length = "0x13")]
	[Token(Token = "0x6000F3D")]
	public virtual Vector2 get_value() { }

	[Address(RVA = "0x2C5BF40", Offset = "0x2C5B340", Length = "0x46")]
	[Token(Token = "0x6000F40")]
	public virtual void Interp(Vector2 from, Vector2 to, float t) { }

	[Address(RVA = "0x2C5C010", Offset = "0x2C5B410", Length = "0x26")]
	[Token(Token = "0x6000F3E")]
	public virtual void set_value(Vector2 value) { }

}

