namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x2000221")]
public class CubemapParameter : VolumeParameter<Texture>
{

	[Address(RVA = "0x2C5B360", Offset = "0x2C5A760", Length = "0x5A")]
	[Token(Token = "0x6000F5F")]
	public CubemapParameter(Texture value, bool overrideState = false) { }

	[Address(RVA = "0x2C5B260", Offset = "0x2C5A660", Length = "0xF4")]
	[Token(Token = "0x6000F60")]
	public virtual int GetHashCode() { }

}

