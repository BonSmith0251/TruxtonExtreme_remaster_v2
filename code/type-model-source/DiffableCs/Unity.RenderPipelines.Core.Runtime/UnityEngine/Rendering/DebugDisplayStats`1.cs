namespace UnityEngine.Rendering;

[Token(Token = "0x2000083")]
public abstract class DebugDisplayStats
{
	[CompilerGenerated]
	[Token(Token = "0x2000086")]
	private sealed class <>c__DisplayClass19_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B2")]
		public TProfileId samplerId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B3")]
		public ProfilingSampler sampler; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B4")]
		public DebugProfilingType<TProfileId> type; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B5")]
		public DebugDisplayStats<TProfileId> <>4__this; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000606")]
		public <>c__DisplayClass19_0() { }

		[Address(RVA = "0xA545C0", Offset = "0xA539C0", Length = "0x55")]
		[Token(Token = "0x6000607")]
		internal object <BuildProfilingSamplerWidgetList>b__1() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000087")]
	private sealed class <>c__DisplayClass19_1
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B6")]
		public TProfileId samplerId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B7")]
		public DebugDisplayStats<TProfileId> <>4__this; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000608")]
		public <>c__DisplayClass19_1() { }

		[Address(RVA = "0xA54620", Offset = "0xA53A20", Length = "0x4C")]
		[Token(Token = "0x6000609")]
		internal bool <BuildProfilingSamplerWidgetList>b__2() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000088")]
	private sealed class <>c__DisplayClass19_2
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B8")]
		public ProfilingSampler sampler; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B9")]
		public <>c__DisplayClass19_1<TProfileId> CS$<>8__locals1; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600060A")]
		public <>c__DisplayClass19_2() { }

		[Address(RVA = "0xA548F0", Offset = "0xA53CF0", Length = "0x4A")]
		[Token(Token = "0x600060B")]
		internal Value <BuildProfilingSamplerWidgetList>b__3(DebugProfilingType<TProfileId> e) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000089")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001BA")]
		public Type type; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001BB")]
		public Func<MemberInfo, Boolean> <>9__0; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600060C")]
		public <>c__DisplayClass6_0() { }

		[Address(RVA = "0xA750F0", Offset = "0xA744F0", Length = "0x65")]
		[Token(Token = "0x600060D")]
		internal bool <GetProfilerIdsToDisplay>b__0(MemberInfo m) { }

	}

	[Token(Token = "0x2000084")]
	private class AccumulatedTiming
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001AC")]
		public float accumulatedValue; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001AD")]
		public float lastAverage; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000605")]
		public AccumulatedTiming() { }

		[Address(RVA = "0x1B5CDE0", Offset = "0x1B5C1E0", Length = "0x1D")]
		[Token(Token = "0x6000604")]
		internal void UpdateLastAverage(int frameCount) { }

	}

	[Token(Token = "0x2000085")]
	private enum DebugProfilingType : int
	{
		CPU = 0,
		InlineCPU = 1,
		GPU = 2,
	}

	[Token(Token = "0x40001A4")]
	private static readonly String[] k_DetailedStatsColumnLabels; //Field offset: 0x0
	[Token(Token = "0x40001A9")]
	private const float k_AccumulationTimeInSeconds = 1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001A5")]
	private Dictionary<TProfileId, AccumulatedTiming<TProfileId>>[] m_AccumulatedTiming; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001A6")]
	private float m_TimeSinceLastAvgValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001A7")]
	private int m_AccumulatedFrames; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001A8")]
	private HashSet<TProfileId> m_HiddenProfileIds; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001AA")]
	protected bool averageProfilerTimingsOverASecond; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001AB")]
	protected bool hideEmptyScopes; //Field offset: 0x0

	[Address(RVA = "0x17D21E0", Offset = "0x17D15E0", Length = "0x154")]
	[Token(Token = "0x6000602")]
	private static DebugDisplayStats`1() { }

	[Address(RVA = "0x17D2740", Offset = "0x17D1B40", Length = "0x295")]
	[Token(Token = "0x6000601")]
	protected DebugDisplayStats`1() { }

	[Address(RVA = "0x17D0E00", Offset = "0x17D0200", Length = "0x22C")]
	[CompilerGenerated]
	[Token(Token = "0x6000603")]
	private Value <BuildProfilingSamplerWidgetList>g__CreateWidgetForSampler|19_0(TProfileId samplerId, ProfilingSampler sampler, DebugProfilingType<TProfileId> type) { }

	[Address(RVA = "0x17CF680", Offset = "0x17CEA80", Length = "0x106")]
	[Token(Token = "0x60005FD")]
	protected Widget BuildDetailedStatsList(string title, List<TProfileId> samplers) { }

	[Address(RVA = "0x17CFE00", Offset = "0x17CF200", Length = "0x538")]
	[Token(Token = "0x6000600")]
	private ObservableList<Widget> BuildProfilingSamplerWidgetList(IEnumerable<TProfileId> samplers) { }

	[Token(Token = "0x60005F8")]
	public abstract void DisableProfilingRecorders() { }

	[Token(Token = "0x60005F7")]
	public abstract void EnableProfilingRecorders() { }

	[Address(RVA = "0x17D0340", Offset = "0x17CF740", Length = "0x422")]
	[Token(Token = "0x60005FB")]
	protected List<TProfileId> GetProfilerIdsToDisplay() { }

	[Address(RVA = "0x17D0BD0", Offset = "0x17CFFD0", Length = "0xD6")]
	[Token(Token = "0x60005FF")]
	private float GetSamplerTiming(TProfileId samplerId, ProfilingSampler sampler, DebugProfilingType<TProfileId> type) { }

	[Token(Token = "0x60005F9")]
	public abstract void RegisterDebugUI(List<Widget> list) { }

	[Token(Token = "0x60005FA")]
	public abstract void Update() { }

	[Address(RVA = "0x17D1460", Offset = "0x17D0860", Length = "0xAB")]
	[Token(Token = "0x60005FC")]
	protected void UpdateDetailedStats(List<TProfileId> samplers) { }

	[Address(RVA = "0x17D1D10", Offset = "0x17D1110", Length = "0x4C6")]
	[Token(Token = "0x60005FE")]
	private void UpdateListOfAveragedProfilerTimings(bool needUpdatingAverages, List<TProfileId> samplers) { }

}

