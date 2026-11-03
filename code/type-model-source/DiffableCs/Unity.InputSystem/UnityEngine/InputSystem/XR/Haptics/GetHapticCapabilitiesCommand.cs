namespace UnityEngine.InputSystem.XR.Haptics;

[Token(Token = "0x20000FB")]
public struct GetHapticCapabilitiesCommand : IInputDeviceCommandInfo
{
	[Token(Token = "0x40005D0")]
	private const int kSize = 28; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005D1")]
	private InputDeviceCommand baseCommand; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40005D2")]
	public uint numChannels; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40005D3")]
	public bool supportsImpulse; //Field offset: 0xC
	[FieldOffset(Offset = "0xD")]
	[Token(Token = "0x40005D4")]
	public bool supportsBuffer; //Field offset: 0xD
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005D5")]
	public uint frequencyHz; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40005D6")]
	public uint maxBufferSize; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005D7")]
	public uint optimalBufferSize; //Field offset: 0x18

	[Token(Token = "0x17000357")]
	public HapticCapabilities capabilities
	{
		[Address(RVA = "0x29B65C0", Offset = "0x29B59C0", Length = "0x2F")]
		[Token(Token = "0x6000CBB")]
		 get { } //Length: 47
	}

	[Token(Token = "0x17000355")]
	private static FourCC Type
	{
		[Address(RVA = "0x29B6580", Offset = "0x29B5980", Length = "0x3A")]
		[Token(Token = "0x6000CB9")]
		private get { } //Length: 58
	}

	[Token(Token = "0x17000356")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29B65F0", Offset = "0x29B59F0", Length = "0x3A")]
		[Token(Token = "0x6000CBA")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29B6500", Offset = "0x29B5900", Length = "0x74")]
	[Token(Token = "0x6000CBC")]
	public static GetHapticCapabilitiesCommand Create() { }

	[Address(RVA = "0x29B65C0", Offset = "0x29B59C0", Length = "0x2F")]
	[Token(Token = "0x6000CBB")]
	public HapticCapabilities get_capabilities() { }

	[Address(RVA = "0x29B6580", Offset = "0x29B5980", Length = "0x3A")]
	[Token(Token = "0x6000CB9")]
	private static FourCC get_Type() { }

	[Address(RVA = "0x29B65F0", Offset = "0x29B59F0", Length = "0x3A")]
	[Token(Token = "0x6000CBA")]
	public override FourCC get_typeStatic() { }

}

