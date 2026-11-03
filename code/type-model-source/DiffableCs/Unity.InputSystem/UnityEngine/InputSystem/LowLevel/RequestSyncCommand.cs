namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x200018F")]
public struct RequestSyncCommand : IInputDeviceCommandInfo
{
	[Token(Token = "0x4000989")]
	internal const int kSize = 8; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400098A")]
	public InputDeviceCommand baseCommand; //Field offset: 0x0

	[Token(Token = "0x1700045C")]
	public static FourCC Type
	{
		[Address(RVA = "0x29FC7C0", Offset = "0x29FBBC0", Length = "0x3A")]
		[Token(Token = "0x6000FEC")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700045D")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29FC800", Offset = "0x29FBC00", Length = "0x3A")]
		[Token(Token = "0x6000FED")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29FC770", Offset = "0x29FBB70", Length = "0x4B")]
	[Token(Token = "0x6000FEE")]
	public static RequestSyncCommand Create() { }

	[Address(RVA = "0x29FC7C0", Offset = "0x29FBBC0", Length = "0x3A")]
	[Token(Token = "0x6000FEC")]
	public static FourCC get_Type() { }

	[Address(RVA = "0x29FC800", Offset = "0x29FBC00", Length = "0x3A")]
	[Token(Token = "0x6000FED")]
	public override FourCC get_typeStatic() { }

}

