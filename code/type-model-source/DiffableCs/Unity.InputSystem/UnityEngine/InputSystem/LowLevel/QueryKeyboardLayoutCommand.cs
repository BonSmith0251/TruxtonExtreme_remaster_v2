namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x2000183")]
public struct QueryKeyboardLayoutCommand : IInputDeviceCommandInfo
{
	[CompilerGenerated]
	[Token(Token = "0x2000184")]
	[UnsafeValueType]
	internal struct <nameBuffer>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400096A")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[Token(Token = "0x4000967")]
	internal const int kMaxNameLength = 256; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000968")]
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[FixedBuffer(typeof(byte), 256)]
	[Token(Token = "0x4000969")]
	public <nameBuffer>e__FixedBuffer nameBuffer; //Field offset: 0x8

	[Token(Token = "0x1700044E")]
	public static FourCC Type
	{
		[Address(RVA = "0x29FC100", Offset = "0x29FB500", Length = "0x3A")]
		[Token(Token = "0x6000FD2")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700044F")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29FC140", Offset = "0x29FB540", Length = "0x3A")]
		[Token(Token = "0x6000FD5")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29FC040", Offset = "0x29FB440", Length = "0x64")]
	[Token(Token = "0x6000FD6")]
	public static QueryKeyboardLayoutCommand Create() { }

	[Address(RVA = "0x29FC100", Offset = "0x29FB500", Length = "0x3A")]
	[Token(Token = "0x6000FD2")]
	public static FourCC get_Type() { }

	[Address(RVA = "0x29FC140", Offset = "0x29FB540", Length = "0x3A")]
	[Token(Token = "0x6000FD5")]
	public override FourCC get_typeStatic() { }

	[Address(RVA = "0x29FC0B0", Offset = "0x29FB4B0", Length = "0x11")]
	[Token(Token = "0x6000FD3")]
	public string ReadLayoutName() { }

	[Address(RVA = "0x29FC0D0", Offset = "0x29FB4D0", Length = "0x2A")]
	[Token(Token = "0x6000FD4")]
	public void WriteLayoutName(string name) { }

}

