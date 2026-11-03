namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
[Token(Token = "0x20000BD")]
internal struct UpdateLODGroupTransformJob : IJobParallelFor
{
	[Token(Token = "0x4000382")]
	public const int k_BatchSize = 256; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000383")]
	public NativeParallelHashMap<Int32, GPUInstanceIndex> lodGroupDataHash; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x4000384")]
	public NativeArray<EntityId> lodGroupIDs; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[ReadOnly]
	[Token(Token = "0x4000385")]
	public NativeArray<Vector3> worldSpaceReferencePoints; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[ReadOnly]
	[Token(Token = "0x4000386")]
	public NativeArray<Single> worldSpaceSizes; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[ReadOnly]
	[Token(Token = "0x4000387")]
	public bool requiresGPUUpload; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[ReadOnly]
	[Token(Token = "0x4000388")]
	public bool supportDitheringCrossFade; //Field offset: 0x41
	[FieldOffset(Offset = "0x48")]
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[ReadOnly]
	[Token(Token = "0x4000389")]
	public NativeList<LODGroupData> lodGroupData; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[Token(Token = "0x400038A")]
	[WriteOnly]
	public NativeList<LODGroupCullingData> lodGroupCullingData; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x400038B")]
	public UnsafeAtomicCounter32 atomicUpdateCount; //Field offset: 0x58

	[Address(RVA = "0x2D04550", Offset = "0x2D03950", Length = "0x1EF")]
	[Token(Token = "0x600032E")]
	public override void Execute(int index) { }

}

