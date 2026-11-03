namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[MovedFrom(True, "Unity.Networking.Transport", "Unity.Networking.Transport", null)]
[Token(Token = "0x2000047")]
public struct DataStreamWriter
{
	[Token(Token = "0x2000048")]
	private struct StreamData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B1")]
		public Byte* buffer; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000B2")]
		public int length; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40000B3")]
		public int capacity; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000B4")]
		public ulong bitBuffer; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000B5")]
		public int bitIndex; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40000B6")]
		public int failedWrites; //Field offset: 0x1C

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40000AF")]
	private StreamData m_Data; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000B0")]
	public IntPtr m_SendHandleData; //Field offset: 0x20

	[Token(Token = "0x17000034")]
	public int Capacity
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x60001B4")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000033")]
	public bool HasFailedWrites
	{
		[Address(RVA = "0x28AF370", Offset = "0x28AE770", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x60001B3")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000032")]
	public bool IsCreated
	{
		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x60001B2")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000031")]
	public static bool IsLittleEndian
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60001AA")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000035")]
	public int Length
	{
		[Address(RVA = "0x28AF3D0", Offset = "0x28AE7D0", Length = "0x4D")]
		[Token(Token = "0x60001B5")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000036")]
	public int LengthInBits
	{
		[Address(RVA = "0x28AF380", Offset = "0x28AE780", Length = "0x4A")]
		[Token(Token = "0x60001B6")]
		 get { } //Length: 74
	}

	[Address(RVA = "0x28AF160", Offset = "0x28AE560", Length = "0xB7")]
	[Token(Token = "0x60001AB")]
	public DataStreamWriter(int length, AllocatorHandle allocator) { }

	[Address(RVA = "0x28AF2E0", Offset = "0x28AE6E0", Length = "0x85")]
	[Token(Token = "0x60001AC")]
	public DataStreamWriter(NativeArray<Byte> data) { }

	[Address(RVA = "0x28AF220", Offset = "0x28AE620", Length = "0xB6")]
	[Token(Token = "0x60001AD")]
	public DataStreamWriter(Byte* data, int length) { }

	[Address(RVA = "0x28AE0B0", Offset = "0x28AD4B0", Length = "0xAC")]
	[Token(Token = "0x60001AE")]
	public NativeArray<Byte> AsNativeArray() { }

	[Address(RVA = "0x1FD37D0", Offset = "0x1FD2BD0", Length = "0x8")]
	[Token(Token = "0x60001B0")]
	private static short ByteSwap(short val) { }

	[Address(RVA = "0x1FD37C0", Offset = "0x1FD2BC0", Length = "0x5")]
	[Token(Token = "0x60001B1")]
	private static int ByteSwap(int val) { }

	[Address(RVA = "0x28AE160", Offset = "0x28AD560", Length = "0x6D")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60001E6")]
	private static void CheckAllocator(AllocatorHandle allocator) { }

	[Address(RVA = "0x28AE1D0", Offset = "0x28AD5D0", Length = "0x169")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60001E7")]
	private static void CheckBits(uint value, int numBits) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[IsReadOnly]
	[Token(Token = "0x60001E4")]
	private void CheckRead() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Token(Token = "0x60001E5")]
	private void CheckWrite() { }

	[Address(RVA = "0x28AE340", Offset = "0x28AD740", Length = "0xE")]
	[Token(Token = "0x60001E3")]
	public void Clear() { }

	[Address(RVA = "0x28AE390", Offset = "0x28AD790", Length = "0x43")]
	[Token(Token = "0x60001B8")]
	public void Flush() { }

	[Address(RVA = "0x28AE350", Offset = "0x28AD750", Length = "0x3C")]
	[Token(Token = "0x60001C9")]
	private void FlushBits() { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x60001B4")]
	public int get_Capacity() { }

	[Address(RVA = "0x28AF370", Offset = "0x28AE770", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x60001B3")]
	public bool get_HasFailedWrites() { }

	[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x60001B2")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60001AA")]
	public static bool get_IsLittleEndian() { }

	[Address(RVA = "0x28AF3D0", Offset = "0x28AE7D0", Length = "0x4D")]
	[Token(Token = "0x60001B5")]
	public int get_Length() { }

	[Address(RVA = "0x28AF380", Offset = "0x28AE780", Length = "0x4A")]
	[Token(Token = "0x60001B6")]
	public int get_LengthInBits() { }

	[Address(RVA = "0x28AE3E0", Offset = "0x28AD7E0", Length = "0x74")]
	[Token(Token = "0x60001AF")]
	private static void Initialize(out DataStreamWriter self, NativeArray<Byte> data) { }

	[Address(RVA = "0x28AE460", Offset = "0x28AD860", Length = "0x3F")]
	[Token(Token = "0x60001B7")]
	private void SyncBitData() { }

	[Address(RVA = "0x28AE4A0", Offset = "0x28AD8A0", Length = "0x91")]
	[Token(Token = "0x60001BA")]
	public bool WriteByte(byte value) { }

	[Address(RVA = "0x28AE5E0", Offset = "0x28AD9E0", Length = "0x61")]
	[Token(Token = "0x60001BB")]
	public bool WriteBytes(NativeArray<Byte> value) { }

	[Address(RVA = "0x28AE650", Offset = "0x28ADA50", Length = "0x64")]
	[Token(Token = "0x60001BC")]
	public bool WriteBytes(Span<Byte> value) { }

	[Address(RVA = "0x28AE540", Offset = "0x28AD940", Length = "0x96")]
	[Token(Token = "0x60001B9")]
	private bool WriteBytesInternal(Byte* data, int bytes) { }

	[Address(RVA = "0x28AE6C0", Offset = "0x28ADAC0", Length = "0xD")]
	[Token(Token = "0x60001C8")]
	public bool WriteDouble(double value) { }

	[Address(RVA = "0x28AE6D0", Offset = "0x28ADAD0", Length = "0x98")]
	[Token(Token = "0x60001DA")]
	public bool WriteFixedString128(FixedString128Bytes str) { }

	[Address(RVA = "0x28AE6D0", Offset = "0x28ADAD0", Length = "0x98")]
	[Token(Token = "0x60001D8")]
	public bool WriteFixedString32(FixedString32Bytes str) { }

	[Address(RVA = "0x28AE6D0", Offset = "0x28ADAD0", Length = "0x98")]
	[Token(Token = "0x60001DC")]
	public bool WriteFixedString4096(FixedString4096Bytes str) { }

	[Address(RVA = "0x28AE6D0", Offset = "0x28ADAD0", Length = "0x98")]
	[Token(Token = "0x60001DB")]
	public bool WriteFixedString512(FixedString512Bytes str) { }

	[Address(RVA = "0x28AE6D0", Offset = "0x28ADAD0", Length = "0x98")]
	[Token(Token = "0x60001D9")]
	public bool WriteFixedString64(FixedString64Bytes str) { }

	[Address(RVA = "0x28AE770", Offset = "0x28ADB70", Length = "0xC")]
	[Token(Token = "0x60001C7")]
	public bool WriteFloat(float value) { }

	[Address(RVA = "0x28AE820", Offset = "0x28ADC20", Length = "0x92")]
	[Token(Token = "0x60001BF")]
	public bool WriteInt(int value) { }

	[Address(RVA = "0x28AE780", Offset = "0x28ADB80", Length = "0x92")]
	[Token(Token = "0x60001C5")]
	public bool WriteIntNetworkByteOrder(int value) { }

	[Address(RVA = "0x28AE8C0", Offset = "0x28ADCC0", Length = "0x92")]
	[Token(Token = "0x60001C1")]
	public bool WriteLong(long value) { }

	[Address(RVA = "0x28AEA60", Offset = "0x28ADE60", Length = "0x1D")]
	[Token(Token = "0x60001D1")]
	public bool WritePackedDouble(double value, in StreamCompressionModel model) { }

	[Address(RVA = "0x28AE960", Offset = "0x28ADD60", Length = "0xF9")]
	[Token(Token = "0x60001D7")]
	public bool WritePackedDoubleDelta(double value, double baseline, in StreamCompressionModel model) { }

	[Address(RVA = "0x28AEA80", Offset = "0x28ADE80", Length = "0x33")]
	[Token(Token = "0x60001DF")]
	public bool WritePackedFixedString128Delta(FixedString128Bytes str, FixedString128Bytes baseline, in StreamCompressionModel model) { }

	[Address(RVA = "0x28AEA80", Offset = "0x28ADE80", Length = "0x33")]
	[Token(Token = "0x60001DD")]
	public bool WritePackedFixedString32Delta(FixedString32Bytes str, FixedString32Bytes baseline, in StreamCompressionModel model) { }

	[Address(RVA = "0x28AEA80", Offset = "0x28ADE80", Length = "0x33")]
	[Token(Token = "0x60001E1")]
	public bool WritePackedFixedString4096Delta(FixedString4096Bytes str, FixedString4096Bytes baseline, in StreamCompressionModel model) { }

	[Address(RVA = "0x28AEA80", Offset = "0x28ADE80", Length = "0x33")]
	[Token(Token = "0x60001E0")]
	public bool WritePackedFixedString512Delta(FixedString512Bytes str, FixedString512Bytes baseline, in StreamCompressionModel model) { }

	[Address(RVA = "0x28AEA80", Offset = "0x28ADE80", Length = "0x33")]
	[Token(Token = "0x60001DE")]
	public bool WritePackedFixedString64Delta(FixedString64Bytes str, FixedString64Bytes baseline, in StreamCompressionModel model) { }

	[Address(RVA = "0x28AEAC0", Offset = "0x28ADEC0", Length = "0x16B")]
	[Token(Token = "0x60001E2")]
	private bool WritePackedFixedStringDelta(Byte* data, uint length, Byte* baseData, uint baseLength, in StreamCompressionModel model) { }

	[Address(RVA = "0x28AECE0", Offset = "0x28AE0E0", Length = "0x1D")]
	[Token(Token = "0x60001D0")]
	public bool WritePackedFloat(float value, in StreamCompressionModel model) { }

	[Address(RVA = "0x28AEC30", Offset = "0x28AE030", Length = "0xA7")]
	[Token(Token = "0x60001D6")]
	public bool WritePackedFloatDelta(float value, float baseline, in StreamCompressionModel model) { }

	[Address(RVA = "0x28AED20", Offset = "0x28AE120", Length = "0x14")]
	[Token(Token = "0x60001CE")]
	public bool WritePackedInt(int value, in StreamCompressionModel model) { }

	[Address(RVA = "0x28AED00", Offset = "0x28AE100", Length = "0x1D")]
	[Token(Token = "0x60001D3")]
	public bool WritePackedIntDelta(int value, int baseline, in StreamCompressionModel model) { }

	[Address(RVA = "0x28AEDA0", Offset = "0x28AE1A0", Length = "0x5A")]
	[Token(Token = "0x60001CF")]
	public bool WritePackedLong(long value, in StreamCompressionModel model) { }

	[Address(RVA = "0x28AED40", Offset = "0x28AE140", Length = "0x5D")]
	[Token(Token = "0x60001D4")]
	public bool WritePackedLongDelta(long value, long baseline, in StreamCompressionModel model) { }

	[Address(RVA = "0x28AEE00", Offset = "0x28AE200", Length = "0x111")]
	[Token(Token = "0x60001CC")]
	public bool WritePackedUInt(uint value, in StreamCompressionModel model) { }

	[Address(RVA = "0x28AED00", Offset = "0x28AE100", Length = "0x1D")]
	[Token(Token = "0x60001D2")]
	public bool WritePackedUIntDelta(uint value, uint baseline, in StreamCompressionModel model) { }

	[Address(RVA = "0x28AEF20", Offset = "0x28AE320", Length = "0x49")]
	[Token(Token = "0x60001CD")]
	public bool WritePackedULong(ulong value, in StreamCompressionModel model) { }

	[Address(RVA = "0x28AED40", Offset = "0x28AE140", Length = "0x5D")]
	[Token(Token = "0x60001D5")]
	public bool WritePackedULongDelta(ulong value, ulong baseline, in StreamCompressionModel model) { }

	[Address(RVA = "0x28AEF90", Offset = "0x28AE390", Length = "0x64")]
	[Token(Token = "0x60001CB")]
	public bool WriteRawBits(uint value, int numbits) { }

	[Address(RVA = "0x28AEF70", Offset = "0x28AE370", Length = "0x14")]
	[Token(Token = "0x60001CA")]
	private void WriteRawBitsInternal(uint value, int numbits) { }

	[Address(RVA = "0x28AF0A0", Offset = "0x28AE4A0", Length = "0x92")]
	[Token(Token = "0x60001BD")]
	public bool WriteShort(short value) { }

	[Address(RVA = "0x28AF000", Offset = "0x28AE400", Length = "0x92")]
	[Token(Token = "0x60001C3")]
	public bool WriteShortNetworkByteOrder(short value) { }

	[Address(RVA = "0x28AE820", Offset = "0x28ADC20", Length = "0x92")]
	[Token(Token = "0x60001C0")]
	public bool WriteUInt(uint value) { }

	[Address(RVA = "0x28AF140", Offset = "0x28AE540", Length = "0x8")]
	[Token(Token = "0x60001C6")]
	public bool WriteUIntNetworkByteOrder(uint value) { }

	[Address(RVA = "0x28AE8C0", Offset = "0x28ADCC0", Length = "0x92")]
	[Token(Token = "0x60001C2")]
	public bool WriteULong(ulong value) { }

	[Address(RVA = "0x28AF0A0", Offset = "0x28AE4A0", Length = "0x92")]
	[Token(Token = "0x60001BE")]
	public bool WriteUShort(ushort value) { }

	[Address(RVA = "0x28AF150", Offset = "0x28AE550", Length = "0x8")]
	[Token(Token = "0x60001C4")]
	public bool WriteUShortNetworkByteOrder(ushort value) { }

}

