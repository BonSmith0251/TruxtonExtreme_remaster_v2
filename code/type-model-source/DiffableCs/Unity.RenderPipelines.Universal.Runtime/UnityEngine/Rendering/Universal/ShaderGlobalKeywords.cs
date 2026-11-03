namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001F7")]
internal static class ShaderGlobalKeywords
{
	[Token(Token = "0x4000B07")]
	public static GlobalKeyword MainLightShadows; //Field offset: 0x0
	[Token(Token = "0x4000B08")]
	public static GlobalKeyword MainLightShadowCascades; //Field offset: 0x4
	[Token(Token = "0x4000B09")]
	public static GlobalKeyword MainLightShadowScreen; //Field offset: 0x8
	[Token(Token = "0x4000B0A")]
	public static GlobalKeyword CastingPunctualLightShadow; //Field offset: 0xC
	[Token(Token = "0x4000B0B")]
	public static GlobalKeyword AdditionalLightsVertex; //Field offset: 0x10
	[Token(Token = "0x4000B0C")]
	public static GlobalKeyword AdditionalLightsPixel; //Field offset: 0x14
	[Token(Token = "0x4000B0D")]
	public static GlobalKeyword ClusterLightLoop; //Field offset: 0x18
	[Token(Token = "0x4000B0E")]
	public static GlobalKeyword AdditionalLightShadows; //Field offset: 0x1C
	[Token(Token = "0x4000B0F")]
	public static GlobalKeyword ReflectionProbeBoxProjection; //Field offset: 0x20
	[Token(Token = "0x4000B10")]
	public static GlobalKeyword ReflectionProbeBlending; //Field offset: 0x24
	[Token(Token = "0x4000B11")]
	public static GlobalKeyword ReflectionProbeAtlas; //Field offset: 0x28
	[Token(Token = "0x4000B12")]
	public static GlobalKeyword ReflectionProbeRotation; //Field offset: 0x2C
	[Token(Token = "0x4000B13")]
	public static GlobalKeyword SoftShadows; //Field offset: 0x30
	[Token(Token = "0x4000B14")]
	public static GlobalKeyword SoftShadowsLow; //Field offset: 0x34
	[Token(Token = "0x4000B15")]
	public static GlobalKeyword SoftShadowsMedium; //Field offset: 0x38
	[Token(Token = "0x4000B16")]
	public static GlobalKeyword SoftShadowsHigh; //Field offset: 0x3C
	[Token(Token = "0x4000B17")]
	public static GlobalKeyword MixedLightingSubtractive; //Field offset: 0x40
	[Token(Token = "0x4000B18")]
	public static GlobalKeyword LightmapShadowMixing; //Field offset: 0x44
	[Token(Token = "0x4000B19")]
	public static GlobalKeyword ShadowsShadowMask; //Field offset: 0x48
	[Token(Token = "0x4000B1A")]
	public static GlobalKeyword LightLayers; //Field offset: 0x4C
	[Token(Token = "0x4000B1B")]
	public static GlobalKeyword RenderPassEnabled; //Field offset: 0x50
	[Token(Token = "0x4000B1C")]
	public static GlobalKeyword BillboardFaceCameraPos; //Field offset: 0x54
	[Token(Token = "0x4000B1D")]
	public static GlobalKeyword LightCookies; //Field offset: 0x58
	[Token(Token = "0x4000B1E")]
	public static GlobalKeyword DepthNoMsaa; //Field offset: 0x5C
	[Token(Token = "0x4000B1F")]
	public static GlobalKeyword DepthMsaa2; //Field offset: 0x60
	[Token(Token = "0x4000B20")]
	public static GlobalKeyword DepthMsaa4; //Field offset: 0x64
	[Token(Token = "0x4000B21")]
	public static GlobalKeyword DepthMsaa8; //Field offset: 0x68
	[Token(Token = "0x4000B22")]
	public static GlobalKeyword DBufferMRT1; //Field offset: 0x6C
	[Token(Token = "0x4000B23")]
	public static GlobalKeyword DBufferMRT2; //Field offset: 0x70
	[Token(Token = "0x4000B24")]
	public static GlobalKeyword DBufferMRT3; //Field offset: 0x74
	[Token(Token = "0x4000B25")]
	public static GlobalKeyword DecalNormalBlendLow; //Field offset: 0x78
	[Token(Token = "0x4000B26")]
	public static GlobalKeyword DecalNormalBlendMedium; //Field offset: 0x7C
	[Token(Token = "0x4000B27")]
	public static GlobalKeyword DecalNormalBlendHigh; //Field offset: 0x80
	[Token(Token = "0x4000B28")]
	public static GlobalKeyword DecalLayers; //Field offset: 0x84
	[Token(Token = "0x4000B29")]
	public static GlobalKeyword WriteRenderingLayers; //Field offset: 0x88
	[Token(Token = "0x4000B2A")]
	public static GlobalKeyword ScreenSpaceOcclusion; //Field offset: 0x8C
	[Token(Token = "0x4000B2B")]
	public static GlobalKeyword ScreenSpaceIrradiance; //Field offset: 0x90
	[Token(Token = "0x4000B2C")]
	public static GlobalKeyword _SPOT; //Field offset: 0x94
	[Token(Token = "0x4000B2D")]
	public static GlobalKeyword _DIRECTIONAL; //Field offset: 0x98
	[Token(Token = "0x4000B2E")]
	public static GlobalKeyword _POINT; //Field offset: 0x9C
	[Token(Token = "0x4000B2F")]
	public static GlobalKeyword _DEFERRED_STENCIL; //Field offset: 0xA0
	[Token(Token = "0x4000B30")]
	public static GlobalKeyword _DEFERRED_FIRST_LIGHT; //Field offset: 0xA4
	[Token(Token = "0x4000B31")]
	public static GlobalKeyword _DEFERRED_MAIN_LIGHT; //Field offset: 0xA8
	[Token(Token = "0x4000B32")]
	public static GlobalKeyword _GBUFFER_NORMALS_OCT; //Field offset: 0xAC
	[Token(Token = "0x4000B33")]
	public static GlobalKeyword _DEFERRED_MIXED_LIGHTING; //Field offset: 0xB0
	[Token(Token = "0x4000B34")]
	public static GlobalKeyword LIGHTMAP_ON; //Field offset: 0xB4
	[Token(Token = "0x4000B35")]
	public static GlobalKeyword DYNAMICLIGHTMAP_ON; //Field offset: 0xB8
	[Token(Token = "0x4000B36")]
	public static GlobalKeyword _ALPHATEST_ON; //Field offset: 0xBC
	[Token(Token = "0x4000B37")]
	public static GlobalKeyword DIRLIGHTMAP_COMBINED; //Field offset: 0xC0
	[Token(Token = "0x4000B38")]
	public static GlobalKeyword _DETAIL_MULX2; //Field offset: 0xC4
	[Token(Token = "0x4000B39")]
	public static GlobalKeyword _DETAIL_SCALED; //Field offset: 0xC8
	[Token(Token = "0x4000B3A")]
	public static GlobalKeyword _CLEARCOAT; //Field offset: 0xCC
	[Token(Token = "0x4000B3B")]
	public static GlobalKeyword _CLEARCOATMAP; //Field offset: 0xD0
	[Token(Token = "0x4000B3C")]
	public static GlobalKeyword DEBUG_DISPLAY; //Field offset: 0xD4
	[Token(Token = "0x4000B3D")]
	public static GlobalKeyword LOD_FADE_CROSSFADE; //Field offset: 0xD8
	[Token(Token = "0x4000B3E")]
	public static GlobalKeyword USE_UNITY_CROSSFADE; //Field offset: 0xDC
	[Token(Token = "0x4000B3F")]
	public static GlobalKeyword _EMISSION; //Field offset: 0xE0
	[Token(Token = "0x4000B40")]
	public static GlobalKeyword _RECEIVE_SHADOWS_OFF; //Field offset: 0xE4
	[Token(Token = "0x4000B41")]
	public static GlobalKeyword _SURFACE_TYPE_TRANSPARENT; //Field offset: 0xE8
	[Token(Token = "0x4000B42")]
	public static GlobalKeyword _ALPHAPREMULTIPLY_ON; //Field offset: 0xEC
	[Token(Token = "0x4000B43")]
	public static GlobalKeyword _ALPHAMODULATE_ON; //Field offset: 0xF0
	[Token(Token = "0x4000B44")]
	public static GlobalKeyword _NORMALMAP; //Field offset: 0xF4
	[Token(Token = "0x4000B45")]
	public static GlobalKeyword _ADD_PRECOMPUTED_VELOCITY; //Field offset: 0xF8
	[Token(Token = "0x4000B46")]
	public static GlobalKeyword EDITOR_VISUALIZATION; //Field offset: 0xFC
	[Token(Token = "0x4000B47")]
	public static GlobalKeyword FoveatedRenderingNonUniformRaster; //Field offset: 0x100
	[Token(Token = "0x4000B48")]
	public static GlobalKeyword DisableTexture2DXArray; //Field offset: 0x104
	[Token(Token = "0x4000B49")]
	public static GlobalKeyword BlitSingleSlice; //Field offset: 0x108
	[Token(Token = "0x4000B4A")]
	public static GlobalKeyword XROcclusionMeshCombined; //Field offset: 0x10C
	[Token(Token = "0x4000B4B")]
	public static GlobalKeyword SCREEN_COORD_OVERRIDE; //Field offset: 0x110
	[Token(Token = "0x4000B4C")]
	public static GlobalKeyword DOWNSAMPLING_SIZE_2; //Field offset: 0x114
	[Token(Token = "0x4000B4D")]
	public static GlobalKeyword DOWNSAMPLING_SIZE_4; //Field offset: 0x118
	[Token(Token = "0x4000B4E")]
	public static GlobalKeyword DOWNSAMPLING_SIZE_8; //Field offset: 0x11C
	[Token(Token = "0x4000B4F")]
	public static GlobalKeyword DOWNSAMPLING_SIZE_16; //Field offset: 0x120
	[Token(Token = "0x4000B50")]
	public static GlobalKeyword EVALUATE_SH_MIXED; //Field offset: 0x124
	[Token(Token = "0x4000B51")]
	public static GlobalKeyword EVALUATE_SH_VERTEX; //Field offset: 0x128
	[Token(Token = "0x4000B52")]
	public static GlobalKeyword ProbeVolumeL1; //Field offset: 0x12C
	[Token(Token = "0x4000B53")]
	public static GlobalKeyword ProbeVolumeL2; //Field offset: 0x130
	[Token(Token = "0x4000B54")]
	public static GlobalKeyword LIGHTMAP_BICUBIC_SAMPLING; //Field offset: 0x134
	[Token(Token = "0x4000B55")]
	public static GlobalKeyword _OUTPUT_DEPTH; //Field offset: 0x138
	[Token(Token = "0x4000B56")]
	public static GlobalKeyword LinearToSRGBConversion; //Field offset: 0x13C
	[Token(Token = "0x4000B57")]
	public static GlobalKeyword _ENABLE_ALPHA_OUTPUT; //Field offset: 0x140
	[Token(Token = "0x4000B58")]
	public static GlobalKeyword ForwardPlus; //Field offset: 0x144

	[Address(RVA = "0x2E08AF0", Offset = "0x2E07EF0", Length = "0xE84")]
	[Token(Token = "0x6000AC1")]
	public static void InitializeShaderGlobalKeywords() { }

}

