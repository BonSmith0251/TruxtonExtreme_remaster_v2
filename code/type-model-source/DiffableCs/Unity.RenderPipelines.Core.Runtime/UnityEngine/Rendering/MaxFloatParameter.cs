namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x200020D")]
public class MaxFloatParameter : FloatParameter
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400098D")]
	public float max; //Field offset: 0x20

	[Token(Token = "0x170001F3")]
	public virtual float value
	{
		[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
		[Token(Token = "0x6000F31")]
		 get { } //Length: 6
		[Address(RVA = "0x2C61CE0", Offset = "0x2C610E0", Length = "0xD")]
		[Token(Token = "0x6000F32")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2C61C70", Offset = "0x2C61070", Length = "0x6D")]
	[Token(Token = "0x6000F33")]
	public MaxFloatParameter(float value, float max, bool overrideState = false) { }

	[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
	[Token(Token = "0x6000F31")]
	public virtual float get_value() { }

	[Address(RVA = "0x2C61CE0", Offset = "0x2C610E0", Length = "0xD")]
	[Token(Token = "0x6000F32")]
	public virtual void set_value(float value) { }

}

