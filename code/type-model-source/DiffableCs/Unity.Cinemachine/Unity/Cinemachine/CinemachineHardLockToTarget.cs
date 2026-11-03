namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Position Control/Cinemachine Hard Lock to Target")]
[CameraPipeline(Stage::Body (0))]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineHardLockToTarget.html")]
[RequiredTarget(RequiredTargets::Tracking (1))]
[SaveDuringPlay]
[Token(Token = "0x200005B")]
public class CinemachineHardLockToTarget : CinemachineComponentBase
{
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_Damping")]
	[Token(Token = "0x400016C")]
	[Tooltip("How much time it takes for the position to catch up to the target's position")]
	public float Damping; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400016D")]
	private Vector3 m_PreviousTargetPosition; //Field offset: 0x2C

	[Token(Token = "0x1700003E")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x281D9F0", Offset = "0x281CDF0", Length = "0x6D")]
		[Token(Token = "0x600019B")]
		 get { } //Length: 109
	}

	[Token(Token = "0x1700003F")]
	public virtual Stage Stage
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600019C")]
		 get { } //Length: 3
	}

	[Address(RVA = "0xE31DA0", Offset = "0xE311A0", Length = "0x7")]
	[Token(Token = "0x600019F")]
	public CinemachineHardLockToTarget() { }

	[Address(RVA = "0x281D9F0", Offset = "0x281CDF0", Length = "0x6D")]
	[Token(Token = "0x600019B")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600019C")]
	public virtual Stage get_Stage() { }

	[Address(RVA = "0x1D376B0", Offset = "0x1D36AB0", Length = "0x6")]
	[Token(Token = "0x600019D")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x281D850", Offset = "0x281CC50", Length = "0x19A")]
	[Token(Token = "0x600019E")]
	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

}

