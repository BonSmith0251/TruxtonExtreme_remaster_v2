namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x200018B")]
internal struct QuerySamplingFrequencyCommand : IInputDeviceCommandInfo
{
	[Token(Token = "0x400097F")]
	internal const int kSize = 12; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000980")]
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000981")]
	public float frequency; //Field offset: 0x8

	[Token(Token = "0x17000456")]
	public static FourCC Type
	{
		[Address(RVA = "0x29FC530", Offset = "0x29FB930", Length = "0x3A")]
		[Token(Token = "0x6000FE2")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000457")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29FC570", Offset = "0x29FB970", Length = "0x3A")]
		[Token(Token = "0x6000FE3")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29FC4D0", Offset = "0x29FB8D0", Length = "0x5F")]
	[Token(Token = "0x6000FE4")]
	public static QuerySamplingFrequencyCommand Create() { }

	[Address(RVA = "0x29FC530", Offset = "0x29FB930", Length = "0x3A")]
	[Token(Token = "0x6000FE2")]
	public static FourCC get_Type() { }

	[Address(RVA = "0x29FC570", Offset = "0x29FB970", Length = "0x3A")]
	[Token(Token = "0x6000FE3")]
	public override FourCC get_typeStatic() { }

}

