namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001AA")]
internal struct TouchscreenState : IInputStateTypeInfo
{
	[CompilerGenerated]
	[Token(Token = "0x20001AB")]
	[UnsafeValueType]
	internal struct <primaryTouchData>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009FD")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20001AC")]
	[UnsafeValueType]
	internal struct <touchData>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009FE")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[Token(Token = "0x40009F9")]
	public const int MaxTouches = 10; //Field offset: 0x0
	[Token(Token = "0x40009FB")]
	internal const int kTouchDataOffset = 56; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[FixedBuffer(typeof(byte), 56)]
	[InputControl(name = "primaryTouch", displayName = "Primary Touch", layout = "Touch", synthetic = True)]
	[InputControl(name = "primaryTouch/tap", usage = "PrimaryAction")]
	[InputControl(name = "position", useStateFrom = "primaryTouch/position")]
	[InputControl(name = "delta", useStateFrom = "primaryTouch/delta", layout = "Delta")]
	[InputControl(name = "pressure", useStateFrom = "primaryTouch/pressure")]
	[InputControl(name = "radius", useStateFrom = "primaryTouch/radius")]
	[InputControl(name = "press", useStateFrom = "primaryTouch/phase", layout = "TouchPress", synthetic = True, usages = new IL2CPP_TYPE_STRING[] {})]
	[InputControl(name = "displayIndex", useStateFrom = "primaryTouch/displayIndex", format = "BYTE")]
	[Token(Token = "0x40009FA")]
	public <primaryTouchData>e__FixedBuffer primaryTouchData; //Field offset: 0x0
	[FieldOffset(Offset = "0x38")]
	[FixedBuffer(typeof(byte), 560)]
	[InputControl(layout = "Touch", name = "touch", displayName = "Touch", arraySize = 10)]
	[Token(Token = "0x40009FC")]
	public <touchData>e__FixedBuffer touchData; //Field offset: 0x38

	[Token(Token = "0x1700048C")]
	public override FourCC format
	{
		[Address(RVA = "0x2A00960", Offset = "0x29FFD60", Length = "0x3A")]
		[Token(Token = "0x600103A")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000489")]
	public static FourCC Format
	{
		[Address(RVA = "0x2A00920", Offset = "0x29FFD20", Length = "0x3A")]
		[Token(Token = "0x6001037")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700048A")]
	public TouchState* primaryTouch
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x6001038")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700048B")]
	public TouchState* touches
	{
		[Address(RVA = "0x2A009A0", Offset = "0x29FFDA0", Length = "0x5")]
		[Token(Token = "0x6001039")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2A00960", Offset = "0x29FFD60", Length = "0x3A")]
	[Token(Token = "0x600103A")]
	public override FourCC get_format() { }

	[Address(RVA = "0x2A00920", Offset = "0x29FFD20", Length = "0x3A")]
	[Token(Token = "0x6001037")]
	public static FourCC get_Format() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6001038")]
	public TouchState* get_primaryTouch() { }

	[Address(RVA = "0x2A009A0", Offset = "0x29FFDA0", Length = "0x5")]
	[Token(Token = "0x6001039")]
	public TouchState* get_touches() { }

}

