namespace UnityEngine.Rendering.RenderGraphModule.Util;

[Extension]
[Token(Token = "0x20002A6")]
public static class RenderGraphUtils
{
	[CompilerGenerated]
	[Token(Token = "0x20002AD")]
	private sealed class <>c
	{
		[Token(Token = "0x4000C21")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000C22")]
		public static BaseRenderFunc<CopyPassData, RasterGraphContext> <>9__9_0; //Field offset: 0x8
		[Token(Token = "0x4000C23")]
		public static BaseRenderFunc<BlitPassData, UnsafeGraphContext> <>9__15_0; //Field offset: 0x10
		[Token(Token = "0x4000C24")]
		public static BaseRenderFunc<BlitMaterialPassData, UnsafeGraphContext> <>9__21_0; //Field offset: 0x18

		[Address(RVA = "0x2CAC370", Offset = "0x2CAB770", Length = "0x1B5")]
		[Token(Token = "0x600131D")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600131E")]
		public <>c() { }

		[Address(RVA = "0x2CAC1F0", Offset = "0x2CAB5F0", Length = "0x59")]
		[Token(Token = "0x6001320")]
		internal void <AddBlitPass>b__15_0(BlitPassData data, UnsafeGraphContext context) { }

		[Address(RVA = "0x2CAC250", Offset = "0x2CAB650", Length = "0x59")]
		[Token(Token = "0x6001321")]
		internal void <AddBlitPass>b__21_0(BlitMaterialPassData data, UnsafeGraphContext context) { }

		[Address(RVA = "0x2CAC2B0", Offset = "0x2CAB6B0", Length = "0xB5")]
		[Token(Token = "0x600131F")]
		internal void <AddCopyPass>b__9_0(CopyPassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x20002A8")]
	internal enum BlitFilterMode : int
	{
		ClampNearest = 0,
		ClampBilinear = 1,
	}

	[Token(Token = "0x20002AB")]
	internal struct BlitMaterialParameters
	{
		[Token(Token = "0x4000BF8")]
		private static readonly int blitTextureProperty; //Field offset: 0x0
		[Token(Token = "0x4000BF9")]
		private static readonly int blitSliceProperty; //Field offset: 0x4
		[Token(Token = "0x4000BFA")]
		private static readonly int blitMipProperty; //Field offset: 0x8
		[Token(Token = "0x4000BFB")]
		private static readonly int blitScaleBias; //Field offset: 0xC
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BFC")]
		public TextureHandle source; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000BFD")]
		public TextureHandle destination; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BFE")]
		public Vector2 scale; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BFF")]
		public Vector2 offset; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C00")]
		public int sourceSlice; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000C01")]
		public int destinationSlice; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C02")]
		public int numSlices; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000C03")]
		public int sourceMip; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000C04")]
		public int destinationMip; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4000C05")]
		public int numMips; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000C06")]
		public Material material; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000C07")]
		public int shaderPass; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000C08")]
		public MaterialPropertyBlock propertyBlock; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000C09")]
		public int sourceTexturePropertyID; //Field offset: 0x60
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x4000C0A")]
		public int sourceSlicePropertyID; //Field offset: 0x64
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000C0B")]
		public int sourceMipPropertyID; //Field offset: 0x68
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x4000C0C")]
		public int scaleBiasPropertyID; //Field offset: 0x6C
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000C0D")]
		public FullScreenGeometryType geometry; //Field offset: 0x70

		[Address(RVA = "0x2C8C810", Offset = "0x2C8BC10", Length = "0xD0")]
		[Token(Token = "0x600131B")]
		private static BlitMaterialParameters() { }

		[Address(RVA = "0x2C8D070", Offset = "0x2C8C470", Length = "0x149")]
		[Token(Token = "0x6001315")]
		public BlitMaterialParameters(TextureHandle source, TextureHandle destination, Material material, int shaderPass) { }

		[Address(RVA = "0x2C8CAF0", Offset = "0x2C8BEF0", Length = "0x123")]
		[Token(Token = "0x6001316")]
		public BlitMaterialParameters(TextureHandle source, TextureHandle destination, Vector2 scale, Vector2 offset, Material material, int shaderPass) { }

		[Address(RVA = "0x2C8C8E0", Offset = "0x2C8BCE0", Length = "0x203")]
		[Token(Token = "0x6001317")]
		public BlitMaterialParameters(TextureHandle source, TextureHandle destination, Material material, int shaderPass, MaterialPropertyBlock mpb, int destinationSlice, int destinationMip, int numSlices = -1, int numMips = 1, int sourceSlice = -1, int sourceMip = -1, FullScreenGeometryType geometry = 0, int sourceTexturePropertyID = -1, int sourceSlicePropertyID = -1, int sourceMipPropertyID = -1) { }

		[Address(RVA = "0x2C8CF10", Offset = "0x2C8C310", Length = "0x158")]
		[Token(Token = "0x6001318")]
		public BlitMaterialParameters(TextureHandle source, TextureHandle destination, Vector2 scale, Vector2 offset, Material material, int shaderPass, MaterialPropertyBlock mpb, int destinationSlice, int destinationMip, int numSlices = -1, int numMips = 1, int sourceSlice = -1, int sourceMip = -1, FullScreenGeometryType geometry = 0, int sourceTexturePropertyID = -1, int sourceSlicePropertyID = -1, int sourceMipPropertyID = -1, int scaleBiasPropertyID = -1) { }

		[Address(RVA = "0x2C8CD40", Offset = "0x2C8C140", Length = "0x1C7")]
		[Token(Token = "0x6001319")]
		public BlitMaterialParameters(TextureHandle source, TextureHandle destination, Material material, int shaderPass, MaterialPropertyBlock mpb, FullScreenGeometryType geometry = 0, int sourceTexturePropertyID = -1, int sourceSlicePropertyID = -1, int sourceMipPropertyID = -1) { }

		[Address(RVA = "0x2C8CC20", Offset = "0x2C8C020", Length = "0x11C")]
		[Token(Token = "0x600131A")]
		public BlitMaterialParameters(TextureHandle source, TextureHandle destination, Vector2 scale, Vector2 offset, Material material, int shaderPass, MaterialPropertyBlock mpb, FullScreenGeometryType geometry = 0, int sourceTexturePropertyID = -1, int sourceSlicePropertyID = -1, int sourceMipPropertyID = -1, int scaleBiasPropertyID = -1) { }

	}

	[Token(Token = "0x20002AC")]
	private class BlitMaterialPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000C0E")]
		public int sourceTexturePropertyID; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000C0F")]
		public TextureHandle source; //Field offset: 0x14
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000C10")]
		public TextureHandle destination; //Field offset: 0x24
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000C11")]
		public Vector2 scale; //Field offset: 0x34
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000C12")]
		public Vector2 offset; //Field offset: 0x3C
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000C13")]
		public Material material; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000C14")]
		public int shaderPass; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000C15")]
		public MaterialPropertyBlock propertyBlock; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000C16")]
		public int sourceSlice; //Field offset: 0x60
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x4000C17")]
		public int destinationSlice; //Field offset: 0x64
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000C18")]
		public int numSlices; //Field offset: 0x68
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x4000C19")]
		public int sourceMip; //Field offset: 0x6C
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000C1A")]
		public int destinationMip; //Field offset: 0x70
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x4000C1B")]
		public int numMips; //Field offset: 0x74
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000C1C")]
		public FullScreenGeometryType geometry; //Field offset: 0x78
		[FieldOffset(Offset = "0x7C")]
		[Token(Token = "0x4000C1D")]
		public int sourceSlicePropertyID; //Field offset: 0x7C
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000C1E")]
		public int sourceMipPropertyID; //Field offset: 0x80
		[FieldOffset(Offset = "0x84")]
		[Token(Token = "0x4000C1F")]
		public int scaleBiasPropertyID; //Field offset: 0x84
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000C20")]
		public bool isXR; //Field offset: 0x88

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600131C")]
		public BlitMaterialPassData() { }

	}

	[Token(Token = "0x20002A9")]
	private class BlitPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000BE7")]
		public TextureHandle source; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BE8")]
		public TextureHandle destination; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BE9")]
		public Vector2 scale; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BEA")]
		public Vector2 offset; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000BEB")]
		public int sourceSlice; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4000BEC")]
		public int destinationSlice; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000BED")]
		public int numSlices; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4000BEE")]
		public int sourceMip; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000BEF")]
		public int destinationMip; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x4000BF0")]
		public int numMips; //Field offset: 0x54
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000BF1")]
		public BlitFilterMode filterMode; //Field offset: 0x58
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x4000BF2")]
		public bool isXR; //Field offset: 0x5C
		[FieldOffset(Offset = "0x5D")]
		[Token(Token = "0x4000BF3")]
		public bool isDepth; //Field offset: 0x5D

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001314")]
		public BlitPassData() { }

	}

	[Token(Token = "0x20002A7")]
	private class CopyPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000BE2")]
		public bool isMSAA; //Field offset: 0x10
		[FieldOffset(Offset = "0x11")]
		[Token(Token = "0x4000BE3")]
		public bool force2DForXR; //Field offset: 0x11

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001313")]
		public CopyPassData() { }

	}

