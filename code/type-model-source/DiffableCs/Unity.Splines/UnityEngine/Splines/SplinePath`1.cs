namespace UnityEngine.Splines;

[DefaultMember("Item")]
[Token(Token = "0x2000053")]
public class SplinePath : ISpline, IReadOnlyList<BezierKnot>, IEnumerable<BezierKnot>, IEnumerable, IReadOnlyCollection<BezierKnot>, IHasEmptyCurves
{
	[CompilerGenerated]
	[Token(Token = "0x2000054")]
	private sealed class <GetEnumerator>d__7 : IEnumerator<BezierKnot>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000142")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000143")]
		private BezierKnot <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000144")]
		public SplinePath<T> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000145")]
		private T[] <>7__wrap1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000146")]
		private int <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000147")]
		private IEnumerator<BezierKnot> <>7__wrap3; //Field offset: 0x0

		[Token(Token = "0x170000B5")]
		private override BezierKnot System.Collections.Generic.IEnumerator<UnityEngine.Splines.BezierKnot>.Current
		{
			[Address(RVA = "0x1804230", Offset = "0x1803630", Length = "0x21")]
			[DebuggerHidden]
			[Token(Token = "0x60002EA")]
			private get { } //Length: 33
		}

		[Token(Token = "0x170000B6")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x1807A70", Offset = "0x1806E70", Length = "0x5E")]
			[DebuggerHidden]
			[Token(Token = "0x60002EC")]
			private get { } //Length: 94
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60002E6")]
		public <GetEnumerator>d__7(int <>1__state) { }

		[Address(RVA = "0x1807D70", Offset = "0x1807170", Length = "0x50")]
		[Token(Token = "0x60002E9")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x18075D0", Offset = "0x18069D0", Length = "0x33B")]
		[Token(Token = "0x60002E8")]
		private override bool MoveNext() { }

		[Address(RVA = "0x1804230", Offset = "0x1803630", Length = "0x21")]
		[DebuggerHidden]
		[Token(Token = "0x60002EA")]
		private override BezierKnot System.Collections.Generic.IEnumerator<UnityEngine.Splines.BezierKnot>.get_Current() { }

		[Address(RVA = "0x1807A70", Offset = "0x1806E70", Length = "0x5E")]
		[DebuggerHidden]
		[Token(Token = "0x60002EC")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x60002EB")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x1807C30", Offset = "0x1807030", Length = "0x9B")]
		[DebuggerHidden]
		[Token(Token = "0x60002E7")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000140")]
	private T[] m_Splines; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000141")]
	private Int32[] m_Splits; //Field offset: 0x0

	[Token(Token = "0x170000B3")]
	public override bool Closed
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60002DE")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000B0")]
	public override int Count
	{
		[Address(RVA = "0xFC4A00", Offset = "0xFC3E00", Length = "0x169")]
		[Token(Token = "0x60002DA")]
		 get { } //Length: 361
	}

	[Token(Token = "0x170000B4")]
	public override IReadOnlyList<Int32> EmptyCurves
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60002E0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000B1")]
	public override BezierKnot Item
	{
		[Address(RVA = "0xFC5390", Offset = "0xFC4790", Length = "0x83")]
		[Token(Token = "0x60002DB")]
		 get { } //Length: 131
	}

	[Token(Token = "0x170000B2")]
	public BezierKnot Item
	{
		[Address(RVA = "0xFC5050", Offset = "0xFC4450", Length = "0xFB")]
		[Token(Token = "0x60002DC")]
		 get { } //Length: 251
	}

	[Token(Token = "0x170000AF")]
	public IReadOnlyList<T> Slices
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60002D4")]
		 get { } //Length: 5
		[Address(RVA = "0xFC54E0", Offset = "0xFC48E0", Length = "0x5B")]
		[Token(Token = "0x60002D5")]
		 set { } //Length: 91
	}

	[Address(RVA = "0xFC4650", Offset = "0xFC3A50", Length = "0x6C")]
	[Token(Token = "0x60002D6")]
	public SplinePath`1(IEnumerable<T> slices) { }

	[Address(RVA = "0xFC0CB0", Offset = "0xFC00B0", Length = "0x21D")]
	[Token(Token = "0x60002D7")]
	private void BuildSplitData() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60002DE")]
	public override bool get_Closed() { }

	[Address(RVA = "0xFC4A00", Offset = "0xFC3E00", Length = "0x169")]
	[Token(Token = "0x60002DA")]
	public override int get_Count() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60002E0")]
	public override IReadOnlyList<Int32> get_EmptyCurves() { }

	[Address(RVA = "0xFC5050", Offset = "0xFC4450", Length = "0xFB")]
	[Token(Token = "0x60002DC")]
	public BezierKnot get_Item(SplineKnotIndex index) { }

	[Address(RVA = "0xFC5390", Offset = "0xFC4790", Length = "0x83")]
	[Token(Token = "0x60002DB")]
	public override BezierKnot get_Item(int index) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60002D4")]
	public IReadOnlyList<T> get_Slices() { }

	[Address(RVA = "0xFC1740", Offset = "0xFC0B40", Length = "0x1BD")]
	[Token(Token = "0x60002DD")]
	internal SplineKnotIndex GetBranchKnotIndex(int knot) { }

	[Address(RVA = "0xFC3F70", Offset = "0xFC3370", Length = "0x209")]
	[Token(Token = "0x60002E2")]
	public override BezierCurve GetCurve(int knot) { }

	[Address(RVA = "0xFC1A20", Offset = "0xFC0E20", Length = "0x102")]
	[Token(Token = "0x60002E5")]
	public override float GetCurveInterpolation(int curveIndex, float curveDistance) { }

	[Address(RVA = "0xFC2090", Offset = "0xFC1490", Length = "0x3DC")]
	[Token(Token = "0x60002E3")]
	public override float GetCurveLength(int index) { }

	[Address(RVA = "0xFC2880", Offset = "0xFC1C80", Length = "0x590")]
	[Token(Token = "0x60002E4")]
	public override float3 GetCurveUpVector(int index, float t) { }

	[Address(RVA = "0xFC4210", Offset = "0xFC3610", Length = "0x86")]
	[IteratorStateMachine(typeof(<GetEnumerator>d__7))]
	[Token(Token = "0x60002D8")]
	public override IEnumerator<BezierKnot> GetEnumerator() { }

	[Address(RVA = "0xFC4340", Offset = "0xFC3740", Length = "0x98")]
	[Token(Token = "0x60002DF")]
	public override float GetLength() { }

	[Address(RVA = "0xFC44A0", Offset = "0xFC38A0", Length = "0x4D")]
	[Token(Token = "0x60002E1")]
	private bool IsDegenerate(int index) { }

	[Address(RVA = "0xFC54E0", Offset = "0xFC48E0", Length = "0x5B")]
	[Token(Token = "0x60002D5")]
	public void set_Slices(IReadOnlyList<T> value) { }

	[Address(RVA = "0xFC4590", Offset = "0xFC3990", Length = "0x92")]
	[Token(Token = "0x60002D9")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

