namespace UnityEngine.Splines;

[DefaultMember("Item")]
[Token(Token = "0x2000059")]
public struct SplineSlice : ISpline, IReadOnlyList<BezierKnot>, IEnumerable<BezierKnot>, IEnumerable, IReadOnlyCollection<BezierKnot>
{
	[CompilerGenerated]
	[Token(Token = "0x200005A")]
	private sealed class <GetEnumerator>d__10 : IEnumerator<BezierKnot>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400015F")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000160")]
		private BezierKnot <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000161")]
		public SplineSlice<T> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000162")]
		private int <i>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000163")]
		private int <c>5__3; //Field offset: 0x0

		[Token(Token = "0x170000C4")]
		private override BezierKnot System.Collections.Generic.IEnumerator<UnityEngine.Splines.BezierKnot>.Current
		{
			[Address(RVA = "0x1804230", Offset = "0x1803630", Length = "0x21")]
			[DebuggerHidden]
			[Token(Token = "0x6000317")]
			private get { } //Length: 33
		}

		[Token(Token = "0x170000C5")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x18042C0", Offset = "0x18036C0", Length = "0x5E")]
			[DebuggerHidden]
			[Token(Token = "0x6000319")]
			private get { } //Length: 94
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000314")]
		public <GetEnumerator>d__10(int <>1__state) { }

		[Address(RVA = "0x1803DD0", Offset = "0x18031D0", Length = "0xA5")]
		[Token(Token = "0x6000316")]
		private override bool MoveNext() { }

		[Address(RVA = "0x1804230", Offset = "0x1803630", Length = "0x21")]
		[DebuggerHidden]
		[Token(Token = "0x6000317")]
		private override BezierKnot System.Collections.Generic.IEnumerator<UnityEngine.Splines.BezierKnot>.get_Current() { }

		[Address(RVA = "0x18042C0", Offset = "0x18036C0", Length = "0x5E")]
		[DebuggerHidden]
		[Token(Token = "0x6000319")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x6000318")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000315")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400015C")]
	public T Spline; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400015D")]
	public SplineRange Range; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400015E")]
	public float4x4 Transform; //Field offset: 0x0

	[Token(Token = "0x170000C2")]
	public override bool Closed
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000308")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000C1")]
	public override int Count
	{
		[Address(RVA = "0xFC6E90", Offset = "0xFC6290", Length = "0xD0")]
		[Token(Token = "0x6000307")]
		 get { } //Length: 208
	}

	[Token(Token = "0x170000C3")]
	public override BezierKnot Item
	{
		[Address(RVA = "0xFC6F70", Offset = "0xFC6370", Length = "0x2EC")]
		[Token(Token = "0x600030A")]
		 get { } //Length: 748
	}

	[Address(RVA = "0xFC68E0", Offset = "0xFC5CE0", Length = "0xDC")]
	[Token(Token = "0x600030D")]
	public SplineSlice`1(T spline, SplineRange range) { }

	[Address(RVA = "0xFC6680", Offset = "0xFC5A80", Length = "0x5E")]
	[Token(Token = "0x600030E")]
	public SplineSlice`1(T spline, SplineRange range, float4x4 transform) { }

	[Address(RVA = "0xFC5540", Offset = "0xFC4940", Length = "0x8A")]
	[Token(Token = "0x6000309")]
	private static BezierKnot FlipTangents(BezierKnot knot) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000308")]
	public override bool get_Closed() { }

	[Address(RVA = "0xFC6E90", Offset = "0xFC6290", Length = "0xD0")]
	[Token(Token = "0x6000307")]
	public override int get_Count() { }

	[Address(RVA = "0xFC6F70", Offset = "0xFC6370", Length = "0x2EC")]
	[Token(Token = "0x600030A")]
	public override BezierKnot get_Item(int index) { }

	[Address(RVA = "0xFC5C00", Offset = "0xFC5000", Length = "0x15F")]
	[Token(Token = "0x6000310")]
	public override BezierCurve GetCurve(int index) { }

	[Address(RVA = "0xFC56E0", Offset = "0xFC4AE0", Length = "0xE8")]
	[Token(Token = "0x6000313")]
	public override float GetCurveInterpolation(int curveIndex, float curveDistance) { }

	[Address(RVA = "0xFC57D0", Offset = "0xFC4BD0", Length = "0xDD")]
	[Token(Token = "0x6000311")]
	public override float GetCurveLength(int index) { }

	[Address(RVA = "0xFC59C0", Offset = "0xFC4DC0", Length = "0x10A")]
	[Token(Token = "0x6000312")]
	public override float3 GetCurveUpVector(int index, float t) { }

	[Address(RVA = "0xFC6100", Offset = "0xFC5500", Length = "0xDA")]
	[IteratorStateMachine(typeof(<GetEnumerator>d__10))]
	[Token(Token = "0x600030B")]
	public override IEnumerator<BezierKnot> GetEnumerator() { }

	[Address(RVA = "0xFC61E0", Offset = "0xFC55E0", Length = "0x171")]
	[Token(Token = "0x600030F")]
	public override float GetLength() { }

	[Address(RVA = "0xFC6460", Offset = "0xFC5860", Length = "0x36")]
	[Token(Token = "0x600030C")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

