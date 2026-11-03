namespace UnityEngine.Splines;

[DefaultMember("Item")]
[Token(Token = "0x2000021")]
public class Spline : ISpline, IReadOnlyList<BezierKnot>, IEnumerable<BezierKnot>, IEnumerable, IReadOnlyCollection<BezierKnot>, IList<BezierKnot>, ICollection<BezierKnot>
{
	[CompilerGenerated]
	[Token(Token = "0x2000023")]
	private sealed class <get_embeddedSplineData>d__15 : IEnumerable<ISplineModificationHandler>, IEnumerable, IEnumerator<ISplineModificationHandler>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000065")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000066")]
		private ISplineModificationHandler <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000067")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000068")]
		public Spline <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000069")]
		private IEnumerator<SplineDataKeyValuePair`1<Int32>> <>7__wrap1; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400006A")]
		private IEnumerator<SplineDataKeyValuePair`1<Single>> <>7__wrap2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400006B")]
		private IEnumerator<SplineDataKeyValuePair`1<float4>> <>7__wrap3; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400006C")]
		private IEnumerator<SplineDataKeyValuePair`1<Object>> <>7__wrap4; //Field offset: 0x48

		[Token(Token = "0x17000031")]
		private override ISplineModificationHandler System.Collections.Generic.IEnumerator<UnityEngine.Splines.ISplineModificationHandler>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000123")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000032")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000125")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x600011C")]
		public <get_embeddedSplineData>d__15(int <>1__state) { }

		[Address(RVA = "0x2E74740", Offset = "0x2E73B40", Length = "0x50")]
		[Token(Token = "0x600011F")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x2E74790", Offset = "0x2E73B90", Length = "0x50")]
		[Token(Token = "0x6000120")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x2E747E0", Offset = "0x2E73BE0", Length = "0x50")]
		[Token(Token = "0x6000121")]
		private void <>m__Finally3() { }

		[Address(RVA = "0x2E74830", Offset = "0x2E73C30", Length = "0x50")]
		[Token(Token = "0x6000122")]
		private void <>m__Finally4() { }

		[Address(RVA = "0x2E73DF0", Offset = "0x2E731F0", Length = "0x629")]
		[Token(Token = "0x600011E")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2E74420", Offset = "0x2E73820", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x6000126")]
		private override IEnumerator<ISplineModificationHandler> System.Collections.Generic.IEnumerable<UnityEngine.Splines.ISplineModificationHandler>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000123")]
		private override ISplineModificationHandler System.Collections.Generic.IEnumerator<UnityEngine.Splines.ISplineModificationHandler>.get_Current() { }

		[Address(RVA = "0x2E74420", Offset = "0x2E73820", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x6000127")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000125")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2E744C0", Offset = "0x2E738C0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000124")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2E74500", Offset = "0x2E73900", Length = "0x208")]
		[DebuggerHidden]
		[Token(Token = "0x600011D")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000022")]
	private sealed class MetaData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000061")]
		public TangentMode Mode; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000062")]
		public float Tension; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000063")]
		private DistanceToInterpolation[] m_DistanceToInterpolation; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000064")]
		private float3[] m_UpVectors; //Field offset: 0x20

		[Token(Token = "0x1700002F")]
		public DistanceToInterpolation[] DistanceToInterpolation
		{
			[Address(RVA = "0x2E5BB90", Offset = "0x2E5AF90", Length = "0x6B")]
			[Token(Token = "0x6000117")]
			 get { } //Length: 107
		}

		[Token(Token = "0x17000030")]
		public float3[] UpVectors
		{
			[Address(RVA = "0x2E5BC00", Offset = "0x2E5B000", Length = "0x6B")]
			[Token(Token = "0x6000118")]
			 get { } //Length: 107
		}

		[Address(RVA = "0x2E5BAF0", Offset = "0x2E5AEF0", Length = "0x9A")]
		[Token(Token = "0x6000119")]
		public MetaData() { }

		[Address(RVA = "0x2E5B7C0", Offset = "0x2E5ABC0", Length = "0x326")]
		[Token(Token = "0x600011A")]
		public MetaData(MetaData toCopy) { }

		[Address(RVA = "0x2E5BB90", Offset = "0x2E5AF90", Length = "0x6B")]
		[Token(Token = "0x6000117")]
		public DistanceToInterpolation[] get_DistanceToInterpolation() { }

		[Address(RVA = "0x2E5BC00", Offset = "0x2E5B000", Length = "0x6B")]
		[Token(Token = "0x6000118")]
		public float3[] get_UpVectors() { }

		[Address(RVA = "0x2E5B660", Offset = "0x2E5AA60", Length = "0x158")]
		[Token(Token = "0x600011B")]
		public void InvalidateCache() { }

	}

	[Token(Token = "0x4000051")]
	private const TangentMode k_DefaultTangentMode = 4; //Field offset: 0x0
	[Token(Token = "0x4000052")]
	private const BezierTangent k_DefaultMainTangent = 1; //Field offset: 0x0
	[Token(Token = "0x4000053")]
	private const int k_BatchModification = -1; //Field offset: 0x0
	[Token(Token = "0x4000054")]
	private const int k_CurveDistanceLutResolution = 30; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x400005F")]
	private static Action<Spline, Int32, SplineModification> Changed; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[Obsolete]
	[SerializeField]
	[Token(Token = "0x4000055")]
	private SplineType m_EditModeType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000056")]
	private List<BezierKnot> m_Knots; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000057")]
	private float m_Length; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000058")]
	private List<MetaData> m_MetaData; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000059")]
	private bool m_Closed; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400005A")]
	private SplineDataDictionary<Int32> m_IntData; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400005B")]
	private SplineDataDictionary<Single> m_FloatData; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400005C")]
	private SplineDataDictionary<float4> m_Float4Data; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x400005D")]
	private SplineDataDictionary<Object> m_ObjectData; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400005E")]
	private Action changed; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000060")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"curve0", "curve1"})]
	private ValueTuple<Single, Single> m_LastKnotChangeCurveLengths; //Field offset: 0x60

	[Obsolete("Deprecated, use Changed instead.")]
	[Token(Token = "0x14000001")]
	public event Action changed
	{
		[Address(RVA = "0x2E736E0", Offset = "0x2E72AE0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000CE")]
		 add { } //Length: 158
		[Address(RVA = "0x2E739B0", Offset = "0x2E72DB0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000CF")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000002")]
	public static event Action<Spline, Int32, SplineModification> Changed
	{
		[Address(RVA = "0x2E73600", Offset = "0x2E72A00", Length = "0xD7")]
		[CompilerGenerated]
		[Token(Token = "0x60000D0")]
		 add { } //Length: 215
		[Address(RVA = "0x2E738D0", Offset = "0x2E72CD0", Length = "0xD7")]
		[CompilerGenerated]
		[Token(Token = "0x60000D1")]
		 remove { } //Length: 215
	}

	[Token(Token = "0x1700002D")]
	public override bool Closed
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x60000E8")]
		 get { } //Length: 5
		[Address(RVA = "0x2E73A50", Offset = "0x2E72E50", Length = "0xFC")]
		[Token(Token = "0x60000E9")]
		 set { } //Length: 252
	}

	[Token(Token = "0x17000029")]
	public override int Count
	{
		[Address(RVA = "0x2E73780", Offset = "0x2E72B80", Length = "0x3C")]
		[Token(Token = "0x60000CC")]
		 get { } //Length: 60
	}

	[Obsolete("Use GetTangentMode and SetTangentMode.")]
	[Token(Token = "0x1700002B")]
	public SplineType EditType
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x60000E4")]
		 get { } //Length: 5
		[Address(RVA = "0x2E73B50", Offset = "0x2E72F50", Length = "0xA7")]
		[Token(Token = "0x60000E5")]
		 set { } //Length: 167
	}

	[Token(Token = "0x17000028")]
	private IEnumerable<ISplineModificationHandler> embeddedSplineData
	{
		[Address(RVA = "0x2E73850", Offset = "0x2E72C50", Length = "0x71")]
		[IteratorStateMachine(typeof(<get_embeddedSplineData>d__15))]
		[Token(Token = "0x60000B2")]
		private get { } //Length: 113
	}

	[Token(Token = "0x1700002A")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60000CD")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700002E")]
	public override BezierKnot Item
	{
		[Address(RVA = "0x2E737C0", Offset = "0x2E72BC0", Length = "0x8A")]
		[Token(Token = "0x60000F2")]
		 get { } //Length: 138
		[Address(RVA = "0x2E73C00", Offset = "0x2E73000", Length = "0x82")]
		[Token(Token = "0x60000F3")]
		 set { } //Length: 130
	}

	[Token(Token = "0x1700002C")]
	public IEnumerable<BezierKnot> Knots
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60000E6")]
		 get { } //Length: 5
		[Address(RVA = "0x2E73C90", Offset = "0x2E73090", Length = "0xF5")]
		[Token(Token = "0x60000E7")]
		 set { } //Length: 245
	}

	[Address(RVA = "0x2E727B0", Offset = "0x2E71BB0", Length = "0x25C")]
	[Token(Token = "0x60000F9")]
	public Spline(IEnumerable<float3> knotPositions, TangentMode tangentMode = 0, bool closed = false) { }

	[Address(RVA = "0x2E72A10", Offset = "0x2E71E10", Length = "0x1E4")]
	[Token(Token = "0x60000F6")]
	public Spline() { }

	[Address(RVA = "0x2E72340", Offset = "0x2E71740", Length = "0x23F")]
	[Token(Token = "0x60000F7")]
	public Spline(int knotCapacity, bool closed = false) { }

	[Address(RVA = "0x2E72C00", Offset = "0x2E72000", Length = "0x9F6")]
	[Token(Token = "0x60000FA")]
	public Spline(Spline spline) { }

	[Address(RVA = "0x2E72580", Offset = "0x2E71980", Length = "0x22F")]
	[Token(Token = "0x60000F8")]
	public Spline(IEnumerable<BezierKnot> knots, bool closed = false) { }

	[Address(RVA = "0x2E6C990", Offset = "0x2E6BD90", Length = "0x223")]
	[Token(Token = "0x6000110")]
	public void Add(Spline spline) { }

	[Address(RVA = "0x2E6C8B0", Offset = "0x2E6BCB0", Length = "0xD8")]
	[Token(Token = "0x600010F")]
	public void Add(BezierKnot item, TangentMode mode, float tension) { }

	[Address(RVA = "0x2E6CE20", Offset = "0x2E6C220", Length = "0xCD")]
	[Token(Token = "0x600010E")]
	public void Add(BezierKnot item, TangentMode mode) { }

	[Address(RVA = "0x2E6CBC0", Offset = "0x2E6BFC0", Length = "0x251")]
	[Token(Token = "0x6000109")]
	public void Add(float3 knotPosition, TangentMode tangentMode = 0) { }

	[Address(RVA = "0x2E6C870", Offset = "0x2E6BC70", Length = "0x3D")]
	[Token(Token = "0x6000108")]
	public override void Add(BezierKnot item) { }

	[Address(RVA = "0x2E736E0", Offset = "0x2E72AE0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000CE")]
	public void add_changed(Action value) { }

	[Address(RVA = "0x2E73600", Offset = "0x2E72A00", Length = "0xD7")]
	[CompilerGenerated]
	[Token(Token = "0x60000D0")]
	public static void add_Changed(Action<Spline, Int32, SplineModification> value) { }

	[Address(RVA = "0x2E6C7E0", Offset = "0x2E6BBE0", Length = "0x86")]
	[Token(Token = "0x600010A")]
	public void AddRange(IEnumerable<float3> knotPositions, TangentMode tangentMode = 0) { }

	[Address(RVA = "0x2E6CEF0", Offset = "0x2E6C2F0", Length = "0x3DE")]
	[Token(Token = "0x60000DD")]
	private void ApplyTangentModeNoNotify(int index, BezierTangent main = 1) { }

	[Address(RVA = "0x2E6D2D0", Offset = "0x2E6C6D0", Length = "0xC5")]
	[Token(Token = "0x6000116")]
	internal void CacheKnotOperationCurves(int index) { }

	[Address(RVA = "0x2E6D3A0", Offset = "0x2E6C7A0", Length = "0xD6")]
	[Token(Token = "0x60000EA")]
	internal void CheckAutoSmoothExtremityKnots() { }

	[Address(RVA = "0x2E6D480", Offset = "0x2E6C880", Length = "0x88")]
	[Token(Token = "0x6000111")]
	public override void Clear() { }

	[Address(RVA = "0x2E6D510", Offset = "0x2E6C910", Length = "0x77")]
	[Token(Token = "0x6000112")]
	public override bool Contains(BezierKnot item) { }

	[Address(RVA = "0x2E6D600", Offset = "0x2E6CA00", Length = "0x1F7")]
	[Token(Token = "0x6000105")]
	public void Copy(Spline copyFrom) { }

	[Address(RVA = "0x2E6D590", Offset = "0x2E6C990", Length = "0x63")]
	[Token(Token = "0x6000113")]
	public override void CopyTo(BezierKnot[] array, int arrayIndex) { }

	[Address(RVA = "0x2E6D800", Offset = "0x2E6CC00", Length = "0x63")]
	[Token(Token = "0x60000D7")]
	public void EnforceTangentModeNoNotify(SplineRange range) { }

	[Address(RVA = "0x2E6D870", Offset = "0x2E6CC70", Length = "0x90")]
	[Token(Token = "0x60000D6")]
	public void EnforceTangentModeNoNotify(int index) { }

	[Address(RVA = "0x2E6D900", Offset = "0x2E6CD00", Length = "0x19E")]
	[Token(Token = "0x60000D5")]
	private void EnsureMetaDataValid() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x60000E8")]
	public override bool get_Closed() { }

	[Address(RVA = "0x2E73780", Offset = "0x2E72B80", Length = "0x3C")]
	[Token(Token = "0x60000CC")]
	public override int get_Count() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x60000E4")]
	public SplineType get_EditType() { }

	[Address(RVA = "0x2E73850", Offset = "0x2E72C50", Length = "0x71")]
	[IteratorStateMachine(typeof(<get_embeddedSplineData>d__15))]
	[Token(Token = "0x60000B2")]
	private IEnumerable<ISplineModificationHandler> get_embeddedSplineData() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60000CD")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x2E737C0", Offset = "0x2E72BC0", Length = "0x8A")]
	[Token(Token = "0x60000F2")]
	public override BezierKnot get_Item(int index) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60000E6")]
	public IEnumerable<BezierKnot> get_Knots() { }

	[Address(RVA = "0x2E6DAA0", Offset = "0x2E6CEA0", Length = "0x5C")]
	[Token(Token = "0x60000DE")]
	public float GetAutoSmoothTension(int index) { }

	[Address(RVA = "0x2E6E2E0", Offset = "0x2E6D6E0", Length = "0x15A")]
	[Token(Token = "0x60000FB")]
	public override BezierCurve GetCurve(int index) { }

	[Address(RVA = "0x2E6DB00", Offset = "0x2E6CF00", Length = "0x231")]
	[Token(Token = "0x60000FE")]
	private DistanceToInterpolation[] GetCurveDistanceLut(int index) { }

	[Address(RVA = "0x2E6DD40", Offset = "0x2E6D140", Length = "0x85")]
	[Token(Token = "0x60000FF")]
	public override float GetCurveInterpolation(int curveIndex, float curveDistance) { }

	[Address(RVA = "0x2E6DDD0", Offset = "0x2E6D1D0", Length = "0x1B5")]
	[Token(Token = "0x60000FC")]
	public override float GetCurveLength(int index) { }

	[Address(RVA = "0x2E6DF90", Offset = "0x2E6D390", Length = "0x348")]
	[Token(Token = "0x6000101")]
	public override float3 GetCurveUpVector(int index, float t) { }

	[Address(RVA = "0x2E6E440", Offset = "0x2E6D840", Length = "0xAD")]
	[Token(Token = "0x6000106")]
	public override IEnumerator<BezierKnot> GetEnumerator() { }

	[Address(RVA = "0x2E6E4F0", Offset = "0x2E6D8F0", Length = "0x44")]
	[Token(Token = "0x60000C0")]
	public IEnumerable<String> GetFloat4DataKeys() { }

	[Address(RVA = "0x2E6E540", Offset = "0x2E6D940", Length = "0x44")]
	[Token(Token = "0x60000C5")]
	public IEnumerable<SplineData`1<float4>> GetFloat4DataValues() { }

	[Address(RVA = "0x2E6E590", Offset = "0x2E6D990", Length = "0x44")]
	[Token(Token = "0x60000BF")]
	public IEnumerable<String> GetFloatDataKeys() { }

	[Address(RVA = "0x2E6E5E0", Offset = "0x2E6D9E0", Length = "0x44")]
	[Token(Token = "0x60000C4")]
	public IEnumerable<SplineData`1<Single>> GetFloatDataValues() { }

	[Address(RVA = "0x2E6E630", Offset = "0x2E6DA30", Length = "0x44")]
	[Token(Token = "0x60000C1")]
	public IEnumerable<String> GetIntDataKeys() { }

	[Address(RVA = "0x2E6E680", Offset = "0x2E6DA80", Length = "0x44")]
	[Token(Token = "0x60000C6")]
	public IEnumerable<SplineData`1<Int32>> GetIntDataValues() { }

	[Address(RVA = "0x2E6E6D0", Offset = "0x2E6DAD0", Length = "0xD0")]
	[Token(Token = "0x60000FD")]
	public override float GetLength() { }

	[Address(RVA = "0x2E6E7B0", Offset = "0x2E6DBB0", Length = "0x44")]
	[Token(Token = "0x60000C2")]
	public IEnumerable<String> GetObjectDataKeys() { }

	[Address(RVA = "0x2E6E800", Offset = "0x2E6DC00", Length = "0x44")]
	[Token(Token = "0x60000C7")]
	public IEnumerable<SplineData`1<Object>> GetObjectDataValues() { }

	[Address(RVA = "0x2E6E850", Offset = "0x2E6DC50", Length = "0x53")]
	[Token(Token = "0x60000B8")]
	public SplineData<float4> GetOrCreateFloat4Data(string key) { }

	[Address(RVA = "0x2E6E8B0", Offset = "0x2E6DCB0", Length = "0x53")]
	[Token(Token = "0x60000B7")]
	public SplineData<Single> GetOrCreateFloatData(string key) { }

	[Address(RVA = "0x2E6E910", Offset = "0x2E6DD10", Length = "0x53")]
	[Token(Token = "0x60000B9")]
	public SplineData<Int32> GetOrCreateIntData(string key) { }

	[Address(RVA = "0x2E6E970", Offset = "0x2E6DD70", Length = "0x53")]
	[Token(Token = "0x60000BA")]
	public SplineData<Object> GetOrCreateObjectData(string key) { }

	[Address(RVA = "0x2E6E9D0", Offset = "0x2E6DDD0", Length = "0x120")]
	[Token(Token = "0x60000C3")]
	public IEnumerable<String> GetSplineDataKeys(EmbeddedSplineDataType type) { }

	[Address(RVA = "0x2E6EB00", Offset = "0x2E6DF00", Length = "0x89")]
	[Token(Token = "0x60000D8")]
	public TangentMode GetTangentMode(int index) { }

	[Address(RVA = "0x2E6EB90", Offset = "0x2E6DF90", Length = "0x77")]
	[Token(Token = "0x60000EB")]
	public override int IndexOf(BezierKnot item) { }

	[Address(RVA = "0x2E6FFA0", Offset = "0x2E6F3A0", Length = "0x1FB")]
	[Token(Token = "0x600010B")]
	public void Insert(int index, float3 knotPosition, TangentMode tangentMode = 0) { }

	[Address(RVA = "0x2E701A0", Offset = "0x2E6F5A0", Length = "0x90")]
	[Token(Token = "0x60000EC")]
	public override void Insert(int index, BezierKnot knot) { }

	[Address(RVA = "0x2E6FF00", Offset = "0x2E6F300", Length = "0x99")]
	[Token(Token = "0x60000ED")]
	public void Insert(int index, BezierKnot knot, TangentMode mode) { }

	[Address(RVA = "0x2E6FE60", Offset = "0x2E6F260", Length = "0x9A")]
	[Token(Token = "0x60000EE")]
	public void Insert(int index, BezierKnot knot, TangentMode mode, float tension) { }

	[Address(RVA = "0x2E6EC10", Offset = "0x2E6E010", Length = "0x195")]
	[Token(Token = "0x60000EF")]
	private void InsertNoNotify(int index, BezierKnot knot, TangentMode mode, float tension) { }

	[Address(RVA = "0x2E6EDB0", Offset = "0x2E6E1B0", Length = "0xB95")]
	[Token(Token = "0x60000F0")]
	internal void InsertOnCurve(int index, float curveT) { }

	[Address(RVA = "0x2E6FE20", Offset = "0x2E6F220", Length = "0x37")]
	[Token(Token = "0x600010C")]
	public void InsertRange(int index, IEnumerable<float3> knotPositions, TangentMode tangentMode = 0) { }

	[Address(RVA = "0x2E6F950", Offset = "0x2E6ED50", Length = "0x4C4")]
	[Token(Token = "0x600010D")]
	private void InsertRangeNoNotify(int index, IEnumerable<float3> knotPositions, TangentMode tangentMode = 0, bool cacheCurves = false) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000D4")]
	protected override void OnSplineChanged() { }

	[Address(RVA = "0x2E705C0", Offset = "0x2E6F9C0", Length = "0x97")]
	[Token(Token = "0x6000114")]
	public override bool Remove(BezierKnot item) { }

	[Address(RVA = "0x2E739B0", Offset = "0x2E72DB0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000CF")]
	public void remove_changed(Action value) { }

	[Address(RVA = "0x2E738D0", Offset = "0x2E72CD0", Length = "0xD7")]
	[CompilerGenerated]
	[Token(Token = "0x60000D1")]
	public static void remove_Changed(Action<Spline, Int32, SplineModification> value) { }

	[Address(RVA = "0x2E70230", Offset = "0x2E6F630", Length = "0x15A")]
	[Token(Token = "0x60000F1")]
	public override void RemoveAt(int index) { }

	[Address(RVA = "0x2E70390", Offset = "0x2E6F790", Length = "0x53")]
	[Token(Token = "0x60000BC")]
	public bool RemoveFloat4Data(string key) { }

	[Address(RVA = "0x2E703F0", Offset = "0x2E6F7F0", Length = "0x53")]
	[Token(Token = "0x60000BB")]
	public bool RemoveFloatData(string key) { }

	[Address(RVA = "0x2E70450", Offset = "0x2E6F850", Length = "0x53")]
	[Token(Token = "0x60000BD")]
	public bool RemoveIntData(string key) { }

	[Address(RVA = "0x2E704B0", Offset = "0x2E6F8B0", Length = "0x53")]
	[Token(Token = "0x60000BE")]
	public bool RemoveObjectData(string key) { }

	[Address(RVA = "0x2E70510", Offset = "0x2E6F910", Length = "0xA7")]
	[Token(Token = "0x6000115")]
	internal void RemoveUnusedSplineData() { }

	[Address(RVA = "0x2E70660", Offset = "0x2E6FA60", Length = "0x161")]
	[Token(Token = "0x6000103")]
	public void Resize(int newSize) { }

	[Address(RVA = "0x2E73A50", Offset = "0x2E72E50", Length = "0xFC")]
	[Token(Token = "0x60000E9")]
	public void set_Closed(bool value) { }

	[Address(RVA = "0x2E73B50", Offset = "0x2E72F50", Length = "0xA7")]
	[Token(Token = "0x60000E5")]
	public void set_EditType(SplineType value) { }

	[Address(RVA = "0x2E73C00", Offset = "0x2E73000", Length = "0x82")]
	[Token(Token = "0x60000F3")]
	public override void set_Item(int index, BezierKnot value) { }

	[Address(RVA = "0x2E73C90", Offset = "0x2E73090", Length = "0xF5")]
	[Token(Token = "0x60000E7")]
	public void set_Knots(IEnumerable<BezierKnot> value) { }

	[Address(RVA = "0x2E70B10", Offset = "0x2E6FF10", Length = "0x114")]
	[Token(Token = "0x60000E0")]
	public void SetAutoSmoothTension(SplineRange range, float tension) { }

	[Address(RVA = "0x2E70C30", Offset = "0x2E70030", Length = "0x134")]
	[Token(Token = "0x60000DF")]
	public void SetAutoSmoothTension(int index, float tension) { }

	[Address(RVA = "0x2E707D0", Offset = "0x2E6FBD0", Length = "0x11B")]
	[Token(Token = "0x60000E3")]
	private void SetAutoSmoothTensionInternal(SplineRange range, float tension, bool setDirty) { }

	[Address(RVA = "0x2E708F0", Offset = "0x2E6FCF0", Length = "0xF9")]
	[Token(Token = "0x60000E2")]
	public void SetAutoSmoothTensionNoNotify(SplineRange range, float tension) { }

	[Address(RVA = "0x2E709F0", Offset = "0x2E6FDF0", Length = "0x119")]
	[Token(Token = "0x60000E1")]
	public void SetAutoSmoothTensionNoNotify(int index, float tension) { }

	[Address(RVA = "0x2E70E20", Offset = "0x2E70220", Length = "0x3AA")]
	[Token(Token = "0x60000D3")]
	internal void SetDirty(SplineModification modificationEvent, int knotIndex = -1) { }

	[Address(RVA = "0x2E70D70", Offset = "0x2E70170", Length = "0xA1")]
	[Token(Token = "0x60000D2")]
	internal void SetDirtyNoNotify() { }

	[Address(RVA = "0x2E711D0", Offset = "0x2E705D0", Length = "0x63")]
	[Token(Token = "0x60000C9")]
	public void SetFloat4Data(string key, SplineData<float4> value) { }

	[Address(RVA = "0x2E71240", Offset = "0x2E70640", Length = "0x63")]
	[Token(Token = "0x60000C8")]
	public void SetFloatData(string key, SplineData<Single> value) { }

	[Address(RVA = "0x2E712B0", Offset = "0x2E706B0", Length = "0x63")]
	[Token(Token = "0x60000CA")]
	public void SetIntData(string key, SplineData<Int32> value) { }

	[Address(RVA = "0x2E71480", Offset = "0x2E70880", Length = "0x8B")]
	[Token(Token = "0x60000F4")]
	public void SetKnot(int index, BezierKnot value, BezierTangent main = 1) { }

	[Address(RVA = "0x2E71320", Offset = "0x2E70720", Length = "0x157")]
	[Token(Token = "0x60000F5")]
	public void SetKnotNoNotify(int index, BezierKnot value, BezierTangent main = 1) { }

	[Address(RVA = "0x2E71510", Offset = "0x2E70910", Length = "0x63")]
	[Token(Token = "0x60000CB")]
	public void SetObjectData(string key, SplineData<Object> value) { }

	[Address(RVA = "0x2E718D0", Offset = "0x2E70CD0", Length = "0x1D5")]
	[Token(Token = "0x60000DB")]
	public void SetTangentMode(SplineRange range, TangentMode mode, BezierTangent main = 1) { }

	[Address(RVA = "0x2E71AB0", Offset = "0x2E70EB0", Length = "0xD8")]
	[Token(Token = "0x60000DA")]
	public void SetTangentMode(int index, TangentMode mode, BezierTangent main = 1) { }

	[Address(RVA = "0x2E71830", Offset = "0x2E70C30", Length = "0x95")]
	[Token(Token = "0x60000D9")]
	public void SetTangentMode(TangentMode mode) { }

	[Address(RVA = "0x2E71580", Offset = "0x2E70980", Length = "0x2A8")]
	[Token(Token = "0x60000DC")]
	public void SetTangentModeNoNotify(int index, TangentMode mode, BezierTangent main = 1) { }

	[Address(RVA = "0x2E71B90", Offset = "0x2E70F90", Length = "0xAD")]
	[Token(Token = "0x6000107")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x2E71C40", Offset = "0x2E71040", Length = "0x44")]
	[Token(Token = "0x6000104")]
	public BezierKnot[] ToArray() { }

	[Address(RVA = "0x2E71C90", Offset = "0x2E71090", Length = "0x63")]
	[Token(Token = "0x60000B4")]
	public bool TryGetFloat4Data(string key, out SplineData<float4>& data) { }

	[Address(RVA = "0x2E71D00", Offset = "0x2E71100", Length = "0x63")]
	[Token(Token = "0x60000B3")]
	public bool TryGetFloatData(string key, out SplineData<Single>& data) { }

	[Address(RVA = "0x2E71D70", Offset = "0x2E71170", Length = "0x63")]
	[Token(Token = "0x60000B5")]
	public bool TryGetIntData(string key, out SplineData<Int32>& data) { }

	[Address(RVA = "0x2E71DE0", Offset = "0x2E711E0", Length = "0x63")]
	[Token(Token = "0x60000B6")]
	public bool TryGetObjectData(string key, out SplineData<Object>& data) { }

	[Address(RVA = "0x2E71FD0", Offset = "0x2E713D0", Length = "0x367")]
	[Token(Token = "0x6000102")]
	public void Warmup() { }

	[Address(RVA = "0x2E71E50", Offset = "0x2E71250", Length = "0x178")]
	[Token(Token = "0x6000100")]
	private void WarmUpCurveUps() { }

}

