namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001A7")]
internal struct LinearAccelerationState : IInputStateTypeInfo
{
	[FieldOffset(Offset = "0x0")]
	[InputControl(displayName = "Acceleration", processors = "CompensateDirection", noisy = True)]
	[Token(Token = "0x40009E4")]
	public Vector3 acceleration; //Field offset: 0x0

	[Token(Token = "0x1700047C")]
	public override FourCC format
	{
		[Address(RVA = "0x29FB820", Offset = "0x29FAC20", Length = "0x37")]
		[Token(Token = "0x6001021")]
		 get { } //Length: 55
	}

	[Token(Token = "0x1700047B")]
	public static FourCC kFormat
	{
		[Address(RVA = "0x29FB860", Offset = "0x29FAC60", Length = "0x37")]
		[Token(Token = "0x6001020")]
		 get { } //Length: 55
	}

	[Address(RVA = "0x29FB820", Offset = "0x29FAC20", Length = "0x37")]
	[Token(Token = "0x6001021")]
	public override FourCC get_format() { }

	[Address(RVA = "0x29FB860", Offset = "0x29FAC60", Length = "0x37")]
	[Token(Token = "0x6001020")]
	public static FourCC get_kFormat() { }

}

