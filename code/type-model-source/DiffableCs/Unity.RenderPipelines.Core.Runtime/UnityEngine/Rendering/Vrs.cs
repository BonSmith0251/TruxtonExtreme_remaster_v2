namespace UnityEngine.Rendering;

[Token(Token = "0x200022B")]
public static class Vrs
{
	[CompilerGenerated]
	[Token(Token = "0x200022E")]
	private sealed class <>c
	{
		[Token(Token = "0x40009C1")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40009C2")]
		public static BaseRenderFunc<ConversionPassData, ComputeGraphContext> <>9__9_0; //Field offset: 0x8
		[Token(Token = "0x40009C3")]
		public static BaseRenderFunc<VisualizationPassData, RasterGraphContext> <>9__10_0; //Field offset: 0x10

		[Address(RVA = "0x2C88A10", Offset = "0x2C87E10", Length = "0x67")]
		[Token(Token = "0x6000FA2")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000FA3")]
		public <>c() { }

		[Address(RVA = "0x2C88660", Offset = "0x2C87A60", Length = "0x67")]
		[Token(Token = "0x6000FA4")]
		internal void <ColorMaskTextureToShadingRateImage>b__9_0(ConversionPassData innerPassData, ComputeGraphContext context) { }

		[Address(RVA = "0x2C887A0", Offset = "0x2C87BA0", Length = "0x1F6")]
		[Token(Token = "0x6000FA5")]
		internal void <ShadingRateImageToColorMaskTexture>b__10_0(VisualizationPassData innerPassData, RasterGraphContext context) { }

	}

	[Token(Token = "0x200022C")]
	private class ConversionPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40009B2")]
		public TextureHandle sriTextureHandle; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40009B3")]
		public TextureHandle mainTexHandle; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40009B4")]
		public TextureDimension mainTexDimension; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40009B5")]
		public BufferHandle mainTexLutHandle; //Field offset: 0x34
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40009B6")]
		public BufferHandle validatedShadingRateFragmentSizeHandle; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40009B7")]
		public ComputeShader computeShader; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40009B8")]
		public int kernelIndex; //Field offset: 0x58
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x40009B9")]
		public Vector4 scaleBias; //Field offset: 0x5C
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x40009BA")]
		public Vector2Int dispatchSize; //Field offset: 0x6C
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x40009BB")]
		public bool yFlip; //Field offset: 0x74

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000FA0")]
		public ConversionPassData() { }

	}

	[Token(Token = "0x200022D")]
	private class VisualizationPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40009BC")]
		public Material material; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40009BD")]
		public TextureHandle source; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40009BE")]
		public BufferHandle lut; //Field offset: 0x28
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40009BF")]
		public TextureHandle dummy; //Field offset: 0x34
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x40009C0")]
		public Vector4 visualizationParams; //Field offset: 0x44

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000FA1")]
		public VisualizationPassData() { }

	}

	[Token(Token = "0x40009B0")]
	internal static readonly int shadingRateFragmentSizeCount; //Field offset: 0x0
	[Token(Token = "0x40009B1")]
	private static VrsResources s_VrsResources; //Field offset: 0x8

	[Address(RVA = "0x2C6DCC0", Offset = "0x2C6D0C0", Length = "0xC9E")]
	[Token(Token = "0x6000F9F")]
	private static Vrs() { }

	[Address(RVA = "0x2C6C8B0", Offset = "0x2C6BCB0", Length = "0x1ED")]
	[Token(Token = "0x6000F99")]
	public static TextureHandle ColorMaskTextureToShadingRateImage(RenderGraph renderGraph, RTHandle sriRtHandle, RTHandle colorMaskRtHandle, bool yFlip) { }

	[Address(RVA = "0x2C6C040", Offset = "0x2C6B440", Length = "0x868")]
	[Token(Token = "0x6000F9A")]
	public static TextureHandle ColorMaskTextureToShadingRateImage(RenderGraph renderGraph, TextureHandle sriTextureHandle, TextureHandle colorMaskHandle, TextureDimension colorMaskDimension, bool yFlip) { }

	[Address(RVA = "0x2C6BA70", Offset = "0x2C6AE70", Length = "0x5CA")]
	[Token(Token = "0x6000F9D")]
	public static void ColorMaskTextureToShadingRateImageDispatch(CommandBuffer cmd, RTHandle sriDestination, Texture colorMaskSource, bool yFlip = true) { }

	[Address(RVA = "0x2C6CAA0", Offset = "0x2C6BEA0", Length = "0x309")]
	[Token(Token = "0x6000F9C")]
	private static void ConversionDispatch(ComputeCommandBuffer cmd, ConversionPassData conversionPassData) { }

	[Address(RVA = "0x2C6CDB0", Offset = "0x2C6C1B0", Length = "0x9E")]
	[Token(Token = "0x6000F98")]
	public static void DisposeResources() { }

	[Address(RVA = "0x2C6CE50", Offset = "0x2C6C250", Length = "0x107")]
	[Token(Token = "0x6000F97")]
	public static void InitializeResources() { }

	[Address(RVA = "0x2C6CF60", Offset = "0x2C6C360", Length = "0x5D")]
	[Token(Token = "0x6000F95")]
	public static bool IsColorMaskTextureConversionSupported() { }

	[Address(RVA = "0x2C6CFC0", Offset = "0x2C6C3C0", Length = "0x126")]
	[Token(Token = "0x6000F96")]
	public static bool IsInitialized() { }

	[Address(RVA = "0x2C6D580", Offset = "0x2C6C980", Length = "0x731")]
	[Token(Token = "0x6000F9B")]
	public static void ShadingRateImageToColorMaskTexture(RenderGraph renderGraph, in TextureHandle sriTextureHandle, in TextureHandle colorMaskHandle) { }

	[Address(RVA = "0x2C6D0F0", Offset = "0x2C6C4F0", Length = "0x48E")]
	[Token(Token = "0x6000F9E")]
	public static void ShadingRateImageToColorMaskTextureBlit(CommandBuffer cmd, RTHandle sriSource, RTHandle colorMaskDestination) { }

}

