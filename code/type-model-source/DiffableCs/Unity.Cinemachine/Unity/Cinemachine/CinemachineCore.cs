namespace Unity.Cinemachine;

[Token(Token = "0x2000090")]
public static class CinemachineCore
{
	[CompilerGenerated]
	[Token(Token = "0x200009A")]
	private sealed class <>c
	{
		[Token(Token = "0x4000283")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x284DAD0", Offset = "0x284CED0", Length = "0x67")]
		[Token(Token = "0x6000312")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000313")]
		public <>c() { }

		[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
		[Token(Token = "0x6000314")]
		internal float <.cctor>b__46_0(string <p0>) { }

	}

	[Token(Token = "0x2000093")]
	internal sealed class AxisInputDelegate : MulticastDelegate
	{

		[Address(RVA = "0x10DF2A0", Offset = "0x10DE6A0", Length = "0xB4")]
		[Token(Token = "0x6000303")]
		public AxisInputDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6A0", Offset = "0x5BBAA0", Length = "0x21")]
		[Token(Token = "0x6000305")]
		public override IAsyncResult BeginInvoke(string axisName, AsyncCallback callback, object object) { }

		[Address(RVA = "0x64F590", Offset = "0x64E990", Length = "0x29")]
		[Token(Token = "0x6000306")]
		public override float EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6000304")]
		public override float Invoke(string axisName) { }

	}

	[Token(Token = "0x2000099")]
	internal class BlendEvent : UnityEvent<BlendEventParams>
	{

		[Address(RVA = "0x2834E00", Offset = "0x2834200", Length = "0x39")]
		[Token(Token = "0x6000311")]
		public BlendEvent() { }

	}

	[Token(Token = "0x2000098")]
	internal struct BlendEventParams
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000281")]
		public ICinemachineMixer Origin; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000282")]
		public CinemachineBlend Blend; //Field offset: 0x8

	}

	[Flags]
	[Token(Token = "0x2000092")]
	internal enum BlendHints : int
	{
		SphericalPosition = 1,
		CylindricalPosition = 2,
		ScreenSpaceAimWhenTargetsDiffer = 4,
		InheritPosition = 8,
		IgnoreTarget = 16,
		FreezeWhenBlendingOut = 32,
	}

	[Token(Token = "0x2000097")]
	internal class BrainEvent : UnityEvent<CinemachineBrain>
	{

		[Address(RVA = "0x2834E40", Offset = "0x2834240", Length = "0x39")]
		[Token(Token = "0x6000310")]
		public BrainEvent() { }

	}

	[Token(Token = "0x2000096")]
	internal class CameraEvent : UnityEvent<ICinemachineMixer, ICinemachineCamera>
	{

		[Address(RVA = "0x2834E80", Offset = "0x2834280", Length = "0x39")]
		[Token(Token = "0x600030F")]
		public CameraEvent() { }

	}

	[Token(Token = "0x2000094")]
	internal sealed class GetBlendOverrideDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2845780", Offset = "0x2844B80", Length = "0x125")]
		[Token(Token = "0x6000307")]
		public GetBlendOverrideDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x2845670", Offset = "0x2844A70", Length = "0xAB")]
		[Token(Token = "0x6000309")]
		public override IAsyncResult BeginInvoke(ICinemachineCamera fromVcam, ICinemachineCamera toVcam, CinemachineBlendDefinition defaultBlend, object owner, AsyncCallback callback, object object) { }

		[Address(RVA = "0x17C9A40", Offset = "0x17C8E40", Length = "0x34")]
		[Token(Token = "0x600030A")]
		public override CinemachineBlendDefinition EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x2845720", Offset = "0x2844B20", Length = "0x58")]
		[Token(Token = "0x6000308")]
		public override CinemachineBlendDefinition Invoke(ICinemachineCamera fromVcam, ICinemachineCamera toVcam, CinemachineBlendDefinition defaultBlend, object owner) { }

	}

	[Token(Token = "0x2000095")]
	internal sealed class GetCustomBlenderDelegate : MulticastDelegate
	{

