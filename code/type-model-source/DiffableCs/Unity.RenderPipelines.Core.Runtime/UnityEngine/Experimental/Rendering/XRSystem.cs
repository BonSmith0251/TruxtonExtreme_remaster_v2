namespace UnityEngine.Experimental.Rendering;

[Token(Token = "0x2000014")]
public static class XRSystem
{
	[CompilerGenerated]
	[Token(Token = "0x2000015")]
	private struct <>c__DisplayClass50_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007B")]
		public Camera camera; //Field offset: 0x0

	}

	[Token(Token = "0x400006D")]
	private static XRLayoutStack s_Layout; //Field offset: 0x0
	[Token(Token = "0x400006E")]
	private static Func<XRPassCreateInfo, XRPass> s_PassAllocator; //Field offset: 0x8
	[Token(Token = "0x400006F")]
	private static List<XRDisplaySubsystem> s_DisplayList; //Field offset: 0x10
	[Token(Token = "0x4000070")]
	private static XRDisplaySubsystem s_Display; //Field offset: 0x18
	[Token(Token = "0x4000071")]
	private static MSAASamples s_MSAASamples; //Field offset: 0x20
	[Token(Token = "0x4000072")]
	private static float s_OcclusionMeshScaling; //Field offset: 0x24
	[Token(Token = "0x4000073")]
	private static bool s_UseVisibilityMesh; //Field offset: 0x28
	[Token(Token = "0x4000074")]
	private static Material s_OcclusionMeshMaterial; //Field offset: 0x30
	[Token(Token = "0x4000075")]
	private static Material s_MirrorViewMaterial; //Field offset: 0x38
	[Token(Token = "0x4000076")]
	private static Action<XRLayout, Camera> s_LayoutOverride; //Field offset: 0x40
	[Token(Token = "0x4000077")]
	public static readonly XRPass emptyPass; //Field offset: 0x48
	[CompilerGenerated]
	[Token(Token = "0x4000078")]
	private static bool <singlePassAllowed>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[Token(Token = "0x4000079")]
	private static FoveatedRenderingCaps <foveatedRenderingCaps>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	[Token(Token = "0x400007A")]
	private static bool <dumpDebugInfo>k__BackingField; //Field offset: 0x58

	[Token(Token = "0x17000024")]
	public static bool displayActive
	{
		[Address(RVA = "0x2BD2540", Offset = "0x2BD1940", Length = "0x86")]
		[Token(Token = "0x6000086")]
		 get { } //Length: 134
	}

	[Token(Token = "0x17000028")]
	public static bool dumpDebugInfo
	{
		[Address(RVA = "0x2BD25D0", Offset = "0x2BD19D0", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x600008C")]
		 get { } //Length: 79
		[Address(RVA = "0x2BD2780", Offset = "0x2BD1B80", Length = "0x54")]
		[CompilerGenerated]
		[Token(Token = "0x600008D")]
		 set { } //Length: 84
	}

	[Token(Token = "0x17000027")]
	public static FoveatedRenderingCaps foveatedRenderingCaps
	{
		[Address(RVA = "0x2BD2620", Offset = "0x2BD1A20", Length = "0x4E")]
		[CompilerGenerated]
		[Token(Token = "0x600008A")]
		 get { } //Length: 78
		[Address(RVA = "0x2BD27E0", Offset = "0x2BD1BE0", Length = "0x53")]
		[CompilerGenerated]
		[Token(Token = "0x600008B")]
		 set { } //Length: 83
	}

	[Token(Token = "0x17000025")]
	public static bool isHDRDisplayOutputActive
	{
		[Address(RVA = "0x2BD2670", Offset = "0x2BD1A70", Length = "0xB7")]
		[Token(Token = "0x6000087")]
		 get { } //Length: 183
	}

	[Token(Token = "0x17000026")]
	public static bool singlePassAllowed
	{
		[Address(RVA = "0x2BD2730", Offset = "0x2BD1B30", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x6000088")]
		 get { } //Length: 79
		[Address(RVA = "0x2BD2840", Offset = "0x2BD1C40", Length = "0x54")]
		[CompilerGenerated]
		[Token(Token = "0x6000089")]
		 set { } //Length: 84
	}

	[Address(RVA = "0x2BD2210", Offset = "0x2BD1610", Length = "0x327")]
	[Token(Token = "0x60000AA")]
	private static XRSystem() { }

	[Address(RVA = "0x2BD1D00", Offset = "0x2BD1100", Length = "0x39A")]
	[CompilerGenerated]
	[Token(Token = "0x60000AB")]
	internal static void <CreateDefaultLayout>g__AddViewToPass|50_0(XRPass xrPass, XRRenderPass renderPass, int renderParamIndex, ref <>c__DisplayClass50_0 unnamed_param_3) { }

	[Address(RVA = "0x2BCDF70", Offset = "0x2BCD370", Length = "0x9D9")]
	[Token(Token = "0x60000A9")]
	private static XRPassCreateInfo BuildPass(XRRenderPass xrRenderPass, ScriptableCullingParameters cullingParameters, XRLayout layout, bool isLastPass) { }

	[Address(RVA = "0x2BCE950", Offset = "0x2BCDD50", Length = "0x89B")]
	[Token(Token = "0x60000A7")]
	private static XRView BuildView(XRRenderPass renderPass, XRRenderParameter renderParameter) { }

	[Address(RVA = "0x2BCF1F0", Offset = "0x2BCE5F0", Length = "0x222")]
	[Token(Token = "0x60000A6")]
	private static bool CanUseSinglePass(Camera camera, XRRenderPass renderPass) { }

	[Address(RVA = "0x2BCF420", Offset = "0x2BCE820", Length = "0xB69")]
	[Token(Token = "0x60000A4")]
	internal static void CreateDefaultLayout(Camera camera, XRLayout layout) { }

	[Address(RVA = "0x2BCFF90", Offset = "0x2BCF390", Length = "0x1D5")]
	[Token(Token = "0x600009F")]
	public static void Dispose() { }

	[Address(RVA = "0x2BD0170", Offset = "0x2BCF570", Length = "0x12A")]
	[Token(Token = "0x600009D")]
	public static void EndLayout() { }

	[Address(RVA = "0x2BD2540", Offset = "0x2BD1940", Length = "0x86")]
	[Token(Token = "0x6000086")]
	public static bool get_displayActive() { }

	[Address(RVA = "0x2BD25D0", Offset = "0x2BD19D0", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x600008C")]
	public static bool get_dumpDebugInfo() { }

	[Address(RVA = "0x2BD2620", Offset = "0x2BD1A20", Length = "0x4E")]
	[CompilerGenerated]
	[Token(Token = "0x600008A")]
	public static FoveatedRenderingCaps get_foveatedRenderingCaps() { }

	[Address(RVA = "0x2BD2670", Offset = "0x2BD1A70", Length = "0xB7")]
	[Token(Token = "0x6000087")]
	public static bool get_isHDRDisplayOutputActive() { }

	[Address(RVA = "0x2BD2730", Offset = "0x2BD1B30", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x6000088")]
	public static bool get_singlePassAllowed() { }

	[Address(RVA = "0x2BD02A0", Offset = "0x2BCF6A0", Length = "0x4F")]
	[Token(Token = "0x6000085")]
	public static XRDisplaySubsystem GetActiveDisplay() { }

	[Address(RVA = "0x2BD02F0", Offset = "0x2BCF6F0", Length = "0x4E")]
	[Token(Token = "0x6000090")]
	public static MSAASamples GetDisplayMSAASamples() { }

	[Address(RVA = "0x2BD0340", Offset = "0x2BCF740", Length = "0x5F")]
	[Token(Token = "0x6000099")]
	public static float GetDynamicResolutionScale() { }

	[Address(RVA = "0x2BD03A0", Offset = "0x2BCF7A0", Length = "0x89")]
	[Token(Token = "0x6000096")]
	internal static int GetMirrorViewMode() { }

	[Address(RVA = "0x2BD0430", Offset = "0x2BCF830", Length = "0x50")]
	[Token(Token = "0x6000092")]
	internal static float GetOcclusionMeshScale() { }

	[Address(RVA = "0x2BD0480", Offset = "0x2BCF880", Length = "0x5F")]
	[Token(Token = "0x6000098")]
	public static float GetRenderViewportScale() { }

	[Address(RVA = "0x2BD04E0", Offset = "0x2BCF8E0", Length = "0x4F")]
	[Token(Token = "0x6000094")]
	internal static bool GetUseVisibilityMesh() { }

	[Address(RVA = "0x2BD0530", Offset = "0x2BCF930", Length = "0x477")]
	[Token(Token = "0x600008E")]
	public static void Initialize(Func<XRPassCreateInfo, XRPass> passAllocator, Shader occlusionMeshPS, Shader mirrorViewPS) { }

	[Address(RVA = "0x2BD09B0", Offset = "0x2BCFDB0", Length = "0xF0")]
	[Token(Token = "0x600009C")]
	public static XRLayout NewLayout() { }

	[Address(RVA = "0x2BD0AB0", Offset = "0x2BCFEB0", Length = "0x72A")]
	[Token(Token = "0x60000A5")]
	internal static void ReconfigurePass(XRPass xrPass, Camera camera) { }

	[Address(RVA = "0x2BD11E0", Offset = "0x2BD05E0", Length = "0x345")]
	[Token(Token = "0x60000A3")]
	private static void RefreshDeviceInfo() { }

	[Address(RVA = "0x2BD1530", Offset = "0x2BD0930", Length = "0xB1")]
	[Token(Token = "0x600009E")]
	public static void RenderMirrorView(CommandBuffer cmd, Camera camera) { }

	[Address(RVA = "0x2BD15F0", Offset = "0x2BD09F0", Length = "0x69")]
	[Token(Token = "0x600009B")]
	public static int ScaleTextureHeightForXR(RenderTexture texture) { }

	[Address(RVA = "0x2BD1660", Offset = "0x2BD0A60", Length = "0x69")]
	[Token(Token = "0x600009A")]
	public static int ScaleTextureWidthForXR(RenderTexture texture) { }

	[Address(RVA = "0x2BD2780", Offset = "0x2BD1B80", Length = "0x54")]
	[CompilerGenerated]
	[Token(Token = "0x600008D")]
	public static void set_dumpDebugInfo(bool value) { }

	[Address(RVA = "0x2BD27E0", Offset = "0x2BD1BE0", Length = "0x53")]
	[CompilerGenerated]
	[Token(Token = "0x600008B")]
	public static void set_foveatedRenderingCaps(FoveatedRenderingCaps value) { }

	[Address(RVA = "0x2BD2840", Offset = "0x2BD1C40", Length = "0x54")]
	[CompilerGenerated]
	[Token(Token = "0x6000089")]
	public static void set_singlePassAllowed(bool value) { }

	[Address(RVA = "0x2BD16D0", Offset = "0x2BD0AD0", Length = "0x1F1")]
	[Token(Token = "0x600008F")]
	public static void SetDisplayMSAASamples(MSAASamples msaaSamples) { }

	[Address(RVA = "0x2BD18D0", Offset = "0x2BD0CD0", Length = "0xC0")]
	[Token(Token = "0x60000A0")]
	internal static void SetDisplayZRange(float zNear, float zFar) { }

	[Address(RVA = "0x2BD19A0", Offset = "0x2BD0DA0", Length = "0x6E")]
	[Token(Token = "0x60000A1")]
	private static void SetLayoutOverride(Action<XRLayout, Camera> action) { }

	[Address(RVA = "0x2BD1A10", Offset = "0x2BD0E10", Length = "0x8D")]
	[Token(Token = "0x6000095")]
	internal static void SetMirrorViewMode(int mirrorBlitMode) { }

	[Address(RVA = "0x2BD1AA0", Offset = "0x2BD0EA0", Length = "0x5D")]
	[Token(Token = "0x6000091")]
	internal static void SetOcclusionMeshScale(float occlusionMeshScale) { }

	[Address(RVA = "0x2BD1B00", Offset = "0x2BD0F00", Length = "0x198")]
	[Token(Token = "0x6000097")]
	public static void SetRenderScale(float renderScale) { }

	[Address(RVA = "0x2BD1CA0", Offset = "0x2BD10A0", Length = "0x54")]
	[Token(Token = "0x6000093")]
	internal static void SetUseVisibilityMesh(bool useVisibilityMesh) { }

	[Address(RVA = "0x2BD2150", Offset = "0x2BD1550", Length = "0xB1")]
	[Token(Token = "0x60000A8")]
	private static RenderTextureDescriptor XrRenderTextureDescToUnityRenderTextureDesc(RenderTextureDescriptor xrDesc) { }

	[Address(RVA = "0x2BD20A0", Offset = "0x2BD14A0", Length = "0xA6")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSplashScreen (3))]
	[Token(Token = "0x60000A2")]
	private static void XRSystemInit() { }

}

