namespace Unity.Cinemachine;

[AddComponentMenu(null)]
[CameraPipeline(Stage::Body (0))]
[Obsolete("CinemachineFramingTransposer has been deprecated. Use CinemachinePositionComposer instead")]
[SaveDuringPlay]
[Token(Token = "0x200010E")]
public class CinemachineFramingTransposer : CinemachineComponentBase
{
	[Token(Token = "0x2000110")]
	internal enum AdjustmentMode : int
	{
		ZoomOnly = 0,
		DollyOnly = 1,
		DollyThenZoom = 2,
	}

	[Token(Token = "0x200010F")]
	internal enum FramingMode : int
	{
		Horizontal = 0,
		Vertical = 1,
		HorizontalAndVertical = 2,
		None = 3,
	}

	[Token(Token = "0x4000448")]
	private const float kMinimumCameraDistance = 0.01; //Field offset: 0x0
	[Token(Token = "0x4000449")]
	private const float kMinimumGroupSize = 0.01; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000429")]
	[Tooltip("Offset from the Follow Target object (in target-local co-ordinates).  The camera will attempt to frame the point which is the target's position plus this offset.  Use it to correct for cases when the target's origin is not the point of interest for the camera.")]
	public Vector3 m_TrackedObjectOffset; //Field offset: 0x28
	[FieldOffset(Offset = "0x34")]
	[Range(0, 1)]
	[Space]
	[Token(Token = "0x400042A")]
	[Tooltip("This setting will instruct the composer to adjust its target offset based on the motion of the target.  The composer will look at a point where it estimates the target will be this many seconds into the future.  Note that this setting is sensitive to noisy animation, and can amplify the noise, resulting in undesirable camera jitter.  If the camera jitters unacceptably when the target is in motion, turn down this setting, or animate the target more smoothly.")]
	public float m_LookaheadTime; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Range(0, 30)]
	[Token(Token = "0x400042B")]
	[Tooltip("Controls the smoothness of the lookahead algorithm.  Larger values smooth out jittery predictions and also increase prediction lag")]
	public float m_LookaheadSmoothing; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400042C")]
	[Tooltip("If checked, movement along the Y axis will be ignored for lookahead calculations")]
	public bool m_LookaheadIgnoreY; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Range(0, 20)]
	[Space]
	[Token(Token = "0x400042D")]
	[Tooltip("How aggressively the camera tries to maintain the offset in the X-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's x-axis offset.  Larger numbers give a more heavy slowly responding camera.  Using different settings per axis can yield a wide range of camera behaviors.")]
	public float m_XDamping; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Range(0, 20)]
	[Token(Token = "0x400042E")]
	[Tooltip("How aggressively the camera tries to maintain the offset in the Y-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's y-axis offset.  Larger numbers give a more heavy slowly responding camera.  Using different settings per axis can yield a wide range of camera behaviors.")]
	public float m_YDamping; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Range(0, 20)]
	[Token(Token = "0x400042F")]
	[Tooltip("How aggressively the camera tries to maintain the offset in the Z-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's z-axis offset.  Larger numbers give a more heavy slowly responding camera.  Using different settings per axis can yield a wide range of camera behaviors.")]
	public float m_ZDamping; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000430")]
	[Tooltip("If set, damping will apply  only to target motion, but not to camera rotation changes.  Turn this on to get an instant response when the rotation changes.  ")]
	public bool m_TargetMovementOnly; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Range(-0.5, 1.5)]
	[Space]
	[Token(Token = "0x4000431")]
	[Tooltip("Horizontal screen position for target. The camera will move to position the tracked object here.")]
	public float m_ScreenX; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Range(-0.5, 1.5)]
	[Token(Token = "0x4000432")]
	[Tooltip("Vertical screen position for target, The camera will move to position the tracked object here.")]
	public float m_ScreenY; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000433")]
	[Tooltip("The distance along the camera axis that will be maintained from the Follow target")]
	public float m_CameraDistance; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Range(0, 2)]
	[Space]
	[Token(Token = "0x4000434")]
	[Tooltip("Camera will not move horizontally if the target is within this range of the position.")]
	public float m_DeadZoneWidth; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Range(0, 2)]
	[Token(Token = "0x4000435")]
	[Tooltip("Camera will not move vertically if the target is within this range of the position.")]
	public float m_DeadZoneHeight; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[FormerlySerializedAs("m_DistanceDeadZoneSize")]
	[Token(Token = "0x4000436")]
	[Tooltip("The camera will not move along its z-axis if the Follow target is within this distance of the specified camera distance")]
	public float m_DeadZoneDepth; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Space]
	[Token(Token = "0x4000437")]
	[Tooltip("If checked, then then soft zone will be unlimited in size.")]
	public bool m_UnlimitedSoftZone; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Range(0, 2)]
	[Token(Token = "0x4000438")]
	[Tooltip("When target is within this region, camera will gradually move horizontally to re-align towards the desired position, depending on the damping speed.")]
	public float m_SoftZoneWidth; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Range(0, 2)]
	[Token(Token = "0x4000439")]
	[Tooltip("When target is within this region, camera will gradually move vertically to re-align towards the desired position, depending on the damping speed.")]
	public float m_SoftZoneHeight; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Range(-0.5, 0.5)]
	[Token(Token = "0x400043A")]
	[Tooltip("A non-zero bias will move the target position horizontally away from the center of the soft zone.")]
	public float m_BiasX; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Range(-0.5, 0.5)]
	[Token(Token = "0x400043B")]
	[Tooltip("A non-zero bias will move the target position vertically away from the center of the soft zone.")]
	public float m_BiasY; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x400043C")]
	[Tooltip("Force target to center of screen when this camera activates.  If false, will clamp target to the edges of the dead zone")]
	public bool m_CenterOnActivate; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[FormerlySerializedAs("m_FramingMode")]
	[Space]
	[Token(Token = "0x400043D")]
	[Tooltip("What screen dimensions to consider when framing.  Can be Horizontal, Vertical, or both")]
	public FramingMode m_GroupFramingMode; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x400043E")]
	[Tooltip("How to adjust the camera to get the desired framing.  You can zoom, dolly in/out, or do both.")]
	public AdjustmentMode m_AdjustmentMode; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400043F")]
	[Tooltip("The bounding box of the targets should occupy this amount of the screen space.  1 means fill the whole screen.  0.5 means fill half the screen, etc.")]
	public float m_GroupFramingSize; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000440")]
	[Tooltip("The maximum distance toward the target that this behaviour is allowed to move the camera.")]
	public float m_MaxDollyIn; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000441")]
	[Tooltip("The maximum distance away the target that this behaviour is allowed to move the camera.")]
	public float m_MaxDollyOut; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000442")]
	[Tooltip("Set this to limit how close to the target the camera can get.")]
	public float m_MinimumDistance; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000443")]
	[Tooltip("Set this to limit how far from the target the camera can get.")]
	public float m_MaximumDistance; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Range(1, 179)]
	[Token(Token = "0x4000444")]
	[Tooltip("If adjusting FOV, will not set the FOV lower than this.")]
	public float m_MinimumFOV; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Range(1, 179)]
	[Token(Token = "0x4000445")]
	[Tooltip("If adjusting FOV, will not set the FOV higher than this.")]
	public float m_MaximumFOV; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000446")]
	[Tooltip("If adjusting Orthographic Size, will not set it lower than this.")]
	public float m_MinimumOrthoSize; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000447")]
	[Tooltip("If adjusting Orthographic Size, will not set it higher than this.")]
	public float m_MaximumOrthoSize; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x400044A")]
	private Vector3 m_PreviousCameraPosition; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400044B")]
	internal PositionPredictor m_Predictor; //Field offset: 0xB8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x400044C")]
	private Vector3 <TrackedPoint>k__BackingField; //Field offset: 0xE4
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400044D")]
	private bool m_InheritingPosition; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x400044E")]
	private float m_prevFOV; //Field offset: 0xF4
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400044F")]
	private Quaternion m_prevRotation; //Field offset: 0xF8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000450")]
	private Bounds <LastBounds>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000451")]
	private Matrix4x4 <LastBoundsMatrix>k__BackingField; //Field offset: 0x120

	[Token(Token = "0x17000110")]
	public virtual bool BodyAppliesAfterAim
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000521")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000114")]
	internal ScreenComposerSettings Composition
	{
		[Address(RVA = "0x285D590", Offset = "0x285C990", Length = "0xBC")]
		[Token(Token = "0x6000532")]
		internal get { } //Length: 188
		[Address(RVA = "0x285D8A0", Offset = "0x285CCA0", Length = "0x58")]
		[Token(Token = "0x6000533")]
		internal set { } //Length: 88
	}

	[Token(Token = "0x1700010D")]
	internal Rect HardGuideRect
	{
		[Address(RVA = "0x285D650", Offset = "0x285CA50", Length = "0x118")]
		[Token(Token = "0x600051C")]
		internal get { } //Length: 280
		[Address(RVA = "0x285D900", Offset = "0x285CD00", Length = "0xAB")]
		[Token(Token = "0x600051D")]
		internal set { } //Length: 171
	}

	[Token(Token = "0x1700010E")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x285D770", Offset = "0x285CB70", Length = "0x6D")]
		[Token(Token = "0x600051F")]
		 get { } //Length: 109
	}

	[Token(Token = "0x17000112")]
	public private Bounds LastBounds
	{
		[Address(RVA = "0x285D810", Offset = "0x285CC10", Length = "0x1B")]
		[CompilerGenerated]
		[Token(Token = "0x600052A")]
		 get { } //Length: 27
		[Address(RVA = "0x285D9E0", Offset = "0x285CDE0", Length = "0x18")]
		[CompilerGenerated]
		[Token(Token = "0x600052B")]
		private set { } //Length: 24
	}

	[Token(Token = "0x17000113")]
	public private Matrix4x4 LastBoundsMatrix
	{
		[Address(RVA = "0x285D7E0", Offset = "0x285CBE0", Length = "0x2F")]
		[CompilerGenerated]
		[Token(Token = "0x600052C")]
		 get { } //Length: 47
		[Address(RVA = "0x285D9B0", Offset = "0x285CDB0", Length = "0x2C")]
		[CompilerGenerated]
		[Token(Token = "0x600052D")]
		private set { } //Length: 44
	}

	[Token(Token = "0x1700010C")]
	internal Rect SoftGuideRect
	{
		[Address(RVA = "0x285D830", Offset = "0x285CC30", Length = "0x45")]
		[Token(Token = "0x600051A")]
		internal get { } //Length: 69
		[Address(RVA = "0x285DA00", Offset = "0x285CE00", Length = "0x108")]
		[Token(Token = "0x600051B")]
		internal set { } //Length: 264
	}

	[Token(Token = "0x1700010F")]
	public virtual Stage Stage
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000520")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000111")]
	public private Vector3 TrackedPoint
	{
		[Address(RVA = "0x285D880", Offset = "0x285CC80", Length = "0x19")]
		[CompilerGenerated]
		[Token(Token = "0x6000522")]
		 get { } //Length: 25
		[Address(RVA = "0x285DB10", Offset = "0x285CF10", Length = "0x16")]
		[CompilerGenerated]
		[Token(Token = "0x6000523")]
		private set { } //Length: 22
	}

	[Address(RVA = "0x285D490", Offset = "0x285C890", Length = "0xFB")]
	[Token(Token = "0x6000536")]
	public CinemachineFramingTransposer() { }

	[Address(RVA = "0x285A510", Offset = "0x2859910", Length = "0x639")]
	[Token(Token = "0x6000530")]
	private Vector3 ComputeGroupBounds(ICinemachineTargetGroup group, ref CameraState curState) { }

	[Address(RVA = "0x285AB50", Offset = "0x2859F50", Length = "0x73")]
	[Token(Token = "0x6000525")]
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000521")]
	public virtual bool get_BodyAppliesAfterAim() { }

	[Address(RVA = "0x285D590", Offset = "0x285C990", Length = "0xBC")]
	[Token(Token = "0x6000532")]
	internal ScreenComposerSettings get_Composition() { }

	[Address(RVA = "0x285D650", Offset = "0x285CA50", Length = "0x118")]
	[Token(Token = "0x600051C")]
	internal Rect get_HardGuideRect() { }

	[Address(RVA = "0x285D770", Offset = "0x285CB70", Length = "0x6D")]
	[Token(Token = "0x600051F")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x285D810", Offset = "0x285CC10", Length = "0x1B")]
	[CompilerGenerated]
	[Token(Token = "0x600052A")]
	public Bounds get_LastBounds() { }

	[Address(RVA = "0x285D7E0", Offset = "0x285CBE0", Length = "0x2F")]
	[CompilerGenerated]
	[Token(Token = "0x600052C")]
	public Matrix4x4 get_LastBoundsMatrix() { }

	[Address(RVA = "0x285D830", Offset = "0x285CC30", Length = "0x45")]
	[Token(Token = "0x600051A")]
	internal Rect get_SoftGuideRect() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000520")]
	public virtual Stage get_Stage() { }

	[Address(RVA = "0x285D880", Offset = "0x285CC80", Length = "0x19")]
	[CompilerGenerated]
	[Token(Token = "0x6000522")]
	public Vector3 get_TrackedPoint() { }

	[Address(RVA = "0x285ABD0", Offset = "0x2859FD0", Length = "0x16")]
	[Token(Token = "0x6000526")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x285ABF0", Offset = "0x2859FF0", Length = "0x7A9")]
	[Token(Token = "0x6000531")]
	private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, ref Vector3 pos, Quaternion orientation) { }

	[Address(RVA = "0x285B3A0", Offset = "0x285A7A0", Length = "0x189")]
	[Token(Token = "0x600052F")]
	private float GetTargetHeight(Vector2 boundsSize) { }

	[Address(RVA = "0x285B530", Offset = "0x285A930", Length = "0x1517")]
	[Token(Token = "0x600052E")]
	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x285CA50", Offset = "0x285BE50", Length = "0x11C")]
	[Token(Token = "0x6000524")]
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	[Address(RVA = "0x285CB70", Offset = "0x285BF70", Length = "0x293")]
	[Token(Token = "0x6000527")]
	public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x285CE10", Offset = "0x285C210", Length = "0xEA")]
	[Token(Token = "0x600051E")]
	private void OnValidate() { }

	[Address(RVA = "0x285CF00", Offset = "0x285C300", Length = "0x1DD")]
	[Token(Token = "0x6000529")]
	private Vector3 OrthoOffsetToScreenBounds(Vector3 targetPos2D, Rect screenRect) { }

	[Address(RVA = "0x285D0E0", Offset = "0x285C4E0", Length = "0x18C")]
	[Token(Token = "0x6000528")]
	private Rect ScreenToOrtho(Rect rScreen, float orthoSize, float aspect) { }

	[Address(RVA = "0x285D8A0", Offset = "0x285CCA0", Length = "0x58")]
	[Token(Token = "0x6000533")]
	internal void set_Composition(ScreenComposerSettings value) { }

	[Address(RVA = "0x285D900", Offset = "0x285CD00", Length = "0xAB")]
	[Token(Token = "0x600051D")]
	internal void set_HardGuideRect(Rect value) { }

	[Address(RVA = "0x285D9E0", Offset = "0x285CDE0", Length = "0x18")]
	[CompilerGenerated]
	[Token(Token = "0x600052B")]
	private void set_LastBounds(Bounds value) { }

	[Address(RVA = "0x285D9B0", Offset = "0x285CDB0", Length = "0x2C")]
	[CompilerGenerated]
	[Token(Token = "0x600052D")]
	private void set_LastBoundsMatrix(Matrix4x4 value) { }

	[Address(RVA = "0x285DA00", Offset = "0x285CE00", Length = "0x108")]
	[Token(Token = "0x600051B")]
	internal void set_SoftGuideRect(Rect value) { }

	[Address(RVA = "0x285DB10", Offset = "0x285CF10", Length = "0x16")]
	[CompilerGenerated]
	[Token(Token = "0x6000523")]
	private void set_TrackedPoint(Vector3 value) { }

	[Address(RVA = "0x285D270", Offset = "0x285C670", Length = "0x88")]
	[Token(Token = "0x6000535")]
	internal void UpgradeToCm3(CinemachineGroupFraming c) { }

	[Address(RVA = "0x285D300", Offset = "0x285C700", Length = "0x186")]
	[Token(Token = "0x6000534")]
	internal void UpgradeToCm3(CinemachinePositionComposer c) { }

}

