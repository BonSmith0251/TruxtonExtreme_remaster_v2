namespace UnityEngine.Rendering;

[Token(Token = "0x20001ED")]
public class TextureGradientParameter : VolumeParameter<TextureGradient>
{

	[Address(RVA = "0x2C66DA0", Offset = "0x2C661A0", Length = "0x5A")]
	[Token(Token = "0x6000EB2")]
	public TextureGradientParameter(TextureGradient value, bool overrideState = false) { }

	[Address(RVA = "0x2C66CF0", Offset = "0x2C660F0", Length = "0xAF")]
	[Token(Token = "0x6000EB3")]
	public virtual void Release() { }

}

