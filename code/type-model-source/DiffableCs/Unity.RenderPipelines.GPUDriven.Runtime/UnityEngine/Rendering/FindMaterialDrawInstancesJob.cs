namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
[Token(Token = "0x200005A")]
internal struct FindMaterialDrawInstancesJob : IJobParallelForBatch
{
	[Token(Token = "0x4000188")]
	public const int k_BatchSize = 128; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000189")]
	public NativeArray<UInt32> materialsSorted; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[ReadOnly]
	[Token(Token = "0x400018A")]
	public NativeList<DrawInstance> drawInstances; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400018B")]
	[WriteOnly]
	public ParallelWriter<Int32> outDrawInstanceIndicesWriter; //Field offset: 0x18

	[Address(RVA = "0x2CDF730", Offset = "0x2CDEB30", Length = "0x105")]
	[Token(Token = "0x6000177")]
	public override void Execute(int startIndex, int count) { }

}

