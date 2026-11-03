namespace Unity.Cinemachine;

[Token(Token = "0x2000081")]
internal static class CameraUpdateManager
{
	[Token(Token = "0x2000083")]
	internal enum UpdateFilter : int
	{
		Fixed = 1,
		Late = 2,
		Smart = 8,
		SmartFixed = 9,
		SmartLate = 10,
	}

	[Token(Token = "0x2000082")]
	private class UpdateStatus
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000234")]
		public int lastUpdateFrame; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000235")]
		public int lastUpdateFixedFrame; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000236")]
		public UpdateClock lastUpdateMode; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600029A")]
		public UpdateStatus() { }

	}

	[Token(Token = "0x400022C")]
	private static readonly VirtualCameraRegistry s_CameraRegistry; //Field offset: 0x0
	[Token(Token = "0x400022D")]
	private static int s_RoundRobinIndex; //Field offset: 0x8
	[Token(Token = "0x400022E")]
	private static int s_RoundRobinSubIndex; //Field offset: 0xC
	[Token(Token = "0x400022F")]
	private static object s_LastFixedUpdateContext; //Field offset: 0x10
	[Token(Token = "0x4000230")]
	private static float s_LastUpdateTime; //Field offset: 0x18
	[Token(Token = "0x4000231")]
	private static int s_FixedFrameCount; //Field offset: 0x1C
	[Token(Token = "0x4000232")]
	private static Dictionary<CinemachineVirtualCameraBase, UpdateStatus> s_UpdateStatus; //Field offset: 0x20
	[Token(Token = "0x4000233")]
	public static UpdateFilter s_CurrentUpdateFilter; //Field offset: 0x28

	[Token(Token = "0x17000085")]
	public static int VirtualCameraCount
	{
		[Address(RVA = "0x283A7B0", Offset = "0x2839BB0", Length = "0x5E")]
		[Token(Token = "0x600028D")]
		 get { } //Length: 94
	}

	[Address(RVA = "0x283A6F0", Offset = "0x2839AF0", Length = "0xBA")]
	[Token(Token = "0x6000299")]
	private static CameraUpdateManager() { }

	[Address(RVA = "0x28394A0", Offset = "0x28388A0", Length = "0x68")]
	[Token(Token = "0x600028F")]
	public static void AddActiveCamera(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x2839510", Offset = "0x2838910", Length = "0x115")]
	[Token(Token = "0x6000291")]
	public static void CameraDestroyed(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x2839630", Offset = "0x2838A30", Length = "0x68")]
	[Token(Token = "0x6000293")]
	public static void CameraDisabled(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x28396A0", Offset = "0x2838AA0", Length = "0x68")]
	[Token(Token = "0x6000292")]
	public static void CameraEnabled(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x2839710", Offset = "0x2838B10", Length = "0x96")]
	[Token(Token = "0x6000294")]
	public static void ForgetContext(object context) { }

	[Address(RVA = "0x283A7B0", Offset = "0x2839BB0", Length = "0x5E")]
	[Token(Token = "0x600028D")]
	public static int get_VirtualCameraCount() { }

	[Address(RVA = "0x28397B0", Offset = "0x2838BB0", Length = "0x146")]
	[Token(Token = "0x6000297")]
	private static Transform GetUpdateTarget(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x2839900", Offset = "0x2838D00", Length = "0xC4")]
	[Token(Token = "0x6000298")]
	public static UpdateClock GetVcamUpdateStatus(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x28399D0", Offset = "0x2838DD0", Length = "0x66")]
	[Token(Token = "0x600028E")]
	public static CinemachineVirtualCameraBase GetVirtualCamera(int index) { }

	[Address(RVA = "0x2839A40", Offset = "0x2838E40", Length = "0x9E")]
	[RuntimeInitializeOnLoadMethod]
	[Token(Token = "0x600028C")]
	private static void InitializeModule() { }

	[Address(RVA = "0x2839AE0", Offset = "0x2838EE0", Length = "0x68")]
	[Token(Token = "0x6000290")]
	public static void RemoveActiveCamera(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x2839B50", Offset = "0x2838F50", Length = "0x5E4")]
	[Token(Token = "0x6000295")]
	public static void UpdateAllActiveVirtualCameras(uint channelMask, Vector3 worldUp, float deltaTime, object context) { }

	[Address(RVA = "0x283A140", Offset = "0x2839540", Length = "0x5AA")]
	[Token(Token = "0x6000296")]
	public static void UpdateVirtualCamera(CinemachineVirtualCameraBase vcam, Vector3 worldUp, float deltaTime) { }

}

