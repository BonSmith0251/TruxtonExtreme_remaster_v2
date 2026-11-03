namespace UnityEngine.Rendering;

[Token(Token = "0x200001D")]
public class GPUResidentDrawer
{
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x200001E")]
	private struct FindRenderersFromMaterialOrMeshJob : IJobParallelForBatch
	{
		[Token(Token = "0x400005B")]
		public const int k_BatchSize = 128; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x400005C")]
		public ReadOnly<EntityId> materialIDs; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[ReadOnly]
		[Token(Token = "0x400005D")]
		public ReadOnly<SmallEntityIdArray> materialIDArrays; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[ReadOnly]
		[Token(Token = "0x400005E")]
		public ReadOnly<EntityId> meshIDs; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[ReadOnly]
		[Token(Token = "0x400005F")]
		public ReadOnly<EntityId> meshIDArray; //Field offset: 0x28
		[FieldOffset(Offset = "0x38")]
		[ReadOnly]
		[Token(Token = "0x4000060")]
		public ReadOnly<EntityId> rendererGroupIDs; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[ReadOnly]
		[Token(Token = "0x4000061")]
		public ReadOnly<EntityId> sortedExcludeRendererIDs; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000062")]
		[WriteOnly]
		public ParallelWriter<EntityId> selectedRenderGroupsForMaterials; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000063")]
		[WriteOnly]
		public ParallelWriter<EntityId> selectedRenderGroupsForMeshes; //Field offset: 0x60

		[Address(RVA = "0x2CC6790", Offset = "0x2CC5B90", Length = "0x361")]
		[Token(Token = "0x60000E8")]
		public override void Execute(int startIndex, int count) { }

	}

	[Token(Token = "0x200001F")]
	private static class Strings
	{
		[Token(Token = "0x4000064")]
		public static readonly string drawerModeDisabled; //Field offset: 0x0
		[Token(Token = "0x4000065")]
		public static readonly string allowInEditModeDisabled; //Field offset: 0x8
		[Token(Token = "0x4000066")]
		public static readonly string notGPUResidentRenderPipeline; //Field offset: 0x10
		[Token(Token = "0x4000067")]
		public static readonly string rawBufferNotSupportedByPlatform; //Field offset: 0x18
		[Token(Token = "0x4000068")]
		public static readonly string kernelNotPresent; //Field offset: 0x20
		[Token(Token = "0x4000069")]
		public static readonly string batchRendererGroupShaderStrippingModeInvalid; //Field offset: 0x28
		[Token(Token = "0x400006A")]
		public static readonly string visionOSNotSupported; //Field offset: 0x30

		[Address(RVA = "0x2CD7F70", Offset = "0x2CD7370", Length = "0x23E")]
		[Token(Token = "0x60000E9")]
		private static Strings() { }

	}

	[Token(Token = "0x4000052")]
	private static GPUResidentDrawer s_Instance; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x4000053")]
	private static bool <MaintainContext>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[Token(Token = "0x4000054")]
	private static bool <ForceOcclusion>k__BackingField; //Field offset: 0x9
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000055")]
	private IntPtr m_ContextIntPtr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000056")]
	private GPUResidentDrawerSettings m_Settings; //Field offset: 0x18
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000057")]
	private GPUDrivenProcessor m_GPUDrivenProcessor; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000058")]
	private RenderersBatchersContext m_BatchersContext; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000059")]
	private GPUResidentBatcher m_Batcher; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400005A")]
	private ObjectDispatcher m_Dispatcher; //Field offset: 0x48

