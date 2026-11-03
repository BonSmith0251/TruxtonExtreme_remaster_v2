namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000FA")]
public sealed class DownscaleParameter : VolumeParameter<BloomDownscaleMode>
{

	[Address(RVA = "0x2DAA9C0", Offset = "0x2DA9DC0", Length = "0x58")]
	[Token(Token = "0x60006B5")]
	public DownscaleParameter(BloomDownscaleMode value, bool overrideState = false) { }

}

