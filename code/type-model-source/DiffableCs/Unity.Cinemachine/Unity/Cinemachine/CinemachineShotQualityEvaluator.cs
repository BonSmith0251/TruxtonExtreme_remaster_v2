namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Extensions/Cinemachine Shot Quality Evaluator")]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineShotQualityEvaluator.html")]
[RequiredTarget(RequiredTargets::Tracking (1))]
[SaveDuringPlay]
[Token(Token = "0x2000041")]
public class CinemachineShotQualityEvaluator : CinemachineExtension, IShotQualityEvaluator
{
	[Token(Token = "0x2000042")]
	internal struct DistanceEvaluationSettings
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000FC")]
		[Tooltip("If enabled, will evaluate shot quality based on target distance")]
		public bool Enabled; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40000FD")]
		[Tooltip("If greater than zero, maximum quality boost will occur when target is this far from the camera")]
		public float OptimalDistance; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000FE")]
		[Tooltip("Shots with targets closer to the camera than this will not get a quality boost")]
		public float NearLimit; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40000FF")]
		[Tooltip("Shots with targets farther from the camera than this will not get a quality boost")]
		public float FarLimit; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000100")]
		[Tooltip("High quality shots will be boosted by this fraction of their normal quality")]
		public float MaxQualityBoost; //Field offset: 0x10

		[Token(Token = "0x17000025")]
		internal static DistanceEvaluationSettings Default
		{
			[Address(RVA = "0x28161F0", Offset = "0x28155F0", Length = "0x26")]
			[Token(Token = "0x6000121")]
			internal get { } //Length: 38
		}

		[Address(RVA = "0x28161F0", Offset = "0x28155F0", Length = "0x26")]
		[Token(Token = "0x6000121")]
		internal static DistanceEvaluationSettings get_Default() { }

	}

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000F7")]
	[Tooltip("Objects on these layers will be detected")]
	public LayerMask OcclusionLayers; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[TagField]
	[Token(Token = "0x40000F8")]
	[Tooltip("Obstacles with this tag will be ignored.  It is a good idea to set this field to the target's tag")]
	public string IgnoreTag; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000F9")]
	[Tooltip("Obstacles closer to the target than this will be ignored")]
	public float MinimumDistanceFromTarget; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40000FA")]
	[Tooltip("Radius of the spherecast that will be done to check for occlusions.")]
	public float CameraRadius; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[FoldoutWithEnabledButton("Enabled")]
	[Token(Token = "0x40000FB")]
	public DistanceEvaluationSettings DistanceEvaluation; //Field offset: 0x48

	[Address(RVA = "0x2815580", Offset = "0x2814980", Length = "0x82")]
	[Token(Token = "0x6000120")]
	public CinemachineShotQualityEvaluator() { }

	[Address(RVA = "0x2814DF0", Offset = "0x28141F0", Length = "0x34D")]
	[Token(Token = "0x600011F")]
	private bool IsTargetObscured(CameraState state) { }

	[Address(RVA = "0x2815140", Offset = "0x2814540", Length = "0x6A")]
	[Token(Token = "0x600011C")]
	private void OnValidate() { }

	[Address(RVA = "0x28151B0", Offset = "0x28145B0", Length = "0x342")]
	[Token(Token = "0x600011E")]
	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x2815500", Offset = "0x2814900", Length = "0x78")]
	[Token(Token = "0x600011D")]
	private void Reset() { }

}

