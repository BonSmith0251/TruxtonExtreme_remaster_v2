namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x20000EB")]
internal struct UnsafeQueueData
{
	[Token(Token = "0x4000459")]
	internal const int m_BlockSize = 16384; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400045A")]
	public IntPtr m_FirstBlock; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400045B")]
	public IntPtr m_LastBlock; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400045C")]
	public int m_MaxItems; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400045D")]
	public int m_CurrentRead; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400045E")]
	public Byte* m_CurrentWriteBlockTLS; //Field offset: 0x18

	[Address(RVA = "0x9DC230", Offset = "0x9DB630", Length = "0xE0")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000A3F")]
	public static void AllocateQueue(AllocatorHandle allocator, out UnsafeQueueData* outBuf) { }

	[Address(RVA = "0x9DC500", Offset = "0x9DB900", Length = "0xBA")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000A3E")]
	public static UnsafeQueueBlockHeader* AllocateWriteBlockMT(UnsafeQueueData* data, AllocatorHandle allocator, int threadIndex) { }

	[Address(RVA = "0x28D30C0", Offset = "0x28D24C0", Length = "0x91")]
	[Token(Token = "0x6000A40")]
	public static void DeallocateQueue(UnsafeQueueData* data, AllocatorHandle allocator) { }

	[Address(RVA = "0x28D3160", Offset = "0x28D2560", Length = "0xF")]
	[Token(Token = "0x6000A3C")]
	internal UnsafeQueueBlockHeader* GetCurrentWriteBlockTLS(int threadIndex) { }

	[Address(RVA = "0x28D3170", Offset = "0x28D2570", Length = "0xF")]
	[Token(Token = "0x6000A3D")]
	internal void SetCurrentWriteBlockTLS(int threadIndex, UnsafeQueueBlockHeader* currentWriteBlock) { }

}

