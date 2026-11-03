namespace Unity.Collections.LowLevel.Unsafe;

[BurstCompile]
[Token(Token = "0x2000113")]
internal struct UnsafeDisposeJob : IJob
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40004C0")]
	public Void* Ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40004C1")]
	public AllocatorHandle Allocator; //Field offset: 0x8

	[Address(RVA = "0x28D2C60", Offset = "0x28D2060", Length = "0x5B")]
	[Token(Token = "0x6000BA5")]
	public override void Execute() { }

}

