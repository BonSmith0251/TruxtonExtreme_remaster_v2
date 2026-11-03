namespace UnityEngine.Rendering.Universal;

[Extension]
[Token(Token = "0x2000040")]
internal static class RendererLighting
{
	[Token(Token = "0x400014A")]
	private static readonly ProfilingSampler m_ProfilingSampler; //Field offset: 0x0
	[Token(Token = "0x400014B")]
	private static readonly ShaderTagId k_NormalsRenderingPassName; //Field offset: 0x8
	[Token(Token = "0x400014C")]
	public static readonly Color k_NormalClearColor; //Field offset: 0xC
	[Token(Token = "0x400014D")]
	private static readonly string k_UsePointLightCookiesKeyword; //Field offset: 0x20
	[Token(Token = "0x400014E")]
	private static readonly string k_LightQualityFastKeyword; //Field offset: 0x28
	[Token(Token = "0x400014F")]
	private static readonly string k_UseNormalMap; //Field offset: 0x30
	[Token(Token = "0x4000150")]
	private static readonly string k_UseShadowMap; //Field offset: 0x38
	[Token(Token = "0x4000151")]
	private static readonly string k_UseAdditiveBlendingKeyword; //Field offset: 0x40
	[Token(Token = "0x4000152")]
	private static readonly string k_UseVolumetric; //Field offset: 0x48
	[Token(Token = "0x4000153")]
	private static readonly String[] k_UseBlendStyleKeywords; //Field offset: 0x50
	[Token(Token = "0x4000154")]
	private static readonly Int32[] k_BlendFactorsPropIDs; //Field offset: 0x58
	[Token(Token = "0x4000155")]
	private static readonly Int32[] k_MaskFilterPropIDs; //Field offset: 0x60
	[Token(Token = "0x4000156")]
	private static readonly Int32[] k_InvertedFilterPropIDs; //Field offset: 0x68
	[Token(Token = "0x4000157")]
	public static readonly String[] k_ShapeLightTextureIDs; //Field offset: 0x70
	[Token(Token = "0x4000158")]
	private static GraphicsFormat s_RenderTextureFormatToUse; //Field offset: 0x78
	[Token(Token = "0x4000159")]
	private static bool s_HasSetupRenderTextureFormatToUse; //Field offset: 0x7C
	[Token(Token = "0x400015A")]
	private static readonly int k_SrcBlendID; //Field offset: 0x80
	[Token(Token = "0x400015B")]
	private static readonly int k_DstBlendID; //Field offset: 0x84
	[Token(Token = "0x400015C")]
	private static readonly int k_CookieTexID; //Field offset: 0x88
	[Token(Token = "0x400015D")]
	private static readonly int k_PointLightCookieTexID; //Field offset: 0x8C
	[Token(Token = "0x400015E")]
	private static readonly int k_L2DInvMatrix; //Field offset: 0x90
	[Token(Token = "0x400015F")]
	private static readonly int k_L2DColor; //Field offset: 0x94
	[Token(Token = "0x4000160")]
	private static readonly int k_L2DPosition; //Field offset: 0x98
	[Token(Token = "0x4000161")]
	private static readonly int k_L2DFalloffIntensity; //Field offset: 0x9C
	[Token(Token = "0x4000162")]
	private static readonly int k_L2DFalloffDistance; //Field offset: 0xA0
	[Token(Token = "0x4000163")]
	private static readonly int k_L2DOuterAngle; //Field offset: 0xA4
	[Token(Token = "0x4000164")]
	private static readonly int k_L2DInnerAngle; //Field offset: 0xA8
	[Token(Token = "0x4000165")]
	private static readonly int k_L2DInnerRadiusMult; //Field offset: 0xAC
	[Token(Token = "0x4000166")]
	private static readonly int k_L2DVolumeOpacity; //Field offset: 0xB0
	[Token(Token = "0x4000167")]
	private static readonly int k_L2DShadowIntensity; //Field offset: 0xB4
	[Token(Token = "0x4000168")]
	private static readonly int k_L2DLightType; //Field offset: 0xB8
	[Token(Token = "0x4000169")]
	internal static LightBatch lightBatch; //Field offset: 0xC0

	[Address(RVA = "0x2D2EFC0", Offset = "0x2D2E3C0", Length = "0xB5D")]
	[Token(Token = "0x60001B3")]
	private static RendererLighting() { }

