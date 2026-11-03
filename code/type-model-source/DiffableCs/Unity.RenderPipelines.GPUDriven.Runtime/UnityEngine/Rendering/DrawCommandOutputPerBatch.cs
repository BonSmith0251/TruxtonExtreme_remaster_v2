namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
[Token(Token = "0x2000044")]
internal struct DrawCommandOutputPerBatch : IJobParallelFor
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x400011F")]
	public BinningConfig binningConfig; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[ReadOnly]
	[Token(Token = "0x4000120")]
	public NativeParallelHashMap<UInt32, BatchID> batchIDs; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[ReadOnly]
	[Token(Token = "0x4000121")]
	public ReadOnly instanceDataBuffer; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[ReadOnly]
	[Token(Token = "0x4000122")]
	public NativeList<DrawBatch> drawBatches; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[ReadOnly]
	[Token(Token = "0x4000123")]
	public NativeArray<Int32> drawInstanceIndices; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[ReadOnly]
	[Token(Token = "0x4000124")]
	public ReadOnly instanceData; //Field offset: 0x40
	[FieldOffset(Offset = "0x128")]
	[ReadOnly]
	[Token(Token = "0x4000125")]
	public NativeArray<Byte> rendererVisibilityMasks; //Field offset: 0x128
	[FieldOffset(Offset = "0x138")]
	[ReadOnly]
	[Token(Token = "0x4000126")]
	public NativeArray<Byte> rendererMeshLodSettings; //Field offset: 0x138
	[FieldOffset(Offset = "0x148")]
	[ReadOnly]
	[Token(Token = "0x4000127")]
	public NativeArray<Byte> rendererCrossFadeValues; //Field offset: 0x148
	[DeallocateOnJobCompletion]
	[FieldOffset(Offset = "0x158")]
	[ReadOnly]
	[Token(Token = "0x4000128")]
	public NativeArray<Int32> batchBinAllocOffsets; //Field offset: 0x158
	[DeallocateOnJobCompletion]
	[FieldOffset(Offset = "0x168")]
	[ReadOnly]
	[Token(Token = "0x4000129")]
	public NativeArray<Int32> batchBinCounts; //Field offset: 0x168
	[DeallocateOnJobCompletion]
	[FieldOffset(Offset = "0x178")]
	[ReadOnly]
	[Token(Token = "0x400012A")]
	public NativeArray<Int32> batchDrawCommandOffsets; //Field offset: 0x178
	[DeallocateOnJobCompletion]
	[FieldOffset(Offset = "0x188")]
	[ReadOnly]
	[Token(Token = "0x400012B")]
	public NativeArray<Int16> binConfigIndices; //Field offset: 0x188
	[DeallocateOnJobCompletion]
	[FieldOffset(Offset = "0x198")]
	[ReadOnly]
	[Token(Token = "0x400012C")]
	public NativeArray<Int32> binVisibleInstanceOffsets; //Field offset: 0x198
	[DeallocateOnJobCompletion]
	[FieldOffset(Offset = "0x1A8")]
	[ReadOnly]
	[Token(Token = "0x400012D")]
	public NativeArray<Int32> binVisibleInstanceCounts; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1B8")]
	[ReadOnly]
	[Token(Token = "0x400012E")]
	public NativeArray<BatchCullingOutputDrawCommands> cullingOutput; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C8")]
	[ReadOnly]
	[Token(Token = "0x400012F")]
	public IndirectBufferLimits indirectBufferLimits; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[ReadOnly]
	[Token(Token = "0x4000130")]
	public GraphicsBufferHandle visibleInstancesBufferHandle; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D4")]
	[ReadOnly]
	[Token(Token = "0x4000131")]
	public GraphicsBufferHandle indirectArgsBufferHandle; //Field offset: 0x1D4
	[FieldOffset(Offset = "0x1D8")]
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[Token(Token = "0x4000132")]
	public NativeArray<IndirectBufferAllocInfo> indirectBufferAllocInfo; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E8")]
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[Token(Token = "0x4000133")]
	public NativeArray<IndirectDrawInfo> indirectDrawInfoGlobalArray; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F8")]
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[Token(Token = "0x4000134")]
	public NativeArray<IndirectInstanceInfo> indirectInstanceInfoGlobalArray; //Field offset: 0x1F8

	[Address(RVA = "0x2CC58E0", Offset = "0x2CC4CE0", Length = "0xE1")]
	[Token(Token = "0x600013B")]
	private int EncodeGPUInstanceIndexAndCrossFade(int rendererIndex, bool negateCrossFade) { }

	[Address(RVA = "0x2CC59D0", Offset = "0x2CC4DD0", Length = "0xA29")]
	[Token(Token = "0x600013E")]
	public override void Execute(int batchIndex) { }

	[Address(RVA = "0x2CC6400", Offset = "0x2CC5800", Length = "0x93")]
	[Token(Token = "0x600013C")]
	private bool IsInstanceFlipped(int rendererIndex) { }

	[Address(RVA = "0x2CC64A0", Offset = "0x2CC58A0", Length = "0x55")]
	[Token(Token = "0x600013D")]
	private bool IsMeshLodVisible(int batchLodLevel, int rendererIndex, bool supportsCrossFade, ref bool negateCrossfade) { }

}

