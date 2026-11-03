namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
[Token(Token = "0x2000057")]
internal struct PrefixSumDrawInstancesJob : IJob
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000179")]
	public NativeParallelHashMap<RangeKey, Int32> rangeHash; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400017A")]
	public NativeList<DrawRange> drawRanges; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400017B")]
	public NativeList<DrawBatch> drawBatches; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400017C")]
	public NativeArray<Int32> drawBatchIndices; //Field offset: 0x20

	[Address(RVA = "0x2CED2A0", Offset = "0x2CEC6A0", Length = "0x253")]
	[Token(Token = "0x6000173")]
	public override void Execute() { }

}

