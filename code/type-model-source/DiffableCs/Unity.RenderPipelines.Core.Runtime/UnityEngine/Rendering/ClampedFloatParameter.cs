namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x200020F")]
public class ClampedFloatParameter : FloatParameter
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400098F")]
	public float min; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000990")]
	public float max; //Field offset: 0x24

	[Token(Token = "0x170001F5")]
	public virtual float value
	{
		[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
		[Token(Token = "0x6000F37")]
		 get { } //Length: 6
		[Address(RVA = "0x2C54250", Offset = "0x2C53650", Length = "0x20")]
		[Token(Token = "0x6000F38")]
		 set { } //Length: 32
	}

	[Address(RVA = "0x2C541D0", Offset = "0x2C535D0", Length = "0x7B")]
	[Token(Token = "0x6000F39")]
	public ClampedFloatParameter(float value, float min, float max, bool overrideState = false) { }

	[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
	[Token(Token = "0x6000F37")]
	public virtual float get_value() { }

	[Address(RVA = "0x2C54250", Offset = "0x2C53650", Length = "0x20")]
	[Token(Token = "0x6000F38")]
	public virtual void set_value(float value) { }

}

