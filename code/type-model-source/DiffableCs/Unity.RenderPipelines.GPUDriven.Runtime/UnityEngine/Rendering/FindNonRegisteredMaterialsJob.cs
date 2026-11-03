namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
[Token(Token = "0x200005C")]
internal struct FindNonRegisteredMaterialsJob : IJobParallelForBatch
{
	[Token(Token = "0x4000190")]
	public const int k_BatchSize = 128; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000191")]
	public NativeArray<EntityId> instanceIDs; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x4000192")]
	public NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[ReadOnly]
	[Token(Token = "0x4000193")]
	public NativeParallelHashMap<EntityId, BatchMaterialID> hashMap; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000194")]
	[WriteOnly]
	public ParallelWriter<EntityId> outInstancesWriter; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000195")]
	[WriteOnly]
	public ParallelWriter<GPUDrivenPackedMaterialData> outPackedMaterialDatasWriter; //Field offset: 0x38

	[Address(RVA = "0x2CDF840", Offset = "0x2CDEC40", Length = "0x275")]
	[Token(Token = "0x6000179")]
	public override void Execute(int startIndex, int count) { }

}

