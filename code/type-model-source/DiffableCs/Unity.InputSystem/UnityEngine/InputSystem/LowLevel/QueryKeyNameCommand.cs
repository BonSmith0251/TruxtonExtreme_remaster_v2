namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x2000185")]
public struct QueryKeyNameCommand : IInputDeviceCommandInfo
{
	[CompilerGenerated]
	[Token(Token = "0x2000186")]
	[UnsafeValueType]
	internal struct <nameBuffer>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000970")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[Token(Token = "0x400096B")]
	internal const int kMaxNameLength = 256; //Field offset: 0x0
	[Token(Token = "0x400096C")]
	internal const int kSize = 268; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400096D")]
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400096E")]
	public int scanOrKeyCode; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[FixedBuffer(typeof(byte), 256)]
	[Token(Token = "0x400096F")]
	public <nameBuffer>e__FixedBuffer nameBuffer; //Field offset: 0xC

	[Token(Token = "0x17000450")]
	public static FourCC Type
	{
		[Address(RVA = "0x29FBFC0", Offset = "0x29FB3C0", Length = "0x3A")]
		[Token(Token = "0x6000FD7")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000451")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29FC000", Offset = "0x29FB400", Length = "0x3A")]
		[Token(Token = "0x6000FD9")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29FBF20", Offset = "0x29FB320", Length = "0x72")]
	[Token(Token = "0x6000FDA")]
	public static QueryKeyNameCommand Create(Key key) { }

	[Address(RVA = "0x29FBFC0", Offset = "0x29FB3C0", Length = "0x3A")]
	[Token(Token = "0x6000FD7")]
	public static FourCC get_Type() { }

	[Address(RVA = "0x29FC000", Offset = "0x29FB400", Length = "0x3A")]
	[Token(Token = "0x6000FD9")]
	public override FourCC get_typeStatic() { }

	[Address(RVA = "0x29FBFA0", Offset = "0x29FB3A0", Length = "0x11")]
	[Token(Token = "0x6000FD8")]
	public string ReadKeyName() { }

}

