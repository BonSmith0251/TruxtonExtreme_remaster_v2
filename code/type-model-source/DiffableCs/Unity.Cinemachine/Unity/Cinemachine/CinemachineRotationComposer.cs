namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Rotation Control/Cinemachine Rotation Composer")]
[CameraPipeline(Stage::Aim (1))]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineRotationComposer.html")]
[RequiredTarget(RequiredTargets::LookAt (2))]
[SaveDuringPlay]
[Token(Token = "0x200006C")]
public class CinemachineRotationComposer : CinemachineComponentBase, IModifiableComposition
{
	[Token(Token = "0x200006D")]
	private struct FovCache
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001C4")]
		public Rect FovSoftGuideRect; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001C5")]
		public Rect FovHardGuideRect; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001C6")]
		public Vector2 Fov; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001C7")]
		private float m_OrthoSizeOverDistance; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40001C8")]
		private float m_Aspect; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001C9")]
		private Rect m_DeadZoneRect; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40001CA")]
		private Rect m_HardLimitRect; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40001CB")]
		private Vector2 m_ScreenBounds; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40001CC")]
		private Vector2 m_HalfFovRad; //Field offset: 0x58

		[Address(RVA = "0x2831EB0", Offset = "0x28312B0", Length = "0x4B")]
		[IsReadOnly]
		[Token(Token = "0x6000219")]
		public Vector3 DirectionFromScreen(Vector2 p) { }

		[Address(RVA = "0x2831F00", Offset = "0x2831300", Length = "0x93")]
		[IsReadOnly]
		[Token(Token = "0x6000218")]
		private Vector2 ScreenToAngle(Vector2 p) { }

