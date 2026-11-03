namespace Unity.Cinemachine;

[AddComponentMenu(null)]
[CameraPipeline(Stage::Aim (1))]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineComposer.html")]
[Obsolete("CinemachineComposer has been deprecated. Use CinemachineRotationComposer instead")]
[SaveDuringPlay]
[Token(Token = "0x2000106")]
public class CinemachineComposer : CinemachineComponentBase
{
	[Token(Token = "0x2000107")]
	private struct FovCache
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400040B")]
		public Rect mFovSoftGuideRect; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400040C")]
		public Rect mFovHardGuideRect; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400040D")]
		public float mFovH; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400040E")]
		public float mFov; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400040F")]
		private float mOrthoSizeOverDistance; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000410")]
		private float mAspect; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000411")]
		private Rect mSoftGuideRect; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000412")]
		private Rect mHardGuideRect; //Field offset: 0x40

		[Address(RVA = "0x28635C0", Offset = "0x28629C0", Length = "0x91B")]
		[Token(Token = "0x6000500")]
		private Rect ScreenToFOV(Rect rScreen, float fov, float fovH, float aspect) { }

		[Address(RVA = "0x2863EE0", Offset = "0x28632E0", Length = "0x3D6")]
		[Token(Token = "0x60004FF")]
		public void UpdateCache(LensSettings lens, Rect softGuide, Rect hardGuide, float targetDistance) { }

	}

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003F5")]
	[Tooltip("Target offset from the target object's center in target-local space. Use this to fine-tune the tracking target position when the desired area is not the tracked object's center.")]
	public Vector3 m_TrackedObjectOffset; //Field offset: 0x28
	[FieldOffset(Offset = "0x34")]
	[Range(0, 1)]
	[Space]
	[Token(Token = "0x40003F6")]
	[Tooltip("This setting will instruct the composer to adjust its target offset based on the motion of the target.  The composer will look at a point where it estimates the target will be this many seconds into the future.  Note that this setting is sensitive to noisy animation, and can amplify the noise, resulting in undesirable camera jitter.  If the camera jitters unacceptably when the target is in motion, turn down this setting, or animate the target more smoothly.")]
	public float m_LookaheadTime; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Range(0, 30)]
	[Token(Token = "0x40003F7")]
	[Tooltip("Controls the smoothness of the lookahead algorithm.  Larger values smooth out jittery predictions and also increase prediction lag")]
	public float m_LookaheadSmoothing; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40003F8")]
	[Tooltip("If checked, movement along the Y axis will be ignored for lookahead calculations")]
	public bool m_LookaheadIgnoreY; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Range(0, 20)]
	[Space]
	[Token(Token = "0x40003F9")]
	[Tooltip("How aggressively the camera tries to follow the target in the screen-horizontal direction. Small numbers are more responsive, rapidly orienting the camera to keep the target in the dead zone. Larger numbers give a more heavy slowly responding camera. Using different vertical and horizontal settings can yield a wide range of camera behaviors.")]
	public float m_HorizontalDamping; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Range(0, 20)]
	[Token(Token = "0x40003FA")]
	[Tooltip("How aggressively the camera tries to follow the target in the screen-vertical direction. Small numbers are more responsive, rapidly orienting the camera to keep the target in the dead zone. Larger numbers give a more heavy slowly responding camera. Using different vertical and horizontal settings can yield a wide range of camera behaviors.")]
	public float m_VerticalDamping; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Range(-0.5, 1.5)]
	[Space]
	[Token(Token = "0x40003FB")]
	[Tooltip("Horizontal screen position for target. The camera will rotate to position the tracked object here.")]
	public float m_ScreenX; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Range(-0.5, 1.5)]
	[Token(Token = "0x40003FC")]
	[Tooltip("Vertical screen position for target, The camera will rotate to position the tracked object here.")]
	public float m_ScreenY; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Range(0, 2)]
	[Token(Token = "0x40003FD")]
	[Tooltip("Camera will not rotate horizontally if the target is within this range of the position.")]
	public float m_DeadZoneWidth; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Range(0, 2)]
	[Token(Token = "0x40003FE")]
	[Tooltip("Camera will not rotate vertically if the target is within this range of the position.")]
	public float m_DeadZoneHeight; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Range(0, 2)]
	[Token(Token = "0x40003FF")]
	[Tooltip("When target is within this region, camera will gradually rotate horizontally to re-align towards the desired position, depending on the damping speed.")]
	public float m_SoftZoneWidth; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Range(0, 2)]
	[Token(Token = "0x4000400")]
	[Tooltip("When target is within this region, camera will gradually rotate vertically to re-align towards the desired position, depending on the damping speed.")]
	public float m_SoftZoneHeight; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Range(-0.5, 0.5)]
	[Token(Token = "0x4000401")]
	[Tooltip("A non-zero bias will move the target position horizontally away from the center of the soft zone.")]
	public float m_BiasX; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Range(-0.5, 0.5)]
	[Token(Token = "0x4000402")]
	[Tooltip("A non-zero bias will move the target position vertically away from the center of the soft zone.")]
	public float m_BiasY; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000403")]
	[Tooltip("Force target to center of screen when this camera activates.  If false, will clamp target to the edges of the dead zone")]
	public bool m_CenterOnActivate; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000404")]
	private Vector3 <TrackedPoint>k__BackingField; //Field offset: 0x6C
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000405")]
	private Vector3 m_CameraPosPrevFrame; //Field offset: 0x78
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000406")]
	private Vector3 m_LookAtPrevFrame; //Field offset: 0x84
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000407")]
	private Vector2 m_ScreenOffsetPrevFrame; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000408")]
	private Quaternion m_CameraOrientationPrevFrame; //Field offset: 0x98
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000409")]
	internal PositionPredictor m_Predictor; //Field offset: 0xA8
	[FieldOffset(Offset = "0xD4")]
	[Token(Token = "0x400040A")]
	private FovCache mCache; //Field offset: 0xD4

	[Token(Token = "0x1700010A")]
	internal ScreenComposerSettings Composition
	{
		[Address(RVA = "0x2858070", Offset = "0x2857470", Length = "0xB9")]
		[Token(Token = "0x60004FB")]
		internal get { } //Length: 185
		[Address(RVA = "0x2858330", Offset = "0x2857730", Length = "0x58")]
		[Token(Token = "0x60004FC")]
		internal set { } //Length: 88
	}

	[Token(Token = "0x17000109")]
	internal Rect HardGuideRect
	{
		[Address(RVA = "0x2858130", Offset = "0x2857530", Length = "0x118")]
		[Token(Token = "0x60004F7")]
		internal get { } //Length: 280
		[Address(RVA = "0x2858390", Offset = "0x2857790", Length = "0xAB")]
		[Token(Token = "0x60004F8")]
		internal set { } //Length: 171
	}

	[Token(Token = "0x17000105")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x2858250", Offset = "0x2857650", Length = "0x6D")]
		[Token(Token = "0x60004EB")]
		 get { } //Length: 109
	}

	[Token(Token = "0x17000108")]
	internal Rect SoftGuideRect
	{
		[Address(RVA = "0x28582C0", Offset = "0x28576C0", Length = "0x45")]
		[Token(Token = "0x60004F5")]
		internal get { } //Length: 69
		[Address(RVA = "0x2858440", Offset = "0x2857840", Length = "0x108")]
		[Token(Token = "0x60004F6")]
		internal set { } //Length: 264
	}

	[Token(Token = "0x17000106")]
	public virtual Stage Stage
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60004EC")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000107")]
	public private Vector3 TrackedPoint
	{
		[Address(RVA = "0x2858310", Offset = "0x2857710", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60004ED")]
		 get { } //Length: 19
		[Address(RVA = "0x2858550", Offset = "0x2857950", Length = "0x10")]
		[CompilerGenerated]
		[Token(Token = "0x60004EE")]
		private set { } //Length: 16
	}

	[Address(RVA = "0x2857F00", Offset = "0x2857300", Length = "0x16D")]
	[Token(Token = "0x60004FE")]
	public CinemachineComposer() { }

	[Address(RVA = "0x28562D0", Offset = "0x28556D0", Length = "0x1C5")]
	[Token(Token = "0x60004FA")]
	private bool ClampVerticalBounds(ref Rect r, Vector3 dir, Vector3 up, float fov) { }

	[Address(RVA = "0x28564A0", Offset = "0x28558A0", Length = "0x70")]
	[Token(Token = "0x60004F1")]
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x2858070", Offset = "0x2857470", Length = "0xB9")]
	[Token(Token = "0x60004FB")]
	internal ScreenComposerSettings get_Composition() { }

	[Address(RVA = "0x2858130", Offset = "0x2857530", Length = "0x118")]
	[Token(Token = "0x60004F7")]
	internal Rect get_HardGuideRect() { }

	[Address(RVA = "0x2858250", Offset = "0x2857650", Length = "0x6D")]
	[Token(Token = "0x60004EB")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x28582C0", Offset = "0x28576C0", Length = "0x45")]
	[Token(Token = "0x60004F5")]
	internal Rect get_SoftGuideRect() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60004EC")]
	public virtual Stage get_Stage() { }

	[Address(RVA = "0x2858310", Offset = "0x2857710", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60004ED")]
	public Vector3 get_TrackedPoint() { }

	[Address(RVA = "0x2856510", Offset = "0x2855910", Length = "0x2C6")]
	[Token(Token = "0x60004EF")]
	protected override Vector3 GetLookAtPointAndSetTrackedPoint(Vector3 lookAt, Vector3 up, float deltaTime) { }

	[Address(RVA = "0x28567E0", Offset = "0x2855BE0", Length = "0xD")]
	[Token(Token = "0x60004F2")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x28567F0", Offset = "0x2855BF0", Length = "0xE3F")]
	[Token(Token = "0x60004F4")]
	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x2857630", Offset = "0x2856A30", Length = "0x16B")]
	[Token(Token = "0x60004F0")]
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	[Address(RVA = "0x28577A0", Offset = "0x2856BA0", Length = "0x136")]
	[Token(Token = "0x60004F3")]
	public virtual void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x28578E0", Offset = "0x2856CE0", Length = "0x4AB")]
	[Token(Token = "0x60004F9")]
	private void RotateToScreenBounds(ref CameraState state, Rect screenRect, Vector3 trackedPoint, ref Quaternion rigOrientation, float fov, float fovH, float deltaTime) { }

	[Address(RVA = "0x2858330", Offset = "0x2857730", Length = "0x58")]
	[Token(Token = "0x60004FC")]
	internal void set_Composition(ScreenComposerSettings value) { }

	[Address(RVA = "0x2858390", Offset = "0x2857790", Length = "0xAB")]
	[Token(Token = "0x60004F8")]
	internal void set_HardGuideRect(Rect value) { }

	[Address(RVA = "0x2858440", Offset = "0x2857840", Length = "0x108")]
	[Token(Token = "0x60004F6")]
	internal void set_SoftGuideRect(Rect value) { }

	[Address(RVA = "0x2858550", Offset = "0x2857950", Length = "0x10")]
	[CompilerGenerated]
	[Token(Token = "0x60004EE")]
	private void set_TrackedPoint(Vector3 value) { }

	[Address(RVA = "0x2857D90", Offset = "0x2857190", Length = "0x16B")]
	[Token(Token = "0x60004FD")]
	internal void UpgradeToCm3(CinemachineRotationComposer c) { }

}

