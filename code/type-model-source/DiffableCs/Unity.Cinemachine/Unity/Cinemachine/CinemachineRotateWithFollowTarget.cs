namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Rotation Control/Cinemachine Rotate With Follow Target")]
[CameraPipeline(Stage::Aim (1))]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineRotateWithFollowTarget.html")]
[RequiredTarget(RequiredTargets::Tracking (1))]
[SaveDuringPlay]
[Token(Token = "0x200006B")]
public class CinemachineRotateWithFollowTarget : CinemachineComponentBase
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001B5")]
	[Tooltip("How much time it takes for the aim to catch up to the target's rotation")]
	public float Damping; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40001B6")]
	private Quaternion m_PreviousReferenceOrientation; //Field offset: 0x2C

	[Token(Token = "0x1700005C")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x2825210", Offset = "0x2824610", Length = "0x6D")]
		[Token(Token = "0x60001FF")]
		 get { } //Length: 109
	}

	[Token(Token = "0x1700005D")]
	public virtual Stage Stage
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000200")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x28251C0", Offset = "0x28245C0", Length = "0x49")]
	[Token(Token = "0x6000203")]
	public CinemachineRotateWithFollowTarget() { }

	[Address(RVA = "0x2825210", Offset = "0x2824610", Length = "0x6D")]
	[Token(Token = "0x60001FF")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000200")]
	public virtual Stage get_Stage() { }

	[Address(RVA = "0x1D376B0", Offset = "0x1D36AB0", Length = "0x6")]
	[Token(Token = "0x6000201")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x2825050", Offset = "0x2824450", Length = "0x162")]
	[Token(Token = "0x6000202")]
	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

}

