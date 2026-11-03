namespace UnityEngine.InputSystem.XR.Haptics;

[Token(Token = "0x20000FC")]
public struct SendBufferedHapticCommand : IInputDeviceCommandInfo
{
	[CompilerGenerated]
	[Token(Token = "0x20000FD")]
	[UnsafeValueType]
	internal struct <buffer>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005DE")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[Token(Token = "0x40005D8")]
	private const int kMaxHapticBufferSize = 1024; //Field offset: 0x0
	[Token(Token = "0x40005D9")]
	private const int kSize = 1040; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005DA")]
	private InputDeviceCommand baseCommand; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40005DB")]
	private int channel; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40005DC")]
	private int bufferSize; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[FixedBuffer(typeof(byte), 1024)]
	[Token(Token = "0x40005DD")]
	private <buffer>e__FixedBuffer buffer; //Field offset: 0x10

	[Token(Token = "0x17000358")]
	private static FourCC Type
	{
		[Address(RVA = "0x29CB1C0", Offset = "0x29CA5C0", Length = "0x3A")]
		[Token(Token = "0x6000CBD")]
		private get { } //Length: 58
	}

	[Token(Token = "0x17000359")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29CB200", Offset = "0x29CA600", Length = "0x3A")]
		[Token(Token = "0x6000CBE")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29CAFF0", Offset = "0x29CA3F0", Length = "0x1C5")]
	[Token(Token = "0x6000CBF")]
	public static SendBufferedHapticCommand Create(Byte[] rumbleBuffer) { }

	[Address(RVA = "0x29CB1C0", Offset = "0x29CA5C0", Length = "0x3A")]
	[Token(Token = "0x6000CBD")]
	private static FourCC get_Type() { }

	[Address(RVA = "0x29CB200", Offset = "0x29CA600", Length = "0x3A")]
	[Token(Token = "0x6000CBE")]
	public override FourCC get_typeStatic() { }

}