		[Address(RVA = "0x2831FA0", Offset = "0x28313A0", Length = "0x6E5")]
		[Token(Token = "0x6000217")]
		public void UpdateCache(ref LensSettings lens, Rect softGuide, Rect hardGuide, float targetDistance) { }

	}

	[FieldOffset(Offset = "0x28")]
	[Header("Composition")]
	[HideFoldout]
	[Token(Token = "0x40001B7")]
	public ScreenComposerSettings Composition; //Field offset: 0x28
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001B8")]
	[Tooltip("Force target to center of screen when this camera activates.  If false, will clamp target to the edges of the dead zone")]
	public bool CenterOnActivate; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[FormerlySerializedAs("TrackedObjectOffset")]
	[Header("Target Tracking")]
	[Token(Token = "0x40001B9")]
	[Tooltip("Target offset from the target object's center in target-local space. Use this to fine-tune the tracking target position when the desired area is not the tracked object's center.")]
	public Vector3 TargetOffset; //Field offset: 0x54
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40001BA")]
	[Tooltip("How aggressively the camera tries to follow the target in the screen space. Small numbers are more responsive, rapidly orienting the camera to keep the target in the dead zone. Larger numbers give a more heavy slowly responding camera. Using different vertical and horizontal settings can yield a wide range of camera behaviors.")]
	public Vector2 Damping; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[FoldoutWithEnabledButton("Enabled")]
	[Token(Token = "0x40001BB")]
	public LookaheadSettings Lookahead; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40001BC")]
	private Vector3 <TrackedPoint>k__BackingField; //Field offset: 0x78
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x40001BD")]
	private Vector3 m_CameraPosPrevFrame; //Field offset: 0x84
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40001BE")]
	private Vector3 m_LookAtPrevFrame; //Field offset: 0x90
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40001BF")]
	private Vector2 m_ScreenOffsetPrevFrame; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x40001C0")]
	private Quaternion m_CameraOrientationPrevFrame; //Field offset: 0xA4
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x40001C1")]
	internal PositionPredictor m_Predictor; //Field offset: 0xB4
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40001C2")]
	private ScreenComposerSettings m_CompositionLastFrame; //Field offset: 0xE0
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40001C3")]
	private FovCache m_Cache; //Field offset: 0x108

	[Token(Token = "0x17000060")]
	internal virtual bool CameraLooksAtTarget
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000208")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000062")]
	internal ScreenComposerSettings GetEffectiveComposition
	{
		[Address(RVA = "0x28272F0", Offset = "0x28266F0", Length = "0x26")]
		[Token(Token = "0x600020B")]
		internal get { } //Length: 38
	}

	[Token(Token = "0x1700005E")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x2827320", Offset = "0x2826720", Length = "0x6D")]
		[Token(Token = "0x6000206")]
		 get { } //Length: 109
	}

	[Token(Token = "0x1700005F")]
	public virtual Stage Stage
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000207")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000061")]
	internal Vector3 TrackedPoint
	{
		[Address(RVA = "0x1DDF390", Offset = "0x1DDE790", Length = "0x16")]
		[CompilerGenerated]
		[Token(Token = "0x6000209")]
		internal get { } //Length: 22
		[Address(RVA = "0x2827390", Offset = "0x2826790", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600020A")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000063")]
	private override ScreenComposerSettings Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableComposition.Composition
	{
		[Address(RVA = "0x2827170", Offset = "0x2826570", Length = "0x1D")]
		[Token(Token = "0x6000214")]
		private get { } //Length: 29
		[Address(RVA = "0x2827190", Offset = "0x2826590", Length = "0x1A")]
		[Token(Token = "0x6000215")]
		private set { } //Length: 26
	}

	[Address(RVA = "0x28271B0", Offset = "0x28265B0", Length = "0x136")]
	[Token(Token = "0x6000216")]
	public CinemachineRotationComposer() { }

	[Address(RVA = "0x2825280", Offset = "0x2824680", Length = "0x1C9")]
	[Token(Token = "0x6000213")]
	private static bool ClampVerticalBounds(ref Rect r, Vector3 dir, Vector3 up, float fov) { }

	[Address(RVA = "0x2825450", Offset = "0x2824850", Length = "0x1E1")]
	[Token(Token = "0x600020E")]
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000208")]
	internal virtual bool get_CameraLooksAtTarget() { }

	[Address(RVA = "0x28272F0", Offset = "0x28266F0", Length = "0x26")]
	[Token(Token = "0x600020B")]
	internal ScreenComposerSettings get_GetEffectiveComposition() { }

	[Address(RVA = "0x2827320", Offset = "0x2826720", Length = "0x6D")]
	[Token(Token = "0x6000206")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000207")]
	public virtual Stage get_Stage() { }

	[Address(RVA = "0x1DDF390", Offset = "0x1DDE790", Length = "0x16")]
	[CompilerGenerated]
	[Token(Token = "0x6000209")]
	internal Vector3 get_TrackedPoint() { }

	[Address(RVA = "0x2825640", Offset = "0x2824A40", Length = "0x2D3")]
	[Token(Token = "0x600020C")]
	private Vector3 GetLookAtPointAndSetTrackedPoint(Vector3 lookAt, Vector3 up, float deltaTime) { }

	[Address(RVA = "0x2825920", Offset = "0x2824D20", Length = "0xD")]
	[Token(Token = "0x600020F")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x2825930", Offset = "0x2824D30", Length = "0x100B")]
	[Token(Token = "0x6000211")]
	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x2826940", Offset = "0x2825D40", Length = "0x171")]
	[Token(Token = "0x600020D")]
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	[Address(RVA = "0x2826AC0", Offset = "0x2825EC0", Length = "0x27")]
	[Token(Token = "0x6000205")]
	private void OnValidate() { }

	[Address(RVA = "0x2826AF0", Offset = "0x2825EF0", Length = "0x12B")]
	[Token(Token = "0x6000210")]
	public virtual void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x2826C20", Offset = "0x2826020", Length = "0x86")]
	[Token(Token = "0x6000204")]
	private void Reset() { }

	[Address(RVA = "0x2826CB0", Offset = "0x28260B0", Length = "0x4B7")]
	[Token(Token = "0x6000212")]
	private void RotateToScreenBounds(ref CameraState state, Rect screenRect, Vector3 trackedPoint, ref Quaternion rigOrientation, Vector2 fov, float deltaTime) { }

	[Address(RVA = "0x2827390", Offset = "0x2826790", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600020A")]
	private void set_TrackedPoint(Vector3 value) { }

	[Address(RVA = "0x2827170", Offset = "0x2826570", Length = "0x1D")]
	[Token(Token = "0x6000214")]
	private override ScreenComposerSettings Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableComposition.get_Composition() { }

	[Address(RVA = "0x2827190", Offset = "0x2826590", Length = "0x1A")]
	[Token(Token = "0x6000215")]
	private override void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableComposition.set_Composition(ScreenComposerSettings value) { }

}

