namespace Unity.Cinemachine;

[Token(Token = "0x2000080")]
public struct CameraTarget
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000229")]
	[Tooltip("Object for the camera to follow")]
	public Transform TrackingTarget; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400022A")]
	[Tooltip("Object for the camera to look at")]
	public Transform LookAtTarget; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400022B")]
	public bool CustomLookAtTarget; //Field offset: 0x10

}

