namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
[Token(Token = "0x200005F")]
internal struct UpdatePackedMaterialDataCacheJob : IJob
{
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x40001A0")]
	public ReadOnly<EntityId> materialIDs; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x40001A1")]
	public ReadOnly<GPUDrivenPackedMaterialData> packedMaterialDatas; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001A2")]
	public NativeParallelHashMap<EntityId, GPUDrivenPackedMaterialData> packedMaterialHash; //Field offset: 0x20

	[Address(RVA = "0x2CF0C80", Offset = "0x2CF0080", Length = "0x4F")]
	[Token(Token = "0x600017D")]
	public override void Execute() { }

	[Address(RVA = "0x2CF0CD0", Offset = "0x2CF00D0", Length = "0xD4")]
	[Token(Token = "0x600017C")]
	private void ProcessMaterial(int i) { }

}

