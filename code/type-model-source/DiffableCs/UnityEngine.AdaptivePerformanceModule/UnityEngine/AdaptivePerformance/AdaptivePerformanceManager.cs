namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000006")]
internal class AdaptivePerformanceManager : MonoBehaviour, IAdaptivePerformance, IThermalStatus, IPerformanceStatus, IDevicePerformanceControl, IDevelopmentSettings, IPerformanceModeStatus
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000002")]
	private ThermalEventHandler ThermalEvent; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000003")]
	private PerformanceBottleneckChangeHandler PerformanceBottleneckChangeEvent; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000004")]
	private PerformanceLevelChangeHandler PerformanceLevelChangeEvent; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000005")]
	private PerformanceBoostChangeHandler PerformanceBoostChangeEvent; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000006")]
	private PerformanceModeEventHandler PerformanceModeEvent; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000007")]
	private bool m_JustResumed; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000008")]
	private int m_RequestedCpuLevel; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000009")]
	private int m_RequestedGpuLevel; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400000A")]
	private bool m_NewUserPerformanceLevelRequest; //Field offset: 0x54
	[FieldOffset(Offset = "0x55")]
	[Token(Token = "0x400000B")]
	private bool m_RequestedCpuBoost; //Field offset: 0x55
	[FieldOffset(Offset = "0x56")]
	[Token(Token = "0x400000C")]
	private bool m_RequestedGpuBoost; //Field offset: 0x56
	[FieldOffset(Offset = "0x57")]
	[Token(Token = "0x400000D")]
	private bool m_NewUserCpuPerformanceBoostRequest; //Field offset: 0x57
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400000E")]
	private bool m_NewUserGpuPerformanceBoostRequest; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400000F")]
	private ThermalMetrics m_ThermalMetrics; //Field offset: 0x5C
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000010")]
	private PerformanceMetrics m_PerformanceMetrics; //Field offset: 0x68
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000011")]
	private FrameTiming m_FrameTiming; //Field offset: 0x84
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000012")]
	private PerformanceMode m_PerformanceMode; //Field offset: 0x9C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000013")]
	private int <LoggingFrequencyInFrames>k__BackingField; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000014")]
	private bool m_AutomaticPerformanceControl; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA5")]
	[Token(Token = "0x4000015")]
	private bool m_AutomaticPerformanceControlChanged; //Field offset: 0xA5
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000016")]
	private AdaptivePerformanceIndexer <Indexer>k__BackingField; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000017")]
	private IAdaptivePerformanceSettings m_Settings; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000018")]
	private AdaptivePerformanceSubsystem m_Subsystem; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000019")]
	private DevicePerformanceControlImpl m_DevicePerfControl; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400001A")]
	private AutoPerformanceLevelController m_AutoPerformanceLevelController; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400001B")]
	private AutoPerformanceModeController m_AutoPerformanceModeController; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400001C")]
	private CpuTimeProvider m_CpuFrameTimeProvider; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400001D")]
	private GpuTimeProvider m_GpuFrameTimeProvider; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400001E")]
	private IApplicationLifecycle m_AppLifecycle; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400001F")]
	private TemperatureTrend m_TemperatureTrend; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000020")]
	private bool m_UseProviderOverallFrameTime; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000021")]
	private WaitForEndOfFrame m_WaitForEndOfFrame; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000022")]
	private int m_FrameCount; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000023")]
	private RunningAverage m_OverallFrameTime; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000024")]
	private float m_OverallFrameTimeAccu; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000025")]
	private RunningAverage m_GpuFrameTime; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000026")]
	private RunningAverage m_CpuFrameTime; //Field offset: 0x128

	[Token(Token = "0x14000004")]
	public override event PerformanceBoostChangeHandler PerformanceBoostChangeEvent
	{
		[Address(RVA = "0x2F90CE0", Offset = "0x2F900E0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600000D")]
		 add { } //Length: 158
		[Address(RVA = "0x2F91490", Offset = "0x2F90890", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600000E")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000002")]
	public override event PerformanceBottleneckChangeHandler PerformanceBottleneckChangeEvent
	{
		[Address(RVA = "0x2F90D80", Offset = "0x2F90180", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000009")]
		 add { } //Length: 158
		[Address(RVA = "0x2F91530", Offset = "0x2F90930", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600000A")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000003")]
	public override event PerformanceLevelChangeHandler PerformanceLevelChangeEvent
	{
		[Address(RVA = "0x2F90E20", Offset = "0x2F90220", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600000B")]
		 add { } //Length: 158
		[Address(RVA = "0x2F915D0", Offset = "0x2F909D0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600000C")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000005")]
	public override event PerformanceModeEventHandler PerformanceModeEvent
	{
		[Address(RVA = "0x2F90EC0", Offset = "0x2F902C0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600000F")]
		 add { } //Length: 158
		[Address(RVA = "0x2F91670", Offset = "0x2F90A70", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000010")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000001")]
	public override event ThermalEventHandler ThermalEvent
	{
		[Address(RVA = "0x2F90F60", Offset = "0x2F90360", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000007")]
		 add { } //Length: 158
		[Address(RVA = "0x2F91710", Offset = "0x2F90B10", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000008")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000008")]
	public override bool Active
	{
		[Address(RVA = "0x2F91000", Offset = "0x2F90400", Length = "0x137")]
		[Token(Token = "0x600001A")]
		 get { } //Length: 311
	}

	[Token(Token = "0x1700000B")]
	public override bool AutomaticPerformanceControl
	{
		[Address(RVA = "0x2F91140", Offset = "0x2F90540", Length = "0xA")]
		[Token(Token = "0x600001D")]
		 get { } //Length: 10
		[Address(RVA = "0x2F917B0", Offset = "0x2F90BB0", Length = "0xE")]
		[Token(Token = "0x600001E")]
		 set { } //Length: 14
	}

	[Token(Token = "0x1700000D")]
	public override int CpuLevel
	{
		[Address(RVA = "0x2F91150", Offset = "0x2F90550", Length = "0x6")]
		[Token(Token = "0x6000020")]
		 get { } //Length: 6
		[Address(RVA = "0x2F917C0", Offset = "0x2F90BC0", Length = "0x8")]
		[Token(Token = "0x6000021")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700000F")]
	public override bool CpuPerformanceBoost
	{
		[Address(RVA = "0x2F91160", Offset = "0x2F90560", Length = "0x7")]
		[Token(Token = "0x6000024")]
		 get { } //Length: 7
		[Address(RVA = "0x2F917D0", Offset = "0x2F90BD0", Length = "0x8")]
		[Token(Token = "0x6000025")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000011")]
	public override IDevelopmentSettings DevelopmentSettings
	{
		[Address(RVA = "0x2081AD0", Offset = "0x2080ED0", Length = "0x6")]
		[Token(Token = "0x6000028")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000014")]
	public override IDevicePerformanceControl DevicePerformanceControl
	{
		[Address(RVA = "0x2081AD0", Offset = "0x2080ED0", Length = "0x6")]
		[Token(Token = "0x600002B")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000003")]
	public override FrameTiming FrameTiming
	{
		[Address(RVA = "0x2F91170", Offset = "0x2F90570", Length = "0x1B")]
		[Token(Token = "0x6000013")]
		 get { } //Length: 27
	}

	[Token(Token = "0x1700000E")]
	public override int GpuLevel
	{
		[Address(RVA = "0x1073720", Offset = "0x1072B20", Length = "0x6")]
		[Token(Token = "0x6000022")]
		 get { } //Length: 6
		[Address(RVA = "0x2F917E0", Offset = "0x2F90BE0", Length = "0x8")]
		[Token(Token = "0x6000023")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000010")]
	public override bool GpuPerformanceBoost
	{
		[Address(RVA = "0x2F91190", Offset = "0x2F90590", Length = "0x7")]
		[Token(Token = "0x6000026")]
		 get { } //Length: 7
		[Address(RVA = "0x2F917F0", Offset = "0x2F90BF0", Length = "0x8")]
		[Token(Token = "0x6000027")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000016")]
	public private override AdaptivePerformanceIndexer Indexer
	{
		[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600002D")]
		 get { } //Length: 8
		[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600002E")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000007")]
	public override bool Initialized
	{
		[Address(RVA = "0x2F911A0", Offset = "0x2F905A0", Length = "0x121")]
		[Token(Token = "0x6000019")]
		 get { } //Length: 289
	}

	[Token(Token = "0x17000005")]
	public override bool Logging
	{
		[Address(RVA = "0x2F912D0", Offset = "0x2F906D0", Length = "0x36")]
		[Token(Token = "0x6000015")]
		 get { } //Length: 54
		[Address(RVA = "0x2F91800", Offset = "0x2F90C00", Length = "0x3B")]
		[Token(Token = "0x6000016")]
		 set { } //Length: 59
	}

	[Token(Token = "0x17000006")]
	public override int LoggingFrequencyInFrames
	{
		[Address(RVA = "0x1D59130", Offset = "0x1D58530", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000017")]
		 get { } //Length: 7
		[Address(RVA = "0x1D639B0", Offset = "0x1D62DB0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000018")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000009")]
	public override int MaxCpuPerformanceLevel
	{
		[Address(RVA = "0x2F91310", Offset = "0x2F90710", Length = "0x72")]
		[Token(Token = "0x600001B")]
		 get { } //Length: 114
	}

	[Token(Token = "0x1700000A")]
	public override int MaxGpuPerformanceLevel
	{
		[Address(RVA = "0x2F91390", Offset = "0x2F90790", Length = "0x75")]
		[Token(Token = "0x600001C")]
		 get { } //Length: 117
	}

	[Token(Token = "0x1700000C")]
	public override PerformanceControlMode PerformanceControlMode
	{
		[Address(RVA = "0x2F91410", Offset = "0x2F90810", Length = "0x1B")]
		[Token(Token = "0x600001F")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000002")]
	public override PerformanceMetrics PerformanceMetrics
	{
		[Address(RVA = "0x2F91430", Offset = "0x2F90830", Length = "0x1E")]
		[Token(Token = "0x6000012")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000004")]
	public override PerformanceMode PerformanceMode
	{
		[Address(RVA = "0x2F91450", Offset = "0x2F90850", Length = "0x9")]
		[Token(Token = "0x6000014")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000015")]
	public override IPerformanceModeStatus PerformanceModeStatus
	{
		[Address(RVA = "0x2081AD0", Offset = "0x2080ED0", Length = "0x6")]
		[Token(Token = "0x600002C")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000013")]
	public override IPerformanceStatus PerformanceStatus
	{
		[Address(RVA = "0x2081AD0", Offset = "0x2080ED0", Length = "0x6")]
		[Token(Token = "0x600002A")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000017")]
	public private override IAdaptivePerformanceSettings Settings
	{
		[Address(RVA = "0x26D4F00", Offset = "0x26D4300", Length = "0xA")]
		[Token(Token = "0x600002F")]
		 get { } //Length: 10
		[Address(RVA = "0xE7CFB0", Offset = "0xE7C3B0", Length = "0x13")]
		[Token(Token = "0x6000030")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000018")]
	public override AdaptivePerformanceSubsystem Subsystem
	{
		[Address(RVA = "0x2F91460", Offset = "0x2F90860", Length = "0xA")]
		[Token(Token = "0x6000031")]
		 get { } //Length: 10
	}

	[Token(Token = "0x17000001")]
	public override ThermalMetrics ThermalMetrics
	{
		[Address(RVA = "0x2F91470", Offset = "0x2F90870", Length = "0x13")]
		[Token(Token = "0x6000011")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000012")]
	public override IThermalStatus ThermalStatus
	{
		[Address(RVA = "0x2081AD0", Offset = "0x2080ED0", Length = "0x6")]
		[Token(Token = "0x6000029")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2F90AF0", Offset = "0x2F8FEF0", Length = "0x1E3")]
	[Token(Token = "0x6000048")]
	public AdaptivePerformanceManager() { }

	[Address(RVA = "0x2F8C390", Offset = "0x2F8B790", Length = "0x24")]
	[Token(Token = "0x600003E")]
	private void AccumulateTimingValue(ref float accu, float newValue) { }

	[Address(RVA = "0x2F90CE0", Offset = "0x2F900E0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600000D")]
	public override void add_PerformanceBoostChangeEvent(PerformanceBoostChangeHandler value) { }

	[Address(RVA = "0x2F90D80", Offset = "0x2F90180", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000009")]
	public override void add_PerformanceBottleneckChangeEvent(PerformanceBottleneckChangeHandler value) { }

	[Address(RVA = "0x2F90E20", Offset = "0x2F90220", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600000B")]
	public override void add_PerformanceLevelChangeEvent(PerformanceLevelChangeHandler value) { }

	[Address(RVA = "0x2F90EC0", Offset = "0x2F902C0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600000F")]
	public override void add_PerformanceModeEvent(PerformanceModeEventHandler value) { }

	[Address(RVA = "0x2F90F60", Offset = "0x2F90360", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000007")]
	public override void add_ThermalEvent(ThermalEventHandler value) { }

	[Address(RVA = "0x2F8C3C0", Offset = "0x2F8B7C0", Length = "0xB5")]
	[Token(Token = "0x600003A")]
	private void AddNonNegativeValue(RunningAverage runningAverage, float value) { }

	[Address(RVA = "0x2F8C480", Offset = "0x2F8B880", Length = "0x18D")]
	[Token(Token = "0x6000033")]
	public void Awake() { }

	[Address(RVA = "0x2F8C610", Offset = "0x2F8BA10", Length = "0x253")]
	[Token(Token = "0x600003D")]
	private void CollectProfilerStats() { }

	[Address(RVA = "0x2F8C870", Offset = "0x2F8BC70", Length = "0x787")]
	[Token(Token = "0x6000046")]
	public override void DeinitializeAdaptivePerformance() { }

	[Address(RVA = "0x2F8D000", Offset = "0x2F8C400", Length = "0x48")]
	[Token(Token = "0x6000041")]
	public static float EffectiveTargetFrameRate() { }

	[Address(RVA = "0x2F91000", Offset = "0x2F90400", Length = "0x137")]
	[Token(Token = "0x600001A")]
	public override bool get_Active() { }

	[Address(RVA = "0x2F91140", Offset = "0x2F90540", Length = "0xA")]
	[Token(Token = "0x600001D")]
	public override bool get_AutomaticPerformanceControl() { }

	[Address(RVA = "0x2F91150", Offset = "0x2F90550", Length = "0x6")]
	[Token(Token = "0x6000020")]
	public override int get_CpuLevel() { }

	[Address(RVA = "0x2F91160", Offset = "0x2F90560", Length = "0x7")]
	[Token(Token = "0x6000024")]
	public override bool get_CpuPerformanceBoost() { }

	[Address(RVA = "0x2081AD0", Offset = "0x2080ED0", Length = "0x6")]
	[Token(Token = "0x6000028")]
	public override IDevelopmentSettings get_DevelopmentSettings() { }

	[Address(RVA = "0x2081AD0", Offset = "0x2080ED0", Length = "0x6")]
	[Token(Token = "0x600002B")]
	public override IDevicePerformanceControl get_DevicePerformanceControl() { }

	[Address(RVA = "0x2F91170", Offset = "0x2F90570", Length = "0x1B")]
	[Token(Token = "0x6000013")]
	public override FrameTiming get_FrameTiming() { }

	[Address(RVA = "0x1073720", Offset = "0x1072B20", Length = "0x6")]
	[Token(Token = "0x6000022")]
	public override int get_GpuLevel() { }

	[Address(RVA = "0x2F91190", Offset = "0x2F90590", Length = "0x7")]
	[Token(Token = "0x6000026")]
	public override bool get_GpuPerformanceBoost() { }

	[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600002D")]
	public override AdaptivePerformanceIndexer get_Indexer() { }

	[Address(RVA = "0x2F911A0", Offset = "0x2F905A0", Length = "0x121")]
	[Token(Token = "0x6000019")]
	public override bool get_Initialized() { }

	[Address(RVA = "0x2F912D0", Offset = "0x2F906D0", Length = "0x36")]
	[Token(Token = "0x6000015")]
	public override bool get_Logging() { }

	[Address(RVA = "0x1D59130", Offset = "0x1D58530", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000017")]
	public override int get_LoggingFrequencyInFrames() { }

	[Address(RVA = "0x2F91310", Offset = "0x2F90710", Length = "0x72")]
	[Token(Token = "0x600001B")]
	public override int get_MaxCpuPerformanceLevel() { }

	[Address(RVA = "0x2F91390", Offset = "0x2F90790", Length = "0x75")]
	[Token(Token = "0x600001C")]
	public override int get_MaxGpuPerformanceLevel() { }

	[Address(RVA = "0x2F91410", Offset = "0x2F90810", Length = "0x1B")]
	[Token(Token = "0x600001F")]
	public override PerformanceControlMode get_PerformanceControlMode() { }

	[Address(RVA = "0x2F91430", Offset = "0x2F90830", Length = "0x1E")]
	[Token(Token = "0x6000012")]
	public override PerformanceMetrics get_PerformanceMetrics() { }

	[Address(RVA = "0x2F91450", Offset = "0x2F90850", Length = "0x9")]
	[Token(Token = "0x6000014")]
	public override PerformanceMode get_PerformanceMode() { }

	[Address(RVA = "0x2081AD0", Offset = "0x2080ED0", Length = "0x6")]
	[Token(Token = "0x600002C")]
	public override IPerformanceModeStatus get_PerformanceModeStatus() { }

	[Address(RVA = "0x2081AD0", Offset = "0x2080ED0", Length = "0x6")]
	[Token(Token = "0x600002A")]
	public override IPerformanceStatus get_PerformanceStatus() { }

	[Address(RVA = "0x26D4F00", Offset = "0x26D4300", Length = "0xA")]
	[Token(Token = "0x600002F")]
	public override IAdaptivePerformanceSettings get_Settings() { }

	[Address(RVA = "0x2F91460", Offset = "0x2F90860", Length = "0xA")]
	[Token(Token = "0x6000031")]
	public override AdaptivePerformanceSubsystem get_Subsystem() { }

	[Address(RVA = "0x2F91470", Offset = "0x2F90870", Length = "0x13")]
	[Token(Token = "0x6000011")]
	public override ThermalMetrics get_ThermalMetrics() { }

	[Address(RVA = "0x2081AD0", Offset = "0x2080ED0", Length = "0x6")]
	[Token(Token = "0x6000029")]
	public override IThermalStatus get_ThermalStatus() { }

	[Address(RVA = "0x2F8D050", Offset = "0x2F8C450", Length = "0x1113")]
	[Token(Token = "0x6000043")]
	public override void InitializeAdaptivePerformance() { }

	[Address(RVA = "0x2F8E170", Offset = "0x2F8D570", Length = "0x91")]
	[Token(Token = "0x600003B")]
	public void LateUpdate() { }

	[Address(RVA = "0x2F8E210", Offset = "0x2F8D610", Length = "0x13A")]
	[Token(Token = "0x6000036")]
	private void LogBoostEvent(PerformanceBoostChangeEventArgs ev) { }

	[Address(RVA = "0x2F8E350", Offset = "0x2F8D750", Length = "0xD8")]
	[Token(Token = "0x6000035")]
	private void LogBottleneckEvent(PerformanceBottleneckChangeEventArgs ev) { }

	[Address(RVA = "0x2F8E430", Offset = "0x2F8D830", Length = "0x31A")]
	[Token(Token = "0x6000039")]
	private void LogPerformanceLevelEvent(PerformanceLevelChangeEventArgs ev) { }

	[Address(RVA = "0x2F8E750", Offset = "0x2F8DB50", Length = "0xD8")]
	[Token(Token = "0x6000037")]
	private void LogPerformanceModeEvent(PerformanceMode performanceMode) { }

	[Address(RVA = "0x2F8E830", Offset = "0x2F8DC30", Length = "0x1B5")]
	[Token(Token = "0x6000034")]
	private void LogThermalEvent(ThermalMetrics ev) { }

	[Address(RVA = "0x2F8E9F0", Offset = "0x2F8DDF0", Length = "0x144")]
	[Token(Token = "0x6000047")]
	public void OnApplicationPause(bool pause) { }

	[Address(RVA = "0x2F8EB40", Offset = "0x2F8DF40", Length = "0x7")]
	[Token(Token = "0x6000042")]
	public void OnDestroy() { }

	[Address(RVA = "0x2F91490", Offset = "0x2F90890", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600000E")]
	public override void remove_PerformanceBoostChangeEvent(PerformanceBoostChangeHandler value) { }

	[Address(RVA = "0x2F91530", Offset = "0x2F90930", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600000A")]
	public override void remove_PerformanceBottleneckChangeEvent(PerformanceBottleneckChangeHandler value) { }

	[Address(RVA = "0x2F915D0", Offset = "0x2F909D0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600000C")]
	public override void remove_PerformanceLevelChangeEvent(PerformanceLevelChangeHandler value) { }

	[Address(RVA = "0x2F91670", Offset = "0x2F90A70", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000010")]
	public override void remove_PerformanceModeEvent(PerformanceModeEventHandler value) { }

	[Address(RVA = "0x2F91710", Offset = "0x2F90B10", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000008")]
	public override void remove_ThermalEvent(ThermalEventHandler value) { }

	[Address(RVA = "0x2F917B0", Offset = "0x2F90BB0", Length = "0xE")]
	[Token(Token = "0x600001E")]
	public override void set_AutomaticPerformanceControl(bool value) { }

	[Address(RVA = "0x2F917C0", Offset = "0x2F90BC0", Length = "0x8")]
	[Token(Token = "0x6000021")]
	public override void set_CpuLevel(int value) { }

	[Address(RVA = "0x2F917D0", Offset = "0x2F90BD0", Length = "0x8")]
	[Token(Token = "0x6000025")]
	public override void set_CpuPerformanceBoost(bool value) { }

	[Address(RVA = "0x2F917E0", Offset = "0x2F90BE0", Length = "0x8")]
	[Token(Token = "0x6000023")]
	public override void set_GpuLevel(int value) { }

	[Address(RVA = "0x2F917F0", Offset = "0x2F90BF0", Length = "0x8")]
	[Token(Token = "0x6000027")]
	public override void set_GpuPerformanceBoost(bool value) { }

	[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600002E")]
	private void set_Indexer(AdaptivePerformanceIndexer value) { }

	[Address(RVA = "0x2F91800", Offset = "0x2F90C00", Length = "0x3B")]
	[Token(Token = "0x6000016")]
	public override void set_Logging(bool value) { }

	[Address(RVA = "0x1D639B0", Offset = "0x1D62DB0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000018")]
	public override void set_LoggingFrequencyInFrames(int value) { }

	[Address(RVA = "0xE7CFB0", Offset = "0xE7C3B0", Length = "0x13")]
	[Token(Token = "0x6000030")]
	private void set_Settings(IAdaptivePerformanceSettings value) { }

	[Address(RVA = "0x2F8EB50", Offset = "0x2F8DF50", Length = "0xA7")]
	[Token(Token = "0x6000044")]
	public override void StartAdaptivePerformance() { }

	[Address(RVA = "0x2F8EC00", Offset = "0x2F8E000", Length = "0xA7")]
	[Token(Token = "0x6000045")]
	public override void StopAdaptivePerformance() { }

	[Address(RVA = "0x2F8ECB0", Offset = "0x2F8E0B0", Length = "0x44")]
	[Token(Token = "0x6000032")]
	public override bool SupportedFeature(Feature feature) { }

	[Address(RVA = "0x2F8ED00", Offset = "0x2F8E100", Length = "0x3D")]
	[Token(Token = "0x6000038")]
	private static string ToStringWithSign(int x) { }

	[Address(RVA = "0x2F8FAF0", Offset = "0x2F8EEF0", Length = "0xFB1")]
	[Token(Token = "0x600003C")]
	public void Update() { }

	[Address(RVA = "0x2F8ED40", Offset = "0x2F8E140", Length = "0xDA9")]
	[Token(Token = "0x600003F")]
	private void UpdateSubsystem() { }

	[Address(RVA = "0x2F90AB0", Offset = "0x2F8FEB0", Length = "0x40")]
	[Token(Token = "0x6000040")]
	private static bool WillCurrentFrameRender() { }

}

