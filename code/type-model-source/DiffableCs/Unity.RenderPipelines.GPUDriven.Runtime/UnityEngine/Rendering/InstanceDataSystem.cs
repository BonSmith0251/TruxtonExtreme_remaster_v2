namespace UnityEngine.Rendering;

[Token(Token = "0x2000086")]
internal class InstanceDataSystem : IDisposable
{
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x200008E")]
	private struct CalculateInterpolatedLightAndOcclusionProbesBatchJob : IJobParallelFor
	{
		[Token(Token = "0x40002A6")]
		public const int k_BatchSize = 1; //Field offset: 0x0
		[Token(Token = "0x40002A7")]
		public const int k_CalculatedProbesPerBatch = 8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x40002A8")]
		public int probesCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[ReadOnly]
		[Token(Token = "0x40002A9")]
		public LightProbesQuery lightProbesQuery; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[NativeDisableParallelForRestriction]
		[ReadOnly]
		[Token(Token = "0x40002AA")]
		public NativeArray<Vector3> queryPostitions; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[NativeDisableParallelForRestriction]
		[Token(Token = "0x40002AB")]
		public NativeArray<Int32> compactTetrahedronCache; //Field offset: 0x28
		[FieldOffset(Offset = "0x38")]
		[NativeDisableParallelForRestriction]
		[Token(Token = "0x40002AC")]
		[WriteOnly]
		public NativeArray<SphericalHarmonicsL2> probesSphericalHarmonics; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[NativeDisableParallelForRestriction]
		[Token(Token = "0x40002AD")]
		[WriteOnly]
		public NativeArray<Vector4> probesOcclusion; //Field offset: 0x48

		[Address(RVA = "0x2CF2760", Offset = "0x2CF1B60", Length = "0x150")]
		[Token(Token = "0x60002C7")]
		public override void Execute(int index) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x2000094")]
	private struct CollectInstancesLODGroupsAndMasksJob : IJobParallelFor
	{
		[Token(Token = "0x40002D3")]
		public const int k_BatchSize = 128; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x40002D4")]
		public NativeArray<InstanceHandle> instances; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		[Token(Token = "0x40002D5")]
		public ReadOnly instanceData; //Field offset: 0x10
		[FieldOffset(Offset = "0xF8")]
		[ReadOnly]
		[Token(Token = "0x40002D6")]
		public ReadOnly sharedInstanceData; //Field offset: 0xF8
		[FieldOffset(Offset = "0x1A8")]
		[Token(Token = "0x40002D7")]
		[WriteOnly]
		public NativeArray<UInt32> lodGroupAndMasks; //Field offset: 0x1A8

		[Address(RVA = "0x2CF28B0", Offset = "0x2CF1CB0", Length = "0x9A")]
		[Token(Token = "0x60002CD")]
		public override void Execute(int index) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x200008A")]
	private struct ComputeInstancesOffsetAndResizeInstancesArrayJob : IJob
	{
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x4000291")]
		public NativeArray<Int32> instancesCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000292")]
		[WriteOnly]
		public NativeArray<Int32> instancesOffset; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000293")]
		public NativeList<InstanceHandle> instances; //Field offset: 0x20

