namespace UnityEngine.AdaptivePerformance.Provider;

[Token(Token = "0x2000051")]
public struct PerformanceDataRecord
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400013D")]
	private Feature <ChangeFlags>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400013E")]
	private float <TemperatureLevel>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400013F")]
	private float <TemperatureTrend>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000140")]
	private WarningLevel <WarningLevel>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000141")]
	private int <CpuPerformanceLevel>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000142")]
	private int <GpuPerformanceLevel>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000143")]
	private bool <PerformanceLevelControlAvailable>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000144")]
	private float <CpuFrameTime>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000145")]
	private float <GpuFrameTime>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000146")]
	private float <OverallFrameTime>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000147")]
	private bool <CpuPerformanceBoost>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000148")]
	private bool <GpuPerformanceBoost>k__BackingField; //Field offset: 0x29
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000149")]
	private ClusterInfo <ClusterInfo>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400014A")]
	private PerformanceMode <PerformanceMode>k__BackingField; //Field offset: 0x38

	[Token(Token = "0x170000AE")]
	public Feature ChangeFlags
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000249")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x600024A")]
		 set { } //Length: 3
	}

	[Token(Token = "0x170000BA")]
	public ClusterInfo ClusterInfo
	{
		[Address(RVA = "0x2C150E0", Offset = "0x2C144E0", Length = "0x13")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600025D")]
		 get { } //Length: 19
	}

	[Token(Token = "0x170000B5")]
	public float CpuFrameTime
	{
		[Address(RVA = "0x1DF2990", Offset = "0x1DF1D90", Length = "0x6")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000256")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000B8")]
	public bool CpuPerformanceBoost
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000259")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600025A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000B2")]
	public int CpuPerformanceLevel
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000250")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000251")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000B6")]
	public float GpuFrameTime
	{
		[Address(RVA = "0x1D40680", Offset = "0x1D3FA80", Length = "0x6")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000257")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000B9")]
	public bool GpuPerformanceBoost
	{
		[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600025B")]
		 get { } //Length: 5
		[Address(RVA = "0x2707C90", Offset = "0x2707090", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600025C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000B3")]
	public int GpuPerformanceLevel
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000252")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000253")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000B7")]
	public float OverallFrameTime
	{
		[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000258")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000B4")]
	public bool PerformanceLevelControlAvailable
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000254")]
		 get { } //Length: 5
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000255")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000BB")]
	public PerformanceMode PerformanceMode
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600025E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000AF")]
	public float TemperatureLevel
	{
		[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600024B")]
		 get { } //Length: 388
		[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600024C")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170000B0")]
	public float TemperatureTrend
	{
		[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600024D")]
		 get { } //Length: 229
		[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600024E")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170000B1")]
	public WarningLevel WarningLevel
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600024F")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000249")]
	public Feature get_ChangeFlags() { }

	[Address(RVA = "0x2C150E0", Offset = "0x2C144E0", Length = "0x13")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600025D")]
	public ClusterInfo get_ClusterInfo() { }

	[Address(RVA = "0x1DF2990", Offset = "0x1DF1D90", Length = "0x6")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000256")]
	public float get_CpuFrameTime() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000259")]
	public bool get_CpuPerformanceBoost() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000250")]
	public int get_CpuPerformanceLevel() { }

	[Address(RVA = "0x1D40680", Offset = "0x1D3FA80", Length = "0x6")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000257")]
	public float get_GpuFrameTime() { }

	[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600025B")]
	public bool get_GpuPerformanceBoost() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000252")]
	public int get_GpuPerformanceLevel() { }

	[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000258")]
	public float get_OverallFrameTime() { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000254")]
	public bool get_PerformanceLevelControlAvailable() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600025E")]
	public PerformanceMode get_PerformanceMode() { }

	[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600024B")]
	public float get_TemperatureLevel() { }

	[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600024D")]
	public float get_TemperatureTrend() { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600024F")]
	public WarningLevel get_WarningLevel() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x600024A")]
	public void set_ChangeFlags(Feature value) { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600025A")]
	public void set_CpuPerformanceBoost(bool value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000251")]
	public void set_CpuPerformanceLevel(int value) { }

	[Address(RVA = "0x2707C90", Offset = "0x2707090", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600025C")]
	public void set_GpuPerformanceBoost(bool value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000253")]
	public void set_GpuPerformanceLevel(int value) { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000255")]
	public void set_PerformanceLevelControlAvailable(bool value) { }

	[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600024C")]
	public void set_TemperatureLevel(float value) { }

	[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600024E")]
	public void set_TemperatureTrend(float value) { }

}

