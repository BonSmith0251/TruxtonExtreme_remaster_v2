namespace UnityEngine.Rendering.Universal;

[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(Camera))]
[Token(Token = "0x20001C7")]
public class UniversalAdditionalCameraData : MonoBehaviour, ISerializationCallbackReceiver, IAdditionalData
{
	[CompilerGenerated]
	[Token(Token = "0x20001C9")]
	private sealed class <>c
	{
		[Token(Token = "0x40009E9")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40009EA")]
		public static Predicate<Camera> <>9__50_0; //Field offset: 0x8

		[Address(RVA = "0x2E0AFE0", Offset = "0x2E0A3E0", Length = "0x67")]
		[Token(Token = "0x60009E8")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60009E9")]
		public <>c() { }

		[Address(RVA = "0x2E0ABA0", Offset = "0x2E09FA0", Length = "0x4C")]
		[Token(Token = "0x60009EA")]
		internal bool <UpdateCameraStack>b__50_0(Camera cam) { }

	}

	[Token(Token = "0x20001C8")]
	private enum Version : int
	{
		Initial = 0,
		DepthAndOpaqueTextureOptions = 2,
		Count = 3,
	}

	[Token(Token = "0x40009C3")]
	private const string k_GizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/"; //Field offset: 0x0
	[Token(Token = "0x40009C6")]
	private const string k_PostProcessingGizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/Camera_PostProcessing.png"; //Field offset: 0x0
	[Token(Token = "0x40009E1")]
	private static UniversalAdditionalCameraData s_DefaultAdditionalCameraData; //Field offset: 0x0
	[Token(Token = "0x40009C4")]
	private const string k_BaseCameraGizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/Camera_Base.png"; //Field offset: 0x0
	[Token(Token = "0x40009C5")]
	private const string k_OverlayCameraGizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/Camera_Base.png"; //Field offset: 0x0
	[Token(Token = "0x40009E2")]
	private static List<VolumeStack> s_CachedVolumeStacks; //Field offset: 0x8
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("renderShadows")]
	[SerializeField]
	[Token(Token = "0x40009C7")]
	private bool m_RenderShadows; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x40009C8")]
	private CameraOverrideOption m_RequiresDepthTextureOption; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40009C9")]
	private CameraOverrideOption m_RequiresOpaqueTextureOption; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x40009CA")]
	private CameraRenderType m_CameraType; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40009CB")]
	private List<Camera> m_Cameras; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40009CC")]
	private int m_RendererIndex; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x40009CD")]
	private LayerMask m_VolumeLayerMask; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40009CE")]
	private Transform m_VolumeTrigger; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40009CF")]
	private VolumeFrameworkUpdateMode m_VolumeFrameworkUpdateModeOption; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x40009D0")]
	private bool m_RenderPostProcessing; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40009D1")]
	private AntialiasingMode m_Antialiasing; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x40009D2")]
	private AntialiasingQuality m_AntialiasingQuality; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40009D3")]
	private bool m_StopNaN; //Field offset: 0x58
	[FieldOffset(Offset = "0x59")]
	[SerializeField]
	[Token(Token = "0x40009D4")]
	private bool m_Dithering; //Field offset: 0x59
	[FieldOffset(Offset = "0x5A")]
	[SerializeField]
	[Token(Token = "0x40009D5")]
	private bool m_ClearDepth; //Field offset: 0x5A
	[FieldOffset(Offset = "0x5B")]
	[SerializeField]
	[Token(Token = "0x40009D6")]
	private bool m_AllowXRRendering; //Field offset: 0x5B
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Token(Token = "0x40009D7")]
	private bool m_AllowHDROutput; //Field offset: 0x5C
	[FieldOffset(Offset = "0x5D")]
	[SerializeField]
	[Token(Token = "0x40009D8")]
	private bool m_UseScreenCoordOverride; //Field offset: 0x5D
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x40009D9")]
	private Vector4 m_ScreenSizeOverride; //Field offset: 0x60
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x40009DA")]
	private Vector4 m_ScreenCoordScaleBias; //Field offset: 0x70
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40009DB")]
	private Camera m_Camera; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[FormerlySerializedAs("requiresDepthTexture")]
	[SerializeField]
	[Token(Token = "0x40009DC")]
	private bool m_RequiresDepthTexture; //Field offset: 0x88
	[FieldOffset(Offset = "0x89")]
	[FormerlySerializedAs("requiresColorTexture")]
	[SerializeField]
	[Token(Token = "0x40009DD")]
	private bool m_RequiresColorTexture; //Field offset: 0x89
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40009DE")]
	private MotionVectorsPersistentData m_MotionVectorsPersistentData; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40009DF")]
	internal UniversalCameraHistory m_History; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x40009E0")]
	internal Settings m_TaaSettings; //Field offset: 0xA0
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40009E3")]
	private VolumeStack m_VolumeStack; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[Token(Token = "0x40009E4")]
	private Version m_Version; //Field offset: 0xC8

