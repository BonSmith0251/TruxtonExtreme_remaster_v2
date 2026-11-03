namespace UnityEngine.InputSystem.XR.Haptics;

[Token(Token = "0x20000FE")]
public struct SendHapticImpulseCommand : IInputDeviceCommandInfo
{
	[Token(Token = "0x40005DF")]
	private const int kSize = 20; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005E0")]
	private InputDeviceCommand baseCommand; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40005E1")]
	private int channel; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40005E2")]
	private float amplitude; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005E3")]
	private float duration; //Field offset: 0x10

	[Token(Token = "0x1700035A")]
	private static FourCC Type
	{
		[Address(RVA = "0x29CB2F0", Offset = "0x29CA6F0", Length = "0x3A")]
		[Token(Token = "0x6000CC0")]
		private get { } //Length: 58
	}

	[Token(Token = "0x1700035B")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29CB330", Offset = "0x29CA730", Length = "0x3A")]
		[Token(Token = "0x6000CC1")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29CB240", Offset = "0x29CA640", Length = "0xA2")]
	[Token(Token = "0x6000CC2")]
	public static SendHapticImpulseCommand Create(int motorChannel, float motorAmplitude, float motorDuration) { }

	[Address(RVA = "0x29CB2F0", Offset = "0x29CA6F0", Length = "0x3A")]
	[Token(Token = "0x6000CC0")]
	private static FourCC get_Type() { }

	[Address(RVA = "0x29CB330", Offset = "0x29CA730", Length = "0x3A")]
	[Token(Token = "0x6000CC1")]
	public override FourCC get_typeStatic() { }

}

