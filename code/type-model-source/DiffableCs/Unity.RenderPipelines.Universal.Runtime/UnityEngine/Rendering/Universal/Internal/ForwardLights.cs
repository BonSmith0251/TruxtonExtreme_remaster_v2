namespace UnityEngine.Rendering.Universal.Internal;

[Token(Token = "0x200021F")]
public class ForwardLights
{
	[CompilerGenerated]
	[Token(Token = "0x2000223")]
	private sealed class <>c
	{
		[Token(Token = "0x4000D62")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000D63")]
		public static BaseRenderFunc<SetupLightPassData, UnsafeGraphContext> <>9__45_0; //Field offset: 0x8

		[Address(RVA = "0x2E358E0", Offset = "0x2E34CE0", Length = "0x67")]
		[Token(Token = "0x6000BDE")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000BDF")]
		public <>c() { }

		[Address(RVA = "0x2E35510", Offset = "0x2E34910", Length = "0x47")]
		[Token(Token = "0x6000BE0")]
		internal void <SetupRenderGraphLights>b__45_0(SetupLightPassData data, UnsafeGraphContext rgContext) { }

	}

	[Token(Token = "0x2000221")]
	public struct InitParams
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000D5C")]
		public LightCookieManager lightCookieManager; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000D5D")]
		public bool forwardPlus; //Field offset: 0x8

		[Address(RVA = "0x2E2FCD0", Offset = "0x2E2F0D0", Length = "0x11D")]
		[Token(Token = "0x6000BDC")]
		internal static InitParams Create() { }

	}

	[Token(Token = "0x2000220")]
	private static class LightConstantBuffer
	{
		[Token(Token = "0x4000D51")]
		public static int _MainLightPosition; //Field offset: 0x0
		[Token(Token = "0x4000D52")]
		public static int _MainLightColor; //Field offset: 0x4
		[Token(Token = "0x4000D53")]
		public static int _MainLightOcclusionProbesChannel; //Field offset: 0x8
		[Token(Token = "0x4000D54")]
		public static int _MainLightLayerMask; //Field offset: 0xC
		[Token(Token = "0x4000D55")]
		public static int _AdditionalLightsCount; //Field offset: 0x10
		[Token(Token = "0x4000D56")]
		public static int _AdditionalLightsPosition; //Field offset: 0x14
		[Token(Token = "0x4000D57")]
		public static int _AdditionalLightsColor; //Field offset: 0x18
		[Token(Token = "0x4000D58")]
		public static int _AdditionalLightsAttenuation; //Field offset: 0x1C
		[Token(Token = "0x4000D59")]
		public static int _AdditionalLightsSpotDir; //Field offset: 0x20
		[Token(Token = "0x4000D5A")]
		public static int _AdditionalLightOcclusionProbeChannel; //Field offset: 0x24
		[Token(Token = "0x4000D5B")]
		public static int _AdditionalLightsLayerMasks; //Field offset: 0x28

	}

	[Token(Token = "0x2000222")]
	private class SetupLightPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000D5E")]
		internal UniversalRenderingData renderingData; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000D5F")]
		internal UniversalCameraData cameraData; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000D60")]
		internal UniversalLightData lightData; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000D61")]
		internal ForwardLights forwardLights; //Field offset: 0x28

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000BDD")]
		public SetupLightPassData() { }

	}

