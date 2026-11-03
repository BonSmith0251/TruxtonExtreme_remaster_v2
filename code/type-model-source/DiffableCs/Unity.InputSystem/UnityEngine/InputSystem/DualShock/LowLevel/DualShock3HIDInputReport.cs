namespace UnityEngine.InputSystem.DualShock.LowLevel;

[Token(Token = "0x200016D")]
internal struct DualShock3HIDInputReport : IInputStateTypeInfo
{
	[CompilerGenerated]
	[Token(Token = "0x200016E")]
	[UnsafeValueType]
	internal struct <padding3>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000933")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000927")]
	private ushort padding1; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[InputControl(name = "select", displayName = "Share", bit = 0)]
	[InputControl(name = "leftStickPress", bit = 1)]
	[InputControl(name = "rightStickPress", bit = 2)]
	[InputControl(name = "start", displayName = "Options", bit = 3)]
	[InputControl(name = "dpad", format = "BIT", layout = "Dpad", bit = 4, sizeInBits = 4)]
	[InputControl(name = "dpad/up", bit = 4)]
	[InputControl(name = "dpad/right", bit = 5)]
	[InputControl(name = "dpad/down", bit = 6)]
	[InputControl(name = "dpad/left", bit = 7)]
	[Token(Token = "0x4000928")]
	public byte buttons1; //Field offset: 0x2
	[FieldOffset(Offset = "0x3")]
	[InputControl(name = "leftTriggerButton", layout = "Button", bit = 0, synthetic = True)]
	[InputControl(name = "rightTriggerButton", layout = "Button", bit = 1, synthetic = True)]
	[InputControl(name = "leftShoulder", bit = 2)]
	[InputControl(name = "rightShoulder", bit = 3)]
	[InputControl(name = "buttonNorth", displayName = "Triangle", bit = 4)]
	[InputControl(name = "buttonEast", displayName = "Circle", bit = 5)]
	[InputControl(name = "buttonSouth", displayName = "Cross", bit = 6)]
	[InputControl(name = "buttonWest", displayName = "Square", bit = 7)]
	[Token(Token = "0x4000929")]
	public byte buttons2; //Field offset: 0x3
	[FieldOffset(Offset = "0x4")]
	[InputControl(name = "systemButton", layout = "Button", displayName = "System", bit = 0)]
	[InputControl(name = "touchpadButton", layout = "Button", displayName = "Touchpad Press", bit = 1)]
	[Token(Token = "0x400092A")]
	public byte buttons3; //Field offset: 0x4
	[FieldOffset(Offset = "0x5")]
	[Token(Token = "0x400092B")]
	private byte padding2; //Field offset: 0x5
	[FieldOffset(Offset = "0x6")]
	[InputControl(name = "leftStick", layout = "Stick", format = "VC2B")]
	[InputControl(name = "leftStick/x", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
	[InputControl(name = "leftStick/left", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
	[InputControl(name = "leftStick/right", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
	[InputControl(name = "leftStick/y", offset = 1, format = "BYTE", parameters = "invert,normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
	[InputControl(name = "leftStick/up", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
	[InputControl(name = "leftStick/down", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1,invert=false")]
	[Token(Token = "0x400092C")]
	public byte leftStickX; //Field offset: 0x6
	[FieldOffset(Offset = "0x7")]
	[Token(Token = "0x400092D")]
	public byte leftStickY; //Field offset: 0x7
	[FieldOffset(Offset = "0x8")]
	[InputControl(name = "rightStick", layout = "Stick", format = "VC2B")]
	[InputControl(name = "rightStick/x", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
	[InputControl(name = "rightStick/left", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
	[InputControl(name = "rightStick/right", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
	[InputControl(name = "rightStick/y", offset = 1, format = "BYTE", parameters = "invert,normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
	[InputControl(name = "rightStick/up", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
	[InputControl(name = "rightStick/down", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1,invert=false")]
	[Token(Token = "0x400092E")]
	public byte rightStickX; //Field offset: 0x8
	[FieldOffset(Offset = "0x9")]
	[Token(Token = "0x400092F")]
	public byte rightStickY; //Field offset: 0x9
	[FieldOffset(Offset = "0xA")]
	[FixedBuffer(typeof(byte), 8)]
	[Token(Token = "0x4000930")]
	private <padding3>e__FixedBuffer padding3; //Field offset: 0xA
	[FieldOffset(Offset = "0x12")]
	[InputControl(name = "leftTrigger", format = "BYTE")]
	[Token(Token = "0x4000931")]
	public byte leftTrigger; //Field offset: 0x12
	[FieldOffset(Offset = "0x13")]
	[InputControl(name = "rightTrigger", format = "BYTE")]
	[Token(Token = "0x4000932")]
	public byte rightTrigger; //Field offset: 0x13

	[Token(Token = "0x17000433")]
	public override FourCC format
	{
		[Address(RVA = "0x29ECD80", Offset = "0x29EC180", Length = "0x3A")]
		[Token(Token = "0x6000F93")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29ECD80", Offset = "0x29EC180", Length = "0x3A")]
	[Token(Token = "0x6000F93")]
	public override FourCC get_format() { }

}

