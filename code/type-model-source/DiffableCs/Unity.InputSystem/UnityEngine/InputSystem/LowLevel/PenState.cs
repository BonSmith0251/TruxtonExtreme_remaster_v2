namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001A1")]
public struct PenState : IInputStateTypeInfo
{
	[FieldOffset(Offset = "0x0")]
	[InputControl(usage = "Point", dontReset = True)]
	[Token(Token = "0x40009D2")]
	public Vector2 position; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[InputControl(usage = "Secondary2DMotion", layout = "Delta")]
	[Token(Token = "0x40009D3")]
	public Vector2 delta; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[InputControl(layout = "Vector2", displayName = "Tilt", usage = "Tilt")]
	[Token(Token = "0x40009D4")]
	public Vector2 tilt; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[InputControl(layout = "Analog", usage = "Pressure", defaultState = 0)]
	[Token(Token = "0x40009D5")]
	public float pressure; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[InputControl(layout = "Axis", displayName = "Twist", usage = "Twist")]
	[Token(Token = "0x40009D6")]
	public float twist; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[InputControl(name = "tip", displayName = "Tip", layout = "Button", bit = 0, usage = "PrimaryAction")]
	[InputControl(name = "press", useStateFrom = "tip", synthetic = True, usages = new IL2CPP_TYPE_STRING[] {})]
	[InputControl(name = "eraser", displayName = "Eraser", layout = "Button", bit = 1)]
	[InputControl(name = "inRange", displayName = "In Range?", layout = "Button", bit = 4, synthetic = True)]
	[InputControl(name = "barrel1", displayName = "Barrel Button #1", layout = "Button", bit = 2, alias = "barrelFirst", usage = "SecondaryAction")]
	[InputControl(name = "barrel2", displayName = "Barrel Button #2", layout = "Button", bit = 3, alias = "barrelSecond")]
	[InputControl(name = "barrel3", displayName = "Barrel Button #3", layout = "Button", bit = 5, alias = "barrelThird")]
	[InputControl(name = "barrel4", displayName = "Barrel Button #4", layout = "Button", bit = 6, alias = "barrelFourth")]
	[InputControl(name = "radius", layout = "Vector2", format = "VEC2", sizeInBits = 64, usage = "Radius", offset = 4294967294)]
	[InputControl(name = "pointerId", layout = "Digital", format = "UINT", sizeInBits = 32, offset = 4294967294)]
	[Token(Token = "0x40009D7")]
	public ushort buttons; //Field offset: 0x20
	[FieldOffset(Offset = "0x22")]
	[InputControl(name = "displayIndex", displayName = "Display Index", layout = "Integer")]
	[Token(Token = "0x40009D8")]
	private ushort displayIndex; //Field offset: 0x22

	[Token(Token = "0x17000470")]
	public override FourCC format
	{
		[Address(RVA = "0x29FBBB0", Offset = "0x29FAFB0", Length = "0x3A")]
		[Token(Token = "0x6001015")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700046F")]
	public static FourCC Format
	{
		[Address(RVA = "0x29FBB70", Offset = "0x29FAF70", Length = "0x3A")]
		[Token(Token = "0x6001013")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29FBBB0", Offset = "0x29FAFB0", Length = "0x3A")]
	[Token(Token = "0x6001015")]
	public override FourCC get_format() { }

	[Address(RVA = "0x29FBB70", Offset = "0x29FAF70", Length = "0x3A")]
	[Token(Token = "0x6001013")]
	public static FourCC get_Format() { }

	[Address(RVA = "0x29FBB20", Offset = "0x29FAF20", Length = "0x49")]
	[Token(Token = "0x6001014")]
	public PenState WithButton(PenButton button, bool state = true) { }

}

