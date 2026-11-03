namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x200018E")]
public struct RequestResetCommand : IInputDeviceCommandInfo
{
	[Token(Token = "0x4000987")]
	internal const int kSize = 8; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000988")]
	public InputDeviceCommand baseCommand; //Field offset: 0x0

	[Token(Token = "0x1700045A")]
	public static FourCC Type
	{
		[Address(RVA = "0x29FC6F0", Offset = "0x29FBAF0", Length = "0x3A")]
		[Token(Token = "0x6000FE9")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700045B")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29FC730", Offset = "0x29FBB30", Length = "0x3A")]
		[Token(Token = "0x6000FEA")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29FC6A0", Offset = "0x29FBAA0", Length = "0x4B")]
	[Token(Token = "0x6000FEB")]
	public static RequestResetCommand Create() { }

	[Address(RVA = "0x29FC6F0", Offset = "0x29FBAF0", Length = "0x3A")]
	[Token(Token = "0x6000FE9")]
	public static FourCC get_Type() { }

	[Address(RVA = "0x29FC730", Offset = "0x29FBB30", Length = "0x3A")]
	[Token(Token = "0x6000FEA")]
	public override FourCC get_typeStatic() { }

}

