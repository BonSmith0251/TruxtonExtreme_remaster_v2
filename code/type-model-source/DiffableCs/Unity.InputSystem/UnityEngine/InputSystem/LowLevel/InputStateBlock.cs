namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001DE")]
public struct InputStateBlock
{
	[Token(Token = "0x4000AA1")]
	public const uint InvalidOffset = 4294967295; //Field offset: 0x0
	[Token(Token = "0x4000AC8")]
	internal const int kFormatPose = 1349481317; //Field offset: 0x0
	[Token(Token = "0x4000AC2")]
	internal const int kFormatQuaternion = 1364541780; //Field offset: 0x0
	[Token(Token = "0x4000AC0")]
	internal const int kFormatVector3 = 1447379763; //Field offset: 0x0
	[Token(Token = "0x4000ABE")]
	internal const int kFormatVector2 = 1447379762; //Field offset: 0x0
	[Token(Token = "0x4000ABC")]
	internal const int kFormatDouble = 1145195552; //Field offset: 0x0
	[Token(Token = "0x4000ABA")]
	internal const int kFormatFloat = 1179407392; //Field offset: 0x0
	[Token(Token = "0x4000AB8")]
	internal const int kFormatULong = 1431064135; //Field offset: 0x0
	[Token(Token = "0x4000AB4")]
	internal const int kFormatSByte = 1396857172; //Field offset: 0x0
	[Token(Token = "0x4000AB2")]
	internal const int kFormatByte = 1113150533; //Field offset: 0x0
	[Token(Token = "0x4000AB0")]
	internal const int kFormatUShort = 1431521364; //Field offset: 0x0
	[Token(Token = "0x4000AAE")]
	internal const int kFormatShort = 1397248596; //Field offset: 0x0
	[Token(Token = "0x4000AB6")]
	internal const int kFormatLong = 1280198432; //Field offset: 0x0
	[Token(Token = "0x4000AAC")]
	internal const int kFormatUInt = 1430867540; //Field offset: 0x0
	[Token(Token = "0x4000AA6")]
	internal const int kFormatBit = 1112101920; //Field offset: 0x0
	[Token(Token = "0x4000AA8")]
	internal const int kFormatSBit = 1396853076; //Field offset: 0x0
	[Token(Token = "0x4000AA3")]
	public static readonly FourCC FormatInvalid; //Field offset: 0x0
	[Token(Token = "0x4000AA2")]
	public const uint AutomaticOffset = 4294967294; //Field offset: 0x0
	[Token(Token = "0x4000AA4")]
	internal const int kFormatInvalid = 0; //Field offset: 0x0
	[Token(Token = "0x4000AAA")]
	internal const int kFormatInt = 1229870112; //Field offset: 0x0
	[Token(Token = "0x4000AA5")]
	public static readonly FourCC FormatBit; //Field offset: 0x4
	[Token(Token = "0x4000AA7")]
	public static readonly FourCC FormatSBit; //Field offset: 0x8
	[Token(Token = "0x4000AA9")]
	public static readonly FourCC FormatInt; //Field offset: 0xC
	[Token(Token = "0x4000AAB")]
	public static readonly FourCC FormatUInt; //Field offset: 0x10
	[Token(Token = "0x4000AAD")]
	public static readonly FourCC FormatShort; //Field offset: 0x14
	[Token(Token = "0x4000AAF")]
	public static readonly FourCC FormatUShort; //Field offset: 0x18
	[Token(Token = "0x4000AB1")]
	public static readonly FourCC FormatByte; //Field offset: 0x1C
	[Token(Token = "0x4000AB3")]
	public static readonly FourCC FormatSByte; //Field offset: 0x20
	[Token(Token = "0x4000AB5")]
	public static readonly FourCC FormatLong; //Field offset: 0x24
	[Token(Token = "0x4000AB7")]
	public static readonly FourCC FormatULong; //Field offset: 0x28
	[Token(Token = "0x4000AB9")]
	public static readonly FourCC FormatFloat; //Field offset: 0x2C
	[Token(Token = "0x4000ABB")]
	public static readonly FourCC FormatDouble; //Field offset: 0x30
	[Token(Token = "0x4000ABD")]
	public static readonly FourCC FormatVector2; //Field offset: 0x34
	[Token(Token = "0x4000ABF")]
	public static readonly FourCC FormatVector3; //Field offset: 0x38
	[Token(Token = "0x4000AC1")]
	public static readonly FourCC FormatQuaternion; //Field offset: 0x3C
	[Token(Token = "0x4000AC3")]
	public static readonly FourCC FormatVector2Short; //Field offset: 0x40
	[Token(Token = "0x4000AC4")]
	public static readonly FourCC FormatVector3Short; //Field offset: 0x44
	[Token(Token = "0x4000AC5")]
	public static readonly FourCC FormatVector2Byte; //Field offset: 0x48
	[Token(Token = "0x4000AC6")]
	public static readonly FourCC FormatVector3Byte; //Field offset: 0x4C
	[Token(Token = "0x4000AC7")]
	public static readonly FourCC FormatPose; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AC9")]
	private FourCC <format>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000ACA")]
	internal uint m_ByteOffset; //Field offset: 0x4
	[CompilerGenerated]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000ACB")]
	private uint <bitOffset>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000ACC")]
	private uint <sizeInBits>k__BackingField; //Field offset: 0xC

