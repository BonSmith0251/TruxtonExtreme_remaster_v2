namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
[Token(Token = "0x2000058")]
internal struct BuildDrawListsJob : IJobParallelFor
{
	[Token(Token = "0x400017D")]
	public const int k_BatchSize = 128; //Field offset: 0x0
	[Token(Token = "0x400017E")]
	public const int k_IntsPerCacheLine = 16; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x400017F")]
	public NativeParallelHashMap<DrawKey, Int32> batchHash; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[ReadOnly]
	[Token(Token = "0x4000180")]
	public NativeList<DrawInstance> drawInstances; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[ReadOnly]
	[Token(Token = "0x4000181")]
	public NativeList<DrawBatch> drawBatches; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[Token(Token = "0x4000182")]
	[WriteOnly]
	public NativeArray<Int32> internalDrawIndex; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[Token(Token = "0x4000183")]
	[WriteOnly]
	public NativeArray<Int32> drawInstanceIndices; //Field offset: 0x30

	[Address(RVA = "0x2CD9A70", Offset = "0x2CD8E70", Length = "0x118")]
	[Token(Token = "0x6000175")]
	public override void Execute(int index) { }

	[Address(RVA = "0x2CD9B90", Offset = "0x2CD8F90", Length = "0x37")]
	[Token(Token = "0x6000174")]
	private static int IncrementCounter(Int32* counter) { }

}

