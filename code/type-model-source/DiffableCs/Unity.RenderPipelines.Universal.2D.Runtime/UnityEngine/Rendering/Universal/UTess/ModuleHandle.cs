namespace UnityEngine.Rendering.Universal.UTess;

[Token(Token = "0x20000B5")]
internal struct ModuleHandle
{
	[Token(Token = "0x4000306")]
	internal static readonly int kMaxArea; //Field offset: 0x0
	[Token(Token = "0x4000307")]
	internal static readonly int kMaxEdgeCount; //Field offset: 0x4
	[Token(Token = "0x4000308")]
	internal static readonly int kMaxIndexCount; //Field offset: 0x8
	[Token(Token = "0x4000309")]
	internal static readonly int kMaxVertexCount; //Field offset: 0xC
	[Token(Token = "0x400030A")]
	internal static readonly int kMaxTriangleCount; //Field offset: 0x10
	[Token(Token = "0x400030B")]
	internal static readonly int kMaxRefineIterations; //Field offset: 0x14
	[Token(Token = "0x400030C")]
	internal static readonly int kMaxSmoothenIterations; //Field offset: 0x18
	[Token(Token = "0x400030D")]
	internal static readonly float kIncrementAreaFactor; //Field offset: 0x1C

	[Address(RVA = "0x2D4CC30", Offset = "0x2D4C030", Length = "0xE0")]
	[Token(Token = "0x60003DA")]
	private static ModuleHandle() { }

	[Address(RVA = "0x2D4ACE0", Offset = "0x2D4A0E0", Length = "0x4A0")]
	[Token(Token = "0x60003D0")]
	internal static void BuildTriangles(NativeArray<float2> vertices, int vertexCount, NativeArray<Int32> indices, int indexCount, ref NativeArray<UTriangle>& triangles, ref int triangleCount, ref float maxArea, ref float avgArea, ref float minArea, ref float maxEdge, ref float avgEdge, ref float minEdge) { }

	[Address(RVA = "0x2D4B180", Offset = "0x2D4A580", Length = "0x33A")]
	[Token(Token = "0x60003CF")]
	internal static void BuildTriangles(NativeArray<float2> vertices, int vertexCount, NativeArray<Int32> indices, int indexCount, ref NativeArray<UTriangle>& triangles, ref int triangleCount, ref float maxArea, ref float avgArea, ref float minArea) { }

	[Address(RVA = "0x2D4A8E0", Offset = "0x2D49CE0", Length = "0x3FF")]
	[Token(Token = "0x60003D1")]
	internal static void BuildTrianglesAndEdges(NativeArray<float2> vertices, int vertexCount, NativeArray<Int32> indices, int indexCount, ref NativeArray<UTriangle>& triangles, ref int triangleCount, ref NativeArray<int4>& delaEdges, ref int delaEdgeCount, ref float maxArea, ref float avgArea, ref float minArea) { }

	[Address(RVA = "0x2D4B4C0", Offset = "0x2D4A8C0", Length = "0x1E0")]
	[Token(Token = "0x60003C8")]
	internal static UCircle CircumCircle(UTriangle tri) { }

	[Address(RVA = "0x2D4B6A0", Offset = "0x2D4AAA0", Length = "0x278")]
	[Token(Token = "0x60003D8")]
	public static float4 ConvexQuad(Allocator allocator, NativeArray<float2> points, NativeArray<int2> edges, ref NativeArray<float2>& outVertices, ref int outVertexCount, ref NativeArray<Int32>& outIndices, ref int outIndexCount, ref NativeArray<int2>& outEdges, ref int outEdgeCount) { }

	[Address(RVA = "0x8888E0", Offset = "0x887CE0", Length = "0x94")]
	[Token(Token = "0x60003C0")]
	internal static void Copy(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }

	[Address(RVA = "0x888980", Offset = "0x887D80", Length = "0xB9")]
	[Token(Token = "0x60003C1")]
	internal static void Copy(NativeArray<T> src, NativeArray<T> dst, int length) { }

	[Address(RVA = "0x2D4B920", Offset = "0x2D4AD20", Length = "0xFE")]
	[Token(Token = "0x60003D3")]
	private static void CopyGeometry(NativeArray<Int32> srcIndices, int srcIndexCount, ref NativeArray<Int32>& dstIndices, ref int dstIndexCount, NativeArray<float2> srcVertices, int srcVertexCount, ref NativeArray<float2>& dstVertices, ref int dstVertexCount) { }

	[Address(RVA = "0x2D4BA20", Offset = "0x2D4AE20", Length = "0x10B")]
	[Token(Token = "0x60003D2")]
	private static void CopyGraph(NativeArray<float2> srcPoints, int srcPointCount, ref NativeArray<float2>& dstPoints, ref int dstPointCount, NativeArray<int2> srcEdges, int srcEdgeCount, ref NativeArray<int2>& dstEdges, ref int dstEdgeCount) { }

