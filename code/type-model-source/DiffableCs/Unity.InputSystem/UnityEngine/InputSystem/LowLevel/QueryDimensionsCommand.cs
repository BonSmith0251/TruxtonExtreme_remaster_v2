namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x2000181")]
public struct QueryDimensionsCommand : IInputDeviceCommandInfo
{
	[Token(Token = "0x4000961")]
	internal const int kSize = 16; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000962")]
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000963")]
	public Vector2 outDimensions; //Field offset: 0x8

	[Token(Token = "0x1700044A")]
	public static FourCC Type
	{
		[Address(RVA = "0x29FBDC0", Offset = "0x29FB1C0", Length = "0x3A")]
		[Token(Token = "0x6000FCC")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700044B")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29FBE00", Offset = "0x29FB200", Length = "0x3A")]
		[Token(Token = "0x6000FCD")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29FBD60", Offset = "0x29FB160", Length = "0x5D")]
	[Token(Token = "0x6000FCE")]
	public static QueryDimensionsCommand Create() { }

	[Address(RVA = "0x29FBDC0", Offset = "0x29FB1C0", Length = "0x3A")]
	[Token(Token = "0x6000FCC")]
	public static FourCC get_Type() { }

	[Address(RVA = "0x29FBE00", Offset = "0x29FB200", Length = "0x3A")]
	[Token(Token = "0x6000FCD")]
	public override FourCC get_typeStatic() { }

}

