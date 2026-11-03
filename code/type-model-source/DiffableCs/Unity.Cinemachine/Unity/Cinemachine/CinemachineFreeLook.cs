namespace Unity.Cinemachine;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
[ExcludeFromPreset]
[ExecuteAlways]
[Obsolete("This is deprecated. Use Create -> Cinemachine -> FreeLook camera, or create a CinemachineCamera with appropriate components")]
[Token(Token = "0x2000111")]
public class CinemachineFreeLook : CinemachineVirtualCameraBase, IRequiresInput, ICinemachineMixer, ICinemachineCamera
{
	[CompilerGenerated]
	[Token(Token = "0x2000116")]
	private struct <>c__DisplayClass52_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000481")]
		public CinemachineFreeLook <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000482")]
		public Vector3 cameraOffset; //Field offset: 0x8

	}

	[CompilerGenerated]
	[Token(Token = "0x2000117")]
	private struct <>c__DisplayClass52_1
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000483")]
		public float bestAngle; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000484")]
		public float best; //Field offset: 0x4

	}

	[Token(Token = "0x2000114")]
	internal sealed class CreateRigDelegate : MulticastDelegate
	{

		[Address(RVA = "0x1C172C0", Offset = "0x1C166C0", Length = "0x125")]
		[Token(Token = "0x6000562")]
		public CreateRigDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x213E140", Offset = "0x213D540", Length = "0x35")]
		[Token(Token = "0x6000564")]
		public override IAsyncResult BeginInvoke(CinemachineFreeLook vcam, string name, CinemachineVirtualCamera copyFrom, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000565")]
		public override CinemachineVirtualCamera EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x6000563")]
		public override CinemachineVirtualCamera Invoke(CinemachineFreeLook vcam, string name, CinemachineVirtualCamera copyFrom) { }

	}

	[Token(Token = "0x2000115")]
	internal sealed class DestroyRigDelegate : MulticastDelegate
	{

		[Address(RVA = "0x1FCA570", Offset = "0x1FC9970", Length = "0xB4")]
		[Token(Token = "0x6000566")]
		public DestroyRigDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6A0", Offset = "0x5BBAA0", Length = "0x21")]
		[Token(Token = "0x6000568")]
		public override IAsyncResult BeginInvoke(GameObject rig, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000569")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6000567")]
		public override void Invoke(GameObject rig) { }

	}

	[Token(Token = "0x2000113")]
	private struct LegacyTransitionParams
	{
		[FieldOffset(Offset = "0x0")]
		[FormerlySerializedAs("m_PositionBlending")]
		[Token(Token = "0x400047E")]
		public int m_BlendHint; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400047F")]
		public bool m_InheritPosition; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000480")]
		public OnCameraLiveEvent m_OnCameraLive; //Field offset: 0x8

	}

	[Token(Token = "0x2000112")]
	internal struct Orbit
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400047C")]
		public float m_Height; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400047D")]
		public float m_Radius; //Field offset: 0x4

		[Address(RVA = "0x12F1450", Offset = "0x12F0850", Length = "0xA")]
		[Token(Token = "0x6000561")]
		public Orbit(float h, float r) { }

	}

	[Token(Token = "0x4000472")]
	public static CreateRigDelegate CreateRigOverride; //Field offset: 0x0
	[Token(Token = "0x4000473")]
	public static DestroyRigDelegate DestroyRigOverride; //Field offset: 0x8
	[FieldOffset(Offset = "0xA0")]
	[NoSaveDuringPlay]
	[Token(Token = "0x400045B")]
	[Tooltip("Object for the camera children to look at (the aim target).")]
	[VcamTargetProperty]
	public Transform m_LookAt; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[NoSaveDuringPlay]
	[Token(Token = "0x400045C")]
	[Tooltip("Object for the camera children wants to move with (the body target).")]
	[VcamTargetProperty]
	public Transform m_Follow; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[FormerlySerializedAs("m_UseCommonLensSetting")]
	[Token(Token = "0x400045D")]
	[Tooltip("If enabled, this lens setting will apply to all three child rigs, otherwise the child rig lens settings will be used")]
	public bool m_CommonLens; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[FormerlySerializedAs("m_LensAttributes")]
	[Token(Token = "0x400045E")]
	[Tooltip("Specifies the lens properties of this Virtual Camera.  This generally mirrors the Unity Camera's lens settings, and will be used to drive the Unity camera when the vcam is active")]
	public LegacyLensSettings m_Lens; //Field offset: 0xB4
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x400045F")]
	[Tooltip("Hint for transitioning to and from this CinemachineCamera.  Hints can be combined, although not all combinations make sense.  In the case of conflicting hints, Cinemachine will make an arbitrary choice.")]
	public BlendHints BlendHint; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000460")]
	[Tooltip("This event fires when a transition occurs")]
	public OnCameraLiveEvent m_OnCameraLiveEvent; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Header("Axis Control")]
	[Token(Token = "0x4000461")]
	[Tooltip("The Vertical axis.  Value is 0..1.  Chooses how to blend the child rigs")]
	public AxisState m_YAxis; //Field offset: 0x110
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4000462")]
	[Tooltip("Controls how automatic recentering of the Y axis is accomplished")]
	public Recentering m_YAxisRecentering; //Field offset: 0x180
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000463")]
	[Tooltip("The Horizontal axis.  Value is -180...180.  This is passed on to the rigs' OrbitalTransposer component")]
	public AxisState m_XAxis; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4000464")]
	[Tooltip("The definition of Forward.  Camera will follow behind.")]
	public Heading m_Heading; //Field offset: 0x210
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000465")]
	[Tooltip("Controls how automatic recentering of the X axis is accomplished")]
	public Recentering m_RecenterToTargetHeading; //Field offset: 0x21C
	[FieldOffset(Offset = "0x23C")]
	[Header("Orbits")]
	[Token(Token = "0x4000466")]
	[Tooltip("The coordinate space to use when interpreting the offset from the target.  This is also used to set the camera's Up vector, which will be maintained when aiming the camera.")]
	public BindingMode m_BindingMode; //Field offset: 0x23C
	[FieldOffset(Offset = "0x240")]
	[FormerlySerializedAs("m_SplineTension")]
	[Range(0, 1)]
	[Token(Token = "0x4000467")]
	[Tooltip("Controls how taut is the line that connects the rigs' orbits, which determines final placement on the Y axis")]
	public float m_SplineCurvature; //Field offset: 0x240
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000468")]
	[Tooltip("The radius and height of the three orbiting rigs.")]
	public Orbit[] m_Orbits; //Field offset: 0x248
	[FieldOffset(Offset = "0x250")]
	[FormerlySerializedAs("m_HeadingBias")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000469")]
	private float m_LegacyHeadingBias; //Field offset: 0x250
	[FieldOffset(Offset = "0x254")]
	[Token(Token = "0x400046A")]
	private bool mUseLegacyRigDefinitions; //Field offset: 0x254
	[FieldOffset(Offset = "0x258")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400046B")]
	private LegacyTransitionParams m_LegacyTransitions; //Field offset: 0x258
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x400046C")]
	private bool mIsDestroyed; //Field offset: 0x268
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x400046D")]
	private CameraState m_State; //Field offset: 0x270
	[FieldOffset(Offset = "0x380")]
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	[Token(Token = "0x400046E")]
	private CinemachineVirtualCamera[] m_Rigs; //Field offset: 0x380
	[FieldOffset(Offset = "0x388")]
	[Token(Token = "0x400046F")]
	private CinemachineOrbitalTransposer[] mOrbitals; //Field offset: 0x388
	[FieldOffset(Offset = "0x390")]
	[Token(Token = "0x4000470")]
	private CinemachineBlend mBlendA; //Field offset: 0x390
	[FieldOffset(Offset = "0x398")]
	[Token(Token = "0x4000471")]
	private CinemachineBlend mBlendB; //Field offset: 0x398
	[FieldOffset(Offset = "0x3A0")]
	[Token(Token = "0x4000474")]
	private float m_CachedXAxisHeading; //Field offset: 0x3A0
	[FieldOffset(Offset = "0x3A4")]
	[Token(Token = "0x4000475")]
	private float m_LastHeadingUpdateFrame; //Field offset: 0x3A4
	[FieldOffset(Offset = "0x3A8")]
	[Token(Token = "0x4000476")]
	private LensSettings m_LensSettings; //Field offset: 0x3A8
	[FieldOffset(Offset = "0x400")]
	[Token(Token = "0x4000477")]
	private Orbit[] m_CachedOrbits; //Field offset: 0x400
	[FieldOffset(Offset = "0x408")]
	[Token(Token = "0x4000478")]
	private float m_CachedTension; //Field offset: 0x408
	[FieldOffset(Offset = "0x410")]
	[Token(Token = "0x4000479")]
	private Vector4[] m_CachedKnots; //Field offset: 0x410
	[FieldOffset(Offset = "0x418")]
	[Token(Token = "0x400047A")]
	private Vector4[] m_CachedCtrl1; //Field offset: 0x418
	[FieldOffset(Offset = "0x420")]
	[Token(Token = "0x400047B")]
	private Vector4[] m_CachedCtrl2; //Field offset: 0x420

	[Token(Token = "0x1700011B")]
	public virtual Transform Follow
	{
		[Address(RVA = "0x2863310", Offset = "0x2862710", Length = "0xF")]
		[Token(Token = "0x6000547")]
		 get { } //Length: 15
		[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
		[Token(Token = "0x6000548")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000115")]
	protected private virtual bool IsDprecated
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000538")]
		private get { } //Length: 3
	}

	[Token(Token = "0x1700011A")]
	public virtual Transform LookAt
	{
		[Address(RVA = "0x2863320", Offset = "0x2862720", Length = "0xF")]
		[Token(Token = "0x6000545")]
		 get { } //Length: 15
		[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
		[Token(Token = "0x6000546")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000118")]
	public virtual bool PreviousStateIsValid
	{
		[Address(RVA = "0xD11AF0", Offset = "0xD10EF0", Length = "0x8")]
		[Token(Token = "0x6000542")]
		 get { } //Length: 8
		[Address(RVA = "0x28634A0", Offset = "0x28628A0", Length = "0x115")]
		[Token(Token = "0x6000543")]
		 set { } //Length: 277
	}

	[Token(Token = "0x17000117")]
	public static String[] RigNames
	{
		[Address(RVA = "0x2863330", Offset = "0x2862730", Length = "0xC1")]
		[Token(Token = "0x600053C")]
		 get { } //Length: 193
	}

	[Token(Token = "0x17000116")]
	internal bool RigsAreCreated
	{
		[Address(RVA = "0x2863400", Offset = "0x2862800", Length = "0x1C")]
		[Token(Token = "0x600053B")]
		internal get { } //Length: 28
	}

	[Token(Token = "0x17000119")]
	public virtual CameraState State
	{
		[Address(RVA = "0x2863420", Offset = "0x2862820", Length = "0x76")]
		[Token(Token = "0x6000544")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x2862C60", Offset = "0x2862060", Length = "0x6A6")]
	[Token(Token = "0x600055C")]
	public CinemachineFreeLook() { }

	[Address(RVA = "0x28619C0", Offset = "0x2860DC0", Length = "0xBF")]
	[CompilerGenerated]
	[Token(Token = "0x600055D")]
	private float <SteepestDescent>g__AngleFunction|52_0(float input, ref <>c__DisplayClass52_0 unnamed_param_1) { }

	[Address(RVA = "0x2861A80", Offset = "0x2860E80", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x6000560")]
	private void <SteepestDescent>g__ChooseBestAngle|52_3(float x, ref <>c__DisplayClass52_0 unnamed_param_1, ref <>c__DisplayClass52_1 unnamed_param_2) { }

	[Address(RVA = "0x2861AC0", Offset = "0x2860EC0", Length = "0x108")]
	[CompilerGenerated]
	[Token(Token = "0x600055F")]
	private float <SteepestDescent>g__InitialGuess|52_2(ref <>c__DisplayClass52_0 unnamed_param_0) { }

	[Address(RVA = "0x2861BD0", Offset = "0x2860FD0", Length = "0x6F")]
	[CompilerGenerated]
	[Token(Token = "0x600055E")]
	private float <SteepestDescent>g__SlopeOfAngleFunction|52_1(float input, ref <>c__DisplayClass52_0 unnamed_param_1) { }

	[Address(RVA = "0x285DB30", Offset = "0x285CF30", Length = "0x34D")]
	[Token(Token = "0x6000559")]
	private CameraState CalculateNewState(Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x285DE80", Offset = "0x285D280", Length = "0x9A5")]
	[Token(Token = "0x6000553")]
	private CinemachineVirtualCamera[] CreateRigs(CinemachineVirtualCamera[] copyFrom) { }

	[Address(RVA = "0x285E830", Offset = "0x285DC30", Length = "0x516")]
	[Token(Token = "0x6000552")]
	private void DestroyRigs() { }

	[Address(RVA = "0x285ED50", Offset = "0x285E150", Length = "0x331")]
	[Token(Token = "0x600054B")]
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x2863310", Offset = "0x2862710", Length = "0xF")]
	[Token(Token = "0x6000547")]
	public virtual Transform get_Follow() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000538")]
	protected private virtual bool get_IsDprecated() { }

	[Address(RVA = "0x2863320", Offset = "0x2862720", Length = "0xF")]
	[Token(Token = "0x6000545")]
	public virtual Transform get_LookAt() { }

	[Address(RVA = "0xD11AF0", Offset = "0xD10EF0", Length = "0x8")]
	[Token(Token = "0x6000542")]
	public virtual bool get_PreviousStateIsValid() { }

	[Address(RVA = "0x2863330", Offset = "0x2862730", Length = "0xC1")]
	[Token(Token = "0x600053C")]
	public static String[] get_RigNames() { }

	[Address(RVA = "0x2863400", Offset = "0x2862800", Length = "0x1C")]
	[Token(Token = "0x600053B")]
	internal bool get_RigsAreCreated() { }

	[Address(RVA = "0x2863420", Offset = "0x2862820", Length = "0x76")]
	[Token(Token = "0x6000544")]
	public virtual CameraState get_State() { }

	[Address(RVA = "0x285F090", Offset = "0x285E490", Length = "0x29B")]
	[Token(Token = "0x600055A")]
	public Vector3 GetLocalPositionForCameraFromInput(float t) { }

	[Address(RVA = "0x285F330", Offset = "0x285E730", Length = "0x59")]
	[Token(Token = "0x600053A")]
	public CinemachineVirtualCamera GetRig(int i) { }

	[Address(RVA = "0x285F390", Offset = "0x285E790", Length = "0x44F")]
	[Token(Token = "0x600054F")]
	private float GetYAxisClosestValue(Vector3 cameraPos, Vector3 up) { }

	[Address(RVA = "0x285F7E0", Offset = "0x285EBE0", Length = "0x2F")]
	[Token(Token = "0x6000558")]
	private float GetYAxisValue() { }

	[Address(RVA = "0x285F810", Offset = "0x285EC10", Length = "0x8E0")]
	[Token(Token = "0x600054C")]
	public virtual void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x2860100", Offset = "0x285F500", Length = "0x19")]
	[Token(Token = "0x6000551")]
	private void InvalidateRigCache() { }

	[Address(RVA = "0x2860120", Offset = "0x285F520", Length = "0x107")]
	[Token(Token = "0x6000549")]
	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false) { }

	[Address(RVA = "0x2860230", Offset = "0x285F630", Length = "0x46F")]
	[Token(Token = "0x6000555")]
	private List<CinemachineVirtualCamera> LocateExistingRigs(bool forceOrbital) { }

	[Address(RVA = "0x28606A0", Offset = "0x285FAA0", Length = "0x14A")]
	[Token(Token = "0x600053F")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x28607F0", Offset = "0x285FBF0", Length = "0xF0")]
	[Token(Token = "0x600053D")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x28608E0", Offset = "0x285FCE0", Length = "0xE6")]
	[Token(Token = "0x600054A")]
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	[Address(RVA = "0x2860100", Offset = "0x285F500", Length = "0x19")]
	[Token(Token = "0x6000540")]
	private void OnTransformChildrenChanged() { }

	[Address(RVA = "0x28609D0", Offset = "0x285FDD0", Length = "0x463")]
	[Token(Token = "0x600054D")]
	public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x2860E40", Offset = "0x2860240", Length = "0x155")]
	[Token(Token = "0x6000539")]
	private void OnValidate() { }

	[Address(RVA = "0x2860FA0", Offset = "0x28603A0", Length = "0x10C")]
	[Token(Token = "0x6000537")]
	protected private virtual void PerformLegacyUpgrade(int streamedVersion) { }

	[Address(RVA = "0x28610B0", Offset = "0x28604B0", Length = "0x6B3")]
	[Token(Token = "0x6000557")]
	private void PushSettingsToRigs() { }

	[Address(RVA = "0x2861770", Offset = "0x2860B70", Length = "0x2D")]
	[Token(Token = "0x6000541")]
	private void Reset() { }

	[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
	[Token(Token = "0x6000548")]
	public virtual void set_Follow(Transform value) { }

	[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
	[Token(Token = "0x6000546")]
	public virtual void set_LookAt(Transform value) { }

	[Address(RVA = "0x28634A0", Offset = "0x28628A0", Length = "0x115")]
	[Token(Token = "0x6000543")]
	public virtual void set_PreviousStateIsValid(bool value) { }

	[Address(RVA = "0x28617A0", Offset = "0x2860BA0", Length = "0x219")]
	[Token(Token = "0x6000550")]
	private float SteepestDescent(Vector3 cameraOffset) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600054E")]
	private override bool Unity.Cinemachine.AxisState.IRequiresInput.RequiresInput() { }

	[Address(RVA = "0x2861C40", Offset = "0x2861040", Length = "0x56B")]
	[Token(Token = "0x600055B")]
	private void UpdateCachedSpline() { }

	[Address(RVA = "0x28621B0", Offset = "0x28615B0", Length = "0xCD")]
	[Token(Token = "0x600053E")]
	internal void UpdateInputAxisProvider() { }

	[Address(RVA = "0x2862280", Offset = "0x2861680", Length = "0x7AC")]
	[Token(Token = "0x6000554")]
	private bool UpdateRigCache() { }

	[Address(RVA = "0x2862A30", Offset = "0x2861E30", Length = "0x224")]
	[Token(Token = "0x6000556")]
	private float UpdateXAxisHeading(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up) { }

}

