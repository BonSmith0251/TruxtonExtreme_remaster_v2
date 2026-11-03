namespace UnityEngine.Rendering.Universal.UTess;

[Token(Token = "0x200009A")]
internal struct PlanarGraph
{
	[Token(Token = "0x40002CF")]
	private static readonly double kEpsilon; //Field offset: 0x0
	[Token(Token = "0x40002D0")]
	private static readonly int kMaxIntersectionTolerance; //Field offset: 0x8

	[Address(RVA = "0x2D4EE00", Offset = "0x2D4E200", Length = "0x55")]
	[Token(Token = "0x6000394")]
	private static PlanarGraph() { }

	[Address(RVA = "0x2D4CD10", Offset = "0x2D4C110", Length = "0x459")]
	[Token(Token = "0x600038F")]
	internal static bool CalculateEdgeIntersections(NativeArray<int2> edges, int edgeCount, NativeArray<double2> points, int pointCount, ref NativeArray<int2>& results, ref NativeArray<double2>& intersects, ref int resultCount) { }

	[Address(RVA = "0x2D4D170", Offset = "0x2D4C570", Length = "0x297")]
	[Token(Token = "0x6000390")]
	internal static bool CalculateTJunctions(NativeArray<int2> edges, int edgeCount, NativeArray<double2> points, int pointCount, NativeArray<int2> results, ref int resultCount) { }

	[Address(RVA = "0x2D4D410", Offset = "0x2D4C810", Length = "0x178")]
	[Token(Token = "0x600038C")]
	internal static bool CheckCollinear(double2 a0, double2 a1, double2 b0, double2 b1) { }

	[Address(RVA = "0x2D4D590", Offset = "0x2D4C990", Length = "0x2DB")]
	[Token(Token = "0x6000391")]
	internal static bool CutEdges(ref NativeArray<double2>& points, ref int pointCount, ref NativeArray<int2>& edges, ref int edgeCount, ref NativeArray<int2>& tJunctions, ref int tJunctionCount, NativeArray<int2> intersections, NativeArray<double2> intersects, int intersectionCount) { }

	[Address(RVA = "0x2D4D870", Offset = "0x2D4CC70", Length = "0x5F0")]
	[Token(Token = "0x600038D")]
	internal static bool LineLineIntersection(double2 a0, double2 a1, double2 b0, double2 b1) { }

	[Address(RVA = "0x2D4DE60", Offset = "0x2D4D260", Length = "0x1D2")]
	[Token(Token = "0x600038E")]
	internal static bool LineLineIntersection(double2 p1, double2 p2, double2 p3, double2 p4, ref double2 result) { }

	[Address(RVA = "0x2D4E040", Offset = "0x2D4D440", Length = "0x1DF")]
	[Token(Token = "0x600038B")]
	internal static void RemoveDuplicateEdges(ref NativeArray<int2>& edges, ref int edgeCount, NativeArray<Int32> duplicates, int duplicateCount) { }

	[Address(RVA = "0x2D4E220", Offset = "0x2D4D620", Length = "0x488")]
	[Token(Token = "0x6000392")]
	internal static void RemoveDuplicatePoints(ref NativeArray<double2>& points, ref int pointCount, ref NativeArray<Int32>& duplicates, ref int duplicateCount, Allocator allocator) { }

	[Address(RVA = "0x2D4E6B0", Offset = "0x2D4DAB0", Length = "0x744")]
	[Token(Token = "0x6000393")]
	internal static bool Validate(Allocator allocator, NativeArray<float2> inputPoints, int pointCount, NativeArray<int2> inputEdges, int edgeCount, ref NativeArray<float2>& outputPoints, ref int outputPointCount, ref NativeArray<int2>& outputEdges, ref int outputEdgeCount) { }

}

