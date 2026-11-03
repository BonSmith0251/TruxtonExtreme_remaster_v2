namespace UnityEngine.Rendering;

[Token(Token = "0x20001B6")]
public static class Blitter
{
	[Token(Token = "0x20001B9")]
	private enum BlitColorAndDepthPassNames : int
	{
		ColorOnly = 0,
		ColorAndDepth = 1,
		DepthOnly = 2,
	}

	[Token(Token = "0x20001B7")]
	private static class BlitShaderIDs
	{
		[Token(Token = "0x4000870")]
		public static readonly int _BlitTexture; //Field offset: 0x0
		[Token(Token = "0x4000871")]
		public static readonly int _BlitCubeTexture; //Field offset: 0x4
		[Token(Token = "0x4000872")]
		public static readonly int _BlitScaleBias; //Field offset: 0x8
		[Token(Token = "0x4000873")]
		public static readonly int _BlitScaleBiasRt; //Field offset: 0xC
		[Token(Token = "0x4000874")]
		public static readonly int _SourceResolution; //Field offset: 0x10
		[Token(Token = "0x4000875")]
		public static readonly int _BlitMipLevel; //Field offset: 0x14
		[Token(Token = "0x4000876")]
		public static readonly int _BlitTexArraySlice; //Field offset: 0x18
		[Token(Token = "0x4000877")]
		public static readonly int _BlitTextureSize; //Field offset: 0x1C
		[Token(Token = "0x4000878")]
		public static readonly int _BlitPaddingSize; //Field offset: 0x20
		[Token(Token = "0x4000879")]
		public static readonly int _BlitDecodeInstructions; //Field offset: 0x24
		[Token(Token = "0x400087A")]
		public static readonly int _InputDepth; //Field offset: 0x28
		[Token(Token = "0x400087B")]
		public static readonly int _InputDepthXR; //Field offset: 0x2C
		[Token(Token = "0x400087C")]
		public static readonly int _InputDepthXRMS; //Field offset: 0x30

		[Address(RVA = "0x2C3CC00", Offset = "0x2C3C000", Length = "0x257")]
		[Token(Token = "0x6000D7F")]
		private static BlitShaderIDs() { }

	}

	[Token(Token = "0x20001B8")]
	private enum BlitShaderPassNames : int
	{
		Nearest = 0,
		Bilinear = 1,
		NearestQuad = 2,
		BilinearQuad = 3,
		NearestQuadPadding = 4,
		BilinearQuadPadding = 5,
		NearestQuadPaddingRepeat = 6,
		BilinearQuadPaddingRepeat = 7,
		BilinearQuadPaddingOctahedral = 8,
		NearestQuadPaddingAlphaBlend = 9,
		BilinearQuadPaddingAlphaBlend = 10,
		NearestQuadPaddingAlphaBlendRepeat = 11,
		BilinearQuadPaddingAlphaBlendRepeat = 12,
		BilinearQuadPaddingAlphaBlendOctahedral = 13,
		CubeToOctahedral = 14,
		CubeToOctahedralLuminance = 15,
		CubeToOctahedralAlpha = 16,
		CubeToOctahedralRed = 17,
		BilinearQuadLuminance = 18,
		BilinearQuadAlpha = 19,
		BilinearQuadRed = 20,
		NearestCubeToOctahedralPadding = 21,
		BilinearCubeToOctahedralPadding = 22,
	}

	[Token(Token = "0x4000862")]
	private static Material s_Copy; //Field offset: 0x0
	[Token(Token = "0x4000863")]
	private static Material s_Blit; //Field offset: 0x8
	[Token(Token = "0x4000864")]
	private static Material s_BlitTexArray; //Field offset: 0x10
	[Token(Token = "0x4000865")]
	private static Material s_BlitTexArraySingleSlice; //Field offset: 0x18
	[Token(Token = "0x4000866")]
	private static Material s_BlitColorAndDepth; //Field offset: 0x20
	[Token(Token = "0x4000867")]
	private static MaterialPropertyBlock s_PropertyBlock; //Field offset: 0x28
	[Token(Token = "0x4000868")]
	private static Mesh s_TriangleMesh; //Field offset: 0x30
	[Token(Token = "0x4000869")]
	private static Mesh s_QuadMesh; //Field offset: 0x38
	[Token(Token = "0x400086A")]
	private static LocalKeyword s_DecodeHdrKeyword; //Field offset: 0x40
	[Token(Token = "0x400086B")]
	private static LocalKeyword s_ResolveDepthMSAA2X; //Field offset: 0x58
	[Token(Token = "0x400086C")]
	private static LocalKeyword s_ResolveDepthMSAA4X; //Field offset: 0x70
	[Token(Token = "0x400086D")]
	private static LocalKeyword s_ResolveDepthMSAA8X; //Field offset: 0x88
	[Token(Token = "0x400086E")]
	private static Int32[] s_BlitShaderPassIndicesMap; //Field offset: 0xA0
	[Token(Token = "0x400086F")]
	private static Int32[] s_BlitColorAndDepthShaderPassIndicesMap; //Field offset: 0xA8

