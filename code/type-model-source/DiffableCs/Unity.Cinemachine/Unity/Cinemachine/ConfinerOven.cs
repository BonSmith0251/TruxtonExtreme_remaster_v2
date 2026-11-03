namespace Unity.Cinemachine;

[Token(Token = "0x20000B1")]
internal class ConfinerOven
{
	[IsReadOnly]
	[Token(Token = "0x20000B4")]
	private struct AspectStretcher
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002C8")]
		private readonly float <Aspect>k__BackingField; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40002C9")]
		private readonly float m_InverseAspect; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40002CA")]
		private readonly float m_CenterX; //Field offset: 0x8

		[Token(Token = "0x170000C7")]
		public float Aspect
		{
			[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000392")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x28338E0", Offset = "0x2832CE0", Length = "0x1B")]
		[Token(Token = "0x6000393")]
		public AspectStretcher(float aspect, float centerX) { }

		[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000392")]
		public float get_Aspect() { }

		[Address(RVA = "0x2833880", Offset = "0x2832C80", Length = "0x29")]
		[Token(Token = "0x6000394")]
		public Vector2 Stretch(Vector2 p) { }

		[Address(RVA = "0x28338B0", Offset = "0x2832CB0", Length = "0x28")]
		[Token(Token = "0x6000395")]
		public Vector2 Unstretch(Vector2 p) { }

	}

	[Token(Token = "0x20000B3")]
	internal class BakedSolution
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002C1")]
		private float m_FrustumSizeIntSpace; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40002C2")]
		private readonly AspectStretcher m_AspectStretcher; //Field offset: 0x14
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40002C3")]
		private readonly bool m_HasBones; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40002C4")]
		private readonly double m_SqrPolygonDiagonal; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40002C5")]
		private List<List`1<Point64>> m_OriginalPolygon; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40002C6")]
		internal List<List`1<Point64>> m_Solution; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40002C7")]
		private FloatToIntScaler m_FloatToInt; //Field offset: 0x40

		[Address(RVA = "0x2834C60", Offset = "0x2834060", Length = "0x190")]
		[Token(Token = "0x6000389")]
		public BakedSolution(float aspectRatio, float frustumHeight, bool hasBones, Rect polygonBounds, List<List`1<Point64>> originalPolygon, List<List`1<Point64>> solution) { }

		[Address(RVA = "0x2834810", Offset = "0x2833C10", Length = "0xB3")]
		[CompilerGenerated]
		[Token(Token = "0x600038F")]
		private float <ConfinePoint>g__ClosestPointOnSegment|9_2(Point64 point, Point64 s0, Point64 s1) { }

		[Address(RVA = "0x28348D0", Offset = "0x2833CD0", Length = "0x1CD")]
		[CompilerGenerated]
		[Token(Token = "0x6000390")]
		private bool <ConfinePoint>g__DoesIntersectOriginal|9_3(Point64 l1, Point64 l2) { }

		[Address(RVA = "0x2834AA0", Offset = "0x2833EA0", Length = "0x98")]
		[CompilerGenerated]
		[Token(Token = "0x600038D")]
		internal static Point64 <ConfinePoint>g__IntPointLerp|9_0(Point64 a, Point64 b, float lerp) { }

		[Address(RVA = "0x2834B40", Offset = "0x2833F40", Length = "0xE1")]
		[CompilerGenerated]
		[Token(Token = "0x600038E")]
		private bool <ConfinePoint>g__IsInsideOriginal|9_1(Point64 point) { }

		[Address(RVA = "0x2834C30", Offset = "0x2834030", Length = "0x2B")]
		[CompilerGenerated]
		[Token(Token = "0x6000391")]
		internal static double <FindIntersection>g__IntPointDiffSqrMagnitude|10_0(Point64 point1, Point64 point2) { }

		[Address(RVA = "0x2833FB0", Offset = "0x28333B0", Length = "0x616")]
		[Token(Token = "0x600038B")]
		public Vector2 ConfinePoint(in Vector2 pointToConfine) { }

		[Address(RVA = "0x28345D0", Offset = "0x28339D0", Length = "0x234")]
		[Token(Token = "0x600038C")]
		private static int FindIntersection(in Point64 p1, in Point64 p2, in Point64 p3, in Point64 p4, double epsilon) { }

