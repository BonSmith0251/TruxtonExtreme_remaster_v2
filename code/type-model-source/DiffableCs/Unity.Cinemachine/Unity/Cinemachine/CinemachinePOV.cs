namespace Unity.Cinemachine;

[AddComponentMenu(null)]
[CameraPipeline(Stage::Aim (1))]
[Obsolete("CinemachinePOV has been deprecated. Use CinemachinePanTilt instead")]
[SaveDuringPlay]
[Token(Token = "0x200012F")]
public class CinemachinePOV : CinemachineComponentBase, IModifierValueSource, IRequiresInput
{
	[Token(Token = "0x2000130")]
	internal enum RecenterTargetMode : int
	{
		None = 0,
		FollowTargetForward = 1,
		LookAtTargetForward = 2,
	}

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004EA")]
	public RecenterTargetMode m_RecenterTarget; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004EB")]
	[Tooltip("The Vertical axis.  Value is -90..90. Controls the vertical orientation")]
	public AxisState m_VerticalAxis; //Field offset: 0x30
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40004EC")]
	[Tooltip("Controls how automatic recentering of the Vertical axis is accomplished")]
	public Recentering m_VerticalRecentering; //Field offset: 0xA0
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40004ED")]
	[Tooltip("The Horizontal axis.  Value is -180..180.  Controls the horizontal orientation")]
	public AxisState m_HorizontalAxis; //Field offset: 0xC0
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x40004EE")]
	[Tooltip("Controls how automatic recentering of the Horizontal axis is accomplished")]
	public Recentering m_HorizontalRecentering; //Field offset: 0x130
	[FieldOffset(Offset = "0x150")]
	[HideInInspector]
	[Token(Token = "0x40004EF")]
	[Tooltip("Obsolete - no longer used")]
	public bool m_ApplyBeforeBody; //Field offset: 0x150
	[FieldOffset(Offset = "0x154")]
	[Token(Token = "0x40004F0")]
	private Quaternion m_PreviousCameraRotation; //Field offset: 0x154

	[Token(Token = "0x17000129")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x1CC9FE0", Offset = "0x1CC93E0", Length = "0x7")]
		[Token(Token = "0x60005D2")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700012A")]
	public virtual Stage Stage
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60005D3")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000128")]
	private override float Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource.NormalizedModifierValue
	{
		[Address(RVA = "0x2874700", Offset = "0x2873B00", Length = "0x35")]
		[Token(Token = "0x60005D1")]
		private get { } //Length: 53
	}

	[Address(RVA = "0x2874910", Offset = "0x2873D10", Length = "0x28D")]
	[Token(Token = "0x60005E0")]
	public CinemachinePOV() { }

	[Address(RVA = "0x2873290", Offset = "0x2872690", Length = "0x1F")]
	[Token(Token = "0x60005DC")]
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x1CC9FE0", Offset = "0x1CC93E0", Length = "0x7")]
	[Token(Token = "0x60005D2")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60005D3")]
	public virtual Stage get_Stage() { }

	[Address(RVA = "0x28732B0", Offset = "0x28726B0", Length = "0x32C")]
	[Token(Token = "0x60005DA")]
	public Vector2 GetRecenterTarget() { }

	[Address(RVA = "0x28735E0", Offset = "0x28729E0", Length = "0x764")]
	[Token(Token = "0x60005D9")]
	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x2822E00", Offset = "0x2822200", Length = "0x26")]
	[Token(Token = "0x60005DB")]
	private static float NormalizeAngle(float angle) { }

	[Address(RVA = "0x2873D50", Offset = "0x2873150", Length = "0xF5")]
	[Token(Token = "0x60005D5")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2873E50", Offset = "0x2873250", Length = "0x257")]
	[Token(Token = "0x60005DD")]
	public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x28740B0", Offset = "0x28734B0", Length = "0x43")]
	[Token(Token = "0x60005D4")]
	private void OnValidate() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005D8")]
	public virtual void PrePipelineMutateCameraState(ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x2874100", Offset = "0x2873500", Length = "0x5F7")]
	[Token(Token = "0x60005DE")]
	private void SetAxesForRotation(Quaternion targetRot) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60005D6")]
	private override bool Unity.Cinemachine.AxisState.IRequiresInput.RequiresInput() { }

	[Address(RVA = "0x2874700", Offset = "0x2873B00", Length = "0x35")]
	[Token(Token = "0x60005D1")]
	private override float Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource.get_NormalizedModifierValue() { }

	[Address(RVA = "0x2874740", Offset = "0x2873B40", Length = "0xEE")]
	[Token(Token = "0x60005D7")]
	internal void UpdateInputAxisProvider() { }

	[Address(RVA = "0x2874830", Offset = "0x2873C30", Length = "0xD1")]
	[Token(Token = "0x60005DF")]
	internal void UpgradeToCm3(CinemachinePanTilt c) { }

}