	[Address(RVA = "0x888DD0", Offset = "0x8881D0", Length = "0x133")]
	[Token(Token = "0x60003C5")]
	internal static int GetEqual(NativeArray<T> values, int count, U check, X condition) { }

	[Address(RVA = "0x889300", Offset = "0x888700", Length = "0x123")]
	[Token(Token = "0x60003C3")]
	internal static int GetLower(NativeArray<T> values, int count, U check, X condition) { }

	[Address(RVA = "0x889760", Offset = "0x888B60", Length = "0x112")]
	[Token(Token = "0x60003C4")]
	internal static int GetUpper(NativeArray<T> values, int count, U check, X condition) { }

	[Address(RVA = "0x2D4BB30", Offset = "0x2D4AF30", Length = "0x386")]
	[Token(Token = "0x60003D5")]
	private static void GraphConditioner(NativeArray<float2> points, ref NativeArray<float2>& pgPoints, ref int pgPointCount, ref NativeArray<int2>& pgEdges, ref int pgEdgeCount, bool resetTopology) { }

	[Address(RVA = "0x889880", Offset = "0x888C80", Length = "0xCD")]
	[Token(Token = "0x60003C2")]
	internal static void InsertionSort(Void* array, int lo, int hi, U comp) { }

	[Address(RVA = "0x2D4BEC0", Offset = "0x2D4B2C0", Length = "0x47")]
	[Token(Token = "0x60003C9")]
	internal static bool IsInsideCircle(UCircle c, float2 v) { }

	[Address(RVA = "0x2D4BF10", Offset = "0x2D4B310", Length = "0x225")]
	[Token(Token = "0x60003CE")]
	internal static bool IsInsideCircle(float2 a, float2 b, float2 c, float2 p) { }

	[Address(RVA = "0x2D4C2F0", Offset = "0x2D4B6F0", Length = "0x14A")]
	[Token(Token = "0x60003CC")]
	internal static bool IsInsideTriangle(float2 pt, float2 v1, float2 v2, float2 v3) { }

	[Address(RVA = "0x2D4C140", Offset = "0x2D4B540", Length = "0x1B0")]
	[Token(Token = "0x60003CD")]
	internal static bool IsInsideTriangleApproximate(float2 pt, float2 v1, float2 v2, float2 v3) { }

	[Address(RVA = "0x2D4C4A0", Offset = "0x2D4B8A0", Length = "0x75")]
	[Token(Token = "0x60003C6")]
	internal static float OrientFast(float2 a, float2 b, float2 c) { }

	[Address(RVA = "0x2D4C440", Offset = "0x2D4B840", Length = "0x5F")]
	[Token(Token = "0x60003C7")]
	internal static double OrientFastDouble(double2 a, double2 b, double2 c) { }

	[Address(RVA = "0x2D4C520", Offset = "0x2D4B920", Length = "0x95")]
	[Token(Token = "0x60003D6")]
	private static void Reorder(int startVertexCount, int index, ref NativeArray<Int32>& indices, ref int indexCount, ref NativeArray<float2>& vertices, ref int vertexCount) { }

	[Address(RVA = "0x2D4C5C0", Offset = "0x2D4B9C0", Length = "0x51")]
	[Token(Token = "0x60003CB")]
	internal static float Sign(float2 p1, float2 p2, float2 p3) { }

	[Address(RVA = "0x2D4C620", Offset = "0x2D4BA20", Length = "0x32B")]
	[Token(Token = "0x60003D9")]
	public static float4 Tessellate(Allocator allocator, NativeArray<float2> points, NativeArray<int2> edges, ref NativeArray<float2>& outVertices, ref int outVertexCount, ref NativeArray<Int32>& outIndices, ref int outIndexCount, ref NativeArray<int2>& outEdges, ref int outEdgeCount) { }

	[Address(RVA = "0x2D4C950", Offset = "0x2D4BD50", Length = "0x161")]
	[Token(Token = "0x60003D4")]
	private static void TransferOutput(NativeArray<int2> srcEdges, int srcEdgeCount, ref NativeArray<int2>& dstEdges, ref int dstEdgeCount, NativeArray<Int32> srcIndices, int srcIndexCount, ref NativeArray<Int32>& dstIndices, ref int dstIndexCount, NativeArray<float2> srcVertices, int srcVertexCount, ref NativeArray<float2>& dstVertices, ref int dstVertexCount) { }

	[Address(RVA = "0x2D4CAC0", Offset = "0x2D4BEC0", Length = "0x60")]
	[Token(Token = "0x60003CA")]
	internal static float TriangleArea(float2 va, float2 vb, float2 vc) { }

	[Address(RVA = "0x2D4CB20", Offset = "0x2D4BF20", Length = "0x103")]
	[Token(Token = "0x60003D7")]
	internal static void VertexCleanupConditioner(int startVertexCount, ref NativeArray<Int32>& indices, ref int indexCount, ref NativeArray<float2>& vertices, ref int vertexCount) { }

}