		[Address(RVA = "0xF51B30", Offset = "0xF50F30", Length = "0x9")]
		[Token(Token = "0x600038A")]
		public bool IsValid() { }

	}

	[Token(Token = "0x20000B6")]
	internal enum BakingState : int
	{
		BAKING = 0,
		BAKED = 1,
		TIMEOUT = 2,
	}

	[Token(Token = "0x20000B7")]
	private struct BakingStateCache
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002D1")]
		public ClipperOffset offsetter; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40002D2")]
		public List<PolygonSolution> solutions; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002D3")]
		public PolygonSolution rightCandidate; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40002D4")]
		public PolygonSolution leftCandidate; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40002D5")]
		public List<List`1<Point64>> userSetMaxCandidate; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40002D6")]
		public List<List`1<Point64>> theoreticalMaxCandidate; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40002D7")]
		public float stepSize; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x40002D8")]
		public float maxFrustumHeight; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40002D9")]
		public float userSetMaxFrustumHeight; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x40002DA")]
		public float theoreticalMaxFrustumHeight; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40002DB")]
		public float currentFrustumHeight; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x40002DC")]
		public float bakeTime; //Field offset: 0x54

	}

	[Token(Token = "0x20000B2")]
	private class FloatToIntScaler
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002BF")]
		private readonly long m_FloatToInt; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40002C0")]
		private readonly float m_IntToFloat; //Field offset: 0x18

		[Token(Token = "0x170000C6")]
		public float ClipperEpsilon
		{
			[Address(RVA = "0x2844BC0", Offset = "0x2843FC0", Length = "0x12")]
			[Token(Token = "0x6000387")]
			 get { } //Length: 18
		}

		[Address(RVA = "0x2844B00", Offset = "0x2843F00", Length = "0xBE")]
		[Token(Token = "0x6000388")]
		public FloatToIntScaler(Rect polygonBounds) { }

		[Address(RVA = "0x2844AE0", Offset = "0x2843EE0", Length = "0xE")]
		[Token(Token = "0x6000385")]
		public float FloatToInt(float f) { }

		[Address(RVA = "0x2844BC0", Offset = "0x2843FC0", Length = "0x12")]
		[Token(Token = "0x6000387")]
		public float get_ClipperEpsilon() { }

		[Address(RVA = "0x2844AF0", Offset = "0x2843EF0", Length = "0xE")]
		[Token(Token = "0x6000386")]
		public float IntToFloat(long i) { }

	}

	[Token(Token = "0x20000B5")]
	private struct PolygonSolution
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002CB")]
		public List<List`1<Point64>> polygons; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40002CC")]
		public float frustumHeight; //Field offset: 0x8

		[Token(Token = "0x170000C8")]
		public bool IsNull
		{
			[Address(RVA = "0x1F12030", Offset = "0x1F11430", Length = "0x8")]
			[Token(Token = "0x6000397")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x1F12030", Offset = "0x1F11430", Length = "0x8")]
		[Token(Token = "0x6000397")]
		public bool get_IsNull() { }

		[Address(RVA = "0x2847680", Offset = "0x2846A80", Length = "0xE4")]
		[Token(Token = "0x6000396")]
		public bool StateChanged(in List<List`1<Point64>>& paths) { }

	}

	[Token(Token = "0x40002B8")]
	private const int k_MiterLimit = 2; //Field offset: 0x0
	[Token(Token = "0x40002B9")]
	private const float k_MaxComputationTimeForFullSkeletonBakeInSeconds = 5; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002B2")]
	private float m_MinFrustumHeightWithBones; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40002B3")]
	private float m_SkeletonPadding; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002B4")]
	private List<List`1<Point64>> m_OriginalPolygon; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002B5")]
	private Point64 m_MidPoint; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002B6")]
	internal List<List`1<Point64>> m_Skeleton; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002B7")]
	private FloatToIntScaler m_FloatToInt; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002BA")]
	private Rect m_PolygonRect; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002BB")]
	private AspectStretcher m_AspectStretcher; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40002BC")]
	private BakingState <State>k__BackingField; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40002BD")]
	public float bakeProgress; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40002BE")]
	private BakingStateCache m_Cache; //Field offset: 0x68

	[Token(Token = "0x170000C5")]
	public private BakingState State
	{
		[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600037E")]
		 get { } //Length: 4
		[Address(RVA = "0x2471CE0", Offset = "0x24710E0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600037F")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x2843DF0", Offset = "0x28431F0", Length = "0x107")]
	[Token(Token = "0x600037C")]
	public ConfinerOven(in List<List`1<Vector2>>& inputPath, in float aspectRatio, float maxFrustumHeight, float skeletonPadding) { }

	[Address(RVA = "0x2843800", Offset = "0x2842C00", Length = "0x3C0")]
	[CompilerGenerated]
	[Token(Token = "0x6000384")]
	private void <BakeConfiner>g__ComputeSkeleton|25_0(in List<PolygonSolution>& solutions) { }

	[Address(RVA = "0x2843BD0", Offset = "0x2842FD0", Length = "0x1C2")]
	[CompilerGenerated]
	[Token(Token = "0x6000382")]
	internal static Rect <Initialize>g__GetPolygonBoundingBox|24_0(in List<List`1<Vector2>>& polygons) { }

	[Address(RVA = "0x2843DA0", Offset = "0x28431A0", Length = "0x48")]
	[CompilerGenerated]
	[Token(Token = "0x6000383")]
	internal static Point64 <Initialize>g__MidPointOfIntRect|24_1(Rect64 bounds) { }

	[Address(RVA = "0x28426F0", Offset = "0x2841AF0", Length = "0x520")]
	[Token(Token = "0x6000381")]
	public void BakeConfiner(float maxComputationTimePerFrameInSeconds) { }

	[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600037E")]
	public BakingState get_State() { }

	[Address(RVA = "0x2842C20", Offset = "0x2842020", Length = "0x301")]
	[Token(Token = "0x600037D")]
	public BakedSolution GetBakedSolution(float frustumHeight) { }

	[Address(RVA = "0x2842F30", Offset = "0x2842330", Length = "0x8CA")]
	[Token(Token = "0x6000380")]
	private void Initialize(in List<List`1<Vector2>>& inputPath, in float aspectRatio, float maxFrustumHeight, float skeletonPadding) { }

	[Address(RVA = "0x2471CE0", Offset = "0x24710E0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600037F")]
	private void set_State(BakingState value) { }

}

