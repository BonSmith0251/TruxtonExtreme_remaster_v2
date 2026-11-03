namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x200017B")]
public struct InitiateUserAccountPairingCommand : IInputDeviceCommandInfo
{
	[Token(Token = "0x200017C")]
	internal enum Result : int
	{
		SuccessfullyInitiated = 1,
		ErrorNotSupported = -1,
		ErrorAlreadyInProgress = -2,
	}

	[Token(Token = "0x4000952")]
	internal const int kSize = 8; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000953")]
	public InputDeviceCommand baseCommand; //Field offset: 0x0

	[Token(Token = "0x17000443")]
	public static FourCC Type
	{
		[Address(RVA = "0x29F66B0", Offset = "0x29F5AB0", Length = "0x3A")]
		[Token(Token = "0x6000FB9")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000444")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29F66F0", Offset = "0x29F5AF0", Length = "0x3A")]
		[Token(Token = "0x6000FBA")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29F6660", Offset = "0x29F5A60", Length = "0x4B")]
	[Token(Token = "0x6000FBB")]
	public static InitiateUserAccountPairingCommand Create() { }

	[Address(RVA = "0x29F66B0", Offset = "0x29F5AB0", Length = "0x3A")]
	[Token(Token = "0x6000FB9")]
	public static FourCC get_Type() { }

	[Address(RVA = "0x29F66F0", Offset = "0x29F5AF0", Length = "0x3A")]
	[Token(Token = "0x6000FBA")]
	public override FourCC get_typeStatic() { }

}

