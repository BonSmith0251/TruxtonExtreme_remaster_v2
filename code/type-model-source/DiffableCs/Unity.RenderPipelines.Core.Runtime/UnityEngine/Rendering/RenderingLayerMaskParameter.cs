namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x2000200")]
public class RenderingLayerMaskParameter : VolumeParameter<RenderingLayerMask>
{

	[Address(RVA = "0x2C64840", Offset = "0x2C63C40", Length = "0x58")]
	[Token(Token = "0x6000F12")]
	public RenderingLayerMaskParameter(RenderingLayerMask value, bool overrideState = false) { }

}

