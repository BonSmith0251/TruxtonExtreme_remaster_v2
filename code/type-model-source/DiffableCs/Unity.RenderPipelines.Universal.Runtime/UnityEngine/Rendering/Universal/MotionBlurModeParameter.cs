namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200010C")]
public sealed class MotionBlurModeParameter : VolumeParameter<MotionBlurMode>
{

	[Address(RVA = "0x2DB1F50", Offset = "0x2DB1350", Length = "0x58")]
	[Token(Token = "0x60006D8")]
	public MotionBlurModeParameter(MotionBlurMode value, bool overrideState = false) { }

}

