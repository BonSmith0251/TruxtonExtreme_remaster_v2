namespace UnityEngine.InputSystem.DualShock.LowLevel;

[Token(Token = "0x2000169")]
internal struct DualSenseHIDUSBOutputReport : IInputDeviceCommandInfo
{
	[Token(Token = "0x4000910")]
	internal const int kSize = 56; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000911")]
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000912")]
	public byte reportId; //Field offset: 0x8
	[FieldOffset(Offset = "0x9")]
	[Token(Token = "0x4000913")]
	public DualSenseHIDOutputReportPayload payload; //Field offset: 0x9

	[Token(Token = "0x1700042E")]
	public static FourCC Type
	{
		[Address(RVA = "0x29E5550", Offset = "0x29E4950", Length = "0x3A")]
		[Token(Token = "0x6000F8B")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700042F")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29E5590", Offset = "0x29E4990", Length = "0x3A")]
		[Token(Token = "0x6000F8C")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29ECBE0", Offset = "0x29EBFE0", Length = "0xB5")]
	[Token(Token = "0x6000F8D")]
	public static DualSenseHIDUSBOutputReport Create(DualSenseHIDOutputReportPayload payload, int outputReportSize) { }

	[Address(RVA = "0x29E5550", Offset = "0x29E4950", Length = "0x3A")]
	[Token(Token = "0x6000F8B")]
	public static FourCC get_Type() { }

	[Address(RVA = "0x29E5590", Offset = "0x29E4990", Length = "0x3A")]
	[Token(Token = "0x6000F8C")]
	public override FourCC get_typeStatic() { }

}

