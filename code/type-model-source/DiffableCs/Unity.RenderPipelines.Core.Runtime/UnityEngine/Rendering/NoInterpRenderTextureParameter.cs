namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x2000220")]
public class NoInterpRenderTextureParameter : VolumeParameter<RenderTexture>
{

	[Address(RVA = "0x2C63640", Offset = "0x2C62A40", Length = "0x5A")]
	[Token(Token = "0x6000F5D")]
	public NoInterpRenderTextureParameter(RenderTexture value, bool overrideState = false) { }

	[Address(RVA = "0x2C63540", Offset = "0x2C62940", Length = "0xF4")]
	[Token(Token = "0x6000F5E")]
	public virtual int GetHashCode() { }

}

