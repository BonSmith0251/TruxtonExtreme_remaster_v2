namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
[Token(Token = "0x20000BE")]
internal struct UpdateLODGroupDataJob : IJobParallelFor
{
	[Token(Token = "0x400038C")]
	public const int k_BatchSize = 256; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x400038D")]
	public NativeArray<GPUInstanceIndex> lodGroupInstances; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x400038E")]
	public GPUDrivenLODGroupData inputData; //Field offset: 0x10
	[FieldOffset(Offset = "0xE0")]
	[ReadOnly]
	[Token(Token = "0x400038F")]
	public bool supportDitheringCrossFade; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000390")]
	public NativeArray<LODGroupData> lodGroupsData; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000391")]
	public NativeArray<LODGroupCullingData> lodGroupsCullingData; //Field offset: 0xF8
	[FieldOffset(Offset = "0x108")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000392")]
	public UnsafeAtomicCounter32 rendererCount; //Field offset: 0x108

	[Address(RVA = "0x2D04230", Offset = "0x2D03630", Length = "0x31D")]
	[Token(Token = "0x600032F")]
	public override void Execute(int index) { }

}

