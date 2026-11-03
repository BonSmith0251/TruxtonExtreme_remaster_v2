namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
[Token(Token = "0x2000045")]
internal struct CompactVisibilityMasksJob : IJobParallelForBatch
{
	[Token(Token = "0x4000135")]
	public const int k_BatchSize = 64; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000136")]
	public NativeArray<Byte> rendererVisibilityMasks; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[Token(Token = "0x4000137")]
	public ParallelBitArray compactedVisibilityMasks; //Field offset: 0x10

	[Address(RVA = "0x2CC1980", Offset = "0x2CC0D80", Length = "0x4C")]
	[Token(Token = "0x600013F")]
	public override void Execute(int startIndex, int count) { }

}

