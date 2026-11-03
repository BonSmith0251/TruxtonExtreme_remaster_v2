namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Extensions/Cinemachine Group Framing")]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineGroupFraming.html")]
[RequiredTarget(RequiredTargets::GroupLookAt (3))]
[SaveDuringPlay]
[Token(Token = "0x2000037")]
public class CinemachineGroupFraming : CinemachineExtension
{
	[Token(Token = "0x2000038")]
	internal enum FramingModes : int
	{
		Horizontal = 0,
		Vertical = 1,
		HorizontalAndVertical = 2,
	}

	[Token(Token = "0x200003A")]
	internal enum LateralAdjustmentModes : int
	{
		ChangePosition = 0,
		ChangeRotation = 1,
	}

	[Token(Token = "0x2000039")]
	internal enum SizeAdjustmentModes : int
	{
		ZoomOnly = 0,
		DollyOnly = 1,
		DollyThenZoom = 2,
	}

	[Token(Token = "0x200003B")]
	private class VcamExtraState : VcamExtraStateBase
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000D5")]
		public Vector3 PosAdjustment; //Field offset: 0x18
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40000D6")]
		public Vector2 RotAdjustment; //Field offset: 0x24
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40000D7")]
		public float FovAdjustment; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000D8")]
		public Stage Stage; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000D9")]
		public CinemachineConfiner2D Confiner; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000DA")]
		public float PreviousOrthoSize; //Field offset: 0x40

		[Address(RVA = "0x2818B00", Offset = "0x2817F00", Length = "0xE")]
		[Token(Token = "0x60000FC")]
		public VcamExtraState() { }

		[Address(RVA = "0x28188E0", Offset = "0x2817CE0", Length = "0x8F")]
		[Token(Token = "0x60000FB")]
		public void Reset() { }

	}

	[Token(Token = "0x40000C7")]
	private const float k_MinimumGroupSize = 0.01; //Field offset: 0x0
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000BE")]
	[Tooltip("What screen dimensions to consider when framing.  Can be Horizontal, Vertical, or both")]
	public FramingModes FramingMode; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Range(0, 2)]
	[Token(Token = "0x40000BF")]
	[Tooltip("The bounding box of the targets should occupy this amount of the screen space.  1 means fill the whole screen.  0.5 means fill half the screen, etc.")]
	public float FramingSize; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000C0")]
	[Tooltip("A nonzero value will offset the group in the camera frame.")]
	public Vector2 CenterOffset; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Range(0, 20)]
	[Token(Token = "0x40000C1")]
	[Tooltip("How aggressively the camera tries to frame the group. Small numbers are more responsive, rapidly adjusting the camera to keep the group in the frame.  Larger numbers give a heavier more slowly responding camera.")]
	public float Damping; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40000C2")]
	[Tooltip("How to adjust the camera to get the desired framing size.  You can zoom, dolly in/out, or do both.")]
	public SizeAdjustmentModes SizeAdjustment; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000C3")]
	[Tooltip("How to adjust the camera to get the desired horizontal and vertical framing.")]
	public LateralAdjustmentModes LateralAdjustment; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[MinMaxRangeSlider(1, 179)]
	[Token(Token = "0x40000C4")]
	[Tooltip("Allowable FOV range, if adjusting FOV.")]
	public Vector2 FovRange; //Field offset: 0x4C
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40000C5")]
	[Tooltip("Allowable range for the camera to move.  0 is the undollied position.  Negative values move the camera closer to the target.")]
	[Vector2AsRange]
	public Vector2 DollyRange; //Field offset: 0x54
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40000C6")]
	[Tooltip("Allowable orthographic size range, if adjusting orthographic size.")]
	[Vector2AsRange]
	public Vector2 OrthoSizeRange; //Field offset: 0x5C
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40000C8")]
	internal Bounds GroupBounds; //Field offset: 0x64
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40000C9")]
	internal Matrix4x4 GroupBoundsMatrix; //Field offset: 0x7C

	[Address(RVA = "0x2812810", Offset = "0x2811C10", Length = "0x97")]
	[Token(Token = "0x60000FA")]
	public CinemachineGroupFraming() { }

	[Address(RVA = "0x280FD50", Offset = "0x280F150", Length = "0x299")]
	[Token(Token = "0x60000F7")]
	private void AdjustSize(ICinemachineTargetGroup group, float aspect, ref Vector3 camPos, ref Quaternion camRot, ref float fov, ref float dollyAmount) { }

	[Address(RVA = "0x280FFF0", Offset = "0x280F3F0", Length = "0xCF3")]
	[Token(Token = "0x60000F8")]
	private void ComputeCameraViewGroupBounds(ICinemachineTargetGroup group, ref Vector3 camPos, ref Quaternion camRot, bool moveCamera) { }

	[Address(RVA = "0x2810CF0", Offset = "0x28100F0", Length = "0x81")]
	[Token(Token = "0x60000F9")]
	private float GetFrameHeight(Vector2 boundsSize, float aspect) { }

	[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
	[Token(Token = "0x60000F3")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x2810D80", Offset = "0x2810180", Length = "0x90")]
	[Token(Token = "0x60000F1")]
	private void OnValidate() { }

	[Address(RVA = "0x2810E10", Offset = "0x2810210", Length = "0x651")]
	[Token(Token = "0x60000F5")]
	private void OrthoFraming(CinemachineVirtualCameraBase vcam, ICinemachineTargetGroup group, VcamExtraState extra, ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x2811470", Offset = "0x2810870", Length = "0xFA1")]
	[Token(Token = "0x60000F6")]
	private void PerspectiveFraming(CinemachineVirtualCameraBase vcam, ICinemachineTargetGroup group, VcamExtraState extra, ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x2812420", Offset = "0x2811820", Length = "0x35D")]
	[Token(Token = "0x60000F4")]
	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x2812780", Offset = "0x2811B80", Length = "0x8F")]
	[Token(Token = "0x60000F2")]
	private void Reset() { }

}

