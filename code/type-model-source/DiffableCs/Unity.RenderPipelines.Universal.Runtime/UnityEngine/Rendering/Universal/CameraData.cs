namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000C4")]
public struct CameraData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000444")]
	private ContextContainer frameData; //Field offset: 0x0

	[Token(Token = "0x17000149")]
	public bool allowHDROutput
	{
		[Address(RVA = "0x2D8C180", Offset = "0x2D8B580", Length = "0x4F")]
		[Token(Token = "0x60004E2")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000162")]
	public AntialiasingMode antialiasing
	{
		[Address(RVA = "0x2D8C220", Offset = "0x2D8B620", Length = "0x4F")]
		[Token(Token = "0x60004FF")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000163")]
	public AntialiasingQuality antialiasingQuality
	{
		[Address(RVA = "0x2D8C1D0", Offset = "0x2D8B5D0", Length = "0x4F")]
		[Token(Token = "0x6000500")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700013E")]
	internal float aspectRatio
	{
		[Address(RVA = "0x2D8C270", Offset = "0x2D8B670", Length = "0x4F")]
		[Token(Token = "0x60004D7")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000167")]
	public Color backgroundColor
	{
		[Address(RVA = "0x2D8C2C0", Offset = "0x2D8B6C0", Length = "0x4F")]
		[Token(Token = "0x6000504")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700016B")]
	public Camera baseCamera
	{
		[Address(RVA = "0x2D8C310", Offset = "0x2D8B710", Length = "0x4F")]
		[Token(Token = "0x6000508")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000133")]
	public Camera camera
	{
		[Address(RVA = "0x2D8C400", Offset = "0x2D8B800", Length = "0x4F")]
		[Token(Token = "0x60004CC")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000137")]
	public RenderTextureDescriptor cameraTargetDescriptor
	{
		[Address(RVA = "0x2D8C360", Offset = "0x2D8B760", Length = "0x4F")]
		[Token(Token = "0x60004D0")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000146")]
	public CameraType cameraType
	{
		[Address(RVA = "0x2D8C3B0", Offset = "0x2D8B7B0", Length = "0x4F")]
		[Token(Token = "0x60004DF")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700015D")]
	public IEnumerator<Action`2<RenderTargetIdentifier, CommandBuffer>>& captureActions
	{
		[Address(RVA = "0x2D8C450", Offset = "0x2D8B850", Length = "0x4F")]
		[Token(Token = "0x60004FA")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000145")]
	public bool clearDepth
	{
		[Address(RVA = "0x2D8C4A0", Offset = "0x2D8B8A0", Length = "0x4F")]
		[Token(Token = "0x60004DE")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000158")]
	public SortingCriteria defaultOpaqueSortFlags
	{
		[Address(RVA = "0x2D8C4F0", Offset = "0x2D8B8F0", Length = "0x4F")]
		[Token(Token = "0x60004F4")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000142")]
	internal bool fsrOverrideSharpness
	{
		[Address(RVA = "0x2D8C540", Offset = "0x2D8B940", Length = "0x4F")]
		[Token(Token = "0x60004DB")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000143")]
	internal float fsrSharpness
	{
		[Address(RVA = "0x2D8C590", Offset = "0x2D8B990", Length = "0x4F")]
		[Token(Token = "0x60004DC")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000144")]
	internal HDRColorBufferPrecision hdrColorBufferPrecision
	{
		[Address(RVA = "0x2D8C5E0", Offset = "0x2D8B9E0", Length = "0x4F")]
		[Token(Token = "0x60004DD")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000156")]
	public ColorGamut hdrDisplayColorGamut
	{
		[Address(RVA = "0x2D8C630", Offset = "0x2D8BA30", Length = "0xC5")]
		[Token(Token = "0x60004EF")]
		 get { } //Length: 197
	}

	[Token(Token = "0x17000155")]
	public HDRDisplayInformation hdrDisplayInformation
	{
		[Address(RVA = "0x2D8C700", Offset = "0x2D8BB00", Length = "0x16A")]
		[Token(Token = "0x60004EE")]
		 get { } //Length: 362
	}

	[Token(Token = "0x17000134")]
	public UniversalCameraHistory historyManager
	{
		[Address(RVA = "0x2D8C870", Offset = "0x2D8BC70", Length = "0x4F")]
		[Token(Token = "0x60004CD")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000140")]
	internal ImageScalingMode imageScalingMode
	{
		[Address(RVA = "0x2D8C8C0", Offset = "0x2D8BCC0", Length = "0x4F")]
		[Token(Token = "0x60004D9")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700014A")]
	public bool isAlphaOutputEnabled
	{
		[Address(RVA = "0x2D8C910", Offset = "0x2D8BD10", Length = "0x4F")]
		[Token(Token = "0x60004E3")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000147")]
	public bool isDefaultViewport
	{
		[Address(RVA = "0x2D8C960", Offset = "0x2D8BD60", Length = "0x4F")]
		[Token(Token = "0x60004E0")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000161")]
	public bool isDitheringEnabled
	{
		[Address(RVA = "0x2D8C9B0", Offset = "0x2D8BDB0", Length = "0x4F")]
		[Token(Token = "0x60004FE")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000148")]
	public bool isHdrEnabled
	{
		[Address(RVA = "0x2D8CA60", Offset = "0x2D8BE60", Length = "0x4F")]
		[Token(Token = "0x60004E1")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000154")]
	public bool isHDROutputActive
	{
		[Address(RVA = "0x2D8CA00", Offset = "0x2D8BE00", Length = "0x52")]
		[Token(Token = "0x60004ED")]
		 get { } //Length: 82
	}

	[Token(Token = "0x17000151")]
	public bool isPreviewCamera
	{
		[Address(RVA = "0x2D8CAB0", Offset = "0x2D8BEB0", Length = "0x53")]
		[Token(Token = "0x60004EA")]
		 get { } //Length: 83
	}

	[Token(Token = "0x17000152")]
	internal bool isRenderPassSupportedCamera
	{
		[Address(RVA = "0x2D8CB10", Offset = "0x2D8BF10", Length = "0x64")]
		[Token(Token = "0x60004EB")]
		internal get { } //Length: 100
	}

	[Token(Token = "0x17000150")]
	public bool isSceneViewCamera
	{
		[Address(RVA = "0x2D8CB80", Offset = "0x2D8BF80", Length = "0x53")]
		[Token(Token = "0x60004E9")]
		 get { } //Length: 83
	}

	[Token(Token = "0x17000160")]
	public bool isStopNaNEnabled
	{
		[Address(RVA = "0x2D8CBE0", Offset = "0x2D8BFE0", Length = "0x4F")]
		[Token(Token = "0x60004FD")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700015B")]
	public float maxShadowDistance
	{
		[Address(RVA = "0x2D8CC30", Offset = "0x2D8C030", Length = "0x4F")]
		[Token(Token = "0x60004F8")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700013D")]
	internal int pixelHeight
	{
		[Address(RVA = "0x2D8CC80", Offset = "0x2D8C080", Length = "0x4F")]
		[Token(Token = "0x60004D6")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000138")]
	internal Rect pixelRect
	{
		[Address(RVA = "0x2D8CCD0", Offset = "0x2D8C0D0", Length = "0x4F")]
		[Token(Token = "0x60004D1")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700013C")]
	internal int pixelWidth
	{
		[Address(RVA = "0x2D8CD20", Offset = "0x2D8C120", Length = "0x4F")]
		[Token(Token = "0x60004D5")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700015C")]
	public bool postProcessEnabled
	{
		[Address(RVA = "0x2D8CD70", Offset = "0x2D8C170", Length = "0x4F")]
		[Token(Token = "0x60004F9")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700014D")]
	public bool postProcessingRequiresDepthTexture
	{
		[Address(RVA = "0x2D8CDC0", Offset = "0x2D8C1C0", Length = "0x4F")]
		[Token(Token = "0x60004E6")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000164")]
	public ScriptableRenderer renderer
	{
		[Address(RVA = "0x2D8CEB0", Offset = "0x2D8C2B0", Length = "0x4F")]
		[Token(Token = "0x6000501")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700013F")]
	public float renderScale
	{
		[Address(RVA = "0x2D8CE10", Offset = "0x2D8C210", Length = "0x4F")]
		[Token(Token = "0x60004D8")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000157")]
	public bool rendersOverlayUI
	{
		[Address(RVA = "0x2D8CF00", Offset = "0x2D8C300", Length = "0xA0")]
		[Token(Token = "0x60004F0")]
		 get { } //Length: 160
	}

	[Token(Token = "0x17000135")]
	public CameraRenderType renderType
	{
		[Address(RVA = "0x2D8CE60", Offset = "0x2D8C260", Length = "0x4F")]
		[Token(Token = "0x60004CE")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700014B")]
	public bool requiresDepthTexture
	{
		[Address(RVA = "0x2D8D010", Offset = "0x2D8C410", Length = "0x4F")]
		[Token(Token = "0x60004E4")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700014C")]
	public bool requiresOpaqueTexture
	{
		[Address(RVA = "0x2D8D060", Offset = "0x2D8C460", Length = "0x4F")]
		[Token(Token = "0x60004E5")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700014F")]
	internal bool requireSrgbConversion
	{
		[Address(RVA = "0x2D8CFB0", Offset = "0x2D8C3B0", Length = "0x52")]
		[Token(Token = "0x60004E8")]
		internal get { } //Length: 82
	}

	[Token(Token = "0x1700016A")]
	internal bool resetHistory
	{
		[Address(RVA = "0x2D8D0B0", Offset = "0x2D8C4B0", Length = "0x53")]
		[Token(Token = "0x6000507")]
		internal get { } //Length: 83
	}

	[Token(Token = "0x17000165")]
	public bool resolveFinalTarget
	{
		[Address(RVA = "0x2D8D110", Offset = "0x2D8C510", Length = "0x4F")]
		[Token(Token = "0x6000502")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000153")]
	internal bool resolveToScreen
	{
		[Address(RVA = "0x2D8D160", Offset = "0x2D8C560", Length = "0x52")]
		[Token(Token = "0x60004EC")]
		internal get { } //Length: 82
	}

	[Token(Token = "0x1700013B")]
	internal Vector4 screenCoordScaleBias
	{
		[Address(RVA = "0x2D8D1C0", Offset = "0x2D8C5C0", Length = "0x4F")]
		[Token(Token = "0x60004D4")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700013A")]
	internal Vector4 screenSizeOverride
	{
		[Address(RVA = "0x2D8D210", Offset = "0x2D8C610", Length = "0x4F")]
		[Token(Token = "0x60004D3")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000168")]
	internal TaaHistory taaHistory
	{
		[Address(RVA = "0x2D8D260", Offset = "0x2D8C660", Length = "0x4F")]
		[Token(Token = "0x6000505")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000169")]
	internal Settings taaSettings
	{
		[Address(RVA = "0x2D8D2B0", Offset = "0x2D8C6B0", Length = "0x4F")]
		[Token(Token = "0x6000506")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000136")]
	public RenderTexture targetTexture
	{
		[Address(RVA = "0x2D8D300", Offset = "0x2D8C700", Length = "0x4F")]
		[Token(Token = "0x60004CF")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000132")]
	internal UniversalCameraData universalCameraData
	{
		[Address(RVA = "0x2D8D350", Offset = "0x2D8C750", Length = "0x43")]
		[Token(Token = "0x60004C4")]
		internal get { } //Length: 67
	}

	[Token(Token = "0x17000141")]
	internal ImageUpscalingFilter upscalingFilter
	{
		[Address(RVA = "0x2D8D3A0", Offset = "0x2D8C7A0", Length = "0x4F")]
		[Token(Token = "0x60004DA")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000139")]
	internal bool useScreenCoordOverride
	{
		[Address(RVA = "0x2D8D3F0", Offset = "0x2D8C7F0", Length = "0x4F")]
		[Token(Token = "0x60004D2")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700015E")]
	public LayerMask volumeLayerMask
	{
		[Address(RVA = "0x2D8D440", Offset = "0x2D8C840", Length = "0x4F")]
		[Token(Token = "0x60004FB")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700015F")]
	public Transform volumeTrigger
	{
		[Address(RVA = "0x2D8D490", Offset = "0x2D8C890", Length = "0x4F")]
		[Token(Token = "0x60004FC")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000166")]
	public Vector3 worldSpaceCameraPos
	{
		[Address(RVA = "0x2D8D4E0", Offset = "0x2D8C8E0", Length = "0x4F")]
		[Token(Token = "0x6000503")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000159")]
	public internal XRPass xr
	{
		[Address(RVA = "0x2D8D5E0", Offset = "0x2D8C9E0", Length = "0x50")]
		[Token(Token = "0x60004F5")]
		 get { } //Length: 80
		[Address(RVA = "0x2D8D640", Offset = "0x2D8CA40", Length = "0x6A")]
		[Token(Token = "0x60004F6")]
		internal set { } //Length: 106
	}

	[Token(Token = "0x1700014E")]
	public bool xrRendering
	{
		[Address(RVA = "0x2D8D530", Offset = "0x2D8C930", Length = "0x4F")]
		[Token(Token = "0x60004E7")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700015A")]
	internal XRPassUniversal xrUniversal
	{
		[Address(RVA = "0x2D8D580", Offset = "0x2D8C980", Length = "0x52")]
		[Token(Token = "0x60004F7")]
		internal get { } //Length: 82
	}

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x60004C3")]
	internal CameraData(ContextContainer frameData) { }

	[Address(RVA = "0x2D8C180", Offset = "0x2D8B580", Length = "0x4F")]
	[Token(Token = "0x60004E2")]
	public bool get_allowHDROutput() { }

	[Address(RVA = "0x2D8C220", Offset = "0x2D8B620", Length = "0x4F")]
	[Token(Token = "0x60004FF")]
	public AntialiasingMode get_antialiasing() { }

	[Address(RVA = "0x2D8C1D0", Offset = "0x2D8B5D0", Length = "0x4F")]
	[Token(Token = "0x6000500")]
	public AntialiasingQuality get_antialiasingQuality() { }

	[Address(RVA = "0x2D8C270", Offset = "0x2D8B670", Length = "0x4F")]
	[Token(Token = "0x60004D7")]
	internal float get_aspectRatio() { }

	[Address(RVA = "0x2D8C2C0", Offset = "0x2D8B6C0", Length = "0x4F")]
	[Token(Token = "0x6000504")]
	public Color get_backgroundColor() { }

	[Address(RVA = "0x2D8C310", Offset = "0x2D8B710", Length = "0x4F")]
	[Token(Token = "0x6000508")]
	public Camera get_baseCamera() { }

	[Address(RVA = "0x2D8C400", Offset = "0x2D8B800", Length = "0x4F")]
	[Token(Token = "0x60004CC")]
	public Camera get_camera() { }

	[Address(RVA = "0x2D8C360", Offset = "0x2D8B760", Length = "0x4F")]
	[Token(Token = "0x60004D0")]
	public RenderTextureDescriptor get_cameraTargetDescriptor() { }

	[Address(RVA = "0x2D8C3B0", Offset = "0x2D8B7B0", Length = "0x4F")]
	[Token(Token = "0x60004DF")]
	public CameraType get_cameraType() { }

	[Address(RVA = "0x2D8C450", Offset = "0x2D8B850", Length = "0x4F")]
	[Token(Token = "0x60004FA")]
	public IEnumerator<Action`2<RenderTargetIdentifier, CommandBuffer>>& get_captureActions() { }

	[Address(RVA = "0x2D8C4A0", Offset = "0x2D8B8A0", Length = "0x4F")]
	[Token(Token = "0x60004DE")]
	public bool get_clearDepth() { }

	[Address(RVA = "0x2D8C4F0", Offset = "0x2D8B8F0", Length = "0x4F")]
	[Token(Token = "0x60004F4")]
	public SortingCriteria get_defaultOpaqueSortFlags() { }

	[Address(RVA = "0x2D8C540", Offset = "0x2D8B940", Length = "0x4F")]
	[Token(Token = "0x60004DB")]
	internal bool get_fsrOverrideSharpness() { }

	[Address(RVA = "0x2D8C590", Offset = "0x2D8B990", Length = "0x4F")]
	[Token(Token = "0x60004DC")]
	internal float get_fsrSharpness() { }

	[Address(RVA = "0x2D8C5E0", Offset = "0x2D8B9E0", Length = "0x4F")]
	[Token(Token = "0x60004DD")]
	internal HDRColorBufferPrecision get_hdrColorBufferPrecision() { }

	[Address(RVA = "0x2D8C630", Offset = "0x2D8BA30", Length = "0xC5")]
	[Token(Token = "0x60004EF")]
	public ColorGamut get_hdrDisplayColorGamut() { }

	[Address(RVA = "0x2D8C700", Offset = "0x2D8BB00", Length = "0x16A")]
	[Token(Token = "0x60004EE")]
	public HDRDisplayInformation get_hdrDisplayInformation() { }

	[Address(RVA = "0x2D8C870", Offset = "0x2D8BC70", Length = "0x4F")]
	[Token(Token = "0x60004CD")]
	public UniversalCameraHistory get_historyManager() { }

	[Address(RVA = "0x2D8C8C0", Offset = "0x2D8BCC0", Length = "0x4F")]
	[Token(Token = "0x60004D9")]
	internal ImageScalingMode get_imageScalingMode() { }

	[Address(RVA = "0x2D8C910", Offset = "0x2D8BD10", Length = "0x4F")]
	[Token(Token = "0x60004E3")]
	public bool get_isAlphaOutputEnabled() { }

	[Address(RVA = "0x2D8C960", Offset = "0x2D8BD60", Length = "0x4F")]
	[Token(Token = "0x60004E0")]
	public bool get_isDefaultViewport() { }

	[Address(RVA = "0x2D8C9B0", Offset = "0x2D8BDB0", Length = "0x4F")]
	[Token(Token = "0x60004FE")]
	public bool get_isDitheringEnabled() { }

	[Address(RVA = "0x2D8CA60", Offset = "0x2D8BE60", Length = "0x4F")]
	[Token(Token = "0x60004E1")]
	public bool get_isHdrEnabled() { }

	[Address(RVA = "0x2D8CA00", Offset = "0x2D8BE00", Length = "0x52")]
	[Token(Token = "0x60004ED")]
	public bool get_isHDROutputActive() { }

	[Address(RVA = "0x2D8CAB0", Offset = "0x2D8BEB0", Length = "0x53")]
	[Token(Token = "0x60004EA")]
	public bool get_isPreviewCamera() { }

	[Address(RVA = "0x2D8CB10", Offset = "0x2D8BF10", Length = "0x64")]
	[Token(Token = "0x60004EB")]
	internal bool get_isRenderPassSupportedCamera() { }

	[Address(RVA = "0x2D8CB80", Offset = "0x2D8BF80", Length = "0x53")]
	[Token(Token = "0x60004E9")]
	public bool get_isSceneViewCamera() { }

	[Address(RVA = "0x2D8CBE0", Offset = "0x2D8BFE0", Length = "0x4F")]
	[Token(Token = "0x60004FD")]
	public bool get_isStopNaNEnabled() { }

	[Address(RVA = "0x2D8CC30", Offset = "0x2D8C030", Length = "0x4F")]
	[Token(Token = "0x60004F8")]
	public float get_maxShadowDistance() { }

	[Address(RVA = "0x2D8CC80", Offset = "0x2D8C080", Length = "0x4F")]
	[Token(Token = "0x60004D6")]
	internal int get_pixelHeight() { }

	[Address(RVA = "0x2D8CCD0", Offset = "0x2D8C0D0", Length = "0x4F")]
	[Token(Token = "0x60004D1")]
	internal Rect get_pixelRect() { }

	[Address(RVA = "0x2D8CD20", Offset = "0x2D8C120", Length = "0x4F")]
	[Token(Token = "0x60004D5")]
	internal int get_pixelWidth() { }

	[Address(RVA = "0x2D8CD70", Offset = "0x2D8C170", Length = "0x4F")]
	[Token(Token = "0x60004F9")]
	public bool get_postProcessEnabled() { }

	[Address(RVA = "0x2D8CDC0", Offset = "0x2D8C1C0", Length = "0x4F")]
	[Token(Token = "0x60004E6")]
	public bool get_postProcessingRequiresDepthTexture() { }

	[Address(RVA = "0x2D8CEB0", Offset = "0x2D8C2B0", Length = "0x4F")]
	[Token(Token = "0x6000501")]
	public ScriptableRenderer get_renderer() { }

	[Address(RVA = "0x2D8CE10", Offset = "0x2D8C210", Length = "0x4F")]
	[Token(Token = "0x60004D8")]
	public float get_renderScale() { }

	[Address(RVA = "0x2D8CF00", Offset = "0x2D8C300", Length = "0xA0")]
	[Token(Token = "0x60004F0")]
	public bool get_rendersOverlayUI() { }

	[Address(RVA = "0x2D8CE60", Offset = "0x2D8C260", Length = "0x4F")]
	[Token(Token = "0x60004CE")]
	public CameraRenderType get_renderType() { }

	[Address(RVA = "0x2D8D010", Offset = "0x2D8C410", Length = "0x4F")]
	[Token(Token = "0x60004E4")]
	public bool get_requiresDepthTexture() { }

	[Address(RVA = "0x2D8D060", Offset = "0x2D8C460", Length = "0x4F")]
	[Token(Token = "0x60004E5")]
	public bool get_requiresOpaqueTexture() { }

	[Address(RVA = "0x2D8CFB0", Offset = "0x2D8C3B0", Length = "0x52")]
	[Token(Token = "0x60004E8")]
	internal bool get_requireSrgbConversion() { }

	[Address(RVA = "0x2D8D0B0", Offset = "0x2D8C4B0", Length = "0x53")]
	[Token(Token = "0x6000507")]
	internal bool get_resetHistory() { }

	[Address(RVA = "0x2D8D110", Offset = "0x2D8C510", Length = "0x4F")]
	[Token(Token = "0x6000502")]
	public bool get_resolveFinalTarget() { }

	[Address(RVA = "0x2D8D160", Offset = "0x2D8C560", Length = "0x52")]
	[Token(Token = "0x60004EC")]
	internal bool get_resolveToScreen() { }

	[Address(RVA = "0x2D8D1C0", Offset = "0x2D8C5C0", Length = "0x4F")]
	[Token(Token = "0x60004D4")]
	internal Vector4 get_screenCoordScaleBias() { }

	[Address(RVA = "0x2D8D210", Offset = "0x2D8C610", Length = "0x4F")]
	[Token(Token = "0x60004D3")]
	internal Vector4 get_screenSizeOverride() { }

	[Address(RVA = "0x2D8D260", Offset = "0x2D8C660", Length = "0x4F")]
	[Token(Token = "0x6000505")]
	internal TaaHistory get_taaHistory() { }

	[Address(RVA = "0x2D8D2B0", Offset = "0x2D8C6B0", Length = "0x4F")]
	[Token(Token = "0x6000506")]
	internal Settings get_taaSettings() { }

	[Address(RVA = "0x2D8D300", Offset = "0x2D8C700", Length = "0x4F")]
	[Token(Token = "0x60004CF")]
	public RenderTexture get_targetTexture() { }

	[Address(RVA = "0x2D8D350", Offset = "0x2D8C750", Length = "0x43")]
	[Token(Token = "0x60004C4")]
	internal UniversalCameraData get_universalCameraData() { }

	[Address(RVA = "0x2D8D3A0", Offset = "0x2D8C7A0", Length = "0x4F")]
	[Token(Token = "0x60004DA")]
	internal ImageUpscalingFilter get_upscalingFilter() { }

	[Address(RVA = "0x2D8D3F0", Offset = "0x2D8C7F0", Length = "0x4F")]
	[Token(Token = "0x60004D2")]
	internal bool get_useScreenCoordOverride() { }

	[Address(RVA = "0x2D8D440", Offset = "0x2D8C840", Length = "0x4F")]
	[Token(Token = "0x60004FB")]
	public LayerMask get_volumeLayerMask() { }

	[Address(RVA = "0x2D8D490", Offset = "0x2D8C890", Length = "0x4F")]
	[Token(Token = "0x60004FC")]
	public Transform get_volumeTrigger() { }

	[Address(RVA = "0x2D8D4E0", Offset = "0x2D8C8E0", Length = "0x4F")]
	[Token(Token = "0x6000503")]
	public Vector3 get_worldSpaceCameraPos() { }

	[Address(RVA = "0x2D8D5E0", Offset = "0x2D8C9E0", Length = "0x50")]
	[Token(Token = "0x60004F5")]
	public XRPass get_xr() { }

	[Address(RVA = "0x2D8D530", Offset = "0x2D8C930", Length = "0x4F")]
	[Token(Token = "0x60004E7")]
	public bool get_xrRendering() { }

	[Address(RVA = "0x2D8D580", Offset = "0x2D8C980", Length = "0x52")]
	[Token(Token = "0x60004F7")]
	internal XRPassUniversal get_xrUniversal() { }

	[Address(RVA = "0x2D8B9D0", Offset = "0x2D8ADD0", Length = "0x16")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x60004C0")]
	public Matrix4x4 GetGPUProjectionMatrix(int viewIndex = 0) { }

	[Address(RVA = "0x2D8B9F0", Offset = "0x2D8ADF0", Length = "0xEC")]
	[Token(Token = "0x60004CB")]
	internal Matrix4x4 GetGPUProjectionMatrix(bool renderIntoTexture, int viewIndex = 0) { }

	[Address(RVA = "0x2D8B9D0", Offset = "0x2D8ADD0", Length = "0x16")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x60004C1")]
	public Matrix4x4 GetGPUProjectionMatrixNoJitter(int viewIndex = 0) { }

	[Address(RVA = "0x2D8BBC0", Offset = "0x2D8AFC0", Length = "0x96")]
	[Token(Token = "0x60004C9")]
	public Matrix4x4 GetProjectionMatrix(int viewIndex = 0) { }

	[Address(RVA = "0x2D8BAE0", Offset = "0x2D8AEE0", Length = "0xD2")]
	[Token(Token = "0x60004CA")]
	internal Matrix4x4 GetProjectionMatrixNoJitter(int viewIndex = 0) { }

	[Address(RVA = "0x2D8BC60", Offset = "0x2D8B060", Length = "0xCF")]
	[Token(Token = "0x60004C8")]
	public Matrix4x4 GetViewMatrix(int viewIndex = 0) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x60004C2")]
	public bool IsCameraProjectionMatrixFlipped() { }

	[Address(RVA = "0x2D8BD30", Offset = "0x2D8B130", Length = "0x62")]
	[Token(Token = "0x60004F1")]
	public bool IsHandleYFlipped(RTHandle handle) { }

	[Address(RVA = "0x2D8BDA0", Offset = "0x2D8B1A0", Length = "0xF1")]
	[Token(Token = "0x60004F2")]
	public bool IsRenderTargetProjectionMatrixFlipped(RTHandle color, RTHandle depth = null) { }

	[Address(RVA = "0x2D8BEA0", Offset = "0x2D8B2A0", Length = "0x52")]
	[Token(Token = "0x60004F3")]
	internal bool IsTemporalAAEnabled() { }

	[Address(RVA = "0x2D8BF00", Offset = "0x2D8B300", Length = "0x74")]
	[Token(Token = "0x60004C7")]
	internal void PushBuiltinShaderConstantsXR(RasterCommandBuffer cmd, bool renderIntoTexture) { }

	[Address(RVA = "0x2D8D640", Offset = "0x2D8CA40", Length = "0x6A")]
	[Token(Token = "0x60004F6")]
	internal void set_xr(XRPass value) { }

	[Address(RVA = "0x2D8BF80", Offset = "0x2D8B380", Length = "0x104")]
	[Token(Token = "0x60004C5")]
	internal void SetViewAndProjectionMatrix(Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix) { }

	[Address(RVA = "0x2D8C090", Offset = "0x2D8B490", Length = "0xE4")]
	[Token(Token = "0x60004C6")]
	internal void SetViewProjectionAndJitterMatrix(Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, Matrix4x4 jitterMatrix) { }

}

