namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001A5")]
internal struct GravityState : IInputStateTypeInfo
{
	[FieldOffset(Offset = "0x0")]
	[InputControl(displayName = "Gravity", processors = "CompensateDirection", noisy = True)]
	[Token(Token = "0x40009E2")]
	public Vector3 gravity; //Field offset: 0x0

	[Token(Token = "0x17000478")]
	public override FourCC format
	{
		[Address(RVA = "0x29F17C0", Offset = "0x29F0BC0", Length = "0x3A")]
		[Token(Token = "0x600101D")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000477")]
	public static FourCC kFormat
	{
		[Address(RVA = "0x29F1800", Offset = "0x29F0C00", Length = "0x3A")]
		[Token(Token = "0x600101C")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29F17C0", Offset = "0x29F0BC0", Length = "0x3A")]
	[Token(Token = "0x600101D")]
	public override FourCC get_format() { }

	[Address(RVA = "0x29F1800", Offset = "0x29F0C00", Length = "0x3A")]
	[Token(Token = "0x600101C")]
	public static FourCC get_kFormat() { }

}

