namespace Unity.Cinemachine;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200017E")]
internal class ClipperBase
{
	[NullableContext(0)]
	[Token(Token = "0x200017F")]
	private struct IntersectListSort : IComparer<IntersectNode>
	{

		[Address(RVA = "0x28A42B0", Offset = "0x28A36B0", Length = "0x44")]
		[Token(Token = "0x60007F0")]
		public override int Compare(IntersectNode a, IntersectNode b) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400066A")]
	private ClipType _cliptype; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400066B")]
	private FillRule _fillrule; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Nullable(2)]
	[Token(Token = "0x400066C")]
	private Active _actives; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Nullable(2)]
	[Token(Token = "0x400066D")]
	private Active _sel; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Nullable(2)]
	[Token(Token = "0x400066E")]
	private Joiner _horzJoiners; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400066F")]
	private readonly List<LocalMinima> _minimaList; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000670")]
	private readonly List<IntersectNode> _intersectList; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000671")]
	private readonly List<Vertex> _vertexList; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000672")]
	private readonly List<OutRec> _outrecList; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Nullable(new IL2CPP_TYPE_U1[] {1, 2})]
	[Token(Token = "0x4000673")]
	private readonly List<Joiner> _joinerList; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000674")]
	private readonly List<Int64> _scanlineList; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000675")]
	private int _currentLocMin; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000676")]
	private long _currentBotY; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000677")]
	private bool _isSortedMinimaList; //Field offset: 0x70
	[FieldOffset(Offset = "0x71")]
	[Token(Token = "0x4000678")]
	private bool _hasOpenPaths; //Field offset: 0x71
	[FieldOffset(Offset = "0x72")]
	[Token(Token = "0x4000679")]
	internal bool _using_polytree; //Field offset: 0x72
	[FieldOffset(Offset = "0x73")]
	[Token(Token = "0x400067A")]
	internal bool _succeeded; //Field offset: 0x73
	[CompilerGenerated]
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x400067B")]
	private bool <PreserveCollinear>k__BackingField; //Field offset: 0x74
	[CompilerGenerated]
	[FieldOffset(Offset = "0x75")]
	[Token(Token = "0x400067C")]
	private bool <ReverseSolution>k__BackingField; //Field offset: 0x75

	[Token(Token = "0x1700014E")]
	public bool PreserveCollinear
	{
		[Address(RVA = "0x1D48530", Offset = "0x1D47930", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600076D")]
		 get { } //Length: 5
		[Address(RVA = "0x28937D0", Offset = "0x2892BD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600076E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700014F")]
	public bool ReverseSolution
	{
		[Address(RVA = "0x2470270", Offset = "0x246F670", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600076F")]
		 get { } //Length: 5
		[Address(RVA = "0x24702A0", Offset = "0x246F6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000770")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x28935F0", Offset = "0x28929F0", Length = "0x1DE")]
	[Token(Token = "0x6000771")]
	public ClipperBase() { }

	[Address(RVA = "0x28846C0", Offset = "0x2883AC0", Length = "0x20")]
	[Token(Token = "0x600079E")]
	public void AddClip(List<Point64> path) { }

	[Address(RVA = "0x28846E0", Offset = "0x2883AE0", Length = "0xB9")]
	[Token(Token = "0x60007DC")]
	private void AddJoin(OutPt op1, OutPt op2) { }

	[Address(RVA = "0x2884910", Offset = "0x2883D10", Length = "0x2BA")]
	[Token(Token = "0x60007B0")]
	private OutPt AddLocalMaxPoly(Active ae1, Active ae2, Point64 pt) { }

	[Address(RVA = "0x2884BD0", Offset = "0x2883FD0", Length = "0x2F7")]
	[Token(Token = "0x60007AF")]
	private OutPt AddLocalMinPoly(Active ae1, Active ae2, Point64 pt, bool isNew = false) { }

	[Address(RVA = "0x28847A0", Offset = "0x2883BA0", Length = "0x164")]
	[Token(Token = "0x600079A")]
	private void AddLocMin(Vertex vert, PathType polytype, bool isOpen) { }

	[Address(RVA = "0x2884ED0", Offset = "0x28842D0", Length = "0x294")]
	[Token(Token = "0x60007BC")]
	private void AddNewIntersectNode(Active ae1, Active ae2, long topY) { }

	[Address(RVA = "0x2885170", Offset = "0x2884570", Length = "0x1D")]
	[Token(Token = "0x600079D")]
	public void AddOpenSubject(List<Point64> path) { }

	[Address(RVA = "0x2885190", Offset = "0x2884590", Length = "0x19C")]
	[Token(Token = "0x60007B2")]
	private OutPt AddOutPt(Active ae, Point64 pt) { }

	[Address(RVA = "0x2885330", Offset = "0x2884730", Length = "0x130")]
	[Token(Token = "0x600079F")]
	protected void AddPath(List<Point64> path, PathType polytype, bool isOpen = false) { }

	[Address(RVA = "0x2885BA0", Offset = "0x2884FA0", Length = "0x1B")]
	[Token(Token = "0x60007A0")]
	protected void AddPaths(List<List`1<Point64>> paths, PathType polytype, bool isOpen = false) { }

	[Address(RVA = "0x2885470", Offset = "0x2884870", Length = "0x722")]
	[Token(Token = "0x600079B")]
	protected void AddPathsToVertexList(List<List`1<Point64>> paths, PathType polytype, bool isOpen) { }

	[Address(RVA = "0x2885BC0", Offset = "0x2884FC0", Length = "0x1D")]
	[Token(Token = "0x600079C")]
	public void AddSubject(List<Point64> path) { }

	[Address(RVA = "0x2885BE0", Offset = "0x2884FE0", Length = "0x17A")]
	[Token(Token = "0x60007D7")]
	private void AddTrialHorzJoin(OutPt op) { }

	[Address(RVA = "0x2885D60", Offset = "0x2885160", Length = "0x116")]
	[Token(Token = "0x60007B8")]
	private void AdjustCurrXAndCopyToSEL(long topY) { }

	[Address(RVA = "0x2885FB0", Offset = "0x28853B0", Length = "0x61")]
	[Token(Token = "0x600078C")]
	private static double Area(OutPt op) { }

	[Address(RVA = "0x2885F30", Offset = "0x2885330", Length = "0x72")]
	[Token(Token = "0x600078D")]
	private static double AreaTriangle(Point64 pt1, Point64 pt2, Point64 pt3) { }

	[Address(RVA = "0x2885E80", Offset = "0x2885280", Length = "0xAC")]
	[Token(Token = "0x60007C9")]
	private static bool AreReallyClose(Point64 pt1, Point64 pt2) { }

	[Address(RVA = "0x2886020", Offset = "0x2885420", Length = "0x354")]
	[Token(Token = "0x60007BF")]
	private bool BuildIntersectList(long topY) { }

	[Address(RVA = "0x2886380", Offset = "0x2885780", Length = "0x1D2")]
	[Token(Token = "0x60007E9")]
	internal bool BuildPath(OutPt op, bool reverse, bool isOpen, List<Point64> path) { }

	[Address(RVA = "0x2886560", Offset = "0x2885960", Length = "0x2A2")]
	[Token(Token = "0x60007EA")]
	protected bool BuildPaths(List<List`1<Point64>> solutionClosed, List<List`1<Point64>> solutionOpen) { }

	[Address(RVA = "0x2886810", Offset = "0x2885C10", Length = "0x406")]
	[Token(Token = "0x60007EE")]
	protected bool BuildTree(PolyPathBase polytree, List<List`1<Point64>> solutionOpen) { }

	[Address(RVA = "0x2886C20", Offset = "0x2886020", Length = "0x1D8")]
	[Token(Token = "0x60007E0")]
	private static bool CheckDisposeAdjacent(ref OutPt op, OutPt guard, OutRec outRec) { }

	[Address(RVA = "0x2886E00", Offset = "0x2886200", Length = "0x870")]
	[NullableContext(2)]
	[Token(Token = "0x60007E6")]
	private void CleanCollinear(OutRec outrec) { }

	[Address(RVA = "0x2887800", Offset = "0x2886C00", Length = "0xA7")]
	[Token(Token = "0x6000794")]
	public void Clear() { }

	[Address(RVA = "0x2887680", Offset = "0x2886A80", Length = "0x172")]
	[Token(Token = "0x6000793")]
	protected void ClearSolution() { }

	[Address(RVA = "0x28878B0", Offset = "0x2886CB0", Length = "0xFB")]
	[Token(Token = "0x60007CE")]
	private static bool CollinearSegsOverlap(Point64 seg1a, Point64 seg1b, Point64 seg2a, Point64 seg2b) { }

	[Address(RVA = "0x28879B0", Offset = "0x2886DB0", Length = "0x427")]
	[NullableContext(2)]
	[Token(Token = "0x60007E5")]
	private void CompleteSplit(OutPt op1, OutPt op2, OutRec outrec) { }

	[Address(RVA = "0x2887DE0", Offset = "0x28871E0", Length = "0x9BA")]
	[Token(Token = "0x60007DB")]
	private void ConvertHorzTrialsToJoins() { }

	[Address(RVA = "0x28887A0", Offset = "0x2887BA0", Length = "0x3EB")]
	[Token(Token = "0x60007ED")]
	private bool DeepCheckOwner(OutRec outrec, OutRec owner) { }

	[Address(RVA = "0x2880920", Offset = "0x287FD20", Length = "0x6E")]
	[Token(Token = "0x60007B7")]
	private void DeleteFromAEL(Active ae) { }

	[Address(RVA = "0x2888B90", Offset = "0x2887F90", Length = "0x153")]
	[Token(Token = "0x60007DE")]
	private void DeleteJoin(Joiner joiner) { }

	[Address(RVA = "0x2888CF0", Offset = "0x28880F0", Length = "0x179")]
	[Token(Token = "0x60007D9")]
	private void DeleteTrialHorzJoin(OutPt op) { }

	[Address(RVA = "0x2888E70", Offset = "0x2888270", Length = "0x5F")]
	[Token(Token = "0x60007BB")]
	private void DisposeIntersectNodes() { }

	[Address(RVA = "0x2880990", Offset = "0x287FD90", Length = "0x67")]
	[Token(Token = "0x60007D4")]
	private static OutPt DisposeOutPt(OutPt op) { }

	[Address(RVA = "0x2888ED0", Offset = "0x28882D0", Length = "0x74")]
	[Token(Token = "0x60007E1")]
	private static double DistanceFromLineSqrd(Point64 pt, Point64 linePt1, Point64 linePt2) { }

	[Address(RVA = "0x2834C30", Offset = "0x2834030", Length = "0x2B")]
	[Token(Token = "0x60007E2")]
	private static double DistanceSqr(Point64 pt1, Point64 pt2) { }

	[Address(RVA = "0x2888F50", Offset = "0x2888350", Length = "0x18A7")]
	[Token(Token = "0x60007C5")]
	private void DoHorizontal(Active horz) { }

	[Address(RVA = "0x288A800", Offset = "0x2889C00", Length = "0x75")]
	[Token(Token = "0x60007BA")]
	private void DoIntersections(long topY) { }

	[Address(RVA = "0x288A880", Offset = "0x2889C80", Length = "0x104E")]
	[Token(Token = "0x60007C7")]
	private Active DoMaxima(Active ae) { }

	[Address(RVA = "0x288B8D0", Offset = "0x288ACD0", Length = "0x5F8")]
	[Token(Token = "0x60007E7")]
	private OutPt DoSplitOp(ref OutPt outRecOp, OutPt splitOp) { }

	[Address(RVA = "0x288BED0", Offset = "0x288B2D0", Length = "0x115")]
	[Token(Token = "0x60007C6")]
	private void DoTopOfScanbeam(long y) { }

	[Address(RVA = "0x288BFF0", Offset = "0x288B3F0", Length = "0x34")]
	[Token(Token = "0x6000792")]
	private static bool EdgesAdjacentInAEL(IntersectNode inode) { }

	[Address(RVA = "0x288C030", Offset = "0x288B430", Length = "0x222")]
	[Token(Token = "0x60007B9")]
	protected void ExecuteInternal(ClipType ct, FillRule fillRule) { }

	[Address(RVA = "0x288C260", Offset = "0x288B660", Length = "0x58")]
	[Token(Token = "0x60007BD")]
	private Active ExtractFromSEL(Active ae) { }

	[Address(RVA = "0x288C2C0", Offset = "0x288B6C0", Length = "0xBC")]
	[Token(Token = "0x60007B5")]
	private Active FindEdgeWithMatchingLocMin(Active e) { }

	[Address(RVA = "0x288C380", Offset = "0x288B780", Length = "0x3F")]
	[Token(Token = "0x60007DD")]
	private static Joiner FindJoinParent(Joiner joiner, OutPt op) { }

	[Address(RVA = "0x288C3C0", Offset = "0x288B7C0", Length = "0x63")]
	[Token(Token = "0x60007D8")]
	private static Joiner FindTrialJoinParent(ref Joiner joiner, OutPt op) { }

	[Address(RVA = "0x288C430", Offset = "0x288B830", Length = "0x25F")]
	[Token(Token = "0x60007E8")]
	private void FixSelfIntersects(ref OutPt op) { }

	[Address(RVA = "0x1D48530", Offset = "0x1D47930", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600076D")]
	public bool get_PreserveCollinear() { }

	[Address(RVA = "0x2470270", Offset = "0x246F670", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600076F")]
	public bool get_ReverseSolution() { }

	[Address(RVA = "0x288C900", Offset = "0x288BD00", Length = "0x1F9")]
	[Token(Token = "0x60007EC")]
	private Rect64 GetBounds(List<Point64> path) { }

	[Address(RVA = "0x288C690", Offset = "0x288BA90", Length = "0x264")]
	[Token(Token = "0x60007EF")]
	public Rect64 GetBounds() { }

	[Address(RVA = "0x2880A00", Offset = "0x287FE00", Length = "0x72")]
	[Token(Token = "0x6000788")]
	private static Vertex GetCurrYMaximaVertex(Active ae) { }

	[Address(RVA = "0x288CB00", Offset = "0x288BF00", Length = "0x48")]
	[Token(Token = "0x6000779")]
	private static double GetDx(Point64 pt1, Point64 pt2) { }

	[Address(RVA = "0x288CB50", Offset = "0x288BF50", Length = "0x1E8")]
	[Token(Token = "0x60007DA")]
	private bool GetHorzExtendedHorzSeg(ref OutPt op, out OutPt op2) { }

	[Address(RVA = "0x288CD40", Offset = "0x288C140", Length = "0xCE")]
	[Token(Token = "0x6000789")]
	private static Active GetHorzMaximaPair(Active horz, Vertex maxVert) { }

	[Address(RVA = "0x288CE10", Offset = "0x288C210", Length = "0x46")]
	[Token(Token = "0x60007D0")]
	private Joiner GetHorzTrialParent(OutPt op) { }

	[Address(RVA = "0x288CE60", Offset = "0x288C260", Length = "0x257")]
	[Token(Token = "0x6000781")]
	private static Point64 GetIntersectPoint(Active ae1, Active ae2) { }

	[Address(RVA = "0x288D0C0", Offset = "0x288C4C0", Length = "0x45")]
	[Token(Token = "0x6000787")]
	private Active GetMaximaPair(Active ae) { }

	[Address(RVA = "0x288D110", Offset = "0x288C510", Length = "0x19")]
	[Token(Token = "0x600077F")]
	private static PathType GetPolyType(Active ae) { }

	[Address(RVA = "0x288D130", Offset = "0x288C530", Length = "0x35")]
	[Token(Token = "0x6000777")]
	private static Active GetPrevHotEdge(Active ae) { }

	[Address(RVA = "0x288D170", Offset = "0x288C570", Length = "0x19")]
	[NullableContext(2)]
	[Token(Token = "0x600078E")]
	private static OutRec GetRealOutRec(OutRec outRec) { }

	[Address(RVA = "0x288D190", Offset = "0x288C590", Length = "0x90")]
	[Token(Token = "0x6000798")]
	private bool HasLocMinAtY(long y) { }

	[Address(RVA = "0x2880A80", Offset = "0x287FE80", Length = "0x1F0")]
	[Token(Token = "0x60007CF")]
	private static bool HorzEdgesOverlap(long x1a, long x1b, long x2a, long x2b) { }

	[Address(RVA = "0x288D230", Offset = "0x288C630", Length = "0x51")]
	[Token(Token = "0x60007C3")]
	private bool HorzIsSpike(Active horz) { }

	[Address(RVA = "0x288D290", Offset = "0x288C690", Length = "0x75")]
	[Token(Token = "0x60007BE")]
	private void Insert1Before2InSEL(Active ae1, Active ae2) { }

	[Address(RVA = "0x288D310", Offset = "0x288C710", Length = "0x15A")]
	[Token(Token = "0x60007A6")]
	private void InsertLeftEdge(Active ae) { }

	[Address(RVA = "0x288D470", Offset = "0x288C870", Length = "0x88D")]
	[Token(Token = "0x60007A8")]
	private void InsertLocalMinimaIntoAEL(long botY) { }

	[Address(RVA = "0x288DD00", Offset = "0x288D100", Length = "0x10E")]
	[Token(Token = "0x60007D3")]
	private static OutPt InsertOp(Point64 pt, OutPt insertAfter) { }

	[Address(RVA = "0x288DE10", Offset = "0x288D210", Length = "0x75")]
	[Token(Token = "0x60007A7")]
	private void InsertRightEdge(Active ae, Active ae2) { }

	[Address(RVA = "0x288DE90", Offset = "0x288D290", Length = "0x80")]
	[Token(Token = "0x6000796")]
	private void InsertScanline(long y) { }

	[Address(RVA = "0x288DF20", Offset = "0x288D320", Length = "0x16F7")]
	[Token(Token = "0x60007B6")]
	private OutPt IntersectEdges(Active ae1, Active ae2, Point64 pt) { }

	[Address(RVA = "0x288F620", Offset = "0x288EA20", Length = "0x1BB")]
	[Token(Token = "0x60007A1")]
	private bool IsContributingClosed(Active ae) { }

	[Address(RVA = "0x288F7E0", Offset = "0x288EBE0", Length = "0x6D")]
	[Token(Token = "0x60007A2")]
	private bool IsContributingOpen(Active ae) { }

	[Address(RVA = "0x288F850", Offset = "0x288EC50", Length = "0x23")]
	[Token(Token = "0x6000778")]
	private static bool IsFront(Active ae) { }

	[Address(RVA = "0x288F880", Offset = "0x288EC80", Length = "0x2D")]
	[Token(Token = "0x600077D")]
	private static bool IsHeadingLeftHorz(Active ae) { }

	[Address(RVA = "0x288F8B0", Offset = "0x288ECB0", Length = "0x2D")]
	[Token(Token = "0x600077C")]
	private static bool IsHeadingRightHorz(Active ae) { }

	[Address(RVA = "0x288F8E0", Offset = "0x288ECE0", Length = "0x1E")]
	[Token(Token = "0x600077B")]
	private static bool IsHorizontal(Active ae) { }

	[Address(RVA = "0x288F900", Offset = "0x288ED00", Length = "0x1B")]
	[Token(Token = "0x6000773")]
	private static bool IsHotEdge(Active ae) { }

	[Address(RVA = "0x288F940", Offset = "0x288ED40", Length = "0x26")]
	[Token(Token = "0x6000786")]
	private static bool IsMaxima(Active ae) { }

	[Address(RVA = "0x288F920", Offset = "0x288ED20", Length = "0x1A")]
	[Token(Token = "0x6000785")]
	private static bool IsMaxima(Vertex vertex) { }

	[Address(RVA = "0x288F970", Offset = "0x288ED70", Length = "0x7")]
	[Token(Token = "0x6000772")]
	private static bool IsOdd(int val) { }

	[Address(RVA = "0x288F9E0", Offset = "0x288EDE0", Length = "0x1A")]
	[Token(Token = "0x6000774")]
	private static bool IsOpen(Active ae) { }

	[Address(RVA = "0x288F980", Offset = "0x288ED80", Length = "0x1A")]
	[Token(Token = "0x6000776")]
	private static bool IsOpenEnd(Vertex v) { }

	[Address(RVA = "0x288F9A0", Offset = "0x288EDA0", Length = "0x36")]
	[Token(Token = "0x6000775")]
	private static bool IsOpenEnd(Active ae) { }

	[Address(RVA = "0x288FA00", Offset = "0x288EE00", Length = "0x27")]
	[Token(Token = "0x6000780")]
	private static bool IsSamePolyType(Active ae1, Active ae2) { }

	[Address(RVA = "0x288FA30", Offset = "0x288EE30", Length = "0x443")]
	[Token(Token = "0x60007A5")]
	private bool IsValidAelOrder(Active resident, Active newcomer) { }

	[Address(RVA = "0x2880C80", Offset = "0x2880080", Length = "0x2E4")]
	[NullableContext(2)]
	[Token(Token = "0x60007CA")]
	private static bool IsValidClosedPath(OutPt op) { }

	[Address(RVA = "0x288FE80", Offset = "0x288F280", Length = "0x1A")]
	[Token(Token = "0x60007C8")]
	private static bool IsValidPath(OutPt op) { }

	[Address(RVA = "0x288FEA0", Offset = "0x288F2A0", Length = "0x344")]
	[Token(Token = "0x60007B1")]
	private void JoinOutrecPaths(Active ae1, Active ae2) { }

	[Address(RVA = "0x28901F0", Offset = "0x288F5F0", Length = "0x37")]
	[Token(Token = "0x6000783")]
	private static Vertex NextVertex(Active ae) { }

	[Address(RVA = "0x2890230", Offset = "0x288F630", Length = "0x65")]
	[Token(Token = "0x60007D1")]
	private bool OutPtInTrialHorzList(OutPt op) { }

	[Address(RVA = "0x28902A0", Offset = "0x288F6A0", Length = "0x23")]
	[Token(Token = "0x6000790")]
	private bool OutrecIsAscending(Active hotEdge) { }

	[Address(RVA = "0x28902D0", Offset = "0x288F6D0", Length = "0x30E")]
	[Token(Token = "0x60007EB")]
	private bool Path1InsidePath2(OutRec or1, OutRec or2) { }

	[Address(RVA = "0x28905E0", Offset = "0x288F9E0", Length = "0x6D")]
	[Token(Token = "0x60007CD")]
	private static bool PointBetween(Point64 pt, Point64 corner1, Point64 corner2) { }

	[Address(RVA = "0x2890650", Offset = "0x288FA50", Length = "0x47")]
	[NullableContext(2)]
	[Token(Token = "0x60007AA")]
	private bool PopHorz(out Active ae) { }

	[Address(RVA = "0x28906A0", Offset = "0x288FAA0", Length = "0x6C")]
	[Token(Token = "0x6000799")]
	private LocalMinima PopLocalMinima() { }

	[Address(RVA = "0x2890710", Offset = "0x288FB10", Length = "0x104")]
	[Token(Token = "0x6000797")]
	private bool PopScanline(out long y) { }

	[Address(RVA = "0x2890820", Offset = "0x288FC20", Length = "0x49")]
	[Token(Token = "0x6000784")]
	private Vertex PrevPrevVertex(Active ae) { }

	[Address(RVA = "0x2890870", Offset = "0x288FC70", Length = "0x385")]
	[Token(Token = "0x60007C0")]
	private void ProcessIntersectList() { }

	[Address(RVA = "0x2890CE0", Offset = "0x28900E0", Length = "0x13DB")]
	[Token(Token = "0x60007E3")]
	private OutRec ProcessJoin(Joiner j) { }

	[Address(RVA = "0x2890C00", Offset = "0x2890000", Length = "0xD2")]
	[Token(Token = "0x60007DF")]
	private void ProcessJoinList() { }

	[Address(RVA = "0x28920C0", Offset = "0x28914C0", Length = "0x45")]
	[Token(Token = "0x60007A9")]
	private void PushHorz(Active ae) { }

	[Address(RVA = "0x28921A0", Offset = "0x28915A0", Length = "0x1CC")]
	[Token(Token = "0x6000795")]
	protected void Reset() { }

	[Address(RVA = "0x2892110", Offset = "0x2891510", Length = "0x83")]
	[Token(Token = "0x60007C2")]
	private bool ResetHorzDirection(Active horz, Active maxPair, out long leftX, out long rightX) { }

	[Address(RVA = "0x2892370", Offset = "0x2891770", Length = "0x14D")]
	[Token(Token = "0x60007D6")]
	private void SafeDeleteOutPtJoiners(OutPt op) { }

	[Address(RVA = "0x28924C0", Offset = "0x28918C0", Length = "0xF5")]
	[Token(Token = "0x60007D5")]
	private void SafeDisposeOutPts(ref OutPt op) { }

	[Address(RVA = "0x28937D0", Offset = "0x2892BD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600076E")]
	public void set_PreserveCollinear(bool value) { }

	[Address(RVA = "0x24702A0", Offset = "0x246F6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000770")]
	public void set_ReverseSolution(bool value) { }

	[Address(RVA = "0x2880F70", Offset = "0x2880370", Length = "0x78")]
	[Token(Token = "0x6000782")]
	private static void SetDx(Active ae) { }

	[Address(RVA = "0x2880FF0", Offset = "0x28803F0", Length = "0x41")]
	[Token(Token = "0x600078A")]
	private static void SetSides(OutRec outrec, Active startEdge, Active endEdge) { }

	[Address(RVA = "0x28925C0", Offset = "0x28919C0", Length = "0x1C0")]
	[Token(Token = "0x60007A3")]
	private void SetWindCountForClosedPathEdge(Active ae) { }

	[Address(RVA = "0x2892790", Offset = "0x2891B90", Length = "0xA4")]
	[Token(Token = "0x60007A4")]
	private void SetWindCountForOpenPathEdge(Active ae) { }

	[Address(RVA = "0x2892840", Offset = "0x2891C40", Length = "0x234")]
	[Token(Token = "0x60007B3")]
	private OutPt StartOpenPath(Active ae, Point64 pt) { }

	[Address(RVA = "0x2892A80", Offset = "0x2891E80", Length = "0x39")]
	[Token(Token = "0x600077E")]
	private static void SwapActives(ref Active ae1, ref Active ae2) { }

	[Address(RVA = "0x2892AC0", Offset = "0x2891EC0", Length = "0x61")]
	[Token(Token = "0x6000791")]
	private static void SwapFrontBackSides(OutRec outrec) { }

	[Address(RVA = "0x2892B30", Offset = "0x2891F30", Length = "0xE0")]
	[Token(Token = "0x600078B")]
	private static void SwapOutrecs(Active ae1, Active ae2) { }

	[Address(RVA = "0x2892C20", Offset = "0x2892020", Length = "0xDB")]
	[Token(Token = "0x60007C1")]
	private void SwapPositionsInAEL(Active ae1, Active ae2) { }

	[Address(RVA = "0x2881040", Offset = "0x2880440", Length = "0x119")]
	[Token(Token = "0x60007AD")]
	private bool TestJoinWithNext1(Active e, long currY) { }

	[Address(RVA = "0x2892D00", Offset = "0x2892100", Length = "0x181")]
	[Token(Token = "0x60007AE")]
	private bool TestJoinWithNext2(Active e, Point64 currPt) { }

	[Address(RVA = "0x2881160", Offset = "0x2880560", Length = "0x36B")]
	[Token(Token = "0x60007AB")]
	private bool TestJoinWithPrev1(Active e, long currY) { }

	[Address(RVA = "0x2892E90", Offset = "0x2892290", Length = "0x181")]
	[Token(Token = "0x60007AC")]
	private bool TestJoinWithPrev2(Active e, Point64 currPt) { }

	[Address(RVA = "0x2893020", Offset = "0x2892420", Length = "0xBB")]
	[Token(Token = "0x600077A")]
	private static long TopX(Active ae, long currentY) { }

	[Address(RVA = "0x28930E0", Offset = "0x28924E0", Length = "0x188")]
	[Token(Token = "0x60007C4")]
	private bool TrimHorz(Active horzEdge, bool preserveCollinear) { }

	[Address(RVA = "0x2893270", Offset = "0x2892670", Length = "0x78")]
	[Token(Token = "0x600078F")]
	private static void UncoupleOutRec(Active ae) { }

	[Address(RVA = "0x28932F0", Offset = "0x28926F0", Length = "0x204")]
	[Token(Token = "0x60007B4")]
	private void UpdateEdgeIntoAEL(Active ae) { }

	[Address(RVA = "0x2893500", Offset = "0x2892900", Length = "0x45")]
	[Token(Token = "0x60007E4")]
	private static void UpdateOutrecOwner(OutRec outrec) { }

	[Address(RVA = "0x2893550", Offset = "0x2892950", Length = "0x4C")]
	[NullableContext(2)]
	[Token(Token = "0x60007D2")]
	private bool ValidateClosedPathEx(ref OutPt op) { }

	[Address(RVA = "0x28935A0", Offset = "0x28929A0", Length = "0x2A")]
	[Token(Token = "0x60007CB")]
	private static bool ValueBetween(long val, long end1, long end2) { }

	[Address(RVA = "0x28935D0", Offset = "0x28929D0", Length = "0x1C")]
	[Token(Token = "0x60007CC")]
	private static bool ValueEqualOrBetween(long val, long end1, long end2) { }

}