	[Token(Token = "0x17000013")]
	internal GPUResidentBatcher batcher
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60000C7")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000012")]
	internal static bool ForceOcclusion
	{
		[Address(RVA = "0x2CCE3E0", Offset = "0x2CCD7E0", Length = "0x37")]
		[CompilerGenerated]
		[Token(Token = "0x60000C2")]
		internal get { } //Length: 55
		[Address(RVA = "0x2CCE4A0", Offset = "0x2CCD8A0", Length = "0x3C")]
		[CompilerGenerated]
		[Token(Token = "0x60000C3")]
		internal set { } //Length: 60
	}

	[Token(Token = "0x17000010")]
	internal static GPUResidentDrawer instance
	{
		[Address(RVA = "0x2CCE460", Offset = "0x2CCD860", Length = "0x36")]
		[Token(Token = "0x60000B0")]
		internal get { } //Length: 54
	}

	[Token(Token = "0x17000011")]
	internal static bool MaintainContext
	{
		[Address(RVA = "0x2CCE420", Offset = "0x2CCD820", Length = "0x37")]
		[CompilerGenerated]
		[Token(Token = "0x60000C0")]
		internal get { } //Length: 55
		[Address(RVA = "0x2CCE4E0", Offset = "0x2CCD8E0", Length = "0x3C")]
		[CompilerGenerated]
		[Token(Token = "0x60000C1")]
		internal set { } //Length: 60
	}

	[Token(Token = "0x17000014")]
	internal GPUResidentDrawerSettings settings
	{
		[Address(RVA = "0xABF730", Offset = "0xABEB30", Length = "0x15")]
		[Token(Token = "0x60000C8")]
		internal get { } //Length: 21
	}

	[Address(RVA = "0x2CCDDC0", Offset = "0x2CCD1C0", Length = "0x61B")]
	[Token(Token = "0x60000C9")]
	private GPUResidentDrawer(GPUResidentDrawerSettings settings, int maxInstanceCount, int maxTreeInstanceCount) { }

	[Address(RVA = "0x2CC9D90", Offset = "0x2CC9190", Length = "0x3E")]
	[Token(Token = "0x60000DB")]
	private InstanceHandle AppendNewInstance(int rendererGroupID, in Matrix4x4 instanceTransform) { }

	[Address(RVA = "0x2CC9DD0", Offset = "0x2CC91D0", Length = "0x19F")]
	[Token(Token = "0x60000E0")]
	private void ClassifyMaterials(NativeArray<EntityId> materials, out NativeList<EntityId>& unsupportedMaterials, out NativeList<EntityId>& supportedMaterials, out NativeList<GPUDrivenPackedMaterialData>& supportedPackedMaterialDatas, Allocator allocator) { }

	[Address(RVA = "0x2CC9F70", Offset = "0x2CC9370", Length = "0x71")]
	[Token(Token = "0x60000C5")]
	private static void CleanUp() { }

	[Address(RVA = "0x2CC9FF0", Offset = "0x2CC93F0", Length = "0x284")]
	[Token(Token = "0x60000CA")]
	private void Dispose() { }

	[Address(RVA = "0x2CCA280", Offset = "0x2CC9680", Length = "0x357")]
	[Token(Token = "0x60000E3")]
	private ValueTuple<NativeList`1<EntityId>, NativeList`1<EntityId>> FindRenderersFromMaterialsOrMeshes(NativeArray<EntityId> sortedExcludeRenderers, NativeHashSet<EntityId> materials, NativeArray<EntityId> meshes, Allocator rendererListAllocator) { }

	[Address(RVA = "0x2CCA5E0", Offset = "0x2CC99E0", Length = "0x1E9")]
	[Token(Token = "0x60000E1")]
	private NativeList<EntityId> FindUnsupportedRenderers(NativeArray<EntityId> unsupportedMaterials) { }

	[Address(RVA = "0x2CCA7D0", Offset = "0x2CC9BD0", Length = "0x65")]
	[Token(Token = "0x60000D9")]
	private void FreeInstances(NativeArray<InstanceHandle> instances) { }

	[Address(RVA = "0x2CCA840", Offset = "0x2CC9C40", Length = "0xC7")]
	[Token(Token = "0x60000DA")]
	private void FreeRendererGroupInstances(NativeArray<EntityId> rendererGroupIDs, NativeArray<EntityId> unsupportedRendererGroupIDs) { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60000C7")]
	internal GPUResidentBatcher get_batcher() { }

	[Address(RVA = "0x2CCE3E0", Offset = "0x2CCD7E0", Length = "0x37")]
	[CompilerGenerated]
	[Token(Token = "0x60000C2")]
	internal static bool get_ForceOcclusion() { }

	[Address(RVA = "0x2CCE460", Offset = "0x2CCD860", Length = "0x36")]
	[Token(Token = "0x60000B0")]
	internal static GPUResidentDrawer get_instance() { }

	[Address(RVA = "0x2CCE420", Offset = "0x2CCD820", Length = "0x37")]
	[CompilerGenerated]
	[Token(Token = "0x60000C0")]
	internal static bool get_MaintainContext() { }

	[Address(RVA = "0xABF730", Offset = "0xABEB30", Length = "0x15")]
	[Token(Token = "0x60000C8")]
	internal GPUResidentDrawerSettings get_settings() { }

	[Address(RVA = "0x2CCA910", Offset = "0x2CC9D10", Length = "0x55")]
	[Token(Token = "0x60000B9")]
	internal static DebugRendererBatcherStats GetDebugStats() { }

	[Address(RVA = "0x2CCA970", Offset = "0x2CC9D70", Length = "0x17E")]
	[Token(Token = "0x60000BD")]
	internal static GPUResidentDrawerSettings GetGlobalSettingsFromRPAsset() { }

	[Address(RVA = "0x2CCAAF0", Offset = "0x2CC9EF0", Length = "0x109")]
	[Token(Token = "0x60000E2")]
	private NativeHashSet<EntityId> GetMaterialsWithChangedPackedMaterial(NativeArray<EntityId> materials, NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas, Allocator allocator) { }

	[Address(RVA = "0x2CCAC00", Offset = "0x2CCA000", Length = "0x4FC")]
	[Token(Token = "0x60000BA")]
	private void InsertIntoPlayerLoop() { }

	[Address(RVA = "0x2CCB100", Offset = "0x2CCA500", Length = "0xC3")]
	[Token(Token = "0x60000B4")]
	public static void InstanceOcclusionTest(RenderGraph renderGraph, in OcclusionCullingSettings settings, ReadOnlySpan<SubviewOcclusionTest> subviewOcclusionTests) { }

	[Address(RVA = "0x2CCB1D0", Offset = "0x2CCA5D0", Length = "0x3A")]
	[Token(Token = "0x60000BC")]
	internal static bool IsEnabled() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60000BE")]
	internal static bool IsForcedOnViaCommandLine() { }

	[Address(RVA = "0x2CCB210", Offset = "0x2CCA610", Length = "0x1C1")]
	[Token(Token = "0x60000E6")]
	internal static bool IsGPUResidentDrawerSupportedBySRP(GPUResidentDrawerSettings settings, out string message, out LogType severity) { }

	[Address(RVA = "0x2CCB3E0", Offset = "0x2CCA7E0", Length = "0x6B")]
	[Token(Token = "0x60000B1")]
	public static bool IsInstanceOcclusionCullingEnabled() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60000BF")]
	internal static bool IsOcclusionForcedOnViaCommandLine() { }

	[Address(RVA = "0x2CCB580", Offset = "0x2CCA980", Length = "0x26")]
	[Token(Token = "0x60000E4")]
	internal static bool IsProjectSupported() { }

	[Address(RVA = "0x2CCB450", Offset = "0x2CCA850", Length = "0x122")]
	[Token(Token = "0x60000E5")]
	internal static bool IsProjectSupported(out string message, out LogType severity) { }

	[Address(RVA = "0x2CCB5B0", Offset = "0x2CCA9B0", Length = "0x96")]
	[Token(Token = "0x60000E7")]
	internal static void LogMessage(string message, LogType severity) { }

	[Address(RVA = "0x2CCB650", Offset = "0x2CCAA50", Length = "0x32")]
	[Token(Token = "0x60000CF")]
	private void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera) { }

	[Address(RVA = "0x2CCB690", Offset = "0x2CCAA90", Length = "0xA3")]
	[Token(Token = "0x60000CD")]
	private void OnBeginContextRendering(ScriptableRenderContext context, List<Camera> cameras) { }

	[Address(RVA = "0x2CCB650", Offset = "0x2CCAA50", Length = "0x32")]
	[Token(Token = "0x60000D0")]
	private void OnEndCameraRendering(ScriptableRenderContext context, Camera camera) { }

	[Address(RVA = "0x2CCB740", Offset = "0x2CCAB40", Length = "0xA9")]
	[Token(Token = "0x60000CE")]
	private void OnEndContextRendering(ScriptableRenderContext context, List<Camera> cameras) { }

	[Address(RVA = "0x2CCB7F0", Offset = "0x2CCABF0", Length = "0x2B")]
	[Token(Token = "0x60000CB")]
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	[Address(RVA = "0x2CCB820", Offset = "0x2CCAC20", Length = "0x60")]
	[Token(Token = "0x60000B3")]
	public static void OnSetupAmbientProbe() { }

	[Address(RVA = "0x2CCB890", Offset = "0x2CCAC90", Length = "0x68")]
	[Token(Token = "0x60000B2")]
	public static void PostCullBeginCameraRendering(RenderRequestBatcherContext context) { }

	[Address(RVA = "0x2CCB950", Offset = "0x2CCAD50", Length = "0xBC4")]
	[Token(Token = "0x60000D1")]
	private void PostPostLateUpdate() { }

	[Address(RVA = "0x2CCB900", Offset = "0x2CCAD00", Length = "0x46")]
	[Token(Token = "0x60000CC")]
	private static void PostPostLateUpdateStatic() { }

	[Address(RVA = "0x2CCC520", Offset = "0x2CCB920", Length = "0x5C")]
	[Token(Token = "0x60000D3")]
	private void ProcessCameras(NativeArray<EntityId> changedIDs, NativeArray<EntityId> destroyedIDs) { }

	[Address(RVA = "0x2CCC580", Offset = "0x2CCB980", Length = "0x88")]
	[Token(Token = "0x60000D5")]
	private void ProcessLODGroups(NativeArray<EntityId> changedID, NativeArray<EntityId> destroyed, NativeArray<EntityId> transformedID) { }

	[Address(RVA = "0x2CCC610", Offset = "0x2CCBA10", Length = "0x7A")]
	[Token(Token = "0x60000D2")]
	private void ProcessMaterials(NativeArray<EntityId> destroyedID, NativeArray<EntityId> unsupportedMaterials) { }

	[Address(RVA = "0x2CCC690", Offset = "0x2CCBA90", Length = "0x152")]
	[Token(Token = "0x60000D4")]
	private void ProcessMeshes(NativeArray<EntityId> destroyedID) { }

	[Address(RVA = "0x2CCC7F0", Offset = "0x2CCBBF0", Length = "0x69A")]
	[Token(Token = "0x60000D6")]
	private void ProcessRendererMaterialAndMeshChanges(NativeArray<EntityId> excludedRenderers, NativeArray<EntityId> changedMaterials, NativeArray<GPUDrivenPackedMaterialData> changedPackedMaterialDatas, NativeArray<EntityId> changedMeshes) { }

	[Address(RVA = "0x2CCCE90", Offset = "0x2CCC290", Length = "0x397")]
	[Token(Token = "0x60000D7")]
	private void ProcessRenderers(TypeDispatchData rendererChanges, NativeArray<EntityId> unsupportedRenderers) { }

	[Address(RVA = "0x2CCD230", Offset = "0x2CCC630", Length = "0x1E3")]
	[Token(Token = "0x60000C6")]
	private static void Recreate(GPUResidentDrawerSettings settings) { }

	[Address(RVA = "0x2CCD420", Offset = "0x2CCC820", Length = "0x211")]
	[Token(Token = "0x60000C4")]
	internal static void Reinitialize() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000B6")]
	public static void ReinitializeIfNeeded() { }

	[Address(RVA = "0x2CCD640", Offset = "0x2CCCA40", Length = "0x388")]
	[Token(Token = "0x60000BB")]
	private void RemoveFromPlayerLoop() { }

	[Address(RVA = "0x2CCD9D0", Offset = "0x2CCCDD0", Length = "0xB8")]
	[Token(Token = "0x60000B8")]
	public static void RenderDebugOccluderOverlay(RenderGraph renderGraph, DebugDisplayGPUResidentDrawer debugSettings, Vector2 screenPos, float maxHeight, TextureHandle colorBuffer) { }

	[Address(RVA = "0x2CCDA90", Offset = "0x2CCCE90", Length = "0xA6")]
	[Token(Token = "0x60000B7")]
	public static void RenderDebugOcclusionTestOverlay(RenderGraph renderGraph, DebugDisplayGPUResidentDrawer debugSettings, int viewInstanceID, TextureHandle colorBuffer) { }

	[Address(RVA = "0x2CCDB40", Offset = "0x2CCCF40", Length = "0x47")]
	[Token(Token = "0x60000DF")]
	private JobHandle ScheduleQueryMeshInstancesJob(NativeArray<EntityId> sortedMeshIDs, NativeList<InstanceHandle> instances) { }

	[Address(RVA = "0x2CCDB90", Offset = "0x2CCCF90", Length = "0x55")]
	[Token(Token = "0x60000DC")]
	private JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<EntityId> rendererGroupIDs, NativeArray<InstanceHandle> instances) { }

	[Address(RVA = "0x2CCDC70", Offset = "0x2CCD070", Length = "0x47")]
	[Token(Token = "0x60000DD")]
	private JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<EntityId> rendererGroupIDs, NativeList<InstanceHandle> instances) { }

	[Address(RVA = "0x2CCDBF0", Offset = "0x2CCCFF0", Length = "0x7D")]
	[Token(Token = "0x60000DE")]
	private JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<EntityId> rendererGroupIDs, NativeArray<Int32> instancesOffset, NativeArray<Int32> instancesCount, NativeList<InstanceHandle> instances) { }

	[Address(RVA = "0x2CCE4A0", Offset = "0x2CCD8A0", Length = "0x3C")]
	[CompilerGenerated]
	[Token(Token = "0x60000C3")]
	internal static void set_ForceOcclusion(bool value) { }

	[Address(RVA = "0x2CCE4E0", Offset = "0x2CCD8E0", Length = "0x3C")]
	[CompilerGenerated]
	[Token(Token = "0x60000C1")]
	internal static void set_MaintainContext(bool value) { }

	[Address(RVA = "0x2CCDCC0", Offset = "0x2CCD0C0", Length = "0x3A")]
	[Token(Token = "0x60000D8")]
	private void TransformInstances(NativeArray<InstanceHandle> instances, NativeArray<Matrix4x4> localToWorldMatrices) { }

	[Address(RVA = "0x2CCDD00", Offset = "0x2CCD100", Length = "0xBC")]
	[Token(Token = "0x60000B5")]
	public static void UpdateInstanceOccluders(RenderGraph renderGraph, in OccluderParameters occluderParameters, ReadOnlySpan<OccluderSubviewUpdate> occluderSubviewUpdates) { }

}

