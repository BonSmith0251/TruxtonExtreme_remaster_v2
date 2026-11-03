namespace UnityEngine.Rendering;

[BurstCompile]
[Token(Token = "0x2000040")]
internal struct CullingJob : IJobParallelFor
{
	[Token(Token = "0x2000041")]
	private enum CrossFadeType : int
	{
		kDisabled = 0,
		kCrossFadeOut = 1,
		kCrossFadeIn = 2,
		kVisible = 3,
	}

	[Token(Token = "0x40000DF")]
	public const int k_BatchSize = 32; //Field offset: 0x0
	[Token(Token = "0x40000E8")]
	private const float k_SmallMeshTransitionWidth = 0.1; //Field offset: 0x0
	[Token(Token = "0x40000E6")]
	private const uint k_InvalidCrossFadeAndLevel = 4294967295; //Field offset: 0x0
	[Token(Token = "0x40000E5")]
	public const uint k_LODFadeIsSpeedTree = 256; //Field offset: 0x0
	[Token(Token = "0x40000E4")]
	public const uint k_LODFadeZeroPacked = 127; //Field offset: 0x0
	[Token(Token = "0x40000E7")]
	private const uint k_VisibilityMaskNotVisible = 0; //Field offset: 0x0
	[Token(Token = "0x40000E2")]
	public const uint k_MeshLodCrossfadeBits = 192; //Field offset: 0x0
	[Token(Token = "0x40000E1")]
	public const uint k_MeshLodCrossfadeSignBit = 128; //Field offset: 0x0
	[Token(Token = "0x40000E0")]
	public const uint k_MeshLodCrossfadeActive = 64; //Field offset: 0x0
	[Token(Token = "0x40000E3")]
	public const uint k_LODFadeOff = 255; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x40000E9")]
	public BinningConfig binningConfig; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[ReadOnly]
	[Token(Token = "0x40000EA")]
	public BatchCullingViewType viewType; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[ReadOnly]
	[Token(Token = "0x40000EB")]
	public float3 cameraPosition; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[ReadOnly]
	[Token(Token = "0x40000EC")]
	public float sqrMeshLodSelectionConstant; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[ReadOnly]
	[Token(Token = "0x40000ED")]
	public float sqrScreenRelativeMetric; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[ReadOnly]
	[Token(Token = "0x40000EE")]
	public float minScreenRelativeHeight; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[ReadOnly]
	[Token(Token = "0x40000EF")]
	public bool isOrtho; //Field offset: 0x24
	[FieldOffset(Offset = "0x25")]
	[ReadOnly]
	[Token(Token = "0x40000F0")]
	public bool cullLightmappedShadowCasters; //Field offset: 0x25
	[FieldOffset(Offset = "0x28")]
	[ReadOnly]
	[Token(Token = "0x40000F1")]
	public int maxLOD; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[ReadOnly]
	[Token(Token = "0x40000F2")]
	public uint cullingLayerMask; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[ReadOnly]
	[Token(Token = "0x40000F3")]
	public ulong sceneCullingMask; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[ReadOnly]
	[Token(Token = "0x40000F4")]
	public bool animateCrossFades; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[ReadOnly]
	[Token(Token = "0x40000F5")]
	public NativeArray<PlanePacket4> frustumPlanePackets; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[ReadOnly]
	[Token(Token = "0x40000F6")]
	public NativeArray<SplitInfo> frustumSplitInfos; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[ReadOnly]
	[Token(Token = "0x40000F7")]
	public NativeArray<Plane> lightFacingFrustumPlanes; //Field offset: 0x60
	[FieldOffset(Offset = "0x70")]
	[ReadOnly]
	[Token(Token = "0x40000F8")]
	public NativeArray<SplitInfo> receiverSplitInfos; //Field offset: 0x70
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40000F9")]
	public float3x3 worldToLightSpaceRotation; //Field offset: 0x80
	[FieldOffset(Offset = "0xA8")]
	[ReadOnly]
	[Token(Token = "0x40000FA")]
	public ReadOnly instanceData; //Field offset: 0xA8
	[FieldOffset(Offset = "0x190")]
	[ReadOnly]
	[Token(Token = "0x40000FB")]
	public ReadOnly sharedInstanceData; //Field offset: 0x190
	[FieldOffset(Offset = "0x240")]
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[ReadOnly]
	[Token(Token = "0x40000FC")]
	public NativeList<LODGroupCullingData> lodGroupCullingData; //Field offset: 0x240
	[FieldOffset(Offset = "0x248")]
	[NativeDisableUnsafePtrRestriction]
	[ReadOnly]
	[Token(Token = "0x40000FD")]
	public IntPtr occlusionBuffer; //Field offset: 0x248
	[FieldOffset(Offset = "0x250")]
	[NativeDisableContainerSafetyRestriction]
	[Token(Token = "0x40000FE")]
	public PerCameraInstanceDataArrays cameraInstanceData; //Field offset: 0x250
	[FieldOffset(Offset = "0x280")]
	[NativeDisableParallelForRestriction]
	[Token(Token = "0x40000FF")]
	[WriteOnly]
	public NativeArray<Byte> rendererVisibilityMasks; //Field offset: 0x280
	[FieldOffset(Offset = "0x290")]
	[NativeDisableParallelForRestriction]
	[Token(Token = "0x4000100")]
	[WriteOnly]
	public NativeArray<Byte> rendererMeshLodSettings; //Field offset: 0x290
	[FieldOffset(Offset = "0x2A0")]
	[NativeDisableParallelForRestriction]
	[Token(Token = "0x4000101")]
	[WriteOnly]
	public NativeArray<Byte> rendererCrossFadeValues; //Field offset: 0x2A0

	[Address(RVA = "0x2CC19D0", Offset = "0x2CC0DD0", Length = "0x4DB")]
	[Token(Token = "0x6000130")]
	private uint CalculateLODVisibility(int instanceIndex, int sharedInstanceIndex, InstanceFlags instanceFlags) { }

	[Address(RVA = "0x2CC1EB0", Offset = "0x2CC12B0", Length = "0x271")]
	[Token(Token = "0x6000131")]
	private uint CalculateVisibilityMask(int instanceIndex, int sharedInstanceIndex, InstanceFlags instanceFlags) { }

	[Address(RVA = "0x2CC2130", Offset = "0x2CC1530", Length = "0x108")]
	[Token(Token = "0x6000133")]
	private uint ComputeMeshLODCrossfade(int instanceIndex, ref uint meshLodLevel) { }

	[Address(RVA = "0x2CC2240", Offset = "0x2CC1640", Length = "0x363")]
	[Token(Token = "0x6000132")]
	private uint ComputeMeshLODLevel(int instanceIndex, int sharedInstanceIndex) { }

	[Address(RVA = "0x2CC25B0", Offset = "0x2CC19B0", Length = "0x57")]
	[Token(Token = "0x6000134")]
	private void EnforcePreviousFrameMeshLOD(int instanceIndex, ref uint meshLodLevel) { }

	[Address(RVA = "0x2CC2610", Offset = "0x2CC1A10", Length = "0x27A")]
	[Token(Token = "0x6000135")]
	public override void Execute(int instanceIndex) { }

	[Address(RVA = "0x2CC2890", Offset = "0x2CC1C90", Length = "0x57")]
	[Token(Token = "0x600012F")]
	private static uint PackFloatToUint8(float percent) { }

}

