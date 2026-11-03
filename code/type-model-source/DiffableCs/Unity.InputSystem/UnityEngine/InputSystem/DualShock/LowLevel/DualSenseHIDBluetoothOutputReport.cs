namespace UnityEngine.InputSystem.DualShock.LowLevel;

[Token(Token = "0x200016A")]
internal struct DualSenseHIDBluetoothOutputReport : IInputDeviceCommandInfo
{
	[CompilerGenerated]
	[Token(Token = "0x200016B")]
	[UnsafeValueType]
	internal struct <rawData>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400091C")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[Token(Token = "0x4000914")]
	internal const int kSize = 86; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000915")]
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000916")]
	public byte reportId; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[FixedBuffer(typeof(byte), 74)]
	[Token(Token = "0x400091B")]
	public <rawData>e__FixedBuffer rawData; //Field offset: 0x8
	[FieldOffset(Offset = "0x9")]
	[Token(Token = "0x4000917")]
	public byte tag1; //Field offset: 0x9
	[FieldOffset(Offset = "0xA")]
	[Token(Token = "0x4000918")]
	public byte tag2; //Field offset: 0xA
	[FieldOffset(Offset = "0xB")]
	[Token(Token = "0x4000919")]
	public DualSenseHIDOutputReportPayload payload; //Field offset: 0xB
	[FieldOffset(Offset = "0x52")]
	[Token(Token = "0x400091A")]
	public uint crc32; //Field offset: 0x52

	[Token(Token = "0x17000430")]
	public static FourCC Type
	{
		[Address(RVA = "0x29E5550", Offset = "0x29E4950", Length = "0x3A")]
		[Token(Token = "0x6000F8E")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000431")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29E5590", Offset = "0x29E4990", Length = "0x3A")]
		[Token(Token = "0x6000F8F")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29EC950", Offset = "0x29EBD50", Length = "0xD4")]
	[Token(Token = "0x6000F90")]
	public static DualSenseHIDBluetoothOutputReport Create(DualSenseHIDOutputReportPayload payload, byte outputSequenceId, int outputReportSize) { }

	[Address(RVA = "0x29E5550", Offset = "0x29E4950", Length = "0x3A")]
	[Token(Token = "0x6000F8E")]
	public static FourCC get_Type() { }

	[Address(RVA = "0x29E5590", Offset = "0x29E4990", Length = "0x3A")]
	[Token(Token = "0x6000F8F")]
	public override FourCC get_typeStatic() { }

}