	[Token(Token = "0x17000518")]
	internal uint alignedSizeInBytes
	{
		[Address(RVA = "0x2A0DCB0", Offset = "0x2A0D0B0", Length = "0x49")]
		[Token(Token = "0x60011BF")]
		internal get { } //Length: 73
	}

	[Token(Token = "0x17000516")]
	public uint bitOffset
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60011BB")]
		 get { } //Length: 4
		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60011BC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000515")]
	public uint byteOffset
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x60011B9")]
		 get { } //Length: 4
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[Token(Token = "0x60011BA")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700051A")]
	internal uint effectiveBitOffset
	{
		[Address(RVA = "0x2A0DD00", Offset = "0x2A0D100", Length = "0x49")]
		[Token(Token = "0x60011C1")]
		internal get { } //Length: 73
	}

	[Token(Token = "0x17000519")]
	internal uint effectiveByteOffset
	{
		[Address(RVA = "0x2A0DD50", Offset = "0x2A0D150", Length = "0x49")]
		[Token(Token = "0x60011C0")]
		internal get { } //Length: 73
	}

	[Token(Token = "0x17000514")]
	public FourCC format
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60011B7")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x60011B8")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000517")]
	public uint sizeInBits
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60011BD")]
		 get { } //Length: 4
		[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60011BE")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2A0D790", Offset = "0x2A0CB90", Length = "0x515")]
	[Token(Token = "0x60011CB")]
	private static InputStateBlock() { }

	[Address(RVA = "0x2A0B070", Offset = "0x2A0A470", Length = "0x149")]
	[Token(Token = "0x60011CA")]
	public void CopyToFrom(Void* toStatePtr, Void* fromStatePtr) { }

	[Address(RVA = "0x2A0B1C0", Offset = "0x2A0A5C0", Length = "0x42E")]
	[Token(Token = "0x60011C6")]
	internal PrimitiveValue FloatToPrimitiveValue(float value) { }

	[Address(RVA = "0x2A0DCB0", Offset = "0x2A0D0B0", Length = "0x49")]
	[Token(Token = "0x60011BF")]
	internal uint get_alignedSizeInBytes() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60011BB")]
	public uint get_bitOffset() { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[Token(Token = "0x60011B9")]
	public uint get_byteOffset() { }

	[Address(RVA = "0x2A0DD00", Offset = "0x2A0D100", Length = "0x49")]
	[Token(Token = "0x60011C1")]
	internal uint get_effectiveBitOffset() { }

	[Address(RVA = "0x2A0DD50", Offset = "0x2A0D150", Length = "0x49")]
	[Token(Token = "0x60011C0")]
	internal uint get_effectiveByteOffset() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60011B7")]
	public FourCC get_format() { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60011BD")]
	public uint get_sizeInBits() { }

	[Address(RVA = "0x2A0B5F0", Offset = "0x2A0A9F0", Length = "0x563")]
	[Token(Token = "0x60011B6")]
	public static FourCC GetPrimitiveFormatFromType(Type type) { }

	[Address(RVA = "0x2A0BB60", Offset = "0x2A0AF60", Length = "0x347")]
	[Token(Token = "0x60011B5")]
	public static int GetSizeOfPrimitiveFormatInBits(FourCC type) { }

	[Address(RVA = "0x2A0BEB0", Offset = "0x2A0B2B0", Length = "0x495")]
	[Token(Token = "0x60011C7")]
	public double ReadDouble(Void* statePtr) { }

	[Address(RVA = "0x2A0C350", Offset = "0x2A0B750", Length = "0x459")]
	[Token(Token = "0x60011C4")]
	public float ReadFloat(Void* statePtr) { }

	[Address(RVA = "0x2A0C7B0", Offset = "0x2A0BBB0", Length = "0x2AE")]
	[Token(Token = "0x60011C2")]
	public int ReadInt(Void* statePtr) { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60011BC")]
	public void set_bitOffset(uint value) { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[Token(Token = "0x60011BA")]
	public void set_byteOffset(uint value) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x60011B8")]
	public void set_format(FourCC value) { }

	[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60011BE")]
	public void set_sizeInBits(uint value) { }

	[Address(RVA = "0x2A0D440", Offset = "0x2A0C840", Length = "0x34E")]
	[Token(Token = "0x60011C9")]
	public void Write(Void* statePtr, PrimitiveValue value) { }

	[Address(RVA = "0x2A0CA60", Offset = "0x2A0BE60", Length = "0x3D0")]
	[Token(Token = "0x60011C8")]
	public void WriteDouble(Void* statePtr, double value) { }

	[Address(RVA = "0x2A0CE40", Offset = "0x2A0C240", Length = "0x3AE")]
	[Token(Token = "0x60011C5")]
	public void WriteFloat(Void* statePtr, float value) { }

	[Address(RVA = "0x2A0D1F0", Offset = "0x2A0C5F0", Length = "0x24E")]
	[Token(Token = "0x60011C3")]
	public void WriteInt(Void* statePtr, int value) { }

}

