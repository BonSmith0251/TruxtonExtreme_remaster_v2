namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x2000191")]
public struct SetSamplingFrequencyCommand : IInputDeviceCommandInfo
{
	[Token(Token = "0x400098E")]
	internal const int kSize = 12; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400098F")]
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000990")]
	public float frequency; //Field offset: 0x8

	[Token(Token = "0x17000461")]
	public static FourCC Type
	{
		[Address(RVA = "0x29FCAB0", Offset = "0x29FBEB0", Length = "0x37")]
		[Token(Token = "0x6000FF3")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000462")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29FCAF0", Offset = "0x29FBEF0", Length = "0x37")]
		[Token(Token = "0x6000FF4")]
		 get { } //Length: 55
	}

	[Address(RVA = "0x29FCA40", Offset = "0x29FBE40", Length = "0x6E")]
	[Token(Token = "0x6000FF5")]
	public static SetSamplingFrequencyCommand Create(float frequency) { }

	[Address(RVA = "0x29FCAB0", Offset = "0x29FBEB0", Length = "0x37")]
	[Token(Token = "0x6000FF3")]
	public static FourCC get_Type() { }

	[Address(RVA = "0x29FCAF0", Offset = "0x29FBEF0", Length = "0x37")]
	[Token(Token = "0x6000FF4")]
	public override FourCC get_typeStatic() { }

}

