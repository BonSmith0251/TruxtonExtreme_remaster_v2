namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000023")]
internal class Clipper : ClipperBase
{
	[Token(Token = "0x2000024")]
	public enum NodeType : int
	{
		ntAny = 0,
		ntOpen = 1,
		ntClosed = 2,
	}

	[Token(Token = "0x4000082")]
	public const int ioReverseSolution = 1; //Field offset: 0x0
	[Token(Token = "0x4000083")]
	public const int ioStrictlySimple = 2; //Field offset: 0x0
	[Token(Token = "0x4000084")]
	public const int ioPreserveCollinear = 4; //Field offset: 0x0
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000085")]
	private ClipTypes m_ClipType; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000086")]
	private Maxima m_Maxima; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000087")]
	private TEdge m_SortedEdges; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000088")]
	private List<IntersectNode> m_IntersectList; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000089")]
	private IComparer<IntersectNode> m_IntersectNodeComparer; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400008A")]
	private bool m_ExecuteLocked; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x400008B")]
	private PolyFillTypes m_ClipFillType; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400008C")]
	private PolyFillTypes m_SubjFillType; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400008D")]
	private List<Join> m_Joins; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400008E")]
	private List<Join> m_GhostJoins; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400008F")]
	private bool m_UsingPolyTree; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000090")]
	private int <LastIndex>k__BackingField; //Field offset: 0x94
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000091")]
	private bool <ReverseSolution>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0x99")]
	[Token(Token = "0x4000092")]
	private bool <StrictlySimple>k__BackingField; //Field offset: 0x99

