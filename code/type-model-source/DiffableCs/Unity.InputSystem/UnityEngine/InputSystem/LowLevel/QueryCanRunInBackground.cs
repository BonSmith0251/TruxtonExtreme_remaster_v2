namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x2000180")]
public struct QueryCanRunInBackground : IInputDeviceCommandInfo
{
	[Token(Token = "0x400095E")]
	internal const int kSize = 9; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400095F")]
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000960")]
	public bool canRunInBackground; //Field offset: 0x8

	[Token(Token = "0x17000448")]
	public static FourCC Type
	{
		[Address(RVA = "0x29FBCE0", Offset = "0x29FB0E0", Length = "0x3A")]
		[Token(Token = "0x6000FC9")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000449")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29FBD20", Offset = "0x29FB120", Length = "0x3A")]
		[Token(Token = "0x6000FCA")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29FBC70", Offset = "0x29FB070", Length = "0x63")]
	[Token(Token = "0x6000FCB")]
	public static QueryCanRunInBackground Create() { }

	[Address(RVA = "0x29FBCE0", Offset = "0x29FB0E0", Length = "0x3A")]
	[Token(Token = "0x6000FC9")]
	public static FourCC get_Type() { }

	[Address(RVA = "0x29FBD20", Offset = "0x29FB120", Length = "0x3A")]
	[Token(Token = "0x6000FCA")]
	public override FourCC get_typeStatic() { }

}

