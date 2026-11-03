namespace UnityEngine.Rendering;

[Token(Token = "0x2000061")]
internal class InstanceCullingBatcher : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001AB")]
	private RenderersBatchersContext m_BatchersContext; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001AC")]
	private CPUDrawInstanceData m_DrawInstanceData; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001AD")]
	private BatchRendererGroup m_BRG; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001AE")]
	private NativeParallelHashMap<UInt32, BatchID> m_GlobalBatchIDs; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001AF")]
	private InstanceCuller m_Culler; //Field offset: 0x38
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x40001B0")]
	private NativeParallelHashMap<EntityId, BatchMaterialID> m_BatchMaterialHash; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x40001B1")]
	private NativeParallelHashMap<EntityId, GPUDrivenPackedMaterialData> m_PackedMaterialHash; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x40001B2")]
	private NativeParallelHashMap<EntityId, BatchMeshID> m_BatchMeshHash; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x40001B3")]
	private int m_CachedInstanceDataBufferLayoutVersion; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x40001B4")]
	private OnCullingCompleteCallback m_OnCompleteCallback; //Field offset: 0x210

	[Token(Token = "0x1700002C")]
	public NativeParallelHashMap<EntityId, BatchMaterialID> batchMaterialHash
	{
		[Address(RVA = "0x2CE71E0", Offset = "0x2CE65E0", Length = "0xE")]
		[Token(Token = "0x600018E")]
		 get { } //Length: 14
	}

	[Token(Token = "0x1700002E")]
	internal InstanceCuller culler
	{
		[Address(RVA = "0x2A009A0", Offset = "0x29FFDA0", Length = "0x5")]
		[Token(Token = "0x6000191")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700002D")]
	public NativeParallelHashMap<EntityId, GPUDrivenPackedMaterialData> packedMaterialHash
	{
		[Address(RVA = "0x29D6320", Offset = "0x29D5720", Length = "0xE")]
		[Token(Token = "0x600018F")]
		 get { } //Length: 14
	}

	[Address(RVA = "0x2CE6C50", Offset = "0x2CE6050", Length = "0x58B")]
	[Token(Token = "0x6000190")]
	public InstanceCullingBatcher(RenderersBatchersContext batcherContext, InstanceCullingBatcherDesc desc, OnFinishedCulling onFinishedCulling) { }

	[Address(RVA = "0x2CE4930", Offset = "0x2CE3D30", Length = "0x175")]
	[Token(Token = "0x600019F")]
	public void BuildBatch(NativeArray<InstanceHandle> instances, in GPUDrivenRendererGroupData rendererData, bool registerMaterialsAndMeshes) { }

	[Address(RVA = "0x2CE4AB0", Offset = "0x2CE3EB0", Length = "0x32")]
	[Token(Token = "0x6000198")]
	public void DestroyDrawInstances(NativeArray<InstanceHandle> instances) { }

	[Address(RVA = "0x2CE4AF0", Offset = "0x2CE3EF0", Length = "0x2CC")]
	[Token(Token = "0x6000199")]
	public void DestroyMaterials(NativeArray<EntityId> destroyedMaterials) { }

	[Address(RVA = "0x2CE4DC0", Offset = "0x2CE41C0", Length = "0x1BF")]
	[Token(Token = "0x600019A")]
	public void DestroyMeshes(NativeArray<EntityId> destroyedMeshes) { }

	[Address(RVA = "0x2CE4F80", Offset = "0x2CE4380", Length = "0x49B")]
	[Token(Token = "0x6000192")]
	public override void Dispose() { }

	[Address(RVA = "0x2CE71E0", Offset = "0x2CE65E0", Length = "0xE")]
	[Token(Token = "0x600018E")]
	public NativeParallelHashMap<EntityId, BatchMaterialID> get_batchMaterialHash() { }

	[Address(RVA = "0x2A009A0", Offset = "0x29FFDA0", Length = "0x5")]
	[Token(Token = "0x6000191")]
	internal InstanceCuller get_culler() { }

	[Address(RVA = "0x29D6320", Offset = "0x29D5720", Length = "0xE")]
	[Token(Token = "0x600018F")]
	public NativeParallelHashMap<EntityId, GPUDrivenPackedMaterialData> get_packedMaterialHash() { }

	[Address(RVA = "0x2CE5420", Offset = "0x2CE4820", Length = "0x2A8")]
	[Token(Token = "0x6000193")]
	private BatchID GetBatchID(InstanceComponentGroup componentsOverriden) { }

	[Address(RVA = "0x2CE56D0", Offset = "0x2CE4AD0", Length = "0x31")]
	[Token(Token = "0x60001A2")]
	public ParallelBitArray GetCompactedVisibilityMasks(bool syncCullingJobs) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000195")]
	public CPUDrawInstanceData GetDrawInstanceData() { }

	[Address(RVA = "0x2CE5710", Offset = "0x2CE4B10", Length = "0x1F")]
	[Token(Token = "0x60001A0")]
	public void InstanceOccludersUpdated(int viewInstanceID, int subviewMask) { }

	[Address(RVA = "0x2CE5730", Offset = "0x2CE4B30", Length = "0xC")]
	[Token(Token = "0x60001A4")]
	public void OnBeginCameraRendering(Camera camera) { }

	[Address(RVA = "0x2CE5730", Offset = "0x2CE4B30", Length = "0xC")]
	[Token(Token = "0x60001A5")]
	public void OnEndCameraRendering(Camera camera) { }

	[Address(RVA = "0x2CE5740", Offset = "0x2CE4B40", Length = "0x6C")]
	[Token(Token = "0x60001A3")]
	public void OnEndContextRendering() { }

	[Address(RVA = "0x2CE57B0", Offset = "0x2CE4BB0", Length = "0x29")]
	[Token(Token = "0x6000197")]
	public void OnFinishedCulling(IntPtr customCullingResult) { }

	[Address(RVA = "0x2CE57E0", Offset = "0x2CE4BE0", Length = "0x5C6")]
	[Token(Token = "0x6000196")]
	public JobHandle OnPerformCulling(BatchRendererGroup rendererGroup, BatchCullingContext cc, BatchCullingOutput cullingOutput, IntPtr userContext) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600019B")]
	public void PostCullBeginCameraRendering(RenderRequestBatcherContext context) { }

	[Address(RVA = "0x2CE5DB0", Offset = "0x2CE51B0", Length = "0x5FF")]
	[Token(Token = "0x600019D")]
	private void RegisterBatchMaterials(in NativeArray<EntityId>& usedMaterialIDs, in NativeArray<GPUDrivenPackedMaterialData>& usedPackedMaterialDatas) { }

	[Address(RVA = "0x2CE63B0", Offset = "0x2CE57B0", Length = "0x46A")]
	[Token(Token = "0x600019C")]
	private void RegisterBatchMeshes(NativeArray<EntityId> meshIDs) { }

	[Address(RVA = "0x2CE6820", Offset = "0x2CE5C20", Length = "0xFA")]
	[Token(Token = "0x600019E")]
	public JobHandle SchedulePackedMaterialCacheUpdate(NativeArray<EntityId> materialIDs, NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas) { }

	[Address(RVA = "0x2CE6920", Offset = "0x2CE5D20", Length = "0x31")]
	[Token(Token = "0x60001A1")]
	public void UpdateFrame() { }

	[Address(RVA = "0x2CE6960", Offset = "0x2CE5D60", Length = "0x2E5")]
	[Token(Token = "0x6000194")]
	private void UpdateInstanceDataBufferLayoutVersion() { }

}

