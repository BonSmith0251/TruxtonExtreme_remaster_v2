namespace Unity.Cinemachine;

[Token(Token = "0x200018D")]
internal class ClipperOffset
{
	[Token(Token = "0x40006A2")]
	private const double TwoPi = 6.283185307179586; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000696")]
	private readonly List<PathGroup> _pathGroups; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000697")]
	private readonly List<PointD> _normals; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000698")]
	private readonly List<List`1<Point64>> solution; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000699")]
	private double _delta; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400069A")]
	private double _tmpLimit; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400069B")]
	private double _stepsPerRad; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400069C")]
	private JoinType _joinType; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400069D")]
	private double <ArcTolerance>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400069E")]
	private bool <MergeGroups>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400069F")]
	private double <MiterLimit>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40006A0")]
	private bool <PreserveCollinear>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x40006A1")]
	private bool <ReverseSolution>k__BackingField; //Field offset: 0x61

	[Token(Token = "0x1700015A")]
	public double ArcTolerance
	{
		[Address(RVA = "0x28A4270", Offset = "0x28A3670", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600082E")]
		 get { } //Length: 6
		[Address(RVA = "0x28A4280", Offset = "0x28A3680", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600082F")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700015B")]
	public bool MergeGroups
	{
		[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000830")]
		 get { } //Length: 5
		[Address(RVA = "0x1D3A970", Offset = "0x1D39D70", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000831")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700015C")]
	public double MiterLimit
	{
		[Address(RVA = "0x1CC8830", Offset = "0x1CC7C30", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000832")]
		 get { } //Length: 6
		[Address(RVA = "0x28A4290", Offset = "0x28A3690", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000833")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700015D")]
	public bool PreserveCollinear
	{
		[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000834")]
		 get { } //Length: 5
		[Address(RVA = "0x28A42A0", Offset = "0x28A36A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000835")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700015E")]
	public bool ReverseSolution
	{
		[Address(RVA = "0x1D3B270", Offset = "0x1D3A670", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000836")]
		 get { } //Length: 5
		[Address(RVA = "0x1FE3A30", Offset = "0x1FE2E30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000837")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x28A4120", Offset = "0x28A3520", Length = "0x146")]
	[Token(Token = "0x6000838")]
	public ClipperOffset(double miterLimit = 2, double arcTolerance = 0, bool preserveCollinear = false, bool reverseSolution = false) { }

	[Address(RVA = "0x289FED0", Offset = "0x289F2D0", Length = "0x183")]
	[Token(Token = "0x600083C")]
	public void AddPath(List<PointD> path, JoinType joinType, EndType endType) { }

	[Address(RVA = "0x289FD70", Offset = "0x289F170", Length = "0x155")]
	[Token(Token = "0x600083A")]
	public void AddPath(List<Point64> path, JoinType joinType, EndType endType) { }

	[Address(RVA = "0x28A0130", Offset = "0x289F530", Length = "0xFB")]
	[Token(Token = "0x600083D")]
	public void AddPaths(List<List`1<PointD>> paths, JoinType joinType, EndType endType) { }

	[Address(RVA = "0x28A0060", Offset = "0x289F460", Length = "0xC9")]
	[Token(Token = "0x600083B")]
	public void AddPaths(List<List`1<Point64>> paths, JoinType joinType, EndType endType) { }

	[Address(RVA = "0x28A0230", Offset = "0x289F630", Length = "0x62")]
	[Token(Token = "0x6000843")]
	private bool AlmostZero(double value, double epsilon = 0.001) { }

	[Address(RVA = "0x28A02A0", Offset = "0x289F6A0", Length = "0x456")]
	[Token(Token = "0x600084B")]
	private void BuildNormals(List<Point64> path) { }

	[Address(RVA = "0x28A0700", Offset = "0x289FB00", Length = "0x5F")]
	[Token(Token = "0x6000839")]
	public void Clear() { }

	[Address(RVA = "0x28A0760", Offset = "0x289FB60", Length = "0xC57")]
	[Token(Token = "0x6000851")]
	private void DoGroupOffset(PathGroup group, double delta) { }

	[Address(RVA = "0x28A13C0", Offset = "0x28A07C0", Length = "0x22D")]
	[Token(Token = "0x6000849")]
	private void DoMiter(PathGroup group, List<Point64> path, int j, int k, double cosA) { }

	[Address(RVA = "0x28A15F0", Offset = "0x28A09F0", Length = "0x42F")]
	[Token(Token = "0x600084A")]
	private void DoRound(PathGroup group, Point64 pt, PointD normal1, PointD normal2, double angle) { }

	[Address(RVA = "0x28A1A20", Offset = "0x28A0E20", Length = "0x76F")]
	[Token(Token = "0x6000848")]
	private void DoSquare(PathGroup group, List<Point64> path, int j, int k) { }

	[Address(RVA = "0x28A2190", Offset = "0x28A1590", Length = "0x508")]
	[Token(Token = "0x600083E")]
	public List<List`1<Point64>> Execute(double delta) { }

	[Address(RVA = "0x28A4270", Offset = "0x28A3670", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600082E")]
	public double get_ArcTolerance() { }

	[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000830")]
	public bool get_MergeGroups() { }

	[Address(RVA = "0x1CC8830", Offset = "0x1CC7C30", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000832")]
	public double get_MiterLimit() { }

	[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000834")]
	public bool get_PreserveCollinear() { }

	[Address(RVA = "0x1D3B270", Offset = "0x1D3A670", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000836")]
	public bool get_ReverseSolution() { }

	[Address(RVA = "0x28A26A0", Offset = "0x28A1AA0", Length = "0x119")]
	[Token(Token = "0x6000846")]
	private PointD GetAvgUnitVector(PointD vec1, PointD vec2) { }

	[Address(RVA = "0x28A27C0", Offset = "0x28A1BC0", Length = "0x190")]
	[Token(Token = "0x6000840")]
	private int GetLowestPolygonIdx(List<List`1<Point64>> paths) { }

	[Address(RVA = "0x28A2960", Offset = "0x28A1D60", Length = "0x105")]
	[Token(Token = "0x600083F")]
	internal static PointD GetUnitNormal(Point64 pt1, Point64 pt2) { }

	[Address(RVA = "0x28A2A70", Offset = "0x28A1E70", Length = "0xAF")]
	[Token(Token = "0x6000844")]
	private double Hypotenuse(double x, double y) { }

	[Address(RVA = "0x28A2B20", Offset = "0x28A1F20", Length = "0x17F")]
	[Token(Token = "0x6000847")]
	private PointD IntersectPoint(PointD pt1a, PointD pt1b, PointD pt2a, PointD pt2b) { }

	[Address(RVA = "0x28A2CA0", Offset = "0x28A20A0", Length = "0xE")]
	[Token(Token = "0x6000850")]
	private bool IsFullyOpenEndType(EndType et) { }

	[Address(RVA = "0x28A2CB0", Offset = "0x28A20B0", Length = "0xD0")]
	[Token(Token = "0x6000845")]
	private PointD NormalizeVector(PointD vec) { }

	[Address(RVA = "0x28A2D80", Offset = "0x28A2180", Length = "0x95")]
	[Token(Token = "0x600084E")]
	private void OffsetOpenJoined(PathGroup group, List<Point64> path) { }

	[Address(RVA = "0x28A2E20", Offset = "0x28A2220", Length = "0xA82")]
	[Token(Token = "0x600084F")]
	private void OffsetOpenPath(PathGroup group, List<Point64> path, EndType endType) { }

	[Address(RVA = "0x28A38B0", Offset = "0x28A2CB0", Length = "0x653")]
	[Token(Token = "0x600084C")]
	private void OffsetPoint(PathGroup group, List<Point64> path, int j, ref int k) { }

	[Address(RVA = "0x28A3F10", Offset = "0x28A3310", Length = "0x172")]
	[Token(Token = "0x600084D")]
	private void OffsetPolygon(PathGroup group, List<Point64> path) { }

	[Address(RVA = "0x28A4090", Offset = "0x28A3490", Length = "0x41")]
	[Token(Token = "0x6000842")]
	private PointD ReflectPoint(PointD pt, PointD pivot) { }

	[Address(RVA = "0x28A4280", Offset = "0x28A3680", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600082F")]
	public void set_ArcTolerance(double value) { }

	[Address(RVA = "0x1D3A970", Offset = "0x1D39D70", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000831")]
	public void set_MergeGroups(bool value) { }

	[Address(RVA = "0x28A4290", Offset = "0x28A3690", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000833")]
	public void set_MiterLimit(double value) { }

	[Address(RVA = "0x28A42A0", Offset = "0x28A36A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000835")]
	public void set_PreserveCollinear(bool value) { }

	[Address(RVA = "0x1FE3A30", Offset = "0x1FE2E30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000837")]
	public void set_ReverseSolution(bool value) { }

	[Address(RVA = "0x28A40E0", Offset = "0x28A34E0", Length = "0x34")]
	[Token(Token = "0x6000841")]
	private PointD TranslatePoint(PointD pt, double dx, double dy) { }

}

