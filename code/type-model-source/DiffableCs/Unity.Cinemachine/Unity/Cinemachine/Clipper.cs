namespace Unity.Cinemachine;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000173")]
internal static class Clipper
{
	[Token(Token = "0x400062F")]
	public static Rect64 MaxInvalidRect64; //Field offset: 0x0
	[Token(Token = "0x4000630")]
	public static RectD MaxInvalidRectD; //Field offset: 0x20

	[Address(RVA = "0x289AFE0", Offset = "0x289A3E0", Length = "0x70")]
	[Token(Token = "0x6000760")]
	private static Clipper() { }

	[Address(RVA = "0x2893930", Offset = "0x2892D30", Length = "0x14F")]
	[Token(Token = "0x6000751")]
	private static void AddPolyNodeToPaths(PolyPath64 polyPath, List<List`1<Point64>> paths) { }

	[Address(RVA = "0x28937E0", Offset = "0x2892BE0", Length = "0x14F")]
	[Token(Token = "0x6000753")]
	public static void AddPolyNodeToPathsD(PolyPathD polyPath, List<List`1<PointD>> paths) { }

	[Address(RVA = "0x2893F60", Offset = "0x2893360", Length = "0x15E")]
	[Token(Token = "0x600072A")]
	public static double Area(List<List`1<PointD>> paths) { }

	[Address(RVA = "0x2893DA0", Offset = "0x28931A0", Length = "0x1B3")]
	[Token(Token = "0x6000729")]
	public static double Area(List<PointD> path) { }

	[Address(RVA = "0x2893A80", Offset = "0x2892E80", Length = "0x15E")]
	[Token(Token = "0x6000728")]
	public static double Area(List<List`1<Point64>> paths) { }

	[Address(RVA = "0x2893BE0", Offset = "0x2892FE0", Length = "0x1B2")]
	[Token(Token = "0x6000727")]
	public static double Area(List<Point64> path) { }

	[Address(RVA = "0x28941C0", Offset = "0x28935C0", Length = "0x119")]
	[Token(Token = "0x6000721")]
	public static List<List`1<Point64>> BooleanOp(ClipType clipType, FillRule fillRule, List<List`1<Point64>> subject, List<List`1<Point64>> clip) { }

	[Address(RVA = "0x28940C0", Offset = "0x28934C0", Length = "0xF5")]
	[Token(Token = "0x6000722")]
	public static List<List`1<PointD>> BooleanOp(ClipType clipType, FillRule fillRule, List<List`1<PointD>> subject, List<List`1<PointD>> clip, int roundingDecimalPrecision = 0) { }

	[Address(RVA = "0x2894360", Offset = "0x2893760", Length = "0x74")]
	[Token(Token = "0x600071D")]
	public static List<List`1<Point64>> Difference(List<List`1<Point64>> subject, List<List`1<Point64>> clip, FillRule fillRule) { }

	[Address(RVA = "0x28942E0", Offset = "0x28936E0", Length = "0x76")]
	[Token(Token = "0x600071E")]
	public static List<List`1<PointD>> Difference(List<List`1<PointD>> subject, List<List`1<PointD>> clip, FillRule fillRule) { }

	[Address(RVA = "0x28943E0", Offset = "0x28937E0", Length = "0x36F")]
	[Token(Token = "0x6000749")]
	public static RectD GetBounds(List<List`1<PointD>> paths) { }

	[Address(RVA = "0x2894750", Offset = "0x2893B50", Length = "0x352")]
	[Token(Token = "0x6000748")]
	public static Rect64 GetBounds(List<List`1<Point64>> paths) { }

