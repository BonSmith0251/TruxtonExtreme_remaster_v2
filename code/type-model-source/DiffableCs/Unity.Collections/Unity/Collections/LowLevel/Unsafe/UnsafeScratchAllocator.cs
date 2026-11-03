namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x200013E")]
public struct UnsafeScratchAllocator
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400051E")]
	private Void* m_Pointer; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400051F")]
	private int m_LengthInBytes; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000520")]
	private readonly int m_CapacityInBytes; //Field offset: 0xC

	[Address(RVA = "0x28D33B0", Offset = "0x28D27B0", Length = "0xF")]
	[Token(Token = "0x6000D7C")]
	public UnsafeScratchAllocator(Void* ptr, int capacityInBytes) { }

	[Address(RVA = "0x28D3230", Offset = "0x28D2630", Length = "0x9D")]
	[Token(Token = "0x6000D7E")]
	public Void* Allocate(int sizeInBytes, int alignmentInBytes) { }

	[Address(RVA = "0x9DC5C0", Offset = "0x9DB9C0", Length = "0x73")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000D7F")]
	public Void* Allocate(int count = 1) { }

	[Address(RVA = "0x28D32D0", Offset = "0x28D26D0", Length = "0xE0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000D7D")]
	private void CheckAllocationDoesNotExceedCapacity(ulong requestedSize) { }

}

