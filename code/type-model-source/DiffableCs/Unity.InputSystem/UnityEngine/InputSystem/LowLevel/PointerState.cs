namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001A2")]
internal struct PointerState : IInputStateTypeInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009D9")]
	private uint pointerId; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[InputControl(layout = "Vector2", displayName = "Position", usage = "Point", dontReset = True)]
	[Token(Token = "0x40009DA")]
	public Vector2 position; //Field offset: 0x4
	[FieldOffset(Offset = "0xC")]
	[InputControl(layout = "Delta", displayName = "Delta", usage = "Secondary2DMotion")]
	[Token(Token = "0x40009DB")]
	public Vector2 delta; //Field offset: 0xC
	[FieldOffset(Offset = "0x14")]
	[InputControl(layout = "Analog", displayName = "Pressure", usage = "Pressure", defaultState = 1)]
	[Token(Token = "0x40009DC")]
	public float pressure; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[InputControl(layout = "Vector2", displayName = "Radius", usage = "Radius")]
	[Token(Token = "0x40009DD")]
	public Vector2 radius; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[InputControl(name = "press", displayName = "Press", layout = "Button", format = "BIT", bit = 0)]
	[Token(Token = "0x40009DE")]
	public ushort buttons; //Field offset: 0x20
	[FieldOffset(Offset = "0x22")]
	[InputControl(name = "displayIndex", layout = "Integer", displayName = "Display Index")]
	[Token(Token = "0x40009DF")]
	public ushort displayIndex; //Field offset: 0x22

	[Token(Token = "0x17000472")]
	public override FourCC format
	{
		[Address(RVA = "0x29FBBF0", Offset = "0x29FAFF0", Length = "0x3A")]
		[Token(Token = "0x6001017")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000471")]
	public static FourCC kFormat
	{
		[Address(RVA = "0x29FBC30", Offset = "0x29FB030", Length = "0x3A")]
		[Token(Token = "0x6001016")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29FBBF0", Offset = "0x29FAFF0", Length = "0x3A")]
	[Token(Token = "0x6001017")]
	public override FourCC get_format() { }

	[Address(RVA = "0x29FBC30", Offset = "0x29FB030", Length = "0x3A")]
	[Token(Token = "0x6001016")]
	public static FourCC get_kFormat() { }

}

