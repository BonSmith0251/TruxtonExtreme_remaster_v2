namespace Unity.Cinemachine;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
[ExcludeFromPreset]
[ExecuteAlways]
[Obsolete("CinemachineVirtualCamera is deprecated. Use CinemachineCamera instead.")]
[Token(Token = "0x2000139")]
public class CinemachineVirtualCamera : CinemachineVirtualCameraBase, IRequiresInput
{
	[CompilerGenerated]
	[Token(Token = "0x200013D")]
	private sealed class <>c
	{
		[Token(Token = "0x400053B")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400053C")]
		public static Comparison<CinemachineComponentBase> <>9__44_0; //Field offset: 0x8

		[Address(RVA = "0x2880020", Offset = "0x287F420", Length = "0x67")]
		[Token(Token = "0x600063A")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600063B")]
		public <>c() { }

		[Address(RVA = "0x287FE70", Offset = "0x287F270", Length = "0x5D")]
		[Token(Token = "0x600063C")]
		internal int <UpdateComponentPipeline>b__44_0(CinemachineComponentBase c1, CinemachineComponentBase c2) { }

	}

	[Token(Token = "0x200013B")]
	internal sealed class CreatePipelineDelegate : MulticastDelegate
	{

		[Address(RVA = "0x1C172C0", Offset = "0x1C166C0", Length = "0x125")]
		[Token(Token = "0x6000632")]
		public CreatePipelineDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x213E140", Offset = "0x213D540", Length = "0x35")]
		[Token(Token = "0x6000634")]
		public override IAsyncResult BeginInvoke(CinemachineVirtualCamera vcam, string name, CinemachineComponentBase[] copyFrom, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000635")]
		public override Transform EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x6000633")]
		public override Transform Invoke(CinemachineVirtualCamera vcam, string name, CinemachineComponentBase[] copyFrom) { }

	}

	[Token(Token = "0x200013C")]
	internal sealed class DestroyPipelineDelegate : MulticastDelegate
	{

		[Address(RVA = "0x1FCA570", Offset = "0x1FC9970", Length = "0xB4")]
		[Token(Token = "0x6000636")]
		public DestroyPipelineDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6A0", Offset = "0x5BBAA0", Length = "0x21")]
		[Token(Token = "0x6000638")]
		public override IAsyncResult BeginInvoke(GameObject pipeline, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000639")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6000637")]
		public override void Invoke(GameObject pipeline) { }

	}

	[Token(Token = "0x200013A")]
	private struct LegacyTransitionParams
	{
		[FieldOffset(Offset = "0x0")]
		[FormerlySerializedAs("m_PositionBlending")]
		[Token(Token = "0x4000538")]
		public int m_BlendHint; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000539")]
		public bool m_InheritPosition; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400053A")]
		public OnCameraLiveEvent m_OnCameraLive; //Field offset: 0x8

	}

	[Token(Token = "0x400052F")]
	private const string PipelineName = "cm"; //Field offset: 0x0
	[Token(Token = "0x4000530")]
	public static CreatePipelineDelegate CreatePipelineOverride; //Field offset: 0x0
	[Token(Token = "0x4000531")]
	public static DestroyPipelineDelegate DestroyPipelineOverride; //Field offset: 0x8
	[FieldOffset(Offset = "0xA0")]
	[NoSaveDuringPlay]
	[Token(Token = "0x4000527")]
	[Tooltip("The object that the camera wants to look at (the Aim target).  If this is null, then the vcam's Transform orientation will define the camera's orientation.")]
	[VcamTargetProperty]
	public Transform m_LookAt; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[NoSaveDuringPlay]
	[Token(Token = "0x4000528")]
	[Tooltip("The object that the camera wants to move with (the Body target).  If this is null, then the vcam's Transform position will define the camera's position.")]
	[VcamTargetProperty]
	public Transform m_Follow; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[FormerlySerializedAs("m_LensAttributes")]
	[Token(Token = "0x4000529")]
	[Tooltip("Specifies the lens properties of this Virtual Camera.  This generally mirrors the Unity Camera's lens settings, and will be used to drive the Unity camera when the vcam is active.")]
	public LegacyLensSettings m_Lens; //Field offset: 0xB0
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400052A")]
	[Tooltip("Hint for transitioning to and from this CinemachineCamera.  Hints can be combined, although not all combinations make sense.  In the case of conflicting hints, Cinemachine will make an arbitrary choice.")]
	public BlendHints BlendHint; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400052B")]
	[Tooltip("This event fires when a transition occurs")]
	public OnCameraLiveEvent m_OnCameraLiveEvent; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	[Token(Token = "0x400052C")]
	internal String[] m_ExcludedPropertiesInInspector; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	[Token(Token = "0x400052D")]
	internal Stage[] m_LockStageInInspector; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[FormerlySerializedAs("m_Transitions")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400052E")]
	private LegacyTransitionParams m_LegacyTransitions; //Field offset: 0x120
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000532")]
	private CameraState m_State; //Field offset: 0x130
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000533")]
	private CinemachineComponentBase[] m_ComponentPipeline; //Field offset: 0x240
	[FieldOffset(Offset = "0x248")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000534")]
	private Transform m_ComponentOwner; //Field offset: 0x248
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4000535")]
	private LensSettings m_LensSettings; //Field offset: 0x250
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x4000536")]
	private Transform mCachedLookAtTarget; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2B0")]
	[Token(Token = "0x4000537")]
	private CinemachineVirtualCameraBase mCachedLookAtTargetVcam; //Field offset: 0x2B0

	[Token(Token = "0x1700013D")]
	public virtual Transform Follow
	{
		[Address(RVA = "0x2863310", Offset = "0x2862710", Length = "0xF")]
		[Token(Token = "0x6000617")]
		 get { } //Length: 15
		[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
		[Token(Token = "0x6000618")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700013A")]
	protected private virtual bool IsDprecated
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000613")]
		private get { } //Length: 3
	}

	[Token(Token = "0x1700013C")]
	public virtual Transform LookAt
	{
		[Address(RVA = "0x2863320", Offset = "0x2862720", Length = "0xF")]
		[Token(Token = "0x6000615")]
		 get { } //Length: 15
		[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
		[Token(Token = "0x6000616")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700013B")]
	public virtual CameraState State
	{
		[Address(RVA = "0x287D640", Offset = "0x287CA40", Length = "0x76")]
		[Token(Token = "0x6000614")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x287D330", Offset = "0x287C730", Length = "0x305")]
	[Token(Token = "0x6000631")]
	public CinemachineVirtualCamera() { }

	[Address(RVA = "0x79D2F0", Offset = "0x79C6F0", Length = "0x22C")]
	[Token(Token = "0x6000627")]
	public T AddCinemachineComponent() { }

	[Address(RVA = "0x287AA90", Offset = "0x2879E90", Length = "0x675")]
	[Token(Token = "0x600062B")]
	private CameraState CalculateNewState(Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x287B110", Offset = "0x287A510", Length = "0x1E8")]
	[Token(Token = "0x6000621")]
	internal Transform CreatePipeline(CinemachineVirtualCamera copyFrom) { }

	[Address(RVA = "0x79D520", Offset = "0x79C920", Length = "0xFF")]
	[Token(Token = "0x6000628")]
	public void DestroyCinemachineComponent() { }

	[Address(RVA = "0x287B300", Offset = "0x287A700", Length = "0x57C")]
	[Token(Token = "0x6000620")]
	internal void DestroyPipeline() { }

	[Address(RVA = "0x287B880", Offset = "0x287AC80", Length = "0x192")]
	[Token(Token = "0x600062D")]
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x2863310", Offset = "0x2862710", Length = "0xF")]
	[Token(Token = "0x6000617")]
	public virtual Transform get_Follow() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000613")]
	protected private virtual bool get_IsDprecated() { }

	[Address(RVA = "0x2863320", Offset = "0x2862720", Length = "0xF")]
	[Token(Token = "0x6000615")]
	public virtual Transform get_LookAt() { }

	[Address(RVA = "0x287D640", Offset = "0x287CA40", Length = "0x76")]
	[Token(Token = "0x6000614")]
	public virtual CameraState get_State() { }

	[Address(RVA = "0x287BA20", Offset = "0x287AE20", Length = "0xA2")]
	[Token(Token = "0x6000625")]
	public virtual CinemachineComponentBase GetCinemachineComponent(Stage stage) { }

	[Address(RVA = "0x79D620", Offset = "0x79CA20", Length = "0xCB")]
	[Token(Token = "0x6000626")]
	public T GetCinemachineComponent() { }

	[Address(RVA = "0x287BAD0", Offset = "0x287AED0", Length = "0x1D")]
	[Token(Token = "0x6000623")]
	public Transform GetComponentOwner() { }

	[Address(RVA = "0x287BAF0", Offset = "0x287AEF0", Length = "0x1D")]
	[Token(Token = "0x6000624")]
	public CinemachineComponentBase[] GetComponentPipeline() { }

	[Address(RVA = "0x287BB10", Offset = "0x287AF10", Length = "0xB8")]
	[Token(Token = "0x6000619")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x287BBD0", Offset = "0x287AFD0", Length = "0x3C3")]
	[Token(Token = "0x600061A")]
	public virtual void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x287BFA0", Offset = "0x287B3A0", Length = "0x19")]
	[Token(Token = "0x6000622")]
	public void InvalidateComponentPipeline() { }

	[Address(RVA = "0x287BFC0", Offset = "0x287B3C0", Length = "0x2AF")]
	[Token(Token = "0x600061C")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x287C270", Offset = "0x287B670", Length = "0x1D6")]
	[Token(Token = "0x600061B")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x287C450", Offset = "0x287B850", Length = "0x21B")]
	[Token(Token = "0x600062C")]
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	[Address(RVA = "0x287BFA0", Offset = "0x287B3A0", Length = "0x19")]
	[Token(Token = "0x600061E")]
	private void OnTransformChildrenChanged() { }

	[Address(RVA = "0x287C670", Offset = "0x287BA70", Length = "0x486")]
	[Token(Token = "0x600062F")]
	public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x287CB00", Offset = "0x287BF00", Length = "0xE")]
	[Token(Token = "0x600061D")]
	protected void OnValidate() { }

	[Address(RVA = "0x287CB10", Offset = "0x287BF10", Length = "0xA3")]
	[Token(Token = "0x6000612")]
	protected private virtual void PerformLegacyUpgrade(int streamedVersion) { }

	[Address(RVA = "0x287CBC0", Offset = "0x287BFC0", Length = "0x2D")]
	[Token(Token = "0x600061F")]
	private void Reset() { }

	[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
	[Token(Token = "0x6000618")]
	public virtual void set_Follow(Transform value) { }

	[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
	[Token(Token = "0x6000616")]
	public virtual void set_LookAt(Transform value) { }

	[Address(RVA = "0x287CBF0", Offset = "0x287BFF0", Length = "0x7A")]
	[Token(Token = "0x600062A")]
	internal static void SetFlagsForHiddenChild(GameObject child) { }

	[Address(RVA = "0x287CC70", Offset = "0x287C070", Length = "0x16")]
	[Token(Token = "0x600062E")]
	internal void SetStateRawPosition(Vector3 pos) { }

	[Address(RVA = "0x287CC90", Offset = "0x287C090", Length = "0x140")]
	[Token(Token = "0x6000630")]
	private override bool Unity.Cinemachine.AxisState.IRequiresInput.RequiresInput() { }

	[Address(RVA = "0x287CDE0", Offset = "0x287C1E0", Length = "0x544")]
	[Token(Token = "0x6000629")]
	private void UpdateComponentPipeline() { }

}

