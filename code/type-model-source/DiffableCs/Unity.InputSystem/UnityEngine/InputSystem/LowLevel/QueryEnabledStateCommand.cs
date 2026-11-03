namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x2000182")]
public struct QueryEnabledStateCommand : IInputDeviceCommandInfo
{
	[Token(Token = "0x4000964")]
	internal const int kSize = 9; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000965")]
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000966")]
	public bool isEnabled; //Field offset: 0x8

	[Token(Token = "0x1700044C")]
	public static FourCC Type
	{
		[Address(RVA = "0x29FBEA0", Offset = "0x29FB2A0", Length = "0x3A")]
		[Token(Token = "0x6000FCF")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700044D")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29FBEE0", Offset = "0x29FB2E0", Length = "0x3A")]
		[Token(Token = "0x6000FD0")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29FBE40", Offset = "0x29FB240", Length = "0x5F")]
	[Token(Token = "0x6000FD1")]
	public static QueryEnabledStateCommand Create() { }

	[Address(RVA = "0x29FBEA0", Offset = "0x29FB2A0", Length = "0x3A")]
	[Token(Token = "0x6000FCF")]
	public static FourCC get_Type() { }

	[Address(RVA = "0x29FBEE0", Offset = "0x29FB2E0", Length = "0x3A")]
	[Token(Token = "0x6000FD0")]
	public override FourCC get_typeStatic() { }

}

