//Type is in global namespace

[Token(Token = "0x2000006")]
public class OnTilePostProcessPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x200000A")]
	private sealed class <>c
	{
		[Token(Token = "0x4000029")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400002A")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__13_0; //Field offset: 0x8

		[Address(RVA = "0x2D64CC0", Offset = "0x2D640C0", Length = "0x67")]
		[Token(Token = "0x6000019")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600001A")]
		public <>c() { }

		[Address(RVA = "0x2D61C90", Offset = "0x2D61090", Length = "0x64")]
		[Token(Token = "0x600001B")]
		internal void <RecordRenderGraph>b__13_0(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x2000008")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000018")]
		internal TextureHandle source; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000019")]
		internal TextureHandle destination; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400001A")]
		internal TextureHandle lutTexture; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400001B")]
		internal TextureHandle userLutTexture; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400001C")]
		internal Material material; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400001D")]
		internal UberShaderPasses shaderPass; //Field offset: 0x58
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x400001E")]
		internal Vector4 scaleBias; //Field offset: 0x5C
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x400001F")]
		internal bool useXRVisibilityMesh; //Field offset: 0x6C
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000020")]
		internal XRPass xr; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000021")]
		internal int msaaSamples; //Field offset: 0x78

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000017")]
		public PassData() { }

	}

	[Token(Token = "0x2000009")]
	private static class ShaderConstants
	{
		[Token(Token = "0x4000022")]
		public static readonly int _Vignette_Params1; //Field offset: 0x0
		[Token(Token = "0x4000023")]
		public static readonly int _Vignette_Params2; //Field offset: 0x4
		[Token(Token = "0x4000024")]
		public static readonly int _Vignette_ParamsXR; //Field offset: 0x8
		[Token(Token = "0x4000025")]
		public static readonly int _Lut_Params; //Field offset: 0xC
		[Token(Token = "0x4000026")]
		public static readonly int _UserLut_Params; //Field offset: 0x10
		[Token(Token = "0x4000027")]
		public static readonly int _InternalLut; //Field offset: 0x14
		[Token(Token = "0x4000028")]
		public static readonly int _UserLut; //Field offset: 0x18

		[Address(RVA = "0x2D60430", Offset = "0x2D5F830", Length = "0x151")]
		[Token(Token = "0x6000018")]
		private static ShaderConstants() { }

	}

	[Token(Token = "0x2000007")]
	private enum UberShaderPasses : int
	{
		Normal = 0,
		MSAASoftwareResolve = 1,
		TextureRead = 2,
		NormalVisMesh = 3,
		MSAASoftwareResolveVisMesh = 4,
		TextureReadVisMesh = 5,
	}

	[Token(Token = "0x400000B")]
	private static readonly int s_BlitScaleBias; //Field offset: 0x0
	[Token(Token = "0x400000F")]
	private const string m_PassName = "On Tile Post Processing"; //Field offset: 0x0
	[Token(Token = "0x4000010")]
	private const string m_FallbackPassName = "On Tile Post Processing (sampling fallback) "; //Field offset: 0x0
	[Token(Token = "0x400000C")]
	private static readonly int s_BlitTexture; //Field offset: 0x4
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000007")]
	internal bool m_UseMultisampleShaderResolve; //Field offset: 0x60
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x4000008")]
	internal bool m_UseTextureReadFallback; //Field offset: 0x61
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000009")]
	private RTHandle m_UserLut; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400000A")]
	private Material m_OnTileUberMaterial; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400000D")]
	private int m_DitheringTextureIndex; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400000E")]
	private PostProcessData m_PostProcessData; //Field offset: 0x80

	[Address(RVA = "0x2D5DBA0", Offset = "0x2D5CFA0", Length = "0x7A")]
	[Token(Token = "0x6000016")]
	private static OnTilePostProcessPass() { }

	[Address(RVA = "0x2D5DC20", Offset = "0x2D5D020", Length = "0x42")]
	[Token(Token = "0x600000B")]
	internal OnTilePostProcessPass(PostProcessData postProcessData) { }

	[Address(RVA = "0x2D5B9F0", Offset = "0x2D5ADF0", Length = "0x5D")]
	[Token(Token = "0x600000D")]
	public void Dispose() { }

	[Address(RVA = "0x2D5BA50", Offset = "0x2D5AE50", Length = "0x4AD")]
	[Token(Token = "0x600000F")]
	private static void ExecuteFBFetchPass(PassData data, RasterGraphContext context) { }

	[Address(RVA = "0x2D5BF00", Offset = "0x2D5B300", Length = "0x10F9")]
	[Token(Token = "0x600000E")]
	public virtual void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData) { }

	[Address(RVA = "0x2D5D960", Offset = "0x2D5CD60", Length = "0x10")]
	[Token(Token = "0x600000C")]
	internal void Setup(ref Material onTileUberMaterial) { }

	[Address(RVA = "0x2D5D000", Offset = "0x2D5C400", Length = "0xA5")]
	[Token(Token = "0x6000015")]
	private void SetupDithering(Material onTileUberMaterial, UniversalCameraData cameraData, PostProcessData data) { }

	[Address(RVA = "0x2D5D0B0", Offset = "0x2D5C4B0", Length = "0xA1")]
	[Token(Token = "0x6000014")]
	private void SetupGrain(Material onTileUberMaterial, UniversalCameraData cameraData, FilmGrain filmgrain, PostProcessData data) { }

	[Address(RVA = "0x2D5D160", Offset = "0x2D5C560", Length = "0x392")]
	[Token(Token = "0x6000011")]
	private void SetupLut(Material material, ColorLookup colorLookup, ColorAdjustments colorAdjustments, int lutSize) { }

	[Address(RVA = "0x2D5D500", Offset = "0x2D5C900", Length = "0x13B")]
	[Token(Token = "0x6000013")]
	private void SetupTonemapping(Material onTileUberMaterial, Tonemapping tonemapping, bool isHdrGrading) { }

	[Address(RVA = "0x2D5D640", Offset = "0x2D5CA40", Length = "0x31D")]
	[Token(Token = "0x6000012")]
	private void SetupVignette(Material material, XRPass xrPass, int width, int height, Vignette vignette) { }

	[Address(RVA = "0x2D5D970", Offset = "0x2D5CD70", Length = "0x221")]
	[Token(Token = "0x6000010")]
	private TextureHandle TryGetCachedUserLutTextureHandle(ColorLookup colorLookup, RenderGraph renderGraph) { }

}