		[Address(RVA = "0x2CDE9D0", Offset = "0x2CDDDD0", Length = "0x64")]
		[Token(Token = "0x60002C3")]
		public override void Execute() { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x2000095")]
	private struct GetVisibleNonProcessedTreeInstancesJob : IJobParallelForBatch
	{
		[Token(Token = "0x40002D8")]
		public const int k_BatchSize = 64; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x40002D9")]
		public CPUInstanceData instanceData; //Field offset: 0x0
		[FieldOffset(Offset = "0xF0")]
		[ReadOnly]
		[Token(Token = "0x40002DA")]
		public CPUSharedInstanceData sharedInstanceData; //Field offset: 0xF0
		[FieldOffset(Offset = "0x1A8")]
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		[Token(Token = "0x40002DB")]
		public ParallelBitArray compactedVisibilityMasks; //Field offset: 0x1A8
		[FieldOffset(Offset = "0x1C8")]
		[ReadOnly]
		[Token(Token = "0x40002DC")]
		public bool becomeVisible; //Field offset: 0x1C8
		[FieldOffset(Offset = "0x1D0")]
		[NativeDisableParallelForRestriction]
		[Token(Token = "0x40002DD")]
		public ParallelBitArray processedBits; //Field offset: 0x1D0
		[FieldOffset(Offset = "0x1F0")]
		[NativeDisableParallelForRestriction]
		[Token(Token = "0x40002DE")]
		[WriteOnly]
		public NativeArray<Int32> rendererIDs; //Field offset: 0x1F0
		[FieldOffset(Offset = "0x200")]
		[NativeDisableParallelForRestriction]
		[Token(Token = "0x40002DF")]
		[WriteOnly]
		public NativeArray<InstanceHandle> instances; //Field offset: 0x200
		[FieldOffset(Offset = "0x210")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40002E0")]
		public UnsafeAtomicCounter32 atomicTreeInstancesCount; //Field offset: 0x210

		[Address(RVA = "0x2CF3DA0", Offset = "0x2CF31A0", Length = "0x2FB")]
		[Token(Token = "0x60002CE")]
		public override void Execute(int startIndex, int count) { }

	}

	[Token(Token = "0x2000087")]
	private static class InstanceTransformUpdateIDs
	{
		[Token(Token = "0x4000276")]
		public static readonly int _TransformUpdateQueueCount; //Field offset: 0x0
		[Token(Token = "0x4000277")]
		public static readonly int _TransformUpdateOutputL2WVec4Offset; //Field offset: 0x4
		[Token(Token = "0x4000278")]
		public static readonly int _TransformUpdateOutputW2LVec4Offset; //Field offset: 0x8
		[Token(Token = "0x4000279")]
		public static readonly int _TransformUpdateOutputPrevL2WVec4Offset; //Field offset: 0xC
		[Token(Token = "0x400027A")]
		public static readonly int _TransformUpdateOutputPrevW2LVec4Offset; //Field offset: 0x10
		[Token(Token = "0x400027B")]
		public static readonly int _BoundingSphereOutputVec4Offset; //Field offset: 0x14
		[Token(Token = "0x400027C")]
		public static readonly int _TransformUpdateDataQueue; //Field offset: 0x18
		[Token(Token = "0x400027D")]
		public static readonly int _TransformUpdateIndexQueue; //Field offset: 0x1C
		[Token(Token = "0x400027E")]
		public static readonly int _BoundingSphereDataQueue; //Field offset: 0x20
		[Token(Token = "0x400027F")]
		public static readonly int _OutputTransformBuffer; //Field offset: 0x24
		[Token(Token = "0x4000280")]
		public static readonly int _ProbeUpdateQueueCount; //Field offset: 0x28
		[Token(Token = "0x4000281")]
		public static readonly int _SHUpdateVec4Offset; //Field offset: 0x2C
		[Token(Token = "0x4000282")]
		public static readonly int _ProbeUpdateDataQueue; //Field offset: 0x30
		[Token(Token = "0x4000283")]
		public static readonly int _ProbeOcclusionUpdateDataQueue; //Field offset: 0x34
		[Token(Token = "0x4000284")]
		public static readonly int _ProbeUpdateIndexQueue; //Field offset: 0x38
		[Token(Token = "0x4000285")]
		public static readonly int _OutputProbeBuffer; //Field offset: 0x3C

		[Address(RVA = "0x2CEC990", Offset = "0x2CEBD90", Length = "0x2D8")]
		[Token(Token = "0x60002C0")]
		private static InstanceTransformUpdateIDs() { }

	}

	[Token(Token = "0x2000088")]
	private static class InstanceWindDataUpdateIDs
	{
		[Token(Token = "0x4000286")]
		public static readonly int _WindDataQueueCount; //Field offset: 0x0
		[Token(Token = "0x4000287")]
		public static readonly int _WindDataUpdateIndexQueue; //Field offset: 0x4
		[Token(Token = "0x4000288")]
		public static readonly int _WindDataBuffer; //Field offset: 0x8
		[Token(Token = "0x4000289")]
		public static readonly int _WindParamAddressArray; //Field offset: 0xC
		[Token(Token = "0x400028A")]
		public static readonly int _WindHistoryParamAddressArray; //Field offset: 0x10

		[Address(RVA = "0x2CECC70", Offset = "0x2CEC070", Length = "0xFB")]
		[Token(Token = "0x60002C1")]
		private static InstanceWindDataUpdateIDs() { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x2000092")]
	private struct MotionUpdateJob : IJobParallelFor
	{
		[Token(Token = "0x40002C6")]
		public const int k_BatchSize = 16; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x40002C7")]
		public int queueWriteBase; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[NativeDisableParallelForRestriction]
		[Token(Token = "0x40002C8")]
		public CPUInstanceData instanceData; //Field offset: 0x8
		[FieldOffset(Offset = "0xF8")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40002C9")]
		public UnsafeAtomicCounter32 atomicUpdateQueueCount; //Field offset: 0xF8
		[FieldOffset(Offset = "0x100")]
		[NativeDisableParallelForRestriction]
		[Token(Token = "0x40002CA")]
		[WriteOnly]
		public NativeArray<InstanceHandle> transformUpdateInstanceQueue; //Field offset: 0x100

		[Address(RVA = "0x2CF7B10", Offset = "0x2CF6F10", Length = "0x22F")]
		[Token(Token = "0x60002CB")]
		public override void Execute(int chunk_index) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x2000091")]
	private struct ProbesUpdateJob : IJobParallelForBatch
	{
		[Token(Token = "0x40002BE")]
		public const int k_BatchSize = 64; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		[Token(Token = "0x40002BF")]
		public NativeArray<InstanceHandle> instances; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[NativeDisableContainerSafetyRestriction]
		[NativeDisableParallelForRestriction]
		[NoAlias]
		[Token(Token = "0x40002C0")]
		public CPUInstanceData instanceData; //Field offset: 0x10
		[FieldOffset(Offset = "0x100")]
		[ReadOnly]
		[Token(Token = "0x40002C1")]
		public CPUSharedInstanceData sharedInstanceData; //Field offset: 0x100
		[FieldOffset(Offset = "0x1B8")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40002C2")]
		public UnsafeAtomicCounter32 atomicProbesQueueCount; //Field offset: 0x1B8
		[FieldOffset(Offset = "0x1C0")]
		[NativeDisableParallelForRestriction]
		[Token(Token = "0x40002C3")]
		public NativeArray<InstanceHandle> probeInstanceQueue; //Field offset: 0x1C0
		[FieldOffset(Offset = "0x1D0")]
		[NativeDisableParallelForRestriction]
		[Token(Token = "0x40002C4")]
		public NativeArray<Int32> compactTetrahedronCache; //Field offset: 0x1D0
		[FieldOffset(Offset = "0x1E0")]
		[NativeDisableParallelForRestriction]
		[Token(Token = "0x40002C5")]
		public NativeArray<Vector3> probeQueryPosition; //Field offset: 0x1E0

		[Address(RVA = "0x2CFE9E0", Offset = "0x2CFDDE0", Length = "0x32B")]
		[Token(Token = "0x60002CA")]
		public override void Execute(int startIndex, int count) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x2000089")]
	private struct QueryRendererGroupInstancesCountJob : IJobParallelForBatch
	{
		[Token(Token = "0x400028B")]
		public const int k_BatchSize = 128; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x400028C")]
		public CPUInstanceData instanceData; //Field offset: 0x0
		[FieldOffset(Offset = "0xF0")]
		[ReadOnly]
		[Token(Token = "0x400028D")]
		public CPUSharedInstanceData sharedInstanceData; //Field offset: 0xF0
		[FieldOffset(Offset = "0x1A8")]
		[ReadOnly]
		[Token(Token = "0x400028E")]
		public NativeParallelMultiHashMap<Int32, InstanceHandle> rendererGroupInstanceMultiHash; //Field offset: 0x1A8
		[FieldOffset(Offset = "0x1B8")]
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		[Token(Token = "0x400028F")]
		public NativeArray<EntityId> rendererGroupIDs; //Field offset: 0x1B8
		[FieldOffset(Offset = "0x1C8")]
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[Token(Token = "0x4000290")]
		[WriteOnly]
		public NativeArray<Int32> instancesCount; //Field offset: 0x1C8

		[Address(RVA = "0x2CED500", Offset = "0x2CEC900", Length = "0x101")]
		[Token(Token = "0x60002C2")]
		public override void Execute(int startIndex, int count) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x200008B")]
	private struct QueryRendererGroupInstancesJob : IJobParallelForBatch
	{
		[Token(Token = "0x4000294")]
		public const int k_BatchSize = 128; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x4000295")]
		public NativeParallelMultiHashMap<Int32, InstanceHandle> rendererGroupInstanceMultiHash; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		[Token(Token = "0x4000296")]
		public NativeArray<EntityId> rendererGroupIDs; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[Token(Token = "0x4000297")]
		[WriteOnly]
		public NativeArray<InstanceHandle> instances; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4000298")]
		public UnsafeAtomicCounter32 atomicNonFoundInstancesCount; //Field offset: 0x30

		[Address(RVA = "0x2CFED10", Offset = "0x2CFE110", Length = "0x104")]
		[Token(Token = "0x60002C4")]
		public override void Execute(int startIndex, int count) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x200008C")]
	private struct QueryRendererGroupInstancesMultiJob : IJobParallelForBatch
	{
		[Token(Token = "0x4000299")]
		public const int k_BatchSize = 128; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x400029A")]
		public NativeParallelMultiHashMap<Int32, InstanceHandle> rendererGroupInstanceMultiHash; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		[Token(Token = "0x400029B")]
		public NativeArray<EntityId> rendererGroupIDs; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		[Token(Token = "0x400029C")]
		public NativeArray<Int32> instancesOffsets; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		[Token(Token = "0x400029D")]
		public NativeArray<Int32> instancesCounts; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[Token(Token = "0x400029E")]
		[WriteOnly]
		public NativeArray<InstanceHandle> instances; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x400029F")]
		public UnsafeAtomicCounter32 atomicNonFoundSharedInstancesCount; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40002A0")]
		public UnsafeAtomicCounter32 atomicNonFoundInstancesCount; //Field offset: 0x58

		[Address(RVA = "0x2CFEE20", Offset = "0x2CFE220", Length = "0x1EE")]
		[Token(Token = "0x60002C5")]
		public override void Execute(int startIndex, int count) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x200008D")]
	private struct QuerySortedMeshInstancesJob : IJobParallelForBatch
	{
		[Token(Token = "0x40002A1")]
		public const int k_BatchSize = 64; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x40002A2")]
		public CPUInstanceData instanceData; //Field offset: 0x0
		[FieldOffset(Offset = "0xF0")]
		[ReadOnly]
		[Token(Token = "0x40002A3")]
		public CPUSharedInstanceData sharedInstanceData; //Field offset: 0xF0
		[FieldOffset(Offset = "0x1A8")]
		[ReadOnly]
		[Token(Token = "0x40002A4")]
		public NativeArray<EntityId> sortedMeshID; //Field offset: 0x1A8
		[FieldOffset(Offset = "0x1B8")]
		[NativeDisableParallelForRestriction]
		[Token(Token = "0x40002A5")]
		[WriteOnly]
		public NativeList<InstanceHandle> instances; //Field offset: 0x1B8

		[Address(RVA = "0x2CFF010", Offset = "0x2CFE410", Length = "0x27F")]
		[Token(Token = "0x60002C6")]
		public override void Execute(int startIndex, int count) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x200008F")]
	private struct ScatterTetrahedronCacheIndicesJob : IJobParallelFor
	{
		[Token(Token = "0x40002AE")]
		public const int k_BatchSize = 128; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x40002AF")]
		public NativeArray<InstanceHandle> probeInstances; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		[Token(Token = "0x40002B0")]
		public NativeArray<Int32> compactTetrahedronCache; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[NativeDisableContainerSafetyRestriction]
		[NativeDisableParallelForRestriction]
		[NoAlias]
		[Token(Token = "0x40002B1")]
		public CPUInstanceData instanceData; //Field offset: 0x20

		[Address(RVA = "0x2D02740", Offset = "0x2D01B40", Length = "0x23")]
		[Token(Token = "0x60002C8")]
		public override void Execute(int index) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x2000090")]
	private struct TransformUpdateJob : IJobParallelForBatch
	{
		[Token(Token = "0x40002B2")]
		public const int k_BatchSize = 64; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x40002B3")]
		public bool initialize; //Field offset: 0x0
		[FieldOffset(Offset = "0x1")]
		[ReadOnly]
		[Token(Token = "0x40002B4")]
		public bool enableBoundingSpheres; //Field offset: 0x1
		[FieldOffset(Offset = "0x8")]
		[ReadOnly]
		[Token(Token = "0x40002B5")]
		public NativeArray<InstanceHandle> instances; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[ReadOnly]
		[Token(Token = "0x40002B6")]
		public NativeArray<Matrix4x4> localToWorldMatrices; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[ReadOnly]
		[Token(Token = "0x40002B7")]
		public NativeArray<Matrix4x4> prevLocalToWorldMatrices; //Field offset: 0x28
		[FieldOffset(Offset = "0x38")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40002B8")]
		public UnsafeAtomicCounter32 atomicTransformQueueCount; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[NativeDisableParallelForRestriction]
		[Token(Token = "0x40002B9")]
		public CPUSharedInstanceData sharedInstanceData; //Field offset: 0x40
		[FieldOffset(Offset = "0xF8")]
		[NativeDisableParallelForRestriction]
		[Token(Token = "0x40002BA")]
		public CPUInstanceData instanceData; //Field offset: 0xF8
		[FieldOffset(Offset = "0x1E8")]
		[NativeDisableParallelForRestriction]
		[Token(Token = "0x40002BB")]
		public NativeArray<InstanceHandle> transformUpdateInstanceQueue; //Field offset: 0x1E8
		[FieldOffset(Offset = "0x1F8")]
		[NativeDisableParallelForRestriction]
		[Token(Token = "0x40002BC")]
		public NativeArray<TransformUpdatePacket> transformUpdateDataQueue; //Field offset: 0x1F8
		[FieldOffset(Offset = "0x208")]
		[NativeDisableParallelForRestriction]
		[Token(Token = "0x40002BD")]
		public NativeArray<float4> boundingSpheresDataQueue; //Field offset: 0x208

		[Address(RVA = "0x2D031A0", Offset = "0x2D025A0", Length = "0x796")]
		[Token(Token = "0x60002C9")]
		public override void Execute(int startIndex, int count) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x2000096")]
	private struct UpdateCompactedInstanceVisibilityJob : IJobParallelForBatch
	{
		[Token(Token = "0x40002E1")]
		public const int k_BatchSize = 64; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x40002E2")]
		public ParallelBitArray compactedVisibilityMasks; //Field offset: 0x0
		[FieldOffset(Offset = "0x20")]
		[NativeDisableContainerSafetyRestriction]
		[NativeDisableParallelForRestriction]
		[NoAlias]
		[Token(Token = "0x40002E3")]
		public CPUInstanceData instanceData; //Field offset: 0x20

		[Address(RVA = "0x2D04110", Offset = "0x2D03510", Length = "0x11B")]
		[Token(Token = "0x60002CF")]
		public override void Execute(int startIndex, int count) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x2000093")]
	private struct UpdateRendererInstancesJob : IJobParallelFor
	{
		[Token(Token = "0x40002CB")]
		public const int k_BatchSize = 128; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x40002CC")]
		public bool implicitInstanceIndices; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[ReadOnly]
		[Token(Token = "0x40002CD")]
		public GPUDrivenRendererGroupData rendererData; //Field offset: 0x8
		[FieldOffset(Offset = "0x1F8")]
		[ReadOnly]
		[Token(Token = "0x40002CE")]
		public NativeArray<InstanceHandle> instances; //Field offset: 0x1F8
		[FieldOffset(Offset = "0x208")]
		[ReadOnly]
		[Token(Token = "0x40002CF")]
		public NativeParallelHashMap<Int32, GPUInstanceIndex> lodGroupDataMap; //Field offset: 0x208
		[FieldOffset(Offset = "0x218")]
		[NativeDisableContainerSafetyRestriction]
		[NativeDisableParallelForRestriction]
		[NoAlias]
		[Token(Token = "0x40002D0")]
		public CPUInstanceData instanceData; //Field offset: 0x218
		[FieldOffset(Offset = "0x308")]
		[NativeDisableContainerSafetyRestriction]
		[NativeDisableParallelForRestriction]
		[NoAlias]
		[Token(Token = "0x40002D1")]
		public CPUSharedInstanceData sharedInstanceData; //Field offset: 0x308
		[FieldOffset(Offset = "0x3C0")]
		[NativeDisableContainerSafetyRestriction]
		[NativeDisableParallelForRestriction]
		[NoAlias]
		[Token(Token = "0x40002D2")]
		public CPUPerCameraInstanceData perCameraInstanceData; //Field offset: 0x3C0

		[Address(RVA = "0x2D04740", Offset = "0x2D03B40", Length = "0x6C4")]
		[Token(Token = "0x60002CC")]
		public override void Execute(int index) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000262")]
	private InstanceAllocators m_InstanceAllocators; //Field offset: 0x10
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000263")]
	private CPUSharedInstanceData m_SharedInstanceData; //Field offset: 0x70
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000264")]
	private CPUInstanceData m_InstanceData; //Field offset: 0x128
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000265")]
	private CPUPerCameraInstanceData m_PerCameraInstanceData; //Field offset: 0x218
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000266")]
	private NativeParallelMultiHashMap<Int32, InstanceHandle> m_RendererGroupInstanceMultiHash; //Field offset: 0x238
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000267")]
	private ComputeShader m_TransformUpdateCS; //Field offset: 0x248
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4000268")]
	private ComputeShader m_WindDataUpdateCS; //Field offset: 0x250
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4000269")]
	private int m_TransformInitKernel; //Field offset: 0x258
	[FieldOffset(Offset = "0x25C")]
	[Token(Token = "0x400026A")]
	private int m_TransformUpdateKernel; //Field offset: 0x25C
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400026B")]
	private int m_MotionUpdateKernel; //Field offset: 0x260
	[FieldOffset(Offset = "0x264")]
	[Token(Token = "0x400026C")]
	private int m_ProbeUpdateKernel; //Field offset: 0x264
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x400026D")]
	private int m_LODUpdateKernel; //Field offset: 0x268
	[FieldOffset(Offset = "0x26C")]
	[Token(Token = "0x400026E")]
	private int m_WindDataCopyHistoryKernel; //Field offset: 0x26C
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x400026F")]
	private ComputeBuffer m_UpdateIndexQueueBuffer; //Field offset: 0x270
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4000270")]
	private ComputeBuffer m_ProbeUpdateDataQueueBuffer; //Field offset: 0x278
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4000271")]
	private ComputeBuffer m_ProbeOcclusionUpdateDataQueueBuffer; //Field offset: 0x280
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4000272")]
	private ComputeBuffer m_TransformUpdateDataQueueBuffer; //Field offset: 0x288
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4000273")]
	private ComputeBuffer m_BoundingSpheresUpdateDataQueueBuffer; //Field offset: 0x290
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x4000274")]
	private bool m_EnableBoundingSpheres; //Field offset: 0x298
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x4000275")]
	private readonly Int32[] m_ScratchWindParamAddressArray; //Field offset: 0x2A0

	[Token(Token = "0x1700004F")]
	public NativeArray<InstanceHandle> aliveInstances
	{
		[Address(RVA = "0x2CEC430", Offset = "0x2CEB830", Length = "0x6C")]
		[Token(Token = "0x600029C")]
		 get { } //Length: 108
	}

	[Token(Token = "0x1700004D")]
	public int cameraCount
	{
		[Address(RVA = "0x2CEC4A0", Offset = "0x2CEB8A0", Length = "0x3D")]
		[Token(Token = "0x600029A")]
		 get { } //Length: 61
	}

	[Token(Token = "0x1700004A")]
	public bool hasBoundingSpheres
	{
		[Address(RVA = "0x2CEC4E0", Offset = "0x2CEB8E0", Length = "0x8")]
		[Token(Token = "0x6000297")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700004B")]
	public ReadOnly instanceData
	{
		[Address(RVA = "0x2CEC4F0", Offset = "0x2CEB8F0", Length = "0xD4")]
		[Token(Token = "0x6000298")]
		 get { } //Length: 212
	}

	[Token(Token = "0x1700004C")]
	public CPUPerCameraInstanceData perCameraInstanceData
	{
		[Address(RVA = "0x2CEC5D0", Offset = "0x2CEB9D0", Length = "0x19")]
		[Token(Token = "0x6000299")]
		 get { } //Length: 25
	}

	[Token(Token = "0x1700004E")]
	public ReadOnly sharedInstanceData
	{
		[Address(RVA = "0x2CEC5F0", Offset = "0x2CEB9F0", Length = "0xB7")]
		[Token(Token = "0x600029B")]
		 get { } //Length: 183
	}

	[Address(RVA = "0x2CEC120", Offset = "0x2CEB520", Length = "0x30C")]
	[Token(Token = "0x600029D")]
	public InstanceDataSystem(int maxInstances, bool enableBoundingSpheres, GPUResidentDrawerResources resources) { }

	[Address(RVA = "0x2CE71F0", Offset = "0x2CE65F0", Length = "0x25")]
	[Token(Token = "0x60002BE")]
	public void AllocatePerCameraInstanceData(NativeArray<EntityId> cameraIDs) { }

	[Address(RVA = "0x84BF70", Offset = "0x84B370", Length = "0x46")]
	[Token(Token = "0x60002BF")]
	private static int AtomicAddLengthNoResize(in NativeList<T>& list, int count) { }

	[Address(RVA = "0x2CE7220", Offset = "0x2CE6620", Length = "0x25")]
	[Token(Token = "0x60002BD")]
	public void DeallocatePerCameraInstanceData(NativeArray<EntityId> cameraIDs) { }

	[Address(RVA = "0x2CE7250", Offset = "0x2CE6650", Length = "0x3C3")]
	[Token(Token = "0x60002A6")]
	private void DispatchMotionUpdateCommand(int motionQueueCount, NativeArray<InstanceHandle> transformInstanceQueue, RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer) { }

	[Address(RVA = "0x2CE7620", Offset = "0x2CE6A20", Length = "0x570")]
	[Token(Token = "0x60002A5")]
	private void DispatchProbeUpdateCommand(int queueCount, NativeArray<InstanceHandle> probeInstanceQueue, NativeArray<SphericalHarmonicsL2> probeUpdateDataQueue, NativeArray<Vector4> probeOcclusionUpdateDataQueue, RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer) { }

	[Address(RVA = "0x2CE7BA0", Offset = "0x2CE6FA0", Length = "0x558")]
	[Token(Token = "0x60002A7")]
	private void DispatchTransformUpdateCommand(bool initialize, int transformQueueCount, NativeArray<InstanceHandle> transformInstanceQueue, NativeArray<TransformUpdatePacket> updateDataQueue, NativeArray<float4> boundingSphereUpdateDataQueue, RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer) { }

	[Address(RVA = "0x2CE8100", Offset = "0x2CE7500", Length = "0x320")]
	[Token(Token = "0x60002A8")]
	private void DispatchWindDataCopyHistoryCommand(NativeArray<GPUInstanceIndex> gpuInstanceIndices, RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer) { }

	[Address(RVA = "0x2CE8430", Offset = "0x2CE7830", Length = "0xD4")]
	[Token(Token = "0x600029E")]
	public override void Dispose() { }

	[Address(RVA = "0x2CE8510", Offset = "0x2CE7910", Length = "0xB3")]
	[Token(Token = "0x60002A1")]
	private void EnsureIndexQueueBufferCapacity(int capacity) { }

	[Address(RVA = "0x2CE85D0", Offset = "0x2CE79D0", Length = "0x174")]
	[Token(Token = "0x60002A2")]
	private void EnsureProbeBuffersCapacity(int capacity) { }

	[Address(RVA = "0x2CE8750", Offset = "0x2CE7B50", Length = "0x1A5")]
	[Token(Token = "0x60002A3")]
	private void EnsureTransformBuffersCapacity(int capacity) { }

	[Address(RVA = "0x2CE8900", Offset = "0x2CE7D00", Length = "0x98")]
	[Token(Token = "0x60002AF")]
	public void FreeInstances(NativeArray<InstanceHandle> instances) { }

	[Address(RVA = "0x2CE89A0", Offset = "0x2CE7DA0", Length = "0x98")]
	[Token(Token = "0x60002AE")]
	public void FreeRendererGroupInstances(NativeArray<EntityId> rendererGroupsID) { }

	[Address(RVA = "0x2CEC430", Offset = "0x2CEB830", Length = "0x6C")]
	[Token(Token = "0x600029C")]
	public NativeArray<InstanceHandle> get_aliveInstances() { }

	[Address(RVA = "0x2CEC4A0", Offset = "0x2CEB8A0", Length = "0x3D")]
	[Token(Token = "0x600029A")]
	public int get_cameraCount() { }

	[Address(RVA = "0x2CEC4E0", Offset = "0x2CEB8E0", Length = "0x8")]
	[Token(Token = "0x6000297")]
	public bool get_hasBoundingSpheres() { }

	[Address(RVA = "0x2CEC4F0", Offset = "0x2CEB8F0", Length = "0xD4")]
	[Token(Token = "0x6000298")]
	public ReadOnly get_instanceData() { }

	[Address(RVA = "0x2CEC5D0", Offset = "0x2CEB9D0", Length = "0x19")]
	[Token(Token = "0x6000299")]
	public CPUPerCameraInstanceData get_perCameraInstanceData() { }

	[Address(RVA = "0x2CEC5F0", Offset = "0x2CEB9F0", Length = "0xB7")]
	[Token(Token = "0x600029B")]
	public ReadOnly get_sharedInstanceData() { }

	[Address(RVA = "0x2CE8A40", Offset = "0x2CE7E40", Length = "0xC")]
	[Token(Token = "0x60002A0")]
	public int GetAliveInstancesOfType(InstanceType instanceType) { }

	[Address(RVA = "0x2CE8A50", Offset = "0x2CE7E50", Length = "0xC")]
	[Token(Token = "0x600029F")]
	public int GetMaxInstancesOfType(InstanceType instanceType) { }

	[Address(RVA = "0x2CE8A60", Offset = "0x2CE7E60", Length = "0x69A")]
	[Token(Token = "0x60002BB")]
	public void GetVisibleTreeInstances(in ParallelBitArray compactedVisibilityMasks, in ParallelBitArray processedBits, NativeList<Int32> visibeTreeRendererIDs, NativeList<InstanceHandle> visibeTreeInstances, bool becomeVisibleOnly, out int becomeVisibeTreeInstancesCount) { }

	[Address(RVA = "0x2CE9100", Offset = "0x2CE8500", Length = "0x63")]
	[Token(Token = "0x60002B2")]
	public void InitializeInstanceTransforms(NativeArray<InstanceHandle> instances, NativeArray<Matrix4x4> localToWorldMatrices, NativeArray<Matrix4x4> prevLocalToWorldMatrices, in RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer) { }

	[Address(RVA = "0x2CE9170", Offset = "0x2CE8570", Length = "0x2A4")]
	[Token(Token = "0x60002BA")]
	public bool InternalSanityCheckStates() { }

	[Address(RVA = "0x2CE9420", Offset = "0x2CE8820", Length = "0x29B")]
	[Token(Token = "0x60002AD")]
	public void ReallocateAndGetInstances(in GPUDrivenRendererGroupData rendererData, NativeArray<InstanceHandle> instances) { }

	[Address(RVA = "0x2CE96C0", Offset = "0x2CE8AC0", Length = "0x284")]
	[Token(Token = "0x60002B9")]
	public JobHandle ScheduleCollectInstancesLODGroupAndMasksJob(NativeArray<InstanceHandle> instances, NativeArray<UInt32> lodGroupAndMasks) { }

	[Address(RVA = "0x2CE9950", Offset = "0x2CE8D50", Length = "0x2E6")]
	[Token(Token = "0x60002A4")]
	private JobHandle ScheduleInterpolateProbesAndUpdateTetrahedronCache(int queueCount, NativeArray<InstanceHandle> probeUpdateInstanceQueue, NativeArray<Int32> compactTetrahedronCache, NativeArray<Vector3> probeQueryPosition, NativeArray<SphericalHarmonicsL2> probeUpdateDataQueue, NativeArray<Vector4> probeOcclusionUpdateDataQueue) { }

	[Address(RVA = "0x2CE9C40", Offset = "0x2CE9040", Length = "0xE5")]
	[Token(Token = "0x60002B5")]
	public JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<EntityId> rendererGroupIDs, NativeArray<InstanceHandle> instances) { }

	[Address(RVA = "0x2CEA150", Offset = "0x2CE9550", Length = "0x18F")]
	[Token(Token = "0x60002B6")]
	public JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<EntityId> rendererGroupIDs, NativeList<InstanceHandle> instances) { }

	[Address(RVA = "0x2CE9D30", Offset = "0x2CE9130", Length = "0x41B")]
	[Token(Token = "0x60002B7")]
	public JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<EntityId> rendererGroupIDs, NativeArray<Int32> instancesOffset, NativeArray<Int32> instancesCount, NativeList<InstanceHandle> instances) { }

	[Address(RVA = "0x2CEA2E0", Offset = "0x2CE96E0", Length = "0x2AE")]
	[Token(Token = "0x60002B8")]
	public JobHandle ScheduleQuerySortedMeshInstancesJob(NativeArray<EntityId> sortedMeshIDs, NativeList<InstanceHandle> instances) { }

	[Address(RVA = "0x2CEA590", Offset = "0x2CE9990", Length = "0x362")]
	[Token(Token = "0x60002B0")]
	public JobHandle ScheduleUpdateInstanceDataJob(NativeArray<InstanceHandle> instances, in GPUDrivenRendererGroupData rendererData, NativeParallelHashMap<Int32, GPUInstanceIndex> lodGroupDataMap) { }

	[Address(RVA = "0x2CEA900", Offset = "0x2CE9D00", Length = "0x9C")]
	[Token(Token = "0x60002B1")]
	public void UpdateAllInstanceProbes(in RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer) { }

	[Address(RVA = "0x2CEAC70", Offset = "0x2CEA070", Length = "0x2E2")]
	[Token(Token = "0x60002B4")]
	public void UpdateInstanceMotions(in RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer) { }

	[Address(RVA = "0x2CEA9A0", Offset = "0x2CE9DA0", Length = "0x2CF")]
	[Token(Token = "0x60002A9")]
	private void UpdateInstanceMotionsData(in RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer) { }

	[Address(RVA = "0x2CEAF60", Offset = "0x2CEA360", Length = "0x57E")]
	[Token(Token = "0x60002AB")]
	private void UpdateInstanceProbesData(NativeArray<InstanceHandle> instances, in RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer) { }

	[Address(RVA = "0x2CEBE60", Offset = "0x2CEB260", Length = "0x57")]
	[Token(Token = "0x60002B3")]
	public void UpdateInstanceTransforms(NativeArray<InstanceHandle> instances, NativeArray<Matrix4x4> localToWorldMatrices, in RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer) { }

	[Address(RVA = "0x2CEB4E0", Offset = "0x2CEA8E0", Length = "0x979")]
	[Token(Token = "0x60002AA")]
	private void UpdateInstanceTransformsData(bool initialize, NativeArray<InstanceHandle> instances, NativeArray<Matrix4x4> localToWorldMatrices, NativeArray<Matrix4x4> prevLocalToWorldMatrices, in RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer) { }

	[Address(RVA = "0x2CEBEC0", Offset = "0x2CEB2C0", Length = "0x75")]
	[Token(Token = "0x60002AC")]
	public void UpdateInstanceWindDataHistory(NativeArray<GPUInstanceIndex> gpuInstanceIndices, RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer) { }

	[Address(RVA = "0x2CEBF40", Offset = "0x2CEB340", Length = "0x1D1")]
	[Token(Token = "0x60002BC")]
	public void UpdatePerFrameInstanceVisibility(in ParallelBitArray compactedVisibilityMasks) { }

}

