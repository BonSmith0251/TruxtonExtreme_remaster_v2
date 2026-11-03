namespace UnityEngine.InputSystem.XR.Haptics;

[Token(Token = "0x20000F9")]
public struct GetCurrentHapticStateCommand : IInputDeviceCommandInfo
{
	[Token(Token = "0x40005C6")]
	private const int kSize = 16; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005C7")]
	private InputDeviceCommand baseCommand; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40005C8")]
	public uint samplesQueued; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40005C9")]
	public uint samplesAvailable; //Field offset: 0xC

	[Token(Token = "0x1700034E")]
	public HapticState currentState
	{
		[Address(RVA = "0x29B64A0", Offset = "0x29B58A0", Length = "0x14")]
		[Token(Token = "0x6000CAF")]
		 get { } //Length: 20
	}

	[Token(Token = "0x1700034C")]
	private static FourCC Type
	{
		[Address(RVA = "0x29B6460", Offset = "0x29B5860", Length = "0x3A")]
		[Token(Token = "0x6000CAD")]
		private get { } //Length: 58
	}

	[Token(Token = "0x1700034D")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29B64C0", Offset = "0x29B58C0", Length = "0x3A")]
		[Token(Token = "0x6000CAE")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29B63E0", Offset = "0x29B57E0", Length = "0x73")]
	[Token(Token = "0x6000CB0")]
	public static GetCurrentHapticStateCommand Create() { }

	[Address(RVA = "0x29B64A0", Offset = "0x29B58A0", Length = "0x14")]
	[Token(Token = "0x6000CAF")]
	public HapticState get_currentState() { }

	[Address(RVA = "0x29B6460", Offset = "0x29B5860", Length = "0x3A")]
	[Token(Token = "0x6000CAD")]
	private static FourCC get_Type() { }

	[Address(RVA = "0x29B64C0", Offset = "0x29B58C0", Length = "0x3A")]
	[Token(Token = "0x6000CAE")]
	public override FourCC get_typeStatic() { }

}

