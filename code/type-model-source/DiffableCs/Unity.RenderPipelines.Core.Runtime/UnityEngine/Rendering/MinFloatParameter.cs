namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x200020B")]
public class MinFloatParameter : FloatParameter
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400098B")]
	public float min; //Field offset: 0x20

	[Token(Token = "0x170001F1")]
	public virtual float value
	{
		[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
		[Token(Token = "0x6000F2B")]
		 get { } //Length: 6
		[Address(RVA = "0x2C62EB0", Offset = "0x2C622B0", Length = "0xD")]
		[Token(Token = "0x6000F2C")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2C61C70", Offset = "0x2C61070", Length = "0x6D")]
	[Token(Token = "0x6000F2D")]
	public MinFloatParameter(float value, float min, bool overrideState = false) { }

	[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
	[Token(Token = "0x6000F2B")]
	public virtual float get_value() { }

	[Address(RVA = "0x2C62EB0", Offset = "0x2C622B0", Length = "0xD")]
	[Token(Token = "0x6000F2C")]
	public virtual void set_value(float value) { }

}

