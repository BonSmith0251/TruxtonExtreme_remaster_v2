namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000FB")]
public sealed class BloomFilterModeParameter : VolumeParameter<BloomFilterMode>
{

	[Address(RVA = "0x2DA7F80", Offset = "0x2DA7380", Length = "0x58")]
	[Token(Token = "0x60006B6")]
	public BloomFilterModeParameter(BloomFilterMode value, bool overrideState = false) { }

}

