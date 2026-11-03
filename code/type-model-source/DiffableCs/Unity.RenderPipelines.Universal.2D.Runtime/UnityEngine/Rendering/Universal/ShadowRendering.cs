namespace UnityEngine.Rendering.Universal;

[Extension]
[Token(Token = "0x2000094")]
internal static class ShadowRendering
{
	[CompilerGenerated]
	[Token(Token = "0x2000096")]
	private sealed class <>c
	{
		[Token(Token = "0x40002C4")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40002C5")]
		public static Func<Renderer2DResources, Shader> <>9__23_0; //Field offset: 0x8
		[Token(Token = "0x40002C6")]
		public static Func<Renderer2DResources, Shader> <>9__24_0; //Field offset: 0x10
		[Token(Token = "0x40002C7")]
		public static Func<Renderer2DResources, Shader> <>9__25_0; //Field offset: 0x18
		[Token(Token = "0x40002C8")]
		public static Func<Renderer2DResources, Shader> <>9__26_0; //Field offset: 0x20
		[Token(Token = "0x40002C9")]
		public static Func<Renderer2DResources, Shader> <>9__27_0; //Field offset: 0x28
		[Token(Token = "0x40002CA")]
		public static Func<Renderer2DResources, Shader> <>9__28_0; //Field offset: 0x30

		[Address(RVA = "0x2D56DB0", Offset = "0x2D561B0", Length = "0x67")]
		[Token(Token = "0x600036F")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000370")]
		public <>c() { }

		[Address(RVA = "0x232A970", Offset = "0x2329D70", Length = "0x17")]
		[Token(Token = "0x6000375")]
		internal Shader <GetGeometryShadowMaterial>b__27_0(Renderer2DResources r) { }

		[Address(RVA = "0x2D56D70", Offset = "0x2D56170", Length = "0x17")]
		[Token(Token = "0x6000376")]
		internal Shader <GetGeometryUnshadowMaterial>b__28_0(Renderer2DResources r) { }

		[Address(RVA = "0x22909D0", Offset = "0x228FDD0", Length = "0x17")]
		[Token(Token = "0x6000371")]
		internal Shader <GetProjectedShadowMaterial>b__23_0(Renderer2DResources r) { }

		[Address(RVA = "0x22909D0", Offset = "0x228FDD0", Length = "0x17")]
		[Token(Token = "0x6000372")]
		internal Shader <GetProjectedUnshadowMaterial>b__24_0(Renderer2DResources r) { }

		[Address(RVA = "0x2D56D90", Offset = "0x2D56190", Length = "0x17")]
		[Token(Token = "0x6000373")]
		internal Shader <GetSpriteShadowMaterial>b__25_0(Renderer2DResources r) { }

		[Address(RVA = "0x2144120", Offset = "0x2143520", Length = "0x17")]
		[Token(Token = "0x6000374")]
		internal Shader <GetSpriteUnshadowMaterial>b__26_0(Renderer2DResources r) { }

	}

	[Token(Token = "0x2000095")]
	public enum ShadowTestType : int
	{
		Always = 0,
		Unshadow = 1,
	}

	[Token(Token = "0x40002AD")]
	private static readonly int k_LightPosID; //Field offset: 0x0
	[Token(Token = "0x40002AE")]
	private static readonly int k_ShadowRadiusID; //Field offset: 0x4
	[Token(Token = "0x40002AF")]
	private static readonly int k_ShadowColorMaskID; //Field offset: 0x8
	[Token(Token = "0x40002B0")]
	private static readonly int k_ShadowModelMatrixID; //Field offset: 0xC
	[Token(Token = "0x40002B1")]
	private static readonly int k_ShadowModelInvMatrixID; //Field offset: 0x10
	[Token(Token = "0x40002B2")]
	private static readonly int k_ShadowModelScaleID; //Field offset: 0x14
	[Token(Token = "0x40002B3")]
	private static readonly int k_ShadowContractionDistanceID; //Field offset: 0x18
	[Token(Token = "0x40002B4")]
	private static readonly int k_ShadowAlphaCutoffID; //Field offset: 0x1C
	[Token(Token = "0x40002B5")]
	private static readonly int k_SoftShadowAngle; //Field offset: 0x20
	[Token(Token = "0x40002B6")]
	private static readonly int k_ShadowSoftnessFalloffIntensityID; //Field offset: 0x24
	[Token(Token = "0x40002B7")]
	private static readonly int k_ShadowShadowColorID; //Field offset: 0x28
	[Token(Token = "0x40002B8")]
	private static readonly int k_ShadowUnshadowColorID; //Field offset: 0x2C
	[Token(Token = "0x40002B9")]
	private static readonly ProfilingSampler m_ProfilingSamplerShadows; //Field offset: 0x30
	[Token(Token = "0x40002BA")]
	private static readonly ProfilingSampler m_ProfilingSamplerShadowsA; //Field offset: 0x38
	[Token(Token = "0x40002BB")]
	private static readonly ProfilingSampler m_ProfilingSamplerShadowsR; //Field offset: 0x40
	[Token(Token = "0x40002BC")]
	private static readonly ProfilingSampler m_ProfilingSamplerShadowsG; //Field offset: 0x48
	[Token(Token = "0x40002BD")]
	private static readonly ProfilingSampler m_ProfilingSamplerShadowsB; //Field offset: 0x50
	[Token(Token = "0x40002BE")]
	private static readonly float k_MaxShadowSoftnessAngle; //Field offset: 0x58
	[Token(Token = "0x40002BF")]
	private static readonly Color k_ShadowColorLookup; //Field offset: 0x5C
	[Token(Token = "0x40002C0")]
	private static readonly Color k_UnshadowColorLookup; //Field offset: 0x6C

	[Address(RVA = "0x2D52540", Offset = "0x2D51940", Length = "0x441")]
	[Token(Token = "0x600036E")]
	private static ShadowRendering() { }

	[Address(RVA = "0x2D4F560", Offset = "0x2D4E960", Length = "0xB1")]
	[Token(Token = "0x6000361")]
	private static void CalculateFrustumCornersOrthographic(Camera camera, float distance, NativeArray<Vector3> corners) { }

	[Address(RVA = "0x2D4F620", Offset = "0x2D4EA20", Length = "0xCA")]
	[Token(Token = "0x6000360")]
	private static void CalculateFrustumCornersPerspective(Camera camera, float distance, NativeArray<Vector3> corners) { }

	[Address(RVA = "0x2D4F6F0", Offset = "0x2D4EAF0", Length = "0x80F")]
	[Token(Token = "0x6000362")]
	private static Bounds CalculateWorldSpaceBounds(Camera camera, ILight2DCullResult cullResult) { }

	[Address(RVA = "0x2D4FF00", Offset = "0x2D4F300", Length = "0x222")]
	[Token(Token = "0x6000363")]
	internal static void CallOnBeforeRender(Camera camera, ILight2DCullResult cullResult) { }

	[Address(RVA = "0x2D50130", Offset = "0x2D4F530", Length = "0xCB")]
	[Token(Token = "0x6000358")]
	private static Material CreateMaterial(Shader shader, int offset, int pass) { }

	[Address(RVA = "0x2D50200", Offset = "0x2D4F600", Length = "0x168")]
	[Extension]
	[Token(Token = "0x600035E")]
	private static Material GetGeometryShadowMaterial(Renderer2DData rendererData) { }

	[Address(RVA = "0x2D50370", Offset = "0x2D4F770", Length = "0x16B")]
	[Extension]
	[Token(Token = "0x600035F")]
	private static Material GetGeometryUnshadowMaterial(Renderer2DData rendererData) { }

	[Address(RVA = "0x2D50700", Offset = "0x2D4FB00", Length = "0x168")]
	[Extension]
	[Token(Token = "0x600035A")]
	internal static Material GetProjectedShadowMaterial(Renderer2DData rendererData) { }

	[Address(RVA = "0x2D504E0", Offset = "0x2D4F8E0", Length = "0x219")]
	[Token(Token = "0x6000359")]
	private static Material GetProjectedShadowMaterial(Material material, Func<Renderer2DResources, Shader> shaderFunc, int offset, int pass) { }

	[Address(RVA = "0x2D50870", Offset = "0x2D4FC70", Length = "0x16B")]
	[Extension]
	[Token(Token = "0x600035B")]
	internal static Material GetProjectedUnshadowMaterial(Renderer2DData rendererData) { }

	[Address(RVA = "0x2D509E0", Offset = "0x2D4FDE0", Length = "0xC5")]
	[Token(Token = "0x6000368")]
	private static Renderer GetRendererFromCaster(ShadowCaster2D shadowCaster, Light2D light, int layerToRender) { }

	[Address(RVA = "0x2D50AB0", Offset = "0x2D4FEB0", Length = "0x19")]
	[Token(Token = "0x600036A")]
	private static int GetRendererSubmeshes(Renderer renderer, ShadowCaster2D shadowCaster2D) { }

	[Address(RVA = "0x2D50AD0", Offset = "0x2D4FED0", Length = "0x168")]
	[Extension]
	[Token(Token = "0x600035C")]
	private static Material GetSpriteShadowMaterial(Renderer2DData rendererData) { }

	[Address(RVA = "0x2D50C40", Offset = "0x2D50040", Length = "0x16B")]
	[Extension]
	[Token(Token = "0x600035D")]
	private static Material GetSpriteUnshadowMaterial(Renderer2DData rendererData) { }

	[Address(RVA = "0x2D50DB0", Offset = "0x2D501B0", Length = "0x7F")]
	[Token(Token = "0x6000364")]
	internal static void PrerenderShadows(UnsafeCommandBuffer cmdBuffer, Renderer2DData rendererData, ref LayerBatch layer, Light2D light, int shadowIndex, float shadowIntensity) { }

	[Address(RVA = "0x2D50E30", Offset = "0x2D50230", Length = "0x2C8")]
	[Token(Token = "0x6000369")]
	private static void RenderProjectedShadows(UnsafeCommandBuffer cmdBuffer, int layerToRender, Light2D light, List<ShadowCaster2D> shadowCasters, Material projectedShadowsMaterial, int pass, ShadowTestType shadowTestType) { }

	[Address(RVA = "0x2D51100", Offset = "0x2D50500", Length = "0xBCB")]
	[Token(Token = "0x600036D")]
	private static void RenderShadows(UnsafeCommandBuffer cmdBuffer, Renderer2DData rendererData, ref LayerBatch layer, Light2D light) { }

	[Address(RVA = "0x2D51CD0", Offset = "0x2D510D0", Length = "0x43A")]
	[Token(Token = "0x600036B")]
	private static void RenderSpriteShadow(UnsafeCommandBuffer cmdBuffer, int layerToRender, Light2D light, List<ShadowCaster2D> shadowCasters, Material spriteShadowMaterial, Material spriteUnshadowMaterial, Material geometryShadowMaterial, Material geometryUnshadowMaterial, int pass, ShadowTestType shadowTestType) { }

	[Address(RVA = "0x2D52110", Offset = "0x2D51510", Length = "0x1BE")]
	[Token(Token = "0x6000366")]
	internal static void SetGlobalShadowProp(IRasterCommandBuffer cmdBuffer) { }

	[Address(RVA = "0x2D522D0", Offset = "0x2D516D0", Length = "0x228")]
	[Token(Token = "0x6000365")]
	private static void SetShadowProjectionGlobals(UnsafeCommandBuffer cmdBuffer, ShadowCaster2D shadowCaster, Light2D light) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000367")]
	private static bool ShadowCasterIsVisible(ShadowCaster2D shadowCaster) { }

	[Address(RVA = "0x2D52500", Offset = "0x2D51900", Length = "0x39")]
	[Token(Token = "0x600036C")]
	internal static bool ShadowTest(ShadowTestType shadowTestType, ShadowCaster2D shadowCaster) { }

}

