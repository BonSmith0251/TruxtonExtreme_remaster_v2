namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000025")]
internal class ClipperOffset
{
	[Token(Token = "0x40000A3")]
	private const double two_pi = 6.283185307179586; //Field offset: 0x0
	[Token(Token = "0x40000A4")]
	private const double def_arc_tolerance = 0.25; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000097")]
	private List<List`1<IntPoint>> m_destPolys; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000098")]
	private List<IntPoint> m_srcPoly; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000099")]
	private List<IntPoint> m_destPoly; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400009A")]
	private List<DoublePoint> m_normals; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400009B")]
	private double m_delta; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400009C")]
	private double m_sinA; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400009D")]
	private double m_sin; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400009E")]
	private double m_cos; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400009F")]
	private double m_StepsPerRad; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000A0")]
	private IntPoint m_lowest; //Field offset: 0x58
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40000A1")]
	private PolyNode m_polyNodes; //Field offset: 0x88
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40000A2")]
	private double <ArcTolerance>k__BackingField; //Field offset: 0x90

	[Token(Token = "0x1700000C")]
	public double ArcTolerance
	{
		[Address(RVA = "0x2D1D1F0", Offset = "0x2D1C5F0", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x60000D0")]
		 get { } //Length: 9
		[Address(RVA = "0x2D1D200", Offset = "0x2D1C600", Length = "0x9")]
		[CompilerGenerated]
		[Token(Token = "0x60000D1")]
		 set { } //Length: 9
	}

	[Address(RVA = "0x2D1D120", Offset = "0x2D1C520", Length = "0xD0")]
	[Token(Token = "0x60000D2")]
	public ClipperOffset(double arcTolerance = 0.25) { }

	[Address(RVA = "0x2D19370", Offset = "0x2D18770", Length = "0x58F")]
	[Token(Token = "0x60000D5")]
	public void AddPath(List<IntPoint> path, JoinTypes joinType, EndTypes endType) { }

	[Address(RVA = "0x2D19900", Offset = "0x2D18D00", Length = "0xB0")]
	[Token(Token = "0x60000D6")]
	public void AddPaths(List<List`1<IntPoint>> paths, JoinTypes joinType, EndTypes endType) { }

	[Address(RVA = "0x2D199C0", Offset = "0x2D18DC0", Length = "0x6E")]
	[Token(Token = "0x60000D3")]
	public void Clear() { }

	[Address(RVA = "0x2D19A30", Offset = "0x2D18E30", Length = "0x330")]
	[Token(Token = "0x60000DE")]
	internal void DoMiter(int j, int k, double r) { }

	[Address(RVA = "0x2D19D70", Offset = "0x2D19170", Length = "0xF48")]
	[Token(Token = "0x60000D9")]
	private void DoOffset(double delta) { }

	[Address(RVA = "0x2D1ACC0", Offset = "0x2D1A0C0", Length = "0x5C5")]
	[Token(Token = "0x60000DF")]
	internal void DoRound(int j, int k) { }

	[Address(RVA = "0x2D1B290", Offset = "0x2D1A690", Length = "0x6BD")]
	[Token(Token = "0x60000DD")]
	internal void DoSquare(int j, int k) { }

	[Address(RVA = "0x2D1BFD0", Offset = "0x2D1B3D0", Length = "0x50F")]
	[Token(Token = "0x60000DA")]
	public void Execute(ref List<List`1<IntPoint>>& solution, double delta, int inputSize) { }

	[Address(RVA = "0x2D1B950", Offset = "0x2D1AD50", Length = "0x67F")]
	[Token(Token = "0x60000DB")]
	public void Execute(ref PolyTree solution, double delta) { }

	[Address(RVA = "0x2D1C4E0", Offset = "0x2D1B8E0", Length = "0x1DA")]
	[Token(Token = "0x60000D7")]
	private void FixOrientations() { }

	[Address(RVA = "0x2D1D1F0", Offset = "0x2D1C5F0", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x60000D0")]
	public double get_ArcTolerance() { }

	[Address(RVA = "0x2D1C6C0", Offset = "0x2D1BAC0", Length = "0x10F")]
	[Token(Token = "0x60000D8")]
	internal static DoublePoint GetUnitNormal(IntPoint pt1, IntPoint pt2) { }

	[Address(RVA = "0x2D1C7D0", Offset = "0x2D1BBD0", Length = "0x944")]
	[Token(Token = "0x60000DC")]
	private void OffsetPoint(int j, ref int k, JoinTypes jointype) { }

	[Address(RVA = "0x2D16E50", Offset = "0x2D16250", Length = "0x25")]
	[Token(Token = "0x60000D4")]
	internal static long Round(double value) { }

	[Address(RVA = "0x2D1D200", Offset = "0x2D1C600", Length = "0x9")]
	[CompilerGenerated]
	[Token(Token = "0x60000D1")]
	public void set_ArcTolerance(double value) { }

}

