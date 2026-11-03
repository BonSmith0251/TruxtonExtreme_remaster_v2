namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000022")]
internal class ClipperBase
{
	[Token(Token = "0x4000073")]
	internal const double horizontal = -3.4E+38; //Field offset: 0x0
	[Token(Token = "0x4000074")]
	internal const int Skip = -2; //Field offset: 0x0
	[Token(Token = "0x4000075")]
	internal const int Unassigned = -1; //Field offset: 0x0
	[Token(Token = "0x4000076")]
	internal const double tolerance = 1E-20; //Field offset: 0x0
	[Token(Token = "0x4000077")]
	public const long loRange = 1073741823; //Field offset: 0x0
	[Token(Token = "0x4000078")]
	public const long hiRange = 4611686018427387903; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000079")]
	internal LocalMinima m_MinimaList; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400007A")]
	internal LocalMinima m_CurrentLM; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400007B")]
	internal List<List`1<TEdge>> m_edges; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400007C")]
	internal Scanbeam m_Scanbeam; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400007D")]
	internal List<OutRec> m_PolyOuts; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400007E")]
	internal TEdge m_ActiveEdges; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400007F")]
	internal bool m_UseFullRange; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x4000080")]
	internal bool m_HasOpenPaths; //Field offset: 0x41
	[CompilerGenerated]
	[FieldOffset(Offset = "0x42")]
	[Token(Token = "0x4000081")]
	private bool <PreserveCollinear>k__BackingField; //Field offset: 0x42

	[Token(Token = "0x17000008")]
	public bool PreserveCollinear
	{
		[Address(RVA = "0x1DDDDC0", Offset = "0x1DDD1C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600003F")]
		 get { } //Length: 5
		[Address(RVA = "0x1DDDAC0", Offset = "0x1DDCEC0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000040")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2D09C10", Offset = "0x2D09010", Length = "0x9C")]
	[Token(Token = "0x6000049")]
	internal ClipperBase() { }

	[Address(RVA = "0x2D052E0", Offset = "0x2D046E0", Length = "0x1E8E")]
	[Token(Token = "0x6000051")]
	public bool AddPath(List<IntPoint> pg, PolyTypes polyType, bool Closed) { }

	[Address(RVA = "0x2D07170", Offset = "0x2D06570", Length = "0xC9")]
	[Token(Token = "0x6000052")]
	public bool AddPaths(List<List`1<IntPoint>> ppg, PolyTypes polyType, bool closed) { }

	[Address(RVA = "0x2D07240", Offset = "0x2D06640", Length = "0x1C3")]
	[Token(Token = "0x600004A")]
	public override void Clear() { }

	[Address(RVA = "0x2D07410", Offset = "0x2D06810", Length = "0x142")]
	[Token(Token = "0x600005E")]
	internal OutRec CreateOutRec() { }

	[Address(RVA = "0x2D07560", Offset = "0x2D06960", Length = "0xB6")]
	[Token(Token = "0x6000062")]
	internal void DeleteFromAEL(TEdge e) { }

	[Address(RVA = "0x2D07620", Offset = "0x2D06A20", Length = "0x7A")]
	[Token(Token = "0x600004B")]
	private void DisposeLocalMinimaList() { }

	[Address(RVA = "0x2D076A0", Offset = "0x2D06AA0", Length = "0x8F")]
	[Token(Token = "0x600005F")]
	internal void DisposeOutRec(int index) { }

	[Address(RVA = "0x2D07730", Offset = "0x2D06B30", Length = "0x127")]
	[Token(Token = "0x600004F")]
	private TEdge FindNextLocMin(TEdge E) { }

	[Address(RVA = "0x1DDDDC0", Offset = "0x1DDD1C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600003F")]
	public bool get_PreserveCollinear() { }

	[Address(RVA = "0x2D07860", Offset = "0x2D06C60", Length = "0x37F")]
	[Token(Token = "0x600005A")]
	public static IntRect GetBounds(List<List`1<IntPoint>> paths) { }

	[Address(RVA = "0x2D07D00", Offset = "0x2D07100", Length = "0x77")]
	[Token(Token = "0x600004D")]
	private void InitEdge(TEdge e, TEdge eNext, TEdge ePrev, IntPoint pt) { }

	[Address(RVA = "0x2D07BE0", Offset = "0x2D06FE0", Length = "0x112")]
	[Token(Token = "0x600004E")]
	private void InitEdge2(TEdge e, PolyTypes polyType) { }

	[Address(RVA = "0x2D07D80", Offset = "0x2D07180", Length = "0xBC")]
	[Token(Token = "0x6000056")]
	private void InsertLocalMinima(LocalMinima newLm) { }

	[Address(RVA = "0x2D07E40", Offset = "0x2D07240", Length = "0x169")]
	[Token(Token = "0x600005B")]
	internal void InsertScanbeam(long Y) { }

	[Address(RVA = "0x2D07FB0", Offset = "0x2D073B0", Length = "0x1E")]
	[Token(Token = "0x6000042")]
	internal static bool IsHorizontal(TEdge e) { }

	[Address(RVA = "0x20B1050", Offset = "0x20B0450", Length = "0x9")]
	[Token(Token = "0x600005D")]
	internal bool LocalMinimaPending() { }

	[Address(RVA = "0x2D09CB0", Offset = "0x2D090B0", Length = "0x20")]
	[Token(Token = "0x600003E")]
	internal static bool near_zero(double val) { }

	[Address(RVA = "0x2D07FD0", Offset = "0x2D073D0", Length = "0x45")]
	[Token(Token = "0x6000043")]
	internal bool PointIsVertex(IntPoint pt, OutPt pp) { }

	[Address(RVA = "0x2D08020", Offset = "0x2D07420", Length = "0x27A")]
	[Token(Token = "0x6000044")]
	internal bool PointOnLineSegment(IntPoint pt, IntPoint linePt1, IntPoint linePt2, bool UseFullRange) { }

	[Address(RVA = "0x2D082A0", Offset = "0x2D076A0", Length = "0x2B0")]
	[Token(Token = "0x6000045")]
	internal bool PointOnPolygon(IntPoint pt, OutPt pp, bool UseFullRange) { }

	[Address(RVA = "0x2D08560", Offset = "0x2D07960", Length = "0x5B")]
	[Token(Token = "0x6000057")]
	internal bool PopLocalMinima(long Y, out LocalMinima current) { }

	[Address(RVA = "0x2D085C0", Offset = "0x2D079C0", Length = "0x4A")]
	[Token(Token = "0x600005C")]
	internal bool PopScanbeam(out long Y) { }

	[Address(RVA = "0x2D08610", Offset = "0x2D07A10", Length = "0x639")]
	[Token(Token = "0x6000050")]
	private TEdge ProcessBound(TEdge E, bool LeftBoundIsForward) { }

	[Address(RVA = "0x2D08C50", Offset = "0x2D08050", Length = "0x94")]
	[Token(Token = "0x6000053")]
	internal bool Pt2IsBetweenPt1AndPt3(IntPoint pt1, IntPoint pt2, IntPoint pt3) { }

	[Address(RVA = "0x2D08CF0", Offset = "0x2D080F0", Length = "0x134")]
	[Token(Token = "0x600004C")]
	private void RangeTest(IntPoint Pt, ref bool useFullRange) { }

	[Address(RVA = "0x2D08E30", Offset = "0x2D08230", Length = "0x92")]
	[Token(Token = "0x6000054")]
	private TEdge RemoveEdge(TEdge e) { }

	[Address(RVA = "0x2D08ED0", Offset = "0x2D082D0", Length = "0x241")]
	[Token(Token = "0x6000059")]
	internal override void Reset() { }

	[Address(RVA = "0x2D09120", Offset = "0x2D08520", Length = "0x23")]
	[Token(Token = "0x6000058")]
	private void ReverseHorizontal(TEdge e) { }

	[Address(RVA = "0x1DDDAC0", Offset = "0x1DDCEC0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000040")]
	public void set_PreserveCollinear(bool value) { }

	[Address(RVA = "0x2D09150", Offset = "0x2D08550", Length = "0x6C")]
	[Token(Token = "0x6000055")]
	private void SetDx(TEdge e) { }

	[Address(RVA = "0x2D091C0", Offset = "0x2D085C0", Length = "0x175")]
	[Token(Token = "0x6000046")]
	internal static bool SlopesEqual(TEdge e1, TEdge e2, bool UseFullRange) { }

	[Address(RVA = "0x2D094D0", Offset = "0x2D088D0", Length = "0x1A7")]
	[Token(Token = "0x6000047")]
	internal static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, bool UseFullRange) { }

	[Address(RVA = "0x2D09340", Offset = "0x2D08740", Length = "0x18C")]
	[Token(Token = "0x6000048")]
	internal static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, IntPoint pt4, bool UseFullRange) { }

	[Address(RVA = "0x2D09990", Offset = "0x2D08D90", Length = "0xD")]
	[Token(Token = "0x6000041")]
	public void Swap(ref long val1, ref long val2) { }

	[Address(RVA = "0x2D09680", Offset = "0x2D08A80", Length = "0x301")]
	[Token(Token = "0x6000061")]
	internal void SwapPositionsInAEL(TEdge edge1, TEdge edge2) { }

	[Address(RVA = "0x2D099A0", Offset = "0x2D08DA0", Length = "0x263")]
	[Token(Token = "0x6000060")]
	internal void UpdateEdgeIntoAEL(ref TEdge e) { }

}

