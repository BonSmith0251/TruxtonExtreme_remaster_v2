namespace UnityEngine.Rendering;

[Token(Token = "0x200019C")]
public static class RTHandles
{
	[Token(Token = "0x40007EC")]
	private static RTHandleSystem s_DefaultInstance; //Field offset: 0x0

	[Token(Token = "0x1700017C")]
	public static int maxHeight
	{
		[Address(RVA = "0x2C4E5B0", Offset = "0x2C4D9B0", Length = "0x5B")]
		[Token(Token = "0x6000BF8")]
		 get { } //Length: 91
	}

	[Token(Token = "0x1700017B")]
	public static int maxWidth
	{
		[Address(RVA = "0x2C4E610", Offset = "0x2C4DA10", Length = "0x5B")]
		[Token(Token = "0x6000BF7")]
		 get { } //Length: 91
	}

	[Token(Token = "0x1700017D")]
	public static RTHandleProperties rtHandleProperties
	{
		[Address(RVA = "0x2C4E670", Offset = "0x2C4DA70", Length = "0x78")]
		[Token(Token = "0x6000BF9")]
		 get { } //Length: 120
	}

	[Address(RVA = "0x2C4E530", Offset = "0x2C4D930", Length = "0x73")]
	[Token(Token = "0x6000C17")]
	private static RTHandles() { }

	[Address(RVA = "0x2C4D530", Offset = "0x2C4C930", Length = "0x56")]
	[Token(Token = "0x6000C0F")]
	private static RTHandle Alloc(RTHandle tex) { }

	[Address(RVA = "0x2C4D8A0", Offset = "0x2C4CCA0", Length = "0x96")]
	[Token(Token = "0x6000C0E")]
	public static RTHandle Alloc(RenderTargetIdentifier tex, string name) { }

	[Address(RVA = "0x2C4D040", Offset = "0x2C4C440", Length = "0xB6")]
	[Token(Token = "0x6000C0D")]
	public static RTHandle Alloc(RenderTargetIdentifier tex) { }

	[Address(RVA = "0x2C4CB10", Offset = "0x2C4BF10", Length = "0x110")]
	[Token(Token = "0x6000C0C")]
	public static RTHandle Alloc(RenderTexture tex, bool transferOwnership = false) { }

	[Address(RVA = "0x2C4CCE0", Offset = "0x2C4C0E0", Length = "0x155")]
	[Token(Token = "0x6000C0B")]
	public static RTHandle Alloc(Texture tex) { }

	[Address(RVA = "0x2C4CC30", Offset = "0x2C4C030", Length = "0xAB")]
	[Token(Token = "0x6000C0A")]
	public static RTHandle Alloc(ScaleFunc scaleFunc, RTHandleAllocInfo info) { }

