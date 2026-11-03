namespace UnityEngine.Rendering;

[Token(Token = "0x200001A")]
internal struct ReceiverSphereCuller
{
	[Token(Token = "0x200001B")]
	public struct SplitInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004A")]
		public float4 receiverSphereLightSpace; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400004B")]
		public float cascadeBlendCullingFactor; //Field offset: 0x10

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000048")]
	public NativeList<SplitInfo> splitInfos; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000049")]
	public float3x3 worldToLightSpaceRotation; //Field offset: 0x8

	[Address(RVA = "0x2CD5090", Offset = "0x2CD4490", Length = "0x3AF")]
	[Token(Token = "0x6000096")]
	internal static uint ComputeSplitVisibilityMask(NativeArray<Plane> lightFacingFrustumPlanes, NativeArray<SplitInfo> splitInfos, float3x3 worldToLightSpaceRotation, in AABB bounds) { }

	[Address(RVA = "0x2CD54F0", Offset = "0x2CD48F0", Length = "0x4DF")]
	[Token(Token = "0x6000094")]
	internal static ReceiverSphereCuller Create(in BatchCullingContext cc, Allocator allocator) { }

	[Address(RVA = "0x2CD5440", Offset = "0x2CD4840", Length = "0xA6")]
	[Token(Token = "0x6000091")]
	internal static ReceiverSphereCuller CreateEmptyForTesting(Allocator allocator) { }

	[Address(RVA = "0x2CD59D0", Offset = "0x2CD4DD0", Length = "0x58")]
	[Token(Token = "0x6000092")]
	internal void Dispose(JobHandle job) { }

	[Address(RVA = "0x2CD5A30", Offset = "0x2CD4E30", Length = "0x18C")]
	[Token(Token = "0x6000095")]
	internal static float DistanceUntilCylinderFullyCrossesPlane(float3 cylinderCenter, float3 cylinderDirection, float cylinderRadius, Plane plane) { }

	[Address(RVA = "0x2CD5BC0", Offset = "0x2CD4FC0", Length = "0x4E")]
	[Token(Token = "0x6000093")]
	internal bool UseReceiverPlanes() { }

}

