namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Extensions/Cinemachine Auto Focus")]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineAutoFocus.html")]
[SaveDuringPlay]
[Token(Token = "0x2000162")]
public class CinemachineAutoFocus : CinemachineExtension
{
	[Token(Token = "0x2000163")]
	internal enum FocusTrackingMode : int
	{
		None = 0,
		LookAtTarget = 1,
		FollowTarget = 2,
		CustomTarget = 3,
		Camera = 4,
		ScreenCenter = 5,
	}

	[Token(Token = "0x2000164")]
	private class VcamExtraState : VcamExtraStateBase
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40005FD")]
		public float CurrentFocusDistance; //Field offset: 0x18

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60006D0")]
		public VcamExtraState() { }

	}

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005F2")]
	[Tooltip("The camera's focus distance will be set to the distance from the camera to the selected target.  The Focus Offset field will then modify that distance.")]
	public FocusTrackingMode FocusTarget; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005F3")]
	[Tooltip("The target to use if Focus Target is set to Custom Target")]
	public Transform CustomTarget; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005F4")]
	[Tooltip("Offsets the sharpest point away in depth from the focus target location.")]
	public float FocusDepthOffset; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40005F5")]
	[Tooltip("The value corresponds approximately to the time the focus will take to adjust to the new value.")]
	public float Damping; //Field offset: 0x44

	[Address(RVA = "0xE31DA0", Offset = "0xE311A0", Length = "0x7")]
	[Token(Token = "0x60006CF")]
	public CinemachineAutoFocus() { }

	[Address(RVA = "0x28814D0", Offset = "0x28808D0", Length = "0x10")]
	[Token(Token = "0x60006CD")]
	private void OnValidate() { }

	[Address(RVA = "0x28814E0", Offset = "0x28808E0", Length = "0x442")]
	[Token(Token = "0x60006CE")]
	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x2881930", Offset = "0x2880D30", Length = "0x37")]
	[Token(Token = "0x60006CC")]
	private void Reset() { }

}

