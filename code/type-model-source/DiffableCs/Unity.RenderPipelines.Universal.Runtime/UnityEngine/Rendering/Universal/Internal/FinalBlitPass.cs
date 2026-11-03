namespace UnityEngine.Rendering.Universal.Internal;

[Token(Token = "0x2000224")]
public class FinalBlitPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x2000229")]
	private sealed class <>c
	{
		[Token(Token = "0x4000D78")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000D79")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__15_0; //Field offset: 0x8

		[Address(RVA = "0x2E35AA0", Offset = "0x2E34EA0", Length = "0x67")]
		[Token(Token = "0x6000BED")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000BEE")]
		public <>c() { }

		[Address(RVA = "0x2E344F0", Offset = "0x2E338F0", Length = "0x51A")]
		[Token(Token = "0x6000BEF")]
		internal void <Render>b__15_0(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x2000227")]
	private struct BlitMaterialData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000D6C")]
		public Material material; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000D6D")]
		public int nearestSamplerPass; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000D6E")]
		public int bilinearSamplerPass; //Field offset: 0xC

	}

	[Token(Token = "0x2000225")]
	private static class BlitPassNames
	{
		[Token(Token = "0x4000D66")]
		public const string NearestSampler = "NearestDebugDraw"; //Field offset: 0x0
		[Token(Token = "0x4000D67")]
		public const string BilinearSampler = "BilinearDebugDraw"; //Field offset: 0x0

	}

	[Token(Token = "0x2000226")]
	private enum BlitType : int
	{
		Core = 0,
		HDR = 1,
		Count = 2,
	}

	[Token(Token = "0x2000228")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000D6F")]
		internal TextureHandle source; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000D70")]
		internal TextureHandle destination; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000D71")]
		internal int sourceID; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000D72")]
		internal Vector4 hdrOutputLuminanceParams; //Field offset: 0x34
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4000D73")]
		internal bool requireSrgbConversion; //Field offset: 0x44
		[FieldOffset(Offset = "0x45")]
		[Token(Token = "0x4000D74")]
		internal bool enableAlphaOutput; //Field offset: 0x45
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000D75")]
		internal BlitMaterialData blitMaterialData; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000D76")]
		internal UniversalCameraData cameraData; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000D77")]
		internal bool useFullScreenViewport; //Field offset: 0x60

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000BEC")]
		public PassData() { }

	}

	[Token(Token = "0x4000D64")]
	private static readonly int s_CameraDepthTextureID; //Field offset: 0x0
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D65")]
	private BlitMaterialData[] m_BlitMaterialData; //Field offset: 0x60

	[Address(RVA = "0x2E29070", Offset = "0x2E28470", Length = "0x4F")]
	[Token(Token = "0x6000BEB")]
	private static FinalBlitPass() { }

	[Address(RVA = "0x2E290C0", Offset = "0x2E284C0", Length = "0x1BA")]
	[Token(Token = "0x6000BE3")]
	public FinalBlitPass(RenderPassEvent evt, Material blitMaterial, Material blitHDRMaterial) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000BE4")]
	public void Dispose() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000BE2")]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[Address(RVA = "0x2E28150", Offset = "0x2E27550", Length = "0x386")]
	[Token(Token = "0x6000BE8")]
	private static void ExecutePass(RasterCommandBuffer cmd, PassData data, RTHandle source, RTHandle destination, UniversalCameraData cameraData, Vector4 scaleBias) { }

	[Address(RVA = "0x2E284E0", Offset = "0x2E278E0", Length = "0xCE")]
	[Token(Token = "0x6000BE9")]
	private void InitPassData(UniversalCameraData cameraData, ref PassData passData, BlitType blitType, bool enableAlphaOutput, bool useFullScreenViewport) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000BE1")]
	public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	[Address(RVA = "0x2E285B0", Offset = "0x2E279B0", Length = "0x961")]
	[Token(Token = "0x6000BEA")]
	internal void Render(RenderGraph renderGraph, ContextContainer frameData, UniversalCameraData cameraData, in TextureHandle src, in TextureHandle dest, TextureHandle overlayUITexture, bool useFullScreenViewport = false) { }

	[Address(RVA = "0x2E29020", Offset = "0x2E28420", Length = "0x4E")]
	[Obsolete("Use RTHandles for colorHandle. #from(2022.1) #breakingFrom(2023.1)", True)]
	[Token(Token = "0x6000BE5")]
	public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorHandle) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000BE6")]
	public void Setup(RenderTextureDescriptor baseDescriptor, RTHandle colorHandle) { }

	[Address(RVA = "0x2E28F20", Offset = "0x2E28320", Length = "0xF2")]
	[Token(Token = "0x6000BE7")]
	private static void SetupHDROutput(ColorGamut hdrDisplayColorGamut, Material material, Operation hdrOperation, Vector4 hdrOutputParameters, bool rendersOverlayUI) { }

}