	[Address(RVA = "0x2894AB0", Offset = "0x2893EB0", Length = "0xBD")]
	[Token(Token = "0x6000723")]
	public static List<List`1<Point64>> InflatePaths(List<List`1<Point64>> paths, double delta, JoinType joinType, EndType endType, double miterLimit = 2) { }

	[Address(RVA = "0x2894B70", Offset = "0x2893F70", Length = "0x1B3")]
	[Token(Token = "0x6000724")]
	public static List<List`1<PointD>> InflatePaths(List<List`1<PointD>> paths, double delta, JoinType joinType, EndType endType, double miterLimit = 2, int precision = 2) { }

	[Address(RVA = "0x2894DB0", Offset = "0x28941B0", Length = "0x74")]
	[Token(Token = "0x6000717")]
	public static List<List`1<Point64>> Intersect(List<List`1<Point64>> subject, List<List`1<Point64>> clip, FillRule fillRule) { }

	[Address(RVA = "0x2894D30", Offset = "0x2894130", Length = "0x76")]
	[Token(Token = "0x6000718")]
	public static List<List`1<PointD>> Intersect(List<List`1<PointD>> subject, List<List`1<PointD>> clip, FillRule fillRule) { }

	[Address(RVA = "0x2894E90", Offset = "0x2894290", Length = "0x54")]
	[Token(Token = "0x600072B")]
	public static bool IsPositive(List<Point64> poly) { }

	[Address(RVA = "0x2894E30", Offset = "0x2894230", Length = "0x54")]
	[Token(Token = "0x600072C")]
	public static bool IsPositive(List<PointD> poly) { }

	[Address(RVA = "0x2894EF0", Offset = "0x28942F0", Length = "0x16F")]
	[Token(Token = "0x600074C")]
	public static List<PointD> MakePath(Double[] arr) { }

	[Address(RVA = "0x2895060", Offset = "0x2894460", Length = "0x184")]
	[Token(Token = "0x600074B")]
	public static List<Point64> MakePath(Int64[] arr) { }

	[Address(RVA = "0x28951F0", Offset = "0x28945F0", Length = "0x184")]
	[Token(Token = "0x600074A")]
	public static List<Point64> MakePath(Int32[] arr) { }

	[Address(RVA = "0x2895380", Offset = "0x2894780", Length = "0x8")]
	[Token(Token = "0x6000726")]
	public static List<List`1<Point64>> MinkowskiDiff(List<Point64> pattern, List<Point64> path, bool isClosed) { }

	[Address(RVA = "0x2895390", Offset = "0x2894790", Length = "0x8")]
	[Token(Token = "0x6000725")]
	public static List<List`1<Point64>> MinkowskiSum(List<Point64> pattern, List<Point64> path, bool isClosed) { }

	[Address(RVA = "0x28953A0", Offset = "0x28947A0", Length = "0x247")]
	[Token(Token = "0x6000731")]
	public static List<Point64> OffsetPath(List<Point64> path, long dx, long dy) { }

	[Address(RVA = "0x28957E0", Offset = "0x2894BE0", Length = "0x294")]
	[Token(Token = "0x600073C")]
	public static List<Point64> Path64(List<PointD> path) { }

	[Address(RVA = "0x28955F0", Offset = "0x28949F0", Length = "0x1EA")]
	[Token(Token = "0x600072D")]
	public static string Path64ToString(List<Point64> path) { }

	[Address(RVA = "0x2895C70", Offset = "0x2895070", Length = "0x209")]
	[Token(Token = "0x600073F")]
	public static List<PointD> PathD(List<Point64> path) { }

	[Address(RVA = "0x2895A80", Offset = "0x2894E80", Length = "0x1ED")]
	[Token(Token = "0x600072F")]
	public static string PathDToString(List<PointD> path) { }

	[Address(RVA = "0x2896000", Offset = "0x2895400", Length = "0x220")]
	[Token(Token = "0x600073D")]
	public static List<List`1<Point64>> Paths64(List<List`1<PointD>> paths) { }

	[Address(RVA = "0x2895E80", Offset = "0x2895280", Length = "0x173")]
	[Token(Token = "0x600072E")]
	public static string Paths64ToString(List<List`1<Point64>> paths) { }

	[Address(RVA = "0x28963B0", Offset = "0x28957B0", Length = "0x220")]
	[Token(Token = "0x600073E")]
	public static List<List`1<PointD>> PathsD(List<List`1<Point64>> paths) { }

	[Address(RVA = "0x2896230", Offset = "0x2895630", Length = "0x173")]
	[Token(Token = "0x6000730")]
	public static string PathsDToString(List<List`1<PointD>> paths) { }

	[Address(RVA = "0x2896700", Offset = "0x2895B00", Length = "0xE8")]
	[Token(Token = "0x6000755")]
	public static double PerpendicDistFromLineSqrd(PointD pt, PointD line1, PointD line2) { }

	[Address(RVA = "0x28965E0", Offset = "0x28959E0", Length = "0x11C")]
	[Token(Token = "0x6000756")]
	public static double PerpendicDistFromLineSqrd(Point64 pt, Point64 line1, Point64 line2) { }

	[Address(RVA = "0x28967F0", Offset = "0x2895BF0", Length = "0x1E")]
	[Token(Token = "0x600075F")]
	public static PointInPolygonResult PointInPolygon(Point64 pt, List<Point64> polygon) { }

	[Address(RVA = "0x2896810", Offset = "0x2895C10", Length = "0x88")]
	[Token(Token = "0x600074E")]
	public static bool PointsNearEqual(PointD pt1, PointD pt2, double distanceSqrd) { }

	[Address(RVA = "0x28968A0", Offset = "0x2895CA0", Length = "0x141")]
	[Token(Token = "0x6000752")]
	public static List<List`1<Point64>> PolyTreeToPaths64(PolyTree64 polyTree) { }

	[Address(RVA = "0x28969F0", Offset = "0x2895DF0", Length = "0x1AD")]
	[Token(Token = "0x6000754")]
	public static List<List`1<PointD>> PolyTreeToPathsD(PolyTreeD polyTree) { }

	[Address(RVA = "0x28979F0", Offset = "0x2896DF0", Length = "0x23B")]
	[Token(Token = "0x600075C")]
	public static List<List`1<PointD>> RamerDouglasPeucker(List<List`1<PointD>> paths, double epsilon) { }

	[Address(RVA = "0x2897310", Offset = "0x2896710", Length = "0x21A")]
	[Token(Token = "0x600075B")]
	public static List<PointD> RamerDouglasPeucker(List<PointD> path, double epsilon) { }

	[Address(RVA = "0x2897530", Offset = "0x2896930", Length = "0x271")]
	[Token(Token = "0x6000758")]
	public static List<Point64> RamerDouglasPeucker(List<Point64> path, double epsilon) { }

	[Address(RVA = "0x28977B0", Offset = "0x2896BB0", Length = "0x23B")]
	[Token(Token = "0x6000759")]
	public static List<List`1<Point64>> RamerDouglasPeucker(List<List`1<Point64>> paths, double epsilon) { }

	[Address(RVA = "0x2896BA0", Offset = "0x2895FA0", Length = "0x362")]
	[Token(Token = "0x6000757")]
	internal static void RDP(List<Point64> path, int begin, int end, double epsSqrd, List<Boolean> flags) { }

	[Address(RVA = "0x2896F10", Offset = "0x2896310", Length = "0x3F0")]
	[Token(Token = "0x600075A")]
	internal static void RDP(List<PointD> path, int begin, int end, double epsSqrd, List<Boolean> flags) { }

	[Address(RVA = "0x2897CC0", Offset = "0x28970C0", Length = "0x89")]
	[Token(Token = "0x6000745")]
	public static List<PointD> ReversePath(List<PointD> path) { }

	[Address(RVA = "0x2897C30", Offset = "0x2897030", Length = "0x89")]
	[Token(Token = "0x6000744")]
	public static List<Point64> ReversePath(List<Point64> path) { }

	[Address(RVA = "0x2897FE0", Offset = "0x28973E0", Length = "0x28A")]
	[Token(Token = "0x6000746")]
	public static List<List`1<Point64>> ReversePaths(List<List`1<Point64>> paths) { }

	[Address(RVA = "0x2897D50", Offset = "0x2897150", Length = "0x28A")]
	[Token(Token = "0x6000747")]
	public static List<List`1<PointD>> ReversePaths(List<List`1<PointD>> paths) { }

	[Address(RVA = "0x2898760", Offset = "0x2897B60", Length = "0x237")]
	[Token(Token = "0x6000736")]
	public static List<PointD> ScalePath(List<PointD> path, double scale) { }

	[Address(RVA = "0x28989A0", Offset = "0x2897DA0", Length = "0x2CB")]
	[Token(Token = "0x6000734")]
	public static List<Point64> ScalePath(List<Point64> path, double scale) { }

	[Address(RVA = "0x2898270", Offset = "0x2897670", Length = "0x2B3")]
	[Token(Token = "0x6000738")]
	public static List<Point64> ScalePath64(List<PointD> path, double scale) { }

	[Address(RVA = "0x2898530", Offset = "0x2897930", Length = "0x228")]
	[Token(Token = "0x600073A")]
	public static List<PointD> ScalePathD(List<Point64> path, double scale) { }

	[Address(RVA = "0x28990F0", Offset = "0x28984F0", Length = "0x248")]
	[Token(Token = "0x6000737")]
	public static List<List`1<PointD>> ScalePaths(List<List`1<PointD>> paths, double scale) { }

	[Address(RVA = "0x2899340", Offset = "0x2898740", Length = "0x248")]
	[Token(Token = "0x6000735")]
	public static List<List`1<Point64>> ScalePaths(List<List`1<Point64>> paths, double scale) { }

	[Address(RVA = "0x2898C70", Offset = "0x2898070", Length = "0x23B")]
	[Token(Token = "0x6000739")]
	public static List<List`1<Point64>> ScalePaths64(List<List`1<PointD>> paths, double scale) { }

	[Address(RVA = "0x2898EB0", Offset = "0x28982B0", Length = "0x23B")]
	[Token(Token = "0x600073B")]
	public static List<List`1<PointD>> ScalePathsD(List<List`1<Point64>> paths, double scale) { }

	[Address(RVA = "0x2899590", Offset = "0x2898990", Length = "0x2E")]
	[Token(Token = "0x6000732")]
	public static Point64 ScalePoint64(Point64 pt, double scale) { }

	[Address(RVA = "0x28995C0", Offset = "0x28989C0", Length = "0x26")]
	[Token(Token = "0x6000733")]
	public static PointD ScalePointD(Point64 pt, double scale) { }

	[Address(RVA = "0x28995F0", Offset = "0x28989F0", Length = "0x5")]
	[Token(Token = "0x600074D")]
	public static double Sqr(double value) { }

	[Address(RVA = "0x2899600", Offset = "0x2898A00", Length = "0x284")]
	[Token(Token = "0x6000750")]
	public static List<Point64> StripDuplicates(List<Point64> path, bool isClosedPath) { }

	[Address(RVA = "0x2899890", Offset = "0x2898C90", Length = "0x32F")]
	[Token(Token = "0x600074F")]
	public static List<PointD> StripNearDuplicates(List<PointD> path, double minEdgeLenSqrd, bool isClosedPath) { }

	[Address(RVA = "0x2899E10", Offset = "0x2899210", Length = "0x222")]
	[Token(Token = "0x6000742")]
	public static List<PointD> TranslatePath(List<PointD> path, double dx, double dy) { }

	[Address(RVA = "0x2899BC0", Offset = "0x2898FC0", Length = "0x247")]
	[Token(Token = "0x6000740")]
	public static List<Point64> TranslatePath(List<Point64> path, long dx, long dy) { }

	[Address(RVA = "0x289A040", Offset = "0x2899440", Length = "0x23D")]
	[Token(Token = "0x6000741")]
	public static List<List`1<Point64>> TranslatePaths(List<List`1<Point64>> paths, long dx, long dy) { }

	[Address(RVA = "0x289A280", Offset = "0x2899680", Length = "0x247")]
	[Token(Token = "0x6000743")]
	public static List<List`1<PointD>> TranslatePaths(List<List`1<PointD>> paths, double dx, double dy) { }

	[Address(RVA = "0x289A600", Offset = "0x2899A00", Length = "0x6F5")]
	[Token(Token = "0x600075D")]
	public static List<Point64> TrimCollinear(List<Point64> path, bool isOpen = false) { }

	[Address(RVA = "0x289A4D0", Offset = "0x28998D0", Length = "0x126")]
	[Token(Token = "0x600075E")]
	public static List<PointD> TrimCollinear(List<PointD> path, int precision, bool isOpen = false) { }

	[Address(RVA = "0x289AD70", Offset = "0x289A170", Length = "0x68")]
	[Token(Token = "0x600071B")]
	public static List<List`1<PointD>> Union(List<List`1<PointD>> subject, FillRule fillRule) { }

	[Address(RVA = "0x289AD00", Offset = "0x289A100", Length = "0x66")]
	[Token(Token = "0x6000719")]
	public static List<List`1<Point64>> Union(List<List`1<Point64>> subject, FillRule fillRule) { }

	[Address(RVA = "0x289AE60", Offset = "0x289A260", Length = "0x76")]
	[Token(Token = "0x600071C")]
	public static List<List`1<PointD>> Union(List<List`1<PointD>> subject, List<List`1<PointD>> clip, FillRule fillRule) { }

	[Address(RVA = "0x289ADE0", Offset = "0x289A1E0", Length = "0x74")]
	[Token(Token = "0x600071A")]
	public static List<List`1<Point64>> Union(List<List`1<Point64>> subject, List<List`1<Point64>> clip, FillRule fillRule) { }

	[Address(RVA = "0x289AEE0", Offset = "0x289A2E0", Length = "0x74")]
	[Token(Token = "0x600071F")]
	public static List<List`1<Point64>> Xor(List<List`1<Point64>> subject, List<List`1<Point64>> clip, FillRule fillRule) { }

	[Address(RVA = "0x289AF60", Offset = "0x289A360", Length = "0x76")]
	[Token(Token = "0x6000720")]
	public static List<List`1<PointD>> Xor(List<List`1<PointD>> subject, List<List`1<PointD>> clip, FillRule fillRule) { }

}

