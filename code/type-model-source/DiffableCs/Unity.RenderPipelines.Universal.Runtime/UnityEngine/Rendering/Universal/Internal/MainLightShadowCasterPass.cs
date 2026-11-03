namespace UnityEngine.Rendering.Universal.Internal;

[Token(Token = "0x200022A")]
public class MainLightShadowCasterPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x200022D")]
	private sealed class <>c
	{
		[Token(Token = "0x4000DA2")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000DA3")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__35_0; //Field offset: 0x8

		[Address(RVA = "0x2E35560", Offset = "0x2E34960", Length = "0x67")]
		[Token(Token = "0x6000C02")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C03")]
		public <>c() { }

		[Address(RVA = "0x2E35190", Offset = "0x2E34590", Length = "0x19D")]
		[Token(Token = "0x6000C04")]
		internal void <Render>b__35_0(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x200022B")]
	private static class MainLightShadowConstantBuffer
	{
		[Token(Token = "0x4000D8D")]
		public static readonly int _WorldToShadow; //Field offset: 0x0
		[Token(Token = "0x4000D8E")]
		public static readonly int _ShadowParams; //Field offset: 0x4
		[Token(Token = "0x4000D8F")]
		public static readonly int _CascadeShadowSplitSpheres0; //Field offset: 0x8
		[Token(Token = "0x4000D90")]
		public static readonly int _CascadeShadowSplitSpheres1; //Field offset: 0xC
		[Token(Token = "0x4000D91")]
		public static readonly int _CascadeShadowSplitSpheres2; //Field offset: 0x10
		[Token(Token = "0x4000D92")]
		public static readonly int _CascadeShadowSplitSpheres3; //Field offset: 0x14
		[Token(Token = "0x4000D93")]
		public static readonly int _CascadeShadowSplitSphereRadii; //Field offset: 0x18
		[Token(Token = "0x4000D94")]
		public static readonly int _ShadowOffset0; //Field offset: 0x1C
		[Token(Token = "0x4000D95")]
		public static readonly int _ShadowOffset1; //Field offset: 0x20
		[Token(Token = "0x4000D96")]
		public static readonly int _ShadowmapSize; //Field offset: 0x24
		[Token(Token = "0x4000D97")]
		public static readonly int _MainLightShadowmapID; //Field offset: 0x28

		[Address(RVA = "0x2E32CE0", Offset = "0x2E320E0", Length = "0x201")]
		[Token(Token = "0x6000C00")]
		private static MainLightShadowConstantBuffer() { }

	}

	[Token(Token = "0x200022C")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000D98")]
		internal bool emptyShadowmap; //Field offset: 0x10
		[FieldOffset(Offset = "0x11")]
		[Token(Token = "0x4000D99")]
		internal bool setKeywordForEmptyShadowmap; //Field offset: 0x11
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000D9A")]
		internal UniversalRenderingData renderingData; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000D9B")]
		internal UniversalCameraData cameraData; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000D9C")]
		internal UniversalLightData lightData; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000D9D")]
		internal UniversalShadowData shadowData; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000D9E")]
		internal MainLightShadowCasterPass pass; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000D9F")]
		internal TextureHandle shadowmapTexture; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000DA0")]
		internal readonly RendererList[] shadowRendererLists; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000DA1")]
		internal readonly RendererListHandle[] shadowRendererListsHandle; //Field offset: 0x58

		[Address(RVA = "0x2E335E0", Offset = "0x2E329E0", Length = "0x82")]
		[Token(Token = "0x6000C01")]
		public PassData() { }

	}

	[Token(Token = "0x4000D8A")]
	private const string k_MainLightShadowMapTextureName = "_MainLightShadowmapTexture"; //Field offset: 0x0
	[Token(Token = "0x4000D89")]
	private const int k_ShadowmapBufferBits = 16; //Field offset: 0x0
	[Token(Token = "0x4000D88")]
	private const int k_MaxCascades = 4; //Field offset: 0x0
	[Token(Token = "0x4000D87")]
	private const int k_EmptyShadowMapDimensions = 1; //Field offset: 0x0
	[Token(Token = "0x4000D8B")]
	private static Vector4 s_EmptyShadowParams; //Field offset: 0x0
	[Token(Token = "0x4000D8C")]
	private static readonly Vector4 s_EmptyShadowmapSize; //Field offset: 0x10
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D7A")]
	internal RTHandle m_MainLightShadowmapTexture; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D7B")]
	private int m_RenderTargetWidth; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000D7C")]
	private int m_RenderTargetHeight; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000D7D")]
	private int m_ShadowCasterCascadesCount; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000D7E")]
	private bool m_CreateEmptyShadowmap; //Field offset: 0x74
	[FieldOffset(Offset = "0x75")]
	[Token(Token = "0x4000D7F")]
	private bool m_SetKeywordForEmptyShadowmap; //Field offset: 0x75
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000D80")]
	private float m_CascadeBorder; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000D81")]
	private float m_MaxShadowDistanceSq; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000D82")]
	private RenderTextureDescriptor m_MainLightShadowDescriptor; //Field offset: 0x80
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000D83")]
	private readonly Vector4[] m_CascadeSplitDistances; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000D84")]
	private readonly Matrix4x4[] m_MainLightShadowMatrices; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000D85")]
	private readonly ProfilingSampler m_ProfilingSetupSampler; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000D86")]
	private readonly ShadowSliceData[] m_CascadeSlices; //Field offset: 0xD0

	[Address(RVA = "0x2E32B10", Offset = "0x2E31F10", Length = "0x58")]
	[Token(Token = "0x6000BFF")]
	private static MainLightShadowCasterPass() { }

	[Address(RVA = "0x2E32B70", Offset = "0x2E31F70", Length = "0x163")]
	[Token(Token = "0x6000BF2")]
	public MainLightShadowCasterPass(RenderPassEvent evt) { }

	[Address(RVA = "0x2E2FDF0", Offset = "0x2E2F1F0", Length = "0x192")]
	[Token(Token = "0x6000BF8")]
	private void Clear() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000BF0")]
	public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	[Address(RVA = "0x2DAC1C0", Offset = "0x2DAB5C0", Length = "0x11")]
	[Token(Token = "0x6000BF3")]
	public void Dispose() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000BF1")]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[Address(RVA = "0x2E2FF90", Offset = "0x2E2F390", Length = "0xDB")]
	[Token(Token = "0x6000BFC")]
	private void InitPassData(ref PassData passData, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, UniversalShadowData shadowData) { }

	[Address(RVA = "0x2E30070", Offset = "0x2E2F470", Length = "0x2CB")]
	[Token(Token = "0x6000BFD")]
	private void InitRendererLists(ref PassData passData, ScriptableRenderContext context, RenderGraph renderGraph, bool useRenderGraph) { }

	[Address(RVA = "0x2E30B60", Offset = "0x2E2FF60", Length = "0x9E4")]
	[Token(Token = "0x6000BFE")]
	internal TextureHandle Render(RenderGraph graph, ContextContainer frameData) { }

	[Address(RVA = "0x2E30340", Offset = "0x2E2F740", Length = "0x81C")]
	[Token(Token = "0x6000BFA")]
	private void RenderMainLightCascadeShadowmap(RasterCommandBuffer cmd, ref PassData data, bool isRenderGraph) { }

	[Address(RVA = "0x2E31550", Offset = "0x2E30950", Length = "0xEB")]
	[Token(Token = "0x6000BF9")]
	internal static void SetShadowParamsForEmptyShadowmap(RasterCommandBuffer rasterCommandBuffer) { }

	[Address(RVA = "0x2E31EF0", Offset = "0x2E312F0", Length = "0xF1")]
	[Token(Token = "0x6000BF4")]
	public bool Setup(ref RenderingData renderingData) { }

	[Address(RVA = "0x2E31FF0", Offset = "0x2E313F0", Length = "0xA50")]
	[Token(Token = "0x6000BF5")]
	public bool Setup(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, UniversalShadowData shadowData) { }

	[Address(RVA = "0x2E31640", Offset = "0x2E30A40", Length = "0x216")]
	[Token(Token = "0x6000BF7")]
	private bool SetupForEmptyRendering(bool stripShadowsOffVariants, bool shadowsEnabled, Light light, UniversalCameraData cameraData, UniversalShadowData shadowData) { }

	[Address(RVA = "0x2E31860", Offset = "0x2E30C60", Length = "0x681")]
	[Token(Token = "0x6000BFB")]
	private void SetupMainLightShadowReceiverConstants(RasterCommandBuffer cmd, ref VisibleLight shadowLight, UniversalShadowData shadowData) { }

	[Address(RVA = "0x2E32A50", Offset = "0x2E31E50", Length = "0xB2")]
	[Token(Token = "0x6000BF6")]
	private void UpdateTextureDescriptorIfNeeded() { }

}

