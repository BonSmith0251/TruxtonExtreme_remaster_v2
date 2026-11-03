namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x2000178")]
public struct EnableDeviceCommand : IInputDeviceCommandInfo
{
	[Token(Token = "0x400094D")]
	internal const int kSize = 8; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400094E")]
	public InputDeviceCommand baseCommand; //Field offset: 0x0

	[Token(Token = "0x1700043D")]
	public static FourCC Type
	{
		[Address(RVA = "0x29EE9C0", Offset = "0x29EDDC0", Length = "0x3A")]
		[Token(Token = "0x6000FB1")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700043E")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29EEA00", Offset = "0x29EDE00", Length = "0x3A")]
		[Token(Token = "0x6000FB2")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29EE970", Offset = "0x29EDD70", Length = "0x4B")]
	[Token(Token = "0x6000FB3")]
	public static EnableDeviceCommand Create() { }

	[Address(RVA = "0x29EE9C0", Offset = "0x29EDDC0", Length = "0x3A")]
	[Token(Token = "0x6000FB1")]
	public static FourCC get_Type() { }

	[Address(RVA = "0x29EEA00", Offset = "0x29EDE00", Length = "0x3A")]
	[Token(Token = "0x6000FB2")]
	public override FourCC get_typeStatic() { }

}

