namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x2000193")]
public struct GamepadState : IInputStateTypeInfo
{
	[Token(Token = "0x4000994")]
	internal const string ButtonSouthShortDisplayName = "A"; //Field offset: 0x0
	[Token(Token = "0x4000995")]
	internal const string ButtonNorthShortDisplayName = "Y"; //Field offset: 0x0
	[Token(Token = "0x4000996")]
	internal const string ButtonWestShortDisplayName = "X"; //Field offset: 0x0
	[Token(Token = "0x4000997")]
	internal const string ButtonEastShortDisplayName = "B"; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[InputControl(name = "dpad", layout = "Dpad", usage = "Hatswitch", displayName = "D-Pad", format = "BIT", sizeInBits = 4, bit = 0)]
	[InputControl(name = "buttonSouth", layout = "Button", bit = 6, usages = new IL2CPP_TYPE_STRING[] {"PrimaryAction", "Submit"}, aliases = new IL2CPP_TYPE_STRING[] {"a", "cross"}, displayName = "Button South", shortDisplayName = "A")]
	[InputControl(name = "buttonWest", layout = "Button", bit = 7, usage = "SecondaryAction", aliases = new IL2CPP_TYPE_STRING[] {"x", "square"}, displayName = "Button West", shortDisplayName = "X")]
	[InputControl(name = "buttonNorth", layout = "Button", bit = 4, aliases = new IL2CPP_TYPE_STRING[] {"y", "triangle"}, displayName = "Button North", shortDisplayName = "Y")]
	[InputControl(name = "buttonEast", layout = "Button", bit = 5, usages = new IL2CPP_TYPE_STRING[] {"Back", "Cancel"}, aliases = new IL2CPP_TYPE_STRING[] {"b", "circle"}, displayName = "Button East", shortDisplayName = "B")]
	[InputControl(name = "leftStickPress", layout = "Button", bit = 8, displayName = "Left Stick Press")]
	[InputControl(name = "rightStickPress", layout = "Button", bit = 9, displayName = "Right Stick Press")]
	[InputControl(name = "leftShoulder", layout = "Button", bit = 10, displayName = "Left Shoulder", shortDisplayName = "LB")]
	[InputControl(name = "rightShoulder", layout = "Button", bit = 11, displayName = "Right Shoulder", shortDisplayName = "RB")]
	[InputControl(name = "start", layout = "Button", bit = 12, usage = "Menu", displayName = "Start")]
	[InputControl(name = "select", layout = "Button", bit = 13, displayName = "Select")]
	[Token(Token = "0x4000998")]
	public uint buttons; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[InputControl(layout = "Stick", usage = "Primary2DMotion", processors = "stickDeadzone", displayName = "Left Stick", shortDisplayName = "LS")]
	[Token(Token = "0x4000999")]
	public Vector2 leftStick; //Field offset: 0x4
	[FieldOffset(Offset = "0xC")]
	[InputControl(layout = "Stick", usage = "Secondary2DMotion", processors = "stickDeadzone", displayName = "Right Stick", shortDisplayName = "RS")]
	[Token(Token = "0x400099A")]
	public Vector2 rightStick; //Field offset: 0xC
	[FieldOffset(Offset = "0x14")]
	[InputControl(layout = "Button", format = "FLT", usage = "SecondaryTrigger", displayName = "Left Trigger", shortDisplayName = "LT")]
	[Token(Token = "0x400099B")]
	public float leftTrigger; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[InputControl(layout = "Button", format = "FLT", usage = "SecondaryTrigger", displayName = "Right Trigger", shortDisplayName = "RT")]
	[Token(Token = "0x400099C")]
	public float rightTrigger; //Field offset: 0x18

	[Token(Token = "0x17000466")]
	public override FourCC format
	{
		[Address(RVA = "0x29F1780", Offset = "0x29F0B80", Length = "0x3A")]
		[Token(Token = "0x6000FFA")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000465")]
	public static FourCC Format
	{
		[Address(RVA = "0x29F1740", Offset = "0x29F0B40", Length = "0x3A")]
		[Token(Token = "0x6000FF9")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29F1690", Offset = "0x29F0A90", Length = "0xA2")]
	[Token(Token = "0x6000FFB")]
	public GamepadState(GamepadButton[] buttons) { }

	[Address(RVA = "0x29F1780", Offset = "0x29F0B80", Length = "0x3A")]
	[Token(Token = "0x6000FFA")]
	public override FourCC get_format() { }

	[Address(RVA = "0x29F1740", Offset = "0x29F0B40", Length = "0x3A")]
	[Token(Token = "0x6000FF9")]
	public static FourCC get_Format() { }

	[Address(RVA = "0x29F1640", Offset = "0x29F0A40", Length = "0x43")]
	[Token(Token = "0x6000FFC")]
	public GamepadState WithButton(GamepadButton button, bool value = true) { }

}

