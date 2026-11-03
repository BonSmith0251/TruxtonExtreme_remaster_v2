namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001A6")]
internal struct AttitudeState : IInputStateTypeInfo
{
	[FieldOffset(Offset = "0x0")]
	[InputControl(displayName = "Attitude", processors = "CompensateRotation", noisy = True)]
	[Token(Token = "0x40009E3")]
	public Quaternion attitude; //Field offset: 0x0

	[Token(Token = "0x1700047A")]
	public override FourCC format
	{
		[Address(RVA = "0x29EA8D0", Offset = "0x29E9CD0", Length = "0x37")]
		[Token(Token = "0x600101F")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000479")]
	public static FourCC kFormat
	{
		[Address(RVA = "0x29EA910", Offset = "0x29E9D10", Length = "0x37")]
		[Token(Token = "0x600101E")]
		 get { } //Length: 55
	}

	[Address(RVA = "0x29EA8D0", Offset = "0x29E9CD0", Length = "0x37")]
	[Token(Token = "0x600101F")]
	public override FourCC get_format() { }

	[Address(RVA = "0x29EA910", Offset = "0x29E9D10", Length = "0x37")]
	[Token(Token = "0x600101E")]
	public static FourCC get_kFormat() { }

}

