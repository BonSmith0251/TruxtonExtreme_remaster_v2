namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x200019F")]
public struct MouseState : IInputStateTypeInfo
{
	[FieldOffset(Offset = "0x0")]
	[InputControl(usage = "Point", dontReset = True)]
	[Token(Token = "0x40009C6")]
	public Vector2 position; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[InputControl(usage = "Secondary2DMotion", layout = "Delta")]
	[Token(Token = "0x40009C7")]
	public Vector2 delta; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[InputControl(displayName = "Scroll", layout = "Delta")]
	[InputControl(name = "scroll/x", aliases = new IL2CPP_TYPE_STRING[] {"horizontal"}, usage = "ScrollHorizontal", displayName = "Left/Right")]
	[InputControl(name = "scroll/y", aliases = new IL2CPP_TYPE_STRING[] {"vertical"}, usage = "ScrollVertical", displayName = "Up/Down", shortDisplayName = "Wheel")]
	[Token(Token = "0x40009C8")]
	public Vector2 scroll; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[InputControl(name = "press", useStateFrom = "leftButton", synthetic = True, usages = new IL2CPP_TYPE_STRING[] {})]
	[InputControl(name = "leftButton", layout = "Button", bit = 0, usage = "PrimaryAction", displayName = "Left Button", shortDisplayName = "LMB")]
	[InputControl(name = "rightButton", layout = "Button", bit = 1, usage = "SecondaryAction", displayName = "Right Button", shortDisplayName = "RMB")]
	[InputControl(name = "middleButton", layout = "Button", bit = 2, displayName = "Middle Button", shortDisplayName = "MMB")]
	[InputControl(name = "forwardButton", layout = "Button", bit = 3, usage = "Forward", displayName = "Forward")]
	[InputControl(name = "backButton", layout = "Button", bit = 4, usage = "Back", displayName = "Back")]
	[InputControl(name = "pressure", layout = "Axis", usage = "Pressure", offset = 4294967294, format = "FLT", sizeInBits = 32)]
	[InputControl(name = "radius", layout = "Vector2", usage = "Radius", offset = 4294967294, format = "VEC2", sizeInBits = 64)]
	[InputControl(name = "pointerId", layout = "Digital", format = "BIT", sizeInBits = 1, offset = 4294967294)]
	[Token(Token = "0x40009C9")]
	public ushort buttons; //Field offset: 0x18
	[FieldOffset(Offset = "0x1A")]
	[InputControl(name = "displayIndex", layout = "Integer", displayName = "Display Index")]
	[Token(Token = "0x40009CA")]
	public ushort displayIndex; //Field offset: 0x1A
	[FieldOffset(Offset = "0x1C")]
	[InputControl(name = "clickCount", layout = "Integer", displayName = "Click Count", synthetic = True)]
	[Token(Token = "0x40009CB")]
	public ushort clickCount; //Field offset: 0x1C

	[Token(Token = "0x1700046E")]
	public override FourCC format
	{
		[Address(RVA = "0x29FB940", Offset = "0x29FAD40", Length = "0x3A")]
		[Token(Token = "0x6001012")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700046D")]
	public static FourCC Format
	{
		[Address(RVA = "0x29FB900", Offset = "0x29FAD00", Length = "0x3A")]
		[Token(Token = "0x6001010")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29FB940", Offset = "0x29FAD40", Length = "0x3A")]
	[Token(Token = "0x6001012")]
	public override FourCC get_format() { }

	[Address(RVA = "0x29FB900", Offset = "0x29FAD00", Length = "0x3A")]
	[Token(Token = "0x6001010")]
	public static FourCC get_Format() { }

	[Address(RVA = "0x29FB8A0", Offset = "0x29FACA0", Length = "0x54")]
	[Token(Token = "0x6001011")]
	public MouseState WithButton(MouseButton button, bool state = true) { }

}

