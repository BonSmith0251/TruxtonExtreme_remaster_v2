namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x200018C")]
internal struct QueryUserIdCommand : IInputDeviceCommandInfo
{
	[CompilerGenerated]
	[Token(Token = "0x200018D")]
	[UnsafeValueType]
	internal struct <idBuffer>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000986")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[Token(Token = "0x4000982")]
	public const int kMaxIdLength = 256; //Field offset: 0x0
	[Token(Token = "0x4000983")]
	internal const int kSize = 520; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000984")]
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[FixedBuffer(typeof(byte), 512)]
	[Token(Token = "0x4000985")]
	public <idBuffer>e__FixedBuffer idBuffer; //Field offset: 0x8

	[Token(Token = "0x17000458")]
	public static FourCC Type
	{
		[Address(RVA = "0x29FC620", Offset = "0x29FBA20", Length = "0x3A")]
		[Token(Token = "0x6000FE5")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000459")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29FC660", Offset = "0x29FBA60", Length = "0x3A")]
		[Token(Token = "0x6000FE7")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29FC5B0", Offset = "0x29FB9B0", Length = "0x64")]
	[Token(Token = "0x6000FE8")]
	public static QueryUserIdCommand Create() { }

	[Address(RVA = "0x29FC620", Offset = "0x29FBA20", Length = "0x3A")]
	[Token(Token = "0x6000FE5")]
	public static FourCC get_Type() { }

	[Address(RVA = "0x29FC660", Offset = "0x29FBA60", Length = "0x3A")]
	[Token(Token = "0x6000FE7")]
	public override FourCC get_typeStatic() { }

	[Address(RVA = "0x29FC0B0", Offset = "0x29FB4B0", Length = "0x11")]
	[Token(Token = "0x6000FE6")]
	public string ReadId() { }

}

