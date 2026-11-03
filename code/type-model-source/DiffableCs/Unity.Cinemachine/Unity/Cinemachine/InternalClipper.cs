namespace Unity.Cinemachine;

[Token(Token = "0x2000172")]
internal static class InternalClipper
{
	[Token(Token = "0x400062D")]
	internal const double floatingPointTolerance = 1E-15; //Field offset: 0x0
	[Token(Token = "0x400062E")]
	internal const double defaultMinimumEdgeLength = 0.1; //Field offset: 0x0

	[Address(RVA = "0x289BC80", Offset = "0x289B080", Length = "0x49")]
	[Token(Token = "0x6000711")]
	internal static double CrossProduct(Point64 pt1, Point64 pt2, Point64 pt3) { }

	[Address(RVA = "0x289BCF0", Offset = "0x289B0F0", Length = "0x49")]
	[Token(Token = "0x6000712")]
	internal static double DotProduct(Point64 pt1, Point64 pt2, Point64 pt3) { }

	[Address(RVA = "0x289BCD0", Offset = "0x289B0D0", Length = "0x17")]
	[Token(Token = "0x6000713")]
	internal static double DotProduct(PointD vec1, PointD vec2) { }

	[Address(RVA = "0x289BD40", Offset = "0x289B140", Length = "0x261")]
	[Token(Token = "0x6000714")]
	internal static bool GetIntersectPoint(Point64 ln1a, Point64 ln1b, Point64 ln2a, Point64 ln2b, out PointD ip) { }

	[Address(RVA = "0x289BFB0", Offset = "0x289B3B0", Length = "0x2ED")]
	[Token(Token = "0x6000716")]
	public static PointInPolygonResult PointInPolygon(Point64 pt, List<Point64> polygon) { }

	[Address(RVA = "0x289C2A0", Offset = "0x289B6A0", Length = "0x118")]
	[Token(Token = "0x6000715")]
	internal static bool SegmentsIntersect(Point64 seg1a, Point64 seg1b, Point64 seg2a, Point64 seg2b) { }

}