	[Token(Token = "0x4000D33")]
	private const string k_SetupLightConstants = "Setup Light Constants"; //Field offset: 0x0
	[Token(Token = "0x4000D34")]
	private static readonly ProfilingSampler m_ProfilingSampler; //Field offset: 0x0
	[Token(Token = "0x4000D35")]
	private static readonly ProfilingSampler m_ProfilingSamplerFPSetup; //Field offset: 0x8
	[Token(Token = "0x4000D36")]
	private static readonly ProfilingSampler m_ProfilingSamplerFPComplete; //Field offset: 0x10
	[Token(Token = "0x4000D37")]
	private static readonly ProfilingSampler m_ProfilingSamplerFPUpload; //Field offset: 0x18
	[Token(Token = "0x4000D50")]
	private static ProfilingSampler s_SetupForwardLights; //Field offset: 0x20
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D31")]
	private int m_AdditionalLightsBufferId; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000D32")]
	private int m_AdditionalLightsIndicesId; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D38")]
	private MixedLightingSetup m_MixedLightingSetup; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D39")]
	private Vector4[] m_AdditionalLightPositions; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D3A")]
	private Vector4[] m_AdditionalLightColors; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D3B")]
	private Vector4[] m_AdditionalLightAttenuations; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D3C")]
	private Vector4[] m_AdditionalLightSpotDirections; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000D3D")]
	private Vector4[] m_AdditionalLightOcclusionProbeChannels; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000D3E")]
	private Single[] m_AdditionalLightsLayerMasks; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000D3F")]
	private bool m_UseStructuredBuffer; //Field offset: 0x50
	[FieldOffset(Offset = "0x51")]
	[Token(Token = "0x4000D40")]
	private bool m_UseForwardPlus; //Field offset: 0x51
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000D41")]
	private int m_DirectionalLightCount; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000D42")]
	private int m_ActualTileWidth; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000D43")]
	private int2 m_TileResolution; //Field offset: 0x5C
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D44")]
	private JobHandle m_CullingHandle; //Field offset: 0x68
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000D45")]
	private NativeArray<UInt32> m_ZBins; //Field offset: 0x78
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000D46")]
	private GraphicsBuffer m_ZBinsBuffer; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000D47")]
	private NativeArray<UInt32> m_TileMasks; //Field offset: 0x90
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000D48")]
	private GraphicsBuffer m_TileMasksBuffer; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000D49")]
	private LightCookieManager m_LightCookieManager; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000D4A")]
	private ReflectionProbeManager m_ReflectionProbeManager; //Field offset: 0xB0
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000D4B")]
	private int m_WordsPerTile; //Field offset: 0x140
	[FieldOffset(Offset = "0x144")]
	[Token(Token = "0x4000D4C")]
	private float m_ZBinScale; //Field offset: 0x144
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000D4D")]
	private float m_ZBinOffset; //Field offset: 0x148
	[FieldOffset(Offset = "0x14C")]
	[Token(Token = "0x4000D4E")]
	private int m_LightCount; //Field offset: 0x14C
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000D4F")]
	private int m_BinCount; //Field offset: 0x150

	[Token(Token = "0x170002CD")]
	internal ReflectionProbeManager reflectionProbeManager
	{
		[Address(RVA = "0x2E2E060", Offset = "0x2E2D460", Length = "0x69")]
		[Token(Token = "0x6000BCD")]
		internal get { } //Length: 105
	}

	[Address(RVA = "0x2E2D8B0", Offset = "0x2E2CCB0", Length = "0x1EB")]
	[Token(Token = "0x6000BDA")]
	private static ForwardLights() { }

	[Address(RVA = "0x2E2DAA0", Offset = "0x2E2CEA0", Length = "0x13C")]
	[Token(Token = "0x6000BCA")]
	public ForwardLights() { }

	[Address(RVA = "0x2E2DBE0", Offset = "0x2E2CFE0", Length = "0x47D")]
	[Token(Token = "0x6000BCB")]
	internal ForwardLights(InitParams initParams) { }

	[Address(RVA = "0x2E2D720", Offset = "0x2E2CB20", Length = "0x18D")]
	[CompilerGenerated]
	[Token(Token = "0x6000BDB")]
	internal static bool <ScheduleClusteringJobs>g__IsProbeGreater|41_0(VisibleReflectionProbe probe, VisibleReflectionProbe otherProbe) { }

	[Address(RVA = "0x2E29280", Offset = "0x2E28680", Length = "0x18")]
	[Token(Token = "0x6000BCE")]
	private static int AlignByteCount(int count, int align) { }

