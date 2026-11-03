namespace UnityEngine.Rendering;

[Token(Token = "0x20001BF")]
public static class CoreUtils
{
	[Token(Token = "0x20001C1")]
	internal static class Priorities
	{
		[Token(Token = "0x40008C0")]
		public const int assetsCreateShaderMenuPriority = 83; //Field offset: 0x0
		[Token(Token = "0x40008C1")]
		public const int assetsCreateRenderingMenuPriority = 308; //Field offset: 0x0
		[Token(Token = "0x40008C2")]
		public const int editMenuPriority = 320; //Field offset: 0x0
		[Token(Token = "0x40008C3")]
		public const int gameObjectMenuPriority = 10; //Field offset: 0x0
		[Token(Token = "0x40008C4")]
		public const int srpLensFlareMenuPriority = 9; //Field offset: 0x0
		[Token(Token = "0x40008C5")]
		public const int scriptingPriority = 40; //Field offset: 0x0

	}

	[Token(Token = "0x20001C0")]
	internal static class Sections
	{
		[Token(Token = "0x40008B8")]
		public const int section1 = 10000; //Field offset: 0x0
		[Token(Token = "0x40008B9")]
		public const int section2 = 20000; //Field offset: 0x0
		[Token(Token = "0x40008BA")]
		public const int section3 = 30000; //Field offset: 0x0
		[Token(Token = "0x40008BB")]
		public const int section4 = 40000; //Field offset: 0x0
		[Token(Token = "0x40008BC")]
		public const int section5 = 50000; //Field offset: 0x0
		[Token(Token = "0x40008BD")]
		public const int section6 = 60000; //Field offset: 0x0
		[Token(Token = "0x40008BE")]
		public const int section7 = 70000; //Field offset: 0x0
		[Token(Token = "0x40008BF")]
		public const int section8 = 80000; //Field offset: 0x0

	}

	[Token(Token = "0x40008A4")]
	public static readonly Vector3[] lookAtList; //Field offset: 0x0
	[Obsolete("Use CoreUtils.Priorities instead. #from(2021.2)")]
	[Token(Token = "0x40008AE")]
	public const int gameObjectMenuPriority = 10; //Field offset: 0x0
	[Obsolete("Use CoreUtils.Priorities instead. #from(2021.2)")]
	[Token(Token = "0x40008AC")]
	public const int assetCreateMenuPriority2 = 241; //Field offset: 0x0
	[Obsolete("Use CoreUtils.Priorities instead. #from(2021.2)")]
	[Token(Token = "0x40008AB")]
	public const int assetCreateMenuPriority1 = 230; //Field offset: 0x0
	[Obsolete("Use CoreUtils.Priorities instead. #from(2021.2)")]
	[Token(Token = "0x40008AA")]
	public const int editMenuPriority4 = 353; //Field offset: 0x0
	[Obsolete("Use CoreUtils.Priorities instead. #from(2021.2)")]
	[Token(Token = "0x40008AD")]
	public const int assetCreateMenuPriority3 = 300; //Field offset: 0x0
	[Obsolete("Use CoreUtils.Priorities instead. #from(2021.2)")]
	[Token(Token = "0x40008A8")]
	public const int editMenuPriority2 = 331; //Field offset: 0x0
	[Obsolete("Use CoreUtils.Priorities instead. #from(2021.2)")]
	[Token(Token = "0x40008A7")]
	public const int editMenuPriority1 = 320; //Field offset: 0x0
	[Token(Token = "0x40008A6")]
	private const string obsoletePriorityMessage = "Use CoreUtils.Priorities instead. #from(2021.2)"; //Field offset: 0x0
	[Obsolete("Use CoreUtils.Priorities instead. #from(2021.2)")]
	[Token(Token = "0x40008A9")]
	public const int editMenuPriority3 = 342; //Field offset: 0x0
	[Token(Token = "0x40008A5")]
	public static readonly Vector3[] upVectorList; //Field offset: 0x8
	[Token(Token = "0x40008AF")]
	private static Cubemap m_BlackCubeTexture; //Field offset: 0x10
	[Token(Token = "0x40008B0")]
	private static Cubemap m_MagentaCubeTexture; //Field offset: 0x18
	[Token(Token = "0x40008B1")]
	private static CubemapArray m_MagentaCubeTextureArray; //Field offset: 0x20
	[Token(Token = "0x40008B2")]
	private static Cubemap m_WhiteCubeTexture; //Field offset: 0x28
	[Token(Token = "0x40008B3")]
	private static RenderTexture m_EmptyUAV; //Field offset: 0x30
	[Token(Token = "0x40008B4")]
	private static GraphicsBuffer m_EmptyBuffer; //Field offset: 0x38
	[Token(Token = "0x40008B5")]
	private static Texture3D m_BlackVolumeTexture; //Field offset: 0x40
	[Token(Token = "0x40008B6")]
	internal static Texture3D m_WhiteVolumeTexture; //Field offset: 0x48
	[Token(Token = "0x40008B7")]
	private static IEnumerable<Type> s_AssemblyTypes; //Field offset: 0x50

