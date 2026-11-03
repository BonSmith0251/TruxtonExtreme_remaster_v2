namespace UnityEngine.Rendering;

[Token(Token = "0x20001A0")]
public class RTHandleSystem : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x20001A2")]
	private sealed class <>c
	{
		[Token(Token = "0x4000811")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000812")]
		public static ScaleFunc <>9__32_0; //Field offset: 0x8

		[Address(RVA = "0x2C53D10", Offset = "0x2C53110", Length = "0x67")]
		[Token(Token = "0x6000C71")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C72")]
		public <>c() { }

		[Address(RVA = "0x2C53B50", Offset = "0x2C52F50", Length = "0xA")]
		[Token(Token = "0x6000C73")]
		internal Vector2Int <Alloc>b__32_0(Vector2Int refSize) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001A3")]
	private sealed class <>c__DisplayClass37_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000813")]
		public Vector2 scaleFactor; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C74")]
		public <>c__DisplayClass37_0() { }

		[Address(RVA = "0x2C53BF0", Offset = "0x2C52FF0", Length = "0x74")]
		[Token(Token = "0x6000C75")]
		internal Vector2Int <Alloc>b__0(Vector2Int refSize) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001A4")]
	private sealed class <>c__DisplayClass41_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000814")]
		public ScaleFunc scaleFunc; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C76")]
		public <>c__DisplayClass41_0() { }

		[Address(RVA = "0x2C53C70", Offset = "0x2C53070", Length = "0x2E")]
		[Token(Token = "0x6000C77")]
		internal Vector2Int <Alloc>b__0(Vector2Int refSize) { }

	}

	[Token(Token = "0x20001A1")]
	public enum ResizeMode : int
	{
		Auto = 0,
		OnDemand = 1,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000807")]
	private bool m_HardwareDynamicResRequested; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000808")]
	private HashSet<RTHandle> m_AutoSizedRTs; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000809")]
	private RTHandle[] m_AutoSizedRTsArray; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400080A")]
	private HashSet<RTHandle> m_ResizeOnDemandRTs; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400080B")]
	private RTHandleProperties m_RTHandleProperties; //Field offset: 0x30
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400080C")]
	private int m_MaxWidths; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400080D")]
	private int m_MaxHeights; //Field offset: 0x64

	[Token(Token = "0x17000193")]
	public RTHandleProperties rtHandleProperties
	{
		[Address(RVA = "0x27A9020", Offset = "0x27A8420", Length = "0x1B")]
		[Token(Token = "0x6000C47")]
		 get { } //Length: 27
	}

	[Address(RVA = "0x2C4BD30", Offset = "0x2C4B130", Length = "0xB4")]
	[Token(Token = "0x6000C48")]
	public RTHandleSystem() { }

	[Address(RVA = "0x2C48D80", Offset = "0x2C48180", Length = "0x198")]
	[Token(Token = "0x6000C5B")]
	public RTHandle Alloc(int width, int height, TextureWrapMode wrapModeU, TextureWrapMode wrapModeV, TextureWrapMode wrapModeW = 0, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	[Address(RVA = "0x2C48F20", Offset = "0x2C48320", Length = "0x315")]
	[Token(Token = "0x6000C5E")]
	public RTHandle Alloc(int width, int height, RTHandleAllocInfo info) { }

	[Address(RVA = "0x2C48950", Offset = "0x2C47D50", Length = "0x216")]
	[Token(Token = "0x6000C5C")]
	public RTHandle Alloc(int width, int height, GraphicsFormat format, TextureWrapMode wrapModeU, TextureWrapMode wrapModeV, TextureWrapMode wrapModeW = 0, int slices = 1, FilterMode filterMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	[Address(RVA = "0x2C49A90", Offset = "0x2C48E90", Length = "0xEE")]
	[Token(Token = "0x6000C5A")]
	public RTHandle Alloc(int width, int height, GraphicsFormat format, int slices = 1, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	[Address(RVA = "0x2C485F0", Offset = "0x2C479F0", Length = "0x18A")]
	[Token(Token = "0x6000C59")]
	public RTHandle Alloc(int width, int height, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	[Address(RVA = "0x2C48B70", Offset = "0x2C47F70", Length = "0x20C")]
	[Token(Token = "0x6000C63")]
	public RTHandle Alloc(Vector2 scaleFactor, RTHandleAllocInfo info) { }

	[Address(RVA = "0x2C496F0", Offset = "0x2C48AF0", Length = "0x16A")]
	[Token(Token = "0x6000C65")]
	public RTHandle Alloc(ScaleFunc scaleFunc, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	[Address(RVA = "0x2C49860", Offset = "0x2C48C60", Length = "0x1CF")]
	[Token(Token = "0x6000C61")]
	public RTHandle Alloc(Vector2 scaleFactor, GraphicsFormat format, int slices = 1, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	[Address(RVA = "0x2C48780", Offset = "0x2C47B80", Length = "0x1C1")]
	[Token(Token = "0x6000C66")]
	public RTHandle Alloc(ScaleFunc scaleFunc, GraphicsFormat format, int slices = 1, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	[Address(RVA = "0x2C49B80", Offset = "0x2C48F80", Length = "0x207")]
	[Token(Token = "0x6000C67")]
	public RTHandle Alloc(ScaleFunc scaleFunc, RTHandleAllocInfo info) { }

	[Address(RVA = "0x2C49490", Offset = "0x2C48890", Length = "0x172")]
	[Token(Token = "0x6000C62")]
	public RTHandle Alloc(Vector2 scaleFactor, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	[Address(RVA = "0x2C493C0", Offset = "0x2C487C0", Length = "0xC6")]
	[Token(Token = "0x6000C6A")]
	public RTHandle Alloc(RenderTexture texture, bool transferOwnership = false) { }

	[Address(RVA = "0x2C492B0", Offset = "0x2C486B0", Length = "0x10A")]
	[Token(Token = "0x6000C6B")]
	public RTHandle Alloc(Texture texture) { }

	[Address(RVA = "0x2C49240", Offset = "0x2C48640", Length = "0x6A")]
	[Token(Token = "0x6000C6C")]
	public RTHandle Alloc(RenderTargetIdentifier texture) { }

	[Address(RVA = "0x2C49610", Offset = "0x2C48A10", Length = "0xD6")]
	[Token(Token = "0x6000C6D")]
	public RTHandle Alloc(RenderTargetIdentifier texture, string name) { }

	[Address(RVA = "0x2C49A30", Offset = "0x2C48E30", Length = "0x56")]
	[Token(Token = "0x6000C6E")]
	private static RTHandle Alloc(RTHandle tex) { }

	[Address(RVA = "0x2C483C0", Offset = "0x2C477C0", Length = "0x22C")]
	[Token(Token = "0x6000C68")]
	internal RTHandle AllocAutoSizedRenderTexture(int width, int height, int slices, GraphicsFormat format, FilterMode filterMode, TextureWrapMode wrapMode, TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, RenderTextureMemoryless memoryless, VRTextureUsage vrUsage, bool enableShadingRate, string name) { }

	[Address(RVA = "0x2C481E0", Offset = "0x2C475E0", Length = "0x1DE")]
	[Token(Token = "0x6000C69")]
	internal RTHandle AllocAutoSizedRenderTexture(int width, int height, RTHandleAllocInfo info) { }

	[Address(RVA = "0x2C49D90", Offset = "0x2C49190", Length = "0x59")]
	[Token(Token = "0x6000C64")]
	public Vector2Int CalculateDimensions(ScaleFunc scaleFunc) { }

	[Address(RVA = "0x2C49DF0", Offset = "0x2C491F0", Length = "0x6E")]
	[Token(Token = "0x6000C5F")]
	public Vector2Int CalculateDimensions(Vector2 scaleFactor) { }

	[Address(RVA = "0x2C49E60", Offset = "0x2C49260", Length = "0x67")]
	[Token(Token = "0x6000C60")]
	private static Vector2Int CalculateDimensions(Vector2 scaleFactor, Vector2Int size) { }

	[Address(RVA = "0x2C49ED0", Offset = "0x2C492D0", Length = "0x21B")]
	[Token(Token = "0x6000C51")]
	internal Vector2 CalculateRatioAgainstMaxSize(in Vector2Int viewportSize) { }

	[Address(RVA = "0x2C4A0F0", Offset = "0x2C494F0", Length = "0x5C1")]
	[Token(Token = "0x6000C5D")]
	private RenderTexture CreateRenderTexture(int width, int height, GraphicsFormat format, int slices, FilterMode filterMode, TextureWrapMode wrapModeU, TextureWrapMode wrapModeV, TextureWrapMode wrapModeW, TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, bool useDynamicScaleExplicit, RenderTextureMemoryless memoryless, VRTextureUsage vrUsage, bool enableShadingRate, string name) { }

	[Address(RVA = "0x2C4A6C0", Offset = "0x2C49AC0", Length = "0x2D0")]
	[Token(Token = "0x6000C54")]
	private void DemandResize(RTHandle rth) { }

	[Address(RVA = "0x2C4A9A0", Offset = "0x2C49DA0", Length = "0x1E9")]
	[Token(Token = "0x6000C57")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x2C4AB90", Offset = "0x2C49F90", Length = "0xA")]
	[Token(Token = "0x6000C49")]
	public override void Dispose() { }

	[Address(RVA = "0x2C4ABA0", Offset = "0x2C49FA0", Length = "0x3B3")]
	[Token(Token = "0x6000C6F")]
	internal string DumpRTInfo() { }

	[Address(RVA = "0x27A9020", Offset = "0x27A8420", Length = "0x1B")]
	[Token(Token = "0x6000C47")]
	public RTHandleProperties get_rtHandleProperties() { }

	[Address(RVA = "0x121E530", Offset = "0x121D930", Length = "0x4")]
	[Token(Token = "0x6000C56")]
	public int GetMaxHeight() { }

	[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
	[Token(Token = "0x6000C55")]
	public int GetMaxWidth() { }

	[Address(RVA = "0x2C4AF60", Offset = "0x2C4A360", Length = "0x6D")]
	[Token(Token = "0x6000C70")]
	private GraphicsFormat GetStencilFormat(GraphicsFormat depthStencilFormat) { }

	[Address(RVA = "0x2C4AFD0", Offset = "0x2C4A3D0", Length = "0x2C")]
	[Obsolete("useLegacyDynamicResControl is deprecated. Please use SetHardwareDynamicResolutionState() instead. #from(2023.3)")]
	[Token(Token = "0x6000C4B")]
	public void Initialize(int width, int height, bool useLegacyDynamicResControl = false) { }

	[Address(RVA = "0x2C4B000", Offset = "0x2C4A400", Length = "0x270")]
	[Token(Token = "0x6000C4A")]
	public void Initialize(int width, int height) { }

	[Address(RVA = "0x2C4B280", Offset = "0x2C4A680", Length = "0x11D")]
	[Token(Token = "0x6000C4C")]
	public void Release(RTHandle rth) { }

	[Address(RVA = "0x2C4B3A0", Offset = "0x2C4A7A0", Length = "0x53")]
	[Token(Token = "0x6000C4D")]
	internal void Remove(RTHandle rth) { }

	[Address(RVA = "0x2C4B400", Offset = "0x2C4A800", Length = "0x21")]
	[Token(Token = "0x6000C4E")]
	public void ResetReferenceSize(int width, int height) { }

	[Address(RVA = "0x2C4B430", Offset = "0x2C4A830", Length = "0x423")]
	[Token(Token = "0x6000C58")]
	private void Resize(int width, int height, bool sizeChanged) { }

	[Address(RVA = "0x2C4B860", Offset = "0x2C4AC60", Length = "0x1A0")]
	[Token(Token = "0x6000C52")]
	public void SetHardwareDynamicResolutionState(bool enableHWDynamicRes) { }

	[Address(RVA = "0x2C4BA10", Offset = "0x2C4AE10", Length = "0x1FC")]
	[Token(Token = "0x6000C50")]
	public void SetReferenceSize(int width, int height, bool reset) { }

	[Address(RVA = "0x2C4BC10", Offset = "0x2C4B010", Length = "0x1A")]
	[Token(Token = "0x6000C4F")]
	public void SetReferenceSize(int width, int height) { }

	[Address(RVA = "0x2C4BC30", Offset = "0x2C4B030", Length = "0xF8")]
	[Token(Token = "0x6000C53")]
	internal void SwitchResizeMode(RTHandle rth, ResizeMode mode) { }

}

