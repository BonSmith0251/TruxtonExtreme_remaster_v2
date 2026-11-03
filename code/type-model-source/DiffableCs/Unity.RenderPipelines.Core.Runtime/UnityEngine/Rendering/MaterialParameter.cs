namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
[Token(Token = "0x2000226")]
public class MaterialParameter : VolumeParameter<Material>
{

	[Address(RVA = "0x2C613B0", Offset = "0x2C607B0", Length = "0x5A")]
	[Token(Token = "0x6000F75")]
	public MaterialParameter(Material value, bool overrideState = false) { }

}

