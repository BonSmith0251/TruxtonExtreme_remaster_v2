namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x200017F")]
public struct InputDeviceCommand : IInputDeviceCommandInfo
{
	[Token(Token = "0x4000958")]
	internal const int kBaseCommandSize = 8; //Field offset: 0x0
	[Token(Token = "0x4000959")]
	public const int BaseCommandSize = 8; //Field offset: 0x0
	[Token(Token = "0x400095A")]
	public const long GenericFailure = -1; //Field offset: 0x0
	[Token(Token = "0x400095B")]
	public const long GenericSuccess = 1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400095C")]
	public FourCC type; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400095D")]
	public int sizeInBytes; //Field offset: 0x4

	[Token(Token = "0x17000446")]
	public Void* payloadPtr
	{
		[Address(RVA = "0x29F67E0", Offset = "0x29F5BE0", Length = "0x5")]
		[Token(Token = "0x6000FC5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000445")]
	public int payloadSizeInBytes
	{
		[Address(RVA = "0x29F67F0", Offset = "0x29F5BF0", Length = "0x7")]
		[Token(Token = "0x6000FC4")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000447")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000FC8")]
		 get { } //Length: 3
	}

	[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
	[Token(Token = "0x6000FC6")]
	public InputDeviceCommand(FourCC type, int sizeInBytes = 8) { }

	[Address(RVA = "0x29F6730", Offset = "0x29F5B30", Length = "0xAF")]
	[Token(Token = "0x6000FC7")]
	public static NativeArray<Byte> AllocateNative(FourCC type, int payloadSize) { }

	[Address(RVA = "0x29F67E0", Offset = "0x29F5BE0", Length = "0x5")]
	[Token(Token = "0x6000FC5")]
	public Void* get_payloadPtr() { }

	[Address(RVA = "0x29F67F0", Offset = "0x29F5BF0", Length = "0x7")]
	[Token(Token = "0x6000FC4")]
	public int get_payloadSizeInBytes() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000FC8")]
	public override FourCC get_typeStatic() { }

}

