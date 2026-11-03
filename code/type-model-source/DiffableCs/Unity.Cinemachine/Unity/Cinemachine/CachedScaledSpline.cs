namespace Unity.Cinemachine;

[DefaultMember("Item")]
[Token(Token = "0x20000EC")]
internal class CachedScaledSpline : ISpline, IReadOnlyList<BezierKnot>, IEnumerable<BezierKnot>, IEnumerable, IReadOnlyCollection<BezierKnot>, IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000374")]
	private NativeSpline m_NativeSpline; //Field offset: 0x10
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000375")]
	private readonly Spline m_CachedSource; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000376")]
	private readonly Vector3 m_CachedScale; //Field offset: 0x60
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000377")]
	private bool m_IsAllocated; //Field offset: 0x6C

	[Token(Token = "0x170000ED")]
	public override bool Closed
	{
		[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
		[Token(Token = "0x6000456")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000EE")]
	public override int Count
	{
		[Address(RVA = "0x284FFF0", Offset = "0x284F3F0", Length = "0xB")]
		[Token(Token = "0x6000457")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170000EC")]
	public override BezierKnot Item
	{
		[Address(RVA = "0x2850000", Offset = "0x284F400", Length = "0x3F")]
		[Token(Token = "0x6000455")]
		 get { } //Length: 63
	}

	[Address(RVA = "0x284FDB0", Offset = "0x284F1B0", Length = "0x23F")]
	[Token(Token = "0x6000451")]
	public CachedScaledSpline(Spline spline, Transform transform, Allocator allocator = 4) { }

	[Address(RVA = "0x284F810", Offset = "0x284EC10", Length = "0x2E")]
	[Token(Token = "0x6000452")]
	public override void Dispose() { }

	[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
	[Token(Token = "0x6000456")]
	public override bool get_Closed() { }

	[Address(RVA = "0x284FFF0", Offset = "0x284F3F0", Length = "0xB")]
	[Token(Token = "0x6000457")]
	public override int get_Count() { }

	[Address(RVA = "0x2850000", Offset = "0x284F400", Length = "0x3F")]
	[Token(Token = "0x6000455")]
	public override BezierKnot get_Item(int index) { }

	[Address(RVA = "0x284F8A0", Offset = "0x284ECA0", Length = "0x39")]
	[Token(Token = "0x6000458")]
	public override BezierCurve GetCurve(int index) { }

	[Address(RVA = "0x284F840", Offset = "0x284EC40", Length = "0xC")]
	[Token(Token = "0x6000459")]
	public override float GetCurveInterpolation(int curveIndex, float curveDistance) { }

	[Address(RVA = "0x284F850", Offset = "0x284EC50", Length = "0xC")]
	[Token(Token = "0x600045A")]
	public override float GetCurveLength(int index) { }

	[Address(RVA = "0x284F860", Offset = "0x284EC60", Length = "0x37")]
	[Token(Token = "0x600045B")]
	public override float3 GetCurveUpVector(int index, float t) { }

	[Address(RVA = "0x284F8E0", Offset = "0x284ECE0", Length = "0xB")]
	[Token(Token = "0x600045C")]
	public override IEnumerator<BezierKnot> GetEnumerator() { }

	[Address(RVA = "0x5B3830", Offset = "0x5B2C30", Length = "0x6")]
	[Token(Token = "0x600045D")]
	public override float GetLength() { }

	[Address(RVA = "0x284F8F0", Offset = "0x284ECF0", Length = "0x147")]
	[Token(Token = "0x6000453")]
	public bool IsCrudelyValid(Spline spline, Transform transform) { }

	[Address(RVA = "0x284FA40", Offset = "0x284EE40", Length = "0x36E")]
	[Token(Token = "0x6000454")]
	public bool KnotsAreValid(Spline spline, Transform transform) { }

	[Address(RVA = "0x284F8E0", Offset = "0x284ECE0", Length = "0xB")]
	[Token(Token = "0x600045E")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

