namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x2000177")]
public struct DisableDeviceCommand : IInputDeviceCommandInfo
{
	[Token(Token = "0x400094B")]
	internal const int kSize = 8; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400094C")]
	public InputDeviceCommand baseCommand; //Field offset: 0x0

	[Token(Token = "0x1700043B")]
	public static FourCC Type
	{
		[Address(RVA = "0x29EB140", Offset = "0x29EA540", Length = "0x3A")]
		[Token(Token = "0x6000FAE")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700043C")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29EB180", Offset = "0x29EA580", Length = "0x3A")]
		[Token(Token = "0x6000FAF")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29EB0F0", Offset = "0x29EA4F0", Length = "0x4B")]
	[Token(Token = "0x6000FB0")]
	public static DisableDeviceCommand Create() { }

	[Address(RVA = "0x29EB140", Offset = "0x29EA540", Length = "0x3A")]
	[Token(Token = "0x6000FAE")]
	public static FourCC get_Type() { }

	[Address(RVA = "0x29EB180", Offset = "0x29EA580", Length = "0x3A")]
	[Token(Token = "0x6000FAF")]
	public override FourCC get_typeStatic() { }

}

