namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x200020E")]
public class NoInterpMaxFloatParameter : VolumeParameter<Single>
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400098E")]
	public float max; //Field offset: 0x20

	[Token(Token = "0x170001F4")]
	public virtual float value
	{
		[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
		[Token(Token = "0x6000F34")]
		 get { } //Length: 6
		[Address(RVA = "0x2C61CE0", Offset = "0x2C610E0", Length = "0xD")]
		[Token(Token = "0x6000F35")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2C63380", Offset = "0x2C62780", Length = "0x6D")]
	[Token(Token = "0x6000F36")]
	public NoInterpMaxFloatParameter(float value, float max, bool overrideState = false) { }

	[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
	[Token(Token = "0x6000F34")]
	public virtual float get_value() { }

	[Address(RVA = "0x2C61CE0", Offset = "0x2C610E0", Length = "0xD")]
	[Token(Token = "0x6000F35")]
	public virtual void set_value(float value) { }

}

