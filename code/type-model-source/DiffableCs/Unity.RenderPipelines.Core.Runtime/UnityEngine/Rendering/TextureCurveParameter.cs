namespace UnityEngine.Rendering;

[Token(Token = "0x20001EB")]
public class TextureCurveParameter : VolumeParameter<TextureCurve>
{

	[Address(RVA = "0x2C662B0", Offset = "0x2C656B0", Length = "0x5A")]
	[Token(Token = "0x6000EA2")]
	public TextureCurveParameter(TextureCurve value, bool overrideState = false) { }

	[Address(RVA = "0x2C66290", Offset = "0x2C65690", Length = "0x1D")]
	[Token(Token = "0x6000EA3")]
	public virtual void Release() { }

}

