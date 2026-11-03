namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x2000212")]
public class NoInterpFloatRangeParameter : VolumeParameter<Vector2>
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000995")]
	public float min; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000996")]
	public float max; //Field offset: 0x24

	[Token(Token = "0x170001F8")]
	public virtual Vector2 value
	{
		[Address(RVA = "0xABEC50", Offset = "0xABE050", Length = "0x13")]
		[Token(Token = "0x6000F41")]
		 get { } //Length: 19
		[Address(RVA = "0x2C5C010", Offset = "0x2C5B410", Length = "0x26")]
		[Token(Token = "0x6000F42")]
		 set { } //Length: 38
	}

	[Address(RVA = "0x2C632A0", Offset = "0x2C626A0", Length = "0x7D")]
	[Token(Token = "0x6000F43")]
	public NoInterpFloatRangeParameter(Vector2 value, float min, float max, bool overrideState = false) { }

	[Address(RVA = "0xABEC50", Offset = "0xABE050", Length = "0x13")]
	[Token(Token = "0x6000F41")]
	public virtual Vector2 get_value() { }

	[Address(RVA = "0x2C5C010", Offset = "0x2C5B410", Length = "0x26")]
	[Token(Token = "0x6000F42")]
	public virtual void set_value(Vector2 value) { }

}

