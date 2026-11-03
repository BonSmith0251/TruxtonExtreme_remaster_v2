namespace Unity.Cinemachine;

[Token(Token = "0x2000078")]
internal class CameraBlendStack : ICameraOverrideStack
{
	[Token(Token = "0x200007A")]
	private class SnapshotBlendSource : ICinemachineCamera
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000206")]
		private CameraState m_State; //Field offset: 0x10
		[FieldOffset(Offset = "0x120")]
		[Token(Token = "0x4000207")]
		private string m_Name; //Field offset: 0x120
		[CompilerGenerated]
		[FieldOffset(Offset = "0x128")]
		[Token(Token = "0x4000208")]
		private float <RemainingTimeInBlend>k__BackingField; //Field offset: 0x128

		[Token(Token = "0x17000080")]
		public override string Description
		{
			[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
			[Token(Token = "0x6000274")]
			 get { } //Length: 8
		}

		[Token(Token = "0x17000082")]
		public override bool IsValid
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6000276")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700007F")]
		public override string Name
		{
			[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
			[Token(Token = "0x6000273")]
			 get { } //Length: 8
		}

		[Token(Token = "0x17000083")]
		public override ICinemachineMixer ParentCamera
		{
			[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
			[Token(Token = "0x6000277")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700007E")]
		public float RemainingTimeInBlend
		{
			[Address(RVA = "0x284A2F0", Offset = "0x28496F0", Length = "0x9")]
			[CompilerGenerated]
			[Token(Token = "0x6000270")]
			 get { } //Length: 9
			[Address(RVA = "0x284A380", Offset = "0x2849780", Length = "0x9")]
			[CompilerGenerated]
			[Token(Token = "0x6000271")]
			 set { } //Length: 9
		}

		[Token(Token = "0x17000081")]
		public override CameraState State
		{
			[Address(RVA = "0x284A300", Offset = "0x2849700", Length = "0x76")]
			[Token(Token = "0x6000275")]
			 get { } //Length: 118
		}

		[Address(RVA = "0x284A2A0", Offset = "0x28496A0", Length = "0x45")]
		[Token(Token = "0x6000272")]
		public SnapshotBlendSource(ICinemachineCamera source = null, float remainingTimeInBlend = 0) { }

		[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
		[Token(Token = "0x6000274")]
		public override string get_Description() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000276")]
		public override bool get_IsValid() { }

		[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
		[Token(Token = "0x6000273")]
		public override string get_Name() { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000277")]
		public override ICinemachineMixer get_ParentCamera() { }

		[Address(RVA = "0x284A2F0", Offset = "0x28496F0", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x6000270")]
		public float get_RemainingTimeInBlend() { }

		[Address(RVA = "0x284A300", Offset = "0x2849700", Length = "0x76")]
		[Token(Token = "0x6000275")]
		public override CameraState get_State() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000279")]
		public override void OnCameraActivated(ActivationEventParams evt) { }

		[Address(RVA = "0x284A380", Offset = "0x2849780", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x6000271")]
		public void set_RemainingTimeInBlend(float value) { }

		[Address(RVA = "0x284A030", Offset = "0x2849430", Length = "0x26C")]
		[Token(Token = "0x600027A")]
		public void TakeSnapshot(ICinemachineCamera source) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000278")]
		public override void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	}

	[Token(Token = "0x2000079")]
	private class StackFrame : NestedBlendSource
	{
		[FieldOffset(Offset = "0x130")]
		[Token(Token = "0x40001FF")]
		public int Id; //Field offset: 0x130
		[FieldOffset(Offset = "0x134")]
		[Token(Token = "0x4000200")]
		public int Priority; //Field offset: 0x134
		[FieldOffset(Offset = "0x138")]
		[Token(Token = "0x4000201")]
		public readonly CinemachineBlend Source; //Field offset: 0x138
		[FieldOffset(Offset = "0x140")]
		[Token(Token = "0x4000202")]
		public float DeltaTimeOverride; //Field offset: 0x140
		[FieldOffset(Offset = "0x148")]
		[Token(Token = "0x4000203")]
		private readonly SnapshotBlendSource m_Snapshot; //Field offset: 0x148
		[FieldOffset(Offset = "0x150")]
		[Token(Token = "0x4000204")]
		private ICinemachineCamera m_SnapshotSource; //Field offset: 0x150
		[FieldOffset(Offset = "0x158")]
		[Token(Token = "0x4000205")]
		private float m_SnapshotBlendWeight; //Field offset: 0x158

		[Token(Token = "0x1700007D")]
		public bool Active
		{
			[Address(RVA = "0x284D940", Offset = "0x284CD40", Length = "0x20")]
			[Token(Token = "0x600026E")]
			 get { } //Length: 32
		}

		[Address(RVA = "0x284D850", Offset = "0x284CC50", Length = "0xE7")]
		[Token(Token = "0x600026D")]
		public StackFrame() { }

		[Address(RVA = "0x284D940", Offset = "0x284CD40", Length = "0x20")]
		[Token(Token = "0x600026E")]
		public bool get_Active() { }

		[Address(RVA = "0x284D6C0", Offset = "0x284CAC0", Length = "0x187")]
		[Token(Token = "0x600026F")]
		public ICinemachineCamera GetSnapshotIfAppropriate(ICinemachineCamera cam, float weight) { }

	}

	[Token(Token = "0x40001FA")]
	private const float kEpsilon = 0.0001; //Field offset: 0x0
	[Token(Token = "0x40001FD")]
	private static readonly AnimationCurve s_DefaultLinearAnimationCurve; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001FB")]
	private readonly List<StackFrame> m_FrameStack; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001FC")]
	private int m_NextFrameId; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001FE")]
	private LookupBlendDelegate <LookupBlendDelegate>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700007A")]
	public override Vector3 DefaultWorldUp
	{
		[Address(RVA = "0x281BB90", Offset = "0x281AF90", Length = "0x4B")]
		[Token(Token = "0x600025C")]
		 get { } //Length: 75
	}

	[Token(Token = "0x1700007B")]
	public bool IsInitialized
	{
		[Address(RVA = "0x281BBE0", Offset = "0x281AFE0", Length = "0x40")]
		[Token(Token = "0x6000261")]
		 get { } //Length: 64
	}

	[Token(Token = "0x1700007C")]
	public LookupBlendDelegate LookupBlendDelegate
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000262")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000263")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x281BAA0", Offset = "0x281AEA0", Length = "0x6A")]
	[Token(Token = "0x600026A")]
	private static CameraBlendStack() { }

	[Address(RVA = "0x281BB10", Offset = "0x281AF10", Length = "0x77")]
	[Token(Token = "0x6000269")]
	public CameraBlendStack() { }

	[Address(RVA = "0x281ADD0", Offset = "0x281A1D0", Length = "0x1C5")]
	[CompilerGenerated]
	[Token(Token = "0x600026B")]
	private int <SetCameraOverride>g__FindFrame|7_0(int withId, int priority) { }

	[Address(RVA = "0x281AFA0", Offset = "0x281A3A0", Length = "0x114")]
	[CompilerGenerated]
	[Token(Token = "0x600026C")]
	internal static bool <UpdateRootFrame>g__AdvanceBlend|18_0(CinemachineBlend blend, float deltaTime) { }

	[Address(RVA = "0x281BB90", Offset = "0x281AF90", Length = "0x4B")]
	[Token(Token = "0x600025C")]
	public override Vector3 get_DefaultWorldUp() { }

	[Address(RVA = "0x281BBE0", Offset = "0x281AFE0", Length = "0x40")]
	[Token(Token = "0x6000261")]
	public bool get_IsInitialized() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000262")]
	public LookupBlendDelegate get_LookupBlendDelegate() { }

	[Address(RVA = "0x281A1F0", Offset = "0x28195F0", Length = "0xB8")]
	[Token(Token = "0x6000268")]
	public float GetDeltaTimeOverride() { }

	[Address(RVA = "0x281A2B0", Offset = "0x28196B0", Length = "0x61")]
	[Token(Token = "0x6000260")]
	public override void OnDisable() { }

	[Address(RVA = "0x281A320", Offset = "0x2819720", Length = "0x107")]
	[Token(Token = "0x600025F")]
	public override void OnEnable() { }

	[Address(RVA = "0x281A430", Offset = "0x2819830", Length = "0x38D")]
	[Token(Token = "0x6000266")]
	public void ProcessOverrideFrames(ref CinemachineBlend outputBlend, int numTopLayersToExclude) { }

	[Address(RVA = "0x281A7C0", Offset = "0x2819BC0", Length = "0xC5")]
	[Token(Token = "0x600025E")]
	public override void ReleaseCameraOverride(int overrideId) { }

	[Address(RVA = "0x281A890", Offset = "0x2819C90", Length = "0x125")]
	[Token(Token = "0x6000264")]
	public void ResetRootFrame() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000263")]
	public void set_LookupBlendDelegate(LookupBlendDelegate value) { }

	[Address(RVA = "0x281A9C0", Offset = "0x2819DC0", Length = "0x291")]
	[Token(Token = "0x600025D")]
	public override int SetCameraOverride(int overrideId, int priority, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime) { }

	[Address(RVA = "0x281AC60", Offset = "0x281A060", Length = "0x16C")]
	[Token(Token = "0x6000267")]
	public void SetRootBlend(CinemachineBlend blend) { }

	[Address(RVA = "0x281B0C0", Offset = "0x281A4C0", Length = "0x9D4")]
	[Token(Token = "0x6000265")]
	public void UpdateRootFrame(ICinemachineMixer context, ICinemachineCamera activeCamera, Vector3 up, float deltaTime) { }

}

