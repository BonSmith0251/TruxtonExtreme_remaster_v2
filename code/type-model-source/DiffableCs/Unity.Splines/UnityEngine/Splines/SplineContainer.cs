namespace UnityEngine.Splines;

[AddComponentMenu("Splines/Spline Container")]
[DefaultMember("Item")]
[ExecuteAlways]
[Token(Token = "0x200002B")]
public sealed class SplineContainer : MonoBehaviour, ISplineContainer, ISerializationCallbackReceiver
{
	[CompilerGenerated]
	[Token(Token = "0x200002D")]
	private sealed class <>c__DisplayClass21_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000AE")]
		public IReadOnlyList<Spline> value; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000AF")]
		public int i; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000B0")]
		public Predicate<Spline> <>9__0; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60001A0")]
		public <>c__DisplayClass21_0() { }

		[Address(RVA = "0x2E73D90", Offset = "0x2E73190", Length = "0x5D")]
		[Token(Token = "0x60001A1")]
		internal bool <set_Splines>b__0(Spline spline) { }

	}

	[Token(Token = "0x200002C")]
	private struct SplineToNative
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AC")]
		public ISpline spline; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000AD")]
		public NativeSpline nativeSpline; //Field offset: 0x8

	}

	[Token(Token = "0x400009E")]
	private const string k_IconPath = "Packages/com.unity.splines/Editor/Editor Resources/Icons/SplineComponent.png"; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x40000A5")]
	private static Action<SplineContainer, Int32> SplineAdded; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x40000A6")]
	private static Action<SplineContainer, Int32> SplineRemoved; //Field offset: 0x8
	[CompilerGenerated]
	[Token(Token = "0x40000A7")]
	private static Action<SplineContainer, Int32, Int32> SplineReordered; //Field offset: 0x10
	[Token(Token = "0x40000AB")]
	private static List<SplineToNative> s_AllocPreventionHelperBuffer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[Obsolete]
	[SerializeField]
	[Token(Token = "0x400009F")]
	private Spline m_Spline; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40000A0")]
	private Spline[] m_Splines; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40000A1")]
	private KnotLinkCollection m_Knots; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000A2")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"previousIndex", "newIndex"})]
	private List<ValueTuple`2<Int32, Int32>> m_ReorderedSplinesIndices; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000A3")]
	private List<Int32> m_RemovedSplinesIndices; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000A4")]
	private List<Int32> m_AddedSplinesIndices; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000A8")]
	private ReadOnlyCollection<Spline> m_ReadOnlySplines; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000A9")]
	private Dictionary<ISpline, NativeSpline> m_NativeSplinesCache; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000AA")]
	private float4x4 m_NativeSplinesCacheTransform; //Field offset: 0x60

	[Token(Token = "0x14000006")]
	public static event Action<SplineContainer, Int32> SplineAdded
	{
		[Address(RVA = "0x2E60C80", Offset = "0x2E60080", Length = "0x101")]
		[CompilerGenerated]
		[Token(Token = "0x6000173")]
		 add { } //Length: 257
		[Address(RVA = "0x2E61110", Offset = "0x2E60510", Length = "0x101")]
		[CompilerGenerated]
		[Token(Token = "0x6000174")]
		 remove { } //Length: 257
	}

	[Token(Token = "0x14000007")]
	public static event Action<SplineContainer, Int32> SplineRemoved
	{
		[Address(RVA = "0x2E60D90", Offset = "0x2E60190", Length = "0x105")]
		[CompilerGenerated]
		[Token(Token = "0x6000175")]
		 add { } //Length: 261
		[Address(RVA = "0x2E61220", Offset = "0x2E60620", Length = "0x105")]
		[CompilerGenerated]
		[Token(Token = "0x6000176")]
		 remove { } //Length: 261
	}

	[Token(Token = "0x14000008")]
	public static event Action<SplineContainer, Int32, Int32> SplineReordered
	{
		[Address(RVA = "0x2E60EA0", Offset = "0x2E602A0", Length = "0x105")]
		[CompilerGenerated]
		[Token(Token = "0x6000177")]
		 add { } //Length: 261
		[Address(RVA = "0x2E61330", Offset = "0x2E60730", Length = "0x105")]
		[CompilerGenerated]
		[Token(Token = "0x6000178")]
		 remove { } //Length: 261
	}

	[Token(Token = "0x17000052")]
	private bool IsNonUniformlyScaled
	{
		[Address(RVA = "0x2E60FB0", Offset = "0x2E603B0", Length = "0x8F")]
		[Token(Token = "0x6000187")]
		private get { } //Length: 143
	}

	[Token(Token = "0x17000051")]
	public Spline Item
	{
		[Address(RVA = "0x1E13990", Offset = "0x1E12D90", Length = "0x2B")]
		[Token(Token = "0x600017D")]
		 get { } //Length: 43
	}

	[Token(Token = "0x17000050")]
	public override KnotLinkCollection KnotLinkCollection
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600017C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000053")]
	public Spline Spline
	{
		[Address(RVA = "0x2E61040", Offset = "0x2E60440", Length = "0x35")]
		[Token(Token = "0x6000188")]
		 get { } //Length: 53
		[Address(RVA = "0x2E61440", Offset = "0x2E60840", Length = "0x76")]
		[Token(Token = "0x6000189")]
		 set { } //Length: 118
	}

	[Token(Token = "0x1700004F")]
	public override IReadOnlyList<Spline> Splines
	{
		[Address(RVA = "0x2E61080", Offset = "0x2E60480", Length = "0x8C")]
		[Token(Token = "0x6000179")]
		 get { } //Length: 140
		[Address(RVA = "0x2E614C0", Offset = "0x2E608C0", Length = "0xA50")]
		[Token(Token = "0x600017A")]
		 set { } //Length: 2640
	}

	[Address(RVA = "0x2E60950", Offset = "0x2E5FD50", Length = "0x8E")]
	[Token(Token = "0x600019F")]
	private static SplineContainer() { }

	[Address(RVA = "0x2E609E0", Offset = "0x2E5FDE0", Length = "0x299")]
	[Token(Token = "0x600019E")]
	public SplineContainer() { }

	[Address(RVA = "0x2E60C80", Offset = "0x2E60080", Length = "0x101")]
	[CompilerGenerated]
	[Token(Token = "0x6000173")]
	public static void add_SplineAdded(Action<SplineContainer, Int32> value) { }

	[Address(RVA = "0x2E60D90", Offset = "0x2E60190", Length = "0x105")]
	[CompilerGenerated]
	[Token(Token = "0x6000175")]
	public static void add_SplineRemoved(Action<SplineContainer, Int32> value) { }

	[Address(RVA = "0x2E60EA0", Offset = "0x2E602A0", Length = "0x105")]
	[CompilerGenerated]
	[Token(Token = "0x6000177")]
	public static void add_SplineReordered(Action<SplineContainer, Int32, Int32> value) { }

	[Address(RVA = "0x2E5F500", Offset = "0x2E5E900", Length = "0xF6")]
	[Token(Token = "0x600019A")]
	public float CalculateLength(int splineIndex) { }

	[Address(RVA = "0x2E5F600", Offset = "0x2E5EA00", Length = "0xA")]
	[Token(Token = "0x6000199")]
	public float CalculateLength() { }

	[Address(RVA = "0x2E5F610", Offset = "0x2E5EA10", Length = "0x77")]
	[Token(Token = "0x6000183")]
	internal void ClearCaches() { }

	[Address(RVA = "0x2E5F690", Offset = "0x2E5EA90", Length = "0x2B9")]
	[Token(Token = "0x6000184")]
	private void DisposeNativeSplinesCache() { }

	[Address(RVA = "0x8F9A40", Offset = "0x8F8E40", Length = "0x376")]
	[Token(Token = "0x600018C")]
	public bool Evaluate(T spline, float t, out float3 position, out float3 tangent, out float3 upVector) { }

	[Address(RVA = "0x2E5FF30", Offset = "0x2E5F330", Length = "0x8C")]
	[Token(Token = "0x600018B")]
	public bool Evaluate(int splineIndex, float t, out float3 position, out float3 tangent, out float3 upVector) { }

	[Address(RVA = "0x2E5FE90", Offset = "0x2E5F290", Length = "0x9B")]
	[Token(Token = "0x600018A")]
	public bool Evaluate(float t, out float3 position, out float3 tangent, out float3 upVector) { }

	[Address(RVA = "0x8F85C0", Offset = "0x8F79C0", Length = "0x1C5")]
	[Token(Token = "0x6000198")]
	public float3 EvaluateAcceleration(T spline, float t) { }

	[Address(RVA = "0x2E5F950", Offset = "0x2E5ED50", Length = "0xA0")]
	[Token(Token = "0x6000197")]
	public float3 EvaluateAcceleration(int splineIndex, float t) { }

	[Address(RVA = "0x2E5FA00", Offset = "0x2E5EE00", Length = "0x93")]
	[Token(Token = "0x6000196")]
	public float3 EvaluateAcceleration(float t) { }

	[Address(RVA = "0x2E5FB40", Offset = "0x2E5EF40", Length = "0xA0")]
	[Token(Token = "0x600018E")]
	public float3 EvaluatePosition(int splineIndex, float t) { }

	[Address(RVA = "0x2E5FAA0", Offset = "0x2E5EEA0", Length = "0x93")]
	[Token(Token = "0x600018D")]
	public float3 EvaluatePosition(float t) { }

	[Address(RVA = "0x8F8A80", Offset = "0x8F7E80", Length = "0x1CC")]
	[Token(Token = "0x600018F")]
	public float3 EvaluatePosition(T spline, float t) { }

	[Address(RVA = "0x2E5FCA0", Offset = "0x2E5F0A0", Length = "0x93")]
	[Token(Token = "0x6000190")]
	public float3 EvaluateTangent(float t) { }

	[Address(RVA = "0x8F8F40", Offset = "0x8F8340", Length = "0x1CC")]
	[Token(Token = "0x6000192")]
	public float3 EvaluateTangent(T spline, float t) { }

	[Address(RVA = "0x2E5FBF0", Offset = "0x2E5EFF0", Length = "0xA0")]
	[Token(Token = "0x6000191")]
	public float3 EvaluateTangent(int splineIndex, float t) { }

	[Address(RVA = "0x8F9400", Offset = "0x8F8800", Length = "0x1C5")]
	[Token(Token = "0x6000195")]
	public float3 EvaluateUpVector(T spline, float t) { }

	[Address(RVA = "0x2E5FD40", Offset = "0x2E5F140", Length = "0xA0")]
	[Token(Token = "0x6000194")]
	public float3 EvaluateUpVector(int splineIndex, float t) { }

	[Address(RVA = "0x2E5FDF0", Offset = "0x2E5F1F0", Length = "0x93")]
	[Token(Token = "0x6000193")]
	public float3 EvaluateUpVector(float t) { }

	[Address(RVA = "0x1F33B80", Offset = "0x1F32F80", Length = "0x32")]
	[Token(Token = "0x600017E")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2E60FB0", Offset = "0x2E603B0", Length = "0x8F")]
	[Token(Token = "0x6000187")]
	private bool get_IsNonUniformlyScaled() { }

	[Address(RVA = "0x1E13990", Offset = "0x1E12D90", Length = "0x2B")]
	[Token(Token = "0x600017D")]
	public Spline get_Item(int index) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600017C")]
	public override KnotLinkCollection get_KnotLinkCollection() { }

	[Address(RVA = "0x2E61040", Offset = "0x2E60440", Length = "0x35")]
	[Token(Token = "0x6000188")]
	public Spline get_Spline() { }

	[Address(RVA = "0x2E61080", Offset = "0x2E60480", Length = "0x8C")]
	[Token(Token = "0x6000179")]
	public override IReadOnlyList<Spline> get_Splines() { }

	[Address(RVA = "0x8FA7A0", Offset = "0x8F9BA0", Length = "0x8CC")]
	[Token(Token = "0x600019D")]
	private NativeSpline GetOrBakeNativeSpline(T spline) { }

	[Address(RVA = "0x2E5FFC0", Offset = "0x2E5F3C0", Length = "0xA7")]
	[Token(Token = "0x600017B")]
	private static int IndexOf(IReadOnlyList<Spline> self, Spline elementToFind) { }

	[Address(RVA = "0x2E60070", Offset = "0x2E5F470", Length = "0x25B")]
	[Token(Token = "0x600019C")]
	public override void OnAfterDeserialize() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600019B")]
	public override void OnBeforeSerialize() { }

	[Address(RVA = "0x2E602D0", Offset = "0x2E5F6D0", Length = "0x7")]
	[Token(Token = "0x6000181")]
	private void OnDestroy() { }

	[Address(RVA = "0x2E602E0", Offset = "0x2E5F6E0", Length = "0x6D")]
	[Token(Token = "0x6000180")]
	private void OnDisable() { }

	[Address(RVA = "0x2E60350", Offset = "0x2E5F750", Length = "0x6D")]
	[Token(Token = "0x600017F")]
	private void OnEnable() { }

	[Address(RVA = "0x2E603C0", Offset = "0x2E5F7C0", Length = "0x96")]
	[Token(Token = "0x6000186")]
	private void OnKnotModified(Spline spline, int index) { }

	[Address(RVA = "0x2E60460", Offset = "0x2E5F860", Length = "0x25B")]
	[Token(Token = "0x6000185")]
	private void OnSplineChanged(Spline spline, int index, SplineModification modificationType) { }

	[Address(RVA = "0x2E61110", Offset = "0x2E60510", Length = "0x101")]
	[CompilerGenerated]
	[Token(Token = "0x6000174")]
	public static void remove_SplineAdded(Action<SplineContainer, Int32> value) { }

	[Address(RVA = "0x2E61220", Offset = "0x2E60620", Length = "0x105")]
	[CompilerGenerated]
	[Token(Token = "0x6000176")]
	public static void remove_SplineRemoved(Action<SplineContainer, Int32> value) { }

	[Address(RVA = "0x2E61330", Offset = "0x2E60730", Length = "0x105")]
	[CompilerGenerated]
	[Token(Token = "0x6000178")]
	public static void remove_SplineReordered(Action<SplineContainer, Int32, Int32> value) { }

	[Address(RVA = "0x2E61440", Offset = "0x2E60840", Length = "0x76")]
	[Token(Token = "0x6000189")]
	public void set_Spline(Spline value) { }

	[Address(RVA = "0x2E614C0", Offset = "0x2E608C0", Length = "0xA50")]
	[Token(Token = "0x600017A")]
	public override void set_Splines(IReadOnlyList<Spline> value) { }

	[Address(RVA = "0x2E606C0", Offset = "0x2E5FAC0", Length = "0x28B")]
	[Token(Token = "0x6000182")]
	public void Warmup() { }

}

