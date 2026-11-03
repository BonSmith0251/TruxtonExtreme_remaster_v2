namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[MovedFrom(True, "Unity.Networking.Transport", null, null)]
[Token(Token = "0x2000045")]
public struct DataStreamReader
{
	[Token(Token = "0x2000046")]
	private struct Context
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AB")]
		public int m_ReadByteIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40000AC")]
		public int m_BitIndex; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000AD")]
		public ulong m_BitBuffer; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000AE")]
		public int m_FailedReads; //Field offset: 0x10

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40000A8")]
	internal Byte* m_BufferPtr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000A9")]
	private Context m_Context; //Field offset: 0x8
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000AA")]
	private int m_Length; //Field offset: 0x20

	[Token(Token = "0x1700002E")]
	public bool HasFailedReads
	{
		[Address(RVA = "0x28AE0A0", Offset = "0x28AD4A0", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x6000173")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000030")]
	public bool IsCreated
	{
		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x6000175")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700002D")]
	public static bool IsLittleEndian
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000170")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700002F")]
	public int Length
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x6000174")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x28AE030", Offset = "0x28AD430", Length = "0x6A")]
	[Token(Token = "0x600016E")]
	public DataStreamReader(NativeArray<Byte> array) { }

	[Address(RVA = "0x1FD37C0", Offset = "0x1FD2BC0", Length = "0x5")]
	[Token(Token = "0x6000172")]
	private static int ByteSwap(int val) { }

	[Address(RVA = "0x1FD37D0", Offset = "0x1FD2BD0", Length = "0x8")]
	[Token(Token = "0x6000171")]
	private static short ByteSwap(short val) { }

	[Address(RVA = "0x28ACC00", Offset = "0x28AC000", Length = "0x93")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60001A9")]
	private static void CheckBits(int numBits) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[IsReadOnly]
	[Token(Token = "0x60001A8")]
	internal void CheckRead() { }

	[Address(RVA = "0x28ACCA0", Offset = "0x28AC0A0", Length = "0x3F")]
	[Token(Token = "0x600018C")]
	private void FillBitBuffer() { }

	[Address(RVA = "0x28ACCE0", Offset = "0x28AC0E0", Length = "0x13")]
	[Token(Token = "0x6000183")]
	public void Flush() { }

	[Address(RVA = "0x28AE0A0", Offset = "0x28AD4A0", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x6000173")]
	public bool get_HasFailedReads() { }

	[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x6000175")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000170")]
	public static bool get_IsLittleEndian() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x6000174")]
	public int get_Length() { }

	[Address(RVA = "0x28ACD00", Offset = "0x28AC100", Length = "0xA")]
	[Token(Token = "0x600017A")]
	public int GetBitsRead() { }

	[Address(RVA = "0x28ACD10", Offset = "0x28AC110", Length = "0xC")]
	[Token(Token = "0x6000179")]
	public int GetBytesRead() { }

	[Address(RVA = "0x28ACD20", Offset = "0x28AC120", Length = "0x66")]
	[Token(Token = "0x600016F")]
	private static void Initialize(out DataStreamReader self, NativeArray<Byte> array) { }

	[Address(RVA = "0x28ACD90", Offset = "0x28AC190", Length = "0x7A")]
	[Token(Token = "0x600017C")]
	public byte ReadByte() { }

	[Address(RVA = "0x28ACF00", Offset = "0x28AC300", Length = "0x61")]
	[Token(Token = "0x6000177")]
	public void ReadBytes(NativeArray<Byte> array) { }

	[Address(RVA = "0x28ACE90", Offset = "0x28AC290", Length = "0x64")]
	[Token(Token = "0x6000178")]
	public void ReadBytes(Span<Byte> span) { }

	[Address(RVA = "0x28ACE10", Offset = "0x28AC210", Length = "0x7C")]
	[Token(Token = "0x6000176")]
	private void ReadBytesInternal(Byte* data, int length) { }

	[Address(RVA = "0x28ACF70", Offset = "0x28AC370", Length = "0x15")]
	[Token(Token = "0x6000189")]
	public double ReadDouble() { }

	[Address(RVA = "0x28AD2B0", Offset = "0x28AC6B0", Length = "0x91")]
	[Token(Token = "0x600019F")]
	public ushort ReadFixedString(NativeArray<Byte> array) { }

	[Address(RVA = "0x28ACF90", Offset = "0x28AC390", Length = "0x89")]
	[Token(Token = "0x600019C")]
	public FixedString128Bytes ReadFixedString128() { }

	[Address(RVA = "0x28AD020", Offset = "0x28AC420", Length = "0x71")]
	[Token(Token = "0x600019A")]
	public FixedString32Bytes ReadFixedString32() { }

	[Address(RVA = "0x28AD0A0", Offset = "0x28AC4A0", Length = "0xA9")]
	[Token(Token = "0x600019E")]
	public FixedString4096Bytes ReadFixedString4096() { }

	[Address(RVA = "0x28AD150", Offset = "0x28AC550", Length = "0x79")]
	[Token(Token = "0x600019D")]
	public FixedString512Bytes ReadFixedString512() { }

	[Address(RVA = "0x28AD1D0", Offset = "0x28AC5D0", Length = "0x79")]
	[Token(Token = "0x600019B")]
	public FixedString64Bytes ReadFixedString64() { }

	[Address(RVA = "0x28AD250", Offset = "0x28AC650", Length = "0x58")]
	[Token(Token = "0x60001A0")]
	private ushort ReadFixedStringInternal(Byte* data, int maxLength) { }

	[Address(RVA = "0x28AD350", Offset = "0x28AC750", Length = "0x14")]
	[Token(Token = "0x6000188")]
	public float ReadFloat() { }

	[Address(RVA = "0x28AD3F0", Offset = "0x28AC7F0", Length = "0x79")]
	[Token(Token = "0x600017F")]
	public int ReadInt() { }

	[Address(RVA = "0x28AD370", Offset = "0x28AC770", Length = "0x7D")]
	[Token(Token = "0x6000186")]
	public int ReadIntNetworkByteOrder() { }

	[Address(RVA = "0x28AD470", Offset = "0x28AC870", Length = "0x7C")]
	[Token(Token = "0x6000181")]
	public long ReadLong() { }

	[Address(RVA = "0x28AD610", Offset = "0x28ACA10", Length = "0xE")]
	[Token(Token = "0x6000193")]
	public double ReadPackedDouble(in StreamCompressionModel model) { }

	[Address(RVA = "0x28AD4F0", Offset = "0x28AC8F0", Length = "0x113")]
	[Token(Token = "0x6000199")]
	public double ReadPackedDoubleDelta(double baseline, in StreamCompressionModel model) { }

	[Address(RVA = "0x28AD620", Offset = "0x28ACA20", Length = "0x6A")]
	[Token(Token = "0x60001A3")]
	public FixedString128Bytes ReadPackedFixedString128Delta(FixedString128Bytes baseline, in StreamCompressionModel model) { }

	[Address(RVA = "0x28AD690", Offset = "0x28ACA90", Length = "0x52")]
	[Token(Token = "0x60001A1")]
	public FixedString32Bytes ReadPackedFixedString32Delta(FixedString32Bytes baseline, in StreamCompressionModel model) { }

	[Address(RVA = "0x28AD6F0", Offset = "0x28ACAF0", Length = "0xB7")]
	[Token(Token = "0x60001A5")]
	public FixedString4096Bytes ReadPackedFixedString4096Delta(FixedString4096Bytes baseline, in StreamCompressionModel model) { }

	[Address(RVA = "0x28AD7B0", Offset = "0x28ACBB0", Length = "0x77")]
	[Token(Token = "0x60001A4")]
	public FixedString512Bytes ReadPackedFixedString512Delta(FixedString512Bytes baseline, in StreamCompressionModel model) { }

	[Address(RVA = "0x28AD830", Offset = "0x28ACC30", Length = "0x5A")]
	[Token(Token = "0x60001A2")]
	public FixedString64Bytes ReadPackedFixedString64Delta(FixedString64Bytes baseline, in StreamCompressionModel model) { }

	[Address(RVA = "0x28ADA00", Offset = "0x28ACE00", Length = "0xBB")]
	[Token(Token = "0x60001A6")]
	public ushort ReadPackedFixedStringDelta(NativeArray<Byte> data, NativeArray<Byte> baseData, in StreamCompressionModel model) { }

	[Address(RVA = "0x28AD890", Offset = "0x28ACC90", Length = "0x16D")]
	[Token(Token = "0x60001A7")]
	private ushort ReadPackedFixedStringDeltaInternal(Byte* data, int maxLength, Byte* baseData, ushort baseLength, in StreamCompressionModel model) { }

	[Address(RVA = "0x28ADB60", Offset = "0x28ACF60", Length = "0xE")]
	[Token(Token = "0x6000192")]
	public float ReadPackedFloat(in StreamCompressionModel model) { }

	[Address(RVA = "0x28ADAC0", Offset = "0x28ACEC0", Length = "0x92")]
	[Token(Token = "0x6000198")]
	public float ReadPackedFloatDelta(float baseline, in StreamCompressionModel model) { }

	[Address(RVA = "0x28ADBA0", Offset = "0x28ACFA0", Length = "0x24")]
	[Token(Token = "0x6000190")]
	public int ReadPackedInt(in StreamCompressionModel model) { }

	[Address(RVA = "0x28ADB70", Offset = "0x28ACF70", Length = "0x2A")]
	[Token(Token = "0x6000194")]
	public int ReadPackedIntDelta(int baseline, in StreamCompressionModel model) { }

	[Address(RVA = "0x28ADC50", Offset = "0x28AD050", Length = "0x62")]
	[Token(Token = "0x6000191")]
	public long ReadPackedLong(in StreamCompressionModel model) { }

	[Address(RVA = "0x28ADBD0", Offset = "0x28ACFD0", Length = "0x72")]
	[Token(Token = "0x6000196")]
	public long ReadPackedLongDelta(long baseline, in StreamCompressionModel model) { }

	[Address(RVA = "0x28ADDB0", Offset = "0x28AD1B0", Length = "0x10")]
	[Token(Token = "0x600018A")]
	public uint ReadPackedUInt(in StreamCompressionModel model) { }

	[Address(RVA = "0x28ADB70", Offset = "0x28ACF70", Length = "0x2A")]
	[Token(Token = "0x6000195")]
	public uint ReadPackedUIntDelta(uint baseline, in StreamCompressionModel model) { }

	[Address(RVA = "0x28ADCC0", Offset = "0x28AD0C0", Length = "0xE3")]
	[Token(Token = "0x600018B")]
	private uint ReadPackedUIntInternal(int maxSymbolLength, in StreamCompressionModel model) { }

	[Address(RVA = "0x28ADDC0", Offset = "0x28AD1C0", Length = "0x53")]
	[Token(Token = "0x600018F")]
	public ulong ReadPackedULong(in StreamCompressionModel model) { }

	[Address(RVA = "0x28ADBD0", Offset = "0x28ACFD0", Length = "0x72")]
	[Token(Token = "0x6000197")]
	public ulong ReadPackedULongDelta(ulong baseline, in StreamCompressionModel model) { }

	[Address(RVA = "0x28ADE60", Offset = "0x28AD260", Length = "0x75")]
	[Token(Token = "0x600018E")]
	public uint ReadRawBits(int numbits) { }

	[Address(RVA = "0x28ADE20", Offset = "0x28AD220", Length = "0x36")]
	[Token(Token = "0x600018D")]
	private uint ReadRawBitsInternal(int numbits) { }

	[Address(RVA = "0x28ADF70", Offset = "0x28AD370", Length = "0x7C")]
	[Token(Token = "0x600017D")]
	public short ReadShort() { }

	[Address(RVA = "0x28ADEE0", Offset = "0x28AD2E0", Length = "0x84")]
	[Token(Token = "0x6000184")]
	public short ReadShortNetworkByteOrder() { }

	[Address(RVA = "0x28AD3F0", Offset = "0x28AC7F0", Length = "0x79")]
	[Token(Token = "0x6000180")]
	public uint ReadUInt() { }

	[Address(RVA = "0x28ADFF0", Offset = "0x28AD3F0", Length = "0x7")]
	[Token(Token = "0x6000187")]
	public uint ReadUIntNetworkByteOrder() { }

	[Address(RVA = "0x28AD470", Offset = "0x28AC870", Length = "0x7C")]
	[Token(Token = "0x6000182")]
	public ulong ReadULong() { }

	[Address(RVA = "0x28ADF70", Offset = "0x28AD370", Length = "0x7C")]
	[Token(Token = "0x600017E")]
	public ushort ReadUShort() { }

	[Address(RVA = "0x28AE000", Offset = "0x28AD400", Length = "0x7")]
	[Token(Token = "0x6000185")]
	public ushort ReadUShortNetworkByteOrder() { }

	[Address(RVA = "0x28AE010", Offset = "0x28AD410", Length = "0x16")]
	[Token(Token = "0x600017B")]
	public void SeekSet(int pos) { }

}

