namespace UnityEngine.InputSystem.DualShock.LowLevel;

[Token(Token = "0x2000167")]
public struct DualSenseHIDInputReport : IInputStateTypeInfo
{
	[Token(Token = "0x40008FF")]
	public static FourCC Format; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[InputControl(name = "leftStick", layout = "Stick", format = "VC2B")]
	[InputControl(name = "leftStick/x", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
	[InputControl(name = "leftStick/left", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
	[InputControl(name = "leftStick/right", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
	[InputControl(name = "leftStick/y", offset = 1, format = "BYTE", parameters = "invert,normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
	[InputControl(name = "leftStick/up", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
	[InputControl(name = "leftStick/down", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1,invert=false")]
	[Token(Token = "0x4000900")]
	public byte leftStickX; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x4000901")]
	public byte leftStickY; //Field offset: 0x1
	[FieldOffset(Offset = "0x2")]
	[InputControl(name = "rightStick", layout = "Stick", format = "VC2B")]
	[InputControl(name = "rightStick/x", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
	[InputControl(name = "rightStick/left", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
	[InputControl(name = "rightStick/right", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
	[InputControl(name = "rightStick/y", offset = 1, format = "BYTE", parameters = "invert,normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
	[InputControl(name = "rightStick/up", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
	[InputControl(name = "rightStick/down", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1,invert=false")]
	[Token(Token = "0x4000902")]
	public byte rightStickX; //Field offset: 0x2
	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x4000903")]
	public byte rightStickY; //Field offset: 0x3
	[FieldOffset(Offset = "0x4")]
	[InputControl(name = "leftTrigger", format = "BYTE")]
	[Token(Token = "0x4000904")]
	public byte leftTrigger; //Field offset: 0x4
	[FieldOffset(Offset = "0x5")]
	[InputControl(name = "rightTrigger", format = "BYTE")]
	[Token(Token = "0x4000905")]
	public byte rightTrigger; //Field offset: 0x5
	[FieldOffset(Offset = "0x6")]
	[InputControl(name = "dpad", format = "BIT", layout = "Dpad", sizeInBits = 4, defaultState = 8)]
	[InputControl(name = "dpad/up", format = "BIT", layout = "DiscreteButton", parameters = "minValue=7,maxValue=1,nullValue=8,wrapAtValue=7", bit = 0, sizeInBits = 4)]
	[InputControl(name = "dpad/right", format = "BIT", layout = "DiscreteButton", parameters = "minValue=1,maxValue=3", bit = 0, sizeInBits = 4)]
	[InputControl(name = "dpad/down", format = "BIT", layout = "DiscreteButton", parameters = "minValue=3,maxValue=5", bit = 0, sizeInBits = 4)]
	[InputControl(name = "dpad/left", format = "BIT", layout = "DiscreteButton", parameters = "minValue=5, maxValue=7", bit = 0, sizeInBits = 4)]
	[InputControl(name = "buttonWest", displayName = "Square", bit = 4)]
	[InputControl(name = "buttonSouth", displayName = "Cross", bit = 5)]
	[InputControl(name = "buttonEast", displayName = "Circle", bit = 6)]
	[InputControl(name = "buttonNorth", displayName = "Triangle", bit = 7)]
	[Token(Token = "0x4000906")]
	public byte buttons0; //Field offset: 0x6
	[FieldOffset(Offset = "0x7")]
	[InputControl(name = "leftShoulder", bit = 0)]
	[InputControl(name = "rightShoulder", bit = 1)]
	[InputControl(name = "leftTriggerButton", layout = "Button", bit = 2)]
	[InputControl(name = "rightTriggerButton", layout = "Button", bit = 3)]
	[InputControl(name = "select", displayName = "Share", bit = 4)]
	[InputControl(name = "start", displayName = "Options", bit = 5)]
	[InputControl(name = "leftStickPress", bit = 6)]
	[InputControl(name = "rightStickPress", bit = 7)]
	[Token(Token = "0x4000907")]
	public byte buttons1; //Field offset: 0x7
	[FieldOffset(Offset = "0x8")]
	[InputControl(name = "systemButton", layout = "Button", displayName = "System", bit = 0)]
	[InputControl(name = "touchpadButton", layout = "Button", displayName = "Touchpad Press", bit = 1)]
	[InputControl(name = "micButton", layout = "Button", displayName = "Mic Mute", bit = 2)]
	[Token(Token = "0x4000908")]
	public byte buttons2; //Field offset: 0x8

	[Token(Token = "0x1700042D")]
	public override FourCC format
	{
		[Address(RVA = "0x29ECAA0", Offset = "0x29EBEA0", Length = "0x4D")]
		[Token(Token = "0x6000F89")]
		 get { } //Length: 77
	}

	[Address(RVA = "0x29ECA30", Offset = "0x29EBE30", Length = "0x66")]
	[Token(Token = "0x6000F8A")]
	private static DualSenseHIDInputReport() { }

	[Address(RVA = "0x29ECAA0", Offset = "0x29EBEA0", Length = "0x4D")]
	[Token(Token = "0x6000F89")]
	public override FourCC get_format() { }

}