	[Token(Token = "0x170001C1")]
	public static Cubemap blackCubeTexture
	{
		[Address(RVA = "0x2C5A400", Offset = "0x2C59800", Length = "0x1E0")]
		[Token(Token = "0x6000DA0")]
		 get { } //Length: 480
	}

	[Token(Token = "0x170001C7")]
	public static Texture3D blackVolumeTexture
	{
		[Address(RVA = "0x2C5A5F0", Offset = "0x2C599F0", Length = "0x1CE")]
		[Token(Token = "0x6000DA6")]
		 get { } //Length: 462
	}

	[Token(Token = "0x170001C6")]
	public static GraphicsBuffer emptyBuffer
	{
		[Address(RVA = "0x2C5A7C0", Offset = "0x2C59BC0", Length = "0x13D")]
		[Token(Token = "0x6000DA5")]
		 get { } //Length: 317
	}

	[Token(Token = "0x170001C5")]
	public static RenderTexture emptyUAV
	{
		[Address(RVA = "0x2C5A900", Offset = "0x2C59D00", Length = "0x171")]
		[Token(Token = "0x6000DA4")]
		 get { } //Length: 369
	}

	[Token(Token = "0x170001C2")]
	public static Cubemap magentaCubeTexture
	{
		[Address(RVA = "0x2C5ACB0", Offset = "0x2C5A0B0", Length = "0x1E0")]
		[Token(Token = "0x6000DA1")]
		 get { } //Length: 480
	}

	[Token(Token = "0x170001C3")]
	public static CubemapArray magentaCubeTextureArray
	{
		[Address(RVA = "0x2C5AA80", Offset = "0x2C59E80", Length = "0x225")]
		[Token(Token = "0x6000DA2")]
		 get { } //Length: 549
	}

	[Token(Token = "0x170001C4")]
	public static Cubemap whiteCubeTexture
	{
		[Address(RVA = "0x2C5AEA0", Offset = "0x2C5A2A0", Length = "0x1E0")]
		[Token(Token = "0x6000DA3")]
		 get { } //Length: 480
	}

	[Token(Token = "0x170001C8")]
	internal static Texture3D whiteVolumeTexture
	{
		[Address(RVA = "0x2C5B090", Offset = "0x2C5A490", Length = "0x1CE")]
		[Token(Token = "0x6000DA7")]
		internal get { } //Length: 462
	}

	[Address(RVA = "0x2C5A1D0", Offset = "0x2C595D0", Length = "0x226")]
	[Token(Token = "0x6000E02")]
	private static CoreUtils() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000DED")]
	public static bool AreAnimatedMaterialsEnabled(Camera camera) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000DEC")]
	public static bool ArePostProcessesEnabled(Camera camera) { }

	[Address(RVA = "0x2C54490", Offset = "0x2C53890", Length = "0x555")]
	[Token(Token = "0x6000DFD")]
	public static Vector3[] CalculateViewSpaceCorners(Matrix4x4 proj, float z) { }

