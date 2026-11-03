namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x200019B")]
internal struct JoystickState : IInputStateTypeInfo
{
	[Token(Token = "0x200019C")]
	internal enum Button : int
	{
		HatSwitchUp = 0,
		HatSwitchDown = 1,
		HatSwitchLeft = 2,
		HatSwitchRight = 3,
		Trigger = 4,
	}

	[FieldOffset(Offset = "0x0")]
	[InputControl(name = "trigger", displayName = "Trigger", layout = "Button", usages = new IL2CPP_TYPE_STRING[] {"PrimaryTrigger", "PrimaryAction", "Submit"}, bit = 4)]
	[Token(Token = "0x40009BA")]
	public int buttons; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[InputControl(displayName = "Stick", layout = "Stick", usage = "Primary2DMotion", processors = "stickDeadzone")]
	[Token(Token = "0x40009BB")]
	public Vector2 stick; //Field offset: 0x4

	[Token(Token = "0x1700046A")]
	public override FourCC format
	{
		[Address(RVA = "0x29FB540", Offset = "0x29FA940", Length = "0x3A")]
		[Token(Token = "0x6001007")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000469")]
	public static FourCC kFormat
	{
		[Address(RVA = "0x29FB580", Offset = "0x29FA980", Length = "0x3A")]
		[Token(Token = "0x6001006")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29FB540", Offset = "0x29FA940", Length = "0x3A")]
	[Token(Token = "0x6001007")]
	public override FourCC get_format() { }

	[Address(RVA = "0x29FB580", Offset = "0x29FA980", Length = "0x3A")]
	[Token(Token = "0x6001006")]
	public static FourCC get_kFormat() { }

}

