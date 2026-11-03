namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
[Token(Token = "0x200005B")]
internal struct FindNonRegisteredMeshesJob : IJobParallelForBatch
{
	[Token(Token = "0x400018C")]
	public const int k_BatchSize = 128; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x400018D")]
	public NativeArray<EntityId> instanceIDs; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x400018E")]
	public NativeParallelHashMap<EntityId, BatchMeshID> hashMap; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400018F")]
	[WriteOnly]
	public ParallelWriter<EntityId> outInstancesWriter; //Field offset: 0x20

	[Address(RVA = "0x2CDFAC0", Offset = "0x2CDEEC0", Length = "0x17E")]
	[Token(Token = "0x6000178")]
	public override void Execute(int startIndex, int count) { }

}

