namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x200021E")]
public class Texture3DParameter : VolumeParameter<Texture>
{

	[Address(RVA = "0x2C66230", Offset = "0x2C65630", Length = "0x5A")]
	[Token(Token = "0x6000F59")]
	public Texture3DParameter(Texture value, bool overrideState = false) { }

	[Address(RVA = "0x2C66130", Offset = "0x2C65530", Length = "0xF4")]
	[Token(Token = "0x6000F5A")]
	public virtual int GetHashCode() { }

}

