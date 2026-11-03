namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x200021F")]
public class RenderTextureParameter : VolumeParameter<RenderTexture>
{

	[Address(RVA = "0x2C647E0", Offset = "0x2C63BE0", Length = "0x5A")]
	[Token(Token = "0x6000F5B")]
	public RenderTextureParameter(RenderTexture value, bool overrideState = false) { }

	[Address(RVA = "0x2C646E0", Offset = "0x2C63AE0", Length = "0xF4")]
	[Token(Token = "0x6000F5C")]
	public virtual int GetHashCode() { }

}

