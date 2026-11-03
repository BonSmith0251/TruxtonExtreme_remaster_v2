namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000142")]
internal struct UnsafeStreamBlockData
{
	[Token(Token = "0x4000529")]
	internal const int AllocationSize = 4096; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400052A")]
	internal AllocatorHandle Allocator; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400052B")]
	internal UnsafeStreamBlock** Blocks; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400052C")]
	internal int BlockCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400052D")]
	internal Block Ranges; //Field offset: 0x18
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400052E")]
	internal int RangeCount; //Field offset: 0x38

	[Address(RVA = "0x28D33C0", Offset = "0x28D27C0", Length = "0x13F")]
	[Token(Token = "0x6000D80")]
	internal UnsafeStreamBlock* Allocate(UnsafeStreamBlock* oldBlock, int threadIndex) { }

	[Address(RVA = "0x28D3500", Offset = "0x28D2900", Length = "0xDA")]
	[Token(Token = "0x6000D81")]
	internal void Free(UnsafeStreamBlock* oldBlock) { }

}

