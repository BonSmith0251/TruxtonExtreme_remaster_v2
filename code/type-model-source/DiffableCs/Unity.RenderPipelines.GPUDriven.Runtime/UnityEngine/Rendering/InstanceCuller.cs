namespace UnityEngine.Rendering;

[Token(Token = "0x200004C")]
internal struct InstanceCuller : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000050")]
	private sealed class <>c
	{
		[Token(Token = "0x4000171")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000172")]
		public static BaseRenderFunc<InstanceOcclusionTestPassData, ComputeGraphContext> <>9__28_0; //Field offset: 0x8

		[Address(RVA = "0x2CF0C10", Offset = "0x2CF0010", Length = "0x67")]
		[Token(Token = "0x6000162")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000163")]
		public <>c() { }

		[Address(RVA = "0x2CF0B60", Offset = "0x2CEFF60", Length = "0xA7")]
		[Token(Token = "0x6000164")]
		internal void <InstanceOcclusionTest>b__28_0(InstanceOcclusionTestPassData data, ComputeGraphContext context) { }

	}

	[Token(Token = "0x200004D")]
	private struct AnimatedFadeData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000162")]
		public int cameraID; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000163")]
		public JobHandle jobHandle; //Field offset: 0x8

	}

	[Token(Token = "0x200004F")]
	private class InstanceOcclusionTestPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400016D")]
		public OcclusionCullingSettings settings; //Field offset: 0x10
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400016E")]
		public InstanceOcclusionTestSubviewSettings subviewSettings; //Field offset: 0x1C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400016F")]
		public OccluderHandles occluderHandles; //Field offset: 0x30
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4000170")]
		public IndirectBufferContextHandles bufferHandles; //Field offset: 0x4C

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000161")]
		public InstanceOcclusionTestPassData() { }

	}

	[Token(Token = "0x200004E")]
	private static class ShaderIDs
	{
		[Token(Token = "0x4000164")]
		public static readonly int InstanceOcclusionCullerShaderVariables; //Field offset: 0x0
		[Token(Token = "0x4000165")]
		public static readonly int _DrawInfo; //Field offset: 0x4
		[Token(Token = "0x4000166")]
		public static readonly int _InstanceInfo; //Field offset: 0x8
		[Token(Token = "0x4000167")]
		public static readonly int _DispatchArgs; //Field offset: 0xC
		[Token(Token = "0x4000168")]
		public static readonly int _DrawArgs; //Field offset: 0x10
		[Token(Token = "0x4000169")]
		public static readonly int _InstanceIndices; //Field offset: 0x14
		[Token(Token = "0x400016A")]
		public static readonly int _InstanceDataBuffer; //Field offset: 0x18
		[Token(Token = "0x400016B")]
		public static readonly int _OccluderDepthPyramid; //Field offset: 0x1C
		[Token(Token = "0x400016C")]
		public static readonly int _OcclusionDebugCounters; //Field offset: 0x20

		[Address(RVA = "0x2CF04B0", Offset = "0x2CEF8B0", Length = "0x1A7")]
		[Token(Token = "0x6000160")]
		private static ShaderIDs() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000153")]
	private NativeParallelHashMap<Int32, AnimatedFadeData> m_LODParamsToCameraID; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000154")]
	private ParallelBitArray m_CompactedVisibilityMasks; //Field offset: 0x10
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000155")]
	private JobHandle m_CompactedVisibilityMasksJobsHandle; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000156")]
	private IndirectBufferContextStorage m_IndirectStorage; //Field offset: 0x40
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000157")]
	private OcclusionTestComputeShader m_OcclusionTestShader; //Field offset: 0xC8
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000158")]
	private int m_ResetDrawArgsKernel; //Field offset: 0xE8
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x4000159")]
	private int m_CopyInstancesKernel; //Field offset: 0xEC
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400015A")]
	private int m_CullInstancesKernel; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400015B")]
	private DebugRendererBatcherStats m_DebugStats; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400015C")]
	private InstanceCullerSplitDebugArray m_SplitDebugArray; //Field offset: 0x100
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400015D")]
	private InstanceOcclusionEventDebugArray m_OcclusionEventDebugArray; //Field offset: 0x120
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x400015E")]
	private ProfilingSampler m_ProfilingSampleInstanceOcclusionTest; //Field offset: 0x178
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x400015F")]
	private NativeArray<InstanceOcclusionCullerShaderVariables> m_ShaderVariables; //Field offset: 0x180
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000160")]
	private ComputeBuffer m_ConstantBuffer; //Field offset: 0x190
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000161")]
	private CommandBuffer m_CommandBuffer; //Field offset: 0x198

	[Address(RVA = "0x2CCF320", Offset = "0x2CCE720", Length = "0xC65")]
	[Token(Token = "0x6000158")]
	private void AddOcclusionCullingDispatch(ComputeCommandBuffer cmd, in OcclusionCullingSettings settings, in InstanceOcclusionTestSubviewSettings subviewSettings, in IndirectBufferContextHandles bufferHandles, in OccluderHandles occluderHandles, RenderersBatchersContext batchersContext) { }

	[Address(RVA = "0x2CCFF90", Offset = "0x2CCF390", Length = "0x440")]
	[Token(Token = "0x600014D")]
	private JobHandle AnimateCrossFades(CPUPerCameraInstanceData perCameraInstanceData, BatchCullingContext cc, out PerCameraInstanceDataArrays cameraInstanceData, out bool hasAnimatedCrossfade) { }

	[Address(RVA = "0x2CD03D0", Offset = "0x2CCF7D0", Length = "0xD2")]
	[Token(Token = "0x600014F")]
	private int ComputeWorstCaseDrawCommandCount(in BatchCullingContext cc, BinningConfig binningConfig, CPUDrawInstanceData drawInstanceData) { }

	[Address(RVA = "0x2CD04B0", Offset = "0x2CCF8B0", Length = "0x15B")]
	[Token(Token = "0x6000151")]
	private JobHandle CreateCompactedVisibilityMaskJob(in ReadOnly instanceData, NativeArray<Byte> rendererVisibilityMasks, JobHandle cullingJobHandle) { }

	[Address(RVA = "0x2CD0610", Offset = "0x2CCFA10", Length = "0xDBF")]
	[Token(Token = "0x6000150")]
	public JobHandle CreateCullJobTree(in BatchCullingContext cc, BatchCullingOutput cullingOutput, in ReadOnly instanceData, in ReadOnly sharedInstanceData, in CPUPerCameraInstanceData perCameraInstanceData, in ReadOnly instanceDataBuffer, NativeList<LODGroupCullingData> lodGroupCullingData, CPUDrawInstanceData drawInstanceData, NativeParallelHashMap<UInt32, BatchID> batchIDs, float smallMeshScreenPercentage, OcclusionCullingCommon occlusionCullingCommon) { }

	[Address(RVA = "0x2CD13D0", Offset = "0x2CD07D0", Length = "0x88C")]
	[Token(Token = "0x600014E")]
	private JobHandle CreateFrustumCullingJob(in BatchCullingContext cc, in ReadOnly instanceData, in ReadOnly sharedInstanceData, in CPUPerCameraInstanceData perCameraInstanceData, NativeList<LODGroupCullingData> lodGroupCullingData, in BinningConfig binningConfig, float smallMeshScreenPercentage, OcclusionCullingCommon occlusionCullingCommon, NativeArray<Byte> rendererVisibilityMasks, NativeArray<Byte> rendererMeshLodSettings, NativeArray<Byte> rendererCrossFadeValues) { }

	[Address(RVA = "0x2CD1C90", Offset = "0x2CD1090", Length = "0xDD")]
	[Token(Token = "0x600015F")]
	public override void Dispose() { }

	[Address(RVA = "0x2CD1C60", Offset = "0x2CD1060", Length = "0x2E")]
	[Token(Token = "0x6000153")]
	private void DisposeCompactVisibilityMasks() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000154")]
	private void DisposeSceneViewHiddenBits() { }

	[Address(RVA = "0x2CD1D70", Offset = "0x2CD1170", Length = "0x339")]
	[Token(Token = "0x6000157")]
	internal void EnsureValidOcclusionTestResults(int viewInstanceID) { }

	[Address(RVA = "0x2CD20B0", Offset = "0x2CD14B0", Length = "0x66")]
	[Token(Token = "0x6000159")]
	private void FlushDebugCounters() { }

	[Address(RVA = "0x2CD2120", Offset = "0x2CD1520", Length = "0x3D")]
	[Token(Token = "0x6000155")]
	public ParallelBitArray GetCompactedVisibilityMasks(bool syncCullingJobs) { }

	[Address(RVA = "0x2CD2160", Offset = "0x2CD1560", Length = "0x302")]
	[Token(Token = "0x600014C")]
	internal void Init(GPUResidentDrawerResources resources, DebugRendererBatcherStats debugStats = null) { }

	[Address(RVA = "0x2CD2470", Offset = "0x2CD1870", Length = "0xB5")]
	[Token(Token = "0x6000152")]
	public void InstanceOccludersUpdated(int viewInstanceID, int subviewMask, RenderersBatchersContext batchersContext) { }

	[Address(RVA = "0x2CD2530", Offset = "0x2CD1930", Length = "0x53F")]
	[Token(Token = "0x6000156")]
	public void InstanceOcclusionTest(RenderGraph renderGraph, in OcclusionCullingSettings settings, ReadOnlySpan<SubviewOcclusionTest> subviewOcclusionTests, RenderersBatchersContext batchersContext) { }

	[Address(RVA = "0x2CD2A70", Offset = "0x2CD1E70", Length = "0x20")]
	[Token(Token = "0x600015D")]
	public void OnBeginCameraRendering(Camera camera) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600015A")]
	private void OnBeginSceneViewCameraRendering() { }

	[Address(RVA = "0x2CD2A70", Offset = "0x2CD1E70", Length = "0x20")]
	[Token(Token = "0x600015E")]
	public void OnEndCameraRendering(Camera camera) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600015B")]
	private void OnEndSceneViewCameraRendering() { }

	[Address(RVA = "0x2CD2AA0", Offset = "0x2CD1EA0", Length = "0x10E")]
	[Token(Token = "0x600015C")]
	public void UpdateFrame(int cameraCount) { }

}

