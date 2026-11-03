namespace UnityEngine.Splines;

[DefaultMember("Item")]
[Token(Token = "0x200001A")]
public struct NativeSpline : ISpline, IReadOnlyList<BezierKnot>, IEnumerable<BezierKnot>, IEnumerable, IReadOnlyCollection<BezierKnot>, IDisposable
{
	[DefaultMember("Item")]
	[Token(Token = "0x200001B")]
	private struct Slice : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000042")]
		private NativeSlice<T> m_Slice; //Field offset: 0x0

		[Token(Token = "0x17000025")]
		public override int Count
		{
			[Address(RVA = "0xF643F0", Offset = "0xF637F0", Length = "0x36")]
			[Token(Token = "0x60000A5")]
			 get { } //Length: 54
		}

		[Token(Token = "0x17000026")]
		public override T Item
		{
			[Address(RVA = "0xF64430", Offset = "0xF63830", Length = "0x43")]
			[Token(Token = "0x60000A6")]
			 get { } //Length: 67
		}

		[Address(RVA = "0xF642D0", Offset = "0xF636D0", Length = "0x90")]
		[Token(Token = "0x60000A2")]
		public Slice`1(NativeArray<T> array, int start, int count) { }

		[Address(RVA = "0xF643F0", Offset = "0xF637F0", Length = "0x36")]
		[Token(Token = "0x60000A5")]
		public override int get_Count() { }

		[Address(RVA = "0xF64430", Offset = "0xF63830", Length = "0x43")]
		[Token(Token = "0x60000A6")]
		public override T get_Item(int index) { }

		[Address(RVA = "0xF64150", Offset = "0xF63550", Length = "0x88")]
		[Token(Token = "0x60000A3")]
		public override IEnumerator<T> GetEnumerator() { }

		[Address(RVA = "0xF64290", Offset = "0xF63690", Length = "0x36")]
		[Token(Token = "0x60000A4")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[Token(Token = "0x4000041")]
	private const int k_SegmentResolution = 30; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x400003B")]
	private NativeArray<BezierKnot> m_Knots; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x400003C")]
	private NativeArray<BezierCurve> m_Curves; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[ReadOnly]
	[Token(Token = "0x400003D")]
	private NativeArray<DistanceToInterpolation> m_SegmentLengthsLookupTable; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[ReadOnly]
	[Token(Token = "0x400003E")]
	private NativeArray<float3> m_UpVectorsLookupTable; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400003F")]
	private bool m_Closed; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000040")]
	private float m_Length; //Field offset: 0x44

	[Token(Token = "0x17000022")]
	public override bool Closed
	{
		[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
		[Token(Token = "0x600008F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000023")]
	public override int Count
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x6000090")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000021")]
	public NativeArray<BezierCurve> Curves
	{
		[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
		[Token(Token = "0x600008E")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000024")]
	public override BezierKnot Item
	{
		[Address(RVA = "0x2E5D140", Offset = "0x2E5C540", Length = "0x32")]
		[Token(Token = "0x6000092")]
		 get { } //Length: 50
	}

	[Token(Token = "0x17000020")]
	public NativeArray<BezierKnot> Knots
	{
		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[Token(Token = "0x600008D")]
		 get { } //Length: 10
	}

	[Address(RVA = "0x2E5D020", Offset = "0x2E5C420", Length = "0x112")]
	[Token(Token = "0x6000097")]
	public NativeSpline(ISpline spline, float4x4 transform, Allocator allocator = 2) { }

	[Address(RVA = "0x2E5C2C0", Offset = "0x2E5B6C0", Length = "0xB91")]
	[Token(Token = "0x600009C")]
	public NativeSpline(IReadOnlyList<BezierKnot> knots, IReadOnlyList<Int32> splits, bool closed, float4x4 transform, bool cacheUpVectors, Allocator allocator = 2) { }

	[Address(RVA = "0x2E5C0C0", Offset = "0x2E5B4C0", Length = "0x62")]
	[Token(Token = "0x600009B")]
	public NativeSpline(IReadOnlyList<BezierKnot> knots, IReadOnlyList<Int32> splits, bool closed, float4x4 transform, Allocator allocator = 2) { }

	[Address(RVA = "0x2E5CE60", Offset = "0x2E5C260", Length = "0x6C")]
	[Token(Token = "0x600009A")]
	public NativeSpline(IReadOnlyList<BezierKnot> knots, bool closed, float4x4 transform, bool cacheUpVectors, Allocator allocator = 2) { }

	[Address(RVA = "0x2E5CF80", Offset = "0x2E5C380", Length = "0x9B")]
	[Token(Token = "0x6000095")]
	public NativeSpline(ISpline spline, Allocator allocator = 2) { }

	[Address(RVA = "0x2E5CED0", Offset = "0x2E5C2D0", Length = "0xA9")]
	[Token(Token = "0x6000096")]
	public NativeSpline(ISpline spline, bool cacheUpVectors, Allocator allocator = 2) { }

	[Address(RVA = "0x2E5C1A0", Offset = "0x2E5B5A0", Length = "0x11A")]
	[Token(Token = "0x6000098")]
	public NativeSpline(ISpline spline, float4x4 transform, bool cacheUpVectors, Allocator allocator = 2) { }

	[Address(RVA = "0x2E5C130", Offset = "0x2E5B530", Length = "0x65")]
	[Token(Token = "0x6000099")]
	public NativeSpline(IReadOnlyList<BezierKnot> knots, bool closed, float4x4 transform, Allocator allocator = 2) { }

	[Address(RVA = "0x2E5BC70", Offset = "0x2E5B070", Length = "0x8D")]
	[Token(Token = "0x60000A0")]
	public override void Dispose() { }

	[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
	[Token(Token = "0x600008F")]
	public override bool get_Closed() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x6000090")]
	public override int get_Count() { }

	[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
	[Token(Token = "0x600008E")]
	public NativeArray<BezierCurve> get_Curves() { }

	[Address(RVA = "0x2E5D140", Offset = "0x2E5C540", Length = "0x32")]
	[Token(Token = "0x6000092")]
	public override BezierKnot get_Item(int index) { }

	[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
	[Token(Token = "0x600008D")]
	public NativeArray<BezierKnot> get_Knots() { }

	[Address(RVA = "0x2E5BFD0", Offset = "0x2E5B3D0", Length = "0x2E")]
	[Token(Token = "0x600009D")]
	public override BezierCurve GetCurve(int index) { }

	[Address(RVA = "0x2E5BD00", Offset = "0x2E5B100", Length = "0x10A")]
	[Token(Token = "0x60000A1")]
	public override float GetCurveInterpolation(int curveIndex, float curveDistance) { }

	[Address(RVA = "0x2E5BE10", Offset = "0x2E5B210", Length = "0x13")]
	[Token(Token = "0x600009E")]
	public override float GetCurveLength(int curveIndex) { }

	[Address(RVA = "0x2E5BE30", Offset = "0x2E5B230", Length = "0x19B")]
	[Token(Token = "0x600009F")]
	public override float3 GetCurveUpVector(int index, float t) { }

	[Address(RVA = "0x2E5C000", Offset = "0x2E5B400", Length = "0xA2")]
	[Token(Token = "0x6000093")]
	public override IEnumerator<BezierKnot> GetEnumerator() { }

	[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
	[Token(Token = "0x6000091")]
	public override float GetLength() { }

	[Address(RVA = "0x2E5C0B0", Offset = "0x2E5B4B0", Length = "0x7")]
	[Token(Token = "0x6000094")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

