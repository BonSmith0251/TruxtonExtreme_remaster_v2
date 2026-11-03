namespace UnityEngine.Splines;

[DefaultMember("Item")]
[Token(Token = "0x2000031")]
public class SplineData : IEnumerable<DataPoint`1<T>>, IEnumerable, ISplineModificationHandler
{
	[CompilerGenerated]
	[Token(Token = "0x2000032")]
	private sealed class <>c
	{
		[Token(Token = "0x40000BC")]
		public static readonly <>c<T> <>9; //Field offset: 0x0
		[Token(Token = "0x40000BD")]
		public static Func<DataPoint`1<T>, Single> <>9__17_0; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x60001CC")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60001CD")]
		public <>c() { }

		[Address(RVA = "0xA502F0", Offset = "0xA4F6F0", Length = "0xC")]
		[Token(Token = "0x60001CE")]
		internal float <get_Indexes>b__17_0(DataPoint<T> dp) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000033")]
	private sealed class <>c__DisplayClass32_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000BE")]
		public float t; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60001CF")]
		public <>c__DisplayClass32_0() { }

		[Address(RVA = "0xA72160", Offset = "0xA71560", Length = "0x20")]
		[Token(Token = "0x60001D0")]
		internal bool <RemoveDataPoint>b__0(DataPoint<T> point) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000034")]
	private sealed class <GetEnumerator>d__46 : IEnumerator<DataPoint`1<T>>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000BF")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C0")]
		private DataPoint<T> <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C1")]
		public SplineData<T> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C2")]
		private int <i>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C3")]
		private int <c>5__3; //Field offset: 0x0

		[Token(Token = "0x17000059")]
		private override DataPoint<T> System.Collections.Generic.IEnumerator<UnityEngine.Splines.DataPoint<T>>.Current
		{
			[Address(RVA = "0x16F54C0", Offset = "0x16F48C0", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60001D4")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700005A")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x16F54D0", Offset = "0x16F48D0", Length = "0x2B")]
			[DebuggerHidden]
			[Token(Token = "0x60001D6")]
			private get { } //Length: 43
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60001D1")]
		public <GetEnumerator>d__46(int <>1__state) { }

		[Address(RVA = "0x18068E0", Offset = "0x1805CE0", Length = "0xBF")]
		[Token(Token = "0x60001D3")]
		private override bool MoveNext() { }

		[Address(RVA = "0x16F54C0", Offset = "0x16F48C0", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60001D4")]
		private override DataPoint<T> System.Collections.Generic.IEnumerator<UnityEngine.Splines.DataPoint<T>>.get_Current() { }

		[Address(RVA = "0x16F54D0", Offset = "0x16F48D0", Length = "0x2B")]
		[DebuggerHidden]
		[Token(Token = "0x60001D6")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x60001D5")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60001D2")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x40000B5")]
	private static readonly DataPointComparer<DataPoint`1<T>> k_DataPointComparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40000B6")]
	private PathIndexUnit m_IndexUnit; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40000B7")]
	private T m_DefaultValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40000B8")]
	private List<DataPoint`1<T>> m_DataPoints; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B9")]
	private bool m_NeedsSort; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000BA")]
	private Action changed; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000BB")]
	private Action Changed; //Field offset: 0x0

	[Obsolete("Use Changed instead.", False)]
	[Token(Token = "0x14000009")]
	public event Action changed
	{
		[Address(RVA = "0xFBE8E0", Offset = "0xFBDCE0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60001AC")]
		 add { } //Length: 158
		[Address(RVA = "0xFBFE60", Offset = "0xFBF260", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60001AD")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1400000A")]
	public event Action Changed
	{
		[Address(RVA = "0xFBE430", Offset = "0xFBD830", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60001AE")]
		 add { } //Length: 158
		[Address(RVA = "0xFBF910", Offset = "0xFBED10", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60001AF")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000057")]
	public int Count
	{
		[Address(RVA = "0xFBEA80", Offset = "0xFBDE80", Length = "0x1A")]
		[Token(Token = "0x60001AA")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000056")]
	public T DefaultValue
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x60001A8")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[Token(Token = "0x60001A9")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000058")]
	public IEnumerable<Single> Indexes
	{
		[Address(RVA = "0xFBF2C0", Offset = "0xFBE6C0", Length = "0x1B0")]
		[Token(Token = "0x60001AB")]
		 get { } //Length: 432
	}

	[Token(Token = "0x17000054")]
	public DataPoint<T> Item
	{
		[Address(RVA = "0xFBF7F0", Offset = "0xFBEBF0", Length = "0x2A")]
		[Token(Token = "0x60001A4")]
		 get { } //Length: 42
		[Address(RVA = "0xFC07C0", Offset = "0xFBFBC0", Length = "0xF2")]
		[Token(Token = "0x60001A5")]
		 set { } //Length: 242
	}

	[Token(Token = "0x17000055")]
	public PathIndexUnit PathIndexUnit
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x60001A6")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x60001A7")]
		 set { } //Length: 4
	}

	[Address(RVA = "0xFBB810", Offset = "0xFBAC10", Length = "0x102")]
	[Token(Token = "0x60001CB")]
	private static SplineData`1() { }

	[Address(RVA = "0xFBC6B0", Offset = "0xFBBAB0", Length = "0x3B6")]
	[Token(Token = "0x60001B2")]
	public SplineData`1(IEnumerable<DataPoint`1<T>> dataPoints) { }

	[Address(RVA = "0xFBC590", Offset = "0xFBB990", Length = "0x11B")]
	[Token(Token = "0x60001B1")]
	public SplineData`1(T init) { }

	[Address(RVA = "0xFBC500", Offset = "0xFBB900", Length = "0x87")]
	[Token(Token = "0x60001B0")]
	public SplineData`1() { }

	[Address(RVA = "0xFB1DF0", Offset = "0xFB11F0", Length = "0x5F")]
	[Token(Token = "0x60001B4")]
	public void Add(float t, T data) { }

	[Address(RVA = "0xFB1660", Offset = "0xFB0A60", Length = "0x141")]
	[Token(Token = "0x60001B5")]
	public int Add(DataPoint<T> dataPoint) { }

	[Address(RVA = "0xFBE8E0", Offset = "0xFBDCE0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60001AC")]
	public void add_changed(Action value) { }

	[Address(RVA = "0xFBE430", Offset = "0xFBD830", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60001AE")]
	public void add_Changed(Action value) { }

	[Address(RVA = "0xFB1300", Offset = "0xFB0700", Length = "0x201")]
	[Token(Token = "0x60001B6")]
	public int AddDataPointWithDefaultValue(float t, bool useDefaultValue = false) { }

	[Address(RVA = "0xFB23E0", Offset = "0xFB17E0", Length = "0xE8")]
	[Token(Token = "0x60001C9")]
	private static float ClampInt(float index, int lowerBound, int upperBound) { }

	[Address(RVA = "0xFB25B0", Offset = "0xFB19B0", Length = "0x5B")]
	[Token(Token = "0x60001BA")]
	public void Clear() { }

	[Address(RVA = "0x6A2640", Offset = "0x6A1A40", Length = "0x510")]
	[Token(Token = "0x60001C4")]
	public void ConvertPathUnit(TSplineType spline, PathIndexUnit toUnit) { }

	[Address(RVA = "0x6A3250", Offset = "0x6A2650", Length = "0x358")]
	[Token(Token = "0x60001BE")]
	public T Evaluate(TSpline spline, float t, PathIndexUnit indexUnit, TInterpolator interpolator) { }

	[Address(RVA = "0x6A2B60", Offset = "0x6A1F60", Length = "0x6E8")]
	[Token(Token = "0x60001BF")]
	public T Evaluate(TSpline spline, float t, TInterpolator interpolator) { }

	[Address(RVA = "0xFB29E0", Offset = "0xFB1DE0", Length = "0x82")]
	[Token(Token = "0x60001C3")]
	internal void ForceSort() { }

	[Address(RVA = "0xFBEA80", Offset = "0xFBDE80", Length = "0x1A")]
	[Token(Token = "0x60001AA")]
	public int get_Count() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x60001A8")]
	public T get_DefaultValue() { }

	[Address(RVA = "0xFBF2C0", Offset = "0xFBE6C0", Length = "0x1B0")]
	[Token(Token = "0x60001AB")]
	public IEnumerable<Single> get_Indexes() { }

	[Address(RVA = "0xFBF7F0", Offset = "0xFBEBF0", Length = "0x2A")]
	[Token(Token = "0x60001A4")]
	public DataPoint<T> get_Item(int index) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x60001A6")]
	public PathIndexUnit get_PathIndexUnit() { }

	[Address(RVA = "0xFB2B00", Offset = "0xFB1F00", Length = "0x8C")]
	[IteratorStateMachine(typeof(<GetEnumerator>d__46))]
	[Token(Token = "0x60001C6")]
	public override IEnumerator<DataPoint`1<T>> GetEnumerator() { }

	[Address(RVA = "0xFB3C60", Offset = "0xFB3060", Length = "0x4E4")]
	[Token(Token = "0x60001BD")]
	private ValueTuple<Int32, Int32, Single> GetIndex(float t, float splineLength, int knotCount, bool closed) { }

	[Address(RVA = "0x6A3BA0", Offset = "0x6A2FA0", Length = "0x112")]
	[Token(Token = "0x60001C5")]
	public float GetNormalizedInterpolation(TSplineType spline, float t) { }

	[Address(RVA = "0xFB5AE0", Offset = "0xFB4EE0", Length = "0x10B")]
	[Token(Token = "0x60001B9")]
	public int MoveDataPoint(int index, float newIndex) { }

	[Address(RVA = "0xFBFE60", Offset = "0xFBF260", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60001AD")]
	public void remove_changed(Action value) { }

	[Address(RVA = "0xFBF910", Offset = "0xFBED10", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60001AF")]
	public void remove_Changed(Action value) { }

	[Address(RVA = "0xFB5DD0", Offset = "0xFB51D0", Length = "0xBC")]
	[Token(Token = "0x60001B7")]
	public void RemoveAt(int index) { }

	[Address(RVA = "0xFB6960", Offset = "0xFB5D60", Length = "0x16A")]
	[Token(Token = "0x60001B8")]
	public bool RemoveDataPoint(float t) { }

	[Address(RVA = "0xFB6D00", Offset = "0xFB6100", Length = "0xA4")]
	[Token(Token = "0x60001BC")]
	private int ResolveBinaryIndex(int index, bool wrap) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[Token(Token = "0x60001A9")]
	public void set_DefaultValue(T value) { }

	[Address(RVA = "0xFC07C0", Offset = "0xFBFBC0", Length = "0xF2")]
	[Token(Token = "0x60001A5")]
	public void set_Item(int index, DataPoint<T> value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x60001A7")]
	public void set_PathIndexUnit(PathIndexUnit value) { }

	[Address(RVA = "0xFB7730", Offset = "0xFB6B30", Length = "0xE6")]
	[Token(Token = "0x60001C0")]
	public void SetDataPoint(int index, DataPoint<T> value) { }

	[Address(RVA = "0xFB7460", Offset = "0xFB6860", Length = "0x8E")]
	[Token(Token = "0x60001C1")]
	public void SetDataPointNoSort(int index, DataPoint<T> value) { }

	[Address(RVA = "0xFB7CF0", Offset = "0xFB70F0", Length = "0x43")]
	[Token(Token = "0x60001B3")]
	private void SetDirty() { }

	[Address(RVA = "0xFB7E60", Offset = "0xFB7260", Length = "0x72")]
	[Token(Token = "0x60001C2")]
	public void SortIfNecessary() { }

	[Address(RVA = "0xFB8280", Offset = "0xFB7680", Length = "0x9B")]
	[Token(Token = "0x60001C7")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xFB8AB0", Offset = "0xFB7EB0", Length = "0x61D")]
	[Token(Token = "0x60001CA")]
	private override void UnityEngine.Splines.ISplineModificationHandler.OnSplineModified(SplineModificationData data) { }

	[Address(RVA = "0xFBB6B0", Offset = "0xFBAAB0", Length = "0x2B")]
	[Token(Token = "0x60001BB")]
	private static int Wrap(int value, int lowerBound, int upperBound) { }

	[Address(RVA = "0xFBB3C0", Offset = "0xFBA7C0", Length = "0x167")]
	[Token(Token = "0x60001C8")]
	private static float WrapInt(float index, int lowerBound, int upperBound) { }

}