	[Token(Token = "0x17000251")]
	public bool allowHDROutput
	{
		[Address(RVA = "0x1FEC950", Offset = "0x1FEBD50", Length = "0x5")]
		[Token(Token = "0x60009DE")]
		 get { } //Length: 5
		[Address(RVA = "0x2C9FC50", Offset = "0x2C9F050", Length = "0x4")]
		[Token(Token = "0x60009DF")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700024D")]
	public bool allowXRRendering
	{
		[Address(RVA = "0x2204BC0", Offset = "0x2203FC0", Length = "0x5")]
		[Token(Token = "0x60009D6")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFC980", Offset = "0x2DFBD80", Length = "0x4")]
		[Token(Token = "0x60009D7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000244")]
	public AntialiasingMode antialiasing
	{
		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[Token(Token = "0x60009C8")]
		 get { } //Length: 4
		[Address(RVA = "0x1E07600", Offset = "0x1E06A00", Length = "0x4")]
		[Token(Token = "0x60009C9")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000245")]
	public AntialiasingQuality antialiasingQuality
	{
		[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
		[Token(Token = "0x60009CA")]
		 get { } //Length: 4
		[Address(RVA = "0x2592030", Offset = "0x2591430", Length = "0x4")]
		[Token(Token = "0x60009CB")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000234")]
	internal Camera camera
	{
		[Address(RVA = "0x2DFC250", Offset = "0x2DFB650", Length = "0x9B")]
		[Token(Token = "0x60009A9")]
		internal get { } //Length: 155
	}

	[Token(Token = "0x17000239")]
	public List<Camera> cameraStack
	{
		[Address(RVA = "0x2DFC0E0", Offset = "0x2DFB4E0", Length = "0x16D")]
		[Token(Token = "0x60009B3")]
		 get { } //Length: 365
	}

	[Token(Token = "0x1700023A")]
	public bool clearDepth
	{
		[Address(RVA = "0x1CF2E00", Offset = "0x1CF2200", Length = "0x5")]
		[Token(Token = "0x60009B5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000233")]
	internal static UniversalAdditionalCameraData defaultAdditionalCameraData
	{
		[Address(RVA = "0x2DFC2F0", Offset = "0x2DFB6F0", Length = "0x21C")]
		[Token(Token = "0x60009A8")]
		internal get { } //Length: 540
	}

	[Token(Token = "0x1700024C")]
	public bool dithering
	{
		[Address(RVA = "0x1CCAA30", Offset = "0x1CC9E30", Length = "0x5")]
		[Token(Token = "0x60009D4")]
		 get { } //Length: 5
		[Address(RVA = "0x1CEB130", Offset = "0x1CEA530", Length = "0x4")]
		[Token(Token = "0x60009D5")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000247")]
	public ICameraHistoryReadAccess history
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x60009CD")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000248")]
	internal UniversalCameraHistory historyManager
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x60009CE")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000249")]
	internal MotionVectorsPersistentData motionVectorsPersistentData
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x60009CF")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000243")]
	public bool renderPostProcessing
	{
		[Address(RVA = "0x1CF2CC0", Offset = "0x1CF20C0", Length = "0x5")]
		[Token(Token = "0x60009C6")]
		 get { } //Length: 5
		[Address(RVA = "0x29E48A0", Offset = "0x29E3CA0", Length = "0x4")]
		[Token(Token = "0x60009C7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000235")]
	public bool renderShadows
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x60009AB")]
		 get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[Token(Token = "0x60009AC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000238")]
	public CameraRenderType renderType
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x60009B1")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
		[Token(Token = "0x60009B2")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000237")]
	public CameraOverrideOption requiresColorOption
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x60009AF")]
		 get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[Token(Token = "0x60009B0")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700023C")]
	public bool requiresColorTexture
	{
		[Address(RVA = "0x2DFC510", Offset = "0x2DFB910", Length = "0x68")]
		[Token(Token = "0x60009B8")]
		 get { } //Length: 104
		[Address(RVA = "0x2DFC990", Offset = "0x2DFBD90", Length = "0x19")]
		[Token(Token = "0x60009B9")]
		 set { } //Length: 25
	}

	[Token(Token = "0x17000236")]
	public CameraOverrideOption requiresDepthOption
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x60009AD")]
		 get { } //Length: 4
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[Token(Token = "0x60009AE")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700023B")]
	public bool requiresDepthTexture
	{
		[Address(RVA = "0x2DFC580", Offset = "0x2DFB980", Length = "0x68")]
		[Token(Token = "0x60009B6")]
		 get { } //Length: 104
		[Address(RVA = "0x2DFC9B0", Offset = "0x2DFBDB0", Length = "0x19")]
		[Token(Token = "0x60009B7")]
		 set { } //Length: 25
	}

	[Token(Token = "0x17000241")]
	public bool requiresVolumeFrameworkUpdate
	{
		[Address(RVA = "0x2DFC5F0", Offset = "0x2DFB9F0", Length = "0x6E")]
		[Token(Token = "0x60009C2")]
		 get { } //Length: 110
	}

	[Token(Token = "0x1700024A")]
	public bool resetHistory
	{
		[Address(RVA = "0x26C2F10", Offset = "0x26C2310", Length = "0xB")]
		[Token(Token = "0x60009D0")]
		 get { } //Length: 11
		[Address(RVA = "0x2DFC9D0", Offset = "0x2DFBDD0", Length = "0x3F")]
		[Token(Token = "0x60009D1")]
		 set { } //Length: 63
	}

	[Token(Token = "0x17000250")]
	public Vector4 screenCoordScaleBias
	{
		[Address(RVA = "0x2161F30", Offset = "0x2161330", Length = "0xB")]
		[Token(Token = "0x60009DC")]
		 get { } //Length: 11
		[Address(RVA = "0x2162000", Offset = "0x2161400", Length = "0x8")]
		[Token(Token = "0x60009DD")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700024F")]
	public Vector4 screenSizeOverride
	{
		[Address(RVA = "0x20D8470", Offset = "0x20D7870", Length = "0xB")]
		[Token(Token = "0x60009DA")]
		 get { } //Length: 11
		[Address(RVA = "0x2162020", Offset = "0x2161420", Length = "0x8")]
		[Token(Token = "0x60009DB")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700023D")]
	public ScriptableRenderer scriptableRenderer
	{
		[Address(RVA = "0x2DFC660", Offset = "0x2DFBA60", Length = "0x2FC")]
		[Token(Token = "0x60009BA")]
		 get { } //Length: 764
	}

	[Token(Token = "0x1700024B")]
	public bool stopNaN
	{
		[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
		[Token(Token = "0x60009D2")]
		 get { } //Length: 5
		[Address(RVA = "0x1E523B0", Offset = "0x1E517B0", Length = "0x4")]
		[Token(Token = "0x60009D3")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000246")]
	public Settings taaSettings
	{
		[Address(RVA = "0x1399B20", Offset = "0x1398F20", Length = "0x8")]
		[Token(Token = "0x60009CC")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700024E")]
	public bool useScreenCoordOverride
	{
		[Address(RVA = "0x2DFC960", Offset = "0x2DFBD60", Length = "0x5")]
		[Token(Token = "0x60009D8")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFCA10", Offset = "0x2DFBE10", Length = "0x4")]
		[Token(Token = "0x60009D9")]
		 set { } //Length: 4
	}

	[Obsolete("This field has been deprecated. #from(6000.2)")]
	[Token(Token = "0x17000252")]
	public float version
	{
		[Address(RVA = "0x2DFC970", Offset = "0x2DFBD70", Length = "0xC")]
		[Token(Token = "0x60009E6")]
		 get { } //Length: 12
	}

	[Token(Token = "0x17000240")]
	internal VolumeFrameworkUpdateMode volumeFrameworkUpdateMode
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x60009C0")]
		internal get { } //Length: 4
		[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
		[Token(Token = "0x60009C1")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700023E")]
	public LayerMask volumeLayerMask
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x60009BC")]
		 get { } //Length: 4
		[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
		[Token(Token = "0x60009BD")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000242")]
	public VolumeStack volumeStack
	{
		[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
		[Token(Token = "0x60009C3")]
		 get { } //Length: 8
		[Address(RVA = "0x2DFCA20", Offset = "0x2DFBE20", Length = "0x17F")]
		[Token(Token = "0x60009C4")]
		 set { } //Length: 383
	}

	[Token(Token = "0x1700023F")]
	public Transform volumeTrigger
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60009BE")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[Token(Token = "0x60009BF")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2DFBF60", Offset = "0x2DFB360", Length = "0x173")]
	[Token(Token = "0x60009E7")]
	public UniversalAdditionalCameraData() { }

	[Address(RVA = "0x1FEC950", Offset = "0x1FEBD50", Length = "0x5")]
	[Token(Token = "0x60009DE")]
	public bool get_allowHDROutput() { }

	[Address(RVA = "0x2204BC0", Offset = "0x2203FC0", Length = "0x5")]
	[Token(Token = "0x60009D6")]
	public bool get_allowXRRendering() { }

	[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
	[Token(Token = "0x60009C8")]
	public AntialiasingMode get_antialiasing() { }

	[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
	[Token(Token = "0x60009CA")]
	public AntialiasingQuality get_antialiasingQuality() { }

	[Address(RVA = "0x2DFC250", Offset = "0x2DFB650", Length = "0x9B")]
	[Token(Token = "0x60009A9")]
	internal Camera get_camera() { }

	[Address(RVA = "0x2DFC0E0", Offset = "0x2DFB4E0", Length = "0x16D")]
	[Token(Token = "0x60009B3")]
	public List<Camera> get_cameraStack() { }

	[Address(RVA = "0x1CF2E00", Offset = "0x1CF2200", Length = "0x5")]
	[Token(Token = "0x60009B5")]
	public bool get_clearDepth() { }

	[Address(RVA = "0x2DFC2F0", Offset = "0x2DFB6F0", Length = "0x21C")]
	[Token(Token = "0x60009A8")]
	internal static UniversalAdditionalCameraData get_defaultAdditionalCameraData() { }

	[Address(RVA = "0x1CCAA30", Offset = "0x1CC9E30", Length = "0x5")]
	[Token(Token = "0x60009D4")]
	public bool get_dithering() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x60009CD")]
	public ICameraHistoryReadAccess get_history() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x60009CE")]
	internal UniversalCameraHistory get_historyManager() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x60009CF")]
	internal MotionVectorsPersistentData get_motionVectorsPersistentData() { }

	[Address(RVA = "0x1CF2CC0", Offset = "0x1CF20C0", Length = "0x5")]
	[Token(Token = "0x60009C6")]
	public bool get_renderPostProcessing() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x60009AB")]
	public bool get_renderShadows() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x60009B1")]
	public CameraRenderType get_renderType() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x60009AF")]
	public CameraOverrideOption get_requiresColorOption() { }

	[Address(RVA = "0x2DFC510", Offset = "0x2DFB910", Length = "0x68")]
	[Token(Token = "0x60009B8")]
	public bool get_requiresColorTexture() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x60009AD")]
	public CameraOverrideOption get_requiresDepthOption() { }

	[Address(RVA = "0x2DFC580", Offset = "0x2DFB980", Length = "0x68")]
	[Token(Token = "0x60009B6")]
	public bool get_requiresDepthTexture() { }

	[Address(RVA = "0x2DFC5F0", Offset = "0x2DFB9F0", Length = "0x6E")]
	[Token(Token = "0x60009C2")]
	public bool get_requiresVolumeFrameworkUpdate() { }

	[Address(RVA = "0x26C2F10", Offset = "0x26C2310", Length = "0xB")]
	[Token(Token = "0x60009D0")]
	public bool get_resetHistory() { }

	[Address(RVA = "0x2161F30", Offset = "0x2161330", Length = "0xB")]
	[Token(Token = "0x60009DC")]
	public Vector4 get_screenCoordScaleBias() { }

	[Address(RVA = "0x20D8470", Offset = "0x20D7870", Length = "0xB")]
	[Token(Token = "0x60009DA")]
	public Vector4 get_screenSizeOverride() { }

	[Address(RVA = "0x2DFC660", Offset = "0x2DFBA60", Length = "0x2FC")]
	[Token(Token = "0x60009BA")]
	public ScriptableRenderer get_scriptableRenderer() { }

	[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
	[Token(Token = "0x60009D2")]
	public bool get_stopNaN() { }

	[Address(RVA = "0x1399B20", Offset = "0x1398F20", Length = "0x8")]
	[Token(Token = "0x60009CC")]
	public Settings get_taaSettings() { }

	[Address(RVA = "0x2DFC960", Offset = "0x2DFBD60", Length = "0x5")]
	[Token(Token = "0x60009D8")]
	public bool get_useScreenCoordOverride() { }

	[Address(RVA = "0x2DFC970", Offset = "0x2DFBD70", Length = "0xC")]
	[Token(Token = "0x60009E6")]
	public float get_version() { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x60009C0")]
	internal VolumeFrameworkUpdateMode get_volumeFrameworkUpdateMode() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x60009BC")]
	public LayerMask get_volumeLayerMask() { }

	[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
	[Token(Token = "0x60009C3")]
	public VolumeStack get_volumeStack() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60009BE")]
	public Transform get_volumeTrigger() { }

	[Address(RVA = "0x2DFB390", Offset = "0x2DFA790", Length = "0x2DC")]
	[Token(Token = "0x60009C5")]
	internal void GetOrCreateVolumeStack() { }

	[Address(RVA = "0x2DFB670", Offset = "0x2DFAA70", Length = "0x158")]
	[Token(Token = "0x60009E3")]
	private ScriptableRenderer GetRawRenderer() { }

	[Address(RVA = "0x2DFB7D0", Offset = "0x2DFABD0", Length = "0x221")]
	[Token(Token = "0x60009E2")]
	public void OnDestroy() { }

	[Address(RVA = "0x2DFBA00", Offset = "0x2DFAE00", Length = "0x144")]
	[Token(Token = "0x60009E1")]
	public void OnDrawGizmos() { }

	[Address(RVA = "0x2DFBB50", Offset = "0x2DFAF50", Length = "0x8B")]
	[Token(Token = "0x60009E0")]
	public void OnValidate() { }

	[Address(RVA = "0x2C9FC50", Offset = "0x2C9F050", Length = "0x4")]
	[Token(Token = "0x60009DF")]
	public void set_allowHDROutput(bool value) { }

	[Address(RVA = "0x2DFC980", Offset = "0x2DFBD80", Length = "0x4")]
	[Token(Token = "0x60009D7")]
	public void set_allowXRRendering(bool value) { }

	[Address(RVA = "0x1E07600", Offset = "0x1E06A00", Length = "0x4")]
	[Token(Token = "0x60009C9")]
	public void set_antialiasing(AntialiasingMode value) { }

	[Address(RVA = "0x2592030", Offset = "0x2591430", Length = "0x4")]
	[Token(Token = "0x60009CB")]
	public void set_antialiasingQuality(AntialiasingQuality value) { }

	[Address(RVA = "0x1CEB130", Offset = "0x1CEA530", Length = "0x4")]
	[Token(Token = "0x60009D5")]
	public void set_dithering(bool value) { }

	[Address(RVA = "0x29E48A0", Offset = "0x29E3CA0", Length = "0x4")]
	[Token(Token = "0x60009C7")]
	public void set_renderPostProcessing(bool value) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[Token(Token = "0x60009AC")]
	public void set_renderShadows(bool value) { }

	[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
	[Token(Token = "0x60009B2")]
	public void set_renderType(CameraRenderType value) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[Token(Token = "0x60009B0")]
	public void set_requiresColorOption(CameraOverrideOption value) { }

	[Address(RVA = "0x2DFC990", Offset = "0x2DFBD90", Length = "0x19")]
	[Token(Token = "0x60009B9")]
	public void set_requiresColorTexture(bool value) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[Token(Token = "0x60009AE")]
	public void set_requiresDepthOption(CameraOverrideOption value) { }

	[Address(RVA = "0x2DFC9B0", Offset = "0x2DFBDB0", Length = "0x19")]
	[Token(Token = "0x60009B7")]
	public void set_requiresDepthTexture(bool value) { }

	[Address(RVA = "0x2DFC9D0", Offset = "0x2DFBDD0", Length = "0x3F")]
	[Token(Token = "0x60009D1")]
	public void set_resetHistory(bool value) { }

	[Address(RVA = "0x2162000", Offset = "0x2161400", Length = "0x8")]
	[Token(Token = "0x60009DD")]
	public void set_screenCoordScaleBias(Vector4 value) { }

	[Address(RVA = "0x2162020", Offset = "0x2161420", Length = "0x8")]
	[Token(Token = "0x60009DB")]
	public void set_screenSizeOverride(Vector4 value) { }

	[Address(RVA = "0x1E523B0", Offset = "0x1E517B0", Length = "0x4")]
	[Token(Token = "0x60009D3")]
	public void set_stopNaN(bool value) { }

	[Address(RVA = "0x2DFCA10", Offset = "0x2DFBE10", Length = "0x4")]
	[Token(Token = "0x60009D9")]
	public void set_useScreenCoordOverride(bool value) { }

	[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
	[Token(Token = "0x60009C1")]
	internal void set_volumeFrameworkUpdateMode(VolumeFrameworkUpdateMode value) { }

	[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
	[Token(Token = "0x60009BD")]
	public void set_volumeLayerMask(LayerMask value) { }

	[Address(RVA = "0x2DFCA20", Offset = "0x2DFBE20", Length = "0x17F")]
	[Token(Token = "0x60009C4")]
	public void set_volumeStack(VolumeStack value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x60009BF")]
	public void set_volumeTrigger(Transform value) { }

	[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
	[Token(Token = "0x60009BB")]
	public void SetRenderer(int index) { }

	[Address(RVA = "0x2DFBBE0", Offset = "0x2DFAFE0", Length = "0x34")]
	[Token(Token = "0x60009AA")]
	private void Start() { }

	[Address(RVA = "0x2DFBC20", Offset = "0x2DFB020", Length = "0x3F")]
	[Token(Token = "0x60009E5")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	[Address(RVA = "0x2DFBC60", Offset = "0x2DFB060", Length = "0x14")]
	[Token(Token = "0x60009E4")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	[Address(RVA = "0x2DFBC80", Offset = "0x2DFB080", Length = "0x2D0")]
	[Token(Token = "0x60009B4")]
	internal void UpdateCameraStack() { }

}

