namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[Token(Token = "0x20003AA")]
[UsedByNativeCode]
public struct BatchCullingContext
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B56")]
	public readonly NativeArray<Plane> cullingPlanes; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B57")]
	public readonly NativeArray<CullingSplit> cullingSplits; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B58")]
	public readonly LODParameters lodParameters; //Field offset: 0x20
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000B59")]
	public readonly Matrix4x4 localToWorldMatrix; //Field offset: 0x3C
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000B5A")]
	public readonly BatchCullingViewType viewType; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000B5B")]
	public readonly BatchCullingProjectionType projectionType; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000B5C")]
	public readonly BatchCullingFlags cullingFlags; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000B5D")]
	public readonly BatchPackedCullingViewID viewID; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000B5E")]
	public readonly uint cullingLayerMask; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000B5F")]
	public readonly ulong sceneCullingMask; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000B60")]
	public readonly ushort splitExclusionMask; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA2")]
	[Obsolete("BatchCullingContext.isOrthographic is deprecated. Use BatchCullingContext.projectionType instead.")]
	[Token(Token = "0x4000B61")]
	public readonly byte isOrthographic; //Field offset: 0xA2
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000B62")]
	public readonly int receiverPlaneOffset; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000B63")]
	public readonly int receiverPlaneCount; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000B64")]
	internal readonly IntPtr occlusionBuffer; //Field offset: 0xB0

	[Address(RVA = "0x30983A0", Offset = "0x30977A0", Length = "0xBD")]
	[Token(Token = "0x6001CF0")]
	internal BatchCullingContext(NativeArray<Plane> inCullingPlanes, NativeArray<CullingSplit> inCullingSplits, LODParameters inLodParameters, Matrix4x4 inLocalToWorldMatrix, BatchCullingViewType inViewType, BatchCullingProjectionType inProjectionType, BatchCullingFlags inBatchCullingFlags, ulong inViewID, uint inCullingLayerMask, ulong inSceneCullingMask, byte inExclusionSplitMask, int inReceiverPlaneOffset, int inReceiverPlaneCount, IntPtr inOcclusionBuffer) { }

}

