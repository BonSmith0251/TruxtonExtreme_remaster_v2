namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x20000DD")]
public struct StreamCompressionModel
{
	[CompilerGenerated]
	[Token(Token = "0x20000DF")]
	[UnsafeValueType]
	internal struct <bucketOffsets>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400043C")]
		public uint FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E0")]
	[UnsafeValueType]
	internal struct <bucketSizes>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400043D")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E1")]
	[UnsafeValueType]
	internal struct <decodeTable>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400043E")]
		public ushort FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E2")]
	[UnsafeValueType]
	internal struct <encodeTable>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400043F")]
		public ushort FixedElementField; //Field offset: 0x0

	}

	[Token(Token = "0x20000DE")]
	private static class SharedStaticCompressionModel
	{
		[Token(Token = "0x400043B")]
		internal static readonly SharedStatic<StreamCompressionModel> Default; //Field offset: 0x0

		[Address(RVA = "0x28CD330", Offset = "0x28CC730", Length = "0x5D")]
		[Token(Token = "0x6000A1C")]
		private static SharedStaticCompressionModel() { }

	}

	[Token(Token = "0x400042F")]
	internal static readonly Byte[] k_BucketSizes; //Field offset: 0x0
	[Token(Token = "0x4000433")]
	internal const int k_AlphabetSize = 16; //Field offset: 0x0
	[Token(Token = "0x4000434")]
	internal const int k_MaxHuffmanSymbolLength = 6; //Field offset: 0x0
	[Token(Token = "0x4000435")]
	internal const int k_MaxContexts = 1; //Field offset: 0x0
	[Token(Token = "0x4000430")]
	internal static readonly UInt32[] k_BucketOffsets; //Field offset: 0x8
	[Token(Token = "0x4000431")]
	internal static readonly Int32[] k_FirstBucketCandidate; //Field offset: 0x10
	[Token(Token = "0x4000432")]
	internal static readonly Byte[] k_DefaultModelData; //Field offset: 0x18
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000436")]
	private byte m_Initialized; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[FixedBuffer(typeof(ushort), 16)]
	[Token(Token = "0x4000437")]
	internal <encodeTable>e__FixedBuffer encodeTable; //Field offset: 0x2
	[FieldOffset(Offset = "0x22")]
	[FixedBuffer(typeof(ushort), 64)]
	[Token(Token = "0x4000438")]
	internal <decodeTable>e__FixedBuffer decodeTable; //Field offset: 0x22
	[FieldOffset(Offset = "0xA2")]
	[FixedBuffer(typeof(byte), 16)]
	[Token(Token = "0x4000439")]
	internal <bucketSizes>e__FixedBuffer bucketSizes; //Field offset: 0xA2
	[FieldOffset(Offset = "0xB4")]
	[FixedBuffer(typeof(uint), 16)]
	[Token(Token = "0x400043A")]
	internal <bucketOffsets>e__FixedBuffer bucketOffsets; //Field offset: 0xB4

	[Token(Token = "0x1700012C")]
	public static StreamCompressionModel Default
	{
		[Address(RVA = "0x28CE180", Offset = "0x28CD580", Length = "0x17E")]
		[Token(Token = "0x6000A10")]
		 get { } //Length: 382
	}

	[Address(RVA = "0x28CDFC0", Offset = "0x28CD3C0", Length = "0x1BE")]
	[Token(Token = "0x6000A1B")]
	private static StreamCompressionModel() { }

	[Address(RVA = "0x28CD390", Offset = "0x28CC790", Length = "0xD1")]
	[IsReadOnly]
	[Token(Token = "0x6000A15")]
	public int CalculateBucket(uint value) { }

	[Address(RVA = "0x28CD470", Offset = "0x28CC870", Length = "0x68")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000A19")]
	private static void CheckAlphabetAndMaxCodeLength(int alphabetSize, int maxCodeLength) { }

	[Address(RVA = "0x28CD4E0", Offset = "0x28CC8E0", Length = "0x92")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000A17")]
	private static void CheckAlphabetSize(int alphabetSize) { }

	[Address(RVA = "0x28CD580", Offset = "0x28CC980", Length = "0x5F")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000A1A")]
	private static void CheckExceedMaxCodeLength(int length, int maxCodeLength) { }

	[Address(RVA = "0x28CD5E0", Offset = "0x28CC9E0", Length = "0x6E")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000A18")]
	private static void CheckSymbolLength(NativeArray<Byte> symbolLengths, int symbolLengthsOffset, int symbol, int length) { }

	[Address(RVA = "0x28CD650", Offset = "0x28CCA50", Length = "0x259")]
	[Token(Token = "0x6000A12")]
	private static void GenerateHuffmanCodes(NativeArray<Byte> symbolCodes, int symbolCodesOffset, NativeArray<Byte> symbolLengths, int symbolLengthsOffset, int alphabetSize, int maxCodeLength) { }

	[Address(RVA = "0x28CD8B0", Offset = "0x28CCCB0", Length = "0xB8")]
	[Token(Token = "0x6000A14")]
	private static void GenerateHuffmanDecodeTable(NativeArray<UInt16> decodeTable, int decodeTableOffset, NativeArray<Byte> symbolLengths, NativeArray<Byte> symbolCodes, int alphabetSize, int maxCodeLength) { }

	[Address(RVA = "0x28CE180", Offset = "0x28CD580", Length = "0x17E")]
	[Token(Token = "0x6000A10")]
	public static StreamCompressionModel get_Default() { }

	[Address(RVA = "0x28CD970", Offset = "0x28CCD70", Length = "0x6D")]
	[IsReadOnly]
	[Token(Token = "0x6000A16")]
	public int GetCompressedSizeInBits(uint value) { }

	[Address(RVA = "0x28CD9E0", Offset = "0x28CCDE0", Length = "0x571")]
	[Token(Token = "0x6000A11")]
	private static void Initialize() { }

	[Address(RVA = "0x28CDF60", Offset = "0x28CD360", Length = "0x53")]
	[Token(Token = "0x6000A13")]
	private static uint ReverseBits(uint value, int num_bits) { }

}

