namespace UnityEngine.InputSystem.DualShock.LowLevel;

[Token(Token = "0x200016F")]
internal struct DualShockHIDOutputReport : IInputDeviceCommandInfo
{
	[CompilerGenerated]
	[Token(Token = "0x2000171")]
	[UnsafeValueType]
	internal struct <unknown1>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000943")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x2000172")]
	[UnsafeValueType]
	internal struct <unknown2>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000944")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[Flags]
	[Token(Token = "0x2000170")]
	internal enum Flags : int
	{
		Rumble = 1,
		Color = 2,
	}

	[Token(Token = "0x4000934")]
	internal const int kSize = 40; //Field offset: 0x0
	[Token(Token = "0x4000935")]
	internal const int kReportId = 5; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000936")]
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000937")]
	public byte reportId; //Field offset: 0x8
	[FieldOffset(Offset = "0x9")]
	[Token(Token = "0x4000938")]
	public byte flags; //Field offset: 0x9
	[FieldOffset(Offset = "0xA")]
	[FixedBuffer(typeof(byte), 2)]
	[Token(Token = "0x4000939")]
	public <unknown1>e__FixedBuffer unknown1; //Field offset: 0xA
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400093A")]
	public byte highFrequencyMotorSpeed; //Field offset: 0xC
	[FieldOffset(Offset = "0xD")]
	[Token(Token = "0x400093B")]
	public byte lowFrequencyMotorSpeed; //Field offset: 0xD
	[FieldOffset(Offset = "0xE")]
	[Token(Token = "0x400093C")]
	public byte redColor; //Field offset: 0xE
	[FieldOffset(Offset = "0xF")]
	[Token(Token = "0x400093D")]
	public byte greenColor; //Field offset: 0xF
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400093E")]
	public byte blueColor; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[FixedBuffer(typeof(byte), 23)]
	[Token(Token = "0x400093F")]
	public <unknown2>e__FixedBuffer unknown2; //Field offset: 0x11

	[Token(Token = "0x17000434")]
	public static FourCC Type
	{
		[Address(RVA = "0x29E5550", Offset = "0x29E4950", Length = "0x3A")]
		[Token(Token = "0x6000F94")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000435")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29E5590", Offset = "0x29E4990", Length = "0x3A")]
		[Token(Token = "0x6000F95")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29EE370", Offset = "0x29ED770", Length = "0x75")]
	[Token(Token = "0x6000F98")]
	public static DualShockHIDOutputReport Create(int outputReportSize) { }

	[Address(RVA = "0x29E5550", Offset = "0x29E4950", Length = "0x3A")]
	[Token(Token = "0x6000F94")]
	public static FourCC get_Type() { }

	[Address(RVA = "0x29E5590", Offset = "0x29E4990", Length = "0x3A")]
	[Token(Token = "0x6000F95")]
	public override FourCC get_typeStatic() { }

	[Address(RVA = "0x29EE3F0", Offset = "0x29ED7F0", Length = "0x7B")]
	[Token(Token = "0x6000F97")]
	public void SetColor(Color color) { }

	[Address(RVA = "0x29EE470", Offset = "0x29ED870", Length = "0x50")]
	[Token(Token = "0x6000F96")]
	public void SetMotorSpeeds(float lowFreq, float highFreq) { }

}

