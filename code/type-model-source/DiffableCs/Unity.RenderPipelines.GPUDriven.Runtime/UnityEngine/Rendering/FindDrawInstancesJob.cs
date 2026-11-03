namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
[Token(Token = "0x2000059")]
internal struct FindDrawInstancesJob : IJobParallelForBatch
{
	[Token(Token = "0x4000184")]
	public const int k_BatchSize = 128; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000185")]
	public NativeArray<InstanceHandle> instancesSorted; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[ReadOnly]
	[Token(Token = "0x4000186")]
	public NativeList<DrawInstance> drawInstances; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000187")]
	[WriteOnly]
	public ParallelWriter<Int32> outDrawInstanceIndicesWriter; //Field offset: 0x18

	[Address(RVA = "0x2CDF5C0", Offset = "0x2CDE9C0", Length = "0x16E")]
	[Token(Token = "0x6000176")]
	public override void Execute(int startIndex, int count) { }

}