		[Address(RVA = "0xD0F0A0", Offset = "0xD0E4A0", Length = "0x125")]
		[Token(Token = "0x600030B")]
		public GetCustomBlenderDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x639C50", Offset = "0x639050", Length = "0x31")]
		[Token(Token = "0x600030D")]
		public override IAsyncResult BeginInvoke(ICinemachineCamera fromCam, ICinemachineCamera toCam, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600030E")]
		public override IBlender EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x600030C")]
		public override IBlender Invoke(ICinemachineCamera fromCam, ICinemachineCamera toCam) { }

	}

	[Token(Token = "0x2000091")]
	internal enum Stage : int
	{
		Body = 0,
		Aim = 1,
		Noise = 2,
		Finalize = 3,
	}

	[Token(Token = "0x4000265")]
	internal const int kStreamingVersion = 20241001; //Field offset: 0x0
	[Token(Token = "0x4000266")]
	public const string kPackageRoot = "Packages/com.unity.cinemachine"; //Field offset: 0x0
	[Token(Token = "0x4000267")]
	internal static float CurrentUnscaledTimeTimeOverride; //Field offset: 0x0
	[Token(Token = "0x4000268")]
	internal static bool UnitTestMode; //Field offset: 0x4
	[Token(Token = "0x4000269")]
	public static AxisInputDelegate GetInputAxis; //Field offset: 0x8
	[Token(Token = "0x400026A")]
	public static float UniformDeltaTimeOverride; //Field offset: 0x10
	[Token(Token = "0x400026B")]
	public static float CurrentTimeOverride; //Field offset: 0x14
	[CompilerGenerated]
	[Token(Token = "0x400026C")]
	private static int <CurrentUpdateFrame>k__BackingField; //Field offset: 0x18
	[Token(Token = "0x400026D")]
	public static GetBlendOverrideDelegate GetBlendOverride; //Field offset: 0x20
	[Token(Token = "0x400026E")]
	public static GetCustomBlenderDelegate GetCustomBlender; //Field offset: 0x28
	[Token(Token = "0x400026F")]
	public static BrainEvent CameraUpdatedEvent; //Field offset: 0x30
	[Token(Token = "0x4000270")]
	public static ActivationEvent CameraActivatedEvent; //Field offset: 0x38
	[Token(Token = "0x4000271")]
	public static CameraEvent CameraDeactivatedEvent; //Field offset: 0x40
	[Token(Token = "0x4000272")]
	public static BlendEvent BlendCreatedEvent; //Field offset: 0x48
	[Token(Token = "0x4000273")]
	public static CameraEvent BlendFinishedEvent; //Field offset: 0x50
	[Token(Token = "0x4000274")]
	private static ICinemachineCamera s_SoloCamera; //Field offset: 0x58

	[Token(Token = "0x170000AD")]
	public static float CurrentTime
	{
		[Address(RVA = "0x283F2A0", Offset = "0x283E6A0", Length = "0x81")]
		[Token(Token = "0x60002F6")]
		 get { } //Length: 129
	}

	[Token(Token = "0x170000AB")]
	internal static float CurrentUnscaledTime
	{
		[Address(RVA = "0x283F330", Offset = "0x283E730", Length = "0x7F")]
		[Token(Token = "0x60002F3")]
		internal get { } //Length: 127
	}

	[Token(Token = "0x170000AE")]
	public internal static int CurrentUpdateFrame
	{
		[Address(RVA = "0x283F3B0", Offset = "0x283E7B0", Length = "0x4E")]
		[CompilerGenerated]
		[Token(Token = "0x60002F7")]
		 get { } //Length: 78
		[Address(RVA = "0x283F570", Offset = "0x283E970", Length = "0x53")]
		[CompilerGenerated]
		[Token(Token = "0x60002F8")]
		internal set { } //Length: 83
	}

	[Token(Token = "0x170000AC")]
	public static float DeltaTime
	{
		[Address(RVA = "0x283F400", Offset = "0x283E800", Length = "0x81")]
		[Token(Token = "0x60002F5")]
		 get { } //Length: 129
	}

