namespace UnityEngine.Rendering;

[Token(Token = "0x2000017")]
internal struct FrustumPlaneCuller
{
	[Token(Token = "0x2000018")]
	public struct PlanePacket4
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000040")]
		public float4 nx; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000041")]
		public float4 ny; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000042")]
		public float4 nz; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000043")]
		public float4 d; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000044")]
		public float4 nxAbs; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000045")]
		public float4 nyAbs; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000046")]
		public float4 nzAbs; //Field offset: 0x60

		[Address(RVA = "0x2CD3950", Offset = "0x2CD2D50", Length = "0x2B9")]
		[Token(Token = "0x6000090")]
		public PlanePacket4(NativeArray<Plane> planes, int offset, int limit) { }

	}

	[Token(Token = "0x2000019")]
	public struct SplitInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000047")]
		public int packetCount; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400003E")]
	public NativeList<PlanePacket4> planePackets; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400003F")]
	public NativeList<SplitInfo> splitInfos; //Field offset: 0x8

	[Address(RVA = "0x2CC7370", Offset = "0x2CC6770", Length = "0x483")]
	[Token(Token = "0x600008F")]
	internal static uint ComputeSplitVisibilityMask(NativeArray<PlanePacket4> planePackets, NativeArray<SplitInfo> splitInfos, in AABB bounds) { }

	[Address(RVA = "0x2CC7800", Offset = "0x2CC6C00", Length = "0x5D6")]
	[Token(Token = "0x600008E")]
	internal static FrustumPlaneCuller Create(in BatchCullingContext cc, NativeArray<Plane> receiverPlanes, in ReceiverSphereCuller receiverSphereCuller, Allocator allocator) { }

	[Address(RVA = "0x2CC7DE0", Offset = "0x2CC71E0", Length = "0x86")]
	[Token(Token = "0x600008D")]
	internal void Dispose(JobHandle job) { }

}

