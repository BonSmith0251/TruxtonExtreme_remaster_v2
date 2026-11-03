namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000131")]
internal sealed class MotionVectorRenderPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x2000134")]
	private sealed class <>c
	{
		[Token(Token = "0x400068C")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400068D")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__17_0; //Field offset: 0x8
		[Token(Token = "0x400068E")]
		public static BaseRenderFunc<MotionMatrixPassData, RasterGraphContext> <>9__19_0; //Field offset: 0x10

		[Address(RVA = "0x2DC8D00", Offset = "0x2DC8100", Length = "0x67")]
		[Token(Token = "0x6000741")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000742")]
		public <>c() { }

		[Address(RVA = "0x2DC87E0", Offset = "0x2DC7BE0", Length = "0x195")]
		[Token(Token = "0x6000743")]
		internal void <Render>b__17_0(PassData data, RasterGraphContext context) { }

		[Address(RVA = "0x2DC8AE0", Offset = "0x2DC7EE0", Length = "0x2E")]
		[Token(Token = "0x6000744")]
		internal void <SetRenderGraphMotionVectorGlobalMatrices>b__19_0(MotionMatrixPassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x2000133")]
	internal class MotionMatrixPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400068A")]
		public MotionVectorsPersistentData motionData; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400068B")]
		public XRPass xr; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000740")]
		public MotionMatrixPassData() { }

	}

	[Token(Token = "0x2000132")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000684")]
		internal Camera camera; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000685")]
		internal XRPass xr; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000686")]
		internal TextureHandle cameraDepth; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000687")]
		internal Material cameraMaterial; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000688")]
		internal RendererListHandle rendererListHdl; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000689")]
		internal RendererList rendererList; //Field offset: 0x48

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600073F")]
		public PassData() { }

	}

	[Token(Token = "0x400067B")]
	internal const string k_MotionVectorTextureName = "_MotionVectorTexture"; //Field offset: 0x0
	[Token(Token = "0x400067C")]
	internal const string k_MotionVectorDepthTextureName = "_MotionVectorDepthTexture"; //Field offset: 0x0
	[Token(Token = "0x400067D")]
	internal const GraphicsFormat k_TargetFormat = 46; //Field offset: 0x0
	[Token(Token = "0x400067E")]
	public const string k_MotionVectorsLightModeTag = "MotionVectors"; //Field offset: 0x0
	[Token(Token = "0x400067F")]
	private static readonly String[] s_ShaderTags; //Field offset: 0x0
	[Token(Token = "0x4000680")]
	private static readonly int s_CameraDepthTextureID; //Field offset: 0x8
	[Token(Token = "0x4000681")]
	private static readonly ProfilingSampler s_SetMotionMatrixProfilingSampler; //Field offset: 0x10
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000682")]
	private readonly Material m_CameraMaterial; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000683")]
	private readonly FilteringSettings m_FilteringSettings; //Field offset: 0x68

	[Address(RVA = "0x2DB3D80", Offset = "0x2DB3180", Length = "0x13C")]
	[Token(Token = "0x600073E")]
	private static MotionVectorRenderPass() { }

	[Address(RVA = "0x2DB3EC0", Offset = "0x2DB32C0", Length = "0x146")]
	[Token(Token = "0x6000735")]
	internal MotionVectorRenderPass(RenderPassEvent evt, Material cameraMaterial, LayerMask opaqueLayerMask) { }

	[Address(RVA = "0x2DB2190", Offset = "0x2DB1590", Length = "0x197")]
	[Token(Token = "0x6000738")]
	private static void DrawCameraMotionVectors(RasterCommandBuffer cmd, XRPass xr, Material cameraMaterial) { }

	[Address(RVA = "0x2DB2330", Offset = "0x2DB1730", Length = "0x92")]
	[Token(Token = "0x6000739")]
	private static void DrawObjectMotionVectors(RasterCommandBuffer cmd, XRPass xr, ref RendererList rendererList) { }

	[Address(RVA = "0x2DB23D0", Offset = "0x2DB17D0", Length = "0x2C2")]
	[Token(Token = "0x6000736")]
	private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RendererList rendererList) { }

	[Address(RVA = "0x2DB26A0", Offset = "0x2DB1AA0", Length = "0x2FD")]
	[Token(Token = "0x6000737")]
	private static DrawingSettings GetDrawingSettings(Camera camera, bool supportsDynamicBatching) { }

	[Address(RVA = "0x2DB29A0", Offset = "0x2DB1DA0", Length = "0x82")]
	[Token(Token = "0x600073A")]
	private void InitPassData(ref PassData passData, UniversalCameraData cameraData) { }

	[Address(RVA = "0x2DB2A30", Offset = "0x2DB1E30", Length = "0x4B0")]
	[Token(Token = "0x600073B")]
	private void InitRendererLists(ref PassData passData, ref CullingResults cullResults, bool supportsDynamicBatching, ScriptableRenderContext context, RenderGraph renderGraph, bool useRenderGraph) { }

	[Address(RVA = "0x2DB2EF0", Offset = "0x2DB22F0", Length = "0xAE4")]
	[Token(Token = "0x600073C")]
	internal void Render(RenderGraph renderGraph, ContextContainer frameData, TextureHandle cameraDepthTexture, TextureHandle motionVectorColor, TextureHandle motionVectorDepth) { }

	[Address(RVA = "0x2DB39E0", Offset = "0x2DB2DE0", Length = "0x395")]
	[Token(Token = "0x600073D")]
	internal static void SetRenderGraphMotionVectorGlobalMatrices(RenderGraph renderGraph, UniversalCameraData cameraData) { }

}

