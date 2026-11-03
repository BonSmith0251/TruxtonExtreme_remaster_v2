namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x2000209")]
public class FloatParameter : VolumeParameter<Single>
{

	[Address(RVA = "0x2C5BEE0", Offset = "0x2C5B2E0", Length = "0x5A")]
	[Token(Token = "0x6000F28")]
	public FloatParameter(float value, bool overrideState = false) { }

	[Address(RVA = "0x2C5BEC0", Offset = "0x2C5B2C0", Length = "0x12")]
	[Token(Token = "0x6000F29")]
	public virtual void Interp(float from, float to, float t) { }

}

