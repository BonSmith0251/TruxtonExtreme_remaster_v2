namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x2000195")]
internal struct DualMotorRumbleCommand : IInputDeviceCommandInfo
{
	[Token(Token = "0x40009B6")]
	internal const int kSize = 16; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009B7")]
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009B8")]
	public float lowFrequencyMotorSpeed; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40009B9")]
	public float highFrequencyMotorSpeed; //Field offset: 0xC

	[Token(Token = "0x17000467")]
	public static FourCC Type
	{
		[Address(RVA = "0x29EB390", Offset = "0x29EA790", Length = "0x3A")]
		[Token(Token = "0x6000FFD")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000468")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29EB3D0", Offset = "0x29EA7D0", Length = "0x3A")]
		[Token(Token = "0x6000FFE")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29EB300", Offset = "0x29EA700", Length = "0x81")]
	[Token(Token = "0x6000FFF")]
	public static DualMotorRumbleCommand Create(float lowFrequency, float highFrequency) { }

	[Address(RVA = "0x29EB390", Offset = "0x29EA790", Length = "0x3A")]
	[Token(Token = "0x6000FFD")]
	public static FourCC get_Type() { }

	[Address(RVA = "0x29EB3D0", Offset = "0x29EA7D0", Length = "0x3A")]
	[Token(Token = "0x6000FFE")]
	public override FourCC get_typeStatic() { }

}

