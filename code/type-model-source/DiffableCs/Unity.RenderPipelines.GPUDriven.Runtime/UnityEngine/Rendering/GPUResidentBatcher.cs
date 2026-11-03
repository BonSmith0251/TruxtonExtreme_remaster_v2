namespace UnityEngine.Rendering;

[Token(Token = "0x200001C")]
internal class GPUResidentBatcher : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400004C")]
	private RenderersBatchersContext m_BatchersContext; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400004D")]
	private GPUDrivenProcessor m_GPUDrivenProcessor; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400004E")]
	private GPUDrivenRendererDataCallback m_UpdateRendererInstancesAndBatchesCallback; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400004F")]
	private GPUDrivenRendererDataCallback m_UpdateRendererBatchesCallback; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000050")]
	private InstanceCullingBatcher m_InstanceCullingBatcher; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000051")]
	private ParallelBitArray m_ProcessedThisFrameTreeBits; //Field offset: 0x38

	[Token(Token = "0x1700000D")]
	internal RenderersBatchersContext batchersContext
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000097")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700000F")]
	internal InstanceCullingBatcher instanceCullingBatcher
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000099")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700000E")]
	internal OcclusionCullingCommon occlusionCullingCommon
	{
		[Address(RVA = "0x2CC91D0", Offset = "0x2CC85D0", Length = "0x1E")]
		[Token(Token = "0x6000098")]
		internal get { } //Length: 30
	}

	[Address(RVA = "0x2CC9040", Offset = "0x2CC8440", Length = "0x187")]
	[Token(Token = "0x600009A")]
	public GPUResidentBatcher(RenderersBatchersContext batcherContext, InstanceCullingBatcherDesc instanceCullerBatcherDesc, GPUDrivenProcessor gpuDrivenProcessor) { }

	[Address(RVA = "0x2CC7E70", Offset = "0x2CC7270", Length = "0x2C")]
	[Token(Token = "0x60000A2")]
	public void DestroyDrawInstances(NativeArray<InstanceHandle> instances) { }

	[Address(RVA = "0x2CC7EA0", Offset = "0x2CC72A0", Length = "0x2C")]
	[Token(Token = "0x60000A1")]
	public void DestroyMaterials(NativeArray<EntityId> destroyedMaterials) { }

	[Address(RVA = "0x2CC7ED0", Offset = "0x2CC72D0", Length = "0x2C")]
	[Token(Token = "0x60000A3")]
	public void DestroyMeshes(NativeArray<EntityId> destroyedMeshes) { }

	[Address(RVA = "0x2CC7F00", Offset = "0x2CC7300", Length = "0x53")]
	[Token(Token = "0x600009B")]
	public override void Dispose() { }

	[Address(RVA = "0x2CC7F60", Offset = "0x2CC7360", Length = "0x13E")]
	[Token(Token = "0x60000A4")]
	internal void FreeRendererGroupInstances(NativeArray<EntityId> rendererGroupIDs) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000097")]
	internal RenderersBatchersContext get_batchersContext() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000099")]
	internal InstanceCullingBatcher get_instanceCullingBatcher() { }

	[Address(RVA = "0x2CC91D0", Offset = "0x2CC85D0", Length = "0x1E")]
	[Token(Token = "0x6000098")]
	internal OcclusionCullingCommon get_occlusionCullingCommon() { }

	[Address(RVA = "0x2CC80A0", Offset = "0x2CC74A0", Length = "0x8B")]
	[Token(Token = "0x60000A5")]
	public void InstanceOcclusionTest(RenderGraph renderGraph, in OcclusionCullingSettings settings, ReadOnlySpan<SubviewOcclusionTest> subviewOcclusionTests) { }

	[Address(RVA = "0x2CC8130", Offset = "0x2CC7530", Length = "0x12")]
	[Token(Token = "0x600009E")]
	public void OnBeginCameraRendering(Camera camera) { }

	[Address(RVA = "0x2CC8150", Offset = "0x2CC7550", Length = "0x2E")]
	[Token(Token = "0x600009C")]
	public void OnBeginContextRendering() { }

	[Address(RVA = "0x2CC8130", Offset = "0x2CC7530", Length = "0x12")]
	[Token(Token = "0x600009F")]
	public void OnEndCameraRendering(Camera camera) { }

	[Address(RVA = "0x2CC8180", Offset = "0x2CC7580", Length = "0x11")]
	[Token(Token = "0x600009D")]
	public void OnEndContextRendering() { }

	[Address(RVA = "0x2CC81A0", Offset = "0x2CC75A0", Length = "0x3A")]
	[Token(Token = "0x60000AD")]
	private void OnFinishedCulling(IntPtr customCullingResult) { }

	[Address(RVA = "0x2CC81E0", Offset = "0x2CC75E0", Length = "0x20")]
	[Token(Token = "0x60000AA")]
	public void OnSetupAmbientProbe() { }

	[Address(RVA = "0x2CC8210", Offset = "0x2CC7610", Length = "0x1E")]
	[Token(Token = "0x60000A9")]
	public void PostCullBeginCameraRendering(RenderRequestBatcherContext context) { }

	[Address(RVA = "0x2CC8230", Offset = "0x2CC7630", Length = "0x39B")]
	[Token(Token = "0x60000AE")]
	private void ProcessTrees() { }

	[Address(RVA = "0x2CC85D0", Offset = "0x2CC79D0", Length = "0x55")]
	[Token(Token = "0x60000A8")]
	public JobHandle SchedulePackedMaterialCacheUpdate(NativeArray<EntityId> materialIDs, NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas) { }

	[Address(RVA = "0x2CC8630", Offset = "0x2CC7A30", Length = "0x33")]
	[Token(Token = "0x60000A0")]
	public void UpdateFrame() { }

	[Address(RVA = "0x2CC8670", Offset = "0x2CC7A70", Length = "0x84")]
	[Token(Token = "0x60000A6")]
	public void UpdateInstanceOccluders(RenderGraph renderGraph, in OccluderParameters occluderParams, ReadOnlySpan<OccluderSubviewUpdate> occluderSubviewUpdates) { }

	[Address(RVA = "0x2CC8700", Offset = "0x2CC7B00", Length = "0x158")]
	[Token(Token = "0x60000AC")]
	private void UpdateRendererBatches(in GPUDrivenRendererGroupData rendererData, IList<Mesh> meshes, IList<Material> materials) { }

	[Address(RVA = "0x2CC8860", Offset = "0x2CC7C60", Length = "0x38D")]
	[Token(Token = "0x60000AB")]
	private void UpdateRendererInstancesAndBatches(in GPUDrivenRendererGroupData rendererData, IList<Mesh> meshes, IList<Material> materials) { }

	[Address(RVA = "0x2CC8BF0", Offset = "0x2CC7FF0", Length = "0xC7")]
	[Token(Token = "0x60000A7")]
	public void UpdateRenderers(NativeArray<EntityId> renderersID, bool materialUpdateOnly = false) { }

	[Address(RVA = "0x2CC8CC0", Offset = "0x2CC80C0", Length = "0x378")]
	[Token(Token = "0x60000AF")]
	private void UpdateSpeedTreeWindAndUploadWindParamsToGPU(NativeArray<Int32> treeRendererIDs, NativeArray<InstanceHandle> treeInstances, bool history) { }

}

