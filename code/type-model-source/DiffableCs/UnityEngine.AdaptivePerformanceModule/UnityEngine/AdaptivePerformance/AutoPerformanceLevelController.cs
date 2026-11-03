namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000009")]
internal class AutoPerformanceLevelController
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002A")]
	private IDevicePerformanceControl m_PerfControl; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400002B")]
	private IPerformanceStatus m_PerfStats; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400002C")]
	private IThermalStatus m_ThermalStats; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400002D")]
	private float m_LastChangeTimeStamp; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400002E")]
	private float m_LastGpuLevelRaiseTimeStamp; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400002F")]
	private float m_LastCpuLevelRaiseTimeStamp; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000030")]
	private float m_TargetFrameRateHitTimestamp; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000031")]
	private float m_BottleneckUnknownTimestamp; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000032")]
	private bool m_TriedToResolveUnknownBottleneck; //Field offset: 0x3C
	[FieldOffset(Offset = "0x3D")]
	[Token(Token = "0x4000033")]
	private bool m_Enabled; //Field offset: 0x3D
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000034")]
	private string m_FeatureName; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000035")]
	private float <TargetFrameTime>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000036")]
	private float <AllowedCpuActiveTimeRatio>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000037")]
	private float <AllowedGpuActiveTimeRatio>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000038")]
	private float <GpuLevelBounceAvoidanceThreshold>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000039")]
	private float <CpuLevelBounceAvoidanceThreshold>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400003A")]
	private float <UpdateInterval>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400003B")]
	private float <MinTargetFrameRateHitTime>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400003C")]
	private float <MaxTemperatureLevel>k__BackingField; //Field offset: 0x64

	[Token(Token = "0x1700001B")]
	public float AllowedCpuActiveTimeRatio
	{
		[Address(RVA = "0x21F3FC0", Offset = "0x21F33C0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000052")]
		 get { } //Length: 6
		[Address(RVA = "0x26DEB10", Offset = "0x26DDF10", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000053")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700001C")]
	public float AllowedGpuActiveTimeRatio
	{
		[Address(RVA = "0x5B3800", Offset = "0x5B2C00", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000054")]
		 get { } //Length: 6
		[Address(RVA = "0x26DEAE0", Offset = "0x26DDEE0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000055")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700001E")]
	public float CpuLevelBounceAvoidanceThreshold
	{
		[Address(RVA = "0x21F00E0", Offset = "0x21EF4E0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000058")]
		 get { } //Length: 6
		[Address(RVA = "0x29E0B50", Offset = "0x29DFF50", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000059")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000022")]
	public bool Enabled
	{
		[Address(RVA = "0x2F96D70", Offset = "0x2F96170", Length = "0x7")]
		[Token(Token = "0x6000061")]
		 get { } //Length: 7
		[Address(RVA = "0x2F96D80", Offset = "0x2F96180", Length = "0x9")]
		[Token(Token = "0x6000062")]
		 set { } //Length: 9
	}

	[Token(Token = "0x1700001D")]
	public float GpuLevelBounceAvoidanceThreshold
	{
		[Address(RVA = "0x5B3830", Offset = "0x5B2C30", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000056")]
		 get { } //Length: 6
		[Address(RVA = "0x1D1D150", Offset = "0x1D1C550", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000057")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000021")]
	public float MaxTemperatureLevel
	{
		[Address(RVA = "0x121E450", Offset = "0x121D850", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600005E")]
		 get { } //Length: 6
		[Address(RVA = "0x121E6F0", Offset = "0x121DAF0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600005F")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000020")]
	public float MinTargetFrameRateHitTime
	{
		[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600005C")]
		 get { } //Length: 6
		[Address(RVA = "0x1CC5D40", Offset = "0x1CC5140", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600005D")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700001A")]
	public float TargetFrameTime
	{
		[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000050")]
		 get { } //Length: 6
		[Address(RVA = "0x1DD4B70", Offset = "0x1DD3F70", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000051")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700001F")]
	public float UpdateInterval
	{
		[Address(RVA = "0x2820D50", Offset = "0x2820150", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600005A")]
		 get { } //Length: 6
		[Address(RVA = "0x2820D60", Offset = "0x2820160", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600005B")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x2F96B50", Offset = "0x2F95F50", Length = "0x210")]
	[Token(Token = "0x6000060")]
	public AutoPerformanceLevelController(IDevicePerformanceControl perfControl, IPerformanceStatus perfStat, IThermalStatus thermalStat) { }

	[Address(RVA = "0x2F961D0", Offset = "0x2F955D0", Length = "0x44")]
	[CompilerGenerated]
	[Token(Token = "0x6000070")]
	private void <.ctor>b__43_0(PerformanceBottleneckChangeEventArgs ev) { }

	[Address(RVA = "0x2F95A30", Offset = "0x2F94E30", Length = "0xEB")]
	[Token(Token = "0x600006B")]
	private bool AllowLowerCpuLevel(float timestamp) { }

	[Address(RVA = "0x2F95B20", Offset = "0x2F94F20", Length = "0xEB")]
	[Token(Token = "0x600006C")]
	private bool AllowLowerGpuLevel(float timestamp) { }

	[Address(RVA = "0x2F95C10", Offset = "0x2F95010", Length = "0x87")]
	[Token(Token = "0x600006E")]
	private bool AllowRaiseCpuLevel() { }

	[Address(RVA = "0x2F95CA0", Offset = "0x2F950A0", Length = "0x8A")]
	[Token(Token = "0x600006F")]
	private bool AllowRaiseGpuLevel() { }

	[Address(RVA = "0x2F95D30", Offset = "0x2F95130", Length = "0x215")]
	[Token(Token = "0x600006D")]
	private bool AllowRaiseLevels() { }

	[Address(RVA = "0x21F3FC0", Offset = "0x21F33C0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000052")]
	public float get_AllowedCpuActiveTimeRatio() { }

	[Address(RVA = "0x5B3800", Offset = "0x5B2C00", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000054")]
	public float get_AllowedGpuActiveTimeRatio() { }

	[Address(RVA = "0x21F00E0", Offset = "0x21EF4E0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000058")]
	public float get_CpuLevelBounceAvoidanceThreshold() { }

	[Address(RVA = "0x2F96D70", Offset = "0x2F96170", Length = "0x7")]
	[Token(Token = "0x6000061")]
	public bool get_Enabled() { }

	[Address(RVA = "0x5B3830", Offset = "0x5B2C30", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000056")]
	public float get_GpuLevelBounceAvoidanceThreshold() { }

	[Address(RVA = "0x121E450", Offset = "0x121D850", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600005E")]
	public float get_MaxTemperatureLevel() { }

	[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600005C")]
	public float get_MinTargetFrameRateHitTime() { }

	[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000050")]
	public float get_TargetFrameTime() { }

	[Address(RVA = "0x2820D50", Offset = "0x2820150", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600005A")]
	public float get_UpdateInterval() { }

	[Address(RVA = "0x2F95F50", Offset = "0x2F95350", Length = "0x13E")]
	[Token(Token = "0x6000069")]
	private void LowerCpuLevel(float timestamp) { }

	[Address(RVA = "0x2F96090", Offset = "0x2F95490", Length = "0x13E")]
	[Token(Token = "0x600006A")]
	private void LowerGpuLevel(float timestamp) { }

	[Address(RVA = "0x2F961D0", Offset = "0x2F955D0", Length = "0x44")]
	[Token(Token = "0x6000066")]
	private void OnBottleneckChange(PerformanceBottleneckChangeEventArgs ev) { }

	[Address(RVA = "0x2F96220", Offset = "0x2F95620", Length = "0xD9")]
	[Token(Token = "0x6000064")]
	public void Override(int requestedCpuLevel, int requestedGpuLevel) { }

	[Address(RVA = "0x2F96300", Offset = "0x2F95700", Length = "0x143")]
	[Token(Token = "0x6000068")]
	private void RaiseCpuLevel(float timestamp) { }

	[Address(RVA = "0x2F96450", Offset = "0x2F95850", Length = "0x143")]
	[Token(Token = "0x6000067")]
	private void RaiseGpuLevel(float timestamp) { }

	[Address(RVA = "0x26DEB10", Offset = "0x26DDF10", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000053")]
	public void set_AllowedCpuActiveTimeRatio(float value) { }

	[Address(RVA = "0x26DEAE0", Offset = "0x26DDEE0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000055")]
	public void set_AllowedGpuActiveTimeRatio(float value) { }

	[Address(RVA = "0x29E0B50", Offset = "0x29DFF50", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000059")]
	public void set_CpuLevelBounceAvoidanceThreshold(float value) { }

	[Address(RVA = "0x2F96D80", Offset = "0x2F96180", Length = "0x9")]
	[Token(Token = "0x6000062")]
	public void set_Enabled(bool value) { }

	[Address(RVA = "0x1D1D150", Offset = "0x1D1C550", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000057")]
	public void set_GpuLevelBounceAvoidanceThreshold(float value) { }

	[Address(RVA = "0x121E6F0", Offset = "0x121DAF0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600005F")]
	public void set_MaxTemperatureLevel(float value) { }

	[Address(RVA = "0x1CC5D40", Offset = "0x1CC5140", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600005D")]
	public void set_MinTargetFrameRateHitTime(float value) { }

	[Address(RVA = "0x1DD4B70", Offset = "0x1DD3F70", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000051")]
	public void set_TargetFrameTime(float value) { }

	[Address(RVA = "0x2820D60", Offset = "0x2820160", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600005B")]
	public void set_UpdateInterval(float value) { }

	[Address(RVA = "0x2F96B20", Offset = "0x2F95F20", Length = "0x2F")]
	[Token(Token = "0x6000063")]
	public void Update() { }

	[Address(RVA = "0x2F965A0", Offset = "0x2F959A0", Length = "0x57E")]
	[Token(Token = "0x6000065")]
	private void UpdateImpl(float timestamp) { }

}

