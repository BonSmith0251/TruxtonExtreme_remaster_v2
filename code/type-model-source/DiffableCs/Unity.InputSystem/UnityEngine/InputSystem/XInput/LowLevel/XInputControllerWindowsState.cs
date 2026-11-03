namespace UnityEngine.InputSystem.XInput.LowLevel;

[Token(Token = "0x2000107")]
internal struct XInputControllerWindowsState : IInputStateTypeInfo
{
	[Token(Token = "0x2000108")]
	internal enum Button : int
	{
		DPadUp = 0,
		DPadDown = 1,
		DPadLeft = 2,
		DPadRight = 3,
		Start = 4,
		Select = 5,
		LeftThumbstickPress = 6,
		RightThumbstickPress = 7,
		LeftShoulder = 8,
		RightShoulder = 9,
		A = 12,
		B = 13,
		X = 14,
		Y = 15,
	}

	[FieldOffset(Offset = "0x0")]
	[InputControl(name = "buttonNorth", bit = 15, displayName = "Y")]
	[InputControl(name = "buttonWest", bit = 14, displayName = "X")]
	[InputControl(name = "buttonEast", bit = 13, displayName = "B")]
	[InputControl(name = "buttonSouth", bit = 12, displayName = "A")]
	[InputControl(name = "rightShoulder", bit = 9)]
	[InputControl(name = "leftShoulder", bit = 8)]
	[InputControl(name = "rightStickPress", bit = 7)]
	[InputControl(name = "select", bit = 5, displayName = "Select")]
	[InputControl(name = "start", bit = 4, displayName = "Start")]
	[InputControl(name = "dpad/right", bit = 3)]
	[InputControl(name = "dpad/left", bit = 2)]
	[InputControl(name = "dpad/down", bit = 1)]
	[InputControl(name = "dpad/up", bit = 0)]
	[InputControl(name = "leftStickPress", bit = 6)]
	[InputControl(name = "dpad", layout = "Dpad", sizeInBits = 4, bit = 0)]
	[Token(Token = "0x4000600")]
	public ushort buttons; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[InputControl(name = "leftTrigger", format = "BYTE")]
	[Token(Token = "0x4000601")]
	public byte leftTrigger; //Field offset: 0x2
	[FieldOffset(Offset = "0x3")]
	[InputControl(name = "rightTrigger", format = "BYTE")]
	[Token(Token = "0x4000602")]
	public byte rightTrigger; //Field offset: 0x3
	[FieldOffset(Offset = "0x4")]
	[InputControl(name = "leftStick", layout = "Stick", format = "VC2S")]
	[InputControl(name = "leftStick/x", offset = 0, format = "SHRT", parameters = "clamp=false,invert=false,normalize=false")]
	[InputControl(name = "leftStick/left", offset = 0, format = "SHRT")]
	[InputControl(name = "leftStick/right", offset = 0, format = "SHRT")]
	[InputControl(name = "leftStick/y", offset = 2, format = "SHRT", parameters = "clamp=false,invert=false,normalize=false")]
	[InputControl(name = "leftStick/up", offset = 2, format = "SHRT")]
	[InputControl(name = "leftStick/down", offset = 2, format = "SHRT")]
	[Token(Token = "0x4000603")]
	public short leftStickX; //Field offset: 0x4
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x4000604")]
	public short leftStickY; //Field offset: 0x6
	[FieldOffset(Offset = "0x8")]
	[InputControl(name = "rightStick", layout = "Stick", format = "VC2S")]
	[InputControl(name = "rightStick/x", offset = 0, format = "SHRT", parameters = "clamp=false,invert=false,normalize=false")]
	[InputControl(name = "rightStick/left", offset = 0, format = "SHRT")]
	[InputControl(name = "rightStick/right", offset = 0, format = "SHRT")]
	[InputControl(name = "rightStick/y", offset = 2, format = "SHRT", parameters = "clamp=false,invert=false,normalize=false")]
	[InputControl(name = "rightStick/up", offset = 2, format = "SHRT")]
	[InputControl(name = "rightStick/down", offset = 2, format = "SHRT")]
	[Token(Token = "0x4000605")]
	public short rightStickX; //Field offset: 0x8
	[FieldOffset(Offset = "0xA")]
	[Token(Token = "0x4000606")]
	public short rightStickY; //Field offset: 0xA

	[Token(Token = "0x17000360")]
	public override FourCC format
	{
		[Address(RVA = "0x29D1580", Offset = "0x29D0980", Length = "0x3A")]
		[Token(Token = "0x6000CCF")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29D1580", Offset = "0x29D0980", Length = "0x3A")]
	[Token(Token = "0x6000CCF")]
	public override FourCC get_format() { }

	[Address(RVA = "0x29D1550", Offset = "0x29D0950", Length = "0x22")]
	[Token(Token = "0x6000CD0")]
	public XInputControllerWindowsState WithButton(Button button) { }

}

