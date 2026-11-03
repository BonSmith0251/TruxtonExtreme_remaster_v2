namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000122")]
public struct UnsafeParallelHashMapBucketData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004E1")]
	public readonly Byte* values; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40004E2")]
	public readonly Byte* keys; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004E3")]
	public readonly Byte* next; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004E4")]
	public readonly Byte* buckets; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004E5")]
	public readonly int bucketCapacityMask; //Field offset: 0x20

	[Address(RVA = "0x28D2CC0", Offset = "0x28D20C0", Length = "0x1C")]
	[Token(Token = "0x6000C2B")]
	internal UnsafeParallelHashMapBucketData(Byte* v, Byte* k, Byte* n, Byte* b, int bcm) { }

}