	[Address(RVA = "0x2D2CE80", Offset = "0x2D2C280", Length = "0x72")]
	[Token(Token = "0x60001A6")]
	internal static bool CanCastShadows(Light2D light, int layerToRender) { }

	[Address(RVA = "0x2D2CF00", Offset = "0x2D2C300", Length = "0x3BC")]
	[Token(Token = "0x60001B0")]
	private static Material CreateLightMaterial(Renderer2DData rendererData, Light2D light, bool isVolume, bool useShadows) { }

	[Address(RVA = "0x2D2D2C0", Offset = "0x2D2C6C0", Length = "0x144")]
	[Token(Token = "0x60001A4")]
	internal static void DisableAllKeywords(IRasterCommandBuffer cmd) { }

	[Address(RVA = "0x2D2D410", Offset = "0x2D2C810", Length = "0xB9")]
	[Token(Token = "0x60001A3")]
	internal static void EnableBlendStyle(IRasterCommandBuffer cmd, int blendStyleIndex, bool enabled) { }

	[Address(RVA = "0x2D2D4D0", Offset = "0x2D2C8D0", Length = "0xD3")]
	[Extension]
	[Token(Token = "0x60001B2")]
	internal static short GetCameraSortingLayerBoundsIndex(Renderer2DData rendererData) { }

	[Address(RVA = "0x2D2D700", Offset = "0x2D2CB00", Length = "0x228")]
	[Extension]
	[Token(Token = "0x60001B1")]
	internal static Material GetLightMaterial(Renderer2DData rendererData, Light2D light, bool isVolume, bool useShadows) { }

	[Address(RVA = "0x2D2D5B0", Offset = "0x2D2C9B0", Length = "0x14E")]
	[Token(Token = "0x60001AF")]
	private static uint GetLightMaterialIndex(Light2D light, bool isVolume, bool useShadows) { }

	[Address(RVA = "0x2D2D930", Offset = "0x2D2CD30", Length = "0x9")]
	[Token(Token = "0x60001A9")]
	private static float GetNormalizedAngle(float angle) { }

	[Address(RVA = "0x2D2D940", Offset = "0x2D2CD40", Length = "0x23")]
	[Token(Token = "0x60001A8")]
	private static float GetNormalizedInnerRadius(Light2D light) { }

	[Address(RVA = "0x2D2D970", Offset = "0x2D2CD70", Length = "0x139")]
	[Token(Token = "0x60001A2")]
	internal static GraphicsFormat GetRenderTextureFormat() { }

	[Address(RVA = "0x2D2DAB0", Offset = "0x2D2CEB0", Length = "0x1A0")]
	[Token(Token = "0x60001AA")]
	private static void GetScaledLightInvMatrix(Light2D light, out Matrix4x4 retMatrix) { }

	[Address(RVA = "0x2D2DC60", Offset = "0x2D2D060", Length = "0xA8")]
	[Token(Token = "0x60001A5")]
	internal static void GetTransparencySortingMode(Renderer2DData rendererData, Camera camera, ref SortingSettings sortingSettings) { }

	[Address(RVA = "0x2D2DD10", Offset = "0x2D2D110", Length = "0xB0")]
	[Token(Token = "0x60001AE")]
	private static void SetBlendModes(Material material, BlendMode src, BlendMode dst) { }

	[Address(RVA = "0x2D2DDD0", Offset = "0x2D2D1D0", Length = "0x13E")]
	[Token(Token = "0x60001AD")]
	internal static void SetCookieShaderProperties(Light2D light, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2D2DF10", Offset = "0x2D2D310", Length = "0x2ED")]
	[Token(Token = "0x60001A7")]
	internal static void SetLightShaderGlobals(IRasterCommandBuffer cmd, Light2DBlendStyle[] lightBlendStyles, Int32[] blendStyleIndices) { }

	[Address(RVA = "0x2D2E200", Offset = "0x2D2D600", Length = "0x741")]
	[Token(Token = "0x60001AB")]
	internal static void SetPerLightShaderGlobals(IRasterCommandBuffer cmd, Light2D light, int slot, bool isVolumetric, bool hasShadows, bool batchingSupported) { }

	[Address(RVA = "0x2D2E950", Offset = "0x2D2DD50", Length = "0x66F")]
	[Token(Token = "0x60001AC")]
	internal static void SetPerPointLightShaderGlobals(IRasterCommandBuffer cmd, Light2D light, int slot, bool batchingSupported) { }

}

