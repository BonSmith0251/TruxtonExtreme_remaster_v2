namespace UnityEngine.Rendering.Universal.Internal;

[Token(Token = "0x2000207")]
public class AdditionalLightsShadowCasterPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x200020A")]
	private sealed class <>c
	{
		[Token(Token = "0x4000CBC")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000CBD")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__59_0; //Field offset: 0x8

		[Address(RVA = "0x2E35720", Offset = "0x2E34B20", Length = "0x67")]
		[Token(Token = "0x6000B5D")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000B5E")]
		public <>c() { }

		[Address(RVA = "0x2E35380", Offset = "0x2E34780", Length = "0xD6")]
		[Token(Token = "0x6000B5F")]
		internal void <Render>b__59_0(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x2000208")]
	private static class AdditionalShadowsConstantBuffer
	{
		[Token(Token = "0x4000CA6")]
		public static readonly int _AdditionalLightsWorldToShadow; //Field offset: 0x0
		[Token(Token = "0x4000CA7")]
		public static readonly int _AdditionalShadowParams; //Field offset: 0x4
		[Token(Token = "0x4000CA8")]
		public static readonly int _AdditionalShadowOffset0; //Field offset: 0x8
		[Token(Token = "0x4000CA9")]
		public static readonly int _AdditionalShadowOffset1; //Field offset: 0xC
		[Token(Token = "0x4000CAA")]
		public static readonly int _AdditionalShadowFadeParams; //Field offset: 0x10
		[Token(Token = "0x4000CAB")]
		public static readonly int _AdditionalShadowmapSize; //Field offset: 0x14
		[Token(Token = "0x4000CAC")]
		public static readonly int _AdditionalLightsShadowmapID; //Field offset: 0x18
		[Token(Token = "0x4000CAD")]
		public static readonly int _AdditionalLightsWorldToShadow_SSBO; //Field offset: 0x1C
		[Token(Token = "0x4000CAE")]
		public static readonly int _AdditionalShadowParams_SSBO; //Field offset: 0x20

		[Address(RVA = "0x2E1DFE0", Offset = "0x2E1D3E0", Length = "0x1A7")]
		[Token(Token = "0x6000B5B")]
		private static AdditionalShadowsConstantBuffer() { }

	}

	[Token(Token = "0x2000209")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000CAF")]
		internal int shadowmapID; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000CB0")]
		internal bool emptyShadowmap; //Field offset: 0x14
		[FieldOffset(Offset = "0x15")]
		[Token(Token = "0x4000CB1")]
		internal bool setKeywordForEmptyShadowmap; //Field offset: 0x15
		[FieldOffset(Offset = "0x16")]
		[Token(Token = "0x4000CB2")]
		internal bool useStructuredBuffer; //Field offset: 0x16
		[FieldOffset(Offset = "0x17")]
		[Token(Token = "0x4000CB3")]
		internal bool stripShadowsOffVariants; //Field offset: 0x17
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000CB4")]
		internal Matrix4x4 viewMatrix; //Field offset: 0x18
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000CB5")]
		internal Vector2Int allocatedShadowAtlasSize; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000CB6")]
		internal TextureHandle shadowmapTexture; //Field offset: 0x60
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000CB7")]
		internal UniversalLightData lightData; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000CB8")]
		internal UniversalShadowData shadowData; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000CB9")]
		internal AdditionalLightsShadowCasterPass pass; //Field offset: 0x80
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000CBA")]
		internal readonly RendererList[] shadowRendererLists; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000CBB")]
		internal readonly RendererListHandle[] shadowRendererListsHdl; //Field offset: 0x90

		[Address(RVA = "0x2E33670", Offset = "0x2E32A70", Length = "0x8E")]
		[Token(Token = "0x6000B5C")]
		public PassData() { }

	}

	[Obsolete("AdditionalLightsShadowCasterPass.m_AdditionalShadowsBufferId was deprecated. Shadow slice matrix is now passed to the GPU using an entry in buffer m_AdditionalLightsWorldToShadow_SSBO #from(2021.1) #breakingFrom(2023.1)", True)]
	[Token(Token = "0x4000C83")]
	public static int m_AdditionalShadowsBufferId; //Field offset: 0x0
	[Token(Token = "0x4000CA1")]
	private const string k_AdditionalLightShadowMapTextureName = "_AdditionalLightsShadowmapTexture"; //Field offset: 0x0
	[Token(Token = "0x4000CA0")]
	private const float k_LightTypeIdentifierInShadowParams_Point = 1; //Field offset: 0x0
	[Token(Token = "0x4000C9F")]
	private const float k_LightTypeIdentifierInShadowParams_Spot = 0; //Field offset: 0x0
	[Token(Token = "0x4000C9E")]
	private const int k_ShadowmapBufferBits = 16; //Field offset: 0x0
	[Obsolete("AdditionalLightsShadowCasterPass.m_AdditionalShadowsIndicesId was deprecated. Shadow slice index is now passed to the GPU using last member of an entry in buffer m_AdditionalShadowParams_SSBO #from(2021.1) #breakingFrom(2023.1)", True)]
	[Token(Token = "0x4000C84")]
	public static int m_AdditionalShadowsIndicesId; //Field offset: 0x4
	[Token(Token = "0x4000C8E")]
	private static bool m_IssuedMessageAboutPointLightHardShadowResolutionTooSmall; //Field offset: 0x8
	[Token(Token = "0x4000C8F")]
	private static bool m_IssuedMessageAboutPointLightSoftShadowResolutionTooSmall; //Field offset: 0x9
	[Token(Token = "0x4000CA2")]
	private static readonly Vector4 c_DefaultShadowParams; //Field offset: 0xC
	[Token(Token = "0x4000CA3")]
	private static Vector4 s_EmptyAdditionalShadowFadeParams; //Field offset: 0x1C
	[Token(Token = "0x4000CA4")]
	private static Vector4[] s_EmptyAdditionalLightIndexToShadowParams; //Field offset: 0x30
	[Token(Token = "0x4000CA5")]
	private static bool isAdditionalShadowParamsDirty; //Field offset: 0x38
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000C85")]
	internal RTHandle m_AdditionalLightsShadowmapHandle; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000C86")]
	private int renderTargetWidth; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000C87")]
	private int renderTargetHeight; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000C88")]
	private bool m_CreateEmptyShadowmap; //Field offset: 0x70
	[FieldOffset(Offset = "0x71")]
	[Token(Token = "0x4000C89")]
	private bool m_SetKeywordForEmptyShadowmap; //Field offset: 0x71
	[FieldOffset(Offset = "0x72")]
	[Token(Token = "0x4000C8A")]
	private bool m_IssuedMessageAboutShadowSlicesTooMany; //Field offset: 0x72
	[FieldOffset(Offset = "0x73")]
	[Token(Token = "0x4000C8B")]
	private bool m_IssuedMessageAboutShadowMapsRescale; //Field offset: 0x73
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000C8C")]
	private bool m_IssuedMessageAboutShadowMapsTooBig; //Field offset: 0x74
	[FieldOffset(Offset = "0x75")]
	[Token(Token = "0x4000C8D")]
	private bool m_IssuedMessageAboutRemovedShadowSlices; //Field offset: 0x75
	[FieldOffset(Offset = "0x76")]
	[Token(Token = "0x4000C90")]
	private readonly bool m_UseStructuredBuffer; //Field offset: 0x76
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000C91")]
	private float m_MaxShadowDistanceSq; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000C92")]
	private float m_CascadeBorder; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000C93")]
	private Boolean[] m_VisibleLightIndexToIsCastingShadows; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000C94")]
	private Int16[] m_VisibleLightIndexToAdditionalLightIndex; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000C95")]
	private Int16[] m_AdditionalLightIndexToVisibleLightIndex; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000C96")]
	private Vector4[] m_AdditionalLightIndexToShadowParams; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000C97")]
	private Matrix4x4[] m_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000C98")]
	private ShadowSliceData[] m_AdditionalLightsShadowSlices; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000C99")]
	private readonly List<Byte> m_GlobalShadowSliceIndexToPerLightShadowSliceIndex; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000C9A")]
	private readonly List<Int16> m_ShadowSliceToAdditionalLightIndex; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000C9B")]
	private readonly Dictionary<Int32, UInt64> m_ShadowRequestsHashes; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000C9C")]
	private readonly ProfilingSampler m_ProfilingSetupSampler; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000C9D")]
	private RenderTextureDescriptor m_AdditionalLightShadowDescriptor; //Field offset: 0xD0

	[Address(RVA = "0x2E1DB80", Offset = "0x2E1CF80", Length = "0x3F")]
	[Token(Token = "0x6000B5A")]
	private static AdditionalLightsShadowCasterPass() { }

	[Address(RVA = "0x2E1DBC0", Offset = "0x2E1CFC0", Length = "0x41F")]
	[Token(Token = "0x6000B45")]
	public AdditionalLightsShadowCasterPass(RenderPassEvent evt) { }

	[Address(RVA = "0x2E18890", Offset = "0x2E17C90", Length = "0x18D")]
	[Token(Token = "0x6000B50")]
	private bool AnyAdditionalLightHasMixedShadows(UniversalLightData lightData) { }

	[Address(RVA = "0x2E18A20", Offset = "0x2E17E20", Length = "0x8B")]
	[Token(Token = "0x6000B47")]
	internal static float CalcGuardAngle(float frustumAngleInDegrees, float guardBandSizeInTexels, float sliceResolutionInTexels) { }

	[Address(RVA = "0x2E18AB0", Offset = "0x2E17EB0", Length = "0x65")]
	[Token(Token = "0x6000B53")]
	private void Clear() { }

	[Address(RVA = "0x2E18B20", Offset = "0x2E17F20", Length = "0x33C")]
	[Token(Token = "0x6000B4A")]
	private ulong ComputeShadowRequestHash(UniversalLightData lightData, UniversalShadowData shadowData) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000B43")]
	public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	[Address(RVA = "0x2DAC1C0", Offset = "0x2DAB5C0", Length = "0x11")]
	[Token(Token = "0x6000B46")]
	public void Dispose() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000B44")]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[Address(RVA = "0x2E18E60", Offset = "0x2E18260", Length = "0x1F")]
	[Token(Token = "0x6000B4B")]
	private float GetLightTypeIdentifierForShadowParams(LightType lightType) { }

	[Address(RVA = "0x2E18E80", Offset = "0x2E18280", Length = "0x319")]
	[Token(Token = "0x6000B48")]
	internal static float GetPointLightShadowFrustumFovBiasInDegrees(int shadowSliceResolution, bool shadowFiltering) { }

	[Address(RVA = "0x2E191A0", Offset = "0x2E185A0", Length = "0x66")]
	[Token(Token = "0x6000B52")]
	public int GetShadowLightIndexFromLightIndex(int visibleLightIndex) { }

	[Address(RVA = "0x2E19210", Offset = "0x2E18610", Length = "0x124")]
	[Token(Token = "0x6000B57")]
	private void InitPassData(ref PassData passData, UniversalCameraData cameraData, UniversalLightData lightData, UniversalShadowData shadowData) { }

	[Address(RVA = "0x2E19340", Offset = "0x2E18740", Length = "0x32D")]
	[Token(Token = "0x6000B58")]
	private void InitRendererLists(ref CullingResults cullResults, ref PassData passData, ScriptableRenderContext context, RenderGraph renderGraph, bool useRenderGraph) { }

	[Address(RVA = "0x2E1A250", Offset = "0x2E19650", Length = "0x96C")]
	[Token(Token = "0x6000B59")]
	internal TextureHandle Render(RenderGraph graph, ContextContainer frameData) { }

	[Address(RVA = "0x2E19670", Offset = "0x2E18A70", Length = "0xBD8")]
	[Token(Token = "0x6000B55")]
	private void RenderAdditionalShadowmapAtlas(RasterCommandBuffer cmd, ref PassData data, bool useRenderGraph) { }

	[Address(RVA = "0x2E1ABC0", Offset = "0x2E19FC0", Length = "0x4C")]
	[Token(Token = "0x6000B49")]
	private ulong ResolutionLog2ForHash(int resolution) { }

	[Address(RVA = "0x2E1AC10", Offset = "0x2E1A010", Length = "0x258")]
	[Token(Token = "0x6000B54")]
	internal static void SetShadowParamsForEmptyShadowmap(RasterCommandBuffer rasterCommandBuffer) { }

	[Address(RVA = "0x2E1D980", Offset = "0x2E1CD80", Length = "0xF1")]
	[Token(Token = "0x6000B4D")]
	public bool Setup(ref RenderingData renderingData) { }

	[Address(RVA = "0x2E1B8F0", Offset = "0x2E1ACF0", Length = "0x208E")]
	[Token(Token = "0x6000B4E")]
	public bool Setup(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, UniversalShadowData shadowData) { }

	[Address(RVA = "0x2E1AE70", Offset = "0x2E1A270", Length = "0x41C")]
	[Token(Token = "0x6000B56")]
	private void SetupAdditionalLightsShadowReceiverConstants(RasterCommandBuffer cmd, Vector2Int allocatedShadowAtlasSize, bool useStructuredBuffer, bool softShadows) { }

	[Address(RVA = "0x2E1B290", Offset = "0x2E1A690", Length = "0x656")]
	[Token(Token = "0x6000B51")]
	private bool SetupForEmptyRendering(bool stripShadowsOffVariants, bool shadowsEnabled, UniversalLightData lightData, UniversalShadowData shadowData) { }

	[Address(RVA = "0x2E1DA80", Offset = "0x2E1CE80", Length = "0xB5")]
	[Token(Token = "0x6000B4F")]
	private void UpdateTextureDescriptorIfNeeded() { }

	[Address(RVA = "0x2E1DB40", Offset = "0x2E1CF40", Length = "0x32")]
	[Token(Token = "0x6000B4C")]
	private bool UsesBakedShadows(Light light) { }

}