	[Address(RVA = "0x2C42FE0", Offset = "0x2C423E0", Length = "0x78")]
	[Token(Token = "0x6000D7A")]
	private static Blitter() { }

	[Address(RVA = "0x2C42C50", Offset = "0x2C42050", Length = "0x109")]
	[CompilerGenerated]
	[Token(Token = "0x6000D7C")]
	internal static Vector2[] <Initialize>g__GetFullScreenTriangleTexCoord|17_1() { }

	[Address(RVA = "0x2C42D60", Offset = "0x2C42160", Length = "0xC4")]
	[CompilerGenerated]
	[Token(Token = "0x6000D7B")]
	internal static Vector3[] <Initialize>g__GetFullScreenTriangleVertexPosition|17_0(float z) { }

	[Address(RVA = "0x2C42E30", Offset = "0x2C42230", Length = "0xE6")]
	[CompilerGenerated]
	[Token(Token = "0x6000D7E")]
	internal static Vector2[] <Initialize>g__GetQuadTexCoord|17_3() { }

	[Address(RVA = "0x2C42F20", Offset = "0x2C42320", Length = "0xB8")]
	[CompilerGenerated]
	[Token(Token = "0x6000D7D")]
	internal static Vector3[] <Initialize>g__GetQuadVertexPosition|17_2(float z) { }

