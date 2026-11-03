namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000BD")]
public class UniversalCameraData : ContextItem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003E4")]
	private Matrix4x4 m_ViewMatrix; //Field offset: 0x10
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40003E5")]
	private Matrix4x4 m_ProjectionMatrix; //Field offset: 0x50
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40003E6")]
	private Matrix4x4 m_JitterMatrix; //Field offset: 0x90
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40003E7")]
	private bool m_CachedRenderIntoTextureXR; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD1")]
	[Token(Token = "0x40003E8")]
	private bool m_InitBuiltinXRConstants; //Field offset: 0xD1
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40003E9")]
	public Camera camera; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40003EA")]
	public int scaledWidth; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x40003EB")]
	public int scaledHeight; //Field offset: 0xE4
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40003EC")]
	internal UniversalCameraHistory m_HistoryManager; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40003ED")]
	public CameraRenderType renderType; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40003EE")]
	public RenderTexture targetTexture; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40003EF")]
	public RenderTextureDescriptor cameraTargetDescriptor; //Field offset: 0x100
	[FieldOffset(Offset = "0x134")]
	[Token(Token = "0x40003F0")]
	internal Rect pixelRect; //Field offset: 0x134
	[FieldOffset(Offset = "0x144")]
	[Token(Token = "0x40003F1")]
	internal bool useScreenCoordOverride; //Field offset: 0x144
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x40003F2")]
	internal Vector4 screenSizeOverride; //Field offset: 0x148
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x40003F3")]
	internal Vector4 screenCoordScaleBias; //Field offset: 0x158
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x40003F4")]
	internal int pixelWidth; //Field offset: 0x168
	[FieldOffset(Offset = "0x16C")]
	[Token(Token = "0x40003F5")]
	internal int pixelHeight; //Field offset: 0x16C
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x40003F6")]
	internal float aspectRatio; //Field offset: 0x170
	[FieldOffset(Offset = "0x174")]
	[Token(Token = "0x40003F7")]
	public float renderScale; //Field offset: 0x174
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x40003F8")]
	internal ImageScalingMode imageScalingMode; //Field offset: 0x178
	[FieldOffset(Offset = "0x17C")]
	[Token(Token = "0x40003F9")]
	internal ImageUpscalingFilter upscalingFilter; //Field offset: 0x17C
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x40003FA")]
	internal bool fsrOverrideSharpness; //Field offset: 0x180
	[FieldOffset(Offset = "0x184")]
	[Token(Token = "0x40003FB")]
	internal float fsrSharpness; //Field offset: 0x184
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x40003FC")]
	internal HDRColorBufferPrecision hdrColorBufferPrecision; //Field offset: 0x188
	[FieldOffset(Offset = "0x18C")]
	[Token(Token = "0x40003FD")]
	public bool clearDepth; //Field offset: 0x18C
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x40003FE")]
	public CameraType cameraType; //Field offset: 0x190
	[FieldOffset(Offset = "0x194")]
	[Token(Token = "0x40003FF")]
	public bool isDefaultViewport; //Field offset: 0x194
	[FieldOffset(Offset = "0x195")]
	[Token(Token = "0x4000400")]
	public bool isHdrEnabled; //Field offset: 0x195
	[FieldOffset(Offset = "0x196")]
	[Token(Token = "0x4000401")]
	public bool allowHDROutput; //Field offset: 0x196
	[FieldOffset(Offset = "0x197")]
	[Token(Token = "0x4000402")]
	public bool isAlphaOutputEnabled; //Field offset: 0x197
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000403")]
	public bool requiresDepthTexture; //Field offset: 0x198
	[FieldOffset(Offset = "0x199")]
	[Token(Token = "0x4000404")]
	public bool requiresOpaqueTexture; //Field offset: 0x199
	[FieldOffset(Offset = "0x19A")]
	[Token(Token = "0x4000405")]
	public bool postProcessingRequiresDepthTexture; //Field offset: 0x19A
	[FieldOffset(Offset = "0x19B")]
	[Token(Token = "0x4000406")]
	public bool xrRendering; //Field offset: 0x19B
	[FieldOffset(Offset = "0x19C")]
	[Token(Token = "0x4000407")]
	internal bool useGPUOcclusionCulling; //Field offset: 0x19C
	[FieldOffset(Offset = "0x19D")]
	[Token(Token = "0x4000408")]
	internal bool stackLastCameraOutputToHDR; //Field offset: 0x19D
	[FieldOffset(Offset = "0x19E")]
	[Token(Token = "0x4000409")]
	internal bool rendersOffscreenUI; //Field offset: 0x19E
	[FieldOffset(Offset = "0x19F")]
	[Token(Token = "0x400040A")]
	internal bool blitsOffscreenUICover; //Field offset: 0x19F
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x400040B")]
	public SortingCriteria defaultOpaqueSortFlags; //Field offset: 0x1A0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x400040C")]
	private XRPass <xr>k__BackingField; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x400040D")]
	public float maxShadowDistance; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B4")]
	[Token(Token = "0x400040E")]
	public bool postProcessEnabled; //Field offset: 0x1B4
	[FieldOffset(Offset = "0x1B5")]
	[Token(Token = "0x400040F")]
	internal bool stackAnyPostProcessingEnabled; //Field offset: 0x1B5
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000410")]
	public IEnumerator<Action`2<RenderTargetIdentifier, CommandBuffer>> captureActions; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000411")]
	public LayerMask volumeLayerMask; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000412")]
	public Transform volumeTrigger; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000413")]
	public bool isStopNaNEnabled; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D1")]
	[Token(Token = "0x4000414")]
	public bool isDitheringEnabled; //Field offset: 0x1D1
	[FieldOffset(Offset = "0x1D4")]
	[Token(Token = "0x4000415")]
	public AntialiasingMode antialiasing; //Field offset: 0x1D4
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4000416")]
	public AntialiasingQuality antialiasingQuality; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000417")]
	public ScriptableRenderer renderer; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000418")]
	public bool resolveFinalTarget; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1EC")]
	[Token(Token = "0x4000419")]
	public Vector3 worldSpaceCameraPos; //Field offset: 0x1EC
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x400041A")]
	public Color backgroundColor; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x400041B")]
	internal TaaHistory taaHistory; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x400041C")]
	internal StpHistory stpHistory; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x400041D")]
	internal Settings taaSettings; //Field offset: 0x218
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x400041E")]
	public Camera baseCamera; //Field offset: 0x238
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x400041F")]
	internal bool isLastBaseCamera; //Field offset: 0x240

	[Token(Token = "0x17000126")]
	public ColorGamut hdrDisplayColorGamut
	{
		[Address(RVA = "0x2D94930", Offset = "0x2D93D30", Length = "0x89")]
		[Token(Token = "0x6000489")]
		 get { } //Length: 137
	}

	[Token(Token = "0x17000125")]
	public HDRDisplayInformation hdrDisplayInformation
	{
		[Address(RVA = "0x2D949C0", Offset = "0x2D93DC0", Length = "0x12B")]
		[Token(Token = "0x6000488")]
		 get { } //Length: 299
	}

	[Token(Token = "0x1700011D")]
	public UniversalCameraHistory historyManager
	{
		[Address(RVA = "0x1CF29E0", Offset = "0x1CF1DE0", Length = "0x8")]
		[Token(Token = "0x600047F")]
		 get { } //Length: 8
		[Address(RVA = "0x20D5300", Offset = "0x20D4700", Length = "0x13")]
		[Token(Token = "0x6000480")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700011F")]
	public bool isGameCamera
	{
		[Address(RVA = "0x2D94AF0", Offset = "0x2D93EF0", Length = "0xB")]
		[Token(Token = "0x6000482")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000124")]
	public bool isHDROutputActive
	{
		[Address(RVA = "0x2D94B00", Offset = "0x2D93F00", Length = "0xA9")]
		[Token(Token = "0x6000487")]
		 get { } //Length: 169
	}

	[Token(Token = "0x17000121")]
	public bool isPreviewCamera
	{
		[Address(RVA = "0x2D94BB0", Offset = "0x2D93FB0", Length = "0xB")]
		[Token(Token = "0x6000484")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000122")]
	internal bool isRenderPassSupportedCamera
	{
		[Address(RVA = "0x2D94BC0", Offset = "0x2D93FC0", Length = "0x17")]
		[Token(Token = "0x6000485")]
		internal get { } //Length: 23
	}

	[Token(Token = "0x17000120")]
	public bool isSceneViewCamera
	{
		[Address(RVA = "0x2D94BE0", Offset = "0x2D93FE0", Length = "0xB")]
		[Token(Token = "0x6000483")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000127")]
	public bool rendersOverlayUI
	{
		[Address(RVA = "0x2D94BF0", Offset = "0x2D93FF0", Length = "0x68")]
		[Token(Token = "0x600048A")]
		 get { } //Length: 104
	}

	[Token(Token = "0x1700011E")]
	internal bool requireSrgbConversion
	{
		[Address(RVA = "0x2D94C60", Offset = "0x2D94060", Length = "0x1C4")]
		[Token(Token = "0x6000481")]
		internal get { } //Length: 452
	}

	[Token(Token = "0x1700012A")]
	internal bool resetHistory
	{
		[Address(RVA = "0x2D94E30", Offset = "0x2D94230", Length = "0xB")]
		[Token(Token = "0x6000494")]
		internal get { } //Length: 11
	}

	[Token(Token = "0x17000123")]
	internal bool resolveToScreen
	{
		[Address(RVA = "0x2D94E40", Offset = "0x2D94240", Length = "0xAB")]
		[Token(Token = "0x6000486")]
		internal get { } //Length: 171
	}

	[Token(Token = "0x17000128")]
	public internal XRPass xr
	{
		[Address(RVA = "0x291FDB0", Offset = "0x291F1B0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000491")]
		 get { } //Length: 8
		[Address(RVA = "0x291FDD0", Offset = "0x291F1D0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000492")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000129")]
	internal XRPassUniversal xrUniversal
	{
		[Address(RVA = "0x2D94EF0", Offset = "0x2D942F0", Length = "0x75")]
		[Token(Token = "0x6000493")]
		internal get { } //Length: 117
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000496")]
	public UniversalCameraData() { }

	[Address(RVA = "0x2D94930", Offset = "0x2D93D30", Length = "0x89")]
	[Token(Token = "0x6000489")]
	public ColorGamut get_hdrDisplayColorGamut() { }

	[Address(RVA = "0x2D949C0", Offset = "0x2D93DC0", Length = "0x12B")]
	[Token(Token = "0x6000488")]
	public HDRDisplayInformation get_hdrDisplayInformation() { }

	[Address(RVA = "0x1CF29E0", Offset = "0x1CF1DE0", Length = "0x8")]
	[Token(Token = "0x600047F")]
	public UniversalCameraHistory get_historyManager() { }

	[Address(RVA = "0x2D94AF0", Offset = "0x2D93EF0", Length = "0xB")]
	[Token(Token = "0x6000482")]
	public bool get_isGameCamera() { }

	[Address(RVA = "0x2D94B00", Offset = "0x2D93F00", Length = "0xA9")]
	[Token(Token = "0x6000487")]
	public bool get_isHDROutputActive() { }

	[Address(RVA = "0x2D94BB0", Offset = "0x2D93FB0", Length = "0xB")]
	[Token(Token = "0x6000484")]
	public bool get_isPreviewCamera() { }

	[Address(RVA = "0x2D94BC0", Offset = "0x2D93FC0", Length = "0x17")]
	[Token(Token = "0x6000485")]
	internal bool get_isRenderPassSupportedCamera() { }

	[Address(RVA = "0x2D94BE0", Offset = "0x2D93FE0", Length = "0xB")]
	[Token(Token = "0x6000483")]
	public bool get_isSceneViewCamera() { }

	[Address(RVA = "0x2D94BF0", Offset = "0x2D93FF0", Length = "0x68")]
	[Token(Token = "0x600048A")]
	public bool get_rendersOverlayUI() { }

	[Address(RVA = "0x2D94C60", Offset = "0x2D94060", Length = "0x1C4")]
	[Token(Token = "0x6000481")]
	internal bool get_requireSrgbConversion() { }

	[Address(RVA = "0x2D94E30", Offset = "0x2D94230", Length = "0xB")]
	[Token(Token = "0x6000494")]
	internal bool get_resetHistory() { }

	[Address(RVA = "0x2D94E40", Offset = "0x2D94240", Length = "0xAB")]
	[Token(Token = "0x6000486")]
	internal bool get_resolveToScreen() { }

	[Address(RVA = "0x291FDB0", Offset = "0x291F1B0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000491")]
	public XRPass get_xr() { }

	[Address(RVA = "0x2D94EF0", Offset = "0x2D942F0", Length = "0x75")]
	[Token(Token = "0x6000493")]
	internal XRPassUniversal get_xrUniversal() { }

	[Address(RVA = "0x2D8B9D0", Offset = "0x2D8ADD0", Length = "0x16")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000475")]
	public Matrix4x4 GetGPUProjectionMatrix(int viewIndex = 0) { }

	[Address(RVA = "0x2D934C0", Offset = "0x2D928C0", Length = "0x92")]
	[Token(Token = "0x600047E")]
	internal Matrix4x4 GetGPUProjectionMatrix(bool renderIntoTexture, int viewIndex = 0) { }

	[Address(RVA = "0x2D8B9D0", Offset = "0x2D8ADD0", Length = "0x16")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000476")]
	public Matrix4x4 GetGPUProjectionMatrixNoJitter(int viewIndex = 0) { }

	[Address(RVA = "0x2D93610", Offset = "0x2D92A10", Length = "0x1B3")]
	[Token(Token = "0x600047C")]
	public Matrix4x4 GetProjectionMatrix(int viewIndex = 0) { }

	[Address(RVA = "0x2D93560", Offset = "0x2D92960", Length = "0xA1")]
	[Token(Token = "0x600047D")]
	internal Matrix4x4 GetProjectionMatrixNoJitter(int viewIndex = 0) { }

	[Address(RVA = "0x2D937D0", Offset = "0x2D92BD0", Length = "0x9E")]
	[Token(Token = "0x600047B")]
	public Matrix4x4 GetViewMatrix(int viewIndex = 0) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000477")]
	public bool IsCameraProjectionMatrixFlipped() { }

	[Address(RVA = "0x2D93870", Offset = "0x2D92C70", Length = "0x32D")]
	[Token(Token = "0x600048B")]
	public bool IsHandleYFlipped(RTHandle handle) { }

	[Address(RVA = "0x2D93BA0", Offset = "0x2D92FA0", Length = "0xAC")]
	[Token(Token = "0x600048C")]
	public bool IsRenderTargetProjectionMatrixFlipped(RTHandle color, RTHandle depth = null) { }

	[Address(RVA = "0x2D93C50", Offset = "0x2D93050", Length = "0x1C")]
	[Token(Token = "0x6000490")]
	internal bool IsSTPEnabled() { }

	[Address(RVA = "0x2D93C70", Offset = "0x2D93070", Length = "0x17")]
	[Token(Token = "0x600048F")]
	internal bool IsSTPRequested() { }

	[Address(RVA = "0x2D93C90", Offset = "0x2D93090", Length = "0xEB")]
	[Token(Token = "0x600048E")]
	internal bool IsTemporalAAEnabled() { }

	[Address(RVA = "0x2D93D80", Offset = "0x2D93180", Length = "0xB")]
	[Token(Token = "0x600048D")]
	internal bool IsTemporalAARequested() { }

	[Address(RVA = "0x2D93D90", Offset = "0x2D93190", Length = "0x820")]
	[Token(Token = "0x600047A")]
	internal void PushBuiltinShaderConstantsXR(RasterCommandBuffer cmd, bool renderIntoTexture) { }

	[Address(RVA = "0x2D945C0", Offset = "0x2D939C0", Length = "0x237")]
	[Token(Token = "0x6000495")]
	public virtual void Reset() { }

	[Address(RVA = "0x20D5300", Offset = "0x20D4700", Length = "0x13")]
	[Token(Token = "0x6000480")]
	public void set_historyManager(UniversalCameraHistory value) { }

	[Address(RVA = "0x291FDD0", Offset = "0x291F1D0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000492")]
	internal void set_xr(XRPass value) { }

	[Address(RVA = "0x2D94800", Offset = "0x2D93C00", Length = "0xAA")]
	[Token(Token = "0x6000478")]
	internal void SetViewAndProjectionMatrix(Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix) { }

	[Address(RVA = "0x2D948B0", Offset = "0x2D93CB0", Length = "0x75")]
	[Token(Token = "0x6000479")]
	internal void SetViewProjectionAndJitterMatrix(Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, Matrix4x4 jitterMatrix) { }

}