	[Address(RVA = "0x2C549F0", Offset = "0x2C53DF0", Length = "0x276")]
	[Token(Token = "0x6000DD3")]
	public static void ClearCubemap(CommandBuffer cmd, RenderTexture renderTexture, Color clearColor, bool clearMips = false) { }

	[Address(RVA = "0x2C54C70", Offset = "0x2C54070", Length = "0x3D")]
	[Token(Token = "0x6000DA8")]
	public static void ClearRenderTarget(CommandBuffer cmd, ClearFlag clearFlag, Color clearColor) { }

	[Address(RVA = "0x2C54CB0", Offset = "0x2C540B0", Length = "0x9F")]
	[Token(Token = "0x6000DDB")]
	public static Color ConvertLinearToActiveColorSpace(Color color) { }

	[Address(RVA = "0x2C54D50", Offset = "0x2C54150", Length = "0x9F")]
	[Token(Token = "0x6000DDA")]
	public static Color ConvertSRGBToActiveColorSpace(Color color) { }

	[Address(RVA = "0x2C54DF0", Offset = "0x2C541F0", Length = "0x431")]
	[Token(Token = "0x6000DEB")]
	public static Mesh CreateCubeMesh(Vector3 min, Vector3 max) { }

	[Address(RVA = "0x2C55460", Offset = "0x2C54860", Length = "0xE4")]
	[Token(Token = "0x6000DDD")]
	public static Material CreateEngineMaterial(Shader shader) { }

	[Address(RVA = "0x2C55230", Offset = "0x2C54630", Length = "0x22A")]
	[Token(Token = "0x6000DDC")]
	public static Material CreateEngineMaterial(string shaderPath) { }

	[Address(RVA = "0x2C55550", Offset = "0x2C54950", Length = "0x75")]
	[Token(Token = "0x6000DE6")]
	public static void Destroy(object obj) { }

	[Address(RVA = "0x2C12730", Offset = "0x2C11B30", Length = "0xD")]
	[Token(Token = "0x6000DFA")]
	public static int DivRoundUp(int value, int divisor) { }