	[Address(RVA = "0x2C3D040", Offset = "0x2C3C440", Length = "0x1D7")]
	[Token(Token = "0x6000D6A")]
	public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, float mipLevel = 0, bool bilinear = false) { }

	[Address(RVA = "0x2C3D870", Offset = "0x2C3CC70", Length = "0x1CF")]
	[Token(Token = "0x6000D6C")]
	public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Material material, int pass) { }

	[Address(RVA = "0x2C3D220", Offset = "0x2C3C620", Length = "0x11D")]
	[Token(Token = "0x6000D6D")]
	public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Vector4 scaleBias, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int pass) { }

	[Address(RVA = "0x2C3D630", Offset = "0x2C3CA30", Length = "0x235")]
	[Token(Token = "0x6000D6E")]
	public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int pass) { }

	[Address(RVA = "0x2C3D540", Offset = "0x2C3C940", Length = "0xE7")]
	[Token(Token = "0x6000D6F")]
	public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Vector4 scaleBias, float mipLevel = 0, bool bilinear = false) { }

	[Address(RVA = "0x2C3D340", Offset = "0x2C3C740", Length = "0x1F8")]
	[Token(Token = "0x6000D70")]
	public static void BlitCameraTexture(CommandBuffer cmd, RTHandle source, RTHandle destination, Rect destViewport, float mipLevel = 0, bool bilinear = false) { }

	[Address(RVA = "0x2C3CE60", Offset = "0x2C3C260", Length = "0x1D7")]
	[Token(Token = "0x6000D6B")]
	public static void BlitCameraTexture2D(CommandBuffer cmd, RTHandle source, RTHandle destination, float mipLevel = 0, bool bilinear = false) { }

	[Address(RVA = "0x2C3DA40", Offset = "0x2C3CE40", Length = "0xB3")]
	[Token(Token = "0x6000D5E")]
	public static void BlitColorAndDepth(RasterCommandBuffer cmd, Texture sourceColor, RenderTexture sourceDepth, Vector4 scaleBias, float mipLevel, bool blitDepth) { }

	[Address(RVA = "0x2C3DB00", Offset = "0x2C3CF00", Length = "0x23C")]
	[Token(Token = "0x6000D5F")]
	public static void BlitColorAndDepth(CommandBuffer cmd, Texture sourceColor, RenderTexture sourceDepth, Vector4 scaleBias, float mipLevel, bool blitDepth) { }

	[Address(RVA = "0x2C3E400", Offset = "0x2C3D800", Length = "0x1FA")]
	[Token(Token = "0x6000D76")]
	public static void BlitCubeToOctahedral2DQuad(CommandBuffer cmd, Texture source, Vector4 scaleBiasRT, int mipLevelTex) { }

	[Address(RVA = "0x2C3DD40", Offset = "0x2C3D140", Length = "0x2C4")]
	[Token(Token = "0x6000D78")]
	public static void BlitCubeToOctahedral2DQuadSingleChannel(CommandBuffer cmd, Texture source, Vector4 scaleBiasRT, int mipLevelTex) { }

	[Address(RVA = "0x2C3E010", Offset = "0x2C3D410", Length = "0x3E6")]
	[Token(Token = "0x6000D77")]
	public static void BlitCubeToOctahedral2DQuadWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels, Nullable<Vector4> decodeInstructions = null) { }

	[Address(RVA = "0x2C3E600", Offset = "0x2C3DA00", Length = "0x3B7")]
	[Token(Token = "0x6000D60")]
	public static void BlitDepth(CommandBuffer cmd, RenderTexture sourceDepth, Vector4 scaleBias, float mipLevel) { }

	[Address(RVA = "0x2C3EC60", Offset = "0x2C3E060", Length = "0x291")]
	[Token(Token = "0x6000D74")]
	public static void BlitOctahedralWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels) { }

	[Address(RVA = "0x2C3E9C0", Offset = "0x2C3DDC0", Length = "0x291")]
	[Token(Token = "0x6000D75")]
	public static void BlitOctahedralWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels) { }

	[Address(RVA = "0x2C3F870", Offset = "0x2C3EC70", Length = "0x221")]
	[Token(Token = "0x6000D71")]
	public static void BlitQuad(CommandBuffer cmd, Texture source, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear) { }

	[Address(RVA = "0x2C3EF00", Offset = "0x2C3E300", Length = "0x2C1")]
	[Token(Token = "0x6000D79")]
	public static void BlitQuadSingleChannel(CommandBuffer cmd, Texture source, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex) { }

	[Address(RVA = "0x2C3F520", Offset = "0x2C3E920", Length = "0x346")]
	[Token(Token = "0x6000D72")]
	public static void BlitQuadWithPadding(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels) { }

	[Address(RVA = "0x2C3F1D0", Offset = "0x2C3E5D0", Length = "0x346")]
	[Token(Token = "0x6000D73")]
	public static void BlitQuadWithPaddingMultiply(CommandBuffer cmd, Texture source, Vector2 textureSize, Vector4 scaleBiasTex, Vector4 scaleBiasRT, int mipLevelTex, bool bilinear, int paddingInPixels) { }

	[Address(RVA = "0x2C40530", Offset = "0x2C3F930", Length = "0x12D")]
	[Token(Token = "0x6000D69")]
	public static void BlitTexture(RasterCommandBuffer cmd, Vector4 scaleBias, Material material, int pass) { }

	[Address(RVA = "0x2C408B0", Offset = "0x2C3FCB0", Length = "0xEF")]
	[Token(Token = "0x6000D68")]
	public static void BlitTexture(CommandBuffer cmd, Vector4 scaleBias, Material material, int pass) { }

	[Address(RVA = "0x2C40330", Offset = "0x2C3F730", Length = "0x1FD")]
	[Token(Token = "0x6000D67")]
	public static void BlitTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int pass) { }

	[Address(RVA = "0x2C40710", Offset = "0x2C3FB10", Length = "0x197")]
	[Token(Token = "0x6000D64")]
	public static void BlitTexture(RasterCommandBuffer cmd, RenderTargetIdentifier source, Vector4 scaleBias, Material material, int pass) { }

	[Address(RVA = "0x2C40090", Offset = "0x2C3F490", Length = "0x15C")]
	[Token(Token = "0x6000D65")]
	public static void BlitTexture(CommandBuffer cmd, RenderTargetIdentifier source, Vector4 scaleBias, Material material, int pass) { }

	[Address(RVA = "0x2C3FF10", Offset = "0x2C3F310", Length = "0x17E")]
	[Token(Token = "0x6000D63")]
	public static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, Material material, int pass) { }

	[Address(RVA = "0x2C40E70", Offset = "0x2C40270", Length = "0xA0")]
	[Token(Token = "0x6000D62")]
	public static void BlitTexture(UnsafeCommandBuffer cmd, RTHandle source, Vector4 scaleBias, Material material, int pass) { }

	[Address(RVA = "0x2C40660", Offset = "0x2C3FA60", Length = "0xA0")]
	[Token(Token = "0x6000D61")]
	public static void BlitTexture(RasterCommandBuffer cmd, RTHandle source, Vector4 scaleBias, Material material, int pass) { }

	[Address(RVA = "0x2C40BD0", Offset = "0x2C3FFD0", Length = "0x292")]
	[Token(Token = "0x6000D5B")]
	public static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear) { }

	[Address(RVA = "0x2C40F20", Offset = "0x2C40320", Length = "0xA4")]
	[Token(Token = "0x6000D5A")]
	public static void BlitTexture(RasterCommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear) { }

	[Address(RVA = "0x2C401F0", Offset = "0x2C3F5F0", Length = "0x13F")]
	[Token(Token = "0x6000D59")]
	internal static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, Material material, int pass, float sourceMipLevel, int sourceDepthSlice) { }

	[Address(RVA = "0x2C409A0", Offset = "0x2C3FDA0", Length = "0x22F")]
	[Token(Token = "0x6000D58")]
	internal static void BlitTexture(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float sourceMipLevel, int sourceDepthSlice, bool bilinear) { }

	[Address(RVA = "0x2C3FD20", Offset = "0x2C3F120", Length = "0x1E7")]
	[Token(Token = "0x6000D66")]
	public static void BlitTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass) { }

	[Address(RVA = "0x2C3FB50", Offset = "0x2C3EF50", Length = "0x1C5")]
	[Token(Token = "0x6000D5D")]
	public static void BlitTexture2D(CommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear) { }

	[Address(RVA = "0x2C3FAA0", Offset = "0x2C3EEA0", Length = "0xA4")]
	[Token(Token = "0x6000D5C")]
	public static void BlitTexture2D(RasterCommandBuffer cmd, RTHandle source, Vector4 scaleBias, float mipLevel, bool bilinear) { }

	[Address(RVA = "0x2C40FD0", Offset = "0x2C403D0", Length = "0x78")]
	[Token(Token = "0x6000D55")]
	internal static bool CanCopyMSAA() { }

	[Address(RVA = "0x2C41050", Offset = "0x2C40450", Length = "0x105")]
	[Token(Token = "0x6000D56")]
	internal static bool CanCopyMSAA(bool srcBindTextureMS) { }

	[Address(RVA = "0x2C41160", Offset = "0x2C40560", Length = "0x23B")]
	[Token(Token = "0x6000D4C")]
	public static void Cleanup() { }

	[Address(RVA = "0x2C413A0", Offset = "0x2C407A0", Length = "0x129")]
	[Token(Token = "0x6000D57")]
	internal static void CopyTexture(RasterCommandBuffer cmd, bool isMSAA, bool force2DForXR = false) { }

	[Address(RVA = "0x2C415E0", Offset = "0x2C409E0", Length = "0x1BC")]
	[Token(Token = "0x6000D54")]
	internal static void DrawQuad(CommandBuffer cmd, Material material, int shaderPass, MaterialPropertyBlock propertyBlock) { }

	[Address(RVA = "0x2C41830", Offset = "0x2C40C30", Length = "0x86")]
	[Token(Token = "0x6000D53")]
	internal static void DrawQuad(CommandBuffer cmd, Material material, int shaderPass) { }

	[Address(RVA = "0x2C417A0", Offset = "0x2C40BA0", Length = "0x8D")]
	[Token(Token = "0x6000D52")]
	internal static void DrawQuad(RasterCommandBuffer cmd, Material material, int shaderPass, MaterialPropertyBlock propertyBlock) { }

	[Address(RVA = "0x2C414D0", Offset = "0x2C408D0", Length = "0x10C")]
	[Token(Token = "0x6000D51")]
	internal static void DrawQuadMesh(CommandBuffer cmd, Material material, int shaderPass, MaterialPropertyBlock propertyBlock) { }

	[Address(RVA = "0x2C418C0", Offset = "0x2C40CC0", Length = "0x1B8")]
	[Token(Token = "0x6000D50")]
	internal static void DrawTriangle(CommandBuffer cmd, Material material, int shaderPass, MaterialPropertyBlock propertyBlock) { }

	[Address(RVA = "0x2C41A80", Offset = "0x2C40E80", Length = "0x1FB")]
	[Token(Token = "0x6000D4F")]
	internal static void DrawTriangle(CommandBuffer cmd, Material material, int shaderPass) { }

	[Address(RVA = "0x2C41C80", Offset = "0x2C41080", Length = "0x77")]
	[Token(Token = "0x6000D4E")]
	internal static void DrawTriangle(RasterCommandBuffer cmd, Material material, int shaderPass) { }

	[Address(RVA = "0x2C41D00", Offset = "0x2C41100", Length = "0xFC")]
	[Token(Token = "0x6000D4D")]
	public static Material GetBlitMaterial(TextureDimension dimension, bool singleSlice = false) { }

	[Address(RVA = "0x2C41E00", Offset = "0x2C41200", Length = "0xE4C")]
	[Token(Token = "0x6000D4B")]
	public static void Initialize(Shader blitPS, Shader blitColorAndDepthPS) { }

}

