namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001AB")]
public static class ShadowUtils
{
	[Token(Token = "0x4000945")]
	internal static readonly bool m_ForceShadowPointSampling; //Field offset: 0x0
	[Token(Token = "0x4000946")]
	internal const int kMinimumPunctualLightHardShadowResolution = 8; //Field offset: 0x0
	[Token(Token = "0x4000947")]
	internal const int kMinimumPunctualLightSoftShadowResolution = 16; //Field offset: 0x0

	[Address(RVA = "0x2DF0740", Offset = "0x2DEFB40", Length = "0xBB")]
	[Token(Token = "0x6000921")]
	private static ShadowUtils() { }

	[Address(RVA = "0x2DED290", Offset = "0x2DEC690", Length = "0x124")]
	[Token(Token = "0x600093C")]
	public static RTHandle AllocShadowRT(int width, int height, int bits, int anisoLevel, float mipMapBias, string name) { }

	[Address(RVA = "0x2DED3C0", Offset = "0x2DEC7C0", Length = "0x1C3")]
	[Token(Token = "0x600092D")]
	public static void ApplySliceTransform(ref ShadowSliceData shadowSliceData, int atlasWidth, int atlasHeight) { }

	[Address(RVA = "0x2DED590", Offset = "0x2DEC990", Length = "0x167")]
	[Token(Token = "0x6000922")]
	public static bool ExtractDirectionalLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix) { }

	[Address(RVA = "0x2DED700", Offset = "0x2DECB00", Length = "0x92")]
	[Token(Token = "0x6000923")]
	public static bool ExtractDirectionalLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData) { }

	[Address(RVA = "0x2DED7A0", Offset = "0x2DECBA0", Length = "0x410")]
	[Token(Token = "0x6000924")]
	public static bool ExtractDirectionalLightMatrix(ref CullingResults cullResults, UniversalShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData) { }

	[Address(RVA = "0x2DEDDB0", Offset = "0x2DED1B0", Length = "0x8F")]
	[Token(Token = "0x6000927")]
	public static bool ExtractPointLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData splitData) { }

	[Address(RVA = "0x2DEDBC0", Offset = "0x2DECFC0", Length = "0x1EF")]
	[Token(Token = "0x6000928")]
	public static bool ExtractPointLightMatrix(ref CullingResults cullResults, UniversalShadowData shadowData, int shadowLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData splitData) { }

	[Address(RVA = "0x2DEDE40", Offset = "0x2DED240", Length = "0x8F")]
	[Token(Token = "0x6000925")]
	public static bool ExtractSpotLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData splitData) { }

	[Address(RVA = "0x2DEDED0", Offset = "0x2DED2D0", Length = "0x1C5")]
	[Token(Token = "0x6000926")]
	public static bool ExtractSpotLightMatrix(ref CullingResults cullResults, UniversalShadowData shadowData, int shadowLightIndex, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData splitData) { }

	[Address(RVA = "0x2DEE1C0", Offset = "0x2DED5C0", Length = "0x1A")]
	[Token(Token = "0x6000946")]
	internal static bool FastApproximately(float a, float b) { }

	[Address(RVA = "0x2DEE0A0", Offset = "0x2DED4A0", Length = "0x116")]
	[Token(Token = "0x6000947")]
	internal static bool FastApproximately(Vector4 a, Vector4 b) { }

	[Address(RVA = "0x2DEE1E0", Offset = "0x2DED5E0", Length = "0x3A")]
	[Token(Token = "0x600092C")]
	public static int GetMaxTileResolutionInAtlas(int atlasWidth, int atlasHeight, int tileCount) { }

	[Address(RVA = "0x2DEE220", Offset = "0x2DED620", Length = "0x1A")]
	[Token(Token = "0x6000945")]
	internal static int GetPunctualLightShadowSlicesCount(in LightType lightType) { }

	[Address(RVA = "0x2DEE240", Offset = "0x2DED640", Length = "0x6A")]
	[Token(Token = "0x6000931")]
	internal static void GetScaleAndBiasForLinearDistanceFade(float fadeDistance, float border, out float scale, out float bias) { }

	[Address(RVA = "0x2DEE7C0", Offset = "0x2DEDBC0", Length = "0x107")]
	[Token(Token = "0x600092E")]
	public static Vector4 GetShadowBias(ref VisibleLight shadowLight, int shadowLightIndex, ref ShadowData shadowData, Matrix4x4 lightProjectionMatrix, float shadowResolution) { }

	[Address(RVA = "0x2DEE6B0", Offset = "0x2DEDAB0", Length = "0x105")]
	[Token(Token = "0x600092F")]
	public static Vector4 GetShadowBias(ref VisibleLight shadowLight, int shadowLightIndex, UniversalShadowData shadowData, Matrix4x4 lightProjectionMatrix, float shadowResolution) { }

	[Address(RVA = "0x2DEE2B0", Offset = "0x2DED6B0", Length = "0x3FA")]
	[Token(Token = "0x6000930")]
	private static Vector4 GetShadowBias(ref VisibleLight shadowLight, int shadowLightIndex, List<Vector4> bias, bool supportsSoftShadows, Matrix4x4 lightProjectionMatrix, float shadowResolution) { }

	[Address(RVA = "0x2DEE8D0", Offset = "0x2DEDCD0", Length = "0x271")]
	[Token(Token = "0x600093E")]
	private static Matrix4x4 GetShadowTransform(Matrix4x4 proj, Matrix4x4 view) { }

	[Address(RVA = "0x2DEEC30", Offset = "0x2DEE030", Length = "0xF0")]
	[Obsolete("Use AllocShadowRT or ShadowRTReAllocateIfNeeded. #from(2022.1) #breakingFrom(2023.1)", True)]
	[Token(Token = "0x600093A")]
	public static RenderTexture GetTemporaryShadowTexture(int width, int height, int bits) { }

	[Address(RVA = "0x2DEEB50", Offset = "0x2DEDF50", Length = "0xDB")]
	[Token(Token = "0x6000939")]
	private static RenderTextureDescriptor GetTemporaryShadowTextureDescriptor(int width, int height, int bits) { }

	[Address(RVA = "0x2DEED70", Offset = "0x2DEE170", Length = "0x13A")]
	[Token(Token = "0x6000943")]
	internal static bool IsValidShadowCastingLight(UniversalLightData lightData, int i) { }

	[Address(RVA = "0x2DEED30", Offset = "0x2DEE130", Length = "0x39")]
	[Token(Token = "0x6000944")]
	internal static bool IsValidShadowCastingLight(UniversalLightData lightData, int i, LightType lightType, LightShadows lightShadows, float shadowStrength) { }

	[Address(RVA = "0x2DEEEB0", Offset = "0x2DEE2B0", Length = "0x10")]
	[Token(Token = "0x6000948")]
	internal static int MinimalPunctualLightShadowResolution(bool softShadow) { }

	[Address(RVA = "0x2DEEEC0", Offset = "0x2DEE2C0", Length = "0x24E")]
	[Token(Token = "0x600092B")]
	public static void RenderShadowSlice(CommandBuffer cmd, ref ScriptableRenderContext context, ref ShadowSliceData shadowSliceData, ref ShadowDrawingSettings settings) { }

	[Address(RVA = "0x2DEF2E0", Offset = "0x2DEE6E0", Length = "0x1A7")]
	[Token(Token = "0x600092A")]
	internal static void RenderShadowSlice(RasterCommandBuffer cmd, ref ShadowSliceData shadowSliceData, ref RendererList shadowRendererList, Matrix4x4 proj, Matrix4x4 view) { }

	[Address(RVA = "0x2DEF110", Offset = "0x2DEE510", Length = "0x1CF")]
	[Token(Token = "0x6000929")]
	public static void RenderShadowSlice(CommandBuffer cmd, ref ScriptableRenderContext context, ref ShadowSliceData shadowSliceData, ref ShadowDrawingSettings settings, Matrix4x4 proj, Matrix4x4 view) { }

	[Address(RVA = "0x2DEF490", Offset = "0x2DEE890", Length = "0xAF")]
	[Token(Token = "0x6000937")]
	internal static void SetCameraPosition(RasterCommandBuffer cmd, Vector3 worldSpaceCameraPos) { }

	[Address(RVA = "0x2DEF540", Offset = "0x2DEE940", Length = "0xA5")]
	[Token(Token = "0x6000935")]
	internal static void SetLightDirection(RasterCommandBuffer cmd, Vector3 lightDirection) { }

	[Address(RVA = "0x2DEF5F0", Offset = "0x2DEE9F0", Length = "0xA5")]
	[Token(Token = "0x6000936")]
	internal static void SetLightPosition(RasterCommandBuffer cmd, Vector3 lightPosition) { }

	[Address(RVA = "0x2DEF6A0", Offset = "0x2DEEAA0", Length = "0x83")]
	[Token(Token = "0x6000941")]
	internal static void SetPerLightSoftShadowKeyword(RasterCommandBuffer cmd, bool hasSoftShadows) { }

	[Address(RVA = "0x2DEF730", Offset = "0x2DEEB30", Length = "0x85")]
	[Token(Token = "0x6000934")]
	internal static void SetShadowBias(RasterCommandBuffer cmd, Vector4 shadowBias) { }

	[Address(RVA = "0x2DEF7C0", Offset = "0x2DEEBC0", Length = "0xFD")]
	[Token(Token = "0x6000942")]
	internal static void SetSoftShadowQualityShaderKeywords(RasterCommandBuffer cmd, UniversalShadowData shadowData) { }

	[Address(RVA = "0x2DEFDF0", Offset = "0x2DEF1F0", Length = "0x23A")]
	[Token(Token = "0x6000933")]
	internal static void SetupShadowCasterConstantBuffer(RasterCommandBuffer cmd, ref VisibleLight shadowLight, Vector4 shadowBias) { }

	[Address(RVA = "0x2DEFAF0", Offset = "0x2DEEEF0", Length = "0x2F8")]
	[Token(Token = "0x6000932")]
	public static void SetupShadowCasterConstantBuffer(CommandBuffer cmd, ref VisibleLight shadowLight, Vector4 shadowBias) { }

	[Address(RVA = "0x2DEF8C0", Offset = "0x2DEECC0", Length = "0x224")]
	[Token(Token = "0x6000938")]
	internal static void SetWorldToCameraAndCameraToWorldMatrices(RasterCommandBuffer cmd, Matrix4x4 viewMatrix) { }

	[Address(RVA = "0x2DF0030", Offset = "0x2DEF430", Length = "0x3A8")]
	[Token(Token = "0x600093B")]
	public static bool ShadowRTNeedsReAlloc(RTHandle handle, int width, int height, int bits, int anisoLevel, float mipMapBias, string name) { }

	[Address(RVA = "0x2DF03E0", Offset = "0x2DEF7E0", Length = "0x1E7")]
	[Token(Token = "0x600093D")]
	public static bool ShadowRTReAllocateIfNeeded(ref RTHandle handle, int width, int height, int bits, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	[Address(RVA = "0x2DF05D0", Offset = "0x2DEF9D0", Length = "0x169")]
	[Token(Token = "0x600093F")]
	internal static float SoftShadowQualityToShaderProperty(Light light, bool softShadowsEnabled) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000940")]
	internal static bool SupportsPerLightSoftShadowQuality() { }

}

