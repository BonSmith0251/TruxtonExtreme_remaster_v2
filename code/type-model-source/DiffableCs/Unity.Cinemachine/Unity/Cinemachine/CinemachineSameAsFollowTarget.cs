namespace Unity.Cinemachine;

[CameraPipeline(Stage::Aim (1))]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineSameAsFollowTarget.html")]
[Obsolete("CinemachineSameAsFollowTarget has been deprecated. Use CinemachineRotateWithFollowTarget instead")]
[RequiredTarget(RequiredTargets::Tracking (1))]
[SaveDuringPlay]
[Token(Token = "0x2000131")]
public class CinemachineSameAsFollowTarget : CinemachineComponentBase
{
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_AngularDamping")]
	[FormerlySerializedAs("m_Damping")]
	[Token(Token = "0x40004F5")]
	[Tooltip("How much time it takes for the aim to catch up to the target's rotation")]
	public float Damping; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40004F6")]
	private Quaternion m_PreviousReferenceOrientation; //Field offset: 0x2C

	[Token(Token = "0x1700012B")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x2876DA0", Offset = "0x28761A0", Length = "0x6D")]
		[Token(Token = "0x60005E1")]
		 get { } //Length: 109
	}

	[Token(Token = "0x1700012C")]
	public virtual Stage Stage
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60005E2")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x28251C0", Offset = "0x28245C0", Length = "0x49")]
	[Token(Token = "0x60005E6")]
	public CinemachineSameAsFollowTarget() { }

	[Address(RVA = "0x2876DA0", Offset = "0x28761A0", Length = "0x6D")]
	[Token(Token = "0x60005E1")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60005E2")]
	public virtual Stage get_Stage() { }

	[Address(RVA = "0x1D376B0", Offset = "0x1D36AB0", Length = "0x6")]
	[Token(Token = "0x60005E3")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x2825050", Offset = "0x2824450", Length = "0x162")]
	[Token(Token = "0x60005E4")]
	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x2876D80", Offset = "0x2876180", Length = "0x19")]
	[Token(Token = "0x60005E5")]
	internal void UpgradeToCm3(CinemachineRotateWithFollowTarget c) { }

}

