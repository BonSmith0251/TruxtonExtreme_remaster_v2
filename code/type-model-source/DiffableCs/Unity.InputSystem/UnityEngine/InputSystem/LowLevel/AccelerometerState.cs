namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001A3")]
internal struct AccelerometerState : IInputStateTypeInfo
{
	[FieldOffset(Offset = "0x0")]
	[InputControl(displayName = "Acceleration", processors = "CompensateDirection", noisy = True)]
	[Token(Token = "0x40009E0")]
	public Vector3 acceleration; //Field offset: 0x0

	[Token(Token = "0x17000474")]
	public override FourCC format
	{
		[Address(RVA = "0x29EA440", Offset = "0x29E9840", Length = "0x37")]
		[Token(Token = "0x6001019")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000473")]
	public static FourCC kFormat
	{
		[Address(RVA = "0x29EA480", Offset = "0x29E9880", Length = "0x37")]
		[Token(Token = "0x6001018")]
		 get { } //Length: 55
	}

	[Address(RVA = "0x29EA440", Offset = "0x29E9840", Length = "0x37")]
	[Token(Token = "0x6001019")]
	public override FourCC get_format() { }

	[Address(RVA = "0x29EA480", Offset = "0x29E9880", Length = "0x37")]
	[Token(Token = "0x6001018")]
	public static FourCC get_kFormat() { }

}