	[Token(Token = "0x170000B0")]
	public static ICinemachineCamera SoloCamera
	{
		[Address(RVA = "0x283F490", Offset = "0x283E890", Length = "0x4F")]
		[Token(Token = "0x60002FB")]
		 get { } //Length: 79
		[Address(RVA = "0x283F5D0", Offset = "0x283E9D0", Length = "0x235")]
		[Token(Token = "0x60002FC")]
		 set { } //Length: 565
	}

	[Token(Token = "0x170000AF")]
	public static int VirtualCameraCount
	{
		[Address(RVA = "0x283F4E0", Offset = "0x283E8E0", Length = "0x8C")]
		[Token(Token = "0x60002F9")]
		 get { } //Length: 140
	}

	[Address(RVA = "0x283EEC0", Offset = "0x283E2C0", Length = "0x3DD")]
	[Token(Token = "0x6000302")]
	private static CinemachineCore() { }

	[Address(RVA = "0x283E610", Offset = "0x283DA10", Length = "0x220")]
	[Token(Token = "0x60002FF")]
	public static CinemachineBrain FindPotentialTargetBrain(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x283F2A0", Offset = "0x283E6A0", Length = "0x81")]
	[Token(Token = "0x60002F6")]
	public static float get_CurrentTime() { }

	[Address(RVA = "0x283F330", Offset = "0x283E730", Length = "0x7F")]
	[Token(Token = "0x60002F3")]
	internal static float get_CurrentUnscaledTime() { }

	[Address(RVA = "0x283F3B0", Offset = "0x283E7B0", Length = "0x4E")]
	[CompilerGenerated]
	[Token(Token = "0x60002F7")]
	public static int get_CurrentUpdateFrame() { }

	[Address(RVA = "0x283F400", Offset = "0x283E800", Length = "0x81")]
	[Token(Token = "0x60002F5")]
	public static float get_DeltaTime() { }

	[Address(RVA = "0x283F490", Offset = "0x283E890", Length = "0x4F")]
	[Token(Token = "0x60002FB")]
	public static ICinemachineCamera get_SoloCamera() { }

	[Address(RVA = "0x283F4E0", Offset = "0x283E8E0", Length = "0x8C")]
	[Token(Token = "0x60002F9")]
	public static int get_VirtualCameraCount() { }

	[Address(RVA = "0x283E840", Offset = "0x283DC40", Length = "0x94")]
	[Token(Token = "0x60002FA")]
	public static CinemachineVirtualCameraBase GetVirtualCamera(int index) { }

	[Address(RVA = "0x283E9E0", Offset = "0x283DDE0", Length = "0xF7")]
	[Token(Token = "0x60002FD")]
	public static bool IsLive(ICinemachineCamera vcam) { }

	[Address(RVA = "0x283E8E0", Offset = "0x283DCE0", Length = "0xF4")]
	[Token(Token = "0x60002FE")]
	public static bool IsLiveInBlend(ICinemachineCamera vcam) { }

	[Address(RVA = "0x283EAE0", Offset = "0x283DEE0", Length = "0x1B0")]
	[Token(Token = "0x6000300")]
	public static void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	[Address(RVA = "0x283ECA0", Offset = "0x283E0A0", Length = "0x1FC")]
	[Token(Token = "0x6000301")]
	public static void ResetCameraState() { }

	[Address(RVA = "0x283F570", Offset = "0x283E970", Length = "0x53")]
	[CompilerGenerated]
	[Token(Token = "0x60002F8")]
	internal static void set_CurrentUpdateFrame(int value) { }

	[Address(RVA = "0x283F5D0", Offset = "0x283E9D0", Length = "0x235")]
	[Token(Token = "0x60002FC")]
	public static void set_SoloCamera(ICinemachineCamera value) { }

	[Address(RVA = "0x283EEA0", Offset = "0x283E2A0", Length = "0x11")]
	[Token(Token = "0x60002F4")]
	internal static Color SoloGUIColor() { }

}

