namespace UnityEngine.InputSystem.Switch.LowLevel;

[Token(Token = "0x2000134")]
internal struct SwitchProControllerHIDInputState : IInputStateTypeInfo
{
	[Token(Token = "0x2000135")]
	internal enum Button : int
	{
		Up = 0,
		Right = 1,
		Down = 2,
		Left = 3,
		West = 4,
		North = 5,
		South = 6,
		East = 7,
		L = 8,
		R = 9,
		StickL = 10,
		StickR = 11,
		ZL = 12,
		ZR = 13,
		Plus = 14,
		Minus = 15,
		Capture = 16,
		Home = 17,
		X = 5,
		B = 6,
		Y = 4,
		A = 7,
	}

	[Token(Token = "0x400072A")]
	public static FourCC Format; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[InputControl(name = "leftStick", layout = "Stick", format = "VC2B")]
	[InputControl(name = "leftStick/x", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5")]
	[InputControl(name = "leftStick/left", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.15,clampMax=0.5,invert")]
	[InputControl(name = "leftStick/right", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=0.85")]
	[InputControl(name = "leftStick/y", offset = 1, format = "BYTE", parameters = "invert,normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5")]
	[InputControl(name = "leftStick/up", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.15,clampMax=0.5,invert")]
	[InputControl(name = "leftStick/down", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=0.85,invert=false")]
	[Token(Token = "0x400072B")]
	public byte leftStickX; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x400072C")]
	public byte leftStickY; //Field offset: 0x1
	[FieldOffset(Offset = "0x2")]
	[InputControl(name = "rightStick", layout = "Stick", format = "VC2B")]
	[InputControl(name = "rightStick/x", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5")]
	[InputControl(name = "rightStick/left", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
	[InputControl(name = "rightStick/right", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
	[InputControl(name = "rightStick/y", offset = 1, format = "BYTE", parameters = "invert,normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5")]
	[InputControl(name = "rightStick/up", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.15,clampMax=0.5,invert")]
	[InputControl(name = "rightStick/down", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=0.85,invert=false")]
	[Token(Token = "0x400072D")]
	public byte rightStickX; //Field offset: 0x2
	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x400072E")]
	public byte rightStickY; //Field offset: 0x3
	[FieldOffset(Offset = "0x4")]
	[InputControl(name = "select", displayName = "Minus", bit = 15)]
	[InputControl(name = "start", displayName = "Plus", bit = 14, usage = "Menu")]
	[InputControl(name = "rightTrigger", displayName = "ZR", shortDisplayName = "ZR", format = "BIT", bit = 13)]
	[InputControl(name = "leftTrigger", displayName = "ZL", shortDisplayName = "ZL", format = "BIT", bit = 12)]
	[InputControl(name = "rightStickPress", displayName = "Right Stick", bit = 11)]
	[InputControl(name = "leftStickPress", displayName = "Left Stick", bit = 10)]
	[InputControl(name = "rightShoulder", displayName = "R", shortDisplayName = "R", bit = 9)]
	[InputControl(name = "leftShoulder", displayName = "L", shortDisplayName = "L", bit = 8)]
	[InputControl(name = "buttonSouth", displayName = "B", shortDisplayName = "B", bit = 6, usages = new IL2CPP_TYPE_STRING[] {"Back", "Cancel"})]
	[InputControl(name = "buttonNorth", displayName = "X", shortDisplayName = "X", bit = 5)]
	[InputControl(name = "buttonWest", displayName = "Y", shortDisplayName = "Y", bit = 4, usage = "SecondaryAction")]
	[InputControl(name = "dpad/left", bit = 3)]
	[InputControl(name = "dpad/down", bit = 2)]
	[InputControl(name = "dpad/right", bit = 1)]
	[InputControl(name = "dpad/up", bit = 0)]
	[InputControl(name = "buttonEast", displayName = "A", shortDisplayName = "A", bit = 7, usages = new IL2CPP_TYPE_STRING[] {"PrimaryAction", "Submit"})]
	[InputControl(name = "dpad", format = "BIT", bit = 0, sizeInBits = 4)]
	[Token(Token = "0x400072F")]
	public ushort buttons1; //Field offset: 0x4
	[FieldOffset(Offset = "0x6")]
	[InputControl(name = "capture", layout = "Button", displayName = "Capture", bit = 0)]
	[InputControl(name = "home", layout = "Button", displayName = "Home", bit = 1)]
	[Token(Token = "0x4000730")]
	public byte buttons2; //Field offset: 0x6

	[Token(Token = "0x170003D2")]
	public override FourCC format
	{
		[Address(RVA = "0x29E5950", Offset = "0x29E4D50", Length = "0x4D")]
		[Token(Token = "0x6000E51")]
		 get { } //Length: 77
	}

	[Address(RVA = "0x29E58E0", Offset = "0x29E4CE0", Length = "0x66")]
	[Token(Token = "0x6000E56")]
	private static SwitchProControllerHIDInputState() { }

	[Address(RVA = "0x29E5950", Offset = "0x29E4D50", Length = "0x4D")]
	[Token(Token = "0x6000E51")]
	public override FourCC get_format() { }

	[Address(RVA = "0x29E5690", Offset = "0x29E4A90", Length = "0x80")]
	[Token(Token = "0x6000E54")]
	public void Press(Button button) { }

	[Address(RVA = "0x29E5710", Offset = "0x29E4B10", Length = "0x80")]
	[Token(Token = "0x6000E55")]
	public void Release(Button button) { }

	[Address(RVA = "0x29E5790", Offset = "0x29E4B90", Length = "0x61")]
	[Token(Token = "0x6000E53")]
	public void Set(Button button, bool state) { }

	[Address(RVA = "0x29E5800", Offset = "0x29E4C00", Length = "0xD8")]
	[Token(Token = "0x6000E52")]
	public SwitchProControllerHIDInputState WithButton(Button button, bool value = true) { }

}

