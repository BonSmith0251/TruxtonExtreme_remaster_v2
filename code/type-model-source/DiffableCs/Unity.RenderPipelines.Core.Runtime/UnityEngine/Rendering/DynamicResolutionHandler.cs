namespace UnityEngine.Rendering;

[Token(Token = "0x2000047")]
public class DynamicResolutionHandler
{
	[Token(Token = "0x2000048")]
	private struct ScalerContainer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000102")]
		public DynamicResScalePolicyType type; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000103")]
		public PerformDynamicRes method; //Field offset: 0x8

	}

	[Token(Token = "0x2000049")]
	internal enum UpsamplerScheduleType : int
	{
		BeforePost = 0,
		AfterDepthOfField = 1,
		AfterPost = 2,
	}

	[Token(Token = "0x40000F8")]
	private const int CameraDictionaryMaxcCapacity = 32; //Field offset: 0x0
	[Token(Token = "0x40000F0")]
	private static DynamicResScalerSlot s_ActiveScalerSlot; //Field offset: 0x0
	[Token(Token = "0x40000F1")]
	private static ScalerContainer[] s_ScalerContainers; //Field offset: 0x8
	[Token(Token = "0x40000F4")]
	private static Dictionary<Int32, DynamicResUpscaleFilter> s_CameraUpscaleFilters; //Field offset: 0x10
	[Token(Token = "0x40000FA")]
	private static Dictionary<Int32, DynamicResolutionHandler> s_CameraInstances; //Field offset: 0x18
	[Token(Token = "0x40000FB")]
	private static DynamicResolutionHandler s_DefaultInstance; //Field offset: 0x20
	[Token(Token = "0x40000FC")]
	private static int s_ActiveCameraId; //Field offset: 0x28
	[Token(Token = "0x40000FD")]
	private static DynamicResolutionHandler s_ActiveInstance; //Field offset: 0x30
	[Token(Token = "0x40000FE")]
	private static bool s_ActiveInstanceDirty; //Field offset: 0x38
	[Token(Token = "0x40000FF")]
	private static float s_GlobalHwFraction; //Field offset: 0x3C
	[Token(Token = "0x4000100")]
	private static bool s_GlobalHwUpresActive; //Field offset: 0x40
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000E3")]
	private bool m_Enabled; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x40000E4")]
	private bool m_UseMipBias; //Field offset: 0x11
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000E5")]
	private float m_MinScreenFraction; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000E6")]
	private float m_MaxScreenFraction; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000E7")]
	private float m_CurrentFraction; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000E8")]
	private bool m_ForcingRes; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x40000E9")]
	private bool m_CurrentCameraRequest; //Field offset: 0x21
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40000EA")]
	private float m_PrevFraction; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000EB")]
	private bool m_ForceSoftwareFallback; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x40000EC")]
	private bool m_RunUpscalerFilterOnFullResolution; //Field offset: 0x29
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40000ED")]
	private float m_PrevHWScaleWidth; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000EE")]
	private float m_PrevHWScaleHeight; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40000EF")]
	private Vector2Int m_LastScaledSize; //Field offset: 0x34
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40000F2")]
	private Vector2Int cachedOriginalSize; //Field offset: 0x3C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40000F3")]
	private DynamicResUpscaleFilter <filter>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000F5")]
	private Vector2Int <finalViewport>k__BackingField; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000F6")]
	private DynamicResolutionType type; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000F7")]
	private GlobalDynamicResolutionSettings m_CachedSettings; //Field offset: 0x58
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40000F9")]
	private WeakReference m_OwnerCameraWeakRef; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000101")]
	private UpsamplerScheduleType m_UpsamplerSchedule; //Field offset: 0xE8

	[Token(Token = "0x17000035")]
	public private DynamicResUpscaleFilter filter
	{
		[Address(RVA = "0x1CF2CF0", Offset = "0x1CF20F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60004E3")]
		 get { } //Length: 5
		[Address(RVA = "0x22BA530", Offset = "0x22B9930", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60004E4")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000036")]
	public Vector2Int finalViewport
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60004E5")]
		 get { } //Length: 5
		[Address(RVA = "0x2161FF0", Offset = "0x21613F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60004E6")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000038")]
	public bool forcingResolution
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x60004E9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700003A")]
	public static DynamicResolutionHandler instance
	{
		[Address(RVA = "0x2BC0D40", Offset = "0x2BC0140", Length = "0x4F")]
		[Token(Token = "0x60004EE")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000037")]
	public bool runUpscalerFilterOnFullResolution
	{
		[Address(RVA = "0x2BC0D90", Offset = "0x2BC0190", Length = "0x11")]
		[Token(Token = "0x60004E8")]
		 get { } //Length: 17
		[Address(RVA = "0x2707C90", Offset = "0x2707090", Length = "0x4")]
		[Token(Token = "0x60004E7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000039")]
	public UpsamplerScheduleType upsamplerSchedule
	{
		[Address(RVA = "0xE26980", Offset = "0xE25D80", Length = "0x7")]
		[Token(Token = "0x60004ED")]
		 get { } //Length: 7
		[Address(RVA = "0xE26DC0", Offset = "0xE261C0", Length = "0x7")]
		[Token(Token = "0x60004EC")]
		 set { } //Length: 7
	}

	[Address(RVA = "0x2BC0830", Offset = "0x2BBFC30", Length = "0x3FC")]
	[Token(Token = "0x6000508")]
	private static DynamicResolutionHandler() { }

	[Address(RVA = "0x2BC0C30", Offset = "0x2BC0030", Length = "0x110")]
	[Token(Token = "0x60004EF")]
	private DynamicResolutionHandler() { }

	[Address(RVA = "0x2BBECF0", Offset = "0x2BBE0F0", Length = "0x1A2")]
	[Token(Token = "0x6000502")]
	public Vector2Int ApplyScalesOnSize(Vector2Int size) { }

	[Address(RVA = "0x2BBEEA0", Offset = "0x2BBE2A0", Length = "0x14D")]
	[Token(Token = "0x6000503")]
	internal Vector2Int ApplyScalesOnSize(Vector2Int size, Vector2 scales) { }

	[Address(RVA = "0x2BBEFF0", Offset = "0x2BBE3F0", Length = "0x9F")]
	[Token(Token = "0x60004F3")]
	public float CalculateMipBias(Vector2Int inputResolution, Vector2Int outputResolution, bool forceApply = false) { }

	[Address(RVA = "0x2BBF090", Offset = "0x2BBE490", Length = "0x8E")]
	[Token(Token = "0x60004F7")]
	public static void ClearSelectedCamera() { }

	[Address(RVA = "0x21D6EB0", Offset = "0x21D62B0", Length = "0x9")]
	[Token(Token = "0x60004F0")]
	private static float DefaultDynamicResMethod() { }

	[Address(RVA = "0x2BBF120", Offset = "0x2BBE520", Length = "0x30")]
	[Token(Token = "0x60004FF")]
	public bool DynamicResolutionEnabled() { }

	[Address(RVA = "0x2BBF150", Offset = "0x2BBE550", Length = "0x15E")]
	[Token(Token = "0x60004EA")]
	private bool FlushScalableBufferManagerState() { }

	[Address(RVA = "0x2845AA0", Offset = "0x2844EA0", Length = "0x5")]
	[Token(Token = "0x6000500")]
	public void ForceSoftwareFallback() { }

	[Address(RVA = "0x1CF2CF0", Offset = "0x1CF20F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60004E3")]
	public DynamicResUpscaleFilter get_filter() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60004E5")]
	public Vector2Int get_finalViewport() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x60004E9")]
	public bool get_forcingResolution() { }

	[Address(RVA = "0x2BC0D40", Offset = "0x2BC0140", Length = "0x4F")]
	[Token(Token = "0x60004EE")]
	public static DynamicResolutionHandler get_instance() { }

	[Address(RVA = "0x2BC0D90", Offset = "0x2BC0190", Length = "0x11")]
	[Token(Token = "0x60004E8")]
	public bool get_runUpscalerFilterOnFullResolution() { }

	[Address(RVA = "0xE26980", Offset = "0xE25D80", Length = "0x7")]
	[Token(Token = "0x60004ED")]
	public UpsamplerScheduleType get_upsamplerSchedule() { }

	[Address(RVA = "0x2BBF2B0", Offset = "0x2BBE6B0", Length = "0x1B")]
	[Token(Token = "0x6000504")]
	public float GetCurrentScale() { }

	[Address(RVA = "0x2BBF2D0", Offset = "0x2BBE6D0", Length = "0x5")]
	[Token(Token = "0x6000505")]
	public Vector2Int GetLastScaledSize() { }

	[Address(RVA = "0x2BBF2E0", Offset = "0x2BBE6E0", Length = "0xC9")]
	[Token(Token = "0x6000507")]
	public float GetLowResMultiplier(float targetLowRes, float minimumThreshold) { }

	[Address(RVA = "0x2BBF3B0", Offset = "0x2BBE7B0", Length = "0xCE")]
	[Token(Token = "0x6000506")]
	public float GetLowResMultiplier(float targetLowRes) { }

	[Address(RVA = "0x2BBF480", Offset = "0x2BBE880", Length = "0x525")]
	[Token(Token = "0x60004EB")]
	private static DynamicResolutionHandler GetOrCreateDrsInstanceHandler(Camera camera) { }

	[Address(RVA = "0x2BBF9B0", Offset = "0x2BBEDB0", Length = "0x64")]
	[Token(Token = "0x60004F2")]
	public Vector2 GetResolvedScale() { }

	[Address(RVA = "0x2BBFA20", Offset = "0x2BBEE20", Length = "0x1B3")]
	[Token(Token = "0x6000501")]
	public Vector2Int GetScaledSize(Vector2Int size) { }

	[Address(RVA = "0x2BBFBE0", Offset = "0x2BBEFE0", Length = "0x1D")]
	[Token(Token = "0x60004FD")]
	public bool HardwareDynamicResIsEnabled() { }

	[Address(RVA = "0x2BBFC00", Offset = "0x2BBF000", Length = "0x26B")]
	[Token(Token = "0x60004F1")]
	private void ProcessSettings(GlobalDynamicResolutionSettings settings) { }

	[Address(RVA = "0x2BBFE70", Offset = "0x2BBF270", Length = "0x11")]
	[Token(Token = "0x60004FE")]
	public bool RequestsHardwareDynamicResolution() { }

	[Address(RVA = "0x2BBFE90", Offset = "0x2BBF290", Length = "0x4C")]
	[Token(Token = "0x60004E2")]
	private void Reset() { }

	[Address(RVA = "0x22BA530", Offset = "0x22B9930", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60004E4")]
	private void set_filter(DynamicResUpscaleFilter value) { }

	[Address(RVA = "0x2161FF0", Offset = "0x21613F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60004E6")]
	public void set_finalViewport(Vector2Int value) { }

	[Address(RVA = "0x2707C90", Offset = "0x2707090", Length = "0x4")]
	[Token(Token = "0x60004E7")]
	public void set_runUpscalerFilterOnFullResolution(bool value) { }

	[Address(RVA = "0xE26DC0", Offset = "0xE261C0", Length = "0x7")]
	[Token(Token = "0x60004EC")]
	public void set_upsamplerSchedule(UpsamplerScheduleType value) { }

	[Address(RVA = "0x2BBFEE0", Offset = "0x2BBF2E0", Length = "0x52")]
	[Token(Token = "0x60004F6")]
	public static void SetActiveDynamicScalerSlot(DynamicResScalerSlot slot) { }

	[Address(RVA = "0x1EA5240", Offset = "0x1EA4640", Length = "0x4")]
	[Token(Token = "0x60004F9")]
	public void SetCurrentCameraRequest(bool cameraRequest) { }

	[Address(RVA = "0x2BBFF40", Offset = "0x2BBF340", Length = "0xBA")]
	[Token(Token = "0x60004F4")]
	public static void SetDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = 1) { }

	[Address(RVA = "0x2BC0000", Offset = "0x2BBF400", Length = "0xBA")]
	[Token(Token = "0x60004F5")]
	public static void SetSystemDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = 1) { }

	[Address(RVA = "0x2BC00C0", Offset = "0x2BBF4C0", Length = "0x13B")]
	[Token(Token = "0x60004F8")]
	public static void SetUpscaleFilter(Camera camera, DynamicResUpscaleFilter filter) { }

	[Address(RVA = "0x2BC0200", Offset = "0x2BBF600", Length = "0x3C")]
	[Token(Token = "0x60004FC")]
	public bool SoftwareDynamicResIsEnabled() { }

	[Address(RVA = "0x2BC0510", Offset = "0x2BBF910", Length = "0x31E")]
	[Token(Token = "0x60004FB")]
	public void Update(GlobalDynamicResolutionSettings settings, Action OnResolutionChange = null) { }

	[Address(RVA = "0x2BC0240", Offset = "0x2BBF640", Length = "0x2C2")]
	[Token(Token = "0x60004FA")]
	public static void UpdateAndUseCamera(Camera camera, Nullable<GlobalDynamicResolutionSettings> settings = null, Action OnResolutionChange = null) { }

}