	[Token(Token = "0x20002AA")]
	internal enum FullScreenGeometryType : int
	{
		Mesh = 0,
		ProceduralTriangle = 1,
		ProceduralQuad = 2,
	}

	[Token(Token = "0x4000BE0")]
	private static MaterialPropertyBlock s_PropertyBlock; //Field offset: 0x0
	[Token(Token = "0x4000BE1")]
	private static Vector4 s_BlitScaleBias; //Field offset: 0x8

	[Address(RVA = "0x2CAA390", Offset = "0x2CA9790", Length = "0x89")]
	[Token(Token = "0x6001312")]
	private static RenderGraphUtils() { }

	[Address(RVA = "0x2CA7C40", Offset = "0x2CA7040", Length = "0xB53")]
	[Extension]
	[Token(Token = "0x600130E")]
	public static IBaseRenderGraphBuilder AddBlitPass(RenderGraph graph, TextureHandle source, TextureHandle destination, Vector2 scale, Vector2 offset, int sourceSlice = 0, int destinationSlice = 0, int numSlices = -1, int sourceMip = 0, int destinationMip = 0, int numMips = 1, BlitFilterMode filterMode = 1, string passName = "Blit Pass Utility", bool returnBuilder = false, string file = "", int line = 0) { }

	[Address(RVA = "0x2CA6F30", Offset = "0x2CA6330", Length = "0xD02")]
	[Extension]
	[Token(Token = "0x6001310")]
	public static IBaseRenderGraphBuilder AddBlitPass(RenderGraph graph, BlitMaterialParameters blitParameters, string passName = "Blit Pass Utility w. Material", bool returnBuilder = false, string file = "", int line = 0) { }

