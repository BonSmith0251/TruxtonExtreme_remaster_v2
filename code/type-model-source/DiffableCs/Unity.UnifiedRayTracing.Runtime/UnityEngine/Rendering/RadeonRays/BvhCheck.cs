namespace UnityEngine.Rendering.RadeonRays;

[Token(Token = "0x2000005")]
internal class BvhCheck
{
	[Token(Token = "0x2000008")]
	private struct Triangle
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000014")]
		public float3 v0; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000015")]
		public float3 v1; //Field offset: 0xC
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000016")]
		public float3 v2; //Field offset: 0x18

	}

	[Token(Token = "0x2000006")]
	internal class VertexBuffers
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000009")]
		public GraphicsBuffer vertices; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400000A")]
		public GraphicsBuffer indices; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400000B")]
		public uint vertexBufferOffset; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400000C")]
		public uint vertexCount; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400000D")]
		public uint vertexStride; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x400000E")]
		public uint indexBufferOffset; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400000F")]
		public IndexFormat indexFormat; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000010")]
		public uint indexCount; //Field offset: 0x34

		[Address(RVA = "0x2F61E10", Offset = "0x2F61210", Length = "0xE")]
		[Token(Token = "0x600001A")]
		public VertexBuffers() { }

	}

	[Token(Token = "0x2000007")]
	private sealed class VertexBuffersCPU
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000011")]
		public Single[] vertices; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000012")]
		public UInt32[] indices; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000013")]
		public uint vertexStride; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600001B")]
		public VertexBuffersCPU() { }

	}

	[Token(Token = "0x4000008")]
	private const uint kInvalidID = 4294967295; //Field offset: 0x0

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000019")]
	public BvhCheck() { }

	[Address(RVA = "0x2F51640", Offset = "0x2F50A40", Length = "0x47B")]
	[Token(Token = "0x6000013")]
	private static double CheckConsistency(VertexBuffers bvhVertexBuffers, GraphicsBuffer bvhBuffer, uint bvhBufferOffset, GraphicsBuffer bvhLeavesBuffer, uint bvhLeavesBufferOffset, BvhHeader header, uint primitiveCount) { }

	[Address(RVA = "0x2F51AC0", Offset = "0x2F50EC0", Length = "0x11F")]
	[Token(Token = "0x600000E")]
	private static double CheckConsistency(VertexBuffers bvhVertexBuffers, GraphicsBuffer bvhBuffer, uint bvhBufferOffset, GraphicsBuffer bvhLeavesBuffer, uint bvhLeavesBufferOffset, uint primitiveCount) { }

	[Address(RVA = "0x2F51C10", Offset = "0x2F51010", Length = "0x2E")]
	[Token(Token = "0x600000C")]
	public static double CheckConsistency(VertexBuffers bvhVertexBuffers, BottomLevelLevelAccelStruct bvh, uint primitiveCount) { }

	[Address(RVA = "0x2F51BE0", Offset = "0x2F50FE0", Length = "0x29")]
	[Token(Token = "0x600000D")]
	public static double CheckConsistency(GraphicsBuffer bvhBuffer, uint bvhBufferOffset, uint primitiveCount) { }

	[Address(RVA = "0x2F51C40", Offset = "0x2F51040", Length = "0xB8")]
	[Token(Token = "0x6000009")]
	public static VertexBuffers Convert(MeshBuildInfo info) { }

	[Address(RVA = "0x2F51D00", Offset = "0x2F51100", Length = "0x1DC")]
	[Token(Token = "0x6000017")]
	private static VertexBuffersCPU DownloadVertexData(VertexBuffers vertexBuffers) { }

	[Address(RVA = "0x2F51EE0", Offset = "0x2F512E0", Length = "0x21")]
	[Token(Token = "0x600000F")]
	public static int ExtractBits(uint value, int startBit, int count) { }

	[Address(RVA = "0x2F51F10", Offset = "0x2F51310", Length = "0x417")]
	[Token(Token = "0x6000018")]
	private static AABB GetAabb(VertexBuffersCPU bvhVertexBuffers, BvhNode[] bvhNodes, uint4[] bvhLeafNodes, uint nodeAddr, bool isTopLevel) { }

	[Address(RVA = "0x2F52330", Offset = "0x2F51730", Length = "0x61")]
	[Token(Token = "0x6000014")]
	private static uint3 GetFaceIndices(UInt32[] indices, uint triangleIdx) { }

	[Address(RVA = "0x2F523A0", Offset = "0x2F517A0", Length = "0x9")]
	[Token(Token = "0x6000011")]
	public static uint GetLeafNodeFirstPrim(uint nodeAddr) { }

	[Address(RVA = "0x2F523B0", Offset = "0x2F517B0", Length = "0xA")]
	[Token(Token = "0x6000012")]
	public static uint GetLeafNodePrimCount(uint nodeAddr) { }

	[Address(RVA = "0x2F523C0", Offset = "0x2F517C0", Length = "0x11C")]
	[Token(Token = "0x6000016")]
	private static Triangle GetTriangle(Single[] vertices, uint stride, uint3 idx) { }

	[Address(RVA = "0x2F524E0", Offset = "0x2F518E0", Length = "0x5A")]
	[Token(Token = "0x6000015")]
	private static float3 GetVertex(Single[] vertices, uint stride, uint idx) { }

	[Address(RVA = "0x2F52540", Offset = "0x2F51940", Length = "0xC")]
	[Token(Token = "0x6000010")]
	public static bool IsLeafNode(uint nodeAddr) { }

	[Address(RVA = "0x2F52550", Offset = "0x2F51950", Length = "0x117")]
	[Token(Token = "0x600000B")]
	public static double NodeSahCost(uint nodeAddr, AABB nodeAabb, AABB parentAabb) { }

	[Address(RVA = "0x2F52670", Offset = "0x2F51A70", Length = "0x60")]
	[Token(Token = "0x600000A")]
	public static double SurfaceArea(AABB aabb) { }

}

