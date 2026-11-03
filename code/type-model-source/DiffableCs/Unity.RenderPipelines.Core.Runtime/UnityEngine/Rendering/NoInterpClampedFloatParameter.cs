namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x2000210")]
public class NoInterpClampedFloatParameter : VolumeParameter<Single>
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000991")]
	public float min; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000992")]
	public float max; //Field offset: 0x24

	[Token(Token = "0x170001F6")]
	public virtual float value
	{
		[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
		[Token(Token = "0x6000F3A")]
		 get { } //Length: 6
		[Address(RVA = "0x2C54250", Offset = "0x2C53650", Length = "0x20")]
		[Token(Token = "0x6000F3B")]
		 set { } //Length: 32
	}

	[Address(RVA = "0x2C62ED0", Offset = "0x2C622D0", Length = "0x7B")]
	[Token(Token = "0x6000F3C")]
	public NoInterpClampedFloatParameter(float value, float min, float max, bool overrideState = false) { }

	[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
	[Token(Token = "0x6000F3A")]
	public virtual float get_value() { }

	[Address(RVA = "0x2C54250", Offset = "0x2C53650", Length = "0x20")]
	[Token(Token = "0x6000F3B")]
	public virtual void set_value(float value) { }

}