	[Token(Token = "0x17000009")]
	public int LastIndex
	{
		[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000065")]
		 get { } //Length: 7
		[Address(RVA = "0xE26C10", Offset = "0xE26010", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000066")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700000A")]
	public bool ReverseSolution
	{
		[Address(RVA = "0xD11AF0", Offset = "0xD10EF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000067")]
		 get { } //Length: 8
		[Address(RVA = "0xD11C70", Offset = "0xD11070", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000068")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700000B")]
	public bool StrictlySimple
	{
		[Address(RVA = "0x1D633F0", Offset = "0x1D627F0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000069")]
		 get { } //Length: 8
		[Address(RVA = "0x28426D0", Offset = "0x2841AD0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600006A")]
		 set { } //Length: 7
	}

	[Address(RVA = "0x2D17DE0", Offset = "0x2D171E0", Length = "0x264")]
	[Token(Token = "0x6000063")]
	public Clipper(int InitOptions = 0) { }

	[Address(RVA = "0x2D09CD0", Offset = "0x2D090D0", Length = "0xDC")]
	[Token(Token = "0x600007B")]
	private void AddEdgeToSEL(TEdge edge) { }

	[Address(RVA = "0x2D09DB0", Offset = "0x2D091B0", Length = "0x111")]
	[Token(Token = "0x6000073")]
	private void AddGhostJoin(OutPt Op, IntPoint OffPt) { }

	[Address(RVA = "0x2D09ED0", Offset = "0x2D092D0", Length = "0x130")]
	[Token(Token = "0x6000072")]
	private void AddJoin(OutPt Op1, OutPt Op2, IntPoint OffPt) { }

	[Address(RVA = "0x2D0A010", Offset = "0x2D09410", Length = "0xE7")]
	[Token(Token = "0x600007F")]
	private void AddLocalMaxPoly(TEdge e1, TEdge e2, IntPoint pt) { }

	[Address(RVA = "0x2D0A100", Offset = "0x2D09500", Length = "0x402")]
	[Token(Token = "0x6000080")]
	private OutPt AddLocalMinPoly(TEdge e1, TEdge e2, IntPoint pt) { }

	[Address(RVA = "0x2D0A510", Offset = "0x2D09910", Length = "0x323")]
	[Token(Token = "0x6000081")]
	private OutPt AddOutPt(TEdge e, IntPoint pt) { }

	[Address(RVA = "0x2D0A840", Offset = "0x2D09C40", Length = "0x193")]
	[Token(Token = "0x60000CD")]
	internal static void AddPolyNodeToPaths(PolyNode polynode, NodeType nt, List<List`1<IntPoint>> paths) { }

	[Address(RVA = "0x2D0A9E0", Offset = "0x2D09DE0", Length = "0x96F")]
	[Token(Token = "0x600008C")]
	private void AppendPolygon(TEdge e1, TEdge e2) { }

	[Address(RVA = "0x2D0B540", Offset = "0x2D0A940", Length = "0x61")]
	[Token(Token = "0x60000BD")]
	internal double Area(OutPt op) { }

	[Address(RVA = "0x2D0B4D0", Offset = "0x2D0A8D0", Length = "0x6C")]
	[Token(Token = "0x60000BC")]
	internal double Area(OutRec outRec) { }

	[Address(RVA = "0x2D0B350", Offset = "0x2D0A750", Length = "0x171")]
	[Token(Token = "0x60000BB")]
	public static double Area(List<IntPoint> poly) { }

	[Address(RVA = "0x2D0B5B0", Offset = "0x2D0A9B0", Length = "0x31D")]
	[Token(Token = "0x600009C")]
	private void BuildIntersectList(long topY) { }

	[Address(RVA = "0x2D0BD10", Offset = "0x2D0B110", Length = "0x22E")]
	[Token(Token = "0x60000A9")]
	private void BuildResult(List<List`1<IntPoint>> polyg) { }

	[Address(RVA = "0x2D0B8D0", Offset = "0x2D0ACD0", Length = "0x430")]
	[Token(Token = "0x60000AA")]
	private void BuildResult2(PolyTree polytree) { }

	[Address(RVA = "0x2D0BF40", Offset = "0x2D0B340", Length = "0x6F9")]
	[Token(Token = "0x60000C5")]
	public static List<IntPoint> CleanPolygon(List<IntPoint> path, double distance = 1.415) { }

	[Address(RVA = "0x2D0C640", Offset = "0x2D0BA40", Length = "0x14B")]
	[Token(Token = "0x60000C6")]
	public static List<List`1<IntPoint>> CleanPolygons(List<List`1<IntPoint>> polys, double distance = 1.415) { }

	[Address(RVA = "0x2D0C790", Offset = "0x2D0BB90", Length = "0xAA")]
	[Token(Token = "0x60000CF")]
	public static List<List`1<IntPoint>> ClosedPathsFromPolyTree(PolyTree polytree) { }

	[Address(RVA = "0x2D0C840", Offset = "0x2D0BC40", Length = "0x66")]
	[Token(Token = "0x600007D")]
	private void CopyAELToSEL() { }

	[Address(RVA = "0x2D0C8B0", Offset = "0x2D0BCB0", Length = "0xB6")]
	[Token(Token = "0x6000091")]
	private void DeleteFromSEL(TEdge e) { }

	[Address(RVA = "0x2D0C970", Offset = "0x2D0BD70", Length = "0x117")]
	[Token(Token = "0x6000071")]
	private void DisposeAllPolyPts() { }

	[Address(RVA = "0x2D0CA90", Offset = "0x2D0BE90", Length = "0xA3")]
	[Token(Token = "0x60000C1")]
	private static double DistanceFromLineSqrd(IntPoint pt, IntPoint ln1, IntPoint ln2) { }

	[Address(RVA = "0x2D0CB40", Offset = "0x2D0BF40", Length = "0x57")]
	[Token(Token = "0x60000C0")]
	private static double DistanceSqrd(IntPoint pt1, IntPoint pt2) { }

	[Address(RVA = "0x2D0CBA0", Offset = "0x2D0BFA0", Length = "0x1353")]
	[Token(Token = "0x60000A5")]
	private void DoMaxima(TEdge e) { }

	[Address(RVA = "0x2D0DF00", Offset = "0x2D0D300", Length = "0x2FB")]
	[Token(Token = "0x60000BA")]
	private void DoSimplePolygons() { }

	[Address(RVA = "0x2D0E200", Offset = "0x2D0D600", Length = "0x146")]
	[Token(Token = "0x60000AD")]
	private OutPt DupOutPt(OutPt outPt, bool InsertAfter) { }

	[Address(RVA = "0x2D0E350", Offset = "0x2D0D750", Length = "0x11A")]
	[Token(Token = "0x6000076")]
	private bool E2InsertsBeforeE1(TEdge e1, TEdge e2) { }

	[Address(RVA = "0x2D0E470", Offset = "0x2D0D870", Length = "0x3A")]
	[Token(Token = "0x600009D")]
	private bool EdgesAdjacent(IntersectNode inode) { }

	[Address(RVA = "0x2D0E4B0", Offset = "0x2D0D8B0", Length = "0x5F")]
	[Token(Token = "0x60000C4")]
	private static OutPt ExcludeOp(OutPt op) { }

	[Address(RVA = "0x2D0E9A0", Offset = "0x2D0DDA0", Length = "0x19C")]
	[Token(Token = "0x600006D")]
	public bool Execute(ClipTypes clipType, List<List`1<IntPoint>> solution, PolyFillTypes subjFillType, PolyFillTypes clipFillType) { }

	[Address(RVA = "0x2D0EB60", Offset = "0x2D0DF60", Length = "0x1C")]
	[Token(Token = "0x600006C")]
	public bool Execute(ClipTypes clipType, PolyTree polytree, PolyFillTypes FillType = 0) { }

	[Address(RVA = "0x2D0EB40", Offset = "0x2D0DF40", Length = "0x1C")]
	[Token(Token = "0x600006B")]
	public bool Execute(ClipTypes clipType, List<List`1<IntPoint>> solution, PolyFillTypes FillType = 0) { }

	[Address(RVA = "0x2D0EB80", Offset = "0x2D0DF80", Length = "0xDD")]
	[Token(Token = "0x600006E")]
	public bool Execute(ClipTypes clipType, PolyTree polytree, PolyFillTypes subjFillType, PolyFillTypes clipFillType) { }

	[Address(RVA = "0x2D0E510", Offset = "0x2D0D910", Length = "0x489")]
	[Token(Token = "0x6000070")]
	private bool ExecuteInternal() { }

	[Address(RVA = "0x2D0EC60", Offset = "0x2D0E060", Length = "0x3EF")]
	[Token(Token = "0x6000087")]
	private bool FirstIsBottomPt(OutPt btmPt1, OutPt btmPt2) { }

	[Address(RVA = "0x2D0F050", Offset = "0x2D0E450", Length = "0x60")]
	[Token(Token = "0x600006F")]
	internal void FixHoleLinkage(OutRec outRec) { }

	[Address(RVA = "0x2D0F0C0", Offset = "0x2D0E4C0", Length = "0x183")]
	[Token(Token = "0x60000B4")]
	private void FixupFirstLefts1(OutRec OldOutRec, OutRec NewOutRec) { }

	[Address(RVA = "0x2D0F250", Offset = "0x2D0E650", Length = "0x20E")]
	[Token(Token = "0x60000B5")]
	private void FixupFirstLefts2(OutRec innerOutRec, OutRec outerOutRec) { }

	[Address(RVA = "0x2D0F460", Offset = "0x2D0E860", Length = "0x153")]
	[Token(Token = "0x60000B6")]
	private void FixupFirstLefts3(OutRec OldOutRec, OutRec NewOutRec) { }

	[Address(RVA = "0x2D0F5C0", Offset = "0x2D0E9C0", Length = "0x2A5")]
	[Token(Token = "0x600009F")]
	private bool FixupIntersectionOrder() { }

	[Address(RVA = "0x2D0F870", Offset = "0x2D0EC70", Length = "0x4AC")]
	[Token(Token = "0x60000AC")]
	private void FixupOutPolygon(OutRec outRec) { }

	[Address(RVA = "0x2D0FD20", Offset = "0x2D0F120", Length = "0xF5")]
	[Token(Token = "0x60000AB")]
	private void FixupOutPolyline(OutRec outrec) { }

	[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000065")]
	public int get_LastIndex() { }

	[Address(RVA = "0xD11AF0", Offset = "0xD10EF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000067")]
	public bool get_ReverseSolution() { }

	[Address(RVA = "0x1D633F0", Offset = "0x1D627F0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000069")]
	public bool get_StrictlySimple() { }

	[Address(RVA = "0x2D0FE20", Offset = "0x2D0F220", Length = "0xE1")]
	[Token(Token = "0x6000088")]
	private OutPt GetBottomPt(OutPt pp) { }

	[Address(RVA = "0x2D0FF10", Offset = "0x2D0F310", Length = "0x43")]
	[Token(Token = "0x6000086")]
	private double GetDx(IntPoint pt1, IntPoint pt2) { }

	[Address(RVA = "0x2D0FF60", Offset = "0x2D0F360", Length = "0x52")]
	[Token(Token = "0x6000093")]
	private void GetHorzDirection(TEdge HorzEdge, out Directions Dir, out long Left, out long Right) { }

	[Address(RVA = "0x2D0FFC0", Offset = "0x2D0F3C0", Length = "0x77")]
	[Token(Token = "0x6000082")]
	private OutPt GetLastOutPt(TEdge e) { }

	[Address(RVA = "0x2D10040", Offset = "0x2D0F440", Length = "0xE3")]
	[Token(Token = "0x6000089")]
	private OutRec GetLowermostRec(OutRec outRec1, OutRec outRec2) { }

	[Address(RVA = "0x2D10200", Offset = "0x2D0F600", Length = "0x85")]
	[Token(Token = "0x6000099")]
	internal TEdge GetMaximaPair(TEdge e) { }

	[Address(RVA = "0x2D10130", Offset = "0x2D0F530", Length = "0xCC")]
	[Token(Token = "0x600009A")]
	internal TEdge GetMaximaPairEx(TEdge e) { }

	[Address(RVA = "0x2D10290", Offset = "0x2D0F690", Length = "0x2C")]
	[Token(Token = "0x6000095")]
	private TEdge GetNextInAEL(TEdge e, Directions Directions) { }

	[Address(RVA = "0x2D102C0", Offset = "0x2D0F6C0", Length = "0xA2")]
	[Token(Token = "0x600008B")]
	private OutRec GetOutRec(int idx) { }

	[Address(RVA = "0x2D10370", Offset = "0x2D0F770", Length = "0xFF")]
	[Token(Token = "0x60000AE")]
	private bool GetOverlap(long a1, long a2, long b1, long b2, out long Left, out long Right) { }

	[Address(RVA = "0x2D10470", Offset = "0x2D0F870", Length = "0x38")]
	[Token(Token = "0x6000084")]
	private bool HorzSegmentsOverlap(long seg1a, long seg1b, long seg2a, long seg2b) { }

	[Address(RVA = "0x2D104B0", Offset = "0x2D0F8B0", Length = "0x1AF")]
	[Token(Token = "0x6000075")]
	private void InsertEdgeIntoAEL(TEdge edge, TEdge startEdge) { }

	[Address(RVA = "0x2D10660", Offset = "0x2D0FA60", Length = "0x6F5")]
	[Token(Token = "0x6000074")]
	private void InsertLocalMinimaIntoAEL(long botY) { }

	[Address(RVA = "0x2D10D60", Offset = "0x2D10160", Length = "0x160")]
	[Token(Token = "0x6000064")]
	private void InsertMaxima(long X) { }

	[Address(RVA = "0x2D10ED0", Offset = "0x2D102D0", Length = "0x752")]
	[Token(Token = "0x6000090")]
	private void IntersectEdges(TEdge e1, TEdge e2, IntPoint pt) { }

	[Address(RVA = "0x2D11630", Offset = "0x2D10A30", Length = "0x1E")]
	[Token(Token = "0x600009E")]
	private static int IntersectNodeSort(IntersectNode node1, IntersectNode node2) { }

	[Address(RVA = "0x2D11650", Offset = "0x2D10A50", Length = "0x5F2")]
	[Token(Token = "0x60000A3")]
	private void IntersectPoint(TEdge edge1, TEdge edge2, out IntPoint ip) { }

	[Address(RVA = "0x2D11C50", Offset = "0x2D11050", Length = "0x1D9")]
	[Token(Token = "0x6000079")]
	private bool IsContributing(TEdge edge) { }

	[Address(RVA = "0x2D11E30", Offset = "0x2D11230", Length = "0x2F")]
	[Token(Token = "0x6000078")]
	private bool IsEvenOddAltFillType(TEdge edge) { }

	[Address(RVA = "0x2D11E60", Offset = "0x2D11260", Length = "0x2F")]
	[Token(Token = "0x6000077")]
	private bool IsEvenOddFillType(TEdge edge) { }

	[Address(RVA = "0x2D11E90", Offset = "0x2D11290", Length = "0x39")]
	[Token(Token = "0x6000098")]
	private bool IsIntermediate(TEdge e, double Y) { }

	[Address(RVA = "0x2D11ED0", Offset = "0x2D112D0", Length = "0x28")]
	[Token(Token = "0x6000097")]
	private bool IsMaxima(TEdge e, double Y) { }

	[Address(RVA = "0x2D11F00", Offset = "0x2D11300", Length = "0x45")]
	[Token(Token = "0x6000096")]
	private bool IsMinima(TEdge e) { }

	[Address(RVA = "0x2D11F50", Offset = "0x2D11350", Length = "0x996")]
	[Token(Token = "0x60000B8")]
	private void JoinCommonEdges() { }

	[Address(RVA = "0x2D128F0", Offset = "0x2D11CF0", Length = "0x451")]
	[Token(Token = "0x60000AF")]
	private bool JoinHorz(OutPt op1, OutPt op1b, OutPt op2, OutPt op2b, IntPoint Pt, bool DiscardLeft) { }

	[Address(RVA = "0x2D12D50", Offset = "0x2D12150", Length = "0xE24")]
	[Token(Token = "0x60000B0")]
	private bool JoinPoints(Join j, OutRec outRec1, OutRec outRec2) { }

	[Address(RVA = "0x2D13F90", Offset = "0x2D13390", Length = "0x60A")]
	[Token(Token = "0x60000C7")]
	internal static List<List`1<IntPoint>> Minkowski(List<IntPoint> pattern, List<IntPoint> path, bool IsSum, bool IsClosed) { }

	[Address(RVA = "0x2D13B80", Offset = "0x2D12F80", Length = "0xBC")]
	[Token(Token = "0x60000CB")]
	public static List<List`1<IntPoint>> MinkowskiDiff(List<IntPoint> poly1, List<IntPoint> poly2) { }

	[Address(RVA = "0x2D13C40", Offset = "0x2D13040", Length = "0xCB")]
	[Token(Token = "0x60000C8")]
	public static List<List`1<IntPoint>> MinkowskiSum(List<IntPoint> pattern, List<IntPoint> path, bool pathIsClosed) { }

	[Address(RVA = "0x2D13D10", Offset = "0x2D13110", Length = "0x273")]
	[Token(Token = "0x60000CA")]
	public static List<List`1<IntPoint>> MinkowskiSum(List<IntPoint> pattern, List<List`1<IntPoint>> paths, bool pathIsClosed) { }

	[Address(RVA = "0x2D145A0", Offset = "0x2D139A0", Length = "0x168")]
	[Token(Token = "0x60000CE")]
	public static List<List`1<IntPoint>> OpenPathsFromPolyTree(PolyTree polytree) { }

	[Address(RVA = "0x2D14710", Offset = "0x2D13B10", Length = "0x178")]
	[Token(Token = "0x60000A7")]
	public static bool Orientation(List<IntPoint> poly) { }

	[Address(RVA = "0x2D14890", Offset = "0x2D13C90", Length = "0x2A")]
	[Token(Token = "0x600008A")]
	private bool OutRec1RightOfOutRec2(OutRec outRec1, OutRec outRec2) { }

	[Address(RVA = "0x2D148C0", Offset = "0x2D13CC0", Length = "0x19")]
	[Token(Token = "0x60000B7")]
	private static OutRec ParseFirstLeft(OutRec FirstLeft) { }

	[Address(RVA = "0x2D148E0", Offset = "0x2D13CE0", Length = "0x2A")]
	[Token(Token = "0x60000A8")]
	private int PointCount(OutPt pts) { }

	[Address(RVA = "0x2D14A70", Offset = "0x2D13E70", Length = "0x2E7")]
	[Token(Token = "0x60000B1")]
	public static int PointInPolygon(IntPoint pt, List<IntPoint> path) { }

	[Address(RVA = "0x2D14910", Offset = "0x2D13D10", Length = "0x15B")]
	[Token(Token = "0x60000B2")]
	private static int PointInPolygon(IntPoint pt, OutPt op) { }

	[Address(RVA = "0x2D14D60", Offset = "0x2D14160", Length = "0x68")]
	[Token(Token = "0x60000C3")]
	private static bool PointsAreClose(IntPoint pt1, IntPoint pt2, double distSqrd) { }

	[Address(RVA = "0x2D14DD0", Offset = "0x2D141D0", Length = "0x18A")]
	[Token(Token = "0x60000B3")]
	private static bool Poly2ContainsPoly1(OutPt outPt1, OutPt outPt2) { }

	[Address(RVA = "0x2D14F60", Offset = "0x2D14360", Length = "0xA7")]
	[Token(Token = "0x60000CC")]
	public static List<List`1<IntPoint>> PolyTreeToPaths(PolyTree polytree) { }

	[Address(RVA = "0x2D15010", Offset = "0x2D14410", Length = "0xAB")]
	[Token(Token = "0x600007C")]
	internal bool PopEdgeFromSEL(out TEdge e) { }

	[Address(RVA = "0x2D150C0", Offset = "0x2D144C0", Length = "0x89B")]
	[Token(Token = "0x60000A4")]
	private void ProcessEdgesAtTopOfScanbeam(long topY) { }

	[Address(RVA = "0x2D15960", Offset = "0x2D14D60", Length = "0xF92")]
	[Token(Token = "0x6000094")]
	private void ProcessHorizontal(TEdge horzEdge) { }

	[Address(RVA = "0x2D16900", Offset = "0x2D15D00", Length = "0xCE")]
	[Token(Token = "0x6000092")]
	private void ProcessHorizontals() { }

	[Address(RVA = "0x2D16B00", Offset = "0x2D15F00", Length = "0x22F")]
	[Token(Token = "0x600009B")]
	private bool ProcessIntersections(long topY) { }

	[Address(RVA = "0x2D169D0", Offset = "0x2D15DD0", Length = "0x125")]
	[Token(Token = "0x60000A0")]
	private void ProcessIntersectList() { }

	[Address(RVA = "0x2D16D40", Offset = "0x2D16140", Length = "0x90")]
	[Token(Token = "0x60000A6")]
	public static void ReversePaths(List<List`1<IntPoint>> polys) { }

	[Address(RVA = "0x2D16DE0", Offset = "0x2D161E0", Length = "0x67")]
	[Token(Token = "0x600008D")]
	private void ReversePolyPtLinks(OutPt pp) { }

	[Address(RVA = "0x2D16E50", Offset = "0x2D16250", Length = "0x25")]
	[Token(Token = "0x60000A1")]
	internal static long Round(double value) { }

	[Address(RVA = "0xE26C10", Offset = "0xE26010", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000066")]
	public void set_LastIndex(int value) { }

	[Address(RVA = "0xD11C70", Offset = "0xD11070", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000068")]
	public void set_ReverseSolution(bool value) { }

	[Address(RVA = "0x28426D0", Offset = "0x2841AD0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600006A")]
	public void set_StrictlySimple(bool value) { }

	[Address(RVA = "0x2D16E80", Offset = "0x2D16280", Length = "0x111")]
	[Token(Token = "0x6000085")]
	private void SetHoleState(TEdge e, OutRec outRec) { }

	[Address(RVA = "0x2D16FA0", Offset = "0x2D163A0", Length = "0x293")]
	[Token(Token = "0x600007A")]
	private void SetWindingCount(TEdge edge) { }

	[Address(RVA = "0x2D17240", Offset = "0x2D16640", Length = "0xEA")]
	[Token(Token = "0x60000BE")]
	public static List<List`1<IntPoint>> SimplifyPolygon(List<IntPoint> poly, PolyFillTypes fillType = 0) { }

	[Address(RVA = "0x2D17330", Offset = "0x2D16730", Length = "0xEA")]
	[Token(Token = "0x60000BF")]
	public static List<List`1<IntPoint>> SimplifyPolygons(List<List`1<IntPoint>> polys, PolyFillTypes fillType = 0) { }

	[Address(RVA = "0x2D17420", Offset = "0x2D16820", Length = "0x2DA")]
	[Token(Token = "0x60000C2")]
	private static bool SlopesNearCollinear(IntPoint pt1, IntPoint pt2, IntPoint pt3, double distSqrd) { }

	[Address(RVA = "0x2D17700", Offset = "0x2D16B00", Length = "0x73")]
	[Token(Token = "0x6000083")]
	internal void SwapPoints(ref IntPoint pt1, ref IntPoint pt2) { }

	[Address(RVA = "0x2D17780", Offset = "0x2D16B80", Length = "0x32")]
	[Token(Token = "0x600008F")]
	private static void SwapPolyIndexes(TEdge edge1, TEdge edge2) { }

	[Address(RVA = "0x2D177C0", Offset = "0x2D16BC0", Length = "0x309")]
	[Token(Token = "0x600007E")]
	private void SwapPositionsInSEL(TEdge edge1, TEdge edge2) { }

	[Address(RVA = "0x2D17AD0", Offset = "0x2D16ED0", Length = "0x32")]
	[Token(Token = "0x600008E")]
	private static void SwapSides(TEdge edge1, TEdge edge2) { }

	[Address(RVA = "0x2D17B10", Offset = "0x2D16F10", Length = "0x69")]
	[Token(Token = "0x60000A2")]
	private static long TopX(TEdge edge, long currentY) { }

	[Address(RVA = "0x2D17B80", Offset = "0x2D16F80", Length = "0x222")]
	[Token(Token = "0x60000C9")]
	private static List<IntPoint> TranslatePath(List<IntPoint> path, IntPoint delta) { }

	[Address(RVA = "0x2D17DB0", Offset = "0x2D171B0", Length = "0x2F")]
	[Token(Token = "0x60000B9")]
	private void UpdateOutPtIdxs(OutRec outrec) { }

}

