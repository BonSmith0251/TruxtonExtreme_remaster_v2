namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001A4")]
internal struct GyroscopeState : IInputStateTypeInfo
{
	[FieldOffset(Offset = "0x0")]
	[InputControl(displayName = "Angular Velocity", processors = "CompensateDirection", noisy = True)]
	[Token(Token = "0x40009E1")]
	public Vector3 angularVelocity; //Field offset: 0x0

	[Token(Token = "0x17000476")]
	public override FourCC format
	{
		[Address(RVA = "0x29F1840", Offset = "0x29F0C40", Length = "0x3A")]
		[Token(Token = "0x600101B")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000475")]
	public static FourCC kFormat
	{
		[Address(RVA = "0x29F1880", Offset = "0x29F0C80", Length = "0x3A")]
		[Token(Token = "0x600101A")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29F1840", Offset = "0x29F0C40", Length = "0x3A")]
	[Token(Token = "0x600101B")]
	public override FourCC get_format() { }

	[Address(RVA = "0x29F1880", Offset = "0x29F0C80", Length = "0x3A")]
	[Token(Token = "0x600101A")]
	public static FourCC get_kFormat() { }

}

