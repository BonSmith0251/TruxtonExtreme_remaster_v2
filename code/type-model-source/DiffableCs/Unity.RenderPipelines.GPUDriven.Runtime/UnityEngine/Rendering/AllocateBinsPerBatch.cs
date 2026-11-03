namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
[Token(Token = "0x2000042")]
internal struct AllocateBinsPerBatch : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000107")]
	public BinningConfig binningConfig; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[ReadOnly]
	[Token(Token = "0x4000108")]
	public NativeList<DrawBatch> drawBatches; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x4000109")]
	public NativeArray<Int32> drawInstanceIndices; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[ReadOnly]
	[Token(Token = "0x400010A")]
	public ReadOnly instanceData; //Field offset: 0x20
	[FieldOffset(Offset = "0x108")]
	[ReadOnly]
	[Token(Token = "0x400010B")]
	public NativeArray<Byte> rendererVisibilityMasks; //Field offset: 0x108
	[FieldOffset(Offset = "0x118")]
	[ReadOnly]
	[Token(Token = "0x400010C")]
	public NativeArray<Byte> rendererMeshLodSettings; //Field offset: 0x118
	[FieldOffset(Offset = "0x128")]
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[Token(Token = "0x400010D")]
	[WriteOnly]
	public NativeArray<Int32> batchBinAllocOffsets; //Field offset: 0x128
	[FieldOffset(Offset = "0x138")]
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[Token(Token = "0x400010E")]
	[WriteOnly]
	public NativeArray<Int32> batchBinCounts; //Field offset: 0x138
	[DeallocateOnJobCompletion]
	[FieldOffset(Offset = "0x148")]
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[Token(Token = "0x400010F")]
	public NativeArray<Int32> binAllocCounter; //Field offset: 0x148
	[FieldOffset(Offset = "0x158")]
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[Token(Token = "0x4000110")]
	[WriteOnly]
	public NativeArray<Int16> binConfigIndices; //Field offset: 0x158
	[FieldOffset(Offset = "0x168")]
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[Token(Token = "0x4000111")]
	[WriteOnly]
	public NativeArray<Int32> binVisibleInstanceCounts; //Field offset: 0x168
	[FieldOffset(Offset = "0x178")]
	[ReadOnly]
	[Token(Token = "0x4000112")]
	public int debugCounterIndexBase; //Field offset: 0x178
	[FieldOffset(Offset = "0x180")]
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[Token(Token = "0x4000113")]
	public NativeArray<Int32> splitDebugCounters; //Field offset: 0x180

	[Address(RVA = "0x2CC0A90", Offset = "0x2CBFE90", Length = "0x5CC")]
	[Token(Token = "0x6000139")]
	public override void Execute(int batchIndex) { }

	[Address(RVA = "0x2CC1060", Offset = "0x2CC0460", Length = "0x58")]
	[Token(Token = "0x6000138")]
	private static int GetPrimitiveCount(int indexCount, MeshTopology topology, bool nativeQuads) { }

	[Address(RVA = "0x2CC10D0", Offset = "0x2CC04D0", Length = "0x90")]
	[Token(Token = "0x6000136")]
	private bool IsInstanceFlipped(int rendererIndex) { }

	[Address(RVA = "0x2CC1160", Offset = "0x2CC0560", Length = "0x4D")]
	[Token(Token = "0x6000137")]
	private bool IsMeshLodVisible(int batchLodLevel, int rendererIndex, bool supportsCrossFade) { }

}