	[Address(RVA = "0x2C559A0", Offset = "0x2C54DA0", Length = "0xCE")]
	[Token(Token = "0x6000DD4")]
	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, MaterialPropertyBlock properties = null, int shaderPassId = 0) { }

	[Address(RVA = "0x2C55800", Offset = "0x2C54C00", Length = "0x19E")]
	[Token(Token = "0x6000DD9")]
	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier[] colorBuffers, MaterialPropertyBlock properties = null, int shaderPassId = 0) { }

	[Address(RVA = "0x2C556E0", Offset = "0x2C54AE0", Length = "0x114")]
	[Token(Token = "0x6000DD8")]
	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthStencilBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0) { }

	[Address(RVA = "0x2C55B80", Offset = "0x2C54F80", Length = "0x138")]
	[Token(Token = "0x6000DD7")]
	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthStencilBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0) { }

	[Address(RVA = "0x2C55A70", Offset = "0x2C54E70", Length = "0x10B")]
	[Token(Token = "0x6000DD6")]
	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier colorBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0) { }

	[Address(RVA = "0x2C555D0", Offset = "0x2C549D0", Length = "0x108")]
	[Token(Token = "0x6000DD5")]
	public static void DrawFullScreen(RasterCommandBuffer commandBuffer, Material material, MaterialPropertyBlock properties = null, int shaderPassId = 0) { }

	[Address(RVA = "0x2C55CC0", Offset = "0x2C550C0", Length = "0x33")]
	[Token(Token = "0x6000DF4")]
	public static void DrawRendererList(CommandBuffer cmd, RendererList rendererList) { }

	[Address(RVA = "0x2C55D40", Offset = "0x2C55140", Length = "0xD9")]
	[Token(Token = "0x6000DF5")]
	public static void DrawRendererList(IRasterCommandBuffer cmd, RendererList rendererList) { }

	[Address(RVA = "0x2C55D00", Offset = "0x2C55100", Length = "0x3B")]
	[Obsolete("Use DrawRendererList(CommandBuffer cmd, UnityEngine.Rendering.RendererList rendererList) instead. #from(6000.3) (UnityUpgradable) -> !0")]
	[Token(Token = "0x6000DF3")]
	public static void DrawRendererList(ScriptableRenderContext renderContext, CommandBuffer cmd, RendererList rendererList) { }

	[Address(RVA = "0x2C55E30", Offset = "0x2C55230", Length = "0x43")]
	[Token(Token = "0x6000DA9")]
	private static int FixupDepthSlice(int depthSlice, RTHandle buffer) { }

	[Address(RVA = "0x2C55E20", Offset = "0x2C55220", Length = "0x10")]
	[Token(Token = "0x6000DAA")]
	private static int FixupDepthSlice(int depthSlice, CubemapFace cubemapFace) { }

	[Address(RVA = "0x2C5A400", Offset = "0x2C59800", Length = "0x1E0")]
	[Token(Token = "0x6000DA0")]
	public static Cubemap get_blackCubeTexture() { }

	[Address(RVA = "0x2C5A5F0", Offset = "0x2C599F0", Length = "0x1CE")]
	[Token(Token = "0x6000DA6")]
	public static Texture3D get_blackVolumeTexture() { }

	[Address(RVA = "0x2C5A7C0", Offset = "0x2C59BC0", Length = "0x13D")]
	[Token(Token = "0x6000DA5")]
	public static GraphicsBuffer get_emptyBuffer() { }

	[Address(RVA = "0x2C5A900", Offset = "0x2C59D00", Length = "0x171")]
	[Token(Token = "0x6000DA4")]
	public static RenderTexture get_emptyUAV() { }

	[Address(RVA = "0x2C5ACB0", Offset = "0x2C5A0B0", Length = "0x1E0")]
	[Token(Token = "0x6000DA1")]
	public static Cubemap get_magentaCubeTexture() { }

	[Address(RVA = "0x2C5AA80", Offset = "0x2C59E80", Length = "0x225")]
	[Token(Token = "0x6000DA2")]
	public static CubemapArray get_magentaCubeTextureArray() { }

	[Address(RVA = "0x2C5AEA0", Offset = "0x2C5A2A0", Length = "0x1E0")]
	[Token(Token = "0x6000DA3")]
	public static Cubemap get_whiteCubeTexture() { }

	[Address(RVA = "0x2C5B090", Offset = "0x2C5A490", Length = "0x1CE")]
	[Token(Token = "0x6000DA7")]
	internal static Texture3D get_whiteVolumeTexture() { }

	[Address(RVA = "0x2C55E80", Offset = "0x2C55280", Length = "0x1CF")]
	[Token(Token = "0x6000DE7")]
	public static IEnumerable<Type> GetAllAssemblyTypes() { }

	[Address(RVA = "0x7B8810", Offset = "0x7B7C10", Length = "0x2A5")]
	[Token(Token = "0x6000DE8")]
	public static IEnumerable<Type> GetAllTypesDerivedFrom() { }

	[Address(RVA = "0x2C56050", Offset = "0x2C55450", Length = "0x2C")]
	[Token(Token = "0x6000DFC")]
	internal static string GetCorePath() { }

	[Address(RVA = "0x9DCBC0", Offset = "0x9DBFC0", Length = "0x6")]
	[Token(Token = "0x6000E00")]
	public static DepthBits GetDefaultDepthBufferBits() { }

	[Address(RVA = "0x2C56080", Offset = "0x2C55480", Length = "0x6")]
	[Token(Token = "0x6000DFF")]
	public static GraphicsFormat GetDefaultDepthOnlyFormat() { }

	[Address(RVA = "0x2C56090", Offset = "0x2C55490", Length = "0x6")]
	[Token(Token = "0x6000DFE")]
	public static GraphicsFormat GetDefaultDepthStencilFormat() { }

	[Address(RVA = "0x7B8BD0", Offset = "0x7B7FD0", Length = "0xD2")]
	[Token(Token = "0x6000DFB")]
	public static T GetLastEnumValue() { }

	[Address(RVA = "0x2C560A0", Offset = "0x2C554A0", Length = "0xA9")]
	[Token(Token = "0x6000DF8")]
	public static int GetMipCount(int size) { }

	[Address(RVA = "0x2C56150", Offset = "0x2C55550", Length = "0xA4")]
	[Token(Token = "0x6000DF9")]
	public static int GetMipCount(float size) { }

	[Address(RVA = "0x2C56660", Offset = "0x2C55A60", Length = "0xF1")]
	[Token(Token = "0x6000DCC")]
	public static string GetRenderTargetAutoName(int width, int height, int depth, RenderTextureFormat format, string name, bool mips = false, bool enableMSAA = false, MSAASamples msaaSamples = 1) { }

	[Address(RVA = "0x2C56560", Offset = "0x2C55960", Length = "0xF1")]
	[Token(Token = "0x6000DCD")]
	public static string GetRenderTargetAutoName(int width, int height, int depth, GraphicsFormat format, string name, bool mips = false, bool enableMSAA = false, MSAASamples msaaSamples = 1) { }

	[Address(RVA = "0x2C56200", Offset = "0x2C55600", Length = "0x247")]
	[Token(Token = "0x6000DCF")]
	private static string GetRenderTargetAutoName(int width, int height, int depth, string format, TextureDimension dim, string name, bool mips, bool enableMSAA, MSAASamples msaaSamples, bool dynamicRes, bool dynamicResExplicit) { }

	[Address(RVA = "0x2C56450", Offset = "0x2C55850", Length = "0x10A")]
	[Token(Token = "0x6000DCE")]
	public static string GetRenderTargetAutoName(int width, int height, int depth, GraphicsFormat format, TextureDimension dim, string name, bool mips = false, bool enableMSAA = false, MSAASamples msaaSamples = 1, bool dynamicRes = false, bool dynamicResExplicit = false) { }

	[Address(RVA = "0x2C56840", Offset = "0x2C55C40", Length = "0xD7")]
	[Token(Token = "0x6000DD0")]
	public static string GetTextureAutoName(int width, int height, TextureFormat format, TextureDimension dim = 0, string name = "", bool mips = false, int depth = 0) { }

	[Address(RVA = "0x2C56920", Offset = "0x2C55D20", Length = "0x4CE")]
	[Token(Token = "0x6000DD2")]
	private static string GetTextureAutoName(int width, int height, string format, TextureDimension dim = 0, string name = "", bool mips = false, int depth = 0) { }

	[Address(RVA = "0x2C56760", Offset = "0x2C55B60", Length = "0xD7")]
	[Token(Token = "0x6000DD1")]
	public static string GetTextureAutoName(int width, int height, GraphicsFormat format, TextureDimension dim = 0, string name = "", bool mips = false, int depth = 0) { }

	[Address(RVA = "0x2C56DF0", Offset = "0x2C561F0", Length = "0x18D")]
	[Token(Token = "0x6000DF6")]
	public static int GetTextureHash(Texture texture) { }

	[Address(RVA = "0x7B8CB0", Offset = "0x7B80B0", Length = "0x175")]
	[Token(Token = "0x6000DDE")]
	public static bool HasFlag(T mask, T flag) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000DEF")]
	public static bool IsLightOverlapDebugEnabled(Camera camera) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000DF1")]
	public static bool IsSceneFilteringEnabled() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000DEE")]
	public static bool IsSceneLightingDisabled(Camera camera) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000DF0")]
	public static bool IsSceneViewFogEnabled(Camera camera) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000DF2")]
	public static bool IsSceneViewPrefabStageContextHidden() { }

	[Address(RVA = "0x2C56F80", Offset = "0x2C56380", Length = "0x46E")]
	[Token(Token = "0x6000E01")]
	public static bool IsScreenFullyCoveredByCameras(List<Camera> cameras) { }

	[Address(RVA = "0x2C573F0", Offset = "0x2C567F0", Length = "0x30")]
	[Token(Token = "0x6000DF7")]
	public static int PreviousPowerOfTwo(int size) { }

	[Address(RVA = "0x2C57420", Offset = "0x2C56820", Length = "0xD")]
	[Token(Token = "0x6000DEA")]
	public static void SafeRelease(ComputeBuffer buffer) { }

	[Address(RVA = "0x2C57430", Offset = "0x2C56830", Length = "0xD")]
	[Token(Token = "0x6000DE9")]
	public static void SafeRelease(GraphicsBuffer buffer) { }

	[Address(RVA = "0x2C57440", Offset = "0x2C56840", Length = "0x7C")]
	[Token(Token = "0x6000DE1")]
	public static void SetKeyword(CommandBuffer cmd, ComputeShader cs, string keyword, bool state) { }

	[Address(RVA = "0x2C57560", Offset = "0x2C56960", Length = "0x2B")]
	[Token(Token = "0x6000DE5")]
	public static void SetKeyword(ComputeShader cs, string keyword, bool state) { }

	[Address(RVA = "0x2C574C0", Offset = "0x2C568C0", Length = "0x2D")]
	[Token(Token = "0x6000DE4")]
	public static void SetKeyword(Material material, LocalKeyword keyword, bool state) { }

	[Address(RVA = "0x2C574F0", Offset = "0x2C568F0", Length = "0x2B")]
	[Token(Token = "0x6000DE3")]
	public static void SetKeyword(Material material, string keyword, bool state) { }

	[Address(RVA = "0x2C57590", Offset = "0x2C56990", Length = "0x2B")]
	[Token(Token = "0x6000DE0")]
	public static void SetKeyword(CommandBuffer cmd, string keyword, bool state) { }

	[Address(RVA = "0x2C57520", Offset = "0x2C56920", Length = "0x39")]
	[Token(Token = "0x6000DE2")]
	public static void SetKeyword(BaseCommandBuffer cmd, string keyword, bool state) { }

	[Address(RVA = "0x2C58090", Offset = "0x2C57490", Length = "0x107")]
	[Token(Token = "0x6000DAB")]
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	[Address(RVA = "0x2C58310", Offset = "0x2C57710", Length = "0x12F")]
	[Token(Token = "0x6000DAC")]
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, ClearFlag clearFlag = 0, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	[Address(RVA = "0x2C59CD0", Offset = "0x2C590D0", Length = "0x123")]
	[Token(Token = "0x6000DAD")]
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	[Address(RVA = "0x2C57680", Offset = "0x2C56A80", Length = "0x1F2")]
	[Token(Token = "0x6000DB8")]
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	[Address(RVA = "0x2C58440", Offset = "0x2C57840", Length = "0xFF")]
	[Token(Token = "0x6000DBA")]
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor) { }

	[Address(RVA = "0x2C58A60", Offset = "0x2C57E60", Length = "0x163")]
	[Token(Token = "0x6000DBB")]
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag) { }

	[Address(RVA = "0x2C596F0", Offset = "0x2C58AF0", Length = "0x1DF")]
	[Token(Token = "0x6000DBD")]
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	[Address(RVA = "0x2C588E0", Offset = "0x2C57CE0", Length = "0xB9")]
	[Token(Token = "0x6000DBE")]
	public static void SetRenderTarget(ComputeCommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	[Address(RVA = "0x2C59EF0", Offset = "0x2C592F0", Length = "0xB2")]
	[Token(Token = "0x6000DBF")]
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag = 0, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	[Address(RVA = "0x2C589A0", Offset = "0x2C57DA0", Length = "0xB8")]
	[Token(Token = "0x6000DC0")]
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	[Address(RVA = "0x2C575C0", Offset = "0x2C569C0", Length = "0xBF")]
	[Token(Token = "0x6000DC1")]
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, ClearFlag clearFlag, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	[Address(RVA = "0x2C58BD0", Offset = "0x2C57FD0", Length = "0x2B6")]
	[Token(Token = "0x6000DC2")]
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	[Address(RVA = "0x2C57BF0", Offset = "0x2C56FF0", Length = "0x29B")]
	[Token(Token = "0x6000DC3")]
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	[Address(RVA = "0x2C58E90", Offset = "0x2C58290", Length = "0x384")]
	[Token(Token = "0x6000DC4")]
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RTHandle depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	[Address(RVA = "0x2C57A50", Offset = "0x2C56E50", Length = "0x192")]
	[Token(Token = "0x6000DC8")]
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer) { }

	[Address(RVA = "0x2C586A0", Offset = "0x2C57AA0", Length = "0x235")]
	[Token(Token = "0x6000DC9")]
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer, ClearFlag clearFlag = 0) { }

	[Address(RVA = "0x2C59470", Offset = "0x2C58870", Length = "0x27C")]
	[Token(Token = "0x6000DB9")]
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	[Address(RVA = "0x2C59E00", Offset = "0x2C59200", Length = "0xE3")]
	[Token(Token = "0x6000DB3")]
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor) { }

	[Address(RVA = "0x2C581A0", Offset = "0x2C575A0", Length = "0x16E")]
	[Token(Token = "0x6000DAE")]
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	[Address(RVA = "0x2C59B90", Offset = "0x2C58F90", Length = "0x139")]
	[Token(Token = "0x6000DB7")]
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor) { }

	[Address(RVA = "0x2C598D0", Offset = "0x2C58CD0", Length = "0x10D")]
	[Token(Token = "0x6000DB6")]
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag) { }

	[Address(RVA = "0x2C57880", Offset = "0x2C56C80", Length = "0x1C2")]
	[Token(Token = "0x6000DB5")]
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	[Address(RVA = "0x2C58540", Offset = "0x2C57940", Length = "0x159")]
	[Token(Token = "0x6000DB4")]
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	[Address(RVA = "0x2C599E0", Offset = "0x2C58DE0", Length = "0x1A6")]
	[Token(Token = "0x6000DCA")]
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer, ClearFlag clearFlag, Color clearColor) { }

	[Address(RVA = "0x2C59370", Offset = "0x2C58770", Length = "0xF4")]
	[Token(Token = "0x6000DB2")]
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, Color clearColor) { }

	[Address(RVA = "0x2C57E90", Offset = "0x2C57290", Length = "0x11E")]
	[Token(Token = "0x6000DB1")]
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag = 0) { }

	[Address(RVA = "0x2C57FB0", Offset = "0x2C573B0", Length = "0xDE")]
	[Token(Token = "0x6000DB0")]
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer) { }

	[Address(RVA = "0x2C59220", Offset = "0x2C58620", Length = "0x144")]
	[Token(Token = "0x6000DAF")]
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	[Address(RVA = "0x2C59FB0", Offset = "0x2C593B0", Length = "0x1A")]
	[Token(Token = "0x6000DC6")]
	public static void SetShadingRateCombiner(CommandBuffer cmd, ShadingRateCombinerStage stage, ShadingRateCombiner combiner) { }

	[Address(RVA = "0x2C59FD0", Offset = "0x2C593D0", Length = "0x1A")]
	[Token(Token = "0x6000DC5")]
	public static void SetShadingRateFragmentSize(CommandBuffer cmd, ShadingRateFragmentSize baseShadingRateFragmentSize) { }

	[Address(RVA = "0x2C59FF0", Offset = "0x2C593F0", Length = "0x1A")]
	[Token(Token = "0x6000DC7")]
	public static void SetShadingRateImage(CommandBuffer cmd, in RenderTargetIdentifier shadingRateImage) { }

	[Address(RVA = "0x2C5A130", Offset = "0x2C59530", Length = "0x99")]
	[Token(Token = "0x6000DCB")]
	public static void SetViewport(CommandBuffer cmd, RTHandle target) { }

	[Address(RVA = "0x2C5A010", Offset = "0x2C59410", Length = "0x11D")]
	[Token(Token = "0x6000DBC")]
	private static void SetViewportAndClear(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag, Color clearColor) { }

	[Address(RVA = "0x725DD0", Offset = "0x7251D0", Length = "0x194")]
	[Token(Token = "0x6000DDF")]
	public static void Swap(ref T a, ref T b) { }

}

