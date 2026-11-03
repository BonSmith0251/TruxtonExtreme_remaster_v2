namespace UnityEngine.Rendering;

[Token(Token = "0x20000E3")]
internal class RenderersBatchersContext : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000411")]
	private InstanceDataSystem m_InstanceDataSystem; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000412")]
	private GPUResidentDrawerResources m_Resources; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000413")]
	private GPUDrivenProcessor m_GPUDrivenProcessor; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000414")]
	private LODGroupDataPool m_LODGroupDataPool; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000415")]
	internal GPUInstanceDataBuffer m_InstanceDataBuffer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000416")]
	private RenderersParameters m_RenderersParameters; //Field offset: 0x38
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000417")]
	private GPUResources m_UploadResources; //Field offset: 0xA8
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000418")]
	private GPUResources m_GrowerResources; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000419")]
	internal CommandBuffer m_CmdBuffer; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400041A")]
	private SphericalHarmonicsL2 m_CachedAmbientProbe; //Field offset: 0x100
	[FieldOffset(Offset = "0x16C")]
	[Token(Token = "0x400041B")]
	private float m_SmallMeshScreenPercentage; //Field offset: 0x16C
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x400041C")]
	private GPUDrivenLODGroupDataCallback m_UpdateLODGroupCallback; //Field offset: 0x170
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x400041D")]
	private GPUDrivenLODGroupDataCallback m_TransformLODGroupCallback; //Field offset: 0x178
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x400041E")]
	private OcclusionCullingCommon m_OcclusionCullingCommon; //Field offset: 0x180
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x400041F")]
	private DebugRendererBatcherStats m_DebugStats; //Field offset: 0x188

	[Token(Token = "0x17000062")]
	public int activeLodGroupCount
	{
		[Address(RVA = "0x2D01660", Offset = "0x2D00A60", Length = "0x56")]
		[Token(Token = "0x6000381")]
		 get { } //Length: 86
	}

	[Token(Token = "0x1700006F")]
	public NativeArray<InstanceHandle> aliveInstances
	{
		[Address(RVA = "0x2D016C0", Offset = "0x2D00AC0", Length = "0x33")]
		[Token(Token = "0x600038E")]
		 get { } //Length: 51
	}

	[Token(Token = "0x17000068")]
	public SphericalHarmonicsL2 cachedAmbientProbe
	{
		[Address(RVA = "0x2D01700", Offset = "0x2D00B00", Length = "0x5B")]
		[Token(Token = "0x6000387")]
		 get { } //Length: 91
	}

	[Token(Token = "0x1700006A")]
	public int cameraCount
	{
		[Address(RVA = "0x2D01760", Offset = "0x2D00B60", Length = "0x1D")]
		[Token(Token = "0x6000389")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000073")]
	internal DebugRendererBatcherStats debugStats
	{
		[Address(RVA = "0x22EAA80", Offset = "0x22E9E80", Length = "0x8")]
		[Token(Token = "0x6000392")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000063")]
	public ReadOnly<GPUInstanceComponentDesc> defaultDescriptions
	{
		[Address(RVA = "0x2D01780", Offset = "0x2D00B80", Length = "0x65")]
		[Token(Token = "0x6000382")]
		 get { } //Length: 101
	}

	[Token(Token = "0x17000064")]
	public NativeArray<MetadataValue> defaultMetadata
	{
		[Address(RVA = "0x2D017F0", Offset = "0x2D00BF0", Length = "0x24")]
		[Token(Token = "0x6000383")]
		 get { } //Length: 36
	}

	[Token(Token = "0x17000061")]
	public GraphicsBuffer gpuInstanceDataBuffer
	{
		[Address(RVA = "0x2D01820", Offset = "0x2D00C20", Length = "0x1B")]
		[Token(Token = "0x6000380")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000069")]
	public bool hasBoundingSpheres
	{
		[Address(RVA = "0x2D01840", Offset = "0x2D00C40", Length = "0x1E")]
		[Token(Token = "0x6000388")]
		 get { } //Length: 30
	}

	[Token(Token = "0x1700006B")]
	public ReadOnly instanceData
	{
		[Address(RVA = "0x2D018C0", Offset = "0x2D00CC0", Length = "0xB6")]
		[Token(Token = "0x600038A")]
		 get { } //Length: 182
	}

	[Token(Token = "0x1700006E")]
	public ReadOnly instanceDataBuffer
	{
		[Address(RVA = "0x2D01880", Offset = "0x2D00C80", Length = "0x33")]
		[Token(Token = "0x600038D")]
		 get { } //Length: 51
	}

	[Token(Token = "0x17000067")]
	public int instanceDataBufferLayoutVersion
	{
		[Address(RVA = "0x2D01860", Offset = "0x2D00C60", Length = "0x1A")]
		[Token(Token = "0x6000386")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000066")]
	public int instanceDataBufferVersion
	{
		[Address(RVA = "0x25253C0", Offset = "0x25247C0", Length = "0x1A")]
		[Token(Token = "0x6000385")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000065")]
	public NativeList<LODGroupCullingData> lodGroupCullingData
	{
		[Address(RVA = "0x21B3940", Offset = "0x21B2D40", Length = "0x1B")]
		[Token(Token = "0x6000384")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000072")]
	internal OcclusionCullingCommon occlusionCullingCommon
	{
		[Address(RVA = "0x291FDC0", Offset = "0x291F1C0", Length = "0x8")]
		[Token(Token = "0x6000391")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700006D")]
	public CPUPerCameraInstanceData perCameraInstanceData
	{
		[Address(RVA = "0x2D01980", Offset = "0x2D00D80", Length = "0x2F")]
		[Token(Token = "0x600038C")]
		 get { } //Length: 47
	}

	[Token(Token = "0x17000060")]
	public RenderersParameters renderersParameters
	{
		[Address(RVA = "0x2D019B0", Offset = "0x2D00DB0", Length = "0x41")]
		[Token(Token = "0x600037F")]
		 get { } //Length: 65
	}

	[Token(Token = "0x17000071")]
	public GPUResidentDrawerResources resources
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000390")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700006C")]
	public ReadOnly sharedInstanceData
	{
		[Address(RVA = "0x2D01A00", Offset = "0x2D00E00", Length = "0x9F")]
		[Token(Token = "0x600038B")]
		 get { } //Length: 159
	}

	[Token(Token = "0x17000070")]
	public float smallMeshScreenPercentage
	{
		[Address(RVA = "0x2D01AA0", Offset = "0x2D00EA0", Length = "0x9")]
		[Token(Token = "0x600038F")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2D01100", Offset = "0x2D00500", Length = "0x558")]
	[Token(Token = "0x6000393")]
	public RenderersBatchersContext(in RenderersBatchersContextDesc desc, GPUDrivenProcessor gpuDrivenProcessor, GPUResidentDrawerResources resources) { }

	[Address(RVA = "0x2CFFE30", Offset = "0x2CFF230", Length = "0x1A")]
	[Token(Token = "0x60003A5")]
	public void ChangeInstanceBufferVersion() { }

	[Address(RVA = "0x2CFFE50", Offset = "0x2CFF250", Length = "0x4E")]
	[Token(Token = "0x60003A6")]
	public GPUInstanceDataBufferUploader CreateDataBufferUploader(int capacity, InstanceType instanceType) { }

	[Address(RVA = "0x2CFFEA0", Offset = "0x2CFF2A0", Length = "0x57")]
	[Token(Token = "0x600039B")]
	public void DestroyLODGroups(NativeArray<EntityId> destroyed) { }

	[Address(RVA = "0x2CFFF00", Offset = "0x2CFF300", Length = "0x29D")]
	[Token(Token = "0x6000394")]
	public override void Dispose() { }

	[Address(RVA = "0x2D001A0", Offset = "0x2CFF5A0", Length = "0xAA")]
	[Token(Token = "0x6000398")]
	private void EnsureInstanceBufferCapacity() { }

	[Address(RVA = "0x2D00250", Offset = "0x2CFF650", Length = "0x2C")]
	[Token(Token = "0x60003A0")]
	public void FreeInstances(NativeArray<InstanceHandle> instances) { }

	[Address(RVA = "0x2D00280", Offset = "0x2CFF680", Length = "0x2C")]
	[Token(Token = "0x60003B5")]
	public void FreePerCameraInstanceData(NativeArray<EntityId> cameraIDs) { }

	[Address(RVA = "0x2D002B0", Offset = "0x2CFF6B0", Length = "0x2C")]
	[Token(Token = "0x600039F")]
	public void FreeRendererGroupInstances(NativeArray<EntityId> rendererGroupsID) { }

	[Address(RVA = "0x2D01660", Offset = "0x2D00A60", Length = "0x56")]
	[Token(Token = "0x6000381")]
	public int get_activeLodGroupCount() { }

	[Address(RVA = "0x2D016C0", Offset = "0x2D00AC0", Length = "0x33")]
	[Token(Token = "0x600038E")]
	public NativeArray<InstanceHandle> get_aliveInstances() { }

	[Address(RVA = "0x2D01700", Offset = "0x2D00B00", Length = "0x5B")]
	[Token(Token = "0x6000387")]
	public SphericalHarmonicsL2 get_cachedAmbientProbe() { }

	[Address(RVA = "0x2D01760", Offset = "0x2D00B60", Length = "0x1D")]
	[Token(Token = "0x6000389")]
	public int get_cameraCount() { }

	[Address(RVA = "0x22EAA80", Offset = "0x22E9E80", Length = "0x8")]
	[Token(Token = "0x6000392")]
	internal DebugRendererBatcherStats get_debugStats() { }

	[Address(RVA = "0x2D01780", Offset = "0x2D00B80", Length = "0x65")]
	[Token(Token = "0x6000382")]
	public ReadOnly<GPUInstanceComponentDesc> get_defaultDescriptions() { }

	[Address(RVA = "0x2D017F0", Offset = "0x2D00BF0", Length = "0x24")]
	[Token(Token = "0x6000383")]
	public NativeArray<MetadataValue> get_defaultMetadata() { }

	[Address(RVA = "0x2D01820", Offset = "0x2D00C20", Length = "0x1B")]
	[Token(Token = "0x6000380")]
	public GraphicsBuffer get_gpuInstanceDataBuffer() { }

	[Address(RVA = "0x2D01840", Offset = "0x2D00C40", Length = "0x1E")]
	[Token(Token = "0x6000388")]
	public bool get_hasBoundingSpheres() { }

	[Address(RVA = "0x2D018C0", Offset = "0x2D00CC0", Length = "0xB6")]
	[Token(Token = "0x600038A")]
	public ReadOnly get_instanceData() { }

	[Address(RVA = "0x2D01880", Offset = "0x2D00C80", Length = "0x33")]
	[Token(Token = "0x600038D")]
	public ReadOnly get_instanceDataBuffer() { }

	[Address(RVA = "0x2D01860", Offset = "0x2D00C60", Length = "0x1A")]
	[Token(Token = "0x6000386")]
	public int get_instanceDataBufferLayoutVersion() { }

	[Address(RVA = "0x25253C0", Offset = "0x25247C0", Length = "0x1A")]
	[Token(Token = "0x6000385")]
	public int get_instanceDataBufferVersion() { }

	[Address(RVA = "0x21B3940", Offset = "0x21B2D40", Length = "0x1B")]
	[Token(Token = "0x6000384")]
	public NativeList<LODGroupCullingData> get_lodGroupCullingData() { }

	[Address(RVA = "0x291FDC0", Offset = "0x291F1C0", Length = "0x8")]
	[Token(Token = "0x6000391")]
	internal OcclusionCullingCommon get_occlusionCullingCommon() { }

	[Address(RVA = "0x2D01980", Offset = "0x2D00D80", Length = "0x2F")]
	[Token(Token = "0x600038C")]
	public CPUPerCameraInstanceData get_perCameraInstanceData() { }

	[Address(RVA = "0x2D019B0", Offset = "0x2D00DB0", Length = "0x41")]
	[Token(Token = "0x600037F")]
	public RenderersParameters get_renderersParameters() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000390")]
	public GPUResidentDrawerResources get_resources() { }

	[Address(RVA = "0x2D01A00", Offset = "0x2D00E00", Length = "0x9F")]
	[Token(Token = "0x600038B")]
	public ReadOnly get_sharedInstanceData() { }

	[Address(RVA = "0x2D01AA0", Offset = "0x2D00EA0", Length = "0x9")]
	[Token(Token = "0x600038F")]
	public float get_smallMeshScreenPercentage() { }

	[Address(RVA = "0x2D002E0", Offset = "0x2CFF6E0", Length = "0x1E")]
	[Token(Token = "0x6000396")]
	public int GetAliveInstancesOfType(InstanceType instanceType) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60003B3")]
	public GPUInstanceDataBuffer GetInstanceDataBuffer() { }

	[Address(RVA = "0x2D00300", Offset = "0x2CFF700", Length = "0x1E")]
	[Token(Token = "0x6000395")]
	public int GetMaxInstancesOfType(InstanceType instanceType) { }

	[Address(RVA = "0x2D00320", Offset = "0x2CFF720", Length = "0x14E")]
	[Token(Token = "0x60003B1")]
	public InstanceHandle GetRendererInstanceHandle(EntityId rendererID) { }

	[Address(RVA = "0x2D00470", Offset = "0x2CFF870", Length = "0x30")]
	[Token(Token = "0x60003B2")]
	public void GetVisibleTreeInstances(in ParallelBitArray compactedVisibilityMasks, in ParallelBitArray processedBits, NativeList<Int32> visibeTreeRendererIDs, NativeList<InstanceHandle> visibeTreeInstances, bool becomeVisibleOnly, out int becomeVisibeTreeInstancesCount) { }

	[Address(RVA = "0x2D004B0", Offset = "0x2CFF8B0", Length = "0x179")]
	[Token(Token = "0x6000397")]
	public void GrowInstanceBuffer(in InstanceNumInfo instanceNumInfo) { }

	[Address(RVA = "0x2D00630", Offset = "0x2CFFA30", Length = "0x78")]
	[Token(Token = "0x60003A9")]
	public void InitializeInstanceTransforms(NativeArray<InstanceHandle> instances, NativeArray<Matrix4x4> localToWorldMatrices, NativeArray<Matrix4x4> prevLocalToWorldMatrices) { }

	[Address(RVA = "0x2D006B0", Offset = "0x2CFFAB0", Length = "0xD4")]
	[Token(Token = "0x600039D")]
	public void ReallocateAndGetInstances(in GPUDrivenRendererGroupData rendererData, NativeArray<InstanceHandle> instances) { }

	[Address(RVA = "0x2D00790", Offset = "0x2CFFB90", Length = "0x55")]
	[Token(Token = "0x60003B0")]
	public JobHandle ScheduleCollectInstancesLODGroupAndMasksJob(NativeArray<InstanceHandle> instances, NativeArray<UInt32> lodGroupAndMasks) { }

	[Address(RVA = "0x2D007F0", Offset = "0x2CFFBF0", Length = "0x47")]
	[Token(Token = "0x60003A4")]
	public JobHandle ScheduleQueryMeshInstancesJob(NativeArray<EntityId> sortedMeshIDs, NativeList<InstanceHandle> instances) { }

	[Address(RVA = "0x2D00840", Offset = "0x2CFFC40", Length = "0x55")]
	[Token(Token = "0x60003A1")]
	public JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<EntityId> rendererGroupIDs, NativeArray<InstanceHandle> instances) { }

	[Address(RVA = "0x2D008A0", Offset = "0x2CFFCA0", Length = "0x47")]
	[Token(Token = "0x60003A2")]
	public JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<EntityId> rendererGroupIDs, NativeList<InstanceHandle> instances) { }

	[Address(RVA = "0x2D008F0", Offset = "0x2CFFCF0", Length = "0x7D")]
	[Token(Token = "0x60003A3")]
	public JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<EntityId> rendererGroupIDs, NativeArray<Int32> instancesOffset, NativeArray<Int32> instancesCount, NativeList<InstanceHandle> instances) { }

	[Address(RVA = "0x2D00970", Offset = "0x2CFFD70", Length = "0x63")]
	[Token(Token = "0x600039E")]
	public JobHandle ScheduleUpdateInstanceDataJob(NativeArray<InstanceHandle> instances, in GPUDrivenRendererGroupData rendererData) { }

	[Address(RVA = "0x2D00A20", Offset = "0x2CFFE20", Length = "0x3D")]
	[Token(Token = "0x60003A7")]
	public void SubmitToGpu(NativeArray<InstanceHandle> instances, ref GPUInstanceDataBufferUploader uploader, bool submitOnlyWrittenParams) { }

	[Address(RVA = "0x2D009E0", Offset = "0x2CFFDE0", Length = "0x3D")]
	[Token(Token = "0x60003A8")]
	public void SubmitToGpu(NativeArray<GPUInstanceIndex> gpuInstanceIndices, ref GPUInstanceDataBufferUploader uploader, bool submitOnlyWrittenParams) { }

	[Address(RVA = "0x2D00A60", Offset = "0x2CFFE60", Length = "0x13B")]
	[Token(Token = "0x600039A")]
	private void TransformLODGroupData(in GPUDrivenLODGroupData lodGroupData) { }

	[Address(RVA = "0x2D00BA0", Offset = "0x2CFFFA0", Length = "0x8B")]
	[Token(Token = "0x60003AE")]
	public void TransformLODGroups(NativeArray<EntityId> lodGroupsID) { }

	[Address(RVA = "0x2D00C30", Offset = "0x2D00030", Length = "0x21A")]
	[Token(Token = "0x60003AB")]
	public void UpdateAmbientProbeAndGpuBuffer(bool forceUpdate) { }

	[Address(RVA = "0x2D00E50", Offset = "0x2D00250", Length = "0x2C")]
	[Token(Token = "0x60003B6")]
	public void UpdateCameras(NativeArray<EntityId> cameraIDs) { }

	[Address(RVA = "0x2D00E80", Offset = "0x2D00280", Length = "0x51")]
	[Token(Token = "0x60003B4")]
	public void UpdateFrame() { }

	[Address(RVA = "0x2D00EE0", Offset = "0x2D002E0", Length = "0x39")]
	[Token(Token = "0x60003AD")]
	public void UpdateInstanceMotions() { }

	[Address(RVA = "0x2D00F20", Offset = "0x2D00320", Length = "0x65")]
	[Token(Token = "0x60003AA")]
	public void UpdateInstanceTransforms(NativeArray<InstanceHandle> instances, NativeArray<Matrix4x4> localToWorldMatrices) { }

	[Address(RVA = "0x2D00F90", Offset = "0x2D00390", Length = "0x98")]
	[Token(Token = "0x60003AC")]
	public void UpdateInstanceWindDataHistory(NativeArray<GPUInstanceIndex> gpuInstanceIndices) { }

	[Address(RVA = "0x2D01030", Offset = "0x2D00430", Length = "0x1E")]
	[Token(Token = "0x6000399")]
	private void UpdateLODGroupData(in GPUDrivenLODGroupData lodGroupData) { }

	[Address(RVA = "0x2D01050", Offset = "0x2D00450", Length = "0x8B")]
	[Token(Token = "0x600039C")]
	public void UpdateLODGroups(NativeArray<EntityId> changedID) { }

	[Address(RVA = "0x2D010E0", Offset = "0x2D004E0", Length = "0x1E")]
	[Token(Token = "0x60003AF")]
	public void UpdatePerFrameInstanceVisibility(in ParallelBitArray compactedVisibilityMasks) { }

}