	[Address(RVA = "0x2C4D260", Offset = "0x2C4C660", Length = "0x120")]
	[Token(Token = "0x6000C09")]
	public static RTHandle Alloc(ScaleFunc scaleFunc, in RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	[Address(RVA = "0x2C4C9A0", Offset = "0x2C4BDA0", Length = "0x16A")]
	[Token(Token = "0x6000C08")]
	public static RTHandle Alloc(ScaleFunc scaleFunc, GraphicsFormat format, int slices = 1, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	[Address(RVA = "0x2C4D940", Offset = "0x2C4CD40", Length = "0xB3")]
	[Token(Token = "0x6000C06")]
	public static RTHandle Alloc(Vector2 scaleFactor, RTHandleAllocInfo info) { }

	[Address(RVA = "0x2C4C700", Offset = "0x2C4BB00", Length = "0x122")]
	[Token(Token = "0x6000C05")]
	public static RTHandle Alloc(Vector2 scaleFactor, in RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	[Address(RVA = "0x2C4D720", Offset = "0x2C4CB20", Length = "0x172")]
	[Token(Token = "0x6000C04")]
	public static RTHandle Alloc(Vector2 scaleFactor, GraphicsFormat format, int slices = 1, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	[Address(RVA = "0x2C4D100", Offset = "0x2C4C500", Length = "0x15E")]
	[Token(Token = "0x6000C07")]
	public static RTHandle Alloc(ScaleFunc scaleFunc, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	[Address(RVA = "0x2C4CE40", Offset = "0x2C4C240", Length = "0x129")]
	[Token(Token = "0x6000C00")]
	public static RTHandle Alloc(in RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	[Address(RVA = "0x2C4CF70", Offset = "0x2C4C370", Length = "0xC3")]
	[Token(Token = "0x6000BFF")]
	public static RTHandle Alloc(int width, int height, RTHandleAllocInfo info) { }

	[Address(RVA = "0x2C4D390", Offset = "0x2C4C790", Length = "0x19C")]
	[Token(Token = "0x6000BFE")]
	public static RTHandle Alloc(int width, int height, TextureWrapMode wrapModeU, TextureWrapMode wrapModeV, TextureWrapMode wrapModeW = 0, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	[Address(RVA = "0x2C4D590", Offset = "0x2C4C990", Length = "0x184")]
	[Token(Token = "0x6000BFD")]
	public static RTHandle Alloc(int width, int height, GraphicsFormat format, int slices = 1, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	[Address(RVA = "0x2C4DA00", Offset = "0x2C4CE00", Length = "0x1DC")]
	[Token(Token = "0x6000BFC")]
	public static RTHandle Alloc(int width, int height, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	[Address(RVA = "0x2C4C830", Offset = "0x2C4BC30", Length = "0x160")]
	[Token(Token = "0x6000C03")]
	public static RTHandle Alloc(Vector2 scaleFactor, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	[Address(RVA = "0x2C4DBE0", Offset = "0x2C4CFE0", Length = "0xC5")]
	[Token(Token = "0x6000BFA")]
	public static Vector2Int CalculateDimensions(Vector2 scaleFactor) { }

	[Address(RVA = "0x2C4DCB0", Offset = "0x2C4D0B0", Length = "0xA6")]
	[Token(Token = "0x6000BFB")]
	public static Vector2Int CalculateDimensions(ScaleFunc scaleFunc) { }

	[Address(RVA = "0x2C4DD60", Offset = "0x2C4D160", Length = "0x87")]
	[Token(Token = "0x6000C16")]
	public static Vector2 CalculateRatioAgainstMaxSize(int width, int height) { }

	[Address(RVA = "0x2C4E5B0", Offset = "0x2C4D9B0", Length = "0x5B")]
	[Token(Token = "0x6000BF8")]
	public static int get_maxHeight() { }

	[Address(RVA = "0x2C4E610", Offset = "0x2C4DA10", Length = "0x5B")]
	[Token(Token = "0x6000BF7")]
	public static int get_maxWidth() { }

	[Address(RVA = "0x2C4E670", Offset = "0x2C4DA70", Length = "0x78")]
	[Token(Token = "0x6000BF9")]
	public static RTHandleProperties get_rtHandleProperties() { }

	[Address(RVA = "0x2C4DDF0", Offset = "0x2C4D1F0", Length = "0x8")]
	[Token(Token = "0x6000C01")]
	internal static GraphicsFormat GetFormat(GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	[Address(RVA = "0x2C4DE00", Offset = "0x2C4D200", Length = "0x294")]
	[Token(Token = "0x6000C02")]
	internal static RTHandleAllocInfo GetRTHandleAllocInfo(in RenderTextureDescriptor desc, FilterMode filterMode, TextureWrapMode wrapMode, int anisoLevel, float mipMapBias, string name) { }

	[Address(RVA = "0x2C4E0A0", Offset = "0x2C4D4A0", Length = "0x74")]
	[Token(Token = "0x6000C10")]
	public static void Initialize(int width, int height) { }

	[Address(RVA = "0x2C4E120", Offset = "0x2C4D520", Length = "0x99")]
	[Obsolete("useLegacyDynamicResControl is deprecated. Please use SetHardwareDynamicResolutionState() instead. #from(2023.3)")]
	[Token(Token = "0x6000C11")]
	public static void Initialize(int width, int height, bool useLegacyDynamicResControl = false) { }

	[Address(RVA = "0x2C4E1C0", Offset = "0x2C4D5C0", Length = "0x68")]
	[Token(Token = "0x6000C12")]
	public static void Release(RTHandle rth) { }

	[Address(RVA = "0x2C4E230", Offset = "0x2C4D630", Length = "0x84")]
	[Token(Token = "0x6000C15")]
	public static void ResetReferenceSize(int width, int height) { }

	[Address(RVA = "0x2C4E2C0", Offset = "0x2C4D6C0", Length = "0x1E1")]
	[Token(Token = "0x6000C13")]
	public static void SetHardwareDynamicResolutionState(bool hwDynamicResRequested) { }

	[Address(RVA = "0x2C4E4B0", Offset = "0x2C4D8B0", Length = "0x7E")]
	[Token(Token = "0x6000C14")]
	public static void SetReferenceSize(int width, int height) { }

}

