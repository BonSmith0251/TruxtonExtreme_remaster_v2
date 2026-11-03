namespace UnityEngine.XR;

[Flags]
[Token(Token = "0x2000005")]
internal enum AvailableTrackingData : int
{
	None = 0,
	PositionAvailable = 1,
	RotationAvailable = 2,
	VelocityAvailable = 4,
	AngularVelocityAvailable = 8,
	AccelerationAvailable = 16,
	AngularAccelerationAvailable = 32,
}

