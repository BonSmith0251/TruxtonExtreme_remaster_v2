namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001AD")]
internal static class StpUtils
{
	[Token(Token = "0x4000948")]
	internal static JitterFunc s_JitterFunc; //Field offset: 0x0

	[Address(RVA = "0x2DF1670", Offset = "0x2DF0A70", Length = "0x104")]
	[Token(Token = "0x6000950")]
	private static StpUtils() { }

	[Address(RVA = "0x2DF09A0", Offset = "0x2DEFDA0", Length = "0x8C")]
	[Token(Token = "0x600094D")]
	private static void CalculateJitter(int frameIndex, out Vector2 jitter, out bool allowScaling) { }

	[Address(RVA = "0x2DF0A30", Offset = "0x2DEFE30", Length = "0x31A")]
	[Token(Token = "0x600094F")]
	internal static void Execute(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, TextureHandle inputColor, TextureHandle inputDepth, TextureHandle inputMotion, TextureHandle destination, Texture2D noiseTexture) { }

	[Address(RVA = "0x2DF0D50", Offset = "0x2DF0150", Length = "0x914")]
	[Token(Token = "0x600094E")]
	private static void PopulateStpConfig(UniversalCameraData cameraData, TextureHandle inputColor, TextureHandle inputDepth, TextureHandle inputMotion, int debugViewIndex, TextureHandle debugView, TextureHandle destination, Texture2D noiseTexture, out Config config) { }

}

