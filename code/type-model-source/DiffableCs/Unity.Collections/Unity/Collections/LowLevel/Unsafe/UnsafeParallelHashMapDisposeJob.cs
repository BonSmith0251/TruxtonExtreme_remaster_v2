namespace Unity.Collections.LowLevel.Unsafe;

[BurstCompile]
[Token(Token = "0x200012D")]
internal struct UnsafeParallelHashMapDisposeJob : IJob
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000501")]
	public UnsafeParallelHashMapData* Data; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000502")]
	public AllocatorHandle Allocator; //Field offset: 0x8

	[Address(RVA = "0x28D2CE0", Offset = "0x28D20E0", Length = "0x6E")]
	[Token(Token = "0x6000C87")]
	public override void Execute() { }

}

