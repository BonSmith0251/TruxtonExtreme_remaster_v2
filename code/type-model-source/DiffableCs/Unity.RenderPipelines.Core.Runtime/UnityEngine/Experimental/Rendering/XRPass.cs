namespace UnityEngine.Experimental.Rendering;

[Token(Token = "0x2000012")]
public class XRPass
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000059")]
	private readonly List<XRView> m_Views; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400005A")]
	private readonly XROcclusionMesh m_OcclusionMesh; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400005B")]
	private readonly XRVisibleMesh m_VisibleMesh; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400005C")]
	private bool <copyDepth>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x400005D")]
	private bool <hasMotionVectorPass>k__BackingField; //Field offset: 0x29
	[CompilerGenerated]
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x400005E")]
	private bool <spaceWarpRightHandedNDC>k__BackingField; //Field offset: 0x2A
	[CompilerGenerated]
	[FieldOffset(Offset = "0x2B")]
	[Token(Token = "0x400005F")]
	private bool <isLastCameraPass>k__BackingField; //Field offset: 0x2B
	[CompilerGenerated]
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000060")]
	private int <multipassId>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000061")]
	private int <cullingPassId>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000062")]
	private int <renderTargetScaledWidth>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000063")]
	private int <renderTargetScaledHeight>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000064")]
	private RenderTargetIdentifier <renderTarget>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000065")]
	private RenderTextureDescriptor <renderTargetDesc>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000066")]
	private RenderTargetIdentifier <motionVectorRenderTarget>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000067")]
	private RenderTextureDescriptor <motionVectorRenderTargetDesc>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000068")]
	private ScriptableCullingParameters <cullingParams>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	[FieldOffset(Offset = "0x738")]
	[Token(Token = "0x4000069")]
	private IntPtr <foveatedRenderingInfo>k__BackingField; //Field offset: 0x738
	[CompilerGenerated]
	[FieldOffset(Offset = "0x740")]
	[Token(Token = "0x400006A")]
	private float <occlusionMeshScale>k__BackingField; //Field offset: 0x740

	[Token(Token = "0x1700000D")]
	public private bool copyDepth
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000048")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000049")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700001A")]
	public private ScriptableCullingParameters cullingParams
	{
		[Address(RVA = "0x2BCD5B0", Offset = "0x2BCC9B0", Length = "0x24")]
		[CompilerGenerated]
		[Token(Token = "0x6000061")]
		 get { } //Length: 36
		[Address(RVA = "0x2BCDE60", Offset = "0x2BCD260", Length = "0x1B")]
		[CompilerGenerated]
		[Token(Token = "0x6000062")]
		private set { } //Length: 27
	}

	[Token(Token = "0x17000013")]
	public private int cullingPassId
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000053")]
		 get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000054")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700000B")]
	public bool enabled
	{
		[Address(RVA = "0x2BCD5E0", Offset = "0x2BCC9E0", Length = "0x40")]
		[Token(Token = "0x6000046")]
		 get { } //Length: 64
	}

	[Token(Token = "0x1700001D")]
	public private IntPtr foveatedRenderingInfo
	{
		[Address(RVA = "0x2BCD630", Offset = "0x2BCCA30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000065")]
		 get { } //Length: 8
		[Address(RVA = "0x2BCDE80", Offset = "0x2BCD280", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000066")]
		private set { } //Length: 8
	}

	[Token(Token = "0x1700000E")]
	public private bool hasMotionVectorPass
	{
		[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600004A")]
		 get { } //Length: 5
		[Address(RVA = "0x2707C90", Offset = "0x2707090", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600004B")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000022")]
	public bool hasValidOcclusionMesh
	{
		[Address(RVA = "0x2BCD640", Offset = "0x2BCCA40", Length = "0xCD")]
		[Token(Token = "0x6000078")]
		 get { } //Length: 205
	}

	[Token(Token = "0x17000023")]
	public bool hasValidVisibleMesh
	{
		[Address(RVA = "0x2BCD710", Offset = "0x2BCCB10", Length = "0x15D")]
		[Token(Token = "0x6000079")]
		 get { } //Length: 349
	}

	[Token(Token = "0x1700001F")]
	public ColorGamut hdrDisplayOutputColorGamut
	{
		[Address(RVA = "0x2BCD870", Offset = "0x2BCCC70", Length = "0xA1")]
		[Token(Token = "0x6000068")]
		 get { } //Length: 161
	}

	[Token(Token = "0x17000020")]
	public HDRDisplayInformation hdrDisplayOutputInformation
	{
		[Address(RVA = "0x2BCD920", Offset = "0x2BCCD20", Length = "0x26F")]
		[Token(Token = "0x6000069")]
		 get { } //Length: 623
	}

	[Token(Token = "0x17000010")]
	public bool isFirstCameraPass
	{
		[Address(RVA = "0x26F85B0", Offset = "0x26F79B0", Length = "0x8")]
		[Token(Token = "0x600004E")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700001E")]
	public bool isHDRDisplayOutputActive
	{
		[Address(RVA = "0x2BCDB90", Offset = "0x2BCCF90", Length = "0xA1")]
		[Token(Token = "0x6000067")]
		 get { } //Length: 161
	}

	[Token(Token = "0x17000011")]
	public private bool isLastCameraPass
	{
		[Address(RVA = "0x1CC53B0", Offset = "0x1CC47B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600004F")]
		 get { } //Length: 5
		[Address(RVA = "0x2BCDE90", Offset = "0x2BCD290", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000050")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000018")]
	public private RenderTargetIdentifier motionVectorRenderTarget
	{
		[Address(RVA = "0x2BCDC70", Offset = "0x2BCD070", Length = "0x26")]
		[CompilerGenerated]
		[Token(Token = "0x600005D")]
		 get { } //Length: 38
		[Address(RVA = "0x2BCDED0", Offset = "0x2BCD2D0", Length = "0x23")]
		[CompilerGenerated]
		[Token(Token = "0x600005E")]
		private set { } //Length: 35
	}

	[Token(Token = "0x17000019")]
	public private RenderTextureDescriptor motionVectorRenderTargetDesc
	{
		[Address(RVA = "0x2BCDC40", Offset = "0x2BCD040", Length = "0x2D")]
		[CompilerGenerated]
		[Token(Token = "0x600005F")]
		 get { } //Length: 45
		[Address(RVA = "0x2BCDEA0", Offset = "0x2BCD2A0", Length = "0x2A")]
		[CompilerGenerated]
		[Token(Token = "0x6000060")]
		private set { } //Length: 42
	}

	[Token(Token = "0x17000012")]
	public private int multipassId
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000051")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000052")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000021")]
	public private float occlusionMeshScale
	{
		[Address(RVA = "0x2BCDCA0", Offset = "0x2BCD0A0", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x600006A")]
		 get { } //Length: 9
		[Address(RVA = "0x2BCDF00", Offset = "0x2BCD300", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x600006B")]
		private set { } //Length: 9
	}

	[Token(Token = "0x17000016")]
	public private RenderTargetIdentifier renderTarget
	{
		[Address(RVA = "0x2BCDCE0", Offset = "0x2BCD0E0", Length = "0x1D")]
		[CompilerGenerated]
		[Token(Token = "0x6000059")]
		 get { } //Length: 29
		[Address(RVA = "0x2BCDF40", Offset = "0x2BCD340", Length = "0x1A")]
		[CompilerGenerated]
		[Token(Token = "0x600005A")]
		private set { } //Length: 26
	}

	[Token(Token = "0x17000017")]
	public private RenderTextureDescriptor renderTargetDesc
	{
		[Address(RVA = "0x2BCDCB0", Offset = "0x2BCD0B0", Length = "0x27")]
		[CompilerGenerated]
		[Token(Token = "0x600005B")]
		 get { } //Length: 39
		[Address(RVA = "0x2BCDF10", Offset = "0x2BCD310", Length = "0x24")]
		[CompilerGenerated]
		[Token(Token = "0x600005C")]
		private set { } //Length: 36
	}

	[Token(Token = "0x17000015")]
	public private int renderTargetScaledHeight
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000057")]
		 get { } //Length: 4
		[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000058")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000014")]
	public private int renderTargetScaledWidth
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000055")]
		 get { } //Length: 4
		[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000056")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700001C")]
	public bool singlePassEnabled
	{
		[Address(RVA = "0x2BCDD00", Offset = "0x2BCD100", Length = "0x40")]
		[Token(Token = "0x6000064")]
		 get { } //Length: 64
	}

	[Token(Token = "0x1700000F")]
	public private bool spaceWarpRightHandedNDC
	{
		[Address(RVA = "0x1CC53A0", Offset = "0x1CC47A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600004C")]
		 get { } //Length: 5
		[Address(RVA = "0x2BCDF60", Offset = "0x2BCD360", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600004D")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700000C")]
	public bool supportsFoveatedRendering
	{
		[Address(RVA = "0x2BCDD50", Offset = "0x2BCD150", Length = "0xC8")]
		[Token(Token = "0x6000047")]
		 get { } //Length: 200
	}

	[Token(Token = "0x1700001B")]
	public int viewCount
	{
		[Address(RVA = "0x2BCDE20", Offset = "0x2BCD220", Length = "0x3C")]
		[Token(Token = "0x6000063")]
		 get { } //Length: 60
	}

	[Address(RVA = "0x2BCD4A0", Offset = "0x2BCC8A0", Length = "0x10B")]
	[Token(Token = "0x6000043")]
	public XRPass() { }

	[Address(RVA = "0x2BCBAD0", Offset = "0x2BCAED0", Length = "0x302")]
	[Token(Token = "0x6000084")]
	internal void AddView(XRView xrView) { }

	[Address(RVA = "0x2BCBDE0", Offset = "0x2BCB1E0", Length = "0x1A9")]
	[Token(Token = "0x600007F")]
	public Vector4 ApplyXRViewCenterOffset(Vector2 center) { }

	[Address(RVA = "0x2BCBF90", Offset = "0x2BCB390", Length = "0x8A")]
	[Token(Token = "0x6000081")]
	internal void AssignCullingParams(int cullingPassId, ScriptableCullingParameters cullingParams) { }

	[Address(RVA = "0x2BCC020", Offset = "0x2BCB420", Length = "0x15E")]
	[Token(Token = "0x6000080")]
	internal void AssignView(int viewId, XRView xrView) { }

	[Address(RVA = "0x2BCC180", Offset = "0x2BCB580", Length = "0x9D")]
	[Token(Token = "0x6000044")]
	public static XRPass CreateDefault(XRPassCreateInfo createInfo) { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000048")]
	public bool get_copyDepth() { }

	[Address(RVA = "0x2BCD5B0", Offset = "0x2BCC9B0", Length = "0x24")]
	[CompilerGenerated]
	[Token(Token = "0x6000061")]
	public ScriptableCullingParameters get_cullingParams() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000053")]
	public int get_cullingPassId() { }

	[Address(RVA = "0x2BCD5E0", Offset = "0x2BCC9E0", Length = "0x40")]
	[Token(Token = "0x6000046")]
	public bool get_enabled() { }

	[Address(RVA = "0x2BCD630", Offset = "0x2BCCA30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000065")]
	public IntPtr get_foveatedRenderingInfo() { }

	[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600004A")]
	public bool get_hasMotionVectorPass() { }

	[Address(RVA = "0x2BCD640", Offset = "0x2BCCA40", Length = "0xCD")]
	[Token(Token = "0x6000078")]
	public bool get_hasValidOcclusionMesh() { }

	[Address(RVA = "0x2BCD710", Offset = "0x2BCCB10", Length = "0x15D")]
	[Token(Token = "0x6000079")]
	public bool get_hasValidVisibleMesh() { }

	[Address(RVA = "0x2BCD870", Offset = "0x2BCCC70", Length = "0xA1")]
	[Token(Token = "0x6000068")]
	public ColorGamut get_hdrDisplayOutputColorGamut() { }

	[Address(RVA = "0x2BCD920", Offset = "0x2BCCD20", Length = "0x26F")]
	[Token(Token = "0x6000069")]
	public HDRDisplayInformation get_hdrDisplayOutputInformation() { }

	[Address(RVA = "0x26F85B0", Offset = "0x26F79B0", Length = "0x8")]
	[Token(Token = "0x600004E")]
	public bool get_isFirstCameraPass() { }

	[Address(RVA = "0x2BCDB90", Offset = "0x2BCCF90", Length = "0xA1")]
	[Token(Token = "0x6000067")]
	public bool get_isHDRDisplayOutputActive() { }

	[Address(RVA = "0x1CC53B0", Offset = "0x1CC47B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600004F")]
	public bool get_isLastCameraPass() { }

	[Address(RVA = "0x2BCDC70", Offset = "0x2BCD070", Length = "0x26")]
	[CompilerGenerated]
	[Token(Token = "0x600005D")]
	public RenderTargetIdentifier get_motionVectorRenderTarget() { }

	[Address(RVA = "0x2BCDC40", Offset = "0x2BCD040", Length = "0x2D")]
	[CompilerGenerated]
	[Token(Token = "0x600005F")]
	public RenderTextureDescriptor get_motionVectorRenderTargetDesc() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000051")]
	public int get_multipassId() { }

	[Address(RVA = "0x2BCDCA0", Offset = "0x2BCD0A0", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x600006A")]
	public float get_occlusionMeshScale() { }

	[Address(RVA = "0x2BCDCE0", Offset = "0x2BCD0E0", Length = "0x1D")]
	[CompilerGenerated]
	[Token(Token = "0x6000059")]
	public RenderTargetIdentifier get_renderTarget() { }

	[Address(RVA = "0x2BCDCB0", Offset = "0x2BCD0B0", Length = "0x27")]
	[CompilerGenerated]
	[Token(Token = "0x600005B")]
	public RenderTextureDescriptor get_renderTargetDesc() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000057")]
	public int get_renderTargetScaledHeight() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000055")]
	public int get_renderTargetScaledWidth() { }

	[Address(RVA = "0x2BCDD00", Offset = "0x2BCD100", Length = "0x40")]
	[Token(Token = "0x6000064")]
	public bool get_singlePassEnabled() { }

	[Address(RVA = "0x1CC53A0", Offset = "0x1CC47A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600004C")]
	public bool get_spaceWarpRightHandedNDC() { }

	[Address(RVA = "0x2BCDD50", Offset = "0x2BCD150", Length = "0xC8")]
	[Token(Token = "0x6000047")]
	public bool get_supportsFoveatedRendering() { }

	[Address(RVA = "0x2BCDE20", Offset = "0x2BCD220", Length = "0x3C")]
	[Token(Token = "0x6000063")]
	public int get_viewCount() { }

	[Address(RVA = "0x2BCC220", Offset = "0x2BCB620", Length = "0x69")]
	[Token(Token = "0x6000071")]
	public Mesh GetOcclusionMesh(int viewIndex = 0) { }

	[Address(RVA = "0x2BCC290", Offset = "0x2BCB690", Length = "0xA0")]
	[Token(Token = "0x600006F")]
	public Matrix4x4 GetPrevViewMatrix(int viewIndex = 0) { }

	[Address(RVA = "0x2BCC340", Offset = "0x2BCB740", Length = "0x69")]
	[Token(Token = "0x600006E")]
	public bool GetPrevViewValid(int viewIndex = 0) { }

	[Address(RVA = "0x2BCC3B0", Offset = "0x2BCB7B0", Length = "0x94")]
	[Token(Token = "0x600006C")]
	public Matrix4x4 GetProjMatrix(int viewIndex = 0) { }

	[Address(RVA = "0x2BCC450", Offset = "0x2BCB850", Length = "0x68")]
	[Token(Token = "0x6000073")]
	public int GetTextureArraySlice(int viewIndex = 0) { }

	[Address(RVA = "0x2BCC4C0", Offset = "0x2BCB8C0", Length = "0x9A")]
	[Token(Token = "0x600006D")]
	public Matrix4x4 GetViewMatrix(int viewIndex = 0) { }

	[Address(RVA = "0x2BCC560", Offset = "0x2BCB960", Length = "0x7C")]
	[Token(Token = "0x6000070")]
	public Rect GetViewport(int viewIndex = 0) { }

	[Address(RVA = "0x2BCC5E0", Offset = "0x2BCB9E0", Length = "0x69")]
	[Token(Token = "0x6000072")]
	public Mesh GetVisibleMesh(int viewIndex = 0) { }

	[Address(RVA = "0x2BCC650", Offset = "0x2BCBA50", Length = "0x413")]
	[Token(Token = "0x6000083")]
	public void InitBase(XRPassCreateInfo createInfo) { }

	[Address(RVA = "0x2BCCA70", Offset = "0x2BCBE70", Length = "0x104")]
	[Token(Token = "0x6000045")]
	public override void Release() { }

	[Address(RVA = "0x2BCCB80", Offset = "0x2BCBF80", Length = "0x3C9")]
	[Token(Token = "0x600007E")]
	public void RenderDebugXRViewsFrustum() { }

	[Address(RVA = "0x2BCCF50", Offset = "0x2BCC350", Length = "0x45")]
	[Token(Token = "0x600007B")]
	public void RenderOcclusionMesh(RasterCommandBuffer cmd, bool renderIntoTexture = false) { }

	[Address(RVA = "0x2BCCFA0", Offset = "0x2BCC3A0", Length = "0x3C")]
	[Token(Token = "0x600007A")]
	public void RenderOcclusionMesh(CommandBuffer cmd, bool renderIntoTexture = false) { }

	[Address(RVA = "0x2BCCFE0", Offset = "0x2BCC3E0", Length = "0x43")]
	[Token(Token = "0x600007D")]
	public void RenderVisibleMeshCustomMaterial(CommandBuffer cmd, float occlusionMeshScale, Material material, MaterialPropertyBlock materialBlock, int shaderPass = 0, bool renderIntoTexture = false) { }

	[Address(RVA = "0x2BCD030", Offset = "0x2BCC430", Length = "0x4C")]
	[Token(Token = "0x600007C")]
	public void RenderVisibleMeshCustomMaterial(RasterCommandBuffer cmd, float occlusionMeshScale, Material material, MaterialPropertyBlock materialBlock, int shaderPass, bool renderIntoTexture = false) { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000049")]
	private void set_copyDepth(bool value) { }

	[Address(RVA = "0x2BCDE60", Offset = "0x2BCD260", Length = "0x1B")]
	[CompilerGenerated]
	[Token(Token = "0x6000062")]
	private void set_cullingParams(ScriptableCullingParameters value) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000054")]
	private void set_cullingPassId(int value) { }

	[Address(RVA = "0x2BCDE80", Offset = "0x2BCD280", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000066")]
	private void set_foveatedRenderingInfo(IntPtr value) { }

	[Address(RVA = "0x2707C90", Offset = "0x2707090", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600004B")]
	private void set_hasMotionVectorPass(bool value) { }

	[Address(RVA = "0x2BCDE90", Offset = "0x2BCD290", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000050")]
	private void set_isLastCameraPass(bool value) { }

	[Address(RVA = "0x2BCDED0", Offset = "0x2BCD2D0", Length = "0x23")]
	[CompilerGenerated]
	[Token(Token = "0x600005E")]
	private void set_motionVectorRenderTarget(RenderTargetIdentifier value) { }

	[Address(RVA = "0x2BCDEA0", Offset = "0x2BCD2A0", Length = "0x2A")]
	[CompilerGenerated]
	[Token(Token = "0x6000060")]
	private void set_motionVectorRenderTargetDesc(RenderTextureDescriptor value) { }

	[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000052")]
	private void set_multipassId(int value) { }

	[Address(RVA = "0x2BCDF00", Offset = "0x2BCD300", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x600006B")]
	private void set_occlusionMeshScale(float value) { }

	[Address(RVA = "0x2BCDF40", Offset = "0x2BCD340", Length = "0x1A")]
	[CompilerGenerated]
	[Token(Token = "0x600005A")]
	private void set_renderTarget(RenderTargetIdentifier value) { }

	[Address(RVA = "0x2BCDF10", Offset = "0x2BCD310", Length = "0x24")]
	[CompilerGenerated]
	[Token(Token = "0x600005C")]
	private void set_renderTargetDesc(RenderTextureDescriptor value) { }

	[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000058")]
	private void set_renderTargetScaledHeight(int value) { }

	[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000056")]
	private void set_renderTargetScaledWidth(int value) { }

	[Address(RVA = "0x2BCDF60", Offset = "0x2BCD360", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600004D")]
	private void set_spaceWarpRightHandedNDC(bool value) { }

	[Address(RVA = "0x2BCD080", Offset = "0x2BCC480", Length = "0x97")]
	[Token(Token = "0x6000075")]
	public void StartSinglePass(IRasterCommandBuffer cmd) { }

	[Address(RVA = "0x2BCD120", Offset = "0x2BCC520", Length = "0x224")]
	[Token(Token = "0x6000074")]
	public void StartSinglePass(CommandBuffer cmd) { }

	[Address(RVA = "0x2BCD350", Offset = "0x2BCC750", Length = "0x1E")]
	[Token(Token = "0x6000077")]
	public void StopSinglePass(BaseCommandBuffer cmd) { }

	[Address(RVA = "0x2BCD370", Offset = "0x2BCC770", Length = "0xEE")]
	[Token(Token = "0x6000076")]
	public void StopSinglePass(CommandBuffer cmd) { }

	[Address(RVA = "0x2BCD460", Offset = "0x2BCC860", Length = "0x33")]
	[Token(Token = "0x6000082")]
	internal void UpdateCombinedOcclusionMesh() { }

}

