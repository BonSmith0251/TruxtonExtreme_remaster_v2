namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x2000192")]
internal struct WarpMousePositionCommand : IInputDeviceCommandInfo
{
	[Token(Token = "0x4000991")]
	internal const int kSize = 16; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000992")]
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000993")]
	public Vector2 warpPositionInPlayerDisplaySpace; //Field offset: 0x8

	[Token(Token = "0x17000463")]
	public static FourCC Type
	{
		[Address(RVA = "0x2A00D20", Offset = "0x2A00120", Length = "0x3A")]
		[Token(Token = "0x6000FF6")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000464")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x2A00D60", Offset = "0x2A00160", Length = "0x85")]
		[Token(Token = "0x6000FF7")]
		 get { } //Length: 133
	}

	[Address(RVA = "0x2A00CA0", Offset = "0x2A000A0", Length = "0x71")]
	[Token(Token = "0x6000FF8")]
	public static WarpMousePositionCommand Create(Vector2 position) { }

	[Address(RVA = "0x2A00D20", Offset = "0x2A00120", Length = "0x3A")]
	[Token(Token = "0x6000FF6")]
	public static FourCC get_Type() { }

	[Address(RVA = "0x2A00D60", Offset = "0x2A00160", Length = "0x85")]
	[Token(Token = "0x6000FF7")]
	public override FourCC get_typeStatic() { }

}

