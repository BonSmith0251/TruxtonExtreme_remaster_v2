namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
[Token(Token = "0x200005E")]
internal struct RegisterNewMaterialsJob : IJobParallelFor
{
	[Token(Token = "0x400019A")]
	public const int k_BatchSize = 128; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x400019B")]
	public NativeArray<EntityId> instanceIDs; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x400019C")]
	public NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[ReadOnly]
	[Token(Token = "0x400019D")]
	public NativeArray<BatchMaterialID> batchIDs; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400019E")]
	[WriteOnly]
	public ParallelWriter<EntityId, BatchMaterialID> batchMaterialHashMap; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400019F")]
	[WriteOnly]
	public ParallelWriter<EntityId, GPUDrivenPackedMaterialData> packedMaterialHashMap; //Field offset: 0x40

	[Address(RVA = "0x2CEF2A0", Offset = "0x2CEE6A0", Length = "0x86")]
	[Token(Token = "0x600017B")]
	public override void Execute(int index) { }

}

