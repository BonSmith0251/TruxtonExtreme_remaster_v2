namespace UnityEngine.InputSystem.XR.Haptics;

[Token(Token = "0x20000F7")]
public struct BufferedRumble
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005C2")]
	private HapticCapabilities <capabilities>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005C3")]
	private InputDevice <device>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000348")]
	public private HapticCapabilities capabilities
	{
		[Address(RVA = "0x29B4FC0", Offset = "0x29B43C0", Length = "0x10")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000CA2")]
		 get { } //Length: 16
		[Address(RVA = "0x29B4FD0", Offset = "0x29B43D0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000CA3")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000349")]
	private InputDevice device
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000CA4")]
		private get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000CA5")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x29B4E40", Offset = "0x29B4240", Length = "0x172")]
	[Token(Token = "0x6000CA6")]
	public BufferedRumble(InputDevice device) { }

	[Address(RVA = "0x29B4BB0", Offset = "0x29B3FB0", Length = "0x281")]
	[Token(Token = "0x6000CA7")]
	public void EnqueueRumble(Byte[] samples) { }

	[Address(RVA = "0x29B4FC0", Offset = "0x29B43C0", Length = "0x10")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000CA2")]
	public HapticCapabilities get_capabilities() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000CA4")]
	private InputDevice get_device() { }

	[Address(RVA = "0x29B4FD0", Offset = "0x29B43D0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000CA3")]
	private void set_capabilities(HapticCapabilities value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000CA5")]
	private void set_device(InputDevice value) { }

}

