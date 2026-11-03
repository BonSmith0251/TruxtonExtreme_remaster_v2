namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Extensions/Cinemachine Volume Settings")]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineVolumeSettings.html")]
[SaveDuringPlay]
[Token(Token = "0x2000165")]
public class CinemachineVolumeSettings : CinemachineExtension
{
	[Token(Token = "0x2000166")]
	internal enum FocusTrackingMode : int
	{
		None = 0,
		LookAtTarget = 1,
		FollowTarget = 2,
		CustomTarget = 3,
		Camera = 4,
	}

	[Token(Token = "0x2000167")]
	private class VcamExtraState : VcamExtraStateBase
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400060E")]
		public VolumeProfile ProfileCopy; //Field offset: 0x18

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60006E2")]
		public VcamExtraState() { }

		[Address(RVA = "0x289D160", Offset = "0x289C560", Length = "0x1F3")]
		[Token(Token = "0x60006E0")]
		public void CreateProfileCopy(VolumeProfile source) { }

		[Address(RVA = "0x289D360", Offset = "0x289C760", Length = "0x9F")]
		[Token(Token = "0x60006E1")]
		public void DestroyProfileCopy() { }

	}

	[Token(Token = "0x40005FE")]
	public static float s_VolumePriority; //Field offset: 0x0
	[Token(Token = "0x4000606")]
	private const string sVolumeOwnerName = "__CMVolumes"; //Field offset: 0x0
	[Token(Token = "0x4000607")]
	private static List<Volume> sVolumes; //Field offset: 0x8
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005FF")]
	public float Weight; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[FormerlySerializedAs("m_FocusTracking")]
	[Token(Token = "0x4000600")]
	[Tooltip("If the profile has the appropriate overrides, will set the base focus distance to be the distance from the selected target to the camera.The Focus Offset field will then modify that distance.")]
	public FocusTrackingMode FocusTracking; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("m_FocusTarget")]
	[Token(Token = "0x4000601")]
	[Tooltip("The target to use if Focus Tracks Target is set to Custom Target")]
	public Transform FocusTarget; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("m_FocusOffset")]
	[Token(Token = "0x4000602")]
	[Tooltip("Offset from target distance, to be used with Focus Tracks Target.  Offsets the sharpest point away from the focus target.")]
	public float FocusOffset; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000603")]
	private float <CalculatedFocusDistance>k__BackingField; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[FormerlySerializedAs("m_Profile")]
	[Token(Token = "0x4000604")]
	[Tooltip("This profile will be applied whenever this virtual camera is live")]
	public VolumeProfile Profile; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000605")]
	private List<VcamExtraState> m_extraStateCache; //Field offset: 0x50

	[Token(Token = "0x17000148")]
	public private float CalculatedFocusDistance
	{
		[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60006D1")]
		 get { } //Length: 6
		[Address(RVA = "0x1E08FF0", Offset = "0x1E083F0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60006D2")]
		private set { } //Length: 6
	}

	[Token(Token = "0x17000149")]
	public bool IsValid
	{
		[Address(RVA = "0x2884620", Offset = "0x2883A20", Length = "0x93")]
		[Token(Token = "0x60006D3")]
		 get { } //Length: 147
	}

	[Address(RVA = "0x2884570", Offset = "0x2883970", Length = "0x9D")]
	[Token(Token = "0x60006DF")]
	private static CinemachineVolumeSettings() { }

	[Address(RVA = "0x2884610", Offset = "0x2883A10", Length = "0xE")]
	[Token(Token = "0x60006DE")]
	public CinemachineVolumeSettings() { }

	[Address(RVA = "0x2883300", Offset = "0x2882700", Length = "0x45F")]
	[Token(Token = "0x60006DB")]
	private static void ApplyPostFX(CinemachineBrain brain) { }

	[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x60006D1")]
	public float get_CalculatedFocusDistance() { }

	[Address(RVA = "0x2884620", Offset = "0x2883A20", Length = "0x93")]
	[Token(Token = "0x60006D3")]
	public bool get_IsValid() { }

	[Address(RVA = "0x2883760", Offset = "0x2882B60", Length = "0x476")]
	[Token(Token = "0x60006DC")]
	private static List<Volume> GetDynamicBrainVolumes(CinemachineBrain brain, int minVolumes) { }

	[Address(RVA = "0x2883BE0", Offset = "0x2882FE0", Length = "0x1E5")]
	[RuntimeInitializeOnLoadMethod]
	[Token(Token = "0x60006DD")]
	private static void InitializeModule() { }

	[Address(RVA = "0x2883DD0", Offset = "0x28831D0", Length = "0xFA")]
	[Token(Token = "0x60006D4")]
	public void InvalidateCachedProfile() { }

	[Address(RVA = "0x2883ED0", Offset = "0x28832D0", Length = "0x136")]
	[Token(Token = "0x60006DA")]
	private static void OnCameraCut(ActivationEventParams evt) { }

	[Address(RVA = "0x2884010", Offset = "0x2883410", Length = "0x1F")]
	[Token(Token = "0x60006D8")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x2884030", Offset = "0x2883430", Length = "0x7")]
	[Token(Token = "0x60006D7")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2884040", Offset = "0x2883440", Length = "0x10")]
	[Token(Token = "0x60006D5")]
	private void OnValidate() { }

	[Address(RVA = "0x2884050", Offset = "0x2883450", Length = "0x4CE")]
	[Token(Token = "0x60006D9")]
	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x2884520", Offset = "0x2883920", Length = "0x42")]
	[Token(Token = "0x60006D6")]
	private void Reset() { }

	[Address(RVA = "0x1E08FF0", Offset = "0x1E083F0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x60006D2")]
	private void set_CalculatedFocusDistance(float value) { }

}

