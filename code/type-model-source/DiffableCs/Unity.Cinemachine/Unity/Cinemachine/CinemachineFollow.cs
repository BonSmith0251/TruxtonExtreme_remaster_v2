namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Position Control/Cinemachine Follow")]
[CameraPipeline(Stage::Body (0))]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineFollow.html")]
[RequiredTarget(RequiredTargets::Tracking (1))]
[SaveDuringPlay]
[Token(Token = "0x200005A")]
public class CinemachineFollow : CinemachineComponentBase
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000169")]
	public TrackerSettings TrackerSettings; //Field offset: 0x28
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400016A")]
	[Tooltip("The distance vector that the camera will attempt to maintain from the tracking target")]
	public Vector3 FollowOffset; //Field offset: 0x4C
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400016B")]
	private Tracker m_TargetTracker; //Field offset: 0x58

	[Token(Token = "0x1700003B")]
	internal Vector3 EffectiveOffset
	{
		[Address(RVA = "0x281D7A0", Offset = "0x281CBA0", Length = "0x37")]
		[Token(Token = "0x6000191")]
		internal get { } //Length: 55
	}

	[Token(Token = "0x1700003C")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x281D7E0", Offset = "0x281CBE0", Length = "0x6D")]
		[Token(Token = "0x6000192")]
		 get { } //Length: 109
	}

	[Token(Token = "0x1700003D")]
	public virtual Stage Stage
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000193")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x281D700", Offset = "0x281CB00", Length = "0x93")]
	[Token(Token = "0x600019A")]
	public CinemachineFollow() { }

	[Address(RVA = "0x281CC60", Offset = "0x281C060", Length = "0x1A3")]
	[Token(Token = "0x6000197")]
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x281D7A0", Offset = "0x281CBA0", Length = "0x37")]
	[Token(Token = "0x6000191")]
	internal Vector3 get_EffectiveOffset() { }

	[Address(RVA = "0x281D7E0", Offset = "0x281CBE0", Length = "0x6D")]
	[Token(Token = "0x6000192")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000193")]
	public virtual Stage get_Stage() { }

	[Address(RVA = "0x281CE10", Offset = "0x281C210", Length = "0x233")]
	[Token(Token = "0x6000199")]
	internal Vector3 GetDesiredCameraPosition(Vector3 worldUp) { }

	[Address(RVA = "0x281D050", Offset = "0x281C450", Length = "0x2E")]
	[Token(Token = "0x6000194")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x281D080", Offset = "0x281C480", Length = "0x113")]
	[Token(Token = "0x6000198")]
	internal Quaternion GetReferenceOrientation(Vector3 up) { }

	[Address(RVA = "0x281D1A0", Offset = "0x281C5A0", Length = "0x393")]
	[Token(Token = "0x6000195")]
	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x281D540", Offset = "0x281C940", Length = "0xC8")]
	[Token(Token = "0x6000196")]
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	[Address(RVA = "0x281D610", Offset = "0x281CA10", Length = "0x59")]
	[Token(Token = "0x600018F")]
	private void OnValidate() { }

	[Address(RVA = "0x281D670", Offset = "0x281CA70", Length = "0x8A")]
	[Token(Token = "0x6000190")]
	private void Reset() { }

}

