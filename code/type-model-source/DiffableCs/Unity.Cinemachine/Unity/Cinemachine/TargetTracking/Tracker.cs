namespace Unity.Cinemachine.TargetTracking;

[Token(Token = "0x2000197")]
internal struct Tracker
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006BB")]
	private Vector3 <PreviousTargetPosition>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40006BC")]
	private Quaternion <PreviousReferenceOrientation>k__BackingField; //Field offset: 0xC
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40006BD")]
	private Quaternion m_TargetOrientationOnAssign; //Field offset: 0x1C
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40006BE")]
	private Vector3 m_PreviousOffset; //Field offset: 0x2C
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40006BF")]
	private Transform m_PreviousTarget; //Field offset: 0x38

	[Token(Token = "0x17000162")]
	public private Quaternion PreviousReferenceOrientation
	{
		[Address(RVA = "0x28A7D30", Offset = "0x28A7130", Length = "0xB")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000869")]
		 get { } //Length: 11
		[Address(RVA = "0x28A7D40", Offset = "0x28A7140", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600086A")]
		private set { } //Length: 8
	}

	[Token(Token = "0x17000161")]
	public private Vector3 PreviousTargetPosition
	{
		[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000867")]
		 get { } //Length: 18
		[Address(RVA = "0x28A7D50", Offset = "0x28A7150", Length = "0xF")]
		[CompilerGenerated]
		[Token(Token = "0x6000868")]
		private set { } //Length: 15
	}

	[Address(RVA = "0x28A7D30", Offset = "0x28A7130", Length = "0xB")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000869")]
	public Quaternion get_PreviousReferenceOrientation() { }

	[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000867")]
	public Vector3 get_PreviousTargetPosition() { }

	[Address(RVA = "0x28A6080", Offset = "0x28A5480", Length = "0x4DA")]
	[Token(Token = "0x600086E")]
	public Vector3 GetOffsetForMinimumTargetDistance(CinemachineComponentBase component, Vector3 dampedTargetPos, Vector3 cameraOffset, Vector3 cameraFwd, Vector3 up, Vector3 actualTargetPos) { }

	[Address(RVA = "0x28A6560", Offset = "0x28A5960", Length = "0x49C")]
	[Token(Token = "0x600086C")]
	public Quaternion GetReferenceOrientation(CinemachineComponentBase component, BindingMode bindingMode, Vector3 worldUp, ref CameraState cameraState) { }

	[Address(RVA = "0x28A6A20", Offset = "0x28A5E20", Length = "0x236")]
	[Token(Token = "0x600086B")]
	public void InitStateInfo(CinemachineComponentBase component, float deltaTime, BindingMode bindingMode, Vector3 up) { }

	[Address(RVA = "0x28A6C60", Offset = "0x28A6060", Length = "0x475")]
	[Token(Token = "0x6000870")]
	public void OnForceCameraPosition(CinemachineComponentBase component, BindingMode bindingMode, ref CameraState newState) { }

	[Address(RVA = "0x28A70E0", Offset = "0x28A64E0", Length = "0x3B")]
	[Token(Token = "0x600086F")]
	public void OnTargetObjectWarped(Vector3 positionDelta) { }

	[Address(RVA = "0x28A7D40", Offset = "0x28A7140", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600086A")]
	private void set_PreviousReferenceOrientation(Quaternion value) { }

	[Address(RVA = "0x28A7D50", Offset = "0x28A7150", Length = "0xF")]
	[CompilerGenerated]
	[Token(Token = "0x6000868")]
	private void set_PreviousTargetPosition(Vector3 value) { }

	[Address(RVA = "0x28A7120", Offset = "0x28A6520", Length = "0xC0F")]
	[Token(Token = "0x600086D")]
	public void TrackTarget(CinemachineComponentBase component, float deltaTime, Vector3 up, Vector3 desiredCameraOffset, in TrackerSettings settings, ref CameraState cameraState, out Vector3 outTargetPosition, out Quaternion outTargetOrient) { }

}

