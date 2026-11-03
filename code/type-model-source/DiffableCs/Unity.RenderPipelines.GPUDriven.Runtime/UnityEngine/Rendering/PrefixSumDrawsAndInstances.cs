namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
[Token(Token = "0x2000043")]
internal struct PrefixSumDrawsAndInstances : IJob
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000114")]
	public NativeList<DrawRange> drawRanges; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[ReadOnly]
	[Token(Token = "0x4000115")]
	public NativeArray<Int32> drawBatchIndices; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[ReadOnly]
	[Token(Token = "0x4000116")]
	public NativeArray<Int32> batchBinAllocOffsets; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[ReadOnly]
	[Token(Token = "0x4000117")]
	public NativeArray<Int32> batchBinCounts; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[ReadOnly]
	[Token(Token = "0x4000118")]
	public NativeArray<Int32> binVisibleInstanceCounts; //Field offset: 0x38
	[FieldOffset(Offset = "0x48")]
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[Token(Token = "0x4000119")]
	[WriteOnly]
	public NativeArray<Int32> batchDrawCommandOffsets; //Field offset: 0x48
	[FieldOffset(Offset = "0x58")]
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[Token(Token = "0x400011A")]
	[WriteOnly]
	public NativeArray<Int32> binVisibleInstanceOffsets; //Field offset: 0x58
	[FieldOffset(Offset = "0x68")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x400011B")]
	public NativeArray<BatchCullingOutputDrawCommands> cullingOutput; //Field offset: 0x68
	[FieldOffset(Offset = "0x78")]
	[ReadOnly]
	[Token(Token = "0x400011C")]
	public IndirectBufferLimits indirectBufferLimits; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[Token(Token = "0x400011D")]
	public NativeArray<IndirectBufferAllocInfo> indirectBufferAllocInfo; //Field offset: 0x80
	[FieldOffset(Offset = "0x90")]
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[Token(Token = "0x400011E")]
	public NativeArray<Int32> indirectAllocationCounters; //Field offset: 0x90

	[Address(RVA = "0x2CD3C10", Offset = "0x2CD3010", Length = "0x584")]
	[Token(Token = "0x600013A")]
	public override void Execute() { }

}

