namespace NVIDIA;

[AddComponentMenu("NVIDIA/Reflex")]
[Token(Token = "0x2000004")]
public class Reflex : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x200000A")]
	private sealed class <SleepCoroutine>d__21 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000BE")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000BF")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000C0")]
		public Reflex <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000001")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000021")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000002")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000023")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600001E")]
		public <SleepCoroutine>d__21(int <>1__state) { }

		[Address(RVA = "0x5D6CD0", Offset = "0x5D60D0", Length = "0x31A")]
		[Token(Token = "0x6000020")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000021")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000023")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x5D6FF0", Offset = "0x5D63F0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000022")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600001F")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000007")]
	internal struct NvReflex_FrameReport
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AE")]
		public ulong frameID; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000AF")]
		public ulong inputSampleTime; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000B0")]
		public ulong simStartTime; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000B1")]
		public ulong simEndTime; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000B2")]
		public ulong renderSubmitStartTime; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000B3")]
		public ulong renderSubmitEndTime; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000B4")]
		public ulong presentStartTime; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000B5")]
		public ulong presentEndTime; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000B6")]
		public ulong driverStartTime; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40000B7")]
		public ulong driverEndTime; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40000B8")]
		public ulong osRenderQueueStartTime; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40000B9")]
		public ulong osRenderQueueEndTime; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40000BA")]
		public ulong gpuRenderStartTime; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40000BB")]
		public ulong gpuRenderEndTime; //Field offset: 0x68

	}

	[Token(Token = "0x2000009")]
	internal struct NvReflex_GET_SLEEP_STATUS_PARAMS
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000BD")]
		public byte bLowLatencyMode; //Field offset: 0x0

	}

	[Token(Token = "0x2000005")]
	internal enum NvReflex_LATENCY_MARKER_TYPE : int
	{
		SIMULATION_START = 0,
		SIMULATION_END = 1,
		RENDERSUBMIT_START = 2,
		RENDERSUBMIT_END = 3,
		PRESENT_START = 4,
		PRESENT_END = 5,
		INPUT_SAMPLE = 6,
		TRIGGER_FLASH = 7,
		PC_LATENCY_PING = 8,
	}

	[Token(Token = "0x2000008")]
	internal struct NvReflex_LATENCY_RESULT_PARAMS
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000BC")]
		public NvReflex_FrameReport[] frameReport; //Field offset: 0x0

	}

	[Token(Token = "0x2000006")]
	internal enum NvReflex_Status : int
	{
		NvReflex_OK = 0,
		NvReflex_ERROR = -1,
		NvReflex_LIBRARY_NOT_FOUND = -2,
		NvReflex_NO_IMPLEMENTATION = -3,
		NvReflex_API_NOT_INITIALIZED = -4,
		NvReflex_INVALID_ARGUMENT = -5,
		NvReflex_NVIDIA_DEVICE_NOT_FOUND = -6,
		NvReflex_END_ENUMERATION = -7,
		NvReflex_INVALID_HANDLE = -8,
		NvReflex_INCOMPATIBLE_STRUCT_VERSION = -9,
		NvReflex_HANDLE_INVALIDATED = -10,
		NvReflex_OPENGL_CONTEXT_NOT_CURRENT = -11,
		NvReflex_INVALID_POINTER = -14,
		NvReflex_NO_GL_EXPERT = -12,
		NvReflex_INSTRUMENTATION_DISABLED = -13,
		NvReflex_NO_GL_NSIGHT = -15,
		NvReflex_EXPECTED_LOGICAL_GPU_HANDLE = -100,
		NvReflex_EXPECTED_PHYSICAL_GPU_HANDLE = -101,
		NvReflex_EXPECTED_DISPLAY_HANDLE = -102,
		NvReflex_INVALID_COMBINATION = -103,
		NvReflex_NOT_SUPPORTED = -104,
		NvReflex_PORTID_NOT_FOUND = -105,
		NvReflex_EXPECTED_UNATTACHED_DISPLAY_HANDLE = -106,
		NvReflex_INVALID_PERF_LEVEL = -107,
		NvReflex_DEVICE_BUSY = -108,
		NvReflex_NV_PERSIST_FILE_NOT_FOUND = -109,
		NvReflex_PERSIST_DATA_NOT_FOUND = -110,
		NvReflex_EXPECTED_TV_DISPLAY = -111,
		NvReflex_EXPECTED_TV_DISPLAY_ON_DCONNECTOR = -112,
		NvReflex_NO_ACTIVE_SLI_TOPOLOGY = -113,
		NvReflex_SLI_RENDERING_MODE_NOTALLOWED = -114,
		NvReflex_EXPECTED_DIGITAL_FLAT_PANEL = -115,
		NvReflex_ARGUMENT_EXCEED_MAX_SIZE = -116,
		NvReflex_DEVICE_SWITCHING_NOT_ALLOWED = -117,
		NvReflex_TESTING_CLOCKS_NOT_SUPPORTED = -118,
		NvReflex_UNKNOWN_UNDERSCAN_CONFIG = -119,
		NvReflex_TIMEOUT_RECONFIGURING_GPU_TOPO = -120,
		NvReflex_DATA_NOT_FOUND = -121,
		NvReflex_EXPECTED_ANALOG_DISPLAY = -122,
		NvReflex_NO_VIDLINK = -123,
		NvReflex_REQUIRES_REBOOT = -124,
		NvReflex_INVALID_HYBRID_MODE = -125,
		NvReflex_MIXED_TARGET_TYPES = -126,
		NvReflex_SYSWOW64_NOT_SUPPORTED = -127,
		NvReflex_IMPLICIT_SET_GPU_TOPOLOGY_CHANGE_NOT_ALLOWED = -128,
		NvReflex_REQUEST_USER_TO_CLOSE_NON_MIGRATABLE_APPS = -129,
		NvReflex_OUT_OF_MEMORY = -130,
		NvReflex_WAS_STILL_DRAWING = -131,
		NvReflex_FILE_NOT_FOUND = -132,
		NvReflex_TOO_MANY_UNIQUE_STATE_OBJECTS = -133,
		NvReflex_INVALID_CALL = -134,
		NvReflex_D3D10_1_LIBRARY_NOT_FOUND = -135,
		NvReflex_FUNCTION_NOT_FOUND = -136,
		NvReflex_INVALID_USER_PRIVILEGE = -137,
		NvReflex_EXPECTED_NON_PRIMARY_DISPLAY_HANDLE = -138,
		NvReflex_EXPECTED_COMPUTE_GPU_HANDLE = -139,
		NvReflex_STEREO_NOT_INITIALIZED = -140,
		NvReflex_STEREO_REGISTRY_ACCESS_FAILED = -141,
		NvReflex_STEREO_REGISTRY_PROFILE_TYPE_NOT_SUPPORTED = -142,
		NvReflex_STEREO_REGISTRY_VALUE_NOT_SUPPORTED = -143,
		NvReflex_STEREO_NOT_ENABLED = -144,
		NvReflex_STEREO_NOT_TURNED_ON = -145,
		NvReflex_STEREO_INVALID_DEVICE_INTERFACE = -146,
		NvReflex_STEREO_PARAMETER_OUT_OF_RANGE = -147,
		NvReflex_STEREO_FRUSTUM_ADJUST_MODE_NOT_SUPPORTED = -148,
		NvReflex_TOPO_NOT_POSSIBLE = -149,
		NvReflex_MODE_CHANGE_FAILED = -150,
		NvReflex_D3D11_LIBRARY_NOT_FOUND = -151,
		NvReflex_INVALID_ADDRESS = -152,
		NvReflex_STRING_TOO_SMALL = -153,
		NvReflex_MATCHING_DEVICE_NOT_FOUND = -154,
		NvReflex_DRIVER_RUNNING = -155,
		NvReflex_DRIVER_NOTRUNNING = -156,
		NvReflex_ERROR_DRIVER_RELOAD_REQUIRED = -157,
		NvReflex_SET_NOT_ALLOWED = -158,
		NvReflex_ADVANCED_DISPLAY_TOPOLOGY_REQUIRED = -159,
		NvReflex_SETTING_NOT_FOUND = -160,
		NvReflex_SETTING_SIZE_TOO_LARGE = -161,
		NvReflex_TOO_MANY_SETTINGS_IN_PROFILE = -162,
		NvReflex_PROFILE_NOT_FOUND = -163,
		NvReflex_PROFILE_NAME_IN_USE = -164,
		NvReflex_PROFILE_NAME_EMPTY = -165,
		NvReflex_EXECUTABLE_NOT_FOUND = -166,
		NvReflex_EXECUTABLE_ALREADY_IN_USE = -167,
		NvReflex_DATATYPE_MISMATCH = -168,
		NvReflex_PROFILE_REMOVED = -169,
		NvReflex_UNREGISTERED_RESOURCE = -170,
		NvReflex_ID_OUT_OF_RANGE = -171,
		NvReflex_DISPLAYCONFIG_VALIDATION_FAILED = -172,
		NvReflex_DPMST_CHANGED = -173,
		NvReflex_INSUFFICIENT_BUFFER = -174,
		NvReflex_ACCESS_DENIED = -175,
		NvReflex_MOSAIC_NOT_ACTIVE = -176,
		NvReflex_SHARE_RESOURCE_RELOCATED = -177,
		NvReflex_REQUEST_USER_TO_DISABLE_DWM = -178,
		NvReflex_D3D_DEVICE_LOST = -179,
		NvReflex_INVALID_CONFIGURATION = -180,
		NvReflex_STEREO_HANDSHAKE_NOT_DONE = -181,
		NvReflex_EXECUTABLE_PATH_IS_AMBIGUOUS = -182,
		NvReflex_DEFAULT_STEREO_PROFILE_IS_NOT_DEFINED = -183,
		NvReflex_DEFAULT_STEREO_PROFILE_DOES_NOT_EXIST = -184,
		NvReflex_CLUSTER_ALREADY_EXISTS = -185,
		NvReflex_DPMST_DISPLAY_ID_EXPECTED = -186,
		NvReflex_INVALID_DISPLAY_ID = -187,
		NvReflex_STREAM_IS_OUT_OF_SYNC = -188,
		NvReflex_INCOMPATIBLE_AUDIO_DRIVER = -189,
		NvReflex_VALUE_ALREADY_SET = -190,
		NvReflex_TIMEOUT = -191,
		NvReflex_GPU_WORKSTATION_FEATURE_INCOMPLETE = -192,
		NvReflex_STEREO_INIT_ACTIVATION_NOT_DONE = -193,
		NvReflex_SYNC_NOT_ACTIVE = -194,
		NvReflex_SYNC_MASTER_NOT_FOUND = -195,
		NvReflex_INVALID_SYNC_TOPOLOGY = -196,
		NvReflex_ECID_SIGN_ALGO_UNSUPPORTED = -197,
		NvReflex_ECID_KEY_VERIFICATION_FAILED = -198,
		NvReflex_FIRMWARE_OUT_OF_DATE = -199,
		NvReflex_FIRMWARE_REVISION_NOT_SUPPORTED = -200,
		NvReflex_LICENSE_CALLER_AUTHENTICATION_FAILED = -201,
		NvReflex_D3D_DEVICE_NOT_REGISTERED = -202,
		NvReflex_RESOURCE_NOT_ACQUIRED = -203,
		NvReflex_TIMING_NOT_SUPPORTED = -204,
		NvReflex_HDCP_ENCRYPTION_FAILED = -205,
		NvReflex_PCLK_LIMITATION_FAILED = -206,
		NvReflex_NO_CONNECTOR_FOUND = -207,
		NvReflex_HDCP_DISABLED = -208,
		NvReflex_API_IN_USE = -209,
		NvReflex_NVIDIA_DISPLAY_NOT_FOUND = -210,
		NvReflex_PRIV_SEC_VIOLATION = -211,
		NvReflex_INCORRECT_VENDOR = -212,
		NvReflex_DISPLAY_IN_USE = -213,
		NvReflex_UNSUPPORTED_CONFIG_NON_HDCP_HMD = -214,
		NvReflex_MAX_DISPLAY_LIMIT_REACHED = -215,
		NvReflex_INVALID_DIRECT_MODE_DISPLAY = -216,
		NvReflex_GPU_IN_DEBUG_MODE = -217,
		NvReflex_D3D_CONTEXT_NOT_FOUND = -218,
		NvReflex_STEREO_VERSION_MISMATCH = -219,
		NvReflex_GPU_NOT_POWERED = -220,
		NvReflex_ERROR_DRIVER_RELOAD_IN_PROGRESS = -221,
		NvReflex_WAIT_FOR_HW_RESOURCE = -222,
		NvReflex_REQUIRE_FURTHER_HDCP_ACTION = -223,
		NvReflex_DISPLAY_MUX_TRANSITION_FAILED = -224,
	}

	[Token(Token = "0x400000E")]
	private static uint previousIntervalUs; //Field offset: 0x0
	[Token(Token = "0x400000F")]
	private static bool previousIsLowLatencyMode; //Field offset: 0x4
	[Token(Token = "0x4000010")]
	private static bool previousIsLowLatencyBoost; //Field offset: 0x5
	[Token(Token = "0x4000011")]
	private static bool previousUseMarkersToOptimize; //Field offset: 0x6
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000006")]
	[Tooltip("Is this the first camera to be rendered")]
	public bool isFirstCamera; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x4000007")]
	private bool isAttachedBeforeRender; //Field offset: 0x21
	[FieldOffset(Offset = "0x22")]
	[Token(Token = "0x4000008")]
	[Tooltip("Is this the last camera to be rendered")]
	public bool isLastCamera; //Field offset: 0x22
	[FieldOffset(Offset = "0x23")]
	[Token(Token = "0x4000009")]
	private bool isAttachedAfterRender; //Field offset: 0x23
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400000A")]
	[Tooltip("Minimum interval in microseconds for frame synchronization. 0 = no frame rate limit")]
	public uint intervalUs; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400000B")]
	[Tooltip("NVIDIA Reflex Low Latency mode.")]
	public bool isLowLatencyMode; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x400000C")]
	[Tooltip("NVIDIA Reflex Low Latency Boost")]
	public bool isLowLatencyBoost; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x400000D")]
	[Tooltip("NVIDIA Reflex Low Latency Boost")]
	public bool useMarkersToOptimize; //Field offset: 0x2A
	[FieldOffset(Offset = "0x2B")]
	[Token(Token = "0x4000012")]
	private bool hasSimulationStarted; //Field offset: 0x2B
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000013")]
	private CommandBuffer renderSubmitStart_CommandBuffer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000014")]
	private CommandBuffer renderSubmitEnd_CommandBuffer; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000015")]
	public bool isIgnored; //Field offset: 0x40

	[Address(RVA = "0x5D6C40", Offset = "0x5D6040", Length = "0x6F")]
	[Token(Token = "0x600001D")]
	private static Reflex() { }

	[Address(RVA = "0x5D6CB0", Offset = "0x5D60B0", Length = "0x13")]
	[Token(Token = "0x600001C")]
	public Reflex() { }

	[Address(RVA = "0x5D5A50", Offset = "0x5D4E50", Length = "0x6B")]
	[Token(Token = "0x6000008")]
	private void AfterPresent() { }

	[Address(RVA = "0x5D5AC0", Offset = "0x5D4EC0", Length = "0x150")]
	[Token(Token = "0x600000B")]
	private void AttachDetachCommandBuffers() { }

	[Address(RVA = "0x5D5C10", Offset = "0x5D5010", Length = "0x7D")]
	[Token(Token = "0x6000009")]
	public void FixedUpdate() { }

	[Address(RVA = "0x5D5C90", Offset = "0x5D5090", Length = "0xF0")]
	[Token(Token = "0x6000012")]
	public static NvReflex_Status IsAutomaticReflexAnalyzerSupported() { }

	[Address(RVA = "0x5D5D80", Offset = "0x5D5180", Length = "0x178")]
	[Token(Token = "0x6000011")]
	public static NvReflex_Status IsReflexLowLatencySupported() { }

	[Address(RVA = "0x5D5F00", Offset = "0x5D5300", Length = "0x384")]
	[Token(Token = "0x600000E")]
	private void LateUpdate() { }

	[Address(RVA = "0x5D6290", Offset = "0x5D5690", Length = "0x71")]
	[Token(Token = "0x600001B")]
	public static NvReflex_Status NvReflex_Plugin_GetDriverVersion(out uint ver) { }

	[Address(RVA = "0x5D6310", Offset = "0x5D5710", Length = "0x6F")]
	[Token(Token = "0x6000018")]
	public static int NvReflex_Plugin_GetEventIDForEvent(int inEvent) { }

	[Address(RVA = "0x5D6380", Offset = "0x5D5780", Length = "0xD6")]
	[Token(Token = "0x6000016")]
	public static NvReflex_Status NvReflex_Plugin_GetLatency(out NvReflex_LATENCY_RESULT_PARAMS markers) { }

	[Address(RVA = "0x5D6460", Offset = "0x5D5860", Length = "0x65")]
	[Token(Token = "0x6000019")]
	public static IntPtr NvReflex_Plugin_GetRenderEventAndDataFunc() { }

	[Address(RVA = "0x5D64D0", Offset = "0x5D58D0", Length = "0x71")]
	[Token(Token = "0x6000017")]
	public static NvReflex_Status NvReflex_Plugin_GetSleepStatus(out NvReflex_GET_SLEEP_STATUS_PARAMS sleepStatusParams) { }

	[Address(RVA = "0x5D6550", Offset = "0x5D5950", Length = "0x6A")]
	[Token(Token = "0x600001A")]
	public static bool NvReflex_Plugin_HasReceivedRenderEvent() { }

	[Address(RVA = "0x5D65C0", Offset = "0x5D59C0", Length = "0x7A")]
	[Token(Token = "0x6000015")]
	public static NvReflex_Status NvReflex_Plugin_SetLatencyMarker(NvReflex_LATENCY_MARKER_TYPE marker, ulong frameID) { }

	[Address(RVA = "0x5D6640", Offset = "0x5D5A40", Length = "0x99")]
	[Token(Token = "0x6000013")]
	public static NvReflex_Status NvReflex_Plugin_SetSleepMode(bool lowLatencyMode, uint minimumIntervalUs, bool lowLatencyBoost, bool markersOptimzation) { }

	[Address(RVA = "0x5D66E0", Offset = "0x5D5AE0", Length = "0x65")]
	[Token(Token = "0x6000014")]
	public static NvReflex_Status NvReflex_Plugin_Sleep() { }

	[Address(RVA = "0x5D6750", Offset = "0x5D5B50", Length = "0x58")]
	[Token(Token = "0x6000006")]
	private void OnBeginFrameRendering(ScriptableRenderContext context, List<Camera> camera) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000005")]
	private void OnDestroy() { }

	[Address(RVA = "0x5D67B0", Offset = "0x5D5BB0", Length = "0x78")]
	[Token(Token = "0x600000D")]
	private void OnDisable() { }

	[Address(RVA = "0x5D6830", Offset = "0x5D5C30", Length = "0x78")]
	[Token(Token = "0x600000C")]
	private void OnEnable() { }

	[Address(RVA = "0x5D68B0", Offset = "0x5D5CB0", Length = "0x64")]
	[Token(Token = "0x6000007")]
	private void OnEndFrameRendering(ScriptableRenderContext context, List<Camera> camera) { }

	[Address(RVA = "0x5D6920", Offset = "0x5D5D20", Length = "0x87")]
	[Token(Token = "0x6000010")]
	public static void PCLatencyPing() { }

	[Address(RVA = "0x5D69B0", Offset = "0x5D5DB0", Length = "0x67")]
	[IteratorStateMachine(typeof(<SleepCoroutine>d__21))]
	[Token(Token = "0x6000003")]
	private IEnumerator SleepCoroutine() { }

	[Address(RVA = "0x5D6A20", Offset = "0x5D5E20", Length = "0xD2")]
	[Token(Token = "0x6000004")]
	private void Start() { }

	[Address(RVA = "0x5D6B00", Offset = "0x5D5F00", Length = "0x87")]
	[Token(Token = "0x600000F")]
	public static void TriggerFlash() { }

	[Address(RVA = "0x5D6B90", Offset = "0x5D5F90", Length = "0xAC")]
	[Token(Token = "0x600000A")]
	public void Update() { }

}

