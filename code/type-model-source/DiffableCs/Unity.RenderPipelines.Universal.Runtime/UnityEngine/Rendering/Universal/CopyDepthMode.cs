namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001D5")]
public enum CopyDepthMode : int
{
	AfterOpaques = 0,
	AfterTransparents = 1,
	ForcePrepass = 2,
}

