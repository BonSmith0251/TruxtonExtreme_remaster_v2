namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
[Token(Token = "0x200005D")]
internal struct RegisterNewMeshesJob : IJobParallelFor
{
	[Token(Token = "0x4000196")]
	public const int k_BatchSize = 128; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000197")]
	public NativeArray<EntityId> instanceIDs; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x4000198")]
	public NativeArray<BatchMeshID> batchIDs; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000199")]
	[WriteOnly]
	public ParallelWriter<EntityId, BatchMeshID> hashMap; //Field offset: 0x20

	[Address(RVA = "0x2CEF330", Offset = "0x2CEE730", Length = "0x54")]
	[Token(Token = "0x600017A")]
	public override void Execute(int index) { }

}

