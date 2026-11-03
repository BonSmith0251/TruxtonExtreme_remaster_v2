namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Position Control/Cinemachine Position Composer")]
[CameraPipeline(Stage::Body (0))]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachinePositionComposer.html")]
[RequiredTarget(RequiredTargets::Tracking (1))]
[SaveDuringPlay]
[Token(Token = "0x200006A")]
public class CinemachinePositionComposer : CinemachineComponentBase, IModifiablePositionDamping, IModifiableDistance, IModifiableComposition
{
	[Token(Token = "0x40001AD")]
	private const float kMinimumCameraDistance = 0.01; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Header("Camera Position")]
	[Token(Token = "0x40001A6")]
	[Tooltip("The distance along the camera axis that will be maintained from the target")]
	public float CameraDistance; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40001A7")]
	[Tooltip("The camera will not move along its z-axis if the target is within this distance of the specified camera distance")]
	public float DeadZoneDepth; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Header("Composition")]
	[HideFoldout]
	[Token(Token = "0x40001A8")]
	public ScreenComposerSettings Composition; //Field offset: 0x30
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001A9")]
	[Tooltip("Force target to center of screen when this camera activates.  If false, will clamp target to the edges of the dead zone")]
	public bool CenterOnActivate; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[FormerlySerializedAs("TrackedObjectOffset")]
	[Header("Target Tracking")]
	[Token(Token = "0x40001AA")]
	[Tooltip("Offset from the target object (in target-local co-ordinates).  The camera will attempt to frame the point which is the target's position plus this offset.  Use it to correct for cases when the target's origin is not the point of interest for the camera.")]
	public Vector3 TargetOffset; //Field offset: 0x5C
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40001AB")]
	[Tooltip("How aggressively the camera tries to follow the target in the screen space. Small numbers are more responsive, rapidly orienting the camera to keep the target in the dead zone. Larger numbers give a more heavy slowly responding camera. Using different vertical and horizontal settings can yield a wide range of camera behaviors.")]
	public Vector3 Damping; //Field offset: 0x68
	[FieldOffset(Offset = "0x74")]
	[FoldoutWithEnabledButton("Enabled")]
	[Token(Token = "0x40001AC")]
	public LookaheadSettings Lookahead; //Field offset: 0x74
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x40001AE")]
	internal PositionPredictor m_Predictor; //Field offset: 0x84
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40001AF")]
	private Vector3 m_PreviousCameraPosition; //Field offset: 0xB0
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x40001B0")]
	private Quaternion m_PreviousRotation; //Field offset: 0xBC
	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x40001B1")]
	private ScreenComposerSettings m_PreviousComposition; //Field offset: 0xCC
	[FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x40001B2")]
	private float m_PreviousDesiredDistance; //Field offset: 0xF4
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40001B3")]
	private bool m_InheritingPosition; //Field offset: 0xF8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x40001B4")]
	private Vector3 <TrackedPoint>k__BackingField; //Field offset: 0xFC

	[Token(Token = "0x1700005A")]
	public virtual bool BodyAppliesAfterAim
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60001F4")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000054")]
	internal ScreenComposerSettings GetEffectiveComposition
	{
		[Address(RVA = "0x2824F70", Offset = "0x2824370", Length = "0x26")]
		[Token(Token = "0x60001E9")]
		internal get { } //Length: 38
	}

	[Token(Token = "0x17000058")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x2824FA0", Offset = "0x28243A0", Length = "0x6D")]
		[Token(Token = "0x60001F2")]
		 get { } //Length: 109
	}

	[Token(Token = "0x17000059")]
	public virtual Stage Stage
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60001F3")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700005B")]
	internal Vector3 TrackedPoint
	{
		[Address(RVA = "0x2825010", Offset = "0x2824410", Length = "0x19")]
		[CompilerGenerated]
		[Token(Token = "0x60001F5")]
		internal get { } //Length: 25
		[Address(RVA = "0x2825030", Offset = "0x2824430", Length = "0x16")]
		[CompilerGenerated]
		[Token(Token = "0x60001F6")]
		private set { } //Length: 22
	}

	[Token(Token = "0x17000055")]
	private override ScreenComposerSettings Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableComposition.Composition
	{
		[Address(RVA = "0x2824EA0", Offset = "0x28242A0", Length = "0x1D")]
		[Token(Token = "0x60001EC")]
		private get { } //Length: 29
		[Address(RVA = "0x2824EC0", Offset = "0x28242C0", Length = "0x1A")]
		[Token(Token = "0x60001ED")]
		private set { } //Length: 26
	}

	[Token(Token = "0x17000057")]
	private override float Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.Distance
	{
		[Address(RVA = "0x1D376B0", Offset = "0x1D36AB0", Length = "0x6")]
		[Token(Token = "0x60001F0")]
		private get { } //Length: 6
		[Address(RVA = "0x1D3E540", Offset = "0x1D3D940", Length = "0x6")]
		[Token(Token = "0x60001F1")]
		private set { } //Length: 6
	}

	[Token(Token = "0x17000056")]
	private override Vector3 Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.PositionDamping
	{
		[Address(RVA = "0x16D0940", Offset = "0x16CFD40", Length = "0x13")]
		[Token(Token = "0x60001EE")]
		private get { } //Length: 19
		[Address(RVA = "0x16D0B90", Offset = "0x16CFF90", Length = "0x10")]
		[Token(Token = "0x60001EF")]
		private set { } //Length: 16
	}

	[Address(RVA = "0x2824EE0", Offset = "0x28242E0", Length = "0x87")]
	[Token(Token = "0x60001FE")]
	public CinemachinePositionComposer() { }

	[Address(RVA = "0x2823440", Offset = "0x2822840", Length = "0x1E1")]
	[Token(Token = "0x60001F8")]
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60001F4")]
	public virtual bool get_BodyAppliesAfterAim() { }

	[Address(RVA = "0x2824F70", Offset = "0x2824370", Length = "0x26")]
	[Token(Token = "0x60001E9")]
	internal ScreenComposerSettings get_GetEffectiveComposition() { }

	[Address(RVA = "0x2824FA0", Offset = "0x28243A0", Length = "0x6D")]
	[Token(Token = "0x60001F2")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60001F3")]
	public virtual Stage get_Stage() { }

	[Address(RVA = "0x2825010", Offset = "0x2824410", Length = "0x19")]
	[CompilerGenerated]
	[Token(Token = "0x60001F5")]
	internal Vector3 get_TrackedPoint() { }

	[Address(RVA = "0x2823630", Offset = "0x2822A30", Length = "0x16")]
	[Token(Token = "0x60001F9")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x2823650", Offset = "0x2822A50", Length = "0xFFC")]
	[Token(Token = "0x60001FD")]
	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x2824650", Offset = "0x2823A50", Length = "0x11C")]
	[Token(Token = "0x60001F7")]
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	[Address(RVA = "0x2824770", Offset = "0x2823B70", Length = "0x293")]
	[Token(Token = "0x60001FA")]
	public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x2824A10", Offset = "0x2823E10", Length = "0x53")]
	[Token(Token = "0x60001EB")]
	private void OnValidate() { }

	[Address(RVA = "0x2824A70", Offset = "0x2823E70", Length = "0x1DD")]
	[Token(Token = "0x60001FC")]
	private Vector3 OrthoOffsetToScreenBounds(Vector3 targetPos2D, Rect screenRect) { }

	[Address(RVA = "0x2824C50", Offset = "0x2824050", Length = "0xC0")]
	[Token(Token = "0x60001EA")]
	private void Reset() { }

	[Address(RVA = "0x2824D10", Offset = "0x2824110", Length = "0x18C")]
	[Token(Token = "0x60001FB")]
	private Rect ScreenToOrtho(Rect rScreen, float orthoSize, float aspect) { }

	[Address(RVA = "0x2825030", Offset = "0x2824430", Length = "0x16")]
	[CompilerGenerated]
	[Token(Token = "0x60001F6")]
	private void set_TrackedPoint(Vector3 value) { }

	[Address(RVA = "0x2824EA0", Offset = "0x28242A0", Length = "0x1D")]
	[Token(Token = "0x60001EC")]
	private override ScreenComposerSettings Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableComposition.get_Composition() { }

	[Address(RVA = "0x2824EC0", Offset = "0x28242C0", Length = "0x1A")]
	[Token(Token = "0x60001ED")]
	private override void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableComposition.set_Composition(ScreenComposerSettings value) { }

	[Address(RVA = "0x1D376B0", Offset = "0x1D36AB0", Length = "0x6")]
	[Token(Token = "0x60001F0")]
	private override float Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.get_Distance() { }

	[Address(RVA = "0x1D3E540", Offset = "0x1D3D940", Length = "0x6")]
	[Token(Token = "0x60001F1")]
	private override void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.set_Distance(float value) { }

	[Address(RVA = "0x16D0940", Offset = "0x16CFD40", Length = "0x13")]
	[Token(Token = "0x60001EE")]
	private override Vector3 Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.get_PositionDamping() { }

	[Address(RVA = "0x16D0B90", Offset = "0x16CFF90", Length = "0x10")]
	[Token(Token = "0x60001EF")]
	private override void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.set_PositionDamping(Vector3 value) { }

}

