namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000161")]
public static class PostProcessUtils
{
	[Token(Token = "0x2000162")]
	private static class ShaderConstants
	{
		[Token(Token = "0x4000815")]
		public static readonly int _Grain_Texture; //Field offset: 0x0
		[Token(Token = "0x4000816")]
		public static readonly int _Grain_Params; //Field offset: 0x4
		[Token(Token = "0x4000817")]
		public static readonly int _Grain_TilingParams; //Field offset: 0x8
		[Token(Token = "0x4000818")]
		public static readonly int _BlueNoise_Texture; //Field offset: 0xC
		[Token(Token = "0x4000819")]
		public static readonly int _Dithering_Params; //Field offset: 0x10
		[Token(Token = "0x400081A")]
		public static readonly int _SourceSize; //Field offset: 0x14

		[Address(RVA = "0x2DDD0D0", Offset = "0x2DDC4D0", Length = "0x126")]
		[Token(Token = "0x60007E4")]
		private static ShaderConstants() { }

	}


	[Address(RVA = "0x2DCBD20", Offset = "0x2DCB120", Length = "0x7E")]
	[Obsolete("This method is obsolete. Use ConfigureDithering override that takes camera pixel width and height instead. #from(2021.1)")]
	[Token(Token = "0x60007DC")]
	public static int ConfigureDithering(PostProcessData data, int index, Camera camera, Material material) { }

	[Address(RVA = "0x2DCBB10", Offset = "0x2DCAF10", Length = "0x208")]
	[Token(Token = "0x60007DD")]
	public static int ConfigureDithering(PostProcessData data, int index, int cameraPixelWidth, int cameraPixelHeight, Material material) { }

	[Address(RVA = "0x2DCC150", Offset = "0x2DCB550", Length = "0x80")]
	[Obsolete("This method is obsolete. Use ConfigureFilmGrain override that takes camera pixel width and height instead. #from(2021.1)")]
	[Token(Token = "0x60007DE")]
	public static void ConfigureFilmGrain(PostProcessData data, FilmGrain settings, Camera camera, Material material) { }

	[Address(RVA = "0x2DCBDA0", Offset = "0x2DCB1A0", Length = "0x3A3")]
	[Token(Token = "0x60007DF")]
	public static void ConfigureFilmGrain(PostProcessData data, FilmGrain settings, int cameraPixelWidth, int cameraPixelHeight, Material material) { }

	[Address(RVA = "0x2DCC3D0", Offset = "0x2DCB7D0", Length = "0x11E")]
	[Token(Token = "0x60007E0")]
	internal static void SetSourceSize(RasterCommandBuffer cmd, float width, float height, RenderTexture rt) { }

	[Address(RVA = "0x2DCC340", Offset = "0x2DCB740", Length = "0x8C")]
	[Token(Token = "0x60007E1")]
	internal static void SetSourceSize(CommandBuffer cmd, float width, float height, RenderTexture rt) { }

	[Address(RVA = "0x2DCC1E0", Offset = "0x2DCB5E0", Length = "0x8D")]
	[Token(Token = "0x60007E2")]
	internal static void SetSourceSize(RasterCommandBuffer cmd, RTHandle source) { }

	[Address(RVA = "0x2DCC270", Offset = "0x2DCB670", Length = "0xCC")]
	[Token(Token = "0x60007E3")]
	internal static void SetSourceSize(CommandBuffer cmd, RTHandle source) { }

}

