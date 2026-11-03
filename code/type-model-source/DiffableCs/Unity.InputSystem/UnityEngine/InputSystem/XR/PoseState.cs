namespace UnityEngine.InputSystem.XR;

[Token(Token = "0x20000E2")]
public struct PoseState : IInputStateTypeInfo
{
	[Token(Token = "0x4000560")]
	internal const int kSizeInBytes = 60; //Field offset: 0x0
	[Token(Token = "0x4000561")]
	internal static readonly FourCC s_Format; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[InputControl(displayName = "Is Tracked", layout = "Button", sizeInBits = 8)]
	[Token(Token = "0x4000562")]
	public bool isTracked; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[InputControl(displayName = "Tracking State", layout = "Integer")]
	[Token(Token = "0x4000563")]
	public InputTrackingState trackingState; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[InputControl(displayName = "Position", noisy = True)]
	[Token(Token = "0x4000564")]
	public Vector3 position; //Field offset: 0x8
	[FieldOffset(Offset = "0x14")]
	[InputControl(displayName = "Rotation", noisy = True)]
	[Token(Token = "0x4000565")]
	public Quaternion rotation; //Field offset: 0x14
	[FieldOffset(Offset = "0x24")]
	[InputControl(displayName = "Velocity", noisy = True)]
	[Token(Token = "0x4000566")]
	public Vector3 velocity; //Field offset: 0x24
	[FieldOffset(Offset = "0x30")]
	[InputControl(displayName = "Angular Velocity", noisy = True)]
	[Token(Token = "0x4000567")]
	public Vector3 angularVelocity; //Field offset: 0x30

	[Token(Token = "0x1700031D")]
	public override FourCC format
	{
		[Address(RVA = "0x29CAFA0", Offset = "0x29CA3A0", Length = "0x4D")]
		[Token(Token = "0x6000C0A")]
		 get { } //Length: 77
	}

	[Address(RVA = "0x29CAEE0", Offset = "0x29CA2E0", Length = "0x66")]
	[Token(Token = "0x6000C0C")]
	private static PoseState() { }

	[Address(RVA = "0x29CAF50", Offset = "0x29CA350", Length = "0x4C")]
	[Token(Token = "0x6000C0B")]
	public PoseState(bool isTracked, InputTrackingState trackingState, Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity) { }

	[Address(RVA = "0x29CAFA0", Offset = "0x29CA3A0", Length = "0x4D")]
	[Token(Token = "0x6000C0A")]
	public override FourCC get_format() { }

}

