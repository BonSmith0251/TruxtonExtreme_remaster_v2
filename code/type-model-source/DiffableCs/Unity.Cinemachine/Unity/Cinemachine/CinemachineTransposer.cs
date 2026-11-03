namespace Unity.Cinemachine;

[AddComponentMenu(null)]
[CameraPipeline(Stage::Body (0))]
[Obsolete("CinemachineTransposer has been deprecated. Use CinemachineFollow instead")]
[SaveDuringPlay]
[Token(Token = "0x2000138")]
public class CinemachineTransposer : CinemachineComponentBase
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400051B")]
	[Tooltip("The coordinate space to use when interpreting the offset from the target.  This is also used to set the camera's Up vector, which will be maintained when aiming the camera.")]
	public BindingMode m_BindingMode; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400051C")]
	[Tooltip("The distance vector that the transposer will attempt to maintain from the Follow target")]
	public Vector3 m_FollowOffset; //Field offset: 0x2C
	[FieldOffset(Offset = "0x38")]
	[Range(0, 20)]
	[Token(Token = "0x400051D")]
	[Tooltip("How aggressively the camera tries to maintain the offset in the X-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's x-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
	public float m_XDamping; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Range(0, 20)]
	[Token(Token = "0x400051E")]
	[Tooltip("How aggressively the camera tries to maintain the offset in the Y-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's y-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
	public float m_YDamping; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Range(0, 20)]
	[Token(Token = "0x400051F")]
	[Tooltip("How aggressively the camera tries to maintain the offset in the Z-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's z-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
	public float m_ZDamping; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000520")]
	public AngularDampingMode m_AngularDampingMode; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Range(0, 20)]
	[Token(Token = "0x4000521")]
	[Tooltip("How aggressively the camera tries to track the target rotation's X angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
	public float m_PitchDamping; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Range(0, 20)]
	[Token(Token = "0x4000522")]
	[Tooltip("How aggressively the camera tries to track the target rotation's Y angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
	public float m_YawDamping; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Range(0, 20)]
	[Token(Token = "0x4000523")]
	[Tooltip("How aggressively the camera tries to track the target rotation's Z angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
	public float m_RollDamping; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Range(0, 20)]
	[Token(Token = "0x4000524")]
	[Tooltip("How aggressively the camera tries to track the target's orientation.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
	public float m_AngularDamping; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000525")]
	private Tracker m_TargetTracker; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000526")]
	private bool <HideOffsetInInspector>k__BackingField; //Field offset: 0x98

	[Token(Token = "0x17000137")]
	public Vector3 EffectiveOffset
	{
		[Address(RVA = "0x287A390", Offset = "0x2879790", Length = "0x37")]
		[Token(Token = "0x6000607")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000136")]
	internal bool HideOffsetInInspector
	{
		[Address(RVA = "0xD11AF0", Offset = "0xD10EF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000605")]
		internal get { } //Length: 8
		[Address(RVA = "0xD11C70", Offset = "0xD11070", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000606")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000138")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x287A3D0", Offset = "0x28797D0", Length = "0x6D")]
		[Token(Token = "0x6000608")]
		 get { } //Length: 109
	}

	[Token(Token = "0x17000139")]
	public virtual Stage Stage
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000609")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000135")]
	protected TrackerSettings TrackerSettings
	{
		[Address(RVA = "0x287A440", Offset = "0x2879840", Length = "0x4D")]
		[Token(Token = "0x6000603")]
		 get { } //Length: 77
	}

	[Address(RVA = "0x287A300", Offset = "0x2879700", Length = "0x8E")]
	[Token(Token = "0x6000611")]
	public CinemachineTransposer() { }

	[Address(RVA = "0x281CC60", Offset = "0x281C060", Length = "0x1A3")]
	[Token(Token = "0x600060D")]
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x287A390", Offset = "0x2879790", Length = "0x37")]
	[Token(Token = "0x6000607")]
	public Vector3 get_EffectiveOffset() { }

	[Address(RVA = "0xD11AF0", Offset = "0xD10EF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000605")]
	internal bool get_HideOffsetInInspector() { }

	[Address(RVA = "0x287A3D0", Offset = "0x28797D0", Length = "0x6D")]
	[Token(Token = "0x6000608")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000609")]
	public virtual Stage get_Stage() { }

	[Address(RVA = "0x287A440", Offset = "0x2879840", Length = "0x4D")]
	[Token(Token = "0x6000603")]
	protected TrackerSettings get_TrackerSettings() { }

	[Address(RVA = "0x28799F0", Offset = "0x2878DF0", Length = "0xB9")]
	[Token(Token = "0x600060A")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x281D080", Offset = "0x281C480", Length = "0x113")]
	[Token(Token = "0x600060E")]
	internal Quaternion GetReferenceOrientation(Vector3 up) { }

	[Address(RVA = "0x2879AB0", Offset = "0x2878EB0", Length = "0x233")]
	[Token(Token = "0x600060F")]
	internal override Vector3 GetTargetCameraPosition(Vector3 worldUp) { }

	[Address(RVA = "0x2879CF0", Offset = "0x28790F0", Length = "0x427")]
	[Token(Token = "0x600060B")]
	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x287A120", Offset = "0x2879520", Length = "0xC8")]
	[Token(Token = "0x600060C")]
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	[Address(RVA = "0x287A1F0", Offset = "0x28795F0", Length = "0x4C")]
	[Token(Token = "0x6000604")]
	protected override void OnValidate() { }

	[Address(RVA = "0xD11C70", Offset = "0xD11070", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000606")]
	internal void set_HideOffsetInInspector(bool value) { }

	[Address(RVA = "0x287A240", Offset = "0x2879640", Length = "0xBB")]
	[Token(Token = "0x6000610")]
	internal void UpgradeToCm3(CinemachineFollow c) { }

}

