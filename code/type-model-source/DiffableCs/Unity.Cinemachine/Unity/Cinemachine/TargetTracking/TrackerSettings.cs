namespace Unity.Cinemachine.TargetTracking;

[Token(Token = "0x2000195")]
public struct TrackerSettings
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006B6")]
	[Tooltip("The coordinate space to use when interpreting the offset from the target.  This is also used to set the camera's Up vector, which will be maintained when aiming the camera.")]
	public BindingMode BindingMode; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40006B7")]
	[Tooltip("How aggressively the camera tries to maintain the offset, per axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
	public Vector3 PositionDamping; //Field offset: 0x4
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006B8")]
	public AngularDampingMode AngularDampingMode; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40006B9")]
	[Tooltip("How aggressively the camera tries to track the target's rotation, per axis.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
	public Vector3 RotationDamping; //Field offset: 0x14
	[FieldOffset(Offset = "0x20")]
	[Range(0, 20)]
	[Token(Token = "0x40006BA")]
	[Tooltip("How aggressively the camera tries to track the target's rotation.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
	public float QuaternionDamping; //Field offset: 0x20

	[Token(Token = "0x17000160")]
	public static TrackerSettings Default
	{
		[Address(RVA = "0x28A5FD0", Offset = "0x28A53D0", Length = "0xAF")]
		[Token(Token = "0x6000862")]
		 get { } //Length: 175
	}

	[Address(RVA = "0x28A5FD0", Offset = "0x28A53D0", Length = "0xAF")]
	[Token(Token = "0x6000862")]
	public static TrackerSettings get_Default() { }

	[Address(RVA = "0x28A5F70", Offset = "0x28A5370", Length = "0x5E")]
	[Token(Token = "0x6000863")]
	public void Validate() { }

}

