namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000190")]
internal static class RenderingLayerUtils
{
	[Token(Token = "0x2000191")]
	internal enum Event : int
	{
		DepthNormalPrePass = 0,
		Opaque = 1,
	}

	[Token(Token = "0x2000192")]
	internal enum MaskSize : int
	{
		Bits8 = 0,
		Bits16 = 1,
		Bits24 = 2,
		Bits32 = 3,
	}


	[Address(RVA = "0x7A92F0", Offset = "0x7A86F0", Length = "0xA")]
	[Token(Token = "0x600084D")]
	private static Event Combine(Event a, Event b) { }

	[Address(RVA = "0x2DCFF20", Offset = "0x2DCF320", Length = "0xA")]
	[Token(Token = "0x600084E")]
	private static MaskSize Combine(MaskSize a, MaskSize b) { }

	[Address(RVA = "0x2DCFF00", Offset = "0x2DCF300", Length = "0x1C")]
	[Token(Token = "0x6000844")]
	public static void CombineRendererEvents(bool isDeferred, int msaaSampleCount, Event rendererEvent, ref Event combinedEvent) { }

	[Address(RVA = "0x2DCFF30", Offset = "0x2DCF330", Length = "0x81")]
	[Token(Token = "0x600084C")]
	private static int GetBits(MaskSize maskSize) { }

	[Address(RVA = "0x2DCFFC0", Offset = "0x2DCF3C0", Length = "0x77")]
	[Token(Token = "0x6000849")]
	public static GraphicsFormat GetFormat(MaskSize maskSize) { }

	[Address(RVA = "0x2DD0040", Offset = "0x2DCF440", Length = "0x37")]
	[Token(Token = "0x600084B")]
	private static MaskSize GetMaskSize(int bits) { }

	[Address(RVA = "0x2DD0080", Offset = "0x2DCF480", Length = "0x87")]
	[Token(Token = "0x6000845")]
	public static bool RequireRenderingLayers(UniversalRenderer universalRenderer, List<ScriptableRendererFeature> rendererFeatures, int msaaSampleCount, out Event combinedEvent, out MaskSize combinedMaskSize) { }

	[Address(RVA = "0x2DD0110", Offset = "0x2DCF510", Length = "0x2ED")]
	[Token(Token = "0x6000846")]
	internal static bool RequireRenderingLayers(List<ScriptableRendererFeature> rendererFeatures, RenderingMode renderingMode, bool accurateGbufferNormals, int msaaSampleCount, out Event combinedEvent, out MaskSize combinedMaskSize) { }

	[Address(RVA = "0x2DD04E0", Offset = "0x2DCF8E0", Length = "0x11D")]
	[Token(Token = "0x6000847")]
	public static void SetupProperties(CommandBuffer cmd, MaskSize maskSize) { }

	[Address(RVA = "0x2DD0400", Offset = "0x2DCF800", Length = "0xDF")]
	[Token(Token = "0x6000848")]
	internal static void SetupProperties(RasterCommandBuffer cmd, MaskSize maskSize) { }

	[Address(RVA = "0x2DD0600", Offset = "0x2DCFA00", Length = "0xC9")]
	[Token(Token = "0x600084A")]
	public static uint ToValidRenderingLayers(uint renderingLayers) { }

}

