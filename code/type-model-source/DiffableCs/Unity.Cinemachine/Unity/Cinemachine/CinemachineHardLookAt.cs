namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Rotation Control/Cinemachine Hard Look At")]
[CameraPipeline(Stage::Aim (1))]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineHardLookAt.html")]
[RequiredTarget(RequiredTargets::LookAt (2))]
[SaveDuringPlay]
[Token(Token = "0x200005C")]
public class CinemachineHardLookAt : CinemachineComponentBase
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400016E")]
	[Tooltip("Offset from the LookAt target's origin, in target's local space.  The camera will look at this point.")]
	public Vector3 LookAtOffset; //Field offset: 0x28

	[Token(Token = "0x17000042")]
	internal virtual bool CameraLooksAtTarget
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60001A2")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000040")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x281DF30", Offset = "0x281D330", Length = "0x6D")]
		[Token(Token = "0x60001A0")]
		 get { } //Length: 109
	}

	[Token(Token = "0x17000041")]
	public virtual Stage Stage
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60001A1")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x281DED0", Offset = "0x281D2D0", Length = "0x51")]
	[Token(Token = "0x60001A5")]
	public CinemachineHardLookAt() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60001A2")]
	internal virtual bool get_CameraLooksAtTarget() { }

	[Address(RVA = "0x281DF30", Offset = "0x281D330", Length = "0x6D")]
	[Token(Token = "0x60001A0")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60001A1")]
	public virtual Stage get_Stage() { }

	[Address(RVA = "0x281DA60", Offset = "0x281CE60", Length = "0x412")]
	[Token(Token = "0x60001A4")]
	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x281DE80", Offset = "0x281D280", Length = "0x48")]
	[Token(Token = "0x60001A3")]
	private void Reset() { }

}