	[Address(RVA = "0x2E292A0", Offset = "0x2E286A0", Length = "0xFD")]
	[Token(Token = "0x6000BD4")]
	internal void Cleanup() { }

	[Address(RVA = "0x2E293A0", Offset = "0x2E287A0", Length = "0x1F9")]
	[Token(Token = "0x6000BCC")]
	private void CreateForwardPlusBuffers() { }

	[Address(RVA = "0x2E2E060", Offset = "0x2E2D460", Length = "0x69")]
	[Token(Token = "0x6000BCD")]
	internal ReflectionProbeManager get_reflectionProbeManager() { }

	[Address(RVA = "0x2E295A0", Offset = "0x2E289A0", Length = "0x1C6")]
	[Token(Token = "0x6000BCF")]
	private static void GetViewParams(bool isOrthographic, float4x4 viewToClip, out float viewPlaneBot, out float viewPlaneTop, out float4 viewToViewportScaleBias) { }

	[Address(RVA = "0x2E29770", Offset = "0x2E28B70", Length = "0x258")]
	[Token(Token = "0x6000BD5")]
	private void InitializeLightConstants(NativeArray<VisibleLight> lights, int lightIndex, bool supportsLightLayers, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel, out uint lightLayerMask, out bool isSubtractive) { }

	[Address(RVA = "0x2E299D0", Offset = "0x2E28DD0", Length = "0xA4E")]
	[Token(Token = "0x6000BD1")]
	internal void PreSetup(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData) { }

	[Address(RVA = "0x2E2A420", Offset = "0x2E29820", Length = "0x1445")]
	[Token(Token = "0x6000BD0")]
	internal static JobHandle ScheduleClusteringJobs(bool hasMainLight, bool supportsAdditionalLights, NativeArray<VisibleLight> lights, NativeArray<VisibleReflectionProbe> probes, NativeArray<UInt32> zBins, NativeArray<UInt32> tileMasks, Fixed2<float4x4> worldToViews, Fixed2<float4x4> viewToClips, int viewCount, int2 screenResolution, float nearClipPlane, float farClipPlane, bool isOrthographic, out int localLightCount, out int directionalLightCount, out int binCount, out float zBinScale, out float zBinOffset, out int2 tileResolution, out int actualTileWidth, out int wordsPerTile) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000BC9")]
	public void Setup(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[Address(RVA = "0x2E2B870", Offset = "0x2E2AC70", Length = "0x6A6")]
	[Token(Token = "0x6000BD8")]
	private void SetupAdditionalLightConstants(UnsafeCommandBuffer cmd, ref CullingResults cullResults, UniversalLightData lightData) { }

	[Address(RVA = "0x2E2BF20", Offset = "0x2E2B320", Length = "0xD54")]
	[Token(Token = "0x6000BD3")]
	internal void SetupLights(UnsafeCommandBuffer cmd, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData) { }

	[Address(RVA = "0x2E2CC80", Offset = "0x2E2C080", Length = "0x34A")]
	[Token(Token = "0x6000BD7")]
	private void SetupMainLightConstants(UnsafeCommandBuffer cmd, UniversalLightData lightData) { }

	[Address(RVA = "0x2E2CFD0", Offset = "0x2E2C3D0", Length = "0x35F")]
	[Token(Token = "0x6000BD9")]
	private int SetupPerObjectLightIndices(CullingResults cullResults, UniversalLightData lightData) { }

	[Address(RVA = "0x2E2D330", Offset = "0x2E2C730", Length = "0x383")]
	[Token(Token = "0x6000BD2")]
	internal void SetupRenderGraphLights(RenderGraph renderGraph, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData) { }

	[Address(RVA = "0x2E2D6C0", Offset = "0x2E2CAC0", Length = "0x60")]
	[Token(Token = "0x6000BD6")]
	private void SetupShaderLightConstants(UnsafeCommandBuffer cmd, ref CullingResults cullResults, UniversalLightData lightData) { }

}

