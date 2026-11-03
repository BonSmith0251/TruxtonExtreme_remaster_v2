namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x20001FF")]
public class LayerMaskParameter : VolumeParameter<LayerMask>
{

	[Address(RVA = "0x2C601F0", Offset = "0x2C5F5F0", Length = "0x58")]
	[Token(Token = "0x6000F11")]
	public LayerMaskParameter(LayerMask value, bool overrideState = false) { }

}

