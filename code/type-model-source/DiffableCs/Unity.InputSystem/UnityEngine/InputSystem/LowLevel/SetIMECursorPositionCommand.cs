namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x2000190")]
public struct SetIMECursorPositionCommand : IInputDeviceCommandInfo
{
	[Token(Token = "0x400098B")]
	internal const int kSize = 16; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400098C")]
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400098D")]
	private Vector2 m_Position; //Field offset: 0x8

	[Token(Token = "0x1700045F")]
	public Vector2 position
	{
		[Address(RVA = "0x29FC9E0", Offset = "0x29FBDE0", Length = "0x13")]
		[Token(Token = "0x6000FF0")]
		 get { } //Length: 19
	}

	[Token(Token = "0x1700045E")]
	public static FourCC Type
	{
		[Address(RVA = "0x29FC9A0", Offset = "0x29FBDA0", Length = "0x3A")]
		[Token(Token = "0x6000FEF")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000460")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29FCA00", Offset = "0x29FBE00", Length = "0x3A")]
		[Token(Token = "0x6000FF1")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29FC920", Offset = "0x29FBD20", Length = "0x71")]
	[Token(Token = "0x6000FF2")]
	public static SetIMECursorPositionCommand Create(Vector2 cursorPosition) { }

	[Address(RVA = "0x29FC9E0", Offset = "0x29FBDE0", Length = "0x13")]
	[Token(Token = "0x6000FF0")]
	public Vector2 get_position() { }

	[Address(RVA = "0x29FC9A0", Offset = "0x29FBDA0", Length = "0x3A")]
	[Token(Token = "0x6000FEF")]
	public static FourCC get_Type() { }

	[Address(RVA = "0x29FCA00", Offset = "0x29FBE00", Length = "0x3A")]
	[Token(Token = "0x6000FF1")]
	public override FourCC get_typeStatic() { }

}

