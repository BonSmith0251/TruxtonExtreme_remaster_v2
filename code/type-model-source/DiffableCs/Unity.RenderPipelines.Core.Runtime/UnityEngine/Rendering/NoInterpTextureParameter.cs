namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x200021C")]
public class NoInterpTextureParameter : VolumeParameter<Texture>
{

	[Address(RVA = "0x2C637A0", Offset = "0x2C62BA0", Length = "0x5A")]
	[Token(Token = "0x6000F55")]
	public NoInterpTextureParameter(Texture value, bool overrideState = false) { }

	[Address(RVA = "0x2C636A0", Offset = "0x2C62AA0", Length = "0xF4")]
	[Token(Token = "0x6000F56")]
	public virtual int GetHashCode() { }

}

