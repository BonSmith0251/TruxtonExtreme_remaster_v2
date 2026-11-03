namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x200020C")]
public class NoInterpMinFloatParameter : VolumeParameter<Single>
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400098C")]
	public float min; //Field offset: 0x20

	[Token(Token = "0x170001F2")]
	public virtual float value
	{
		[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
		[Token(Token = "0x6000F2E")]
		 get { } //Length: 6
		[Address(RVA = "0x2C62EB0", Offset = "0x2C622B0", Length = "0xD")]
		[Token(Token = "0x6000F2F")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2C63460", Offset = "0x2C62860", Length = "0x6D")]
	[Token(Token = "0x6000F30")]
	public NoInterpMinFloatParameter(float value, float min, bool overrideState = false) { }

	[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
	[Token(Token = "0x6000F2E")]
	public virtual float get_value() { }

	[Address(RVA = "0x2C62EB0", Offset = "0x2C622B0", Length = "0xD")]
	[Token(Token = "0x6000F2F")]
	public virtual void set_value(float value) { }

}