	[Address(RVA = "0x2CA8850", Offset = "0x2CA7C50", Length = "0x755")]
	[Extension]
	[Token(Token = "0x600130A")]
	public static IBaseRenderGraphBuilder AddCopyPass(RenderGraph graph, TextureHandle source, TextureHandle destination, string passName = "Copy Pass Utility", bool returnBuilder = false, string file = "", int line = 0) { }

	[Address(RVA = "0x2CA87A0", Offset = "0x2CA7BA0", Length = "0xA9")]
	[Extension]
	[Token(Token = "0x600130B")]
	public static void AddCopyPass(RenderGraph graph, TextureHandle source, TextureHandle destination, int sourceSlice, int destinationSlice = 0, int sourceMip = 0, int destinationMip = 0, string passName = "Copy Pass Utility", string file = "", int line = 0) { }

	[Address(RVA = "0x2CA8FB0", Offset = "0x2CA83B0", Length = "0x711")]
	[Token(Token = "0x6001311")]
	private static void BlitMaterialRenderFunc(BlitMaterialPassData data, UnsafeGraphContext context) { }

	[Address(RVA = "0x2CA96D0", Offset = "0x2CA8AD0", Length = "0x5A1")]
	[Token(Token = "0x600130F")]
	private static void BlitRenderFunc(BlitPassData data, UnsafeGraphContext context) { }

	[Address(RVA = "0x2CA9E50", Offset = "0x2CA9250", Length = "0x279")]
	[Extension]
	[Token(Token = "0x6001309")]
	public static bool CanAddCopyPass(RenderGraph graph, TextureHandle source, TextureHandle destination) { }

	[Address(RVA = "0x2CA9D20", Offset = "0x2CA9120", Length = "0x8C")]
	[Token(Token = "0x6001303")]
	public static bool CanAddCopyPassMSAA() { }

	[Address(RVA = "0x2CA9C80", Offset = "0x2CA9080", Length = "0x9A")]
	[Token(Token = "0x6001304")]
	public static bool CanAddCopyPassMSAA(in TextureDesc sourceDesc) { }

	[Address(RVA = "0x2CA9DB0", Offset = "0x2CA91B0", Length = "0x96")]
	[Token(Token = "0x6001305")]
	public static bool CanAddCopyPassMSAA(bool bindTextureMS) { }

	[Address(RVA = "0x2CAA0D0", Offset = "0x2CA94D0", Length = "0x7B")]
	[Token(Token = "0x600130C")]
	private static void CopyRenderFunc(CopyPassData data, RasterGraphContext rgContext) { }

	[Address(RVA = "0x2CAA150", Offset = "0x2CA9550", Length = "0x35")]
	[Token(Token = "0x6001307")]
	internal static bool IsFramebufferFetchEmulationMSAASupportedOnCurrentPlatform() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6001306")]
	internal static bool IsFramebufferFetchEmulationSupportedOnCurrentPlatform() { }

	[Address(RVA = "0x2CAA190", Offset = "0x2CA9590", Length = "0xE0")]
	[Extension]
	[Token(Token = "0x6001308")]
	public static bool IsFramebufferFetchSupportedOnCurrentPlatform(RenderGraph graph, in TextureHandle tex) { }

	[Address(RVA = "0x2CAA280", Offset = "0x2CA9680", Length = "0x10C")]
	[Token(Token = "0x600130D")]
	internal static bool IsTextureXR(ref RenderTargetInfo destDesc, int sourceSlice, int destinationSlice, int numSlices, int numMips) { }

}

