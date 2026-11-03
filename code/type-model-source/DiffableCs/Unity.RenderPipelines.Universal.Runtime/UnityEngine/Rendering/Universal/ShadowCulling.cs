namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001A9")]
internal static class ShadowCulling
{
	[Token(Token = "0x400093D")]
	private static readonly ProfilingSampler computeShadowCasterCullingInfosMarker; //Field offset: 0x0

	[Address(RVA = "0x2DED0F0", Offset = "0x2DEC4F0", Length = "0x87")]
	[Token(Token = "0x600091F")]
	private static ShadowCulling() { }

	[Address(RVA = "0x2DEC080", Offset = "0x2DEB480", Length = "0xF20")]
	[Token(Token = "0x600091D")]
	private static void ComputeShadowCasterCullingInfos(UniversalShadowData shadowData, ref AdditionalLightsShadowAtlasLayout shadowAtlasLayout, ref CullingResults cullingResults, out ShadowCastersCullingInfos shadowCullingInfos, out NativeArray<URPLightShadowCullingInfos>& urpVisibleLightsShadowCullingInfos) { }

	[Address(RVA = "0x2DECFB0", Offset = "0x2DEC3B0", Length = "0x114")]
	[Token(Token = "0x600091C")]
	public static NativeArray<URPLightShadowCullingInfos> CullShadowCasters(ref ScriptableRenderContext context, UniversalShadowData shadowData, ref AdditionalLightsShadowAtlasLayout shadowAtlasLayout, ref CullingResults cullResults) { }

	[Address(RVA = "0x2DED0D0", Offset = "0x2DEC4D0", Length = "0x1D")]
	[Token(Token = "0x600091E")]
	private static BatchCullingProjectionType GetCullingProjectionType(LightType type) { }

}

